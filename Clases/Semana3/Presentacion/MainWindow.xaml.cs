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

namespace Presentacion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lblSaludo.Visibility = Visibility.Hidden;
            lblNombre.Visibility = Visibility.Hidden;

            cboGrupo.ItemsSource = Enum.GetValues(typeof(Clasificacion));
            cboGrupo.SelectedValue = Clasificacion.Default;


        }

        private void BtnSaludar_Click(object sender, RoutedEventArgs e)
        {
            lblSaludo.Visibility = Visibility.Visible;
            lblNombre.Visibility = Visibility.Visible;
        }

        private void BtnRespuesta_Click(object sender, RoutedEventArgs e)
        {
            string nombre = txtNombre.Text;

            MessageBox.Show("Hola " + nombre, "Saludo", MessageBoxButton.OK, MessageBoxImage.Exclamation);
        }

        private void BtnGuardarContacto_Click(object sender, RoutedEventArgs e)
        {
            //1. Capturar datos desde el form
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            DateTime fechaNacimiento = (DateTime)dpFechaNacimiento.SelectedDate;
            string telefono = txtTelefono.Text;
            Clasificacion grupo = (Clasificacion)cboGrupo.SelectedValue;
           
            //2. Validar datos

            //3. Crear objeto Persona
            Persona nuevoContacto = new Persona();
            nuevoContacto.Nombre = nombre;
            nuevoContacto.Apellido = apellido;
            nuevoContacto.FechaNacimiento = fechaNacimiento;
            nuevoContacto.Telefono = telefono;
            nuevoContacto.Grupo = grupo;

            //4. Guardar objeto Persona

        }
    }
}
