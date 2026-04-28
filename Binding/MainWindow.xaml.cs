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
using System.Runtime.CompilerServices;
using System.ComponentModel;
namespace Binding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        string boundText;
        public string BoundText
        {
            get => boundText;
            set
            {
                boundText = value;
                OnPropertyChanged();
                txtInput.Focus();
            }
        }
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
        }
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BoundText"));
        }

        private void btnDefault_Click(object sender, RoutedEventArgs e)
        {
            BoundText = "Default";
        }
    }
}