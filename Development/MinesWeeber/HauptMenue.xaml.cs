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
using System.Windows.Shapes;

namespace MinesWeeber
{
    /// <summary>
    /// Interaktionslogik für HauptMenue.xaml
    /// </summary>
    public partial class HauptMenue : Window
    {
        public HauptMenue()
        {
            InitializeComponent();
        }

        private void Btn_Highscore(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Highscore score = new Highscore();
            score.ShowDialog();
        }
        
        private void Btn_exit(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_start_game(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Game laufendesSpiel = new Game();
            laufendesSpiel.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.Show();
            txtbox_Name.Text = "";
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtbox_Name.Text != "")
                btn_StartGame.IsEnabled = true;
        }
    }
}