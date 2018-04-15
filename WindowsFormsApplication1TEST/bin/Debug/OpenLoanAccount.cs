using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
public class OpenLoanAccount
{
public string DestinationMailbox8 { get; set; } 
public string DestinationCountryCode8 { get; set; } 
public string DestinationIMDCode8 { get; set; } 
public string DestinationBranchNumber8 { get; set; } 
public string SourceMailbox8 { get; set; } 
public string SourceCountryCode8 { get; set; } 
public string SourceIMDCode8 { get; set; } 
public string SourceBranchNumber8 { get; set; } 
public string BusinessPeriod8 { get; set; } 
public string MessageType16 { get; set; } 
public string SequenceNumber8 { get; set; } 
public string Time8 { get; set; } 
public string TransactionStatus8 { get; set; } 
public string MessageFlags8 { get; set; } 
public string ReconciliationPeriod8 { get; set; } 
public string ReconciliationCurrency8 { get; set; } 
public string ReconciliationAmountSign8 { get; set; } 
public string ReconciliationAmount8 { get; set; } 
public string Filler20 { get; set; } 
public string MessageLength8 { get; set; } 
public string TransactionDefinitionId8 { get; set; } 
public string TransactionProcessedFlag8 { get; set; } 
public string BranchPowerTransactionReferenceId8 { get; set; } 
public string MessageType17 { get; set; } 
public string BankMasterDestinationBranchNumber16 { get; set; } 
public string BankMasterDestinationBranchNumber17 { get; set; } 
public string Filler21 { get; set; } 
public string InterBranchingFlag8 { get; set; } 
public string DeviceId8 { get; set; } 
public string MessageFunctionCode8 { get; set; } 
public string TransactionType16 { get; set; } 
public string ForcePostFlag8 { get; set; } 
public string TransactionDate8 { get; set; } 
public string UserId8 { get; set; } 
public string TransactionSequenceNumber8 { get; set; } 
public string TransactionChainNumber8 { get; set; } 
public string HostTaskId8 { get; set; } 
public string BankMasterTransactionType8 { get; set; } 
public string AuthorisedFlag8 { get; set; } 
public string Directory8 { get; set; } 
public string NameofFile8 { get; set; } 
public string TransactionType17 { get; set; } 
public string NoofFields5 { get; set; } 
public string DspofACCOUNTNO1 { get; set; } 
public string Filler190 { get; set; } 
public string ACCOUNTNO1 { get; set; } 
public string DspofFILLER1 { get; set; } 
public string Filler191 { get; set; } 
public string FILLER1 { get; set; } 
public string DspofACDESCR1 { get; set; } 
public string Filler192 { get; set; } 
public string ACDESCR1 { get; set; } 
public string DspofACCTTYPE1 { get; set; } 
public string Filler193 { get; set; } 
public string ACCTTYPE1 { get; set; } 
public string DspofDATEOPEN1 { get; set; } 
public string Filler194 { get; set; } 
public string DATEOPEN1 { get; set; } 
public string DspofREVIEWDTE1 { get; set; } 
public string Filler195 { get; set; } 
public string REVIEWDTE1 { get; set; } 
public string DspofLIMIT { get; set; } 
public string Filler196 { get; set; } 
public string LIMIT { get; set; } 
public string DspofLIMIT1 { get; set; } 
public string Filler197 { get; set; } 
public string LIMIT1 { get; set; } 
public string DspofCRMARGIN { get; set; } 
public string Filler198 { get; set; } 
public string CRMARGIN { get; set; } 
public string DspofCRINTRTE { get; set; } 
public string Filler199 { get; set; } 
public string CRINTRTE { get; set; } 
public string DspofDRMARGIN { get; set; } 
public string Filler200 { get; set; } 
public string DRMARGIN { get; set; } 
public string DspofDRINTRTE { get; set; } 
public string Filler201 { get; set; } 
public string DRINTRTE { get; set; } 
public string Dspof1STCRDR1 { get; set; } 
public string Filler202 { get; set; } 
public string STCRDR1 { get; set; } 
public string DspofPAYACNO1 { get; set; } 
public string Filler203 { get; set; } 
public string PAYACNO1 { get; set; } 
public string DspofCRPAYAC1 { get; set; } 
public string Filler204 { get; set; } 
public string CRPAYAC1 { get; set; } 
public string DspofLIMITFLAG { get; set; } 
public string Filler205 { get; set; } 
public string LIMITFLAG { get; set; } 
public string DspofINPDRDNO { get; set; } 
public string Filler206 { get; set; } 
public string INPDRDNO { get; set; } 
public string DspofTAXFLAG { get; set; } 
public string Filler207 { get; set; } 
public string TAXFLAG { get; set; } 
public string DspofBANKCODED { get; set; } 
public string Filler208 { get; set; } 
public string BANKCODE { get; set; } 
public string DspofNONRESCD2 { get; set; } 
public string Filler209 { get; set; } 
public string NONRESCD2 { get; set; } 
public string DspofCRBASECD { get; set; } 
public string Filler210 { get; set; } 
public string CRBASECD { get; set; } 
public string DspofDRBASECD { get; set; } 
public string Filler211 { get; set; } 
public string DRBASECD { get; set; } 
public string DspofSTATFLAGS { get; set; } 
public string Filler212 { get; set; } 
public string STATFLAGS { get; set; } 
public string DspofCNFRMADV { get; set; } 
public string Filler213 { get; set; } 
public string CNFRMADV { get; set; } 
public string DspofRTCHGADV { get; set; } 
public string Filler214 { get; set; } 
public string RTCHGADV { get; set; } 
public string DspofDRINTAPP { get; set; } 
public string Filler215 { get; set; } 
public string DRINTAPP { get; set; } 
public string DspofCRINTAPP { get; set; } 
public string Filler216 { get; set; } 
public string CRINTAPP { get; set; } 
public string DspofDRFRQCD { get; set; } 
public string Filler217 { get; set; } 
public string DRFRQCD { get; set; } 
public string DspofCRFQAPDY { get; set; } 
public string Filler218 { get; set; } 
public string CRFQAPDY { get; set; } 
public string DspofDRINAPDY { get; set; } 
public string Filler219 { get; set; } 
public string DRINAPDY { get; set; } 
public string DspofINTADVICE { get; set; } 
public string Filler220 { get; set; } 
public string INTADVICE { get; set; } 
public string DspofEXTERNAL1 { get; set; } 
public string Filler221 { get; set; } 
public string EXTERNAL1 { get; set; } 
public string DspofACCTSTAT1 { get; set; } 
public string Filler222 { get; set; } 
public string ACCTSTAT1 { get; set; } 
public string DspofACCTOFFC1 { get; set; } 
public string Filler223 { get; set; } 
public string ACCTOFFC1 { get; set; } 
public string DspofBRANCHNO3 { get; set; } 
public string Filler224 { get; set; } 
public string BRANCHNO3 { get; set; } 
public string DspofACCOUNTNO2 { get; set; } 
public string Filler225 { get; set; } 
public string ACCOUNTNO2 { get; set; } 
public string DspofVALUEDATE { get; set; } 
public string Filler226 { get; set; } 
public string VALUEDATE { get; set; } 
public string DspofACCLIMIT { get; set; } 
public string Filler227 { get; set; } 
public string ACCLIMIT { get; set; } 
public string DspofDRBASECD1 { get; set; } 
public string Filler228 { get; set; } 
public string DRBASECD1 { get; set; } 
public string DspofDRMARGIN1 { get; set; } 
public string Filler229 { get; set; } 
public string DRMARGIN1 { get; set; } 
public string DspofDRINTRTE1 { get; set; } 
public string Filler230 { get; set; } 
public string DRINTRTE1 { get; set; } 
public string DspofCRCDMARG { get; set; } 
public string Filler231 { get; set; } 
public string CRCDMARG { get; set; } 
public string DspofCRMARGIN { get; set; } 
public string Filler232 { get; set; } 
public string CRMARGIN { get; set; } 
public string DspofCRINTRTE1 { get; set; } 
public string Filler233 { get; set; } 
public string CRINTRTE1 { get; set; } 
public string DspofDRCRLMCH { get; set; } 
public string Filler234 { get; set; } 
public string DRCRLMCH { get; set; } 
public string DspofFILLER4 { get; set; } 
public string Filler235 { get; set; } 
public string FILLER4 { get; set; } 
public string DspofFILLER5 { get; set; } 
public string Filler236 { get; set; } 
public string FILLER5 { get; set; } 
public string DspofRECTYPE { get; set; } 
public string Filler237 { get; set; } 
public string RECTYPE { get; set; } 
public string DspofCORRADDR1 { get; set; } 
public string Filler238 { get; set; } 
public string CORRADDR1 { get; set; } 
public string DspofINTTYPE1 { get; set; } 
public string Filler239 { get; set; } 
public string INTTYPE1 { get; set; } 
public string DspofSECTYPE11 { get; set; } 
public string Filler240 { get; set; } 
public string SECTYPE11 { get; set; } 
public string DspofSECAMNT11 { get; set; } 
public string Filler241 { get; set; } 
public string SECAMNT11 { get; set; } 
public string DspofSECTYPE21 { get; set; } 
public string Filler242 { get; set; } 
public string SECTYPE21 { get; set; } 
public string DspofSECAMNT21 { get; set; } 
public string Filler243 { get; set; } 
public string SECAMNT21 { get; set; } 
public string DspofSECTYPE31 { get; set; } 
public string Filler244 { get; set; } 
public string SECTYPE31 { get; set; } 
public string DspofSECAMNT31 { get; set; } 
public string Filler245 { get; set; } 
public string SECAMNT31 { get; set; } 
public string DspofSECTYPE41 { get; set; } 
public string Filler246 { get; set; } 
public string SECTYPE41 { get; set; } 
public string DspofSECAMNT41 { get; set; } 
public string Filler247 { get; set; } 
public string SECAMNT41 { get; set; } 
public string DspofSECTYPE51 { get; set; } 
public string Filler248 { get; set; } 
public string SECTYPE51 { get; set; } 
public string DspofSECAMNT51 { get; set; } 
public string Filler249 { get; set; } 
public string SECAMNT51 { get; set; } 
public string DspofSECTYPE61 { get; set; } 
public string Filler250 { get; set; } 
public string SECTYPE61 { get; set; } 
public string DspofSECAMNT61 { get; set; } 
public string Filler251 { get; set; } 
public string SECAMNT61 { get; set; } 
public string DspofPASSW1 { get; set; } 
public string Filler252 { get; set; } 
public string PASSW1 { get; set; } 
public string DspofSECURED1 { get; set; } 
public string Filler253 { get; set; } 
public string SECURED1 { get; set; } 
public string DspofTAKEON1 { get; set; } 
public string Filler254 { get; set; } 
public string TAKEON1 { get; set; } 
public string DspofCORRADD3 { get; set; } 
public string Filler255 { get; set; } 
public string CORRADD3 { get; set; } 
public string DspofCBMCODE1 { get; set; } 
public string Filler256 { get; set; } 
public string CBMCODE1 { get; set; } 
public string DspofCBMNASCD1 { get; set; } 
public string Filler257 { get; set; } 
public string CBMNASCD1 { get; set; } 
public string DspofACCTOWNER1 { get; set; } 
public string Filler258 { get; set; } 
public string ACCTOWNER1 { get; set; } 
public string DspofLOANTYPE1 { get; set; } 
public string Filler259 { get; set; } 
public string LOANTYPE1 { get; set; } 
public string DspofPURPFACIL1 { get; set; } 
public string Filler260 { get; set; } 
public string PURPFACIL1 { get; set; } 
public string DspofCRCNVFAC1 { get; set; } 
public string Filler261 { get; set; } 
public string CRCNVFAC1 { get; set; } 
 
 
 public string GetDefaultString() 
{
return "b4705123450005a4705123450005000010000001312360@000000000000          N       128500BRFO10000000000500020170214RODR0000000ST01  0esiubpglclm 17201130021   01261500606  02070034          03300047                                 04020045   0005080077   2017021406082024   2017021407020410   0008110412   +000000000009080318   0000000010090158   00000000011080328   0000000012090167   00000000013180605                     14130362                15131295                16011042   017020641   0018011043    19010602   020010603   021020316   0022020326   0023050497        24010540   025010354   026010361   027011294   028030382      29051315        30021066   0031010385   032010594    33020596   RE34061926   5BM   35042030   000536202050   0000000000000000000037082070           38122312   00000000000039022324   0040082326   0000000041092336   00000000042022345   0043082347   0000000044092355            45032362   00046070375          47071308          48012049   049010598    50010600   I51011987   952041988   003053011992    54041993       55011997    56041998       57012002    58042003       59012007    60042008       61012012    62042013       63010604   564012017   S65012020    66060533         67011884   A68061885   04090069012021   O70012022   F71012042   T72012043   G";
}
 
