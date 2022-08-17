using System;

namespace CajeroAutomatico
{
    class Program
    {
        static void Main(string[] args)
    {
        Datos conexion = new Datos();
        conexion.banco();
        Console.ReadKey(true);
    }
  }
}