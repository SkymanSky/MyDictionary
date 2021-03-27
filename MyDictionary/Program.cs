using System;
using System.Collections.Generic;
using MyDictionary;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MyDictionary<string, string> studentsList = new MyDictionary<string, string>();
            studentsList.Add("1", "Ali");
            studentsList.Add("2", "Hakan");
            studentsList.Add("3", "Ayşe");

            Console.WriteLine(studentsList.GetValuesByKeys("1"));
            Console.WriteLine(studentsList.GetValuesByKeys("2"));
            Console.WriteLine(studentsList.GetValuesByKeys("3"));

        }
    }
}
