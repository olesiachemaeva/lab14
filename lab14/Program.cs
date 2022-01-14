using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Разработать классы Cat и Dog, которые реализуют абстрактный класс Animal. В классах реализовать следующие элементы:
•	свойство – название животного;
•	метод Say(), выводящий на экран «Мяу» либо «Гав» соответственно.
Создайте экземпляры классов Cat и Dog и проверьте их работоспособность.*/



namespace lab14
{

    abstract class Animal
    {
        public abstract string Name { get; set; }
        public Animal(string name)
        {
            Name = name;
            }
        public abstract void Say();
        public  void ShowInfo()
        {
            Console.WriteLine(Name);
            Say();
        }

    }
    class Cat : Animal
    {
       // private string taste;
        public string name;
        public override string Name
        { get => name; 
            set => name=value;
        }
        public Cat(string name/*string taste*/)
            :base (name)
        {
           // this.taste = taste;
        }
        public override void Say()
        {
            Console.WriteLine("Мяу!");
        }
    }
    class Dog : Animal
    {
        
        public string name;
        public override string Name
        {
            get => name;
            set => name = value;
        }
        public Dog(string name)
            : base(name)
        {
            
        }
        public override void Say()
        {
            Console.WriteLine("Гав!");
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Cat cat = new Cat("Муська");
            Dog dog = new Dog("Шарик");
            cat.ShowInfo();
            dog.ShowInfo();
            

            //создание стека

            /*var stack = new Stack<string>();
            stack.Push("cat");
            stack.Push("dog");
            

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(stack.Pop());

            }*/
            Console.ReadKey();
        }
    }
   
}


