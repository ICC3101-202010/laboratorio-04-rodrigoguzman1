using System;

namespace Laboratorio4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Maquina MaquinaAlmacenamiento = new Almacenamiento(5, "Almacenamiento");
            Maquina MaquinaEnsamblaje = new Ensamblaje(8, "Ensamblaje");
            Maquina MaquinaVerificacion = new Verificacion(3, "Verificación");
            Maquina MaquinaEmpaque = new Empaque(10, "Empaque");
            Maquina MaquinaRecepcion = new Recepcion(7, "Recepción");

            Console.WriteLine("ABRIENDO FABRICA...\n");
            MaquinaRecepcion.Encendido();
            MaquinaAlmacenamiento.Encendido();
            MaquinaEnsamblaje.Encendido();
            MaquinaVerificacion.Encendido();
            MaquinaEmpaque.Encendido();

            int hora = 7;
            int minutos = 0;

            Console.WriteLine("ELIGA TIPO DE CONTROL");
            Console.WriteLine("[1]CONTROL MANUAL");
            Console.WriteLine("[2]CONTROL AUTOMATICO");
            int control = Convert.ToInt32(Console.ReadLine());

            if (control == 1)
            {
                while (hora < 22)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    if (minutos == 60 || minutos == 0)
                    {
                        hora++; minutos = 0;
                        Console.WriteLine("Hora: " + hora + ":" + minutos + "0");
                    }
                    else
                    {
                        Console.WriteLine("Hora: " + hora + ":" + minutos);
                    }
                    Console.ForegroundColor = ConsoleColor.White;

                    minutos += 15;

                    MaquinaAlmacenamiento.ActualizarMemoria();

                    if (MaquinaAlmacenamiento.MemoriaMaximaAlcanzada())
                    {
                        ComputradorCentral.ReinicioManual(MaquinaAlmacenamiento,MaquinaRecepcion,MaquinaEnsamblaje,MaquinaVerificacion,MaquinaEmpaque, MaquinaAlmacenamiento);
                    }

                    MaquinaEnsamblaje.ActualizarMemoria();

                    if (MaquinaEnsamblaje.MemoriaMaximaAlcanzada())
                    {
                        ComputradorCentral.ReinicioManual(MaquinaAlmacenamiento, MaquinaRecepcion, MaquinaEnsamblaje, MaquinaVerificacion, MaquinaEmpaque, MaquinaEnsamblaje);
                    }

                    MaquinaVerificacion.ActualizarMemoria();

                    if (MaquinaVerificacion.MemoriaMaximaAlcanzada())
                    {
                        ComputradorCentral.ReinicioManual(MaquinaAlmacenamiento, MaquinaRecepcion, MaquinaEnsamblaje, MaquinaVerificacion, MaquinaEmpaque, MaquinaVerificacion);
                    }

                    MaquinaEmpaque.ActualizarMemoria();

                    if (MaquinaEmpaque.MemoriaMaximaAlcanzada())
                    {
                        ComputradorCentral.ReinicioManual(MaquinaAlmacenamiento, MaquinaRecepcion, MaquinaEnsamblaje, MaquinaVerificacion, MaquinaEmpaque, MaquinaEmpaque);
                    }

                    MaquinaRecepcion.ActualizarMemoria();

                    if (MaquinaRecepcion.MemoriaMaximaAlcanzada())
                    {
                        ComputradorCentral.ReinicioManual(MaquinaAlmacenamiento, MaquinaRecepcion, MaquinaEnsamblaje, MaquinaVerificacion, MaquinaEmpaque, MaquinaRecepcion);
                    }
                }

                Console.WriteLine("CERRANDO FABRICA...\n");

                MaquinaRecepcion.Apagado();
                MaquinaAlmacenamiento.Apagado();
                MaquinaEnsamblaje.Apagado();
                MaquinaVerificacion.Apagado();
                MaquinaEmpaque.Apagado();
            }
            else if (control == 2)
            {

                while (hora < 22)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    if (minutos == 60 || minutos == 0)
                    {
                        hora++; minutos = 0;
                        Console.WriteLine("Hora: " + hora + ":" + minutos + "0");
                    }
                    else
                    {
                        Console.WriteLine("Hora: " + hora + ":" + minutos);
                    }
                    Console.ForegroundColor = ConsoleColor.White;

                    minutos += 15;

                    MaquinaAlmacenamiento.ActualizarMemoria();

                    if (MaquinaAlmacenamiento.MemoriaMaximaAlcanzada())
                    {
                        ComputradorCentral.Reinicio(MaquinaAlmacenamiento);
                    }

                    MaquinaEnsamblaje.ActualizarMemoria();

                    if (MaquinaEnsamblaje.MemoriaMaximaAlcanzada())
                    {
                        ComputradorCentral.Reinicio(MaquinaEnsamblaje);
                    }

                    MaquinaVerificacion.ActualizarMemoria();

                    if (MaquinaVerificacion.MemoriaMaximaAlcanzada())
                    {
                        ComputradorCentral.Reinicio(MaquinaVerificacion);
                    }

                    MaquinaEmpaque.ActualizarMemoria();

                    if (MaquinaEmpaque.MemoriaMaximaAlcanzada())
                    {
                        ComputradorCentral.Reinicio(MaquinaEmpaque);
                    }

                    MaquinaRecepcion.ActualizarMemoria();

                    if (MaquinaRecepcion.MemoriaMaximaAlcanzada())
                    {
                        ComputradorCentral.Reinicio(MaquinaRecepcion);
                    }
                }

                Console.WriteLine("CERRANDO FABRICA...\n");

                MaquinaRecepcion.Apagado();
                MaquinaAlmacenamiento.Apagado();
                MaquinaEnsamblaje.Apagado();
                MaquinaVerificacion.Apagado();
                MaquinaEmpaque.Apagado();
            } else
            {
                Console.WriteLine("Opción no valida");
            }
        }
    }
}
