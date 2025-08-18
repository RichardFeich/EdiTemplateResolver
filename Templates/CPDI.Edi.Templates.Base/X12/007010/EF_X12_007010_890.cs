namespace EdiFabric.Templates.X12007010
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
    [Group(typeof(NM1))]
    public class Loop_0100_890
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
        // Property or Entity Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual NX1 NX1 { get; set; }
        /// <summary>
        // Contract Party Restriction
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<PPR> PPR { get; set; }
        /// <summary>
        // Additional Name Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(4)]
        public virtual List<N2> N2 { get; set; }
        /// <summary>
        // Party Location
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(5)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        // Geographic Location
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        // Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<PER> PER { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(8)]
        public virtual List<Loop_0120_890> Loop0120 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_0120_890
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
        // Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<PER> PER { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(AMT))]
    public class Loop_0140_890
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Monetary Amount Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual AMT AMT { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual MTX MTX { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(QTY))]
    public class Loop_0160_890
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Quantity Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual QTY QTY { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual MTX MTX { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_0180_890
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
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        // Frequency Basis
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual TBP TBP { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(CPL))]
    public class Loop_0190_890
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Program Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CPL CPL { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        // Contract Party Restriction
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<PPR> PPR { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual MTX MTX { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<Loop_0200_890> Loop0200 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<Loop_0210_890> Loop0210 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual Loop_LS_890 LoopLS { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(8)]
        public virtual List<Loop_0300_890> Loop0300 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(DTM))]
    public class Loop_0200_890
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual DTM DTM { get; set; }
        /// <summary>
        // Frequency Basis
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual TBP TBP { get; set; }
        /// <summary>
        // Party Identification
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<N1> N1 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(AMT))]
    public class Loop_0210_890
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Monetary Amount Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual AMT AMT { get; set; }
        /// <summary>
        // Measurements
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        // Frequency Basis
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual TBP TBP { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_0230_890
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
        // Quantity Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual QTY QTY { get; set; }
        /// <summary>
        // Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual AMT AMT { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual MTX MTX { get; set; }
        /// <summary>
        // Program Spend
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<PSG> PSG { get; set; }
        /// <summary>
        // Claimant Payment Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual CPI CPI { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<Loop_0250_890> Loop0250 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(SEF))]
    public class Loop_0250_890
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Payment Handling
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SEF SEF { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<Loop_0260_890> Loop0260 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(DTM))]
    public class Loop_0260_890
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual DTM DTM { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual MTX MTX { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_0300_890
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
        // Text
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual MTX MTX { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<Loop_0305_890> Loop0305 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<Loop_0310_890> Loop0310 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<Loop_0320_890> Loop0320 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<Loop_0340_890> Loop0340 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<Loop_0350_890> Loop0350 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(FX2))]
    public class Loop_0305_890
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Product Classification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual FX2 FX2 { get; set; }
        /// <summary>
        // Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual AMT AMT { get; set; }
        /// <summary>
        // Quantity Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual QTY QTY { get; set; }
        /// <summary>
        // Brand Label
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<FX6> FX6 { get; set; }
        /// <summary>
        // Pack and Size
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<FX7> FX7 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(FX3))]
    public class Loop_0310_890
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Product Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual FX3 FX3 { get; set; }
        /// <summary>
        // Product Detail
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual FU3 FU3 { get; set; }
        /// <summary>
        // Product Pack Detail
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual FU4 FU4 { get; set; }
        /// <summary>
        // Co-Product Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual FU5 FU5 { get; set; }
        /// <summary>
        // Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual AMT AMT { get; set; }
        /// <summary>
        // Quantity Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual QTY QTY { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(FU1))]
    public class Loop_0320_890
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Bracket Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual FU1 FU1 { get; set; }
        /// <summary>
        // Deal Value
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual FU2 FU2 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(FX4))]
    public class Loop_0340_890
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Equipment Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual FX4 FX4 { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        // Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<N1> N1 { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        // Fees and Payment Schedule
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual ECS ECS { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(FX5))]
    public class Loop_0350_890
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Services Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual FX5 FX5 { get; set; }
        /// <summary>
        // Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<N1> N1 { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        // Quantity Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual QTY QTY { get; set; }
        /// <summary>
        // Fees and Payment Schedule
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual ECS ECS { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<Loop_0400_890> Loop0400 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(FX4))]
    public class Loop_0400_890
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Equipment Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual FX4 FX4 { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(LS))]
    public class Loop_LS_890
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
        [ListCount(3)]
        [Pos(2)]
        public virtual List<Loop_0180_890> Loop0180 { get; set; }
        /// <summary>
        // Loop Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual LE LE { get; set; }
    }

    /// <summary>
    // Contract & Rebate Management Transaction
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "890")]
    public class TS890 : EdiMessage
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
        // Beginning Segment for Contract Transaction Set
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual CTH CTH { get; set; }
        /// <summary>
        // Currency
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual CUR CUR { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(4)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual MTX MTX { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        // Service
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<SAC> SAC { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(8)]
        public virtual List<Loop_0100_890> Loop0100 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(9)]
        public virtual List<Loop_0140_890> Loop0140 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(10)]
        public virtual List<Loop_0160_890> Loop0160 { get; set; }
        [DataMember]
        [Pos(11)]
        public virtual Loop_LS_890 LoopLS { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(12)]
        public virtual List<Loop_0190_890> Loop0190 { get; set; }
    }
}
