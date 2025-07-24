using System;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }

    public override bool Equals(object obj)
    {
        Student s = (Student)obj;

        if (s.Id == this.Id && s.Name == this.Name) return true;
        return false;   
    }

    public override string ToString()
    {
        return "Student Name:" + this.Name;
    }

}