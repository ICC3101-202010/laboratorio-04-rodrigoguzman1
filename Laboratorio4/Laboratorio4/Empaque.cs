using System;
namespace Laboratorio4
{
    public class Empaque : Maquina
    {
        public Empaque(int memoria, string nombre)
        {
            this.memoriaMaxima = memoria;
            this.nombre = nombre;
        }

        public override void Apagado()
        {
            Console.WriteLine("Maquina de Empaque apagada\n");
        }

        public override void Encendido()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Maquina de Empaque encendida\n");
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public override void Reinicio()
        {
            base.Reinicio();
            Console.WriteLine("Maquina de Empaque reiniciada\n");
        }
    }
}
