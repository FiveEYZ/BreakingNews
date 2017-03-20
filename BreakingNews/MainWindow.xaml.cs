using BreakingNews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
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

namespace BreakingNews
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

        Program myProgram = new Program();

        /// <summary>
        /// Sets the selected keyword and website from the radioButtons
        /// </summary>
        private void contentToCheck()
        {
            buttonGetStats.IsHitTestVisible = false;

            if (radioButtonEkonomi.IsChecked == true)
                myProgram.CheckWord = "ekonomi";
            else if (radioButtonHemlig.IsChecked == true)
                myProgram.CheckWord = "hemlig";
            else if (radioButtonPolis.IsChecked == true)
                myProgram.CheckWord = "polis";
            else if (radioButtonTrump.IsChecked == true)
                myProgram.CheckWord = "trump";

            if (radioButtonAftonbladet.IsChecked == true)
                myProgram.SaveWebAddress("http://www.aftonbladet.se");
            else if (radioButtonExpressen.IsChecked == true)
                myProgram.SaveWebAddress("http://www.expressen.se/");
            else if(radioButtonDN.IsChecked == true)
                myProgram.SaveWebAddress("http://www.dn.se/");
        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "Please Wait";
            contentToCheck();

            Task<int> task = Task.Run(() => myProgram.Calc());
            int wordcount = await task;
            textBox.Text = wordcount.ToString();

            buttonGetStats.IsHitTestVisible = true;
        }
    }
}
