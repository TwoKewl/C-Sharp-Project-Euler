
namespace Problem_007
{
	class Prime_10001
	{
		public static void Main()
		{
			int i = 10001;
			Console.WriteLine(GetPrimeNumberAt(i));
		}
		
		public static int GetPrimeNumberAt(int i)
		{
			List<int> Primes = [2];
			int j = 3;
			
			while (true) 
			{
				if (Primes.Count >= i) return Primes[Primes.Count - 1];
				
				bool isPrime = true;
				foreach (int Prime in Primes)
				{
					if (j % Prime == 0) {
						isPrime = false;
						break;
					}
				}
				
				if (isPrime)
				{
					Primes.Add(j);
				}
				
				j++;
			}
		}
	}
}