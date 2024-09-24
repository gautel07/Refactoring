using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VivesBlog
{
	public class Article
	{
		[Key]
		public int Key { get; set; }
		[Required]
		public string Title { get; set; }
		[Required]
		public string Description { get; set; }
		[Required]
		public string Content { get; set; }
		[Required]
		public int AuthorId { get; set; }
		public Person Author { get; set; }
		public DateTime CreatedDate { get; set; }
	}

	public class ArticleModel
	{
		public Article Article { get; set; }
		public IList<Person> Authors { get; set; }
	}
	public class Person
	{
		public Person()
		{
			Articles = new List<Article>();
		}
		public int Id { get; set; }

		[Required]
		public string Name1 { get; set; }

		[Required]
		public string Name2 { get; set; }

		public IList<Article> Articles { get; set; }
	}
}
