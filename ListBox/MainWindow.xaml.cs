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

namespace ListBox
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
        void button_Click(object sender, EventArgs e)
        {
            switch((sender as Button).Content)
            {
                case "ADD":
                    if (!ListBox.Items.Contains(tbInput.Text))
                    {
                        if (tbInput.Text.Trim() == "") break;
                        ListBox.Items.Add(tbInput.Text);
                        tbInput.Text = "";
                        tbInput.Focus();
                    }
                    break;
                case "DEL":
                    if (ListBox.SelectedIndex >= 0)
                        ListBox.Items.RemoveAt(ListBox.SelectedIndex);
                    break;
                case "CLR": ListBox.Items.Clear(); 
                    break;
            }
        }


        private void TbInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) button_Click(btnAdd, null);
        }
    }
}