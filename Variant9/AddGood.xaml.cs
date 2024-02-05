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
using Variant9.DB;
using Variant9.vm;

namespace Variant9
{
    public partial class AddGood : Window
    {
       
        public AddGood()
        {
            InitializeComponent();
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            string name = NameTextBox.Text;
            int cost = int.Parse(CostTextBox.Text);
            int creatorId = int.Parse(CreatorIdTextBox.Text);
            int providerId = int.Parse(ProviderIdTextBox.Text);
            int categoryId = int.Parse(CategoryIdTextBox.Text);
            int currentSale = int.Parse(CurrentSaleTextBox.Text);
            int amount = int.Parse(AmountTextbox.Text);
            int unitId = int.Parse(UnitIdTextBox.Text);
            int maxSaleProc = int.Parse(MaxSaleProcTextBox.Text);
            string discription = string.Empty;
            string articul = ArticulTextBox.Text;
            

            DataBase.Instance().Goods.Add(new Good {MaxSaleProc = maxSaleProc, UnitId = unitId, Articul = articul, Name = name, Cost = cost, CreatorId = creatorId,  Discription = discription, ProviderId = providerId, CategoryId = categoryId, CurrentSale = currentSale, Amount = amount });
            DataBase.Instance().SaveChanges();
            this.Close();
        }

        private void ProviderIdTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
