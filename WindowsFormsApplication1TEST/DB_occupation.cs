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
 
public class DB_occupation
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public DB_occupation()
{
 
  
 
}
////==========================================================================
// ADD WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Add(occupation _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Add(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Add(occupation _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("INSERT INTO occupation (description) VALUES (@description) SET @tmpid = SCOPE_IDENTITY()", conn);
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
 
public int Update(occupation _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Update(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Update(occupation _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("UPDATE occupation SET description=@description  WHERE id_occupation=@id_occupation", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@description", _tmpObject.DESCRIPTION));
command.Parameters.Add(new SqlParameter("@id_occupation", _tmpObject.ID_OCCUPATION));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END UPDATE WITH PARAMETERS
////==========================================================================
////==========================================================================
// DELETE WITH PARAMETERS WITH OR WITHOUT TRANS
////==========================================================================
 
public int Delete(occupation _tmpObject)
{
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
conn.Open(); 
int x = Delete(_tmpObject, conn, null); 
conn.Close();
return x; 
}
////==========================================================================
 
public int Delete(occupation _tmpObject, SqlConnection conn, SqlTransaction tran)
{
int res = 0;
SqlCommand command = new SqlCommand("DELETE FROM occupation  WHERE id_occupation=@id_occupation", conn);
if (tran != null)
{
command.Transaction = tran;
}
command.Parameters.Add(new SqlParameter("@id_occupation", _tmpObject.ID_OCCUPATION));
res = command.ExecuteNonQuery();
return res;
}
////==========================================================================
//END DELETE WITH PARAMETERS
////==========================================================================
 
////==========================================================================
//GET BY ID ---------------------------------------------
////==========================================================================
public occupation GetById(int _id)
{
occupation tmpObject = new occupation();
 
  
 
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From occupation WHERE id_occupation=" + _id.ToString(), conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
tmpObject.ID_OCCUPATION = (System.Int32)dr["id_occupation"];
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
public List<occupation> GetAll()
{
List<occupation> tmpList = new List<occupation>();
 
  
 
alErrors.Clear();
string msgRecField="-";
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From occupation", conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
occupation tmpObject = new occupation();
msgRecField="-";
msgRecField=msgRecField + "id_occupation=";
msgRecField=msgRecField + dr["id_occupation"].ToString() +"=";
tmpObject.ID_OCCUPATION = (System.Int32)dr["id_occupation"];
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
public List<occupation> GetAllByCond(string cond)
{
List<occupation> tmpList = new List<occupation>();
 
  
 
string msgRecField="-";
alErrors.Clear();
SqlConnection conn = new SqlConnection(connectionString); 
SqlCommand command = new SqlCommand("Select * From occupation Where "+cond, conn);
conn.Open();
SqlDataReader dr = command.ExecuteReader();
while (dr.Read())
{
try
{
occupation tmpObject = new occupation();
msgRecField="-";
msgRecField=msgRecField + "id_occupation=";
msgRecField=msgRecField + dr["id_occupation"].ToString() +"=";
tmpObject.ID_OCCUPATION = (System.Int32)dr["id_occupation"];
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
 
