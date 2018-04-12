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
 
public class usacity
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public usacity()
{
 
  
 
}
 
public usacity (System.Int32 _id_usacity,System.String _description )
{
id_usacity=_id_usacity;
description=_description;
}
 
 
private System.Int32 id_usacity;
 
public System.Int32 ID_USACITY
{
get
{
return id_usacity;
}
set
{
id_usacity=value;
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
id_usacity = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
