using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using System.Windows.Threading;

namespace Intranet_CodingBros
{

	/// <summary>
	/// Interaktionslogik für TodoPage.xaml
	/// </summary>
	public partial class TodoPage : Page
	{
		public ObservableCollection<TodoItem> TodoItems { get; set; }

		public TodoPage()
		{
			InitializeComponent();
			TodoItems = new ObservableCollection<TodoItem>();
			lv_Todo.ItemsSource = TodoItems;
		
		}

		private void lv_Todo_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
		}

		private void txt_description_TextChanged(object sender, TextChangedEventArgs e)
		{

		}

		private void CheckBox_Click(object sender, RoutedEventArgs e)
		{
			CheckBox checkBox = sender as CheckBox;
			if (checkBox != null)
			{
				TodoItem todoItem = checkBox.DataContext as TodoItem;
				if (todoItem != null)
				{
					todoItem.IsDone = checkBox.IsChecked ?? false;
					if (todoItem.IsDone)
					{
						// Zeitpunkt des Erledigt-Markierens speichern oder weitere Aktionen ausführen
						// Hier könnte der Code stehen, um die Aufgabe nach 10 Sekunden zu löschen
						TodoItem itemToDelete = todoItem;
						DispatcherTimer deleteTimer = new DispatcherTimer();
						deleteTimer.Interval = TimeSpan.FromSeconds(10);
						deleteTimer.Tick += (senderTimer, eTimer) =>
						{
							TodoItems.Remove(itemToDelete);
							deleteTimer.Stop();
						};
						deleteTimer.Start();
					}


					// Zeitpunkt des Erledigt-Markierens speichern oder weitere Aktionen ausführen
					// Hier könnte der Code stehen, um die Aufgabe nach 10 Sekunden zu löschen
				}
				}
			}
		

		private void btn_add_Click(object sender, RoutedEventArgs e)
		{
			string title = txt_title.Text;
			string description = txt_description.Text;
			string employee = txt_employee.Text;
			DateTime deadline = dt_deadline.SelectedDate ?? DateTime.MinValue;

			if (!string.IsNullOrWhiteSpace(title) && !string.IsNullOrWhiteSpace(description) && !string.IsNullOrWhiteSpace(employee) && deadline != DateTime.MinValue)
			{
				TodoItems.Add(new TodoItem(title, description, employee, deadline));
				ClearFields();
			}
			else
			{
				MessageBox.Show("Bitte füllen Sie alle Felder aus und wählen Sie ein Datum aus.");
			}
		}

		private void ClearFields()
		{
			txt_title.Text = "";
			txt_description.Text = "";
			txt_employee.Text = "";
			dt_deadline.SelectedDate = null;
		}

		private void btn_delete_Click(object sender, RoutedEventArgs e)
		{
			if (lv_Todo.SelectedItem != null)
			{
				TodoItems.Remove((TodoItem)lv_Todo.SelectedItem);
			}
		}

		private void btn_reset_Click(object sender, RoutedEventArgs e)
		{
			ClearFields();
		}

		private void btn_sort_Click(object sender, RoutedEventArgs e)
		{

			//TodoItems.Sort();
			// Hier kannst du deine Sortierlogik implementieren
			// Zum Beispiel: TodoItems.Sort();
		}
	}

	
	public class TodoItem
	{
		public string Überschrift { get; set; }
		public string Beschreibung { get; set; }
		public string Mitarbeiter { get; set; }
		public DateTime Deadline { get; set; }

		private bool _isDone;

		public bool IsDone
		{
			get { return _isDone; }
			set
			{
				if (_isDone != value)
				{
					_isDone = value;
					OnPropertyChanged("IsDone");
				}
			}

		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		public TodoItem(string überschrift, string beschreibung, string mitarbeiter, DateTime deadline)
		{
			Überschrift = überschrift;
			Beschreibung = beschreibung;
			Mitarbeiter = mitarbeiter;
			Deadline = deadline;
		}
	}
}