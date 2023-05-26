using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Services
{
    public interface IPrinterService
    {
        void InitializePrinter();
        bool PrintResult();
    }
}
