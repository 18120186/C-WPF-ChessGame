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

namespace Chess_Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        MainGame game = new MainGame();
        public MainWindow()
        {
            
            InitializeComponent();
        }

        //private bool Move(Image thisPos, Image nextPos)
        //{
        //    ImageSource temp = thisPos.Source;
        //    nextPos.Source = temp;
        //    thisPos.Source = null;
        //    return true;
        //}

        //Cập nhật bàn cờ
        public void UpdateChessBoard()
        {
            List<List<Unit>> ChessBoard = game.getChessBoard();
            for(int i=0; i<8;i++)
            {
                for(int j=0;j<8;j++)
                {

                }
            }
        }
        //Cập nhật quân cờ
        //public void UpdateChessBox(Image box, Unit unit)
        //{
        //    if()
        //}
        private void Button_00_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_01_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_02_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_03_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_04_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_05_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_06_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_07_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_10_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_11_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_12_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_13_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_14_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_15_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_16_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Button_17_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_20_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_21_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Button_22_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Button_23_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_24_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_25_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_26_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_27_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_30_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_31_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_32_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_33_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_34_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_35_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_36_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_37_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_40_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_41_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_42_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_43_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_44_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_45_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_46_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_47_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_50_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_51_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_52_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_53_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_54_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_55_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_56_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_57_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_60_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Button_61_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_62_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_63_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_64_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_65_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_66_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_67_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_70_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_71_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_72_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_72_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_73_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_74_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_75_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_76_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_77_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
