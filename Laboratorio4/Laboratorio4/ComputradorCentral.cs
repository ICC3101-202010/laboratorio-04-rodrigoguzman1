using System;
namespace Laboratorio4
{
    public class ComputradorCentral
    {
        public static void Reinicio(Maquina maquina){ maquina.Reinicio(); }
        public static void Apagado(Maquina maquina) { maquina.Apagado(); }
        public static void Encendido(Maquina maquina) { maquina.Encendido(); }

        public static void ReinicioManual(Maquina MaquinaAlmacenamiento, Maquina MaquinaRecepcion, Maquina MaquinaEnsamblaje, Maquina MaquinaVerificacion, Maquina MaquinaEmpaque ,Maquina MaquinaColapsada)
        {
            Console.WriteLine("MAQUINA COLAPSADA");
            Console.WriteLine("Nombre Maquina:  "+MaquinaColapsada.nombre);

            Console.WriteLine("SELECCIONE MAQUINA QUE DESEA REINICIAR");
            Console.WriteLine("[1]RECEPCIÓN");
            Console.WriteLine("[2]ALMACENAMIENTO");
            Console.WriteLine("[3]ENSAMBLAJE");
            Console.WriteLine("[4]VERIFICACIÓN");
            Console.WriteLine("[5]EMPAQUE\n");
            int seleccion = Convert.ToInt32(Console.ReadLine());

            switch (seleccion)
            {
                case 1:
                    MaquinaRecepcion.Reinicio();
                    break;
                case 2:
                    MaquinaAlmacenamiento.Reinicio();
                    break;
                case 3:
                    MaquinaEnsamblaje.Reinicio();
                    break;
                case 4:
                    MaquinaVerificacion.Reinicio();
                    break;
                case 5:
                    MaquinaEmpaque.Reinicio();
                    break;
                default:
                    Console.WriteLine("Opción no valida");
                    break;
            }

        }

    }
}
