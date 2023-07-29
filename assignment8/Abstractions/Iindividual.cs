using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Abstractions.Icompany;


namespace Abstractions
{
    public interface Iindividual : Icontact
    {
        Icompany Employer { get; set; }
    }
}
