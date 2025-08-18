namespace EdiFabric.Templates.X12007030
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
    public class Loop_N1_412
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
        [Pos(3)]
        public virtual N3 N3 { get; set; }
        /// <summary>
        // Geographic Location
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        // Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual PER PER { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_412_2
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
        // Party Location
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N3 N3 { get; set; }
        /// <summary>
        // Geographic Location
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4 N4 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(R12))]
    public class Loop_R12_412
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Work Order Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual R12 R12 { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        // Monetary Amount Information
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(6)]
        [Pos(3)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(15)]
        [Pos(4)]
        public virtual List<REF> REF { get; set; }
        [DataMember]
        [Required]
        [ListCount(4)]
        [Pos(5)]
        public virtual List<Loop_N1_412_2> LoopN1 { get; set; }
        [DataMember]
        [Required]
        [ListCount(50)]
        [Pos(6)]
        public virtual List<Loop_R13_412> LoopR13 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(R13))]
    public class Loop_R13_412
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Line Item Repair
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual R13 R13 { get; set; }
        /// <summary>
        // Baseline Item Data (Invoice)
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<IT1> IT1 { get; set; }
        /// <summary>
        // Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<III> III { get; set; }
        /// <summary>
        // Measurements
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(4)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        // Monetary Amount Information
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(10)]
        [Pos(6)]
        public virtual List<AMT> AMT { get; set; }
    }

    /// <summary>
    // Trailer or Container Repair Billing
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "412")]
    public class TS412 : EdiMessage
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
        // Beginning Segment for Trailer or Container Repair Billing
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual R11 R11 { get; set; }
        /// <summary>
        // Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        // Currency
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual CUR CUR { get; set; }
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<Loop_N1_412> LoopN1 { get; set; }
        [DataMember]
        [Required]
        [ListCount(9999)]
        [Pos(6)]
        public virtual List<Loop_R12_412> LoopR12 { get; set; }
        /// <summary>
        // Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(7)]
        public virtual SE SE { get; set; }
    }
}
