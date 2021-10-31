using MvvmCross.Platforms.Wpf.Views;
using MvvmCross.Platforms.Wpf.Presenters.Attributes; 
using Kalkulator_NET_5_MvvmCross.Core.ViewModels;
using MvvmCross.ViewModels;

namespace Kalkulator_NET_5_MvvmCross.Wpf.Views
{
    /// <summary>
    /// Interaction logic for Kalkulator_ViewUC.xaml
    /// </summary>
    /// 
    [MvxContentPresentation]
    [MvxViewFor(typeof(KalkulatorViewModel))]

    public partial class Kalkulator_ViewUC : MvxWpfView
    {
        public Kalkulator_ViewUC()
        {
            InitializeComponent();
        }
    }
}
