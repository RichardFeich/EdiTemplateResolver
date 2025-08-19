namespace EdiFabric.Templates.X12006050
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
    public class Loop_0100_889
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
        // Date/Time
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<G62> G62 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(G94))]
    public class Loop_0200_889
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Promotion Conditions
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual G94 G94 { get; set; }
        /// <summary>
        // Performance Requirements
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(2)]
        public virtual List<G95> G95 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_0300_889
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
        // Promotion Allowance/Charge
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(2)]
        public virtual List<G46> G46 { get; set; }
        /// <summary>
        // Free Goods/Product Condition
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual G51 G51 { get; set; }
        [DataMember]
        [ListCount(20)]
        [Pos(4)]
        public virtual List<Loop_0310_889> Loop0310 { get; set; }
        [DataMember]
        [ListCount(9999)]
        [Pos(5)]
        public virtual List<Loop_0320_889> Loop0320 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(G94))]
    public class Loop_0310_889
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Promotion Conditions
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual G94 G94 { get; set; }
        [DataMember]
        [ListCount(99)]
        [Pos(2)]
        public virtual List<Loop_0311_889> Loop0311 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(G95))]
    public class Loop_0311_889
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Performance Requirements
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual G95 G95 { get; set; }
        /// <summary>
        // Date/Time
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<G62> G62 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(G45))]
    public class Loop_0320_889
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Line Item Detail - Promotion
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual G45 G45 { get; set; }
        /// <summary>
        // Line Item Detail - Description
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<G69> G69 { get; set; }
        /// <summary>
        // Promotion/Price List Area
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(3)]
        public virtual List<G43> G43 { get; set; }
        /// <summary>
        // Free Goods/Product Condition
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(4)]
        public virtual List<G51> G51 { get; set; }
        /// <summary>
        // Terms of Sale
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual G23 G23 { get; set; }
        /// <summary>
        // Date/Time
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(6)]
        public virtual List<G62> G62 { get; set; }
        /// <summary>
        // Pre-Pricing Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual G22 G22 { get; set; }
        /// <summary>
        // Quantity Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(8)]
        public virtual List<QTY> QTY { get; set; }
    }
    
    /// <summary>
    // Promotion Announcement
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "889")]
    public class TS889 : EdiMessage
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
        // Promotion Announcement Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual G42 G42 { get; set; }
        /// <summary>
        // Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        // Contact
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<G61> G61 { get; set; }
        /// <summary>
        // Date/Time
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(50)]
        [Pos(5)]
        public virtual List<G62> G62 { get; set; }
        /// <summary>
        // Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(300)]
        [Pos(6)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        // Promotion/Price List Area
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(7)]
        public virtual List<G43> G43 { get; set; }
        /// <summary>
        // Terms of Sale
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual G23 G23 { get; set; }
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(9)]
        public virtual List<Loop_0100_889> Loop0100 { get; set; }
        [DataMember]
        [ListCount(20)]
        [Pos(10)]
        public virtual List<Loop_0200_889> Loop0200 { get; set; }
        [DataMember]
        [ListCount(9999)]
        [Pos(11)]
        public virtual List<Loop_0300_889> Loop0300 { get; set; }
        /// <summary>
        // Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(12)]
        public virtual SE SE { get; set; }
    }
}
