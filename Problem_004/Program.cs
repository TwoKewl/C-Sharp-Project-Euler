
namespace Problem_004
{
	class LargestPalindromeProduct
	{
		public static void Main()
		{
			int largest = 0;
			
			for (int i = 100; i < 1000; i++)
			{
				for (int j = 100; j < 1000; j++)
				{
					if (IsPalindrome(i * j) && i * j > largest)
					{
						largest = i * j;
					}
				}
			}
			
			Console.WriteLine(largest);
		}
		
		public static bool IsPalindrome(int number)
		{
			string num = number.ToString();
			char[] chars = num.ToCharArray();
			Array.Reverse(chars);
			string reversed = new(chars);
			
			if (reversed == num)
			{
				return true;
			}
			
			return false;
		}
	}
}