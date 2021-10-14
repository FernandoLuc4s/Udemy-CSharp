using System.Collections.Generic;
using ExercresolvidoEnumeracoesEComposicao.Entities.Enums; // chamando o namespace para usar o enum

namespace ExercresolvidoEnumeracoesEComposicao.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; } // associando duas classes diferente
        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); // quando for representar o vários, usar uma lista, e já inicia ela

        public Worker() { }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract) {
            Contracts.Add(contract); // adicionando um contrato ao trabalhador
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract); // removendo um contrato ao trabalhador
        }
        public double Income(int year, int month) {
            double sum = BaseSalary; //  de toda forma o trabalhador vai ganhar esse salário

            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
