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

namespace Biblioteca
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Class1 c1 = new Class1();
        private void btnStampaLibro_Click(object sender, RoutedEventArgs e)
        {
            c1.autore = txtAutore.Text;
            c1.anno = txtAnno.Text;
            c1.npagine = txtPagine.Text;
            c1.libro = txtLibro.Text;
            lblLibri.Content = "Il libro è"+c1.libro + "pubblicato nell'anno" + c1.anno + "con" + c1.npagine + "pagine e" + "l'autore è" + c1.autore;
        }

        private void btnStampaBiblioteca_Click(object sender, RoutedEventArgs e)
        {
            c1.nome = txtBiblioteca.Text;
            c1.indirizzo=
            c1.orarioApertura=
            c1.orarioChiusura=
        }
    }
}
