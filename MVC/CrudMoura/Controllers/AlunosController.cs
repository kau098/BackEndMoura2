
using CrudMoura.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrudMoura.Controllers
{
    // [Route("[controller]")]
    public class AlunosController : Controller
    {
        private readonly ILogger<AlunosController> _logger;

        public AlunosController(ILogger<AlunosController> logger)
        {
            _logger = logger;
        }

        public static List<Aluno> listaDeAlunos = new List<Aluno>
        {
        new Aluno{ Id = 1, Nome = "João", Idade = 16, Cpf = 12345},  
        new Aluno{ Id = 2, Nome = "Eduardo", Idade = 15, Cpf = 5555}, 
        new Aluno{ Id = 3, Nome = "Jonas", Idade = 26, Cpf = 99876}, 
        };

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListarAlunos()
        {
            ViewBag.alunos = listaDeAlunos;
            return View();
        }


        [HttpGet]
        public IActionResult Create()
        {//mostra a tela/formulário de cadastro
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(Aluno aluno)
        {//salvar os dados e redirecionar para o ListarAluno
            //não precisa criar uma view pra esta ação,
            //porque ela vai redirecionar para outra ação

            aluno.Id = listaDeAlunos.Max( a => a.Id ) + 1;
            listaDeAlunos.Add(aluno);
            
            return RedirectToAction(nameof (ListarAlunos));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}