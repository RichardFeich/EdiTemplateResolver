namespace EdiFabric.Templates.X12003020
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
    [EdiCodes(",1,2,3,4,")]
    public class X12_ID_1004
    {
    }

    /// <summary>
    /// Hierarchical Structure Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0001,0002,")]
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
    [EdiCodes(",1,2,3,4,5,")]
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
    [EdiCodes(",CO,CR,DE,MA,NC,OA,PI,PR,")]
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
    [EdiCodes(",AC,QF,QM,TH,TM,")]
    public class X12_ID_1046
    {
    }

    /// <summary>
    /// Miscellaneous Equipment Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AI,CY,DB,DR,ME,ND,NO,PR,SC,SE,VI,")]
    public class X12_ID_1047
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
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,17,18,30,31,32,33,34,36,37,ZZ,")]
    public class X12_ID_1069
    {
    }

    /// <summary>
    /// Payment Method Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,E,F,L,")]
    public class X12_ID_107
    {
    }

    /// <summary>
    /// Type of Residence Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,")]
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
    [EdiCodes(",F,M,T,")]
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
    [EdiCodes(",C,D,")]
    public class X12_ID_1102
    {
    }

    /// <summary>
    /// Loan Documentation Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",F,R,")]
    public class X12_ID_1103
    {
    }

    /// <summary>
    /// Name Component Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,17,")]
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
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,")]
    public class X12_ID_1106
    {
    }

    /// <summary>
    /// Name Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,11,12,13,14,15,16,21,")]
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
    /// Port Function Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,V,W,Y,")]
    public class X12_ID_115
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
    /// Rate Class Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,BHR,C,CTR,DMA,DMB,DMC,E,ECR,F,H,L,M,N,O,Q,QUO,R,S,U,V,X,Y,")]
    public class X12_ID_121
    {
    }

    /// <summary>
    /// Rate/Value Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",AA,AC,AV,B0,B1,BF,BL,BR,C5,CF,CM,CT,DD,DP,DR,DS,EI,ER,FC,FF,FL,FN,FR,FT,FV,GT,HD,HM,HN,HY,KG,KL,KP,KT,LB,LP,LR,LS,LT,MD,ME,MH,MI,MM,MN,MO,MP,MS,MT,MV,MW,MX,PA,PB,PC,PD,PE,PF,PG,PH,PK,PL,PM,PP,PQ,PR,PS,PT,PU,PV,QY,RP,S0,S1,SC,SD,SF,SP,ST,SU,SY,TB,TC,TD,TN,TP,TR,VM,VP,VS,VU,WK,WM,YR,")]
    public class X12_ID_122
    {
    }

    /// <summary>
    /// Date Time Period Format Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CC,CM,CY,D6,D8,DD,MM,RD2,RD4,RD6,RD8,RDT,RTM,TM,TS,YM,YY,")]
    public class X12_ID_1250
    {
    }

    /// <summary>
    /// Reference Number Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,03,04,05,06,07,09,10,11,12,13,14,15,1A,1B,1C,1D,1E,1F,1G,1H,1J,1K,1L,1N,1S,1T,1U,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,51,52,53,54,61,62,63,64,65,95,96,A1,A3,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AR,AS,AT,AU,AW,AX,AY,B1,B4,BC,BD,BG,BH,BI,BJ,BK,BL,BM,BN,BO,BR,BS,BT,BU,BV,BW,BX,BY,BZ,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CQ,CR,CS,CT,CU,CV,CW,CX,CY,CZ,D1,D2,D4,D5,DB,DC,DD,DE,DF,DG,DH,DI,DJ,DK,DL,DN,DO,DP,DQ,DR,DS,DT,DV,DW,DX,DY,EB,ED,EF,EG,EI,EL,EM,EN,EP,EQ,ER,ES,ET,EU,EZ,FA,FB,FC,FD,FE,FG,FI,FK,FM,FN,FP,FR,FS,FT,FU,FX,GA,GB,GC,GE,GG,GP,GR,GS,GT,HB,HC,HD,HE,HI,HN,HO,HP,HS,HW,I2,IA,IB,IC,ID,IE,IF,IG,II,IL,IM,IN,IO,IP,IR,IS,IT,IV,IX,JA,JB,JE,JS,KB,KE,KG,KH,KI,KJ,KM,L1,LA,LB,LC,LD,LF,LG,LI,LM,LN,LO,LP,LS,LT,LV,LW,M1,M2,M4,M5,MA,MB,MC,MD,ME,MF,MG,MH,MI,MJ,MK,ML,MM,MN,MO,MP,MQ,MR,MS,MT,MU,MY,N0,NA,NB,NC,ND,NG,NN,NO,NP,NR,NS,NX,O5,OB,OC,OI,OM,ON,OP,OR,OS,OT,OW,P1,P2,P3,P4,P5,P6,P7,P8,P9,PA,PB,PC,PD,PE,PF,PG,PH,PI,PJ,PK,PL,PM,PN,PO,PP,PQ,PR,PS,PT,PU,PV,PW,PX,PY,PZ,Q1,Q2,Q3,QA,QB,QC,QD,QE,QF,QI,QM,QN,QR,QY,R1,R2,R3,R4,R5,R6,R7,R8,R9,RA,RB,RC,RD,RE,RF,RG,RH,RI,RJ,RK,RL,RM,RN,RO,RP,RQ,RR,RS,RT,RU,RV,RW,RX,RY,RZ,S1,S2,S3,S4,S6,S7,S8,S9,SA,SB,SC,SD,SE,SF,SG,SH,SI,SJ,SK,SL,SM,SN,SO,SP,SQ,SR,SS,ST,SV,SW,SX,SY,SZ,T1,T2,T3,T4,T5,TA,TB,TC,TE,TF,TG,TH,TI,TJ,TK,TL,TM,TN,TO,TP,TQ,TR,TS,TT,TX,UB,UD,UG,UN,UP,US,UT,V1,V3,VA,VB,VC,VD,VN,VP,VR,VS,VT,VV,VX,WM,WN,WO,WP,WR,WS,WY,XC,XP,XX,ZA,ZB,ZC,ZZ,")]
    public class X12_ID_128
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
    /// Routing Sequence Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,B,D,H,I,M,O,R,S,V,Z,")]
    public class X12_ID_133
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
    [EdiCodes(@",101,104,105,107,108,109,110,111,113,114,115,116,170,204,205,207,208,210,211,213,214,216,217,218,300,301,302,303,304,305,306,307,308,309,310,311,312,313,314,315,316,317,319,321,322,323,324,350,352,353,354,355,360,361,404,407,408,410,411,414,416,417,418,419,420,421,422,423,424,425,426,427,429,431,440,460,461,462,463,464,465,466,467,468,469,480,485,486,490,491,492,494,499,602,622,810,811,812,815,819,820,821,822,823,824,826,827,828,829,830,832,835,836,838,840,841,842,843,844,845,846,848,849,850,851,852,855,856,857,858,859,860,861,862,863,864,865,866,867,868,869,870,872,874,875,876,877,878,879,880,881,882,883,884,885,888,889,890,891,892,893,894,895,896,905,920,924,925,926,928,940,941,942,943,944,945,946,947,980,990,994,995,996,997,998,999,")]
    public class X12_ID_143
    {
    }

    /// <summary>
    /// Shipment Method of Payment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CA,CC,CD,CF,DF,FO,HP,MX,NC,NR,PA,PB,PC,PL,PO,PP,PU,RC,RF,RS,TP,WC,")]
    public class X12_ID_146
    {
    }

    /// <summary>
    /// Shipment Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,")]
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
        "999,AAA,AAJ,AAM,AAN,AAO,AAT,ABC,ABL,ACD,ACF,ACH,ACS,ADH,ADV,AFB,AFC,ALC,AMB,AMC," +
        "AMP,ANB,ANS,APT,ARB,ASC,AVA,BAA,BAB,BAC,BAD,BAF,BAP,BAS,BBK,BDX,BEY,BFD,BLA,BLC," +
        "BLD,BLK,BLW,BND,BOB,BRA,BRD,BSC,BYD,CAA,CAB,CAC,CAD,CAE,CAF,CAG,CAH,CAJ,CAK,CAL," +
        "CAO,CAP,CAQ,CAR,CAS,CAT,CAU,CAV,CAW,CBL,CBO,CBP,CBR,CBW,CBX,CCA,CCH,CCR,CDA,CDF," +
        "CDR,CER,CGL,CHG,CHN,CIR,CLC,CLN,CLS,CMC,CMF,CMI,CMP,CNS,CNV,COA,COC,COD,COF,COL," +
        "COM,CON,COU,CRA,CRC,CRF,CSA,CSC,CSE,CSF,CSR,CTA,CTC,CTF,CTG,CTL,CUA,CUD,CUF,CUS," +
        "DAA,DAB,DAC,DAD,DAM,DBD,DCS,DCT,DDA,DDC,DDD,DDF,DDS,DEA,DEL,DEM,DEP,DER,DES,DET," +
        "DFW,DIC,DIS,DIV,DLH,DMC,DMD,DOC,DON,DRC,DRP,DRY,DSC,DSF,DST,DTA,DTC,DTL,DTU,DWC," +
        "EAC,EBD,EBP,ECC,EEA,EEB,EEC,EED,EEF,EEG,EEH,EEP,EEX,EIC,EMS,ENC,ENS,EPC,EPS,ESA," +
        "ESC,EUC,EVC,EXC,EXL,EXM,EXP,EXS,EXW,FAB,FAC,FAD,FAE,FAF,FAG,FAH,FBD,FCB,FCD,FDL," +
        "FFI,FFL,FFN,FFP,FFR,FMR,FMS,FRC,FTC,FUE,FWA,FWC,GAR,GDR,GGA,GGF,GPD,GRD,GRS,GST," +
        "HAN,HAZ,HDF,HDG,HET,HFA,HHA,HHB,HHG,HIC,HLF,HOC,HOL,HOS,HOX,HSC,HUL,HZS,IAA,IAB," +
        "IAC,IDL,IDP,IFC,IHT,IIA,IIP,IIU,ILD,ILF,ILP,INC,INP,INR,INS,IPC,IPU,IRA,ISD,ITC," +
        "LAA,LAB,LAC,LAD,LAE,LAT,LAY,LCG,LCR,LDA,LDG,LDL,LDS,LFT,LID,LLC,LLD,LLF,LLS,LMC," +
        "LNT,LOA,LOC,LPC,LSC,LSH,LSS,LTC,LUP,LUS,MAA,MAB,MAC,MAD,MAE,MAR,MCC,MDM,MES,MFC," +
        "MFG,MGA,MGC,MIL,MIN,MLB,MMC,MMF,MMS,MMT,MNC,MRK,MSC,MSG,MTR,MUS,MVT,NAA,NAB,NAL," +
        "NCH,NFY,NHB,NSD,NWD,NYD,NYP,OAA,OAB,OAC,OCH,ODF,ONC,OOC,OOF,OPC,ORC,ORM,OSO,OSS," +
        "OUT,OVR,PAA,PAB,PAC,PAD,PAE,PAF,PAG,PAH,PAI,PAJ,PAK,PBA,PBE,PBL,PCH,PCT,PDB,PDC," +
        "PEC,PEN,PER,PFA,PIR,PLC,PMC,PMU,PMX,POD,POS,PPC,PPH,PPI,PPM,PPN,PPO,PPR,PPS,PPT," +
        "PPU,PRB,PRC,PRE,PRL,PRM,PRO,PSC,PSH,PST,PTC,PUC,PUD,PWH,PWT,QAA,QQD,RAA,RAB,RAC," +
        "RAD,RAE,RAF,RAG,RAH,RAI,RAJ,RAK,RAL,RAM,RCA,RCB,RCC,RCD,RCE,RCG,RCL,RCP,RCS,RDC," +
        "RDF,REC,REE,REF,REG,REP,REQ,RES,RET,RFD,RGA,RGC,RHM,RID,RLC,RLQ,RMB,RMD,ROC,RPC," +
        "RRC,RRD,RRF,RRN,RRP,RRR,RSM,RTC,SAA,SAB,SAC,SAD,SAE,SAF,SAG,SAH,SAI,SAJ,SAK,SAM," +
        "SAN,SAP,SAT,SBC,SCC,SCG,SCL,SCU,SDC,SDL,SEC,SEG,SEL,SER,SFT,SGL,SHL,SHS,SLC,SMS," +
        "SOC,SOP,SPA,SPB,SPC,SPD,SPL,SPP,SPS,SPT,SPU,SRG,SSA,SSB,SSC,SSF,SSL,SSO,SSP,SSS," +
        "SST,SSX,STC,STF,STM,STP,STR,STW,SUC,SUF,SUP,SUR,SVA,SWC,TAA,TAB,TAC,TAD,TAE,TAF," +
        "TAG,TAH,TAI,TAJ,TAK,TAL,TAX,TAY,TCB,TCM,TDT,TER,TLC,TOA,TOC,TPC,TRC,TRF,TRN,TRP," +
        "TRS,TRU,TSC,TST,TTA,TTB,TTD,TTL,TTM,TTP,TTR,TTS,TTT,TTV,TUR,TWO,UND,UNL,UPD,URC," +
        "USF,USV,USW,UTP,UUC,UUM,UUT,VAA,VAB,VCR,VIT,VOR,VVL,VVP,WAR,WAT,WEA,WFH,WHC,WRC," +
        "WRE,WSA,WTG,WTV,WWC,ZFF,")]
    public class X12_ID_150
    {
    }

    /// <summary>
    /// Special Handling Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",A1M,A3M,A5M,AGG,AGS,AK,AMM,ARG,ASY,AT,AV,AW,BA,BCP,BL,BLS,BN,BNS,BOX,BW,CAR,CCB,CCH,CD,CE,CH,CI,CLS,CM,CMD,CNL,CNS,CO,CON,COR,COU,COV,CPM,CR,CSD,CTM,CW,CY,DA,DCS,DDP,DE,DIS,DLR,DM,DN,DOC,DR,DRO,DRU,DS,DSR,DT,DU,DW,EE,EMR,END,EP,ER,EW,EX,EXC,EXO,EXP,EXT,EXU,EZE,FC,FD,FG,FL,FP,FPT,FR,FRZ,FS,FST,GI,GSS,HAN,HE,HEA,HES,HET,HH,HM,HO,HOR,HP,HQT,HR,HT,HV,HW,IB,IC,ID,IM,INT,IP,IR,IS,JIT,JLX,JS,KEG,KMD,LAB,LAY,LB,LBT,LC,LD,LF,LP,LS,LT,LTT,MC,MES,MEX,MF,MIN,MOT,MP,MR,MRF,MSS,MTE,NC,ND,NE,NH,NP,NPR,NS,NT,NW,NX,OBL,OCA,OCL,OCS,OCV,OEH,OFU,OHC,OIL,ONC,ONS,OOB,OOD,OOL,OPR,OPT,OS,OSB,OST,OTC,OTD,OTS,OVR,OWR,PB,PD,PER,PG,PHR,PI,PIR,PMM,PMR,PS,PSS,PTS,PUP,PW,RA,RB,RC,RDR,RM,RO,RR,RRR,RS,RT,SB,SC,SCL,SD,SE,SER,SEV,SF,SGL,SH,SHL,SI,SK,SLC,SM,SMP,SMS,SOL,SP,SPR,SPT,SR,SSN,ST,STR,SUP,TA,TDC,TDP,TLS,TN,TOF,TRA,TRK,TRL,TRN,TRS,TRT,TS,TSC,TSP,TSS,TT,TV,UB,UI,UN,UP,US,VAC,VAN,VT,WB,WD,WE,WH,WI,WM,WO,WW,XP,XT,")]
    public class X12_ID_152
    {
    }

    /// <summary>
    /// Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",A,AA,AD,AE,AF,AG,AH,AI,AJ,AL,AM,AN,AO,AP,AR,AV,B,BA,BC,BD,BE,BF,BR,C,CA,CB,CC,CR,CS,CT,CU,CV,D,DA,DC,DP,DR,DS,DT,E,EA,EE,ER,F,FP,FT,G,GO,H,HA,HB,HC,HD,I,J,K,L,MT,N,ND,NF,NH,NO,NP,NS,NT,O,OA,OB,OF,OH,ON,P,PA,PB,PC,PD,PE,PF,PG,PH,PI,PJ,PK,PL,PM,PN,PO,PP,PQ,PR,PS,PT,PU,PV,R,RA,RB,RC,RD,RL,S,SA,SB,SC,SI,T,TM,UA,UB,UC,UD,UE,UR,UV,V,VA,VD,W,WE,WH,WR,X,Y,Z,ZZ,")]
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
    [EdiCodes(",AL,CL,CN,CU,HT,LD,LE,PL,PU,RT,SL,SU,TL,UL,WL,")]
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
    /// Intermodal Service Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",00,10,12,20,22,25,30,40,50,60,70,80,83,84,")]
    public class X12_ID_177
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
    [EdiCodes(",A,A1,A2,A3,B,C,D,DR,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,RG,RN,RT,S,T,U,V,W,WA,WB,WG,WJ,X" +
        ",Y,Z,")]
    public class X12_ID_187
    {
    }

    /// <summary>
    /// Weight Unit Qualifier
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
    [EdiCodes(",4,6,9,A,D,E,F,I,R,U,")]
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
    [EdiCodes(@",AMM,BAG,BAL,BBL,BDL,BEM,BIC,BIN,BLK,BOB,BOX,BRG,BSK,BXI,BXT,CAB,CAG,CAN,CAR,CAS,CBC,CBY,CCS,CHE,CHS,CLD,CNT,COL,CON,COR,CRD,CRT,CSK,CTN,CYL,DBK,DRK,DSK,DTB,ENV,FIR,FLO,FRM,FSK,FWR,HED,HGH,HPT,HRB,HRK,HTB,JAR,KEG,KIT,KRK,KTB,LBK,LIF,LOG,LSE,LUG,LVN,MRP,NOL,PAL,PCK,PCS,PIR,PKG,PLF,PLN,PLT,POV,PRK,QTR,RAL,RCK,REL,ROL,RVR,SAK,SHK,SID,SKD,SKE,SLP,SLV,SPI,SPL,TBE,TBN,TKR,TKT,TLD,TNK,TRC,TRK,TRY,TSS,TUB,UNP,UNT,VEH,VPK,WHE,WLC,WRP,")]
    public class X12_ID_211
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
    [EdiCodes(",AR,BX,CC,CF,CM,DK,DM,EA,FR,FT,GC,GL,KG,LB,LC,LH,LR,MR,MT,MV,NB,NC,NL,NN,NP,NR,NT" +
        ",NV,OR,PK,RV,SY,TD,TH,TR,VA,VC,VM,")]
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
    [EdiCodes(",2,A,B,C,D,E,F,G,H,I,J,K,L,N,P,Q,S,T,U,Z,")]
    public class X12_ID_23
    {
    }

    /// <summary>
    /// Cross Reference Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,F,G,H,K,L,M,T,")]
    public class X12_ID_231
    {
    }

    /// <summary>
    /// Product/Service ID Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",AB,AC,AD,AI,AM,AN,AR,AS,AT,AX,B1,B2,B3,B4,B5,B6,B7,BA,BC,BE,BL,BM,BN,BO,BP,BS,BT,BU,BX,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CL,CM,CN,CO,CP,CQ,CR,CS,CT,CU,CY,DE,DG,DI,DL,DN,DP,DR,EC,ED,EI,EN,EP,EQ,ES,FF,FI,FL,FN,FP,FS,FT,GC,GD,GN,GR,GS,GU,HC,HI,HN,IA,IB,IC,ID,IM,IN,IS,IT,IZ,JN,JP,JS,KP,LG,LT,LU,MA,MB,MD,MF,MG,MI,MM,MN,MO,MS,MT,NC,ND,NH,NR,OA,OB,OC,OD,OE,OH,OL,ON,OO,OP,P1,P2,P3,P4,PA,PC,PD,PE,PG,PI,PJ,PK,PL,PM,PN,PO,PQ,PR,PS,PT,PW,RA,RB,RC,RD,RE,RK,RN,RO,RP,RR,RS,RT,RU,RV,RW,RY,SB,SC,SD,SE,SF,SI,SK,SL,SM,SN,SQ,SR,SS,ST,SU,SV,SW,SZ,TA,TC,TI,TM,TP,TR,TS,TT,TU,TY,UA,UB,UC,UD,UE,UF,UG,UH,UI,UM,UN,UO,UP,UQ,US,UV,VA,VB,VC,VE,VI,VM,VN,VO,VP,VS,VU,VV,VX,WL,WS,XC,ZZ,")]
    public class X12_ID_235
    {
    }

    /// <summary>
    /// Price Identifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AGC,ALT,AWP,CAT,CDV,CHG,CON,CUP,CUS,DAP,DIS,DPR,DSC,DSP,EDM,EDP,EDS,EDW,EST,EUP," +
        "FET,FGP,FUL,FUP,GOV,ICL,IND,INS,INV,LPR,MAP,MAX,MIN,MNR,MSR,MXR,NET,OAP,OPP,PAQ," +
        "PBQ,PIE,PPD,PRF,PRO,PRP,QTE,RES,SDP,SFP,SHD,SLP,SPC,SUM,SWP,TOT,TRF,UCP,")]
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
    [EdiCodes(",V--,V40,VC,VD--,VD40,VDOI,VO,VOI,VS,VS10,")]
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
    [EdiCodes(",F,P,")]
    public class X12_ID_253
    {
    }

    /// <summary>
    /// Manifest Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",G,V,W,X,Y,Z,")]
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
    [EdiCodes(",9A,AC,AE,AM,BC,CE,D1,D2,D3,FC,IA,ME,NF,NM,NS,ON,PA,PM,PN,PO,PR,PS,SA,SD,SE,SM,ST" +
        ",ZZ,")]
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
    /// Event Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AAD,ALR,ALV,ARD,CRD,CSL,DDL,EAD,EDD,EFT,ERD,FTE,IBD,IRD,REC,SLD,SPT,TRN,ZZZ,")]
    public class X12_ID_304
    {
    }

    /// <summary>
    /// Transaction Handling Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,U,X,Z,")]
    public class X12_ID_305
    {
    }

    /// <summary>
    /// Action Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,D,E,H,K,L,M,N,O,P,Q,R,")]
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
    [EdiCodes(",AC,AR,BS,CA,CC,CD,CI,CL,CO,CS,CY,D,DC,DE,FA,FE,FF,FI,FV,IM,IP,K,MI,NS,OA,OL,OP,O" +
        "R,OV,PA,PE,PL,PP,PQ,PR,PS,PT,PU,RL,RS,RT,SB,SC,SL,SN,SP,SW,TC,TL,TN,TR,TX,UR,VS," +
        "W,WH,ZZ,")]
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
    [EdiCodes(",BC,CA,FN,NR,RC,RV,SH,")]
    public class X12_ID_313
    {
    }

    /// <summary>
    /// Intermodal Facility Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,C,")]
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
    [EdiCodes(",A,D,O,P,")]
    public class X12_ID_33
    {
    }

    /// <summary>
    /// Allowance or Charge Method of Handling Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,18,ZZ,")]
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
    [EdiCodes(",CAF,CIF,DAF,DDP,EXQ,EXS,EXW,FAS,FCA,FCI,FCP,FOB,FOR,FOT,ZZZ,")]
    public class X12_ID_335
    {
    }

    /// <summary>
    /// Terms Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,ZZ,")]
    public class X12_ID_336
    {
    }

    /// <summary>
    /// Allowance or Charge Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,40,41,42,43,44,45,46,47,48,490,499,5,50,501,502,503,504,505,506,507,508,50" +
        "9,51,510,511,512,513,514,515,516,517,518,519,52,520,521,522,523,524,525,53,54,55" +
        ",57,58,60,61,62,63,64,65,66,67,70,80,88,90,91,92,93,94,95,96,97,990,999,")]
    public class X12_ID_340
    {
    }

    /// <summary>
    /// Unit of Time Period Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AD,AM,AY,BD,CY,DA,DW,DY,EL,FY,HR,LN,LT,MO,QY,SA,SD,SH,WK,")]
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
    [EdiCodes(",21,22,23,24,25,26,27,28,29,30,31,32,AN,BL,BN,DO,LT,MF,")]
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
        ",31,32,33,34,35,36,37,38,ZZ,")]
    public class X12_ID_353
    {
    }

    /// <summary>
    /// Unit of Measurement Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,08,10,11,12,13,14,15,16,17,18,19,1A,1B,1C,1D,1E,1F,1G,1H,1I,1J,1K" +
        ",1L,1M,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,43,44,4" +
        "5,46,47,48,50,51,53,54,56,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75," +
        "76,77,78,79,80,81,82,83,84,85,86,87,89,90,91,92,93,94,95,96,97,98,AA,AB,AC,AD,AE" +
        ",AL,AM,AP,AS,AY,AZ,B0,B1,B2,B3,B4,B5,B6,B7,B8,B9,BA,BB,BC,BD,BE,BF,BG,BH,BI,BJ,B" +
        "K,BL,BM,BN,BO,BP,BQ,BR,BS,BT,BU,BV,BW,BX,BY,BZ,C0,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA," +
        "CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CQ,CR,CS,CT,CU,CV,CW,CX,CY,CZ,D8,D9" +
        ",DA,DB,DC,DD,DE,DF,DG,DH,DI,DJ,DK,DL,DM,DO,DP,DQ,DR,DS,DT,DY,DZ,E3,E4,E5,E7,E8,E" +
        "9,EA,EB,ED,EF,EM,EP,EQ,EV,EX,EY,EZ,F9,FA,FB,FC,FD,FE,FL,FM,FO,FP,FT,GA,GB,GC,GD," +
        "GE,GF,GG,GH,GI,GJ,GK,GL,GM,GN,GO,GP,GQ,GR,GS,GT,GY,GZ,H1,HA,HB,HC,HD,HE,HF,HG,HH" +
        ",HI,HJ,HK,HL,HM,HN,HO,HR,HS,HT,HU,HV,HW,HY,HZ,IC,IL,IM,IN,IP,IT,JB,JO,JR,JU,K1,K" +
        "2,K3,KA,KB,KC,KD,KE,KF,KG,KH,KI,KJ,KK,KL,KM,KN,KO,KP,KQ,KT,KV,KW,KX,LA,LB,LC,LE," +
        "LF,LG,LH,LI,LJ,LK,LM,LN,LO,LP,LR,LS,LT,LX,LY,M0,M1,M2,M3,M4,M5,M6,M7,M8,M9,MA,MB" +
        ",MC,MD,ME,MF,MG,MH,MI,MJ,MK,ML,MM,MN,MO,MP,MQ,MR,MS,MT,MU,MV,MW,MX,MY,MZ,NA,NB,N" +
        "C,ND,NE,NF,NG,NH,NI,NJ,NL,NM,NN,NS,NT,NV,NW,OA,ON,OP,OT,OZ,P0,P1,P2,P3,P4,P5,P6," +
        "P7,P8,P9,PA,PB,PC,PD,PE,PF,PG,PH,PI,PJ,PK,PL,PM,PN,PO,PP,PQ,PR,PS,PT,PU,PV,PW,PX" +
        ",PY,PZ,Q1,QA,QB,QD,QH,QR,QS,QT,QU,RA,RD,RE,RG,RK,RL,RM,RN,RO,RP,RS,RT,RU,S2,S3,S" +
        "4,S6,S7,SA,SB,SC,SD,SE,SF,SG,SH,SI,SJ,SK,SL,SM,SN,SO,SP,SQ,SR,SS,ST,SU,SV,SW,SX," +
        "SY,T0,T1,T2,T3,T4,T5,T6,T7,T8,T9,TA,TB,TC,TD,TE,TF,TG,TH,TI,TJ,TK,TL,TM,TN,TO,TP" +
        ",TQ,TR,TS,TT,TU,TV,TW,TX,TY,TZ,UA,UB,UC,UD,UE,UF,UN,VA,VI,VT,WA,WB,WE,WG,WH,WI,W" +
        "K,WP,WR,WT,WW,YD,YL,YR,YT,ZZ,")]
    public class X12_ID_355
    {
    }

    /// <summary>
    /// Note Reference Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",ALL,BOL,CHG,CUS,DEL,DOD,GEN,GPI,GSI,INS,INT,INV,LAB,LIN,LOI,MFG,NCD,ORI,OTH,PAY," +
        "PCS,PDS,PKG,PMT,PRI,PUR,QUT,REV,SPH,TAF,TCF,TIL,TLF,TRA,TRF,TSF,WHI,WRP,ZZZ,")]
    public class X12_ID_363
    {
    }

    /// <summary>
    /// Communication Number Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AU,CP,ED,EM,FT,FX,HP,IT,PS,TE,TL,TM,TX,WP,")]
    public class X12_ID_365
    {
    }

    /// <summary>
    /// Contact Function Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",AA,AC,AD,AF,AG,AH,AP,AR,AT,AU,BC,BD,BI,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CR,CS,CW,DA,DC,DE,DI,DV,EA,EB,EC,ED,EF,EG,EM,EN,EX,FC,HM,IC,IO,MA,ME,MG,NA,NC,NP,NT,OC,OD,PA,PB,PE,PL,PM,PR,PU,QA,QC,QI,QM,RA,RC,RD,RE,SA,SC,SD,SH,SR,SU,TA,TD,TR,UP,VP,WH,WR,ZZ,")]
    public class X12_ID_366
    {
    }

    /// <summary>
    /// Shipment/Order Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AB,AN,AS,AU,AV,BK,BP,BT,BW,CA,CC,CE,CI,CK,CM,CN,CO,CP,CS,DD,DE,DO,DS,EC,ED,EW,FS" +
        ",HQ,IC,IN,IP,IS,LM,LS,LW,NF,NN,NS,NY,OB,OF,OP,OR,PA,PD,PH,PI,PK,PN,PO,PP,PR,PS,Q" +
        "N,QP,RD,RT,RW,SB,SD,SH,SI,SL,SP,SQ,SS,SU,UB,UN,UR,WS,ZZ,")]
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
    [EdiCodes(@",001,002,003,004,005,006,007,008,009,010,011,012,013,014,015,016,017,018,019,020,021,022,023,024,025,026,027,028,029,030,031,032,033,034,035,036,037,038,039,040,041,042,043,044,050,051,052,053,054,055,056,057,058,059,060,061,062,063,064,065,066,067,068,069,070,071,072,073,074,075,076,077,078,079,080,081,082,083,084,085,086,087,088,089,090,091,092,093,094,095,096,097,098,099,100,101,102,103,104,105,106,107,108,109,110,111,112,113,114,115,116,119,120,121,122,124,125,126,127,128,129,130,131,132,133,134,135,136,137,138,139,140,150,151,152,153,154,155,156,157,158,159,160,161,162,163,164,165,166,167,168,169,170,171,172,173,174,175,176,177,178,179,180,181,182,183,184,185,186,187,188,189,190,191,192,193,194,195,196,197,198,199,200,201,202,204,206,207,208,209,210,211,212,213,214,215,216,217,218,219,222,223,224,225,226,227,228,229,230,231,232,233,234,235,")]
    public class X12_ID_374
    {
    }

    /// <summary>
    /// Tariff Service Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BB,BD,BM,BO,BP,BR,DB,DD,DM,DO,DP,DR,HH,HP,MB,MD,ML,MM,MO,MP,MR,OC,OD,OM,OR,OT,PB" +
        ",PD,PH,PM,PP,PR,RB,RD,RM,RO,RP,RR,")]
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
    [EdiCodes(",1,2,3,4,")]
    public class X12_ID_399
    {
    }

    /// <summary>
    /// Equipment Description Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",20,2B,40,4B,AC,AF,AT,BC,BG,BO,BR,BX,CA,CB,CC,CG,CH,CI,CJ,CK,CL,CM,CN,CP,CQ,CR,CS,CT,CU,CV,CW,CZ,DT,DX,ET,FH,FN,FR,FT,FX,GS,HC,HO,HP,HT,HV,HY,ID,IX,LO,LU,NX,OB,OT,OV,PT,PU,RC,RE,RF,RG,RI,RO,RR,RT,SC,SK,ST,SV,TA,TB,TC,TF,TG,TH,TI,TJ,TK,TL,TM,TN,TO,TP,TQ,TR,TT,TU,TV,TW,UL,VE,VL,VR,VS,VT,WY,")]
    public class X12_ID_40
    {
    }

    /// <summary>
    /// Unit Load Option Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,")]
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
        ",39,40,41,42,44,45,46,49,51,59,60,61,62,63,64,69,70,71,72,79,ZZ,")]
    public class X12_ID_422
    {
    }

    /// <summary>
    /// Promotion Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,")]
    public class X12_ID_423
    {
    }

    /// <summary>
    /// Adjustment Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,A1,A2,A3,A4,A5,A6,A7,A8,A9,B1,B2,B3,B4,B5,B6,B7,B8,B9,C1,C2,C3,C4,C5,C6,C7,C8,C9,D1,D2,D3,D4,D5,D6,D7,D8,D9,E1,E2,E3,E4,E5,E6,E7,E8,E9,F1,ZZ,")]
    public class X12_ID_426
    {
    }

    /// <summary>
    /// Date Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,66,67,68,69,70,71,72,73,74,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,92,93,94,95,AA,AB,")]
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
    [EdiCodes(@",AA,AG,AI,AL,AL,AL,AR,AW,BS,CA,CD,CF,CG,CG,CG,CH,CI,CO,CO,CO,CR,CS,DA,DM,DX,EC,EF,ER,FA,FB,FG,FH,FR,FT,GA,GB,GC,GC,GC,GC,GF,HP,IA,IA,IB,IC,IG,IG,IG,IG,IG,IG,IG,II,IM,IM,IN,IO,IO,IP,IR,IR,IS,LB,LS,MA,MI,MM,MO,MS,MT,MW,NC,OG,OG,OG,OG,OG,OG,OW,PA,PC,PD,PG,PM,PO,PR,PS,PT,PY,QA,QA,QA,QG,QG,QM,QO,QO,QO,QW,RA,RC,RE,RM,RO,RO,RO,RO,RQ,RR,RS,RT,RU,RW,SA,SA,SA,SA,SA,SA,SB,SC,SG,SG,SH,SI,SM,SM,SM,SM,SO,SO,SO,SO,SO,SO,SO,SO,SO,SO,SO,SO,SP,SQ,SR,SS,SW,SW,TD,TI,TP,TS,TX,WB,WR,WT,")]
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
    [EdiCodes(",14,15,16,17,24,25,26,27,34,35,36,37,90,")]
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
    [EdiCodes(",B,C,D,E,F,X,")]
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
    [EdiCodes(",BP,CO,DS,IA,IB,OF,ON,PA,PB,PL,RA,RB,RC,RP,RV,SA,SD,SH,SM,SS,SU,WL,")]
    public class X12_ID_521
    {
    }

    /// <summary>
    /// Amount Qualifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,3,4,5,6,7,8,9,91,A,A1,A2,A3," +
        "A4,AB,AC,AD,AF,AL,AM,AP,BA,BC,BT,CB,CC,CH,EA,EB,EC,FL,FM,FO,FP,IB,LC,LI,LP,MA,NA" +
        ",NB,NC,NF,NL,NP,NS,NY,OP,PA,PB,PC,PL,QN,RR,RS,S,SC,SE,TA,TB,TP,TT,")]
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
    /// Risk of Loss Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BY,FE,PP,SE,ZZ,")]
    public class X12_ID_54
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
    [EdiCodes(",AA,AB,AC,AI,AP,AS,AT,AX,BF,BI,CA,CB,CC,CI,CM,CR,DD,DE,DO,DR,EI,EP,EU,EX,FA,FD,GC" +
        ",GU,HI,IA,IS,LI,MC,MP,MS,NE,NF,NI,NR,NT,OP,OS,PA,ST,TD,TI,TM,TX,UN,VI,ZZ,")]
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
    [EdiCodes(@",A0010,A0020,A0030,AC,AF,AG,B0020,B0040,BH,BI,C0012,C0032,C0036,C0038,C1,CA,CH,CI,CN,CS,CT,CU,CZ,D0020,D0024,D0031,D1,D2,DE,DI,DL,DS,E0030,EG,EN,ER,EU,F1,FG,FS,G0010,G0052,GI,GP,GU,H1,HC,HH,HS,I0012,I0013,I0021,I0022,IC,ID,IG,IK,IL,IM,IN,IO,IQ,IR,IS,IT,KO,L1,LA,LS,M0010,M0042,MI,ML,N0020,N0032,NC,OA,P0012,P0014,P0016,P0018,P0022,PA,PB,PC,PE,PF,PL,PLI,PO,PP,R0072,R0076,R0110,S0014,S0016,S0022,S0024,S0050,S0052,S0054,S0056,S0080,S1,S2,S3,SD,SG,SH,SJ,SPI,SR,SS,ST,SU,SW,T0070,T1,TC,TE,TH,TO,UN,US,V1,V2,W0010,WH,X0010,XP,XX,YY,ZZ,")]
    public class X12_ID_560
    {
    }

    /// <summary>
    /// Sales Requirement Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,BK,F,FT,IS,N,O,P2,P3,P4,SC,SE,SF,SG,SL,SP,SQ,SS,ST,SU,SV,SW,W,Y,Z,")]
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
    [EdiCodes(",AC,DC,DI,DQ,DR,DS,FA,FB,FC,FO,LA,LE,LM,LS,LU,LW,RA,RI,RP,SA,SU,")]
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
    [EdiCodes(",ACC,ACH,ACK,ADA,ADB,ADC,ADD,ASA,ASB,ASC,ASD,BKC,BKD,BKW,BOP,CCD,CHK,CTP,CTX,CWT," +
        "DCC,DCD,DPC,DPD,DXC,DXD,DZC,DZD,FEW,FWT,LOC,NON,PAC,PBC,PBD,PDC,PDD,PPD,PRO,REV," +
        "SCC,SCD,SDC,SDD,SPC,SPD,SWT,SXC,SXD,SZC,SZD,WRD,WRT,X12,ZZZ,")]
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
    /// Reciprocal Switch Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,O,")]
    public class X12_ID_593
    {
    }

    /// <summary>
    /// Frequency Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,9,")]
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
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,3,4,5,6,7,8,9,")]
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
    [EdiCodes(",AN,AP,AW,BD,BR,BW,CA,CP,CT,DI,DR,DS,ES,HF,HP,LC,LD,LE,LM,LR,NC,NE,NQ,PA,PB,PD,PE" +
        ",PF,PM,PN,PO,PP,PR,PS,PT,PY,QE,QH,QR,QS,QT,RC,RD,RE,RM,RS,RT,SA,SC,SM,SR,SW,TB,T" +
        "C,TD,TE,TF,TM,TP,UM,VQ,WC,WD,WE,WH,WI,WM,")]
    public class X12_ID_639
    {
    }

    /// <summary>
    /// Transaction Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,AI,BA,BB,BH,BL,CA,CC,CD,CE,CF,CG,CI,CN,CO,CR,CT,DC,DI,DO,DR,DS,DU,EB" +
        ",EF,EI,ER,FB,IA,IB,IF,IN,IR,IU,JM,JO,JR,MA,MC,ME,MF,MI,ML,MM,MR,MS,PA,PB,PP,PR,R" +
        "A,RB,RC,RE,RF,RG,SA,SL,SM,SP,SS,SU,TP,UF,WS,")]
    public class X12_ID_640
    {
    }

    /// <summary>
    /// Status Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",A01,A02,A03,A04,A05,A06,A07,A08,A09,A10,A11,A12,A13,A14,A15,A16,A17,A18,A19,A20,A21,A22,A23,A24,A25,A26,A27,A28,A29,A30,A31,A32,A33,A34,A36,A37,A38,A39,A40,A41,A42,A43,A45,A46,A49,A50,A55,A58,A59,A61,A63,A64,A65,A73,A74,A91,A95,A96,A98,A99,B01,B02,B03,B04,B05,B06,B07,B08,B09,B10,B11,B12,B13,B14,B15,B16,C01,C02,C03,C04,C05,C06,C07,C08,C09,C10,C11,C12,D01,D02,P01,P02,P03,P04,P05,P06,P07,T01,T02,T03,T04,T05,T06,T07,ZZZ,")]
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
    [EdiCodes(",001,002,003,004,005,006,007,008,009,010,011,012,500,801,802,803,804,805,806,807," +
        "808,809,810,811,812,813,814,815,817,818,819,820,821,822,823,824,825,826,827,828," +
        "829,830,831,832,833,834,847,ZZZ,")]
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
    [EdiCodes(",1,10,11,12,13,14,15,16,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34,35" +
        ",36,38,39,4,40,41,42,5,6,7,8,9,91,92,93,94,95,96,AA,ST,ZZ,")]
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
    /// Subline Price Change Code ID
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
    [EdiCodes(",AI,CA,CB,CC,CD,CE,CF,CG,CH,CI,CT,DI,MU,NC,OA,OC,PC,PQ,PR,QD,QI,RA,RB,RC,RE,RM,RQ" +
        ",RS,TI,")]
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
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,45,46,47,48,49,50,51,52,53,54,55,56,57,58,60,61,62,63,64,65,66,67,68,69,70,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AO,AP,BQ,CG,CI,CL,CO,CW,DO,DP,GI,GL,GV,IQ,LI,LP,LV,MQ,PB,WV,")]
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
    /// Ship/Delivery Pattern Code
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
    [EdiCodes(",A,B,C,D,E,F,G,H,M,N,P,S,T,Z,")]
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
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,B,D,G,H,J,K,L,M,N,P,R,S,T,U,W,")]
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
    [EdiCodes(",AG,BG,BR,CN,CO,DE,DI,EX,GV,ID,IN,JB,MF,OE,PF,RS,ST,TR,WH,WS,")]
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
    /// Action Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AC,AE,AP,CC,CD,CH,CP,DC,DD,DE,DF,FC,IN,PA,PC,PD,PR,PT,RA,RC,RE,RJ,RP,")]
    public class X12_ID_696
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
    [EdiCodes(",1,2,3,E,F,G,P,U,V,")]
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
    [EdiCodes(",1,10,11,12,13,15,16,17,19,2,20,21,22,3,4,5,6,7,8,9,")]
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
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,H,I,J,K,L,M,ML,O,P,PH,Q,S,T,U,")]
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
    [EdiCodes(",9L,AA,AE,AV,BA,BD,BL,BO,BP,BT,BZ,CH,CN,CO,CS,CT,DE,DT,EA,EE,EN,FV,IN,IR,LC,LL,LM" +
        ",LT,NX,OD,P1,PA,PC,PD,PK,PL,PO,PR,PS,R1,R2,RA,RL,RN,RO,RP,RS,SD,SE,SF,SH,SK,SL,S" +
        "M,SP,SR,ST,SU,TD,TE,TI,TL,TR,TS,WA,WT,ZP,")]
    public class X12_ID_737
    {
    }

    /// <summary>
    /// Measurement Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,AA,AB,ABO,ABR,ABS,AC,ACN,AD,ADH,AE,AF,AG,AH,AI,ALK,ALN,ALP,AMW,AP,APP,ASH,ASY," +
        "AT,AVT,AZ,B,BA,BB,BC,BD,BDP,BE,BF,BG,BH,BHF,BHS,BIC,BJ,BK,BL,BO,BOR,BP,BPT,BQ,BR" +
        ",BRS,BSW,BT,BU,BUD,BW,C,CA,CAU,CC,CCF,CD,CE,CF,CG,CGR,CH,CHA,CHC,CHG,CHL,CI,CIV," +
        "CJ,CK,CL,CLA,CM,CN,CO,COL,CON,COR,COT,CP,CPF,CPS,CQ,CR,CS,CSC,CST,CU,CUT,CW,CX,C" +
        "Y,CYB,D,DA,DAT,DB,DC,DCT,DD,DE,DF,DG,DH,DI,DIR,DIS,DJ,DL,DM,DME,DMF,DN,DP,DPM,DR" +
        "Y,DS,DT,DU,DW,DWP,DY,E,EA,EB,EC,ED,EE,EF,EG,EH,EJ,ELC,ELL,ELO,ELP,ELS,ELT,ELV,EL" +
        "W,ELX,EM,EN,EP,EVL,EVR,EX,F,FA,FB,FBP,FC,FD,FE,FF,FG,FH,FI,FIL,FIN,FIT,FL,FLN,FL" +
        "P,FML,FMZ,FN,FNS,FOA,FOR,FP,FPV,FQ,FR,FRP,FS,FT,FV,FW,FX,G,GA,GB,GC,GD,GE,GF,GG," +
        "GGR,GH,GIR,GL,GLE,GN,GP,GR,GRA,GRI,GRS,GW,H2O,HA,HAZ,HB,HC,HD,HE,HF,HG,HH,HI,HIB" +
        ",HJ,HM,HO,HOC,HP,HR,HT,HVM,HYD,HZ,HZC,IA,IB,IC,ID,IDE,IF,IG,IGA,IGR,IH,II,IJ,IK," +
        "IM,IMP,IN,INS,IO,IP,IPI,IQ,IR,IS,IT,IU,IV,IW,IX,IY,IZ,JA,KA,KB,KN,L,LA,LB,LC,LD," +
        "LE,LEF,LF,LG,LIR,LIV,LL,LM,LN,LO,LOS,LOW,LP,LPG,LPR,LS,LSS,LT,LTD,LW,M,MA,MAT,MB" +
        ",MC,MD,ME,MEF,MEL,MEP,MF,MG,MH,MI,MIC,MJ,MK,MN,MO,MOI,MOW,MP,MS,MT,MTD,MU,MUL,MV" +
        ",MW,MX,MY,N,NA,NB,NC,ND,NE,NEU,NF,NG,NH,NI,NJ,NK,NL,NM,NO,NON,NP,NS,NU,O,OA,OAP," +
        "OB,OBT,OC,OCG,OCR,OD,ODR,OE,OF,OG,OH,OI,OJ,OK,OL,OM,ON,OO,OP,OQ,OR,ORC,OS,OT,OTH" +
        ",OV,OW,OX,OXI,OXS,PA,PAR,PB,PBD,PC,PD,PDE,PDG,PE,PF,PFO,PG,PH,PHA,PHW,PI,PIC,PJ," +
        "PK,PL,PM,PN,PO,POD,POP,POR,PP,PQ,PR,PRF,PRL,PRQ,PRY,PS,PSA,PSW,PT,PU,PV,PW,PWE,P" +
        "X,PY,PZ,QA,QUR,R,R10,R18,RA,RAF,RB,RC,RD,RE,REA,RED,REF,REI,REL,RES,RF,RG,RH,RI," +
        "RJ,RK,RL,RM,RN,RO,RP,RQ,RR,RS,RT,RU,RUD,RV,RVP,RW,RX,RY,S,S1,S10,S18,S2,S3,S4,S5" +
        ",S6,S7,S8,SA,SAP,SB,SC,SD,SE,SF,SG,SH,SHA,SI,SIL,SJ,SK,SL,SM,SN,SO,SOD,SOF,SOL,S" +
        "P,SPG,SPR,SQ,SR,SS,ST,STA,STL,STP,SU,SUM,SUT,SV,SW,SX,SXX,SY,SZ,T,TA,TAS,TB,TC,T" +
        "D,TDP,TE,TEE,TES,TEX,TF,TG,TH,TI,TJ,TK,TL,TM,TN,TO,TOA,TP,TPF,TPL,TPQ,TPS,TQ,TR," +
        "TRA,TRC,TRN,TS,TT,TU,TUR,TV,TVD,TX,TY,U,UA,UNI,UNK,VAD,VAP,VH,VIS,VO,VOL,VOT,VOV" +
        ",VOW,VSO,VW,WA,WB,WC,WD,WDE,WE,WEL,WF,WH,WL,WM,WPL,WR,WRA,WT,WTB,WU,WX,X,XA,XH,X" +
        "P,XQ,XZ,YA,YB,YC,ZA,ZAL,ZAS,ZB,ZBI,ZC,ZCA,ZCB,ZCE,ZCO,ZCR,ZCU,ZFE,ZFS,ZGE,ZH,ZMG" +
        ",ZMN,ZMO,ZN,ZNB,ZNI,ZO,ZP,ZPB,ZS,ZSB,ZSE,ZSI,ZSN,ZTA,ZTE,ZTI,ZV,ZW,ZZN,ZZR,ZZZ,")]
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
    [EdiCodes(",A,B,C,D,DS,E,G,I,L,M,N,O,OS,R,S,T,W,X,")]
    public class X12_ID_748
    {
    }

    /// <summary>
    /// Product/Process Characteristic Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,25,28,29,30,32,33,34,35,36,37,38,39,40,41,42,43,54,55,56,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,99,9A,9B,9C,9D,APR,BC,BLM,BPI,BW,C2,C3,C4,C5,CCN,CFC,CHF,CLT,CMS,DAC,DAF,DIR,DM,FCD,FMR,GD,GEN,GM,HB,HZ,ING,MAC,MBU,MS,NH,OD,ODR,OT,PFA,PFC,PFG,PFI,PFL,PFS,PFT,PP,PRO,QAS,RCC,RSD,RSE,RX,SLM,SOL,SYN,TF,THR,TR,TRN,TWF,WLC,WTT,")]
    public class X12_ID_750
    {
    }

    /// <summary>
    /// Surface/Layer/Position Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1S,2S,BC,BK,BS,BT,DU,FR,IN,LT,OA,OS,OT,R0,R1,R2,R3,R4,R5,R6,R7,R8,R9,RA,RB,RC,RD" +
        ",RE,RF,RG,RH,RI,RJ,RK,RL,RM,RN,RO,RP,RQ,RR,RS,RT,RU,RV,RW,RX,RY,RZ,S1,S2,S3,S4,S" +
        "5,S6,S7,S8,S9,SA,SB,SC,SD,SE,SF,SP,TB,TP,TS,UC,")]
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
    [EdiCodes(@",01,02,11,12,13,14,AA,AB,AD,AO,AP,AT,BC,BL,BM,BO,BT,CA,CC,CD,CI,CM,CN,CO,CP,CS,CT,CW,DC,DD,DM,DN,DR,DW,EA,EC,EP,ER,FD,FH,IP,IT,IV,LC,LD,LO,LR,LW,MA,MB,MC,MD,ME,MI,MM,MN,MO,MR,MS,OP,PA,PB,PC,PD,PH,PI,PR,PS,PT,PW,QC,QD,QE,QM,QR,QS,QT,RA,RC,RF,RM,RN,RO,RT,SA,SB,SD,SE,SI,SL,SM,SN,SP,SQ,SR,SS,SW,TT,US,VD,VM,WI,WT,")]
    public class X12_ID_755
    {
    }

    /// <summary>
    /// Report Transmission Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AE,AM,BM,BW,EL,FX,IE,IM,PO,SE,SM,SN,TE,TM,WS,")]
    public class X12_ID_756
    {
    }

    /// <summary>
    /// Hazardous Mnemonic Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BA,CB,CL,CM,DG,FG,FL,FO,FS,FW,IM,NG,OM,OP,OR,OX,PA,PB,RM,XA,XB,XC,")]
    public class X12_ID_758
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
    /// Waybill Request Response Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,D,E,M,N,R,S,W,")]
    public class X12_ID_762
    {
    }

    /// <summary>
    /// Market Area Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",001,002,003,004,005,")]
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
    [EdiCodes(",PS,SO,ST,TO,TT,")]
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
    [EdiCodes(",A,B,C,D,E,F,Z,")]
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
    [EdiCodes(",A,M,O,R,S,")]
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
    /// Promotion Amount Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,")]
    public class X12_ID_827
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
    [EdiCodes(",CA,CL,DL,EX,IN,OC,PR,RO,VA,")]
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
    [EdiCodes(",1,2,3,")]
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
    [EdiCodes(",QA,QD,QO,QP,QR,QS,QT,QX,")]
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
    [EdiCodes(",001,002,003,004,005,006,007,008,009,010,011,012,")]
    public class X12_ID_875
    {
    }

    /// <summary>
    /// Marks and Numbers Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",GM,L,PB,S,SI,SM,SR,SS,UC,ZZ,")]
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
    [EdiCodes(",N,R,")]
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
    [EdiCodes(",01,02,03,04,05,")]
    public class X12_ID_894
    {
    }

    /// <summary>
    /// Account Number Qualifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",DA,SG,")]
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
    [EdiCodes(",1,2,3,Y,")]
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
        ",29,30,31,ZZ,")]
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
    [EdiCodes(",A,AC,AE,AF,B,BP,BU,C,CE,D,E,FL,GG,GR,GS,H,I,J,K,L,LT,M,MB,MP,N,O,P,PA,PG,PL,PP,P" +
        "R,PT,Q,R,RR,S,SE,SR,SS,T,TC,U,VA,VE,VL,W,X,Y1,Y2,ZZ,")]
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
    [EdiCodes(",AB,AC,AO,BD,BE,BK,BL,BQ,BY,CA,CF,CP,CR,DS,FH,IN,JL,KO,LB,LS,NE,NP,NS,OS,PR,RA,RE" +
        ",RL,RN,RO,RR,RT,SA,SO,SP,SS,ST,SW,TC,TM,TR,UE,US,WO,ZZ,")]
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
    /// Printer Carriage Control Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",DS,LC,NP,NS,SS,")]
    public class X12_ID_934
    {
    }

    /// <summary>
    /// Measurement Significance Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,")]
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
    [EdiCodes(",01,02,03,04,05,06,07,08,09,")]
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
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,")]
    public class X12_ID_945
    {
    }

    /// <summary>
    /// Statistic Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27" +
        ",28,29,30,31,AD,CF,CS,HG,KS,SK,SW,ZZ,")]
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
    [EdiCodes(",1,2,3,4,5,6,7,8,")]
    public class X12_ID_962
    {
    }

    /// <summary>
    /// Tax Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CA,CI,CP,CR,CS,CT,FD,FR,FT,GR,GS,HS,HT,LO,LS,LT,MP,MT,OT,SE,SL,SP,SR,ST,SU,TD,TT" +
        ",VA,ZA,ZB,ZC,ZD,ZE,ZZ,")]
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
    [EdiCodes(@",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,1P,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,AA,AB,AC,AD,AE,AF,AG,AI,AK,AL,AO,AP,AQ,AR,BF,BG,BK,BL,BN,BO,BS,BT,BU,BW,BY,C1,C2,C3,CA,CB,CC,CD,CE,CF,CG,CH,CI,CL,CM,CN,CO,CP,CQ,CR,CS,CT,CV,DA,DB,DC,DE,DF,DL,DM,DP,DR,DS,DT,DU,DV,EB,EC,EE,EM,EN,EP,EX,FB,FH,FR,FS,FW,GP,IA,IC,II,IK,IL,IM,IN,IS,IT,IU,LB,LC,LE,LG,LL,LN,LO,LP,LS,M1,M2,M3,M4,M6,M7,M8,MA,MB,MC,MD,ME,MF,MG,MH,MI,MJ,MK,ML,MP,MQ,N1,N2,ND,NP,OB,OC,OI,OM,OO,OP,OR,OT,OU,OV,OW,PA,PB,PC,PD,PE,PF,PG,PH,PI,PJ,PK,PL,PM,PN,PO,PP,PQ,PR,PS,PT,PU,PV,PW,PY,PZ,QR,RA,RB,RC,RD,RE,RF,RG,RH,RI,RJ,RL,RM,RO,RP,RQ,RR,RS,RU,RY,S1,S2,SA,SB,SC,SD,SE,SF,SG,SH,SI,SJ,SM,SN,SO,SP,SR,SS,ST,SU,SW,T1,T2,TC,TF,TH,TI,TO,TR,TS,TT,UC,UP,VN,WF,WH,ZZ,")]
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
