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
 
public class language
 
{
public ArrayList alErrors = new ArrayList();
public string connectionString;
public language()
{
 
  
 
}
 
public language (System.Int32 _idlanguage,System.String _description )
{
idlanguage=_idlanguage;
description=_description;
}
 
 
private System.Int32 idlanguage;
 
public System.Int32 IDLANGUAGE
{
get
{
return idlanguage;
}
set
{
idlanguage=value;
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
idlanguage = 0;
}
////==========================================================================
/// END CLASS WHICH CONTAIN ONLY DATA common objects
////==========================================================================
 
}
