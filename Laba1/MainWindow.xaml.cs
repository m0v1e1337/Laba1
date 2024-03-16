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
using Laba1.Laba1DataSetTableAdapters;

namespace Laba1
{
    public partial class MainWindow : Window
    {
        PlayersTableAdapter Players = new PlayersTableAdapter();
        CoachesTableAdapter Coaches = new CoachesTableAdapter();
        TeamsTableAdapter Teams = new TeamsTableAdapter();

        public MainWindow()
        {
            InitializeComponent();
            DisplayPlayersData();
            DisplayCoachesData();
        }

        private void DisplayPlayersData()
        {
            var playersData = Players.GetData();

            DataGrid dataGrid = new DataGrid();
            dataGrid.AutoGenerateColumns = true;
            dataGrid.ItemsSource = playersData.DefaultView;

            mainGrid.Children.Add(dataGrid);
        }

        private void DisplayCoachesData()
        {
            var coachesData = Coaches.GetData();

            DataGrid dataGrid = new DataGrid();
            dataGrid.AutoGenerateColumns = true;
            dataGrid.ItemsSource = coachesData.DefaultView;

            mainGrid.Children.Add(dataGrid);
        }
    }
}
