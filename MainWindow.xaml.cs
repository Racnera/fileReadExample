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

namespace fileReadExample
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

        private void readFile_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                lblOut.Content = "";
                System.IO.StreamReader sr = new System.IO.StreamReader("BirthdayList.txt");
                while(!sr.EndOfStream)
                { lblOut.Content += sr.ReadLine() + "\n";}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void readFile2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                lblOut.Content = "";
                string output = "";
                System.IO.StreamReader sr = new System.IO.StreamReader("BL2.txt");
                while (!sr.EndOfStream)
                {
                    string fullName = sr.ReadLine();
                    string[] names=fullName.Split(new char[] { ',' });
                    output = names[2];
                    lblOut.Content += output +'\n';
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
