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
 
public class usastates
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public usastates()
{
 
  
 
}
 
public usastates (System.Int32 _id_usastates,System.String _description )
{
id_usastates=_id_usastates;
description=_description;
}
 
 
private System.Int32 id_usastates;
 
public System.Int32 ID_USASTATES
{
get
{
return id_usastates;
}
set
{
id_usastates=value;
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
id_usastates = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
