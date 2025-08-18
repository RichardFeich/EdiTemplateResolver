namespace EdiFabric.Templates.X12006040
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
    [Group(typeof(LX))]
    public class Loop_0200_212
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
        // Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [ListCount(300)]
        [Pos(2)]
        public virtual List<L11> L11 { get; set; }
        /// <summary>
        // Shipment Status Details
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual AT7 AT7 { get; set; }
        /// <summary>
        // Transportation Carrier Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual BLR BLR { get; set; }
        /// <summary>
        // Marks and Numbers Information
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(5)]
        public virtual List<MAN> MAN { get; set; }
        /// <summary>
        // Shipment Weight
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual AT8 AT8 { get; set; }
        /// <summary>
        // Lading Exception Status
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(7)]
        public virtual List<Q7> Q7 { get; set; }
        /// <summary>
        // Date/Time
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(8)]
        public virtual List<G62> G62 { get; set; }
        /// <summary>
        // Trailer Shipment Details
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual TSD TSD { get; set; }
        [DataMember]
        [ListCount(999999)]
        [Pos(10)]
        public virtual List<Loop_0210_212> Loop0210 { get; set; }
        [DataMember]
        [Pos(11)]
        public virtual Loop_N1_212_2 LoopN1 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(OID))]
    public class Loop_0210_212
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Order Information Detail
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual OID OID { get; set; }
        /// <summary>
        // Destination Quantity
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(2)]
        public virtual List<SDQ> SDQ { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(AT7))]
    public class Loop_AT7_212
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Shipment Status Details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual AT7 AT7 { get; set; }
        /// <summary>
        // Date/Time
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<G62> G62 { get; set; }
        /// <summary>
        // Equipment
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual MS1 MS1 { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual Loop_MS2_212 LoopMS2 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(MS2))]
    public class Loop_MS2_212
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Equipment or Container Owner and Type
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual MS2 MS2 { get; set; }
        /// <summary>
        // Seal Numbers
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual M7 M7 { get; set; }
        /// <summary>
        // Trailer or Container Dimension and Weight
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual AT9 AT9 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_212
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
        // Contact
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual G61 G61 { get; set; }
        /// <summary>
        // Date/Time
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual G62 G62 { get; set; }
        /// <summary>
        // Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(7)]
        public virtual List<L11> L11 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_212_2
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
        // Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(5)]
        public virtual List<L11> L11 { get; set; }
    }

    /// <summary>
    // Motor Carrier Delivery Trailer Manifest
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "212")]
    public class TS212 : EdiMessage
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
        // Beginning Segment for Motor Carrier Delivery Trailer Manifest
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual ATA ATA { get; set; }
        /// <summary>
        // Set Purpose
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual B2A B2A { get; set; }
        /// <summary>
        // Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [ListCount(300)]
        [Pos(4)]
        public virtual List<L11> L11 { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual Loop_N1_212 LoopN1 { get; set; }
        [DataMember]
        [Required]
        [Pos(6)]
        public virtual Loop_AT7_212 LoopAT7 { get; set; }
        [DataMember]
        [ListCount(9999)]
        [Pos(7)]
        public virtual List<Loop_0200_212> Loop0200 { get; set; }
        /// <summary>
        // Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(8)]
        public virtual SE SE { get; set; }
    }
}
