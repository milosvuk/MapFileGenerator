using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Text;
 
public class DB_usacity
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_usacity()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(usacity _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(usacity _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO usacity (description) VALUES (@description) SET @tmpid = SCOPE_IDENTITY()", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@description", _tmpObject.DESCRIPTION));
command.Parameters.Add(new SqlParameter("@tmpid", SqlDbType.Int));
command.Parameters["@tmpid"].Direction = ParameterDirection.Output;
command.ExecuteNonQuery();
res = (int)command.Parameters["@tmpid"].Value;
return res;
}
////==========================================================================
//END ADD WITH PARAMETERS
////==========================================================================
////==========================================================================
// UPDATE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Update(usacity _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(usacity _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE usacity SET description=@description  WHERE id_usacity=@id_usacity", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@description", _tmpObject.DESCRIPTION));
command.Parameters.Add(new SqlParameter("@id_usacity", _tmpObject.ID_USACITY));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(usacity _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(usacity _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE FROM usacity  WHERE id_usacity=@id_usacity", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@id_usacity", _tmpObject.ID_USACITY));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public usacity GetById(int _id)
{
usacity tmpObject = new usacity();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From usacity WHERE id_usacity=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.ID_USACITY = (System.Int32)dr["id_usacity"];
tmpObject.DESCRIPTION = (System.String)dr["description"];
}
dr.Close();
conn.Close();
return tmpObject;
}
////==========================================================================
//END OF GetByID ==============
////==========================================================================
////==========================================================================
//GET ALL ---------------------------------------------
////==========================================================================
public List<usacity> GetAll()
{
List<usacity> tmpList = new List<usacity>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From usacity", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
usacity tmpObject = new usacity();
msgRecField="-";
msgRecField=msgRecField + "id_usacity=";
msgRecField=msgRecField + dr["id_usacity"].ToString() +"=";
tmpObject.ID_USACITY = (System.Int32)dr["id_usacity"];
msgRecField=msgRecField + "description=";
msgRecField=msgRecField + dr["description"].ToString() +"=";
tmpObject.DESCRIPTION = (System.String)dr["description"];
tmpList.Add(tmpObject);
}
 catch (Exception ex)
{
alErrors.Add(LogException(ex));
alErrors.Add(msgRecField);
msgRecField="-";
}
}
dr.Close();
conn.Close();
return tmpList;
}
////==========================================================================
//END OF GetALL ==============
////==========================================================================
////==========================================================================
//GET ALL by cond ---------------------------------------------
////==========================================================================
public List<usacity> GetAllByCond(string cond)
{
List<usacity> tmpList = new List<usacity>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From usacity Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
usacity tmpObject = new usacity();
msgRecField="-";
msgRecField=msgRecField + "id_usacity=";
msgRecField=msgRecField + dr["id_usacity"].ToString() +"=";
tmpObject.ID_USACITY = (System.Int32)dr["id_usacity"];
msgRecField=msgRecField + "description=";
msgRecField=msgRecField + dr["description"].ToString() +"=";
tmpObject.DESCRIPTION = (System.String)dr["description"];
tmpList.Add(tmpObject);
}
 catch (Exception ex)
{
alErrors.Add(LogException(ex));
alErrors.Add(msgRecField);
msgRecField="-";
}
}
dr.Close();
conn.Close();
return tmpList;
}
////==========================================================================
//END OF GetALL ==============
////==========================================================================
////==========================================================================
 
public string CheckStringFromField(string StringToCheck, int typeOfReturn)
{
string res = StringToCheck;
if (typeOfReturn == 1 || String.IsNullOrEmpty(StringToCheck)==true)
{
res ="No Data";
return res;
}
if (typeOfReturn == 2 || String.IsNullOrEmpty(StringToCheck)==true)
{
res ="0";
return res;
}
if (typeOfReturn == 3 || String.IsNullOrEmpty(StringToCheck)==true)
{
res ="01/01/1800";
return res;
}
return res;
// using  like CheckStringFromTxtFile(fields[0],1);
}

    private string GetExceptionTypeStack(Exception e)
    {
      if (e.InnerException != null)
      {
        string message = "";
        message = GetExceptionTypeStack(e.InnerException);
        message = message + "   " + e.GetType().ToString();
        return message;
      }
      else
      {
        return "   " + e.GetType().ToString();
      }
    }

    private string GetExceptionMessageStack(Exception e)
    {
      if (e.InnerException != null)
      {
        string message = "";
        message = GetExceptionMessageStack(e.InnerException);
        message = message + "   " + e.Message;
        return message;
      }
      else
      {
        return "   " + e.Message;
      }
    }

    private string GetExceptionCallStack(Exception e)
    {
      if (e.InnerException != null)
      {
        string message = "";
        message = GetExceptionCallStack(e.InnerException);
        message = message + "--- Next Call Stack: ";
        message =  message + e.StackTrace;
        return message;
      }
      else
      {
        return e.StackTrace;
      }
    }


   public string LogException(Exception exception)
    {
      string  error = "";

      error = "Exception classes:   ";
      error = error + GetExceptionTypeStack(exception);
      error = error + " ";
      error = error + " Exception messages: ";
      error = error +GetExceptionMessageStack(exception);

      error= error + " ";
      error= error +" Stack Traces: ";
      error= error +GetExceptionCallStack(exception);
     
      return error;
    }
}
 
