namespace RepeatedElement
{
    internal class Program
    {
			static void Main(string[] args)
			{
				Console.WriteLine("Enter size of array:");
				int n = Convert.ToInt32(Console.ReadLine());

				int[] arr = new int[n];
				Console.WriteLine("Enter array elements:");
				for (int i = 0; i < n; i++)
				{
					arr[i] = Convert.ToInt32(Console.ReadLine());
				}

				int maxCount = 0;

				for (int i = 0; i < n; i++)
				{
					int count = 1;
					for (int j = i + 1; j < n; j++)
					{
						if (arr[i] == arr[j])
							count++;
					}

					if (count > maxCount)
						maxCount = count;
				}

			
				int resultSize = 0;
				for (int i = 0; i < n; i++)
				{
					int count = 1;
					bool alreadyChecked = false;

					for (int k = 0; k < i; k++)
					{
						if (arr[i] == arr[k])
							alreadyChecked = true;
					}

					if (alreadyChecked)
						continue;

					for (int j = i + 1; j < n; j++)
					{
						if (arr[i] == arr[j])
							count++;
					}

					if (count == maxCount)
						resultSize++;
				}

				
				int[] output = new int[resultSize];
				int index = 0;

				for (int i = 0; i < n; i++)
				{
					int count = 1;
					bool alreadyChecked = false;

					for (int k = 0; k < i; k++)
					{
						if (arr[i] == arr[k])
							alreadyChecked = true;
					}

					if (alreadyChecked)
						continue;

					for (int j = i + 1; j < n; j++)
					{
						if (arr[i] == arr[j])
							count++;
					}

					if (count == maxCount)
					{
						output[index] = arr[i];
						index++;
					}
				}

				Console.WriteLine("Output array:");
				for (int i = 0; i < output.Length; i++)
				{
					Console.Write(output[i] + " ");
				}
			}
		}
	}



