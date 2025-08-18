namespace EdiFabric.Templates.X12007010
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
    [Group(typeof(N1))]
    public class Loop_10000_155
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
        // Location ID Component
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<NX2> NX2 { get; set; }
        /// <summary>
        // Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<PER> PER { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL))]
    public class Loop_20000_155
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Hierarchical Level
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual HL HL { get; set; }
        /// <summary>
        // Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        // Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        // Language Use
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual LUI LUI { get; set; }
        /// <summary>
        // Currency Identifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual C3 C3 { get; set; }
        /// <summary>
        // Conditions Indicator
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<CRC> CRC { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<MTX> MTX { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(8)]
        public virtual List<Loop_21000_155> Loop21000 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(9)]
        public virtual List<Loop_22000_155> Loop22000 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(10)]
        public virtual List<Loop_23000_155> Loop23000 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_21000_155
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NM1 NM1 { get; set; }
        /// <summary>
        // Additional Name Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<N2> N2 { get; set; }
        /// <summary>
        // Business Professional Title
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(3)]
        public virtual List<TPB> TPB { get; set; }
        /// <summary>
        // Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<DTP> DTP { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(NX1))]
    public class Loop_22000_155
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Property or Entity Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NX1 NX1 { get; set; }
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
        // Location ID Component
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<NX2> NX2 { get; set; }
        /// <summary>
        // Communication Contact Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<COM> COM { get; set; }
        /// <summary>
        // Yes/No Question
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<YNQ> YNQ { get; set; }
        /// <summary>
        // Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<DTP> DTP { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(8)]
        public virtual List<Loop_22100_155> Loop22100 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(REQ))]
    public class Loop_22100_155
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Request Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual REQ REQ { get; set; }
        /// <summary>
        // Location Description
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(2)]
        public virtual List<LOD> LOD { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<MTX> MTX { get; set; }
        /// <summary>
        // Facility Description
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<FDA> FDA { get; set; }
        /// <summary>
        // Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<III> III { get; set; }
        /// <summary>
        // Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        // Amount with Description
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<AWD> AWD { get; set; }
        /// <summary>
        // Quantity Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(8)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        // Conditions Indicator
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(9)]
        public virtual List<CRC> CRC { get; set; }
        /// <summary>
        // Party Identification
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        // Additional Name Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(11)]
        public virtual List<N2> N2 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(INR))]
    public class Loop_23000_155
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Information Request
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual INR INR { get; set; }
        /// <summary>
        // Property or Entity Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual NX1 NX1 { get; set; }
        /// <summary>
        // Information Type and Comment Results
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<ITC> ITC { get; set; }
        /// <summary>
        // Currency Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C3 C3 { get; set; }
        /// <summary>
        // Quantity Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        // Asset Ownership
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<ASO> ASO { get; set; }
        /// <summary>
        // Supplier Rating
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<SPR> SPR { get; set; }
        /// <summary>
        // Demographic Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual DMG DMG { get; set; }
        /// <summary>
        // Employment Position
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual EMS EMS { get; set; }
        /// <summary>
        // Territory
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(10)]
        public virtual List<TER> TER { get; set; }
        /// <summary>
        // Yes/No Question
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(11)]
        public virtual List<YNQ> YNQ { get; set; }
        /// <summary>
        // Action or Status Indicator
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual ASI ASI { get; set; }
        /// <summary>
        // Conditions Indicator
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(13)]
        public virtual List<CRC> CRC { get; set; }
        /// <summary>
        // Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(14)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        // Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(15)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(16)]
        public virtual List<MTX> MTX { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(17)]
        public virtual List<Loop_23100_155> Loop23100 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(18)]
        public virtual List<Loop_23200_155> Loop23200 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(19)]
        public virtual List<Loop_23300_155> Loop23300 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(20)]
        public virtual List<Loop_23400_155> Loop23400 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(21)]
        public virtual List<Loop_23500_155> Loop23500 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(INQ))]
    public class Loop_23100_155
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Credit Inquiry Details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual INQ INQ { get; set; }
        /// <summary>
        // Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        // Currency Identifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C3 C3 { get; set; }
        /// <summary>
        // Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<III> III { get; set; }
        /// <summary>
        // Historical Payment Terms
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<PYT> PYT { get; set; }
        /// <summary>
        // Payment Manner and Percentage
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<PYM> PYM { get; set; }
        /// <summary>
        // Amount with Description
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<AWD> AWD { get; set; }
        /// <summary>
        // Quantity Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual QTY QTY { get; set; }
        /// <summary>
        // Account Description
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(9)]
        public virtual List<ACD> ACD { get; set; }
        /// <summary>
        // Measurements
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(10)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        // Supplier Rating
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(11)]
        public virtual List<SPR> SPR { get; set; }
        /// <summary>
        // Asset Ownership
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(12)]
        public virtual List<ASO> ASO { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_23200_155
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
        // Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual NM1 NM1 { get; set; }
        /// <summary>
        // Property or Entity Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual NX1 NX1 { get; set; }
        /// <summary>
        // Additional Name Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(4)]
        public virtual List<N2> N2 { get; set; }
        /// <summary>
        // Business Professional Title
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(5)]
        public virtual List<TPB> TPB { get; set; }
        /// <summary>
        // Party Location
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(6)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        // Geographic Location
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        // Location ID Component
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(8)]
        public virtual List<NX2> NX2 { get; set; }
        /// <summary>
        // Communication Contact Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(9)]
        public virtual List<COM> COM { get; set; }
        /// <summary>
        // Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(10)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        // Amount with Description
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(11)]
        public virtual List<AWD> AWD { get; set; }
        /// <summary>
        // Asset Ownership
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(12)]
        public virtual List<ASO> ASO { get; set; }
        /// <summary>
        // Yes/No Question
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(13)]
        public virtual List<YNQ> YNQ { get; set; }
        /// <summary>
        // Percent Amounts
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(14)]
        public virtual List<PCT> PCT { get; set; }
        /// <summary>
        // Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(15)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        // Quantity Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(16)]
        public virtual List<QTY> QTY { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(LM))]
    public class Loop_23300_155
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Code Source Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LM LM { get; set; }
        /// <summary>
        // Information
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<III> III { get; set; }
        /// <summary>
        // Percent Amounts
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<PCT> PCT { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<Loop_23310_155> Loop23310 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_23310_155
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
        // Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<MTX> MTX { get; set; }
        /// <summary>
        // Industry Code Identification
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<LQ> LQ { get; set; }
        /// <summary>
        // Amount with Description
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<AWD> AWD { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<Loop_23311_155> Loop23311 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_23311_155
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NM1 NM1 { get; set; }
        /// <summary>
        // Additional Name Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<N2> N2 { get; set; }
        /// <summary>
        // Business Professional Title
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(3)]
        public virtual List<TPB> TPB { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(REQ))]
    public class Loop_23400_155
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Request Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual REQ REQ { get; set; }
        /// <summary>
        // Amount with Description
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<AWD> AWD { get; set; }
        /// <summary>
        // Conditions Indicator
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<CRC> CRC { get; set; }
        /// <summary>
        // Quantity Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        // Percent Amounts
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<PCT> PCT { get; set; }
        /// <summary>
        // Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        // Yes/No Question
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<YNQ> YNQ { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(8)]
        public virtual List<MTX> MTX { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(API))]
    public class Loop_23500_155
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Activity or Process Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual API API { get; set; }
        /// <summary>
        // Yes/No Question
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual YNQ YNQ { get; set; }
        /// <summary>
        // Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        // Case Description
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual CDS CDS { get; set; }
        /// <summary>
        // Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        // Legal Claims
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<BBC> BBC { get; set; }
        /// <summary>
        // Measurements
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        // Asset Ownership
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(8)]
        public virtual List<ASO> ASO { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(9)]
        public virtual List<MTX> MTX { get; set; }
        /// <summary>
        // Percent Amounts
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(10)]
        public virtual List<PCT> PCT { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(11)]
        public virtual List<Loop_23510_155> Loop23510 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(12)]
        public virtual List<Loop_23520_155> Loop23520 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(13)]
        public virtual List<Loop_23530_155> Loop23530 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(14)]
        public virtual List<Loop_23540_155> Loop23540 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(LM))]
    public class Loop_23510_155
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Code Source Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LM LM { get; set; }
        /// <summary>
        // Information
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<III> III { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(CRC))]
    public class Loop_23520_155
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Conditions Indicator
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CRC CRC { get; set; }
        /// <summary>
        // Amount with Description
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<AWD> AWD { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_23530_155
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NM1 NM1 { get; set; }
        /// <summary>
        // Additional Name Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<N2> N2 { get; set; }
        /// <summary>
        // Business Professional Title
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(3)]
        public virtual List<TPB> TPB { get; set; }
        /// <summary>
        // Party Location
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(4)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        // Geographic Location
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        // Location ID Component
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<NX2> NX2 { get; set; }
        /// <summary>
        // Communication Contact Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<COM> COM { get; set; }
        /// <summary>
        // Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(8)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        // Information Type and Comment Results
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual ITC ITC { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(10)]
        public virtual List<MTX> MTX { get; set; }
        /// <summary>
        // Yes/No Question
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(11)]
        public virtual List<YNQ> YNQ { get; set; }
        /// <summary>
        // Amount with Description
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(12)]
        public virtual List<AWD> AWD { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(13)]
        public virtual List<Loop_23531_155> Loop23531 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(IN1))]
    public class Loop_23531_155
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Individual Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual IN1 IN1 { get; set; }
        /// <summary>
        // Individual Name Structure Components
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<IN2> IN2 { get; set; }
        /// <summary>
        // Business Professional Title
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(3)]
        public virtual List<TPB> TPB { get; set; }
        /// <summary>
        // Party Location
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(4)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        // Geographic Location
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        // Location ID Component
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<NX2> NX2 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(CED))]
    public class Loop_23540_155
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Administration of Justice Event Description
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CED CED { get; set; }
        /// <summary>
        // Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<MTX> MTX { get; set; }
        /// <summary>
        // Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual NM1 NM1 { get; set; }
        /// <summary>
        // Additional Name Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(5)]
        public virtual List<N2> N2 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<Loop_23541_155> Loop23541 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(LM))]
    public class Loop_23541_155
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Code Source Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LM LM { get; set; }
        /// <summary>
        // Industry Code Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<LQ> LQ { get; set; }
    }
    
    /// <summary>
    // Business Credit Report
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "155")]
    public class TS155 : EdiMessage
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
        // Beginning Segment
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BGN BGN { get; set; }
        [DataMember]
        [Required]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<Loop_10000_155> Loop10000 { get; set; }
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<Loop_20000_155> Loop20000 { get; set; }
        /// <summary>
        // Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(5)]
        public virtual SE SE { get; set; }
    }
}
