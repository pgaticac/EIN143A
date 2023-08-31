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
using Negocio;
using Datos;

namespace Presentacion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        CategoriaBLL catBll = new CategoriaBLL();
        public MainWindow()
        {
            InitializeComponent();
            CargarCategorias();
        }

        private void CargarCategorias()
        {
            lstCategorias.ItemsSource = null;
            lstCategorias.ItemsSource = catBll.GetAll();
        }

        private void BtnNuevaCategoria_Click(object sender, RoutedEventArgs e)
        {
            string categoria = txtNuevaCategoria.Text;
            //Validar
            catBll.Add(categoria);

            //Mensaje

            txtNuevaCategoria.Text = String.Empty;

            CargarCategorias();

        }
    }
}
