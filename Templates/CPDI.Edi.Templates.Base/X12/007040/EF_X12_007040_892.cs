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
    [Group(typeof(CRT))]
    public class Loop_CRT_892
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Contractor Report Type
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CRT CRT { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        // Performance Measures
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual PMP PMP { get; set; }
        /// <summary>
        // Measurements
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(4)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        // Service Level
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual SLV SLV { get; set; }
        /// <summary>
        // Delivery Parameter
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual DLP DLP { get; set; }
        /// <summary>
        // Forecast Parameters
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual FQR FQR { get; set; }
        /// <summary>
        // Inventory Parameters
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual IVT IVT { get; set; }
        /// <summary>
        // Sales Parameters
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual SLS SLS { get; set; }
        /// <summary>
        // Item Selection
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual ITS ITS { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual MTX MTX { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(12)]
        public virtual List<Loop_LSC_892> LoopLSC { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(LSC))]
    public class Loop_LSC_892
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Asset Item Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LSC LSC { get; set; }
        /// <summary>
        // Party Location
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N3 N3 { get; set; }
        /// <summary>
        // Geographic Location
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4 N4 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_892
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        // Additional Name Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<N2> N2 { get; set; }
        /// <summary>
        // Party Location
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        // Geographic Location
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        // Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(5)]
        public virtual List<PER> PER { get; set; }
    }
    
    /// <summary>
    // Trading Partner Performance Measurement
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "892")]
    public class TS892 : EdiMessage
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
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        // Communication Contact Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual COM COM { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual MTX MTX { get; set; }
        [DataMember]
        [Required]
        [ListCount(5)]
        [Pos(7)]
        public virtual List<Loop_N1_892> LoopN1 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(8)]
        public virtual List<Loop_CRT_892> LoopCRT { get; set; }
        /// <summary>
        // Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(9)]
        public virtual SE SE { get; set; }
    }
}
