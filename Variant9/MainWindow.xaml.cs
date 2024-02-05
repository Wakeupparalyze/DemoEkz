using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
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

    public partial class MainWindow : Window
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }
    }
}

