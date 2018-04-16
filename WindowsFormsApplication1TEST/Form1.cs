using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Device;
using System.Device.Location;
using System.IO;

namespace WindowsFormsApplication1TEST
{
    public partial class Form1 : Form
    {
        public static string pCon = @"Data Source=KOMP-PC\SQLEXPRESS;Initial Catalog=mecmatch;Persist Security Info=True;User ID=sa;Password=Dvuk1968!";

        public Form1()
        {
            InitializeComponent();
        }





        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int y = 0;
                int x = 5 / y;
            }
            catch (Exception ex)
            {
                Utilities.LoggerImplementation logtext = new Utilities.TextFileLogger();

                Utilities.ExceptionLogger elog = new Utilities.ExceptionLogger();
                elog.AddLogger(logtext); 
                elog.NotificationType = Utilities.NotificationType.Silent;
                elog.LogException(ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 10;
            string logData = "Button2 click, after x=10";
            Utilities.LoggerImplementation logtext = new Utilities.TextFileLogger();

            Utilities.ExceptionLogger elog = new Utilities.ExceptionLogger();
            elog.AddLogger(logtext);
            elog.NotificationType = Utilities.NotificationType.Silent;

            elog.LogData(logData);
            int y = 20;
            logData = "Button2 click, after y = 20;";
            elog.LogData(logData);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TxtFile tx = new TxtFile();
            openFileDialog1.ShowDialog();
            tx.FileName = openFileDialog1.FileName;

            this.saveFileDialog1.ShowDialog();
            string lastname = saveFileDialog1.FileName;

            ArrayList al = tx.FileToArrayList();

            ArrayList al2 = new ArrayList();

            for (int i = 0; i < al.Count; i++)
            {
                string f = al[i].ToString();
                string[] parts = f.Split(',');

                double plat1 = double.Parse(parts[0]);
                double plong1 = double.Parse(parts[1]);

                double plat2 = double.Parse(parts[2]);
                double plong2 = double.Parse(parts[3]);

                double res = getDistinMeters(plat1, plong1, plat2, plong2);

                string finalstring = f + ";" + res.ToString();
                al2.Add(finalstring);

            }


            tx.FileName = lastname;
            tx.ArrayListToFile(al2);
            MessageBox.Show("done");
        }

        public double getDistinMeters(double sLatitude, double sLongitude, double eLatitude, double eLongitude)
        {
            double res = 0;

            var sCoord = new GeoCoordinate(sLatitude, sLongitude);
            var eCoord = new GeoCoordinate(eLatitude, eLongitude);

            res = sCoord.GetDistanceTo(eCoord);

            return res;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            TxtFile tx = new TxtFile();
            tx.FileName = this.openFileDialog1.FileName;

            ArrayList al = tx.FileToArrayList();

            DB_countryoforigin dbcountruorigin = new DB_countryoforigin();
            dbcountruorigin.connectionString = pCon;

            DB_countryofresidences dbcountryresidence = new DB_countryofresidences();
            dbcountryresidence.connectionString = pCon;

            for (int i = 0; i < al.Count; i++)
            {
                string cname = al[i].ToString();
                countryoforigin obj = new countryoforigin();

                obj.DESCRIPTION = cname;

                dbcountruorigin.Add(obj);

                countryofresidences obj1 = new countryofresidences();
                obj1.DESCRIPTION = cname;

                dbcountryresidence.Add(obj1);
            }

            MessageBox.Show("Done");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            TxtFile tx = new TxtFile();
            tx.FileName = this.openFileDialog1.FileName;

            ArrayList al = tx.FileToArrayList();

            DB_language dblng = new DB_language();
            dblng.connectionString = pCon;

            for (int i = 0; i < al.Count; i++)
            {
                string cname = al[i].ToString();

                string[] tmp = cname.Split(',');
                
                language obj = new language();



                obj.DESCRIPTION = tmp[3];

                dblng.Add(obj);

                 
            }

            MessageBox.Show("Done");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            TxtFile tx = new TxtFile();
            tx.FileName = this.openFileDialog1.FileName;

            ArrayList al = tx.FileToArrayList();

            DB_occupation db = new DB_occupation();
            
            db.connectionString = pCon;

            for (int i = 0; i < al.Count; i++)
            {
                string cname = al[i].ToString();
                                
                occupation obj = new occupation();
                
                obj.DESCRIPTION = cname;

                db.Add(obj);


            }

            MessageBox.Show("Done");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            TxtFile tx = new TxtFile();
            tx.FileName = this.openFileDialog1.FileName;

            ArrayList al = tx.FileToArrayList();

            DB_usastates db = new DB_usastates();
          
            db.connectionString = pCon;

            for (int i = 0; i < al.Count; i++)
            {
                string cname = al[i].ToString();

                string[] tmp = cname.Split(',');

                usastates obj = new usastates();



                obj.DESCRIPTION = tmp[0];

                db.Add(obj);


            }

            MessageBox.Show("Done");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            TxtFile tx = new TxtFile();
            tx.FileName = this.openFileDialog1.FileName;

            ArrayList al = tx.FileToArrayList();

            DB_usacity db = new  DB_usacity();

            db.connectionString = pCon;

            for (int i = 0; i < al.Count; i++)
            {
                string cname = al[i].ToString();

                string[] tmp = cname.Split(',');

                usacity obj = new usacity();



                obj.DESCRIPTION = cname;// tmp[1];

                db.Add(obj);


            }

            MessageBox.Show("Done");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string _body = "Test g.d";       
            ArrayList al = new ArrayList();
            al.Add("dvukelic68@gmail.com");


            //string res  = E_mail.SendEmailFromGoDaddy("Info", "Test", "info@mecmatch.com", "dvukelic68@gmail.com",false, "info@mecmatch.com", "Dj2018???");

            E_mail.SendEmail_MECMatch(al);
            

            

            MessageBox.Show("D");

        }

        private void button10_Click(object sender, EventArgs e)
        {

            
            

            this.openFileDialog1.ShowDialog();

            TxtFile tx = new TxtFile();
            tx.FileName = this.openFileDialog1.FileName;

            ArrayList al = tx.FileToArrayList();

            for (int i = 0; i < al.Count; i++)
            {
                this.listBox1.Items.Add(al[i].ToString());
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {

            string xmlFile = Application.StartupPath + @"\DynamicConfiguration.xml";

            DataSet dsOrders = new DataSet();
            dsOrders.ReadXml(xmlFile);

            int i = 0;
            foreach (DataTable dt in dsOrders.Tables)
            {
                //listBox1.Items.Add(dt.TableName);
                i = i + 1;
                notifyIcon1.Text = i.ToString();
                string filePath = Application.StartupPath + @"\File" + i.ToString() + ".txt";
                Write(dt, filePath);
            }

            MessageBox.Show("Done");

        }


        public static void Write(DataTable dt, string filePath)
        {
            int i = 0;
            StreamWriter sw = null;

            try
            {

                sw = new StreamWriter(filePath, false);


                for (i = 0; i < dt.Columns.Count - 1; i++)
                {

                    sw.Write(dt.Columns[i].ColumnName + ",");

                }
                sw.Write(dt.Columns[i].ColumnName);
                sw.WriteLine();


                foreach (DataRow row in dt.Rows)
                {
                    object[] array = row.ItemArray;

                    for (i = 0; i < array.Length - 1; i++)
                    {
                        sw.Write(array[i].ToString() + ",");
                    }
                    sw.Write(array[i].ToString());
                    sw.WriteLine();

                }

                sw.Close();
            }

            catch (Exception ex)
            {
                // MessageBox.Show("Invalid Operation : \n" + ex.ToString(),  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
             string fname = Application.StartupPath + @"\DynamicConfiguration.xml";

             string[] allLines = File.ReadAllLines(fname);

             TxtFile txtObj = new TxtFile();
             ArrayList al = new ArrayList();
             listBox1.Items.Clear();

             int inMessage = 0;
             int inRequest = 0;
             int inProperties = 0;
             

             for (int i = 0; i < allLines.Length; i++)
             {
                 string line = allLines[i];
                
                 listBox1.Items.Add(line);



                 if (line.IndexOf("<message name=") > -1)
                 {
                     // the name of file and class
                     al.Clear();
                     
                     string[] nameOfclass = line.Split('"');
                     al.Add(nameOfclass[1]);
                    listBox2.Items.Add(nameOfclass[1]);
                     
                     txtObj.FileName = Application.StartupPath + @"\" + nameOfclass[1] + ".map";
                     inMessage = 1;
                 } // END MESSAGE ONE

                     if (line.IndexOf("<request>") > -1 && inMessage==1)
                     {
                         // take only request
                         inRequest = 1;                       

                     } // End IF request

                         if (line.IndexOf("<property name=") > -1 && inMessage == 1 && inRequest==1)
                         {

                             string[] parts = line.Split(' ');

                             int start = line.IndexOf("name=");
                             string tm0 = line.Substring(start, line.Length-start);

                             int posOfname = tm0.IndexOf('"');
                             int posLast = tm0.IndexOf('"', posOfname+1);

                             //int last = line.IndexOf('"', posOfname+1);

                             char Navodnici = '"';
                             string tmpName = line.Substring(start, posLast) + Navodnici.ToString()+"|";


                             int start2 = line.IndexOf("defaultValue=");
                             string tm2 = line.Substring(start2, line.Length - start2);

                             int posOfname2 = tm2.IndexOf('"');
                             int posLast2 = tm2.IndexOf('"', posOfname2 + 1);

                             //int last = line.IndexOf('"', posOfname+1);

                             Navodnici = '"';
                             string tmpValue = line.Substring(start2, posLast2) + Navodnici.ToString();

                             string res = tmpName + tmpValue;
                             al.Add(res);
                             this.listBox2.Items.Add(line.Substring(start, posLast)+Navodnici.ToString()+"|");
                             this.listBox2.Items.Add(res);

                             
                         }
              

                 // Save to File
                 if (line.IndexOf("</request>") > -1)
                 {
                       inMessage = 0;
                       inRequest = 0;
                       txtObj.ArrayListToFile(al);
                     //  MessageBox.Show("done");
                 }
                

             } // END for loop

             MessageBox.Show("done");
        }


        public void Tasks()
        {
            // kreiraj klasu MessageBM sa fields Name, Defaultvalue, Leng, Padding, DynamicValue
            // u samoj klasi da se procita csv file i da se ove vrednosti prebace u List
            // ukoliko prebacianje linije u fields nije moguce (try/catch) ignore liniju
            // kroz citanje da se nove vrednosti stave u ArrayList da bi se proverili duplicati

            // da se naprave ovi metodi
            // SetDefaultValue
            // GetDefaultValue
            // GetValueAsOneString

            // SetPading(lenh,



        }

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
            string prop9 = prop8.Replace("_", "");
            string prop10 = prop9.Replace("-", "");
            string prop11 = prop10.Replace("?", "");

            string prop12 = prop11;
            if (prop11[0].ToString().CompareTo("1") == 0)
            {
                prop12 = prop11.Substring(1, prop11.Length - 1);
            }

            return prop12;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string fileName = openFileDialog1.FileName;

            string[] allLines = File.ReadAllLines(fileName);

            ArrayList alString = new ArrayList();
            ArrayList alForExcel = new ArrayList();
            ArrayList alFirstPartWithoutBadChar = new ArrayList();
            ArrayList alCol = new ArrayList();
             ArrayList alText = new ArrayList();

             ArrayList alFirstPartForExcel = new ArrayList();

            string fnameText = Application.StartupPath + @"\" + allLines[0]+".txt";
            string fnameStr = Application.StartupPath + @"\" + allLines[0] + ".str";

            string fnameDat = Application.StartupPath + @"\" + allLines[0] + ".dat";
            string fnameExcel = Application.StartupPath + @"\" + allLines[0] + ".csv";

            string fnameCol = Application.StartupPath + @"\" + allLines[0] + ".col";

            string finalResString = "";

            for (int i = 1; i < allLines.Length; i++)
            {
                string[] tmp = allLines[i].Split('|');
                string[] tmpValueWithOutNavodnici = tmp[1].Split('"');

               
                string[] tmpNameWithOutNavodnici = tmp[0].Split('"');

                alString.Add(tmpNameWithOutNavodnici[1] + "|" + tmpValueWithOutNavodnici[1]);
                alCol.Add(tmpValueWithOutNavodnici[1]);
                alFirstPartForExcel.Add(tmpNameWithOutNavodnici[1]);
                string resnobadchar = RemoveBadChar(tmpNameWithOutNavodnici[1]);
                alFirstPartWithoutBadChar.Add(resnobadchar);

            }

            TxtFile tx = new TxtFile();
            tx.FileName = fnameDat;
            tx.ArrayListToFile(alString);

            tx.FileName = fnameCol;
            tx.ArrayListToFile(alCol);
            string res = "";
            for (int x = 0; x < alCol.Count; x++)
            {
                res = res + alCol[x].ToString();
                
            }
            alText.Add(res);           

            tx.FileName = fnameText;
            tx.ArrayListToFile(alText);


            string res1 = "";
            for (int x = 0; x < alFirstPartForExcel.Count; x++)
            {
                res1 = res1 + alFirstPartForExcel[x].ToString() + "|";

            }

            string res2 = "";
            for (int x = 0; x < alCol.Count; x++)
            {
                res2 = res2 + alCol[x].ToString()+"|";

            }

            alForExcel.Add(res1);
            alForExcel.Add(res2);
            tx.FileName = fnameExcel;
            tx.ArrayListToFile(alForExcel);

            string classname = allLines[0].Replace(" ","");
            string fnameCs = Application.StartupPath + @"\" + classname + ".cs";
            // part for Class
            ArrayList alC = new ArrayList();
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

             for (int x = 0; x < alFirstPartForExcel.Count; x++)
             {
                 string prop1 = alFirstPartForExcel[x].ToString().Replace(" ", "");
                 string prop2 = prop1.Replace("@", "");
                 string prop3 = prop2.Replace("%", "");
                 string prop4 = prop3.Replace("!", "");
                  string prop5 = prop4.Replace("#", "");
                  string prop6 = prop5.Replace("$", "");
                  string prop7 = prop6.Replace(".", "");
                  string prop8 = prop7.Replace("/", "");
                  string prop9 = prop8.Replace("_", "");
                  string prop10 = prop9.Replace("-", "");
                  string prop11 = prop10.Replace("?", "");

                  string prop12 = prop11;
                  if (prop11[0].ToString().CompareTo("1") == 0)
                  {
                      prop12 = prop11.Substring(1, prop11.Length - 1);
                  }

                 string resCs = "public string " + prop12 + GetSet;
                 alC.Add(resCs);
             }

             alC.Add(" ");
             alC.Add(" ");

             alC.Add(" public string GetDefaultString() ");
             alC.Add("{");
              char Navodnici = '"';
              string toreturn = "return " + Navodnici.ToString() + alText[0].ToString() + Navodnici.ToString() + ";";
              alC.Add(toreturn); 
            alC.Add("}"); 
             alC.Add(" ");

             alC.Add(" public void SetDefaultValue()");
             alC.Add("{");

             for (int b = 0; b < alFirstPartWithoutBadChar.Count; b++)
             {

                 string tmpRes = alFirstPartWithoutBadChar[b].ToString() + "=" + Navodnici.ToString() + alCol[b].ToString() + Navodnici.ToString() + ";";
                 alC.Add(tmpRes);

              //   alCol.Add(tmpValueWithOutNavodnici[1]);
              //   alFirstPartForExcel.Add(tmpNameWithOutNavodnici[1]);
             }
             alC.Add("}");

             alC.Add(" public string GetStringFromFields() ");
             alC.Add("{");

             string resT = "";
             for (int b = 0; b < alFirstPartWithoutBadChar.Count; b++)
             {

                 string tmpResWithPlus = alFirstPartWithoutBadChar[b].ToString() + "+"; //
                 if (b != alFirstPartWithoutBadChar.Count - 1)
                 {
                     resT = resT + tmpResWithPlus;
                 }
                 if (b == alFirstPartWithoutBadChar.Count - 1)
                 {
                     resT = resT + alFirstPartWithoutBadChar[b].ToString();
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
             tx.FileName = fnameCs;
             tx.ArrayListToFile(alC);
            

            MessageBox.Show("Done");

        }

        private ArrayList GetArrayListFromFile(string fname)
        {

            TxtFile txtObj = new TxtFile();
            txtObj.FileName = fname;

            ArrayList al = new ArrayList();
            al = txtObj.FileToArrayList();

            return al;
        }

        private void SaveArrayListToFile(ArrayList al, string fname)
        {

            TxtFile txtObj = new TxtFile();
            txtObj.FileName = fname;
            txtObj.ArrayListToFile(al);
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            ArrayList al = GetArrayListFromFile(openFileDialog1.FileName);
            
            // new to get the results
            ArrayList alNew = new ArrayList();
            string[] line0 = al[0].ToString().Split(',');
            alNew.Add(line0[0]);
            for (int i = 3; i < al.Count; i++)
            {
                string lineC = al[i].ToString();
                
                if (lineC[0].ToString().CompareTo(",") == 0)
                {

                }
                else
                {
                    string[] res = al[i].ToString().Split(',');
                    string tmpRes = res[2]+"="+res[4];
                    alNew.Add(tmpRes);
                }
            }
            SaveArrayListToFile(alNew, Application.StartupPath + @"\" + line0[0] + ".txt");
            MessageBox.Show("Done");

        }

        private void button15_Click(object sender, EventArgs e)
        {
            MessageBM objM = new MessageBM();

            this.openFileDialog1.ShowDialog();

            string filename = this.openFileDialog1.FileName;
            objM.CreateCsharpClassFromCSVFile(filename);

            //List<MessageBM> listofmsg = objM.GetFromCSVFile(filename);
            //string filename2   = Application.StartupPath + @"\" + objM.ClassName + ".txt";

            //objM.SaveClassToFile(filename2, listofmsg);
            MessageBox.Show("Done");

        }





    }





}
