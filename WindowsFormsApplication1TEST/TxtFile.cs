using System;
using System.IO;
using System.Resources;  
using System.Collections.Specialized;
using System.Collections;
using System.ComponentModel;
using System.Data;



	/// <summary>
	/// Summary description for TxtFile.
	/// </summary>
	public class TxtFile
	{
		public TxtFile()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		private string filename;

		public string FileName
		{
			get
			{
				return filename;
			}
			set
			{
				filename = value;
			}
		}


		public string[] FileToArray()
		{
			
			ArrayList al = new ArrayList();
			string str;
			int nline = 0;

			try
			{
				
				StreamReader sr = File.OpenText(filename);
				str = sr.ReadLine();
				while( str != null )
				{
				
					nline = nline +1;
					al.Add(str);
					str = sr.ReadLine();
				}
				sr.Close();
				string[] astr = new string[al.Count];
				//al.Sort();
				al.CopyTo(astr);

				return astr;
				// use string[] astr = FileToArray("\\Program Files\\SmartDeviceApplication1\\Cust.txt"")
			}

			catch
			{
				this.WriteLogFile(nline,"Reading File");
				string[] aerror = new string[1];
				aerror[0] = "Mistake Reading File Line "+nline.ToString();
				return aerror;
			}
		}

		public void AppendArrayListToFile(ArrayList alwr)

		{

			int nlinew = 0;

			try

			{

				StreamWriter sw = File.AppendText(filename);

				for (int i=0;i<alwr.Count;i++)

				{

					nlinew = i;

					sw.WriteLine(alwr[i].ToString());

				}

				sw.Close();

			}

			catch

			{

				this.WriteLogFile(nlinew,"Writing File");

			}

		}

		public void AppendArrayToFile(string[] ar)

		{

			int nlinew = 0;

			try

			{

				StreamWriter sw = File.AppendText(filename);

				for (int i=0;i<ar.Length;i++)

				{

					nlinew = i;

					sw.WriteLine(ar[i]);

				}

				sw.Close();

			}

			catch

			{

				this.WriteLogFile(nlinew,"Writing File");

			}

		}

		public ArrayList FileToArrayList()
		{
			
			ArrayList arls = new ArrayList();
			string str;
			int nline = 0;

			try
			{
				
				StreamReader sr = File.OpenText(filename);
				str = sr.ReadLine();
				while( str != null )
				{
				
					nline = nline +1;
					arls.Add(str);
					str = sr.ReadLine();
				}
				sr.Close();
				
				//al.Sort();
				

				return arls;
				// use ArrayList astl = FileToArray("\\Program Files\\SmartDeviceApplication1\\Cust.txt"")
			}

			catch (Exception ex)
			{
              // ErrorLog.Save(ex);
				return arls;
			}
		}

        public static string Convert_to_sql_date(DateTime date)
        {
            return string.Format("'{0,2:00}-{1,2:00}-{2,2:00}'", date.Year, date.Month, date.Day);

            // select * from QtyOnHandPerDayPerStoreVendCodeDepartmentClass where DateOfSales = '2012/01/26'
        }

        //string dateInSQLformat = Utils.Convert_to_sql_date(dtDay);

        ////MessageBox.Show(dateInSQLformat);

        //string strSql = "SELECT id,Store_no,Department,Class_,Vendor_code, DateOfSales FROM SalesPerDayPerStoreVendCodeDepartmentClass Where  DateOfSales=" + dateInSQLformat;
        ////  MessageBox.Show(strSql);

		public void ArrayListToFile(ArrayList alwr)
		{

			int nlinew = 0;
			try
			{
				StreamWriter sw = File.CreateText(filename);
				for (int i=0;i<alwr.Count;i++)
				{
					nlinew = i;
					sw.WriteLine(alwr[i].ToString());
				}
				sw.Close();
			}
			catch
			{
				this.WriteLogFile(nlinew,"Writing File");
			}
		}

		public void ArrayToFile(string[] ar)
		{

			int nlinew = 0;
			try
			{
				StreamWriter sw = File.CreateText(filename);
				for (int i=0;i<ar.Length;i++)
				{
					nlinew = i;
					sw.WriteLine(ar[i]);
				}
				sw.Close();
			}
			catch
			{
				this.WriteLogFile(nlinew,"Writing File");
			}
		}

		private void WriteLogFile(int numline, string type)
		{
            //string istring;
            //istring = "Mistake on line "+numline.ToString()+"  "+type;
            //string ErrroFile = Utils.GetFullPath() + @"ErrorWithTextFile.txt";
            //StreamWriter swlog = File.AppendText(ErrroFile);
            //swlog.WriteLine(istring);
            //swlog.Close();
		}
	}

