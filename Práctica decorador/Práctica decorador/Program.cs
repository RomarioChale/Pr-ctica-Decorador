using Práctica_decorador.Servicios;
using System;

namespace Práctica_decorador
{
    class Program
    {
        static void Main(string[] args)
        {
            var AccionesCXP = new GuardarHistorialDecorator(new EnviarCorreoDecorator(new GuardarCXPService()));
            Console.WriteLine($"se realizaron las siguientes acciones: {AccionesCXP.Accion().ToString()}");
            Console.ReadLine();
        }
    }
}
