using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Client.Model
{
	class Book
	{
		public string Name { get; private set; }
		public ImageSource Image { get; private set; }

		public Book(string name, ImageSource image)
		{
			Name = name;
			Image = image;
		}
	}
}
