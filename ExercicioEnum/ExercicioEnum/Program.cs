using ExercicioEnum.Entities;
using ExercicioEnum.Entities.Enums;
using System;
using System.Globalization;

namespace ExercicioEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level: (Junior/MidLevel/Senior): ");
            WorkerLever level = Enum.Parse<WorkerLever>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
            Departament dept = new Departament(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept );

        }
    }
}