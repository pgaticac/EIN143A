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
        Categoria c;
        public MainWindow()
        {
            InitializeComponent();
            CargarCategorias();
        }

        public  void CargarCategorias()
        {
            lstCategorias.ItemsSource = null;
            lstCategorias.ItemsSource = catBll.GetAll();
        }

        public void CargarCategorias(string filtro)
        {
            lstCategorias.ItemsSource = null;
            lstCategorias.ItemsSource = catBll.GetFilter(filtro);
        }

        private void BtnNuevaCategoria_Click(object sender, RoutedEventArgs e)
        {
            string categoria = txtCategoria.Text;
            //Validar
            catBll.Add(categoria);

            //Mensaje

            txtCategoria.Text = String.Empty;

            CargarCategorias();

        }

        private void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (lstCategorias.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona categoría a eliminar");
            }
            else
            {
                Categoria c = (Categoria)lstCategorias.SelectedItem;
                catBll.Delete(c);
                CargarCategorias();

            }
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (lstCategorias.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona categoría a eliminar");
            }
            else
            {
                c = (Categoria)lstCategorias.SelectedItem;
                txtCategoria.Text = c.Nombre;

                btnEditarCategoria.Visibility = Visibility.Visible;
                btnCancelar.Visibility = Visibility.Visible;
                btnNuevaCategoria.Visibility = Visibility.Collapsed;

            }
        }

        private void BtnEditarCategoria_Click(object sender, RoutedEventArgs e)
        {
            c.Nombre = txtCategoria.Text;
            catBll.Edit(c);
            CargarCategorias();

            txtCategoria.Text = String.Empty;

        }

        private void BtnFiltrar_Click(object sender, RoutedEventArgs e)
        {
            string filtro = txtFiltro.Text;
            CargarCategorias(filtro);

            
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            btnEditarCategoria.Visibility = Visibility.Hidden;
            btnCancelar.Visibility = Visibility.Hidden;
            btnNuevaCategoria.Visibility = Visibility.Visible;
            txtCategoria.Text = string.Empty;
            c = null;
        }
    }
}
