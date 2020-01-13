namespace Operations
{
    public class Sq
    {
        public static int Squared(int a)
        {
            return a * a;
        }

        public static double Squared(double a)
        {
            return a * a;
        }

        public static double[] Squared(double[] a)
        {
            double[] c = new double[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                c[i] = Squared(a[i]);
            }
            return c;
        }

        public static int[] Squared(int[] a)
        {
            int[] c = new int[a.Length]; ;
            for (int i = 0; i < a.Length; i++)
            {
                c[i] = Squared(a[i]);
            }
            return c;
        }
    }
}