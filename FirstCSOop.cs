using System;

class Animal
{
    public void Move()
    {
        Console.WriteLine("Animal is moving");
    }

    public void Sleep()
    {
        Console.WriteLine("Animal is sleeping");
    }

    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}

class Dog : Animal
{
    public void Sing()
    {
        Console.WriteLine("Dog is singing");
    }

    public void Wash()
    {
        Console.WriteLine("Dog is washing");
    }

    public void TurnAround()
    {
        Console.WriteLine("Dog is turning around");
    }
}

class Cat : Animal
{
    public void Sing()
    {
        Console.WriteLine("Cat is singing");
    }

    public void Wash()
    {
        Console.WriteLine("Cat is washing");
    }

    public void TurnAround()
    {
        Console.WriteLine("Cat is turning around");
    }
}

class Bird : Animal
{
    public void Sing()
    {
        Console.WriteLine("Bird is singing");
    }

    public void Wash()
    {
        Console.WriteLine("Bird is washing");
    }

    public void TurnAround()
    {
        Console.WriteLine("Bird is turning around");
    }
}

interface IUFO
{
    void Fly();
    void GoToHyperspace();
    void Land();
}

class SmallCraft : IUFO
{
    public void Fly()
    {
        Console.WriteLine("SmallCraft is flying");
    }

    public void GoToHyperspace()
    {
        Console.WriteLine("SmallCraft is going to hyperspace");
    }

    public void Land()
    {
        Console.WriteLine("SmallCraft is landing");
    }
}

class LargeCraft : IUFO
{
    public void Fly()
    {
        Console.WriteLine("LargeCraft is flying");
    }

    public void GoToHyperspace()
    {
        Console.WriteLine("LargeCraft is going to hyperspace");
    }

    public void Land()
    {
        Console.WriteLine("LargeCraft is landing");
    }
}

class BossCraft : IUFO
{
    public void Fly()
    {
        Console.WriteLine("BossCraft is flying");
    }

    public void GoToHyperspace()
    {
        Console.WriteLine("BossCraft is going to hyperspace");
    }

    public void Land()
    {
        Console.WriteLine("BossCraft is landing");
    }

    class FirstCSOop
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();
            Bird bird = new Bird();

            dog.Move();
            dog.Sleep();
            dog.Eat();
            dog.Sing();
            dog.Wash();
            dog.TurnAround();

            cat.Move();
            cat.Sleep();
            cat.Eat();
            cat.Sing();
            cat.Wash();
            cat.TurnAround();

            bird.Move();
            bird.Sleep();
            bird.Eat();
            bird.Sing();
            bird.Wash();
            bird.TurnAround();

            SmallCraft smallCraft = new SmallCraft();
            LargeCraft largeCraft = new LargeCraft();
            BossCraft bossCraft = new BossCraft();

            smallCraft.Fly();
            smallCraft.GoToHyperspace();
            smallCraft.Land();

            largeCraft.Fly();
            largeCraft.GoToHyperspace();
            largeCraft.Land();

            bossCraft.Fly();
            bossCraft.GoToHyperspace();
            bossCraft.Land();
        }
    }
}
