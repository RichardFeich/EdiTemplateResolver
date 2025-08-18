namespace EdiFabric.Templates.X12007040
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
    [Group(typeof(BA1))]
    public class Loop_BA1_350
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Export Shipment Identifying Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual BA1 BA1 { get; set; }
        [DataMember]
        [ListCount(9999)]
        [Pos(2)]
        public virtual List<Loop_X4_350> LoopX4 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(P4))]
    public class Loop_P4_350
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Port Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual P4 P4 { get; set; }
        /// <summary>
        // Event Detail
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(2)]
        public virtual List<V9> V9 { get; set; }
        /// <summary>
        // Vehicle Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<VEH> VEH { get; set; }
        /// <summary>
        // Individual or Organizational Name
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(4)]
        public virtual List<NM1> NM1 { get; set; }
        [DataMember]
        [ListCount(9999)]
        [Pos(5)]
        public virtual List<Loop_VID_350> LoopVID { get; set; }
        /// <summary>
        // Remarks
        /// </summary>
        [DataMember]
        [ListCount(4)]
        [Pos(6)]
        public virtual List<K1> K1 { get; set; }
        [DataMember]
        [ListCount(9999)]
        [Pos(7)]
        public virtual List<Loop_X4_350_2> LoopX4 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(VID))]
    public class Loop_VID_350
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Conveyance Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual VID VID { get; set; }
        /// <summary>
        // Seal Numbers
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<M7> M7 { get; set; }
        /// <summary>
        // Seal Number Replacement
        /// </summary>
        [DataMember]
        [ListCount(22)]
        [Pos(3)]
        public virtual List<M7A> M7A { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(X4))]
    public class Loop_X4_350
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Customs Release Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual X4 X4 { get; set; }
        /// <summary>
        // Remarks
        /// </summary>
        [DataMember]
        [ListCount(4)]
        [Pos(2)]
        public virtual List<K1> K1 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(X4))]
    public class Loop_X4_350_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Customs Release Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual X4 X4 { get; set; }
        /// <summary>
        // Remarks
        /// </summary>
        [DataMember]
        [ListCount(4)]
        [Pos(2)]
        public virtual List<K1> K1 { get; set; }
        /// <summary>
        // Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(3)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        // Equipment Details
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(4)]
        public virtual List<N7> N7 { get; set; }
    }
    
    /// <summary>
    // Customs Status Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "350")]
    public class TS350 : EdiMessage
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
        // Manifest Identifying Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual M10 M10 { get; set; }
        [DataMember]
        [ListCount(20)]
        [Pos(3)]
        public virtual List<Loop_P4_350> LoopP4 { get; set; }
        [DataMember]
        [ListCount(999)]
        [Pos(4)]
        public virtual List<Loop_BA1_350> LoopBA1 { get; set; }
        /// <summary>
        // Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(5)]
        public virtual SE SE { get; set; }
    }
}
