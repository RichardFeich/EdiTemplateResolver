namespace EdiFabric.Templates.X12003060
{
    using System;
    using System.Runtime.Serialization;
    using EdiFabric.Core.Annotations.Edi;

    /// <summary>
    /// Car Hire Detail/Summary Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,9,")]
    public class X12_ID_1002
    {
    }

    /// <summary>
    /// Percent Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",05,06,07,08,09,1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,3,30,31" +
        ",32,33,34,35,36,37,38,4,5,59,6,7,8,9,AN,AP,AT,BG,BU,CN,CP,CR,CS,DF,DY,EF,GA,IN,K" +
        "A,KB,LM,MN,NA,OF,OH,PA,PC,PF,PH,PM,PN,PP,PR,RA,RB,RC,RD,RP,RQ,SA,SC,SD,SE,SF,SG," +
        "TP,WI,WK,X1,")]
    public class X12_ID_1004
    {
    }

    /// <summary>
    /// Hierarchical Structure Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0001,0002,0003,0004,0010,0011,0012,0013,0014,0015,0016,0017,0018,0019,0020,0021," +
        "0022,0023,0035,0036,0056,0057,0058,0059,0060,0061,0062,0063,0064,0065,0066,0067," +
        "0068,0069,0070,0071,0072,0073,0074,0075,0076,0077,0078,0079,0080,0081,0082,")]
    public class X12_ID_1005
    {
    }

    /// <summary>
    /// Account Description Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,6,7,8,9,AA,")]
    public class X12_ID_1006
    {
    }

    /// <summary>
    /// Rate Source
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,C,T,U,")]
    public class X12_ID_1007
    {
    }

    /// <summary>
    /// Case Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",11,12,13,30,6,7,9,AG,AP,AR,CR,CV,DO,JV,MS,NT,OT,PC,TR,XX,ZZ,")]
    public class X12_ID_1008
    {
    }

    /// <summary>
    /// Court Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,AD,AL,AS,B,C,CA,CH,CI,CL,CM,CN,CO,CP,CR,CS,CT,CV,CY,D,DI,DJ,DO,DS,FC,GS,HO,I,I" +
        "C,JP,JU,LA,M,MA,MC,MU,MY,OR,OT,P,PC,PO,PR,S,SA,SC,SD,SR,SS,ST,SU,TA,TR,V,WA,X,ZZ" +
        ",")]
    public class X12_ID_1009
    {
    }

    /// <summary>
    /// Court Event Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,AS,C,CL,D,DO,H,M,N,O,OP,OR,OT,P,PA,PE,PY,S,SJ,SU,TR,W,ZZZ,")]
    public class X12_ID_1012
    {
    }

    /// <summary>
    /// Notice Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,101,11B,11I,12B,12I,12N,12Y,13B,13I,13N,13Y,18J,18O,2,23A,23B,24B,25,26,27,28,3,305,306,308,309,310,311,315,4,417,5,603,610,611,612,616,619,621,623,625,628,629,630,631,638,642,70,700,701,7BA,7IA,9A,9B,9C,9D,9E,9F,9G,9H,9I,DEF,DIS,DOT,FAM,FCL,FFS,ITB,NOA,OCP,ODC,OFR,POC,SCH,ZZZ,")]
    public class X12_ID_1013
    {
    }

    /// <summary>
    /// Mileage Settlement Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,7,9,")]
    public class X12_ID_1015
    {
    }

    /// <summary>
    /// Penalty Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,3,4,5,")]
    public class X12_ID_1016
    {
    }

    /// <summary>
    /// Claim Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,AR,BG,BM,BO,BP,BR,BS,BT,BW,P,PA,PB,PC,PD,PE,PF,PO,PT,PW,SM,SO,SR,T,U,")]
    public class X12_ID_1017
    {
    }

    /// <summary>
    /// Invoice Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",IBM,IEL,INR,")]
    public class X12_ID_1019
    {
    }

    /// <summary>
    /// Ownership Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",L,N,R,S,T,")]
    public class X12_ID_102
    {
    }

    /// <summary>
    /// Sampling Sequence Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",GC,SU,UP,")]
    public class X12_ID_1020
    {
    }

    /// <summary>
    /// Hazard Zone Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,")]
    public class X12_ID_1023
    {
    }

    /// <summary>
    /// Loading or Discharge Location Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,C,R,")]
    public class X12_ID_1025
    {
    }

    /// <summary>
    /// Vessel Material Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",999,ALU,CST,FBG,NIK,SST,TTN,")]
    public class X12_ID_1026
    {
    }

    /// <summary>
    /// Claim Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,4,5,6,7,8,9" +
        ",AP,CL,CP,RA,RC,RO,")]
    public class X12_ID_1029
    {
    }

    /// <summary>
    /// Gasket Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",999,ASB,BUN,BUT,EPD,FDA,HYP,KAL,LEA,NAT,NEO,SAN,TEF,VIT,")]
    public class X12_ID_1030
    {
    }

    /// <summary>
    /// Trailer Lining Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",999,BUT,CER,CHL,DER,HAL,HER,KYN,NAT,NIC,POL,TEF,VIT,")]
    public class X12_ID_1031
    {
    }

    /// <summary>
    /// Claim Filing Indicator Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,AM,BL,CH,CI,CN" +
        ",DS,FI,HM,LI,LM,MA,MB,MC,MH,OF,SA,TV,VA,WB,WC,WD,WE,ZZ,")]
    public class X12_ID_1032
    {
    }

    /// <summary>
    /// Claim Adjustment Group Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CO,CR,DE,MA,NC,OA,PI,PR,")]
    public class X12_ID_1033
    {
    }

    /// <summary>
    /// Type of Bankruptcy Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,")]
    public class X12_ID_104
    {
    }

    /// <summary>
    /// Load or Device Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AC,BL,BS,PS,PU,")]
    public class X12_ID_1042
    {
    }

    /// <summary>
    /// Hose Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AAM,ACD,CEM,CRO,FDA,GAL,HOT,LIQ,NIR,NIT,PUR,SST,TEF,VIT,")]
    public class X12_ID_1044
    {
    }

    /// <summary>
    /// Inlet or Outlet Material Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AL,BR,IR,NS,SS,")]
    public class X12_ID_1045
    {
    }

    /// <summary>
    /// Inlet or Outlet Fitting Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AC,DF,DM,QF,QM,TH,TM,")]
    public class X12_ID_1046
    {
    }

    /// <summary>
    /// Miscellaneous Equipment Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AD,AF,AI,CY,DB,DR,ME,ND,NO,PR,SC,SE,VI,")]
    public class X12_ID_1047
    {
    }

    /// <summary>
    /// Business Function Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CON,PCS,PEN,TAX,VEN,")]
    public class X12_ID_1048
    {
    }

    /// <summary>
    /// Market Exchange Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",LX1,LX2,")]
    public class X12_ID_1053
    {
    }

    /// <summary>
    /// Commodity Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AG,AU,PT,")]
    public class X12_ID_1054
    {
    }

    /// <summary>
    /// Vehicle Service Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AF,BK,CB,CC,CL,CS,DP,LD,LS,MM,PH,PL,RL,RP,RS,SH,SW,UL,WH,WW,")]
    public class X12_ID_1062
    {
    }

    /// <summary>
    /// Entity Type Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class X12_ID_1065
    {
    }

    /// <summary>
    /// Citizenship Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,")]
    public class X12_ID_1066
    {
    }

    /// <summary>
    /// Marital Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,D,I,K,M,R,S,U,W,X,")]
    public class X12_ID_1067
    {
    }

    /// <summary>
    /// Gender Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",F,M,U,")]
    public class X12_ID_1068
    {
    }

    /// <summary>
    /// Individual Relationship Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,36,37,38,39,40,41,43,45,46,47,48,49,50,51,52,53,55,56,57,58,59,60,61,62,63,64,65,66,67,68,70,71,72,73,74,75,76,78,79,80,81,82,83,84,86,87,88,90,91,92,93,94,95,96,97,98,99,A1,A2,A3,A4,A5,A6,A7,A8,A9,B1,B2,B3,B4,B5,B6,B7,B8,B9,C1,C2,C3,C4,C5,C8,C9,D1,D2,D3,D4,D5,D6,D7,D8,D9,E1,E2,E3,E4,E5,E6,E7,OT,ZZ,")]
    public class X12_ID_1069
    {
    }

    /// <summary>
    /// Payment Method Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,")]
    public class X12_ID_107
    {
    }

    /// <summary>
    /// Type of Residence Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,9,A,B,C,D,F,H,I,L,N,")]
    public class X12_ID_1070
    {
    }

    /// <summary>
    /// General Expense Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27" +
        ",28,29,91,92,93,94,")]
    public class X12_ID_1071
    {
    }

    /// <summary>
    /// Rounding System Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",5,D,T,U,")]
    public class X12_ID_1072
    {
    }

    /// <summary>
    /// Yes/No Condition or Response Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,U,Y,")]
    public class X12_ID_1073
    {
    }

    /// <summary>
    /// Type of Real Estate Asset Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28" +
        ",29,UN,")]
    public class X12_ID_1074
    {
    }

    /// <summary>
    /// Status of Plans for Real Estate Asset Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",H,P,R,S,T,")]
    public class X12_ID_1075
    {
    }

    /// <summary>
    /// Real Estate Loan Security Instrument Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",D,L,M,")]
    public class X12_ID_1076
    {
    }

    /// <summary>
    /// Property Value Estimate Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,C,R,")]
    public class X12_ID_1077
    {
    }

    /// <summary>
    /// Property Ownership Rights Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,F,G,L,O,R,U,X,")]
    public class X12_ID_1078
    {
    }

    /// <summary>
    /// Contact Method Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",E,F,M,T,")]
    public class X12_ID_1079
    {
    }

    /// <summary>
    /// Pick-up or Delivery Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AT,BC,CA,CB,CC,CP,CR,CS,CT,DB,DT,H,IB,IR,J,LD,M,O,OC,OT,P,PB,RB,RC,RD,RG,RR,S,SD" +
        ",U,V,")]
    public class X12_ID_108
    {
    }

    /// <summary>
    /// Assumption Terms Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",2,3,")]
    public class X12_ID_1080
    {
    }

    /// <summary>
    /// Loan Purpose Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,AL,AR,AU,BO,CC,CO,CT" +
        ",FM,MH,PE,RE,RV,SL,SM,SO,")]
    public class X12_ID_1081
    {
    }

    /// <summary>
    /// Purpose of Refinance Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,04,05,06,11,12,13,14,ZZ,")]
    public class X12_ID_1082
    {
    }

    /// <summary>
    /// Type of Downpayment Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,09,10,11,12,13,14,27,28,ZZ,")]
    public class X12_ID_1083
    {
    }

    /// <summary>
    /// Loan Buydown Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",P,T,")]
    public class X12_ID_1084
    {
    }

    /// <summary>
    /// Loan Payment Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,22,23,24,25,")]
    public class X12_ID_1085
    {
    }

    /// <summary>
    /// Loan Rate Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,")]
    public class X12_ID_1086
    {
    }

    /// <summary>
    /// Negative Amortization Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,P,S,")]
    public class X12_ID_1087
    {
    }

    /// <summary>
    /// Rate Life Cap Source Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class X12_ID_1088
    {
    }

    /// <summary>
    /// Source of Interest Rate Change Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27" +
        ",28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,5" +
        "4,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,ZZ,")]
    public class X12_ID_1089
    {
    }

    /// <summary>
    /// Improvement Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,I,P,")]
    public class X12_ID_1090
    {
    }

    /// <summary>
    /// Buydown Source Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,")]
    public class X12_ID_1091
    {
    }

    /// <summary>
    /// Negative Amoritzation Cap Source Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class X12_ID_1092
    {
    }

    /// <summary>
    /// Real Estate Loan Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,Z,")]
    public class X12_ID_1093
    {
    }

    /// <summary>
    /// Mortgage Insurance Application Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,")]
    public class X12_ID_1097
    {
    }

    /// <summary>
    /// Mortgage Insurance Premium Source Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,F,")]
    public class X12_ID_1098
    {
    }

    /// <summary>
    /// Mortgage Insurance Certificate Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,O,P,")]
    public class X12_ID_1099
    {
    }

    /// <summary>
    /// Billing Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,J,M,P,Q,R,S,T,U,V,W,X,Y,")]
    public class X12_ID_11
    {
    }

    /// <summary>
    /// Application Acknowledgment Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BA,BC,BE,BP,BR,GA,GC,GE,GP,GR,IA,IC,IE,IP,IR,TA,TC,TE,TP,TR,")]
    public class X12_ID_110
    {
    }

    /// <summary>
    /// Mortgage Insurance Coverage Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,Z,")]
    public class X12_ID_1100
    {
    }

    /// <summary>
    /// Lien Priority Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,W,")]
    public class X12_ID_1101
    {
    }

    /// <summary>
    /// Mortgage Insurance Renewal Option Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,D,N,")]
    public class X12_ID_1102
    {
    }

    /// <summary>
    /// Loan Documentation Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,F,R,")]
    public class X12_ID_1103
    {
    }

    /// <summary>
    /// Name Component Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,")]
    public class X12_ID_1104
    {
    }

    /// <summary>
    /// Mortgage Insurance Duration Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,")]
    public class X12_ID_1105
    {
    }

    /// <summary>
    /// Address Component Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,30,31,32,33,34" +
        ",35,36,37,38,39,")]
    public class X12_ID_1106
    {
    }

    /// <summary>
    /// Name Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,11,12,13,17,18,19,20,21,")]
    public class X12_ID_1107
    {
    }

    /// <summary>
    /// Month of the Year Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,")]
    public class X12_ID_1108
    {
    }

    /// <summary>
    /// Race or Ethnicity Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",7,8,A,B,C,D,E,F,G,H,I,J,N,O,P,Z,")]
    public class X12_ID_1109
    {
    }

    /// <summary>
    /// Coupon Distribution Media Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BB,DH,DM,EC,FS,HO,HS,IL,IP,MO,MR,NC,OP,RI,SP,TM,")]
    public class X12_ID_1113
    {
    }

    /// <summary>
    /// Vent Setting Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,Z,")]
    public class X12_ID_1122
    {
    }

    /// <summary>
    /// Offer Basis Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",EX,FE,NS,NT,PF,SD,SM,TO,TR,ZZ,")]
    public class X12_ID_1123
    {
    }

    /// <summary>
    /// Interline Settlement System Status Action or Dispute Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CA,CC,CD,CH,CO,CP,CT,DA,DG,DO,DR,DT,GD,LT,NP,NR,OP,OR,PS,PT,RT,SA,SC,SF,SN,SS,ST" +
        ",T1,TD,TR,UT,")]
    public class X12_ID_1127
    {
    }

    /// <summary>
    /// Adjustment Reason Code Characteristic
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,10,11,12,13,14,15,16,17,18,19,2,22,23,24,25,26,27,28,29,3,30,31,32,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,6,60,61,62,63,64,65,66,67,69,7,71,72,73,74,75,76,77,78,79,8,80,81,82,83,84,85,86,87,88,89,9,90,91,92,93,94,95,96,97,98,99,A1,A2,A3,A4,A5,A6,A7,A8,A9,B1,B2,B3,B4,B5,B6,B7,B8,B9,C1,C2,C3,C4,C5,C6,C7,C8,C9,D1,D2,D3,D4,D5,D6,D7,D8,D9,E1,E2,E3,E4,E5,E6,E7,F1,F2,F3,F4,F5,F6,F7,G2,G3,G4,G5,G6,G7,G8,G9,H2,")]
    public class X12_ID_1129
    {
    }

    /// <summary>
    /// Primary or Contingent Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,P,")]
    public class X12_ID_1130
    {
    }

    /// <summary>
    /// Level of Individual, Test, or Course Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,0K,10,11,12,20,21,22,23,24,25,26,27,28,29,30,31,32,33" +
        ",AD,AS,BD,C2,DD,EL,EM,HG,HS,IF,IN,MD,MS,NO,P0,P1,P2,P3,P4,P5,PC,PD,PF,PK,PS,UN,V" +
        "R,VS,")]
    public class X12_ID_1131
    {
    }

    /// <summary>
    /// Instructional Setting Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,3,4,5,6,7,8,9,")]
    public class X12_ID_1132
    {
    }

    /// <summary>
    /// Other Program Participation and Services Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34" +
        ",35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59," +
        "6,60,61,62,63,64,65,66,67,68,69,7,70,71,72,8,9,")]
    public class X12_ID_1133
    {
    }

    /// <summary>
    /// Other Program and Services Funding Source Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,")]
    public class X12_ID_1134
    {
    }

    /// <summary>
    /// Placement Criteria Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,")]
    public class X12_ID_1135
    {
    }

    /// <summary>
    /// Code Category
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,69,70,71,72,73,74,75,76,77,78,79,80,81,82,85,A1,A2,A3,A4,A5,A7,A8,A9,AI,B1,B2,B3,B4,B5,B6,B7,B8,B9,BP,BR,CC,CO,DA,DD,GD,GS,MS,OT,PR,PT,RI,RL,SN,ST,")]
    public class X12_ID_1136
    {
    }

    /// <summary>
    /// Payer Responsibility Sequence Number Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,O,P,S,T,U,")]
    public class X12_ID_1138
    {
    }

    /// <summary>
    /// Session Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,")]
    public class X12_ID_1139
    {
    }

    /// <summary>
    /// Floor Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,D,F,S,W,")]
    public class X12_ID_1140
    {
    }

    /// <summary>
    /// Academic Credit Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,C,G,N,Q,S,U,V,X,")]
    public class X12_ID_1141
    {
    }

    /// <summary>
    /// Academic Grade or Course Level Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,3,4,5,6,7,8,9,A,AR,B,D,DL,E,F,G,H,I,L,M,P,R,T," +
        "U,V,")]
    public class X12_ID_1142
    {
    }

    /// <summary>
    /// Coordination of Benefits Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,")]
    public class X12_ID_1143
    {
    }

    /// <summary>
    /// Disability Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,Z,")]
    public class X12_ID_1146
    {
    }

    /// <summary>
    /// Basis for Academic Credit Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,I,M,N,R,T,V,W,X,Z,")]
    public class X12_ID_1147
    {
    }

    /// <summary>
    /// Port Function Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,V,W,Y,")]
    public class X12_ID_115
    {
    }

    /// <summary>
    /// Course Repeat or No Count Indicator Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,R,X,")]
    public class X12_ID_1150
    {
    }

    /// <summary>
    /// Override Academic Course Source Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",IA,MC,TC,")]
    public class X12_ID_1152
    {
    }

    /// <summary>
    /// Academic Field of Study Level or Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,E,G,L,M,N,S,T,V,")]
    public class X12_ID_1153
    {
    }

    /// <summary>
    /// Work Intensity Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",H,L,M,R,")]
    public class X12_ID_1154
    {
    }

    /// <summary>
    /// Test Norm Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,Z,")]
    public class X12_ID_1156
    {
    }

    /// <summary>
    /// Test Norming Period Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,")]
    public class X12_ID_1157
    {
    }

    /// <summary>
    /// Test Score Interpretation Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,")]
    public class X12_ID_1159
    {
    }

    /// <summary>
    /// Test Score Qualifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,B,Z,")]
    public class X12_ID_1160
    {
    }

    /// <summary>
    /// Product Option Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,2,3,4,5,6,7,8,9,C,D,N,NC,O,S,")]
    public class X12_ID_1161
    {
    }

    /// <summary>
    /// Show Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",EV,FS,LA,LN,LS,MA,NR,SP,")]
    public class X12_ID_1162
    {
    }

    /// <summary>
    /// Ticket Catagory Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AD,CH,EX,GR,NR,RR,SP,ST,")]
    public class X12_ID_1163
    {
    }

    /// <summary>
    /// Network or Schedule Data Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,ZZ,")]
    public class X12_ID_1164
    {
    }

    /// <summary>
    /// Confidentiality Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",O,R,U,")]
    public class X12_ID_1165
    {
    }

    /// <summary>
    /// Contract Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,09,AC,CA,CB,CH,CP,CS,CW,CX,CY,DI,FA,FB,FC,FD,FE,FF,FG,FH,FI,FJ" +
        ",FK,FL,FM,FR,FX,LA,LE,LH,OC,SP,TM,ZZ,")]
    public class X12_ID_1166
    {
    }

    /// <summary>
    /// Door Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A1,A2,A3,A4,A5,A6,A7,AO,B1,B2,B3,B4,B5,B6,B7,BO,")]
    public class X12_ID_1168
    {
    }

    /// <summary>
    /// Claim Response Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CDR,CMP,DC,ELH,ELR,EPC,EW,FRS,FWC,IIS,IRS,IWS,MAP,NCR,NEW,NOP,NRI,NSB,NWR,PNP,PW" +
        "A,RDP,SUB,UPR,UR,URF,WBS,")]
    public class X12_ID_1172
    {
    }

    /// <summary>
    /// Task ID Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,20,21,22,ZZ,")]
    public class X12_ID_1173
    {
    }

    /// <summary>
    /// Employment Class Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27" +
        ",28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,ZZ,")]
    public class X12_ID_1176
    {
    }

    /// <summary>
    /// Customs Entry Type Group Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,W,")]
    public class X12_ID_1179
    {
    }

    /// <summary>
    /// Resource Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,EA,EF,EP,EU,FR,LA,LD,LE,LO,LP,LS,MA,MC,MN,OT,SC,")]
    public class X12_ID_1181
    {
    }

    /// <summary>
    /// Public Record or Obligation Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,ZZ,")]
    public class X12_ID_1185
    {
    }

    /// <summary>
    /// Type of Income Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,16,17,18,19,20,21,22,23,24,25,26,27,28" +
        ",29,30,31,32,33,34,40,41,42,43,44,45,91,92,93,94,BG,HR,K1,PD,PS,SA,SB,SC,SP,VP,Z" +
        "Z,")]
    public class X12_ID_1186
    {
    }

    /// <summary>
    /// Type of Account Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27" +
        ",28,")]
    public class X12_ID_1187
    {
    }

    /// <summary>
    /// Type of Personal Property Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,")]
    public class X12_ID_1188
    {
    }

    /// <summary>
    /// Type of Credit Account Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,I,M,O,R,")]
    public class X12_ID_1189
    {
    }

    /// <summary>
    /// Program Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,11,12,13,14,15,16,AR,AZ,BD,CL,CS,GA,GD,GP,GT,MH,PL,PN,SF" +
        ",SN,")]
    public class X12_ID_1193
    {
    }

    /// <summary>
    /// Breakdown Structure Detail Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,BL,BY,CM,CY,ES,EX,FP,FR,MR,NP,TC,UB,ZZ,")]
    public class X12_ID_1196
    {
    }

    /// <summary>
    /// Financial Transaction Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AV,BA,BM,BP,BV,C,D,M,NA,O,P,R,RD,RE,RI,RN,S,TR,")]
    public class X12_ID_1197
    {
    }

    /// <summary>
    /// Contracting Funding Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,")]
    public class X12_ID_1198
    {
    }

    /// <summary>
    /// Appropriation Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,ZZ,")]
    public class X12_ID_1199
    {
    }

    /// <summary>
    /// Information Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,P,")]
    public class X12_ID_1201
    {
    }

    /// <summary>
    /// Flexible Spending Account Selection Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",D,E,H,L,Z,")]
    public class X12_ID_1202
    {
    }

    /// <summary>
    /// Maintenance Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27" +
        ",28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,5" +
        "4,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,XB,XI,XL,XM,XN,XT," +
        "ZZ,")]
    public class X12_ID_1203
    {
    }

    /// <summary>
    /// Insurance Line Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",403,AC,ADD,AF,AP,AR,BC,BE,BH,BK,CHU,CLF,CV,DCP,DEN,EMP,EPO,FAC,FSA,GDC,HE,HLT,HM" +
        "O,IRA,IRC,LL,LTC,LTD,MM,MOD,NGD,NQ,PDG,POS,PPO,PRA,PSP,QDA,QDC,STD,UL,UR,VIS,ZZZ" +
        ",")]
    public class X12_ID_1205
    {
    }

    /// <summary>
    /// Coverage Level Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CHD,DEP,E1D,E2D,E3D,E5D,E6D,E7D,E8D,E9D,ECH,EMP,ESP,FAM,IND,SPC,SPO,TWO,")]
    public class X12_ID_1207
    {
    }

    /// <summary>
    /// Underwriting Decision Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,I,N,S,")]
    public class X12_ID_1209
    {
    }

    /// <summary>
    /// Rate Class Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,BHR,C,CTR,DMA,DMB,DMC,E,ECR,F,H,I,L,M,N,O,Q,QUO,R,S,U,V,X,Y,")]
    public class X12_ID_121
    {
    }

    /// <summary>
    /// Drug House Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AM,BAX,FLR,HCS,NP,PCS,THR,ZZ,")]
    public class X12_ID_1211
    {
    }

    /// <summary>
    /// Health-Related Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,S,T,U,X,")]
    public class X12_ID_1212
    {
    }

    /// <summary>
    /// Current Health Condition Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,E,F,G,P,")]
    public class X12_ID_1213
    {
    }

    /// <summary>
    /// Identification Card Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",D,H,P,")]
    public class X12_ID_1215
    {
    }

    /// <summary>
    /// Benefit Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,C,S,T,")]
    public class X12_ID_1216
    {
    }

    /// <summary>
    /// Medicare Plan Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,")]
    public class X12_ID_1218
    {
    }

    /// <summary>
    /// Consolidated Omnibus Budget Reconciliation Act (COBRA) Qualifying Event Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,ZZ,")]
    public class X12_ID_1219
    {
    }

    /// <summary>
    /// Rate/Value Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",AA,AC,AV,B0,B1,BF,BL,BR,C5,CF,CM,CO,CP,CS,CT,CW,DD,DP,DR,DS,DV,EI,ER,FC,FF,FL,FN,FR,FT,FV,GT,HD,HM,HN,HX,HY,IN,KG,KL,KP,KT,LB,LF,LI,LP,LR,LS,LT,MA,MB,MC,MD,ME,MH,MI,MM,MN,MO,MP,MR,MS,MT,MV,MW,MX,ND,NE,NM,NP,NV,P0,P1,PA,PB,PC,PD,PE,PF,PG,PH,PI,PK,PL,PM,PN,PP,PQ,PR,PS,PT,PU,PV,PW,PY,PZ,QY,RA,RB,RL,RP,RT,S0,S1,SC,SD,SF,SP,ST,SU,SY,TB,TC,TD,TN,TP,TR,VA,VH,VM,VP,VR,VS,VT,VU,VV,WK,WM,XP,YR,")]
    public class X12_ID_122
    {
    }

    /// <summary>
    /// Student Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",F,N,P,")]
    public class X12_ID_1220
    {
    }

    /// <summary>
    /// Provider Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AD,AS,AT,BI,BS,CO,CV,H,HH,LA,ON,OP,OR,OT,P1,P2,PC,PE,PT,PU,R,RF,RP,SB,SK,SU,")]
    public class X12_ID_1221
    {
    }

    /// <summary>
    /// Provider Organization Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",001,002,003,004,005,006,007,008,")]
    public class X12_ID_1223
    {
    }

    /// <summary>
    /// Contribution Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AC,EA,EB,EC,ED,EI,EM,EP,ER,ES,ET,EU,IC,MB,MS,MT,MU,NC,NQ,PB,PS,PT,QC,QE,QM,QP,RA" +
        ",RK,RO,RP,RS,RT,SD,SP,ZZ,")]
    public class X12_ID_1224
    {
    }

    /// <summary>
    /// Type of Product Service Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AF,CA,CB,CC,CG,CP,CR,CS,CW,DD,DW,EC,ED,EE,EF,EM,EW,FC,FW,GC,GM,GR,IO,LF,LL,LO,LP" +
        ",LW,MB,MC,MG,MI,MR,MS,NE,OW,PD,PG,PL,PO,PW,QP,RC,RD,RN,RP,RR,RS,RT,SB,SC,SD,SP,S" +
        "S,ST,SW,TC,TP,UE,WC,")]
    public class X12_ID_1230
    {
    }

    /// <summary>
    /// Purchase Category
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AE,CN,DR,ER,IR,MD,OV,RD,RE,SB,SP,SU,SV,TE,UT,")]
    public class X12_ID_1232
    {
    }

    /// <summary>
    /// Payment Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",6A,9A,9B,9C,")]
    public class X12_ID_1236
    {
    }

    /// <summary>
    /// Move Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",F,J,P,R,T,")]
    public class X12_ID_1237
    {
    }

    /// <summary>
    /// Bay Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class X12_ID_1238
    {
    }

    /// <summary>
    /// Capacity Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,AA,")]
    public class X12_ID_1239
    {
    }

    /// <summary>
    /// Facility Characteristic Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1G,2G,A,AX,BC,BW,C,CL,CX,D,DA,FX,G,GA,GX,J,K,L,LK,M,N,NF,NH,OF,RH,RR,TP,TR,U,Y,")]
    public class X12_ID_1240
    {
    }

    /// <summary>
    /// Facility Characteristic Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,F,H,L,P,S,X,")]
    public class X12_ID_1241
    {
    }

    /// <summary>
    /// Special Rate Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BH,RT,TA,")]
    public class X12_ID_1246
    {
    }

    /// <summary>
    /// Date Time Period Format Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CC,CD,CM,CY,D6,D8,DD,DT,DTS,EH,MD,MM,RD2,RD4,RD5,RD6,RD8,RDM,RDT,RMD,RMY,RTM,RTS" +
        ",TC,TM,TQ,TR,TS,TT,TU,YM,YY,")]
    public class X12_ID_1250
    {
    }

    /// <summary>
    /// Immunization Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,2,3,4,5,6,7,8,9,")]
    public class X12_ID_1254
    {
    }

    /// <summary>
    /// Special Education Program Participation Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,3,4,5,6,7,8,9,99,")]
    public class X12_ID_1257
    {
    }

    /// <summary>
    /// Loan Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34" +
        ",35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,6,7,8," +
        "9,")]
    public class X12_ID_1262
    {
    }

    /// <summary>
    /// Delayed Repayment Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34,35,36" +
        ",37,4,5,6,7,8,9,")]
    public class X12_ID_1264
    {
    }

    /// <summary>
    /// Interest Payment Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,")]
    public class X12_ID_1265
    {
    }

    /// <summary>
    /// Major Course of Study
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,2,3,4,5,6,7,8,9,")]
    public class X12_ID_1266
    {
    }

    /// <summary>
    /// Dependency Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,")]
    public class X12_ID_1267
    {
    }

    /// <summary>
    /// Applicant Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class X12_ID_1268
    {
    }

    /// <summary>
    /// Code List Qualifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",0,1,10,11,12,13,14,16,17,19,2,20,21,22,23,24,25,26,27,28,29,3,30,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,52,53,54,55,56,57,58,59,6,60,61,62,63,66,67,69,7,71,74,75,78,79,8,80,81,82,83,84,85,87,88,89,9,90,91,92,93,94,95,96,97,98,99,A,A1,A2,A3,A4,A5,A6,A7,A8,A9,AA,AB,ABR,ABS,AC,AD,AH,AI,AJ,AK,AL,AP,AQ,AR,AT,AU,AW,AX,B,BA,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BO,BP,BQ,BR,BS,BT,BU,BZ,C,C1,C2,C3,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CS,CT,CU,CV,D,DB,DD,DE,DF,DG,DK,DL,DN,DPE,DPL,DT,E,EA,EB,EC,ED,EE,EF,EH,EI,EJ,EK,EL,EM,EN,EQ,ER,ET,EU,EV,EW,EX,EY,EZ,FA,FB,FC,FD,FE,FF,FG,FH,FI,FJ,FK,FL,FM,FN,FO,FP,FQ,FR,FS,FT,FU,FV,FW,FX,FZ,G1,GA,GB,GC,GD,GE,GF,GG,GI,GJ,GK,HA,HB,HD,HE,HRC,HS,HZR,I,IC,IT,J0,J1,J2,J3,J4,J5,J6,J7,J8,J9,JA,JB,JC,JD,JE,JF,JG,JH,JI,JK,JL,JM,JN,JO,JP,KA,KB,KC,KD,KE,KF,KG,KH,KI,KJ,KK,KL,LA,LB,LC,LD,LN,LO,LP,LQ,LR,LS,LT,LZ,MB,MC,MI,NA,NB,NC,ND,NDC,NE,NF,NG,NH,NI,NJ,NK,NL,NP,NR,NS,NT,OC,PB,PC,PI,PLC,PLS,PPD,PPP,PPS,PPV,PRA,PRC,PRR,PRT,PWA,PWR,PWS,PWT,QS,RA,RC,RD,RE,RF,RI,RR,RT,S,SA,SB,SC,SD,SE,SF,SI,SJ,SK,SL,SM,SO,SP,SR,SS,ST,TB,TC,TD,TE,TF,TG,UP,W,ZZ,")]
    public class X12_ID_1270
    {
    }

    /// <summary>
    /// Direction Facing
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,F,U,")]
    public class X12_ID_1273
    {
    }

    /// <summary>
    /// Fumigated/Cleaned Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,C,F,N,")]
    public class X12_ID_1275
    {
    }

    /// <summary>
    /// Canadian Wheat Board (CWB) Marketing Class Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,4,5,")]
    public class X12_ID_1277
    {
    }

    /// <summary>
    /// Canadian Wheat Board (CWB) Marketing Class Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,S,")]
    public class X12_ID_1278
    {
    }

    /// <summary>
    /// Reference Identification Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,0A,0B,0C,0D,0E,0F,0G,0H,0I,0J,0M,10,11,12,13,14,15,16" +
        ",17,18,19,1A,1B,1C,1D,1E,1F,1G,1H,1I,1J,1K,1L,1M,1N,1O,1P,1Q,1R,1S,1T,1U,1V,1W,1" +
        "Y,1Z,20,21,22,23,24,25,26,27,28,29,2A,2B,2C,2D,2E,2F,2G,2H,2I,2J,2K,2L,2M,2N,2O," +
        "2P,2Q,2R,2S,2T,2U,2V,2W,2X,2Y,2Z,30,31,32,33,34,35,36,37,38,39,3A,3B,3C,3D,3E,3F" +
        ",3G,3H,3I,3J,3K,3L,3M,3N,3O,3P,3Q,3R,3S,3T,3U,3V,3W,3X,3Y,3Z,40,41,42,43,44,45,4" +
        "6,47,48,49,4A,4B,4C,4D,4E,4F,4G,4H,4I,4J,4K,4L,4M,4N,4O,4P,4Q,4R,4S,4T,4U,4V,4W," +
        "4X,4Y,4Z,50,51,52,53,54,55,56,57,58,59,5A,5C,5F,5G,5H,5I,5J,5K,5M,5N,5O,5P,5Q,5R" +
        ",5S,5V,5W,5X,5Y,5Z,60,65,66,67,68,69,6A,6B,6C,6D,6E,6F,6G,6H,6I,6J,6K,6L,6M,6N,6" +
        "O,6P,6Q,6R,6S,6T,6U,6V,6W,6X,6Z,70,71,72,73,74,75,76,77,78,79,7A,7B,7C,7K,7L,7M," +
        "7P,7Q,7R,7S,7U,80,81,82,83,84,85,86,87,88,89,8A,8B,8C,8D,8E,8F,8G,8H,8I,8J,8K,8L" +
        ",8M,8N,8O,8P,8Q,8R,8S,8T,8U,8Z,90,91,92,93,94,95,96,97,98,99,9A,9B,9C,9D,9E,9F,9" +
        "G,9H,9I,9J,9V,9W,9X,A0,A1,A2,A3,A4,A5,A6,A7,A8,A9,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ," +
        "AK,AL,ALC,ALG,ALH,ALI,ALJ,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,AX,AY,AZ,B1,B2,B3,B4," +
        "B5,B6,B7,B8,B9,BA,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BO,BP,BQ,BR,BS,BT,BU,BV" +
        ",BW,BX,BY,BZ,C0,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,C" +
        "M,CMN,CN,CO,CP,CPT,CQ,CR,CS,CT,CU,CV,CW,CX,CY,CZ,D0,D1,D2,D3,D4,D5,D6,D7,D8,D9,D" +
        "A,DB,DC,DD,DE,DF,DG,DH,DI,DJ,DK,DL,DM,DN,DNR,DO,DP,DQ,DR,DS,DT,DU,DV,DW,DX,DY,DZ" +
        ",E1,E2,E3,E4,E5,E6,E7,E8,E9,EA,EB,EC,ED,EF,EG,EH,EI,EJ,EK,EL,EM,EN,END,EO,EP,EQ," +
        "ER,ES,ET,EU,EV,EW,EX,EY,EZ,F1,F2,F3,F4,F5,F6,F7,F8,F9,FA,FB,FC,FD,FE,FF,FG,FH,FI" +
        ",FJ,FK,FL,FM,FN,FO,FP,FQ,FR,FS,FT,FU,FV,FW,FX,FY,FZ,G1,G2,G3,G4,G5,G6,G7,G8,G9,G" +
        "A,GB,GC,GD,GE,GF,GG,GH,GI,GJ,GK,GL,GM,GN,GO,GP,GQ,GR,GS,GT,GU,GV,GW,GX,GY,GZ,H1," +
        "H2,H3,H4,H5,H6,H7,H9,HA,HB,HC,HD,HE,HF,HI,HN,HO,HP,HR,HS,HT,HW,HX,HY,I1,I2,I3,I4" +
        ",I5,I7,I8,IA,IB,IC,ICD,ID,IE,IF,IG,IH,II,IJ,IK,IL,IM,IN,IO,IP,IQ,IR,IS,IT,IU,IV," +
        "IW,IX,IZ,J0,J1,J2,J3,J4,J5,J6,J7,J8,J9,JA,JB,JC,JD,JE,JH,JL,JS,JY,JZ,K0,K1,K2,K3" +
        ",K4,K5,K6,K7,K8,KA,KB,KC,KD,KE,KF,KG,KH,KI,KJ,KK,KL,KM,KN,KO,KP,KQ,KR,KS,KT,KU,K" +
        "V,KW,KX,KY,KZ,L1,L2,L3,L4,L5,L6,LA,LB,LC,LD,LE,LF,LG,LH,LI,LJ,LK,LL,LM,LN,LO,LP," +
        "LQ,LR,LS,LT,LU,LV,LW,LX,LY,LZ,M1,M2,M3,M4,M5,M6,M7,M8,M9,MA,MB,MC,MD,ME,MF,MG,MH" +
        ",MI,MJ,MK,ML,MM,MN,MO,MP,MQ,MR,MS,MT,MU,MV,MW,MX,MY,MZ,N0,N1,N2,N3,N4,N5,N6,N7,N" +
        "8,N9,NA,NB,NC,ND,NE,NF,NG,NH,NI,NJ,NK,NL,NM,NN,NO,NP,NQ,NR,NS,NU,NX,NY,NZ,O1,O2," +
        "O5,O7,O8,O9,OA,OB,OC,OD,OE,OF,OG,OH,OI,OJ,OK,OL,OM,ON,OP,OQ,OR,OS,OT,OW,OZ,P1,P2" +
        ",P3,P4,P5,P6,P7,P8,P9,PA,PB,PC,PD,PE,PF,PG,PH,PI,PID,PJ,PK,PL,PM,PN,PO,PP,PQ,PR," +
        "PS,PSI,PSL,PSM,PT,PU,PV,PW,PX,PY,PZ,Q1,Q2,Q3,Q4,Q5,Q6,Q7,Q8,Q9,QA,QB,QC,QD,QE,QF" +
        ",QG,QH,QI,QJ,QK,QL,QM,QN,QO,QP,QQ,QR,QS,QT,QU,QV,QW,QX,QY,QZ,R0,R1,R2,R3,R4,R5,R" +
        "6,R7,R8,R9,RA,RB,RC,RD,RE,RF,RG,RH,RI,RJ,RK,RL,RM,RN,RO,RP,RQ,RR,RS,RT,RU,RV,RW," +
        "RX,RY,RZ,S0,S1,S2,S3,S4,S5,S6,S7,S8,S9,SA,SB,SC,SD,SE,SF,SG,SH,SI,SJ,SK,SL,SM,SN" +
        ",SO,SP,SPL,SPN,SQ,SR,SS,ST,SU,SV,SW,SX,SY,SZ,T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,TA,TB" +
        ",TC,TD,TE,TF,TG,TH,TI,TJ,TK,TL,TM,TN,TO,TP,TQ,TR,TS,TT,TU,TV,TW,TX,TY,TZ,U0,U1,U" +
        "2,U3,U4,U7,U8,U9,UA,UB,UC,UD,UE,UF,UG,UH,UI,UJ,UK,UL,UM,UN,UO,UP,UQ,UR,US,UT,UU," +
        "UV,UY,V0,V1,V2,V3,V4,V5,V6,V8,V9,VA,VB,VC,VD,VE,VF,VG,VI,VJ,VK,VL,VN,VO,VP,VQ,VR" +
        ",VS,VT,VU,VV,VW,VX,VZ,W1,W2,W3,W4,W5,W6,W7,W8,W9,WA,WB,WC,WD,WE,WF,WG,WI,WJ,WK,W" +
        "L,WM,WN,WO,WP,WR,WS,WU,WY,X0,X1,X2,X3,X4,X5,X6,X7,X8,X9,XA,XB,XC,XD,XE,XF,XG,XH," +
        "XI,XJ,XK,XL,XM,XN,XO,XP,XR,XS,XT,XU,XV,XW,XX,XY,Y0,Y1,Y2,Y3,Y4,Y5,Y6,Y7,Y9,YA,YB" +
        ",YC,YD,YE,YF,YG,YH,YI,YJ,YK,YL,YM,YO,YP,YQ,YR,YS,YT,YU,YV,YW,Z1,Z2,Z3,Z4,Z5,Z6,Z" +
        "7,Z8,Z9,ZA,ZB,ZC,ZD,ZE,ZF,ZG,ZH,ZI,ZJ,ZK,ZL,ZM,ZN,ZO,ZP,ZQ,ZR,ZS,ZT,ZU,ZV,ZW,ZX," +
        "ZZ,")]
    public class X12_ID_128
    {
    }

    /// <summary>
    /// Direction Identifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,I,J,K,L,M,N,S,W,")]
    public class X12_ID_1280
    {
    }

    /// <summary>
    /// Returns Disposition Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CR,DI,KA,KR,MW,PA,RA,RD,RF,RN,RP,RT,SC,SD,")]
    public class X12_ID_1292
    {
    }

    /// <summary>
    /// Return Request Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BC,CO,CV,DA,DI,DM,DP,DR,DT,EI,EO,EW,LP,MD,NA,OP,PE,PF,PR,PS,PW,RE,SD,SM,SP,SR,ST" +
        ",TE,WG,")]
    public class X12_ID_1293
    {
    }

    /// <summary>
    /// Return Response Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",EW,FR,IN,IO,MI,NR,OS,PC,PR,QD,RR,RT,SR,UI,")]
    public class X12_ID_1294
    {
    }

    /// <summary>
    /// Participant Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,AN,AV,C,CD,D,DB,DN,DP,DR,DV,EL,GA,KP,N,PD,PF,R,RT,S,S1,S2,TD,TN,TR,TS,TV,US,")]
    public class X12_ID_1295
    {
    }

    /// <summary>
    /// Work Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CL,CO,RE,ST,VO,")]
    public class X12_ID_1297
    {
    }

    /// <summary>
    /// Service, Promotion, Allowance, or Charge Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A010,A020,A030,A040,A050,A060,A070,A080,A090,A100,A110,A120,A121,A122,A130,A140," +
        "A150,A160,A170,A180,A190,A200,A210,A220,A230,A240,A250,A260,A270,A280,A290,A300," +
        "A310,A320,A330,A340,A350,A360,A370,A380,A390,A400,A410,A420,A430,A440,A450,A460," +
        "A470,A480,A490,A500,A510,A520,A530,A540,A550,A560,A570,A580,A590,A600,A610,A620," +
        "A630,A640,A650,A660,A670,A680,A690,A691,A700,A710,A720,A721,A730,A740,A750,A760," +
        "A770,A780,A790,A800,A810,A820,A830,A840,A850,A860,A870,A880,A890,A900,A910,A920," +
        "A930,A940,A950,A960,A970,A980,A990,ADOW,ADRW,AFEE,B000,B010,B015,B020,B030,B040," +
        "B050,B060,B070,B080,B090,B091,B100,B110,B120,B130,B140,B150,B160,B170,B180,B190," +
        "B200,B210,B220,B230,B240,B250,B260,B270,B280,B290,B300,B310,B320,B330,B340,B350," +
        "B360,B370,B380,B390,B400,B500,B510,B520,B530,B540,B550,B551,B560,B570,B580,B581," +
        "B590,B600,B610,B620,B630,B650,B660,B670,B680,B690,B700,B710,B720,B730,B740,B750," +
        "B760,B770,B780,B785,B790,B791,B800,B810,B820,B830,B840,B850,B860,B870,B880,B881," +
        "B890,B900,B910,B911,B920,B930,B940,B950,B960,B970,B980,B990,BURD,C000,C010,C020," +
        "C030,C040,C050,C060,C070,C080,C090,C100,C110,C120,C130,C140,C150,C160,C170,C180," +
        "C190,C200,C210,C220,C230,C231,C240,C250,C260,C270,C280,C290,C300,C310,C320,C330," +
        "C340,C350,C360,C370,C380,C390,C400,C401,C402,C410,C420,C430,C440,C450,C460,C470," +
        "C480,C490,C500,C510,C520,C530,C531,C540,C550,C560,C570,C580,C590,C600,C610,C620," +
        "C630,C640,C650,C660,C670,C680,C690,C700,C710,C720,C730,C740,C750,C760,C770,C780," +
        "C790,C800,C810,C820,C830,C840,C850,C860,C870,C880,C890,C900,C910,C920,C930,C940," +
        "C950,C960,C970,C980,C990,COMM,D000,D010,D015,D020,D030,D040,D050,D060,D070,D080," +
        "D090,D100,D101,D110,D120,D130,D140,D141,D142,D143,D144,D150,D160,D170,D180,D190," +
        "D200,D210,D220,D230,D240,D250,D260,D270,D280,D290,D292,D300,D301,D310,D320,D330," +
        "D340,D350,D360,D370,D380,D390,D400,D410,D420,D430,D440,D450,D460,D470,D480,D490," +
        "D500,D501,D510,D520,D530,D540,D550,D560,D570,D580,D590,D600,D610,D620,D630,D640," +
        "D650,D660,D670,D680,D690,D700,D701,D710,D711,D720,D730,D740,D750,D760,D770,D780," +
        "D790,D800,D810,D820,D830,D840,D850,D860,D870,D880,D890,D900,D910,D920,D930,D940," +
        "D950,D960,D970,D980,D990,E000,E010,E020,E030,E040,E050,E060,E065,E070,E080,E090," +
        "E100,E110,E120,E130,E140,E150,E160,E170,E180,E190,E191,E192,E193,E200,E210,E220," +
        "E230,E240,E250,E260,E270,E280,E290,E300,E310,E320,E330,E340,E350,E360,E370,E380," +
        "E390,E400,E410,E420,E430,E440,E450,E460,E470,E480,E490,E500,E510,E520,E530,E540," +
        "E550,E560,E570,E580,E590,E600,E610,E620,E630,E640,E650,E660,E670,E680,E690,E700," +
        "E710,E720,E730,E740,E750,E760,E770,E780,E790,E800,E810,E820,E830,E840,E850,E860," +
        "E870,E880,E890,E900,E910,E920,E930,E940,E950,E960,E970,E980,E990,ENGA,F000,F010," +
        "F020,F030,F040,F050,F060,F061,F070,F080,F090,F100,F110,F120,F130,F140,F150,F155," +
        "F160,F170,F180,F190,F200,F210,F220,F230,F240,F250,F260,F270,F280,F290,F300,F310," +
        "F320,F330,F340,F350,F360,F370,F380,F390,F400,F401,F410,F420,F430,F440,F450,F460," +
        "F470,F480,F490,F500,F510,F520,F530,F540,F550,F560,F570,F580,F590,F600,F610,F620," +
        "F630,F640,F650,F660,F670,F680,F690,F700,F710,F720,F730,F740,F750,F760,F770,F780," +
        "F790,F800,F810,F820,F830,F840,F850,F860,F870,F880,F890,F900,F910,F920,F930,F940," +
        "F950,F960,F970,F980,F990,F991,G000,G010,G020,G030,G040,G050,G060,G070,G080,G090," +
        "G100,G110,G120,G130,G140,G150,G160,G170,G180,G190,G200,G210,G220,G230,G240,G250," +
        "G260,G270,G280,G290,G300,G310,G320,G330,G340,G350,G360,G370,G380,G390,G400,G410," +
        "G420,G430,G440,G450,G460,G470,G480,G490,G500,G510,G520,G530,G540,G550,G560,G570," +
        "G580,G590,G600,G610,G620,G630,G640,G650,G660,G670,G680,G690,G700,G710,G720,G730," +
        "G740,G750,G760,G770,G780,G790,G800,G810,G820,G821,G830,G840,G850,G860,G870,G880," +
        "G890,G900,G910,G920,G930,G940,G950,G960,G970,G980,G990,H000,H010,H020,H030,H040," +
        "H050,H060,H070,H080,H090,H100,H110,H120,H130,H140,H150,H151,H160,H170,H180,H190," +
        "H200,H210,H220,H230,H240,H250,H260,H270,H280,H290,H300,H310,H320,H330,H340,H350," +
        "H360,H370,H380,H390,H400,H410,H420,H430,H440,H450,H460,H470,H480,H490,H500,H510," +
        "H520,H530,H540,H550,H551,H560,H570,H580,H590,H600,H610,H620,H625,H630,H640,H650," +
        "H660,H670,H680,H690,H700,H710,H720,H730,H740,H750,H760,H770,H780,H790,H800,H806," +
        "H810,H820,H830,H840,H850,H860,H870,H880,H890,H900,H910,H920,H930,H935,H940,H950," +
        "H960,H970,H980,H990,I000,I010,I020,I030,I040,I050,I060,I070,I080,I090,I100,I110," +
        "I120,I130,I140,I150,I160,I170,I180,I190,I200,I210,I220,I230,I240,I250,I260,I270," +
        "I280,I290,I300,I310,I320,I330,I340,I350,I360,I370,I380,I390,I400,I410,I411,I420," +
        "I430,I431,I432,I440,I450,I460,I470,I480,I490,I495,I500,I510,I520,I530,I540,I550," +
        "I560,I570,I580,I590,I600,I610,I620,I630,I640,I650,I660,I670,I680,OFFA,OTHR,PTAX," +
        "ZZZZ,")]
    public class X12_ID_1300
    {
    }

    /// <summary>
    /// Use of Language Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,")]
    public class X12_ID_1303
    {
    }

    /// <summary>
    /// Mark Code Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,")]
    public class X12_ID_1304
    {
    }

    /// <summary>
    /// Loan Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34" +
        ",35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,59,6,61,6" +
        "2,63,64,65,66,67,7,8,9,")]
    public class X12_ID_1307
    {
    }

    /// <summary>
    /// Contract Action Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CO,KA,KB,KC,KD,KE,KF,KG,PE,RP,ZZ,")]
    public class X12_ID_1308
    {
    }

    /// <summary>
    /// Acquisition Data Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,K1,K2,K3,K4,K5,K6,KH,KI,KJ,KK,KL,KM,KN,KO,KP,KQ,KR,KS,KT,KU,KV,KW,KX,KY,KZ,L2,")]
    public class X12_ID_1309
    {
    }

    /// <summary>
    /// Financing Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,G,P,")]
    public class X12_ID_1310
    {
    }

    /// <summary>
    /// Calculation Operation Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,D,E,F,M,R,S,")]
    public class X12_ID_1311
    {
    }

    /// <summary>
    /// Test Period or Interval Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",TF,TI,TO,")]
    public class X12_ID_1312
    {
    }

    /// <summary>
    /// Ambulance Transport Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",I,R,T,X,")]
    public class X12_ID_1316
    {
    }

    /// <summary>
    /// Ambulance Transport Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,")]
    public class X12_ID_1317
    {
    }

    /// <summary>
    /// Basis of Cost Determination Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,3,4,5,6,7,8,9,")]
    public class X12_ID_1319
    {
    }

    /// <summary>
    /// Release Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,H,R,S,T,U,")]
    public class X12_ID_132
    {
    }

    /// <summary>
    /// Basis of Days Supply Determination Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,3,")]
    public class X12_ID_1320
    {
    }

    /// <summary>
    /// Condition Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,1A,1B,1C,1D,1E,1F,1G,1H,1I,1J,1K,1L,1M,1N,1O,1P,1Q,1R,1S,1T,1U,1V,1W,1X,1Y,1Z,20,21,22,23,24,25,26,27,28,29,2A,2B,2C,2D,2E,2F,2G,2H,2I,2J,2K,2L,2M,2N,2O,2P,2Q,2R,2S,2T,2U,2V,2W,2X,2Y,30,31,32,33,34,35,36,37,38,39,3A,3B,3C,3D,3F,3G,3H,3I,3J,3K,3L,3M,3N,3O,3P,3R,40,41,42,43,44,45,46,47,48,49,4A,50,51,52,53,54,55,56,57,58,59,5A,5B,5C,60,61,62,63,64,65,66,67,68,69,6A,6B,6C,6D,70,71,72,73,74,75,76,77,78,79,7A,80,81,82,83,84,85,86,87,88,89,8A,8B,8C,8D,8E,8G,8H,8I,90,91,92,93,94,95,96,97,98,99,9A,9B,9C,9D,9E,9F,9G,9H,9I,9J,9K,9L,9M,A3,A4,A5,A6,A7,A8,A9,AA,AB,AC,AD,AE,AF,AG,AH,AI,AL,AN,AO,AP,AR,AS,AT,AU,AV,AW,AX,B1,B2,B9,BA,BC,BE,BL,BP,BR,BT,C1,C2,C3,C4,C5,C6,C8,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CL,CM,CN,CO,CP,CR,CT,CU,CV,D1,D2,D3,D4,D5,D6,D7,DA,DB,DD,DE,DF,DH,DI,DM,DN,DO,DP,DQ,DT,DY,E6,E7,E8,EC,EL,EN,EO,EP,EX,FA,FB,FC,FD,FE,FF,FG,FH,FO,FR,G2,G3,G4,G5,G6,G7,G8,G9,GD,GM,GO,GR,H0,H1,H2,H3,H4,H5,H6,H7,H8,H9,HC,HL,HO,HS,I7,I8,IH,IN,IP,J1,J2,J3,J4,J5,J6,J7,J8,J9,LB,LC,LD,LE,LF,LG,LH,LI,LJ,LK,LT,MB,MC,ML,MS,NA,NC,NP,NR,NU,OL,OO,OR,OT,OV,P1,P2,PA,PB,PC,PD,PE,PF,PG,PM,PO,PP,PR,PS,PT,PV,PW,PY,Q1,Q2,Q3,Q4,Q5,Q6,Q7,Q8,Q9,QA,QB,QC,QD,QE,QF,QG,QH,QI,QJ,QK,QL,QM,QN,QO,QP,QQ,QR,QS,QT,R1,R2,R3,R4,R5,R6,R7,R8,R9,RA,RB,RC,RD,RE,RF,RG,RH,RI,RJ,RK,RL,RM,RO,RP,RQ,RR,RS,RT,RU,RY,RZ,S1,S3,S5,SB,SE,SG,SL,SM,SN,SO,SP,SQ,SR,ST,SU,SV,SW,SX,SY,SZ,TA,TB,TC,TD,TE,TP,TR,TV,UN,UT,V1,V2,V3,V4,V5,V6,V7,VI,WA,WB,WI,WO,WR,WT,WU,ZZ,")]
    public class X12_ID_1321
    {
    }

    /// <summary>
    /// Certification Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,A,B,C,I,R,S,")]
    public class X12_ID_1322
    {
    }

    /// <summary>
    /// Copay Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,3,")]
    public class X12_ID_1327
    {
    }

    /// <summary>
    /// Dispense as Written Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,3,4,5,6,7,8,9,")]
    public class X12_ID_1329
    {
    }

    /// <summary>
    /// Routing Sequence Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,B,D,H,I,JD,JO,M,O,R,S,V,X,Z,")]
    public class X12_ID_133
    {
    }

    /// <summary>
    /// Dosage Form Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,10,11,12,13,14,15,16,20,21,22,23,24,25,30,31,32,33,34,40,41" +
        ",42,43,50,51,52,53,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,8" +
        "0,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,")]
    public class X12_ID_1330
    {
    }

    /// <summary>
    /// Facility Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,")]
    public class X12_ID_1332
    {
    }

    /// <summary>
    /// Record Format Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,D,E,F,P,S,")]
    public class X12_ID_1333
    {
    }

    /// <summary>
    /// Insulin Dependent Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,N,")]
    public class X12_ID_1335
    {
    }

    /// <summary>
    /// Insurance Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",12,13,14,15,16,41,42,43,AP,C1,CO,CP,D,EP,FF,GP,HM,HN,HS,IN,IP,LC,LD,LI,LT,MA,MB," +
        "MC,MG,MH,MI,MP,OT,PE,PL,PP,PR,PS,QM,RP,SP,TF,WC,WU,")]
    public class X12_ID_1336
    {
    }

    /// <summary>
    /// Level of Care Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,")]
    public class X12_ID_1337
    {
    }

    /// <summary>
    /// Level of Service Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",00,01,02,03,04,05,06,09,10,11,F1,F2,I,L,NBC,R,U,")]
    public class X12_ID_1338
    {
    }

    /// <summary>
    /// Multiple Procedure Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,P,S,")]
    public class X12_ID_1340
    {
    }

    /// <summary>
    /// Nature of Condition Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,C,D,E,F,G,M,")]
    public class X12_ID_1342
    {
    }

    /// <summary>
    /// Non-Institutional Claim Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,AA,AM,AN,CF,CH,CS,DA,DD,DM,DN,ER,HH,HS,IF,IL,L,LT,MD,MF,MH,MI,MO,MS,NM,NP,NS,O" +
        ",OC,OP,OT,OX,P,PA,PD,PE,PF,PS,PT,RX,S,SC,SN,ST,T,TX,V,")]
    public class X12_ID_1343
    {
    }

    /// <summary>
    /// Non-Visit Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",L,N,O,")]
    public class X12_ID_1344
    {
    }

    /// <summary>
    /// Nursing Home Residential Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,")]
    public class X12_ID_1345
    {
    }

    /// <summary>
    /// Nutrient Administration Method Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",G,P,S,")]
    public class X12_ID_1346
    {
    }

    /// <summary>
    /// Nutrient Administration Technique Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",G,J,N,O,")]
    public class X12_ID_1347
    {
    }

    /// <summary>
    /// Oxygen Equipment Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,O,")]
    public class X12_ID_1348
    {
    }

    /// <summary>
    /// Oxygen Test Condition Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",E,N,O,R,S,W,X,")]
    public class X12_ID_1349
    {
    }

    /// <summary>
    /// Oxygen Test Findings Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class X12_ID_1350
    {
    }

    /// <summary>
    /// Patient Signature Source Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,C,M,P,S,")]
    public class X12_ID_1351
    {
    }

    /// <summary>
    /// Prescription Denial Override Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",00,01,02,03,04,05,06,07,")]
    public class X12_ID_1355
    {
    }

    /// <summary>
    /// Prescription Origin Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,3,")]
    public class X12_ID_1356
    {
    }

    /// <summary>
    /// Prior Authorization Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,3,4,5,6,7,")]
    public class X12_ID_1357
    {
    }

    /// <summary>
    /// Prosthesis, Crown or Inlay Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",I,R,")]
    public class X12_ID_1358
    {
    }

    /// <summary>
    /// Provider Accept Assignment Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,")]
    public class X12_ID_1359
    {
    }

    /// <summary>
    /// Provider Agreement Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",D,E,H,I,N,P,Y,")]
    public class X12_ID_1360
    {
    }

    /// <summary>
    /// Oral Cavity Designation Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",00,01,02,03,04,05,06,07,08,09,10,20,30,40,L,R,")]
    public class X12_ID_1361
    {
    }

    /// <summary>
    /// Related-Causes Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AP,EM,OA,ZZ,")]
    public class X12_ID_1362
    {
    }

    /// <summary>
    /// Release of Information Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,I,M,N,O,Y,")]
    public class X12_ID_1363
    {
    }

    /// <summary>
    /// Review Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,L,N,")]
    public class X12_ID_1364
    {
    }

    /// <summary>
    /// Service Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,10,11,12,13,14,15,16,17,18,19,2,20,21,3,30,31,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59,6,60,61,62,63,64,65,66,67,68,69,7,70,71,72,73,74,75,76,77,78,79,8,80,81,82,83,84,85,86,87,88,89,9,90,91,92,93,94,95,96,97,98,99,A0,A1,A2,A3,A4,A5,A6,A7,A8,A9,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,BA,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BP,BQ,BR,BS,")]
    public class X12_ID_1365
    {
    }

    /// <summary>
    /// Special Program Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,")]
    public class X12_ID_1366
    {
    }

    /// <summary>
    /// Subluxation Level Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C1,C2,C3,C4,C5,C6,C7,CO,IL,L1,L2,L3,L4,L5,OC,SA,T1,T10,T11,T12,T2,T3,T4,T5,T6,T7" +
        ",T8,T9,")]
    public class X12_ID_1367
    {
    }

    /// <summary>
    /// Tooth Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",E,I,M,")]
    public class X12_ID_1368
    {
    }

    /// <summary>
    /// Tooth Surface Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,D,F,I,L,M,O,")]
    public class X12_ID_1369
    {
    }

    /// <summary>
    /// Unit Dose Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,3,")]
    public class X12_ID_1370
    {
    }

    /// <summary>
    /// Measurement Method or Device
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BM,DM,FT,MM,OM,PT,TM,")]
    public class X12_ID_1373
    {
    }

    /// <summary>
    /// Payment Adjustment Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class X12_ID_1374
    {
    }

    /// <summary>
    /// Investor Reporting Action Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,1A,1B,1C,1D,1E,1F,1G,1H,1J,1K,")]
    public class X12_ID_1376
    {
    }

    /// <summary>
    /// Waybill Cross-Reference Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",W1,W2,W3,W4,W5,W6,W7,W8,W9,")]
    public class X12_ID_1378
    {
    }

    /// <summary>
    /// Loan Verification Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,10,11,12,13,14,15,16,17,18,19,2,20,21,3,4,5,6,7,8,9,")]
    public class X12_ID_1379
    {
    }

    /// <summary>
    /// Oxygen Delivery System Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,")]
    public class X12_ID_1382
    {
    }

    /// <summary>
    /// Claim Submission Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",00,01,02,03,05,07,08,09,15,16,17,18,20,22,27,28,29,PB,")]
    public class X12_ID_1383
    {
    }

    /// <summary>
    /// Patient Location Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,L,M,O,P,R,S,T,")]
    public class X12_ID_1384
    {
    }

    /// <summary>
    /// Rate Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,2,3,4,5,6,7,8,9,BA,CR,DA,PB,PF,")]
    public class X12_ID_1387
    {
    }

    /// <summary>
    /// Sales Terms Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CH,DD,LC,NC,OA,SD,ST,")]
    public class X12_ID_139
    {
    }

    /// <summary>
    /// Eligibility or Benefit Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,A,B,C,CB,D,E,F,G,H,I,J,K,L,M,MC,N,O,P,Q,R,S,T,U,V,W,X,Y,")]
    public class X12_ID_1390
    {
    }

    /// <summary>
    /// Media Type Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",MI,NE,RD,TV,")]
    public class X12_ID_1393
    {
    }

    /// <summary>
    /// Configuration Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,B,C,S,")]
    public class X12_ID_1395
    {
    }

    /// <summary>
    /// Equipment Use Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,G,R,")]
    public class X12_ID_1396
    {
    }

    /// <summary>
    /// Inquiry Selection Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class X12_ID_1398
    {
    }

    /// <summary>
    /// Proposal Data Detail Identifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,")]
    public class X12_ID_1401
    {
    }

    /// <summary>
    /// Equipment Attribute Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",ATM,C02,CLE,DHT,DWI,FAP,GEN,LIN,MCP,MOI,N2,NDO,NOI,ODF,PCO,PRE,PSE,RAD,RUS,SLI,S" +
        "MO,STE,SUB,SUR,TBT,TEC,VOD,VOS,YEA,")]
    public class X12_ID_1402
    {
    }

    /// <summary>
    /// Implant Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class X12_ID_1403
    {
    }

    /// <summary>
    /// Implant Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class X12_ID_1404
    {
    }

    /// <summary>
    /// Usage Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,P,R,")]
    public class X12_ID_1413
    {
    }

    /// <summary>
    /// Title Insurance Services Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AP,CL,CP,ES,MP,PP,SE,SP,SV,TC,TD,TI,TP,ZZ,")]
    public class X12_ID_1420
    {
    }

    /// <summary>
    /// Damage Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",NW,PE,RP,UK,ZZ,")]
    public class X12_ID_1422
    {
    }

    /// <summary>
    /// License Plate Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AM,AP,AQ,AR,AT,BU,CC,CI,CO,CU,DA,DB,DD,DL,DP,DU,DV,DX,EX,FD,FG,FM,IP,IT,JJ,LE,LF" +
        ",LS,MC,MD,MF,ML,MP,MV,NG,OB,OL,PC,PE,PH,PX,RE,RI,RP,RV,S1,SC,SN,ST,SV,TK,TL,TM,T" +
        "P,TR,TX,US,UV,VF,VN,")]
    public class X12_ID_1423
    {
    }

    /// <summary>
    /// Recovery Classification Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,")]
    public class X12_ID_1425
    {
    }

    /// <summary>
    /// Recovery Condition Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,2,3,4,5,6,7,8,9,A,B,C,D,E,F,Z,")]
    public class X12_ID_1426
    {
    }

    /// <summary>
    /// Master In-bond Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,P,")]
    public class X12_ID_1428
    {
    }

    /// <summary>
    /// Construction Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,F,S,")]
    public class X12_ID_1429
    {
    }

    /// <summary>
    /// Transaction Set Identifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",104,110,120,121,124,125,126,127,128,129,130,131,135,139,140,141,142,143,144,146,147,148,149,150,151,152,154,159,161,163,170,175,176,180,185,186,188,189,190,191,194,195,196,197,199,200,201,203,204,206,210,213,214,217,218,242,250,251,255,256,260,261,262,263,264,265,266,270,271,272,273,275,276,277,278,288,290,300,301,303,304,306,309,310,311,312,313,315,317,319,321,322,323,324,325,326,350,352,353,354,355,356,357,358,361,362,404,410,411,414,417,418,419,420,421,422,423,425,426,429,431,432,433,435,436,440,451,452,453,455,456,466,468,475,485,490,492,494,501,503,504,511,517,527,536,561,567,568,601,602,622,715,805,806,810,811,812,813,815,816,818,819,820,821,822,823,824,826,827,828,829,830,831,832,833,834,835,836,837,838,839,840,841,842,843,844,845,846,847,848,849,850,851,852,853,854,855,856,857,858,859,860,861,862,863,864,865,866,867,868,869,870,871,872,875,876,877,878,879,880,881,882,883,884,885,886,887,888,889,891,893,894,895,896,920,924,925,926,928,940,943,944,945,947,980,990,994,996,997,998,")]
    public class X12_ID_143
    {
    }

    /// <summary>
    /// Preference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,D,N,O,")]
    public class X12_ID_1431
    {
    }

    /// <summary>
    /// Shipment Method of Payment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",11,BP,CA,CC,CD,CF,DE,DF,FO,HP,MX,NC,NR,PA,PB,PC,PD,PE,PL,PO,PP,PS,PU,RC,RF,RS,TP" +
        ",WC,")]
    public class X12_ID_146
    {
    }

    /// <summary>
    /// Proximity Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AB,BL,BO,EO,FO,IN,LO,NE,NL,NO,NW,RO,SE,SO,SW,WO,ZZ,")]
    public class X12_ID_1465
    {
    }

    /// <summary>
    /// Location Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AL,AT,LL,PL,RC,RL,TT,VL,WL,ZZ,")]
    public class X12_ID_1466
    {
    }

    /// <summary>
    /// Reason Stopped Work Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",10,11,12,13,14,15,16,17,18,19,")]
    public class X12_ID_1468
    {
    }

    /// <summary>
    /// Affected Area or Section Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,")]
    public class X12_ID_1469
    {
    }

    /// <summary>
    /// Shipment Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,")]
    public class X12_ID_147
    {
    }

    /// <summary>
    /// Pricing Methodology
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",00,01,02,03,04,05,06,07,08,09,10,11,12,13,14,")]
    public class X12_ID_1473
    {
    }

    /// <summary>
    /// Language Proficiency Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,A,B,C,D,E,")]
    public class X12_ID_1476
    {
    }

    /// <summary>
    /// Problem Log Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",ES,MC,ME,MP,PE,RP,SH,SP,TC,TD,")]
    public class X12_ID_1484
    {
    }

    /// <summary>
    /// Service Commitment Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,R,")]
    public class X12_ID_1485
    {
    }

    /// <summary>
    /// Retrip Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BO,CU,DE,ET,HL,HR,HW,ID,MS,MV,OK,OP,RR,SI,SK,SL,SO,TA,TC,TD,TM,TR,WA,WC,WD,WE,WI" +
        ",WT,")]
    public class X12_ID_1487
    {
    }

    /// <summary>
    /// Bad Order Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,")]
    public class X12_ID_1488
    {
    }

    /// <summary>
    /// Hold Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CC,CW,DE,EM,HI,LI,MI,MS,NB,OC,OI,WG,")]
    public class X12_ID_1489
    {
    }

    /// <summary>
    /// Parameter Trace Registration Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class X12_ID_1491
    {
    }

    /// <summary>
    /// Parameter Trace Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,3,4,6,8,A,B,C,P,")]
    public class X12_ID_1492
    {
    }

    /// <summary>
    /// Output Event Selection Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,C,E,F,G,H,L,P,")]
    public class X12_ID_1493
    {
    }

    /// <summary>
    /// Query Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",I,N,V,")]
    public class X12_ID_1495
    {
    }

    /// <summary>
    /// Property Description Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,")]
    public class X12_ID_1496
    {
    }

    /// <summary>
    /// Rate Application Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",DE,OR,")]
    public class X12_ID_1499
    {
    }

    /// <summary>
    /// Special Charge or Allowance Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",003,005,010,015,020,025,026,027,028,029,030,031,032,035,040,045,050,055,060,065," +
        "070,075,080,085,090,095,100,105,110,115,120,135,140,145,150,155,160,165,170,175," +
        "180,185,186,190,205,210,215,220,225,230,235,240,245,250,255,260,265,270,275,280," +
        "285,290,295,297,300,310,315,320,325,335,340,345,350,355,360,365,370,375,380,385," +
        "390,392,393,395,400,405,410,415,416,420,425,426,430,435,440,445,450,455,460,462," +
        "465,470,475,480,485,490,495,500,505,510,515,520,525,535,540,545,550,555,560,565," +
        "570,580,585,586,590,593,595,600,605,610,615,620,625,635,640,641,645,650,665,670," +
        "675,680,685,690,695,696,697,700,705,706,720,725,730,731,732,735,736,740,745,750," +
        "760,761,762,999,AAA,AAJ,AAM,AAN,AAO,AAS,AAT,ABC,ABL,ACD,ACF,ACH,ACL,ACS,ADH,ADL," +
        "ADV,AFB,AFC,AGS,AIB,AIC,AIR,ALC,ALP,AMB,AMC,AMP,ANB,ANC,ANS,APL,APT,ARB,ARC,ARG," +
        "ARR,ASC,AUX,AVA,BAA,BAB,BAC,BAD,BAF,BAP,BAS,BBK,BDX,BEY,BFD,BKA,BLA,BLC,BLD,BLK," +
        "BLW,BND,BOB,BOP,BRA,BRD,BSC,BSS,BUR,BYD,CAA,CAC,CAD,CAE,CAF,CAG,CAH,CAJ,CAK,CAL," +
        "CAO,CAP,CAQ,CAR,CAS,CAV,CAW,CAZ,CBL,CBO,CBP,CBR,CBW,CBX,CCA,CCH,CCP,CCR,CCS,CDA," +
        "CDD,CDF,CDR,CER,CGC,CGL,CGR,CHG,CHN,CIR,CIS,CLC,CLN,CLS,CMC,CMF,CMI,CMP,CNS,CNV," +
        "COA,COC,COD,COF,COL,COM,CON,COR,COU,CPA,CPC,CPE,CPP,CRA,CRF,CRP,CRR,CRS,CSA,CSC," +
        "CSE,CSF,CSP,CSR,CST,CTA,CTC,CTE,CTF,CTG,CTL,CTX,CUA,CUD,CUF,CUP,CUS,DAA,DAB,DAC," +
        "DAD,DAM,DBD,DBL,DBP,DCS,DCT,DDA,DDC,DDD,DDF,DDN,DDP,DDS,DEA,DED,DEL,DEM,DEP,DER," +
        "DES,DET,DEV,DEW,DFM,DFS,DFW,DGS,DIC,DIR,DIS,DIV,DLH,DLP,DMC,DMD,DNA,DOC,DON,DPB," +
        "DPL,DPR,DPT,DPU,DRC,DRP,DRV,DRY,DSC,DSF,DSM,DSR,DST,DTA,DTB,DTC,DTD,DTF,DTL,DTP," +
        "DTU,DTV,DWC,DWP,EAC,EAX,EBD,EBP,ECC,ECR,EDD,EDO,EEA,EEB,EEC,EEF,EEG,EEH,EEP,EEX," +
        "EIC,ELS,EMR,EMS,EMT,ENC,ENS,EPC,EPS,ERS,ERT,ESA,ESC,ESD,ESE,ETR,EUC,EVC,EXC,EXL," +
        "EXM,EXP,EXS,EXW,EXZ,FAB,FAC,FAD,FAE,FAF,FAG,FAH,FBD,FCB,FCD,FCI,FCS,FDL,FDS,FFC," +
        "FFI,FFL,FFN,FFP,FFR,FFS,FIR,FLT,FMR,FMS,FRC,FTC,FTR,FUE,FWA,FWC,FXE,GAR,GDR,GGA," +
        "GGF,GKT,GOC,GPD,GRD,GRS,GSP,GSS,GST,HAN,HAZ,HBD,HDF,HDG,HDH,HDW,HET,HFA,HHA,HHB," +
        "HHG,HIC,HLF,HOC,HOL,HOS,HOX,HRS,HSC,HUL,HZC,HZS,IAA,IAB,IAC,ICE,IDL,IDP,IFC,IHT," +
        "IIA,IIH,IIP,IIU,ILD,ILF,ILP,IMP,INC,INP,INR,INS,INT,IPC,IPU,IRA,ISD,ITC,ITS,JST," +
        "KIT,LAA,LAB,LAC,LAD,LAE,LAL,LAT,LAY,LBR,LCG,LCR,LDA,LDG,LDL,LDS,LFT,LGD,LHS,LID," +
        "LLC,LLD,LLF,LLS,LMC,LNT,LOA,LOC,LPC,LPF,LSC,LSH,LSS,LTC,LUB,LUP,LUS,LYC,MAA,MAB," +
        "MAC,MAD,MAE,MAR,MCC,MDG,MDM,MEA,MEN,MES,MET,MFC,MFG,MGA,MGC,MIC,MIL,MIN,MKU,MLB," +
        "MLS,MMC,MMF,MMS,MMT,MNC,MNS,MPC,MRK,MRP,MSC,MSG,MTR,MUS,MVR,MVS,MVT,NAA,NAB,NAL," +
        "NCH,NDS,NFY,NHB,NSD,NWD,NYD,NYP,OAA,OAB,OAC,OCH,ODF,OFR,OFU,ONC,OOC,OOF,OPC,ORC," +
        "ORM,OSC,OSO,OSS,OUT,OVR,PAA,PAC,PAD,PAE,PAF,PAG,PAH,PAI,PAJ,PAK,PAL,PAR,PAT,PAV," +
        "PBA,PBE,PBL,PCH,PCT,PDB,PDC,PDS,PDY,PEC,PEN,PER,PFA,PHC,PHG,PIR,PLC,PLT,PMC,PMR," +
        "PMS,PMT,PMU,PMX,PNA,POC,POD,POL,POS,PPC,PPD,PPH,PPI,PPM,PPN,PPO,PPR,PPS,PPT,PPU," +
        "PRB,PRC,PRE,PRK,PRL,PRM,PRP,PRV,PSC,PSD,PSG,PSH,PSS,PST,PTC,PTS,PUC,PUD,PUK,PWH," +
        "PWT,PYS,QAA,QQD,RAA,RAB,RAC,RAD,RAE,RAF,RAG,RAH,RAI,RAJ,RAK,RAL,RAM,RCA,RCB,RCC," +
        "RCD,RCE,RCG,RCL,RCP,RCS,RDC,RDF,REC,REE,REF,REG,REL,REP,REQ,RES,RET,RFD,RGA,RGC," +
        "RHM,RID,RIE,RLA,RLC,RLQ,RLS,RMB,RMD,RMS,ROC,RPC,RRC,RRD,RRF,RRN,RRP,RRR,RSM,RSP," +
        "RSS,RSV,RTC,SAA,SAB,SAC,SAD,SAE,SAF,SAG,SAH,SAI,SAJ,SAK,SAM,SAN,SAP,SAT,SBC,SBL," +
        "SCC,SCD,SCG,SCL,SCU,SDC,SDL,SDS,SEC,SEE,SEG,SEL,SEQ,SER,SEV,SFC,SFT,SGL,SHL,SHS," +
        "SKT,SLC,SLP,SMS,SNS,SNT,SOC,SOP,SPA,SPB,SPC,SPD,SPL,SPP,SPS,SPT,SPU,SRG,SRS,SSA," +
        "SSB,SSC,SSF,SSL,SSO,SSP,SSS,SST,SSX,STA,STC,STF,STL,STM,STP,STR,STW,SUC,SUF,SUP," +
        "SUR,SVA,SVL,SVS,SWC,TAA,TAB,TAC,TAD,TAE,TAF,TAG,TAH,TAI,TAJ,TAK,TAL,TAX,TAY,TCB," +
        "TCM,TDT,TER,TLC,TMS,TMV,TOA,TOC,TPC,TPS,TRA,TRC,TRE,TRF,TRM,TRN,TRP,TRS,TRU,TSC," +
        "TSS,TST,TTA,TTB,TTD,TTL,TTM,TTP,TTR,TTS,TTT,TTU,TTV,TUR,TWO,UFC,UND,UNL,UPD,UPK," +
        "URC,USF,USV,USW,UTL,UTP,UUC,UUM,UUT,VAA,VAB,VCR,VEX,VFN,VIS,VIT,VOR,VSO,VTS,VVL," +
        "VVP,WAR,WAT,WDS,WEA,WFH,WHC,WRC,WRE,WSA,WTG,WTM,WTV,WWC,Z01,Z02,Z03,Z04,Z05,Z06," +
        "Z07,Z08,Z09,Z10,Z11,Z12,Z13,Z14,Z15,Z16,Z17,Z18,Z19,Z20,Z21,Z22,Z23,Z24,Z25,Z26," +
        "Z27,Z28,Z29,Z30,Z31,Z32,Z33,Z34,Z35,ZFF,ZZZ,")]
    public class X12_ID_150
    {
    }

    /// <summary>
    /// Type of Deduction
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CS,")]
    public class X12_ID_1511
    {
    }

    /// <summary>
    /// Delay Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,15,16,17,2,3,4,5,6,7,8,9,")]
    public class X12_ID_1514
    {
    }

    /// <summary>
    /// Special Handling Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",045,15,25,35,45,520,675,A1M,A3M,A5M,AAS,AB,ADL,AFN,AGG,AGS,AIB,AK,ALT,AMM,ANC,AP" +
        "D,APL,ARC,ARG,ARR,ART,ASY,AT,AUX,AV,AW,BA,BCP,BKA,BL,BLS,BN,BNS,BOX,BW,CAR,CC,CC" +
        "B,CCH,CCS,CD,CDD,CE,CF,CGC,CGR,CH,CHN,CI,CLS,CM,CMD,CNL,CNS,CO,CON,COR,COU,COV,C" +
        "PC,CPM,CR,CSD,CSP,CTM,CW,CX,CY,DA,DBL,DBP,DCS,DDN,DDP,DDS,DE,DEL,DFM,DFS,DIS,DLP" +
        ",DLR,DM,DN,DNC,DNF,DNT,DOC,DPB,DPL,DPT,DPU,DR,DRO,DRU,DS,DSK,DSM,DSR,DST,DSV,DT," +
        "DTP,DTV,DU,DV,DW,DWP,EAX,ECR,ED,EDD,EDO,EE,EED,EL,ELS,EMR,EMT,END,EP,ER,ERS,ERT," +
        "EV,EW,EX,EXC,EXD,EXO,EXP,EXQ,EXT,EXU,EXZ,EZE,FA,FAS,FB,FC,FCS,FD,FFC,FFS,FG,FL,F" +
        "P,FPT,FR,FRZ,FS,FST,FTR,GI,GOC,GSP,GSS,HAN,HBR,HDH,HDW,HE,HEA,HES,HET,HH,HHB,HM," +
        "HO,HOR,HP,HQT,HR,HRS,HT,HTI,HV,HW,HZC,IB,IC,ID,IIH,IM,IMP,INT,IP,IR,IS,ITS,JIT,J" +
        "LX,JS,KEG,KMD,LAB,LAY,LB,LBL,LBR,LBT,LC,LD,LF,LHS,LN,LP,LR,LS,LT,LTT,LYC,MC,MEN," +
        "MES,MET,MEX,MF,MIN,MOT,MP,MR,MRF,MSS,MTE,MVS,NC,ND,NE,NH,NHC,NHL,NP,NPR,NS,NSV,N" +
        "T,NW,NX,OAH,OBL,OCA,OCL,OCS,OCV,ODI,OEH,OFH,OFU,OHC,OIL,ONC,ONS,OOB,OOD,OOL,OPR," +
        "OPT,OS,OSB,OST,OTC,OTD,OTH,OTO,OTS,OUC,OUW,OVR,OWR,PAV,PB,PD,PDS,PDY,PER,PFH,PG," +
        "PHR,PI,PIR,PMM,PMR,PMS,PMT,POC,PPD,PRL,PS,PSG,PSS,PTS,PUC,PUD,PUK,PUP,PW,PYS,RA," +
        "RB,RC,RCC,RCL,RDR,RIE,RLS,RM,RMS,RO,RR,RRR,RS,RSP,RSS,RSV,RT,RWR,SB,SC,SCC,SCL,S" +
        "D,SDL,SDS,SE,SEC,SEE,SER,SEV,SF,SFT,SGL,SH,SHL,SI,SK,SKT,SLC,SM,SMP,SMS,SNM,SNT," +
        "SOC,SOL,SP,SPC,SPR,SPT,SPU,SR,SRG,SRS,SSN,ST,STA,STR,SUP,SVS,SW,TA,TC,TDC,TDP,TF" +
        ",TLS,TMS,TN,TOF,TPS,TRA,TRK,TRL,TRM,TRN,TRP,TRS,TRT,TS,TSC,TSP,TSS,TT,TV,UB,UFC," +
        "UI,UN,UP,UPK,URC,US,UTL,VAC,VAN,VN,VSO,VT,VTS,WB,WD,WDS,WE,WH,WI,WM,WO,WTV,WW,XP" +
        ",XT,ZZZ,")]
    public class X12_ID_152
    {
    }

    /// <summary>
    /// Display Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,")]
    public class X12_ID_1520
    {
    }

    /// <summary>
    /// Marketing Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,")]
    public class X12_ID_1521
    {
    }

    /// <summary>
    /// Coupon Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,AD,AE,AF,BA,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BO,BP,BQ,BR,BS,")]
    public class X12_ID_1522
    {
    }

    /// <summary>
    /// Labor Activity Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,AD,AE,AF,AG,AH,")]
    public class X12_ID_1523
    {
    }

    /// <summary>
    /// Request Category Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AR,BA,HS,IN,PR,RE,SC,")]
    public class X12_ID_1525
    {
    }

    /// <summary>
    /// Policy Compliance Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,")]
    public class X12_ID_1526
    {
    }

    /// <summary>
    /// Exception Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,")]
    public class X12_ID_1527
    {
    }

    /// <summary>
    /// Net Cost Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,")]
    public class X12_ID_1540
    {
    }

    /// <summary>
    /// Preferential Duty Criteria Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,")]
    public class X12_ID_1546
    {
    }

    /// <summary>
    /// Index Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,")]
    public class X12_ID_1550
    {
    }

    /// <summary>
    /// Academic Summary Source
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,")]
    public class X12_ID_1558
    {
    }

    /// <summary>
    /// Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,2,3,4,A,A1,A2,A3,A4,AA,AC,AD,AE,AF,AG,AH,AI,AJ,AL,AM,AN,AO,AP,AR,AV,AW,B,BA,BC,BD,BE,BF,BR,C,C1,C2,CA,CB,CC,CD,CO,CR,CS,CT,CU,CV,D,DA,DC,DN,DP,DR,DS,DT,E,EA,EE,ER,F,FP,FT,G,GO,H,HA,HB,HC,HD,HE,HF,HG,HH,HI,HR,I,IB,IR,J,K,L,MT,N,ND,NF,NH,NO,NP,NR,NS,NT,O,OA,OB,OF,OH,ON,P,PA,PB,PC,PD,PE,PF,PG,PH,PI,PJ,PK,PL,PM,PN,PO,PP,PQ,PR,PS,PT,PU,PV,PW,PX,R,RA,RB,RC,RD,RI,RL,S,SA,SB,SC,SD,SI,SN,T,TM,U,UA,UB,UC,UD,UE,UP,UR,UV,V,VA,VD,W,WE,WH,WR,X,X1,X2,X3,X4,X5,X6,X7,X8,X9,XA,XB,Y,Z,ZZ,")]
    public class X12_ID_157
    {
    }

    /// <summary>
    /// Filter ID Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",ASB,ASC,HDC,R64,UUE,ZZZ,")]
    public class X12_ID_1570
    {
    }

    /// <summary>
    /// Inspected/Weighed Indicator Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",IB,II,IW,")]
    public class X12_ID_1576
    {
    }

    /// <summary>
    /// Hazardous Material Regulations Exception Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class X12_ID_1577
    {
    }

    /// <summary>
    /// Export Exception Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CN,DP,GS,HH,HR,MS,PP,UP,UR,")]
    public class X12_ID_1578
    {
    }

    /// <summary>
    /// Charge Method of Payment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,P,")]
    public class X12_ID_16
    {
    }

    /// <summary>
    /// Status Report Request Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,P,R,S,")]
    public class X12_ID_160
    {
    }

    /// <summary>
    /// Stop Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AL,CL,CN,CU,DR,HT,IN,LD,LE,PL,PU,RT,SL,SU,TL,UL,WL,")]
    public class X12_ID_163
    {
    }

    /// <summary>
    /// Time Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,3,4,5,6,7,8,9,A,B,C,CB,CE,D,E,ED,EP,F,G,H,I,J,K,L,LD,LP,M,N,O,P,Q,R,S,T,U," +
        "V,W,X,Y,Z,")]
    public class X12_ID_176
    {
    }

    /// <summary>
    /// Quantity or Status Adjustment Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,03,04,05,06,07,51,52,53,54,55,56,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AN,AP,AR" +
        ",AS,AT,AU,AV,AW,AX,AY,BA,BD,BK,BM,BN,BR,BS,BT,CD,CO,CR,CS,PC,TC,UD,")]
    public class X12_ID_181
    {
    }

    /// <summary>
    /// Volume Unit Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,C,D,E,F,G,H,L,M,N,R,S,T,U,V,X,")]
    public class X12_ID_184
    {
    }

    /// <summary>
    /// Weight Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,A1,A2,A3,B,C,CD,D,DR,E,F,G,H,I,J,K,L,M,N,ND,NI,NR,NT,O,P,PA,Q,R,RG,RN,RT,S,SI," +
        "SK,SO,T,U,V,W,WA,WB,WG,WJ,X,Y,Z,")]
    public class X12_ID_187
    {
    }

    /// <summary>
    /// Weight Unit Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",E,K,L,M,O,S,T,")]
    public class X12_ID_188
    {
    }

    /// <summary>
    /// Accomplish Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,P,")]
    public class X12_ID_190
    {
    }

    /// <summary>
    /// Agent/Shipper Routing Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,R,S,")]
    public class X12_ID_192
    {
    }

    /// <summary>
    /// Capacity Load Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,F,G,M,T,V,")]
    public class X12_ID_195
    {
    }

    /// <summary>
    /// Mortgagee Information Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AH,AS,BH,BS,NC,NH,NS,")]
    public class X12_ID_197
    {
    }

    /// <summary>
    /// Confidential Billing Request Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,M,N,R,")]
    public class X12_ID_199
    {
    }

    /// <summary>
    /// Business Transaction Status
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BNR,DCP,DNP,DPP,FCP,FNP,FPP,LGR,OBR,TCR,TNR,TPR,")]
    public class X12_ID_201
    {
    }

    /// <summary>
    /// Correction Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AD,AI,AR,B1,BA,BD,BE,BO,CA,CM,CO,CS,CT,CU,D1,DC,DE,DS,EM,MB,MD,MR,NC,ND,PD,RB,RC" +
        ",RD,RE,RL,SC,SP,TL,WC,")]
    public class X12_ID_202
    {
    }

    /// <summary>
    /// Hazardous Material Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",4,6,9,A,C,D,E,F,I,R,T,U,X,")]
    public class X12_ID_208
    {
    }

    /// <summary>
    /// International/Domestic Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",D,I,")]
    public class X12_ID_210
    {
    }

    /// <summary>
    /// Packaging Form Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",AMM,BAG,BAL,BBL,BDL,BEM,BIC,BIN,BKG,BLK,BOB,BOT,BOX,BRG,BSK,BXI,BXT,CAB,CAG,CAN,CAR,CAS,CBC,CBY,CCS,CHE,CHS,CLD,CNT,COL,CON,COR,CRD,CRT,CSK,CTN,CUB,CYL,DBK,DRK,DRM,DSK,DTB,ENV,FIR,FLO,FLX,FRM,FSK,FWR,GOH,HED,HGH,HPT,HRB,HRK,HTB,JAR,JUG,KEG,KIT,KRK,KTB,LBK,LIF,LOG,LSE,LUG,LVN,MRP,NOL,OVW,PAL,PCK,PCS,PIR,PKG,PLF,PLN,PLT,POV,PRK,QTR,RAL,RCK,REL,ROL,RVR,SAK,SBC,SHK,SID,SKD,SKE,SLP,SLV,SPI,SPL,TBE,TBN,TKR,TKT,TLD,TNK,TRC,TRI,TRK,TRY,TSS,TTC,TUB,UNP,UNT,VEH,VPK,WHE,WLC,WRP,")]
    public class X12_ID_211
    {
    }

    /// <summary>
    /// Waybill Request Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,E,P,")]
    public class X12_ID_214
    {
    }

    /// <summary>
    /// Metric Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",M,")]
    public class X12_ID_216
    {
    }

    /// <summary>
    /// Billed/Rated-as Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AR,BA,BX,CC,CF,CM,DK,DM,DR,EA,FR,FT,GC,GL,KG,LB,LC,LH,LR,MR,MT,MV,NB,NC,ND,NG,NL" +
        ",NN,NP,NR,NT,NU,NV,OR,PK,PR,RV,SP,ST,SY,TD,TH,TN,TR,VA,VC,VM,")]
    public class X12_ID_221
    {
    }

    /// <summary>
    /// Section Seven Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,S,")]
    public class X12_ID_226
    {
    }

    /// <summary>
    /// Commodity Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",2,A,B,C,D,E,F,G,H,I,J,K,L,N,P,Q,S,T,U,V,Z,")]
    public class X12_ID_23
    {
    }

    /// <summary>
    /// Cross Reference Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,F,G,H,K,L,M,N,R,S,T,X,")]
    public class X12_ID_231
    {
    }

    /// <summary>
    /// Product/Service ID Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",A1,A2,A3,A4,A6,A7,A8,A9,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AW,AX,AY,AZ,B1,B2,B3,B4,B5,B6,B7,B8,BA,BB,BC,BD,BE,BF,BG,BH,BK,BL,BM,BN,BO,BP,BS,BT,BU,BV,BX,C1,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CQ,CR,CS,CT,CU,CV,CW,CX,CY,DE,DG,DI,DL,DN,DP,DR,DX,DZ,EA,EC,ED,EF,EI,EL,EM,EN,EP,EQ,ES,EX,F1,F2,F3,F4,F5,F6,F7,F8,F9,FA,FB,FC,FE,FF,FI,FL,FM,FN,FP,FS,FT,FW,GA,GC,GD,GK,GN,GR,GS,GU,HC,HD,HI,HN,IA,IB,IC,ID,IM,IN,IP,IS,IT,IW,IZ,JN,JP,JS,KA,KB,KD,KE,KF,KG,KI,KJ,KK,KL,KM,KN,KP,L1,L2,L3,LA,LC,LG,LR,LS,LT,LU,MA,MB,MC,MD,MF,MG,MI,MM,MN,MO,MS,MT,N1,N2,N3,N4,N5,N6,NC,ND,NH,NR,NU,NW,NZ,OA,OB,OC,OD,OE,OF,OG,OH,OI,OL,ON,OO,OP,OR,P1,P2,P3,P4,P5,PA,PB,PC,PD,PE,PF,PG,PH,PI,PJ,PK,PL,PM,PN,PO,PP,PQ,PR,PS,PT,PU,PV,PW,PY,PZ,R1,R2,RA,RB,RC,RD,RE,RF,RG,RK,RN,RO,RP,RR,RS,RT,RU,RV,RW,RY,S2,S3,SA,SB,SC,SD,SE,SF,SH,SI,SJ,SK,SL,SM,SN,SP,SQ,SR,SS,ST,SU,SV,SW,SZ,T3,TA,TB,TC,TD,TE,TI,TM,TN,TP,TR,TS,TT,TU,TV,TX,TY,U2,U5,U6,UA,UB,UC,UD,UE,UF,UG,UH,UI,UJ,UK,UL,UM,UN,UO,UP,UQ,UR,US,UT,UV,VA,VB,VC,VE,VI,VM,VN,VO,VP,VS,VT,VU,VV,VX,W1,W2,W5,WC,WL,WS,XA,XC,XP,XQ,XZ,YP,ZB,ZR,ZZ,")]
    public class X12_ID_235
    {
    }

    /// <summary>
    /// Price Identifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",ACT,AGC,ALT,AWP,BCH,C01,C02,C03,C04,C05,C06,C07,C08,C09,C10,C11,C12,C13,C14,C15,C16,C17,C18,C19,C20,C21,C22,C23,C24,C25,C26,C27,C28,C29,C30,CAN,CAT,CDF,CDV,CHG,CON,CUP,CUS,D01,D02,D03,DAP,DIS,DPR,DSC,DSD,DSP,EDM,EDP,EDS,EDW,EST,EUP,FCH,FDS,FET,FGP,FUL,FUP,GAP,GDP,GOV,GSP,GTP,ICL,IND,INS,INV,LAR,LPP,LPR,MAP,MAS,MAX,MIN,MNC,MNR,MOD,MPR,MSR,MXR,N01,N02,N03,N04,N05,N06,N07,N08,N09,N10,N11,N12,N13,N14,N15,N16,N17,N18,N19,N20,N21,N22,N23,N24,N25,N26,N27,N28,N29,N30,N31,NET,OAP,OPP,PAP,PAQ,PBQ,PBR,PHS,PIE,PLT,PPA,PPD,PRF,PRO,PRP,PUR,QTE,REG,RES,RPA,RPM,RSH,RTL,SAC,SDP,SFP,SHD,SLP,SPC,SPE,STA,SUM,SWP,THP,TOT,TRF,UCP,ULC,WAR,WHL,ZNP,")]
    public class X12_ID_236
    {
    }

    /// <summary>
    /// Car Service Order Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",145,145A,145S,145X,150,150X,155,155A,155S,34617,34618,34619,435,435A,435S,439,CM" +
        "D1A,CMD1S,CSR5,")]
    public class X12_ID_240
    {
    }

    /// <summary>
    /// Protective Service Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,BC,D,HDN,HDNC,HSC,M,MN,MNU,")]
    public class X12_ID_241
    {
    }

    /// <summary>
    /// Vent Instruction Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",V40,VC,VD40,VDOI,VO,VOI,VS,VS10,")]
    public class X12_ID_242
    {
    }

    /// <summary>
    /// Certification/Clause Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27" +
        ",28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,AM,CB,CC,CP,DC,EE,ER,G" +
        "S,HD,HN,IS,NF,")]
    public class X12_ID_246
    {
    }

    /// <summary>
    /// Allowance or Charge Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,C,N,P,R,S,")]
    public class X12_ID_248
    {
    }

    /// <summary>
    /// Vessel Requirement Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",F,M,O,R,S,")]
    public class X12_ID_249
    {
    }

    /// <summary>
    /// Automobile Ramp Facility Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,F,N,P,T,")]
    public class X12_ID_253
    {
    }

    /// <summary>
    /// Manifest Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,I,J,K,L,P,S,T,V,W,X,Y,Z,")]
    public class X12_ID_256
    {
    }

    /// <summary>
    /// Tariff Application Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,I,N,R,S,")]
    public class X12_ID_257
    {
    }

    /// <summary>
    /// Change Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,T,W,X,")]
    public class X12_ID_259
    {
    }

    /// <summary>
    /// Source of Disclosure Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class X12_ID_261
    {
    }

    /// <summary>
    /// Geography Qualifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,D,F,I,L,O,P,T,U,")]
    public class X12_ID_262
    {
    }

    /// <summary>
    /// Rating Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",00,01,02,03,04,05,07,08,09,")]
    public class X12_ID_263
    {
    }

    /// <summary>
    /// Subsidiary Risk Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",E,EI,I,")]
    public class X12_ID_271
    {
    }

    /// <summary>
    /// Hazardous Certification Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class X12_ID_272
    {
    }

    /// <summary>
    /// Terms Due Date Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,")]
    public class X12_ID_283
    {
    }

    /// <summary>
    /// Service Level Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",09,3D,9A,AC,AE,AM,BC,CB,CE,CG,CX,D1,D2,D3,DC,DR,DS,DT,ES,ET,FC,G2,GP,GT,IA,IE,IX" +
        ",ME,MW,ND,NF,NH,NM,NS,ON,PA,PB,PI,PM,PN,PO,PR,PS,R1,R2,R3,R4,R5,R6,R7,R8,RS,SA,S" +
        "C,SD,SE,SG,SH,SI,SM,SP,ST,ZZ,")]
    public class X12_ID_284
    {
    }

    /// <summary>
    /// Product/Service Condition Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,ZZ,")]
    public class X12_ID_286
    {
    }

    /// <summary>
    /// Authorize/ De-Authorize Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,C,D,")]
    public class X12_ID_287
    {
    }

    /// <summary>
    /// Prepriced Option Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,F,N,Y,Z,")]
    public class X12_ID_288
    {
    }

    /// <summary>
    /// Price Condition Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,")]
    public class X12_ID_290
    {
    }

    /// <summary>
    /// Price Condition Applies Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",001,002,003,")]
    public class X12_ID_291
    {
    }

    /// <summary>
    /// Quantity Basis
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",001,002,")]
    public class X12_ID_292
    {
    }

    /// <summary>
    /// Promotion Condition Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,99,")]
    public class X12_ID_293
    {
    }

    /// <summary>
    /// Distance Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,D,F,K,L,M,T,X,")]
    public class X12_ID_295
    {
    }

    /// <summary>
    /// Event Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",AAD,ACA,ACC,ADR,ALR,ALV,ARD,ARI,ARR,BAD,BFR,BHV,BLG,BOH,CCT,CG1,CRD,CSL,CTU,DDL,DEC,DEL,DEP,DFL,DRM,EAD,EDD,EFT,ERD,ETA,EWI,EWL,FOL,FTE,HAR,HMI,HRE,IBD,ICH,ICR,IGT,INC,INV,IRD,MAL,MWY,NOB,NOT,OCA,OGT,PAC,PCO,PEN,PFP,POS,PRB,RAM,REC,REJ,REP,RET,RLO,RMT,RYD,SAD,SAT,SDD,SLD,SPD,SPT,STA,STI,STN,STP,STS,STU,SUS,TMA,TMD,TOD,TPL,TRN,TRP,UNS,WAI,WGH,WIT,WYB,ZZX,ZZY,ZZZ,")]
    public class X12_ID_304
    {
    }

    /// <summary>
    /// Transaction Handling Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,X,Z,")]
    public class X12_ID_305
    {
    }

    /// <summary>
    /// Action Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,15,2,23,24,26,27,28,29,3,30,31,32,34,35,36,37,38,39,4,40,41,42,43,44,45,46,5,51,6,7,8,9,A,A1,A2,A3,A4,A5,A6,AA,AB,AC,AD,AE,AF,AI,AL,AP,AS,AT,AV,AW,AX,BD,BI,BO,C,CB,CE,CF,CL,CN,CO,CS,CT,CU,CV,CX,D,DC,DE,DF,DI,DJ,DK,DL,DP,DS,DX,E,EN,EP,ER,EX,F,FI,FO,FR,GR,H,HR,I,IA,IN,IS,IT,JO,JU,K,KA,L,LC,LQ,M,ME,N,NA,ND,NP,NS,O,OD,OR,OT,P,PB,PF,PI,PP,PR,Q,R,R1,R2,R3,R4,R5,R6,R7,R8,R9,RA,RB,RC,RE,RF,RG,RH,RL,RM,RO,RR,RS,RU,RV,RX,S1,SA,SC,SE,SL,SR,SU,SV,SZ,T,TR,U,V,VA,W,W1,WD,WI,WQ,WV,Z,")]
    public class X12_ID_306
    {
    }

    /// <summary>
    /// Damage Exception Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",Y,")]
    public class X12_ID_308
    {
    }

    /// <summary>
    /// Location Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",93,94,A,A1,AC,AP,AR,B,B1,BE,BL,BS,C,C2,CA,CC,CD,CI,CL,CO,CR,CS,CY,D,DC,DE,DP,DR,DT,E,EL,F,FA,FE,FF,FI,FR,FS,FT,FV,GL,H,IA,IM,IP,IS,IT,K,KE,KL,KP,L,M,MI,MS,NS,O,OA,OF,OL,OP,OR,OV,P,PA,PE,PL,PO,PP,PQ,PR,PS,PT,PU,RA,RC,RE,RG,RJ,RL,RS,RT,SB,SC,SD,SG,SH,SL,SN,SP,SS,ST,SW,TA,TC,TL,TM,TN,TR,TX,UN,UR,VS,W,WF,WH,ZN,ZZ,")]
    public class X12_ID_309
    {
    }

    /// <summary>
    /// Shipment Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AD,AM,CS,RJ,ST,")]
    public class X12_ID_311
    {
    }

    /// <summary>
    /// Special Indicator Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",I,L,N,O,T,")]
    public class X12_ID_312
    {
    }

    /// <summary>
    /// Authority Identifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BC,CA,FN,LO,NR,PP,RC,RV,SH,SO,")]
    public class X12_ID_313
    {
    }

    /// <summary>
    /// Intermodal Facility Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,3,4,5,")]
    public class X12_ID_321
    {
    }

    /// <summary>
    /// Load/Empty Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",E,L,T,")]
    public class X12_ID_322
    {
    }

    /// <summary>
    /// Lading Exception Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,D,E,O,P,W,")]
    public class X12_ID_33
    {
    }

    /// <summary>
    /// Allowance or Charge Method of Handling Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,15,18,20,21,25,CA,CC,PP,ZZ,")]
    public class X12_ID_331
    {
    }

    /// <summary>
    /// Terms Basis Date Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",09,1,10,11,12,13,14,2,3,4,5,6,7,8,ZZ,")]
    public class X12_ID_333
    {
    }

    /// <summary>
    /// Transportation Terms Qualifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,ZZ,")]
    public class X12_ID_334
    {
    }

    /// <summary>
    /// Transportation Terms Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CAF,CFR,CIF,CIP,CPT,DAF,DDP,DDU,DEQ,DES,DOM,DUP,EXQ,EXS,EXW,FAS,FCA,FCI,FCP,FOB," +
        "FOR,FOT,NPF,PPF,ZZZ,")]
    public class X12_ID_335
    {
    }

    /// <summary>
    /// Terms Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,CO,NC,PP" +
        ",ZZ,")]
    public class X12_ID_336
    {
    }

    /// <summary>
    /// Allowance or Charge Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,10,100,101,105,106,107,2,3,40,41,42,43,44,45,46,47,48,490,491,499,5,50,501,502,503,504,505,506,507,508,509,51,510,511,512,513,514,515,516,517,518,519,52,520,521,522,523,524,525,526,527,53,537,54,55,550,560,561,562,565,566,57,58,60,61,62,63,64,65,66,67,68,70,80,88,90,91,92,93,94,95,96,97,990,999,")]
    public class X12_ID_340
    {
    }

    /// <summary>
    /// Unit of Time Period or Interval
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AD,AM,AN,AP,AY,BD,BW,CC,CY,DA,DW,DY,EL,F1,F2,FY,HR,KK,KL,LN,LT,MO,MS,MT,NX,PR,Q1" +
        ",Q2,Q3,Q4,QY,SA,SD,SH,SP,WK,WW,")]
    public class X12_ID_344
    {
    }

    /// <summary>
    /// Lead Time Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AP,AR,AS,AT,AU,AV,AW,AX,AY,AZ,BA,BB,")]
    public class X12_ID_345
    {
    }

    /// <summary>
    /// Application Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47" +
        ",48,AN,AT,BD,BG,BH,BL,BN,BR,BT,CD,CI,CL,CO,DL,DO,EP,FA,FR,HR,IS,LS,LT,MF,PI,PL,R" +
        "D,RO,RP,RR,S1,S2,SI,SL,SP,SS,TF,TG,TM,ZZ,")]
    public class X12_ID_346
    {
    }

    /// <summary>
    /// Item Description Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",F,S,X,")]
    public class X12_ID_349
    {
    }

    /// <summary>
    /// Transaction Set Purpose Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",00,01,02,03,04,05,06,07,08,10,11,12,13,14,15,16,17,18,19,20,21,22,24,25,26,27,28" +
        ",30,31,32,33,34,35,36,37,38,41,42,43,44,45,46,47,48,49,50,51,52,53,54,5C,77,CN,C" +
        "O,EX,GR,PR,RH,RV,SU,ZZ,")]
    public class X12_ID_353
    {
    }

    /// <summary>
    /// Unit or Basis for Measurement Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,08,10,11,12,13,14,15,16,17,18,19,1A,1B,1C,1D,1E,1F,1G,1H,1I,1J,1K" +
        ",1L,1M,1N,1O,1X,20,21,22,23,24,25,26,27,28,29,2A,2B,2C,2F,2G,2H,2I,2J,2K,2L,2M,2" +
        "N,2P,2Q,2R,2U,2V,2W,2X,2Y,2Z,30,31,32,33,34,35,36,37,38,3A,3B,3C,3E,3F,3G,3H,3I," +
        "40,41,43,44,45,46,47,48,4A,4B,4C,4D,4E,4F,4G,4H,4I,4J,4K,4L,4M,4N,4O,4P,4Q,4R,4S" +
        ",4T,4U,4V,4W,4X,50,51,52,53,54,56,57,58,59,5A,5B,5C,5E,5F,5G,5H,5I,5J,5K,5P,5Q,6" +
        "0,61,62,63,64,65,66,67,68,69,70,71,72,73,74,76,77,78,79,80,81,82,83,84,85,86,87," +
        "89,8C,8D,8P,8R,8S,8U,90,91,92,93,94,95,96,97,98,99,A8,AA,AB,AC,AD,AE,AF,AH,AI,AJ" +
        ",AK,AL,AM,AN,AP,AQ,AR,AS,AT,AU,AV,AW,AX,AY,AZ,B0,B1,B2,B3,B4,B5,B6,B7,B8,B9,BA,B" +
        "B,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BO,BP,BQ,BR,BS,BT,BU,BV,BW,BX,BY,BZ,C0,C1," +
        "C2,C3,C4,C5,C6,C7,C8,C9,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CQ,CR,CS" +
        ",CT,CU,CV,CW,CX,CY,CZ,D2,D3,D5,D8,D9,DA,DB,DC,DD,DE,DF,DG,DH,DI,DJ,DK,DL,DM,DN,D" +
        "O,DP,DQ,DR,DS,DT,DU,DX,DY,DZ,E1,E3,E4,E5,E7,E8,E9,EA,EB,EC,ED,EF,EM,EP,EQ,EV,EX," +
        "EY,EZ,F1,F2,F3,F4,F5,F9,FA,FB,FC,FD,FE,FF,FG,FH,FJ,FL,FM,FO,FP,FR,FS,FT,FZ,G2,G3" +
        ",G4,G5,G7,GA,GB,GC,GD,GE,GF,GG,GH,GI,GJ,GK,GL,GM,GN,GO,GP,GQ,GR,GS,GT,GU,GV,GW,G" +
        "X,GY,GZ,H1,H2,H4,HA,HB,HC,HD,HE,HF,HG,HH,HI,HJ,HK,HL,HM,HN,HO,HP,HQ,HR,HS,HT,HU," +
        "HV,HW,HY,HZ,IA,IB,IC,IE,IF,IH,II,IK,IL,IM,IN,IP,IT,IU,IV,IW,J2,JA,JB,JE,JG,JK,JM" +
        ",JO,JR,JU,K1,K2,K3,K4,K5,K6,K7,K9,KA,KB,KC,KD,KE,KF,KG,KH,KI,KJ,KK,KL,KM,KO,KP,K" +
        "Q,KR,KS,KT,KU,KV,KW,KX,L2,LA,LB,LC,LD,LE,LF,LG,LH,LI,LJ,LK,LL,LM,LN,LO,LP,LQ,LR," +
        "LS,LT,LX,LY,M0,M1,M2,M3,M4,M5,M6,M7,M8,M9,MA,MB,MC,MD,ME,MF,MG,MH,MI,MJ,MK,ML,MM" +
        ",MN,MO,MP,MQ,MR,MS,MT,MU,MV,MW,MX,MY,MZ,N1,N2,N3,N4,N6,N9,NA,NB,NC,ND,NE,NF,NG,N" +
        "H,NI,NJ,NL,NM,NN,NQ,NR,NS,NT,NU,NV,NW,NX,NY,OA,ON,OP,OT,OZ,P0,P1,P2,P3,P4,P5,P6," +
        "P7,P8,P9,PA,PB,PC,PD,PE,PF,PG,PH,PI,PJ,PK,PL,PM,PN,PO,PP,PQ,PR,PS,PT,PU,PV,PW,PX" +
        ",PY,PZ,Q1,Q2,Q3,Q4,Q5,Q6,Q7,QA,QB,QC,QD,QE,QH,QK,QR,QS,QT,QU,R1,R2,R3,R4,R5,R6,R" +
        "7,R9,RA,RD,RE,RG,RH,RK,RL,RM,RN,RO,RP,RS,RT,RU,S1,S2,S3,S4,S5,S6,S7,S8,S9,SA,SB," +
        "SC,SD,SE,SF,SG,SH,SI,SJ,SK,SL,SM,SN,SO,SP,SQ,SR,SS,ST,SU,SV,SW,SX,SY,SZ,T0,T1,T2" +
        ",T3,T4,T5,T6,T7,T8,T9,TA,TB,TC,TD,TE,TF,TG,TH,TI,TJ,TK,TL,TM,TN,TO,TP,TQ,TR,TS,T" +
        "T,TU,TV,TW,TX,TY,TZ,U1,U2,U3,U5,UA,UB,UC,UD,UE,UF,UH,UL,UM,UN,V1,V2,VA,VC,VI,VP," +
        "VS,VT,W2,WA,WB,WE,WG,WH,WI,WK,WM,WP,WR,WT,WU,WW,X1,X2,X3,X4,X5,X6,X7,X8,X9,XP,Y1" +
        ",Y2,Y3,Y4,YD,YL,YR,YT,Z1,Z2,Z3,Z4,Z5,Z6,Z8,ZP,ZZ,")]
    public class X12_ID_355
    {
    }

    /// <summary>
    /// Note Reference Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",ACC,ACI,ACN,ACT,ADD,ALG,ALL,ALT,AOO,APN,APS,BOL,BUR,CER,CHG,CLR,COM,CRA,CRN,CUS,DCP,DEL,DGN,DME,DOD,ECT,EMC,ERN,EXR,EXT,FEE,GEN,GPI,GSI,ICN,IMP,INS,INT,INV,LAB,LEN,LIN,LOC,LOI,MED,MFG,MKN,NCD,NTR,OBL,OCC,ODT,ORA,ORI,OTH,PAY,PCS,PDS,PEN,PES,PID,PKG,PMT,PPC,PRI,PRN,PUR,QUT,RDI,REC,REP,REV,RHB,RLH,RNH,ROU,RPT,RVC,SAN,SET,SFM,SPH,SPT,SPV,TAF,TCF,TIL,TLF,TLR,TPO,TRA,TRF,TRS,TSF,UPI,VEC,VNN,WHI,WRP,ZZZ,")]
    public class X12_ID_363
    {
    }

    /// <summary>
    /// Communication Number Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AP,AU,BN,CP,DN,ED,EM,EX,FT,FU,FX,HF,HP,IT,MN,NP,OF,OT,PC,PS,TE,TL,TM,TX,WC,WF,WP" +
        ",")]
    public class X12_ID_365
    {
    }

    /// <summary>
    /// Contact Function Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1A,1B,1C,1D,1E,1F,1G,1H,3A,A1,A2,A3,A4,A5,AA,AB,AC,AD,AE,AF,AG,AH,AI,AL,AM,AN,AP,AR,AS,AT,AU,AV,BB,BC,BD,BI,BP,BU,C1,C2,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CQ,CR,CS,CT,CU,CW,CX,CZ,DA,DC,DD,DE,DF,DI,DM,DN,DV,E1,EA,EB,EC,ED,EF,EG,EM,EN,EP,ES,EX,FA,FB,FC,FD,FF,FL,FM,GC,GR,HM,IC,IO,IP,IS,KA,KB,KC,KP,KT,LD,MA,MB,MC,MD,ME,MG,NA,NC,NP,NT,OA,OC,OD,OW,PA,PB,PC,PD,PE,PF,PG,PH,PI,PJ,PK,PL,PM,PN,PO,PP,PQ,PR,PS,PT,PU,PX,PZ,QA,QC,QI,QM,QP,QR,RA,RB,RC,RD,RE,RF,RG,RP,RQ,RS,RZ,SA,SB,SC,SD,SE,SF,SG,SH,SI,SJ,SK,SM,SO,SP,SR,ST,SU,SV,SW,SY,TA,TC,TD,TE,TH,TM,TN,TP,TR,UG,UP,VM,VP,WH,WI,WR,ZZ,")]
    public class X12_ID_366
    {
    }

    /// <summary>
    /// Shipment/Order Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",AB,AN,AS,AU,AV,BK,BM,BO,BP,BT,BW,CA,CB,CC,CD,CE,CF,CI,CK,CL,CM,CN,CO,CP,CS,CT,DD,DE,DO,DP,DS,EC,ED,EW,EX,FS,HQ,IC,ID,IN,IP,IS,LM,LS,LW,MC,NF,NN,NS,NY,OB,OF,OP,OR,PA,PD,PH,PI,PK,PL,PN,PO,PP,PR,PS,PT,QN,QP,RC,RD,RT,RW,SA,SB,SC,SD,SE,SF,SG,SH,SI,SJ,SK,SL,SP,SQ,SS,ST,SU,UB,UN,UR,WS,ZZ,")]
    public class X12_ID_368
    {
    }

    /// <summary>
    /// Change Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AQ,BB,BD,C1,C2,C3,C4,C5,C6,DC,EV,FE,GU,GW,LD,MC,MP,PC,PQ,PS,QH,QO,QP,QT,SC,UM,UP" +
        ",WD,WO,ZZ,")]
    public class X12_ID_371
    {
    }

    /// <summary>
    /// Lading Liability Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",F,L,")]
    public class X12_ID_372
    {
    }

    /// <summary>
    /// Date/Time Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",001,002,003,004,005,006,007,008,009,010,011,012,013,014,015,016,017,018,019,020," +
        "021,022,023,024,025,026,027,028,029,030,031,032,033,034,035,036,037,038,039,040," +
        "041,042,043,044,045,046,047,048,049,050,051,052,053,054,055,056,057,058,059,060," +
        "061,062,063,064,065,066,067,068,069,070,071,072,073,074,075,076,077,078,079,080," +
        "081,082,083,084,085,086,087,088,089,090,091,092,093,094,095,096,097,098,099,100," +
        "101,102,103,104,105,106,107,108,109,110,111,112,113,114,115,116,118,119,120,121," +
        "122,124,125,126,127,128,129,130,131,132,133,134,135,136,137,138,139,140,141,142," +
        "143,144,145,146,147,148,149,150,151,152,153,154,155,156,157,158,159,160,161,162," +
        "163,164,165,166,167,168,169,170,171,172,173,174,175,176,177,178,179,180,181,182," +
        "183,184,185,186,187,188,189,190,191,192,193,194,195,196,197,198,199,200,201,202," +
        "203,204,205,206,207,208,209,210,211,212,213,214,215,216,217,218,219,220,221,222," +
        "223,224,225,226,227,228,229,230,231,232,233,234,235,236,237,238,239,240,241,242," +
        "243,244,245,246,247,248,249,250,251,252,253,254,255,256,257,258,259,260,261,262," +
        "263,264,265,266,267,268,269,270,271,272,273,274,275,276,277,278,279,280,281,282," +
        "283,284,285,286,287,288,289,290,291,292,293,294,295,296,297,298,299,300,301,302," +
        "303,304,305,306,307,308,309,310,311,312,313,314,315,316,317,318,319,320,321,322," +
        "323,324,325,326,327,328,329,330,331,332,333,334,335,336,337,338,339,340,341,342," +
        "343,344,345,346,347,348,349,350,351,352,353,354,355,356,357,358,359,360,361,362," +
        "363,364,365,366,367,368,369,370,371,372,373,374,375,376,377,378,379,380,381,382," +
        "383,384,385,386,387,388,389,390,391,392,393,394,395,396,397,398,399,400,401,402," +
        "403,404,405,406,408,409,410,411,412,413,414,415,416,417,418,419,420,421,422,423," +
        "424,425,426,427,428,429,430,431,432,433,434,435,436,437,438,439,440,441,442,443," +
        "444,445,446,447,448,449,450,451,452,453,454,455,456,457,458,459,460,461,462,463," +
        "464,465,466,467,468,469,470,471,472,473,474,475,476,477,478,479,480,481,482,483," +
        "484,485,486,487,488,489,490,491,492,493,494,495,496,497,498,499,500,501,502,503," +
        "504,505,506,507,508,509,510,511,512,513,514,515,516,517,518,519,520,521,522,523," +
        "524,525,526,527,528,529,530,531,532,533,534,535,536,537,538,539,540,541,542,543," +
        "544,545,546,547,548,549,550,551,552,553,554,555,556,557,558,559,560,561,562,563," +
        "564,565,566,567,568,569,570,571,572,573,574,575,576,577,578,579,580,581,582,583," +
        "584,585,586,587,589,590,591,592,593,594,595,596,597,598,599,600,601,602,603,604," +
        "606,607,608,609,610,611,612,613,614,615,616,617,618,619,620,621,622,623,624,625," +
        "626,627,628,629,630,631,632,633,634,635,636,637,640,641,642,643,644,649,650,653," +
        "655,656,657,658,659,660,661,662,663,664,665,666,667,668,669,683,684,686,700,701," +
        "702,703,704,705,706,707,708,709,710,711,712,713,714,715,716,718,719,720,723,724," +
        "725,726,730,731,732,733,734,736,737,738,739,750,751,752,753,754,755,756,757,758," +
        "800,801,802,803,804,805,806,807,808,809,810,811,812,813,814,815,816,817,818,820," +
        "821,822,823,824,841,842,843,844,900,901,902,903,904,905,906,907,908,909,910,911," +
        "912,913,914,915,916,917,918,919,920,921,922,923,924,925,926,927,928,929,930,931," +
        "932,933,934,935,936,937,938,939,940,941,942,943,950,992,993,994,995,996,997,998," +
        "999,AA1,AA2,AA3,AA4,AA5,AA6,ICF,ZZZ,")]
    public class X12_ID_374
    {
    }

    /// <summary>
    /// Tariff Service Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1A,1B,2A,2B,B1,B2,B3,B4,B5,BA,BB,BC,BD,BE,BF,BG,BH,BK,BL,BM,BN,BO,BP,BR,BW,BX,BY" +
        ",DB,DD,DM,DO,DP,DR,EC,H1,H2,HA,HB,HC,HD,HE,HF,HG,HH,HK,HL,HM,HN,HP,HR,HW,HX,HY,M" +
        "B,MD,ML,MM,MO,MP,MR,ND,OC,OD,OM,OR,OT,OV,PB,PD,PH,PM,PP,PR,RB,RD,RM,RO,RP,RR,")]
    public class X12_ID_375
    {
    }

    /// <summary>
    /// Rounding Rule Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,M,")]
    public class X12_ID_377
    {
    }

    /// <summary>
    /// Allowance/ Charge Percent Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,Z,")]
    public class X12_ID_378
    {
    }

    /// <summary>
    /// Bid Type Response Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AB,BF,BI,BW,DQ,OM,RE,RT,UQ,")]
    public class X12_ID_379
    {
    }

    /// <summary>
    /// Price Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,I,J,K,P,Q,S,T,X,")]
    public class X12_ID_381
    {
    }

    /// <summary>
    /// Entitlement Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,I,S,Z,")]
    public class X12_ID_39
    {
    }

    /// <summary>
    /// Bill of Lading Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class X12_ID_392
    {
    }

    /// <summary>
    /// Amendment Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,")]
    public class X12_ID_393
    {
    }

    /// <summary>
    /// Pallet Exchange Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,")]
    public class X12_ID_399
    {
    }

    /// <summary>
    /// Equipment Description Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",20,2B,2D,2E,2F,40,4B,AC,AF,AL,AP,AT,BC,BE,BF,BG,BH,BJ,BK,BO,BR,BX,CA,CB,CC,CD,CG,CH,CI,CJ,CK,CL,CM,CN,CP,CQ,CR,CS,CT,CU,CV,CW,CX,CZ,DD,DF,DT,DX,ET,FH,FN,FP,FR,FS,FT,FX,GS,HB,HC,HO,HP,HT,HV,HY,ID,IX,LO,LS,LU,NX,OB,OT,OV,PL,PP,PT,PU,RA,RC,RD,RE,RF,RG,RI,RO,RR,RS,RT,SA,SC,SD,SK,SL,SR,SS,ST,SV,TA,TB,TC,TF,TG,TH,TI,TJ,TK,TL,TM,TN,TO,TP,TQ,TR,TT,TU,TV,TW,UA,UB,UC,UD,UE,UL,UP,VA,VE,VL,VR,VS,VT,WR,WY,")]
    public class X12_ID_40
    {
    }

    /// <summary>
    /// Unit Load Option Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,ZZ,")]
    public class X12_ID_400
    {
    }

    /// <summary>
    /// Seal Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,")]
    public class X12_ID_407
    {
    }

    /// <summary>
    /// Receiving Condition Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,16,")]
    public class X12_ID_412
    {
    }

    /// <summary>
    /// Promotion Condition Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,10,11,12,13,14,15,16,17,18,19,20,21,22,23,25,26,28,32,33,34,35,36" +
        ",37,39,40,41,42,44,45,46,49,51,59,60,61,62,63,64,69,70,71,72,79,81,82,83,84,88,9" +
        "9,A1,A2,A3,A4,A5,B1,B2,B3,C1,C2,C3,C4,ZZ,")]
    public class X12_ID_422
    {
    }

    /// <summary>
    /// Promotion Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,")]
    public class X12_ID_423
    {
    }

    /// <summary>
    /// Adjustment Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,A1,A2,A3,A4,A5,A6,A7,A8,A9,AA,AB,AC,AD,AE,AF,AG,AH,AL,AM,AN,AO,AP,AR,AT,AU,AV,AW,B1,B2,B3,B4,B5,B6,B7,B8,B9,BN,BO,BR,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CQ,CS,CU,D1,D2,D3,D4,D5,D6,D7,D8,D9,DA,DB,DC,DD,DE,DF,DG,DH,DI,DJ,DK,DL,DO,DP,DR,DS,DT,DV,DW,E1,E2,E3,E4,E5,E6,E7,E8,E9,EE,ER,EX,F1,F3,F4,F5,F6,F7,F8,F9,FA,FI,FR,FT,G1,G2,G3,G4,G5,G6,G7,G8,G9,GA,GB,GC,GD,GE,GF,GG,GH,GJ,GK,GL,GM,GN,GR,H1,H2,H3,H4,H5,H6,H7,H8,H9,HA,HB,HC,HD,HE,HF,HG,HI,IA,IC,IE,IL,J1,J2,J3,J4,J5,J6,J7,J8,J9,JE,K1,K2,K3,L1,L2,L3,L4,L5,L6,L7,L8,L9,LA,LF,LO,LP,LS,M1,M2,M3,M4,MA,MC,NB,OL,PA,PD,PF,PL,PM,PO,PP,PR,PT,R1,R2,R3,RD,RM,SC,SD,SF,SP,TA,UB,VC,VD,VO,W6,W7,W8,W9,WA,WB,WC,WH,WO,WR,WS,WT,WU,WW,WY,ZZ,")]
    public class X12_ID_426
    {
    }

    /// <summary>
    /// Date Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,66,67,68,69,70,71,72,73,74,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,AA,AB,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BO,BP,BQ,BR,BS,BT,BU,BV,BW,BX,BY,BZ,CA,CB,CE,CL,EP,KA,LA,LC,LD,LP,PE,TA,TR,")]
    public class X12_ID_432
    {
    }

    /// <summary>
    /// F.O.B. Point Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,")]
    public class X12_ID_433
    {
    }

    /// <summary>
    /// Reference Usage Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BR,DR,GR,OP,RR,TP,")]
    public class X12_ID_436
    {
    }

    /// <summary>
    /// Rate Maintenance Authority Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",M,")]
    public class X12_ID_437
    {
    }

    /// <summary>
    /// Tax Exempt Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,3,4,5,6,7,8,9,A,B,C,E,F,G,L,R,U,")]
    public class X12_ID_441
    {
    }

    /// <summary>
    /// Purchase Order Instruction Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AQ,BO,BX,NS,SA,SX,")]
    public class X12_ID_444
    {
    }

    /// <summary>
    /// Terms Exception Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",DF,DG,DN,EB,GS,IP,NI,PS,SP,ZZ,")]
    public class X12_ID_445
    {
    }

    /// <summary>
    /// Property Damage Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,")]
    public class X12_ID_448
    {
    }

    /// <summary>
    /// Responsible Agency Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",T,X,")]
    public class X12_ID_455
    {
    }

    /// <summary>
    /// Temperature Probe Location Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,")]
    public class X12_ID_456
    {
    }

    /// <summary>
    /// Shipment Weight Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,C,D,E,F,G,H,M,N,O,R,S,T,")]
    public class X12_ID_460
    {
    }

    /// <summary>
    /// Transit Level Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",X,XX,XXX,")]
    public class X12_ID_461
    {
    }

    /// <summary>
    /// Container Terms Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",I,")]
    public class X12_ID_465
    {
    }

    /// <summary>
    /// Export Filing Key Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,M,")]
    public class X12_ID_47
    {
    }

    /// <summary>
    /// Order Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,C,D,E,F,G,L,N,R,S,T,X,")]
    public class X12_ID_473
    {
    }

    /// <summary>
    /// Credit/Debit Flag Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,D,")]
    public class X12_ID_478
    {
    }

    /// <summary>
    /// Functional Identifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",AA,AF,AG,AI,AK,AL,AN,AR,AS,AW,BE,BS,CA,CC,CD,CF,CG,CH,CI,CJ,CK,CM,CN,CO,CP,CR,CS,CT,D3,D4,D5,DA,DD,DF,DI,DM,DS,DX,EC,ED,EI,ER,EV,FA,FB,FC,FG,FH,FR,FT,GB,GC,GF,GP,GR,GT,HB,HC,HI,HN,HP,HR,HS,IA,IB,IC,ID,IG,II,IJ,IM,IN,IO,IP,IR,IS,LA,LB,LI,LN,LR,LS,LT,MB,MD,ME,MF,MG,MH,MI,ML,MP,MR,MS,MT,MV,MW,MX,NC,NT,OC,OG,OR,OW,PA,PB,PC,PD,PE,PH,PI,PJ,PK,PL,PM,PO,PR,PS,PT,PV,PY,PZ,QG,QM,QO,RA,RC,RD,RE,RF,RG,RI,RL,RM,RN,RO,RP,RQ,RR,RS,RT,RU,RX,RY,RZ,SA,SB,SC,SD,SE,SF,SG,SH,SI,SL,SM,SO,SP,SQ,SR,SS,ST,SV,SW,TA,TC,TD,TF,TI,TN,TO,TP,TR,TS,TX,UA,UB,UC,UD,UI,UW,VA,VB,VC,VD,VH,VS,WA,WB,WG,WI,WR,WT,")]
    public class X12_ID_479
    {
    }

    /// <summary>
    /// Export License Control Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,")]
    public class X12_ID_48
    {
    }

    /// <summary>
    /// Trace Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class X12_ID_481
    {
    }

    /// <summary>
    /// Payment Action Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AE,AI,AJ,EE,EI,ER,FL,NS,PA,PE,PI,PO,PP,PR,")]
    public class X12_ID_482
    {
    }

    /// <summary>
    /// Counseling Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",I,S,T,U,V,")]
    public class X12_ID_483
    {
    }

    /// <summary>
    /// Evaluation Rating Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,N,P,")]
    public class X12_ID_484
    {
    }

    /// <summary>
    /// Results Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,")]
    public class X12_ID_485
    {
    }

    /// <summary>
    /// Product Transfer Movement Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AI,AO,CD,DC,DM,MD,TI,TO,")]
    public class X12_ID_486
    {
    }

    /// <summary>
    /// Maintenance Operation Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,C,D,F,I,R,")]
    public class X12_ID_487
    {
    }

    /// <summary>
    /// Data Element Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,C,S,")]
    public class X12_ID_491
    {
    }

    /// <summary>
    /// Customs Documentation Handling Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",10,14,15,16,17,20,24,25,26,27,30,34,35,36,37,90,")]
    public class X12_ID_501
    {
    }

    /// <summary>
    /// Block 20 Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class X12_ID_503
    {
    }

    /// <summary>
    /// (DFI) ID Number Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,ZZ,")]
    public class X12_ID_506
    {
    }

    /// <summary>
    /// Export License Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,P,")]
    public class X12_ID_51
    {
    }

    /// <summary>
    /// Rail Car Plate Size Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,C,D,E,F,G,H,I,X,")]
    public class X12_ID_511
    {
    }

    /// <summary>
    /// Import/Export Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,E,I,")]
    public class X12_ID_512
    {
    }

    /// <summary>
    /// Reporting Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,F,J,K,N,O,P,R,S,X,Y,")]
    public class X12_ID_514
    {
    }

    /// <summary>
    /// Total Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,")]
    public class X12_ID_516
    {
    }

    /// <summary>
    /// Time Period Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,A,D,H,O,")]
    public class X12_ID_519
    {
    }

    /// <summary>
    /// Export License Symbol Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,2,3,4,5,6,7,8,9,G,V,")]
    public class X12_ID_52
    {
    }

    /// <summary>
    /// Product Transfer Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BO,BP,BQ,BR,CC,CO,CS,DS,FG,IA,IB,OF,ON,PA" +
        ",PB,PL,PM,PO,PP,RA,RB,RC,RP,RU,RV,SA,SC,SD,SH,SM,SS,SU,TD,WL,")]
    public class X12_ID_521
    {
    }

    /// <summary>
    /// Amount Qualifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,1A,1B,1C,1D,1E,1F,1G,1H,1K,1L,1M,1N,1P,1Q,1R,1S," +
        "1T,1U,1V,1W,1X,1Y,1Z,2,20,21,22,23,24,25,26,27,28,29,2A,2B,2C,2D,2F,2H,2I,2J,2K," +
        "2L,2M,3,30,31,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52" +
        ",53,54,55,56,57,58,59,6,60,61,62,63,64,65,66,67,68,69,7,70,71,72,73,74,75,76,77," +
        "78,79,8,80,81,82,83,84,85,86,87,88,89,9,90,91,92,93,94,95,96,97,98,99,A,A0,A1,A2" +
        ",A3,A4,A5,A6,A7,A8,A9,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,A" +
        "T,AU,AV,AW,AX,AY,AZ,B,B0,B1,B2,B3,B4,B5,B6,B7,B8,B9,BA,BB,BC,BD,BE,BF,BG,BH,BI,B" +
        "J,BK,BL,BM,BN,BO,BP,BQ,BR,BS,BT,BU,BV,BW,BX,BY,BZ,C,C1,C2,C3,C4,C5,C6,C7,C8,C9,C" +
        "A,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CQ,CR,CS,CT,CU,CV,CW,CX,CY,CZ,D,D" +
        "1,D2,D3,D4,D5,D6,D7,D8,D9,DA,DB,DC,DD,DE,DF,DG,DH,DI,DJ,DK,DL,DM,DN,DO,DP,DQ,DR," +
        "DS,DT,DU,DV,DW,DX,DY,DZ,E,E1,E2,E3,E4,E5,E6,E7,E8,E9,EA,EB,EC,ED,EE,EF,EG,EH,EI," +
        "EJ,EK,EL,EM,EN,EP,EQ,ER,ES,ET,EU,EV,EW,EX,EY,EZ,F,F1,F2,F3,F4,F5,F6,F7,F8,F9,FA," +
        "FB,FC,FD,FE,FF,FG,FH,FI,FJ,FK,FL,FM,FN,FO,FP,FQ,FR,FT,FX,G,G1,G2,G3,G4,G5,G6,G7," +
        "G8,G9,GA,GB,GC,GD,GE,GF,GG,GH,GI,GJ,GK,GL,GM,GV,H,H0,HA,HB,HC,HD,HE,HF,HG,I,I1,I" +
        "3,I4,IA,IB,IC,ID,IE,IF,IG,IH,II,IJ,IK,IL,IM,IN,IO,IP,IR,IS,IU,IV,IW,J,J1,J2,JA,J" +
        "C,JG,JH,JT,JU,K,K1,K2,K3,K4,K5,K6,K8,K9,KA,KB,KC,KD,KE,KF,KG,KH,KI,KJ,KK,KL,KM,K" +
        "N,KO,KP,KQ,KS,KT,KU,KW,KX,KY,KZ,L,L1,L2,L3,L4,L5,L6,L7,L8,L9,LA,LB,LC,LD,LE,LI,L" +
        "M,LN,LP,LR,LS,LW,LX,LY,LZ,M,M1,M2,M3,M4,M5,M6,M7,M8,MA,MB,MC,MF,MN,MO,MP,MR,MS,M" +
        "Z,N,N1,N2,N3,N4,N5,N6,N7,N8,N9,NA,NB,NC,ND,NE,NF,NG,NH,NI,NJ,NL,NO,NP,NQ,NR,NS,N" +
        "Y,O,O1,O2,OB,OF,OL,OP,P,P0,P1,P2,P3,P4,P5,P6,P7,P8,P9,PA,PB,PC,PD,PE,PF,PG,PH,PI" +
        ",PJ,PK,PL,PM,PN,PO,PP,PQ,PR,PS,PT,PU,PV,PW,PX,PY,PZ,Q,Q1,Q2,Q3,Q4,Q5,Q6,Q7,Q8,Q9" +
        ",QA,QB,QC,QD,QE,QF,QG,QH,QI,QJ,QK,QL,QM,QN,QO,QP,QS,QT,QU,QV,QW,QX,QY,QZ,R,R1,R2" +
        ",R3,R4,R5,R6,R7,R8,R9,RA,RB,RC,RD,RE,RF,RG,RH,RP,RR,RS,RT,RU,RV,RW,RX,RY,RZ,S,S0" +
        ",S1,S2,S3,S4,S5,S6,S7,S8,S9,SA,SB,SC,SE,SF,SG,SI,SM,SP,SR,SS,ST,SU,SX,T,T0,T1,T2" +
        ",T3,T4,T5,T6,T7,T8,T9,TA,TB,TC,TD,TE,TF,TG,TH,TI,TK,TL,TN,TP,TS,TT,TU,TX,TY,TZ,U" +
        ",U0,U1,U2,U3,U4,U5,U6,U7,U8,U9,UA,UB,UC,UD,UE,UF,UG,UH,UI,UJ,UK,UL,UM,UN,UO,UP,U" +
        "Q,US,UV,UY,UZ,V,V0,V1,V2,V3,V4,V5,V6,V7,VF,W,W1,W2,W3,W4,WK,WW,X,X2,X3,X6,X7,X9," +
        "Y1,Y2,Y3,Y4,Y5,Y6,Y7,Y8,Y9,YA,YB,YC,YD,YE,YF,YG,YH,YI,YJ,YK,YQ,YR,YS,YT,YU,YV,YW" +
        ",YX,YY,Z0,Z1,Z2,Z3,Z4,Z5,Z6,Z7,Z8,Z9,ZA,ZB,ZC,ZD,ZE,ZF,ZG,ZH,ZI,ZJ,ZK,ZL,ZM,ZN,Z" +
        "O,ZP,ZQ,ZR,ZS,ZT,ZU,ZV,ZW,ZX,ZY,ZZ,")]
    public class X12_ID_522
    {
    }

    /// <summary>
    /// Inventory Transaction Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AD,AJ,BO,CM,DM,DP,DU,IT,PA,QU,RC,RD,RE,RT,SA,WH,")]
    public class X12_ID_529
    {
    }

    /// <summary>
    /// Water Movement Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,N,P,S,")]
    public class X12_ID_533
    {
    }

    /// <summary>
    /// Inland Transportation Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CO,IC,IP,ML,RO,SD,SU,")]
    public class X12_ID_534
    {
    }

    /// <summary>
    /// Rail Retirement Activity Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,S,T,")]
    public class X12_ID_535
    {
    }

    /// <summary>
    /// Nature of Claim Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",99,CA,CN,DE,FR,HT,PO,RD,RO,SH,TH,VS,WA,")]
    public class X12_ID_536
    {
    }

    /// <summary>
    /// Employment Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,R,")]
    public class X12_ID_537
    {
    }

    /// <summary>
    /// Charge/Allowance Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",DS,LA,MA,PR,RC,RE,RL,SA,TR,")]
    public class X12_ID_538
    {
    }

    /// <summary>
    /// Risk of Loss Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BY,FE,PP,SE,ZZ,")]
    public class X12_ID_54
    {
    }

    /// <summary>
    /// Supporting Evidence Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",D,N,")]
    public class X12_ID_544
    {
    }

    /// <summary>
    /// Unemployed Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,")]
    public class X12_ID_545
    {
    }

    /// <summary>
    /// Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27" +
        ",28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,44,45,AN,AS,AT,CR,DC,DN,DS,FP,MS,N" +
        "O,NR,NU,OH,OV,PF,PP,SP,WD,")]
    public class X12_ID_546
    {
    }

    /// <summary>
    /// Interest Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,D,E,M,")]
    public class X12_ID_547
    {
    }

    /// <summary>
    /// Decline/Amend Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AOG,CAC,CCD,CDC,CDI,CFO,CFT,CIB,CIC,CNG,CNL,CSD,CSO,CSR,CTA,DAM,DDO,DMN,DNH,DNI," +
        "DNR,DNS,DOA,DPS,DSA,DUP,FIS,GSA,GWL,IAW,ICC,INC,INF,MAN,MDD,NCA,NCR,NDI,NFT,NLI," +
        "NNI,NRC,OCC,OTH,RAC,RAD,RUC,RUD,SMA,SNA,SRD,SRE,VDC,VDD,VDI,VDQ,VDS,VIS,VRP,")]
    public class X12_ID_548
    {
    }

    /// <summary>
    /// Reservation Action Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,N,R,U,")]
    public class X12_ID_558
    {
    }

    /// <summary>
    /// Agency Qualifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",94,A1,A2,A3,AA,AB,AC,AD,AE,AH,AI,AL,AM,AP,AS,AT,AW,AX,BE,BF,BI,CA,CB,CC,CI,CL,CM,CO,CR,CX,DA,DD,DE,DF,DI,DL,DO,DR,EI,EP,ES,EU,EX,FA,FC,FD,FG,FI,GC,GS,GU,HC,HI,HU,IA,IB,IC,IM,IS,JA,LB,LI,MA,MB,MC,ME,MI,MP,MS,NA,NB,NC,NE,NF,NG,NI,NR,NS,NT,NW,OP,OS,PA,PC,SA,SE,SL,SP,ST,TA,TB,TC,TD,TI,TM,TP,TR,TX,UC,UN,VI,WH,ZZ,")]
    public class X12_ID_559
    {
    }

    /// <summary>
    /// Type of Service Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CS,CY,HH,HL,HP,MD,NC,PH,PP,")]
    public class X12_ID_56
    {
    }

    /// <summary>
    /// Special Services Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",A0010,A0020,A0030,AC,AD,AF,AG,AM,AO,B0020,B0040,BH,BI,BOP,C0012,C0032,C0036,C0038,C1,CA,CD,CH,CI,CM,CN,CS,CT,CU,CY,CZ,D0020,D0024,D0031,D1,D2,DA,DE,DI,DL,DS,DV,E0030,EG,EM,EN,ER,EU,EX,F1,FG,FS,G0010,G0052,GI,GP,GU,H1,HC,HH,HS,I0012,I0013,I0021,I0022,IC,ID,IG,IK,IL,IM,IN,IO,IP,IQ,IR,IS,IT,KO,L1,LA,LS,M0010,M0042,MI,ML,MNTAN,MNTMN,MNTON,N0020,N0021,N0032,NC,OA,ON,OP,P0012,P0014,P0016,P0018,P0022,PA,PB,PC,PE,PF,PL,PLI,PM,PO,PP,PSF,R0072,R0076,R0077,R0110,RD,RE,RM,RP,S0014,S0016,S0022,S0024,S0050,S0052,S0054,S0056,S0080,S1,S2,S3,SD,SG,SH,SJ,SLP,SPI,SR,SS,ST,SU,SV,SW,T0070,T1,TC,TE,TH,TM,TO,UN,US,V1,V2,W0010,WC,WH,X0010,XP,XX,YY,ZZ,")]
    public class X12_ID_560
    {
    }

    /// <summary>
    /// Rate or Value Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,AB,AD,AE,AR,BO,CB,CR,DR,DT,OI,OT,RF,RR,RS,SP,SR,TR,UA,UT,")]
    public class X12_ID_562
    {
    }

    /// <summary>
    /// Sales Requirement Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",8A,AI,AS,B,BC,BK,C,D,EI,F,FT,GS,IP,IS,K,LS,MY,N,NS,O,P,P2,P3,P4,Q,QB,QM,QP,R,S,S" +
        "C,SE,SF,SG,SL,SP,SQ,SS,ST,SU,SV,SW,T,UC,UL,UP,W,WY,Y,YI,Z,")]
    public class X12_ID_563
    {
    }

    /// <summary>
    /// Do-Not-Exceed Action Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,Z,")]
    public class X12_ID_564
    {
    }

    /// <summary>
    /// Product/Service Substitution Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B0,B1,B2,B3,B4,X,Y,ZZ,")]
    public class X12_ID_566
    {
    }

    /// <summary>
    /// Electronic Form Note Reference Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",ABS,DMR,IND,NON,PUR,SCP,STD,")]
    public class X12_ID_568
    {
    }

    /// <summary>
    /// Account Number Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,03,05,06,07,08,1,10,11,12,13,2,3,AG,ALC,DA,EPC,LTD,RD,REL,RS,SG,Z,ZB1,ZB2,")]
    public class X12_ID_569
    {
    }

    /// <summary>
    /// Scale Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",P,R,")]
    public class X12_ID_570
    {
    }

    /// <summary>
    /// Tare Qualifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,M,")]
    public class X12_ID_571
    {
    }

    /// <summary>
    /// Weight Allowance Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",D,F,I,S,W,")]
    public class X12_ID_572
    {
    }

    /// <summary>
    /// City Name Qualifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",S,")]
    public class X12_ID_575
    {
    }

    /// <summary>
    /// Equipment Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,AG,AH,AI,AJ,AK,D,E,L,O,W,")]
    public class X12_ID_578
    {
    }

    /// <summary>
    /// Type of Consist Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,J,L,P,R,S,T,Y,")]
    public class X12_ID_579
    {
    }

    /// <summary>
    /// Amendment Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,D,N,R,S,")]
    public class X12_ID_580
    {
    }

    /// <summary>
    /// Bill of Lading Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",00,01,10,11,12,13,14,15,16,17,18,")]
    public class X12_ID_582
    {
    }

    /// <summary>
    /// Employment Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,AD,AF,AO,AP,AU,CA,CO,CT,DC,DI,DQ,DR,DS,FA,FB,FC,FO,FT,IA,L1,LA,LE,LM,LS" +
        ",LU,LW,NE,OS,PT,PW,RA,RI,RM,RP,RT,RU,RW,SA,SE,SL,SU,TE,UK,VO,ZZ,")]
    public class X12_ID_584
    {
    }

    /// <summary>
    /// Payroll Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AB,AL,CL,DH,GU,HO,JD,LO,MC,ML,MO,OP,PD,RD,RF,SD,SU,VC,WK,")]
    public class X12_ID_585
    {
    }

    /// <summary>
    /// Acknowledgment Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AC,AD,AE,AH,AK,AP,AT,NA,RD,RF,RJ,RO,ZZ,")]
    public class X12_ID_587
    {
    }

    /// <summary>
    /// Wages Paid Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,")]
    public class X12_ID_590
    {
    }

    /// <summary>
    /// Payment Method Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",ACH,BKW,BOP,CCC,CCF,CHK,CPC,CWT,DCC,DCD,DPC,DPD,DXC,DXD,DZC,DZD,EBX,FEW,FWT,NON," +
        "PAC,PBD,PDC,PDD,PRO,REV,SCC,SCD,SDC,SDD,SPC,SPD,SWT,SXC,SXD,SZC,SZD,X12,ZZZ,")]
    public class X12_ID_591
    {
    }

    /// <summary>
    /// Lading Description Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,C,D,E,I,L,P,")]
    public class X12_ID_592
    {
    }

    /// <summary>
    /// Frequency Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,B,C,H,Q,S,U,Z,")]
    public class X12_ID_594
    {
    }

    /// <summary>
    /// Compartment ID Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,")]
    public class X12_ID_595
    {
    }

    /// <summary>
    /// Manifest Unit Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BAG,BBL,BDL,BIC,BIN,BKT,BLE,BOX,BSK,CAN,CAR,CAS,CBC,CBY,CCS,CHS,CNT,COL,COR,CRT," +
        "CSK,CTN,CYL,DBK,DRM,GAL,HED,HMP,KEG,LBK,LOG,LUG,LVN,PAL,PCL,PCS,PKG,PLT,POV,QTR," +
        "REL,ROL,SAK,SHT,SID,SKD,TBE,TBN,TIN,TNK,UNT,VPK,WDC,")]
    public class X12_ID_599
    {
    }

    /// <summary>
    /// Consolidation Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,N,W,")]
    public class X12_ID_604
    {
    }

    /// <summary>
    /// Deficiency Judgement Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,")]
    public class X12_ID_605
    {
    }

    /// <summary>
    /// Credit File Variation Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,ZZ,")]
    public class X12_ID_608
    {
    }

    /// <summary>
    /// Disposition Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,ZZ,")]
    public class X12_ID_611
    {
    }

    /// <summary>
    /// Credit Report Merge Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,Z,")]
    public class X12_ID_612
    {
    }

    /// <summary>
    /// Time Period Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34" +
        ",35,36,4,5,6,7,8,Z,")]
    public class X12_ID_615
    {
    }

    /// <summary>
    /// Switch Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AI,BE,BO,CR,DC,HF,HT,IP,NO,NU,OS,PL,PU,RE,SB,TR,TS,WG,")]
    public class X12_ID_617
    {
    }

    /// <summary>
    /// Time Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,AD,AS,AT" +
        ",CD,CS,CT,ED,ES,ET,GM,HD,HS,HT,LT,MD,MS,MT,PD,PS,PT,UT,")]
    public class X12_ID_623
    {
    }

    /// <summary>
    /// COD Method of Payment Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,")]
    public class X12_ID_625
    {
    }

    /// <summary>
    /// Excess Transportation Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,I,J,K,L,M,N,P,R,T,U,V,W,X,Y,ZZ,")]
    public class X12_ID_626
    {
    }

    /// <summary>
    /// Excess Transportation Responsibility Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,S,X,Z,")]
    public class X12_ID_627
    {
    }

    /// <summary>
    /// Alternation Precedence Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",L,N,S,")]
    public class X12_ID_629
    {
    }

    /// <summary>
    /// Rate Application Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,D,E,F,L,M,N,P,R,S,T,")]
    public class X12_ID_632
    {
    }

    /// <summary>
    /// Rate Request/Response Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,3,4,A,D,F,I,P,T,")]
    public class X12_ID_635
    {
    }

    /// <summary>
    /// Basis of Unit Price Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",03,AP,AW,BD,BR,BW,CA,CP,CR,CT,DI,DP,DR,DS,EC,ES,FB,FO,FX,HF,HP,HT,KA,KP,KR,LC,LD,LE,LM,LR,ME,ML,NC,NE,NQ,NS,NT,PA,PB,PD,PE,PF,PG,PK,PL,PM,PN,PO,PP,PQ,PR,PS,PT,PU,PV,PY,QE,QH,QR,QS,QT,RC,RD,RE,RM,RS,RT,SA,SC,SM,SR,ST,SW,TB,TC,TD,TE,TF,TM,TP,TT,UM,VQ,WC,WD,WE,WH,WI,WM,")]
    public class X12_ID_639
    {
    }

    /// <summary>
    /// Transaction Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,60,62,63,64,65,66,67,68,69,6A,6C,6N,6R,6S,70,71,72,73,74,75,76,77,78,79,80,81,82,83,85,A0,A1,A3,A4,AC,AD,AF,AI,AM,AN,AP,AQ,AR,AS,AV,AW,AZ,BA,BB,BD,BF,BH,BJ,BK,BL,BM,BN,BO,BP,BS,C0,C1,C2,C3,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CR,CS,CT,CU,CV,CY,D1,D4,DA,DB,DC,DD,DE,DF,DG,DH,DI,DK,DN,DO,DP,DQ,DR,DS,DU,EA,EB,EF,EI,EM,EP,ER,EX,FA,FB,FC,FD,FE,FF,FI,FL,FM,FN,FP,FR,FT,GA,GI,HP,I1,IA,IB,IC,ID,IE,IF,II,IN,IO,IR,IU,IW,IZ,JM,JO,JR,JU,KB,KC,KD,KE,KF,KG,KH,KI,KJ,KK,KL,KM,KN,KS,KT,LC,LD,LE,LF,LN,LO,LP,LR,M1,MA,MC,MD,ME,MF,MI,ML,MM,MP,MR,MS,MU,N1,N2,N3,N4,N5,N6,N7,N8,NA,NB,NC,ND,NE,NF,NG,NH,NI,NJ,NK,NL,NM,NO,NP,NQ,NR,NT,NU,OC,OF,OP,OR,P1,PA,PB,PD,PF,PG,PI,PL,PM,PO,PP,PR,PS,PT,QA,QB,QC,QD,QE,QF,QG,QH,QJ,QK,QL,QP,QR,R1,R2,RA,RB,RC,RD,RE,RF,RG,RH,RM,RP,RQ,RS,RT,RU,RZ,S1,S2,S3,S4,SA,SB,SC,SD,SE,SF,SG,SL,SM,SO,SP,SQ,SR,SS,ST,SU,SV,TD,TG,TH,TI,TJ,TK,TP,TR,TS,U1,U2,U4,U5,U9,UA,UC,UD,UF,UI,UM,UO,UP,UR,UT,V1,W1,W4,W5,WA,WC,WD,WO,WS,WT,XA,XB,XC,XD,ZZ,")]
    public class X12_ID_640
    {
    }

    /// <summary>
    /// Status Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",001,002,003,004,005,006,007,008,009,010,011,012,013,014,015,016,017,018,019,020,021,022,023,024,025,026,027,028,029,030,031,A01,A02,A03,A04,A05,A06,A07,A08,A09,A10,A11,A12,A13,A14,A15,A16,A17,A18,A19,A20,A21,A22,A23,A24,A25,A26,A27,A28,A29,A30,A31,A32,A33,A34,A36,A37,A38,A39,A40,A41,A42,A43,A45,A46,A49,A50,A51,A52,A53,A55,A58,A59,A61,A63,A64,A65,A73,A74,A84,A85,A91,A95,A96,A98,A99,ABN,ACC,ACD,AGC,AGD,B01,B02,B03,B04,B05,B06,B07,B08,B09,B10,B11,B12,B13,B14,B15,B16,B17,B18,B19,B20,B21,B22,B23,B24,B25,B26,B27,B28,B29,B30,B31,B32,B33,B34,B35,B36,B37,B38,B39,B40,B41,B42,B43,B44,B45,B46,B47,B48,B49,B50,B51,B52,BW2,BWL,BWT,BWW,C01,C02,C03,C04,C05,C06,C07,C08,C09,C10,C11,C12,C13,C14,C15,C16,C17,C18,C19,CDE,D01,D02,D03,D04,D05,D06,D07,D08,D09,D10,D11,D12,D13,D14,D15,D16,D17,D18,D19,D20,D21,D22,D23,D24,D25,D26,D27,D28,D29,D30,D50,D51,D52,D53,D54,D55,D56,D57,D58,D59,D60,D61,D62,D63,EB1,EB2,EB3,EB4,EB5,EB6,EB7,EB8,EB9,EBA,ENR,ERR,EXD,F73,F74,FCS,FRB,HZM,INC,IV1,IV2,LSH,MP2,MPL,MPT,MPW,NOR,P01,P02,P03,P04,P05,P06,P07,RFM,S01,SOW,T01,T02,T03,T04,T05,T06,T07,TDR,TIL,TP2,TPL,TPT,TPW,UCD,UND,W01,W02,W03,W04,W05,W06,W07,W08,W09,W10,W11,W12,W13,W14,W15,W16,WLC,WLT,WLW,WTP,ZZZ,")]
    public class X12_ID_641
    {
    }

    /// <summary>
    /// Lading Percent Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,M,O,S,")]
    public class X12_ID_644
    {
    }

    /// <summary>
    /// Related Company Indication Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,Y,")]
    public class X12_ID_645
    {
    }

    /// <summary>
    /// Application Error Condition Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",001,002,003,004,005,006,007,008,009,010,011,012,024,026,027,028,029,036,500,801,802,803,804,805,806,807,808,809,810,811,812,813,814,815,817,818,819,820,821,822,823,824,825,826,827,828,829,830,831,832,833,834,847,848,849,A,ASA,ASV,AVE,B,C,CAL,COV,CUR,D,DBL,DDT,DRC,DTE,DUP,E,F,G,H,HUG,HUL,I,ICA,ICG,IDC,IDN,IID,IMD,INC,INF,IPR,IQT,IWT,J,K,L,LOC,M,MBL,MDN,MID,MQT,MWT,N,NAU,NCL,NCR,NDP,NDT,NIF,NOD,NRA,O,OTH,P,PND,POI,PPD,PRM,Q,QTY,R,RAT,RTE,S,SCA,SCD,SEV,SPL,STA,STP,STR,T,TRN,TYP,U,UAU,UCN,UKN,UNV,V,VIN,VND,VOS,ZDS,ZZZ,")]
    public class X12_ID_647
    {
    }

    /// <summary>
    /// Price Multiplier Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CSD,CSR,DIS,ILP,PSP,SEL,")]
    public class X12_ID_648
    {
    }

    /// <summary>
    /// Rating Remarks Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,33,35,36" +
        ",37,38,39,40,")]
    public class X12_ID_650
    {
    }

    /// <summary>
    /// Discount Terms Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AMT,CSH,DOR,DPU,DSH,DSV,POR,PPU,PSH,PSV,UNT,ZZZ,")]
    public class X12_ID_653
    {
    }

    /// <summary>
    /// Discount Base Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CA,PC,UN,ZZ,")]
    public class X12_ID_654
    {
    }

    /// <summary>
    /// Discount Control Limit Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",DAT,DOF,")]
    public class X12_ID_656
    {
    }

    /// <summary>
    /// Basis of Verification Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,")]
    public class X12_ID_659
    {
    }

    /// <summary>
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,32,33,34,35,36,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,53,54,55,56,57,6,61,62,63,7,71,72,73,74,75,76,77,78,8,81,82,9,90,91,92,93,94,95,96,97,98,99,A1,A2,AA,AC,AD,AE,AL,AP,BC,BD,BE,BG,BP,BS,C,C1,C2,CA,CB,CC,CD,CE,CF,CI,CL,CP,CR,CS,CT,D,DG,DL,DN,DP,DS,EH,EI,EP,EQ,ER,ES,FA,FB,FC,FD,FI,FJ,GA,GC,HN,K,LC,LD,LE,LI,LN,M3,M4,M5,M6,MA,MB,MC,MD,MI,MK,MN,MP,MR,N,NI,NO,OC,OP,PA,PC,PI,PP,PR,RA,RT,SA,SD,SF,SI,SJ,SL,SP,ST,SV,SW,TC,TZ,UC,UL,UP,US,WR,ZC,ZN,ZY,ZZ,")]
    public class X12_ID_66
    {
    }

    /// <summary>
    /// Relationship Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,D,I,O,S,")]
    public class X12_ID_662
    {
    }

    /// <summary>
    /// Residue Indicator Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",R,")]
    public class X12_ID_665
    {
    }

    /// <summary>
    /// Division Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,B,C,D,E,H,M,N,P,R,")]
    public class X12_ID_666
    {
    }

    /// <summary>
    /// Line Item Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AC,AR,BP,DR,IA,IB,IC,ID,IE,IF,IH,IP,IQ,IR,IS,IW,SP,")]
    public class X12_ID_668
    {
    }

    /// <summary>
    /// Currency Market/Exchange Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",IMF,LNF,LNS,NYC,PHI,ZUR,")]
    public class X12_ID_669
    {
    }

    /// <summary>
    /// Change or Response Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AI,CA,CB,CC,CE,CF,CG,CH,CI,CT,DI,MU,NC,OA,OC,PC,PQ,PR,QD,QI,RA,RB,RC,RE,RM,RQ,RS" +
        ",RZ,TI,")]
    public class X12_ID_670
    {
    }

    /// <summary>
    /// Resource Authorization Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",FI,GS,LB,LM,MT,PQ,PR,ZZ,")]
    public class X12_ID_672
    {
    }

    /// <summary>
    /// Quantity Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,1A,1B,1C,1D,1E,1F,1G,1H" +
        ",1I,1J,1K,1L,1M,1N,1O,1P,1Q,1R,1S,1T,1U,1V,1W,1X,20,21,22,23,24,25,26,27,28,29,2" +
        "I,2T,2U,2W,2Y,2Z,30,31,32,33,34,35,36,37,38,39,3A,3B,3C,3D,3E,3F,3G,3H,3I,3J,3K," +
        "3L,3M,3N,3P,3Q,3R,3S,3T,3U,40,41,42,45,46,47,48,49,50,51,52,53,54,55,56,57,58,60" +
        ",61,62,63,64,65,66,67,68,69,70,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,8" +
        "8,89,90,91,92,93,94,95,96,97,98,99,A1,A2,A3,A4,A5,A7,A8,A9,AA,AB,AC,AD,AE,AF,AG," +
        "AH,AI,AJ,AK,AO,AP,AQ,AR,AS,AT,AU,AV,AW,AX,AY,AZ,B1,B2,B3,B4,B5,B6,B7,BA,BB,BC,BD" +
        ",BE,BF,BG,BI,BQ,BR,BW,C0,CA,CB,CD,CE,CF,CG,CH,CI,CL,CN,CO,CP,CR,CS,CW,D3,DA,DB,D" +
        "C,DE,DF,DG,DO,DP,DR,DT,DY,E1,E2,E3,E4,E5,EC,EM,EP,EQ,ER,ES,ET,EW,F1,FB,FC,FD,FE," +
        "FF,FG,FH,FI,FJ,FK,FL,FM,FR,FS,FT,GI,GL,GP,GQ,GR,GS,GT,GV,HM,HO,HP,HR,HS,II,IN,IP" +
        ",IQ,IT,JS,K6,KA,KB,KC,KD,KE,KF,KG,KH,KI,KJ,KK,KL,KM,KN,KO,KP,KQ,KR,KS,KU,KV,KW,K" +
        "X,KY,KZ,LA,LB,LE,LG,LH,LI,LK,LL,LM,LN,LO,LP,LQ,LR,LS,LT,LV,LW,LX,LY,M1,MA,ME,MI," +
        "MN,MO,MQ,MX,NA,NB,NC,NE,NF,NL,NN,NO,NP,NQ,NR,NS,NV,OD,OG,OH,OI,OO,OR,OT,OU,OV,OW" +
        ",P1,P3,P4,P5,P6,PA,PB,PC,PE,PF,PK,PL,PO,PP,PQ,PR,PS,PW,PX,Q1,Q2,QA,QB,QC,QD,QE,Q" +
        "F,QH,QO,QP,QR,QS,QU,QV,R3,RA,RB,RC,RD,RE,RF,RG,RH,RJ,RL,RN,RQ,RS,RW,S1,S2,S3,S4," +
        "S5,S6,S7,S8,S9,SA,SB,SC,SD,SE,SF,SG,SH,SI,SJ,SK,SL,SM,SN,SO,SP,SQ,SR,SS,ST,SU,SV" +
        ",SX,TA,TB,TC,TD,TE,TG,TH,TI,TJ,TK,TM,TN,TO,TP,TR,TS,TT,TU,TV,TW,TX,TY,UG,UL,UO,V" +
        "1,V2,V3,V4,VA,VC,VE,VG,VH,VI,VJ,VK,VL,VM,VR,VS,WA,WB,WC,WD,WE,WO,WP,WR,WT,WV,X1," +
        "XA,XB,XC,XD,XE,XG,XI,XJ,XL,XN,XO,XT,XU,XV,XX,XY,XZ,YA,YB,YC,YD,YE,YF,YG,YH,YJ,YK" +
        ",YL,YM,YN,YP,YQ,YR,YS,YT,YW,YX,YY,Z1,Z2,Z3,Z4,Z6,ZA,ZB,ZC,ZD,ZE,ZF,ZG,ZH,ZI,ZJ,Z" +
        "K,ZL,ZM,ZN,ZO,ZP,ZR,ZS,")]
    public class X12_ID_673
    {
    }

    /// <summary>
    /// Reciprocal Switch Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,O,Y,")]
    public class X12_ID_674
    {
    }

    /// <summary>
    /// Schedule Type Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AD,AS,BB,DL,JS,KB,PD,PR,PS,SH,ZZ,")]
    public class X12_ID_675
    {
    }

    /// <summary>
    /// Schedule Quantity Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,C,D,R,")]
    public class X12_ID_676
    {
    }

    /// <summary>
    /// Ship/Delivery or Calendar Pattern Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,J,K,L,M,N,O,P,Q,R,S,SG,SL,SP,SX,SY,SZ,T,U,V,W," +
        "X,Y,Z,")]
    public class X12_ID_678
    {
    }

    /// <summary>
    /// Ship/Delivery Pattern Time Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,Y,Z,")]
    public class X12_ID_679
    {
    }

    /// <summary>
    /// Forecast Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,K,L,M,N,P,Q,S,T,U,V,W,X,Z,")]
    public class X12_ID_680
    {
    }

    /// <summary>
    /// Forecast Timing Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,C,D,F,M,Q,S,T,W,X,Z,")]
    public class X12_ID_681
    {
    }

    /// <summary>
    /// Part Release Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,B,D,E,F,G,H,I,J,K,L,M,N,P,Q,R,S,T,U,W,X,Y,")]
    public class X12_ID_682
    {
    }

    /// <summary>
    /// Catalog Purpose Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CP,PC,PS,RC,SC,")]
    public class X12_ID_683
    {
    }

    /// <summary>
    /// Class of Trade Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AG,BG,BR,CB,CN,CO,CR,CX,CY,DE,DF,DI,DR,EX,FS,GA,GM,GR,GV,HS,ID,IN,IR,JB,LC,MC,MF" +
        ",ML,OE,OF,ON,PF,PH,PT,PY,RS,SE,ST,TR,WC,WH,WS,")]
    public class X12_ID_687
    {
    }

    /// <summary>
    /// Restrictions/Conditions Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",DO,DW,NR,NS,OR,SR,WO,")]
    public class X12_ID_688
    {
    }

    /// <summary>
    /// Occupancy Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,")]
    public class X12_ID_689
    {
    }

    /// <summary>
    /// Conveyance Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,Y,Z,")]
    public class X12_ID_692
    {
    }

    /// <summary>
    /// Docket Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,D,G,M,P,S,T,")]
    public class X12_ID_693
    {
    }

    /// <summary>
    /// Independence Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,I,L,")]
    public class X12_ID_695
    {
    }

    /// <summary>
    /// Action Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AC,AE,AP,CC,CD,CH,CP,DC,DD,DE,DF,FC,IN,PA,PC,PD,PR,PT,RA,RC,RE,RJ,RP,")]
    public class X12_ID_696
    {
    }

    /// <summary>
    /// Rate Distribution Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",P,S,U,")]
    public class X12_ID_698
    {
    }

    /// <summary>
    /// Commodity/Geographic Logical Connector Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",M,P,")]
    public class X12_ID_699
    {
    }

    /// <summary>
    /// Information Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,")]
    public class X12_ID_701
    {
    }

    /// <summary>
    /// Paperwork/Report Action Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,CH,CO,DM,NT,ON,OR,PV,SG,")]
    public class X12_ID_704
    {
    }

    /// <summary>
    /// Trade Union Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,")]
    public class X12_ID_705
    {
    }

    /// <summary>
    /// Entity Relationship Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,31" +
        ",32,33,34,35,36,37,38,39,40,41,")]
    public class X12_ID_706
    {
    }

    /// <summary>
    /// Rating Category Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AS,BA,BC,BE,C2,CH,CL,CO,CP,CR,CT,DP,DQ,DS" +
        ",EA,EC,EE,EI,FA,IF,IN,LT,PA,PC,PD,PF,PK,PR,PS,PT,PU,PY,RC,RO,RS,RT,SD,SE,SF,SN,S" +
        "P,SS,ST,TC,TR,TS,TT,UT,WR,WT,")]
    public class X12_ID_707
    {
    }

    /// <summary>
    /// Rating Summary Value Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,P,U,V,")]
    public class X12_ID_708
    {
    }

    /// <summary>
    /// Communications Environment Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",PP,SC,")]
    public class X12_ID_709
    {
    }

    /// <summary>
    /// Goods and Services Tax Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class X12_ID_714
    {
    }

    /// <summary>
    /// Functional Group Acknowledge Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,E,M,P,R,W,X,")]
    public class X12_ID_715
    {
    }

    /// <summary>
    /// Functional Group Syntax Error Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,3,4,5,6,")]
    public class X12_ID_716
    {
    }

    /// <summary>
    /// Transaction Set Acknowledgment Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,E,M,R,W,X,")]
    public class X12_ID_717
    {
    }

    /// <summary>
    /// Transaction Set Syntax Error Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,15,16,17,19,2,20,21,22,23,3,4,5,6,7,8,9,")]
    public class X12_ID_718
    {
    }

    /// <summary>
    /// Type of Service Offered Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",D,I,N,")]
    public class X12_ID_72
    {
    }

    /// <summary>
    /// Segment Syntax Error Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,")]
    public class X12_ID_720
    {
    }

    /// <summary>
    /// Data Element Syntax Error Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,2,3,4,5,6,7,8,9,")]
    public class X12_ID_723
    {
    }

    /// <summary>
    /// Real Estate Property Condition Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,")]
    public class X12_ID_726
    {
    }

    /// <summary>
    /// Returnable Container Load Make-Up Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,D,E,L,M,O,P,R,S,U,ZZ,")]
    public class X12_ID_728
    {
    }

    /// <summary>
    /// Compensation Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,F,")]
    public class X12_ID_73
    {
    }

    /// <summary>
    /// Transit Direction Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BS,SB,SC,SD,SF,SS,ZZ,")]
    public class X12_ID_731
    {
    }

    /// <summary>
    /// Transit Time Direction Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AD,CD,CW,HO,SD,SH,WD,WW,ZZ,")]
    public class X12_ID_732
    {
    }

    /// <summary>
    /// Hierarchical Level Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,34,35,36,37,38,4,5,56,6,7,8,9,A,AL,AS,B,BP,C,CB,CC,CE,CH,CI,CL,CN,CO,CT,D,DG,DP,E,ED,EL,EM,F,FC,FR,G,GC,H,I,IA,IB,IC,J,K,L,M,ML,NI,NS,O,OS,P,PA,PC,PD,PH,PL,PT,PY,Q,R,RA,RP,S,SA,SB,SC,SD,SE,SH,SI,SL,SP,SS,SY,T,U,UT,V,W,WB,X,Y,ZZ,")]
    public class X12_ID_735
    {
    }

    /// <summary>
    /// Hierarchical Child Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,")]
    public class X12_ID_736
    {
    }

    /// <summary>
    /// Measurement Reference ID Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",9L,AA,AE,AF,AG,AH,AI,AR,AV,BA,BC,BD,BL,BM,BN,BO,BP,BR,BT,BZ,C1,CA,CF,CH,CN,CO,CS,CT,CV,DE,DT,EA,EE,EF,EL,EN,FC,FD,FH,FJ,FV,FZ,HR,IN,IR,LC,LL,LM,LS,LT,MR,NC,NX,OD,OG,OL,P1,PA,PC,PD,PK,PL,PM,PO,PR,PS,PT,QR,R1,R2,RA,RG,RL,RN,RO,RP,RQ,RS,RT,SA,SD,SE,SF,SH,SK,SL,SM,SP,SR,ST,SU,TD,TE,TI,TL,TO,TP,TR,TS,WA,WT,ZP,")]
    public class X12_ID_737
    {
    }

    /// <summary>
    /// Measurement Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1F,2F,3A,3B,3C,3D,3E,3F,3G,3H,3I,3J,4F,5F,6F,7F,8F,A,A1,A2,A3,A4,A5,A6,A7,A9,AA," +
        "AAP,AB,ABO,ABR,ABS,AC,ACN,AD,ADH,AE,AF,AG,AGE,AH,AI,AJ,AK,AL,ALK,ALN,ALP,AMI,AMW" +
        ",AN,AOX,AP,API,APP,AS,ASH,ASY,AT,AVT,AZ,B,B1,B5,BA,BB,BC,BD,BDP,BE,BF,BG,BH,BHF," +
        "BHS,BIC,BJ,BK,BL,BN,BND,BO,BOR,BP,BQ,BR,BRS,BSW,BT,BU,BUD,BW,C,C0,C1,C2,C3,C4,CA" +
        ",CAU,CC,CCF,CD,CE,CF,CG,CGR,CH,CHA,CHC,CHG,CHL,CI,CIV,CJ,CK,CL,CLA,CLB,CLN,CM,CN" +
        ",CO,COH,COL,CON,COR,COS,COT,CP,CPF,CPS,CQ,CR,CS,CSC,CSR,CST,CT,CTG,CU,CUT,CW,CWT" +
        ",CX,CY,CYB,D,D1,D2,D3,D4,D5,D7,DA,DAT,DB,DC,DCT,DD,DE,DEM,DF,DG,DH,DI,DIR,DIS,DJ" +
        ",DL,DM,DME,DMF,DN,DP,DPM,DR,DRY,DS,DT,DU,DW,DWP,DY,E,E0,E1,EA,EB,EC,ED,EE,EF,EG," +
        "EH,EI,EJ,EL,ELC,ELE,ELI,ELL,ELO,ELP,ELS,ELT,ELV,ELW,ELX,EM,EN,EP,ES,EVL,EVR,EW,E" +
        "X,EXH,EXT,F,F1,F2,F3,F4,F5,F6,F7,F8,F9,FA,FB,FBP,FC,FD,FE,FF,FG,FH,FI,FIL,FIN,FI" +
        "T,FJ,FK,FL,FLD,FLN,FLP,FML,FMZ,FN,FNL,FNS,FOA,FOI,FOR,FP,FPV,FQ,FR,FS,FSI,FT,FU," +
        "FUD,FV,FW,FX,FY,FZ,G,G1,G2,G3,GA,GB,GC,GD,GE,GEL,GF,GG,GGR,GH,GI,GIR,GJ,GK,GL,GL" +
        "E,GM,GN,GO,GOR,GP,GQ,GR,GRA,GRI,GS,GT,GW,H1,H2O,H8,H9,HA,HAR,HAZ,HB,HC,HD,HE,HF," +
        "HG,HH,HHW,HI,HIB,HJ,HK,HL,HM,HO,HOC,HP,HR,HT,HTE,HVM,HWS,HYD,HZ,HZC,IB,IC,ID,IDE" +
        ",IF,IG,IGA,IGR,IH,II,IJ,IK,IM,IMP,IN,IND,INS,IO,IP,IPI,IQ,IR,IRA,IS,IT,IU,IV,IW," +
        "IX,IY,IZ,JA,JOM,KA,KB,KN,L,L0,L1,LA,LB,LC,LC5,LD,LD5,LDH,LE,LEF,LF,LG,LIR,LIV,LL" +
        ",LLD,LM,LN,LO,LOI,LOS,LOW,LP,LPG,LPR,LS,LSS,LT,LTD,LW,M,M1,M2,M3,M4,MA,MAT,MB,MC" +
        ",MCN,MD,ME,MEF,MEL,MER,MF,MG,MH,MI,MIC,MJ,MK,MM,MN,MO,MOI,MOR,MP,MPR,MQ,MR,MS,MT" +
        ",MTD,MU,MUL,MV,MW,MX,MY,N,NA,NB,NC,ND,NEU,NF,NG,NH,NI,NIL,NJ,NK,NL,NM,NNW,NO,NOC" +
        ",NON,NOR,NOX,NP,NS,NU,NV,O,O1,OA,OAP,OB,OBT,OC,OCG,OCR,OD,ODR,OE,OF,OG,OH,OI,OIL" +
        ",OJ,OK,OL,OLE,OM,ON,OO,OP,OQ,OR,ORC,OS,OT,OTE,OTH,OTT,OV,OW,OX,OXI,OXS,OY,P1,PA," +
        "PAR,PB,PBD,PC,PD,PDE,PDG,PE,PER,PF,PFO,PG,PH,PHA,PHW,PI,PIC,PJ,PK,PL,PM,PN,PO,PO" +
        "C,POD,POP,PP,PPS,PQ,PR,PRE,PRF,PRL,PRO,PRQ,PRY,PS,PSA,PSP,PSW,PT,PU,PV,PW,PWA,PW" +
        "E,PWF,PX,PY,PZ,QA,QB,QC,QD,QE,QF,QL,QUR,R,R1,R10,R18,R2,R3,R4,RA,RAD,RAF,RB,RC,R" +
        "D,RE,REA,RED,REF,REI,REL,RES,RF,RG,RH,RI,RJ,RK,RL,RM,RN,RO,ROX,RP,RQ,RR,RS,RSZ,R" +
        "T,RTB,RU,RUD,RV,RVP,RW,RX,RY,S,S1,S10,S12,S18,S2,S3,S4,S5,S6,S7,S8,S9,SA,SAP,SB," +
        "SC,SCH,SD,SE,SEV,SF,SG,SH,SHA,SI,SIL,SJ,SK,SL,SLD,SLI,SM,SN,SO,SOD,SOF,SP,SPG,SP" +
        "R,SQ,SR,SS,ST,STA,STL,STP,SU,SUM,SUR,SUT,SV,SVL,SW,SX,SXX,SY,SZ,T,T1,T2,T3,T50,T" +
        "90,TA,TAS,TB,TC,TD,TDP,TE,TEE,TES,TEX,TF,TG,TH,TI,TJ,TK,TL,TM,TN,TO,TOA,TOR,TOX," +
        "TP,TPF,TPL,TPQ,TPS,TQ,TR,TRA,TRC,TRN,TS,TSZ,TT,TU,TUR,TV,TVD,TW,TX,TY,U,UA,UCB,U" +
        "G,UNI,UNK,VAD,VAP,VH,VIN,VIS,VO,VOC,VOL,VOT,VOV,VOW,VSO,VW,VWT,WA,WB,WC,WD,WDE,W" +
        "E,WEL,WF,WH,WI,WL,WM,WOD,WPF,WPL,WPS,WR,WRA,WT,WTB,WU,WX,X,XA,XH,XP,XQ,XZ,YA,YB," +
        "YC,ZA,ZAL,ZAS,ZB,ZBI,ZBT,ZBZ,ZC,ZCA,ZCB,ZCD,ZCE,ZCO,ZCR,ZCU,ZD,ZET,ZF,ZFE,ZFL,ZF" +
        "S,ZG,ZGE,ZH,ZHP,ZHS,ZHX,ZIB,ZIP,ZMG,ZMN,ZMO,ZMT,ZN,ZNB,ZNI,ZNP,ZO,ZOC,ZP,ZPB,ZPP" +
        ",ZPT,ZR,ZS,ZSB,ZSE,ZSI,ZSN,ZTA,ZTB,ZTE,ZTI,ZV,ZW,ZZN,ZZR,ZZZ,")]
    public class X12_ID_738
    {
    }

    /// <summary>
    /// Returnable Container Freight Payment Responsibility Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,F,S,Z,")]
    public class X12_ID_743
    {
    }

    /// <summary>
    /// Print Option Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CN,DI,EN,MV,PN,RN,SN,TN,UF,VN,WN,XY,")]
    public class X12_ID_744
    {
    }

    /// <summary>
    /// Pre-Cooled (Rule 710) Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",Y,")]
    public class X12_ID_745
    {
    }

    /// <summary>
    /// Rebill Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",RB,RC,RD,")]
    public class X12_ID_747
    {
    }

    /// <summary>
    /// Movement Authority Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,DS,E,G,HM,I,L,M,N,NC,NU,O,OA,OS,P,R,RB,S,T,W,X,")]
    public class X12_ID_748
    {
    }

    /// <summary>
    /// Supplementary Information Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BLC,CIR,COA,COM,CON,CTP,CUS,DOM,EXP,FUM,INS,IPI,LOC,MSD,OBV,ONR,ORI,PAK,QAL,SAN," +
        "SED,SPI,SWB,")]
    public class X12_ID_749
    {
    }

    /// <summary>
    /// Product/Process Characteristic Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,25,28,29,30,32,33,34,35,36,37,38,39,40,41,42,43,54,55,56,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,99,9A,9B,9C,9D,AF,AG,AGE,AT,B8,BC,BCC,BES,BEV,BLM,BND,BPI,BRG,BW,C2,C3,C4,C5,C6,CCN,CD,CFC,CH,CHF,CL,CLT,CM,CMS,CP,CS,CU,CW,DAC,DAF,DE,DF,DIR,DM,EC,EN,FA,FC,FCD,FDD,FL,FLV,FMR,FQ,GD,GEN,GM,HB,HY,HZ,HZR,ING,INJ,KI,LO,MA,MAC,MB,MBU,MS,MSG,NH,OC,OD,ODR,OR,OT,P6,PD,PF,PFA,PFC,PFG,PFI,PFK,PFL,PFM,PFN,PFP,PFS,PFT,PG,PP,PR,PRI,PRO,PSC,PUB,PUR,QAS,R3,RA,RCC,RSD,RSE,RX,SC,SEC,SIZ,SLM,SOL,STL,SYN,TC,TE,TF,THR,TIF,TIR,TP,TR,TRN,TWF,TZ,VA,VC,VI,WD,WF,WLC,WT,WTT,")]
    public class X12_ID_750
    {
    }

    /// <summary>
    /// Surface/Layer/Position Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1S,2S,AL,AS,BC,BK,BL,BR,BS,BT,CH,CT,DT,DU,FR,FS,GF,IN,KB,LO,LT,MD,NT,OA,OS,OT,R0,R1,R2,R3,R4,R5,R6,R7,R8,R9,RA,RB,RC,RD,RE,RF,RG,RH,RI,RJ,RK,RL,RM,RN,RO,RP,RQ,RR,RS,RT,RU,RV,RW,RX,RY,RZ,S1,S2,S3,S4,S5,S6,S7,S8,S9,SA,SB,SC,SD,SE,SF,SN,SP,SS,ST,SU,TB,TP,TS,UC,UP,UT,WF,")]
    public class X12_ID_752
    {
    }

    /// <summary>
    /// Packaging Characteristic Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,10,11,12,13,34,35,36,37,38,39,40,42,43,44,45,60,61,62,63,65,66,67,68,CB,CC,CD" +
        ",CS,CT,CUD,HM,IC,IP,LP,OPI,PK,PM,PML,PN,SMK,UC,UCL,UP,WM,")]
    public class X12_ID_753
    {
    }

    /// <summary>
    /// Report Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,03,11,12,13,14,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,A1,A2,A3,A4,AA,AB,AC,AD,AE,AF,AG,AM,AO,AP,AR,AS,AT,AU,AV,AW,AX,B1,BA,BB,BC,BE,BL,BM,BN,BO,BR,BS,BT,BW,BY,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CQ,CR,CS,CT,CU,CW,CX,CY,CZ,D2,DA,DB,DC,DD,DE,DF,DG,DH,DI,DJ,DK,DL,DM,DN,DQ,DR,DS,DT,DW,E1,EA,EB,EC,ED,EL,EP,ER,EX,EY,F1,F2,F3,F4,F5,F6,F7,F8,F9,FB,FC,FD,FE,FH,FI,FM,FS,GP,GT,HC,HR,HW,I2,I3,I4,I5,I6,IA,IC,IM,IN,IP,IR,IS,IT,IU,IV,KA,KC,KD,KE,KF,KG,KH,KI,KJ,LA,LB,LC,LD,LE,LG,LI,LO,LP,LR,LS,LT,LW,M1,MA,MB,MC,MD,ME,MF,MG,MI,MM,MN,MO,MR,MS,MT,MV,NA,NC,ND,NI,NL,NM,NN,NO,NQ,NR,NT,OB,OC,OD,OE,OL,OP,OR,OS,OT,OX,OZ,P1,P2,P3,P4,P5,P6,P7,P8,PA,PB,PC,PD,PE,PF,PG,PH,PI,PJ,PK,PL,PM,PN,PO,PP,PR,PS,PT,PV,PW,PX,PY,PZ,QC,QD,QE,QM,QR,QS,QT,R1,R2,RA,RB,RC,RD,RE,RF,RM,RN,RO,RR,RT,RV,RX,S1,S2,S3,S4,S5,S6,S7,S8,S9,SA,SB,SC,SD,SE,SF,SG,SH,SI,SL,SM,SN,SO,SP,SQ,SR,SS,ST,SU,SV,SW,SX,T1,T2,T3,T4,T5,T6,TA,TB,TC,TD,TE,TF,TH,TI,TJ,TK,TL,TM,TN,TO,TP,TQ,TR,TS,TT,TX,U1,UA,US,VA,VC,VD,VM,W1,W2,WB,WI,WP,WT,X1,X2,X3,X4,X5,XE,XP,Y1,Y2,Y3,ZB,")]
    public class X12_ID_755
    {
    }

    /// <summary>
    /// Report Transmission Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,AC,AE,AM,AS,AT,AU,BE,BM,BW,CF,DA,EL,FX,GS,HL,IA,IE,IM,MB,MN,NS" +
        ",PO,SE,SM,SN,TE,TM,TX,VO,WS,")]
    public class X12_ID_756
    {
    }

    /// <summary>
    /// Reportable Quantity Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",RQ,")]
    public class X12_ID_759
    {
    }

    /// <summary>
    /// Limited Quantity Indication Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",Y,")]
    public class X12_ID_760
    {
    }

    /// <summary>
    /// Waybill Response Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,C,D,E,M,N,O,R,S,T,U,W,")]
    public class X12_ID_762
    {
    }

    /// <summary>
    /// Market Area Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",001,002,003,004,005,006,007,008,009,010,011,012,")]
    public class X12_ID_771
    {
    }

    /// <summary>
    /// Interchange Agreement Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",E,H,N,")]
    public class X12_ID_772
    {
    }

    /// <summary>
    /// Container Type Request Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,R,S,W,")]
    public class X12_ID_78
    {
    }

    /// <summary>
    /// Planning Schedule Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",MM,MN,MP,OS,OT,PM,PS,SO,ST,TO,TS,TT,XA,XF,")]
    public class X12_ID_783
    {
    }

    /// <summary>
    /// Security Level Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",00,01,02,03,04,05,06,09,11,20,21,90,92,93,94,99,")]
    public class X12_ID_786
    {
    }

    /// <summary>
    /// Entity Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,J,K,L,M,N,Z,")]
    public class X12_ID_792
    {
    }

    /// <summary>
    /// Revision Level Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,Z,")]
    public class X12_ID_795
    {
    }

    /// <summary>
    /// Security Technique Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",9A,9E,9N,OC,ZZ,")]
    public class X12_ID_797
    {
    }

    /// <summary>
    /// Bank Client Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",E,R,")]
    public class X12_ID_8
    {
    }

    /// <summary>
    /// Hazardous Material Shipment Information Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",ADI,D13,DWW,EMS,HOT,HZC,INH,LQY,MFA,MOS,MPI,PIH,POI,RAM,TEC,TNM,")]
    public class X12_ID_808
    {
    }

    /// <summary>
    /// Obligation Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AI,AL,AY,BL,CC,ED,FC,FD,FR,HR,ML,OO,PI,RC,RX,SL,UT,ZZ,")]
    public class X12_ID_811
    {
    }

    /// <summary>
    /// Payment Format Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BPT,CBC,CBP,CCD,CCP,CTP,CTX,PBC,PPD,PPP,PRD,")]
    public class X12_ID_812
    {
    }

    /// <summary>
    /// Station Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,H,I,J,M,N,O,R,S,W,")]
    public class X12_ID_813
    {
    }

    /// <summary>
    /// Nesting Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,T,")]
    public class X12_ID_814
    {
    }

    /// <summary>
    /// Property Inspection Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",DE,DR,EX,GR,HT,IN,LO,NB,PL,SH,SP,WI,ZZ,")]
    public class X12_ID_815
    {
    }

    /// <summary>
    /// Occupancy Verification Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",DI,JU,NB,NM,OM,RE,TE,TN,VI,ZZ,")]
    public class X12_ID_816
    {
    }

    /// <summary>
    /// Report Section Name Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AM,AP,CA,CI,CM,CO,DI,DM,DS,EI,EN,EO,EP,FA,FE,HH,HI,IA,KY,MI,MS,PD,PM,PR,RE,RG,SH" +
        ",SL,ST,TS,TX,")]
    public class X12_ID_820
    {
    }

    /// <summary>
    /// Safety Characteristic/Hazard Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",ACT,AM2,AP2,CAR,CI2,CO2,CON,CTD,DCL,DEC,DEH,DI2,DIS,DM2,EDD,EFA,EFB,EFX,EIM,EN2,ENA,ENB,ENG,ENO,ENS,EO2,EP2,EPA,ESD,EVP,EXC,EXI,EXL,EYA,EYC,EYF,EYZ,FA2,FAA,FAL,FAS,FAT,FAZ,FE2,FEH,FEZ,FLC,GCA,GMA,GPI,HAI,HCA,HCP,HH2,HHA,HI2,HZC,HZR,IA2,IGA,IGC,IGZ,IHA,IHC,IHZ,INC,INS,INX,IRR,KY2,LAB,LKI,MAT,MCE,MUT,NOT,NTE,NTR,NTS,NTZ,OPH,OPR,ORC,PD2,PM2,POL,PPA,PPB,PPC,PPD,PPE,PPF,PPG,PPR,PPS,PPZ,PR2,PRE,PRF,PRG,PRH,PRI,PRJ,PRK,PRL,PRM,PRO,PRQ,PRS,PRT,PRU,PRZ,RE2,REA,REC,REP,RG2,RLI,RTK,SAP,SBY,SCE,SGW,SH2,SHI,SKA,SKC,SKS,SKT,SKZ,SL2,SNS,SPF,SPI,SPJ,SPL,SPP,ST2,STA,SYP,SYS,TER,TOC,TOG,TRH,TS2,TX2,VRZ,WDI,")]
    public class X12_ID_821
    {
    }

    /// <summary>
    /// Fuel Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,D,E,G,P,")]
    public class X12_ID_829
    {
    }

    /// <summary>
    /// Licensing Agency Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,D,E,F,G,I,J,M,N,P,S,T,")]
    public class X12_ID_83
    {
    }

    /// <summary>
    /// Inspection Location Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,90,96,97,98,99,")]
    public class X12_ID_831
    {
    }

    /// <summary>
    /// Supplemental Inspection Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",Y,")]
    public class X12_ID_835
    {
    }

    /// <summary>
    /// Vehicle Deck Position Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A1,A2,A3,A4,A5,A6,A7,B1,B2,B3,B4,B5,B6,B7,C1,C2,C3,C4,C5,C6,C7,")]
    public class X12_ID_836
    {
    }

    /// <summary>
    /// Vehicle Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,C,I,M,T,V,X,")]
    public class X12_ID_837
    {
    }

    /// <summary>
    /// Inbound Condition Hold Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,")]
    public class X12_ID_844
    {
    }

    /// <summary>
    /// Chassis Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",8P,DF,FB,GN,SF,SL,TX,")]
    public class X12_ID_845
    {
    }

    /// <summary>
    /// Contract Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AC,CA,CC,CL,CM,CR,CX,DL,EX,IN,NB,OC,PP,PR,RO,SC,TR,VA,")]
    public class X12_ID_846
    {
    }

    /// <summary>
    /// Order/Item Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AO,CA,CI,CO,PA,PI,PO,PP,")]
    public class X12_ID_847
    {
    }

    /// <summary>
    /// Product/Date Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",PD,SD,SP,")]
    public class X12_ID_848
    {
    }

    /// <summary>
    /// Location Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",SB,SL,SS,")]
    public class X12_ID_849
    {
    }

    /// <summary>
    /// Status Report Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,2,3,4,5,6,7,8,9,")]
    public class X12_ID_850
    {
    }

    /// <summary>
    /// Address Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,C,M,T,")]
    public class X12_ID_852
    {
    }

    /// <summary>
    /// Damage Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BD,CC,CD,DL,DP,FL,HD,ID,IL,IU,LD,LS,NO,NR,PP,PS,SF,TE,UE,VI,WC,")]
    public class X12_ID_853
    {
    }

    /// <summary>
    /// Vessel Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BC,BD,BI,BK,BL,BO,CB,CT,DG,DP,FH,GC,GT,MT,PC,PS,RR,SP,TG,VH,")]
    public class X12_ID_854
    {
    }

    /// <summary>
    /// Peg Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,T,")]
    public class X12_ID_855
    {
    }

    /// <summary>
    /// Rate Level Qualifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,I,Z,")]
    public class X12_ID_856
    {
    }

    /// <summary>
    /// Activity Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BS,BT,DG,HL,MS,OF,OP,Q1,Q2,Q3,QA,QB,QC,QD,QE,QF,QH,QI,QK,QL,QM,QN,QO,QP,QR,QS,QT" +
        ",QU,QW,QX,QZ,RE,TS,WQ,")]
    public class X12_ID_859
    {
    }

    /// <summary>
    /// Initiator Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",R,S,")]
    public class X12_ID_868
    {
    }

    /// <summary>
    /// Maintenance Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",001,002,003,004,005,006,007,008,009,010,012,013,014,015,021,022,023,024,025,026,028,029,030,032,050,051,052,053,054,055,056,057,058,059,060,061,062,063,064,065,066,067,068,069,070,071,072,073,074,075,076,077,078,079,080,081,082,083,100,101,102,104,105,106,107,108,109,110,111,112,113,114,115,116,117,118,119,120,121,122,123,124,125,126,ZZZ,")]
    public class X12_ID_875
    {
    }

    /// <summary>
    /// Marks and Numbers Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AI,CA,CP,DZ,GM,L,MC,PB,R,S,SI,SM,SR,SS,UC,W,ZZ,")]
    public class X12_ID_88
    {
    }

    /// <summary>
    /// Pallet Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,")]
    public class X12_ID_883
    {
    }

    /// <summary>
    /// Nonconformance Report Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CL,FI,OC,OD,OI,OS,OT,RE,RV,")]
    public class X12_ID_886
    {
    }

    /// <summary>
    /// Nonconformance Resultant Response Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CA,FR,HE,IN,P,RE,RJ,RP,RQ,RS,RT,RW,SC,UA,UC,")]
    public class X12_ID_887
    {
    }

    /// <summary>
    /// Nonconformance Determination Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,N,Y,")]
    public class X12_ID_888
    {
    }

    /// <summary>
    /// Follow-up Action Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,D,E,N,P,R,S,W,X,Y,")]
    public class X12_ID_889
    {
    }

    /// <summary>
    /// Carrier/Route Change Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,ZZ,")]
    public class X12_ID_890
    {
    }

    /// <summary>
    /// Shipping Date Change Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,ZZ,")]
    public class X12_ID_891
    {
    }

    /// <summary>
    /// Line Item Change Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,20,21,22,23,24,25,26,ZZ,")]
    public class X12_ID_892
    {
    }

    /// <summary>
    /// Warehouse Detail Adjustment Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class X12_ID_893
    {
    }

    /// <summary>
    /// Batch Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,09,10,11,12,13,")]
    public class X12_ID_894
    {
    }

    /// <summary>
    /// Vessel Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,C,L,Z,")]
    public class X12_ID_897
    {
    }

    /// <summary>
    /// Incentive Grain Rate Indicator Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class X12_ID_898
    {
    }

    /// <summary>
    /// Late Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,C1,D1,D2,D3,D4,D5,D6,E1,E2,E3,E4,E5,E6,L1,L2,L3,L4,L5,L6,L7,L8,L9,LA,")]
    public class X12_ID_9
    {
    }

    /// <summary>
    /// Measurement Unit Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,E,N,X,")]
    public class X12_ID_90
    {
    }

    /// <summary>
    /// Reject Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,95,96,97,98,E1,E2,E3,E4,E5,E6,E7,E8,T1,T2,T3,T4,T5,T6,ZZ,")]
    public class X12_ID_901
    {
    }

    /// <summary>
    /// Section Designator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",D,H,N,S,")]
    public class X12_ID_902
    {
    }

    /// <summary>
    /// Envelope Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",H,N,T,")]
    public class X12_ID_903
    {
    }

    /// <summary>
    /// Requirement Designator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,F,M,N,O,R,")]
    public class X12_ID_904
    {
    }

    /// <summary>
    /// Level Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,3,")]
    public class X12_ID_906
    {
    }

    /// <summary>
    /// Transportation Method/Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",6,7,A,AC,AE,AF,AH,AQ,AR,B,BP,BU,C,CE,D,DA,DW,E,ED,F,FA,FL,GG,GR,GS,H,I,J,K,L,LA," +
        "LT,M,MB,MP,N,O,P,PA,PG,PL,PP,PR,PT,Q,R,RC,RR,S,SB,SC,SD,SE,SR,SS,ST,T,TA,TC,U,VA" +
        ",VE,VL,W,WP,X,Y,Y1,Y2,ZZ,")]
    public class X12_ID_91
    {
    }

    /// <summary>
    /// Relation Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,E,L,P,R,")]
    public class X12_ID_912
    {
    }

    /// <summary>
    /// Data Element Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AN,B,DT,ID,N0,N1,N2,N3,N4,N5,N6,N7,N8,N9,R,TM,")]
    public class X12_ID_913
    {
    }

    /// <summary>
    /// Purchase Order Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AB,AC,AO,BD,BE,BH,BK,BL,BQ,BY,CA,CC,CF,CN,CO,CP,CR,DR,DS,EO,FH,IN,JL,KA,KB,KC,KD" +
        ",KE,KG,KI,KN,KO,KP,KQ,KR,KS,KT,LB,LS,NE,NO,NP,NS,OS,PR,RA,RE,RL,RN,RO,RR,RT,RU,R" +
        "W,SA,SO,SP,SS,ST,SW,TC,TM,TR,UD,UE,US,WO,ZZ,")]
    public class X12_ID_92
    {
    }

    /// <summary>
    /// Discipline Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AI,MS,OT,PT,SN,ST,")]
    public class X12_ID_921
    {
    }

    /// <summary>
    /// Electronic Form Standards Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",I,T,X,")]
    public class X12_ID_922
    {
    }

    /// <summary>
    /// Prognosis Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,")]
    public class X12_ID_923
    {
    }

    /// <summary>
    /// Full or Partial Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",F,P,")]
    public class X12_ID_924
    {
    }

    /// <summary>
    /// Damage Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,")]
    public class X12_ID_927
    {
    }

    /// <summary>
    /// Printer Carriage Control Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AT,DS,LC,NP,NS,SS,")]
    public class X12_ID_934
    {
    }

    /// <summary>
    /// Measurement Significance Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27" +
        ",28,29,30,31,32,34,35,36,37,38,39,40,41,42,43,44,45,46,")]
    public class X12_ID_935
    {
    }

    /// <summary>
    /// Measurement Attribute Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27" +
        ",28,29,40,41,42,44,45,46,48,49,50,51,52,Q1,Q2,TA,")]
    public class X12_ID_936
    {
    }

    /// <summary>
    /// Test Administration Method Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,11,12,AG,CT,FL,MA,ME,PC,PO,SB,SP,")]
    public class X12_ID_937
    {
    }

    /// <summary>
    /// Test Medium Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,")]
    public class X12_ID_938
    {
    }

    /// <summary>
    /// Sample Process Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,")]
    public class X12_ID_939
    {
    }

    /// <summary>
    /// Sample Selection Method Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,")]
    public class X12_ID_940
    {
    }

    /// <summary>
    /// Sample Description Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,")]
    public class X12_ID_943
    {
    }

    /// <summary>
    /// Sample Direction Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,")]
    public class X12_ID_944
    {
    }

    /// <summary>
    /// Position Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,30,31,32" +
        ",33,34,")]
    public class X12_ID_945
    {
    }

    /// <summary>
    /// Statistic Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27" +
        ",28,29,30,31,32,33,34,AD,CF,CS,HG,KS,SK,SW,ZZ,")]
    public class X12_ID_950
    {
    }

    /// <summary>
    /// Balance Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,AM,C,CD,M,N,P,Q,Y,")]
    public class X12_ID_951
    {
    }

    /// <summary>
    /// Adjustment Application Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",F,L,S,")]
    public class X12_ID_952
    {
    }

    /// <summary>
    /// Tax Jurisdiction Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CD,VD,VE,")]
    public class X12_ID_955
    {
    }

    /// <summary>
    /// Payment Cancellation Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CAN,IND,")]
    public class X12_ID_959
    {
    }

    /// <summary>
    /// Request for Quote Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,BF,CB,")]
    public class X12_ID_960
    {
    }

    /// <summary>
    /// Receiving Advice or Acceptance Certificate Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,R,")]
    public class X12_ID_962
    {
    }

    /// <summary>
    /// Tax Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BP,CA,CG,CI,CP,CR,CS,CT,CV,ET,EV,F1,F2,F3,FD,FF,FI,FL,FR,FS,FT,GR,GS,HS,HT,LO,LS" +
        ",LT,LU,LV,MP,MT,OT,PG,PS,SA,SC,SE,SF,SL,SP,SR,ST,SU,SX,T1,T2,TD,TT,TX,UL,UT,VA,W" +
        "S,ZA,ZB,ZC,ZD,ZE,ZZ,")]
    public class X12_ID_963
    {
    }

    /// <summary>
    /// Cost Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",FNC,HAN,LAB,MTL,OCT,OTH,OVR,PKG,RMP,RMU,SET,TDI,TGA,TLN,TML,TMP,TOL,TPU,TTL,")]
    public class X12_ID_964
    {
    }

    /// <summary>
    /// Rate Basis Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,")]
    public class X12_ID_969
    {
    }

    /// <summary>
    /// Tariff Reference Flag
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",R,")]
    public class X12_ID_974
    {
    }

    /// <summary>
    /// Tariff Restriction ID Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,")]
    public class X12_ID_976
    {
    }

    /// <summary>
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,0H,10,11,12,13,14,15,16,17,18,19,1A,1B,1C,1D,1E,1F,1G" +
        ",1H,1I,1J,1K,1L,1M,1N,1O,1P,1Q,1R,1S,1T,1U,1V,1W,1X,1Y,1Z,20,21,22,23,24,25,26,2" +
        "7,28,29,2A,2B,2C,2D,2E,2F,2G,2H,2I,2J,2K,2L,2M,2N,2O,2P,2Q,2R,2S,2T,2U,2V,2W,2X," +
        "2Y,2Z,30,31,32,33,34,35,36,37,38,39,3A,3B,3C,3D,3E,3F,3G,3H,3I,3J,3K,3L,3M,3N,3O" +
        ",3P,3Q,3R,3S,3T,3U,3V,3W,3X,3Y,3Z,40,41,42,43,44,45,46,47,48,49,4A,4B,4C,4D,4E,4" +
        "F,4G,4H,4I,4J,4K,4L,4M,4N,4O,4P,4Q,4R,4S,4T,4U,4V,4W,4X,4Y,4Z,50,51,52,53,54,55," +
        "56,57,58,59,5A,5B,5C,5D,5E,5F,5G,5H,5I,5J,5K,5L,5M,5N,5O,5P,5Q,5R,5S,5T,5U,5V,5W" +
        ",5X,5Y,5Z,60,61,62,63,64,65,66,67,68,69,6A,6B,6C,6D,6E,6F,6G,6H,6I,6J,6K,6L,6M,6" +
        "N,6O,6P,6Q,6R,6S,6T,6U,6V,6W,6X,6Y,70,71,72,73,74,75,76,77,78,79,7A,7B,7C,7D,7E," +
        "7G,7H,7L,7M,7N,7P,7Q,7S,7V,80,81,82,83,84,85,86,87,88,89,8A,8B,8C,8D,8E,8F,8G,8H" +
        ",8I,8J,8K,8M,8N,8O,8P,8Q,8R,8S,8U,8Z,90,91,92,93,94,95,96,97,98,99,9A,9B,9C,9D,9" +
        "E,9F,9G,9H,9J,9K,9L,9N,9O,9P,9Q,9R,9S,9U,9V,9X,9Y,9Z,A1,A2,A3,A4,A5,A6,A7,A8,A9," +
        "AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,AX,AY,AZ,B1" +
        ",B2,B3,B4,B5,B6,B7,B8,B9,BA,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BO,BP,BQ,BR,B" +
        "S,BT,BU,BV,BW,BX,BY,BZ,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ," +
        "CK,CL,CM,CN,CO,CP,CQ,CR,CS,CT,CU,CV,CW,CX,CY,CZ,D1,D2,D3,D4,D5,D6,D7,D8,D9,DA,DB" +
        ",DC,DD,DE,DF,DG,DH,DI,DJ,DK,DL,DM,DN,DO,DP,DQ,DR,DS,DT,DU,DV,DW,DX,DY,DZ,E1,E2,E" +
        "3,E4,E5,E6,E7,E8,EB,EC,ED,EE,EF,EG,EH,EI,EL,EM,EN,EP,ES,EX,EY,F1,F2,F3,F4,F5,F6," +
        "F7,F8,F9,FA,FB,FC,FD,FE,FF,FG,FH,FI,FJ,FK,FL,FM,FN,FO,FP,FR,FS,FW,G0,G2,G3,G5,G6" +
        ",G7,G8,G9,GA,GB,GC,GD,GE,GF,GG,GH,GI,GJ,GK,GL,GM,GN,GO,GP,GQ,GR,GS,GT,GU,GV,GW,G" +
        "X,GY,H1,H2,H3,H4,H5,H6,H8,HA,HB,HC,HD,HE,HF,HH,HS,I1,I3,I4,IA,IB,IC,ID,IE,II,IJ," +
        "IK,IL,IM,IN,IO,IP,IR,IS,IT,IU,JA,JB,JC,JD,JE,JF,JG,JH,JI,JJ,JK,JL,JM,JN,JO,JP,JQ" +
        ",JR,JS,JT,JU,JV,JW,K1,K2,K3,K4,K5,K7,K8,KA,KB,KC,KD,KF,KG,KH,KI,KK,KL,KM,KN,KO,K" +
        "P,KQ,KR,KS,KT,KU,KV,KW,KX,KY,KZ,L1,L2,LA,LB,LC,LD,LE,LF,LG,LH,LI,LJ,LL,LM,LN,LO," +
        "LP,LQ,LR,LS,LT,LV,LW,LZ,M1,M2,M3,M4,M5,M6,M7,M8,M9,MA,MB,MC,MD,ME,MF,MG,MH,MI,MJ" +
        ",MK,ML,MM,MN,MO,MP,MQ,MR,MS,MT,MU,MV,MW,MX,MY,N1,N2,N3,N4,N5,N6,N7,N8,N9,NB,NC,N" +
        "D,NE,NG,NH,NI,NJ,NK,NN,NP,NQ,NR,NS,NT,NU,NV,NW,NY,OA,OB,OC,OD,OE,OF,OG,OH,OI,OK," +
        "OM,ON,OO,OP,OR,OS,OT,OU,OV,OW,OX,OY,OZ,P0,P1,P2,P3,P4,P5,P6,P7,P8,P9,PA,PB,PC,PD" +
        ",PE,PF,PG,PH,PI,PJ,PK,PL,PM,PN,PO,PP,PQ,PR,PS,PT,PU,PV,PW,PX,PY,PZ,Q1,Q2,Q3,Q4,Q" +
        "5,QA,QB,QC,QD,QE,QF,QG,QH,QI,QP,QQ,QR,QZ,R1,R2,R3,R4,R5,R6,R7,R8,R9,RA,RB,RC,RD," +
        "RE,RF,RG,RH,RI,RJ,RK,RL,RM,RN,RO,RP,RQ,RR,RS,RT,RU,RV,RW,RX,RY,RZ,S1,S2,S3,S4,S5" +
        ",S6,S7,S8,SA,SB,SC,SD,SE,SF,SG,SH,SI,SJ,SK,SL,SM,SN,SO,SP,SQ,SR,SS,ST,SU,SV,SW,S" +
        "X,SY,SZ,T1,T2,T3,T4,T5,T6,T7,T8,T9,TA,TB,TC,TD,TE,TF,TG,TH,TI,TJ,TK,TL,TM,TN,TO," +
        "TP,TQ,TR,TS,TT,TU,TV,TW,TX,TY,TZ,U1,U2,U3,U6,UA,UB,UC,UD,UN,UP,US,UT,VC,VN,VP,VS" +
        ",W1,W2,WA,WB,WC,WD,WE,WF,WG,WH,WI,WJ,WL,WN,WO,WP,WR,WT,X1,X2,X3,X4,X5,XA,XB,XC,X" +
        "D,XE,XF,XG,XI,XP,XQ,XR,XS,XU,XX,XY,XZ,YA,YB,YC,YD,YE,YF,YG,YH,YI,YJ,YK,YL,YM,YN," +
        "YO,YP,YQ,YR,YS,YT,YU,YV,YW,Z1,Z2,Z3,Z4,Z5,Z6,Z7,Z8,ZA,ZB,ZC,ZD,ZE,ZG,ZI,ZK,ZL,ZM" +
        ",ZN,ZO,ZP,ZQ,ZR,ZS,ZT,ZU,ZV,ZZ,")]
    public class X12_ID_98
    {
    }

    /// <summary>
    /// Tariff Section ID Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AC,AT,BF,BS,CA,SR,ZA,ZB,")]
    public class X12_ID_980
    {
    }

    /// <summary>
    /// Tariff Value Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AC,AM,CH,HA,HR,HU,II,MA,MH,MI,MN,NO,PA,RB,SE,SH,ST,TN,VE,")]
    public class X12_ID_981
    {
    }

    /// <summary>
    /// Data Source Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,03,05,07,09,")]
    public class X12_ID_982
    {
    }

    /// <summary>
    /// Hazardous Class Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",P,S,")]
    public class X12_ID_983
    {
    }

    /// <summary>
    /// Hazardous Material Shipping Name Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,D,I,")]
    public class X12_ID_984
    {
    }

    /// <summary>
    /// N.O.S. Indicator Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",NOS,")]
    public class X12_ID_985
    {
    }

    /// <summary>
    /// Special Commodity Indicator Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",S,")]
    public class X12_ID_986
    {
    }

    /// <summary>
    /// Cryptographic Service Message (CSM) Message Class Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",DSM,ERS,ESM,KSM,RFS,RSI,RSM,RTR,")]
    public class X12_ID_987
    {
    }

    /// <summary>
    /// Cryptographic Service Message (CSM) Field Tag
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CTA,CTB,CTP,CTR,EDC,ERF,IDA,IDC,IDD,IDU,KD,KDU,KK,KKU,MAC,NOS,PKK,PKKU,SUBF,SVR," +
        "TID,")]
    public class X12_ID_988
    {
    }

    /// <summary>
    /// Delayed Repayment Qualifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class X12_ID_998
    {
    }

    /// <summary>
    /// Interchange Action Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AK,BH,DL,PU,RD,RF,RJ,RT,TR,")]
    public class X12_ID_I40
    {
    }

    /// <summary>
    /// Error Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",000,001,002,003,004,005,006,007,008,009,010,011,012,013,014,015,016,017,018,019," +
        "020,021,022,023,024,025,026,027,028,029,030,031,032,033,")]
    public class X12_ID_I43
    {
    }
}
