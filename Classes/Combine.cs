using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Resistors
{
    internal static class Combine
    {
        // Equivalent resistance of resistors in series
        public static Resistor inSeries(Resistor a, Resistor b)
        {
            Resistor series;

            double value = (a.value + b.value);
            string definition = (" ( " + a.definition + " - " + b.definition + " ) ");

            series = new Resistor(value, definition);

            return series;
        }

        // Equivalent resistance of parallel resistors
        public static Resistor inParallel(Resistor a, Resistor b)
        {

            if (a.value <= 0)
            {
                throw new ArgumentException("Resistor a has a value of { " + a.value + " }, and a definition of { " + a.definition + " }");
            }
            if (b.value <= 0)
            {
                throw new ArgumentException("Resistor b has a value of { " + b.value + " }, and a definition of { " + b.definition + " }");
            }

            Resistor parallel;

            double value = (1 / (a.inverseValue() + b.inverseValue()));
            string definition = (" ( " + a.definition + " | " + b.definition + " ) ");

            parallel = new Resistor(value, definition);

            return parallel;
        }

        // Difference of Squares between two resistor values
        public static double difference(Resistor a, Resistor b)
        {
            return Math.Abs((a.value * a.value) - (b.value * b.value));
        }

        // Loads all possible equivalent resistance values into the table
        public static void findAllCombinations(ResistorCollection table, List<Resistor> resistors)
        {
            // Base Case
            // If the number of given resistors is 
            if (resistors.Count == 1)
            {
                table.Add(resistors[0]);
                return;
            }

            // Recursive Case
            for (int i = 0; i < resistors.Count; i++)
            {

                for (int j = i; j < resistors.Count; j++)
                {

                    // Add these resistors to the table
                    table.Add(resistors[i]);
                    table.Add(resistors[j]);

                    // Can't combine the same resistor with itself
                    if (resistors[i] == resistors[j])
                    {
                        continue;
                    }

                    // Make a copy of the list, and manipulate the list like so.
                    List<Resistor> copy = new List<Resistor>(resistors);

                    // Remove them from the copy
                    copy.RemoveAt(Math.Max(i, j));
                    copy.RemoveAt(Math.Min(i, j));

                    // Add the series equivalent to the copy.
                    Resistor series = Combine.inSeries(resistors[i], resistors[j]);
                    copy.Add(series);

                    // Add the series equivalent to the table.
                    table.Add(series);

                    // Recursion.
                    findAllCombinations(table, copy);

                    // Remove the series equivalent from the list.
                    copy.RemoveAt(copy.Count - 1);

                    // Add the parallel equivalent to the list
                    Resistor parallel = Combine.inParallel(resistors[i], resistors[j]);

                    // Add the parallel equivalent to the copy
                    copy.Add(parallel);

                    // Add the parallel equivalent to the table
                    table.Add(parallel);

                    // Recursion.
                    findAllCombinations(table, copy);
                }

            }

        }
    }
}
