using System.Collections.Generic;
using Project_C14.Code.Classes;
using Project_C14.Code.Structs;
using System.Windows;
using System.Windows.Controls;
using static System.String;

namespace Project_C14;

public partial class Erweiterung : Page
{
    public Probe advancedProbe;
    public static bool LoadStringProbe;
    public static string ImportProbeName;
    public static bool LastWasLoaded;

    private static Erweiterung _erweiterungPage = new();

    public Erweiterung()
    {
        InitializeComponent();
        _erweiterungPage = this;
        EditSelectedProbe();
    }

    private void EditProbeButton_Click(object sender, RoutedEventArgs e)
    {
        if (Data.GetProbeByName(NameOfProbeTextBox.Text).ProbeName == null)
        {
            MessageBox.Show("Es existiert keine Probe mit diesem Namen!");
            return;
        }

        var Probename = NameOfProbeTextBox.Text;

        EditProbe(Probename);
    }

    private static void EditSelectedProbe()
    {
        if (!LoadStringProbe) return;
        _erweiterungPage.EditProbe(ImportProbeName);
        LoadStringProbe = false;
    }

    private void EditProbe(string Probename)
    {
        advancedProbe = Data.GetProbeByName(Probename);

        ProbeNameTextBox.Text = advancedProbe.ProbeName;
        AtmosphericC14InAtomsPerGramOfCarbonTextBox.Text =
            advancedProbe.AtmosphericC14InAtomsPerGramOfCarbon.ToString();
        SampleC14InAtomsPerGramOfCarbonTextBox.Text = advancedProbe.SampleC14InAtomsPerGramOfCarbon.ToString();
        SampleCarbonInGramsTextBox.Text = advancedProbe.SampleCarbonInGrams.ToString();
        SampleHeightInMetersTextBox.Text = advancedProbe.SampleHeightInMeters.ToString();
        GeomagneticFieldStrengthInMicroteslasTextBox.Text =
            advancedProbe.GeomagneticFieldStrengthInMicroteslas.ToString();
        TemperatureInKelvinTextBox.Text = advancedProbe.TemperatureInKelvin.ToString();
        PressureInPascalTextBox.Text = advancedProbe.PressureInPascal.ToString();
    }

    private void NewProbeButton_Click(object sender, RoutedEventArgs e)
    {
        LastWasLoaded = false;

        if (NameOfProbeTextBox.Text == "")
        {
            MessageBox.Show("Probenname kann nicht Leer sein!");
            return;
        }

        if (Data.GetProbeByName(NameOfProbeTextBox.Text).ProbeName == null)
        {
            Data.Create(new Probe(NameOfProbeTextBox.Text));
            EditProbeButton_Click(sender, e);
        }
        else
        {
            MessageBox.Show("Es gibt bereits eine Probe mit diesem Namen!");
        }
    }

    private void CalculateButton_Click(object sender, System.Windows.RoutedEventArgs e)
    {
        advancedProbe = Calculate.CalcProbe(advancedProbe);
        ResultLabel.Content = advancedProbe.EffectiveAge;
    }

    private void SaveProbeButton_Click(object sender, RoutedEventArgs e)
    {
        var Probename = Empty;

        if (advancedProbe.ProbeName == null)
        {
            return;
        }

        Probename = NameOfProbeTextBox.Text;
        if (LastWasLoaded)
        {
            Probename = ImportProbeName;
            LastWasLoaded = false;
        }


        advancedProbe.ProbeName = ProbeNameTextBox.Text;
        advancedProbe.AtmosphericC14InAtomsPerGramOfCarbon =
            double.Parse(AtmosphericC14InAtomsPerGramOfCarbonTextBox.Text);
        advancedProbe.SampleC14InAtomsPerGramOfCarbon = double.Parse(SampleC14InAtomsPerGramOfCarbonTextBox.Text);
        advancedProbe.SampleCarbonInGrams = double.Parse(SampleCarbonInGramsTextBox.Text);
        advancedProbe.SampleHeightInMeters = double.Parse(SampleHeightInMetersTextBox.Text);
        advancedProbe.GeomagneticFieldStrengthInMicroteslas =
            double.Parse(GeomagneticFieldStrengthInMicroteslasTextBox.Text);
        advancedProbe.TemperatureInKelvin = double.Parse(TemperatureInKelvinTextBox.Text);
        advancedProbe.PressureInPascal = double.Parse(PressureInPascalTextBox.Text);

        Data.Edit(Data.GetProbeByName(Probename), advancedProbe);

        MessageBox.Show("Erfolgreich gespeichert!");
    }

    private void ClearAllProbesButton_OnClick(object sender, RoutedEventArgs e)
    {
        LastWasLoaded = false;
        Data.ClearAllProbes(true);
    }
}