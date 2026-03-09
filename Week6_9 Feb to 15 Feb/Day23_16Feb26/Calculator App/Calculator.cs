using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_App
{
	public class Calculator
	{
		public int add(int x, int y) => x + y;
		public int subtract(int x, int y) => x - y;

		public int multiply(int x, int y) => x * y;

		public double divide(int x, int y)
		{
			if (y == 0)
				throw new DivideByZeroException("Cannot divide by 0");
			return (double)x / y;
		}
	}
}
