namespace Project_C14.Code.Structs;

public struct Probe
{
    public Probe(string probeName)
    {
        ProbeName = probeName;
    }

    // Constants
    public const double N0 = 6.02214179e23;// Avogadro's number
    public const double Lambda0 = 1.2093e-4; // Decay constant at sea level and zero geomagnetic field
    public const double DeltaLambda = -0.00012; // Change in decay constant per unit change in geomagnetic field
    public const double R = 8.3144621; // Gas constant

    // Inputs
    public string ProbeName { get; }
    public double AtmosphericC14InAtomsPerGramOfCarbon { get; set; } // Atmospheric C14 concentration in atoms per gram of carbon
    public double SampleC14InAtomsPerGramOfCarbon { get; set; } // C14 concentration in sample in atoms per gram of carbon
    public double SampleCarbonInGrams { get; set; } // Total carbon in sample in grams
    public double SampleWeightInGrams { get; set; } // Sample weight in grams
    public double SampleHeightInMeters { get; set; } // Height above sea level in meters
    public double GeomagneticFieldStrengthInMicroteslas { get; set; } // Geomagnetic field strength in microteslas
    public double TemperatureInKelvin { get; set; } // Temperature in Kelvin
    public double PressureInPascal { get; set; } // Pressure in Pascals
    
    public double EffectiveAge { get; set; } // Effective Age after Calculation

    /*
     // Constants
       double N0 = 6.02214179e23; // Avogadro's number
       double lambda0 = 1.2093e-4; // Decay constant at sea level and zero geomagnetic field
       double deltaLambda = -0.00012; // Change in decay constant per unit change in geomagnetic field
       double R = 8.3144621; // Gas constant
       
       // Inputs
       double atmosphericC14 = 226.2; // Atmospheric C14 concentration in atoms per gram of carbon
       double sampleC14; // C14 concentration in sample in atoms per gram of carbon
       double sampleCarbon; // Total carbon in sample in grams
       double sampleWeight; // Sample weight in grams
       double sampleHeight; // Height above sea level in meters
       double geomagneticFieldStrength; // Geomagnetic field strength in microteslas
       double temperature; // Temperature in Kelvin
       double pressure; // Pressure in Pascals
       
       // Calculations
       double lambda = lambda0 + (deltaLambda / 1000) * geomagneticFieldStrength; // Decay constant adjusted for geomagnetic field
       double h = sampleHeight / 1000; // Height above sea level in kilometers
       double pressureCorrection = (1013.25 / pressure) * ((1 - ((0.0065 * h) / 288.15)) ^ 5.255); // Pressure correction factor
       double temperatureCorrection = 1 / (1 + 0.0003 * (temperature - 273.15)); // Temperature correction factor
       double fractionModern = sampleC14 / atmosphericC14; // Fraction of modern C14
       double years = (-1 / lambda) * Math.Log(fractionModern) / Math.Log(2); // Age of sample in years
       double deltaR = 0.13; // Correction factor for carbon reservoir age
       double deltaC14 = (sampleC14 / sampleCarbon) / (N0 / 1000) * deltaR; // Correction factor for isotopic fractionation
       double correctedYears = years - deltaC14; // Age of sample corrected for isotopic fractionation
       double effectiveResult = correctedYears * pressureCorrection * temperatureCorrection;
       
       // Output
       Console.WriteLine("Sample age: " + correctedYears * pressureCorrection * temperatureCorrection + " years");
       
     */
};