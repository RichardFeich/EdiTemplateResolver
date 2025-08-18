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
    [Group(typeof(ADX))]
    public class Loop_ADX_823
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Adjustment
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ADX ADX { get; set; }
        /// <summary>
        // Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        // Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual DTM DTM { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<Loop_REF_823> LoopREF { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<Loop_IT1_823> LoopIT1 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(ADX))]
    public class Loop_ADX_823_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Adjustment
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ADX ADX { get; set; }
        /// <summary>
        // Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        // Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<PER> PER { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<Loop_REF_823> LoopREF { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<Loop_IT1_823> LoopIT1 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(AIN))]
    public class Loop_AIN_823
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Income
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual AIN AIN { get; set; }
        /// <summary>
        // Quantity Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        // Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<DTP> DTP { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(BAT))]
    public class Loop_BAT_823
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Batch
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual BAT BAT { get; set; }
        /// <summary>
        // Funds Availability
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<AVA> AVA { get; set; }
        /// <summary>
        // Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual AMT AMT { get; set; }
        /// <summary>
        // Quantity Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual QTY QTY { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<DTM> DTM { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<Loop_BPR_823> LoopBPR { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(BPR))]
    public class Loop_BPR_823
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Beginning Segment for Payment Order/Remittance Advice
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual BPR BPR { get; set; }
        /// <summary>
        // Trace
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual TRN TRN { get; set; }
        /// <summary>
        // Currency
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual CUR CUR { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        // Funds Availability
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual AVA AVA { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<Loop_ADX_823> LoopADX { get; set; }
        [DataMember]
        [ListCount(200)]
        [Pos(8)]
        public virtual List<Loop_N1_823> LoopN1 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(9)]
        public virtual List<Loop_RMR_823> LoopRMR { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(10)]
        public virtual List<Loop_TXP_823> LoopTXP { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(11)]
        public virtual List<Loop_DED_823> LoopDED { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(12)]
        public virtual List<Loop_LX_823> LoopLX { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(DED))]
    public class Loop_DED_823
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Deductions
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual DED DED { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(DEP))]
    public class Loop_DEP_823
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Deposit
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual DEP DEP { get; set; }
        /// <summary>
        // Monetary Amount Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual AMT AMT { get; set; }
        /// <summary>
        // Quantity Information
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<DTM> DTM { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<Loop_BAT_823> LoopBAT { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(INV))]
    public class Loop_INV_823
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Investment Vehicle Selection
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual INV INV { get; set; }
        /// <summary>
        // Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<DTP> DTP { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(IT1))]
    public class Loop_IT1_823
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Baseline Item Data (Invoice)
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual IT1 IT1 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<Loop_REF_823_2> LoopREF { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<Loop_SAC_823> LoopSAC { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<Loop_SLN_823> LoopSLN { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_823
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
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        // Trace
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<TRN> TRN { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<Loop_NM1_823> LoopNM1 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_823
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
        [ListCount(12)]
        [Pos(5)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        // Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(6)]
        public virtual List<PER> PER { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_NM1_823
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
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        // Maintenance Type
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<G53> G53 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<Loop_AIN_823> LoopAIN { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<Loop_PEN_823> LoopPEN { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(PEN))]
    public class Loop_PEN_823
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Pension Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PEN PEN { get; set; }
        /// <summary>
        // Monetary Amount Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<AMT> AMT { get; set; }
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
        public virtual List<Loop_INV_823> LoopINV { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(REF))]
    public class Loop_REF_823
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual REF REF { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(REF))]
    public class Loop_REF_823_2
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual REF REF { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual DTM DTM { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(RMR))]
    public class Loop_RMR_823
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Remittance Advice Accounts Receivable Open Item Reference
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual RMR RMR { get; set; }
        /// <summary>
        // Party Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        // Currency
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual CUR CUR { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<DTM> DTM { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<Loop_IT1_823> LoopIT1 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<Loop_ADX_823_2> LoopADX { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(SAC))]
    public class Loop_SAC_823
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Service
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SAC SAC { get; set; }
        /// <summary>
        // Tax Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<TXI> TXI { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(SLN))]
    public class Loop_SLN_823
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Subline Item Detail
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SLN SLN { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<Loop_REF_823> LoopREF { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<Loop_SAC_823> LoopSAC { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(TXP))]
    public class Loop_TXP_823
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Tax Payment
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual TXP TXP { get; set; }
        /// <summary>
        // Tax Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<TXI> TXI { get; set; }
    }
    
    /// <summary>
    // Lockbox
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "823")]
    public class TS823 : EdiMessage
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
        [DataMember]
        [Required]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<Loop_N1_823> LoopN1 { get; set; }
        /// <summary>
        // Trace
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual TRN TRN { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(4)]
        public virtual List<DTM> DTM { get; set; }
        [DataMember]
        [Required]
        [ListCount(100)]
        [Pos(5)]
        public virtual List<Loop_DEP_823> LoopDEP { get; set; }
        /// <summary>
        // Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(6)]
        public virtual SE SE { get; set; }
    }
}