 public void SetDefaultValue()
{
DestinationMailbox8="b";
DestinationCountryCode8="470";
DestinationIMDCode8="512345";
DestinationBranchNumber8="0005";
SourceMailbox8="a";
SourceCountryCode8="470";
SourceIMDCode8="512345";
SourceBranchNumber8="0005";
BusinessPeriod8="0000";
MessageType16="1";
SequenceNumber8="000000";
Time8="131236";
TransactionStatus8="0";
MessageFlags8="@";
ReconciliationPeriod8="0000";
ReconciliationCurrency8="000";
ReconciliationAmountSign8="0";
ReconciliationAmount8="0000          ";
Filler20="N       ";
MessageLength8="1285";
TransactionDefinitionId8="0";
TransactionProcessedFlag8="0";
BranchPowerTransactionReferenceId8="BRFO";
MessageType17="1";
BankMasterDestinationBranchNumber16="00";
BankMasterDestinationBranchNumber17="00";
Filler21="0";
InterBranchingFlag8="0";
DeviceId8="0000";
MessageFunctionCode8="5";
TransactionType16="00";
ForcePostFlag8="0";
TransactionDate8="20170214";
UserId8="RODR";
TransactionSequenceNumber8="00000";
TransactionChainNumber8="00";
HostTaskId8="ST01";
BankMasterTransactionType8="  ";
AuthorisedFlag8="0";
Directory8="esiubp";
NameofFile8="glclm ";
TransactionType17="1";
NoofFields5="72";
DspofACCOUNTNO1="01130021";
Filler190="   ";
ACCOUNTNO1="01261500606  ";
DspofFILLER1="02070034";
Filler191="   ";
FILLER1="       ";
DspofACDESCR1="03300047";
Filler192="   ";
ACDESCR1="                              ";
DspofACCTTYPE1="04020045";
Filler193="   ";
ACCTTYPE1="00";
DspofDATEOPEN1="05080077";
Filler194="   ";
DATEOPEN1="20170214";
DspofREVIEWDTE1="06082024";
Filler195="   ";
REVIEWDTE1="20170214";
DspofLIMIT="07020410";
Filler196="   ";
LIMIT="00";
DspofLIMIT1="08110412";
Filler197="   ";
LIMIT1="+0000000000";
DspofCRMARGIN="09080318";
Filler198="   ";
CRMARGIN="00000000";
DspofCRINTRTE="10090158";
Filler199="   ";
CRINTRTE="000000000";
DspofDRMARGIN="11080328";
Filler200="   ";
DRMARGIN="00000000";
DspofDRINTRTE="12090167";
Filler201="   ";
DRINTRTE="000000000";
Dspof1STCRDR1="13180605";
Filler202="   ";
STCRDR1="                  ";
DspofPAYACNO1="14130362";
Filler203="   ";
PAYACNO1="             ";
DspofCRPAYAC1="15131295";
Filler204="   ";
CRPAYAC1="             ";
DspofLIMITFLAG="16011042";
Filler205="   ";
LIMITFLAG="0";
DspofINPDRDNO="17020641";
Filler206="   ";
INPDRDNO="00";
DspofTAXFLAG="18011043";
Filler207="   ";
TAXFLAG=" ";
DspofBANKCODED="19010602";
Filler208="   ";
BANKCODE="0";
DspofNONRESCD2="20010603";
Filler209="   ";
NONRESCD2="0";
DspofCRBASECD="21020316";
Filler210="   ";
CRBASECD="00";
DspofDRBASECD="22020326";
Filler211="   ";
DRBASECD="00";
DspofSTATFLAGS="23050497";
Filler212="   ";
STATFLAGS="     ";
DspofCNFRMADV="24010540";
Filler213="   ";
CNFRMADV="0";
DspofRTCHGADV="25010354";
Filler214="   ";
RTCHGADV="0";
DspofDRINTAPP="26010361";
Filler215="   ";
DRINTAPP="0";
DspofCRINTAPP="27011294";
Filler216="   ";
CRINTAPP="0";
DspofDRFRQCD="28030382";
Filler217="   ";
DRFRQCD="   ";
DspofCRFQAPDY="29051315";
Filler218="   ";
CRFQAPDY="     ";
DspofDRINAPDY="30021066";
Filler219="   ";
DRINAPDY="00";
DspofINTADVICE="31010385";
Filler220="   ";
INTADVICE="0";
DspofEXTERNAL1="32010594";
Filler221="   ";
EXTERNAL1=" ";
DspofACCTSTAT1="33020596";
Filler222="   ";
ACCTSTAT1="RE";
DspofACCTOFFC1="34061926";
Filler223="   ";
ACCTOFFC1="5BM   ";
DspofBRANCHNO3="35042030";
Filler224="   ";
BRANCHNO3="0005";
DspofACCOUNTNO2="36202050";
Filler225="   ";
ACCOUNTNO2="00000000000000000000";
DspofVALUEDATE="37082070";
Filler226="   ";
VALUEDATE="        ";
DspofACCLIMIT="38122312";
Filler227="   ";
ACCLIMIT="000000000000";
DspofDRBASECD1="39022324";
Filler228="   ";
DRBASECD1="00";
DspofDRMARGIN1="40082326";
Filler229="   ";
DRMARGIN1="00000000";
DspofDRINTRTE1="41092336";
Filler230="   ";
DRINTRTE1="000000000";
DspofCRCDMARG="42022345";
Filler231="   ";
CRCDMARG="00";
DspofCRMARGIN="43082347";
Filler232="   ";
CRMARGIN="00000000";
DspofCRINTRTE1="44092355";
Filler233="   ";
CRINTRTE1="         ";
DspofDRCRLMCH="45032362";
Filler234="   ";
DRCRLMCH="000";
DspofFILLER4="46070375";
Filler235="   ";
FILLER4="       ";
DspofFILLER5="47071308";
Filler236="   ";
FILLER5="       ";
DspofRECTYPE="48012049";
Filler237="   ";
RECTYPE="0";
DspofCORRADDR1="49010598";
Filler238="   ";
CORRADDR1=" ";
DspofINTTYPE1="50010600";
Filler239="   ";
INTTYPE1="I";
DspofSECTYPE11="51011987";
Filler240="   ";
SECTYPE11="9";
DspofSECAMNT11="52041988";
Filler241="   ";
SECAMNT11="0030";
DspofSECTYPE21="53011992";
Filler242="   ";
SECTYPE21=" ";
DspofSECAMNT21="54041993";
Filler243="   ";
SECAMNT21="    ";
DspofSECTYPE31="55011997";
Filler244="   ";
SECTYPE31=" ";
DspofSECAMNT31="56041998";
Filler245="   ";
SECAMNT31="    ";
DspofSECTYPE41="57012002";
Filler246="   ";
SECTYPE41=" ";
DspofSECAMNT41="58042003";
Filler247="   ";
SECAMNT41="    ";
DspofSECTYPE51="59012007";
Filler248="   ";
SECTYPE51=" ";
DspofSECAMNT51="60042008";
Filler249="   ";
SECAMNT51="    ";
DspofSECTYPE61="61012012";
Filler250="   ";
SECTYPE61=" ";
DspofSECAMNT61="62042013";
Filler251="   ";
SECAMNT61="    ";
DspofPASSW1="63010604";
Filler252="   ";
PASSW1="5";
DspofSECURED1="64012017";
Filler253="   ";
SECURED1="S";
DspofTAKEON1="65012020";
Filler254="   ";
TAKEON1=" ";
DspofCORRADD3="66060533";
Filler255="   ";
CORRADD3="      ";
DspofCBMCODE1="67011884";
Filler256="   ";
CBMCODE1="A";
DspofCBMNASCD1="68061885";
Filler257="   ";
CBMNASCD1="040900";
DspofACCTOWNER1="69012021";
Filler258="   ";
ACCTOWNER1="O";
DspofLOANTYPE1="70012022";
Filler259="   ";
LOANTYPE1="F";
DspofPURPFACIL1="71012042";
Filler260="   ";
PURPFACIL1="T";
DspofCRCNVFAC1="72012043";
Filler261="   ";
CRCNVFAC1="G";
}

