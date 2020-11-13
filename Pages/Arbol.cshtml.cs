using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InyeccionDependenciaExplicado.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InyeccionDependenciaExplicado.Pages
{
    public class ArbolModel : PageModel
    {
        private IRamaA arbol;
        public string Mensaje { get; set; }
        public ArbolModel(IRamaA arbol)
        {
            //En este caso el servicio no deberia ser llamado de la siguiente forma, ya que automaticamente dejamos amarrado a la clase dependendiente y no respetamos el Principio de inversión de dependencias
            //RamaA ramaA = new RamaA(new RamaB(new RamaC(), new RamaD(new RamaC())), new RamaC());
            this.arbol = arbol;
        }

        public void OnGet()
        {
            this.Mensaje = arbol.ObtenerMensaje();
        }
    }
}
