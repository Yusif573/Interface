namespace EveryHW.Person;

public abstract class PersonClass
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
    protected PersonClass()
    {
        _id = _staticId++;
    }
    protected PersonClass(string name,string surname, uint age)
        : this()
    {
        Name = name;
        Surname = surname;
        Age = age;
    }
    public override string ToString()
    {
        return $"Id:{_id}\nName:{Name}\nSurname:{Surname}Age:{Age}";
    }
}
