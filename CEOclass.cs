namespace EveryHW.Worker;

public class CEOclass : WorkerClass, IMethodForWorkers
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
    protected CEOclass()
    {
        _id = _staticId++;
    }
    protected CEOclass(string name, string surname, uint age, string position, int salary)
        : base(name, surname, age, position, salary)
    {
        _id = _staticId++;

    }

    public void organize()
    {
        Console.WriteLine("Im organizing something (ceo)");
    }
    public void makeMeeting()
    {
        Console.WriteLine("BiBup answer the call");
    }
    public void decreasePercentage(int percent)
    {
        Console.WriteLine("Something is decreasing idc");
    }
    public override string ToString()
    {
        return base.ToString();
    }
}
