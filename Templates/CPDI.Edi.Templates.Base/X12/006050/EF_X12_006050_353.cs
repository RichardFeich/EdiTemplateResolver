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
    [Group(typeof(M15))]
    public class Loop_M15_353
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Customs Events Advisory Details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual M15 M15 { get; set; }
        /// <summary>
        // Seal Number Replacement
        /// </summary>
        [DataMember]
        [ListCount(22)]
        [Pos(2)]
        public virtual List<M7A> M7A { get; set; }
        /// <summary>
        // Vessel Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual V1 V1 { get; set; }
        /// <summary>
        // Vessel Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual V2 V2 { get; set; }
        /// <summary>
        // Measurements
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual MEA MEA { get; set; }
        /// <summary>
        // Remarks
        /// </summary>
        [DataMember]
        [ListCount(4)]
        [Pos(6)]
        public virtual List<K1> K1 { get; set; }
    }

    /// <summary>
    // Customs Events Advisory Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "353")]
    public class TS353 : EdiMessage
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
        // Manifest Identifying Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual M10 M10 { get; set; }
        /// <summary>
        // Port Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual P4 P4 { get; set; }
        /// <summary>
        // Cargo Manifest
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual CM CM { get; set; }
        [DataMember]
        [Required]
        [ListCount(9999)]
        [Pos(5)]
        public virtual List<Loop_M15_353> LoopM15 { get; set; }
        /// <summary>
        // Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(6)]
        public virtual SE SE { get; set; }
    }
}
