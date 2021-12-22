using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyShelfOfBooks
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataBase db = new DataBase();
        public MainWindow()
        {
            InitializeComponent();
            db.CreateStrConnection();
            db = new DataBase();
        }
        //DataBase = db;
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            db.AddBook(tb1.Text, tb2.Text, tb3.Text, tb4.Text);
        }
    }
}
