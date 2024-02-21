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
	/// Interaktionslogik für MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{

		int login_failure = 4;
		public MainWindow()
		{
			
			InitializeComponent();
		}
		

		//Skip login
		
			
			
		private void btn_login_Click(object sender, RoutedEventArgs e)
		{
			string loginname = txt_benutzer.Text;
			string password = txt_password.Password;

			string benutzer1 = "Daniel";
			string benutzer2 = "Jakob" ;
			string benutzer3 ="Benutzer" ;

			string password1 = "1111";
			string password2 = "2222";
			string password3 = "Passwort";

			bool login_granted = false;
			bool input = false;

			if (string.IsNullOrEmpty(loginname) && string.IsNullOrEmpty(password )) 
			{
				MessageBox.Show("Bitte geben Sie einen Benutzernamen und ein Passwort ein!");
				 input = true;
			}

			if (loginname == benutzer1 && password == password1)
			{
				MessageBox.Show("Willkommen " + benutzer1 + ". Sie sind nun erfolgreich eingeloggt und werden nun zur Startseite weitergeleitet.");
				login_granted = true;
			}

			if (loginname == benutzer2 && password == password2)
			{
				MessageBox.Show("Willkommen " + benutzer2 + ". Sie sind nun erfolgreich eingeloggt und werden nun zur Startseite weitergeleitet.");
				login_granted = true;
			}

			if (loginname == benutzer3 && password == password3)
			{
				MessageBox.Show("Willkommen " + benutzer3 + ". Sie sind nun erfolgreich eingeloggt und werden nun zur Startseite weitergeleitet.");
				login_granted = true;
			}

			else if(login_granted == false && input== false) 
			{ 
				login_failure -= 1;
				MessageBox.Show("Falscher Benutzername oder Passwort. " + "Sie haben noch " + login_failure + " Versuche übrig.");
			}

			if(login_failure == 0)
			{
				MessageBox.Show("Zuviele Login Versuche. Dieses Programm wird jetzt geschlossen.");
				Close();
			}

			if(login_granted == true && input ==false)
			{
				start_page win2 = new start_page();
				win2.Show();
				Close();
			}
		}

		private void btn_delete_Click(object sender, RoutedEventArgs e)
		{
			txt_benutzer.Text = "";
			txt_password.Password = "";
		}

		private void txt_benutzer_TextChanged(object sender, TextChangedEventArgs e)
		{

		}

		private void btn_forgotpw_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Aus Sicherheitsgründen kann Ihr Passwort nicht zurückgesetzt werden. Bitte wenden Sie sich an die IT von CodingBros");
		}

		
	}
}
