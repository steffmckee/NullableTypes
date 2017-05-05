using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class DatabaseReader
    {
        // Nullable data field.
        public int? numericValue = null;
        public bool? boolValue = true;

        // Note the nullable return type.
        public int? GetIntFromDatabase()
        {
            return numericValue;
        }

        // Note the nullable return type.
        public bool? GetBoolFromDatabase()
        {
            return boolValue;
        }
    }

    class Program
    {
        static void LocalNullableVariables()
        {
            int? nullableInt = 10;
            double? nullableDouble = 3.14;
            bool? nullableBool = null;
            char? nullableChar = 'a';
            int?[] arrayofNullableInts = new int?[10];
        }

        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Nullable Data *****\n");

            DatabaseReader dr = new DatabaseReader();

            int? i = dr.GetIntFromDatabase();
            if (i.HasValue)
            {
                Console.WriteLine("Value of 'i' is {0}", i.Value);
            }
            else
            {
                Console.WriteLine("Value of 'i' is undefined.");
            }

            bool? b = dr.GetBoolFromDatabase();
            if (b != null)
            {
                Console.WriteLine("Value of 'b' is {0}", b.Value);
            }
            else
            {
                Console.WriteLine("Value of 'b' is undefined.");
            }

            // If the value from GetIntFromDatabase() is null,
            // assign local variable to 100.
            int myData = dr.GetIntFromDatabase() ?? 100;
            Console.WriteLine("Value of myData: {0}", myData);

            Console.ReadLine();
        }
    }
}
