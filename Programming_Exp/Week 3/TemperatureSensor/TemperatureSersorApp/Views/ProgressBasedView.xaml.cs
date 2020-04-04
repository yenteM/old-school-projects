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

namespace TemperatureSersorApp.Views
{
    /// <summary>
    /// Interaction logic for ProgressBasedView.xaml
    /// </summary>
    public partial class ProgressBasedView : UserControl
    {
        public ProgressBasedView()
        {
            InitializeComponent();
            Mediator.GetInstance().JobChanged += (s, e) => { this.tempProgressBar.Value = e.Temp; };
        }
    }
}
