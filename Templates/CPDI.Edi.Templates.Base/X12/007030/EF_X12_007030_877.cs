namespace EdiFabric.Templates.X12007030
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
    [Group(typeof(ENT))]
    public class Loop_0100_877
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Entity
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ENT ENT { get; set; }
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<Loop_0110_877> Loop0110 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(LIN))]
    public class Loop_0110_877
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Item Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LIN LIN { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<Loop_0111_877> Loop0111 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(G28))]
    public class Loop_0111_877
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Line Item Numbers
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual G28 G28 { get; set; }
        /// <summary>
        // Line Item Detail - Description
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual G69 G69 { get; set; }
    }
    
    /// <summary>
    // Manufacturer Coupon Family Code Structure
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "877")]
    public class TS877 : EdiMessage
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
        // Beginning Segment
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BGN BGN { get; set; }
        /// <summary>
        // Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(3)]
        [Pos(3)]
        public virtual List<N1> N1 { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual DTM DTM { get; set; }
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<Loop_0100_877> Loop0100 { get; set; }
        /// <summary>
        // Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(6)]
        public virtual SE SE { get; set; }
    }
}
