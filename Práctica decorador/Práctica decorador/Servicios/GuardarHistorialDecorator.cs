using Práctica_decorador.Servicios.Interfaces;

namespace Práctica_decorador.Servicios
{
    public class GuardarHistorialDecorator : AbstractCPXDecorator
    {
        public GuardarHistorialDecorator(ICXPService cXPService) : base(cXPService)
        {
            _name = "Se guardo el historial";
        }
    }
}
