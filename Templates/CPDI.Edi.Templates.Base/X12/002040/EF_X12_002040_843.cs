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
    /// Loop for Cost Analysis
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CST))]
    public class Loop_CST_843
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Cost Analysis
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CST CST { get; set; }
        /// <summary>
        /// Product/Item Description
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual PID PID { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual CUR CUR { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(4)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Loop for Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_843
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        /// Additional Name Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<N2> N2 { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Reference Numbers
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(5)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(6)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// F.O.B. Related Instructions
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual FOB FOB { get; set; }
        /// <summary>
        /// Carrier Details (Quantity and Weight)
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(8)]
        public virtual List<TD1> TD1 { get; set; }
        /// <summary>
        /// Carrier Details (Routing Sequence/Transit Time)
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(9)]
        public virtual List<TD5> TD5 { get; set; }
        /// <summary>
        /// Carrier Details (Equipment)
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(10)]
        public virtual List<TD3> TD3 { get; set; }
        /// <summary>
        /// Carrier Details (Special Handling/Hazardous Materials)
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(11)]
        public virtual List<TD4> TD4 { get; set; }
        /// <summary>
        /// Marking, Packaging, Loading
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(12)]
        public virtual List<PKG> PKG { get; set; }
    }
    
    /// <summary>
    /// Loop for Reference Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N9))]
    public class Loop_N9_843
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N9 N9 { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(2)]
        public virtual List<MSG> MSG { get; set; }
    }
    
    /// <summary>
    /// Loop for Purchase Order Baseline Item Data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PO1))]
    public class Loop_PO1_843
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Purchase Order Baseline Item Data
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PO1 PO1 { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual CUR CUR { get; set; }
        /// <summary>
        /// Additional Item Detail
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(3)]
        public virtual List<PO3> PO3 { get; set; }
        /// <summary>
        /// Pricing Information
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(4)]
        public virtual List<CTP> CTP { get; set; }
        /// <summary>
        /// Product/Item Description
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(5)]
        public virtual List<PID> PID { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [ListCount(40)]
        [Pos(6)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// Paperwork
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(7)]
        public virtual List<PWK> PWK { get; set; }
        /// <summary>
        /// Marking, Packaging, Loading
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(8)]
        public virtual List<PKG> PKG { get; set; }
        /// <summary>
        /// Item Physical Details
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual PO4 PO4 { get; set; }
        /// <summary>
        /// Reference Numbers
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(10)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(11)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Special Services
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(12)]
        public virtual List<SSS> SSS { get; set; }
        /// <summary>
        /// Allowance, Charge or Service
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(13)]
        public virtual List<ITA> ITA { get; set; }
        /// <summary>
        /// Conditions of Sale
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual IT8 IT8 { get; set; }
        /// <summary>
        /// Terms of Sale/Deferred Terms of Sale
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(15)]
        public virtual List<ITD> ITD { get; set; }
        /// <summary>
        /// Discount Detail
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(16)]
        public virtual List<DIS> DIS { get; set; }
        /// <summary>
        /// Sales Tax Reference
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(17)]
        public virtual List<TAX> TAX { get; set; }
        /// <summary>
        /// F.O.B. Related Instructions
        /// </summary>
        [DataMember]
        [Pos(18)]
        public virtual FOB FOB { get; set; }
        /// <summary>
        /// Destination Quantity
        /// </summary>
        [DataMember]
        [ListCount(50)]
        [Pos(19)]
        public virtual List<SDQ> SDQ { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(20)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Lead Time
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(21)]
        public virtual List<LDT> LDT { get; set; }
        /// <summary>
        /// Line Item Schedule
        /// </summary>
        [DataMember]
        [ListCount(104)]
        [Pos(22)]
        public virtual List<SCH> SCH { get; set; }
        /// <summary>
        /// Forecast Schedule
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(23)]
        public virtual List<FST> FST { get; set; }
        /// <summary>
        /// Carrier Details (Quantity and Weight)
        /// </summary>
        [DataMember]
        [Pos(24)]
        public virtual TD1 TD1 { get; set; }
        /// <summary>
        /// Carrier Details (Routing Sequence/Transit Time)
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(25)]
        public virtual List<TD5> TD5 { get; set; }
        /// <summary>
        /// Carrier Details (Equipment)
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(26)]
        public virtual List<TD3> TD3 { get; set; }
        /// <summary>
        /// Carrier Details (Special Handling/Hazardous Materials)
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(27)]
        public virtual List<TD4> TD4 { get; set; }
        /// <summary>
        /// Marks and Numbers
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(28)]
        public virtual List<MAN> MAN { get; set; }
        /// <summary>
        /// Restrictions
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(29)]
        public virtual List<CTB> CTB { get; set; }
        /// <summary>
        /// Loop for Cost Analysis
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(30)]
        public virtual List<Loop_CST_843> CSTLoop { get; set; }
        /// <summary>
        /// Loop for Subline Item Detail
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(31)]
        public virtual List<Loop_SLN_843> SLNLoop { get; set; }
        /// <summary>
        /// Loop for Reference Number
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(32)]
        public virtual List<Loop_N9_843> N9Loop { get; set; }
        /// <summary>
        /// Loop for Name
        /// </summary>
        [DataMember]
        [ListCount(200)]
        [Pos(33)]
        public virtual List<Loop_N1_843> N1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Subline Item Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SLN))]
    public class Loop_SLN_843
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Subline Item Detail
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SLN SLN { get; set; }
        /// <summary>
        /// Product/Item Description
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(2)]
        public virtual List<PID> PID { get; set; }
        /// <summary>
        /// Loop for Cost Analysis
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(3)]
        public virtual List<Loop_CST_843> CSTLoop { get; set; }
    }
    
    /// <summary>
    /// Response to Request for Quotation
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "843")]
    public class TS843 : EdiMessage
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transaction Set Header
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual ST ST { get; set; }
        /// <summary>
        /// Beginning Segment for Response to Request For Quotation
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BQR BQR { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(3)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual CUR CUR { get; set; }
        /// <summary>
        /// Reference Numbers
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(5)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(6)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Sales Tax Reference
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(7)]
        public virtual List<TAX> TAX { get; set; }
        /// <summary>
        /// F.O.B. Related Instructions
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual FOB FOB { get; set; }
        /// <summary>
        /// Pricing Information
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(9)]
        public virtual List<CTP> CTP { get; set; }
        /// <summary>
        /// Special Services
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(10)]
        public virtual List<SSS> SSS { get; set; }
        /// <summary>
        /// Header Sale Condition
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual CSH CSH { get; set; }
        /// <summary>
        /// Allowance, Charge or Service
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(12)]
        public virtual List<ITA> ITA { get; set; }
        /// <summary>
        /// Terms of Sale/Deferred Terms of Sale
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(13)]
        public virtual List<ITD> ITD { get; set; }
        /// <summary>
        /// Discount Detail
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(14)]
        public virtual List<DIS> DIS { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(15)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Lead Time
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(16)]
        public virtual List<LDT> LDT { get; set; }
        /// <summary>
        /// General Schedule
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(17)]
        public virtual List<SHH> SHH { get; set; }
        /// <summary>
        /// Item Identification
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(18)]
        public virtual List<LIN> LIN { get; set; }
        /// <summary>
        /// Product/Item Description
        /// </summary>
        [DataMember]
        [ListCount(200)]
        [Pos(19)]
        public virtual List<PID> PID { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [ListCount(40)]
        [Pos(20)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// Paperwork
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(21)]
        public virtual List<PWK> PWK { get; set; }
        /// <summary>
        /// Marking, Packaging, Loading
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(22)]
        public virtual List<PKG> PKG { get; set; }
        /// <summary>
        /// Carrier Details (Quantity and Weight)
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(23)]
        public virtual List<TD1> TD1 { get; set; }
        /// <summary>
        /// Carrier Details (Routing Sequence/Transit Time)
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(24)]
        public virtual List<TD5> TD5 { get; set; }
        /// <summary>
        /// Carrier Details (Equipment)
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(25)]
        public virtual List<TD3> TD3 { get; set; }
        /// <summary>
        /// Carrier Details (Special Handling/Hazardous Materials)
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(26)]
        public virtual List<TD4> TD4 { get; set; }
        /// <summary>
        /// Marks and Numbers
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(27)]
        public virtual List<MAN> MAN { get; set; }
        /// <summary>
        /// Restrictions
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(28)]
        public virtual List<CTB> CTB { get; set; }
        /// <summary>
        /// Loop for Reference Number
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(29)]
        public virtual List<Loop_N9_843> N9Loop { get; set; }
        /// <summary>
        /// Loop for Name
        /// </summary>
        [DataMember]
        [ListCount(200)]
        [Pos(30)]
        public virtual List<Loop_N1_843> N1Loop { get; set; }
        /// <summary>
        /// Loop for Purchase Order Baseline Item Data
        /// </summary>
        [DataMember]
        [ListCount(100000)]
        [Pos(31)]
        public virtual List<Loop_PO1_843> PO1Loop { get; set; }
        /// <summary>
        /// Transaction Totals
        /// </summary>
        [DataMember]
        [Required]
        [Pos(32)]
        public virtual CTT CTT { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(33)]
        public virtual SE SE { get; set; }
    }
}
