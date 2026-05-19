using System;

public class Person
{
    public string GetName()
    {
        return "Person";
    }
}

public class Student : Person
{
    public string GetName()
    {
        return "Student";
    }

}



public abstract class Person1
{
    public abstract string GetName();
}

public class Student1 : Person1
{
    public override string GetName()
    {
        return "Student";
    }

}