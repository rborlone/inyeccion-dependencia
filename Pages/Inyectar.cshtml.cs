using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InyeccionDependenciaExplicado.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InyeccionDependenciaExplicado.Pages
{
    public class InyectarModel : PageModel
    {
        public string Mensaje { get; set; }

        private IDemoInyeccion demoInyeccion;
        public InyectarModel(IDemoInyeccion demoInyeccion)
        {
            this.demoInyeccion = demoInyeccion;
        }

        public void OnGet()
        {
            this.Mensaje = demoInyeccion.MostrarMensaje();
        }
    }
}
