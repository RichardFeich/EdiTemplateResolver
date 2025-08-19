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
    [Group(typeof(G83))]
    public class Loop_0100_894
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Line Item Detail/Direct Store Delivery
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual G83 G83 { get; set; }
        /// <summary>
        // Subline Item Detail
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual SLN SLN { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<MTX> MTX { get; set; }
        /// <summary>
        // Pre-Pricing Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual G22 G22 { get; set; }
        /// <summary>
        // Allowance or Charge
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<G72> G72 { get; set; }
        /// <summary>
        // Terms of Sale
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(6)]
        public virtual List<G23> G23 { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(7)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        // Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(8)]
        public virtual List<N9> N9 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(LS))]
    public class Loop_LS_894
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
        [ListCount(9999)]
        [Pos(2)]
        public virtual List<Loop_0100_894> Loop0100 { get; set; }
        /// <summary>
        // Loop Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual LE LE { get; set; }
    }
    
    /// <summary>
    // Delivery/Return Base Record
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "894")]
    public class TS894 : EdiMessage
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
        // Delivery/Return Base Record Identifier
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual G82 G82 { get; set; }
        /// <summary>
        // Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<MTX> MTX { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual Loop_LS_894 LoopLS { get; set; }
        /// <summary>
        // Allowance or Charge
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(6)]
        public virtual List<G72> G72 { get; set; }
        /// <summary>
        // Terms of Sale
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(7)]
        public virtual List<G23> G23 { get; set; }
        /// <summary>
        // Delivery/Return Record of Totals
        /// </summary>
        [DataMember]
        [Required]
        [Pos(8)]
        public virtual G84 G84 { get; set; }
        /// <summary>
        // Signature Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(9)]
        public virtual G86 G86 { get; set; }
        /// <summary>
        // Record Integrity Check
        /// </summary>
        [DataMember]
        [Required]
        [Pos(10)]
        public virtual G85 G85 { get; set; }
        /// <summary>
        // Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(11)]
        public virtual SE SE { get; set; }
    }
}
