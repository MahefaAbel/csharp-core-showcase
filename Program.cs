using System;

namespace CsBasic {
    class Principal {
        static void Main(string[] args) {
            string nom = "World";
            if (args.Length > 0){
                nom = args[0];
            }
            Console.WriteLine("Hello, " + nom);
        }
    }
}