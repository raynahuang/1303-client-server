using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstractions;

namespace ContactStore
{
    public class Storage : Istorage
    {
        private List<Icompany> companies;
        private List<Iindividual> individuals;
        private int size;
        private int growthFactor;

        public Storage(int size, int growthFactor)
        {
            this.size = size;
            this.growthFactor = growthFactor;
            companies = new List<Icompany>();
            individuals = new List<Iindividual>();
        }

        public void Add(Icompany company)
        {
            companies.Add(company);
            if (companies.Count == size)
            {
                size *= growthFactor;
            }
        }

        public Icompany GetCompany(string companyId)
        {
            return companies.Find(c => c.Id == companyId);
        }

        public void Update(Icompany company)
        {
            int index = companies.FindIndex(c => c.Id == company.Id);
            if (index != -1)
            {
                companies[index] = company;
            }
        }

        public void Delete(Icompany company)
        {
            companies.Remove(company);
        }

        public void Add(Iindividual individual)
        {
            individuals.Add(individual);
            if (individuals.Count == size)
            {
                size *= growthFactor;
            }
        }

        public Iindividual GetIndividual(string individualId)
        {
            return individuals.Find(i => i.Id == individualId);
        }

        public void Update(Iindividual individual)
        {
            int index = individuals.FindIndex(i => i.Id == individual.Id);
            if (index != -1)
            {
                individuals[index] = individual;
            }
        }

        public void Delete(Iindividual individual)
        {
            individuals.Remove(individual);
        }

        public List<Abstractions.Icompany> GetAllCompanies()
        {
            return companies;
        }

        public List<Abstractions.Iindividual> GetAllIndividuals()
        {
            return individuals;
        }
    }
}
