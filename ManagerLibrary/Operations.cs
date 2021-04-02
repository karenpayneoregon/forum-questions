using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerLibrary
{
    public class Operations
    {
        public static void Work(int startValue, int endValue)
        {
            Example example = new();
            example.StartValue = startValue;
            example.EndValue = endValue;
        }
    }
}
