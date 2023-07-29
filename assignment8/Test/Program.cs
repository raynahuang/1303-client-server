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
                Name = "ABC Corporation",
                Address = "123 Main Street",
            };

            Icompany company2 = new Company
            {
                Id = "C002",
                Name = "XYZ Inc.",
                Address = "456 Broad Avenue",
            };

            storage.Add(company1);
            storage.Add(company2);

            Icompany retrievedCompany = storage.GetCompany("C001");
            if (retrievedCompany != null)
            {
                Console.WriteLine("Retrieved Company: " + retrievedCompany.Name);
            }

            company1.Name = "Updated Company";
            storage.Update(company1);

            // Test CRUD operations for individuals
            Iindividual individual1 = new Individual
            {
                Id = "I001",
                Name = "John Doe",
                Address = "789 Oak Lane",
            };

            Iindividual individual2 = new Individual
            {
                Id = "I002",
                Name = "Jane Smith",
                Address = "987 Elm Street",
            };

            storage.Add(individual1);
            storage.Add(individual2);

            Iindividual retrievedIndividual = storage.GetIndividual("I002");
            if (retrievedIndividual != null)
            {
                Console.WriteLine("Retrieved Individual: " + retrievedIndividual.Name);
            }

            individual1.Name = "Updated Individual";
            storage.Update(individual1);

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

            // Deleting company2 and individual2
            storage.Delete(company2);
            storage.Delete(individual2);
        }
    }
}
