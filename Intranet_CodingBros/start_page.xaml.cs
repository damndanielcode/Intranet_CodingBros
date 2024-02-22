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

			Page_apps appsPage = new Page_apps();

			this.Content = appsPage;

		}


		



		private void Image_Loaded(object sender, RoutedEventArgs e)
		{
			Image image = sender as Image;
			if (image != null && image.Source is BitmapImage)
			{
				((BitmapImage)image.Source).CreateOptions = BitmapCreateOptions.IgnoreImageCache;
			}
		}

		private void btn_arrow_right_Click (object sender, RoutedEventArgs e)
		{
			
		}

		private void btn_tickets_Click(object sender, RoutedEventArgs e)
		{

        }
    }
}
