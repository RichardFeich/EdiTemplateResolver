namespace EdiFabric.Templates.X12006050
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
    [Group(typeof(MBL))]
    public class Loop_MBL_358
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Bill of Lading
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual MBL MBL { get; set; }
        /// <summary>
        // Manifest Amendment Details
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual M13 M13 { get; set; }
        /// <summary>
        // Export License
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual X1 X1 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_NM1_358
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NM1 NM1 { get; set; }
        /// <summary>
        // Demographic Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual DMG DMG { get; set; }
        /// <summary>
        // Additional Demographic Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual DMA DMA { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(4)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        // Party Location
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(5)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        // Geographic Location
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual N4 N4 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(P4))]
    public class Loop_P4_358
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
        [DataMember]
        [ListCount(9999)]
        [Pos(2)]
        public virtual List<Loop_VID_358> LoopVID { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(VID))]
    public class Loop_VID_358
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
        // Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(3)]
        public virtual List<N9> N9 { get; set; }
        [DataMember]
        [ListCount(9999)]
        [Pos(4)]
        public virtual List<Loop_MBL_358> LoopMBL { get; set; }
    }
    
    /// <summary>
    // Customs Consist Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "358")]
    public class TS358 : EdiMessage
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
        [Required]
        [Pos(2)]
        public virtual M10 M10 { get; set; }
        /// <summary>
        // Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        // Vehicle Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(4)]
        public virtual List<VEH> VEH { get; set; }
        /// <summary>
        // Seal Numbers
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual M7 M7 { get; set; }
        /// <summary>
        // Conveyance Insurance Information
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(6)]
        public virtual List<CII> CII { get; set; }
        [DataMember]
        [ListCount(999)]
        [Pos(7)]
        public virtual List<Loop_NM1_358> LoopNM1 { get; set; }
        [DataMember]
        [Required]
        [ListCount(20)]
        [Pos(8)]
        public virtual List<Loop_P4_358> LoopP4 { get; set; }
        /// <summary>
        // Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(9)]
        public virtual SE SE { get; set; }
    }
}
