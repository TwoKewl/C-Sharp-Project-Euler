
namespace Problem_001
{
	class MultiplesOf3Or5
	{
		public static void Main()
		{
			List<int> numbers = [];
			
			for (int i = 1; i < 1000; i++)
			{
				if (i % 3 == 0 || i % 5 == 0)
				{
					numbers.Add(i);
				}
			}
			
			Console.WriteLine(numbers.Sum());
		}
	}
}