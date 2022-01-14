using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probniivariant
{
  
    class All
    {
        virtual public void Say()
        { Console.WriteLine("Hi"); }
    }
    class Animal : All
    { }
    

    class Cat : Animal
    {
        override public void Say()
        { 
            Console.WriteLine("мяу");
        }
    }
    class Dog : Animal
    {
        override public void Say()
        { Console.WriteLine("гав"); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Dog dog = new Dog();
          

            //создание стека

            var stack = new Stack<string>();
            stack.Push("cat");
            stack.Push("dog");
          

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(stack.Pop());

            }
            Console.ReadKey();

        }
    }
}

