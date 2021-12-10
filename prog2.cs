using System;
using System.Collections.Generic;
using lib1;

    class Program {
        static void Main() {


        SheepDog s1 = new SheepDog("Max");
        Dog d1 = new Dog("Boby");

       
        
        Console.WriteLine("{0} make ", d1.Name);
        d1.bark();
        Console.WriteLine("\n");
        Console.WriteLine("{0} make ", s1.Name);
        s1.bark();

        
        }
    }