using System.Numerics;

namespace Problem_003
{
	class LargestPrimeFactor
	{
		BigInteger number = 600851475143;
		
		public static void Main()
		{
			new LargestPrimeFactor().GetPrimeFactors();
		}
		
		public void GetPrimeFactors()
		{
			List<int> PrimeNums = [2];
			List<int> PrimeFactors = [];
			int i = 3;
			
			while (true)
			{
				bool isPrime = true;
				foreach (int num in PrimeNums)
				{
					if (i % num == 0) 
					{
						isPrime = false;
						break;
					}
				}
				
				if (isPrime) PrimeNums.Add(i);
				
				if (number % i == 0)
				{
					number /= i;
					PrimeFactors.Add(i);
				}
				
				if (PrimeFactors.Count != 0 && PrimeFactors.Max() > number) break;
				
				i++;
			}
			
			Console.WriteLine(string.Join(", ", PrimeFactors));
		}
	}
}