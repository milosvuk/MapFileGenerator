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
 
public class countryofresidences
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public countryofresidences()
{
 
  
 
}
 
public countryofresidences (System.Int32 _id_countryofresidences,System.String _description )
{
id_countryofresidences=_id_countryofresidences;
description=_description;
}
 
 
private System.Int32 id_countryofresidences;
 
public System.Int32 ID_COUNTRYOFRESIDENCES
{
get
{
return id_countryofresidences;
}
set
{
id_countryofresidences=value;
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
id_countryofresidences = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
