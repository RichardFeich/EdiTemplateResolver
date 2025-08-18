namespace CPDI.EdiFabric.Templates.X12004010.Acme
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;


    /// <summary>
    /// Locomotive Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "436")]
    public class TS436 : EdiMessage
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
        /// Beginning Segment for Locomotive Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual LFI LFI { get; set; }
        /// <summary>
        /// Equipment Details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual N7 N7 { get; set; }
        /// <summary>
        /// File Information
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(4)]
        public virtual List<K3> K3 { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual SE SE { get; set; }
    }
}
