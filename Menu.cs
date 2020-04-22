using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_16._04_DayToDate
{
    public class Menu
    {
        public void InputDay()
        {
            Console.WriteLine("Enter day of year");
        }

        public void InputYear()
        {
            Console.WriteLine("Enter year");
        }

        public int ReadDay()
        {
            int day = Convert.ToInt32(Console.ReadLine());
            if (day < 1 || day > 366)
                throw new IndexOutOfRangeException("Enter correct number of day (1-366)");
            else return day;
        }

        public int ReadYear()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
