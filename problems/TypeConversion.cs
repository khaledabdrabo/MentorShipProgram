using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    public class TypeConversion
    {
        public int ConvertStringToInteger(string userAgeString)
        {
            int userAge = Convert.ToInt32(userAgeString);
            return userAge;
        }

    }

}