 public string GetStringFromFields() 
{
return DestinationMailbox8+DestinationCountryCode8+DestinationIMDCode8+DestinationBranchNumber8+SourceMailbox8+SourceCountryCode8+SourceIMDCode8+SourceBranchNumber8+BusinessPeriod8+MessageType16+SequenceNumber8+Time8+TransactionStatus8+MessageFlags8+ReconciliationPeriod8+ReconciliationCurrency8+ReconciliationAmountSign8+ReconciliationAmount8+Filler20+MessageLength8+TransactionDefinitionId8+TransactionProcessedFlag8+BranchPowerTransactionReferenceId8+MessageType17+BankMasterDestinationBranchNumber16+BankMasterDestinationBranchNumber17+Filler21+InterBranchingFlag8+DeviceId8+MessageFunctionCode8+TransactionType16+ForcePostFlag8+TransactionDate8+UserId8+TransactionSequenceNumber8+TransactionChainNumber8+HostTaskId8+BankMasterTransactionType8+AuthorisedFlag8+Directory8+NameofFile8+TransactionType17+NoofFields5+DspofACCOUNTNO1+Filler190+ACCOUNTNO1+DspofFILLER1+Filler191+FILLER1+DspofACDESCR1+Filler192+ACDESCR1+DspofACCTTYPE1+Filler193+ACCTTYPE1+DspofDATEOPEN1+Filler194+DATEOPEN1+DspofREVIEWDTE1+Filler195+REVIEWDTE1+DspofLIMIT+Filler196+LIMIT+DspofLIMIT1+Filler197+LIMIT1+DspofCRMARGIN+Filler198+CRMARGIN+DspofCRINTRTE+Filler199+CRINTRTE+DspofDRMARGIN+Filler200+DRMARGIN+DspofDRINTRTE+Filler201+DRINTRTE+Dspof1STCRDR1+Filler202+STCRDR1+DspofPAYACNO1+Filler203+PAYACNO1+DspofCRPAYAC1+Filler204+CRPAYAC1+DspofLIMITFLAG+Filler205+LIMITFLAG+DspofINPDRDNO+Filler206+INPDRDNO+DspofTAXFLAG+Filler207+TAXFLAG+DspofBANKCODED+Filler208+BANKCODE+DspofNONRESCD2+Filler209+NONRESCD2+DspofCRBASECD+Filler210+CRBASECD+DspofDRBASECD+Filler211+DRBASECD+DspofSTATFLAGS+Filler212+STATFLAGS+DspofCNFRMADV+Filler213+CNFRMADV+DspofRTCHGADV+Filler214+RTCHGADV+DspofDRINTAPP+Filler215+DRINTAPP+DspofCRINTAPP+Filler216+CRINTAPP+DspofDRFRQCD+Filler217+DRFRQCD+DspofCRFQAPDY+Filler218+CRFQAPDY+DspofDRINAPDY+Filler219+DRINAPDY+DspofINTADVICE+Filler220+INTADVICE+DspofEXTERNAL1+Filler221+EXTERNAL1+DspofACCTSTAT1+Filler222+ACCTSTAT1+DspofACCTOFFC1+Filler223+ACCTOFFC1+DspofBRANCHNO3+Filler224+BRANCHNO3+DspofACCOUNTNO2+Filler225+ACCOUNTNO2+DspofVALUEDATE+Filler226+VALUEDATE+DspofACCLIMIT+Filler227+ACCLIMIT+DspofDRBASECD1+Filler228+DRBASECD1+DspofDRMARGIN1+Filler229+DRMARGIN1+DspofDRINTRTE1+Filler230+DRINTRTE1+DspofCRCDMARG+Filler231+CRCDMARG+DspofCRMARGIN+Filler232+CRMARGIN+DspofCRINTRTE1+Filler233+CRINTRTE1+DspofDRCRLMCH+Filler234+DRCRLMCH+DspofFILLER4+Filler235+FILLER4+DspofFILLER5+Filler236+FILLER5+DspofRECTYPE+Filler237+RECTYPE+DspofCORRADDR1+Filler238+CORRADDR1+DspofINTTYPE1+Filler239+INTTYPE1+DspofSECTYPE11+Filler240+SECTYPE11+DspofSECAMNT11+Filler241+SECAMNT11+DspofSECTYPE21+Filler242+SECTYPE21+DspofSECAMNT21+Filler243+SECAMNT21+DspofSECTYPE31+Filler244+SECTYPE31+DspofSECAMNT31+Filler245+SECAMNT31+DspofSECTYPE41+Filler246+SECTYPE41+DspofSECAMNT41+Filler247+SECAMNT41+DspofSECTYPE51+Filler248+SECTYPE51+DspofSECAMNT51+Filler249+SECAMNT51+DspofSECTYPE61+Filler250+SECTYPE61+DspofSECAMNT61+Filler251+SECAMNT61+DspofPASSW1+Filler252+PASSW1+DspofSECURED1+Filler253+SECURED1+DspofTAKEON1+Filler254+TAKEON1+DspofCORRADD3+Filler255+CORRADD3+DspofCBMCODE1+Filler256+CBMCODE1+DspofCBMNASCD1+Filler257+CBMNASCD1+DspofACCTOWNER1+Filler258+ACCTOWNER1+DspofLOANTYPE1+Filler259+LOANTYPE1+DspofPURPFACIL1+Filler260+PURPFACIL1+DspofCRCNVFAC1+Filler261+CRCNVFAC1;
}
 
}
