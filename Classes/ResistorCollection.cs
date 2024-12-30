using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace Resistors
{
    internal class ResistorCollection
    {
        // How many digits after the decimal place matter?
        private int precision;

        public SortedDictionary<int, Resistor> table;

        /**
         * <param name="precision">How many digits after the decimal place matter?</param>
         */
        public ResistorCollection(int precision)
        {
            table = new SortedDictionary<int, Resistor>();

            this.precision = precision;
        }

        // Adds the new resistor to the table.
        // If the given resistor value is already in the table, compare the length of the resistors definition.
        // The resistor with the smaller definition gets to be in the table.
        public void Add(Resistor resistor)
        {
            int key = calculateKey(resistor);
            
            // If resistor is already in the table...
            if (table.ContainsKey(key))
            {
                Resistor existingResistor = ((Resistor)table[key]);

                int existingResistorDefinitionLength = existingResistor.definition.Length;
                int newResistorDefinitionLength = resistor.definition.Length;

                // Compare the lengths of the definitions.
                // The resistor with the smaller definition gets added / the simpler resistor gets added the table.
                if (newResistorDefinitionLength < existingResistorDefinitionLength)
                {
                    table[key] = resistor;
                }
            }
            else
            {
                table.Add(key, resistor);
            }
        }

        public bool Contains(Resistor resistor)
        {
            return table.ContainsKey(calculateKey(resistor));
        }

        public Resistor get(Resistor resistor)
        {
            int key = calculateKey(resistor);

            return get(key);
        }

        public Resistor findClosestValue(Resistor target)
        {
            double targetValue = target.value;
            Resistor closest = null;

            foreach (Resistor cursor in table.Values)
            {
                if (closest == null)
                {
                    closest = cursor;
                }
                
                if (Combine.difference(cursor, target) < Combine.difference(closest, target))
                {
                    closest = cursor;
                }
            }

            if (closest == null)
            {
                throw new Exception("Hashtable is empty");
            }

            return closest;
        }

        public SortedDictionary<int, Resistor> convertToSortedDictionary()
        {
            SortedDictionary<int, Resistor> dict = new SortedDictionary<int, Resistor>(table);

            return dict;
        }

        private Resistor get(int key)
        {
            return ((Resistor)table[key]);
        }

        private int calculateKey(Resistor resistor)
        {
            int key = (int)Math.Round((resistor.value * Math.Pow(10, precision)), 0);
            return key;
        }
    }
}
