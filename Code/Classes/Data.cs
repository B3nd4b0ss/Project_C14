using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Project_C14.Code.Structs;

namespace Project_C14.Code.Classes;

/// <summary>
/// Call Data.Initialize() before anything else related to the Data-Class.
/// </summary>
public static class Data
{
    private static List<Probe>? _probes;
    private const string SaveFile = "./Probes.json";

    public static void Initialize()
    {
        _probes = new List<Probe>();
        _probes.Clear();
    }

    public static void Create(Probe newProbe)
    {
        _probes!.Add(newProbe);
    }

    public static void Edit(Probe oldProbe, Probe nProbe)
    {
        _probes.Remove(oldProbe); 
        Create(nProbe);
    }

    /// <summary>
    /// First deletes all content in the Probes.json file. Then
    /// writes the, in the _probes list saved, probes to the Probes.json file.
    /// After this the list won't be cleared.
    /// These probes can be loaded with the LoadProbes() function back into the List.
    /// </summary>

    public static void SaveProbe()
    {
        File.WriteAllText(SaveFile, null);
        File.WriteAllText(SaveFile, JsonConvert.SerializeObject(_probes));
    }

    /// <summary>
    /// Loads all the probes that are saved in the file Probes.json into the _probes list.
    /// The file won't be cleared after this action.
    /// </summary>
    public static void LoadProbes()
    {
        if (File.Exists(SaveFile))
        {
            _probes = JsonConvert.DeserializeObject<List<Probe>>(File.ReadAllText(SaveFile));
        }
        else
        {
            File.Create(SaveFile);
        }
    }

    /// <summary>
    /// Clears all saved probes from the list _probes.
    /// </summary>
    /// <param name="alsoFile">If set to true, the file gets also cleared</param>
    public static void ClearAllProbes(bool alsoFile)
    {
        if (_probes != null)
            _probes!.Clear();

        if (alsoFile)
            File.WriteAllText(SaveFile, null);
    }

    public static Probe GetProbeByName(string probeName)
    {
        var result = _probes.FirstOrDefault(x => x.ProbeName == probeName);
        return result;
    }

    public static Probe[] GetProbes()
    {
        return _probes?.ToArray();
    }

    public static string ExportFile(string pathToExportDir)
    {
        string pathToExportedFile = pathToExportDir + "Probes.json";

        File.Copy(SaveFile, pathToExportedFile, true);

        return pathToExportedFile;
    }

    public static void ImportFile(string pathToImportFile)
    {
        File.Copy(pathToImportFile, SaveFile, true);
    }

    public static void PushProbes()
    {
        
    }

    public static void PullProbes()
    {
        
    }
}
