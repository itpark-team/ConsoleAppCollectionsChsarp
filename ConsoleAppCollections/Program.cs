using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*List<Cat> cats = new List<Cat>();

            cats.Add(new Cat(10, "Ivan"));
            cats.Add(new Cat(10, "Ivan"));
            cats.Add(new Cat(3, "Tom"));
            cats.Add(new Cat(2, "Nina"));

            cats.Insert(1, new Cat(9, "Vasya"));
            
            cats.RemoveAt(2);

            for (int i = 0; i < cats.Count; i++)
            {
                Console.WriteLine(cats[i]);
            }*/

            /*Dictionary<string, int> settings = new Dictionary<string, int>();
            settings["power"] = 10;
            settings["hp"] = 15;
            settings["damage"] = 20;

            settings["power"] = 20;*/

            /*foreach (KeyValuePair<string, int> keyValuePair in settings)
            {
                Console.WriteLine(keyValuePair.Key + "   " + keyValuePair.Value);
            }*/

            /*HashSet<int> numbers = new HashSet<int>();
            Console.WriteLine(numbers.Add(10));
            Console.WriteLine(numbers.Add(10));
            Console.WriteLine(numbers.Add(5));

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }*/

            /*List<int> ints = new List<int>()
            {
                1, 1, 10
            };

            ints = ints.Distinct().ToList();

            for (int i = 0; i < ints.Count; i++)
            {
                Console.WriteLine(ints[i]);
            }*/

            /*int[] arr = new[] {3, 5, 7};
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] + 10;
            }*/


            MyGenericCollection<Cat> cats = new MyGenericCollection<Cat>();
            cats.Add(new Cat(10, "Ivan"));
            cats.Add(new Cat(10, "Ivan"));
            cats.Add(new Cat(3, "Tom"));
            cats.Add(new Cat(2, "Nina"));

            /*for (int i = 0; i < cats.GetLength(); i++)
            {
                Console.WriteLine(cats.GetElemByIndex(i));
            }*/

           
        }
    }
}