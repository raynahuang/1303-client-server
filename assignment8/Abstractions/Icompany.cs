using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Abstractions
{
    public interface Icompany : Icontact
    {
        List<Iindividual> Employees { get; set; }
    }
}

