internal class checkvalid
{
	public void find(int n, string str)
	{
		for (int i = 0; i <= str.Length-n; i++)
		{
			string ans = str.Substring(i, n);
			int count = 0;
			bool isvalid = true;
			for (int k = 0; k < ans.Length; k++)
			{
				if (ans[k] != 'P' && ans[k] != 'S' && ans[k] != 'G')
				{
					isvalid = false;
					break;
				}
			}
			if (isvalid == false)
				continue;
				
			for (int j = 0; j < ans.Length - 1; j++)
			{
				if ((ans[j] == 'P' && ans[j + 1] == 'P') ||
					(ans[j] == 'S' && ans[j + 1] == 'S') ||
					(ans[j] == 'G' && ans[j + 1] == 'G'))
				{
					count++;
				}
			}
			if (count >= n / 2)
			{
				Console.WriteLine("Valid");
				return;
			}
		}

		Console.WriteLine("Invalid");
	}
}
