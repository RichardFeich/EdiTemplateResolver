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
    public class Loop_0100_107
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
        // Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(5)]
        public virtual List<PER> PER { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_0200_107
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
        // Geography
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(999)]
        [Pos(2)]
        public virtual List<GY> GY { get; set; }
        /// <summary>
        // Currency
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual CUR CUR { get; set; }
        /// <summary>
        // Product (Commodity)
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(4)]
        public virtual List<PR> PR { get; set; }
        /// <summary>
        // Load Details
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual ID4 ID4 { get; set; }
        /// <summary>
        // Bill of Lading Handling Requirements
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(6)]
        public virtual List<AT5> AT5 { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual Loop_MS2_107 LoopMS2 { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual Loop_N1_107 LoopN1 { get; set; }
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(9)]
        public virtual List<Loop_0230_107> Loop0230 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(CA1))]
    public class Loop_0230_107
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Rate Request Identifier
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CA1 CA1 { get; set; }
        /// <summary>
        // Geography
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(999)]
        [Pos(2)]
        public virtual List<GY> GY { get; set; }
        /// <summary>
        // Product (Commodity)
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(3)]
        public virtual List<PR> PR { get; set; }
        /// <summary>
        // Load Details
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual ID4 ID4 { get; set; }
        /// <summary>
        // Lane Estimates
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual IV1 IV1 { get; set; }
        /// <summary>
        // Service Description
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual SV SV { get; set; }
        /// <summary>
        // Bill of Lading Handling Requirements
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(7)]
        public virtual List<AT5> AT5 { get; set; }
        /// <summary>
        // Tariff Accessorial Charges
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(8)]
        public virtual List<MCT> MCT { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual Loop_MS2_107 LoopMS2 { get; set; }
        [DataMember]
        [Pos(10)]
        public virtual Loop_N1_107 LoopN1 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(MS2))]
    public class Loop_MS2_107
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
        // Trailer or Container Dimension and Weight
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual AT9 AT9 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_107
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
        [ListCount(10)]
        [Pos(5)]
        public virtual List<G62> G62 { get; set; }
    }

    /// <summary>
    // Request for Motor Carrier Rate Proposal
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "107")]
    public class TS107 : EdiMessage
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
        // Beginning Segment
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BGN BGN { get; set; }
        /// <summary>
        // Date/Time
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<G62> G62 { get; set; }
        /// <summary>
        // Bill of Lading Handling Requirements
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(4)]
        public virtual List<AT5> AT5 { get; set; }
        /// <summary>
        // Product (Commodity)
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(5)]
        public virtual List<PR> PR { get; set; }
        /// <summary>
        // Load Details
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual ID4 ID4 { get; set; }
        /// <summary>
        // Lane Estimates
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual IV1 IV1 { get; set; }
        /// <summary>
        // Mileage Source
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual MI1 MI1 { get; set; }
        /// <summary>
        // Currency
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual CUR CUR { get; set; }
        /// <summary>
        // Tariff Accessorial Charges
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(10)]
        public virtual List<MCT> MCT { get; set; }
        [DataMember]
        [Pos(11)]
        public virtual Loop_MS2_107 LoopMS2 { get; set; }
        [DataMember]
        [Required]
        [ListCount(10)]
        [Pos(12)]
        public virtual List<Loop_0100_107> Loop0100 { get; set; }
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(13)]
        public virtual List<Loop_0200_107> Loop0200 { get; set; }
        /// <summary>
        // Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(14)]
        public virtual SE SE { get; set; }
    }
}
