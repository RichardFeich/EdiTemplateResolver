namespace EdiFabric.Templates.X12006010
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
    /// Loop for Monetary Amount Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(AMT))]
    public class Loop_AMT_890
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual AMT AMT { get; set; }
        /// <summary>
        /// Text
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual MTX MTX { get; set; }
    }
    
    /// <summary>
    /// Loop for Monetary Amount Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(AMT))]
    public class Loop_AMT_890_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual AMT AMT { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// Frequency Basis
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual TBP TBP { get; set; }
    }
    
    /// <summary>
    /// Loop for Program Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CPL))]
    public class Loop_CPL_890
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Program Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CPL CPL { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Contract Party Restriction
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<PPR> PPR { get; set; }
        /// <summary>
        /// Text
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual MTX MTX { get; set; }
        /// <summary>
        /// Loop for Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<Loop_DTM_890> DTMLoop { get; set; }
        /// <summary>
        /// Loop for Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<Loop_AMT_890_2> AMTLoop { get; set; }
        /// <summary>
        /// Loop Header
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual LS LS { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<Loop_N1_890_3> N1Loop { get; set; }
        /// <summary>
        /// Loop Trailer
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual LE LE { get; set; }
        /// <summary>
        /// Loop for Transaction Set Line Number
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<Loop_LX_890> LXLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Date/Time Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(DTM))]
    public class Loop_DTM_890
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual DTM DTM { get; set; }
        /// <summary>
        /// Frequency Basis
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual TBP TBP { get; set; }
        /// <summary>
        /// Party Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<N1> N1 { get; set; }
    }
    
    /// <summary>
    /// Loop for Date/Time Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(DTM))]
    public class Loop_DTM_890_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual DTM DTM { get; set; }
        /// <summary>
        /// Text
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual MTX MTX { get; set; }
    }
    
    /// <summary>
    /// Loop for Bracket Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(FU1))]
    public class Loop_FU1_890
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Bracket Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual FU1 FU1 { get; set; }
        /// <summary>
        /// Deal Value
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual FU2 FU2 { get; set; }
    }
    
    /// <summary>
    /// Loop for Product Classification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(FX2))]
    public class Loop_FX2_890
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Product Classification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual FX2 FX2 { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual AMT AMT { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual QTY QTY { get; set; }
        /// <summary>
        /// Brand Label
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<FX6> FX6 { get; set; }
        /// <summary>
        /// Pack and Size
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<FX7> FX7 { get; set; }
    }
    
    /// <summary>
    /// Loop for Product Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(FX3))]
    public class Loop_FX3_890
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Product Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual FX3 FX3 { get; set; }
        /// <summary>
        /// Product Detail
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual FU3 FU3 { get; set; }
        /// <summary>
        /// Product Pack Detail
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual FU4 FU4 { get; set; }
        /// <summary>
        /// Co-Product Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual FU5 FU5 { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual AMT AMT { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual QTY QTY { get; set; }
    }
    
    /// <summary>
    /// Loop for Equipment Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(FX4))]
    public class Loop_FX4_890
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Equipment Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual FX4 FX4 { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual List<N1> N1 { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Fees and Payment Schedule
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual ECS ECS { get; set; }
    }
    
    /// <summary>
    /// Loop for Equipment Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(FX4))]
    public class Loop_FX4_890_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Equipment Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual FX4 FX4 { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
    }
    
    /// <summary>
    /// Loop for Services Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(FX5))]
    public class Loop_FX5_890
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Services Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual FX5 FX5 { get; set; }
        /// <summary>
        /// Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual List<N1> N1 { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual QTY QTY { get; set; }
        /// <summary>
        /// Fees and Payment Schedule
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual ECS ECS { get; set; }
        /// <summary>
        /// Loop for Equipment Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<Loop_FX4_890_2> FX4Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Loop Header
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LS))]
    public class Loop_LS_890
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
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(2)]
        public virtual List<Loop_N1_890_2> N1Loop { get; set; }
        /// <summary>
        /// Loop Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual LE LE { get; set; }
    }
    
    /// <summary>
    /// Loop for Transaction Set Line Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_890
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transaction Set Line Number
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LX LX { get; set; }
        /// <summary>
        /// Text
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual MTX MTX { get; set; }
        /// <summary>
        /// Loop for Product Classification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_FX2_890> FX2Loop { get; set; }
        /// <summary>
        /// Loop for Product Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_FX3_890> FX3Loop { get; set; }
        /// <summary>
        /// Loop for Bracket Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<Loop_FU1_890> FU1Loop { get; set; }
        /// <summary>
        /// Loop for Equipment Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<Loop_FX4_890> FX4Loop { get; set; }
        /// <summary>
        /// Loop for Services Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<Loop_FX5_890> FX5Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_890
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party Identification
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
        /// Party Location
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
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<PER> PER { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_890_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Frequency Basis
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual TBP TBP { get; set; }
    }
    
    /// <summary>
    /// Loop for Party Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_890_3
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual QTY QTY { get; set; }
        /// <summary>
        /// Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual AMT AMT { get; set; }
        /// <summary>
        /// Text
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual MTX MTX { get; set; }
        /// <summary>
        /// Program Spend
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual List<PSG> PSG { get; set; }
        /// <summary>
        /// Claimant Payment Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual CPI CPI { get; set; }
        /// <summary>
        /// Loop for Payment Handling
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual Loop_SEF_890 SEFLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Individual or Organizational Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_NM1_890
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NM1 NM1 { get; set; }
        /// <summary>
        /// Property or Entity Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual NX1 NX1 { get; set; }
        /// <summary>
        /// Contract Party Restriction
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<PPR> PPR { get; set; }
        /// <summary>
        /// Additional Name Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(4)]
        public virtual List<N2> N2 { get; set; }
        /// <summary>
        /// Party Location
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(5)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Loop for Party Identification
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<Loop_N1_890> N1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Quantity Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(QTY))]
    public class Loop_QTY_890
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual QTY QTY { get; set; }
        /// <summary>
        /// Text
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual MTX MTX { get; set; }
    }
    
    /// <summary>
    /// Loop for Payment Handling
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SEF))]
    public class Loop_SEF_890
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Payment Handling
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SEF SEF { get; set; }
        /// <summary>
        /// Loop for Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<Loop_DTM_890_2> DTMLoop { get; set; }
    }
    
    /// <summary>
    /// Contract & Rebate Management Transaction
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
        /// Transaction Set Header
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual ST ST { get; set; }
        /// <summary>
        /// Beginning Segment for Contract Transaction Set
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual CTH CTH { get; set; }
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
        [ListCount(10)]
        [Pos(4)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Text
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual MTX MTX { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Service, Promotion, Allowance, or Charge Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<SAC> SAC { get; set; }
        /// <summary>
        /// Loop for Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<Loop_NM1_890> NM1Loop { get; set; }
        /// <summary>
        /// Loop for Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<Loop_AMT_890> AMTLoop { get; set; }
        /// <summary>
        /// Loop for Quantity Information
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<Loop_QTY_890> QTYLoop { get; set; }
        /// <summary>
        /// Loop for Loop Header
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual Loop_LS_890 LSLoop { get; set; }
        /// <summary>
        /// Loop for Program Information
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual List<Loop_CPL_890> CPLLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual SE SE { get; set; }
    }
}
