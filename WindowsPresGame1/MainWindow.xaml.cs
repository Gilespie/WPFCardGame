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

namespace WindowsPresGame1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetUpGame();
        }

        private void SetUpGame()
        {
            List<string> animals = new List<string>()
            {
                "🦎","🦎",
                "🦨","🦨",
                "🦈","🦈",
                "🐙","🐙",
                "🦁","🦁",
                "🐸","🐸",
                "🐦","🐦",
                "🦅","🦅",
                "🐭","🐭",
                "🦄","🦄",
            };

            Random ramdom = new Random();

            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                int index = ramdom.Next(animals.Count);
                string nextEmoji = animals[index];
                textBlock.Text = nextEmoji;
                animals.RemoveAt(index);
            }
        }
    }
}
