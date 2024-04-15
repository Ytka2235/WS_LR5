using System;

class Program
{
    static void Main()
    {
        Dog dog = new Dog();
        dog.food = "мясо";
        dog.location = "дом";
        dog.breed = "Хаски";
        dog.eat();
        dog.makeNoise();
        dog.sleep();
        Veterinarian vet = new Veterinarian();
        vet.treatAnimal(dog);
        Console.WriteLine( );

        Cat cat = new Cat();
        cat.food = "кити кет";
        cat.location = "квартира";
        cat.color = "черный";
        cat.eat();
        cat.makeNoise();
        cat.sleep();
        vet.treatAnimal(cat);
        Console.WriteLine( );

        Horse horse = new Horse();
        horse.food = "сено";
        horse.location = "конюшня";
        horse.speed = 60;
        horse.eat();
        horse.makeNoise();
        horse.sleep();
        vet.treatAnimal(horse);
    }
}
class Animal
{
    public string food;
    public string location;

    public virtual void makeNoise()
    {
        Console.WriteLine("Животное издаёт звук");
    }

    public virtual void eat()
    {
        Console.WriteLine("Животное ест");
    }

    public virtual void sleep()
    {
        Console.WriteLine("Животное спит");
    }
}

class Dog : Animal
{
    public string breed;

    public override void makeNoise()
    {
        Console.WriteLine("Собака лает");
    }

    public override void eat()
    {
        Console.WriteLine("Собака кушает кость");
    }
    public override void sleep()
    {
        Console.WriteLine("Собака спит");
    }
}

class Cat : Animal
{
    public string color;

    public override void makeNoise()
    {
        Console.WriteLine("Кошка мурлычет");
    }

    public override void eat()
    {
        Console.WriteLine("Кошка ест рыбу");
    }
    public override void sleep()
    {
        Console.WriteLine("Кошка спит");
    }
}

class Horse : Animal
{
    public int speed;

    public override void makeNoise()
    {
        Console.WriteLine("Лошадь фыркает");
    }

    public override void eat()
    {
        Console.WriteLine("Лошадь ест сено");
    }
    public override void sleep()
    {
        Console.WriteLine("Лошадь спит");
    }
}

class Veterinarian
{
    public void treatAnimal(Animal animal)
    {
        Console.WriteLine($"Еда: {animal.food}, Локация: {animal.location}");
    }
}

