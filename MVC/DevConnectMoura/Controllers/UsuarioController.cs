using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DevConnectMoura.Contexts;
using DevConnectMoura.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// CADASTRO DE USUÁRIO
namespace DevConnectMoura.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly DevConnectContext _context;
        private readonly ILogger<UsuarioController> _logger;
        // private DevConnectContexts? context;

        public UsuarioController(ILogger<UsuarioController> logger, DevConnectContext context)
        {
            _logger = logger;
            _context = context;
        }


        // Cadastro de Usuario
        [HttpGet]
        public IActionResult Index()
        {
             ViewBag.UsuarioNovoCadastro = "";
            TempData["UsuarioNovoCadastrado"] = "";
            return View();
        }
        [HttpPost]
         public async Task<IActionResult> Index(IFormCollection form)
        {
            TbUsuario novoUsuario = new TbUsuario()
            {
              NomeCompleto = form["NomeCompleto"].ToString(),
              NomeUsuario = form["NomeUsuario"].ToString(),
              Email = form["Email"].ToString(),
              Senha = form["Senha"].ToString()
            };

            if (form.Files.Count > 0)
            {
                IFormFile file = form.Files[0];
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images");

                if (Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                string path = Path.Combine(folder, file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                novoUsuario.FotoPerflUrl = file.FileName;
            }
            else
            {
                novoUsuario.FotoPerflUrl = "";
            }

            try
            {
                _context.TbUsuario.Add(novoUsuario);

                await _context.SaveChangesAsync();

                TempData["UsuarioNovoCadastrado"] = "Cadastrado";
                ViewBag.UsuarioNovoCadastrado = "";

                return RedirectToAction("Index", "Home");
            }
            catch (System.Exception)
            {
                ViewBag.UsuarioNovoCadastrado = "Nao cadastrado";
                TempData["UsuarioNovoCadastrado"] = "";
                 return View();
            }

        }

        // Perfil de Usuario
        public IActionResult Perfil()
        {
        
            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}