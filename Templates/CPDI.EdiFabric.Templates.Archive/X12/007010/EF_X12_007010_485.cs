namespace EdiFabric.Templates.X12007010
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
    [Group(typeof(SC))]
    public class Loop_0100_485
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Docket Sub-level
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SC SC { get; set; }
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<Loop_0110_485> Loop0110 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(RA))]
    public class Loop_0110_485
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Rate Header
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual RA RA { get; set; }
        /// <summary>
        // Factor
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<FK> FK { get; set; }
        [DataMember]
        [ListCount(64)]
        [Pos(3)]
        public virtual List<Loop_0111_485> Loop0111 { get; set; }
        /// <summary>
        // Switching Charges
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(4)]
        public virtual List<SW> SW { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(MC))]
    public class Loop_0111_485
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Miscellaneous and Accessorial Charges
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual MC MC { get; set; }
        /// <summary>
        // Factor
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<FK> FK { get; set; }
    }
    
    /// <summary>
    // Ratemaking Action
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "485")]
    public class TS485 : EdiMessage
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
        // Docket Header
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual DK DK { get; set; }
        /// <summary>
        // External Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual PRI PRI { get; set; }
        /// <summary>
        // Status Action
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual SA SA { get; set; }
        [DataMember]
        [ListCount(8)]
        [Pos(5)]
        public virtual List<Loop_0100_485> Loop0100 { get; set; }
        /// <summary>
        // Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(6)]
        public virtual SE SE { get; set; }
    }
}
