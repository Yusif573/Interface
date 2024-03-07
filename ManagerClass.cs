namespace EveryHW.Worker;

public class ManagerClass : WorkerClass, IMethodForWorkers
{
    static public int _staticId { get; set; }
    public int _id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    private uint? _age;
    public uint? Age
    {
        get { return _age; }
        set
        {
            if (value is uint)
            {
                _age = value;
            }
            else
            {
                Console.WriteLine("Must be a number!");
                Console.WriteLine("Enter age:");
                Age = Convert.ToUInt32(Console.ReadLine());
            }
        }
    }
    public string Position { get; set; }
    public int Salary { get; set; }

    public ManagerClass(string name, string surname, uint age, string position, int salary)
        : base(name, surname, age, position, salary)
    {
        _id = _staticId++;
    }


    public void organize()
    {
        Console.WriteLine("Organizing something (manager)");
    }
    public void calculatSalaries()
    {
        Console.WriteLine("Calculating");
    }
    public override string ToString()
    {
        return base.ToString();
    }
}
