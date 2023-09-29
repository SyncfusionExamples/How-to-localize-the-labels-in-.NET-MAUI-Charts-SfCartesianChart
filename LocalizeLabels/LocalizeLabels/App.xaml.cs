using Syncfusion.Maui.Charts;
using System.Globalization;
using System.Resources;

namespace LocalizeLabels
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            CultureInfo.CurrentUICulture = new CultureInfo("it-IT");
            var ResXPath = "LocalizeLabels.Resources.SfCartesianChart";
            SfCartesianChartResources.ResourceManager = new ResourceManager(ResXPath, Application.Current.GetType().Assembly);
            MainPage = new AppShell();
        }
    }
}