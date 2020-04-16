using System;
namespace Laboratorio4
{
    public abstract class Maquina
    {
        public Maquina()
        {
        }

        public int memoriaMaxima;
        public int memoriaActual = 0;

        public abstract void Encendido();
        public virtual void Reinicio() { memoriaActual = 0; Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Memoria Colapsada"); Console.ForegroundColor = ConsoleColor.White; }
        public abstract void Apagado();

        public void ActualizarMemoria()
        {
            memoriaActual ++;
        }

        public bool MemoriaMaximaAlcanzada()
        {
            if (memoriaActual == memoriaMaxima) { return true; } else { return false; }
        }
    }
}
