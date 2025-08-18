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
    public class Loop_0100_875
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
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(G72))]
    public class Loop_0200_875
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Allowance or Charge
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual G72 G72 { get; set; }
        /// <summary>
        // Allowance or Charge Description
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<G73> G73 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(G68))]
    public class Loop_0300_875
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Line Item Detail - Product
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual G68 G68 { get; set; }
        /// <summary>
        // Line Item Detail - Description
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<G69> G69 { get; set; }
        /// <summary>
        // Line Item Detail - Miscellaneous
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<G70> G70 { get; set; }
        /// <summary>
        // Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        // Terms of Sale
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(5)]
        public virtual List<G23> G23 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<Loop_0310_875> Loop0310 { get; set; }
        [DataMember]
        [ListCount(9999)]
        [Pos(7)]
        public virtual List<Loop_0320_875> Loop0320 { get; set; }
        [DataMember]
        [ListCount(100)]
        [Pos(8)]
        public virtual List<Loop_0330_875> Loop0330 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(G72))]
    public class Loop_0310_875
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Allowance or Charge
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual G72 G72 { get; set; }
        /// <summary>
        // Allowance or Charge Description
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<G73> G73 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_0320_875
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
        // Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<N9> N9 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(SLN))]
    public class Loop_0330_875
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Subline Item Detail
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SLN SLN { get; set; }
        /// <summary>
        // Allowance or Charge
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<G72> G72 { get; set; }
    }
    
    /// <summary>
    // Grocery Products Purchase Order
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "875")]
    public class TS875 : EdiMessage
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
        // Purchase Order Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual G50 G50 { get; set; }
        /// <summary>
        // Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        // Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(4)]
        public virtual List<G61> G61 { get; set; }
        /// <summary>
        // Date/Time
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<G62> G62 { get; set; }
        /// <summary>
        // Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(6)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        // Transportation Instructions
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual G66 G66 { get; set; }
        /// <summary>
        // Terms of Sale
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(8)]
        public virtual List<G23> G23 { get; set; }
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(9)]
        public virtual List<Loop_0100_875> Loop0100 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(10)]
        public virtual List<Loop_0200_875> Loop0200 { get; set; }
        [DataMember]
        [Required]
        [ListCount(9999)]
        [Pos(11)]
        public virtual List<Loop_0300_875> Loop0300 { get; set; }
        /// <summary>
        // Total Purchase Order
        /// </summary>
        [DataMember]
        [Required]
        [Pos(12)]
        public virtual G76 G76 { get; set; }
        /// <summary>
        // Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(13)]
        public virtual SE SE { get; set; }
    }
}
