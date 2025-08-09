using InheritanceDemo;
using AbstractClassDemo;
using InterfaceDemo;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Inheritance and Method Overriding Demo ===");
        DemonstrateInheritance();
        
        Console.WriteLine("\n=== Abstract Classes and Methods Demo ===");
        DemonstrateAbstractClasses();
        
        Console.WriteLine("\n=== Interfaces Demo ===");
        DemonstrateInterfaces();
    }

    static void DemonstrateInheritance()
    {
        Animal genericAnimal = new Animal();
        Dog dog = new Dog();
        Cat cat = new Cat();

        genericAnimal.MakeSound();
        dog.MakeSound();
        cat.MakeSound();
    }

    static void DemonstrateAbstractClasses()
    {
        Circle circle = new Circle(5);
        Rectangle rectangle = new Rectangle(4, 6);

        Console.WriteLine($"Area of circle (radius=5): {circle.GetArea():F2}");
        Console.WriteLine($"Area of rectangle (4x6): {rectangle.GetArea()}");
    }

    static void DemonstrateInterfaces()
    {
        IMovable car = new Car();
        IMovable bicycle = new Bicycle();

        car.Move();
        bicycle.Move();
    }
}