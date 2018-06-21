using System.Windows;
using SchoolLibrary;

namespace SchoolWPFApp
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

        private void btnPushToTest_Click(object sender, RoutedEventArgs e)
        {
            var testSchool = new School();
        }
    }
}
