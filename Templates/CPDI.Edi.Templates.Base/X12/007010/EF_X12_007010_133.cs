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
    [Group(typeof(ATV))]
    public class Loop_ATV_133
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Student Activities and Awards
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ATV ATV { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(ENM))]
    public class Loop_ENM_133
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // School Enrollment Data
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ENM ENM { get; set; }
        /// <summary>
        // Field of Study
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual FOS FOS { get; set; }
        /// <summary>
        // Quantity Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        // Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<NTE> NTE { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(FOS))]
    public class Loop_FOS_133
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Field of Study
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual FOS FOS { get; set; }
        /// <summary>
        // Degree Record
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual DEG DEG { get; set; }
        /// <summary>
        // Monetary Amount Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<AMT> AMT { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(HL))]
    public class Loop_HL_133
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Hierarchical Level
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual HL HL { get; set; }
        /// <summary>
        // School Type
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<SCT> SCT { get; set; }
        /// <summary>
        // Placement Criteria
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<OPX> OPX { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        // Degree Record
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<DEG> DEG { get; set; }
        /// <summary>
        // Institutional Staff Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<ISI> ISI { get; set; }
        /// <summary>
        // Industry Code Identification
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<LQ> LQ { get; set; }
        /// <summary>
        // Educational Fee Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(8)]
        public virtual List<EDF> EDF { get; set; }
        /// <summary>
        // Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(9)]
        public virtual List<DTP> DTP { get; set; }
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(10)]
        public virtual List<Loop_N1_133> LoopN1 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(11)]
        public virtual List<Loop_YNQ_133> LoopYNQ { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(12)]
        public virtual List<Loop_FOS_133> LoopFOS { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(13)]
        public virtual List<Loop_SP_133> LoopSP { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(14)]
        public virtual List<Loop_SLA_133> LoopSLA { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(15)]
        public virtual List<Loop_ENM_133> LoopENM { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(16)]
        public virtual List<Loop_ATV_133> LoopATV { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_133
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
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        // Communication Contact Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<COM> COM { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_133_3
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
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(SLA))]
    public class Loop_SLA_133
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // School Accreditation and Licensing
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SLA SLA { get; set; }
        /// <summary>
        // Field of Study
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<FOS> FOS { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<REF> REF { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual Loop_N1_133_3 LoopN1 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(SP))]
    public class Loop_SP_133
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Special Program
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SP SP { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        // Individual or Organizational Name
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<NM1> NM1 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(YNQ))]
    public class Loop_YNQ_133
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Yes/No Question
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual YNQ YNQ { get; set; }
        /// <summary>
        // Quantity Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        // Percent Amounts
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<PCT> PCT { get; set; }
    }
    
    /// <summary>
    // Educational Institution Record
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "133")]
    public class TS133 : EdiMessage
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
        // Educational Record Purpose
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual ERP ERP { get; set; }
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<Loop_N1_133> LoopN1 { get; set; }
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<Loop_HL_133> LoopHL { get; set; }
        /// <summary>
        // Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(6)]
        public virtual SE SE { get; set; }
    }
}
