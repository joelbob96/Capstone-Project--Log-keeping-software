using System.Collections.Generic;
using System;
using System.IO;
using System.Threading.Tasks;

public class Incidents{
  private List<string> incidents;

  public Incidents(){
    incidents = new List<string>();
    string loadedData;
    if (File.Exists("Incidents.csv")) {
    using(StreamReader readtext = new StreamReader("Incidents.csv"))
    {
      if((loadedData = readtext.ReadLine()) != null){
        string [] loc = loadedData.Split(',');
        for(int i = 0; i < loc.Length; i++){
          incidents.Add(loc[i]);
        }
        incidents.Sort();
      }
    }
    }
  }

  public void printIncidents(){
    foreach(string inc in incidents){
      Console.WriteLine(inc);
    }
  }
 
}