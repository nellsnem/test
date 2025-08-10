using System;

interface IAnimal
{
    void Speak();
}

class Dog : IAnimal
{
    public void Speak()
    {
        Console.WriteLine(" meow");
    }
}
class Cat : IAnimal
{
    public void Speak()
    {
        Console.WriteLine(" gaf");
    }
}
class Program
{
    static void Main()
    {
        IAnimal dog = new Dog();
        IAnimal cat = new Cat();

        dog.Speak();
        cat.Speak();
        
        Console.ReadKey();
    }
}





