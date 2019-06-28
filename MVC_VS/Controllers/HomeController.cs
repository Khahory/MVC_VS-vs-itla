using MVC_VS.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_VS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            
            return View();
        }

        public ActionResult About()
        {
            Materias persona = new Materias();
            persona.Nombre = "Angel";

            //cantidad de materia ejemplo
            
            int cantMaterias = 7;
            int catTareas = 18;
            for (int i = 0; i < cantMaterias; i++)
            {
                persona.candidadesMateriaArray.Add("");
                for (int j = 0; j < catTareas; j++)
                {
                    persona.candidadesTareasArray.Add("");
                }
            }



            return View(persona);
        }

        public ActionResult Capturar()
        {
            Materias materias = new Materias();
            ArrayList objeto = new ArrayList();
            objeto.Add(materias);

           // materias.Cantidad = 5;
           // materias.CantidadTarea = 2;

            for (int i = 0; i < 1; i++)
            {
                materias.nombres.Add(Request.Form["nombre"].ToString());
                materias.tareas.Add(Request.Form["tareas"].ToString());
                objeto.Add(materias);
                // //registrar tareas
                // for (int j = 0; j < materias.CantidadTarea; j++)
                // {
                //     materias.tareas.Add(Request.Form["tareas"].ToString());
                // }
            }

            //mostra materias y tareas
            foreach (var item in materias.nombres)
            {
                materias.Nombre = item.ToString();
                foreach (var itemDos in materias.tareas)
                {
                    foreach (var itemTres in objeto)
                    {   
                        return Content("La materia es: " + materias.Nombre + " --- Las tareas son: " + itemDos + " --- Los objetos son: " + objeto.Count);
                    }
                   
                }
            }

            return Content("null");
           // return RedirectToAction("About");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}