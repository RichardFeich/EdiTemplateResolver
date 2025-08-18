namespace EdiFabric.Templates.X12002040
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
    /// Ownership Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",N,R,S,T,")]
    public class X12_ID_102
    {
    }
    
    /// <summary>
    /// Billing Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,H,M,P,Q,R,S,T,U,V,W,X,Y,")]
    public class X12_ID_11
    {
    }
    
    /// <summary>
    /// Port Function Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",D,E,L,O,P,R,T,U,")]
    public class X12_ID_115
    {
    }
    
    /// <summary>
    /// Rate Combination Point Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",FSAC,IATA,SPLC,")]
    public class X12_ID_120
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
    [EdiCodes(",AV,BF,BL,CF,CM,CT,EI,FR,FV,GT,KL,LB,LR,LS,LT,ME,MI,MM,MN,MX,PA,PB,PC,PD,PE,PF,PG" +
        ",PH,PK,PL,PM,PP,PQ,PR,PS,PT,PU,PV,SD,ST,SY,TB,TC,TD,TN,TR,VM,VS,WM,")]
    public class X12_ID_122
    {
    }
    
    /// <summary>
    /// Reference Number Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",52,53,54,61,62,63,64,A1,AA,AB,AC,AD,AE,AF,AG,AI,AL,AM,AN,AO,AP,AR,AS,AT,AU,AW,BC,BD,BI,BJ,BK,BL,BM,BN,BO,BR,BT,BU,C1,C2,C3,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CQ,CR,CS,CT,CU,CX,CY,DB,DC,DD,DE,DF,DI,DK,DL,DN,DO,DP,DQ,DR,DS,DV,DW,EB,ED,EI,EL,EN,EP,EQ,ER,ES,ET,EU,EZ,FA,FC,FE,FI,FN,FP,FR,FS,FT,GB,GC,GE,GG,GP,GR,GS,HB,HC,HD,HE,HN,HO,HP,HS,HW,IA,IB,IC,ID,IE,II,IL,IN,IO,IR,IS,IT,IV,JA,JB,JE,JS,KB,KE,LA,LB,LC,LF,LI,LM,LN,LO,LP,LS,LT,LW,MA,MB,MC,ME,MF,MG,MH,MI,MK,MN,MP,MR,MS,MT,MY,NA,NB,ND,NN,NP,NR,NS,OB,OC,OI,OM,OP,OS,P1,P2,P3,P4,P5,P6,P7,PA,PB,PC,PD,PE,PF,PG,PH,PI,PJ,PK,PL,PM,PN,PO,PP,PQ,PR,PS,PT,PV,PW,PX,PY,PZ,QR,RB,RC,RD,RE,RF,RG,RH,RI,RJ,RK,RL,RM,RN,RP,RQ,RR,RS,RT,RU,RV,RW,RX,RY,SA,SB,SC,SD,SE,SF,SH,SI,SJ,SK,SL,SM,SN,SO,SP,SQ,SR,SS,ST,SU,SV,SW,SX,SY,TA,TB,TC,TF,TG,TH,TI,TK,TL,TM,TN,TO,TR,TS,TX,UB,UD,UG,UN,US,UT,VA,VB,VC,VM,VN,VP,VR,VS,VT,VV,VX,WM,WN,WR,WS,WY,XC,XP,ZA,ZB,ZC,ZZ,")]
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
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,B,D,I,O,R,S,V,Z,")]
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
    [EdiCodes(@",101,104,105,107,108,109,110,111,113,114,115,116,204,205,206,207,208,210,211,213,214,216,300,301,302,303,304,305,306,307,308,309,310,312,313,314,315,316,317,319,321,350,352,353,354,404,407,408,410,411,416,417,418,419,420,421,422,423,424,425,425,426,427,440,460,461,462,463,464,465,466,467,468,469,480,485,486,490,491,492,499,810,819,820,821,822,823,827,829,830,832,840,843,844,845,846,849,850,855,856,858,860,861,862,863,864,865,866,867,868,869,870,874,875,876,877,878,879,880,881,882,883,884,885,888,889,890,891,892,893,894,895,901,905,920,924,925,926,928,940,941,942,943,944,945,946,980,990,994,995,996,997,998,999,")]
    public class X12_ID_143
    {
    }
    
    /// <summary>
    /// Shipment Method of Payment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CA,CC,CF,DF,FO,HP,IC,MX,NC,NR,NS,PA,PB,PC,PO,PP,PU,RC,RF,RS,TP,WC,ZZ,")]
    public class X12_ID_146
    {
    }
    
    /// <summary>
    /// Shipment Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,R,S,T,V,W,X,Y,Z,")]
    public class X12_ID_147
    {
    }
    
    /// <summary>
    /// Special Charge Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",005,010,015,020,025,030,035,040,045,050,055,060,065,070,075,080,085,090,095,100," +
        "105,110,115,120,130,135,140,145,150,155,160,165,170,175,180,185,186,190,205,210," +
        "215,220,225,230,235,240,245,250,255,260,265,270,275,280,285,290,295,300,310,315," +
        "320,325,330,335,340,345,350,355,360,365,370,375,380,385,390,392,393,395,400,405," +
        "410,415,416,420,425,426,430,435,440,445,450,455,460,465,470,475,480,485,490,495," +
        "500,505,510,515,520,525,535,540,545,550,555,560,565,570,580,585,586,590,595,600," +
        "605,610,615,620,625,635,640,641,645,650,665,670,675,680,685,690,695,696,697,700," +
        "705,706,720,725,730,731,732,735,736,740,745,750,755,760,761,762,999,AAA,AAJ,AAM," +
        "AAN,AAO,AAT,ADH,ADV,AFB,ALC,ANS,APT,ARB,ASC,BAA,BAB,BAC,BAD,BAF,BAP,BAS,BBK,BDX," +
        "BEY,BFD,BLA,BLC,BLD,BLK,BLW,BND,BOB,BRA,BRD,CAA,CAB,CAC,CAD,CAE,CAF,CAG,CAH,CAJ," +
        "CAK,CAL,CAO,CAP,CAQ,CAR,CAS,CAT,CAU,CAV,CAW,CBO,CBP,CBR,CBW,CBX,CCA,CCH,CDA,CDF," +
        "CER,CGL,CHG,CHN,CIR,CLN,CLS,CMF,CMI,CMP,CNS,CNV,COA,COD,COF,COL,COM,CON,COU,CRA," +
        "CRC,CRF,CSA,CSC,CSE,CSF,CSR,CTA,CTC,CTF,CTG,CTL,CUA,CUD,CUS,DAA,DAB,DAC,DAD,DBD," +
        "DCS,DCT,DDA,DDC,DDD,DDF,DEA,DEL,DEM,DEP,DER,DES,DET,DFW,DIS,DIV,DLH,DMC,DMD,DOC," +
        "DON,DRC,DRP,DRY,DSC,DSF,DST,DTL,DTU,DWC,EEA,EEB,EEC,EED,EEF,EEG,EEH,EEP,EEX,EIC," +
        "EMS,ENC,ENS,EPC,EPS,ESC,EUC,EVC,EXC,EXL,EXM,EXP,EXS,FAB,FAC,FAD,FAE,FAF,FAG,FAH," +
        "FBD,FCB,FCD,FDL,FFA,FFC,FFI,FFL,FFN,FFP,FFR,FRC,FUE,FWA,GAR,GDR,GGA,GGF,GRD,HAN," +
        "HAZ,HDF,HDG,HET,HHA,HHB,HHG,HIC,HOC,HOL,HOS,HOX,HUL,HZS,IAA,IAB,IAC,IDL,IIA,IIP," +
        "IIU,INC,INP,INR,INS,IPC,IPU,IRA,ISD,ITC,LAA,LAB,LAC,LAD,LAE,LAY,LCG,LCR,LDG,LDS," +
        "LFT,LID,LLC,LLD,LLF,LLS,LMC,LNT,LOA,LOC,LPC,LSC,LSH,LTC,LUP,LUS,MAA,MAB,MAC,MAD," +
        "MAE,MAR,MDM,MES,MFG,MIL,MIN,MMC,MMF,MMS,MMT,MNC,MRK,MSC,MSG,MTR,MVT,NAA,NAB,NAL," +
        "NFY,NHB,NSD,NWD,NYD,NYP,OAA,OAB,OAC,ONC,OOC,OOF,OPC,ORM,OSO,OSS,OUT,OVR,PAA,PAB," +
        "PAC,PAD,PAE,PAF,PAG,PAH,PAI,PAJ,PBA,PBE,PBL,PCT,PEN,PER,PIR,PMU,PMX,POD,POS,PPC," +
        "PPH,PPI,PPM,PPN,PPO,PPR,PPS,PPT,PRB,PRC,PRE,PRM,PRO,PSC,PSH,PST,PUC,PUD,PWH,PWT," +
        "QAA,QQD,RAA,RAB,RAC,RAD,RAE,RAF,RAG,RAH,RAI,RAJ,RAK,RAL,RAM,RCA,RCB,RCE,RCG,RCL," +
        "RCP,RCS,RDF,REF,REG,REP,REQ,RES,RET,RGA,RGC,RID,RLC,RMD,RPC,RRC,RRD,RRF,RRN,RRP," +
        "RRR,RTC,SAA,SAB,SAC,SAD,SAE,SAF,SAG,SAH,SAI,SAJ,SAK,SAM,SAN,SAT,SBC,SCC,SCG,SCL," +
        "SCU,SDC,SDL,SEC,SEG,SEL,SER,SFT,SGL,SHL,SLC,SOC,SPA,SPB,SPC,SPD,SPL,SPS,SPT,SPU," +
        "SRG,SSA,SSB,SSC,SSF,SSL,SSO,SSP,SSS,SST,SSX,STF,STM,STP,STR,STW,SUC,SUF,SUP,SUR," +
        "SVA,SWC,TAA,TAB,TAC,TAD,TAE,TAF,TAG,TAH,TAI,TAJ,TAK,TAL,TAX,TAY,TCM,TDT,TER,TLC," +
        "TOC,TRC,TRF,TRN,TRP,TRU,TSC,TST,TTA,TTB,TTD,TTL,TTM,TTP,TTR,TTS,TTT,TTV,TUR,TWO," +
        "UND,UNL,USF,USV,USW,UTP,UUC,UUM,UUT,VAA,VAB,VCR,VOR,VVL,VVP,WAR,WEA,WFH,WRC,WRE," +
        "WSA,WTG,WWC,ZFF,")]
    public class X12_ID_150
    {
    }
    
    /// <summary>
    /// Special Handling Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",A1M,A3M,A5M,AGG,AGS,AK,AMM,ASY,AT,AV,AW,BA,BCP,BL,BN,BNS,BW,CAR,CCB,CCH,CD,CE,CH,CI,CLS,CM,CMD,CNL,CNS,CO,CON,COR,COU,COV,CPM,CR,CSD,CW,CY,DA,DCS,DDP,DE,DIS,DLR,DN,DR,DRO,DS,DSR,DT,DU,DW,EE,END,EP,ER,EW,EX,EXC,EXP,EXU,EZE,FC,FD,FG,FL,FP,FPT,FR,FRZ,FS,FST,GI,GSS,HAN,HE,HH,HM,HO,HP,HQT,HR,HT,HV,HW,IB,IC,ID,IM,IP,IR,IS,JIT,JLX,JS,KEG,KMD,LBT,LC,LD,LF,LP,LS,LT,LTT,MC,MES,MEX,MF,MIN,MOT,MP,MR,MRF,MSS,MTE,NC,ND,NE,NH,NP,NPR,NS,NT,NW,NX,OBL,OCA,OCL,OCS,OCV,OEH,OFU,OHC,ONC,ONS,OOB,OOD,OOL,OPR,OPT,OS,OSB,OST,OTC,OTD,OTS,OVR,OWR,PB,PG,PHR,PI,PMM,PMR,PS,PSS,PUP,PW,RA,RB,RDR,RM,RO,RR,RRR,RS,RT,SB,SC,SCL,SD,SE,SEC,SER,SEV,SF,SGL,SH,SHL,SI,SK,SLC,SM,SMP,SOL,SP,SR,SSN,ST,STR,TA,TDC,TDP,TLS,TN,TOF,TRK,TRS,TS,TSC,TSP,TSS,TT,TV,UB,UI,UN,UP,US,VAN,VT,WB,WD,WE,WH,WI,WM,WO,WW,XP,XT,")]
    public class X12_ID_152
    {
    }
    
    /// <summary>
    /// Charge Method of Payment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,")]
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
    [EdiCodes(",CL,CN,CU,HT,PL,PU,TL,WL,")]
    public class X12_ID_163
    {
    }
    
    /// <summary>
    /// Time Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,")]
    public class X12_ID_176
    {
    }
    
    /// <summary>
    /// TOFC/Intermodal Code Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",00,10,12,20,22,25,30,40,50,60,70,80,83,84,")]
    public class X12_ID_177
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
    [EdiCodes(",A,A1,A2,A3,B,C,D,DR,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,")]
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
    /// Capacity Load Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,F,G,M,V,")]
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
    /// Correction Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AD,AI,AR,BE,BO,CA,CO,CS,DV,RB,RC,RE,TL,")]
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
    [EdiCodes(",BX,CC,CF,CM,DK,DM,EA,FR,FT,GC,GL,KG,LB,LC,LH,LR,MT,MV,NB,NC,NL,NN,NP,NR,NT,NV,PK" +
        ",RV,SY,TD,TH,VA,VC,VM,")]
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
    [EdiCodes(",A,B,C,E,F,G,H,I,J,L,N,S,T,U,Z,")]
    public class X12_ID_23
    {
    }
    
    /// <summary>
    /// Cross Reference Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",F,L,M,T,")]
    public class X12_ID_231
    {
    }
    
    /// <summary>
    /// Product/Service ID Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",AB,AC,AI,AN,AR,AT,B1,B2,B3,B4,B5,B6,B7,BA,BC,BE,BL,BM,BN,BO,BP,CA,CB,CC,CD,CE,CG,CI,CL,CM,CN,CP,CQ,CR,CS,CT,CU,DC,DE,DG,DI,DL,DN,DP,DR,EC,ED,EN,EQ,FI,FL,FP,FS,GC,GD,GN,GR,GS,HI,HN,IA,IB,IM,IN,IS,IT,IZ,JS,KP,LT,LU,MA,MF,MG,MN,MS,MT,NC,ND,NH,NR,OA,OB,OC,OD,OE,OH,ON,OP,P1,P2,P3,P4,PA,PC,PD,PE,PG,PI,PJ,PK,PL,PM,PN,PO,PR,PS,PT,PW,RC,RD,RK,RN,RO,RP,RR,RS,RT,RU,RV,RY,SC,SE,SF,SK,SL,SM,SN,SQ,SR,SS,ST,SU,SV,SZ,TC,TM,TP,TY,UA,UB,UC,UD,UE,UI,UM,UN,UP,US,UV,VA,VB,VC,VE,VI,VN,VO,VP,VS,VU,VV,VX,ZZ,")]
    public class X12_ID_235
    {
    }
    
    /// <summary>
    /// Price Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",ALT,AWP,CAT,CDV,CHG,CON,CUP,CUS,DAP,DIS,DPR,DSC,EUP,FET,FGP,GOV,ICL,IND,INS,INV," +
        "MAX,MIN,MNR,MSR,MXR,NET,PAQ,PBQ,PIE,PPD,PRF,PRO,PRP,QTE,RES,SHD,SPC,SUM,TOT,TRF," +
        "UCP,")]
    public class X12_ID_236
    {
    }
    
    /// <summary>
    /// Vent Instruction Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",V--,VC,VD--,VDOI,VO,VOI,VS,VS10,")]
    public class X12_ID_242
    {
    }
    
    /// <summary>
    /// Allowance or Charge Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,C,N,")]
    public class X12_ID_248
    {
    }
    
    /// <summary>
    /// Tariff Application Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,I,N,S,")]
    public class X12_ID_257
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
    /// Distance Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,D,F,K,L,M,T,X,")]
    public class X12_ID_295
    {
    }
    
    /// <summary>
    /// Transaction Handling Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",C,D,I,P,X,Z,")]
    public class X12_ID_305
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
    [EdiCodes(",AC,CC,CI,CL,CO,CS,CY,D,DC,DE,FA,FE,FI,FV,IM,IP,MI,NS,OA,OL,OP,OR,PL,PP,RS,RT,SC," +
        "SL,SN,SP,TC,TL,TN,TX,W,WH,ZZ,")]
    public class X12_ID_309
    {
    }
    
    /// <summary>
    /// Authority Identifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BC,CA,NR,RC,RV,SH,")]
    public class X12_ID_313
    {
    }
    
    /// <summary>
    /// Allowance or Charge Method of Handling Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,ZZ,")]
    public class X12_ID_331
    {
    }
    
    /// <summary>
    /// Terms Basis Date Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,ZZ,")]
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
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,16,ZZ,")]
    public class X12_ID_336
    {
    }
    
    /// <summary>
    /// Unit of Time Period Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",DA,DW,HR,MO,WK,")]
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
    /// Item Description Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AI,AP,AS,BI,CA,CC,CI,CR,DE,DR,EI,FA,FD,IS,NE,NR,OP,PA,ST,TI,TM,TX,VI,ZZ,")]
    public class X12_ID_348
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
    [EdiCodes(",00,01,02,03,04,05,06,07,08,10,11,12,13,14,15,16,17,18,19,20,21,25,ZZ,")]
    public class X12_ID_353
    {
    }
    
    /// <summary>
    /// Unit of Measurement Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",01,02,03,04,05,08,10,11,12,13,14,15,24,26,27,31,50,51,53,54,56,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,AA,AC,AM,AP,AS,AY,B1,B2,B3,B4,B5,B6,B7,B8,B9,BA,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BO,BP,BQ,BR,BS,BT,BU,BV,BW,BX,BY,BZ,C1,C2,C3,C4,C5,C6,C7,C8,C9,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CQ,CR,CS,CT,CU,CV,CW,CX,CY,CZ,DA,DB,DC,DD,DE,DF,DG,DH,DI,DJ,DK,DL,DM,DP,DR,DS,DT,DZ,E3,E4,E5,E7,E8,E9,EA,ED,EF,EM,EP,EV,EX,EY,EZ,FA,FC,FM,FO,FP,FT,GA,GB,GD,GG,GH,GI,GL,GM,GN,GR,GS,GY,GZ,HA,HB,HC,HD,HE,HF,HG,HH,HI,HJ,HK,HL,HO,HP,HR,HS,HT,HU,HV,HW,HY,IC,IN,IT,JB,JO,JR,JU,KA,KD,KE,KG,KH,KI,KK,KL,KM,KN,KT,KV,KW,LA,LB,LC,LE,LF,LG,LH,LI,LJ,LK,LM,LN,LO,LP,LR,LS,LT,LY,M1,M2,M3,M4,M6,MA,MB,MC,ME,MF,MG,MH,MI,MJ,MK,ML,MM,MN,MO,MP,MQ,MR,MS,MT,MU,MV,MW,MX,MY,MZ,NB,NC,ND,NG,NL,NM,NN,NT,NV,ON,OP,OT,OZ,P1,P2,P3,P4,P5,P6,P7,P8,P9,PA,PB,PC,PD,PE,PF,PG,PH,PI,PJ,PK,PL,PM,PN,PO,PP,PQ,PR,PS,PT,PU,PV,PW,PX,PY,PZ,Q1,QD,QR,QS,QT,QU,RA,RD,RE,RG,RK,RL,RM,RN,RO,RP,RU,S2,SA,SB,SC,SD,SE,SF,SG,SH,SI,SJ,SK,SL,SM,SN,SO,SP,SQ,SR,SS,ST,SU,SV,SW,SX,SY,T1,T2,T3,TA,TB,TC,TD,TE,TF,TG,TH,TI,TJ,TK,TL,TM,TN,TO,TP,TQ,TR,TS,TT,TU,TV,TW,TW,TX,TY,TZ,UN,VI,VT,WB,WE,WG,WH,WI,WK,WP,WR,WT,YD,YL,YR,YT,ZZ,")]
    public class X12_ID_355
    {
    }
    
    /// <summary>
    /// Note Reference Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",ALL,BOL,CHG,CUS,DEL,GEN,INS,INT,INV,LAB,LIN,LOI,MFG,ORI,OTH,PAY,PKG,PMT,PRI,PUR," +
        "QUT,REV,SPH,TAF,TCF,TIL,TLF,TRA,TRF,TSF,WHI,WRP,ZZZ,")]
    public class X12_ID_363
    {
    }
    
    /// <summary>
    /// Communication Number Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AU,EM,FT,FX,IT,PS,TE,TL,TM,TX,")]
    public class X12_ID_365
    {
    }
    
    /// <summary>
    /// Contact Function Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AC,AD,AP,AR,BD,CA,CB,CC,CD,CE,CR,CW,DC,DE,DI,EB,EC,ED,EF,EN,EX,HM,IC,IO,NP,NT,OC" +
        ",OD,PE,PM,PR,QA,QC,QI,RC,RD,SA,SC,SD,SR,SU,TA,TR,WH,ZZ,")]
    public class X12_ID_366
    {
    }
    
    /// <summary>
    /// Shipment/Order Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AB,AN,AS,AU,AV,BK,BP,BT,BW,CA,CC,CE,CI,CK,CM,CN,CO,CP,CS,DD,DE,DO,DS,EC,ED,EW,FS" +
        ",HQ,IC,IN,IP,IS,LM,LS,LW,NF,NN,NS,OB,OF,OP,OR,PA,PD,PH,PI,PK,PN,PO,PP,PR,PS,RD,R" +
        "W,SB,SD,SL,SP,SQ,SS,SU,UB,UN,UR,WS,ZZ,")]
    public class X12_ID_368
    {
    }
    
    /// <summary>
    /// Change Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AQ,BB,BD,DC,EV,FE,GU,GW,LD,MC,PC,PQ,PS,QO,QP,QT,SC,UM,UP,WD,WO,ZZ,")]
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
    [EdiCodes(@",001,002,003,004,005,006,007,008,009,010,011,012,013,014,015,016,017,018,019,020,021,022,023,024,025,026,027,028,029,030,031,032,033,034,035,036,037,038,039,040,041,042,043,050,051,052,053,054,055,056,057,058,059,060,061,062,063,064,065,066,067,068,069,070,071,072,073,074,075,076,077,078,079,080,081,082,083,084,085,086,087,088,089,090,091,092,093,094,095,096,097,098,099,100,101,102,103,104,105,106,107,108,109,110,111,112,113,114,115,116,119,120,121,122,124,125,126,127,128,129,130,131,132,133,134,135,136,137,138,150,151,152,153,154,155,156,157,158,159,160,")]
    public class X12_ID_374
    {
    }
    
    /// <summary>
    /// Allowance/ Charge Percent Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,Z,")]
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
    [EdiCodes(@",20,2B,40,4B,AC,AF,AT,BC,BG,BO,BR,BX,CA,CB,CC,CG,CH,CI,CJ,CK,CL,CM,CN,CP,CQ,CR,CS,CT,CU,CV,CW,CZ,DT,DX,ET,FH,FN,FR,FT,FX,HC,HO,HP,HT,HV,ID,IX,LU,NX,OB,OT,OV,PT,PU,RC,RE,RF,RG,RI,RO,RR,RT,SC,SK,ST,SV,TA,TB,TC,TF,TG,TH,TI,TJ,TK,TL,TM,TN,TO,TR,TT,TU,TV,UL,VE,VL,VR,VS,VT,")]
    public class X12_ID_40
    {
    }
    
    /// <summary>
    /// Receiving Condition Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,11,12,")]
    public class X12_ID_412
    {
    }
    
    /// <summary>
    /// Adjustment Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27" +
        ",28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,5" +
        "4,55,56,57,58,59,60,61,ZZ,")]
    public class X12_ID_426
    {
    }
    
    /// <summary>
    /// Date Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27" +
        ",28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,5" +
        "4,55,56,57,58,59,60,61,62,63,64,66,67,68,69,70,71,72,73,74,76,77,78,79,80,81,82," +
        "83,84,")]
    public class X12_ID_432
    {
    }
    
    /// <summary>
    /// Tax Exempt Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",0,1,2,3,4,5,6,7,8,9,A,B,")]
    public class X12_ID_441
    {
    }
    
    /// <summary>
    /// Shipment Weight Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,D,G,M,N,O,P,Q,R,S,T,U,")]
    public class X12_ID_460
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
    [EdiCodes(@",AA,AG,AI,AL,AL,AL,AR,AW,CA,CF,CG,CG,CG,CG,CH,CO,CO,CO,DM,EC,FA,FR,GA,GB,GC,GC,GC,GC,IA,IA,IB,IC,IG,IG,IG,IG,IG,IG,IG,IM,IM,IN,IO,IO,IR,IR,IS,LB,MA,MM,MO,MW,OG,OG,OG,OG,OG,OG,OW,PA,PC,PG,PO,PR,PS,PT,PY,QA,QA,QA,QG,QG,QM,QM,QO,QO,QO,QW,RA,RC,RE,RO,RO,RO,RO,RQ,RR,RS,RT,RW,RW,SA,SA,SA,SA,SA,SA,SB,SC,SG,SG,SH,SI,SM,SM,SM,SM,SM,SO,SO,SO,SO,SO,SO,SO,SO,SO,SO,SO,SO,SR,SR,SR,SR,SS,SW,SW,TP,TX,WR,")]
    public class X12_ID_479
    {
    }
    
    /// <summary>
    /// Export License Control Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
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
    /// Product Transfer Movement Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AI,AO,CD,DC,DM,MD,TI,TO,")]
    public class X12_ID_486
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
    [EdiCodes(",BP,DS,IA,IB,PA,PB,RA,RB,RC,RP,RV,SA,SD,SH,SM,SS,SU,")]
    public class X12_ID_521
    {
    }
    
    /// <summary>
    /// Amount Qualifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,2,3,4,5,6,7,8,9,AC,AD,AL,BT,CB,CH,FL,FP,IB,NA,NC,NF,NL,NP,NY,OP,PA,PC,PL,SC" +
        ",TP,TT,")]
    public class X12_ID_522
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
    /// Association Qualifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AI,AX,BI,CM,EU,GU,NE,NR,OP,PI,ST,TD,TI,VI,")]
    public class X12_ID_559
    {
    }
    
    /// <summary>
    /// Type of Service Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CS,CY,HH,HL,HP,NC,PH,PP,")]
    public class X12_ID_56
    {
    }
    
    /// <summary>
    /// Special Services Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",A0010,A0020,A0030,AC,AF,B0020,B0040,BH,BI,C0012,C0032,C0036,C0038,C1,CA,CH,CI,CN,CS,CT,CU,CZ,D0020,D0024,D0031,D1,D2,DL,DS,E0030,EG,EN,EU,F1,FG,FS,G0010,G0052,GI,GP,GU,H1,HC,HH,HS,I0012,I0013,I0021,I0022,IC,ID,IG,IM,IN,IO,IR,IS,IT,KO,L1,LA,M0010,M0042,MI,ML,N0020,N0032,NC,OA,P0012,P0014,P0016,P0018,P0022,PA,PB,PC,PE,PF,PL,R0072,R0076,R0110,S0014,S0016,S0022,S0024,S0050,S0052,S0054,S0056,S0080,S1,S2,S3,SD,SG,SH,SJ,SR,SU,SW,T0070,T1,TC,TE,TO,UN,US,V1,V2,W0010,WH,X0010,XP,YY,ZZ,")]
    public class X12_ID_560
    {
    }
    
    /// <summary>
    /// Scheduling/Shipping Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BK,CD,CS,DA,DB,DD,EX,FT,IS,P1,P2,P3,P4,SA,SB,SC,SD,SE,SF,SG,SL,SP,SQ,SS,ST,SU,ZZ" +
        ",")]
    public class X12_ID_562
    {
    }
    
    /// <summary>
    /// Back-Order Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,F,N,W,Y,Z,")]
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
    /// Account Number Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",ZB1,ZB2,")]
    public class X12_ID_569
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
    /// Acknowledgment Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AC,AD,AE,AH,AK,DQ,NA,RD,RF,RJ,UQ,ZZ,")]
    public class X12_ID_587
    {
    }
    
    /// <summary>
    /// Payment Method Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",ACC,ACK,ADA,ADB,ADC,ADD,ASA,ASB,ASC,ASD,BKC,BKD,CCD,CTP,CTX,DCC,DCD,DPC,DPD,DXC," +
        "DXD,DZC,DZD,LOC,PAC,PBC,PBD,PPD,REV,SCC,SCD,SPC,SPD,SXC,SXD,SZC,SZD,WRD,WRT,ZZZ," +
        "")]
    public class X12_ID_591
    {
    }
    
    /// <summary>
    /// Time Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CD,CS,CT,ED,ES,ET,GM,LT,MD,MS,MT,PD,PS,PT,")]
    public class X12_ID_623
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
    /// Basis of Unit Price Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AP,BR,CA,CP,CT,DI,DR,DS,ES,HF,HP,LC,LD,LE,LM,LR,NC,NE,NQ,PA,PB,PD,PE,PM,PO,PP,PR" +
        ",PT,PY,QE,QH,QR,QS,QT,RC,RD,RE,RM,RS,RT,SR,TB,TC,TD,TE,TF,TM,TP,UM,WC,WD,WE,WH,W" +
        "M,")]
    public class X12_ID_639
    {
    }
    
    /// <summary>
    /// Transaction Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BA,BB,BH,CA,CC,CI,CN,CO,CR,DC,DI,DR,DU,EB,EF,EI,ER,FB,IB,IF,IR,IU,MC,ME,MF,MI,MM" +
        ",MR,MS,PB,PP,PR,RA,RB,RC,RE,RF,SM,SS,UF,")]
    public class X12_ID_640
    {
    }
    
    /// <summary>
    /// Status Reason Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",A01,A02,A03,A04,A05,A06,A07,A08,A09,A10,A11,A12,A13,A14,A15,A16,A17,A18,A19,A20,A21,A22,A23,A24,A25,A26,A27,A28,A29,A30,A31,A32,A33,A34,A36,A37,A38,A39,A40,A41,A42,A43,A49,A50,A55,A58,A59,A61,A63,A64,A65,A73,A74,A91,A95,A96,A98,C01,C02,C03,C04,C05,C06,C07,C08,C09,C10,P01,P02,P03,P04,P05,P06,P07,ZZZ,")]
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
    [EdiCodes(",1,10,11,12,13,14,15,16,18,19,2,20,21,22,23,24,25,26,27,28,3,30,31,32,34,4,5,6,7," +
        "8,9,91,92,ZZ,")]
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
    [EdiCodes(",A,D,I,")]
    public class X12_ID_662
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
    /// Line Item Change or Response Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AI,CB,CT,DI,MU,NC,PC,PQ,PR,QD,QI,RC,RE,RM,RQ,RS,TI,")]
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
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27" +
        ",28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,45,46,47,48,49,50,51,52,53,54,55,5" +
        "6,57,58,60,61,62,63,64,65,66,67,68,69,70,71,72,73,")]
    public class X12_ID_673
    {
    }
    
    /// <summary>
    /// Schedule Type Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BB,DL,JS,KB,SH,ZZ,")]
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
    [EdiCodes(",1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,")]
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
    [EdiCodes(",A,B,C,D,E,F,G,M,N,P,S,T,Z,")]
    public class X12_ID_680
    {
    }
    
    /// <summary>
    /// Forecast Timing Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,D,F,M,Q,S,T,W,Z,")]
    public class X12_ID_681
    {
    }
    
    /// <summary>
    /// Part Release Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,A,B,D,G,H,J,K,L,M,N,P,R,S,T,U,W,")]
    public class X12_ID_682
    {
    }
    
    /// <summary>
    /// Catalog Purpose Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",PC,PS,RC,SC,")]
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
    /// Restriction Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",NR,NS,OR,SR,")]
    public class X12_ID_688
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
    /// Functional Group Acknowledge Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,E,P,R,")]
    public class X12_ID_715
    {
    }
    
    /// <summary>
    /// Functional Group Syntax Error Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,")]
    public class X12_ID_716
    {
    }
    
    /// <summary>
    /// Transaction Set Acknowledgment Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,E,R,")]
    public class X12_ID_717
    {
    }
    
    /// <summary>
    /// Transaction Set Syntax Error Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,")]
    public class X12_ID_718
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
    [EdiCodes(",1,2,3,4,5,6,7,8,9,")]
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
    [EdiCodes(",AA,AD,CD,CW,HO,SD,WD,WW,ZZ,")]
    public class X12_ID_732
    {
    }
    
    /// <summary>
    /// Hierarchical Level Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",B,C,D,E,I,K,L,M,O,P,Q,S,T,")]
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
    [EdiCodes(",9L,AA,AE,BA,BL,BP,BZ,CH,CN,CO,CS,CT,DE,DT,EA,EE,EN,IN,LC,LL,LM,P1,PC,PD,PL,PO,PR" +
        ",RL,RN,RP,SE,SH,SL,SM,SP,SR,ST,SU,TD,TE,TI,TL,TR,WT,")]
    public class X12_ID_737
    {
    }
    
    /// <summary>
    /// Measurement Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",A,AA,AB,AC,AD,AE,AF,AG,AH,AZ,B,BA,BB,BC,BD,BE,BF,BG,BH,BK,BO,BR,BW,C,CA,CB,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CN,CO,CP,CR,CS,CU,CW,D,DA,DB,DC,DD,DE,DF,DG,DH,DI,DL,DN,DP,DS,DT,DU,DW,DY,E,EA,EB,EC,ED,EE,EF,EG,EH,EL,EN,EX,F,FA,FB,FC,FD,FE,FF,FH,FI,FL,FN,FP,FR,FT,FV,FW,G,GA,GB,GC,GD,GE,GF,GG,GH,GL,GP,GW,HA,HB,HC,HD,HE,HF,HG,HH,HI,HJ,HM,HP,HR,HT,HZ,IA,IB,IC,ID,IE,IF,IG,IH,II,IJ,IK,IL,IM,IN,IO,IP,IQ,IR,IS,IT,IU,IV,IW,IX,IZ,JA,KA,KB,L,LA,LB,LC,LD,LE,LF,LG,LL,LM,LN,LO,LP,LS,LT,LW,M,MA,MB,MC,MD,ME,MF,MG,MI,MJ,MK,MN,MS,MT,MU,MV,MX,N,NA,NB,NC,ND,NE,NF,NG,NH,NI,NJ,NL,NM,NP,NS,NU,O,OA,OB,OC,OD,OE,OF,OG,OH,OI,OJ,OK,OL,OM,ON,OO,OP,OQ,OR,OS,OT,OV,OW,PA,PB,PC,PD,PE,PF,PG,PH,PI,PJ,PK,PL,PM,PN,PO,PP,PQ,PR,PS,PSA,PW,PY,PZ,QA,R,RA,RB,RC,RD,RE,RF,RG,RH,RI,RJ,RK,RL,RM,RN,RO,RP,RQ,RR,RS,RU,RV,RW,S,S1,S2,SA,SB,SC,SD,SE,SF,SG,SH,SI,SJ,SK,SL,SM,SN,SO,SP,SQ,SR,SS,ST,SU,SV,SW,SX,SY,SZ,T,TA,TB,TC,TD,TE,TF,TG,TH,TI,TJ,TK,TL,TM,TN,TO,TP,TQ,TR,TS,TT,TU,TV,TX,TY,U,UA,VH,VW,WA,WB,WC,WD,WE,WF,WL,WM,WT,WU,X,XA,XH,XP,XQ,XZ,YA,YB,YC,ZA,ZAL,ZAS,ZB,ZBI,ZC,ZCA,ZCB,ZCE,ZCO,ZCR,ZCU,ZFE,ZFS,ZGE,ZH,ZMG,ZMN,ZMO,ZN,ZNB,ZNI,ZO,ZP,ZPB,ZS,ZSB,ZSE,ZSI,ZSN,ZTA,ZTE,ZTI,ZV,ZW,ZZN,ZZR,ZZZ,")]
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
    /// Product/Process Characteristic Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,25,28,29,30,32,33,34,35,36" +
        ",37,38,39,40,41,42,43,54,55,56,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,7" +
        "4,75,76,77,78,79,99,9A,9B,BC,BW,C2,C3,C4,C5,GD,GM,HB,HZ,MS,NH,OD,OT,PP,RX,TR,")]
    public class X12_ID_750
    {
    }
    
    /// <summary>
    /// Surface/Layer/Position Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1S,2S,BS,BT,IN,OA,OS,OT,R0,R1,R2,R3,R4,R5,R6,R7,R8,R9,RA,RB,RC,RD,RE,RF,RG,RH,RI" +
        ",RJ,RK,RL,RM,RN,RO,RP,RQ,RR,RS,RT,RU,RV,RW,RX,RY,RZ,TP,TS,")]
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
    [EdiCodes(",01,02,11,12,13,14,AA,AD,AO,AP,BL,BT,CA,CC,CD,CI,CM,CP,CS,DC,DD,DM,DN,DR,EA,FD,FH" +
        ",IP,IT,IV,LC,MA,MB,MC,MD,MM,MR,MS,PC,PD,PI,PT,RF,RT,SA,SE,SI,SL,SM,SN,SQ,SR,SS,U" +
        "S,VD,VM,")]
    public class X12_ID_755
    {
    }
    
    /// <summary>
    /// Report Transmission Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AE,AM,BM,BW,EL,IE,IM,SE,SM,SN,TE,TM,WS,")]
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
    /// Contract Status Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CL,DL,EX,IN,OC,PR,RO,VA,")]
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
    /// Marks and Numbers Qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",GM,L,PB,S,SM,SR,SS,UC,ZZ,")]
    public class X12_ID_88
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
    /// Incentive Grain Rate Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",Y,")]
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
    /// Transportation Method Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,AC,AE,B,BP,BU,C,CE,D,E,G,H,I,J,K,L,LT,M,N,O,P,PC,PL,PT,Q,R,S,SE,SR,SS,T,TC,U,V" +
        "E,W,X,ZZ,")]
    public class X12_ID_91
    {
    }
    
    /// <summary>
    /// Purchase Order Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AB,BD,BE,BK,BL,BQ,BY,CA,CF,CP,CR,DS,FH,IN,JL,KO,NE,NP,NS,OS,PR,RA,RE,RL,RN,RO,RR" +
        ",RT,SA,SO,SP,SS,ST,SW,TC,TM,TR,UE,WO,ZZ,")]
    public class X12_ID_92
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
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,")]
    public class X12_ID_935
    {
    }
    
    /// <summary>
    /// Measurement Attribute Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27" +
        ",")]
    public class X12_ID_936
    {
    }
    
    /// <summary>
    /// Test Administration Method Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,")]
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
    [EdiCodes(",01,02,03,04,")]
    public class X12_ID_940
    {
    }
    
    /// <summary>
    /// Sample Frequency Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,06,07,08,09,10,11,12,13,14,15,16,17,18,")]
    public class X12_ID_941
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
        ",28,29,30,31,")]
    public class X12_ID_950
    {
    }
    
    /// <summary>
    /// Balance Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,M,Y,")]
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
    /// Request for Quote Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",01,02,03,04,05,")]
    public class X12_ID_960
    {
    }
    
    /// <summary>
    /// Receiving Advice Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class X12_ID_962
    {
    }
    
    /// <summary>
    /// Tax Type Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",CP,CS,CT,FT,LS,LT,MT,ST,VA,ZZ,")]
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
    /// Entity Identifier Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",11,AC,AD,AG,AK,AL,AO,BF,BG,BK,BL,BN,BO,BS,BT,BW,BY,C1,C2,CA,CB,CC,CD,CE,CF,CI,CL,CM,CN,CO,CP,CR,CS,CV,DB,DC,DE,DL,DP,DS,EC,EE,EM,EN,EP,EX,FH,FR,FW,IA,IC,II,IK,IM,IN,IS,IT,LN,LP,MA,MC,MF,MI,MP,MQ,N1,N2,OB,OC,OI,OO,OP,OT,OV,OW,PA,PB,PC,PD,PE,PF,PG,PH,PI,PJ,PK,PM,PN,PP,PR,PT,PU,PV,RB,RC,RE,RF,RL,RM,RP,RQ,RR,RS,SA,SB,SC,SD,SE,SF,SG,SH,SI,SM,SN,SO,SP,SR,SS,ST,SU,SW,TC,TF,TO,TR,TS,TT,UC,UP,VN,WF,WH,ZZ,")]
    public class X12_ID_98
    {
    }
}
