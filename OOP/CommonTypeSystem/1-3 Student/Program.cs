﻿using System;

//  1.Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties. Override the standard methods, inherited by  System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.

//  2.Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object of type Student.

//  3.Implement the  IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) and by social security number (as second criteria, in increasing order).


class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("Gosho", "Pesho", "Maria", "000-234-234", "blv. Bulgaria 5", "0876543219", "example@examle.com", 4, Specialty.AncientHistory, University.SU, Faculty.Biology);

        Student student2 = (Student)student.Clone();

        Console.WriteLine("Student1 hashcode: {0}", student.GetHashCode());
        Console.WriteLine("Student2 hashcode: {0}", student2.GetHashCode());

        student.FirstName = "Pesho";
        Console.WriteLine(student);
        Console.WriteLine(student2);

        Console.WriteLine(student.CompareTo(student2));

    }
}

