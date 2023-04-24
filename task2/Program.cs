
using System.Drawing;
using System.Xml;
using System.Xml.Linq;
using task1;

student stu1 = new student("Elsen", "Nesirov", "p137", 80, true);

Console.WriteLine(stu1.FullName());
Console.WriteLine(stu1.Group());
stu1.GetPoint();
stu1.Isgraduated();
