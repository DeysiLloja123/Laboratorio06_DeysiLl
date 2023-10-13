using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laboratorio06_DeysiLl
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewSource : ContentPage
    {
        ObservableCollection<Estudiante> estudiantes = new ObservableCollection<Estudiante>();
        public ObservableCollection<Estudiante> estudiantes { get { return employees; } }
        public ListViewSource()
        {
            InitializeComponent();
            EstudianteView.ItemsSource = employees;
            estudiantes.Add(new Estudiante { DisplayName = "Rob Finnerty" }, { DisplayName = "Rob Finnerty" });
            estudiantes.Add(new Estudiante { DisplayName = "Bill Wrestler" });
            estudiantes.Add(new Estudiante { DisplayName = "Dr. Geri-Beth Hooper " });
        }
    }
}














