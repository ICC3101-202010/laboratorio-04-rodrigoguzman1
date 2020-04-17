using System;
namespace Laboratorio4
{
    public class Almacenamiento : Maquina
    {
        public Almacenamiento(int memoria, string nombre)
        {
            this.memoriaMaxima = memoria;
            this.nombre = nombre;
        }


        public override void Apagado()
        {
            Console.WriteLine("Maquina de Almacenamiento apagada\n");
        }

        public override void Encendido()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Maquina de Almacenamiento encendida\n");
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public override void Reinicio()
        {
            base.Reinicio();
            Console.WriteLine("Maquina de Almacenamiento reiniciada\n");
        }
    }
}
