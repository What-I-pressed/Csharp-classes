
Product prod = new Product();
prod.ProductName = "Bread";
prod.IntPrice = 20;
prod.DecPrice = 79;
prod.Info();

Kettle kettle = new Kettle("Bosch Kettle", "Kettle for boiling water");
Microwave microwave = new Microwave("LG Microwave", "Microwave for heating food");
Car car = new Car("Audi A4", "Passenger car");
Steamship steamship = new Steamship("Titanic", "Large steamship");
kettle.Show();
kettle.Desc();
kettle.Sound();
microwave.Show();
microwave.Desc();
microwave.Sound();
car.Show();
car.Desc();
car.Sound();
steamship.Show();
steamship.Desc();
steamship.Sound();

Violin violin = new Violin("Stradivarius Violin", "A famous and valuable violin.", "Handcrafted by Antonio Stradivari.");
Trombone trombone = new Trombone("Yamaha Trombone", "A brass wind instrument.", "Invented in Germany.");
Ukulele ukulele = new Ukulele("Kala Ukulele", "A small, four-stringed instrument.", "Derived from the Portuguese machete");
Cello cello = new Cello("Montagnana Cello", "A large, bowed string instrument.", "Made by the Venetian luthier Domenico Montagnana");
violin.Show();
violin.Desc();
violin.HistoryInfo();
violin.Sound();
trombone.Show();
trombone.Desc();
trombone.HistoryInfo();
trombone.Sound();
ukulele.Show();
ukulele.Desc();
ukulele.HistoryInfo();
ukulele.Sound();
cello.Show();
cello.Desc();
cello.HistoryInfo();
cello.Sound();

President president = new President("Vova Puzyrok", 1001, "Finance");
Security security = new Security("Roma Shpak", 2001, "Level 3");
Manager manager = new Manager("Kolay Vitaliovych", 3001, "Sales");
Engineer engineer = new Engineer("Dima Frukt", 4001, "Software Development");
president.Print();
security.Print();
manager.Print();
engineer.Print();

class Money
{
    private int intPrice;
    private int decPrice;

    public int IntPrice
    {
        get { return intPrice; }
        set { intPrice = value; }
    }

    public int DecPrice
    {
        get { return decPrice; }
        set { decPrice = value; }
    }

    public void Price()
    {
        Console.WriteLine($"Price : {IntPrice}.{decPrice}");
    }
}

class Product : Money
{
    private string productName;

    public void ReducePrice(int intReduceBy = 0, int decReduceBy = 0)
    {
        IntPrice -= intReduceBy;
        DecPrice -= decReduceBy;
    }

    public string ProductName
    {
        get { return productName; }
        set { productName = value; }
    }

    public void Info()
    {
        Console.WriteLine($"Product : {productName}");
        base.Price();
    }
}

class Device
{
    private string name;
    private string description;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Description
    {
        get { return description; }
        set { description = value; }
    }

    public Device(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public virtual void Sound()
    {
    }

    public void Show()
    {
        Console.WriteLine($"Device Name: {Name}\n");
    }

    public void Desc()
    {
        Console.WriteLine($"Device Description: {Description}\n");
    }
}

class Kettle : Device
{
    public Kettle(string name, string description) : base(name, description)
    {
    }

    public override void Sound()
    {
        Console.WriteLine("Sounds of boiling water*");
    }
}

class Microwave : Device
{
    public Microwave(string name, string description) : base(name, description)
    {
    }

    public override void Sound()
    {
        Console.WriteLine("Microwave sounds*");
    }
}

class Car : Device
{
    public Car(string name, string description) : base(name, description)
    {
    }

    public override void Sound()
    {
        Console.WriteLine("Sounds of engine*");
    }
}

class Steamship : Device
{
    public Steamship(string name, string description) : base(name, description)
    {
    }

    public override void Sound()
    {
        Console.WriteLine("Sounds of steam engine*");
    }
}


class MusicalInstrument
{
    private string name;
    private string description;
    private string history;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Description
    {
        get { return description; }
        set { description = value; }
    }

    public string History
    {
        get { return history; }
        set { history = value; }
    }

    public MusicalInstrument(string name, string description, string history)
    {
        Name = name;
        Description = description;
        History = history;
    }

    public virtual void Sound()
    {
    }

    public void Show()
    {
        Console.WriteLine($"Musical Instrument Name: {Name} \n");
    }

    public void Desc()
    {
        Console.WriteLine($"Description of the Musical Instrument: {Description} \n");
    }

    public void HistoryInfo()
    {
        Console.WriteLine($"History of the Musical Instrument: {History} \n");
    }
}

class Violin : MusicalInstrument
{
    public Violin(string name, string description, string history) : base(name, description, history)
    {
    }

    public override void Sound()
    {
        Console.WriteLine("The violin produces beautiful melodious tones.");
    }
}

class Trombone : MusicalInstrument
{
    public Trombone(string name, string description, string history) : base(name, description, history)
    {
    }

    public override void Sound()
    {
        Console.WriteLine("The trombone has a deep and brass-like sound.");
    }
}

class Ukulele : MusicalInstrument
{
    public Ukulele(string name, string description, string history) : base(name, description, history)
    {
    }

    public override void Sound()
    {
        Console.WriteLine("The ukulele has a bright and cheerful sound.");
    }
}

class Cello : MusicalInstrument
{
    public Cello(string name, string description, string history) : base(name, description, history)
    {
    }

    public override void Sound()
    {
        Console.WriteLine("The cello produces a rich and warm tone.");
    }
}

abstract class Worker
{
    private string name;
    private int employeeId;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int EmployeeId
    {
        get { return employeeId; }
        set { employeeId = value; }
    }

    public Worker(string name, int employeeId)
    {
        Name = name;
        EmployeeId = employeeId;
    }

    public abstract void Print();
}

class President : Worker
{
    private string department;

    public string Department
    {
        get { return department; }
        set { department = value; }
    }

    public President(string name, int employeeId, string department) : base(name, employeeId)
    {
        Department = department;
    }

    public override void Print()
    {
        Console.WriteLine($"President: {Name}, Employee ID: {EmployeeId}, Department: {Department}\n");
    }
}

class Security : Worker
{
    private string securityClearance;

    public string SecurityClearance
    {
        get { return securityClearance; }
        set { securityClearance = value; }
    }

    public Security(string name, int employeeId, string securityClearance) : base(name, employeeId)
    {
        SecurityClearance = securityClearance;
    }

    public override void Print()
    {
        Console.WriteLine($"Security: {Name}, Employee ID: {EmployeeId}, Security Clearance: {SecurityClearance}\n");
    }
}

class Manager : Worker
{
    private string department;

    public string Department
    {
        get { return department; }
        set { department = value; }
    }

    public Manager(string name, int employeeId, string department) : base(name, employeeId)
    {
        Department = department;
    }

    public override void Print()
    {
        Console.WriteLine($"Manager: {Name}, Employee ID: {EmployeeId}, Department: {Department}\n");
    }
}

class Engineer : Worker
{
    private string specialization;

    public string Specialization
    {
        get { return specialization; }
        set { specialization = value; }
    }

    public Engineer(string name, int employeeId, string specialization) : base(name, employeeId)
    {
        Specialization = specialization;
    }

    public override void Print()
    {
        Console.WriteLine($"Engineer: {Name}, Employee ID: {EmployeeId}, Specialization: {Specialization}\n");
    }
}