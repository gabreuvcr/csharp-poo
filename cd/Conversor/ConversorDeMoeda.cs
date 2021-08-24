namespace Conversor
{
    class ConversorDeMoeda
    {
        public static double Iof = 1.06;

        public static double DolarParaReal(double cotacao, double quantia) 
        {
            return cotacao * quantia * Iof;
        }
    }
}
