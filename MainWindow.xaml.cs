using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
using WebShop.ServiceReference1;
using System.Runtime.Serialization;
using WebShop.Models;
using System.ServiceModel;


namespace WebShop
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

        private void ButtonObrisi_Click(object sender, RoutedEventArgs e)
        {
            if (DataGrid1.SelectedItem != null)
            {
                OsobaCon Oc = DataGrid1.SelectedItem as OsobaCon;
                int id = Oc.OsobaId;
                WebShopServiceClient klijent = new WebShopServiceClient();
                klijent.ObrisiPorudzbinu(id);
                MessageBox.Show("Obrisano "+ Oc.ImePrezime + "\n " + Oc.StaPorucujete);
                DataGrid1.SelectedIndex = -1;
                OsveziGrid();
            }
            else
            {
                MessageBox.Show("Odaberite sta brisete");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
         
            try
            {
              
                WebShopServiceClient klijent = new WebShopServiceClient();
                            
                OsobaCon[] listaOsoba = klijent.VratiOsobe();

                DataGrid1.ItemsSource = listaOsoba.ToList();
                klijent.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Server nije dostupan.");
               // MessageBox.Show("Greska: " + exc);
            };
           
        }
        public void OsveziGrid()
        {
            try
            {
                WebShopServiceClient klijent = new WebShopServiceClient();
                OsobaCon[] listaOsoba = klijent.VratiOsobe();

                DataGrid1.ItemsSource = listaOsoba.ToList();
                DataGrid1.Items.Refresh();
                DataGrid1.UpdateLayout();
                klijent.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Server nije dostupan.");
                //MessageBox.Show("Greska: " + exc);
            }
        }
        private void ButtonOsvezi_Click(object sender, RoutedEventArgs e)
        {
            OsveziGrid();          
        }
    }
}
