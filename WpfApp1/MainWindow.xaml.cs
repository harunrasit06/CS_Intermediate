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

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //var button = (Button)sender;          // DownCasting with Explicit Casting
            //button.Click(button.DataContext);

            var button = sender as Button;          // Beide sind DownCasting
            if (button != null)
            {
                MessageBox.Show(button.ActualHeight.ToString());
            }
            MessageBox.Show("Hello World!");

        }
    }
}