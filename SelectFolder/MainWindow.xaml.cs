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

namespace SelectFolder
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Button_Click( object sender, RoutedEventArgs e )
		{
			var dlg = new PickupFolderDialog.PickupFolderDialog();
			dlg.SelectedPath = EditSelFolder.Text;
			if( dlg.ShowDialog( this ) )
			{
				EditSelFolder.Text = dlg.SelectedPath;
			}
		}

		private void Button_Click_Cancel( object sender, RoutedEventArgs e )
		{
			Close();	//	終了する
		}
	}
}
