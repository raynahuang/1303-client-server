using ClntSrvrWk1.Lessons.Week4.ObjectType;
using ClntSrvr.Lessons.Week6;
using System.ComponentModel.DataAnnotations;

namespace ClntSrvrWk1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var test = new DelegateExample();
            test.TestDelegateFunctionality();
        }
    }
}
