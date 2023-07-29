using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions
{
    public interface Icontact
    {
        string Id { get; set; }
        string Name { get; set; }
        string Address { get; set; }
        List<ContactDetail> ContactDetails { get; set; }
    }
}
