using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

class LogEntry{
  private string date;
  private string startTime;
  private string endTime;
  private string location;
  private string incidentType;
  private string description;
  private List<Officer> officers;
  
  public LogEntry(string date1, string st, string et, string l, string it, string d, List<Officer> o){
    date = date1;
    startTime = st;
    endTime = et;
    location = l;
    incidentType = it;
    description = d;
    officers = o;
  }
  public LogEntry(){
    date = "00.00.0000";
    startTime = "0";
    endTime = "0";
    location = "default location";
    incidentType = "default incident type";
    description = "default description";
    Officer O1 = new Officer();
    officers = new List<Officer>();
    officers.Add(O1);
  }

  public string getDate(){
    return date;
  }
  public string getStartTime(){
    return startTime;
  }
  public string getEndTime(){
    return endTime;
  }
  public string getLocation(){
    return location;
  }

    public string getIncidentType()
    {
        return incidentType;
    }
  public string getDescription(){
    return description;
  }
  public List<Officer> getOfficers(){
    return officers;
  }

  public void printLog(){
    string output = date + startTime + endTime + location + incidentType + description + printOfficers();

    Console.WriteLine(output);
  }

  public string printOfficers(){
    string output = "";

    /*foreach(var Officer in officers){
      output += Officer.getOfficer() + ',';
    }*/
    for(int i = 0; i < officers.Count; i++){
      output += officers[i].getOfficer();
      if(i != (officers.Count) - 1)output += ',';
    }

    return output;
  }

  public void SaveLog(){
    string name = "C:\\DispatchFiles\\LogEntries\\" + incidentType + date + startTime + "to" + endTime + ".csv";

    string data = date + ',' + startTime + ',' + endTime + ',' + location + ',' + incidentType + ',' + description + ',' + printOfficers();

    using (StreamWriter writer = new StreamWriter(name))  
      {  
      writer.WriteLine(data);  
        }
    }

  public void LoadLog(string f1){
    string loadedData;
        string fileName = "C:\\DispatchFiles\\LogEntries\\" + f1;
    if (File.Exists(fileName)) {
    using(StreamReader readtext = new StreamReader(fileName))
    {
      if((loadedData = readtext.ReadLine()) != null){
      //System.Console.WriteLine(loadedData);
      string [] data = loadedData.Split(',');
      date = data[0];
      startTime = data[1];
      endTime = data[2];
      location = data[3];
      incidentType = data[4];
      description = data[5];
      officers.Clear();
      for(int i = 6; i < data.Length; i++){
        string [] off = data[i].Split(' ');
        Officer o1 = new Officer(off[0], off[1], System.Convert.ToInt32(off[2]));
        officers.Add(o1);
      }
      }
    }
    }else{
      Console.WriteLine("File " + fileName + " could not be found");
    }
  }

}
