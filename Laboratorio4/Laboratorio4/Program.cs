using System;

namespace Laboratorio4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Maquina MaquinaAlmacenamiento = new Almacenamiento(5);
            Maquina MaquinaEnsamblaje = new Ensamblaje(8);
            Maquina MaquinaVerificacion = new Verificacion(3);
            Maquina MaquinaEmpaque = new Empaque(10);
            Maquina MaquinaRecepcion = new Recepcion(7);

            Console.WriteLine("ABRIENDO FABRICA...\n");
            MaquinaRecepcion.Encendido();
            MaquinaAlmacenamiento.Encendido();
            MaquinaEnsamblaje.Encendido();
            MaquinaVerificacion.Encendido();
            MaquinaEmpaque.Encendido();

            int hora = 7;
            int minutos = 0;

            while (hora < 22)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                if (minutos == 60 || minutos == 0) {
                    hora++; minutos = 0;
                    Console.WriteLine("Hora: " + hora + ":" + minutos+"0");
                } else {
                    Console.WriteLine("Hora: " + hora + ":" + minutos);
                }
                Console.ForegroundColor = ConsoleColor.White;
                
                minutos += 15;
                
                MaquinaAlmacenamiento.ActualizarMemoria();

                if (MaquinaAlmacenamiento.MemoriaMaximaAlcanzada())
                {
                    MaquinaAlmacenamiento.Reinicio();
                }

                MaquinaEnsamblaje.ActualizarMemoria();

                if (MaquinaEnsamblaje.MemoriaMaximaAlcanzada())
                {
                    MaquinaEnsamblaje.Reinicio();
                }

                MaquinaVerificacion.ActualizarMemoria();

                if (MaquinaVerificacion.MemoriaMaximaAlcanzada())
                {
                    MaquinaVerificacion.Reinicio();
                }

                MaquinaEmpaque.ActualizarMemoria();

                if (MaquinaEmpaque.MemoriaMaximaAlcanzada())
                {
                    MaquinaEmpaque.Reinicio();
                }

                MaquinaRecepcion.ActualizarMemoria();

                if (MaquinaRecepcion.MemoriaMaximaAlcanzada())
                {
                    MaquinaRecepcion.Reinicio();
                }
            }

            Console.WriteLine("CERRANDO FABRICA...\n");

            MaquinaRecepcion.Apagado();
            MaquinaAlmacenamiento.Apagado();
            MaquinaEnsamblaje.Apagado();
            MaquinaVerificacion.Apagado();
            MaquinaEmpaque.Apagado();

        }
    }
}
