using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex37_delegates
{
  public  class Bonuses
    {
        public static double TenPercent(double ammount)
        {
            return ammount * 0.1;
        }
        public static double FlatTwoIfAmountMoreThanFive(double ammount)
        {
            double result;
            if (ammount >=5)
            {
                result = 2;
            }
            else
            {
                result = 0;
            }
            return result;
        }
    }
}
