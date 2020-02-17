using Práctica_decorador.Servicios.Interfaces;

namespace Práctica_decorador.Servicios
{
    public class EnviarCorreoDecorator : AbstractCPXDecorator
    {
        public EnviarCorreoDecorator(ICXPService cXPService) : base(cXPService)
        {
            _name = "Se envió correo";
        }
    }
}
