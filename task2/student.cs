
namespace task1;


internal class student
{
    //fields
    public string name { get; set; }  
    public string surname { get; set; }
    public double point { get; set; }
    public string group { get; set; }
    public bool isgraduated { get; set; }

    //constructor-ilk ishe dusen kod blokudur,
    //c# class aid ile eyni adda olur,
    //yalniz instance alanda ise dusur,
    //return type yoxdur
    public student(string Name, string Surname, string Group, double Point, bool Isgraduated)
    {
        name = Name;
        surname = Surname;
        group = Group;
        point = Point;
        isgraduated = Isgraduated;
    }
    public string FullName()
    {
        return $"{name} {surname}";
    }
    public string Group()
    {
        return $"{group}";
    }
    public bool Isgraduated()
    {
        if (isgraduated)
        {
            Console.WriteLine("Mezun oldunuz");
            return true;

        }
        else
        {
            Console.WriteLine("Mezun olmadiniz");
            return false;


        }

    }
    public bool GetPoint()
    {
        if (point >= 80)
        {
            Console.WriteLine("topladiginiz bal kecerlidir");
            return true;
        }
        else
        {
            Console.WriteLine("bextinizi bir daha sinayin");
            return false;
        }
    }
}
