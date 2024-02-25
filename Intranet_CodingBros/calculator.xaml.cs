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





namespace Intranet_CodingBros { 

public partial class calculator : Page


{
		double calculatortext = 0.00;


		public calculator() 
		{
			InitializeComponent();
		}


		public void btn_calculate_Click(object sender, RoutedEventArgs e)
		{
		
		}

		private void txt_calculate_TextChanged(object sender, TextChangedEventArgs e)
		{

		}

		public void btn_1_CLick(object sender, RoutedEventArgs e)
		{

		}

		public void btn_2_CLick(object sender, RoutedEventArgs e)
	{
	
	}
	public void btn_3_CLick(object sender, RoutedEventArgs e)
	{
		
	}
	public void btn_4_CLick(object sender, RoutedEventArgs e)
	{
		
	}
	

	private void btn_8_Click(object sender, RoutedEventArgs e)
	{

	}

	private void btn_5_Click(object sender, RoutedEventArgs e)
	{

	}

	private void btn_6_Click(object sender, RoutedEventArgs e)
	{

	}

	private void btn_7_Click(object sender, RoutedEventArgs e)
	{

	}

	private void btn_9_Click(object sender, RoutedEventArgs e)
	{

	}

	private void btn_0_Click(object sender, RoutedEventArgs e)
	{

	}
	public class CalculationHistory
	{
		public int Reihenfolge { get; set; }
		public double Ergebnis { get; set; }
		public DateTime Uhrzeit { get; set; }
	}

		private void btn_comma_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btn_x_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btn_div_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btn_minus_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btn_plus_Click(object sender, RoutedEventArgs e)
		{

		}

		private void btn_del_Click(object sender, RoutedEventArgs e)
		{

		}
	}

}
