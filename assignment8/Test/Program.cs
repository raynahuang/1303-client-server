using System;
using Abstractions;
using ContactStore;
using Models;


namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize the Storage with initial size and growth factor
            Istorage storage = new Storage(10, 2);

            // Test CRUD operations for companies
            Icompany company1 = new Company
            {
                Id = "C001",
                Name = "APPE Corporation",
                Address = "1233 Main Street",
            };

            Icompany company2 = new Company
            {
                Id = "C002",
                Name = "XEZ Inc.",
                Address = "4156 Broad Avenue",
            };

            storage.Add(company1);
            storage.Add(company2);

            Icompany retrievedCompany = storage.GetCompany("C001");
            Console.WriteLine("Retrieved Company: " + retrievedCompany.Name);

            // Test CRUD operations for individuals
            Iindividual individual1 = new Individual
            {
                Id = "I001",
                Name = "Bobby Ken",
                Address = "789 Oak Lane",
            };

            Iindividual individual2 = new Individual
            {
                Id = "I002",
                Name = "Ellen Fmith",
                Address = "987 Elm Street",
            };

            storage.Add(individual1);
            storage.Add(individual2);

            Iindividual retrievedIndividual = storage.GetIndividual("I002");
            Console.WriteLine("Retrieved Individual: " + retrievedIndividual.Name);

            // List all entries in the storage
            Console.WriteLine("\nList of Companies:");
            foreach (var company in storage.GetAllCompanies())
            {
                Console.WriteLine(company.Name);
            }

            Console.WriteLine("\nList of Individuals:");
            foreach (var individual in storage.GetAllIndividuals())
            {
                Console.WriteLine(individual.Name);
            }
        }
    }
}