using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Activity
{
    internal class Validation
    {
        public void check_name(string nam)
        {
            if(nam.Length > 10 )
            {
                throw new Exception("Name Cannot be longer than 10 character ");
            }

        }
    }
}
