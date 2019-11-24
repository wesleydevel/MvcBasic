using MvcBasic.Context;
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
        public ActionResult Teste()
        {
            var cliente = new MvcBasicContext().Clientes.SingleOrDefault(c => c.Id == 1);

            //ViewBag.Cliente = cliente;

            ViewBag.Cliente = "Texto";

            //ViewData["Cliente"] = cliente;

            return View("Index", cliente);
        }

        public ActionResult Lista()
        {
            var listaClientes = new List<Cliente>()
            {
                new Cliente()
                {
                    Id = 1,
                    Nome = "Wesley",
                    SobreNome = "Santos",
                    DataCadastro = DateTime.Now
                },
                new Cliente()
                {
                    Id = 2 ,
                    Nome = "Rogéria",
                    SobreNome = "Santos",
                    DataCadastro = DateTime.Now
                }
            };
            return View(listaClientes);
        }

        public ActionResult Pesquisa(int id, string nome)
        {

            var listaCliente = new List<Cliente>()
            {
                new Cliente()
                {
                    Id = 1 ,
                    Nome = "Wesley",
                    SobreNome = "Santos",
                    DataCadastro = DateTime.Now
                },
                new Cliente()
                {
                    Id = 2,
                    Nome = "Rogéria",
                    SobreNome = "Santos",
                    DataCadastro = DateTime.Now
                },
                new Cliente()
                {
                    Id = 3,
                    Nome = "Gonçala",
                    SobreNome = "Pereira",
                    DataCadastro = DateTime.Now
                },
                new Cliente()
                {
                    Id = 4 ,
                    Nome = "Sebastião",
                    SobreNome = "Rosario",
                    DataCadastro = DateTime.Now
                }
            };
          
            var cliente = listaCliente.Where(c => c.Nome == nome).ToList();

            if (!cliente.Any())
            {
                TempData["erro"] = "Nenhum cliente selecionado";
                return RedirectToAction("ErroPesquisa");
            }
            return View("Lista", cliente);
        }

        public ActionResult ErroPesquisa()
        {
            return View("Error");
        }
    }
}