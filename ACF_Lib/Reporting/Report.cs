using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACF_Lib.Reporting
{
    public abstract class Report
    {
        public abstract void Success(string message);
        public abstract void Fail(string message);
        public abstract void Info(string message);
        public abstract void Warning(string message);

    }
}
