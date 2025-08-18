namespace EdiFabric.Templates.X12007020
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.X12;
    using System.Xml.Serialization;
    
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(E1))]
    public class Loop_E1_417
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Empty Car Disposition - Pended Destination Consignee
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual E1 E1 { get; set; }
        /// <summary>
        // Empty Car Disposition - Pended Destination City
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual E4 E4 { get; set; }
        /// <summary>
        // Empty Car Disposition - Pended Destination Route
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(13)]
        [Pos(3)]
        public virtual List<E5> E5 { get; set; }
        /// <summary>
        // Price Authority Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual PI PI { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(L0))]
    public class Loop_L0_417
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Line Item - Quantity and Weight
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual L0 L0 { get; set; }
        /// <summary>
        // Measurements
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(2)]
        public virtual List<MEA> MEA { get; set; }
        [DataMember]
        [ListCount(30)]
        [Pos(3)]
        public virtual List<Loop_PI_417> LoopPI { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(L0))]
    public class Loop_L0_417_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Line Item - Quantity and Weight
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual L0 L0 { get; set; }
        /// <summary>
        // Measurements
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(2)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        // Rate and Charges
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<L1> L1 { get; set; }
        [DataMember]
        [ListCount(30)]
        [Pos(4)]
        public virtual List<Loop_PI_417> LoopPI { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(LH1))]
    public class Loop_LH1_417
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Hazardous Identification Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LH1 LH1 { get; set; }
        /// <summary>
        // Hazardous Classification Information
        /// </summary>
        [DataMember]
        [ListCount(4)]
        [Pos(2)]
        public virtual List<LH2> LH2 { get; set; }
        /// <summary>
        // Hazardous Material Shipping Name Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<LH3> LH3 { get; set; }
        /// <summary>
        // Free-form Hazardous Material Information
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(4)]
        public virtual List<LFH> LFH { get; set; }
        /// <summary>
        // EPA Required Data
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(5)]
        public virtual List<LEP> LEP { get; set; }
        /// <summary>
        // Canadian Dangerous Requirements
        /// </summary>
        [DataMember]
        [ListCount(4)]
        [Pos(6)]
        public virtual List<LH4> LH4 { get; set; }
        /// <summary>
        // Transborder Hazardous Requirements
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(7)]
        public virtual List<LHT> LHT { get; set; }
        /// <summary>
        // Hazardous Material Identifying Reference Numbers
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(8)]
        public virtual List<LHR> LHR { get; set; }
        /// <summary>
        // Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(9)]
        public virtual List<PER> PER { get; set; }
        [DataMember]
        [ListCount(10)]
        [Pos(10)]
        public virtual List<Loop_N1_417_2> LoopN1 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(LS))]
    public class Loop_LS_417
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Loop Header
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LS LS { get; set; }
        [DataMember]
        [ListCount(1000)]
        [Pos(2)]
        public virtual List<Loop_LH1_417> LoopLH1 { get; set; }
        /// <summary>
        // Loop Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual LE LE { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_417
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Transaction Set Line Number
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LX LX { get; set; }
        /// <summary>
        // Description
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(15)]
        [Pos(2)]
        public virtual List<L5> L5 { get; set; }
        [DataMember]
        [ListCount(25)]
        [Pos(3)]
        public virtual List<Loop_L0_417> LoopL0 { get; set; }
        /// <summary>
        // Export License
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(4)]
        public virtual List<X1> X1 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_417
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        // Additional Name Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<N2> N2 { get; set; }
        /// <summary>
        // Party Location
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        // Geographic Location
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(5)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        // Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(6)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        // Billing Information
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(7)]
        public virtual List<BL> BL { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_417_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        // Party Location
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        // Geographic Location
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        // Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(4)]
        public virtual List<PER> PER { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_417_3
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        // Party Location
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N3 N3 { get; set; }
        /// <summary>
        // Geographic Location
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        // Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(4)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        // Billing Information
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(5)]
        public virtual List<BL> BL { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_417_4
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        // Party Location
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        // Geographic Location
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        // Special Handling Instructions
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual H3 H3 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(N7))]
    public class Loop_N7_417
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Equipment Details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N7 N7 { get; set; }
        /// <summary>
        // Equipment Characteristics
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual EM EM { get; set; }
        [DataMember]
        [ListCount(36)]
        [Pos(3)]
        public virtual List<Loop_VC_417> LoopVC { get; set; }
        /// <summary>
        // Intermodal Chassis Equipment
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual IC IC { get; set; }
        /// <summary>
        // Intermodal Movement Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual IM IM { get; set; }
        /// <summary>
        // In-bond Identifying Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(6)]
        public virtual List<M12> M12 { get; set; }
        /// <summary>
        // Scale Identification
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual G4 G4 { get; set; }
        /// <summary>
        // Seal Numbers
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(8)]
        public virtual List<M7> M7 { get; set; }
        /// <summary>
        // Equipment Ordered
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual N5 N5 { get; set; }
        /// <summary>
        // Car Service Order
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual H5 H5 { get; set; }
        [DataMember]
        [ListCount(2)]
        [Pos(11)]
        public virtual List<Loop_E1_417> LoopE1 { get; set; }
        /// <summary>
        // Canadian Grain Information
        /// </summary>
        [DataMember]
        [ListCount(15)]
        [Pos(12)]
        public virtual List<GA> GA { get; set; }
        [DataMember]
        [ListCount(99)]
        [Pos(13)]
        public virtual List<Loop_REF_417> LoopREF { get; set; }
        /// <summary>
        // Interchange Move Authority
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(14)]
        public virtual List<IMA> IMA { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(PI))]
    public class Loop_PI_417
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Price Authority Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PI PI { get; set; }
        /// <summary>
        // Shipment Conditions
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<CD> CD { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(REF))]
    public class Loop_REF_417
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual REF REF { get; set; }
        /// <summary>
        // Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        // Quantity and Description
        /// </summary>
        [DataMember]
        [ListCount(15)]
        [Pos(3)]
        public virtual List<N10> N10 { get; set; }
        /// <summary>
        // Consolidated Shipment Manifest Data
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual SMD SMD { get; set; }
        /// <summary>
        // Motor Vehicle Control
        /// </summary>
        [DataMember]
        [ListCount(36)]
        [Pos(5)]
        public virtual List<VC> VC { get; set; }
        [DataMember]
        [ListCount(25)]
        [Pos(6)]
        public virtual List<Loop_L0_417_2> LoopL0 { get; set; }
        [DataMember]
        [ListCount(15)]
        [Pos(7)]
        public virtual List<Loop_N1_417_3> LoopN1 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(S1))]
    public class Loop_S1_417
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Stop-off Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual S1 S1 { get; set; }
        /// <summary>
        // Stop-off Address
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<S2> S2 { get; set; }
        /// <summary>
        // Stop-off Station
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual S9 S9 { get; set; }
        /// <summary>
        // Party Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        // Additional Name Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual N2 N2 { get; set; }
        /// <summary>
        // Party Location
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual N3 N3 { get; set; }
        /// <summary>
        // Geographic Location
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        // Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual PER PER { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(T1))]
    public class Loop_T1_417
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Transit Inbound Origin
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual T1 T1 { get; set; }
        /// <summary>
        // Transit Inbound Lading
        /// </summary>
        [DataMember]
        [ListCount(30)]
        [Pos(2)]
        public virtual List<T2> T2 { get; set; }
        /// <summary>
        // Transit Inbound Route
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(3)]
        public virtual List<T3> T3 { get; set; }
        /// <summary>
        // Transit Inbound Rates
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual T6 T6 { get; set; }
        /// <summary>
        // Free-form Transit Data
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(5)]
        public virtual List<T8> T8 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(VC))]
    public class Loop_VC_417
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Motor Vehicle Control
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual VC VC { get; set; }
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<Loop_N1_417_4> LoopN1 { get; set; }
    }
    
    /// <summary>
    // Rail Carrier Waybill Interchange
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "417")]
    public class TS417 : EdiMessage
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Transaction Set Header
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ST ST { get; set; }
        /// <summary>
        // Beginning Segment for Data Correction or Change
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual ZC1 ZC1 { get; set; }
        /// <summary>
        // General Shipment Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual BX BX { get; set; }
        /// <summary>
        // Rail Shipment Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual BNX BNX { get; set; }
        /// <summary>
        // Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(30)]
        [Pos(5)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        // Cargo Manifest
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(6)]
        public virtual List<CM> CM { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(7)]
        public virtual List<DTM> DTM { get; set; }
        [DataMember]
        [Required]
        [ListCount(500)]
        [Pos(8)]
        public virtual List<Loop_N7_417> LoopN7 { get; set; }
        /// <summary>
        // Waybill Reference
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(499)]
        [Pos(9)]
        public virtual List<N8> N8 { get; set; }
        /// <summary>
        // Additional Reference Information
        /// </summary>
        [DataMember]
        [ListCount(499)]
        [Pos(10)]
        public virtual List<N8A> N8A { get; set; }
        /// <summary>
        // Event Detail
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual V9 V9 { get; set; }
        /// <summary>
        // Origin Station
        /// </summary>
        [DataMember]
        [Required]
        [Pos(12)]
        public virtual F9 F9 { get; set; }
        /// <summary>
        // Destination Station
        /// </summary>
        [DataMember]
        [Required]
        [Pos(13)]
        public virtual D9 D9 { get; set; }
        [DataMember]
        [Required]
        [ListCount(15)]
        [Pos(14)]
        public virtual List<Loop_N1_417> LoopN1 { get; set; }
        [DataMember]
        [ListCount(12)]
        [Pos(15)]
        public virtual List<Loop_S1_417> LoopS1 { get; set; }
        /// <summary>
        // Route Information
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(13)]
        [Pos(16)]
        public virtual List<R2> R2 { get; set; }
        /// <summary>
        // Route Code Identification
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual R9 R9 { get; set; }
        [DataMember]
        [ListCount(2)]
        [Pos(18)]
        public virtual List<Loop_E1_417> LoopE1 { get; set; }
        /// <summary>
        // Special Handling Instructions
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(19)]
        public virtual List<H3> H3 { get; set; }
        /// <summary>
        // Protective Service Instructions
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(20)]
        public virtual List<PS> PS { get; set; }
        [DataMember]
        [Required]
        [ListCount(25)]
        [Pos(21)]
        public virtual List<Loop_LX_417> LoopLX { get; set; }
        [DataMember]
        [ListCount(64)]
        [Pos(22)]
        public virtual List<Loop_T1_417> LoopT1 { get; set; }
        [DataMember]
        [Pos(23)]
        public virtual Loop_LS_417 LoopLS { get; set; }
        /// <summary>
        // Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(24)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        // Hazardous Classification Information
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(25)]
        public virtual List<LH2> LH2 { get; set; }
        /// <summary>
        // Hazardous Material Identifying Reference Numbers
        /// </summary>
        [DataMember]
        [Pos(26)]
        public virtual LHR LHR { get; set; }
        /// <summary>
        // Pro Forma - B13 Information
        /// </summary>
        [DataMember]
        [Pos(27)]
        public virtual XH XH { get; set; }
        /// <summary>
        // Customs Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(28)]
        public virtual List<X7> X7 { get; set; }
        /// <summary>
        // Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(29)]
        public virtual SE SE { get; set; }
    }
}
