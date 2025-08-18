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
    [Group(typeof(CAL))]
    public class Loop_CAL_806
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Calendar
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CAL CAL { get; set; }
        /// <summary>
        // Quantity Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(MLS))]
    public class Loop_MLS_806
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Milestone
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual MLS MLS { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
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
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        // Monetary Amount Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        // Percent Amounts
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<PCT> PCT { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(MTX))]
    public class Loop_MTX_806
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual MTX MTX { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        // Individual or Organizational Name
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<NM1> NM1 { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<REF> REF { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_806
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
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        // Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(RSC))]
    public class Loop_RSC_806
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Resource
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual RSC RSC { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
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
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        // Monetary Amount Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        // Percent Amounts
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<PCT> PCT { get; set; }
        /// <summary>
        // Rate Amounts or Percents
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<RPA> RPA { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(RSC))]
    public class Loop_RSC_806_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Resource
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual RSC RSC { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
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
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        // Monetary Amount Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        // Percent Amounts
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<PCT> PCT { get; set; }
        /// <summary>
        // Rate Amounts or Percents
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<RPA> RPA { get; set; }
        /// <summary>
        // Period Amount
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(8)]
        public virtual List<PAM> PAM { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(TID))]
    public class Loop_TID_806
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Task Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual TID TID { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
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
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        // Monetary Amount Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        // Percent Amounts
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<PCT> PCT { get; set; }
        /// <summary>
        // Party Identification
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<N1> N1 { get; set; }
        /// <summary>
        // Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(8)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        // Product/Item Description
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(9)]
        public virtual List<PID> PID { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(10)]
        public virtual List<Loop_MTX_806> LoopMTX { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(11)]
        public virtual List<Loop_RSC_806_2> LoopRSC { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(12)]
        public virtual List<Loop_MLS_806> LoopMLS { get; set; }
    }
    
    /// <summary>
    // Project Schedule Reporting
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "806")]
    public class TS806 : EdiMessage
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
        // Beginning Segment for Project Schedule Reporting
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BPP BPP { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<REF> REF { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<Loop_N1_806> LoopN1 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<Loop_CAL_806> LoopCAL { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<Loop_RSC_806> LoopRSC { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<Loop_TID_806> LoopTID { get; set; }
        /// <summary>
        // Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(8)]
        public virtual SE SE { get; set; }
    }
}
