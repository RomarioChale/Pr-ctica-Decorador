using Práctica_decorador.Servicios.Interfaces;

namespace Práctica_decorador.Servicios
{
    public abstract class AbstractCPXDecorator : ICXPService
    {
        private readonly ICXPService _cxpService;

        protected string _name = "";
        protected AbstractCPXDecorator(ICXPService cXPService)
        {
            _cxpService = cXPService;
        }

        public string Accion()
        {
           return $"{_cxpService.Accion()} {_name}" ;
        }

       
    }
}
