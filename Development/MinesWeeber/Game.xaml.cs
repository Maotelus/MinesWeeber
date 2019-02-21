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
    /// Interaktionslogik für Game.xaml
    /// </summary>
    public partial class Game : Window
    {
        SpielFeld _sf = new SpielFeld(16, 30, 99);

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CreateGridCol();
            CreateGridRow();
            CreatePlayground();

        }

        public Game()
        {
            InitializeComponent();

        }

        private void btn_Reset_Click(object sender, RoutedEventArgs e)
        {

        }

        public void CreatePlayground()
        {
            for (int i = 0; i < _sf.Height; i++)
            {
                for (int j = 0; j < _sf.Width; j++)
                {
                    Button neuerButton = new Button();
                    SpielfeldGrid.Children.Add(neuerButton);
                    Grid.SetColumn(neuerButton, j);
                    Grid.SetRow(neuerButton, i);
                    Console.WriteLine("Button added j:{0}, i:{1}",j,i );
                }
            }
        }

        public void CreateGridCol()
        {
            int countCol = _sf.Width;

            for (int i = 0; i < countCol; i++)
            {
                ColumnDefinition newCol = new ColumnDefinition();
                SpielfeldGrid.ColumnDefinitions.Add(newCol);
            }   
        }

        public void CreateGridRow()
        {
            int countCol = _sf.Height;

            for (int i = 0; i < countCol; i++)
            {
                RowDefinition newRow = new RowDefinition();
                SpielfeldGrid.RowDefinitions.Add(newRow);
            }

        }


    }
}
