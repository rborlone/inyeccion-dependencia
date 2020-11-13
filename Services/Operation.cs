using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InyeccionDependenciaExplicado.Services
{
    /// <summary>
    /// Interface de IOperation
    /// </summary>
    public interface IOperation
    {
        Guid OperationId { get; }
    }

    public interface IOperationTransient : IOperation
    {
    }
    public interface IOperationScoped : IOperation
    {
    }
    public interface IOperationSingleton : IOperation
    {
    }
    public interface IOperationSingletonInstance : IOperation
    {
    }

    /// <summary>
    /// Clase Operacion.
    /// </summary>
    public class Operation : IOperationScoped, IOperationSingleton, IOperationSingletonInstance, IOperationTransient
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Operation()
        {
            //Generacion de Guid unico-
            _guid = Guid.NewGuid();
        }
        public Operation(Guid guid)
        {
            _guid = guid;
        }

        private Guid _guid;
        public Guid OperationId { get { return _guid; } }
    }

}
