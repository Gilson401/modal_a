using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using modalmais_a.Data;
using modalmais_a.Models;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Linq;

namespace modal_a.Controllers
{
    [ApiController]
    [Route("v1/categories")]

    public class CategoryController : ControllerBase
    {

        // [HttpGet("{email:string}")]
        [HttpGet("email/{param1:alpha}")]
        [Route("")]

        public async Task<ActionResult<ExpandoObject>> Get([FromServices] DataContext context, string email)
        {
            Console.WriteLine("email: {0}", email.ToString());

            var categories = await context.Categories
            .AsNoTracking()
            .Where(x => x.Email == email)
            .Distinct()
            .OrderBy(x => x.Id)
            .ToListAsync();

            dynamic ObjectToReturn = new ExpandoObject();
            ObjectToReturn.email = email.ToString();
            ObjectToReturn.listaDeCartoes = new List<string>();

            categories.ForEach(num => ObjectToReturn.listaDeCartoes.Add(num.Cartao));

            return ObjectToReturn;
        }


        [HttpPost]
        [Route("")]

        public async Task<ActionResult<Category>> Post(
        [FromServices] DataContext context,
        [FromBody] Category model)
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
                context.Categories.Add(model);
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