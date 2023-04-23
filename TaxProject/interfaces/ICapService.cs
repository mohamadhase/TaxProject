using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxProject.interfaces
{
    public interface ICapService
    {
        decimal ApplyCap(decimal price , decimal amount);
    }
}
