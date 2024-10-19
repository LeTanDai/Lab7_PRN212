using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WrapPanel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnDisplay_Click(object sender, RoutedEventArgs e)
        {
            string carinfor = $"Car name: {txtCarName.Text}\n" + $"Color : {txtColor.Text} \n Brand: {txtBrand.Text}";
            MessageBox.Show(carinfor, "Car Details");
        }
    }
}