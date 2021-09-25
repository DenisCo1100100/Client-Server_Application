using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Client.Model;

namespace Client.ViewModel
{
	class MainWindowViewModel : ObservableObject
	{
		public ObservableCollection<Book> Books { get; set; }

		private Book _selectedBook;
		public Book SelectedBook
		{
			get { return _selectedBook; }
			set
			{
				_selectedBook = value;
				OnPropertyChanged("SelectedBook");
			}
		}

		private ImageSource _image;
		public ImageSource Image
		{
			get { return _image; }
			set
			{
				_image = value;
				OnPropertyChanged("Image");
			}
		}

		/*Commands*/

		private DelegateCommand _addCommand;
		public DelegateCommand AddBook
		{
			get
			{
				return _addCommand ??
					(_addCommand = new DelegateCommand(obj =>
					{
						Books.Add(new Book("NewBook", Image));
					}));
			}
		}

		public MainWindowViewModel()
		{
			Books = new ObservableCollection<Book>();
		}
	}
}
