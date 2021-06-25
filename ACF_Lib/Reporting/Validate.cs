using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACF_Lib.Reporting
{
    public abstract class Validate
    {
        public abstract void IsTrue(Boolean values, string errorMessage);
        public abstract void IsFalse(Boolean Values, string errorMessage);
        public abstract void IsEqual(Object objOne, Object objTwo, string errorMessage);
        public abstract void IsNotEqual(Object objOne, Object objTwo, string errorMessage);
    }
}
