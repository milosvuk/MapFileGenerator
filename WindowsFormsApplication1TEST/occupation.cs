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
 
public class occupation
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public occupation()
{
 
  
 
}
 
public occupation (System.Int32 _id_occupation,System.String _description )
{
id_occupation=_id_occupation;
description=_description;
}
 
 
private System.Int32 id_occupation;
 
public System.Int32 ID_OCCUPATION
{
get
{
return id_occupation;
}
set
{
id_occupation=value;
}
}
 
private System.String description;
 
public System.String DESCRIPTION
{
get
{
return description;
}
set
{
description=value;
}
}
 
 
public void New()
{
id_occupation = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
