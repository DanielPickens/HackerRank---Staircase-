using System;

public class Test
{
	public static void Main()
	{
		var cnt = Convert.ToInt32(Console.ReadLine());
var message = string.Empty;
for (int i = 1; i <= cnt; i++)
{
    Console.WriteLine("{0,"+cnt+"}", message += "#");
}
	}
}
