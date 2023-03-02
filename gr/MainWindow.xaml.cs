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

using Crypto.AES;

namespace gr
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

        private void btn_interactive_Click(object sender, RoutedEventArgs e)
        {
            AES aes = new AES(tb_key.Text);
            if(rb_crypt.IsChecked.Value)
            {
                tb_result.Text = aes.Encrypt(tb_content.Text);
            }
           else if (rb_decrypt.IsChecked.Value)
            {
                tb_result.Text = aes.Decrypt(tb_content.Text);
            }
        }
    }
}
