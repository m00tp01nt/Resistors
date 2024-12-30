using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resistors
{
    internal class Resistor
    {
        public double value;

        public string definition;

        public Resistor(double value, string definition)
        {
            this.value = value;

            this.definition = definition;
        }

        public Resistor(double value)
        {
            this.value = value;

            this.definition = ("" + value.ToString());
        }

        public double inverseValue()
        {
            return (1 / value);
        }

        public string inverseDefinition()
        {
            return (" ( 1 / " + definition + " ) ");
        }

        override public String ToString()
        {
            return definition; 
        }
    }
}
