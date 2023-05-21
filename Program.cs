using System;

class Employee
{
    public int Id { get; set; }
    public string Emri { get; set; }
    public string Pozita { get; set; }
    public decimal Rroga { get; set; }

    public virtual decimal CalculateBonus()
    {
        return 50000; // bonus fiks
    }
}

class Zhvillues : Employee
{
    public override decimal CalculateBonus()
    {
        decimal bonusi = Math.Max(50000, Rroga * 0.2m); // llogarit bonusin më të madh mes fiksit dhe 20% të rrogës
        return bonusi;
    }
}

class Menaxher : Employee
{
    public override decimal CalculateBonus()
    {
        decimal bonusi = Math.Max(50000, Rroga * 0.25m); // llogarit bonusin më të madh mes fiksit dhe 25% të rrogës
        return bonusi;
    }
}

class Admin : Employee
{
    public override decimal CalculateBonus()
    {
        return 50000; // bonus fiks
    }
}

class Program
{
    static void Main(string[] args)
    {
        // krijojme nje developer, nje menaxher dhe nje admin
        Employee dev = new Zhvillues { Id = 1, Emri = "John", Pozita = "Zhvillues", Rroga = 60000 };
        Employee man = new Menaxher { Id = 2, Emri = "Jane", Pozita = "Menaxher", Rroga = 80000 };
        Employee adm = new Admin { Id = 3, Emri = "Alice", Pozita = "Admin", Rroga = 40000 };

        // shfaqim atributet dhe bonusin e secilit punonjes
        Console.WriteLine("Zhvilluesi:");
        Console.WriteLine($"Id: {dev.Id}, Emri: {dev.Emri}, Pozita: {dev.Pozita}, Rroga: {dev.Rroga}, Bonus: {dev.CalculateBonus()}");

        Console.WriteLine("\nMenaxher:");
        Console.WriteLine($"Id: {man.Id}, Emri: {man.Emri}, Pozita: {man.Pozita}, Rroga: {man.Rroga}, Bonus: {man.CalculateBonus()}");

        Console.WriteLine("\nAdmin:");
        Console.WriteLine($"Id: {adm.Id}, Emri: {adm.Emri}, Pozita: {adm.Pozita}, Rroga: {adm.Rroga}, Bonus: {adm.CalculateBonus()}");

        Console.ReadKey();
    }
}