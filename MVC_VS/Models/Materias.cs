using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_VS.Models
{
    public class Materias
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public int CantidadTarea { get; set; }

        public ArrayList nombres = new ArrayList();
        public ArrayList candidadesMateriaArray = new ArrayList();
        public ArrayList candidadesTareasArray = new ArrayList();
        public ArrayList tareas = new ArrayList();

        


    }
}