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
	/// Interaktionslogik für calculator.xaml
	/// </summary>
	public partial class calculator : Page
	{

		                                                

		public calculator()
		{
			InitializeComponent();
		}

		private void btn_0_Click(object sender, RoutedEventArgs e)
		{
			txtb_calculator.Text += 0;
		}

		private void btn_1_Click(object sender, RoutedEventArgs e)
		{
			txtb_calculator.Text += 1;
		}

		private void btn_2_Click(object sender, RoutedEventArgs e)
		{
			txtb_calculator.Text += 2;
		}

		private void btn_3_Click(object sender, RoutedEventArgs e)
		{
			txtb_calculator.Text += 3;
		}

		private void btn_4_Click(object sender, RoutedEventArgs e)
		{
			txtb_calculator.Text += 4;
		}

		private void btn_5_Click(object sender, RoutedEventArgs e)
		{
			txtb_calculator.Text += 5;
		}

		private void btn_6_Click(object sender, RoutedEventArgs e)
		{
			txtb_calculator.Text += 6;
		}

		private void btn_7_Click(object sender, RoutedEventArgs e)
		{

			txtb_calculator.Text += 7;
		}
		private void btn_8_Click(object sender, RoutedEventArgs e)
		{
			txtb_calculator.Text += 8;
		}
		private void btn_9_Click(object sender, RoutedEventArgs e)
		{
			txtb_calculator.Text += 9;
		}

		private void btn_plus_Click(object sender, RoutedEventArgs e)
		{
			txtb_calculator.Text += "+";
		}

		private void txtb_calculator_TextChanged(object sender, TextChangedEventArgs e)
		{

		}
	}
}
