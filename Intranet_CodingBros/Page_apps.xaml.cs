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
	}
}
