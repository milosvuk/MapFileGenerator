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
 
public class countryoforigin
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public countryoforigin()
{
 
  
 
}
 
public countryoforigin (System.Int32 _id_countryoforigin,System.String _description )
{
id_countryoforigin=_id_countryoforigin;
description=_description;
}
 
 
private System.Int32 id_countryoforigin;
 
public System.Int32 ID_COUNTRYOFORIGIN
{
get
{
return id_countryoforigin;
}
set
{
id_countryoforigin=value;
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
id_countryoforigin = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
