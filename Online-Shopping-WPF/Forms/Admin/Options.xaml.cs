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

namespace Online_Shopping_WPF.Forms.Admin
{
    /// <summary>
    /// Interaction logic for Options.xaml
    /// </summary>
    public partial class Options : Window
    {
        public Options()
        {
            InitializeComponent();
        }

        private void addBTN_Click(object sender, RoutedEventArgs e)
        {
            AddProduct x = new AddProduct();
            x.Show();
        }

        private void deleteBTN_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void editBTN_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
