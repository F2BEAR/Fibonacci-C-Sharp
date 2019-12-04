using System;
using System.Collections.Generic;
					
public class Fibonacci
{
	public List<int> Function()
	{
		int a = 0;
		int b = 1;
		var data = new List<int>();
            
                Console.WriteLine("Enter a Number");
                int x = Convert.ToInt32(Console.ReadLine());

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

public class MainClass
{
	public static void Main()
	{
		Fibonacci obj = new Fibonacci();
		List<int> result = obj.Function();
		foreach(var i in result)
		{
			Console.WriteLine(i);
		}
	}
}
