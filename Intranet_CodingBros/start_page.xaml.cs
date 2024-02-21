using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Navigation;

namespace Intranet_CodingBros
{
	/// <summary>
	/// Interaktionslogik für start_page.xaml
	/// </summary>
	public partial class start_page : Window
	{
		public start_page()
		{
			InitializeComponent();
		}

		private void btn_apps_Click(object sender, RoutedEventArgs e)
		{
			try 
			{
				mainFrame.Navigate(new Uri("Page_apps.xaml", UriKind.Relative));
			}
			
			catch (Exception ex)
			{
				MessageBox.Show($"Error navigating to Page_apps.xaml: {ex.Message}");
			}
		}

		

		private void Image_Loaded(object sender, RoutedEventArgs e)
		{
			Image image = sender as Image;
			if (image != null && image.Source is BitmapImage)
			{
				((BitmapImage)image.Source).CreateOptions = BitmapCreateOptions.IgnoreImageCache;
			}
		}

	}
}
