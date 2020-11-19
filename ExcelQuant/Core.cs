using ExcelDna.Integration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelQuant
{
    public class Core
    {
        [ExcelFunction(Name = "eqCore.Version", Description = "Runtime version")]
        public static object Version()
        {
            return true;
        }
    }
}
