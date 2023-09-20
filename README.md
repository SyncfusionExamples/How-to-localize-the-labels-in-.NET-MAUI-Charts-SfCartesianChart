# How-to-localize-the-labels-in-.NET-MAUI-Charts-SfCartesianChart
How-to-localize-the-labels-in-.NET-MAUI-Charts-SfCartesianChart
This sample demonstrates how to localize the labels in the chart.Localization is the process of translating the application resources into different language for the specific cultures. The [SfCartesianChart](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.SfCartesianChart.html?tabs=tabid-1%2Ctabid-3%2Ctabid-6%2Ctabid-8%2Ctabid-10%2Ctabid-12%2Ctabid-25%2Ctabid-27%2Ctabid-29%2Ctabid-23%2Ctabid-14%2Ctabid-37%2Ctabid-17%2Ctabid-19%2Ctabid-21) can be localized by adding resource file.


To localize the Chart based on CurrentUICulture using resource files, follow the below steps.

**Step 1 :** Right-click on the Resources folder, select Add and then NewItem.

**Step 2 :** In Add New Item, select the Resource File option and name the filename as {project name}.{culture name}.resx. For example, give the name as SfCartesianChart.it-IT.resx for Italian culture, The culture name indicates the name of the language and country.

![image.png](https://support.syncfusion.com/kb/agent/attachment/article/13673/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjExMjY4Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.MeD_UlvXRxyMn87DoFYOACNTLCNhwQhsW2looYFWAug)

**Step 3 :** Now, select Add option to add the resource file in Resources folder.

![image.png](https://support.syncfusion.com/kb/agent/attachment/article/13673/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjEwNzgxIiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.QVTiev0KJFscjtPzZn38ZMGQOHqlGAMzGQ7ykCuCV6A)

**Step 4 :** Add the Name/Value pair in Resource Designer of SfCartesianChart.it-IT.resx file and change its corresponding value to corresponding culture.

![image.png](https://support.syncfusion.com/kb/agent/attachment/article/13673/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjEwNzgyIiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.Ym6P6HDlvW9fHSP8bBFyQcA1QFkP54XHPf8qK_iMakA)

**Step 5 :** Now you need to set the CurrentUICulture to the application, the application culture can be changed by setting CurrentUICulture in App.xaml.cs file.

 
 ```C#
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
 ```
 

> <span style="color: green;">*The required resx files with Build Action as EmbeddedResource (File name should contain culture code) into the Resources folder.*</span>

By adhering to these instructions, you will obtain the output as specified below.

![image.png](https://support.syncfusion.com/kb/agent/attachment/article/13673/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjEwNzgzIiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.wxzv5G3YCzCBESim57aFWlf1Ffs75PS54Yu6pjjEQ4w)


**Conclusion**

I hope you enjoyed learning about how to localize the label in the .NET MAUI Chart (SfCartesianChart).

This sample demonstrates how to localize the labels in the chart.Localization is the process of translating the application resources into different language for the specific cultures. The SfCartesianChart can be localized by adding resource file.

![image](https://github.com/SyncfusionExamples/How-to-localize-the-labels-in-.NET-MAUI-Charts-SfCartesianChart/assets/113962276/f874e2dd-e943-4bca-b803-54a61348538f)

