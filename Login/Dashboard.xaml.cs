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
using System.Windows.Shapes;

namespace Login
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }

        private void btn_CongDan_Click(object sender, RoutedEventArgs e)
        {
            Search search = new Search();
            Close();
            search.Show();
        }

        private void btn_LogOut_Click(object sender, RoutedEventArgs e)
        {
            LogIn logIn = new LogIn();
            Close();
            logIn.Show();
        }
    }
}
