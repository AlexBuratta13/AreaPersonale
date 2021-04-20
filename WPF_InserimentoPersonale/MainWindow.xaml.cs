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
using LibraryPersonale;

namespace WPF_InserimentoPersonale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Persona p;
        string[] qualifica = new string[] { "1", "2", "3", "4" };
        public MainWindow()
        {
            InitializeComponent();
        }
        private void cmbQualifica_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (string s in qualifica)
                cmb_Qualifica.Items.Add(s);
        }
    }
}
