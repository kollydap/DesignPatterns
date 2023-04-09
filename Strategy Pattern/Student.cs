using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy_Pattern
{
    public interface IGetStudentBehavior
    {
        void getStudent();
    }

    public class BinarySearchStudent : IGetStudentBehavior
    {
        public void getStudent()
        {
            Console.WriteLine("Binary Search Student..........");

            //Performs Binary Searchhhhhh
            return;
        }
    }
    public class LinearSearchStudent : IGetStudentBehavior
    {
        public void getStudent()
        {
            Console.WriteLine("Linear Search Student..........");

            //Performs Binary Searchhhhhh
            return;
        }
    }
    public class Student
    {
      
        private  IGetStudentBehavior getStudentBehavior;
        public int Id { get; set; }
        public String Name { get; set; }
        public  static List<Student> studentsList;
        public Student(IGetStudentBehavior studentBehavior)
        {
            this.getStudentBehavior = studentBehavior;
        }

        public void performSearch()
        {
            getStudentBehavior.getStudent();
        }
     
    }
}
