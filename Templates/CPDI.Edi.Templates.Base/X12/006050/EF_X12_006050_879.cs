namespace EdiFabric.Templates.X12006050
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
    [Group(typeof(N1))]
    public class Loop_0100_879
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
    [Group(typeof(G28))]
    public class Loop_0200_879
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Line Item Numbers
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual G28 G28 { get; set; }
        /// <summary>
        // Item Packing Detail
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual G20 G20 { get; set; }
        /// <summary>
        // Line Item Detail - Description
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<G69> G69 { get; set; }
        /// <summary>
        // Pricing Conditions
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(4)]
        public virtual List<G26> G26 { get; set; }
        /// <summary>
        // Promotion/Price List Area
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(5)]
        public virtual List<G43> G43 { get; set; }
        /// <summary>
        // Date/Time
        /// </summary>
        [DataMember]
        [ListCount(4)]
        [Pos(6)]
        public virtual List<G62> G62 { get; set; }
        /// <summary>
        // Promotion Allowance/Charge
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(7)]
        public virtual List<G46> G46 { get; set; }
        /// <summary>
        // Pre-Pricing Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual G22 G22 { get; set; }
        /// <summary>
        // Service
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(9)]
        public virtual List<SAC> SAC { get; set; }
        [DataMember]
        [ListCount(100)]
        [Pos(10)]
        public virtual List<Loop_0210_879> Loop0210 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(G40))]
    public class Loop_0210_879
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Bracket Price
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual G40 G40 { get; set; }
        /// <summary>
        // Promotion Allowance/Charge
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(2)]
        public virtual List<G46> G46 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(G93))]
    public class Loop_G93_879
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Price Bracket Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual G93 G93 { get; set; }
        /// <summary>
        // Party Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        // Promotion Allowance/Charge
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual G46 G46 { get; set; }
        /// <summary>
        // Pricing Conditions
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<G26> G26 { get; set; }
    }

    /// <summary>
    // Price Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "879")]
    public class TS879 : EdiMessage
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
        // Price Change Status
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual G91 G91 { get; set; }
        [DataMember]
        [Required]
        [ListCount(999)]
        [Pos(3)]
        public virtual List<Loop_0100_879> Loop0100 { get; set; }
        /// <summary>
        // Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(4)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        // Contact
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<G61> G61 { get; set; }
        /// <summary>
        // Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(6)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        // Price List Reference
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual G36 G36 { get; set; }
        /// <summary>
        // Pricing Conditions
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(8)]
        public virtual List<G26> G26 { get; set; }
        /// <summary>
        // Promotion/Price List Area
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(9)]
        public virtual List<G43> G43 { get; set; }
        /// <summary>
        // Date/Time
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(10)]
        [Pos(10)]
        public virtual List<G62> G62 { get; set; }
        /// <summary>
        // Promotion Allowance/Charge
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(11)]
        public virtual List<G46> G46 { get; set; }
        [DataMember]
        [ListCount(50)]
        [Pos(12)]
        public virtual List<Loop_G93_879> LoopG93 { get; set; }
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(13)]
        public virtual List<Loop_0200_879> Loop0200 { get; set; }
        /// <summary>
        // Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(14)]
        public virtual SE SE { get; set; }
    }
}
