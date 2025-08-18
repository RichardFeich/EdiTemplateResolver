namespace EdiFabric.Templates.X12003030
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
    /// Loop for Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_867
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
    /// Loop for Product Transfer and Resale Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PTD))]
    public class Loop_PTD_867
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Product Transfer and Resale Detail
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PTD PTD { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Reference Numbers
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(3)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Purchase Order Reference
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual PRF PRF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(5)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Loop for Name
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(6)]
        public virtual List<Loop_N1_867> N1Loop { get; set; }
        /// <summary>
        /// Loop for Quantity
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<Loop_QTY_867> QTYLoop { get; set; }
        /// <summary>
        /// Marks and Numbers
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual MAN MAN { get; set; }
    }
    
    /// <summary>
    /// Loop for Quantity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(QTY))]
    public class Loop_QTY_867
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual QTY QTY { get; set; }
        /// <summary>
        /// Item Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual LIN LIN { get; set; }
        /// <summary>
        /// Unit Detail
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(3)]
        public virtual List<UIT> UIT { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(4)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        /// Allowance, Charge or Service
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<ITA> ITA { get; set; }
        /// <summary>
        /// Product/Item Description
        /// </summary>
        [DataMember]
        [ListCount(200)]
        [Pos(6)]
        public virtual List<PID> PID { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [ListCount(40)]
        [Pos(7)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// Paperwork
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(8)]
        public virtual List<PWK> PWK { get; set; }
        /// <summary>
        /// Marking, Packaging, Loading
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(9)]
        public virtual List<PKG> PKG { get; set; }
        /// <summary>
        /// Reference Numbers
        /// </summary>
        [DataMember]
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
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(12)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Currency
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual CUR CUR { get; set; }
    }
    
    /// <summary>
    /// Product Transfer and Resale Report
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "867")]
    public class TS867 : EdiMessage
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
        /// Beginning Segment for Product Transfer and Resale
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BPT BPT { get; set; }
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
        /// Loop for Name
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(7)]
        public virtual List<Loop_N1_867> N1Loop { get; set; }
        /// <summary>
        /// Loop for Product Transfer and Resale Detail
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(10000)]
        [Pos(8)]
        public virtual List<Loop_PTD_867> PTDLoop { get; set; }
        /// <summary>
        /// Transaction Totals
        /// </summary>
        [DataMember]
        [Required]
        [Pos(9)]
        public virtual CTT CTT { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(10)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        /// Allowance, Charge or Service
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(11)]
        public virtual List<ITA> ITA { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual SE SE { get; set; }
    }
}
