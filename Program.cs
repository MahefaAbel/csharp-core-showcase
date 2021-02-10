using System;

namespace CsBasic {
    class Principal {
        static int Main(string[] args) {
            int nombre = -1;
            if (args.Length > 0){
                nombre = Int32.Parse(args[0]);
            }
            if (nombre == -1) {
                Console.WriteLine("Mauvaise argument");
                return 1;
            }

            int result = Operation.factorial(nombre);
            
            Console.WriteLine("Resultat du Factoriel : " + result);
            return 0;
        }
    }

    class Operation {
        public static int factorial(int nombre){
            if (nombre > 0){
                return nombre * Operation.factorial(nombre - 1);
            }else {
                return 1;
            }
        }
    }
}