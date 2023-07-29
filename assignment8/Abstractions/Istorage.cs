using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static Abstractions.Icompany;

namespace Abstractions
{
    public interface Istorage
    {
        void Add(Icompany company);
        Icompany GetCompany(string companyId);
        void Update(Icompany company);
        void Delete(Icompany company);

        void Add(Iindividual individual);
        Iindividual GetIndividual(string individualId);
        void Update(Iindividual individual);
        void Delete(Iindividual individual);

        List<Icompany> GetAllCompanies(); // New method to get all companies
        List<Iindividual> GetAllIndividuals(); // New method to get all individuals
    }
}
