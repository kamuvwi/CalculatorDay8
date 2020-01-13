using Operations;

namespace Square
{
    public class Squares : ISquares
    {
        public dynamic result;

        public dynamic Squared(dynamic a)
        {
            result = Sq.Squared(a);
            return result;
        }
    }
}