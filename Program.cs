using System;

namespace ClassesAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
        
        //    Student students = new Student("Ekene", "Anolue");
        //    students.printFullName();

        // Student stu = new Student();
        // stu.addNumbers(10, 30);

        // Student student1 = new Student("Atolagbe", "Muiz", 32, "London, UK", "+1(0) 4809 92100" );
        // student1.printStudentDetails();

        // Student student2 = new Student("Sam", "Allardyce", 56, "Lagos, Nigeria", "08047830678" );
        // student2.printStudentDetails();

          Triangle triangle = new Triangle();
          triangle.areaOfTriangle(23, 34);

          Triangle perimeterOfTriangle = new Triangle();
          perimeterOfTriangle.perimeter(23, 34, 20);

        }
    }


    public class Student
    { 
        // string _firstName;

        // string _lastName;

        // public Student(string firstName, string lastName)
        // {
        //     _firstName = firstName;
        //     _lastName = lastName;
        // }
        
        // public void printFullName()
        // {
        //     System.Console.WriteLine("The FullName is " + _firstName + " " + _lastName);
        // }

        // public void addNumbers(int firstNumber, int secondNumber)
        // {
        //     // int firstNumber = 10;
        //     // int secondNumber = 20;

        //     int result = firstNumber + secondNumber;
        //     System.Console.WriteLine(result);
        // }


         string _firstName;

        string _lastName;

        int _rollNo;

        string _address;
        string _telephone;

        public Student(string firstName, string lastName, int rollNo, string address, string Tel)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._rollNo = rollNo;
            this._telephone = Tel;
            this._address = address;
        }
        
        public void printStudentDetails()
        {
            System.Console.WriteLine("The FullName is " + _firstName + " " + _lastName + " Address is " + _address+ " , " + " Telephone Number is " + _telephone + " , " + " Roll Number " + _rollNo);
        }
    }
}
