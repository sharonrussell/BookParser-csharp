using System;
using BookParser;

namespace BookParserExe
{
	public class Program
	{
		public static void Main()
		{
			var book = new Book("book.txt");
			Console.WriteLine(book.Words());
		}
	}
}
