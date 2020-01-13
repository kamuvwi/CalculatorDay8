using Operations;

namespace Divide
{
    public class Divides : IDivides
    {
        public dynamic result;

        public dynamic Quotient(dynamic a, dynamic b)
        {
            result = Division.Quotient(a, b);
            return result;
        }

        public dynamic Quotient(dynamic a)
        {
            result = Division.Quotient(a);
            return result;
        }
    }
}