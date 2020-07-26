using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/

        public string Index()
        {
            return "Este é minha ação default...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome(string name , int id=1)
        {
            //  return "Este é o metodo de Ação Welcome...";
            return HtmlEncoder.Default.Encode($"Hello {name}, ID is: {id}");
        }
    }
}
