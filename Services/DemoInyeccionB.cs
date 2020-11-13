using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InyeccionDependenciaExplicado.Services
{
    public class DemoInyeccionB : IDemoInyeccion
    {
        public string MostrarMensaje()
        {
            return "Mensaje desde La Clase Demo Inyeccion B";
        }
    }
}
