using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using modalmais_a.Data;
using modalmais_a.Models;
using System.Linq;

namespace modal_a.Controllers
{
    [ApiController]
    [Route("v1/clientes")]

    public class ClientesController : ControllerBase
    {

        [HttpGet("{email}")]
        [Route("")]

        public async Task<ActionResult<ExpandoObject>> Get([FromServices] DataContext context, string email)
        {
            var listDataBd = await context.Clientes
            .AsNoTracking()
            .Where(x => x.Email == email)
            .Distinct()
            .OrderBy(x => x.Id)
            .ToListAsync();

            dynamic ObjectToReturn = new ExpandoObject();
            ObjectToReturn.email = email.ToString();
            ObjectToReturn.listaDeCartoes = new List<string>();

            listDataBd.ForEach(num => ObjectToReturn.listaDeCartoes.Add(num.Cartao));

            return ObjectToReturn;
        }


        [HttpPost]
        [Route("")]

        public async Task<ActionResult<Clientes>> Post(
        [FromServices] DataContext context,
        [FromBody] Clientes model)
        {
            if (ModelState.IsValid)
            {
                Random rnd = new Random();

                string randomBetween10And20 = "";
                for (int a = 0; a < 16; a = a + 1)
                {
                    randomBetween10And20 += rnd.Next(0, 9).ToString();
                }

                model.Cartao = randomBetween10And20;
                context.Clientes.Add(model);
                await context.SaveChangesAsync();
                return model;
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
    }


}