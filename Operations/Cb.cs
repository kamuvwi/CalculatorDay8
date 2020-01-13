namespace Operations
{
    public class Cb
    {
        public static int Cubed(int a)
        {
            return a * a * a;
        }

        public static double Cubed(double a)
        {
            return a * a * a;
        }

        public static double[] Cubed(double[] a)
        {
            double[] c = new double[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                c[i] = Cubed(a[i]);
            }
            return c;
        }

        public static int[] Cubed(int[] a)
        {
            int[] c = new int[a.Length]; ;
            for (int i = 0; i < a.Length; i++)
            {
                c[i] = Cubed(a[i]);
            }
            return c;
        }
    }
}