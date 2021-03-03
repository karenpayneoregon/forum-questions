using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Because this is a partial class the namespace needs to match
 */
namespace ClaimsLibrary.Models
{
    public partial class AllDoneCode
    {
        public override string ToString() => $"{Id,-4}{Code,-10}{Description}";

    }
}
