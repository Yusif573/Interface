using EveryHW.Person;

namespace EveryHW.Client;

public class ClientClass : PersonClass
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
    public string Live_adress {  get; set; }
    public string Work_adress { get; set; }
    protected ClientClass()
    {
        _id = _staticId++;
    }
    protected ClientClass(string name, string surname, uint age, string live_adress, string work_adress)
        : base(name, surname, age)
    {
        _id = _staticId++;
        Live_adress = live_adress;
        Work_adress = work_adress;
    }
    public override string ToString()
    {
        return base.ToString()+$"\nHome adress:{Live_adress}\nWork adress:{Work_adress}";
    }
}
