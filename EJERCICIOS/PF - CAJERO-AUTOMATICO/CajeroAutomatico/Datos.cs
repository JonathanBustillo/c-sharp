namespace CajeroAutomatico
{
    public class Datos
    {
        public Datos()
        {

        }
        public void banco()
        {
            int opcion=0, saldo=0;
            string respuesta = "";

            Console.WriteLine("Bienvenido al Cajero Automatico Atlantida");

            deskAccess acceso = new deskAccess ();
            Console.WriteLine("Ingrese la Contraseña :");
            acceso.Pin = int.Parse(Console.ReadLine());

            if (acceso.Pin == acceso.Pin)
            {
                Calculos op = new Calculos ();
                do
                {
                    Console.WriteLine("******************************");
                    Console.WriteLine("\nSelecciona la Tr0ansaccion que Deseas Realizar:");
                    Console.WriteLine("Su Saldo Inicial es de 2,500y solo puede Retirar 2,500");
                    Console.WriteLine("1. Consultar Saldo");
                    Console.WriteLine("2. Retirar Efectivo");
                    Console.WriteLine("3. Depositar");
                    Console.WriteLine("0. Salir");
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                        Console.WriteLine("Consultar Saldo");
                        Console.WriteLine("Su Saldo es de:");
                        acceso.Consultar = int.Parse(Console.ReadLine());
                        break;

                         case 2:
                        Console.WriteLine("Retirar Efectivo");
                        Console.WriteLine("Ingrese la Cantidad a Retirar:");
                        acceso.Retirar = int.Parse(Console.ReadLine());
                        acceso.Retirar = int.Parse(Console.ReadLine());

                        if (acceso.Retirar > 2500)
                        {
                            Console.WriteLine("Solo se puede Retirar 2500 lempiras, Vuelva a Intentarlo");
                        }
                        else 
                        {
                            saldo = op.operacion(acceso.Retirar, saldo);
                            Console.WriteLine("Su Saldo es:", saldo);
                        }
                        break;

                         case 3:
                        Console.WriteLine("Depositar");
                        Console.WriteLine("Ingrese la Cantidad a Depositar:");
                        acceso.Depositar = int.Parse(Console.ReadLine());
                        saldo = op.operacion(acceso.Depositar);
                        Console.WriteLine("Se Deposito Correctamente");
                        break;

                        case 0:
                        Console.WriteLine("Saliendo del Sistema");
                        break;

                        default:
                        Console.WriteLine("Los Datos Ingresados son Incorrectos, Vuelva a Intentarlo");
                        break;

                    }
                    Console.WriteLine("Desea volver a Intentarlo?, Presione ¨si¨ para continuar, presione cualquier tecla para finalizar");

                }
                while (respuesta == "SI" || respuesta == "si");
            }
            else 
            {
                Console.WriteLine("¡La Contraseña no es Correcta!");
            }

        }
    }
}
class deskAccess
{
    private int pin;
    private int depositar;
    private int retirar;
    private int consultar;
    public int Pin
    {
        set
        {
            pin = value;
        }
        get 
        {
            return pin;
        }
    }
    public int Depositar
    {
        set
        {
            depositar = value;
        }
        get 
        {
            return depositar;
        }
    }
    public int Retirar 
    {
        set
        {
            retirar = value;
        }
        get 
        {
            return retirar;
        }
    }
    public int Consultar
    {
        set
        {
            consultar = value;
        }
        get 
        {
            return consultar;
        }
    }
}