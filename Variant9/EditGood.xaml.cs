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

namespace Variant9
{
    /// <summary>
    /// Логика взаимодействия для EditGood.xaml
    /// </summary>
    public partial class EditGood : Window
    {
        private Good _selectedGood;

        public EditGood(Good selectedGood)
        {
            InitializeComponent();
            _selectedGood = selectedGood;

            NameTextBox.Text = _selectedGood.Name;
            CostTextBox.Text = _selectedGood.Cost.ToString();
            CreatorIdTextBox.Text = _selectedGood.CreatorId.ToString();
            ProviderIdTextBox.Text = _selectedGood.ProviderId.ToString();
            CategoryIdTextBox.Text = _selectedGood.CategoryId.ToString();
            CurrentSaleTextBox.Text = _selectedGood.CurrentSale.ToString();
            AmountTextBox.Text = _selectedGood.Amount.ToString();
            ArticulTextBox.Text = _selectedGood.Articul;
            DiscriptionTextBox.Text = _selectedGood.Discription;
            UnitIdTextBox.Text = _selectedGood.UnitId.ToString();
            MaxSaleProcTextBox.Text = _selectedGood.MaxSaleProc.ToString();
            

        }

        private void Save(object sender, RoutedEventArgs e)
        {
            _selectedGood.Name = NameTextBox.Text;
            _selectedGood.Cost = int.Parse(CostTextBox.Text);
            _selectedGood.CreatorId = int.Parse(CreatorIdTextBox.Text);
            _selectedGood.ProviderId = int.Parse(ProviderIdTextBox.Text);
            _selectedGood.CategoryId = int.Parse(CategoryIdTextBox.Text);
            _selectedGood.CurrentSale = int.Parse(CurrentSaleTextBox.Text);
            _selectedGood.Amount = int.Parse(AmountTextBox.Text);
            _selectedGood.Articul = ArticulTextBox.Text;
            _selectedGood.Discription = DiscriptionTextBox.Text;
            _selectedGood.UnitId = int.Parse(UnitIdTextBox.Text);
            _selectedGood.MaxSaleProc = int.Parse(MaxSaleProcTextBox.Text);


            DataBase.Instance().SaveChanges();
            this.Close();
        }
    }
}