using System;

namespace CsBasic2 {
    class Animal
    {
        int age;
        public Animal() { }
        public Animal(int mAge)
        {
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
    }

}