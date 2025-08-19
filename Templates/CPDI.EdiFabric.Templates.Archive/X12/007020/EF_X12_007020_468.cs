namespace EdiFabric.Templates.X12007020
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.X12;
    using System.Xml.Serialization;
    
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(DK))]
    public class Loop_0100_468
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Docket Header
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual DK DK { get; set; }
        /// <summary>
        // Price Authority Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual PI PI { get; set; }
        /// <summary>
        // Journal Identification
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual JL JL { get; set; }
        /// <summary>
        // Remarks
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(100)]
        [Pos(4)]
        public virtual List<K1> K1 { get; set; }
    }
    
    /// <summary>
    // Rate Docket Journal Log
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "468")]
    public class TS468 : EdiMessage
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
        // Rate Request Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual REN REN { get; set; }
        [DataMember]
        [Required]
        [ListCount(100)]
        [Pos(3)]
        public virtual List<Loop_0100_468> Loop0100 { get; set; }
        /// <summary>
        // Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual SE SE { get; set; }
    }
}
