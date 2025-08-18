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
    [Group(typeof(ASM))]
    public class Loop_ASM_185
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Amount and Settlement Method
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ASM ASM { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual REF REF { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(LM))]
    public class Loop_LM_185
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Code Source Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LM LM { get; set; }
        /// <summary>
        // Industry Code Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<LQ> LQ { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(LM))]
    public class Loop_LM_185_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Code Source Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LM LM { get; set; }
        /// <summary>
        // Industry Code Identification
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<LQ> LQ { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(LQ))]
    public class Loop_LQ_185
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Industry Code Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LQ LQ { get; set; }
        /// <summary>
        // Quantity Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<QTY> QTY { get; set; }
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
    [Group(typeof(LS))]
    public class Loop_LS_185
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Loop Header
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LS LS { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<Loop_ASM_185> LoopASM { get; set; }
        /// <summary>
        // Loop Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual LE LE { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_185
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Transaction Set Line Number
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LX LX { get; set; }
        /// <summary>
        // Action or Status Indicator
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual ASI ASI { get; set; }
        /// <summary>
        // Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        // Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        // Party Identification
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<N1> N1 { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        // Percent Amounts
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<PCT> PCT { get; set; }
        /// <summary>
        // Amount and Settlement Method
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(8)]
        public virtual List<ASM> ASM { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(9)]
        public virtual List<Loop_LM_185_2> LoopLM { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(10)]
        public virtual List<Loop_PID_185> LoopPID { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_185
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
        [ListCount(5)]
        [Pos(5)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        // Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<PER> PER { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(PID))]
    public class Loop_PID_185
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Product/Item Description
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PID PID { get; set; }
        /// <summary>
        // Measurements
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        // Quantity Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        // Monetary Amount Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        // Amount and Settlement Method
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<ASM> ASM { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<Loop_LQ_185> LoopLQ { get; set; }
    }
    
    /// <summary>
    // Royalty Regulatory Report
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "185")]
    public class TS185 : EdiMessage
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
        // Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<DTP> DTP { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<Loop_N1_185> LoopN1 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<Loop_LM_185> LoopLM { get; set; }
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<Loop_LX_185> LoopLX { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual Loop_LS_185 LoopLS { get; set; }
        /// <summary>
        // Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(8)]
        public virtual SE SE { get; set; }
    }
}
