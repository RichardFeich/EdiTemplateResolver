namespace EdiFabric.Templates.X12003060
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.X12;
    using System.Xml.Serialization;
    
    
    /// <summary>
    /// Railroad Parameter Trace Registration
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "455")]
    public class TS455 : EdiMessage
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
        /// Beginning Segment for Parameter Trace Registration
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BTC BTC { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual DTP DTP { get; set; }
        /// <summary>
        /// Basic Trace Parameters
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual PRM PRM { get; set; }
        /// <summary>
        /// Equipment Description
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual ED ED { get; set; }
        /// <summary>
        /// Transportation Carrier Identification
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(6)]
        public virtual List<BLR> BLR { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual N9 N9 { get; set; }
        /// <summary>
        /// Event Detail
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(8)]
        public virtual List<V9> V9 { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual SE SE { get; set; }
    }
}
