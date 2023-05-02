/*Console.WriteLine("Your Position :");
string Position = Console.ReadLine();
Console.WriteLine("Your Salary :");
float Salary = float.Parse(Console.ReadLine());
if (Position == "Assistant Developer")
    
{
    Console.WriteLine("Salary Increase : {0}" , Salary *= 1.05f);
}
else if (Position == "IT Support")
{
    float sal = (float)(Salary * 0.07);
    Console.WriteLine("Salary Increase : {0}", sal + Salary);
}
else if (Position == "Senior Developer")
{
    float sal = (float)(Salary * 0.10);
    Console.WriteLine("Salary Increase : {0}", sal + Salary);
}
else if (Position == "Administrator")
{
    float sal = (float)(Salary * 0.08);
    Console.WriteLine("Salary Increase : {0}", sal + Salary);
}
else
{
    float sal = (float)(Salary * 0.03);
    Console.WriteLine("Salary Increase : {0}", sal + Salary);
}*/
/*int num = 0;
while (num <= 5)
{
    ++num;
    Console.WriteLine(num);
}*/


/*for (int i = 0;i<=5;i++)
{
    Console.WriteLine(i);
}*/

/*string name = "Karn";
foreach(char charactor in name)
{
    Console.WriteLine(charactor);
}*/

/*string[] cars = new string [] {"Ford","Toyota"};
Array.Resize(ref cars, 2);
cars[1] = "BMW";
foreach (string car in cars)
{
    Console.WriteLine(car);
}*/

/*List<int> ListName = new List<int>();
foreach (int n in ListName)
{
    Console.WriteLine(n);
}
ListName.Add(1);
foreach (int n in ListName)
{
    Console.WriteLine(n);
}*/



/*using System;
class Program
{
    static void Main(string[] args)
    {
        string[] StudentId = {}
        Console.Write("Number of Student: ");
        int numStudents = int.Parse(Console.ReadLine());
        for (int i = 1; i <= numStudents; i++)
        {
            Console.Write($"Student ID : ");
            string studentId = Console.ReadLine();
            Console.Write($"score : ");
            int score = int.Parse(Console.ReadLine());
            Console.WriteLine($" Student ID {studentId} Score is {score}");
        }
        while (true)
        {
            Console.Write("Exit? : ");
            string input = Console.ReadLine();
            if (input == "Y")
            {
                Console.WriteLine($"All Student? : {numStudents}");
                Console.WriteLine($"Student ID  is : {studentId[i]}");
                break;
            }
            else if (input == "N")
            {
                Main(args);
                break;
            }
        }
    }
}*/

/*class person
{
    private string name;
    private string Age;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Age
    {
        get { return Age; }
        set { Age = value; }
    }
}
class progeam
{
    public static void Main()
    {
        person P1 = new person();
        P1.Name = "Karn";
        P1.Age = 20;
        Console.WriteLine(P1.Name);
        Console.WriteLine(P1.Age);
        person P2 = new person();
        P2.Name = "Tong";
        P2.Age = 21;
        Console.WriteLine(P2.Name);
        Console.WriteLine(P2.Age);
    }
}*/

/*class calculator
{
    private int Num1;
    private int Num2;
    public calculator(int num1,int num2)
    /*public double Add (double num1 , double num2)
    {
        return num1 + num2;
    }
    public int Add (int num1 , int num2 , int num3)
    {
        return (num1 + num2) + num3;
    }*/
//}


/*class Program
{
    public static void Main();
}*/
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void Introduce()
    {
        Console.WriteLine($"My name is {Name} and I am {Age} years old.");
    }
}

class Student : Person
{
    public int StudentID { get; set; }

    public void Study()
    {
        Console.WriteLine("I am studying.");
    }

    public Student(string name, int age, int studentID)
    {
        Name = name;
        Age = age;
        StudentID = studentID;
    }
}

class Program
{
    static void Main(string[] args)
    {

        Student student1 = new Student("Karn", 20, 001);


        student1.Introduce();
        student1.Study();
    }
}