using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_core_showcase.Basic
{
    class Casting
    {

        static void Main() {

        }

        void implicitCast() {
            int myInt = 9;
            double myDouble = myInt;       // Automatic casting: int to double

            Console.WriteLine("Valeur entier : " + myInt);      // Outputs 9
            Console.WriteLine("Valeur double: " + myDouble);   // Outputs 9
        }

        void explicitCast() {
            double myDouble = 9.78;
            int myInt = (int)myDouble;    // Manual casting: double to int

            Console.WriteLine(myDouble);   // Outputs 9.78
            Console.WriteLine(myInt);      // Outputs 9
        }

        void methodCast()
        {
            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
        }

        void objectCast() {
            // Create a new derived type.
            Giraffe g = new Giraffe();

            // Implicit conversion to base type is safe.
            Animal a = g;

            // Explicit conversion is required to cast back
            // to derived type. Note: This will compile but will
            // throw an exception at run time if the right-side
            // object is not in fact a Giraffe.
            Giraffe g2 = (Giraffe)a;
        }
    }
}
