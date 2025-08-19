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
    [Group(typeof(N1))]
    public class Loop_0100_260
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
        [Pos(2)]
        public virtual N2 N2 { get; set; }
        /// <summary>
        // Party Location
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N3 N3 { get; set; }
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
        [Pos(5)]
        public virtual REF REF { get; set; }
        /// <summary>
        // Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual PER PER { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(CSI))]
    public class Loop_0200_260
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Claim Status Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CSI CSI { get; set; }
        /// <summary>
        // Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<NM1> NM1 { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(6)]
        [Pos(3)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        // Party Location
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual N3 N3 { get; set; }
        /// <summary>
        // Geographic Location
        /// </summary>
        [DataMember]
        [Required]
        [Pos(5)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        // Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(6)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        // Interest
        /// </summary>
        [DataMember]
        [ListCount(24)]
        [Pos(7)]
        public virtual List<INT> INT { get; set; }
        /// <summary>
        // Mortgage Insurance Response
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual MIR MIR { get; set; }
        /// <summary>
        // Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(9)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        // Percent Amounts
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual PCT PCT { get; set; }
        /// <summary>
        // Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(30)]
        [Pos(11)]
        public virtual List<NTE> NTE { get; set; }
        [DataMember]
        [Pos(12)]
        public virtual Loop_DFI_260 LoopDFI { get; set; }
        [DataMember]
        [Pos(13)]
        public virtual Loop_REC_260 LoopREC { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(14)]
        public virtual List<Loop_0230_260> Loop0230 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(FIS))]
    public class Loop_0230_260
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Mortgage Loan Fiscal Data
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual FIS FIS { get; set; }
        /// <summary>
        // Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual DTP DTP { get; set; }
        /// <summary>
        // Message Text
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual MSG MSG { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(DFI))]
    public class Loop_DFI_260
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Default Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual DFI DFI { get; set; }
        /// <summary>
        // Date or Time or Period
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(19)]
        [Pos(2)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        // Monetary Amount Information
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(4)]
        [Pos(3)]
        public virtual List<AMT> AMT { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(FCL))]
    public class Loop_FCL_260
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Foreclosure
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual FCL FCL { get; set; }
        /// <summary>
        // Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<DTP> DTP { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(REC))]
    public class Loop_REC_260
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Real Estate Condition
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual REC REC { get; set; }
        /// <summary>
        // Monetary Amount Information
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(2)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        // Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(4)]
        [Pos(3)]
        public virtual List<DTP> DTP { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual Loop_FCL_260 LoopFCL { get; set; }
    }
    
    /// <summary>
    // Application for Mortgage Insurance Benefits
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "260")]
    public class TS260 : EdiMessage
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
        [DataMember]
        [Required]
        [ListCount(7)]
        [Pos(3)]
        public virtual List<Loop_0100_260> Loop0100 { get; set; }
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<Loop_0200_260> Loop0200 { get; set; }
        /// <summary>
        // Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(5)]
        public virtual SE SE { get; set; }
    }
}
