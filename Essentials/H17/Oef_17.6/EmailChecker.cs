using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef_17._6
{
    class EmailChecker
    {
        private int count;

        public bool CheckAddress(string adres)
        {
            if (adres.Contains("@") == true)
            {
                if (adres.Contains(".") == true)
                {
                    for (int i = 0; i < adres.Length; i++)
                    {
                        if (adres.Substring(i, 1).Equals("@"))
                        {
                            count++;
                        }
                    }

                    if (count != 1)
                    {
                        throw new InvalidEmailException();
                    }
                    else
                    {
                        return true;
                    }

                }
                else
                {
                    throw new InvalidEmailException();
                }

            }
            else
            {
                throw new InvalidEmailException();
            }
        }
    }
}
