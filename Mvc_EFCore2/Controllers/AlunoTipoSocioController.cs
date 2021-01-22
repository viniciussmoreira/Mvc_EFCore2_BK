using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mvc_EFCore2.Models;

namespace Mvc_EFCore2.Controllers
{
    public class AlunoTipoSocioController : Controller
    {
        private AlunoContext contexto;

        public AlunoTipoSocioController(AlunoContext _alunoContext)
        {
            contexto = _alunoContext;
        }
        public IActionResult Index()
        {
            //var infoAluno = contexto.Alunos.ToList(); //assim não carrega Tipo Socio
            var infoAluno = contexto.Alunos.Include(tp => tp.TipoSocio);  //assim não carrega Tipo Socio

            return View(infoAluno);
        }
    }
}
