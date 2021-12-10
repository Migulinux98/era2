using System;
using System.Collections.Generic;

namespace lib1{


    public abstract class Animal
    {
        protected string _name;
        public Animal(string name)
        {

            _name = name;
        }

        public Animal(){}

        public abstract void bark();
        
    }


    public class Dog : Animal{

        private string name;
        
        public Dog(string nm){

            this.Name=nm;
            
        }
        public Dog(){}

        public string Name{
            
            get { return this.name; }
            set { this.name = value; }
        }


        public override void bark(){
            
            Console.WriteLine("bow-wow");
        }  

    }

    public class SheepDog : Dog{

       
        public SheepDog(string nm ) : base(nm)
        {
            
        }
        public SheepDog(){}

        public override void bark(){

            Random num = new Random();
            int n = num.Next(1,10);
            
           
            for(int i = 0; i<n;i++){
               
                Console.WriteLine("bow-wow");
            }
            
        }

    }
}