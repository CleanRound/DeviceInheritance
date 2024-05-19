public abstract class Device
{
    public string Name { get; set; }
    public string Characteristics { get; set; }

    public Device(string name, string characteristics)
    {
        Name = name;
        Characteristics = characteristics;
    }

    public abstract void Sound();
    public void Show()
    {
        Console.WriteLine($"Device Name: {Name}");
    }
    public void Desc()
    {
        Console.WriteLine($"Description: {Characteristics}");
    }
}

public class Kettle : Device
{
    public Kettle(string name, string characteristics) : base(name, characteristics) { }

    public override void Sound()
    {
        Console.WriteLine("Kettle sound: Whistle");
    }
}

public class Microwave : Device
{
    public Microwave(string name, string characteristics) : base(name, characteristics) { }

    public override void Sound()
    {
        Console.WriteLine("Microwave sound: Beep Beep");
    }
}

public class Car : Device
{
    public Car(string name, string characteristics) : base(name, characteristics) { }

    public override void Sound()
    {
        Console.WriteLine("Car sound: Vroom Vroom");
    }
}

public class Steamboat : Device
{
    public Steamboat(string name, string characteristics) : base(name, characteristics) { }

    public override void Sound()
    {
        Console.WriteLine("Steamboat sound: Horn");
    }
}

public class Program
{
    public static void Main()
    {
        Device kettle = new Kettle("Electric Kettle", "Boils water quickly.");
        Device microwave = new Microwave("Microwave Oven", "Heats food efficiently.");
        Device car = new Car("Electric Car", "Eco-friendly and silent.");
        Device steamboat = new Steamboat("River Steamboat", "Used for leisure cruises.");

        kettle.Show();
        kettle.Sound();
        kettle.Desc();
        Console.WriteLine();

        microwave.Show();
        microwave.Sound();
        microwave.Desc();
        Console.WriteLine();

        car.Show();
        car.Sound();
        car.Desc();
        Console.WriteLine();

        steamboat.Show();
        steamboat.Sound();
        steamboat.Desc();
    }
}
