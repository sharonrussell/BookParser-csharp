using System;
using System.IO;
using BookParser;

namespace BookParserExe
{
	public class Parser
	{
		string _filePath;

		public Parser(string filePath)
		{
			_filePath = filePath;
		}

		public void Parse()
		{
			var book = new Book(_filePath);

			var countedWords = book.Words();

			foreach (var countedWord in countedWords)
			{
				Console.WriteLine($"\"{countedWord.Key}\" appears {countedWord.Value} times");
			}
		}
	}
}