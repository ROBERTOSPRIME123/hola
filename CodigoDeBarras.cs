/*
 * Created by SharpDevelop.
 * User: Roberto Carlos
 * Date: 21/10/2020
 * Time: 23:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CodigoBarras_014_
{
	class Program
	{
		public static void Main()
		{
			int[] num=new int[8];
			int i,tmp,val,tmp1=0,tmp2=0,n;
			for(i=0;i<8;i++)
			{
				val=8-i;
				Console.Write("Ingrese 8 numeros(numeros restantes: {0}): ",val);
				num[i]=Convert.ToInt32(Console.ReadLine());
			}
			Console.WriteLine("");
			for(i=0;i<8;i++)
			{
				tmp=num[i];
				if(((i+1)%2)==0)
				{
					tmp1=tmp1+tmp;
					//Console.Write(tmp1); = 20
				}
				else
				{
					tmp2=tmp2+tmp;
					//Console.WriteLine(tmp2);
				}
				//Console.Write(tmp);
			}
			tmp1=tmp1*3; //60
			n=10-((tmp1+tmp2)%10);
			Console.WriteLine("El codigo EAN-8 es el siguiente:");
			for(i=0;i<8;i++)
			{
				tmp=num[i];
				Console.Write(tmp + " ");
			}
			Console.WriteLine(n);
			Console.WriteLine("");
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}