using BookParser;
using NUnit.Framework;

namespace Tests
{
	[TestFixture]
	public class BookTests
	{
		[Test]
		public void ShouldCountTheTimesAWordAppears()
		{
			var book = new Book("testbook.txt");
			var countedWords = book.Words();

			Assert.That(countedWords["the"], Is.EqualTo(2));
			Assert.That(countedWords["words"], Is.EqualTo(1));
			Assert.That(countedWords["are"], Is.EqualTo(1));
			Assert.That(countedWords["in"], Is.EqualTo(1));
			Assert.That(countedWords["book"], Is.EqualTo(1));
		}
	}
}