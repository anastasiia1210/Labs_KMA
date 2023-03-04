using KMA_lab1_2023.ViewModels;
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

namespace KMA_lab1_2023.Views
{
	/// <summary>
	/// Interaction logic for DateControl.xaml
	/// </summary>
	public partial class DateView : UserControl
	{
		private DateViewModel _viewModel;
		public DateView()
		{
			InitializeComponent();
			DataContext = _viewModel = new DateViewModel();
		}

		private DateViewModel Get_viewModel()
		{
			return _viewModel;
		}

		private void datePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
		{
			if (datePicker.SelectedDate != null)
			{
				_viewModel.Birthday = (DateTime)datePicker.SelectedDate;
				OutPutAge.Text = _viewModel.Age.ToString();
				OutPutWestern.Text = _viewModel.WesternZodiac;
				OutPutChinese.Text = _viewModel.ChineseZodiac;
			}
		}
	}
}
