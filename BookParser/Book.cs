using System;
using System.Collections.Generic;
using System.IO;

namespace BookParser
{
	public class Book
	{
		string _filePath;
		string[] _words;
		Dictionary<string, int> _countedWords;

		public Book(string filePath)
		{
			_filePath = filePath;
			_countedWords = new Dictionary<string, int>();
			ReadFile();
		}

		public Dictionary<string, int> Words()
		{
			foreach (var word in _words)
			{
				SetWordCount(_countedWords, word);
			}

			return _countedWords;
		}

		private void ReadFile()
		{
			var text = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + _filePath);
			_words = text.Split(' ');
		}

		private static void SetWordCount(Dictionary<string, int> countedWords, string word)
		{
			word = word.ToLower();

			if (!countedWords.ContainsKey(word))
				countedWords.Add(word, 1);
			else
				countedWords[word] = countedWords[word] + 1;
		}
	}
}