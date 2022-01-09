using System.Collections.Generic;
using System;

class Officer{

private string fname;
private string lname;
private int badge;

public Officer(string fn, string ln, int b){
  fname = fn;
  lname = ln;
  badge = b;
}
public Officer(){
  fname = "default";
  lname = "default";
  badge = 0;
}

    public string getFName()
    {
        return fname;
    }
    public string getLName()
    {
        return lname;
    }
    public int getBadge()
    {
        return badge;
    }

public void printOfficer(){
 Console.WriteLine(fname + lname + badge);
}

public string getOfficer(){
  string output = fname + ' ' + lname + ' ' + badge;
  return output;
}
}