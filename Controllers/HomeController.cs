using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHpet.Models;
using LHPet.Models;
using LHpet.Model;

namespace LHpet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
       Cliente cliente1 = new Cliente (01, "Arthur A.Ferreira Ferreira", "857.032.950 41", "arthur.antunes@sp.senai.br","Madruga");
        Cliente cliente2 = new Cliente (02, "miguel", "857.032.950 41", "arthur.antunes@sp.senai.br","Madruga");
        Cliente cliente3 = new Cliente (03, "pedro", "857.032.950 41", "arthur.antunes@sp.senai.br","Madruga");
        Cliente cliente4 = new Cliente (04, "joão", "857.032.950 41", "arthur.antunes@sp.senai.br","Madruga");

        Fornecedor fornecedor1 = new Fornecedor (01, "loja 01", "857.032.950 41", "arthur.antunes@sp.senai.br");
          Fornecedor fornecedor2 = new Fornecedor (02, "loja 01", "857.032.950 41", "arthur.antunes@sp.senai.br");
          Fornecedor fornecedor3 = new Fornecedor (03, "loja 01", "857.032.950 41", "arthur.antunes@sp.senai.br");
          Fornecedor fornecedor4 = new Fornecedor (04, "loja 01", "857.032.950 41", "arthur.antunes@sp.senai.br");

        List<Cliente> listaClientes = new List <Cliente>();
            listaClientes.Add (cliente1);
            listaClientes.Add (cliente2);
            listaClientes.Add (cliente3);
            listaClientes.Add (cliente4);

        List <Fornecedor > listaFornecedores = new List <Fornecedor>();
            listaFornecedores.Add(fornecedor1);
            listaFornecedores.Add(fornecedor2);
            listaFornecedores.Add(fornecedor3);
            listaFornecedores.Add(fornecedor4);

        ViewBag.listaclientes = listaClientes;
        ViewBag.listaFornecedores = listaFornecedores;
        

                return View();


    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
