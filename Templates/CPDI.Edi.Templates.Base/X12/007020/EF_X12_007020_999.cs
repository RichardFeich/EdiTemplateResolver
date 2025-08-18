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
    [Group(typeof(AK2))]
    public class Loop_AK2_999
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Transaction Set Response Header
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual AK2 AK2 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<Loop_IK3_999> LoopIK3 { get; set; }
        /// <summary>
        // Implementation Transaction Set Response Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual IK5 IK5 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(IK3))]
    public class Loop_IK3_999
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Implementation Data Segment Note
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual IK3 IK3 { get; set; }
        /// <summary>
        // Context
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<CTX> CTX { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<Loop_IK4_999> LoopIK4 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(IK4))]
    public class Loop_IK4_999
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Implementation Data Element Note
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual IK4 IK4 { get; set; }
        /// <summary>
        // Context
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<CTX> CTX { get; set; }
    }
    
    /// <summary>
    // Implementation Acknowledgment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "999")]
    public class TS999 : EdiMessage
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
        // Functional Group Response Header
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual AK1 AK1 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<Loop_AK2_999> LoopAK2 { get; set; }
        /// <summary>
        // Functional Group Response Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual AK9 AK9 { get; set; }
        /// <summary>
        // Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(5)]
        public virtual SE SE { get; set; }
    }
}
