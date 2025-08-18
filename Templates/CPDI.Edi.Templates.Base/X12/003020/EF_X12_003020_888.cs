namespace EdiFabric.Templates.X12003020
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
    /// Loop for Item Characteristics - Vendor's Selling Unit
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(G39))]
    public class Loop_G39_888
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Item Characteristics - Vendor's Selling Unit
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual G39 G39 { get; set; }
        /// <summary>
        /// Line Item Detail - Description
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<G69> G69 { get; set; }
        /// <summary>
        /// Terms of Sale
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<G23> G23 { get; set; }
        /// <summary>
        /// Date/Time
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(4)]
        public virtual List<G62> G62 { get; set; }
        /// <summary>
        /// Price List Reference
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual G36 G36 { get; set; }
        /// <summary>
        /// Pricing Conditions
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(6)]
        public virtual List<G26> G26 { get; set; }
        /// <summary>
        /// Promotion/Price List Area
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(7)]
        public virtual List<G43> G43 { get; set; }
        /// <summary>
        /// Promotion Reference
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(8)]
        public virtual List<G24> G24 { get; set; }
        /// <summary>
        /// Bracket Price
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(9)]
        public virtual List<G40> G40 { get; set; }
        /// <summary>
        /// Price Bracket Identification
        /// </summary>
        [DataMember]
        [ListCount(50)]
        [Pos(10)]
        public virtual List<G93> G93 { get; set; }
        /// <summary>
        /// Promotion Allowance/Charge
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(11)]
        public virtual List<G46> G46 { get; set; }
        /// <summary>
        /// Module Description
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(12)]
        public virtual List<G54> G54 { get; set; }
        /// <summary>
        /// Loop for Item Characteristics - Consumer Unit
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(13)]
        public virtual List<Loop_G55_888> G55Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Maintenance Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(G53))]
    public class Loop_G53_888
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Maintenance Type
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual G53 G53 { get; set; }
        /// <summary>
        /// Date/Time
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(3)]
        [Pos(2)]
        public virtual List<G62> G62 { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(3)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Loop for Item Characteristics - Vendor's Selling Unit
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(9999)]
        [Pos(4)]
        public virtual List<Loop_G39_888> G39Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Item Characteristics - Consumer Unit
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(G55))]
    public class Loop_G55_888
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Item Characteristics - Consumer Unit
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual G55 G55 { get; set; }
        /// <summary>
        /// Line Item Detail - Description
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<G69> G69 { get; set; }
    }
    
    /// <summary>
    /// Loop for Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_888
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
        [Pos(2)]
        public virtual N2 N2 { get; set; }
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
    }
    
    /// <summary>
    /// Item Maintenance
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "888")]
    public class TS888 : EdiMessage
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
        /// Loop for Name
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(999)]
        [Pos(2)]
        public virtual List<Loop_N1_888> N1Loop { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(4)]
        public virtual List<G61> G61 { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(5)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Loop for Maintenance Type
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(999)]
        [Pos(6)]
        public virtual List<Loop_G53_888> G53Loop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual SE SE { get; set; }
    }
}
