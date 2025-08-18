namespace EdiFabric.Templates.X12003020
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
    /// Loop for Consignee's Third Party
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(D5))]
    public class Loop_D5_410
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Consignee's Third Party
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual D5 D5 { get; set; }
        /// <summary>
        /// Consignee's Third Party Address
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual D6 D6 { get; set; }
        /// <summary>
        /// Consignee's Third Party City
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual D7 D7 { get; set; }
    }
    
    /// <summary>
    /// Loop for Consignor's Third Party
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(F5))]
    public class Loop_F5_410
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Consignor's Third Party
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual F5 F5 { get; set; }
        /// <summary>
        /// Consignor's Third Party Address
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual F6 F6 { get; set; }
        /// <summary>
        /// Consignor's Third Party City
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual F7 F7 { get; set; }
    }
    
    /// <summary>
    /// Loop for Loop Header
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LS))]
    public class Loop_LS_410
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Loop Header
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LS LS { get; set; }
        /// <summary>
        /// Loop for Assigned Number
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(25)]
        [Pos(2)]
        public virtual List<Loop_LX_410_2> LXLoop { get; set; }
        /// <summary>
        /// Loop Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual LE LE { get; set; }
    }
    
    /// <summary>
    /// Loop for Assigned Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_410
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Assigned Number
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LX LX { get; set; }
        /// <summary>
        /// Description, Marks and Numbers
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(15)]
        [Pos(2)]
        public virtual List<L5> L5 { get; set; }
        /// <summary>
        /// Loop for Loop Header
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual Loop_LS_410 LSLoop { get; set; }
        /// <summary>
        /// Tariff Reference
        /// </summary>
        [DataMember]
        [ListCount(30)]
        [Pos(4)]
        public virtual List<L7> L7 { get; set; }
    }
    
    /// <summary>
    /// Loop for Assigned Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_410_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Assigned Number
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LX LX { get; set; }
        /// <summary>
        /// Line Item - Quantity and Weight
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<L0> L0 { get; set; }
        /// <summary>
        /// Rate and Charges
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<L1> L1 { get; set; }
    }
    
    /// <summary>
    /// Loop for Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_410
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
        /// Address Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4 N4 { get; set; }
    }
    
    /// <summary>
    /// Loop for Equipment Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N7))]
    public class Loop_N7_410
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
        /// Motor Vehicle Control
        /// </summary>
        [DataMember]
        [ListCount(21)]
        [Pos(2)]
        public virtual List<VC> VC { get; set; }
        /// <summary>
        /// Scale Identification Segment
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual G4 G4 { get; set; }
        /// <summary>
        /// Seal Numbers
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<M7> M7 { get; set; }
        /// <summary>
        /// Equipment Ordered
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual N5 N5 { get; set; }
        /// <summary>
        /// Intermodal Chassis Equipment
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual IC IC { get; set; }
        /// <summary>
        /// Intermodal Movement Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual IM IM { get; set; }
        /// <summary>
        /// In-bond Identifying Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual M12 M12 { get; set; }
    }
    
    /// <summary>
    /// Loop for Stop-off Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(S1))]
    public class Loop_S1_410
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Stop-off Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual S1 S1 { get; set; }
        /// <summary>
        /// Stop-off Address
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual S2 S2 { get; set; }
        /// <summary>
        /// Stop-off Station
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual S9 S9 { get; set; }
    }
    
    /// <summary>
    /// Loop for Transit Inbound Origin
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(T1))]
    public class Loop_T1_410
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transit Inbound Origin
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual T1 T1 { get; set; }
        /// <summary>
        /// Transit Inbound Lading
        /// </summary>
        [DataMember]
        [ListCount(30)]
        [Pos(2)]
        public virtual List<T2> T2 { get; set; }
        /// <summary>
        /// Transit Inbound Route
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(3)]
        public virtual List<T3> T3 { get; set; }
        /// <summary>
        /// Transit Inbound Rates
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual T6 T6 { get; set; }
        /// <summary>
        /// Free-form Transit Data
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(5)]
        public virtual List<T8> T8 { get; set; }
    }
    
    /// <summary>
    /// Rail Carrier Freight Details and Invoice
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "410")]
    public class TS410 : EdiMessage
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
        /// Beginning Segment for Carrier's Invoice
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual B3B B3B { get; set; }
        /// <summary>
        /// Alternate Amount Due
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C4 C4 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [ListCount(30)]
        [Pos(4)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Loop for Equipment Details
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(255)]
        [Pos(5)]
        public virtual List<Loop_N7_410> N7Loop { get; set; }
        /// <summary>
        /// Waybill Reference
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(255)]
        [Pos(6)]
        public virtual List<N8> N8 { get; set; }
        /// <summary>
        /// Origin Station
        /// </summary>
        [DataMember]
        [Required]
        [Pos(7)]
        public virtual F9 F9 { get; set; }
        /// <summary>
        /// Destination Station
        /// </summary>
        [DataMember]
        [Required]
        [Pos(8)]
        public virtual D9 D9 { get; set; }
        /// <summary>
        /// Loop for Name
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(9)]
        public virtual List<Loop_N1_410> N1Loop { get; set; }
        /// <summary>
        /// Consignor Name
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual F1 F1 { get; set; }
        /// <summary>
        /// Consignor Address
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(11)]
        public virtual List<F2> F2 { get; set; }
        /// <summary>
        /// Consignor City
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual F4 F4 { get; set; }
        /// <summary>
        /// Consignee Name
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual D1 D1 { get; set; }
        /// <summary>
        /// Consignee Adress
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(14)]
        public virtual List<D2> D2 { get; set; }
        /// <summary>
        /// Consignee City
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual D4 D4 { get; set; }
        /// <summary>
        /// Ultimate Consignee Name
        /// </summary>
        [DataMember]
        [Pos(16)]
        public virtual U1 U1 { get; set; }
        /// <summary>
        /// Ultimate Consignee Address
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual U2 U2 { get; set; }
        /// <summary>
        /// Ultimate Consignee City
        /// </summary>
        [DataMember]
        [Pos(18)]
        public virtual U4 U4 { get; set; }
        /// <summary>
        /// Prior Origin Name
        /// </summary>
        [DataMember]
        [Pos(19)]
        public virtual U5 U5 { get; set; }
        /// <summary>
        /// Prior Origin Address
        /// </summary>
        [DataMember]
        [Pos(20)]
        public virtual U6 U6 { get; set; }
        /// <summary>
        /// Prior Origin City
        /// </summary>
        [DataMember]
        [Pos(21)]
        public virtual U9 U9 { get; set; }
        /// <summary>
        /// Loop for Consignor's Third Party
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(22)]
        public virtual List<Loop_F5_410> F5Loop { get; set; }
        /// <summary>
        /// Loop for Consignee's Third Party
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(23)]
        public virtual List<Loop_D5_410> D5Loop { get; set; }
        /// <summary>
        /// Loop for Stop-off Name
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(24)]
        public virtual List<Loop_S1_410> S1Loop { get; set; }
        /// <summary>
        /// Route Information
        /// </summary>
        [DataMember]
        [ListCount(13)]
        [Pos(25)]
        public virtual List<R2> R2 { get; set; }
        /// <summary>
        /// Rebill At Interchange
        /// </summary>
        [DataMember]
        [Pos(26)]
        public virtual RE RE { get; set; }
        /// <summary>
        /// Protective Service Instructions
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(27)]
        public virtual List<PS> PS { get; set; }
        /// <summary>
        /// Loop for Assigned Number
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(25)]
        [Pos(28)]
        public virtual List<Loop_LX_410> LXLoop { get; set; }
        /// <summary>
        /// Loop for Transit Inbound Origin
        /// </summary>
        [DataMember]
        [ListCount(64)]
        [Pos(29)]
        public virtual List<Loop_T1_410> T1Loop { get; set; }
        /// <summary>
        /// Total Weight and Charges
        /// </summary>
        [DataMember]
        [Required]
        [Pos(30)]
        public virtual L3 L3 { get; set; }
        /// <summary>
        /// Customs Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(31)]
        public virtual List<X7> X7 { get; set; }
        /// <summary>
        /// Canadian Grain Information
        /// </summary>
        [DataMember]
        [Pos(32)]
        public virtual GA GA { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(33)]
        public virtual SE SE { get; set; }
    }
}
