namespace Exercise_0519_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            Console.WriteLine(s.GetName());
            Person p = s;
            Console.WriteLine(p.GetName());



            Student1 s1 = new Student1();
            Console.WriteLine(s1.GetName());
            Person1 p1 = s1;
            Console.WriteLine(p1.GetName());


        }
    }
}