namespace CPDI.EdiFabric.Templates.Base.X12004030
{
    using System;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;


    /// <summary>
    /// Response to a Load Tender
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "990")]
    public class TS990 : EdiMessage, ITS990
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
        /// Beginning Segment for Booking or Pick-up/Delivery
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual B1 B1 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N9 N9 { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual SE SE { get; set; }
    }
}

