using Microsoft.AspNetCore.Mvc;
using RCTENNIS.Models;
using System.Diagnostics;
using Correios.Net;

namespace RCTENNIS.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EmpresaCadastro()
        {
            return View();
        }    

        public IActionResult FornecedorCadastro()
        {
            return View();
        }

        public IActionResult MarcasCadastro()
        {
            return View();
        }

        public IActionResult ProdutoCadastro()
        {
            return View();
        }

        public IActionResult ClienteCadastro()
        {
            return View();
        }

        public IActionResult EncordoamentoCadastro()
        {
            return View();
        }

        public IActionResult RaqueteCadastro()
        {
            return View();
        }

        public IActionResult EstoqueCadastro()
        {
            return View();
        }

        public IActionResult VendaCadastro()
        {
            return View();
        }

        public IActionResult CordaCadastro()
        {
            return View();
        }


    }
}