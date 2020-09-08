using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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

namespace MaterialDesignWPF
{
    /// <summary>
    /// Lógica de interacción para NewWindow.xaml
    /// </summary>
    public partial class NewWindow : Window
    {
        public NewWindow()
        {
            Assembly.LoadFrom(System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "MaterialDesignThemes.Wpf.dll"));
            Assembly.LoadFrom(System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "MaterialDesignColors.dll"));
            InitializeComponent();
        }
    }
}
