using System;

namespace Module4
{
    class Program
    {
        static void Main()
        {
            DateTime myDateTimeVariable = new DateTime(2010, 05, 10);

            DateTime myDateTimeVariable2 = new DateTime(1998, 01, 01);

            int result = DateTime.Compare(myDateTimeVariable, myDateTimeVariable2);

            Console.WriteLine(result);
                
        }
    }
}



 


