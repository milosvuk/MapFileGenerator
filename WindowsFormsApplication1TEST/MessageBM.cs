using System;
using System.Collections.Generic;
using System.Collections;
//using System.Linq;
using System.Text;
using System.IO;


 public class MessageBM
 {

     public static ArrayList alUniqueName = new ArrayList();

     public string Name {get;set;}
     public string Type  { get; set; }  // N - numeric A- Alfanumeric (string)
     public int PositionInString { get; set; } 
     public string Defaultvalue {get;set;}
     public string Defaultvalueplain {get;set;}
     public int Leng {get;set;}
     public string Padding {get;set;}
     public int DynamicValue {get;set;}

     public string ClassName { get; set; }

     private string RemoveBadChar(string ToBeUpdated)
     {
         string prop1 = ToBeUpdated.Replace(" ", "");
         string prop2 = prop1.Replace("@", "");
         string prop3 = prop2.Replace("%", "");
         string prop4 = prop3.Replace("!", "");
         string prop5 = prop4.Replace("#", "");
         string prop6 = prop5.Replace("$", "");
         string prop7 = prop6.Replace(".", "");
         string prop8 = prop7.Replace("/", "");
         string prop9 = prop8.Replace("_", "_");
         string prop10 = prop9.Replace("-", "");
         string prop11 = prop10.Replace("?", "");

         string prop12 = prop11;
         if (prop11[0].ToString().CompareTo("1") == 0)
         {
             prop12 = prop11.Substring(1, prop11.Length - 1);
         }

         return prop12;
     }

     private string GetClassNameFromFirstLineOfFile(string line0)
     {
         string temp = "";

         if (line0.IndexOf(",") > -1)
         {
             string[] t = line0.Split(',');
             temp = RemoveBadChar(t[0]);
         }
         else
         {
             temp = RemoveBadChar(line0);
         }

         return temp;
     }

     private bool IsRecordFromCSVFileValid(string[] fields)
     {
         bool res = true;

         for (int i = 0; i<fields.Length; i++)
         {
             if (fields[i].CompareTo("") == 0 || fields[i]==null)
             {
                 res = false;
                 return res;
             }
         }

         return res;
     }

     public void SaveClassToFile(string filename, List<MessageBM> listOfMessages)
     {
         string[] lines = new string[listOfMessages.Count];

         for (int i = 0; i < listOfMessages.Count; i++)
         {
             MessageBM objMessage = new MessageBM();
             objMessage = (MessageBM)listOfMessages[i];

             lines[i] = objMessage.Name + "," + objMessage.Defaultvalue;

         }

         File.WriteAllLines(filename, lines);

     }

     public List<MessageBM> GetFromCSVFile(string fileName)
     {
         alUniqueName.Clear();

         List<MessageBM> listResults = new List<MessageBM>();

         string[] linesOfFile = File.ReadAllLines(fileName);


         ClassName = GetClassNameFromFirstLineOfFile(linesOfFile[0]);

         for (int i=3;i<linesOfFile.Length;i++)
         {
            // try
            // {
                
                 if (linesOfFile[i].ToString()[0].CompareTo(',')!=0)  // the first char must not be coma ,
                 {
                     string[] fields = linesOfFile[i].ToString().Split(',');
                     MessageBM tmpMessageBM = new MessageBM();
                     tmpMessageBM.Defaultvalue = fields[4];
                      string tmpOne =  fields[4].Replace("[","");
                      string tmpTwo = tmpOne.Replace("]","");
                      tmpMessageBM.Defaultvalueplain = tmpTwo;
                                   
                     tmpMessageBM.Leng = int.Parse(fields[1]);
                     tmpMessageBM.Name = RemoveBadChar(fields[2]);
                     tmpMessageBM.Padding = fields[5];

                         int addToFieldToBeUn = 0;
                         while (addToFieldToBeUn!=-1)
                         {
                             //if (fields[2])
                             addToFieldToBeUn = addToFieldToBeUn + 1;
                             if (alUniqueName.IndexOf(tmpMessageBM.Name)>-1)
                             {
                                 tmpMessageBM.Name = tmpMessageBM.Name + addToFieldToBeUn.ToString();
                             }
                             else
                             {
                               alUniqueName.Add(tmpMessageBM.Name);
                               addToFieldToBeUn=-1;
                             }
                                                  
                         }
                     //tmpMessageBM
                     listResults.Add(tmpMessageBM);
                 }
                 

             //}
             //catch
             //{
                 // maybe i the line of cSV file 
             //}
         }


         return listResults;
     }

     public static string GetFullPath()
         {
             string _fullPath = "";
             string tmpPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
             char delimeter = char.Parse(@"\");

             string[] tmp = tmpPath.Split(delimeter);

             int last = tmp.Length - 1;

             for (int i = 0; i < last; i++)
             {
                 if (i == 0)
                 {
                     _fullPath = _fullPath + tmp[i] + delimeter.ToString();
                 }
                 else
                 {
                     _fullPath = _fullPath + tmp[i] + delimeter.ToString();
                 }
             }

             return _fullPath;
         }

     public void CreateCsharpClassFromCSVFile(string csvFilename)
     {
         ArrayList alC = new ArrayList();
         List<MessageBM> listformCSV = GetFromCSVFile(csvFilename);

         
         string classname = RemoveBadChar(ClassName);
         string fnameCs =  GetFullPath() + classname + ".cs";
            // part for Class
           
             alC.Add("using System;");
             alC.Add("using System.Collections.Generic;");
             alC.Add("using System.Linq;");
             alC.Add("using System.Text;");
             alC.Add("using System.Threading.Tasks;");
             alC.Add(" ");

             string c = "public class " + classname;
             alC.Add(c);
             alC.Add("{");

             string GetSet = " { get; set; } ";

             string defaulValue = "";
             for (int x = 0; x < listformCSV.Count; x++)
             {
                 
                 string resCs = "public string " + listformCSV[x].Name + GetSet;
                 defaulValue = defaulValue + listformCSV[x].Defaultvalueplain;
                 alC.Add(resCs);
             }

             alC.Add(" ");
             alC.Add(" ");

             ///

              alC.Add(" public string GetDefaultString() ");
                  alC.Add("{");
                  char Navodnici = '"';
                  string toreturn = "return " + Navodnici.ToString() + defaulValue + Navodnici.ToString() + ";";
                  alC.Add(toreturn); 
                  alC.Add("}"); 
                  alC.Add(" ");
            
             //

              alC.Add(" public void SetDefaultValue()");
                  alC.Add("{");

                  for (int b = 0; b < listformCSV.Count; b++)
                  {

                      string tmpRes = listformCSV[b].Name + "=" + Navodnici.ToString() + listformCSV[b].Defaultvalueplain + Navodnici.ToString() + ";";
                      alC.Add(tmpRes);

                      //   alCol.Add(tmpValueWithOutNavodnici[1]);
                      //   alFirstPartForExcel.Add(tmpNameWithOutNavodnici[1]);
                  }
                  alC.Add("}");

             //

                  alC.Add(" public string GetStringFromFields() ");
                  alC.Add("{");

                  string resT = "";
                  for (int b = 0; b < listformCSV.Count; b++)
                  {

                      string tmpResWithPlus = listformCSV[b].Name + "+"; //
                      if (b != listformCSV.Count - 1)
                      {
                          resT = resT + tmpResWithPlus;
                      }
                      if (b == listformCSV.Count - 1)
                      {
                          resT = resT + listformCSV[b].Name;
                      }

                      //alC.Add(tmpRes);

                      //   alCol.Add(tmpValueWithOutNavodnici[1]);
                      //   alFirstPartForExcel.Add(tmpNameWithOutNavodnici[1]);
                  }


                  toreturn = "return " + resT + ";";
                  alC.Add(toreturn);
                  alC.Add("}");
                  alC.Add(" ");

                  // end

                  alC.Add("}");
                  // string Sequence_Number { get; set; }

                  ArrayListToFile(alC, fnameCs);

     }

     public void ArrayListToFile(ArrayList alwr, string filename)
     {

         int nlinew = 0;
         try
         {
             StreamWriter sw = File.CreateText(filename);
             for (int i = 0; i < alwr.Count; i++)
             {
                 nlinew = i;
                 sw.WriteLine(alwr[i].ToString());
             }
             sw.Close();
         }
         catch
         {
             //this.WriteLogFile(nlinew, "Writing File");
         }
     }
 }

