using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
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
    /// Interaction logic for Search.xaml
    /// </summary>
    public partial class Search : Window
    {
        public Search()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connstr);
        private void btn_LogOut_Click(object sender, RoutedEventArgs e)
        {
            LogIn logIn = new LogIn();
            Close();
            logIn.Show();
        }

        private void dtg_ThongTin_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT *FROM CongDan");

                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dtCongDan = new DataTable();
                adapter.Fill(dtCongDan);

                dtg_ThongTin.ItemsSource = dtCongDan.DefaultView; /// gvHsinh = name cua data gridview
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dtg_Thue_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT *FROM Thue");

                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dtThue = new DataTable();
                adapter.Fill(dtThue);

                dtg_Thue.ItemsSource = dtThue.DefaultView; 
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dtg_Tamtru_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT *FROM Tamtru");

                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dtTamtru = new DataTable();
                adapter.Fill(dtTamtru);

                dtg_Tamtru.ItemsSource = dtTamtru.DefaultView;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dtg_Tamvang_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT *FROM Tamvang");

                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dtTamvang = new DataTable();
                adapter.Fill(dtTamvang);

                dtg_Tamvang.ItemsSource = dtTamvang.DefaultView;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dtg_Cnkh_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT *FROM Cnkh");

                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dtCnkh = new DataTable();
                adapter.Fill(dtCnkh);

                dtg_Cnkh.ItemsSource = dtCnkh.DefaultView;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_Them_ThongTin_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
