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
    [Group(typeof(CF2))]
    public class Loop_0100_224
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Summary Freight Bill Detail
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CF2 CF2 { get; set; }
        /// <summary>
        // Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(2)]
        public virtual List<L11> L11 { get; set; }
    }

    /// <summary>
    // Motor Carrier Summary Freight Bill Manifest
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "224")]
    public class TS224 : EdiMessage
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
        // Beginning Segment for Summary Freight Bill Manifest
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual CF1 CF1 { get; set; }
        [DataMember]
        [Required]
        [ListCount(9999)]
        [Pos(3)]
        public virtual List<Loop_0100_224> Loop0100 { get; set; }
        /// <summary>
        // Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual SE SE { get; set; }
    }
}
