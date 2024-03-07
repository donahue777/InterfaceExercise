using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface ICompany
    {
        public string Make { get; set; }
        public bool LegalCompliance { get; set; }
    }
}
