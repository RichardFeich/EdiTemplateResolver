namespace EdiFabric.Templates.X12003020
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
    /// Scale Rate Table
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "494")]
    public class TS494 : EdiMessage
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
        /// External Reference Identifier
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual PRI PRI { get; set; }
        /// <summary>
        /// Scale Rate Column ID
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual SRC SRC { get; set; }
        /// <summary>
        /// Scale Rate Detail
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(200)]
        [Pos(4)]
        public virtual List<SRD> SRD { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual SE SE { get; set; }
    }
}
