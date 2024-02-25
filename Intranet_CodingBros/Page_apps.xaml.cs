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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Intranet_CodingBros
{
	/// <summary>
	/// Interaktionslogik für Page_apps.xaml
	/// </summary>
	public partial class Page_apps : Page
	{
		public Page_apps()
		{
			InitializeComponent();
		}

		private void btn_earnings_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Fehler. Sie verfügen über nicht genügende Berechtigungen.");
        }

	
		private void btn_salarys_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Fehler. Sie verfügen über nicht genügende Berechtigungen.");
		}

		private void btn_To_Do_Click(object sender, RoutedEventArgs e)
		{
			TodoPage todoPage = new TodoPage();
			Window todoWindow = new Window
			{
				Title = "To Do Page",
				Content = todoPage,
				Width = 1920,
				Height = 1080,
				WindowState = WindowState.Maximized
			};

			todoWindow.Show();
		}

		private void appsFrame_Navigated(object sender, NavigationEventArgs e)
		{

		}

		private void btn_calculator_Click(object sender, RoutedEventArgs e)
		{
			calculator calculatorPage = new calculator();

			Window calculatorWindow = new Window
			{
				Content = calculatorPage,
				Title = "Calculator",

				WindowState = WindowState.Maximized
			};

			calculatorWindow.Show();


		}
    }
}
