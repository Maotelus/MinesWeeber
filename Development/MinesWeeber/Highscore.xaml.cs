using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace MinesWeeber
{
    /// <summary>
    /// Interaktionslogik für Highscore.xaml
    /// </summary>
    public partial class Highscore : Window
    {
       
        public Highscore()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            StreamReader reader = new StreamReader("../../highscore.txt") ;
            
            if (reader.ReadLine() != null)
            {
                String line = reader.ReadLine();
                String[] toSplit = line.Split(';');
                libx_Scores.Items.Add(toSplit[0] + " : " + toSplit[1]);
            }
        }

        private void btn_Back_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            HauptMenue titelbildschirm = new HauptMenue();
            titelbildschirm.ShowDialog();
        }

        private void libx_Scores_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

       
    }
}
