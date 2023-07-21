namespace YieldDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var evenNums = ProduceEvenNos(10);
            foreach(var num in ProduceEvenNos(10))
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("With yield....");
            foreach (var num in ProduceEvenNosYield(10))
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("yield and yield break...");
            //foreach (var num in ExtractPositiveNos(new[] { 1,2,3,4,5,-4, -3, -2, -1}))
            //{
            //    Console.WriteLine(num);
            //}

            var positiveNos = ExtractPositiveNos(new[] { 1, 2, 3, 4, 5, -4, -3, -2, -1 });
            foreach (var num in positiveNos)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("again...");
            foreach (var num in positiveNos)
            {
                Console.WriteLine(num);
            }

        }

        static List<int> ProduceEvenNos(int upto)
        {
            List<int> nums = new List<int>();
            for(int i = 0; i <= upto; i += 2)
            {
                nums.Add(i);
            }

            return nums; 
        }

        static IEnumerable<int> ProduceEvenNosYield(int upto)
        {
            for (int i = 0; i <= upto; i += 2)
            {
                yield return i;
            }
        }

        static IEnumerable<int> ExtractPositiveNos(IEnumerable<int> numbers)
        {
            foreach(int num in numbers)
            {
                if( num > 0)
                {
                    yield return num;
                }
                else
                {
                    yield break;
                }
            }
        }
    }
}