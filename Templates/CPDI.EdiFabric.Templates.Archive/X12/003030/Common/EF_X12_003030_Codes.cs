namespace EdiFabric.Templates.X12003030
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.X12;
    using System.Xml.Serialization;
    
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
    [EdiCodes(",05,06,07,08,09,1,10,11,14,15,16,17,18,19,2,3,4,KA,KB,")]
    public class X12_ID_1004
    {
    }
    
    /// <summary>
    /// Hierarchical Structure Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0001,0002,0035,0036,")]
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
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,3,4,5,6,7,8,9,")]
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
    [EdiCodes(",BL,CH,CI,FI,HM,MA,MB,MC,MH,OF,SA,TV,VA,WC,ZZ,")]
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
    [EdiCodes(",TAX,VEN,")]
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
        ",29,30,31,32,33,34,36,37,38,39,40,41,43,ZZ,")]
    public class X12_ID_1069
    {
    }
    
    /// <summary>
    /// Payment Method Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,C,D,E,F,I,L,N,P,R,S,W,")]
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
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,")]
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
    [EdiCodes(",A,B,C,D,E,F,H,J,M,P,Q,R,S,T,U,V,W,X,Y,")]
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
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,")]
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
    [EdiCodes(",A,B,C,D,E,Z,")]
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
    [EdiCodes(",1,10,11,2,3,4,5,6,7,8,9,")]
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
    /// Level of Student or Test Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,0K,10,11,12,20,21,22,23,24,25,26,27,28,29,30,AD,P0,P1" +
        ",P2,P3,P4,P5,PK,UN,")]
    public class X12_ID_1131
    {
    }
    
    /// <summary>
    /// Instructional Setting Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,")]
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
    [EdiCodes(",1,2,3,")]
    public class X12_ID_1135
    {
    }
    
    /// <summary>
    /// Code Category
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,")]
    public class X12_ID_1136
    {
    }
    
    /// <summary>
    /// Payor Responsibility Sequence Number Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",P,S,T,U,")]
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
    [EdiCodes(",H,L,M,")]
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
    [EdiCodes(",01,02,03,04,05,06,09,CH,CP,CS,CW,CX,CY,FD,FE,FI,FR,FX,LA,LE,LH,OC,TM,ZZ,")]
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
        ",28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,ZZ,")]
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
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,16,17,18,19,20,21,22,23,91,92,93,94,ZZ" +
        ",")]
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
    [EdiCodes(",01,02,03,")]
    public class X12_ID_1193
    {
    }
    
    /// <summary>
    /// Breakdown Structure Detail Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27" +
        ",ZZ,")]
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
        ",28,29,30,31,32,33,34,35,36,37,38,39,40,41,ZZ,")]
    public class X12_ID_1203
    {
    }
    
    /// <summary>
    /// Insurance Line Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",401,403,457,AC,ADD,AF,AP,AR,BC,BE,BH,BK,CLF,CV,DEN,FSA,GDC,HLT,HMO,IRA,IRC,LL,LT" +
        "C,LTD,MOD,NGD,NQ,PDG,PSP,QDA,QDC,STD,TSA,UL,UR,VIS,ZZZ,")]
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
    [EdiCodes(",A,C,D,I,N,")]
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
    [EdiCodes(@",AA,AC,AV,B0,B1,BF,BL,BR,C5,CF,CM,CP,CT,CW,DD,DP,DR,DS,EI,ER,FC,FF,FL,FN,FR,FT,FV,GT,HD,HM,HN,HY,KG,KL,KP,KT,LB,LP,LR,LS,LT,MD,ME,MH,MI,MM,MN,MO,MP,MS,MT,MV,MW,MX,PA,PB,PC,PD,PE,PF,PG,PH,PK,PL,PM,PP,PQ,PR,PS,PT,PU,PV,PW,PY,QY,RP,S0,S1,SC,SD,SF,SP,ST,SU,SY,TB,TC,TD,TN,TP,TR,VA,VH,VM,VP,VR,VS,VU,WK,WM,YR,")]
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
    [EdiCodes(",AD,AS,AT,BI,BS,CO,LA,OP,OR,OT,P1,P2,PC,PE,PT,PU,RF,SU,")]
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
    [EdiCodes(",AC,EB,EC,ED,EI,EM,EP,ER,ES,ET,EU,MB,MS,MT,MU,PB,PS,PT,QP,RA,RK,RO,RP,RS,RT,SD,SP" +
        ",ZZ,")]
    public class X12_ID_1224
    {
    }
    
    /// <summary>
    /// Disposition Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",EXC,HLD,MOD,REP,RET,REW,SAL,SCR,UAI,")]
    public class X12_ID_1225
    {
    }
    
    /// <summary>
    /// Repair Action Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AL,CL,CN,IN,LB,MD,NT,RM,RP,RT,RW,SC,SD,TT,UP,WD,")]
    public class X12_ID_1226
    {
    }
    
    /// <summary>
    /// Repair Complexity Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CR,DAP,INT,MAJ,MIN,OVH,OVR,QP,RAR,RC,RR,RT,")]
    public class X12_ID_1227
    {
    }
    
    /// <summary>
    /// Complaint Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BRK,CON,DED,DOA,MOD,")]
    public class X12_ID_1229
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
    /// Operation Environment Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,")]
    public class X12_ID_1231
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
    [EdiCodes(",1,10,11,12,13,14,15,16,18,19,2,20,21,22,3,4,5,6,7,8,9,99,")]
    public class X12_ID_1257
    {
    }
    
    /// <summary>
    /// Loan Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,")]
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
    [EdiCodes(@",0,1,10,11,12,13,14,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,52,53,54,55,56,57,58,59,6,60,61,62,63,66,67,69,7,71,74,75,78,79,8,80,81,82,83,84,85,86,87,88,89,9,90,91,92,93,94,95,96,97,98,99,A1,A2,A3,A4,A5,A6,A7,A8,A9,AA,AB,AD,AE,AF,AG,AH,AI,AJ,AK,AL,BA,BC,BD,CA,CB,CC,CD,CE,CF,CG,CH,DK,EA,EB,EC,ED,EE,EF,EG,EI,EJ,EL,EM,EN,EQ,ER,ET,EU,EV,EW,EX,EY,EZ,FA,FB,FC,FD,FE,FF,FG,GA,GB,GC,GD,GE,GF,GG,GI,GJ,GK,HA,HB,HC,HD,JA,JB,JC,JD,JE,JF,JG,JH,JI,JK,JL,ZZ,")]
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
        "B,2D,2E,2F,30,31,32,33,34,35,36,37,38,39,3P,40,41,42,43,44,45,46,47,48,49,50,51," +
        "52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78" +
        ",79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,95,96,97,98,99,A1,A2,A3,A4,A5,A6,A" +
        "7,A8,A9,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,AX," +
        "AY,AZ,B1,B2,B3,B4,B5,B6,B7,B8,B9,BA,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BO,BP" +
        ",BQ,BR,BS,BT,BU,BV,BW,BX,BY,BZ,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA,CB,CC,CD,CE,CF,CG,C" +
        "H,CI,CJ,CK,CL,CM,CN,CO,CP,CQ,CR,CS,CT,CU,CV,CW,CX,CY,CZ,D1,D2,D3,D4,D5,D6,D7,D8," +
        "D9,DA,DB,DC,DD,DE,DF,DG,DH,DI,DJ,DK,DL,DM,DN,DO,DP,DQ,DR,DS,DT,DU,DV,DW,DX,DY,DZ" +
        ",E1,E2,E3,E4,E5,E6,E7,E8,E9,EA,EB,ED,EF,EG,EH,EI,EJ,EK,EL,EM,EN,EO,EP,EQ,ER,ES,E" +
        "T,EU,EV,EW,EY,EZ,F1,F2,F3,F4,F5,F6,F7,F8,FA,FB,FC,FD,FE,FG,FH,FI,FJ,FK,FL,FM,FN," +
        "FO,FP,FR,FS,FT,FU,FV,FW,FX,FY,G1,G2,G3,G4,G5,G6,G7,G8,G9,GA,GB,GC,GD,GE,GF,GG,GH" +
        ",GI,GJ,GK,GM,GN,GP,GR,GS,GT,HB,HC,HD,HE,HI,HN,HO,HP,HR,HS,HW,I2,IA,IB,IC,ID,IE,I" +
        "F,IG,IH,II,IJ,IK,IL,IM,IN,IO,IP,IR,IS,IT,IU,IV,IW,IX,IZ,JA,JB,JE,JS,K1,K2,K3,K4," +
        "K8,K9,KB,KE,KG,KH,KI,KJ,KM,KN,KO,KP,KR,KS,KT,KU,KW,KX,KY,KZ,L1,L2,L3,L4,L5,L6,LA" +
        ",LB,LC,LD,LE,LF,LG,LH,LI,LJ,LK,LL,LM,LN,LO,LP,LQ,LR,LS,LT,LU,LV,LW,LZ,M1,M2,M3,M" +
        "4,M5,MA,MB,MC,MD,ME,MF,MG,MH,MI,MJ,MK,ML,MM,MN,MO,MP,MQ,MR,MS,MT,MU,MV,MW,MY,N0," +
        "N1,N2,N3,N4,NA,NB,NC,ND,NE,NF,NG,NN,NO,NP,NR,NS,NX,O5,OA,OB,OC,OD,OI,OL,OM,ON,OP" +
        ",OQ,OR,OS,OT,OW,P1,P2,P3,P4,P5,P6,P7,P8,P9,PA,PB,PC,PD,PE,PF,PG,PH,PI,PJ,PK,PL,P" +
        "M,PN,PO,PP,PQ,PR,PS,PT,PU,PV,PW,PX,PY,PZ,Q1,Q2,Q3,Q4,Q5,Q6,Q7,Q8,Q9,QA,QB,QC,QD," +
        "QE,QF,QG,QH,QI,QJ,QK,QL,QM,QN,QO,QP,QQ,QR,QS,QT,QU,QV,QW,QX,QY,QZ,R1,R2,R3,R4,R5" +
        ",R6,R7,R8,R9,RA,RB,RC,RD,RE,RF,RG,RH,RI,RJ,RK,RL,RM,RN,RO,RP,RQ,RR,RS,RT,RU,RV,R" +
        "W,RX,RY,RZ,S1,S2,S3,S4,S5,S6,S7,S8,S9,SA,SB,SC,SD,SE,SF,SG,SH,SI,SJ,SK,SL,SM,SN," +
        "SO,SP,SQ,SR,SS,ST,SU,SV,SW,SX,SY,SZ,T1,T2,T3,T4,T5,T6,T7,T8,T9,TA,TB,TC,TD,TE,TF" +
        ",TG,TH,TI,TJ,TK,TL,TM,TN,TO,TP,TQ,TR,TS,TT,TU,TV,TW,TX,TY,TZ,UB,UD,UG,UN,UP,US,U" +
        "T,V1,V3,VA,VB,VC,VD,VE,VF,VG,VN,VP,VR,VS,VT,VV,VX,W1,W2,W3,W4,W5,W6,W7,W8,W9,WC," +
        "WD,WM,WN,WO,WP,WR,WS,WY,X9,XA,XB,XC,XD,XE,XF,XG,XH,XP,XT,XX,Z1,Z2,Z3,Z4,Z5,Z6,Z7" +
        ",ZA,ZB,ZC,ZE,ZM,ZR,ZS,ZZ,")]
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
    [EdiCodes(",CO,CV,DM,DP,DR,EI,EO,EW,LP,NA,OP,PF,PW,SP,SR,ST,WG,")]
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
    /// Loan Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,2,3,4,5,6,7,8,9,")]
    public class X12_ID_1307
    {
    }
    
    /// <summary>
    /// Contract Action Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",KA,KB,KC,KD,KE,KF,KG,ZZ,")]
    public class X12_ID_1308
    {
    }
    
    /// <summary>
    /// Pricing Proposal Data Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,")]
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
    [EdiCodes(",A,B,C,D,")]
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
    /// Certification Condition Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27" +
        ",28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,")]
    public class X12_ID_1321
    {
    }
    
    /// <summary>
    /// Certification Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",I,R,S,")]
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
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,B,D,H,I,M,O,R,S,V,Z,")]
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
    [EdiCodes(",12,13,14,15,16,41,42,43,AP,CP,GP,IP,LD,LT,MC,MG,MP,OT,PP,SP,")]
    public class X12_ID_1336
    {
    }
    
    /// <summary>
    /// Level of Care Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,")]
    public class X12_ID_1337
    {
    }
    
    /// <summary>
    /// Level of Service Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",00,01,02,03,04,05,09,F1,F2,L,")]
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
    [EdiCodes(",A,C,M,")]
    public class X12_ID_1342
    {
    }
    
    /// <summary>
    /// Non-Institutional Claim Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AM,CH,DD,DM,ER,HS,IL,MD,OC,PD,PE,PT,RX,SN,ST,")]
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
    [EdiCodes(",A,B,C,L,N,")]
    public class X12_ID_1364
    {
    }
    
    /// <summary>
    /// Service Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,3,4,5,6,7,8,9,")]
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
    [EdiCodes(",00,01,05,07,15,16,17,18,20,22,27,28,29,")]
    public class X12_ID_1383
    {
    }
    
    /// <summary>
    /// Patient Location Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",O,P,R,S,T,")]
    public class X12_ID_1384
    {
    }
    
    /// <summary>
    /// Sales Terms Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CH,DD,LC,OA,SD,")]
    public class X12_ID_139
    {
    }
    
    /// <summary>
    /// Transaction Set Identifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",101,104,105,107,108,109,110,111,113,114,115,116,130,131,135,139,140,141,142,143,144,146,147,151,152,161,170,180,190,204,210,213,214,217,218,263,300,301,302,303,304,305,306,307,309,310,311,312,313,314,315,316,317,319,321,322,323,324,325,326,350,352,353,354,355,356,360,361,404,410,411,414,417,418,419,420,421,422,423,424,425,426,427,429,431,440,460,461,462,463,464,465,466,467,468,469,480,485,486,490,491,492,494,499,511,517,527,536,561,567,601,602,622,805,806,810,811,812,813,815,818,819,820,821,822,823,824,826,827,828,829,830,832,833,834,835,836,837,838,839,840,841,842,843,844,845,846,848,849,850,851,852,853,854,855,856,857,858,859,860,861,862,863,864,865,866,867,868,869,870,872,874,875,876,877,878,879,880,881,882,883,884,885,888,889,890,891,892,893,894,895,896,905,920,924,925,926,928,940,941,942,943,944,945,946,947,980,990,994,995,996,997,998,999,")]
    public class X12_ID_143
    {
    }
    
    /// <summary>
    /// Shipment Method of Payment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BP,CA,CC,CD,CF,DE,DF,FO,HP,MX,NC,NR,PA,PB,PC,PD,PL,PO,PP,PS,PU,RC,RF,RS,TP,WC,")]
    public class X12_ID_146
    {
    }
    
    /// <summary>
    /// Shipment Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,4,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,")]
    public class X12_ID_147
    {
    }
    
    /// <summary>
    /// Special Charge or Allowance Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",003,005,010,015,020,025,030,035,040,045,050,055,060,065,070,075,080,085,090,095," +
        "100,105,110,115,120,130,135,140,145,150,155,160,165,170,175,180,185,186,190,205," +
        "210,215,220,225,230,235,240,245,250,255,260,265,270,275,280,285,290,295,297,300," +
        "310,315,320,325,330,335,340,345,350,355,360,365,370,375,380,385,390,392,393,395," +
        "400,405,410,415,416,420,425,426,430,435,440,445,450,455,460,462,465,470,475,480," +
        "485,490,495,500,505,510,515,520,525,535,540,545,550,555,560,565,570,580,585,586," +
        "590,593,595,600,605,610,615,620,625,635,640,641,645,650,665,670,675,680,685,690," +
        "695,696,697,700,705,706,720,725,730,731,732,735,736,740,745,750,755,760,761,762," +
        "999,AAA,AAJ,AAM,AAN,AAO,AAS,AAT,ABC,ABL,ACD,ACF,ACH,ACL,ACS,ADH,ADV,AFB,AFC,AGS," +
        "ALC,AMB,AMC,AMP,ANB,ANS,APT,ARB,ARG,ASC,AVA,BAA,BAB,BAC,BAD,BAF,BAP,BAS,BBK,BDX," +
        "BEY,BFD,BLA,BLC,BLD,BLK,BLW,BND,BOB,BRA,BRD,BSC,BUR,BYD,CAA,CAB,CAC,CAD,CAE,CAF," +
        "CAG,CAH,CAJ,CAK,CAL,CAO,CAP,CAQ,CAR,CAS,CAT,CAU,CAV,CAW,CAZ,CBL,CBO,CBP,CBR,CBW," +
        "CBX,CCA,CCH,CCP,CCR,CDA,CDF,CDR,CER,CGC,CGL,CGR,CHG,CHN,CIR,CIS,CLC,CLN,CLS,CMC," +
        "CMF,CMI,CMP,CNS,CNV,COA,COC,COD,COF,COL,COM,CON,COR,COU,CPA,CPE,CPP,CRA,CRC,CRF," +
        "CRP,CRR,CSA,CSC,CSE,CSF,CSR,CST,CTA,CTC,CTF,CTG,CTL,CUA,CUD,CUF,CUP,CUS,DAA,DAB," +
        "DAC,DAD,DAM,DBD,DCS,DCT,DDA,DDC,DDD,DDF,DDP,DDS,DEA,DED,DEL,DEM,DEP,DER,DES,DET," +
        "DEV,DEW,DFS,DFW,DIC,DIR,DIS,DIV,DLH,DMC,DMD,DNA,DOC,DON,DPR,DRC,DRP,DRV,DRY,DSC," +
        "DSF,DSR,DST,DTA,DTB,DTC,DTL,DTU,DTV,DWC,EAC,EBD,EBP,ECC,EEA,EEB,EEC,EED,EEF,EEG," +
        "EEH,EEP,EEX,EIC,ELS,EMS,EMT,ENC,ENS,EPC,EPS,ERS,ESA,ESC,ESE,EUC,EVC,EXC,EXL,EXM," +
        "EXP,EXS,EXW,FAB,FAC,FAD,FAE,FAF,FAG,FAH,FBD,FCB,FCD,FCI,FCS,FDL,FFI,FFL,FFN,FFP," +
        "FFR,FIR,FLT,FMR,FMS,FRC,FTC,FUE,FWA,FWC,FXE,GAR,GDR,GGA,GGF,GKT,GPD,GRD,GRS,GSS," +
        "GST,HAN,HAZ,HDF,HDG,HET,HFA,HHA,HHB,HHG,HIC,HLF,HOC,HOL,HOS,HOX,HRS,HSC,HUL,HZS," +
        "IAA,IAB,IAC,ICE,IDL,IDP,IFC,IHT,IIA,IIP,IIU,ILD,ILF,ILP,IMP,INC,INP,INR,INS,IPC," +
        "IPU,IRA,ISD,ITC,KIT,LAA,LAB,LAC,LAD,LAE,LAL,LAT,LAY,LCG,LCR,LDA,LDG,LDL,LDS,LFT," +
        "LGD,LID,LLC,LLD,LLF,LLS,LMC,LNT,LOA,LOC,LPC,LPF,LSC,LSH,LSS,LTC,LUB,LUP,LUS,MAA," +
        "MAB,MAC,MAD,MAE,MAR,MCC,MDG,MDM,MEA,MEN,MES,MET,MFC,MFG,MGA,MGC,MIC,MIL,MIN,MKU," +
        "MLB,MLS,MMC,MMF,MMS,MMT,MNC,MNS,MPC,MRK,MRP,MSC,MSG,MTR,MUS,MVR,MVT,NAA,NAB,NAL," +
        "NCH,NFY,NHB,NSD,NWD,NYD,NYP,OAA,OAB,OAC,OCH,ODF,OFR,OFU,ONC,OOC,OOF,OPC,ORC,ORM," +
        "OSC,OSO,OSS,OUT,OVR,PAA,PAB,PAC,PAD,PAE,PAF,PAG,PAH,PAI,PAJ,PAK,PAL,PAR,PAT,PBA," +
        "PBE,PBL,PCH,PCT,PDB,PDC,PEC,PEN,PER,PFA,PHC,PHG,PIR,PLC,PLT,PMC,PMR,PMU,PMX,PNA," +
        "POD,POL,POS,PPC,PPH,PPI,PPM,PPN,PPO,PPR,PPS,PPT,PPU,PRB,PRC,PRE,PRK,PRL,PRM,PRO," +
        "PRP,PRV,PSC,PSG,PSH,PSS,PST,PTC,PTS,PUC,PUD,PWH,PWT,QAA,QQD,RAA,RAB,RAC,RAD,RAE," +
        "RAF,RAG,RAH,RAI,RAJ,RAK,RAL,RAM,RCA,RCB,RCC,RCD,RCE,RCG,RCL,RCP,RCS,RDC,RDF,REC," +
        "REE,REF,REG,REL,REP,REQ,RES,RET,RFD,RGA,RGC,RHM,RID,RLA,RLC,RLQ,RLS,RMB,RMD,RMS," +
        "ROC,RPC,RRC,RRD,RRF,RRN,RRP,RRR,RSM,RSS,RSV,RTC,SAA,SAB,SAC,SAD,SAE,SAF,SAG,SAH," +
        "SAI,SAJ,SAK,SAM,SAN,SAP,SAT,SBC,SBL,SCC,SCG,SCL,SCU,SDC,SDL,SDS,SEC,SEG,SEL,SEQ," +
        "SER,SEV,SFT,SGL,SHL,SHS,SLC,SMS,SNS,SOC,SOP,SPA,SPB,SPC,SPD,SPL,SPP,SPS,SPT,SPU," +
        "SRG,SRS,SSA,SSB,SSC,SSF,SSL,SSO,SSP,SSS,SST,SSX,STC,STF,STL,STM,STP,STR,STW,SUC," +
        "SUF,SUP,SUR,SVA,SVL,SVS,SWC,TAA,TAB,TAC,TAD,TAE,TAF,TAG,TAH,TAI,TAJ,TAK,TAL,TAX," +
        "TAY,TCB,TCM,TDT,TER,TLC,TMS,TMV,TOA,TOC,TPC,TRA,TRC,TRE,TRF,TRN,TRP,TRS,TRU,TSC," +
        "TSS,TST,TTA,TTB,TTD,TTL,TTM,TTP,TTR,TTS,TTT,TTV,TUR,TWO,UND,UNL,UPD,URC,USF,USV," +
        "USW,UTP,UUC,UUM,UUT,VAA,VAB,VCR,VFN,VIS,VIT,VOR,VTS,VVL,VVP,WAR,WAT,WEA,WFH,WHC," +
        "WRC,WRE,WSA,WTG,WTV,WWC,Z01,Z02,Z03,Z04,Z05,Z06,Z07,Z08,Z09,Z10,Z11,Z12,Z13,Z14," +
        "Z15,Z16,Z17,Z18,Z19,Z20,Z21,Z22,Z23,Z24,Z25,Z26,Z27,Z28,Z29,Z30,ZFF,ZZZ,")]
    public class X12_ID_150
    {
    }
    
    /// <summary>
    /// Special Handling Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",045,520,675,A1M,A3M,A5M,AAS,AGG,AGS,AK,AMM,ANC,APL,ARC,ARG,ASY,AT,AUX,AV,AW,BA,BCP,BKA,BL,BLS,BN,BNS,BOX,BW,CAR,CCB,CCH,CD,CE,CGC,CGR,CH,CHN,CI,CLS,CM,CMD,CNL,CNS,CO,CON,COR,COU,COV,CPM,CR,CSD,CTM,CW,CY,DA,DBL,DCS,DDP,DE,DFS,DIS,DLR,DM,DN,DNF,DOC,DR,DRO,DRU,DS,DSR,DST,DT,DTV,DU,DW,EAX,ED,EE,EED,EL,ELS,EMR,EMT,END,EP,ER,ERS,EW,EX,EXC,EXD,EXO,EXP,EXQ,EXT,EXU,EXZ,EZE,FC,FCS,FD,FG,FL,FP,FPT,FR,FRZ,FS,FST,GI,GOC,GSS,HAN,HE,HEA,HES,HET,HH,HHB,HM,HO,HOR,HP,HQT,HR,HRS,HT,HV,HW,IB,IC,ID,IM,IMP,INT,IP,IR,IS,JIT,JLX,JS,KEG,KMD,LAB,LAY,LB,LBT,LC,LD,LF,LHS,LP,LS,LT,LTT,MC,MEN,MES,MET,MEX,MF,MIN,MOT,MP,MR,MRF,MSS,MTE,NC,ND,NE,NH,NP,NPR,NS,NT,NW,NX,OBL,OCA,OCL,OCS,OCV,OEH,OFU,OHC,OIL,ONC,ONS,OOB,OOD,OOL,OPR,OPT,OS,OSB,OST,OTC,OTD,OTS,OVR,OWR,PB,PD,PDS,PER,PG,PHR,PI,PIR,PMM,PMR,POC,PRL,PS,PSG,PSS,PTS,PUC,PUD,PUK,PUP,PW,RA,RB,RC,RCC,RCL,RDR,RLS,RM,RMS,RO,RR,RRR,RS,RSP,RSS,RSV,RT,SB,SC,SCC,SCL,SD,SDS,SE,SEC,SEE,SER,SEV,SF,SFT,SGL,SH,SHL,SI,SK,SKT,SLC,SM,SMP,SMS,SNT,SOC,SOL,SP,SPC,SPR,SPT,SPU,SR,SRG,SRS,SSN,ST,STR,SUP,SVS,TA,TDC,TDP,TLS,TMS,TN,TOF,TPS,TRA,TRK,TRL,TRM,TRN,TRP,TRS,TRT,TS,TSC,TSP,TSS,TT,TV,UB,UI,UN,UP,UPK,URC,US,UTL,VAC,VAN,VT,VTS,WB,WD,WE,WH,WI,WM,WO,WTV,WW,XP,XT,ZZZ,")]
    public class X12_ID_152
    {
    }
    
    /// <summary>
    /// Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",A,AA,AD,AE,AF,AG,AH,AI,AJ,AL,AM,AN,AO,AP,AR,AV,AW,B,BA,BC,BD,BE,BF,BR,C,CA,CB,CC,CR,CS,CT,CU,CV,D,DA,DC,DP,DR,DS,DT,E,EA,EE,ER,F,FP,FT,G,GO,H,HA,HB,HC,HD,I,J,K,L,MT,N,ND,NF,NH,NO,NP,NS,NT,O,OA,OB,OF,OH,ON,P,PA,PB,PC,PD,PE,PF,PG,PH,PI,PJ,PK,PL,PM,PN,PO,PP,PQ,PR,PS,PT,PU,PV,R,RA,RB,RC,RD,RL,S,SA,SB,SC,SI,T,TM,UA,UB,UC,UD,UE,UR,UV,V,VA,VD,W,WE,WH,WR,X,Y,Z,ZZ,")]
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
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,")]
    public class X12_ID_176
    {
    }
    
    /// <summary>
    /// Quantity or Status Adjustment Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,51,52,53,54,55,56,")]
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
    [EdiCodes(",A,A1,A2,A3,B,C,CD,D,DR,E,F,G,H,I,J,K,L,M,N,ND,O,P,Q,R,RG,RN,RT,S,T,U,V,W,WA,WB,W" +
        "G,WJ,X,Y,Z,")]
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
    [EdiCodes(",AD,AI,AR,BD,BE,BO,CA,CO,CS,DV,PD,RB,RC,RE,TL,")]
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
    [EdiCodes(",A,B,C,D,F,G,H,K,L,M,S,T,")]
    public class X12_ID_231
    {
    }
    
    /// <summary>
    /// Product/Service ID Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",A1,A2,A3,A4,A6,A7,A8,A9,AA,AB,AC,AD,AI,AM,AN,AP,AR,AS,AT,AX,AY,AZ,B1,B2,B3,B4,B5,B6,B7,BA,BC,BE,BL,BM,BN,BO,BP,BS,BT,BU,BX,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CL,CM,CN,CO,CP,CQ,CR,CS,CT,CU,CV,CY,DE,DG,DI,DL,DN,DP,DR,DX,DZ,EC,ED,EI,EL,EM,EN,EP,EQ,ES,EX,F1,F2,F3,F4,F5,F7,F8,FA,FF,FI,FL,FM,FN,FP,FS,FT,FW,GC,GD,GK,GN,GR,GS,GU,HC,HD,HI,HN,IA,IB,IC,ID,IM,IN,IS,IT,IW,IZ,JN,JP,JS,KP,LG,LT,LU,MA,MB,MC,MD,MF,MG,MI,MM,MN,MO,MS,MT,N1,N2,N3,N4,NC,ND,NH,NR,NW,NZ,OA,OB,OC,OD,OE,OF,OG,OH,OI,OL,ON,OO,OP,P1,P2,P3,P4,PA,PC,PD,PE,PG,PH,PI,PJ,PK,PL,PM,PN,PO,PP,PQ,PR,PS,PT,PU,PW,PZ,R1,R2,RA,RB,RC,RD,RE,RF,RK,RN,RO,RP,RR,RS,RT,RU,RV,RW,RY,SA,SB,SC,SD,SE,SF,SH,SI,SK,SL,SM,SN,SP,SQ,SR,SS,ST,SU,SV,SW,SZ,TA,TC,TI,TM,TN,TP,TR,TS,TT,TU,TX,TY,U2,UA,UB,UC,UD,UE,UF,UG,UH,UI,UK,UM,UN,UO,UP,UQ,US,UT,UV,VA,VB,VC,VE,VI,VM,VN,VO,VP,VS,VU,VV,VX,WL,WS,XC,ZZ,")]
    public class X12_ID_235
    {
    }
    
    /// <summary>
    /// Price Identifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",ACT,AGC,ALT,AWP,BCH,C01,C02,C03,C04,C05,C06,C07,C08,C09,C10,C11,C12,C13,C14,C15,C16,C17,C18,C19,C20,C21,C22,C23,C24,C25,C26,C27,C28,C29,C30,CAT,CDV,CHG,CON,CUP,CUS,DAP,DIS,DPR,DSC,DSP,EDM,EDP,EDS,EDW,EST,EUP,FCH,FET,FGP,FUL,FUP,GOV,ICL,IND,INS,INV,LPR,MAP,MAS,MAX,MIN,MNC,MNR,MPR,MSR,MXR,N01,N02,N03,N04,N05,N06,N07,N08,N09,N10,N11,N12,N13,N14,N15,N16,N17,N18,N19,N20,N21,N22,N23,N24,N25,N26,N27,N28,N29,N30,NET,OAP,OPP,PAQ,PBQ,PBR,PIE,PPD,PRF,PRO,PRP,QTE,RES,SDP,SFP,SHD,SLP,SPC,STA,SUM,SWP,THP,TOT,TRF,UCP,ZNP,")]
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
        ",28,")]
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
    [EdiCodes(",E,G,V,W,X,Y,Z,")]
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
    [EdiCodes(",A,B,D,F,L,O,P,T,U,")]
    public class X12_ID_262
    {
    }
    
    /// <summary>
    /// Customs Inhibit/Clearance Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",DM,EC,ET,EX,IB,IC,IR,IT,IX,NC,NE,NI,TR,")]
    public class X12_ID_27
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
    [EdiCodes(",A,N,Y,Z,")]
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
    /// Rail Car Status Order Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CC,FI,IR,TD,TI,")]
    public class X12_ID_303
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
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,AD,AI,AV,AW,AX,BO,C,D,DC,DP,DS,E,H,I,K,KA,L,LC,M,N,O,OR,P,Q," +
        "R,R2,R3,R4,R5,RC,RE,RF,RO,T,U,V,W,Z,")]
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
    [EdiCodes(",AC,AP,AR,BE,BL,BS,CA,CC,CD,CI,CL,CO,CS,CY,D,DC,DE,FA,FE,FF,FI,FR,FT,FV,IA,IM,IP," +
        "IT,K,MI,MS,NS,OA,OL,OR,OV,PA,PE,PL,PP,PQ,PR,PS,PT,PU,RA,RE,RG,RJ,RL,RS,RT,SB,SC," +
        "SD,SL,SN,SP,SS,SW,TC,TL,TN,TR,TX,UN,UR,VS,W,WH,ZN,ZZ,")]
    public class X12_ID_309
    {
    }
    
    /// <summary>
    /// Shipment Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AD,AM,CS,ST,")]
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
    [EdiCodes(",0,1,2,3,4,5,C,")]
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
    [EdiCodes(",A,D,O,P,W,")]
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
    [EdiCodes(",1N,CAF,CIF,DAF,DDP,DOM,EXQ,EXS,EXW,FAS,FCA,FCI,FCP,FOB,FOR,FOT,NPF,PPF,ZZZ,")]
    public class X12_ID_335
    {
    }
    
    /// <summary>
    /// Terms Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,ZZ,")]
    public class X12_ID_336
    {
    }
    
    /// <summary>
    /// Allowance or Charge Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,100,2,3,40,41,42,43,44,45,46,47,48,490,491,499,5,50,501,502,503,504,505,506,50" +
        "7,508,509,51,510,511,512,513,514,515,516,517,518,519,52,520,521,522,523,524,525," +
        "526,53,537,54,55,57,58,60,61,62,63,64,65,66,67,70,80,88,90,91,92,93,94,95,96,97," +
        "990,999,")]
    public class X12_ID_340
    {
    }
    
    /// <summary>
    /// Unit of Time Period or Interval
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AD,AM,AY,BD,CC,CY,DA,DW,DY,EL,FY,HR,LN,LT,MO,MS,MT,QY,SA,SD,SH,WK,WW,")]
    public class X12_ID_344
    {
    }
    
    /// <summary>
    /// Lead Time Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,AD,AE,AF,AG,AS,")]
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
        ",31,32,33,34,35,36,37,38,41,42,43,44,45,46,47,48,49,50,ZZ,")]
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
        "Q,2R,2U,2V,2W,2X,2Y,2Z,30,31,32,33,34,35,36,37,38,39,3A,3B,3C,40,41,43,44,45,46," +
        "47,48,4A,4B,4C,4D,4E,4F,4G,4H,4I,4J,4K,4L,4M,4N,4O,4P,4Q,4R,4S,4T,4U,50,51,53,54" +
        ",56,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,8" +
        "3,84,85,86,87,89,90,91,92,93,94,95,96,97,98,A8,A9,AA,AB,AC,AD,AE,AF,AH,AI,AJ,AK," +
        "AL,AM,AN,AP,AQ,AR,AS,AT,AU,AV,AW,AX,AY,AZ,B0,B1,B2,B3,B4,B5,B6,B7,B8,B9,BA,BB,BC" +
        ",BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BO,BP,BQ,BR,BS,BT,BU,BV,BW,BX,BY,BZ,C0,C1,C2,C" +
        "3,C4,C5,C6,C7,C8,C9,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CQ,CR,CS,CT," +
        "CU,CV,CW,CX,CY,CZ,D3,D8,D9,DA,DB,DC,DD,DE,DF,DG,DH,DI,DJ,DK,DL,DM,DO,DP,DQ,DR,DS" +
        ",DT,DU,DY,DZ,E1,E3,E4,E5,E7,E8,E9,EA,EB,EC,ED,EF,EM,EP,EQ,EV,EX,EY,EZ,F1,F9,FA,F" +
        "B,FC,FD,FE,FF,FG,FH,FL,FM,FO,FP,FR,FS,FT,FZ,G2,G3,G4,G5,G7,GA,GB,GC,GD,GE,GF,GG," +
        "GH,GI,GJ,GK,GL,GM,GN,GO,GP,GQ,GR,GS,GT,GV,GW,GX,GY,GZ,H1,H2,H4,HA,HB,HC,HD,HE,HF" +
        ",HG,HH,HI,HJ,HK,HL,HM,HN,HO,HR,HS,HT,HU,HV,HW,HY,HZ,IA,IB,IC,IE,IF,II,IL,IM,IN,I" +
        "P,IT,IU,IV,IW,J2,JB,JE,JG,JK,JM,JO,JR,JU,K1,K2,K3,K4,K5,K6,K7,KA,KB,KC,KD,KE,KF," +
        "KG,KH,KI,KJ,KK,KL,KM,KN,KO,KP,KQ,KR,KT,KV,KW,KX,L2,LA,LB,LC,LD,LE,LF,LG,LH,LI,LJ" +
        ",LK,LM,LN,LO,LP,LQ,LR,LS,LT,LX,LY,M0,M1,M2,M3,M4,M5,M6,M7,M8,M9,MA,MB,MC,MD,ME,M" +
        "F,MG,MH,MI,MJ,MK,ML,MM,MN,MO,MP,MQ,MR,MS,MT,MU,MV,MW,MX,MY,MZ,N1,N2,N3,N4,NA,NB," +
        "NC,ND,NE,NF,NG,NH,NI,NJ,NL,NM,NN,NQ,NR,NS,NT,NV,NW,NX,NY,OA,ON,OP,OT,OZ,P0,P1,P2" +
        ",P3,P4,P5,P6,P7,P8,P9,PA,PB,PC,PD,PE,PF,PG,PH,PI,PJ,PK,PL,PM,PN,PO,PP,PQ,PR,PS,P" +
        "T,PU,PV,PW,PX,PY,PZ,Q1,Q2,Q3,Q4,Q5,Q6,Q7,QA,QB,QD,QH,QK,QR,QS,QT,QU,R1,R2,R3,R4," +
        "R5,R6,R7,R9,RA,RD,RE,RG,RK,RL,RM,RN,RO,RP,RS,RT,RU,S2,S3,S4,S6,S7,S8,S9,SA,SB,SC" +
        ",SD,SE,SF,SG,SH,SI,SJ,SK,SL,SM,SN,SO,SP,SQ,SR,SS,ST,SU,SV,SW,SX,SY,T0,T1,T2,T3,T" +
        "4,T5,T6,T7,T8,T9,TA,TB,TC,TD,TE,TF,TG,TH,TI,TJ,TK,TL,TM,TN,TO,TP,TQ,TR,TS,TT,TU," +
        "TV,TW,TX,TY,TZ,U2,U3,U5,UA,UB,UC,UD,UE,UF,UH,UM,UN,VA,VC,VI,VS,VT,W2,WA,WB,WE,WG" +
        ",WH,WI,WK,WM,WP,WR,WT,WU,WW,X1,YD,YL,YR,YT,ZZ,")]
    public class X12_ID_355
    {
    }
    
    /// <summary>
    /// Note Reference Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",ACC,ALL,APS,BOL,CER,CHG,CUS,DEL,DGN,DOD,EXR,GEN,GPI,GSI,INS,INT,INV,LAB,LEN,LIN," +
        "LOC,LOI,MFG,NCD,ORA,ORI,OTH,PAY,PCS,PDS,PES,PKG,PMT,PRI,PUR,QUT,REV,ROU,SPH,TAF," +
        "TCF,TIL,TLF,TRA,TRF,TSF,WHI,WRP,ZZZ,")]
    public class X12_ID_363
    {
    }
    
    /// <summary>
    /// Communication Number Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AU,CP,ED,EM,EX,FT,FX,HP,IT,PS,TE,TL,TM,TX,WP,")]
    public class X12_ID_365
    {
    }
    
    /// <summary>
    /// Contact Function Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",AA,AB,AC,AD,AE,AF,AG,AH,AI,AL,AM,AN,AP,AR,AT,AU,BB,BC,BD,BI,BP,BU,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CR,CS,CW,CX,DA,DC,DD,DE,DI,DM,DN,DV,EA,EB,EC,ED,EF,EG,EM,EN,EP,EX,FA,FC,FL,FM,GC,GR,HM,IC,IO,IP,LD,MA,MC,MD,ME,MG,NA,NC,NP,NT,OC,OD,OW,PA,PB,PC,PD,PE,PG,PH,PI,PJ,PL,PM,PO,PP,PR,PS,PU,PX,PZ,QA,QC,QI,QM,QP,QR,RA,RC,RD,RE,RG,RP,RS,SA,SC,SD,SE,SH,SK,SM,SO,SP,SR,ST,SU,SV,SY,TA,TC,TD,TH,TM,TP,TR,UG,UP,VM,VP,WH,WR,ZZ,")]
    public class X12_ID_366
    {
    }
    
    /// <summary>
    /// Shipment/Order Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",AB,AN,AS,AU,AV,BK,BM,BP,BT,BW,CA,CB,CC,CE,CI,CK,CL,CM,CN,CO,CP,CS,CT,DD,DE,DO,DS,EC,ED,EW,FS,HQ,IC,ID,IN,IP,IS,LM,LS,LW,MC,NF,NN,NS,NY,OB,OF,OP,OR,PA,PD,PH,PI,PK,PL,PN,PO,PP,PR,PS,PT,QN,QP,RC,RD,RT,RW,SA,SB,SC,SD,SE,SF,SG,SH,SI,SJ,SK,SL,SP,SQ,SS,ST,SU,UB,UN,UR,WS,ZZ,")]
    public class X12_ID_368
    {
    }
    
    /// <summary>
    /// Change Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AQ,BB,BD,DC,EV,FE,GU,GW,LD,MC,PC,PQ,PS,QH,QO,QP,QT,SC,UM,UP,WD,WO,ZZ,")]
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
        "041,042,043,044,046,047,048,049,050,051,052,053,054,055,056,057,058,059,060,061," +
        "062,063,064,065,066,067,068,069,070,071,072,073,074,075,076,077,078,079,080,081," +
        "082,083,084,085,086,087,088,089,090,091,092,093,094,095,096,097,098,099,100,101," +
        "102,103,104,105,106,107,108,109,110,111,112,113,114,115,116,119,120,121,122,124," +
        "125,126,127,128,129,130,131,132,133,134,135,136,137,138,139,140,141,142,144,150," +
        "151,152,153,154,155,156,157,158,159,160,161,162,163,164,165,166,167,168,170,171," +
        "172,173,174,175,176,177,178,179,180,181,182,183,184,185,186,187,188,189,190,191," +
        "192,193,194,195,196,197,198,199,200,201,202,203,204,206,207,208,209,210,211,212," +
        "213,214,215,216,217,218,219,220,221,222,223,224,225,226,227,228,229,230,231,232," +
        "233,234,235,236,237,238,239,240,241,242,243,244,245,246,247,248,249,250,251,252," +
        "253,254,255,256,257,258,259,260,261,262,263,264,265,266,267,268,269,270,271,275," +
        "276,277,278,279,281,282,283,284,285,286,287,288,289,290,291,292,293,294,295,296," +
        "297,298,299,300,301,302,303,304,305,306,307,309,312,313,314,315,316,317,319,321," +
        "322,323,324,327,330,331,332,333,334,335,336,337,338,339,340,341,342,343,344,345," +
        "346,347,348,349,350,351,352,353,354,355,356,357,358,359,360,361,362,363,364,365," +
        "366,367,368,369,370,371,372,373,374,375,376,377,378,379,380,381,382,383,384,385," +
        "386,387,388,389,390,391,392,393,394,395,396,397,398,399,400,401,402,403,404,405," +
        "406,408,414,415,416,417,418,419,420,421,422,423,424,425,426,427,428,429,430,432," +
        "434,435,436,437,438,439,440,441,442,443,444,445,446,447,448,449,450,451,452,453," +
        "454,455,456,457,458,459,460,461,463,464,465,466,467,468,469,471,472,473,474,475," +
        "476,477,478,479,480,481,482,483,484,485,486,487,488,489,490,491,492,493,494,495," +
        "496,500,501,502,503,504,505,506,507,993,994,996,997,ZZZ,")]
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
    [EdiCodes(@",20,2B,40,4B,AC,AF,AL,AT,BC,BG,BO,BR,BX,CA,CB,CC,CD,CG,CH,CI,CJ,CK,CL,CM,CN,CP,CQ,CR,CS,CT,CU,CV,CW,CZ,DF,DT,DX,ET,FH,FN,FR,FS,FT,FX,GS,HB,HC,HO,HP,HT,HV,HY,ID,IX,LO,LU,NX,OB,OT,OV,PT,PU,RC,RE,RF,RG,RI,RO,RR,RT,SA,SC,SK,SL,SS,ST,SV,TA,TB,TC,TF,TG,TH,TI,TJ,TK,TL,TM,TN,TO,TP,TQ,TR,TT,TU,TV,TW,UL,UP,VA,VE,VL,VR,VS,VT,WR,WY,")]
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
    [EdiCodes(",01,02,03,04,10,11,12,13,14,15,16,17,18,19,20,21,22,23,25,26,28,32,33,34,35,36,37" +
        ",39,40,41,42,44,45,46,49,51,59,60,61,62,63,64,69,70,71,72,79,81,82,83,88,99,ZZ,")]
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
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,A1,A2,A3,A4,A5,A6,A7,A8,A9,B1,B2,B3,B4,B5,B6,B7,B8,B9,C1,C2,C3,C4,C5,C6,C7,C8,C9,D1,D2,D3,D4,D5,D6,D7,D8,D9,E1,E2,E3,E4,E5,E6,E7,E8,E9,F1,F3,F4,F5,F6,F7,F8,F9,G1,G2,G3,G4,G5,G6,G7,G8,G9,H1,H2,H3,H4,H5,H6,H7,H8,H9,J1,J2,J3,J4,J5,J6,J7,J8,J9,K1,K2,K3,L1,L2,L3,L4,L5,L6,L7,L8,ZZ,")]
    public class X12_ID_426
    {
    }
    
    /// <summary>
    /// Date Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,66,67,68,69,70,71,72,73,74,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,AA,AB,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BO,BP,BQ,BR,BS,BT,BU,BV,BW,BX,BY,BZ,CA,LA,LD,")]
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
    [EdiCodes(",0,1,2,3,4,5,6,7,8,9,A,B,C,")]
    public class X12_ID_441
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
    [EdiCodes(",B,C,D,E,F,N,R,")]
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
    [EdiCodes(@",AA,AG,AI,AK,AN,AR,AW,BE,BS,CA,CD,CF,CG,CH,CI,CP,CR,CS,D3,D4,DA,DD,DM,DX,EC,ED,ER,FA,FB,FG,FH,FR,FT,GB,GC,GF,GR,HC,HP,IA,IB,IC,IG,II,IM,IN,IO,IP,IR,IS,LB,LR,LS,LT,MA,MD,MI,ML,MO,MS,MT,MV,MW,NC,OG,OW,PA,PC,PD,PJ,PK,PM,PO,PR,PS,PT,PY,PZ,QA,QG,QM,QO,QW,RA,RC,RE,RI,RM,RN,RO,RP,RQ,RR,RS,RT,RU,RY,RZ,SA,SB,SC,SE,SG,SH,SI,SL,SM,SO,SP,SQ,SR,SS,SV,SW,TA,TD,TF,TI,TP,TR,TS,TX,WA,WB,WR,WT,")]
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
    [EdiCodes(",1,2,")]
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
    [EdiCodes(",A,B,C,F,N,O,R,S,X,Y,")]
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
    [EdiCodes(",1,10,11,2,3,4,5,6,7,8,9,")]
    public class X12_ID_52
    {
    }
    
    /// <summary>
    /// Product Transfer Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BP,CC,CO,DS,IA,IB,OF,ON,PA,PB,PL,RA,RB,RC,RP,RU,RV,SA,SC,SD,SH,SM,SS,SU,TD,WL,")]
    public class X12_ID_521
    {
    }
    
    /// <summary>
    /// Amount Qualifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59,6,60,61,62,63,64,65,66,67,68,69,7,70,71,72,73,74,75,76,77,78,79,8,80,81,82,83,84,85,86,87,88,89,9,90,91,92,93,94,95,96,97,98,99,A,A1,A2,A3,A4,A5,A6,A7,A8,A9,AB,AC,AD,AF,AG,AL,AM,AO,AP,AQ,AS,AT,AU,AV,AW,AX,B,B1,B2,B3,B4,B5,B6,B7,B8,B9,BA,BC,BD,BT,C,C1,C2,C3,C4,C5,C6,C7,C8,C9,CB,CC,CH,CL,CM,CS,CT,D1,D2,D3,D4,D5,D6,D7,D8,DD,E,E1,E2,E3,E4,E5,E6,E7,E8,E9,EA,EB,EC,ED,EF,EP,F1,F2,F3,F4,F5,F6,F7,F8,F9,FC,FD,FI,FL,FM,FO,FP,I,I1,IB,IC,II,IP,IU,KA,KB,KC,KD,KE,L,L1,LC,LE,LI,LP,M1,M2,MA,MB,MC,MO,MP,MR,N,N1,NA,NB,NC,NF,NL,NO,NP,NS,NY,OB,OL,OP,P,P1,P2,P3,P4,P5,P6,P7,P8,PA,PB,PC,PE,PL,PO,QN,RC,RR,RS,S,S1,S2,S3,S4,S5,S6,S7,SC,SE,SI,ST,T,T1,T2,T3,TA,TB,TC,TD,TE,TF,TG,TL,TM,TP,TS,TT,U2,UA,UB,UG,UP,US,W1,W2,W3,W4,Y1,ZZ,")]
    public class X12_ID_522
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
    [EdiCodes(",94,AA,AB,AC,AD,AI,AP,AS,AT,AW,AX,BE,BF,BI,CA,CB,CC,CI,CM,CR,CX,DA,DD,DE,DI,DO,DR" +
        ",EI,EP,EU,EX,FA,FD,FI,GC,GS,GU,HC,HI,IA,IM,IS,JA,LI,MB,MC,ME,MI,MP,MS,NA,NE,NF,N" +
        "I,NR,NT,OP,OS,PA,SA,SL,SP,ST,TA,TC,TD,TI,TM,TX,UN,VI,ZZ,")]
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
    /// Sales Requirement Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,BK,F,FT,IS,K,N,O,P2,P3,P4,SC,SE,SF,SG,SL,SP,SQ,SS,ST,SU,SV,SW,W,Y,Z,")]
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
    [EdiCodes(",B0,B1,B2,B3,B4,X,Y,ZZ,")]
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
    [EdiCodes(",REL,ZB1,ZB2,")]
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
    /// Bill of Lading Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",00,01,10,11,")]
    public class X12_ID_582
    {
    }
    
    /// <summary>
    /// Employment Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,AF,AO,AU,CO,CT,DC,DI,DQ,DR,DS,FA,FB,FC,FO,FT,IA,L1,LA,LE,LM,LS,LU,LW,NE" +
        ",PT,RA,RI,RM,RP,RT,RU,RW,SA,SE,SU,TE,UK,ZZ,")]
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
    [EdiCodes(",ACH,BKW,BOP,CCD,CHK,CTP,CTX,CWT,DCD,DPC,DPD,DXC,DXD,DZC,DZD,FEW,FWT,NON,PAC,PBC," +
        "PBD,PDC,PDD,PPD,PRO,REV,SCC,SCD,SDC,SDD,SPC,SPD,SWT,SXC,SXD,SZC,SZD,X12,ZZZ,")]
    public class X12_ID_591
    {
    }
    
    /// <summary>
    /// Lading Description Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,P,")]
    public class X12_ID_592
    {
    }
    
    /// <summary>
    /// Frequency Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,9,A,Q,S,")]
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
    /// Time Period Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,3,4,5,6,7,8,9,Z,")]
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
    [EdiCodes(",AN,AP,AW,BD,BR,BW,CA,CP,CT,DI,DR,DS,EC,FX,HF,HP,LC,LD,LE,LM,LR,ME,NC,NE,NQ,NT,PA" +
        ",PB,PD,PE,PF,PM,PN,PO,PP,PR,PS,PT,PU,PV,PY,QE,QH,QR,QS,QT,RC,RD,RE,RM,RS,RT,SA,S" +
        "C,SM,SR,ST,SW,TB,TC,TD,TE,TF,TM,TP,UM,VQ,WC,WD,WE,WH,WI,WM,")]
    public class X12_ID_639
    {
    }
    
    /// <summary>
    /// Transaction Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,03,04,A0,AC,AD,AF,AI,AM,AN,AP,AQ,AR,AS,AV,AW,AZ,BA,BB,BH,BL,BM,BN,BO,BP,CA,CC,CD,CE,CF,CG,CI,CN,CO,CR,CT,CV,D4,DA,DB,DC,DD,DE,DF,DG,DI,DO,DP,DR,DS,DU,EB,EF,EI,ER,FB,FP,FT,GA,GI,HP,IA,IB,IF,IN,IR,IU,JM,JO,JR,LR,MA,MC,ME,MF,MI,ML,MM,MR,MS,NA,NB,NC,ND,NE,NF,NG,NH,NI,NJ,NK,NL,NM,NP,NQ,NR,NT,PA,PB,PI,PP,PR,PS,RA,RB,RC,RE,RF,RG,SA,SG,SL,SM,SP,SS,SU,SV,TP,TS,UF,WO,WS,")]
    public class X12_ID_640
    {
    }
    
    /// <summary>
    /// Status Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",A01,A02,A03,A04,A05,A06,A07,A08,A09,A10,A11,A12,A13,A14,A15,A16,A17,A18,A19,A20,A21,A22,A23,A24,A25,A26,A27,A28,A29,A30,A31,A32,A33,A34,A36,A37,A38,A39,A40,A41,A42,A43,A45,A46,A49,A50,A51,A52,A55,A58,A59,A61,A63,A64,A65,A73,A74,A91,A95,A96,A98,A99,ABN,ACC,ACD,AGC,AGD,B01,B02,B03,B04,B05,B06,B07,B08,B09,B10,B11,B12,B13,B14,B15,B16,B17,B18,B19,B20,B21,B22,B23,B24,B25,B26,B27,B28,B29,B30,B31,B32,B33,B34,B35,B36,B37,B38,B39,B40,B41,B42,B43,B44,B45,B46,B47,B48,B49,B50,C01,C02,C03,C04,C05,C06,C07,C08,C09,C10,C11,C12,D01,D02,D03,D04,D05,D06,D07,D08,D09,D10,D11,D12,D13,D14,D15,D16,D17,D18,D19,D20,D21,D22,D23,D50,EB1,EB2,EB3,EB4,EB5,EB6,EB7,EB8,EB9,EBA,ENR,ERR,NOR,P01,P02,P03,P04,P05,P06,P07,T01,T02,T03,T04,T05,T06,T07,UCD,UND,ZZZ,")]
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
    [EdiCodes(",001,002,003,004,005,006,007,008,009,010,011,012,024,036,500,801,802,803,804,805," +
        "806,807,808,809,810,811,812,813,814,815,817,818,819,820,821,822,823,824,825,826," +
        "827,828,829,830,831,832,833,834,847,ZZZ,")]
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
    /// Identification Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,10,11,12,13,14,15,16,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34,35,36,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,6,7,71,72,73,74,75,76,77,78,8,81,82,9,91,92,93,94,95,96,97,98,A2,AA,AC,AD,AE,AL,AP,BC,BD,BE,BS,C,C1,C2,CI,CL,CP,DG,DL,DN,DS,EI,FA,FI,HN,LI,LN,M3,M4,MC,MD,MI,MP,MR,N,NI,PC,PI,PP,SD,SI,SL,SP,ST,UP,ZY,ZZ,")]
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
    [EdiCodes(",A,B,C,D,H,M,P,R,")]
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
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,1A,1B,1C,1D,1E,1F,1G,1H,1I,1J,1K,1L,1M,1N,1O,1P,1Q,1R,1S,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,45,46,47,48,49,50,51,52,53,54,55,56,57,58,60,61,62,63,64,65,66,67,68,69,70,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,A1,A2,A3,A4,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AO,AP,AQ,AR,AS,AT,AU,AV,AW,AX,AY,AZ,BA,BF,BQ,BR,CA,CD,CE,CF,CG,CI,CL,CO,CR,CS,CW,DB,DO,DP,DT,E1,E2,EC,EM,ET,FB,GI,GL,GV,HM,HO,HP,HR,II,IP,IQ,KA,KB,KC,LA,LE,LI,LP,LV,MI,MQ,NA,NE,NP,NR,NS,OR,P3,P4,P5,PB,PQ,PR,PS,QA,QB,QC,QE,QH,QP,QS,QU,RA,RB,SG,SP,TR,WV,XG,XJ,XZ,YA,YB,YC,YD,YE,YF,YG,YH,YJ,YK,YL,YM,YN,YP,YQ,YR,YS,YT,YW,YX,")]
    public class X12_ID_673
    {
    }
    
    /// <summary>
    /// Schedule Type Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AD,AS,BB,DL,JS,KB,PD,PS,SH,ZZ,")]
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
    [EdiCodes(",A,B,C,D,E,F,G,H,K,L,M,N,P,S,T,Z,")]
    public class X12_ID_680
    {
    }
    
    /// <summary>
    /// Forecast Timing Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,C,D,F,M,Q,S,T,W,Z,")]
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
    [EdiCodes(",AG,BG,BR,CN,CO,CX,CY,DE,DI,EX,FS,GM,GV,ID,IN,JB,MF,ML,OE,PF,PY,RS,ST,TR,WC,WH,WS" +
        ",")]
    public class X12_ID_687
    {
    }
    
    /// <summary>
    /// Restrictions/Conditions Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",NR,NS,OR,SR,")]
    public class X12_ID_688
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
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,")]
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
    [EdiCodes(",1,2,")]
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
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,")]
    public class X12_ID_706
    {
    }
    
    /// <summary>
    /// Rating Category Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,")]
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
    [EdiCodes(",1,2,3,4,5,56,6,7,8,9,A,AL,B,C,CC,CE,CT,D,DP,E,EL,F,FC,G,H,I,IA,IB,J,K,L,M,ML,O,P" +
        ",PC,PH,PL,Q,R,S,SC,SE,SY,T,U,V,W,WB,X,Y,ZZ,")]
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
    [EdiCodes(",9L,AA,AE,AV,BA,BD,BL,BM,BO,BP,BT,BZ,CA,CH,CN,CO,CS,CT,CV,DE,DT,EA,EE,EN,FD,FV,IN" +
        ",IR,LC,LL,LM,LT,NC,NX,OD,OG,P1,PA,PC,PD,PK,PL,PM,PO,PR,PS,PT,R1,R2,RA,RL,RN,RO,R" +
        "P,RQ,RS,RT,SD,SE,SF,SH,SK,SL,SM,SP,SR,ST,SU,TD,TE,TI,TL,TP,TR,TS,WA,WT,ZP,")]
    public class X12_ID_737
    {
    }
    
    /// <summary>
    /// Measurement Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,A1,A2,A3,A4,A5,A6,AA,AB,ABO,ABR,ABS,AC,ACN,AD,ADH,AE,AF,AG,AGE,AH,AI,AJ,ALK,AL" +
        "N,ALP,AMW,AP,APP,AS,ASH,ASY,AT,AVT,AZ,B,B1,BA,BB,BC,BD,BDP,BE,BF,BG,BH,BHF,BHS,B" +
        "IC,BJ,BK,BL,BO,BOR,BP,BQ,BR,BRS,BSW,BT,BU,BUD,BW,C,C1,C2,C3,CA,CAU,CC,CCF,CD,CE," +
        "CF,CG,CGR,CH,CHA,CHC,CHG,CHL,CI,CIV,CJ,CK,CL,CLA,CM,CN,CO,COL,CON,COR,COT,CP,CPF" +
        ",CPS,CQ,CR,CS,CSC,CST,CU,CUT,CW,CX,CY,CYB,D,D1,D2,D3,D4,DA,DAT,DB,DC,DCT,DD,DE,D" +
        "F,DG,DH,DI,DIR,DIS,DJ,DL,DM,DME,DMF,DN,DP,DPM,DRY,DS,DT,DU,DW,DWP,DY,E,E1,EA,EB," +
        "EC,ED,EE,EF,EG,EH,EI,EJ,ELC,ELL,ELO,ELP,ELS,ELT,ELV,ELW,ELX,EM,EN,EP,EVL,EVR,EX," +
        "F,F1,FA,FB,FBP,FC,FD,FE,FF,FG,FH,FI,FIL,FIN,FIT,FK,FL,FLD,FLN,FLP,FML,FMZ,FN,FNS" +
        ",FOA,FOI,FOR,FP,FPV,FQ,FR,FRP,FS,FSI,FT,FV,FW,FX,G,GA,GB,GC,GD,GE,GF,GG,GGR,GH,G" +
        "IR,GL,GLE,GN,GOR,GP,GR,GRA,GRI,GRS,GW,H1,H2O,HA,HAZ,HB,HC,HD,HE,HF,HG,HH,HHW,HI," +
        "HIB,HJ,HM,HO,HOC,HP,HR,HT,HVM,HWS,HYD,HZ,HZC,IB,IC,ID,IDE,IF,IG,IGA,IGR,IH,II,IJ" +
        ",IK,IM,IMP,IN,IND,INS,IO,IP,IPI,IQ,IR,IS,IT,IU,IV,IW,IX,IY,IZ,JA,KA,KB,KN,L,L1,L" +
        "A,LB,LC,LD,LE,LEF,LF,LG,LIR,LIV,LL,LM,LN,LO,LOI,LOS,LOW,LP,LPG,LPR,LS,LSS,LT,LTD" +
        ",LW,M,M1,M2,M3,MA,MAT,MB,MC,MD,ME,MEF,MEL,MEP,MER,MF,MG,MH,MI,MIC,MJ,MK,MN,MO,MO" +
        "I,MOW,MP,MPR,MS,MT,MTD,MU,MUL,MV,MW,MX,MY,N,NA,NB,NC,ND,NEU,NF,NG,NH,NI,NJ,NK,NL" +
        ",NM,NO,NOC,NON,NOR,NP,NS,NU,O,O1,OA,OAP,OB,OBT,OC,OCG,OCR,OD,ODR,OE,OF,OG,OH,OI," +
        "OJ,OK,OL,OM,ON,OO,OP,OQ,OR,ORC,OS,OT,OTH,OV,OW,OX,OXI,OXS,PA,PAR,PB,PBD,PC,PD,PD" +
        "E,PDG,PE,PF,PFO,PG,PH,PHA,PHW,PI,PIC,PJ,PK,PL,PM,PN,PO,POD,POP,POR,PP,PPS,PQ,PR," +
        "PRF,PRL,PRQ,PRY,PS,PSA,PSW,PT,PU,PV,PW,PWE,PX,PY,PZ,QA,QUR,R,R10,R18,RA,RAF,RB,R" +
        "C,RD,RE,REA,RED,REF,REI,REL,RES,RF,RG,RH,RI,RJ,RK,RL,RM,RN,RO,RP,RQ,RR,RS,RT,RTB" +
        ",RU,RUD,RV,RVP,RW,RX,RY,S,S1,S10,S12,S18,S2,S3,S4,S5,S6,S7,S8,S9,SA,SAP,SB,SC,SD" +
        ",SE,SF,SH,SHA,SI,SIL,SJ,SK,SL,SLI,SM,SN,SO,SOD,SOF,SOL,SP,SPG,SPR,SQ,SR,SS,ST,ST" +
        "A,STL,STP,SU,SUM,SUT,SV,SW,SX,SXX,SY,SZ,T,T1,T2,TA,TAS,TB,TC,TD,TDP,TE,TEE,TES,T" +
        "EX,TF,TG,TH,TI,TJ,TK,TL,TM,TN,TO,TOA,TP,TPF,TPL,TPQ,TPS,TQ,TR,TRA,TRC,TRN,TS,TT," +
        "TU,TUR,TV,TVD,TX,TY,U,UA,UCB,UNI,UNK,VAD,VAP,VH,VIS,VO,VOL,VOT,VOV,VOW,VSO,VW,WA" +
        ",WB,WC,WD,WDE,WE,WEL,WF,WH,WL,WM,WPF,WPL,WPS,WR,WRA,WT,WTB,WU,WX,X,XA,XH,XP,XQ,X" +
        "Z,YA,YB,YC,ZAL,ZAS,ZB,ZBI,ZBT,ZC,ZCA,ZCB,ZCD,ZCE,ZCO,ZCR,ZCU,ZET,ZF,ZFE,ZFS,ZG,Z" +
        "GE,ZH,ZHP,ZHS,ZHX,ZIB,ZIP,ZMG,ZMN,ZMO,ZMT,ZN,ZNB,ZNI,ZNP,ZO,ZOC,ZP,ZPB,ZPP,ZPT,Z" +
        "R,ZS,ZSB,ZSE,ZSI,ZSN,ZTA,ZTE,ZTI,ZV,ZW,ZZN,ZZR,ZZZ,")]
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
    /// Product/Process Characteristic Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,25,28,29,30,32,33,34,35,36,37,38,39,40,41,42,43,54,55,56,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,99,9A,9B,9C,9D,AT,BC,BLM,BPI,BW,C2,C3,C4,C5,CCN,CFC,CHF,CLT,CMS,CS,CW,DAC,DAF,DE,DF,DIR,DM,EC,FA,FC,FCD,FDD,FMR,GD,GEN,GM,HB,HZ,ING,LO,MA,MAC,MBU,MS,MSG,NH,OD,ODR,OR,OT,PFA,PFC,PFG,PFI,PFL,PFS,PFT,PP,PR,PRO,PSC,QAS,RA,RCC,RSD,RSE,RX,SLM,SOL,SYN,TC,TE,TF,THR,TP,TR,TRN,TWF,WD,WLC,WTT,")]
    public class X12_ID_750
    {
    }
    
    /// <summary>
    /// Surface/Layer/Position Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1S,2S,BC,BK,BS,BT,DT,DU,FR,FS,IN,LT,OA,OS,OT,R0,R1,R2,R3,R4,R5,R6,R7,R8,R9,RA,RB" +
        ",RC,RD,RE,RF,RG,RH,RI,RJ,RK,RL,RM,RN,RO,RP,RQ,RR,RS,RT,RU,RV,RW,RX,RY,RZ,S1,S2,S" +
        "3,S4,S5,S6,S7,S8,S9,SA,SB,SC,SD,SE,SF,SP,SS,TB,TP,TS,UC,UT,")]
    public class X12_ID_752
    {
    }
    
    /// <summary>
    /// Packaging Characteristic Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",10,11,34,35,36,37,38,39,40,42,43,44,45,60,61,62,63,65,66,67,68,")]
    public class X12_ID_753
    {
    }
    
    /// <summary>
    /// Report Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,11,12,13,14,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,AA,AB,AD,AM,AO,AP,AS,AT,BC,BL,BM,BO,BT,CA,CB,CC,CD,CI,CM,CN,CO,CP,CS,CT,CW,CX,CY,DA,DB,DC,DD,DG,DI,DM,DN,DR,DS,DW,EA,EB,EC,EP,ER,F1,F2,F3,F4,F5,FD,FH,IP,IT,IV,LC,LD,LO,LR,LW,MA,MB,MC,MD,ME,MF,MI,MM,MN,MO,MR,MS,MT,MV,NN,OB,OP,OX,OZ,PA,PB,PC,PD,PE,PF,PG,PH,PI,PJ,PN,PO,PR,PS,PT,PW,PZ,QC,QD,QE,QM,QR,QS,QT,RA,RB,RC,RF,RM,RN,RO,RR,RT,S1,S2,S3,S4,S5,S6,S7,S9,SB,SD,SI,SL,SM,SN,SP,SQ,SR,SS,ST,SW,TT,US,VD,VM,WI,WT,")]
    public class X12_ID_755
    {
    }
    
    /// <summary>
    /// Report Transmission Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AE,AM,AU,BE,BM,BW,DA,DC,EL,FD,FX,GS,IA,IE,IM,KS,MS,NS,PC,PO,SE,SM,SN,TA,TE,TM,TX" +
        ",VO,WS,")]
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
    [EdiCodes(",A,C,D,E,M,N,O,R,S,W,")]
    public class X12_ID_762
    {
    }
    
    /// <summary>
    /// Market Area Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",001,002,003,004,005,006,")]
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
    [EdiCodes(",OS,OT,PS,SO,ST,TO,TS,TT,")]
    public class X12_ID_783
    {
    }
    
    /// <summary>
    /// Security Level Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",00,01,02,03,04,05,09,90,92,93,94,99,")]
    public class X12_ID_786
    {
    }
    
    /// <summary>
    /// Drawing Sheet Size Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A0,A1,A2,A3,A4,AH,AV,BH,CH,DH,EH,FH,GH,HH,JH,KH,NL,")]
    public class X12_ID_789
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
    /// Payment Format
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
    [EdiCodes(",AM,AP,CA,CM,CO,DI,DM,DS,EI,EN,EO,EP,FA,FE,HH,HI,IA,MI,MS,PD,PR,RE,RG,SH,SL,ST,TS" +
        ",TX,")]
    public class X12_ID_820
    {
    }
    
    /// <summary>
    /// Safety Characteristic/Hazard Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",ACT,AIR,CAR,CON,DCL,DEC,DEH,DIS,DPI,EFA,EFB,EFX,EPA,ESD,EVP,EXI,EXL,EYA,EYC,EYF,EYZ,FAL,FAS,FAT,FAZ,FEH,FEZ,FIP,GCA,GMA,GPI,HAI,HCA,HHA,HZC,IGA,IGC,IGZ,IHA,IHC,IHZ,INC,INS,LKI,MCE,MUT,NOT,NTE,NTR,NTS,NTZ,OPH,OPR,ORC,POL,PPA,PPC,PPD,PPE,PPF,PPG,PPR,PPS,PPZ,PRE,PRF,PRG,PRH,PRI,PRJ,PRK,PRL,PRM,PRO,PRQ,PRS,PRT,PRU,PRZ,RCA,REP,RLI,RTK,SAP,SBY,SHI,SKA,SKC,SKT,SKZ,SPF,SPI,SPJ,SPL,SPP,SPR,STA,SYS,TER,TOA,TRH,VRZ,WDI,")]
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
    [EdiCodes(",1,2,3,4,5,")]
    public class X12_ID_837
    {
    }
    
    /// <summary>
    /// Inbound Condition  Hold Code
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
    [EdiCodes(",1,2,3,4,5,6,7,8,")]
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
    [EdiCodes(",QA,QB,QC,QD,QE,QH,QI,QL,QM,QN,QO,QP,QR,QS,QT,QW,QX,")]
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
    [EdiCodes(",001,002,003,004,005,021,022,023,024,025,026,028,029,030,032,ZZZ,")]
    public class X12_ID_875
    {
    }
    
    /// <summary>
    /// Marks and Numbers Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CA,GM,L,MC,PB,R,S,SI,SM,SR,SS,UC,ZZ,")]
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
    [EdiCodes(",1,2,3,4,5,6,")]
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
    [EdiCodes(",CA,FR,RE,RJ,RP,RT,RW,SC,UA,")]
    public class X12_ID_887
    {
    }
    
    /// <summary>
    /// Nonconformance Determination Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,Y,")]
    public class X12_ID_888
    {
    }
    
    /// <summary>
    /// Follow-up Action Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,R,W,X,Y,")]
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
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,ZZ,")]
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
    [EdiCodes(",01,05,06,07,08,DA,SG,ZZ,")]
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
        ",29,30,31,E1,E2,E3,E4,E5,E6,ZZ,")]
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
    [EdiCodes(",6,7,A,AC,AE,AF,AH,AQ,AR,B,BP,BU,C,CE,D,DA,DW,E,ED,FA,FL,GG,GR,GS,H,I,J,K,L,LA,LT" +
        ",M,MB,MP,N,O,P,PA,PG,PL,PP,PR,PT,Q,R,RC,RR,S,SB,SC,SD,SE,SR,SS,T,TA,TC,U,VA,VE,V" +
        "L,W,WP,X,Y,Y1,Y2,ZZ,")]
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
    [EdiCodes(",AB,AC,AO,BD,BE,BK,BL,BQ,BY,CA,CF,CP,CR,DR,DS,EO,FH,IN,JL,KO,LB,LS,NE,NP,NS,OS,PR" +
        ",RA,RE,RL,RN,RO,RR,RT,RU,SA,SO,SP,SS,ST,SW,TC,TM,TR,UD,UE,US,WO,ZZ,")]
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
        ",28,29,30,")]
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
    [EdiCodes(",01,02,03,04,05,06,07,08,09,AG,CT,FL,MA,ME,SB,SP,")]
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
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,")]
    public class X12_ID_943
    {
    }
    
    /// <summary>
    /// Sample Direction Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,")]
    public class X12_ID_944
    {
    }
    
    /// <summary>
    /// Sample Location Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,")]
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
    [EdiCodes(",01,02,03,04,05,")]
    public class X12_ID_960
    {
    }
    
    /// <summary>
    /// Receiving Advice or Acceptance Certificate Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,")]
    public class X12_ID_962
    {
    }
    
    /// <summary>
    /// Tax Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BP,CA,CI,CP,CR,CS,CT,FD,FR,FT,GR,GS,HS,HT,LO,LS,LT,MP,MT,OT,SE,SL,SP,SR,ST,SU,SX" +
        ",TD,TT,TX,VA,ZA,ZB,ZC,ZD,ZE,ZZ,")]
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
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,1P,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,87,88,A1,A2,A3,A4,A5,A6,A7,A8,A9,AA,AB,AC,AD,AE,AF,AG,AI,AK,AL,AN,AO,AP,AQ,AR,AS,AT,AU,AV,B1,B2,B3,B4,B5,B6,B7,B8,B9,BA,BD,BE,BF,BG,BK,BL,BM,BN,BO,BR,BS,BT,BU,BV,BW,BY,C1,C2,C3,C4,C5,C6,C7,C8,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CQ,CR,CS,CT,CU,CV,CW,CZ,DA,DB,DC,DD,DE,DF,DG,DH,DI,DJ,DK,DL,DM,DN,DO,DP,DQ,DR,DS,DT,DU,DV,DZ,E1,E2,E3,EB,EC,EE,EF,EG,EL,EM,EN,EP,ES,EX,EY,FA,FB,FH,FM,FO,FR,FS,FW,GA,GP,GU,HB,HF,HS,IA,IC,ID,II,IK,IL,IM,IN,IS,IT,IU,KA,KB,KC,KD,KE,KF,KG,KK,KR,KS,L1,LB,LC,LE,LG,LH,LI,LL,LM,LN,LO,LP,LR,LS,LV,M1,M2,M3,M4,M6,M7,M8,MA,MB,MC,MD,ME,MF,MG,MH,MI,MJ,MK,ML,MM,MP,MQ,N1,N2,N3,NC,ND,NN,NP,OA,OB,OC,OI,OM,OO,OP,OR,OS,OT,OU,OV,OW,OX,P1,P2,P3,P4,P5,P8,P9,PA,PB,PC,PD,PE,PF,PG,PH,PI,PJ,PK,PL,PM,PN,PO,PP,PQ,PR,PS,PT,PU,PV,PW,PX,PY,PZ,QA,QB,QC,QD,QR,R1,R3,RA,RB,RC,RD,RE,RF,RG,RH,RI,RJ,RK,RL,RM,RN,RO,RP,RQ,RR,RS,RT,RU,RY,RZ,S1,S2,SA,SB,SC,SD,SE,SF,SG,SH,SI,SJ,SK,SL,SM,SN,SO,SP,SQ,SR,SS,ST,SU,SV,SW,SY,T1,T2,T3,T4,T5,T6,T7,TC,TF,TH,TI,TL,TM,TO,TP,TR,TS,TT,UC,UP,VN,WD,WF,WH,WO,X1,X2,Z1,Z2,Z3,Z4,Z5,Z6,Z7,Z8,ZA,ZB,ZD,ZE,ZF,ZL,ZN,ZQ,ZR,ZS,ZZ,")]
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
