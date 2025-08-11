using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SafeStudy.Models;

namespace SafeStudy.Controllers;

public class EstudoController : Controller
{
    private readonly ILogger<EstudoController> _logger;

    public EstudoController(ILogger<EstudoController> logger)
    {
        _logger = logger;
    }


    public IActionResult Pomodoro()
    {
        return View();
    }


    public IActionResult Dashboard()
    {
        return View();
    }
    public IActionResult Relatorio()
    {
        return View();
    }

    //     [HttpPost]
    //     public IActionResult RegistrarSessao()
    //     {
    //         // Aqui você pode salvar no banco de dados usando Entity Framework
    //         // Exemplo básico:
    //         // var sessao = new SessaoEstudo { Inicio = DateTime.Now, UsuarioId = 1 };
    //         // _context.SessoesEstudo.Add(sessao);
    //         // _context.SaveChanges();

    //         return Ok(new { message = "Sessão registrada com sucesso!" });
    //     }
    // }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
