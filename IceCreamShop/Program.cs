using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            List<Cone> availableCones = menu.Cones;

            // TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
            //  field.
            FlavorComparer comparer = new FlavorComparer();
            availableFlavors.Sort(comparer);

            // TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
            //  field.
            ConeComparer coneComparer = new ConeComparer();
            availableCones.Sort(coneComparer);

            availableCones.Sort((x, y) => x.Cost.CompareTo(y.Cost));

            // TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.
            foreach (var flavor in availableFlavors)
            {
                Console.WriteLine(flavor.Name);
            }
            foreach (var cone in availableCones)
            {
                Console.WriteLine($"{cone.Name}: {cone.Cost} ");
            }
        }
    }
}
