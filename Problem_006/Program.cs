
namespace Problem_006
{
	class SumSquareDifference
	{
		public static void Main()
		{
			int max = 100;
			
			Console.WriteLine(SquareOfSum(max) - SumOfSquares(max));
		}
		
		public static int SquareOfSum(int max)
		{
			int num = 0;
			
			for (int i = 1; i <= max; i++)
			{
				num += i;
			}
			
			return num * num;
		}
		
		public static int SumOfSquares(int max)
		{
			int num = 0;
			
			for (int i = 1; i <= max; i++)
			{
				num += i * i;
			}
			
			return num;
		}
	}
}