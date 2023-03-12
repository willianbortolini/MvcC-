﻿using ExercicioEnum.Entities.Enums
using System.Collections.Generic;

namespace ExercicioEnum.Entities
{
    internal class Worker
    {
        public String Name { get; set; }
        public WorkerLever Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>;
        
        public Worker()
        {

        }

        public Worker(string name, WorkerLever level, double baseSalary, Departament department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach(HourContract contract in Contracts)
            {
                if(contract.Date.Year ==  year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
        }
    }
}
