namespace EdiFabric.Templates.X12003040
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
    [EdiCodes(",05,06,07,08,09,1,10,11,14,15,16,17,18,19,2,3,4,AN,DF,DY,EF,KA,KB,LM,MN,PF,PH,PM," +
        "PN,PP,PR,WK,")]
    public class X12_ID_1004
    {
    }

    /// <summary>
    /// Hierarchical Structure Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0001,0002,0003,0010,0011,0012,0013,0014,0015,0016,0017,0018,0019,0035,0036,0056," +
        "0057,0058,0059,0060,0061,0062,0063,0064,0065,0066,0067,0068,0069,0070,0071,0072," +
        "0073,0074,0075,0076,0077,")]
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
    [EdiCodes(",N,R,S,T,")]
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
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,3,4,5,6,7,8,9,CL,CP,RC,RO,")]
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
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,BL,CH,CI,FI,HM,MA,MB,MC,MH,OF,SA,TV,VA,WC,ZZ,")]
    public class X12_ID_1032
    {
    }

    /// <summary>
    /// Claim Adjustment Group Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CO,CR,DE,MA,NC,PI,PR,")]
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
    [EdiCodes(",PEN,TAX,VEN,")]
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
    [EdiCodes(",1,2,")]
    public class X12_ID_1065
    {
    }

    /// <summary>
    /// Citizenship Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,")]
    public class X12_ID_1066
    {
    }

    /// <summary>
    /// Marital Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",D,I,K,M,R,S,U,W,X,")]
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
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,17,18,19,20,21,22,23,24,25,26,27,28" +
        ",29,30,31,32,33,34,36,37,38,39,40,41,43,45,46,47,48,49,50,51,52,53,ZZ,")]
    public class X12_ID_1069
    {
    }

    /// <summary>
    /// Payment Method Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,W,")]
    public class X12_ID_107
    {
    }

    /// <summary>
    /// Type of Residence Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,9,A,B,C,H,I,L,N,")]
    public class X12_ID_1070
    {
    }

    /// <summary>
    /// General Expense Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,91,92,93,94,")]
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
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,13,")]
    public class X12_ID_1074
    {
    }

    /// <summary>
    /// Status of Plans for Real Estate Asset Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",H,P,R,S,")]
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
    [EdiCodes(",C,F,L,O,R,X,")]
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
    [EdiCodes(",AT,CA,CC,CT,DB,H,J,M,O,OT,P,PB,RD,S,SD,U,V,")]
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
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,AL,AR,AU,BO,CC,CO,CT,FM,MH,PE,RE,RV,SL,SM" +
        ",SO,")]
    public class X12_ID_1081
    {
    }

    /// <summary>
    /// Purpose of Refinance Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,04,05,06,ZZ,")]
    public class X12_ID_1082
    {
    }

    /// <summary>
    /// Type of Downpayment Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,09,10,11,12,ZZ,")]
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
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,")]
    public class X12_ID_1085
    {
    }

    /// <summary>
    /// Loan Rate Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
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
    [EdiCodes(",1,2,3,4,5,6,Z,")]
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
    [EdiCodes(",1,2,3,Z,")]
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
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,")]
    public class X12_ID_1104
    {
    }

    /// <summary>
    /// Mortgage Insurance Duration Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,")]
    public class X12_ID_1105
    {
    }

    /// <summary>
    /// Address Component Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,30,31,32,33,34,35" +
        ",36,37,")]
    public class X12_ID_1106
    {
    }

    /// <summary>
    /// Name Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,17,18,19,20,21,")]
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
    [EdiCodes(",A,B,C,H,I,N,O,Z,")]
    public class X12_ID_1109
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
    /// Interline Settlement System Status Action or Dispute Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CA,CC,CH,CO,CP,CT,DO,DR,DT,LT,NP,OP,OR,PS,PT,RT,SA,SC,SF,SN,SS,ST,T1,TR,UT,")]
    public class X12_ID_1127
    {
    }

    /// <summary>
    /// Adjustment Reason Code Characteristic
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,2,23,24,25,26,27,28,29,3,30,31,32,34,35,36,37,38,39,4,40,41,42," +
        "43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,6,7,8,9,")]
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
    /// Level of Individual or Test Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,0K,10,11,12,20,21,22,23,24,25,26,27,28,29,30,AD,AS,BD" +
        ",DD,EL,HG,HS,MD,MS,NO,P0,P1,P2,P3,P4,P5,PC,PD,PK,PS,UN,VS,")]
    public class X12_ID_1131
    {
    }

    /// <summary>
    /// Instructional Setting Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,2,3,4,5,6,7,8,9,")]
    public class X12_ID_1132
    {
    }

    /// <summary>
    /// Other Program Participation Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,2,3,4,5,6,7,8,9,")]
    public class X12_ID_1133
    {
    }

    /// <summary>
    /// Other Program Funding Source Code
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
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27" +
        ",28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,")]
    public class X12_ID_1136
    {
    }

    /// <summary>
    /// Payer Responsibility Sequence Number Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,P,S,T,U,")]
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
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,3,4,5,6,7,8,9,A,B,D,G,H,I,L,M,P,R,T,U,")]
    public class X12_ID_1142
    {
    }

    /// <summary>
    /// Coordination of Benefits Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,")]
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
    [EdiCodes(",1,2,3,4,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,V,W,Y,")]
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
    [EdiCodes(",C,E,L,M,N,S,T,")]
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
    [EdiCodes(",1,2,3,4,5,6,7,8,9,Z,")]
    public class X12_ID_1160
    {
    }

    /// <summary>
    /// Product Option Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,C,D,N,NC,O,S,")]
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
    [EdiCodes(",01,02,03,04,05,06,09,AC,CH,CP,CS,CW,CX,CY,DI,FA,FD,FE,FI,FL,FR,FX,LA,LE,LH,OC,SP" +
        ",TM,ZZ,")]
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
        "A,RDP,UPR,UR,URF,WBS,")]
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
    /// Resource Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,")]
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
        ",91,92,93,94,PD,PS,SA,SB,SC,SP,VP,ZZ,")]
    public class X12_ID_1186
    {
    }

    /// <summary>
    /// Type of Account
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,")]
    public class X12_ID_1187
    {
    }

    /// <summary>
    /// Type of Personal Property Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,")]
    public class X12_ID_1188
    {
    }

    /// <summary>
    /// Type of Credit Account Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",I,O,R,")]
    public class X12_ID_1189
    {
    }

    /// <summary>
    /// Program Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,")]
    public class X12_ID_1193
    {
    }

    /// <summary>
    /// Breakdown Structure Detail Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27" +
        ",28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,ZZ,")]
    public class X12_ID_1196
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
        ",28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,XB,XI,XL,XM,X" +
        "N,XT,ZZ,")]
    public class X12_ID_1203
    {
    }

    /// <summary>
    /// Insurance Line Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",403,AC,ADD,AF,AP,AR,BC,BE,BH,BK,CLF,CV,DEN,FSA,GDC,HLT,HMO,IRA,IRC,LL,LTC,LTD,MO" +
        "D,NGD,NQ,PDG,PSP,QDA,QDC,STD,UL,UR,VIS,ZZZ,")]
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
    [EdiCodes(",A,C,D,I,N,S,")]
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
    [EdiCodes(",E,F,G,P,")]
    public class X12_ID_1213
    {
    }

    /// <summary>
    /// Identification Card Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",H,P,")]
    public class X12_ID_1215
    {
    }

    /// <summary>
    /// Benefit Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,C,S,")]
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
    [EdiCodes(@",AA,AC,AV,B0,B1,BF,BL,BR,C5,CF,CM,CP,CS,CT,CW,DD,DP,DR,DS,DV,EI,ER,FC,FF,FL,FN,FR,FT,FV,GT,HD,HM,HN,HX,HY,IN,KG,KL,KP,KT,LB,LF,LP,LR,LS,LT,MA,MB,MC,MD,ME,MH,MI,MM,MN,MO,MP,MR,MS,MT,MV,MW,MX,ND,NM,NP,NV,P1,PA,PB,PC,PD,PE,PF,PG,PH,PK,PL,PM,PN,PP,PQ,PR,PS,PT,PU,PV,PW,PY,QY,RP,RT,S0,S1,SC,SD,SF,SP,ST,SU,SY,TB,TC,TD,TN,TP,TR,VA,VH,VM,VP,VR,VS,VT,VU,VV,WK,WM,XP,YR,")]
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
    [EdiCodes(",AD,AS,AT,BI,BS,CO,CV,H,HH,LA,OP,OR,OT,P1,P2,PC,PE,PT,PU,R,RF,SB,SK,SU,")]
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
    [EdiCodes(",AF,CA,CB,CC,CG,CP,CS,CW,DD,DW,EC,ED,EE,EF,EM,EW,FC,FW,GC,GM,GR,IO,LF,LL,LO,LP,LW" +
        ",MB,MC,MG,MI,MR,MS,NE,OW,PD,PG,PL,PO,PW,RD,RN,RP,RS,SB,SC,SD,SP,SS,ST,SW,TC,TP,U" +
        "E,WC,")]
    public class X12_ID_1230
    {
    }

    /// <summary>
    /// Service Classification Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,AC,B,CHR,CRD,CUR,CUS,D,DOC,E,F,G,H,LER,MAA,PAI,SEI,STR,UIRA,")]
    public class X12_ID_1233
    {
    }

    /// <summary>
    /// Severity Condition Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,")]
    public class X12_ID_1234
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
    [EdiCodes(",CC,CM,CY,D6,D8,DD,DT,MD,ME,MM,RD2,RD4,RD6,RD8,RDM,RDT,RMD,RTM,TM,TS,YM,YY,")]
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
    [EdiCodes(",1,2,3,4,5,6,7,")]
    public class X12_ID_1262
    {
    }

    /// <summary>
    /// Deferment Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,2,3,4,5,6,7,8,9,")]
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
    [EdiCodes(@",0,1,10,11,12,13,14,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,52,53,54,55,56,57,58,59,6,60,61,62,63,66,67,69,7,71,74,75,78,79,8,80,81,82,83,84,85,86,87,88,89,9,90,91,92,93,94,95,96,97,98,99,A1,A2,A3,A4,A5,A6,A7,A8,A9,AA,AB,AD,AE,AF,AG,AH,AI,AJ,AK,AL,BA,BC,BD,CA,CB,CC,CD,CE,CF,CG,CH,CV,DK,EA,EB,EC,ED,EE,EF,EG,EI,EJ,EL,EM,EN,EQ,ER,ET,EU,EV,EW,EX,EY,EZ,FA,FB,FC,FD,FE,FF,FG,GA,GB,GC,GD,GE,GF,GG,GI,GJ,GK,HA,HB,HC,HD,JA,JB,JC,JD,JE,JF,JG,JH,JI,JK,JL,JM,JN,LC,LR,LT,LZ,MC,OC,ZZ,")]
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
    /// Reference Number Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,1A,1B,1C,1D,1E,1F,1G,1H" +
        ",1I,1J,1K,1L,1M,1N,1O,1P,1Q,1R,1S,1T,1U,1V,1W,1X,1Y,1Z,20,21,22,23,25,27,28,29,2" +
        "B,2D,2E,2F,2G,2H,2I,2U,30,31,33,34,35,36,37,38,39,3A,3B,3C,3D,3E,3F,3G,3H,3I,3J," +
        "3P,3S,3X,3Y,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62" +
        ",63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,8" +
        "9,8A,8B,8C,90,91,92,93,95,96,97,98,99,9A,9B,9C,9D,9E,9F,A0,A1,A2,A3,A4,A5,A6,A7," +
        "A8,A9,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,AX,AY" +
        ",AZ,B1,B2,B3,B4,B5,B6,B7,B8,B9,BA,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BO,BP,B" +
        "Q,BR,BS,BT,BU,BV,BW,BX,BY,BZ,C0,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA,CB,CC,CD,CE,CF,CG," +
        "CH,CI,CJ,CK,CL,CM,CN,CO,CP,CQ,CR,CS,CT,CU,CV,CW,CX,CY,CZ,D1,D2,D3,D4,D5,D6,D7,D8" +
        ",D9,DA,DB,DC,DD,DE,DF,DG,DH,DI,DJ,DK,DL,DM,DN,DO,DP,DQ,DR,DS,DT,DU,DV,DW,DX,DY,D" +
        "Z,E1,E2,E3,E4,E5,E6,E7,E8,E9,EA,EB,ED,EF,EG,EH,EI,EJ,EK,EL,EM,EN,EO,EP,EQ,ER,ES," +
        "ET,EU,EV,EW,EX,EY,EZ,F1,F2,F3,F4,F5,F6,F7,F8,F9,FA,FB,FC,FD,FE,FF,FG,FH,FI,FJ,FK" +
        ",FL,FM,FN,FO,FP,FQ,FR,FS,FT,FU,FV,FW,FX,FY,FZ,G1,G2,G3,G4,G5,G6,G7,G8,G9,GA,GB,G" +
        "C,GD,GE,GF,GG,GH,GI,GJ,GK,GL,GM,GN,GP,GQ,GR,GS,GT,GU,GV,GW,GX,GY,H1,H2,H3,HB,HC," +
        "HD,HE,HI,HN,HO,HP,HR,HS,HW,I2,IA,IB,IC,ID,IE,IF,IG,IH,II,IJ,IK,IL,IM,IN,IO,IP,IR" +
        ",IS,IT,IU,IV,IW,IX,IZ,JA,JB,JE,JS,JY,K0,K1,K2,K3,K4,K5,K6,K7,K8,K9,KA,KB,KC,KE,K" +
        "G,KH,KI,KJ,KK,KL,KM,KN,KO,KP,KQ,KR,KS,KT,KU,KV,KW,KX,KY,KZ,L1,L2,L3,L4,L5,L6,LA," +
        "LB,LC,LD,LE,LF,LG,LH,LI,LJ,LK,LL,LM,LN,LO,LP,LQ,LR,LS,LT,LU,LV,LW,LY,LZ,M1,M2,M3" +
        ",M4,M5,M6,MA,MB,MC,MD,ME,MF,MG,MH,MI,MJ,MK,ML,MM,MN,MO,MP,MQ,MR,MS,MT,MU,MV,MW,M" +
        "X,MY,N0,N1,N2,N3,N4,N5,N6,N7,N8,NA,NB,ND,NE,NF,NG,NH,NN,NO,NP,NR,NS,NX,NY,O5,OA," +
        "OB,OC,OD,OE,OI,OL,OM,ON,OP,OQ,OR,OS,OT,OW,OZ,P1,P2,P3,P4,P5,P6,P7,P8,P9,PA,PB,PC" +
        ",PD,PE,PF,PG,PH,PI,PJ,PK,PL,PM,PN,PO,PP,PQ,PR,PS,PT,PU,PV,PW,PX,PY,PZ,Q1,Q2,Q3,Q" +
        "4,Q5,Q6,Q7,Q8,Q9,QA,QB,QC,QD,QE,QF,QG,QH,QI,QJ,QK,QL,QM,QN,QO,QP,QQ,QR,QS,QT,QU," +
        "QV,QW,QX,QY,QZ,R1,R2,R3,R4,R5,R6,R7,R8,R9,RA,RB,RC,RD,RE,RF,RG,RH,RI,RJ,RK,RL,RM" +
        ",RN,RO,RP,RQ,RR,RS,RT,RU,RV,RW,RX,RY,RZ,S1,S2,S3,S4,S5,S6,S7,S8,S9,SA,SB,SC,SD,S" +
        "E,SF,SG,SH,SI,SJ,SK,SL,SM,SN,SO,SP,SQ,SR,SS,ST,SU,SV,SW,SX,SY,SZ,T1,T2,T3,T4,T5," +
        "T6,T7,T8,T9,TA,TB,TC,TD,TE,TF,TG,TH,TI,TJ,TK,TL,TM,TN,TO,TP,TQ,TR,TS,TT,TU,TV,TW" +
        ",TX,TY,TZ,U1,U2,U3,UA,UB,UC,UD,UE,UF,UG,UH,UN,UP,UR,US,UT,V1,V3,VA,VB,VC,VD,VE,V" +
        "F,VG,VN,VP,VR,VS,VT,VV,VX,W1,W2,W3,W4,W5,W6,W7,W8,W9,WC,WD,WF,WG,WM,WN,WO,WP,WR," +
        "WS,WY,X1,X2,X3,X4,X5,X6,X7,X8,X9,XA,XB,XC,XD,XE,XF,XG,XH,XI,XJ,XK,XM,XN,XP,XT,XX" +
        ",Y1,Y2,Y3,Y4,Y9,YA,YS,Z1,Z2,Z3,Z4,Z5,Z6,Z7,Z8,Z9,ZA,ZB,ZC,ZE,ZF,ZG,ZH,ZI,ZJ,ZK,Z" +
        "L,ZM,ZO,ZR,ZS,ZZ,")]
    public class X12_ID_128
    {
    }

    /// <summary>
    /// Direction Identifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",E,N,S,W,")]
    public class X12_ID_1280
    {
    }

    /// <summary>
    /// Returns Disposition Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CR,DI,KA,KR,MW,RA,RD,RF,RN,RP,RT,SC,SD,")]
    public class X12_ID_1292
    {
    }

    /// <summary>
    /// Return Request Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CO,CV,DM,DP,DR,EI,EO,EW,LP,NA,OP,PE,PF,PW,SD,SP,SR,ST,WG,")]
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
    [EdiCodes(",A,AN,AV,C,CD,D,DB,DN,DP,DR,DV,GA,KP,N,PD,PF,R,RT,S,S1,S2,TD,TN,TR,TS,TV,US,")]
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
    [EdiCodes(",A010,A020,A030,A040,A050,A060,A070,A080,A090,A100,A110,A120,A130,A140,A150,A160," +
        "A170,A180,A190,A200,A210,A220,A230,A240,A250,A260,A270,A280,A290,A300,A310,A320," +
        "A330,A340,A350,A360,A370,A380,A390,A400,A410,A420,A430,A440,A450,A460,A470,A480," +
        "A490,A500,A510,A520,A530,A540,A550,A560,A570,A580,A590,A600,A610,A620,A630,A640," +
        "A650,A660,A670,A680,A690,A700,A710,A720,A730,A740,A750,A760,A770,A780,A790,A800," +
        "A810,A820,A830,A840,A850,A860,A870,A880,A890,A900,A910,A920,A930,A940,A950,A960," +
        "A970,A980,A990,B000,B010,B020,B030,B040,B050,B060,B070,B080,B090,B100,B110,B120," +
        "B130,B140,B150,B160,B170,B180,B190,B200,B210,B220,B230,B240,B250,B260,B270,B280," +
        "B290,B300,B310,B320,B330,B340,B350,B360,B370,B380,B390,B400,B500,B510,B520,B530," +
        "B540,B550,B560,B570,B580,B590,B600,B610,B620,B630,B650,B660,B670,B680,B690,B700," +
        "B710,B720,B730,B740,B750,B760,B770,B780,B785,B790,B800,B810,B820,B830,B840,B850," +
        "B860,B870,B880,B890,B900,B910,B920,B930,B940,B950,B960,B970,B980,B990,C000,C010," +
        "C020,C030,C040,C050,C060,C070,C080,C090,C100,C110,C120,C130,C140,C150,C160,C170," +
        "C180,C190,C200,C210,C220,C230,C240,C250,C260,C270,C280,C290,C300,C310,C320,C330," +
        "C340,C350,C360,C370,C380,C390,C400,C410,C420,C430,C440,C450,C460,C470,C480,C490," +
        "C500,C510,C520,C530,C540,C550,C560,C570,C580,C590,C600,C610,C620,C630,C640,C650," +
        "C660,C670,C680,C690,C700,C710,C720,C730,C740,C750,C760,C770,C780,C790,C800,C810," +
        "C820,C830,C840,C850,C860,C870,C880,C890,C900,C910,C920,C930,C940,C950,C960,C970," +
        "C980,C990,D000,D010,D020,D030,D040,D050,D060,D070,D080,D090,D100,D110,D120,D130," +
        "D140,D150,D160,D170,D180,D190,D200,D210,D220,D230,D240,D250,D260,D270,D280,D290," +
        "D300,D310,D320,D330,D340,D350,D360,D370,D380,D390,D400,D410,D420,D430,D440,D450," +
        "D460,D470,D480,D490,D500,D510,D520,D530,D540,D550,D560,D570,D580,D590,D600,D610," +
        "D620,D630,D640,D650,D660,D670,D680,D690,D700,D710,D720,D730,D740,D750,D760,D770," +
        "D780,D790,D800,D810,D820,D830,D840,D850,D860,D870,D880,D890,D900,D910,D920,D930," +
        "D940,D950,D960,D970,D980,D990,E000,E010,E020,E030,E040,E050,E060,E065,E070,E080," +
        "E090,E100,E110,E120,E130,E140,E150,E160,E170,E180,E190,E191,E192,E193,E200,E210," +
        "E220,E230,E240,E250,E260,E270,E280,E290,E300,E310,E320,E330,E340,E350,E360,E370," +
        "E380,E390,E400,E410,E420,E430,E440,E450,E460,E470,E480,E490,E500,E510,E520,E530," +
        "E540,E550,E560,E570,E580,E590,E600,E610,E620,E630,E640,E650,E660,E670,E680,E690," +
        "E700,E710,E720,E730,E740,E750,E760,E770,E780,E790,E800,E810,E820,E830,E840,E850," +
        "E860,E870,E880,E890,E900,E910,E920,E930,E940,E950,E960,E970,E980,E990,F000,F010," +
        "F020,F030,F040,F050,F060,F070,F080,F090,F100,F110,F120,F130,F140,F150,F155,F160," +
        "F170,F180,F190,F200,F210,F220,F230,F240,F250,F260,F270,F280,F290,F300,F310,F320," +
        "F330,F340,F350,F360,F370,F380,F390,F400,F410,F420,F430,F440,F450,F460,F470,F480," +
        "F490,F500,F510,F520,F530,F540,F550,F560,F570,F580,F590,F600,F610,F620,F630,F640," +
        "F650,F660,F670,F680,F690,F700,F710,F720,F730,F740,F750,F760,F770,F780,F790,F800," +
        "F810,F820,F830,F840,F850,F860,F870,F880,F890,F900,F910,F920,F930,F940,F950,F960," +
        "F970,F980,F990,G000,G010,G020,G030,G040,G050,G060,G070,G080,G090,G100,G110,G120," +
        "G130,G140,G150,G160,G170,G180,G190,G200,G210,G220,G230,G240,G250,G260,G270,G280," +
        "G290,G300,G310,G320,G330,G340,G350,G360,G370,G380,G390,G400,G410,G420,G430,G440," +
        "G450,G460,G470,G480,G490,G500,G510,G520,G530,G540,G550,G560,G570,G580,G590,G600," +
        "G610,G620,G630,G640,G650,G660,G670,G680,G690,G700,G710,G720,G730,G740,G750,G760," +
        "G770,G780,G790,G800,G810,G820,G830,G840,G850,G860,G870,G880,G890,G900,G910,G920," +
        "G930,G940,G950,G960,G970,G980,G990,H000,H010,H020,H030,H040,H050,H060,H070,H080," +
        "H090,H100,H110,H120,H130,H140,H150,H160,H170,H180,H190,H200,H210,H220,H230,H240," +
        "H250,H260,H270,H280,H290,H300,H310,H320,H330,H340,H350,H360,H370,H380,H390,H400," +
        "H410,H420,H430,H440,H450,H460,H470,H480,H490,H500,H510,H520,H530,H540,H550,H560," +
        "H570,H580,H590,H600,H610,H620,H625,H630,H640,H650,H660,H670,H680,H690,H700,H710," +
        "H720,H730,H740,H750,H760,H770,H780,H790,H800,H806,H810,H820,H830,H840,H850,H860," +
        "H870,H880,H890,H900,H910,H920,H930,H935,H940,H950,H960,H970,H980,H990,I000,I010," +
        "I020,I030,I040,I050,I060,I070,I080,I090,I100,I110,I120,I130,I140,I150,I160,I170," +
        "I180,I190,I200,I210,I220,I230,I240,I250,I260,I270,I280,I290,I300,I310,I320,I330," +
        "I340,I350,I360,I370,I380,I390,I400,I410,I420,I430,I440,I450,I460,I470,I480,I490," +
        "I495,I500,I510,I520,I530,I540,I550,I560,I570,I580,I590,I600,I610,I620,I630,I640," +
        "I650,I660,I670,I680,ZZZZ,")]
    public class X12_ID_1300
    {
    }

    /// <summary>
    /// Loan Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34" +
        ",35,4,42,43,44,45,46,47,48,49,5,50,6,7,8,9,")]
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
    /// Pricing Proposal Data Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,K1,K2,K3,K4,K5,K6,KH,KI,KJ,KK" +
        ",KL,KM,KN,KO,KP,KQ,KR,KS,KT,KU,KV,KW,KX,KY,KZ,L2,")]
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
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27" +
        ",28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,5" +
        "4,55,56,57,58,59,60,PS,")]
    public class X12_ID_1321
    {
    }

    /// <summary>
    /// Certification Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,I,R,S,")]
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
    [EdiCodes(",0,1,2,3,4,5,6,9,")]
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
    [EdiCodes(",01,02,03,04,10,11,12,13,14,15,16,20,21,22,23,24,30,31,32,33,40,41,42,50,51,52,60" +
        ",61,62,63,64,65,66,67,68,70,71,72,73,74,75,76,77,80,81,82,83,84,85,86,90,91,92,9" +
        "3,94,95,96,97,98,99,")]
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
    [EdiCodes(",F,P,S,")]
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
    [EdiCodes(",12,13,14,15,16,41,42,43,AP,C1,CO,CP,FF,GP,HM,IP,LD,LT,MA,MB,MC,MG,MP,OT,PL,PP,PR" +
        ",PS,SP,TF,")]
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
    [EdiCodes(",00,01,02,03,04,05,09,10,11,F1,F2,L,")]
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
    [EdiCodes(",A,AM,AN,CF,CH,CS,DD,DM,DN,ER,HS,IF,IL,MD,MF,MI,MO,MS,NM,NP,NS,O,OC,OP,OT,OX,P,PA" +
        ",PD,PE,PF,PS,PT,RX,S,SN,ST,")]
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
    /// Payment Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,U,Z,")]
    public class X12_ID_1353
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
    /// Dental Quadrant Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",FM,L,LA,LL,LR,R,UA,UL,UR,")]
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
    [EdiCodes(",M,N,Y,")]
    public class X12_ID_1363
    {
    }

    /// <summary>
    /// Review Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,L,N,")]
    public class X12_ID_1364
    {
    }

    /// <summary>
    /// Service Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,10,11,12,13,14,15,16,17,18,19,2,20,21,3,30,31,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59,6,60,61,62,63,64,65,66,67,68,69,7,70,71,72,73,74,75,76,77,78,79,8,80,81,82,83,84,85,86,87,88,89,9,90,91,92,93,94,95,96,97,98,99,A0,A1,A2,A3,A4,A5,A6,A7,A8,A9,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,")]
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
    /// Waybill Cross-Reference Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",W1,W2,W3,W4,W5,W6,")]
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
    [EdiCodes(",00,01,02,03,05,07,15,16,17,18,20,22,27,28,29,")]
    public class X12_ID_1383
    {
    }

    /// <summary>
    /// Patient Location Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,O,P,R,S,T,")]
    public class X12_ID_1384
    {
    }

    /// <summary>
    /// Rate Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,2,3,4,5,6,7,8,9,")]
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
    [EdiCodes(",1,2,3,4,5,6,7,8,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,")]
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
        ",LS,MC,MD,MF,ML,MP,MV,NG,OB,OL,PC,PE,PH,PX,RE,RI,RP,RV,SC,SN,ST,SV,TK,TL,TM,TP,T" +
        "R,TX,US,VF,")]
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
    [EdiCodes(@",101,104,105,107,108,109,110,111,113,115,116,125,126,127,128,129,130,131,135,139,140,141,142,143,144,146,147,148,151,152,154,161,170,180,186,190,196,204,210,213,214,217,218,250,251,260,263,264,270,271,272,276,277,290,300,301,302,303,304,305,306,307,309,310,311,312,313,314,315,316,317,319,321,322,323,324,325,326,350,352,353,354,355,356,360,361,404,410,411,414,417,418,419,420,421,422,423,424,425,426,427,429,431,440,460,461,462,463,464,465,466,467,468,469,480,485,486,490,491,492,494,499,511,517,527,536,561,567,568,601,602,622,805,806,810,811,812,813,815,816,818,819,820,821,822,823,824,826,827,828,829,830,831,832,833,834,835,836,837,838,839,840,841,842,843,844,845,846,847,848,849,850,851,852,853,854,855,856,857,858,859,860,861,862,863,864,865,866,867,868,869,870,872,874,875,876,877,878,879,880,881,882,883,884,885,888,889,890,891,892,893,894,895,896,905,920,924,925,926,928,940,941,942,943,944,945,946,947,980,990,994,995,996,997,998,999,")]
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
    [EdiCodes(",AB,BL,BO,EO,FO,IN,LO,NL,NO,RO,SO,WO,ZZ,")]
    public class X12_ID_1465
    {
    }

    /// <summary>
    /// Location Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",LL,RC,TT,VL,WL,ZZ,")]
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
    /// Shipment Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,")]
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
    [EdiCodes(",1,2,3,4,5,")]
    public class X12_ID_1476
    {
    }

    /// <summary>
    /// Special Charge or Allowance Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",003,005,010,015,020,025,030,035,040,045,050,055,060,065,070,075,080,085,090,095," +
        "100,105,110,115,120,135,140,145,150,155,160,165,170,175,180,185,186,190,205,210," +
        "215,220,225,230,235,240,245,250,255,260,265,270,275,280,285,290,295,297,300,310," +
        "315,320,325,335,340,345,350,355,360,365,370,375,380,385,390,392,393,395,400,405," +
        "410,415,416,420,425,426,430,435,440,445,450,455,460,462,465,470,475,480,485,490," +
        "495,500,505,510,515,520,525,535,540,545,550,555,560,565,570,580,585,586,590,593," +
        "595,600,605,610,615,620,625,635,640,641,645,650,665,670,675,680,685,690,695,696," +
        "697,700,705,706,720,725,730,731,732,735,736,740,745,750,760,761,762,999,AAA,AAJ," +
        "AAM,AAN,AAO,AAS,AAT,ABC,ABL,ACD,ACF,ACH,ACL,ACS,ADH,ADV,AFB,AFC,AGS,AIC,AIR,ALC," +
        "ALP,AMB,AMC,AMP,ANB,ANC,ANS,APL,APT,ARB,ARC,ARG,ASC,AUX,AVA,BAA,BAB,BAC,BAD,BAF," +
        "BAP,BAS,BBK,BDX,BEY,BFD,BKA,BLA,BLC,BLD,BLK,BLW,BND,BOB,BRA,BRD,BSC,BSS,BUR,BYD," +
        "CAA,CAC,CAD,CAE,CAF,CAG,CAH,CAJ,CAK,CAL,CAO,CAP,CAQ,CAR,CAS,CAV,CAW,CAZ,CBL,CBO," +
        "CBP,CBR,CBW,CBX,CCA,CCH,CCP,CCR,CDA,CDF,CDR,CER,CGC,CGL,CGR,CHG,CHN,CIR,CIS,CLC," +
        "CLN,CLS,CMC,CMF,CMI,CMP,CNS,CNV,COA,COC,COD,COF,COL,COM,CON,COR,COU,CPA,CPE,CPP," +
        "CRA,CRC,CRF,CRP,CRR,CRS,CSA,CSC,CSE,CSF,CSR,CST,CTA,CTC,CTF,CTG,CTL,CTX,CUA,CUD," +
        "CUF,CUP,CUS,DAA,DAB,DAC,DAD,DAM,DBD,DBL,DCS,DCT,DDA,DDC,DDD,DDF,DDN,DDP,DDS,DEA," +
        "DED,DEL,DEM,DEP,DER,DES,DET,DEV,DEW,DFS,DFW,DGS,DIC,DIR,DIS,DIV,DLH,DMC,DMD,DNA," +
        "DOC,DON,DPR,DRC,DRP,DRV,DRY,DSC,DSF,DSR,DST,DTA,DTB,DTC,DTD,DTF,DTL,DTU,DTV,DWC," +
        "EAC,EAX,EBD,EBP,ECC,EEA,EEB,EEC,EEF,EEG,EEH,EEP,EEX,EIC,ELS,EMS,EMT,ENC,ENS,EPC," +
        "EPS,ERS,ESA,ESC,ESD,ESE,ETR,EUC,EVC,EXC,EXL,EXM,EXP,EXS,EXW,EXZ,FAB,FAC,FAD,FAE," +
        "FAF,FAG,FAH,FBD,FCB,FCD,FCI,FCS,FDL,FDS,FFI,FFL,FFN,FFP,FFR,FIR,FLT,FMR,FMS,FRC," +
        "FTC,FUE,FWA,FWC,FXE,GAR,GDR,GGA,GGF,GKT,GOC,GPD,GRD,GRS,GSS,GST,HAN,HAZ,HBD,HDF," +
        "HDG,HET,HFA,HHA,HHB,HHG,HIC,HLF,HOC,HOL,HOS,HOX,HRS,HSC,HUL,HZS,IAA,IAB,IAC,ICE," +
        "IDL,IDP,IFC,IHT,IIA,IIP,IIU,ILD,ILF,ILP,IMP,INC,INP,INR,INS,IPC,IPU,IRA,ISD,ITC," +
        "JST,KIT,LAA,LAB,LAC,LAD,LAE,LAL,LAT,LAY,LCG,LCR,LDA,LDG,LDL,LDS,LFT,LGD,LHS,LID," +
        "LLC,LLD,LLF,LLS,LMC,LNT,LOA,LOC,LPC,LPF,LSC,LSH,LSS,LTC,LUB,LUP,LUS,MAA,MAB,MAC," +
        "MAD,MAE,MAR,MCC,MDG,MDM,MEA,MEN,MES,MET,MFC,MFG,MGA,MGC,MIC,MIL,MIN,MKU,MLB,MLS," +
        "MMC,MMF,MMS,MMT,MNC,MNS,MPC,MRK,MRP,MSC,MSG,MTR,MUS,MVR,MVT,NAA,NAB,NAL,NCH,NDS," +
        "NFY,NHB,NSD,NWD,NYD,NYP,OAA,OAB,OAC,OCH,ODF,OFR,OFU,ONC,OOC,OOF,OPC,ORC,ORM,OSC," +
        "OSO,OSS,OUT,OVR,PAA,PAC,PAD,PAE,PAF,PAG,PAH,PAI,PAJ,PAK,PAL,PAR,PAT,PBA,PBE,PBL," +
        "PCH,PCT,PDB,PDC,PDS,PEC,PEN,PER,PFA,PHC,PHG,PIR,PLC,PLT,PMC,PMR,PMU,PMX,PNA,POC," +
        "POD,POL,POS,PPC,PPH,PPI,PPM,PPN,PPO,PPR,PPS,PPT,PPU,PRB,PRC,PRE,PRK,PRL,PRM,PRP," +
        "PRV,PSC,PSD,PSG,PSH,PSS,PST,PTC,PTS,PUC,PUD,PUK,PWH,PWT,QAA,QQD,RAA,RAB,RAC,RAD," +
        "RAE,RAF,RAG,RAH,RAI,RAJ,RAK,RAL,RAM,RCA,RCB,RCC,RCD,RCE,RCG,RCL,RCP,RCS,RDC,RDF," +
        "REC,REE,REF,REG,REL,REP,REQ,RES,RET,RFD,RGA,RGC,RHM,RID,RLA,RLC,RLQ,RLS,RMB,RMD," +
        "RMS,ROC,RPC,RRC,RRD,RRF,RRN,RRP,RRR,RSM,RSP,RSS,RSV,RTC,SAA,SAB,SAC,SAD,SAE,SAF," +
        "SAG,SAH,SAI,SAJ,SAK,SAM,SAN,SAP,SAT,SBC,SBL,SCC,SCD,SCG,SCL,SCU,SDC,SDL,SDS,SEC," +
        "SEE,SEG,SEL,SEQ,SER,SEV,SFC,SFT,SGL,SHL,SHS,SKT,SLC,SMS,SNS,SNT,SOC,SOP,SPA,SPB," +
        "SPC,SPD,SPL,SPP,SPS,SPT,SPU,SRG,SRS,SSA,SSB,SSC,SSF,SSL,SSO,SSP,SSS,SST,SSX,STC," +
        "STF,STL,STM,STP,STR,STW,SUC,SUF,SUP,SUR,SVA,SVL,SVS,SWC,TAA,TAB,TAC,TAD,TAE,TAF," +
        "TAG,TAH,TAI,TAJ,TAK,TAL,TAX,TAY,TCB,TCM,TDT,TER,TLC,TMS,TMV,TOA,TOC,TPC,TPS,TRA," +
        "TRC,TRE,TRF,TRM,TRN,TRP,TRS,TRU,TSC,TSS,TST,TTA,TTB,TTD,TTL,TTM,TTP,TTR,TTS,TTT," +
        "TTU,TTV,TUR,TWO,UND,UNL,UPD,UPK,URC,USF,USV,USW,UTL,UTP,UUC,UUM,UUT,VAA,VAB,VCR," +
        "VFN,VIS,VIT,VOR,VTS,VVL,VVP,WAR,WAT,WEA,WFH,WHC,WRC,WRE,WSA,WTG,WTV,WWC,Z01,Z02," +
        "Z03,Z04,Z05,Z06,Z07,Z08,Z09,Z10,Z11,Z12,Z13,Z14,Z15,Z16,Z17,Z18,Z19,Z20,Z21,Z22," +
        "Z23,Z24,Z25,Z26,Z27,Z28,Z29,Z30,Z31,ZFF,ZZZ,")]
    public class X12_ID_150
    {
    }

    /// <summary>
    /// Special Handling Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",045,15,25,35,45,520,675,A1M,A3M,A5M,AAS,AGG,AGS,AK,AMM,ANC,APL,ARC,ARG,ASY,AT,AUX,AV,AW,BA,BCP,BKA,BL,BLS,BN,BNS,BOX,BW,CAR,CCB,CCH,CD,CE,CGC,CGR,CH,CHN,CI,CLS,CM,CMD,CNL,CNS,CO,CON,COR,COU,COV,CPM,CR,CSD,CTM,CW,CY,DA,DBL,DCS,DDN,DDP,DE,DFS,DIS,DLR,DM,DN,DNF,DOC,DR,DRO,DRU,DS,DSR,DST,DSV,DT,DTV,DU,DV,DW,EAX,ED,EE,EED,EL,ELS,EMR,EMT,END,EP,ER,ERS,EV,EW,EX,EXC,EXD,EXO,EXP,EXQ,EXT,EXU,EXZ,EZE,FC,FCS,FD,FG,FL,FP,FPT,FR,FRZ,FS,FST,GI,GOC,GSS,HAN,HE,HEA,HES,HET,HH,HHB,HM,HO,HOR,HP,HQT,HR,HRS,HT,HV,HW,IB,IC,ID,IM,IMP,INT,IP,IR,IS,JIT,JLX,JS,KEG,KMD,LAB,LAY,LB,LBT,LC,LD,LF,LHS,LP,LS,LT,LTT,MC,MEN,MES,MET,MEX,MF,MIN,MOT,MP,MR,MRF,MSS,MTE,NC,ND,NE,NH,NP,NPR,NS,NSV,NT,NW,NX,OAH,OBL,OCA,OCL,OCS,OCV,ODI,OEH,OFH,OFU,OHC,OIL,ONC,ONS,OOB,OOD,OOL,OPR,OPT,OS,OSB,OST,OTC,OTD,OTH,OTO,OTS,OUC,OUW,OVR,OWR,PB,PD,PDS,PER,PG,PHR,PI,PIR,PMM,PMR,POC,PRL,PS,PSG,PSS,PTS,PUC,PUD,PUK,PUP,PW,RA,RB,RC,RCC,RCL,RDR,RLS,RM,RMS,RO,RR,RRR,RS,RSP,RSS,RSV,RT,SB,SC,SCC,SCL,SD,SDS,SE,SEC,SEE,SER,SEV,SF,SFT,SGL,SH,SHL,SI,SK,SKT,SLC,SM,SMP,SMS,SNT,SOC,SOL,SP,SPC,SPR,SPT,SPU,SR,SRG,SRS,SSN,ST,STR,SUP,SVS,TA,TDC,TDP,TLS,TMS,TN,TOF,TPS,TRA,TRK,TRL,TRM,TRN,TRP,TRS,TRT,TS,TSC,TSP,TSS,TT,TV,UB,UI,UN,UP,UPK,URC,US,UTL,VAC,VAN,VN,VT,VTS,WB,WD,WE,WH,WI,WM,WO,WTV,WW,XP,XT,ZZZ,")]
    public class X12_ID_152
    {
    }

    /// <summary>
    /// Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,2,3,4,A,A1,A2,A3,A4,AA,AD,AE,AF,AG,AH,AI,AJ,AL,AM,AN,AO,AP,AR,AV,AW,B,BA,BC,BD,BE,BF,BR,C,C1,C2,CA,CB,CC,CR,CS,CT,CU,CV,D,DA,DC,DP,DR,DS,DT,E,EA,EE,ER,F,FP,FT,G,GO,H,HA,HB,HC,HD,HR,I,IB,IR,J,K,L,MT,N,ND,NF,NH,NO,NP,NS,NT,O,OA,OB,OF,OH,ON,P,PA,PB,PC,PD,PE,PF,PG,PH,PI,PJ,PK,PL,PM,PN,PO,PP,PQ,PR,PS,PT,PU,PV,PW,PX,R,RA,RB,RC,RD,RI,RL,S,SA,SB,SC,SI,T,TM,UA,UB,UC,UD,UE,UR,UV,V,VA,VD,W,WE,WH,WR,X,Y,Z,ZZ,")]
    public class X12_ID_157
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
    [EdiCodes(",AL,CL,CN,CU,HT,IN,LD,LE,PL,PU,RT,SL,SU,TL,UL,WL,")]
    public class X12_ID_163
    {
    }

    /// <summary>
    /// Time Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,")]
    public class X12_ID_176
    {
    }

    /// <summary>
    /// Quantity or Status Adjustment Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,51,52,53,54,55,56,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AN,")]
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
    [EdiCodes(",A,A1,A2,A3,B,C,CD,D,DR,E,F,G,H,I,J,K,L,M,N,ND,O,P,PA,Q,R,RG,RN,RT,S,T,U,V,W,WA,W" +
        "B,WG,WJ,X,Y,Z,")]
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
    [EdiCodes(",AD,AI,AR,B1,BD,BE,BO,CA,CM,CO,CS,CT,CU,D1,DC,DS,MB,MD,MR,NC,ND,PD,RB,RC,RD,RE,RL" +
        ",SC,SP,TL,")]
    public class X12_ID_202
    {
    }

    /// <summary>
    /// Hazardous Material Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",4,6,9,A,D,E,F,I,R,T,U,")]
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
    [EdiCodes(@",AMM,BAG,BAL,BBL,BDL,BEM,BIC,BIN,BKG,BLK,BOB,BOT,BOX,BRG,BSK,BXI,BXT,CAB,CAG,CAN,CAR,CAS,CBC,CBY,CCS,CHE,CHS,CLD,CNT,COL,CON,COR,CRD,CRT,CSK,CTN,CUB,CYL,DBK,DRK,DRM,DSK,DTB,ENV,FIR,FLO,FLX,FRM,FSK,FWR,HED,HGH,HPT,HRB,HRK,HTB,JAR,JUG,KEG,KIT,KRK,KTB,LBK,LIF,LOG,LSE,LUG,LVN,MRP,NOL,OVW,PAL,PCK,PCS,PIR,PKG,PLF,PLN,PLT,POV,PRK,QTR,RAL,RCK,REL,ROL,RVR,SAK,SBC,SHK,SID,SKD,SKE,SLP,SLV,SPI,SPL,TBE,TBN,TKR,TKT,TLD,TNK,TRC,TRI,TRK,TRY,TSS,TTC,TUB,UNP,UNT,VEH,VPK,WHE,WLC,WRP,")]
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
        ",NN,NP,NR,NT,NU,NV,OR,PK,PR,RV,SP,SY,TD,TH,TN,TR,VA,VC,VM,")]
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
    [EdiCodes(",A,B,C,D,F,G,H,K,L,M,R,S,T,")]
    public class X12_ID_231
    {
    }

    /// <summary>
    /// Product/Service ID Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",A1,A2,A3,A4,A6,A7,A8,A9,AA,AB,AC,AD,AE,AH,AI,AJ,AK,AM,AN,AO,AP,AR,AS,AT,AW,AX,AY,AZ,B1,B2,B3,B4,B5,B6,B7,BA,BB,BC,BD,BE,BF,BG,BH,BL,BM,BN,BO,BP,BS,BT,BU,BX,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CL,CM,CN,CO,CP,CQ,CR,CS,CT,CU,CV,CY,DE,DG,DI,DL,DN,DP,DR,DX,DZ,EC,ED,EI,EL,EM,EN,EP,EQ,ES,EX,F1,F2,F3,F4,F5,F7,F8,FA,FB,FF,FI,FL,FM,FN,FP,FS,FT,FW,GC,GD,GK,GN,GR,GS,GU,HC,HD,HI,HN,IA,IB,IC,ID,IM,IN,IP,IS,IT,IW,IZ,JN,JP,JS,KA,KB,KP,LC,LG,LS,LT,LU,MA,MB,MC,MD,MF,MG,MI,MM,MN,MO,MS,MT,N1,N2,N3,N4,NC,ND,NH,NR,NU,NW,NZ,OA,OB,OC,OD,OE,OF,OG,OH,OI,OL,ON,OO,OP,P1,P2,P3,P4,PA,PB,PC,PD,PE,PF,PG,PH,PI,PJ,PK,PL,PM,PN,PO,PP,PQ,PR,PS,PT,PU,PV,PW,PY,PZ,R1,R2,RA,RB,RC,RD,RE,RF,RK,RN,RO,RP,RR,RS,RT,RU,RV,RW,RY,SA,SB,SC,SD,SE,SF,SH,SI,SK,SL,SM,SN,SP,SQ,SR,SS,ST,SU,SV,SW,SZ,TA,TC,TI,TM,TN,TP,TR,TS,TT,TU,TV,TX,TY,U2,UA,UB,UC,UD,UE,UF,UG,UH,UI,UK,UL,UM,UN,UO,UP,UQ,US,UT,UV,VA,VB,VC,VE,VI,VM,VN,VO,VP,VS,VU,VV,VX,W1,W2,W5,WL,WS,XA,XC,XP,XQ,YP,ZB,ZZ,")]
    public class X12_ID_235
    {
    }

    /// <summary>
    /// Price Identifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",ACT,AGC,ALT,AWP,BCH,C01,C02,C03,C04,C05,C06,C07,C08,C09,C10,C11,C12,C13,C14,C15,C16,C17,C18,C19,C20,C21,C22,C23,C24,C25,C26,C27,C28,C29,C30,CAT,CDF,CDV,CHG,CON,CUP,CUS,DAP,DIS,DPR,DSC,DSD,DSP,EDM,EDP,EDS,EDW,EST,EUP,FCH,FDS,FET,FGP,FUL,FUP,GOV,ICL,IND,INS,INV,LPR,MAP,MAS,MAX,MIN,MNC,MNR,MPR,MSR,MXR,N01,N02,N03,N04,N05,N06,N07,N08,N09,N10,N11,N12,N13,N14,N15,N16,N17,N18,N19,N20,N21,N22,N23,N24,N25,N26,N27,N28,N29,N30,NET,OAP,OPP,PAQ,PBQ,PBR,PIE,PPD,PRF,PRO,PRP,PUR,QTE,RES,RTL,SDP,SFP,SHD,SLP,SPC,SPE,STA,SUM,SWP,THP,TOT,TRF,UCP,WHL,ZNP,")]
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
        ",28,29,30,31,32,33,34,35,36,37,38,39,40,")]
    public class X12_ID_246
    {
    }

    /// <summary>
    /// Allowance or Charge Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,C,N,R,")]
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
    [EdiCodes(",A,B,C,D,E,F,G,H,I,J,K,P,S,V,W,X,Y,Z,")]
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
    /// Geography Qualifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,D,F,I,L,O,P,T,U,")]
    public class X12_ID_262
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
    [EdiCodes(",09,9A,AC,AE,AM,BC,CE,D1,D2,D3,FC,IA,ME,ND,NF,NM,NS,ON,PA,PB,PI,PM,PN,PO,PR,PS,SA" +
        ",SC,SD,SE,SM,ST,ZZ,")]
    public class X12_ID_284
    {
    }

    /// <summary>
    /// Product/Service Condition Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,ZZ,")]
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
    [EdiCodes(",AAD,ADR,ALR,ALV,ARD,ARI,ARR,BAD,BFR,BHV,BLG,CRD,CSL,DDL,DFL,DRM,EAD,EDD,EFT,ERD," +
        "FTE,HAR,HMI,HRE,IBD,ICH,ICR,IRD,NOB,PAC,PCO,PFP,RAM,REC,RLO,RMT,RYD,SLD,SPT,STN," +
        "STP,STS,STU,TMA,TMD,TRN,TRP,UNS,ZZZ,")]
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
    [EdiCodes(",1,15,2,3,4,5,51,6,7,8,9,A,AC,AD,AI,AV,AW,AX,BO,C,CO,CT,D,DC,DP,DS,E,ER,EX,F,FR,H" +
        ",I,IN,K,KA,L,LC,M,N,NA,ND,O,OR,P,PF,PI,Q,R,R2,R3,R4,R5,RC,RE,RF,RO,RS,T,U,V,W,W1" +
        ",WQ,Z,")]
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
    [EdiCodes(",AC,AP,AR,BE,BL,BS,CA,CC,CD,CI,CL,CO,CR,CS,CY,D,DC,DE,DR,DT,FA,FE,FF,FI,FR,FT,FV," +
        "GL,IA,IM,IP,IS,IT,K,MI,MS,NS,OA,OL,OR,OV,PA,PE,PL,PP,PQ,PR,PS,PT,PU,RA,RC,RE,RG," +
        "RJ,RL,RS,RT,SB,SC,SD,SG,SL,SN,SP,SS,ST,SW,TA,TC,TL,TM,TN,TR,TX,UN,UR,VS,W,WF,WH," +
        "ZN,ZZ,")]
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
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,18,ZZ,")]
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
    [EdiCodes(",1N,CAF,CFR,CIF,CIP,CPT,DAF,DDP,DDU,DEQ,DES,DOM,DUP,EXQ,EXS,EXW,FAS,FCA,FCI,FCP,F" +
        "OB,FOR,FOT,NPF,PPF,ZZZ,")]
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
    [EdiCodes(",1,100,101,2,3,40,41,42,43,44,45,46,47,48,490,491,499,5,50,501,502,503,504,505,50" +
        "6,507,508,509,51,510,511,512,513,514,515,516,517,518,519,52,520,521,522,523,524," +
        "525,526,53,537,54,55,57,58,60,61,62,63,64,65,66,67,70,80,88,90,91,92,93,94,95,96" +
        ",97,990,999,")]
    public class X12_ID_340
    {
    }

    /// <summary>
    /// Unit of Time Period or Interval
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AD,AM,AY,BD,CC,CY,DA,DW,DY,EL,F1,F2,FY,HR,KK,KL,LN,LT,MO,MS,MT,NX,PR,Q1,Q2,Q3,Q4" +
        ",QY,SA,SD,SH,WK,WW,")]
    public class X12_ID_344
    {
    }

    /// <summary>
    /// Lead Time Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AS,AT,AU,AZ,")]
    public class X12_ID_345
    {
    }

    /// <summary>
    /// Application Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47" +
        ",48,AN,BH,BL,BN,DO,FR,HR,LT,MF,")]
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
    [EdiCodes(",00,01,02,03,04,05,06,07,08,10,11,12,13,14,15,16,17,18,19,20,21,22,25,26,27,28,30" +
        ",31,32,33,34,35,36,37,38,41,42,43,44,45,46,47,48,49,50,5C,77,CN,ZZ,")]
    public class X12_ID_353
    {
    }

    /// <summary>
    /// Unit or Basis for Measurement Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,08,10,11,12,13,14,15,16,17,18,19,1A,1B,1C,1D,1E,1F,1G,1H,1I,1J,1K" +
        ",1L,1M,1X,20,21,22,23,24,25,26,27,28,29,2A,2B,2C,2F,2G,2H,2I,2J,2K,2L,2M,2N,2P,2" +
        "Q,2R,2U,2V,2W,2X,2Y,2Z,30,31,32,33,34,35,36,37,38,3A,3B,3C,3E,3F,3G,3H,3I,40,41," +
        "43,44,45,46,47,48,4A,4B,4C,4D,4E,4F,4G,4H,4I,4J,4K,4L,4M,4N,4O,4P,4Q,4R,4S,4T,4U" +
        ",4V,4W,4X,50,51,53,54,56,57,58,59,5A,5B,5C,5E,5F,5G,5H,5I,5J,5K,5P,5Q,60,61,62,6" +
        "3,64,65,66,67,68,69,70,71,72,73,74,76,77,78,79,80,81,82,83,84,85,86,87,89,90,91," +
        "92,93,94,95,96,97,98,A8,A9,AA,AB,AC,AD,AE,AF,AH,AI,AJ,AK,AL,AM,AN,AP,AQ,AR,AS,AT" +
        ",AU,AV,AW,AX,AY,AZ,B0,B1,B2,B3,B4,B5,B6,B7,B8,B9,BA,BB,BC,BD,BE,BF,BG,BH,BI,BJ,B" +
        "K,BL,BM,BN,BO,BP,BQ,BR,BS,BT,BU,BV,BW,BX,BY,BZ,C0,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA," +
        "CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CQ,CR,CS,CT,CU,CV,CW,CX,CY,CZ,D3,D5" +
        ",D8,D9,DA,DB,DC,DD,DE,DF,DG,DH,DI,DJ,DK,DL,DM,DN,DO,DP,DQ,DR,DS,DT,DU,DX,DY,DZ,E" +
        "1,E3,E4,E5,E7,E8,E9,EA,EB,EC,ED,EF,EM,EP,EQ,EV,EX,EY,EZ,F1,F9,FA,FB,FC,FD,FE,FF," +
        "FG,FH,FL,FM,FO,FP,FR,FS,FT,FZ,G2,G3,G4,G5,G7,GA,GB,GC,GD,GE,GF,GG,GH,GI,GJ,GK,GL" +
        ",GM,GN,GO,GP,GQ,GR,GS,GT,GV,GW,GX,GY,GZ,H1,H2,H4,HA,HB,HC,HD,HE,HF,HG,HH,HI,HJ,H" +
        "K,HL,HM,HN,HO,HP,HR,HS,HT,HU,HV,HW,HY,HZ,IA,IB,IC,IE,IF,II,IL,IM,IN,IP,IT,IU,IV," +
        "IW,J2,JB,JE,JG,JK,JM,JO,JR,JU,K1,K2,K3,K4,K5,K6,K7,KA,KB,KC,KD,KE,KF,KG,KH,KI,KJ" +
        ",KK,KL,KM,KO,KP,KQ,KR,KS,KT,KV,KW,KX,L2,LA,LB,LC,LD,LE,LF,LG,LH,LI,LJ,LK,LM,LN,L" +
        "O,LP,LQ,LR,LS,LT,LX,LY,M0,M1,M2,M3,M4,M5,M6,M7,M8,M9,MA,MB,MC,MD,ME,MF,MG,MH,MI," +
        "MJ,MK,ML,MM,MN,MO,MP,MQ,MR,MS,MT,MU,MV,MW,MX,MY,MZ,N1,N2,N3,N4,N6,NA,NB,NC,ND,NE" +
        ",NF,NG,NH,NI,NJ,NL,NM,NN,NQ,NR,NS,NT,NU,NV,NW,NX,NY,OA,ON,OP,OT,OZ,P0,P1,P2,P3,P" +
        "4,P5,P6,P7,P8,P9,PA,PB,PC,PD,PE,PF,PG,PH,PI,PJ,PK,PL,PM,PN,PO,PP,PQ,PR,PS,PT,PU," +
        "PV,PW,PX,PY,PZ,Q1,Q2,Q3,Q4,Q5,Q6,Q7,QA,QB,QD,QH,QK,QR,QS,QT,QU,R1,R2,R3,R4,R5,R6" +
        ",R7,R9,RA,RD,RE,RG,RH,RK,RL,RM,RN,RO,RP,RS,RT,RU,S3,S4,S5,S6,S7,S8,S9,SA,SB,SC,S" +
        "D,SE,SF,SG,SH,SI,SJ,SK,SL,SM,SN,SO,SP,SQ,SR,SS,ST,SU,SV,SW,SX,SY,T0,T1,T2,T3,T4," +
        "T5,T6,T7,T8,T9,TA,TB,TC,TD,TE,TF,TG,TH,TI,TJ,TK,TL,TM,TN,TO,TP,TQ,TR,TS,TT,TU,TV" +
        ",TW,TX,TY,TZ,U1,U2,U3,U5,UA,UB,UC,UD,UE,UF,UH,UL,UM,UN,VA,VC,VI,VS,VT,W2,W4,WA,W" +
        "B,WE,WG,WH,WI,WK,WM,WP,WR,WT,WU,WW,X1,YD,YL,YR,YT,Z1,Z2,Z3,Z4,Z5,Z6,Z8,ZP,ZZ,")]
    public class X12_ID_355
    {
    }

    /// <summary>
    /// Note Reference Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",ACC,ACI,ACT,ADD,ALL,APS,BOL,CER,CHG,CLR,CUS,DEL,DGN,DOD,EXR,GEN,GPI,GSI,INS,INT," +
        "INV,LAB,LEN,LIN,LOC,LOI,MFG,NCD,ORA,ORI,OTH,PAY,PCS,PDS,PES,PKG,PMT,PPC,PRI,PUR," +
        "QUT,REC,REV,ROU,SPH,TAF,TCF,TIL,TLF,TPO,TRA,TRF,TRS,TSF,WHI,WRP,ZZZ,")]
    public class X12_ID_363
    {
    }

    /// <summary>
    /// Communication Number Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AP,AU,BN,CP,DN,ED,EM,EX,FT,FX,HP,IT,MN,NP,PS,TE,TL,TM,TX,WP,")]
    public class X12_ID_365
    {
    }

    /// <summary>
    /// Contact Function Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1A,1B,1C,1D,A1,AA,AB,AC,AD,AE,AF,AG,AH,AI,AL,AM,AN,AP,AR,AS,AT,AU,BB,BC,BD,BI,BP,BU,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CR,CS,CT,CU,CW,CX,DA,DC,DD,DE,DI,DM,DN,DV,EA,EB,EC,ED,EF,EG,EM,EN,EP,EX,FA,FC,FL,FM,GC,GR,HM,IC,IO,IP,KA,LD,MA,MC,MD,ME,MG,NA,NC,NP,NT,OC,OD,OW,PA,PB,PC,PD,PE,PF,PG,PH,PI,PJ,PL,PM,PO,PP,PR,PS,PU,PX,PZ,QA,QC,QI,QM,QP,QR,RA,RC,RD,RE,RG,RP,RS,RZ,SA,SC,SD,SE,SH,SK,SM,SO,SP,SR,ST,SU,SV,SY,TA,TC,TD,TH,TM,TP,TR,UG,UP,VM,VP,WH,WI,WR,ZZ,")]
    public class X12_ID_366
    {
    }

    /// <summary>
    /// Shipment/Order Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",AB,AN,AS,AU,AV,BK,BM,BO,BP,BT,BW,CA,CB,CC,CE,CI,CK,CL,CM,CN,CO,CP,CS,CT,DD,DE,DO,DS,EC,ED,EW,FS,HQ,IC,ID,IN,IP,IS,LM,LS,LW,MC,NF,NN,NS,NY,OB,OF,OP,OR,PA,PD,PH,PI,PK,PL,PN,PO,PP,PR,PS,PT,QN,QP,RC,RD,RT,RW,SA,SB,SC,SD,SE,SF,SG,SH,SI,SJ,SK,SL,SP,SQ,SS,ST,SU,UB,UN,UR,WS,ZZ,")]
    public class X12_ID_368
    {
    }

    /// <summary>
    /// Change Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AQ,BB,BD,C1,C2,C3,C4,C5,C6,DC,EV,FE,GU,GW,LD,MC,PC,PQ,PS,QH,QO,QP,QT,SC,UM,UP,WD" +
        ",WO,ZZ,")]
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
        "203,204,206,207,208,209,210,211,212,213,214,215,216,217,218,219,220,221,222,223," +
        "224,225,226,227,228,229,230,231,232,233,234,235,236,237,238,239,240,241,242,243," +
        "244,245,246,247,248,249,250,251,252,253,254,255,256,257,258,259,260,261,262,263," +
        "264,265,266,267,268,269,270,271,272,273,274,275,276,277,278,279,280,281,282,283," +
        "284,285,286,287,288,289,290,291,292,293,294,295,296,297,298,299,300,301,302,303," +
        "304,305,306,307,309,310,311,312,313,314,315,316,317,319,320,321,322,323,324,327," +
        "328,329,330,331,332,333,334,335,336,337,338,339,340,341,342,343,344,345,346,347," +
        "348,349,350,351,352,353,354,355,356,357,358,359,360,361,362,363,364,365,366,367," +
        "368,369,370,371,372,373,374,375,376,377,378,379,380,381,382,383,384,385,386,387," +
        "388,389,390,391,392,393,394,395,396,397,398,399,400,401,402,403,404,405,406,408," +
        "409,410,411,412,413,414,415,416,417,418,419,420,421,422,423,424,425,426,427,428," +
        "429,430,431,432,434,435,436,437,438,439,440,441,442,443,444,445,446,447,448,449," +
        "450,451,452,453,454,455,456,457,458,459,460,461,462,463,464,465,466,467,468,469," +
        "470,471,472,473,474,475,476,477,478,479,480,481,482,483,484,485,486,487,488,489," +
        "490,491,492,493,494,495,496,497,498,499,500,501,502,503,504,505,506,507,508,509," +
        "510,511,512,513,514,515,516,517,518,519,520,521,522,523,524,525,526,527,528,529," +
        "531,532,533,534,535,536,537,538,539,540,541,542,543,544,545,546,547,548,549,550," +
        "551,552,553,554,555,556,557,558,559,560,561,562,563,564,565,566,567,568,569,570," +
        "571,572,573,574,575,576,577,578,579,580,581,582,583,584,585,586,587,589,590,591," +
        "592,593,594,595,596,597,598,600,601,602,700,701,702,703,704,706,993,994,996,997," +
        "ZZZ,")]
    public class X12_ID_374
    {
    }

    /// <summary>
    /// Tariff Service Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1A,1B,2A,2B,BB,BD,BM,BO,BP,BR,DB,DD,DM,DO,DP,DR,HH,HP,MB,MD,ML,MM,MO,MP,MR,OC,OD" +
        ",OM,OR,OT,PB,PD,PH,PM,PP,PR,RB,RD,RM,RO,RP,RR,")]
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
    [EdiCodes(",1,2,3,4,5,6,7,8,9,Z,")]
    public class X12_ID_378
    {
    }

    /// <summary>
    /// Bid Type Response Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AB,BI,BW,DQ,OM,RE,RT,UQ,")]
    public class X12_ID_379
    {
    }

    /// <summary>
    /// Price Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,P,Q,S,T,X,")]
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
    [EdiCodes(",1,2,")]
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
    [EdiCodes(@",20,2B,40,4B,AC,AF,AL,AP,AT,BC,BE,BF,BG,BH,BJ,BO,BR,BX,CA,CB,CC,CD,CG,CH,CI,CJ,CK,CL,CM,CN,CP,CQ,CR,CS,CT,CU,CV,CW,CZ,DD,DF,DT,DX,ET,FH,FN,FP,FR,FS,FT,FX,GS,HB,HC,HO,HP,HT,HV,HY,ID,IX,LO,LU,NX,OB,OT,OV,PP,PT,PU,RA,RC,RD,RE,RF,RG,RI,RO,RR,RS,RT,SA,SC,SD,SK,SL,SR,SS,ST,SV,TA,TB,TC,TF,TG,TH,TI,TJ,TK,TL,TM,TN,TO,TP,TQ,TR,TT,TU,TV,TW,UA,UB,UC,UD,UE,UL,UP,VA,VE,VL,VR,VS,VT,WR,WY,")]
    public class X12_ID_40
    {
    }

    /// <summary>
    /// Unit Load Option Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,")]
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
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,16,")]
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
        "9,ZZ,")]
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
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,A1,A2,A3,A4,A5,A6,A7,A8,A9,AA,AB,AC,AD,AE,AN,B1,B2,B3,B4,B5,B6,B7,B8,B9,BR,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CN,CO,CP,CQ,D1,D2,D3,D4,D5,D6,D7,D8,D9,DB,DC,DD,DF,DI,DJ,DO,DP,DR,DS,DT,DV,DW,E1,E2,E3,E4,E5,E6,E7,E8,E9,F1,F3,F4,F5,F6,F7,F8,F9,G1,G2,G3,G4,G5,G6,G7,G8,G9,H1,H2,H3,H4,H5,H6,H7,H8,H9,J1,J2,J3,J4,J5,J6,J7,J8,J9,K1,K2,K3,L1,L2,L3,L4,L5,L6,L7,L8,L9,LP,M1,M2,M3,M4,PD,PP,W6,W7,W8,W9,WA,WB,WC,WO,WR,WS,WT,WU,WW,WY,ZZ,")]
    public class X12_ID_426
    {
    }

    /// <summary>
    /// Date Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,66,67,68,69,70,71,72,73,74,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,AA,AB,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BO,BP,BQ,BR,BS,BT,BU,BV,BW,BX,BY,BZ,CA,KA,LA,LD,PE,TA,TR,")]
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
    [EdiCodes(",0,1,2,3,4,5,6,7,8,9,A,B,C,E,L,R,U,")]
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
    [EdiCodes(",01,02,03,04,05,06,07,08,09,")]
    public class X12_ID_448
    {
    }

    /// <summary>
    /// In-bond Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",61,62,63,64,")]
    public class X12_ID_450
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
    [EdiCodes(",B,C,D,E,F,G,N,R,S,T,X,")]
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
    [EdiCodes(@",AA,AG,AI,AK,AL,AN,AR,AW,BE,BS,CA,CD,CF,CG,CH,CI,CO,CP,CR,CS,CT,D3,D4,D5,DA,DD,DI,DM,DX,ED,ER,FA,FB,FG,FH,FR,FT,GB,GC,GF,GP,GR,HB,HC,HN,HP,HR,HS,IA,IB,IC,IG,II,IJ,IM,IN,IO,IP,IR,IS,LB,LN,LR,LS,LT,MA,MC,MD,MG,MI,ML,MO,MR,MS,MT,MV,MW,MX,NC,OG,OR,OW,PA,PC,PD,PJ,PK,PM,PO,PR,PS,PT,PV,PY,PZ,QG,QM,QO,QW,RA,RC,RE,RI,RM,RN,RO,RP,RQ,RR,RS,RT,RU,RY,RZ,SA,SB,SC,SE,SG,SH,SI,SL,SM,SO,SP,SQ,SR,SS,SV,SW,TA,TD,TF,TI,TP,TR,TS,TX,UC,UW,VA,VB,VH,WA,WB,WR,WT,")]
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
    [EdiCodes(",AE,AI,AJ,EE,EI,ER,FL,NS,PA,PE,PI,PO,PP,")]
    public class X12_ID_482
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
    [EdiCodes(",A,C,D,F,R,")]
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
    [EdiCodes(",A,B,C,F,J,K,N,O,R,S,X,Y,")]
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
    [EdiCodes(",1,10,11,12,13,14,15,16,17,2,3,4,5,6,7,8,9,")]
    public class X12_ID_52
    {
    }

    /// <summary>
    /// Product Transfer Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BO,BP,BQ,BR,CC,CO,DS,FG,IA,IB,OF,ON,PA,PB" +
        ",PL,PM,PO,RA,RB,RC,RP,RU,RV,SA,SC,SD,SH,SM,SS,SU,TD,WL,")]
    public class X12_ID_521
    {
    }

    /// <summary>
    /// Amount Qualifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59,6,60,61,62,63,64,65,66,67,68,69,7,70,71,72,73,74,75,76,77,78,79,8,80,81,82,83,84,85,86,87,88,89,9,90,91,92,93,94,95,96,97,98,99,A,A1,A2,A3,A4,A5,A6,A7,A8,A9,AB,AC,AD,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,AX,AY,AZ,B,B1,B2,B3,B4,B5,B6,B7,B8,B9,BA,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BO,BR,BS,BT,BU,BV,BW,BX,BY,BZ,C,C1,C2,C3,C4,C5,C6,C7,C8,C9,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CQ,CS,CT,D,D1,D2,D3,D4,D5,D6,D7,D8,DA,DB,DC,DD,DE,DF,DG,DH,DY,E,E1,E2,E3,E4,E5,E6,E7,E8,E9,EA,EB,EC,ED,EF,EP,F,F1,F2,F3,F4,F5,F6,F7,F8,F9,FC,FD,FI,FL,FM,FO,FP,H,I,I1,IB,IC,II,IP,IR,IU,J,K,KA,KB,KC,KD,KE,KF,KG,KH,KI,KJ,KK,KL,KM,KN,KO,KP,KQ,KS,KT,KU,KW,KX,KZ,L,L1,LC,LE,LI,LM,LN,LP,LW,LX,LY,LZ,M,M1,M2,MA,MB,MC,MN,MO,MP,MR,MS,N,N1,NA,NB,NC,ND,NF,NL,NO,NP,NQ,NR,NS,NY,OB,OL,OP,P,P1,P2,P3,P4,P5,P6,P7,P8,P9,PA,PB,PC,PE,PF,PG,PH,PI,PL,PM,PN,PO,PP,PQ,PR,PS,PT,PW,PX,PY,PZ,Q,Q1,QN,RB,RC,RD,RH,RP,RR,RS,RT,RW,RZ,S,S1,S2,S3,S4,S5,S6,S7,SA,SB,SC,SE,SI,SM,SS,ST,T,T1,T2,T3,TA,TB,TC,TD,TE,TF,TG,TL,TM,TP,TS,TT,TX,TY,U2,UA,UB,UC,UG,UP,US,W,W1,W2,W3,W4,WK,X,Y1,Z1,Z2,Z3,ZA,ZB,ZC,ZD,ZE,ZF,ZG,ZH,ZI,ZJ,ZK,ZL,ZM,ZN,ZO,ZZ,")]
    public class X12_ID_522
    {
    }

    /// <summary>
    /// Inventory Transaction Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AD,AJ,CM,DM,DU,IT,PA,RC,RD,RE,RT,WH,")]
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
    [EdiCodes(",CR,DC,DN,DS,FP,NR,OH,PF,PP,SP,WD,")]
    public class X12_ID_546
    {
    }

    /// <summary>
    /// Interest Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",D,M,")]
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
    [EdiCodes(",94,AA,AB,AC,AD,AE,AH,AI,AP,AS,AT,AW,AX,BE,BF,BI,CA,CB,CC,CI,CM,CR,CX,DA,DD,DE,DI" +
        ",DO,DR,EI,EP,ES,EU,EX,FA,FD,FI,GC,GS,GU,HC,HI,IA,IM,IS,JA,LI,MB,MC,ME,MI,MP,MS,N" +
        "A,NE,NF,NI,NR,NT,NW,OP,OS,PA,SA,SE,SL,SP,ST,TA,TB,TC,TD,TI,TM,TR,TX,UN,VI,WH,ZZ," +
        "")]
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
    [EdiCodes(@",A0010,A0020,A0030,AC,AD,AF,AG,AM,AO,B0020,B0040,BH,BI,C0012,C0032,C0036,C0038,C1,CA,CH,CI,CM,CN,CS,CT,CU,CY,CZ,D0020,D0024,D0031,D1,D2,DE,DI,DL,DS,E0030,EG,EM,EN,ER,EU,EX,F1,FG,FS,G0010,G0052,GI,GP,GU,H1,HC,HH,HS,I0012,I0013,I0021,I0022,IC,ID,IG,IK,IL,IM,IN,IO,IP,IQ,IR,IS,IT,KO,L1,LA,LS,M0010,M0042,MI,ML,N0020,N0021,N0032,NC,OA,ON,P0012,P0014,P0016,P0018,P0022,PA,PB,PC,PE,PF,PL,PLI,PM,PO,PP,PSF,R0072,R0076,R0077,R0110,RE,RM,RP,S0014,S0016,S0022,S0024,S0050,S0052,S0054,S0056,S0080,S1,S2,S3,SD,SG,SH,SJ,SPI,SR,SS,ST,SU,SV,SW,T0070,T1,TC,TE,TH,TM,TO,UN,US,V1,V2,W0010,WH,X0010,XP,XX,YY,ZZ,")]
    public class X12_ID_560
    {
    }

    /// <summary>
    /// Rate or Value Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AB,AE,OI,UA,UT,")]
    public class X12_ID_562
    {
    }

    /// <summary>
    /// Sales Requirement Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,BK,C,F,FT,GS,IS,K,N,O,P,P2,P3,P4,Q,R,S,SC,SE,SF,SG,SL,SP,SQ,SS,ST,SU,SV,SW,T,W" +
        ",Y,Z,")]
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
    [EdiCodes(",EPC,LTD,REL,ZB1,ZB2,")]
    public class X12_ID_569
    {
    }

    /// <summary>
    /// Freight Bill Disposition Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,")]
    public class X12_ID_57
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
    [EdiCodes(",A,D,R,")]
    public class X12_ID_580
    {
    }

    /// <summary>
    /// Bill of Lading Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",00,01,10,11,12,13,14,15,16,")]
    public class X12_ID_582
    {
    }

    /// <summary>
    /// Employment Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,AD,AF,AO,AP,AU,CO,CT,DC,DI,DQ,DR,DS,FA,FB,FC,FO,FT,IA,L1,LA,LE,LM,LS,LU" +
        ",LW,NE,OS,PT,RA,RI,RM,RP,RT,RU,RW,SA,SE,SL,SU,TE,UK,VO,ZZ,")]
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
    [EdiCodes(",ACH,BKW,BOP,CHK,CWT,DCC,DCD,DPC,DPD,DXC,DXD,DZC,DZD,FEW,FWT,NON,PAC,PBD,PDC,PDD," +
        "PRO,REV,SCC,SCD,SDC,SDD,SPC,SPD,SWT,SXC,SXD,SZC,SZD,X12,ZZZ,")]
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
    [EdiCodes(",1,2,3,4,5,6,7,9,A,B,Q,S,")]
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
    [EdiCodes(",BAG,BBL,BDL,BIC,BIN,BKT,BLE,BOX,BSK,CAN,CAR,CAS,CBC,CBY,CCS,CHS,CNT,COL,CRT,CSK," +
        "CTN,CYL,DBK,DRM,GAL,HED,HMP,KEG,LBK,LOG,LUG,LVN,PAL,PCL,PCS,PKG,PLT,POV,QTR,REL," +
        "ROL,SAK,SHT,SID,SKD,TBE,TBN,TIN,TNK,UNT,VPK,WDC,")]
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
    /// Deficiency Judgment Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,")]
    public class X12_ID_605
    {
    }

    /// <summary>
    /// Time Period Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34" +
        ",4,5,6,7,8,Z,")]
    public class X12_ID_615
    {
    }

    /// <summary>
    /// Time Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,CD,CS,CT" +
        ",ED,ES,ET,GM,LT,MD,MS,MT,PD,PS,PT,UT,")]
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
    [EdiCodes(",03,AP,AW,BD,BR,BW,CA,CP,CR,CT,DI,DP,DR,DS,EC,ES,FB,FO,FX,HF,HP,KP,KR,LC,LD,LE,LM" +
        ",LR,ME,NC,NE,NQ,NT,PA,PB,PD,PE,PF,PM,PN,PO,PP,PQ,PR,PS,PT,PU,PV,PY,QE,QH,QR,QS,Q" +
        "T,RC,RD,RE,RM,RS,RT,SA,SC,SM,SR,ST,SW,TB,TC,TD,TE,TF,TM,TP,UM,VQ,WC,WD,WE,WH,WI," +
        "WM,")]
    public class X12_ID_639
    {
    }

    /// <summary>
    /// Transaction Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,13,14,15,16,17,18,19,60,A0,A1,A3,AC,AD,AF,AI,AM,AN,AP,AQ,AR,AS,AV,AW,AZ,BA,BB,BH,BL,BM,BN,BO,BP,BS,CA,CB,CC,CD,CE,CF,CG,CH,CI,CM,CN,CO,CP,CR,CS,CT,CV,D1,D4,DA,DB,DC,DD,DE,DF,DG,DH,DI,DN,DO,DP,DQ,DR,DS,DU,EA,EB,EF,EI,EP,ER,FA,FB,FC,FD,FE,FN,FP,FT,GA,GI,HP,IA,IB,IC,ID,IF,II,IN,IO,IR,IU,IW,IZ,JM,JO,JR,LC,LD,LE,LN,LO,LP,LR,MA,MC,ME,MF,MI,ML,MM,MR,MS,NA,NB,NC,ND,NE,NF,NG,NH,NI,NJ,NK,NL,NM,NP,NQ,NR,NT,NU,PA,PB,PG,PI,PL,PM,PO,PP,PR,PS,PT,QD,QG,QP,QR,RA,RB,RC,RE,RF,RG,RP,S1,S2,S3,SA,SD,SG,SL,SM,SP,SR,SS,SU,SV,TD,TG,TH,TI,TJ,TK,TP,TR,TS,U1,U2,U3,U4,U9,UC,UF,UI,UR,V1,W1,W4,W5,WA,WD,WO,WS,ZZ,")]
    public class X12_ID_640
    {
    }

    /// <summary>
    /// Status Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",001,002,003,004,005,006,007,008,009,010,011,012,013,014,015,016,017,018,019,020,021,022,023,024,025,026,027,028,029,030,031,A01,A02,A03,A04,A05,A06,A07,A08,A09,A10,A11,A12,A13,A14,A15,A16,A17,A18,A19,A20,A21,A22,A23,A24,A25,A26,A27,A28,A29,A30,A31,A32,A33,A34,A36,A37,A38,A39,A40,A41,A42,A43,A45,A46,A49,A50,A51,A52,A55,A58,A59,A61,A63,A64,A65,A73,A74,A84,A91,A95,A96,A98,A99,ABN,ACC,ACD,AGC,AGD,B01,B02,B03,B04,B05,B06,B07,B08,B09,B10,B11,B12,B13,B14,B15,B16,B17,B18,B19,B20,B21,B22,B23,B24,B25,B26,B27,B28,B29,B30,B31,B32,B33,B34,B35,B36,B37,B38,B39,B40,B41,B42,B43,B44,B45,B46,B47,B48,B49,B50,B51,C01,C02,C03,C04,C05,C06,C07,C08,C09,C10,C11,C12,D01,D02,D03,D04,D05,D06,D07,D08,D09,D10,D11,D12,D13,D14,D15,D16,D17,D18,D19,D20,D21,D22,D23,D24,D25,D26,D27,D28,D29,D30,D50,EB1,EB2,EB3,EB4,EB5,EB6,EB7,EB8,EB9,EBA,ENR,ERR,F73,F74,IV1,IV2,NOR,P01,P02,P03,P04,P05,P06,P07,S01,T01,T02,T03,T04,T05,T06,T07,UCD,UND,W01,W02,W03,W04,W05,W06,W07,W08,W09,W10,W11,W12,W13,W14,W15,W16,WTP,ZZZ,")]
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
    [EdiCodes(@",001,002,003,004,005,006,007,008,009,010,011,012,024,036,500,801,802,803,804,805,806,807,808,809,810,811,812,813,814,815,817,818,819,820,821,822,823,824,825,826,827,828,829,830,831,832,833,834,847,A,ASA,ASV,AVE,B,C,CAL,COV,CUR,D,DBL,DDT,DRC,DTE,DUP,E,F,G,H,I,ICA,ICG,IDC,IMD,INC,INF,IPR,J,K,LOC,MBL,NAU,NCL,NCR,NDP,NDT,NIF,NOD,NRA,OTH,PND,PPD,PRM,QTY,RAT,RTE,SCA,SCD,SEV,SPL,STR,TRN,TYP,UAU,UCN,UKN,UNV,VIN,VND,VOS,ZDS,ZZZ,")]
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
    [EdiCodes(@",1,10,11,12,13,14,15,16,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34,35,36,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,53,54,55,56,57,6,61,62,63,7,71,72,73,74,75,76,77,78,8,81,82,9,91,92,93,94,95,96,97,98,A1,A2,AA,AC,AD,AE,AL,AP,BC,BD,BE,BG,BS,C,C1,C2,CC,CD,CI,CL,CP,CS,DG,DL,DN,DS,EH,EI,FA,FI,FJ,GA,GC,HN,LI,LN,M3,M4,MB,MC,MD,MI,MK,MP,MR,N,NI,OC,PA,PC,PI,PP,SA,SD,SI,SJ,SL,SP,ST,UP,US,ZN,ZY,ZZ,")]
    public class X12_ID_66
    {
    }

    /// <summary>
    /// Configuration Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,D,I,S,")]
    public class X12_ID_661
    {
    }

    /// <summary>
    /// Price Relationship Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,D,I,O,")]
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
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,B,C,D,H,M,N,P,R,")]
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
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,1A,1B,1C,1D,1E,1F,1G,1H,1I,1J,1K,1L,1M,1N,1O,1P,1Q,1R,1S,1T,1U,1V,1W,1X,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,45,46,47,48,49,50,51,52,53,54,55,56,57,58,60,61,62,63,64,65,66,67,68,69,70,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,A1,A2,A3,A4,A5,A6,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AO,AP,AQ,AR,AS,AT,AU,AV,AW,AX,AY,AZ,BA,BC,BF,BI,BQ,BR,CA,CB,CD,CE,CF,CG,CH,CI,CL,CO,CP,CR,CS,CW,D3,DB,DO,DP,DR,DT,DY,E1,E2,EC,EM,EP,ET,FB,FC,FT,GI,GL,GT,GV,HM,HO,HP,HR,HS,II,IN,IP,IQ,IT,K6,KA,KB,KC,KD,KE,KF,LA,LB,LE,LG,LI,LP,LT,LV,MA,MI,MN,MQ,NA,NC,NE,NN,NO,NP,NQ,NR,NS,OI,OR,OT,P3,P4,P5,P6,PA,PB,PC,PO,PP,PQ,PR,PS,PX,QA,QB,QC,QD,QE,QF,QH,QP,QR,QS,QU,RA,RB,SG,SP,SQ,ST,TA,TC,TD,TE,TO,TR,V1,V2,V3,VA,VR,VS,WV,XA,XB,XC,XD,XE,XG,XJ,XT,XU,XV,XX,XY,XZ,YA,YB,YC,YD,YE,YF,YG,YH,YJ,YK,YL,YM,YN,YP,YQ,YR,YS,YT,YW,YX,YY,Z1,Z2,Z3,Z4,Z6,ZA,ZB,ZC,ZD,ZE,ZF,ZG,ZH,ZI,ZJ,ZK,ZL,ZM,ZN,ZO,ZP,")]
    public class X12_ID_673
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
    [EdiCodes(",A,B,C,D,E,F,G,H,K,L,M,N,P,S,T,U,V,W,X,Z,")]
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
    [EdiCodes(",AG,BG,BR,CN,CO,CR,CX,CY,DE,DF,DI,EX,FS,GA,GM,GR,GV,HS,ID,IN,IR,JB,LC,MC,MF,ML,OE" +
        ",PF,PH,PY,RS,ST,TR,WC,WH,WS,")]
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
    [EdiCodes(",01,02,03,04,05,06,07,08,")]
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
    /// Financial Information Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class X12_ID_703
    {
    }

    /// <summary>
    /// Paperwork/Report Action Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,CH,CO,NT,ON,OR,SG,")]
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
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,31,32,33,34" +
        ",35,36,37,38,")]
    public class X12_ID_706
    {
    }

    /// <summary>
    /// Rating Category Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,BA,BC,BE,C2,CH,CO,CP,CR,CT,DP,EA,EC,EE,EI,FA" +
        ",IF,IN,LT,PA,PD,PS,PT,PU,RC,RS,RT,SE,SF,SP,SS,ST,TT,UT,WT,")]
    public class X12_ID_707
    {
    }

    /// <summary>
    /// Rating Summary Value Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,D,E,F,G,P,U,V,")]
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
    [EdiCodes(",A,E,M,P,R,X,")]
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
    [EdiCodes(",A,E,M,R,X,")]
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
    [EdiCodes(",1,2,3,4,5,6,7,")]
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
    [EdiCodes(",01,02,03,04,05,06,")]
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
    [EdiCodes(",1,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,34,35,36,37,38,4,5,56,6,7,8,9,A," +
        "AL,B,C,CA,CB,CC,CE,CH,CL,CT,D,DP,E,EL,F,FC,G,H,I,IA,IB,IC,J,K,L,M,ML,O,P,PA,PC,P" +
        "H,PL,Q,R,RA,RP,S,SA,SC,SE,SY,T,U,UT,V,W,WB,X,Y,ZZ,")]
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
    [EdiCodes(",9L,AA,AE,AV,BA,BD,BL,BM,BO,BP,BT,BZ,CA,CF,CH,CN,CO,CS,CT,CV,DE,DT,EA,EE,EN,FD,FV" +
        ",IN,IR,LC,LL,LM,LT,NC,NX,OD,OG,P1,PA,PC,PD,PK,PL,PM,PO,PR,PS,PT,R1,R2,RA,RG,RL,R" +
        "N,RO,RP,RQ,RS,RT,SD,SE,SF,SH,SK,SL,SM,SP,SR,ST,SU,TD,TE,TI,TL,TP,TR,TS,WA,WT,ZP," +
        "")]
    public class X12_ID_737
    {
    }

    /// <summary>
    /// Measurement Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,A1,A2,A3,A4,A5,A6,A7,A9,AA,AB,ABO,ABR,ABS,AC,ACN,AD,ADH,AE,AF,AG,AGE,AH,AI,AJ," +
        "AK,ALK,ALN,ALP,AMI,AMW,AOX,AP,APP,AS,ASH,ASY,AT,AVT,AZ,B,B1,B5,BA,BB,BC,BD,BDP,B" +
        "E,BF,BG,BH,BHF,BHS,BIC,BJ,BK,BL,BND,BO,BOR,BP,BQ,BR,BRS,BSW,BT,BU,BUD,BW,C,C1,C2" +
        ",C3,CA,CAU,CC,CCF,CD,CE,CF,CG,CGR,CH,CHA,CHC,CHG,CHL,CI,CIV,CJ,CK,CL,CLA,CM,CN,C" +
        "O,COL,CON,COR,COT,CP,CPF,CPS,CQ,CR,CS,CSC,CST,CU,CUT,CW,CX,CY,CYB,D,D1,D2,D3,D4," +
        "D5,DA,DAT,DB,DC,DCT,DD,DE,DEM,DF,DG,DH,DI,DIR,DIS,DJ,DL,DM,DME,DMF,DN,DP,DPM,DRY" +
        ",DS,DT,DU,DW,DWP,DY,E,E1,EA,EB,EC,ED,EE,EF,EG,EH,EI,EJ,EL,ELC,ELE,ELI,ELL,ELO,EL" +
        "P,ELS,ELT,ELV,ELW,ELX,EM,EN,EP,EVL,EVR,EW,EX,EXT,F,F1,FA,FB,FBP,FC,FD,FE,FF,FG,F" +
        "H,FI,FIL,FIN,FIT,FJ,FK,FL,FLD,FLN,FLP,FML,FMZ,FN,FNL,FNS,FOA,FOI,FOR,FP,FPV,FQ,F" +
        "R,FS,FSI,FT,FV,FW,FX,G,GA,GB,GC,GD,GE,GEL,GF,GG,GGR,GH,GI,GIR,GJ,GK,GL,GLE,GM,GN" +
        ",GO,GOR,GP,GQ,GR,GRA,GRI,GS,GT,GW,H1,H2O,HA,HAR,HAZ,HB,HC,HD,HE,HF,HG,HH,HHW,HI," +
        "HIB,HJ,HL,HM,HO,HOC,HP,HR,HT,HVM,HWS,HYD,HZ,HZC,IB,IC,ID,IDE,IF,IG,IGA,IGR,IH,II" +
        ",IJ,IK,IM,IMP,IN,IND,INS,IO,IP,IPI,IQ,IR,IS,IT,IU,IV,IW,IX,IY,IZ,JA,KA,KB,KN,L,L" +
        "1,LA,LB,LC,LC5,LD,LD5,LE,LEF,LF,LG,LIR,LIV,LL,LM,LN,LO,LOI,LOS,LOW,LP,LPG,LPR,LS" +
        ",LSS,LT,LTD,LW,M,M1,M2,M3,MA,MAT,MB,MC,MCN,MD,ME,MEF,MEL,MER,MF,MG,MH,MI,MIC,MJ," +
        "MK,MN,MO,MOI,MP,MPR,MS,MT,MTD,MU,MUL,MV,MW,MX,MY,N,NA,NB,NC,ND,NEU,NF,NG,NH,NI,N" +
        "J,NK,NL,NM,NO,NOC,NON,NOR,NP,NS,NU,O,O1,OA,OAP,OB,OBT,OC,OCG,OCR,OD,ODR,OE,OF,OG" +
        ",OH,OI,OIL,OJ,OK,OL,OM,ON,OO,OP,OQ,OR,ORC,OS,OT,OTH,OV,OW,OX,OXI,OXS,OY,PA,PAR,P" +
        "B,PBD,PC,PD,PDE,PDG,PE,PF,PFO,PG,PH,PHA,PHW,PI,PIC,PJ,PK,PL,PM,PN,PO,POC,POD,POP" +
        ",PP,PPS,PQ,PR,PRF,PRL,PRO,PRQ,PRY,PS,PSA,PSW,PT,PU,PV,PW,PWE,PX,PY,PZ,QA,QUR,R,R" +
        "10,R18,RA,RAD,RAF,RB,RC,RD,RE,REA,RED,REF,REI,REL,RES,RF,RG,RH,RI,RJ,RK,RL,RM,RN" +
        ",RO,RP,RQ,RR,RS,RT,RTB,RU,RUD,RV,RVP,RW,RX,RY,S,S1,S10,S12,S18,S2,S3,S4,S5,S6,S7" +
        ",S8,S9,SA,SAP,SB,SC,SD,SE,SF,SG,SH,SHA,SI,SIL,SJ,SK,SL,SLD,SLI,SM,SN,SO,SOD,SOF," +
        "SP,SPG,SPR,SQ,SR,SS,ST,STA,STL,STP,SU,SUM,SUT,SV,SW,SX,SXX,SY,SZ,T,T1,T2,TA,TAS," +
        "TB,TC,TD,TDP,TE,TEE,TES,TEX,TF,TG,TH,TI,TJ,TK,TL,TM,TN,TO,TOA,TOR,TP,TPF,TPL,TPQ" +
        ",TPS,TQ,TR,TRA,TRC,TRN,TS,TT,TU,TUR,TV,TVD,TX,TY,U,UA,UCB,UNI,UNK,VAD,VAP,VH,VIN" +
        ",VIS,VO,VOL,VOT,VOV,VOW,VSO,VW,WA,WB,WC,WD,WDE,WE,WEL,WF,WH,WL,WM,WOD,WPF,WPL,WP" +
        "S,WR,WRA,WT,WTB,WU,WX,X,XA,XH,XP,XQ,XZ,YA,YB,YC,ZAL,ZAS,ZB,ZBI,ZBT,ZBZ,ZC,ZCA,ZC" +
        "B,ZCD,ZCE,ZCO,ZCR,ZCU,ZET,ZF,ZFE,ZFL,ZFS,ZG,ZGE,ZH,ZHP,ZHS,ZHX,ZIB,ZIP,ZMG,ZMN,Z" +
        "MO,ZMT,ZN,ZNB,ZNI,ZNP,ZO,ZOC,ZP,ZPB,ZPP,ZPT,ZR,ZS,ZSB,ZSE,ZSI,ZSN,ZTA,ZTB,ZTE,ZT" +
        "I,ZV,ZW,ZZN,ZZR,ZZZ,")]
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
    [EdiCodes(",CN,EN,MV,PN,RN,SN,TN,UF,VN,WN,XY,")]
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
    [EdiCodes(",BLC,CIR,COA,COM,CON,CTP,CUS,DOM,EXP,FUM,INS,IPI,MSD,OBV,ONR,ORI,PAK,QAL,SAN,SED," +
        "SPI,SWB,")]
    public class X12_ID_749
    {
    }

    /// <summary>
    /// Product/Process Characteristic Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,25,28,29,30,32,33,34,35,36,37,38,39,40,41,42,43,54,55,56,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,99,9A,9B,9C,9D,AF,AG,AT,BC,BLM,BPI,BW,C2,C3,C4,C5,C6,CCN,CFC,CH,CHF,CL,CLT,CMS,CP,CS,CU,CW,DAC,DAF,DE,DF,DIR,DM,EC,FA,FC,FCD,FDD,FMR,GD,GEN,GM,HB,HZ,HZR,ING,LO,MA,MAC,MBU,MS,MSG,NH,OD,ODR,OR,OT,PD,PF,PFA,PFC,PFG,PFI,PFK,PFL,PFM,PFN,PFP,PFS,PFT,PP,PR,PRO,PSC,PUB,PUR,QAS,RA,RCC,RSD,RSE,RX,SEC,SIZ,SLM,SOL,SYN,TC,TE,TF,THR,TIR,TP,TR,TRN,TWF,WD,WLC,WTT,")]
    public class X12_ID_750
    {
    }

    /// <summary>
    /// Surface/Layer/Position Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1S,2S,BC,BK,BS,BT,CH,DT,DU,FR,FS,GF,IN,KB,LT,MD,NT,OA,OS,OT,R0,R1,R2,R3,R4,R5,R6" +
        ",R7,R8,R9,RA,RB,RC,RD,RE,RF,RG,RH,RI,RJ,RK,RL,RM,RN,RO,RP,RQ,RR,RS,RT,RU,RV,RW,R" +
        "X,RY,RZ,S1,S2,S3,S4,S5,S6,S7,S8,S9,SA,SB,SC,SD,SE,SF,SP,SS,SU,TB,TP,TS,UC,UT,")]
    public class X12_ID_752
    {
    }

    /// <summary>
    /// Packaging Characteristic Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,10,11,34,35,36,37,38,39,40,42,43,44,45,60,61,62,63,65,66,67,68,")]
    public class X12_ID_753
    {
    }

    /// <summary>
    /// Report Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,11,12,13,14,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,AA,AB,AC,AD,AF,AG,AM,AO,AP,AS,AT,AU,AW,BA,BB,BC,BL,BM,BN,BO,BS,BT,C1,C2,C3,C4,CA,CB,CC,CD,CE,CG,CH,CI,CL,CM,CN,CO,CP,CQ,CR,CS,CT,CU,CW,CX,CY,CZ,DA,DB,DC,DD,DE,DF,DG,DH,DI,DL,DM,DN,DR,DS,DT,DW,E1,EA,EB,EC,EP,ER,EX,EY,F1,F2,F3,F4,F5,F6,F7,F8,F9,FB,FC,FD,FE,FH,FI,FS,HC,HR,I2,I3,I4,IA,IC,IM,IP,IR,IS,IT,IV,KA,KC,LA,LB,LC,LD,LE,LG,LI,LO,LP,LR,LW,MA,MB,MC,MD,ME,MF,MG,MI,MM,MN,MO,MR,MS,MT,MV,NA,NC,ND,NI,NL,NN,NO,NT,OB,OL,OP,OS,OX,OZ,P1,PA,PB,PC,PD,PE,PF,PG,PH,PI,PJ,PK,PL,PN,PO,PR,PS,PT,PV,PW,PY,PZ,QC,QD,QE,QM,QR,QS,QT,RA,RB,RC,RF,RM,RN,RO,RR,RT,S1,S2,S3,S4,S5,S6,S7,S8,S9,SA,SB,SC,SD,SE,SH,SI,SL,SM,SN,SP,SQ,SR,SS,ST,SU,SW,TA,TB,TC,TD,TE,TF,TH,TI,TJ,TK,TL,TM,TN,TO,TP,TQ,TR,TT,U1,US,VA,VD,VM,WB,WI,WP,WT,ZB,")]
    public class X12_ID_755
    {
    }

    /// <summary>
    /// Report Transmission Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AE,AM,AU,BE,BM,BW,DA,EL,FX,GS,IA,IE,IM,NS,PO,SE,SM,SN,TE,TM,TX,VO,WS,")]
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
    [EdiCodes(",001,002,003,004,005,006,007,008,009,010,")]
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
    [EdiCodes(",OS,OT,PS,SO,ST,TO,TS,TT,XA,XF,")]
    public class X12_ID_783
    {
    }

    /// <summary>
    /// Security Level Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",00,01,02,03,04,05,06,09,11,90,92,93,94,99,")]
    public class X12_ID_786
    {
    }

    /// <summary>
    /// Entity Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,J,K,Z,")]
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
    [EdiCodes(",ADI,D13,DWW,HZC,INH,LQY,PIH,POI,RAM,TEC,TNM,")]
    public class X12_ID_808
    {
    }

    /// <summary>
    /// Payment Format Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CBC,CCD,CCP,CTP,CTX,PBC,PPD,PPP,PRD,")]
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
    /// Report Section Name Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AM,AP,CA,CM,CO,DI,DM,DS,EI,EN,EO,EP,FA,FE,HH,HI,IA,KY,MI,MS,PD,PM,PR,RE,RG,SH,SL" +
        ",ST,TS,TX,")]
    public class X12_ID_820
    {
    }

    /// <summary>
    /// Safety Characteristic/Hazard Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",ACT,AIR,AM2,AP2,CAR,CON,DCL,DEC,DEH,DIS,DM2,DPI,EDD,EFA,EFB,EFX,EIM,ENA,ENB,ENG,ENO,ENS,EO2,EPA,ESD,EVP,EXI,EXL,EYA,EYC,EYF,EYZ,FAA,FAL,FAS,FAT,FAZ,FEH,FEZ,FIP,FLC,GCA,GMA,GPI,HAI,HCA,HCP,HHA,HI2,HZC,HZR,IGA,IGC,IGZ,IHA,IHC,IHZ,INC,INS,INX,IRR,KY2,LAB,LKI,MCE,MUT,NOT,NTE,NTR,NTS,NTZ,OPH,OPR,ORC,PM2,POL,PPA,PPB,PPC,PPD,PPE,PPF,PPG,PPR,PPS,PPZ,PR2,PRE,PRF,PRG,PRH,PRI,PRJ,PRK,PRL,PRM,PRO,PRQ,PRS,PRT,PRU,PRZ,RCA,REA,REC,REP,RLI,RTK,SAP,SBY,SGW,SHI,SKA,SKC,SKT,SKZ,SNS,SPF,SPI,SPJ,SPL,SPP,SPR,STA,SYP,SYS,TER,TOA,TRH,TS2,VRZ,WDI,")]
    public class X12_ID_821
    {
    }

    /// <summary>
    /// Return Flag Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",Y,")]
    public class X12_ID_823
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
    [EdiCodes(",E,G,I,J,M,N,P,S,T,")]
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
    [EdiCodes(",1,10,11,2,3,4,5,6,7,8,9,")]
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
    [EdiCodes(",QA,QB,QC,QD,QE,QH,QI,QL,QM,QN,QO,QP,QR,QS,QT,QU,QW,QX,")]
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
    [EdiCodes(",001,002,003,004,005,006,007,008,009,010,021,022,023,024,025,026,028,029,030,032," +
        "050,051,052,053,054,055,056,057,058,059,060,061,062,063,064,065,066,067,068,069," +
        "ZZZ,")]
    public class X12_ID_875
    {
    }

    /// <summary>
    /// Marks and Numbers Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CA,CP,DZ,GM,L,MC,PB,R,S,SI,SM,SR,SS,UC,W,ZZ,")]
    public class X12_ID_88
    {
    }

    /// <summary>
    /// Pre-Price Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,Y,")]
    public class X12_ID_882
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
    [EdiCodes(",C,D,E,N,P,R,W,X,Y,")]
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
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,ZZ,")]
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
    /// Account Number Qualifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,05,06,07,08,DA,RD,RS,SG,ZZ,")]
    public class X12_ID_896
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
    /// Incentive Grain Rate Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class X12_ID_898
    {
    }

    /// <summary>
    /// Measurement Unit Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,N,")]
    public class X12_ID_90
    {
    }

    /// <summary>
    /// Validity Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",I,V,")]
    public class X12_ID_900
    {
    }

    /// <summary>
    /// Reject Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,23,24,25,26,27,28" +
        ",29,30,31,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,6" +
        "4,65,66,67,68,69,70,71,72,73,74,75,76,77,78,E1,E2,E3,E4,E5,E6,T1,T2,T3,T4,T5,T6," +
        "ZZ,")]
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
    [EdiCodes(",AB,AC,AO,BD,BE,BK,BL,BQ,BY,CA,CC,CF,CN,CP,CR,DR,DS,EO,FH,IN,JL,KO,LB,LS,NE,NP,NS" +
        ",OS,PR,RA,RE,RL,RN,RO,RR,RT,RU,SA,SO,SP,SS,ST,SW,TC,TM,TR,UD,UE,US,WO,ZZ,")]
    public class X12_ID_92
    {
    }

    /// <summary>
    /// Electronic Form Standards Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",T,X,")]
    public class X12_ID_922
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
        ",28,29,30,31,32,35,36,37,38,39,40,")]
    public class X12_ID_935
    {
    }

    /// <summary>
    /// Measurement Attribute Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27" +
        ",28,29,40,41,42,44,45,46,48,49,50,Q1,Q2,")]
    public class X12_ID_936
    {
    }

    /// <summary>
    /// Test Administration Method Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,11,12,AG,CT,FL,MA,ME,SB,SP,")]
    public class X12_ID_937
    {
    }

    /// <summary>
    /// Test Medium Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,")]
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
    /// Sample Location Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,")]
    public class X12_ID_945
    {
    }

    /// <summary>
    /// Statistic Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27" +
        ",28,29,30,31,32,33,AD,CF,CS,HG,KS,SK,SW,ZZ,")]
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
    [EdiCodes(",01,02,03,04,05,06,")]
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
    [EdiCodes(",BP,CA,CI,CP,CR,CS,CT,F1,F2,F3,FD,FR,FT,GR,GS,HS,HT,LO,LS,LT,LU,LV,MP,MT,OT,SC,SE" +
        ",SF,SL,SP,SR,ST,SU,SX,TD,TT,TX,VA,ZA,ZB,ZC,ZD,ZE,ZZ,")]
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
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,1A,1C,1D,1E,1F,1G,1H,1I" +
        ",1K,1L,1M,1N,1O,1P,1Q,1R,1S,1T,1U,1V,1W,1X,1Y,1Z,20,21,22,23,24,25,26,27,28,29,2" +
        "A,2B,2C,2D,2E,2F,2H,2I,2J,2K,2L,2M,2N,2O,2P,2Q,2R,2S,2T,2U,2V,2W,2X,2Y,2Z,30,31," +
        "32,33,34,35,36,37,38,39,3A,3B,3C,3D,3E,3F,3G,3H,3I,3J,3K,3L,3M,3N,3O,3P,3Q,3R,3S" +
        ",3T,3U,3V,3W,3X,3Y,3Z,40,41,42,43,44,45,46,47,48,49,4A,4B,4C,4D,4E,4F,4G,4H,4I,4" +
        "J,4K,4L,4M,4N,4O,4P,4Q,4R,4S,4T,4U,4V,4W,4X,4Y,4Z,50,51,52,53,54,55,56,57,58,59," +
        "5A,5B,5C,5D,5E,5F,5G,5H,5I,5J,5K,5L,5M,5N,5O,5P,5Q,5R,5S,5T,5U,5V,5W,5X,5Y,5Z,60" +
        ",61,62,63,64,65,66,67,68,69,6A,6B,6C,6D,6E,6F,6G,6H,6I,6J,6K,6L,6M,6N,6O,6P,6Q,6" +
        "R,6S,6T,6U,6V,70,71,72,73,74,75,76,77,78,79,7A,7B,80,81,82,83,84,85,86,87,88,89," +
        "8A,8B,8C,91,92,93,94,95,97,98,A1,A2,A3,A4,A5,A6,A7,A8,A9,AA,AB,AC,AD,AE,AF,AG,AH" +
        ",AI,AK,AL,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AY,AZ,B1,B2,B3,B4,B5,B6,B7,B8,B9,BA,BC,BD,B" +
        "E,BF,BG,BK,BL,BM,BN,BO,BR,BS,BT,BU,BV,BW,BY,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA,CB,CC," +
        "CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CQ,CR,CS,CT,CU,CV,CW,CX,CY,CZ,D1,D2,D4,DA" +
        ",DB,DC,DD,DE,DF,DG,DH,DI,DJ,DK,DL,DM,DN,DO,DP,DQ,DR,DS,DT,DU,DV,DW,DY,DZ,E1,E2,E" +
        "3,E4,E6,EB,EC,ED,EE,EF,EG,EH,EL,EM,EN,EP,ES,EX,EY,F1,F2,FA,FB,FC,FD,FE,FF,FG,FH," +
        "FI,FJ,FK,FM,FO,FR,FS,FW,GA,GD,GP,GU,HB,HF,HH,HS,IA,IB,IC,ID,II,IK,IL,IM,IN,IP,IR" +
        ",IS,IT,IU,JU,KA,KB,KC,KD,KE,KF,KG,KK,KR,KS,KV,KW,KX,KY,L1,LB,LC,LE,LG,LH,LI,LL,L" +
        "M,LN,LO,LP,LR,LS,LT,LV,M1,M2,M3,M4,M5,M6,M7,M8,M9,MA,MB,MC,MD,ME,MF,MG,MH,MI,MJ," +
        "MK,ML,MM,MO,MP,MQ,MS,MT,N1,N2,N3,N4,N5,NC,ND,NE,NI,NN,NP,OA,OB,OC,OH,OI,OM,OO,OP" +
        ",OR,OS,OT,OU,OV,OW,OX,OY,OZ,P0,P1,P2,P3,P4,P5,P6,P7,P8,P9,PA,PB,PC,PD,PE,PF,PG,P" +
        "H,PI,PJ,PK,PL,PM,PN,PO,PP,PQ,PR,PS,PT,PU,PV,PW,PX,PY,PZ,QA,QB,QC,QD,QE,QF,QG,QH," +
        "QI,QP,QQ,QR,QZ,R1,R2,R3,R4,R5,RA,RB,RC,RD,RE,RF,RG,RH,RI,RJ,RK,RL,RM,RN,RO,RP,RQ" +
        ",RR,RS,RT,RU,RV,RW,RX,RY,RZ,S1,S2,S3,S4,S5,SA,SB,SC,SD,SE,SF,SG,SH,SI,SJ,SK,SL,S" +
        "M,SN,SO,SP,SQ,SR,SS,ST,SU,SV,SW,SX,SY,T1,T2,T3,T4,T5,T6,T7,TB,TC,TD,TE,TF,TG,TH," +
        "TI,TK,TL,TM,TN,TO,TP,TQ,TR,TS,TT,TU,TV,UC,UP,US,VC,VN,VS,WD,WF,WH,WI,WN,WO,X1,X2" +
        ",Z1,Z2,Z3,Z4,Z5,Z6,Z7,Z8,ZA,ZB,ZD,ZE,ZF,ZL,ZN,ZP,ZQ,ZR,ZS,ZZ,")]
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
        "")]
    public class X12_ID_988
    {
    }
}
