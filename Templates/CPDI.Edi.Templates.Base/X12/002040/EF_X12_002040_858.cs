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
    /// Loop for Hazardous Material
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(H1))]
    public class Loop_H1_858
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Hazardous Material
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual H1 H1 { get; set; }
        /// <summary>
        /// Additional Hazardous Material Description
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<H2> H2 { get; set; }
    }
    
    /// <summary>
    /// Loop for Sequential Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_858
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Sequential Number
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LX LX { get; set; }
        /// <summary>
        /// Description, Marks and Numbers
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<L5> L5 { get; set; }
        /// <summary>
        /// Line Item - Quantity and Weight
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<L0> L0 { get; set; }
        /// <summary>
        /// Rate and Charges
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(4)]
        public virtual List<L1> L1 { get; set; }
        /// <summary>
        /// Measurement
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<L4> L4 { get; set; }
        /// <summary>
        /// Tariff Reference
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(6)]
        public virtual List<L7> L7 { get; set; }
        /// <summary>
        /// Mixed Hazardous Commodities
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual LH LH { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(8)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Export License
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(9)]
        public virtual List<X1> X1 { get; set; }
        /// <summary>
        /// Import License
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual X2 X2 { get; set; }
        /// <summary>
        /// Loop for Hazardous Material
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(11)]
        public virtual List<Loop_H1_858> H1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_858
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
    }
    
    /// <summary>
    /// Loop for Equipment Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N7))]
    public class Loop_N7_858
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Equipment Details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N7 N7 { get; set; }
        /// <summary>
        /// Seal Numbers
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<M7> M7 { get; set; }
        /// <summary>
        /// Equipment Ordered
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N5 N5 { get; set; }
        /// <summary>
        /// Reference Numbers
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Intermodal Chassis Equipment
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual IC IC { get; set; }
        /// <summary>
        /// Motor Vehicle Control
        /// </summary>
        [DataMember]
        [ListCount(21)]
        [Pos(6)]
        public virtual List<VC> VC { get; set; }
    }
    
    /// <summary>
    /// Loop for Stop Off Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(S5))]
    public class Loop_S5_858
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Stop Off Details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual S5 S5 { get; set; }
        /// <summary>
        /// Date/Time
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(2)]
        public virtual List<G62> G62 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Special Services
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(4)]
        public virtual List<H6> H6 { get; set; }
        /// <summary>
        /// Loop for Name
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(5)]
        public virtual List<Loop_N1_858> N1Loop { get; set; }
    }
    
    /// <summary>
    /// Shipment Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "858")]
    public class TS858 : EdiMessage
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
        /// Correction or Change Reference Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual ZC ZC { get; set; }
        /// <summary>
        /// General Shipment Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual BX BX { get; set; }
        /// <summary>
        /// Rail Shipment Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual BNX BNX { get; set; }
        /// <summary>
        /// Release
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual M3 M3 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [ListCount(30)]
        [Pos(6)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Authentication
        /// </summary>
        [DataMember]
        [ListCount(4)]
        [Pos(7)]
        public virtual List<Y6> Y6 { get; set; }
        /// <summary>
        /// Priority
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual Y7 Y7 { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual C3 C3 { get; set; }
        /// <summary>
        /// Terms of Sale/Deferred Terms of Sale
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual ITD ITD { get; set; }
        /// <summary>
        /// Date/Time
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(11)]
        public virtual List<G62> G62 { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(12)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Cross-Reference Equipment
        /// </summary>
        [DataMember]
        [ListCount(30)]
        [Pos(13)]
        public virtual List<NA> NA { get; set; }
        /// <summary>
        /// Origin Station
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual F9 F9 { get; set; }
        /// <summary>
        /// Destination Station
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual D9 D9 { get; set; }
        /// <summary>
        /// Route Information (Air)
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual R1 R1 { get; set; }
        /// <summary>
        /// Route Information
        /// </summary>
        [DataMember]
        [ListCount(13)]
        [Pos(17)]
        public virtual List<R2> R2 { get; set; }
        /// <summary>
        /// Port
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(18)]
        public virtual List<R4> R4 { get; set; }
        /// <summary>
        /// Measurement
        /// </summary>
        [DataMember]
        [Pos(19)]
        public virtual L4 L4 { get; set; }
        /// <summary>
        /// Special Handling Instructions
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(20)]
        public virtual List<H3> H3 { get; set; }
        /// <summary>
        /// Special Services
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(21)]
        public virtual List<H6> H6 { get; set; }
        /// <summary>
        /// Empty Car Disposition - Pended Destination Consignee
        /// </summary>
        [DataMember]
        [Pos(22)]
        public virtual E1 E1 { get; set; }
        /// <summary>
        /// Empty Car Disposition - Pended Destination City
        /// </summary>
        [DataMember]
        [Pos(23)]
        public virtual E4 E4 { get; set; }
        /// <summary>
        /// Empty Car Disposition - Pended Destination Route
        /// </summary>
        [DataMember]
        [ListCount(13)]
        [Pos(24)]
        public virtual List<E5> E5 { get; set; }
        /// <summary>
        /// Insurance
        /// </summary>
        [DataMember]
        [Pos(25)]
        public virtual M1 M1 { get; set; }
        /// <summary>
        /// Sales/Delivery Terms
        /// </summary>
        [DataMember]
        [Pos(26)]
        public virtual M2 M2 { get; set; }
        /// <summary>
        /// Tariff Reference
        /// </summary>
        [DataMember]
        [ListCount(30)]
        [Pos(27)]
        public virtual List<L7> L7 { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(30)]
        [Pos(28)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Pro Forma - B13 Information
        /// </summary>
        [DataMember]
        [Pos(29)]
        public virtual XH XH { get; set; }
        /// <summary>
        /// Canadian Grain Information
        /// </summary>
        [DataMember]
        [Pos(30)]
        public virtual GA GA { get; set; }
        /// <summary>
        /// Loop for Hazardous Material
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(31)]
        public virtual List<Loop_H1_858> H1Loop { get; set; }
        /// <summary>
        /// Loop for Equipment Details
        /// </summary>
        [DataMember]
        [ListCount(600)]
        [Pos(32)]
        public virtual List<Loop_N7_858> N7Loop { get; set; }
        /// <summary>
        /// Loop for Name
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(33)]
        public virtual List<Loop_N1_858> N1Loop { get; set; }
        /// <summary>
        /// Loop for Stop Off Details
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(34)]
        public virtual List<Loop_S5_858> S5Loop { get; set; }
        /// <summary>
        /// Loop for Sequential Number
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(999)]
        [Pos(35)]
        public virtual List<Loop_LX_858> LXLoop { get; set; }
        /// <summary>
        /// Total Weight and Charges
        /// </summary>
        [DataMember]
        [Pos(36)]
        public virtual L3 L3 { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(37)]
        public virtual SE SE { get; set; }
    }
}
