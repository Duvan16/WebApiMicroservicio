﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiMicroservicio.Controllers
{
    //Restfull no va  a trabajar con vistas
    [ApiController]
    [Route("products")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Product>> GetAll()
        {
            return Products;
        }

        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            return Products.Single(x => x.Id == id);
        }

        private static List<Product> Products = new List<Product>
         {
             new Product
             {
                 Id = 1,
                 Name = "Guitarra elétrica",
                 Price = 1200,
                 Description = "Ideal para tocar jazz, blues, rock clásico y afines."
             },
             new Product
             {
                 Id=2,
                 Name = "Amplificador para guitarra eléctrica",
                 Price = 1200,
                 Description = "Excelente amplificador con un sonido cálido."
             },
         };
    }
}
