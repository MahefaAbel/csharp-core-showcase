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

            int result1 = Operation.factorialVal(nombre);
            int result2 = nombre;
            Operation.factorialRef(ref result2);

            Console.WriteLine("Resultat du Factoriel(ByVal) : " + result1);
            Console.WriteLine("Resultat du Factoriel(ByRef) : " + result2);
            return 0;
        }
    }

    class Operation {
        public static void factorialRef(ref int nombre){
            if (nombre > 0){
                int pNombre = nombre;
                nombre = nombre - 1;
                Operation.factorialRef(ref nombre);
                nombre = pNombre * nombre;
            }else {
                nombre = 1;
            }
        }

        public static int factorialVal(int nombre)
        {
            if (nombre > 0){
                return nombre * Operation.factorialVal(nombre - 1);
            }else{
                return 1;
            }
        }
    }
}