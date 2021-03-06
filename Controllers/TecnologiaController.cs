using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Desafio_MVC.Models;
using Desafio_MVC.Data;
using Desafio_MVC.DTO;
using Microsoft.AspNetCore.Authorization;

namespace Desafio_MVC.Controllers
{
    public class TecnologiaController : Controller
    {
        private readonly ApplicationDbContext database;

        public TecnologiaController(ApplicationDbContext database){
            this.database = database;
        }
        [Authorize(Policy = "TemCargo")]
        [HttpPost]
        public IActionResult Salvar (TecnologiaDTO TecnologiaTemporaria){
            if(ModelState.IsValid){
                Tecnologia tecnologia = new Tecnologia();
                tecnologia.NomeTec = TecnologiaTemporaria.NomeTec;
                tecnologia.TipoTec = TecnologiaTemporaria.TipoTec;
                tecnologia.Ativa = true;
                database.Tecnologias.Add(tecnologia);
                database.SaveChanges();
                return RedirectToAction ("Tecnologias", "Wa");

            }
            return View("../Wa/CadastrarTecnologia");}

        [Authorize(Policy = "TemCargo")]
         public IActionResult Atualizar(TecnologiaDTO tecnologiaTemporaria){
            if(ModelState.IsValid){
                var tecnologia = database.Tecnologias.First(tec => tec.Id == tecnologiaTemporaria.Id);
                tecnologia.NomeTec = tecnologiaTemporaria.NomeTec;
                tecnologia.TipoTec = tecnologiaTemporaria.TipoTec;
                tecnologia.Ativa = true;
                
                database.SaveChanges();
                return RedirectToAction ("Tecnologias", "Wa");
            }else { return RedirectToAction ("Tecnologias", "Wa");}}

        [Authorize(Policy = "TemCargo")]        
        public IActionResult Deletar (int id){
            ViewBag.Tecnologias = database.Tecnologias.ToList();
            var tecnologias = database.Tecnologias.First(tec => tec.Id == id);                   
            
                tecnologias.Ativa = false;
                database.SaveChanges();
                        
            return RedirectToAction("Tecnologias", "Wa");}

              public IActionResult TesteBD (){
           
            ViewBag.Tecnologia = database.Tecnologias.ToList();
            ViewBag.Gft = database.Gfts.ToList();
            ViewBag.Funcionario = database.Funcionarios.ToList();

                                 
           
        
            return Content ("tudo certo");
        }
    }
        
}
