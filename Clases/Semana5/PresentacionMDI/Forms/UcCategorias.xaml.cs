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

namespace PresentacionMDI.Forms
{
    /// <summary>
    /// Lógica de interacción para UcCategorias.xaml
    /// </summary>
    public partial class UcCategorias : UserControl
    {
        CategoriaBLL catBll = new CategoriaBLL();
        Categoria categoria;
        
        public UcCategorias()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            CargarCategorias();
        }

        private void CargarCategorias()
        {
            dgCategorias.ItemsSource = null;
            dgCategorias.ItemsSource = catBll.GetAll();
        }

        private void BtnCrear_Click(object sender, RoutedEventArgs e)
        {
            catBll.Add(txtCategoria.Text);
            txtCategoria.Text = string.Empty;
            CargarCategorias();
        }

        private void DgCategorias_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgCategorias.SelectedIndex != -1)
            {
                categoria = (Categoria)dgCategorias.SelectedItem;
                txtCategoria.Text = categoria.Nombre;
                form.Header = "Editar Categoría";

                btnCrear.Visibility = Visibility.Hidden;
                btnGuardar.Visibility = Visibility.Visible;
                btnBorrar.Visibility = Visibility.Visible;
                btnCancelar.Visibility = Visibility.Visible;
            }
           
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            form.Header = "Nueva Categoría";
            txtCategoria.Text = string.Empty;
            dgCategorias.SelectedIndex = -1;

            btnCrear.Visibility = Visibility.Visible;
            btnGuardar.Visibility = Visibility.Hidden;
            btnBorrar.Visibility = Visibility.Hidden;
            btnCancelar.Visibility = Visibility.Hidden;
        }

        private void BtnBorrar_Click(object sender, RoutedEventArgs e)
        {
            categoria = (Categoria)dgCategorias.SelectedItem;

            catBll.Delete(categoria);
            CargarCategorias();

            form.Header = "Nueva Categoría";
            txtCategoria.Text = string.Empty;
            dgCategorias.SelectedIndex = -1;

            btnCrear.Visibility = Visibility.Visible;
            btnGuardar.Visibility = Visibility.Hidden;
            btnBorrar.Visibility = Visibility.Hidden;
            btnCancelar.Visibility = Visibility.Hidden;

        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            categoria.Nombre = txtCategoria.Text;
            catBll.Edit(categoria);

            CargarCategorias();

            form.Header = "Nueva Categoría";
            txtCategoria.Text = string.Empty;
            dgCategorias.SelectedIndex = -1;

            btnCrear.Visibility = Visibility.Visible;
            btnGuardar.Visibility = Visibility.Hidden;
            btnBorrar.Visibility = Visibility.Hidden;
            btnCancelar.Visibility = Visibility.Hidden;


        }
    }
}
