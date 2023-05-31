using System;
using Project_C14.Code.Structs;

namespace Project_C14.Code.Classes;

public class Calculate
{
    // Constants
    static double N0 = 6.02214179e23; // Avogadro's number
    static double lambda0 = 1.2093e-4; // Decay constant at sea level and zero geomagnetic field
    static double deltaLambda = -0.00012; // Change in decay constant per unit change in geomagnetic field
    static double R = 8.3144621; // Gas constant
       
    // Inputs
    static double atmosphericC14 = 226.2; // Atmospheric C14 concentration in atoms per gram of carbon
    static double sampleC14; // C14 concentration in sample in atoms per gram of carbon
    static double sampleCarbon; // Total carbon in sample in grams
    static double sampleWeight; // Sample weight in grams
    static double sampleHeight; // Height above sea level in meters
    static double geomagneticFieldStrength; // Geomagnetic field strength in microteslas
    static double temperature; // Temperature in Kelvin
    static double pressure; // Pressure in Pascals
       
    // Calculations
    public static Probe CalcProbe(Probe probeToCalc)
    {
        double lambda = lambda0 + (deltaLambda / 1000) * geomagneticFieldStrength; // Decay constant adjusted for geomagnetic field
        double h = sampleHeight / 1000; // Height above sea level in kilometers
        double pressureCorrection = (1013.25 / pressure) * Math.Pow(1 - ((0.0065 * h) / 288.15), 5.255); // Pressure correction factor
        double temperatureCorrection = 1 / (1 + 0.0003 * (temperature - 273.15)); // Temperature correction factor
        double fractionModern = sampleC14 / atmosphericC14; // Fraction of modern C14
        double years = (-1 / lambda) * Math.Log(fractionModern) / Math.Log(2); // Age of sample in years
        double deltaR = 0.13; // Correction factor for carbon reservoir age
        double deltaC14 = (sampleC14 / sampleCarbon) / (N0 / 1000) * deltaR; // Correction factor for isotopic fractionation
        double correctedYears = years - deltaC14; // Age of sample corrected for isotopic fractionation
        double effectiveResult = correctedYears * pressureCorrection * temperatureCorrection;
        
        return probeToCalc;
    }
}