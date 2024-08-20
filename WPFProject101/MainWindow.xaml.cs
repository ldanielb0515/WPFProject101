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

namespace WPFProject101
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SetCalculate();
        }

        private void SetCalculate()
        {
            List<string> randLetter = new List<string>()
            {
                "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P",
            };

            Random random = new Random();

            foreach (TextBlock txtblock in maingrid.Children.OfType<TextBlock>())
            {
                int index = random.Next(randLetter.Count);
                string letter = randLetter[index];
                txtblock.Text = letter;
                randLetter.RemoveAt(index);
            }
        }
    }
}