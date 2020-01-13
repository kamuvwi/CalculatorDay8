using Operations;

namespace Add
{
    public class Adds : IAdds
    {
        public dynamic result;

        public dynamic Sum(dynamic a, dynamic b)
        {
            result = Addition.Sum(a, b);
            return result;
        }

        public dynamic Sum(dynamic a)
        {
            result = Addition.Sum(a);
            return result;
        }
    }
}