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

namespace Restoran
{
    /// <summary>
    /// Логика взаимодействия для WorkPage.xaml
    /// </summary>
    public partial class WorkPage : Page
    {
        public WorkPage()
        {
            InitializeComponent();
        }
        int allsum = 0;
        private void Sum()
        {
            TBSum.Text = allsum.ToString() + " Руб.";
        }

        private void Tbiliss_Checked(object sender, RoutedEventArgs e)
        {
            allsum += 195;
            Sum();
            Zakaz.Items.Add(Tbiliss.Content + " 195 руб.");

        }

        private void Tbiliss_Unchecked(object sender, RoutedEventArgs e)
        {
            allsum -= 195;
            Sum();
            Zakaz.Items.Remove(Tbiliss.Content + " 195 руб.");
            
        }

        private void imirit_Checked(object sender, RoutedEventArgs e)
        {
            allsum += 375;
            Sum();
            Zakaz.Items.Add(imirit.Content + " 375 руб.");
        }

        private void imirit_Unchecked(object sender, RoutedEventArgs e)
        {
            allsum -= 375;
            Sum();
            Zakaz.Items.Remove(imirit.Content + " 375 руб.");
        }

        private void Gruz_Checked(object sender, RoutedEventArgs e)
        {
            allsum += 375;
            Sum();
            Zakaz.Items.Add(Gruz.Content + " 375 руб.");
        }

        private void Gruz_Unchecked(object sender, RoutedEventArgs e)
        {
            allsum -= 375;
            Sum();
            Zakaz.Items.Remove(Gruz.Content + " 375 руб.");
        }

        private void TBvGost_TextChanged(object sender, TextChangedEventArgs e)
        {
            TBGost.Text = TBvGost.Text;
        }

        private void TBvStol_TextChanged(object sender, TextChangedEventArgs e)
        {
            TBStol.Text = TBvStol.Text;
        }

        private void BCheck_Click(object sender, RoutedEventArgs e)
        {
            string[] mas=new string[Zakaz.Items.Count];
            for(int i=0; i<Zakaz.Items.Count;i++)
            {
                mas[i] = Zakaz.Items[i].ToString();
            }
            CheckWindow a = new CheckWindow(Convert.ToInt32(TBvGost.Text), Convert.ToInt32(TBvStol.Text), allsum, mas);
            a.ShowDialog();
        }
    }
}
