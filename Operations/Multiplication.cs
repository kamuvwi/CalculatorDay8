namespace Operations
{
    public class Multiplication
    {
        public static int Times(int a, int b)
        {
            return a * b;
        }

        public static double Times(double a, double b)
        {
            return a * b;
        }

        public static double Times(double[] a)
        {
            double c = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                c = Times(c, a[i]);
            }
            return c;
        }

        public static int Times(int[] a)
        {
            int c = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                c = Times(c, a[i]);
            }
            return c;
        }
    }
}