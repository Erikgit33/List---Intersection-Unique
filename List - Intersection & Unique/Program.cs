namespace List___Intersection___Unique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Intersection

            string[] intersectionSet1 = { "a", "b", "c", "d", "e", "k" }; // Both can be changed
            string[] intersectionSet2 = { "h", "d", "w", "s", "a", "b", "k" };
            Console.WriteLine("Demonstration of Intersection:");
            Console.WriteLine("Set 1: " + string.Join(",", intersectionSet1));
            Console.WriteLine("Set 2: " + string.Join(",", intersectionSet2));
            List<string> intersectionResult = Intersection(intersectionSet1, intersectionSet2);
            Console.WriteLine("Result: " + string.Join(",", intersectionResult));
            Console.WriteLine();

            // Unique
            string[] uniqueTestData = { "a", "y", "g", "y", "a", "n", "r", "b", "t", "n" }; // Can be changed
            Console.WriteLine("Demonstration av Unique:");
            Console.WriteLine("Testdata: " + string.Join(",", uniqueTestData));
            List<string> uniqueResult = Unique(uniqueTestData);
            Console.WriteLine("Resultat: " + string.Join(",", uniqueResult));
            Console.WriteLine();
        }
        public static List<string> Intersection(string[] set1, string[] set2)
        {
            List<string> result = new List<string>();

            for (int index = 0; index < set1.Length; index++)
            {
                for (int index2 = 0; index2 < set2.Length; index2++)
                {
                    if (set1[index] == set2[index2])
                    {
                        result.Add(set1[index]);
                    }
                }
            }
            return result;
        }

        public static List<string> Unique(string[] strings)
        {
            List<string> result = new List<string>();

            foreach (string string1 in strings)
            {
                int timesInList = 0;

                foreach (string string2 in strings)
                {
                    if (string1 == string2)
                    {
                        timesInList++;
                    }
                }

                if (timesInList == 1)
                {
                    result.Add(string1);
                }
            }
            return result;
        }
    }
}
