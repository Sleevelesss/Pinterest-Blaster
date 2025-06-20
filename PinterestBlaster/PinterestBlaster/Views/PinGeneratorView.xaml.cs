using System.Windows.Controls;
using PinterestBlaster.ViewModels;

namespace PinterestBlaster.Views
{
    public partial class PinGeneratorView : UserControl
    {
        public PinGeneratorView()
        {
            InitializeComponent();
            this.DataContext = new PinGeneratorViewModel();
        }
    }
}