using System;

namespace BEOPM4_02_05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a Guid randomly
            Guid g1 = Guid.NewGuid();
            Console.WriteLine(g1);

            //Create a hex string into Guid format using 32 hex numbers.
            //Broken into Guid groups or in an unbroken string
            Guid g2 = new Guid("{0d57629c-7d6e-4847-97cb-9e2fc25083fe}");
            Guid g3 = new Guid("0d57629c7d6e484797cb9e2fc25083fe");

            Console.WriteLine(g3);
            Console.WriteLine(g2 == g3);  // True

            //Empty Guid is all set to zero = to default Guid
            Console.WriteLine(Guid.Empty);
            Console.WriteLine(default(Guid));
        }
    }
}
