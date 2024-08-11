
namespace Problem_002
{
	class EvenFibonacciNumbers
	{
		public static void Main()
		{
			List<int> EvenFibonacciNums = [];
			int i = 1;
			
			while (true)
			{
				int f = Fibonacci(i);
				if (f > 4000000) break;
				if (f % 2 == 0) EvenFibonacciNums.Add(f);
				i += 1;
			}
			
			Console.WriteLine(EvenFibonacciNums.Sum());
		}
		
		public static int Fibonacci(int n)
		{
			if (n < 2) return n;
			
			return Fibonacci(n - 1) + Fibonacci(n - 2);
		}
	}
}