using System;
					
public class Program
{
	public static void Main(string[] arg)
	{
		int[][] arr = new int[2][];
		
		arr[0] = new int[]{11,21,56,78};
		arr[1] = new int[]{42,61,37,41,59,63};
		
		for(int i=0;i<2;i++)
		{
			for(int j=0;j<arr[i].Length;j++)
			{
				Console.WriteLine(arr[i][j]+" ");
			}
			Console.WriteLine();
		}	
	}
}