﻿using System;

//  4.Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. Override ToString() to display the information of a person and if age is not specified – to say so. Write a program to test this functionality.

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person("Gosho", 23);
        Console.WriteLine(person);

        Person person2 = new Person("Pesho");
        Console.WriteLine(person2);
    }
}
