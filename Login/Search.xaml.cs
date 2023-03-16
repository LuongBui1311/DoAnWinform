using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        private void btn_LogOut_Click(object sender, RoutedEventArgs e)
        {
            LogIn logIn = new LogIn();
            Close();
            logIn.Show();
        }
    }
}
