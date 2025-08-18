namespace EdiFabric.Templates.X12007020
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.X12;


    [Serializable()]
    [DataContract()]
    [Group(typeof(HL))]
    public class Loop_2000_274
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
        // Trace
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual TRN TRN { get; set; }
        /// <summary>
        // Request Validation
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual AAA AAA { get; set; }
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<Loop_2100_274> Loop2100 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_2100_274
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
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<N2> N2 { get; set; }
        /// <summary>
        // Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        // Demographic Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual DMG DMG { get; set; }
        /// <summary>
        // Monetary Amount Information
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(5)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        // Activity or Process Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<API> API { get; set; }
        /// <summary>
        // Degree Record
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(7)]
        public virtual List<DEG> DEG { get; set; }
        /// <summary>
        // Additional Individual Demographic Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual IND IND { get; set; }
        /// <summary>
        // Language Use
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(9)]
        public virtual List<LUI> LUI { get; set; }
        /// <summary>
        // Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(10)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        // Request Validation
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual AAA AAA { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(12)]
        public virtual List<MTX> MTX { get; set; }
        /// <summary>
        // Quantity Information
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(13)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        // Work Schedule
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(14)]
        public virtual List<WS> WS { get; set; }
        /// <summary>
        // Conditions Indicator
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(15)]
        public virtual List<CRC> CRC { get; set; }
        /// <summary>
        // Health Care Services Delivery
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(16)]
        public virtual List<HSD> HSD { get; set; }
        /// <summary>
        // Basic Claim Information
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(17)]
        public virtual List<BCI> BCI { get; set; }
        /// <summary>
        // Practice Detail Information
        /// </summary>
        [DataMember]
        [Pos(18)]
        public virtual PDI PDI { get; set; }
        /// <summary>
        // Hospital Affiliation Detail
        /// </summary>
        [DataMember]
        [Pos(19)]
        public virtual HAD HAD { get; set; }
        /// <summary>
        // Account Identification
        /// </summary>
        [DataMember]
        [Pos(20)]
        public virtual ACT ACT { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(21)]
        public virtual List<Loop_2110_274> Loop2110 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(22)]
        public virtual List<Loop_2120_274> Loop2120 { get; set; }
        [DataMember]
        [ListCount(99)]
        [Pos(23)]
        public virtual List<Loop_2130_274> Loop2130 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(24)]
        public virtual List<Loop_2140_274> Loop2140 { get; set; }
        [DataMember]
        [ListCount(9)]
        [Pos(25)]
        public virtual List<Loop_2150_274> Loop2150 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(26)]
        public virtual List<Loop_2160_274> Loop2160 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(NX1))]
    public class Loop_2110_274
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
        // Additional Name Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N2 N2 { get; set; }
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
        // Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual PER PER { get; set; }
        /// <summary>
        // Request Validation
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual AAA AAA { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(LQ))]
    public class Loop_2120_274
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Industry Code Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LQ LQ { get; set; }
        /// <summary>
        // Party Identification
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<N1> N1 { get; set; }
        /// <summary>
        // Business Professional Title
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<TPB> TPB { get; set; }
        /// <summary>
        // Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(4)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        // Quantity Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual QTY QTY { get; set; }
        /// <summary>
        // Yes/No Question
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<YNQ> YNQ { get; set; }
        /// <summary>
        // Request Validation
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual AAA AAA { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(HPL))]
    public class Loop_2130_274
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Health Care Provider License
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual HPL HPL { get; set; }
        /// <summary>
        // Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        // Request Validation
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual AAA AAA { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(REF))]
    public class Loop_2140_274
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
        // Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(2)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        // Request Validation
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual AAA AAA { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(EMS))]
    public class Loop_2150_274
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Employment Position
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual EMS EMS { get; set; }
        /// <summary>
        // Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(2)]
        public virtual List<DTP> DTP { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_2160_274
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
        // Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual PER PER { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual REF REF { get; set; }
        /// <summary>
        // Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual DTP DTP { get; set; }
        /// <summary>
        // Associated Object Type Identification
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual OOI OOI { get; set; }
        /// <summary>
        // Binary Data Structure
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual BDS BDS { get; set; }
        /// <summary>
        // Request Validation
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual AAA AAA { get; set; }
    }

    /// <summary>
    // Healthcare Provider Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "274")]
    public class TS274 : EdiMessage
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
        // Beginning of Hierarchical Transaction
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BHT BHT { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual DTM DTM { get; set; }
        /// <summary>
        // Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual PER PER { get; set; }
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<Loop_2000_274> Loop2000 { get; set; }
        /// <summary>
        // Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(6)]
        public virtual SE SE { get; set; }
    }
}
