namespace CPDI.EdiFabric.Templates.Base.X12005010
{
    using System;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;


    /// <summary>
    /// Set Cancellation
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "998")]
    public class TS998 : EdiMessage, ITS998
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
        /// Transaction Set Deletion - ID, Reason, and Source
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual ZD ZD { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual SE SE { get; set; }
    }
}

