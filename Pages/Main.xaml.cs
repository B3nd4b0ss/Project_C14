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

        double reference;
        double sample;

        if (double.TryParse(ReferenceC14TextBox.Text, out reference))
        {
            simpleProbe.ReferencC14 = reference;
        }
        else
        {
            simpleProbe.ReferencC14 = 1.22104E-12;
        }

        if (double.TryParse(SampleC14TextBox.Text, out sample))
        {
            simpleProbe.SampleC14 = sample;
            simpleProbe = Code.Classes.Calculate.SimpleCalc(simpleProbe);

            OutputLabel.Content = Math.Round(simpleProbe.SimpleAge);
        }
    }
}