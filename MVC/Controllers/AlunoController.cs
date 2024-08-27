using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            Aluno a1 = new Aluno(1, "Ana Clara de Souza",
                "ana.c.souza94@aluno.senai.br", 4143);

            Aluno a2 = new Aluno(2, "Maya Ricci",
                "maya.ricci@gmail.com", 0308);

            Aluno a3 = new Aluno(2, "Trunks Ricci",
               "trunks.ricci@gmail.com", 2409);

            Aluno a4 = new Aluno(2, "Gabriela Siqueira Caputti",
               "gabriela.caputti@aluno.senai.br", 4449);

            Aluno a5 = new Aluno(2, "Livia Modesto Ormeleze",
               "livia.ormeleze@aluno.senai.br", 4820);

            List<Aluno> listaAlunos = new List<Aluno>();

            listaAlunos.Add(a1);
            listaAlunos.Add(a2);
            listaAlunos.Add(a3);
            listaAlunos.Add(a4);
            listaAlunos.Add(a5);

            return View();
        }
        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
