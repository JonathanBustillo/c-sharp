namespace CajeroAutomatico
{
    public class Calculos 
    {
        public Calculos()
        {

        }
        int saldoInicial = 2500, calcTotal = 0;


        public int operacion(int Depositar)
        {
            saldoInicial = saldoInicial + Depositar;
            return saldoInicial;
        }

        public int operacion(int Retirar, int totalInicial)
        {
            calcTotal = totalInicial - Retirar;
            return calcTotal;
        }
    }
}