using System.Windows;
using GalaSoft.MvvmLight.Threading;

namespace MultiPDFToOnePDF_MVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static App()
        {
            DispatcherHelper.Initialize();
        }
    }
}
