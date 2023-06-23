using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp.Classes
{
    public interface IStudent
    {
        int Id { get; set; }
        string Name { get; set; }
        int RollNo { get; set; }

        List<string> GetCourses(int id);
    }

    public interface IProfessor
    {
        int ProfessorID { get; set; }
        string Subject { get; set; }
        string Department { get; set; }
        List<string> GetCourses(int id);
    }

    public class Student : IStudent, IProfessor
    {
        int IStudent.Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IStudent.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IStudent.RollNo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IProfessor.ProfessorID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IProfessor.Subject { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IProfessor.Department { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        List<string> IStudent.GetCourses(int id)
        {
            throw new NotImplementedException();
        }

        List<string> IProfessor.GetCourses(int id)
        {
            throw new NotImplementedException();
        }
    }

    //public class ClassA
    //{
    //    public int Id { get; set; }
    //}

    //public class ClassB
    //{ 
    //    public int Id { get; set; } 
    //}

    //public class ClassC : ClassA, ClassB
    //{

    //}
}
