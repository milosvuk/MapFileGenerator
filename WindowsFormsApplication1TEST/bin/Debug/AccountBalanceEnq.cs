using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
public class AccountBalanceEnq
{
public string DestinationMailbox13 { get; set; } 
public string DestinationCountryCode13 { get; set; } 
public string DestinationIMDCode13 { get; set; } 
public string DestinationBranchNumber13 { get; set; } 
public string SourceMailbox13 { get; set; } 
public string SourceCountryCode13 { get; set; } 
public string SourceIMDCode13 { get; set; } 
public string SourceBranchNumber13 { get; set; } 
public string BusinessPeriod13 { get; set; } 
public string MessageType26 { get; set; } 
public string SequenceNumber13 { get; set; } 
public string Time13 { get; set; } 
public string TransactionStatus13 { get; set; } 
public string MessageFlags13 { get; set; } 
public string ReconciliationPeriod13 { get; set; } 
public string ReconciliationCurrency13 { get; set; } 
public string ReconciliationAmountSign13 { get; set; } 
public string ReconciliationAmount13 { get; set; } 
public string Filler32 { get; set; } 
public string MessageLength13 { get; set; } 
public string TransactionDefinitionId13 { get; set; } 
public string TransactionProcessedFlag13 { get; set; } 
public string BranchPowerTransactionReferenceId13 { get; set; } 
public string MessageType27 { get; set; } 
public string BankMasterDestinationBranchNumber26 { get; set; } 
public string BankMasterDestinationBranchNumber27 { get; set; } 
public string Filler33 { get; set; } 
public string InterBranchingFlag13 { get; set; } 
public string DeviceId13 { get; set; } 
public string MessageFunctionCode13 { get; set; } 
public string TransactionType26 { get; set; } 
public string ForcePostFlag13 { get; set; } 
public string TransactionDate13 { get; set; } 
public string UserId13 { get; set; } 
public string TransactionSequenceNumber13 { get; set; } 
public string TransactionChainNumber13 { get; set; } 
public string HostTaskId13 { get; set; } 
public string BankMasterTransactionType13 { get; set; } 
public string AuthorisedFlag13 { get; set; } 
public string Directory13 { get; set; } 
public string NameofFile13 { get; set; } 
public string TransactionType27 { get; set; } 
public string NoofFields9 { get; set; } 
public string DspofACCOUNTNO1 { get; set; } 
public string Filler318 { get; set; } 
public string ACCOUNTNO1 { get; set; } 
public string DspofFILLER1 { get; set; } 
public string Filler319 { get; set; } 
public string FILLER1 { get; set; } 
public string DspofACDESCR1 { get; set; } 
public string Filler320 { get; set; } 
public string ACDESCR1 { get; set; } 
public string DspofBOOKBALC1 { get; set; } 
public string Filler321 { get; set; } 
public string BOOKBALC1 { get; set; } 
public string DspofCLEARBALC1 { get; set; } 
public string Filler322 { get; set; } 
public string CLEARBALC1 { get; set; } 
public string DspofREPORTBALC1 { get; set; } 
public string Filler323 { get; set; } 
public string REPORTBALC1 { get; set; } 
public string DspofLIMIT1 { get; set; } 
public string Filler324 { get; set; } 
public string LIMIT1 { get; set; } 
 
 
 public string GetDefaultString() 
{
return "b4705123450005a4705123450019000010000001535010@0000000000000000000000N       032000BRFO10000000000300020170222RODR0000000ST01  0esiubpglenq030701130021   01170504637  02070034          03300047                                 04110089   0000000000005110105   0000000000006150133   00000000000000007130410   0000000000000";
}
 
 public void SetDefaultValue()
{
DestinationMailbox13="b";
DestinationCountryCode13="470";
DestinationIMDCode13="512345";
DestinationBranchNumber13="0005";
SourceMailbox13="a";
SourceCountryCode13="470";
SourceIMDCode13="512345";
SourceBranchNumber13="0019";
BusinessPeriod13="0000";
MessageType26="1";
SequenceNumber13="000000";
Time13="153501";
TransactionStatus13="0";
MessageFlags13="@";
ReconciliationPeriod13="0000";
ReconciliationCurrency13="000";
ReconciliationAmountSign13="0";
ReconciliationAmount13="00000000000000";
Filler32="N       ";
MessageLength13="0320";
TransactionDefinitionId13="0";
TransactionProcessedFlag13="0";
BranchPowerTransactionReferenceId13="BRFO";
MessageType27="1";
BankMasterDestinationBranchNumber26="00";
BankMasterDestinationBranchNumber27="00";
Filler33="0";
InterBranchingFlag13="0";
DeviceId13="0000";
MessageFunctionCode13="3";
TransactionType26="00";
ForcePostFlag13="0";
TransactionDate13="20170222";
UserId13="RODR";
TransactionSequenceNumber13="00000";
TransactionChainNumber13="00";
HostTaskId13="ST01";
BankMasterTransactionType13="  ";
AuthorisedFlag13="0";
Directory13="esiubp";
NameofFile13="glenq0";
TransactionType27="3";
NoofFields9="07";
DspofACCOUNTNO1="01130021";
Filler318="   ";
ACCOUNTNO1="01170504637  ";
DspofFILLER1="02070034";
Filler319="   ";
FILLER1="       ";
DspofACDESCR1="03300047";
Filler320="   ";
ACDESCR1="                              ";
DspofBOOKBALC1="04110089";
Filler321="   ";
BOOKBALC1="00000000000";
DspofCLEARBALC1="05110105";
Filler322="   ";
CLEARBALC1="00000000000";
DspofREPORTBALC1="06150133";
Filler323="   ";
REPORTBALC1="000000000000000";
DspofLIMIT1="07130410";
Filler324="   ";
LIMIT1="0000000000000";
}
 public string GetStringFromFields() 
{
return DestinationMailbox13+DestinationCountryCode13+DestinationIMDCode13+DestinationBranchNumber13+SourceMailbox13+SourceCountryCode13+SourceIMDCode13+SourceBranchNumber13+BusinessPeriod13+MessageType26+SequenceNumber13+Time13+TransactionStatus13+MessageFlags13+ReconciliationPeriod13+ReconciliationCurrency13+ReconciliationAmountSign13+ReconciliationAmount13+Filler32+MessageLength13+TransactionDefinitionId13+TransactionProcessedFlag13+BranchPowerTransactionReferenceId13+MessageType27+BankMasterDestinationBranchNumber26+BankMasterDestinationBranchNumber27+Filler33+InterBranchingFlag13+DeviceId13+MessageFunctionCode13+TransactionType26+ForcePostFlag13+TransactionDate13+UserId13+TransactionSequenceNumber13+TransactionChainNumber13+HostTaskId13+BankMasterTransactionType13+AuthorisedFlag13+Directory13+NameofFile13+TransactionType27+NoofFields9+DspofACCOUNTNO1+Filler318+ACCOUNTNO1+DspofFILLER1+Filler319+FILLER1+DspofACDESCR1+Filler320+ACDESCR1+DspofBOOKBALC1+Filler321+BOOKBALC1+DspofCLEARBALC1+Filler322+CLEARBALC1+DspofREPORTBALC1+Filler323+REPORTBALC1+DspofLIMIT1+Filler324+LIMIT1;
}
 
}
