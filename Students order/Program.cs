

namespace DSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> list = Console.ReadLine().Split(' ').Select(x => x).ToList();

            int numberStudents = int.Parse(input.Split(' ')[0]);
            int seatChanges = int.Parse(input.Split(' ')[1]);


            for (int i = 0; i < seatChanges; i++)
            {
                string changes = Console.ReadLine();

                string name1 = changes.Split(' ')[0];
                string name2 = changes.Split(' ')[1];

                int indexName1 = 0;
                int indexName2 = 0;

                for (int j = 0; j < list.Count; j++)
                {
                    if (list[j].ToString().Equals(name2))
                    {
                        indexName2 = j;
                    }
                }
                list.Insert(indexName2, name1);
                for (int j = 0; j < list.Count - 1; j++)
                {
                    if (list[list.Count - 1].Equals(name1))
                    {
                        indexName1 = list.Count - 1;
                    }
                    if (list[j].ToString().Equals(name1) && !list[j + 1].ToString().Equals(name2))
                    {
                        indexName1 = j;
                    }
                }
                list.RemoveAt(indexName1);
            }

            Console.WriteLine(string.Join(' ', list));
        }
    }
}