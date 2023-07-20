namespace DSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            List<int> list = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
            var dic = new Dictionary<int, int>();
            var tempList = new List<int>();

            //List<int> result = new List<int>(N);
            var max = int.MinValue;
            for (int i = 0; i < list.Count - 1; i++)
            {
                int tempCounter = 0;
                int currentNumber = list[i];
                if (i != 0 && currentNumber == list[i - 1])
                {
                    list[i] = list[i - 1];
                    continue;
                }
                tempList.Clear();
                for (int j = i + 1; j < list.Count; j++)
                {
                    if(dic.TryGetValue(j, out int jumpsV))
                    {
                        tempCounter += jumpsV;
                        break;
                    }

                    if (currentNumber < list[j])
                    {
                        tempList.Add(list[j]);
                        currentNumber = list[j];
                        tempCounter++;
                    }
                }
                if (tempCounter > max)
                {
                    max = tempCounter;
                }
                list[i] = tempCounter;

                for (int y = 0; y < tempList.Count; y++)
                {
                    // 0 2 0 0 6 0 0 10 
                    // 
                    dic.TryAdd(tempList[y], tempCounter);
                    tempCounter--;
                }
            }
            //result.Add(0);
            list[list.Count - 1] = 0;

            Console.WriteLine(max);
            Console.WriteLine(string.Join(" ", list));
        }
    }
}