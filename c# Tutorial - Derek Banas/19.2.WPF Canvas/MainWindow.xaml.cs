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

namespace _19._2.WPF_Canvas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string usersName = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Send_Button_Click(object sender, RoutedEventArgs e)
        {
            usersName = UsersName.Text;
            MessageBox.Show($"Hello {usersName}");
        }
    }
}
