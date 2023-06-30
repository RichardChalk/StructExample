using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExample
{
    public struct TimeStruct
    {
        private int seconds;
        public int Seconds
        {
            get { return seconds; }
            set { seconds = value; }
        }

        public int CalculateMinutes()
        {
            return seconds / 60;
        }
    }

}
