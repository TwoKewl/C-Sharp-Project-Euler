
namespace Problem_005
{
	class SmallestMultiple
	{
		public static void Main()
		{
			int i = 1;
			
			while (true)
			{
				bool isDivisable = true;
				
				for (int j = 20; j > 1; j--)
				{
					if (i % j != 0) 
					{
						isDivisable = false;
						break;
					}
				}
				
				if (isDivisable)
				{
					Console.WriteLine(i);
					return;
				}
				
				i += 1;
			}
		}
	}
}