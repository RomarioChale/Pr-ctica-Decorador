using Práctica_decorador.Servicios.Interfaces;
using System;

namespace Práctica_decorador
{
    public class GuardarCXPService : ICXPService
    {
        public string Accion()
        {
            return "Se guardo la CXP";
        }
    }
}
