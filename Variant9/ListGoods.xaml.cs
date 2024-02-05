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
using Variant9.DB;

namespace Variant9
{
    /// <summary>
    /// Логика взаимодействия для ListProducts.xaml
    /// </summary>
    public partial class ListGoods : Window
    {
        public List<Good> Goods { get; set; }
        public ListGoods()
        {
            InitializeComponent();
            // Загрузка данных о товарах из базы данных
            

            // Привязка данных к элементу управления ListBox
            //goodsListBox.ItemsSource = goodsList;
            Goods = DataBase.Instance().Goods.ToList();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}