using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
public class ACCOUNTBALANCEINQUIRYREQUEST
{
public string Destination_Mailbox { get; set; } 
public string Destination_Country_Code { get; set; } 
public string Destination_IMD_Code { get; set; } 
public string Destination_Branch_Number { get; set; } 
public string Source_Mailbox { get; set; } 
public string Source_Country_Code { get; set; } 
public string Source_IMD_Code { get; set; } 
public string Source_Branch_Number { get; set; } 
public string Business_Period { get; set; } 
public string Message_Type { get; set; } 
public string Sequence_Number { get; set; } 
public string Time { get; set; } 
public string Transaction_Status { get; set; } 
public string Message_Flags { get; set; } 
public string Reconciliation_Period { get; set; } 
public string Reconciliation_Currency { get; set; } 
public string Reconciliation_Amount_Sign { get; set; } 
public string Reconciliation_Amount { get; set; } 
public string Filler { get; set; } 
public string Message_Length { get; set; } 
public string Transaction_Definition_Id { get; set; } 
public string Transaction_Processed_Flag { get; set; } 
public string BranchPower_Transaction_Reference_Id { get; set; } 
public string Message_Type1 { get; set; } 
public string BankMaster_Destination_Branch_Number { get; set; } 
public string BankMaster_Destination_Branch_Number1 { get; set; } 
public string Filler1 { get; set; } 
public string Inter_Branching_Flag { get; set; } 
public string Device_Id { get; set; } 
public string Message_Function_Code { get; set; } 
public string Transaction_Type { get; set; } 
public string Force_Post_Flag { get; set; } 
public string Transaction_Date { get; set; } 
public string User_Id { get; set; } 
public string Transaction_Sequence_Number { get; set; } 
public string Transaction_Chain_Number { get; set; } 
public string Host_Task_Id { get; set; } 
public string BankMaster_Transaction_Type { get; set; } 
public string Authorised_Flag { get; set; } 
public string Directory { get; set; } 
public string Name_of_File { get; set; } 
public string Transaction_Type1 { get; set; } 
public string No_of_Fields { get; set; } 
public string Dsp_of_ACCOUNTNO { get; set; } 
public string Filler12 { get; set; } 
public string ACCOUNTNO { get; set; } 
public string Dsp_of_FILLER { get; set; } 
public string Filler123 { get; set; } 
public string FILLER { get; set; } 
public string Dsp_of_ACDESCR { get; set; } 
public string Filler1234 { get; set; } 
public string ACDESCR { get; set; } 
public string Dsp_of_BOOKBALC { get; set; } 
public string Filler12345 { get; set; } 
public string BOOKBALC { get; set; } 
public string Dsp_of_CLEARBALC { get; set; } 
public string Filler123456 { get; set; } 
public string CLEARBALC { get; set; } 
public string Dsp_of_REPORTBALC { get; set; } 
public string Filler1234567 { get; set; } 
public string REPORTBALC { get; set; } 
public string Dsp_of_LIMIT { get; set; } 
public string Filler12345678 { get; set; } 
public string LIMIT { get; set; } 
 
 
 public string GetDefaultString() 
{
return "b4705123450005a4705123450005000010000001535010@0000000000000000000000N       032000BRFO10000000000300020170222RODR0000000ST01  0esiubpglenq030701130021   01170504637  02070034          03300047                                 04110089   0000000000005110105   0000000000006150133   00000000000000007130410   0000000000000";
}
 
 public void SetDefaultValue()
{
Destination_Mailbox="b";
Destination_Country_Code="470";
Destination_IMD_Code="512345";
Destination_Branch_Number="0005";
Source_Mailbox="a";
Source_Country_Code="470";
Source_IMD_Code="512345";
Source_Branch_Number="0005";
Business_Period="0000";
Message_Type="1";
Sequence_Number="000000";
Time="153501";
Transaction_Status="0";
Message_Flags="@";
Reconciliation_Period="0000";
Reconciliation_Currency="000";
Reconciliation_Amount_Sign="0";
Reconciliation_Amount="00000000000000";
Filler="N       ";
Message_Length="0320";
Transaction_Definition_Id="0";
Transaction_Processed_Flag="0";
BranchPower_Transaction_Reference_Id="BRFO";
Message_Type1="1";
BankMaster_Destination_Branch_Number="00";
BankMaster_Destination_Branch_Number1="00";
Filler1="0";
Inter_Branching_Flag="0";
Device_Id="0000";
Message_Function_Code="3";
Transaction_Type="00";
Force_Post_Flag="0";
Transaction_Date="20170222";
User_Id="RODR";
Transaction_Sequence_Number="00000";
Transaction_Chain_Number="00";
Host_Task_Id="ST01";
BankMaster_Transaction_Type="  ";
Authorised_Flag="0";
Directory="esiubp";
Name_of_File="glenq0";
Transaction_Type1="3";
No_of_Fields="07";
Dsp_of_ACCOUNTNO="01130021";
Filler12="   ";
ACCOUNTNO="01170504637  ";
Dsp_of_FILLER="02070034";
Filler123="   ";
FILLER="       ";
Dsp_of_ACDESCR="03300047";
Filler1234="   ";
ACDESCR="                              ";
Dsp_of_BOOKBALC="04110089";
Filler12345="   ";
BOOKBALC="00000000000";
Dsp_of_CLEARBALC="05110105";
Filler123456="   ";
CLEARBALC="00000000000";
Dsp_of_REPORTBALC="06150133";
Filler1234567="   ";
REPORTBALC="000000000000000";
Dsp_of_LIMIT="07130410";
Filler12345678="   ";
LIMIT="0000000000000";
}
 public string GetStringFromFields() 
{
return Destination_Mailbox+Destination_Country_Code+Destination_IMD_Code+Destination_Branch_Number+Source_Mailbox+Source_Country_Code+Source_IMD_Code+Source_Branch_Number+Business_Period+Message_Type+Sequence_Number+Time+Transaction_Status+Message_Flags+Reconciliation_Period+Reconciliation_Currency+Reconciliation_Amount_Sign+Reconciliation_Amount+Filler+Message_Length+Transaction_Definition_Id+Transaction_Processed_Flag+BranchPower_Transaction_Reference_Id+Message_Type1+BankMaster_Destination_Branch_Number+BankMaster_Destination_Branch_Number1+Filler1+Inter_Branching_Flag+Device_Id+Message_Function_Code+Transaction_Type+Force_Post_Flag+Transaction_Date+User_Id+Transaction_Sequence_Number+Transaction_Chain_Number+Host_Task_Id+BankMaster_Transaction_Type+Authorised_Flag+Directory+Name_of_File+Transaction_Type1+No_of_Fields+Dsp_of_ACCOUNTNO+Filler12+ACCOUNTNO+Dsp_of_FILLER+Filler123+FILLER+Dsp_of_ACDESCR+Filler1234+ACDESCR+Dsp_of_BOOKBALC+Filler12345+BOOKBALC+Dsp_of_CLEARBALC+Filler123456+CLEARBALC+Dsp_of_REPORTBALC+Filler1234567+REPORTBALC+Dsp_of_LIMIT+Filler12345678+LIMIT;
}
 
}
