/* Thomas Tipper Festing
 * Apr 17, 2020
 * Translate Text
 */
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

namespace TxtTranslate
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

        private void btnTranslate_Click(object sender, RoutedEventArgs e)
        {
            //turns user input into a string
            string UserInput = txtbInput.Text;
            var translation = UserInput;
            translation = translation.Replace(":-)", "I’m happy");          //these are ordered in a way to prevent issues such as CU being read from CUZ and translating incorrectly
            translation = translation.Replace("CUZ", "because");            
            translation = translation.Replace("CCC", "Canadian Computing Competition");
            translation = translation.Replace("CU", "see you");
            translation = translation.Replace("TTYL", "talk to you later");
            translation = translation.Replace("TY", "thank-you");
            translation = translation.Replace("YW", "you’re welcome");
            translation = translation.Replace(":-(", "I’m unhappy");
            translation = translation.Replace(";-)", "wink");
            translation = translation.Replace(":-P", "stick out my tongue");
            translation = translation.Replace("TA", "totally awesome");
            translation = translation.Replace("(˜.˜)", "sleepy");

            lblOutput.Content = "You typed: " + UserInput + Environment.NewLine +
                "Which means: " + translation;
                
        }
    }
}
