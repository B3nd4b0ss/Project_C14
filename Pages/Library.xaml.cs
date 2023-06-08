using System.Windows;
using Project_C14.Code.Structs;
using System.Windows.Controls;
using Project_C14.Code.Classes;

namespace Project_C14;

public partial class Library : Page
{
    public Library()
    {
        InitializeComponent();

        RemoveChilds();
        
        foreach (Probe probe in Data.GetProbes())
        {
            Button ProbeButton = new Button();
            ProbeButton.Style = (Style)FindResource("CalculateButton");
            ProbeButton.Content = probe.ProbeName;
            ProbeButton.Click += ProbeButtonOnClick;
            
            ListedProbesStackPanel.Children.Add(ProbeButton);
        }
    }

    private void ProbeButtonOnClick(object sender, RoutedEventArgs e)
    {
        Button clickedButton = sender as Button;
        Erweiterung.ImportProbeName = clickedButton.Content.ToString();
        Erweiterung.LoadStringProbe = true;
        Erweiterung.LastWasLoaded = true;
        MainWindow.UpdateTo("Erweiterung");
    }

    private void RemoveChilds()
    {
        foreach (UIElement child in ListedProbesStackPanel.Children)
        {
            ListedProbesStackPanel.Children.Remove(child);
        }
    }
}