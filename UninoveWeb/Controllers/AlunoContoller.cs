using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UninoveWeb.Models;

namespace UninoveWeb.Controllers;

public class AlunoController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Nome="Mirelle";
        ViewBag.Curso="Tads";
        ViewBag.Semestre="Primeiro Semestre";

        return View();
    }

    public IActionResult detalhes(int id)
    {
        ViewBag.Aluno=id;
        return View();
    }
    }
