using System;
class Student: Person
{
    private string StudentID;

    public Student(string name,string address,string citizenID,string studentID)
    : base(name,address,citizenID)
    {
        this.StudentID = studentID;
    }
    public string GetStudentID()
    {
        return this.StudentID;
    }
    

}