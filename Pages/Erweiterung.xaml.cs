using Project_C14.Code.Classes;
using Project_C14.Code.Structs;
using System.Windows.Controls;

namespace Project_C14;

public partial class Erweiterung : Page
{
    public Erweiterung()
    {
        InitializeComponent();
    }

    private void EditProbeButton_Click(object sender, System.Windows.RoutedEventArgs e)
    {
        Probe probeToEdit = Data.GetProbeByName(NameOfProbeTextBox.Text);

    }

    private void NewProbeButton_Click(object sender, System.Windows.RoutedEventArgs e)
    {
        Data.Create(new Code.Structs.Probe(NameOfProbeTextBox.Text));
    }
}