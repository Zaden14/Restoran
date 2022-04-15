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

namespace Restoran
{
    /// <summary>
    /// Логика взаимодействия для CheckWindow.xaml
    /// </summary>
    public partial class CheckWindow : Window
    {
        public CheckWindow(int gost, int stol, int summ, string[] havka)
        {
            InitializeComponent();

            TBStol.Text = stol.ToString();
            TBGost.Text = gost.ToString();
            TBSumma.Text = summ.ToString();
            for(int i=0; i< havka.Count(); i++)
            {
                TBhavka.Text+=havka[i]+"\n";
            }
        }

        private void BtSave_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Чек Сохранён!");
            this.Close();
        }
    }
}
