using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ImageCellListView.Models;
using Xamarin.Forms;

namespace ImageCellListView
{
	public partial class MyPage : ContentPage
	{
        public MyPage()
		{
			InitializeComponent();

			PopulateColorList();
		}

		private void PopulateColorList()
		{
			var imagesForListView = new ObservableCollection<ImageCellItem>()
			{
				new ImageCellItem()
				{
					IconSource = ImageSource.FromFile("twitter.png"),
					ImageText = "Twitter",
				},
				new ImageCellItem()
				{
					IconSource = ImageSource.FromFile("google.png"),
					ImageText = "Google",
				},
			};

			ImageCells.ItemsSource = imagesForListView;
		}
	}
}