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
    /// Loop for Loop Header
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LS))]
    public class Loop_LS_820
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
        /// Loop for Name
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(10000)]
        [Pos(2)]
        public virtual List<Loop_N1_820_2> N1Loop { get; set; }
        /// <summary>
        /// Loop Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual LE LE { get; set; }
    }
    
    /// <summary>
    /// Loop for Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_820
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
    /// Loop for Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_820_2
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
        /// Loop for Remittance Advice
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(10000)]
        [Pos(2)]
        public virtual List<Loop_RMT_820> RMTLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Remittance Advice
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(RMT))]
    public class Loop_RMT_820
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Remittance Advice
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual RMT RMT { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual CUR CUR { get; set; }
        /// <summary>
        /// Reference Numbers
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(4)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Payment Order/Remittance Advice
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "820")]
    public class TS820 : EdiMessage
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
        /// Beginning Segment for Payment Order/Remittance Advice
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BPS BPS { get; set; }
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
        [Required]
        [ListCount(5)]
        [Pos(5)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(10)]
        [Pos(6)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Loop for Name
        /// </summary>
        [DataMember]
        [ListCount(200)]
        [Pos(7)]
        public virtual List<Loop_N1_820> N1Loop { get; set; }
        /// <summary>
        /// Loop for Loop Header
        /// </summary>
        [DataMember]
        [Required]
        [Pos(8)]
        public virtual Loop_LS_820 LSLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual SE SE { get; set; }
    }
}
