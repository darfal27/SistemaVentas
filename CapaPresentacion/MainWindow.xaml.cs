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
using CapaPresentacion.Vistas;

namespace CapaPresentacion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtAcercaDe_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sistema de Ventas\nWPF - N-Capas - Singleton",
            "Acerca de", MessageBoxButton.OK,
            MessageBoxImage.Information);
        }

        private void txtProductos_Click(object sender, RoutedEventArgs e)
        {
            txtEstado.Text = "Mantenimiento de productos abierto";
            ProductoWindow ventana = new ProductoWindow();
            ventana.Owner = this;    // se centra sobre esta ventana
            ventana.ShowDialog();    // modal: bloquea el menú hasta cerrarla
            txtEstado.Text = "Listo";
        }

        private void txtSalir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
