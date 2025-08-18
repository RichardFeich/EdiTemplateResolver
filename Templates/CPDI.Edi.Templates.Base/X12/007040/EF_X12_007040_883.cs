namespace EdiFabric.Templates.X12007040
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
    [Group(typeof(LIN))]
    public class Loop_0100_883
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Item Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LIN LIN { get; set; }
        [DataMember]
        [Required]
        [ListCount(99)]
        [Pos(2)]
        public virtual List<Loop_0110_883> Loop0110 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(UIT))]
    public class Loop_0110_883
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Unit Detail
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual UIT UIT { get; set; }
        /// <summary>
        // Quantity Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        // Date/Time
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<G62> G62 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_0200_883
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
        // Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual AMT AMT { get; set; }
        /// <summary>
        // Date/Time
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<G62> G62 { get; set; }
        /// <summary>
        // Performance Requirements
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<G95> G95 { get; set; }
        [DataMember]
        [ListCount(9999)]
        [Pos(5)]
        public virtual List<Loop_0210_883> Loop0210 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(LIN))]
    public class Loop_0210_883
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Item Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LIN LIN { get; set; }
        /// <summary>
        // Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual AMT AMT { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_0300_883
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
        // Item Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual LIN LIN { get; set; }
        /// <summary>
        // Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual AMT AMT { get; set; }
        [DataMember]
        [ListCount(999)]
        [Pos(4)]
        public virtual List<Loop_0310_883> Loop0310 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_0310_883
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
        // Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual AMT AMT { get; set; }
        /// <summary>
        // Date/Time
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<G62> G62 { get; set; }
    }
    
    /// <summary>
    // Market Development Fund Allocation
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "883")]
    public class TS883 : EdiMessage
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
        // Beginning Segment for Market Development Fund Allocation
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BMA BMA { get; set; }
        /// <summary>
        // Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<N1> N1 { get; set; }
        /// <summary>
        // Date/Time
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual G62 G62 { get; set; }
        /// <summary>
        // Promotion/Price List Area
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(5)]
        public virtual List<G43> G43 { get; set; }
        /// <summary>
        // Performance Requirements
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(6)]
        public virtual List<G95> G95 { get; set; }
        /// <summary>
        // Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(7)]
        public virtual List<G61> G61 { get; set; }
        [DataMember]
        [ListCount(9999)]
        [Pos(8)]
        public virtual List<Loop_0100_883> Loop0100 { get; set; }
        [DataMember]
        [ListCount(999)]
        [Pos(9)]
        public virtual List<Loop_0200_883> Loop0200 { get; set; }
        [DataMember]
        [ListCount(9999)]
        [Pos(10)]
        public virtual List<Loop_0300_883> Loop0300 { get; set; }
        /// <summary>
        // Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(11)]
        public virtual SE SE { get; set; }
    }
}
