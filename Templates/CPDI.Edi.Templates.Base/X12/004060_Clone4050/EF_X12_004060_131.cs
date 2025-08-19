namespace CPDI.EdiFabric.Templates.Base.X12004060
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;


    /// <summary>
    /// Student Educational Record (Transcript) Acknowledgment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "131")]
    public class TS131 : EdiMessage, ITS131
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
        /// Beginning Segment
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BGN BGN { get; set; }
        /// <summary>
        /// Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<N1> N1 { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(2)]
        [Pos(4)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Quantity Information
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(2)]
        [Pos(5)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Academic Summary
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual SUM SUM { get; set; }
        /// <summary>
        /// Individual Name Structure Components
        /// </summary>
        [DataMember]
        [Required]
        [Pos(7)]
        public virtual IN2 IN2 { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual SE SE { get; set; }
    }
}

