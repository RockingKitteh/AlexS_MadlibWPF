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

namespace MadlibWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// Help with storing and using text input from https://social.msdn.microsoft.com/Forums/vstudio/en-US/31bcec7d-ac0f-4901-986b-1e2b8e208f2d/how-do-i-read-a-string-from-textbox-and-store-it-in-a-variable?forum=wpf
    public partial class MainWindow : Window
    {
        string Creature;
        string Luminous;
        string Ghastly;
        string Spectral;
        string Countryman;
        string Farrier;
        string Farmer;
        string Dreadful;
        string Apparition;
        string Hound;
        string Story;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void _1_TextChanged(object sender, TextChangedEventArgs e)
        {
            Creature = _1.Text;
        }

        private void _2_TextChanged(object sender, TextChangedEventArgs e)
        {
            Luminous = _2.Text;
        }

        private void _3_TextChanged(object sender, TextChangedEventArgs e)
        {
            Ghastly = _3.Text;
        }

        private void _4_TextChanged(object sender, TextChangedEventArgs e)
        {
            Spectral = _4.Text;
        }

        private void _5_TextChanged(object sender, TextChangedEventArgs e)
        {
            Countryman = _5.Text;
        }

        private void _6_TextChanged(object sender, TextChangedEventArgs e)
        {
            Farrier = _6.Text;
        }

        private void _7_TextChanged(object sender, TextChangedEventArgs e)
        {
            Farmer = _7.Text;
        }

        private void _8_TextChanged(object sender, TextChangedEventArgs e)
        {
            Dreadful = _8.Text;
        }

        private void _9_TextChanged(object sender, TextChangedEventArgs e)
        {
            Apparition = _9.Text;
        }

        private void _10_TextChanged(object sender, TextChangedEventArgs e)
        {
            Hound = _10.Text;
        }

        private void Write_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("They all agreed that it was a huge " + Creature + ", " + Luminous + ", " + Ghastly + ", and " + Spectral + ". I have cross-examined these men, one of them a hard-headed " + Countryman + ", one a " + Farrier + ", and one a moorland " + Farmer + ", who all tell the same story of this " + Dreadful + " " + Apparition + ", exactly corresponding to the " + Hound + " of the legend.");
        }
    }
}
