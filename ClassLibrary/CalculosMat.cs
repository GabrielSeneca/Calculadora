namespace ClassLibrary
{
    public class CalculosMat
    {

        //private CalculosMat _calc = CalculosMat.Cleared;
        //public decimal Value { get; private set; }

        //public decimal Add(decimal value)
        //{
        //    _calc = CalculosMat.Active;
        //    return Value += value;

        //}

        public static double Sum(double nA, double nB)
        {
            return nA + nB;
        }

        public static double Rest(double nA, double nB)
        {
            return nA - nB;
        }

        public static double Mult(double nA, double nB)
        {
            return nA * nB;
        }

        public static double Div(double nA, double nB)
        {
            return nA / nB;
        }

    }
}