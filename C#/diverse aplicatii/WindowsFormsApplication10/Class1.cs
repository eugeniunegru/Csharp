﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication12
{
    public class BaseConverter
    {

        public string ToBase(string number, int start_base, int target_base)
        {

            int base10 = ToBase10(number, start_base);
            string rtn = FromBase10(base10, target_base);
            return rtn;

        }

        public static int ToBase10(string number, int start_base)
        {

            if (start_base < 2 || start_base > 36) return 0;
            if (start_base == 10) return Convert.ToInt32(number);

            char[] chrs = number.ToCharArray();
            int m = chrs.Length - 1;
            int n = start_base;
            int x;
            int rtn = 0;

            foreach (char c in chrs)
            {

                if (char.IsNumber(c))
                    x = int.Parse(c.ToString());
                else
                    x = Convert.ToInt32(c) - 55;

                rtn += x * (Convert.ToInt32(Math.Pow(n, m)));

                m--;

            }

            return rtn;

        }

        public static string FromBase10(int number, int target_base)
        {

            if (target_base < 2 || target_base > 36) return "";
            if (target_base == 10) return number.ToString();

            int n = target_base;
            int q = number;
            int r;
            string rtn = "";

            while (q >= n)
            {

                r = q % n;
                q = q / n;

                if (r < 10)
                    rtn = r.ToString() + rtn;
                else
                    rtn = Convert.ToChar(r + 55).ToString() + rtn;

            }

            if (q < 10)
                rtn = q.ToString() + rtn;
            else
                rtn = Convert.ToChar(q + 55).ToString() + rtn;

            return rtn;

        }

    }
}
