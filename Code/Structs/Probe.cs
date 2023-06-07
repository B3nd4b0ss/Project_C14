namespace Project_C14.Code.Structs;

public struct Probe
{
    public Probe(string probeName)
    {
        ProbeName = probeName;
    }
    
    // Inputs
    public string ProbeName { get; }
    public double AtmosphericC14InAtomsPerGramOfCarbon { get; set; } // Atmospheric C14 concentration in atoms per gram of carbon
    public double SampleC14InAtomsPerGramOfCarbon { get; set; } // C14 concentration in sample in atoms per gram of carbon
    public double SampleCarbonInGrams { get; set; } // Total carbon in sample in grams
    public double SampleHeightInMeters { get; set; } // Height above sea level in meters
    public double GeomagneticFieldStrengthInMicroteslas { get; set; } // Geomagnetic field strength in microteslas
    public double TemperatureInKelvin { get; set; } // Temperature in Kelvin
    public double PressureInPascal { get; set; } // Pressure in Pascals
    public double EffectiveAge { get; set; } // Effective Age after Calculation
    
    public double ReferencC14 { get; set; } // C14 Concentration for Simple Reference
    public double SampleC14 { get; set; } // C14 Concentration for Simple Sample
    public double SimpleAge { get; set; } // Simple Age after Calculation

    
}
