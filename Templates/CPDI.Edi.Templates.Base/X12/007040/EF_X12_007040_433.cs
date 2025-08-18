namespace EdiFabric.Templates.X12007040
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
    public class Loop_N1_433
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
        // Station Codes Segment
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual SMS SMS { get; set; }
        /// <summary>
        // Shipment Conditions
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(160)]
        [Pos(3)]
        public virtual List<CD> CD { get; set; }
        /// <summary>
        // Price Authority Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual PI PI { get; set; }
        /// <summary>
        // Placement/Pull Data
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual XD XD { get; set; }
        [DataMember]
        [ListCount(200)]
        [Pos(6)]
        public virtual List<Loop_R2B_433> LoopR2B { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(R2B))]
    public class Loop_R2B_433
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Junctions and Proportions
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual R2B R2B { get; set; }
        /// <summary>
        // Switching Conditions
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual SWC SWC { get; set; }
        /// <summary>
        // Product (Commodity)
        /// </summary>
        [DataMember]
        [ListCount(200)]
        [Pos(3)]
        public virtual List<PR> PR { get; set; }
        /// <summary>
        // Switching Rates
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual SWR SWR { get; set; }
        /// <summary>
        // Currency
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual CUR CUR { get; set; }
        /// <summary>
        // Shipment Conditions
        /// </summary>
        [DataMember]
        [ListCount(160)]
        [Pos(6)]
        public virtual List<CD> CD { get; set; }
        /// <summary>
        // Placement/Pull Data
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(7)]
        public virtual List<XD> XD { get; set; }
    }

    /// <summary>
    // Railroad Reciprocal Switch File
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "433")]
    public class TS433 : EdiMessage
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
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        // Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        // Station Codes Segment
        /// </summary>
        [DataMember]
        [Required]
        [Pos(5)]
        public virtual SMS SMS { get; set; }
        /// <summary>
        // Shipment Conditions
        /// </summary>
        [DataMember]
        [ListCount(160)]
        [Pos(6)]
        public virtual List<CD> CD { get; set; }
        /// <summary>
        // Price Authority Identification
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual PI PI { get; set; }
        /// <summary>
        // Placement/Pull Data
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual XD XD { get; set; }
        [DataMember]
        [ListCount(200)]
        [Pos(9)]
        public virtual List<Loop_R2B_433> LoopR2B { get; set; }
        [DataMember]
        [ListCount(50)]
        [Pos(10)]
        public virtual List<Loop_N1_433> LoopN1 { get; set; }
        /// <summary>
        // Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(11)]
        public virtual SE SE { get; set; }
    }
}
