using MvcBasic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBasic.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            var cliente = new Cliente()
            {
                Nome = "Asp",
                SobreNome = "NET",
                DataCadastro = DateTime.Now
            };
            return View(cliente);
        }
    }
}