using System;
using System.Windows;
using System.Windows.Controls;
using Project_C14.Code.Structs;

namespace Project_C14;

public partial class Main : Page
{
    public Main()
    {
        InitializeComponent();
    }

    private void CalculateBtn_Click(object sender, RoutedEventArgs e)
    {
        Probe simpleProbe = new Probe("SimpleProbe");

        double reference = Double.Parse(ReferenceC14TextBox.Text);
        double sample = Double.Parse(SampleC14TextBox.Text);
        
        simpleProbe.ReferencC14 = reference;
        simpleProbe.SampleC14 = sample;
        simpleProbe = Code.Classes.Calculate.SimpleCalc(simpleProbe);

        OutputLabel.Content = Math.Round(simpleProbe.SimpleAge);
    }
}