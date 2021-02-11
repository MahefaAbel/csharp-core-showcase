using System;

namespace CsBasic {
    class Principal {
        static int Main(string[] args) {
            //Principal.testArgFactorial(args);
            Principal.testTypeMopdifier();
            return 0;
        }

        static int testTypeMopdifier() {
            int nombre = 1;

            Console.WriteLine("Valeur nombre (passage par valeur) [Avant] : " + nombre);
            CaseValueRef.valueTypeModifier(nombre);
            Console.WriteLine("Valeur nombre (passage par valeur) [Apres] : " + nombre);
            Console.WriteLine("");
            Console.WriteLine("Valeur nombre (passage par reference) [Avant] : " + nombre);
            CaseValueRef.refTypeModifier(ref nombre);
            Console.WriteLine("Valeur nombre (passage par reference) [Apres] : " + nombre);
            Console.WriteLine("");
            Animal animal = new Animal(3);
            Console.WriteLine("Valeur nombre (passage par reference) [Avant] : " + animal.getAge());
            CaseValueRef.modifObject(animal);
            Console.WriteLine("Valeur nombre (passage par reference) [Apres] : " + animal.getAge());

            return 0;
        }

        static int testArgFactorial(string[] args) {
            int nombre = -1;
            if (args.Length > 0)
            {
                nombre = Int32.Parse(args[0]);
            }
            if (nombre == -1)
            {
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

    class Operation
    {
        public static void factorialRef(ref int nombre)
        {
            if (nombre > 0)
            {
                int pNombre = nombre;
                nombre = nombre - 1;
                Operation.factorialRef(ref nombre);
                nombre = pNombre * nombre;
            }
            else
            {
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
    
        class CaseValueRef{
            public static void valueTypeModifier(int nb){
                nb = 20;
            }

            public static void refTypeModifier(ref int nb)
            {
                nb = 30;
            }

            public static void modifObject(Animal animal) {
                animal.setAge(6);
            }
        }

        class Animal {
            int age;
            public Animal(int mAge) {
                this.age = mAge;
            }
            public void setAge(int nAge) {
                this.age = nAge;
            }
            public int getAge() {
                return this.age;
            }
        }
}