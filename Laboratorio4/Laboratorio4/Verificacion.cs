using System;
namespace Laboratorio4
{
    public class Verificacion : Maquina
    {
        public Verificacion(int memoria)
        {
            this.memoriaMaxima = memoria;
        }

        public override void Apagado()
        {
            Console.WriteLine("Maquina de Verificación apagada\n");
        }

        public override void Encendido()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Maquina de Verificación encendida\n");
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public override void Reinicio()
        {
            base.Reinicio();
            Console.WriteLine("Maquina de Verificación reiniciada\n");
        }
    }
}
