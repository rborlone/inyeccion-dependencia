using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InyeccionDependenciaExplicado.Services
{
    public interface IRamaA
    {
        string ObtenerMensaje();
    }
    public interface IRamaB { }
    public interface IRamaC { }
    public interface IRamaD { }

    public class RamaA : IRamaA
    {
        public RamaA(IRamaB ramaB, IRamaC ramaC)
        {
        }

        public string ObtenerMensaje()
        {
            return "Mensaje desde el servicio de Arbol de Dependencias";
        }
    }

    public class RamaB : IRamaB
    {
        public RamaB(IRamaC ramaC, IRamaD ramaD)
        {

        }
    }

    public class RamaC : IRamaC
    {

    }

    public class RamaD : IRamaD
    {
        public RamaD(IRamaC ramaC)
        {

        }
    }
}
