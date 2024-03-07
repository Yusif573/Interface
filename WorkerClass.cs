using EveryHW.Person;

namespace EveryHW.Worker;

public abstract class WorkerClass : PersonClass
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
    public string Position {  get; set; }
    public int Salary {  get; set; }
    protected WorkerClass()
    {
        _id = _staticId++;
    }
    protected WorkerClass(string name, string surname, uint age, string position, int salary)
        : base(name, surname, age)
    {
        _id = _staticId++;
        Position = position;
        Salary = salary;
    }
    public override string ToString()
    {
        return base.ToString()+$"\nPosition:{Position}\nSalary:{Salary}";
    }
}
