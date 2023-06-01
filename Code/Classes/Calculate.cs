using System;
using Project_C14.Code.Structs;
// ReSharper disable SuggestVarOrType_BuiltInTypes

namespace Project_C14.Code.Classes;

public class Calculate
{
    // Constants
    private const double N0 = 6.02214179e23; // Avogadro's number
    private const double lambda0 = 1.2093e-4; // Decay constant at sea level and zero geomagnetic field
    private const double deltaLambda = -0.00012; // Change in decay constant per unit change in geomagnetic field
    private const double R = 8.3144621; // Gas constant
       
    // Calculations
    public static Probe CalcProbe(Probe probeToCalc)
    {
        double lambda = lambda0 + (deltaLambda / 1000) * probeToCalc.GeomagneticFieldStrengthInMicroteslas; // Decay constant adjusted for geomagnetic field
        double h = probeToCalc.SampleHeightInMeters / 1000; // Height above sea level in kilometers
        double pressureCorrection = (1013.25 / probeToCalc.PressureInPascal) * Math.Pow(1 - ((0.0065 * h) / 288.15), 5.255); // Pressure correction factor
        double temperatureCorrection = 1 / (1 + 0.0003 * (probeToCalc.TemperatureInKelvin - 273.15)); // Temperature correction factor
        double fractionModern = probeToCalc.SampleC14InAtomsPerGramOfCarbon / probeToCalc.AtmosphericC14InAtomsPerGramOfCarbon; // Fraction of modern C14
        double years = (-1 / lambda) * Math.Log(fractionModern) / Math.Log(2); // Age of sample in years
        const double deltaR = 0.13; // Correction factor for carbon reservoir age
        double deltaC14 = (probeToCalc.SampleC14InAtomsPerGramOfCarbon / probeToCalc.SampleCarbonInGrams) / (N0 / 1000) * deltaR; // Correction factor for isotopic fractionation
        double correctedYears = years - deltaC14; // Age of sample corrected for isotopic fractionation
        double effectiveResult = correctedYears * pressureCorrection * temperatureCorrection;

        probeToCalc.EffectiveAge = effectiveResult;
        return probeToCalc;
    }
}