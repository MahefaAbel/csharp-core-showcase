﻿using System;

namespace CsBasic {
    class Principal {
        static int Main(string[] args) {
            //Principal.testArgFactorial(args);
            //Principal.testTypeMopdifier();
            //Principal.testCating();
            //Principal.testNullable();
            //Principal.testBox();
            //Principal.testArray();
            //Principal.testTypeChecking();
            //Principal.testStaticConstructor();
            //Principal.testSuperTigre();
            Principal.testPolymorphism();
            return 0;
        }

        static void testPolymorphism() {
            Animal animal = new Animal(4);
            Animal tigre = new Tigre(5);
            Animal taureau = new Taureau(6);

            animal.seDeplacer();
            tigre.seDeplacer();
            taureau.seDeplacer();
        }

        static void testSuperTigre() {
            //SuperTigre superTiger = new SuperTigre();
            //Console.WriteLine("superTiger type : {0}", superTiger.GetType());
        }

        static void testStaticConstructor() {
            Console.WriteLine("testStaticConstructor::debut");
            Animal animal1, animal2, animal3;
            Console.WriteLine("testStaticConstructor::animal1,2,3 declared");
            animal1 = new Animal();
            Console.WriteLine("testStaticConstructor::animal1 instanced");
            animal2 = new Animal();
            Console.WriteLine("testStaticConstructor::animal2 instanced");
            animal3 = new Animal();
            Console.WriteLine("testStaticConstructor::animal3 instanced");

            Console.WriteLine("testStaticConstructor::fin");
        }

        static void testTypeChecking() {
            object animal = new Animal(4);
            object obj = new object();
            Console.WriteLine("Type 'object obj' : {0}", obj.GetType());
            Console.WriteLine("Type 'object animal': {0}", animal.GetType());
            // Resultats :
            // System.Object
            // CsBasic.Animal

            if (animal.GetType() == typeof(CsBasic.Animal)){

            }
            if (animal is CsBasic.Animal)
            {

            }
        }

        static void testArray() {
            int[] arrInt = new int[3];
            arrInt[3] = 1;
            Console.WriteLine(arrInt[3]);
        }

        static void testBox() {
            int nb = 3;
            object obj = nb; // Boxing
            int nb2 = (int)obj; // Unboxing
            Console.WriteLine("Nb : {0}", nb);
            Console.WriteLine("Obj : {0}", obj);
            Console.WriteLine("Nb2 : {0}", nb2);
        }

        static void testNullable() {
            int nb;
            int? nb2;
            Nullable<int> nullableNb = 3;
            Nullable<int> nullableNb2 = null;
            Animal animal = null;
            Console.WriteLine("Nb : {0} {1} {2}", nullableNb.HasValue, nullableNb2, nullableNb2.HasValue);
        }

        static void testCating() {
            int nb = 3;

            double nbd = nb;
            Console.WriteLine("Entier : " + nb);
            Console.WriteLine("Double : " + nbd);
            Console.WriteLine("");
            double nbd2 = 4.002;
            nb = (int)nbd2;
            Console.WriteLine("Double : " + nbd2);
            Console.WriteLine("Entier : " + nb);
            Console.WriteLine("");
            int nb2 = 4;
            double nb2d = Convert.ToDouble(5.1);
            int nb21 = Convert.ToInt32(nb2d);
            Console.WriteLine("");

            Animal animal = new Animal(5);
            Tigre tigre = new Tigre(4);
            Taureau taureau = new Taureau(6);
            Console.WriteLine("Animal : "+ animal.getAge());
            Console.WriteLine("Tigre : "+ tigre.getAge());
            Console.WriteLine("Taureau: "+ taureau.getAge());
            Console.WriteLine("");

            animal = tigre;
            Console.WriteLine("Animal : "+ animal.getAge());

            tigre = (Tigre)animal;
            Console.WriteLine("Tigre : " + tigre.getAge());
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

    class Animal: Object
    {
        int age;
        static Animal() {
            Console.WriteLine("CsBasic.Animal.constructor.static");
        }
        public Animal() {
            Console.WriteLine("CsBasic.Animal.constructor.Animal()");
        }
        public Animal(int mAge)
        {
            Console.WriteLine("CsBasic.Animal.constructor.Animal(int mAge)");
            this.age = mAge;
        }
        public void setAge(int nAge)
        {
            this.age = nAge;
        }
        public int getAge()
        {
            return this.age;
        }
        public virtual void seDeplacer() {
            Console.WriteLine("Animal::seDeplacer");
        }
        ~Animal() {
            //
        }
        //public override void Finalize()
        //{
        //    Console.WriteLine();
        //}
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
        
    sealed class Tigre : Animal {
        int classPredator;
        public Tigre(int age): base(age)
        {

        }
        public override void seDeplacer() {
            Console.WriteLine("Tigre::seDeplacer()");
        }
    }

    //class SuperTigre : Tigre {
    //    public SuperTigre() {
    //        Console.WriteLine("Youpy, La SuperTigre est crée");
    //    }
        
    //}

    class Taureau : Animal {
        int longeurCorne;

        public Taureau(int age)
            : base(age)
        {

        }

        public override void seDeplacer()
        {
            Console.WriteLine("Taureau::seDeplacer()");
        }
    }
}