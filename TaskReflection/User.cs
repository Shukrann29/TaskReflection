using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskReflection;

public class User
{

    private string Id;
    private string Name;
    private string Surname;
    private static int Age;

    public void  GetFullName()
    {
        Console.WriteLine(Name+" "+Surname);
    }
    public static void ChangeAge(int age) 
    {
        Age = age;
        Console.WriteLine("Age: " + Age);
    }
  

}

