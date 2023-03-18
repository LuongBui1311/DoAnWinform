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

            BrushConverter converter = new BrushConverter();
            ObservableCollection<Member> members = new ObservableCollection<Member>();

            //Create DataGrid Items Info
            members.Add(new Member("A", "1", "Quintella Leyton", "Coach", "staff01@gmail.com", "505-447-3334", (Brush)converter.ConvertFromString("#1098ad")));
            //members.Add(new Member("A", "1", "Quintella Leyton", "Coach", "staff01@gmail.com", "505-447-3334", (Brush)converter.ConvertFromString("#1098ad")));
            //members.Add(new Member("A", "1", "Quintella Leyton", "Coach", "staff01@gmail.com", "505-447-3334", (Brush)converter.ConvertFromString("#1098ad")));
            //members.Add(new Member("A", "1", "Quintella Leyton", "Coach", "staff01@gmail.com", "505-447-3334", (Brush)converter.ConvertFromString("#1098ad")));
            //members.Add(new Member("A", "1", "Quintella Leyton", "Coach", "staff01@gmail.com", "505-447-3334", (Brush)converter.ConvertFromString("#1098ad")));
            //members.Add(new Member("A", "1", "Quintella Leyton", "Coach", "staff01@gmail.com", "505-447-3334", (Brush)converter.ConvertFromString("#1098ad")));
            //members.Add(new Member("A", "1", "Quintella Leyton", "Coach", "staff01@gmail.com", "505-447-3334", (Brush)converter.ConvertFromString("#1098ad")));
            //members.Add(new Member("A", "1", "Quintella Leyton", "Coach", "staff01@gmail.com", "505-447-3334", (Brush)converter.ConvertFromString("#1098ad")));
            //members.Add(new Member("A", "1", "Quintella Leyton", "Coach", "staff01@gmail.com", "505-447-3334", (Brush)converter.ConvertFromString("#1098ad")));
            //members.Add(new Member("A", "1", "Quintella Leyton", "Coach", "staff01@gmail.com", "505-447-3334", (Brush)converter.ConvertFromString("#1098ad")));
        }

        public class Member
        {
            public string Character { get; set; }
            public string Number { get; set; }
            public string Name { get; set; }
            public string Position { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public Brush BgColor { get; set; }
            public Member(string character, string number, string name, string position, string email, string phone, Brush bgColor)
            {
                Character = character;
                Number = number;
                Name = name;
                Position = position;
                Email = email;
                Phone = phone;
                BgColor = bgColor;
            }
        }
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connstr);
        private void btn_LogOut_Click(object sender, RoutedEventArgs e)
        {
            LogIn logIn = new LogIn();
            Close();
            logIn.Show();
        }

        //private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        //{
        //    try
        //    {
        //        conn.Open();
        //        string sqlStr = string.Format("SELECT *FROM CongDan");

        //        SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
        //        DataTable dtCongDan = new DataTable();
        //        adapter.Fill(dtCongDan);

        //        dtg_Search.ItemsSource = dtCongDan.DefaultView; /// gvHsinh = name cua data gridview
        //    }
        //    catch (Exception exc)
        //    {
        //        MessageBox.Show(exc.Message);
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}

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
    }
}
