// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Text;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the string:");
string str = Console.ReadLine(); 
       
int len = str.Length; 
Console.WriteLine("Substring of entered string:");
for(int i = 0; i < len ; i++)
{
	StringBuilder substring = new StringBuilder(len-i);
    for (int j = i; j < len; j++)
    {
		substring.Append(str[j]);
		Console.Write(substring + " ");
		}
	} 
}

}