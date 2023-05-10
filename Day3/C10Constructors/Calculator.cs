using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C10Constructors
{
    internal class Calculator
    {

        private string mode; 

        public string Mode
        {
            get { return mode; }
            set { mode = value; }
        }

        public Calculator()
        {
            mode = "scientific";
        }

        public Calculator(string mode)
        {
            this.mode = mode;
        }

        public double Calculate(double a, double b)
        {
            if (mode == "normal")
            {
                return a + b;
            }

            if(mode == "scientific")
            {
                return a + b;
            }

            throw new Exception("unknown mode");
        }

    }
}
