using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
public class AccountBalanceLinqTest
{
public string DestinationMailbox { get; set; } 
public string DestinationCountryCode { get; set; } 
public string DestinationIMDCode { get; set; } 
public string DestinationBranchNumber { get; set; } 
public string SourceMailbox { get; set; } 
public string SourceCountryCode { get; set; } 
public string SourceIMDCode { get; set; } 
public string SourceBranchNumber { get; set; } 
public string BusinessPeriod { get; set; } 
public string MessageType { get; set; } 
public string SequenceNumber { get; set; } 
public string Time { get; set; } 
public string TransactionStatus { get; set; } 
public string MessageFlags { get; set; } 
public string ReconciliationPeriod { get; set; } 
public string ReconciliationCurrency { get; set; } 
public string ReconciliationAmountSign { get; set; } 
public string ReconciliationAmount0 { get; set; } 
public string Filler { get; set; } 
public string MessageLength { get; set; } 
public string TransactionDefinitionId { get; set; } 
public string TransactionProcessedFlag { get; set; } 
public string BranchPowerTransactionReferenceId { get; set; } 
public string MessageType1 { get; set; } 
public string BankMasterDestinationBranchNumber { get; set; } 
public string BankMasterDestinationBranchNumber1 { get; set; } 
public string Filler1 { get; set; } 
public string InterBranchingFlag { get; set; } 
public string DeviceId { get; set; } 
public string MessageFunctionCode { get; set; } 
public string TransactionType { get; set; } 
public string ForcePostFlag { get; set; } 
public string TransactionDate { get; set; } 
public string UserId { get; set; } 
public string TransactionSequenceNumber { get; set; } 
public string TransactionChainNumber { get; set; } 
public string HostTaskId { get; set; } 
public string BankMasterTransactionType01 { get; set; } 
public string AuthorisedFlag { get; set; } 
public string Directory { get; set; } 
public string NameofFile { get; set; } 
public string TransactionType1 { get; set; } 
public string NoofFields { get; set; } 
public string DspofACCOUNTNO { get; set; } 
public string Filler { get; set; } 
public string ACCOUNTNO { get; set; } 
public string DspofFILLER { get; set; } 
public string Filler1 { get; set; } 
public string FILLER { get; set; } 
public string DspofACDESCR { get; set; } 
public string Filler2 { get; set; } 
public string ACDESCR { get; set; } 
public string DspofBOOKBALC { get; set; } 
public string Filler3 { get; set; } 
public string BOOKBALC { get; set; } 
public string DspofCLEARBALC { get; set; } 
public string Filler4 { get; set; } 
public string CLEARBALC { get; set; } 
public string DspofREPORTBALC { get; set; } 
public string Filler5 { get; set; } 
public string REPORTBALC { get; set; } 
public string DspofLIMIT { get; set; } 
public string Filler6 { get; set; } 
public string LIMIT { get; set; } 
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


 public void SetDefaultValue()
{
DestinationMailbox="b"
DestinationCountryCode="470"
DestinationIMDCode="512345"
DestinationBranchNumber="0005"
SourceMailbox="a"
SourceCountryCode="470"
SourceIMDCode="512345"
SourceBranchNumber="0019"
BusinessPeriod="0000"
MessageType="1"
SequenceNumber="000000"
Time="153501"
TransactionStatus="0"
MessageFlags="@"
ReconciliationPeriod="0000"
ReconciliationCurrency="000"
ReconciliationAmountSign="0"
ReconciliationAmount0="00000000000000"
Filler="N       "
MessageLength="0320"
TransactionDefinitionId="0"
TransactionProcessedFlag="0"
BranchPowerTransactionReferenceId="BRFO"
MessageType1="1"
BankMasterDestinationBranchNumber="00"
BankMasterDestinationBranchNumber1="00"
Filler1="0"
InterBranchingFlag="0"
DeviceId="0000"
MessageFunctionCode="3"
TransactionType="00"
ForcePostFlag="0"
TransactionDate="20170222"
UserId="RODR"
TransactionSequenceNumber="00000"
TransactionChainNumber="00"
HostTaskId="ST01"
BankMasterTransactionType01="  "
AuthorisedFlag="0"
Directory="esiubp"
NameofFile="glenq0"
TransactionType1="3"
NoofFields="07"
DspofACCOUNTNO="01130021"
Filler="   "
ACCOUNTNO="01170504637  "
DspofFILLER="02070034"
Filler1="   "
FILLER="       "
DspofACDESCR="03300047"
Filler2="   "
ACDESCR="                              "
DspofBOOKBALC="04110089"
Filler3="   "
BOOKBALC="00000000000"
DspofCLEARBALC="05110105"
Filler4="   "
CLEARBALC="00000000000"
DspofREPORTBALC="06150133"
Filler5="   "
REPORTBALC="000000000000000"
DspofLIMIT="07130410"
Filler6="   "
LIMIT="0000000000000"
DestinationMailbox13="b"
DestinationCountryCode13="470"
DestinationIMDCode13="512345"
DestinationBranchNumber13="0005"
SourceMailbox13="a"
SourceCountryCode13="470"
SourceIMDCode13="512345"
SourceBranchNumber13="0019"
BusinessPeriod13="0000"
MessageType26="1"
SequenceNumber13="000000"
Time13="153501"
TransactionStatus13="0"
MessageFlags13="@"
ReconciliationPeriod13="0000"
ReconciliationCurrency13="000"
ReconciliationAmountSign13="0"
ReconciliationAmount13="00000000000000"
Filler32="N       "
MessageLength13="0320"
TransactionDefinitionId13="0"
TransactionProcessedFlag13="0"
BranchPowerTransactionReferenceId13="BRFO"
MessageType27="1"
BankMasterDestinationBranchNumber26="00"
BankMasterDestinationBranchNumber27="00"
Filler33="0"
InterBranchingFlag13="0"
DeviceId13="0000"
MessageFunctionCode13="3"
TransactionType26="00"
ForcePostFlag13="0"
TransactionDate13="20170222"
UserId13="RODR"
TransactionSequenceNumber13="00000"
TransactionChainNumber13="00"
HostTaskId13="ST01"
BankMasterTransactionType13="  "
AuthorisedFlag13="0"
Directory13="esiubp"
NameofFile13="glenq0"
TransactionType27="3"
NoofFields9="07"
DspofACCOUNTNO1="01130021"
Filler318="   "
ACCOUNTNO1="01170504637  "
DspofFILLER1="02070034"
Filler319="   "
FILLER1="       "
DspofACDESCR1="03300047"
Filler320="   "
ACDESCR1="                              "
DspofBOOKBALC1="04110089"
Filler321="   "
BOOKBALC1="00000000000"
DspofCLEARBALC1="05110105"
Filler322="   "
CLEARBALC1="00000000000"
DspofREPORTBALC1="06150133"
Filler323="   "
REPORTBALC1="000000000000000"
DspofLIMIT1="07130410"
Filler324="   "
LIMIT1="0000000000000"
}
}
