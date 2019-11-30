using System;
using System.Collections.Generic;
					
public class Fibonacci
{
	public List<int> Function(int x)
	{
		int a = 0;
		int b = 1;
		var data = new List<int>();
		do
		{
			data.Add(a);
			data.Add(b);
			a = a + b;
			if(a == x)
			{
				data.Add(a);
				break;
			}else
			{
				b = a + b;
			}
		}while(a <= x);
		return data;
	}
}

public class FirstTry
{
	public static void Main()
	{
		Fibonacci obj = new Fibonacci();
		List<int> result = obj.Function(1555);
		foreach(var i in result)
		{
			Console.WriteLine(i);
		}
	}
}
