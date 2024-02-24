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
	/// Interaktionslogik für TodoPage.xaml
	/// </summary>
	public partial class TodoPage : Page
	{
	

		

		public TodoPage()
		{
			InitializeComponent();
			Loaded += TodoPage_Loaded;
		}

		private void TodoPage_Loaded(object sender, RoutedEventArgs e)
		{
			Window.GetWindow(this).WindowState = WindowState.Maximized;
		}

		private void lv_Todo_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{

        }

		private void btn_add_Click(object sender, RoutedEventArgs e)
		{
			string title = txt_title.Text;
			string describtion = txt_description.Text;

			DateTime deadline = dt_deadline.SelectedDate ?? DateTime.Today;
			string employee = txt_employee.Text;

			if(!string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(describtion) && !string.IsNullOrEmpty(employee) && dt_deadline != null )
			{
				MessageBox.Show("Fehler. Textfelder dürfen nicht leer bleiben!");
			}

			

		}

		private void txt_title_TextChanged(object sender, TextChangedEventArgs e)
		{

        }

		private void txt_title_TextChanged_1(object sender, TextChangedEventArgs e)
		{

		}

		private void txt_description_TextChanged(object sender, TextChangedEventArgs e)
		{

        }
    }
}
