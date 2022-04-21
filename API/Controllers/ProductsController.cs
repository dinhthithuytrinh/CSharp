using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public string getProducts(){
            var x = 2;
            // Console.Out.WriteLine(x);
            return "Học lạis";
        }

        [HttpGet("{id}")]
        public string getProduct(int id){
            return id.ToString();
        }
       
    }
}