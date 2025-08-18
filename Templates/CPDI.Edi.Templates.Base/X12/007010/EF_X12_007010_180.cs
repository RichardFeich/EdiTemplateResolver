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
    [Group(typeof(BLI))]
    public class Loop_BLI_180
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Basic Baseline Item Data
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual BLI BLI { get; set; }
        /// <summary>
        // Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(2)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        // Product/Item Description
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<PID> PID { get; set; }
        /// <summary>
        // Return Disposition Reason
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual RDR RDR { get; set; }
        /// <summary>
        // Service
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<SAC> SAC { get; set; }
        /// <summary>
        // Monetary Amount Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        // Measurements
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        // Conditions Indicator
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(8)]
        public virtual List<CRC> CRC { get; set; }
        /// <summary>
        // Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(9)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        // Purchase Order Reference
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual PRF PRF { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(15)]
        [Pos(11)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        // Demand Detail
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(12)]
        public virtual List<DD> DD { get; set; }
        /// <summary>
        // Furnished Goods and Services
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual GF GF { get; set; }
        /// <summary>
        // Carrier Details (Routing Sequence/Transit Time)
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(14)]
        public virtual List<TD5> TD5 { get; set; }
        /// <summary>
        // Destination Quantity
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(15)]
        public virtual List<SDQ> SDQ { get; set; }
        [DataMember]
        [ListCount(10)]
        [Pos(16)]
        public virtual List<Loop_LM_180> LoopLM { get; set; }
        [DataMember]
        [ListCount(200)]
        [Pos(17)]
        public virtual List<Loop_N1_180> LoopN1 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(18)]
        public virtual List<Loop_QTY_180> LoopQTY { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(19)]
        public virtual List<Loop_FA1_180> LoopFA1 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(FA1))]
    public class Loop_FA1_180
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Type of Financial Accounting Data
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual FA1 FA1 { get; set; }
        /// <summary>
        // Accounting Data
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<FA2> FA2 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(LM))]
    public class Loop_LM_180
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
        [ListCount(100)]
        [Pos(2)]
        public virtual List<LQ> LQ { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_180
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
        // Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        // Party Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N1 N1 { get; set; }
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<Loop_LM_180> LoopLM { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_180
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
        [ListCount(5)]
        [Pos(5)]
        public virtual List<PER> PER { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(QTY))]
    public class Loop_QTY_180
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Quantity Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual QTY QTY { get; set; }
        /// <summary>
        // Monetary Amount Information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        // Party Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N1 N1 { get; set; }
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<Loop_LM_180> LoopLM { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<Loop_LX_180> LoopLX { get; set; }
    }
    
    /// <summary>
    // Return Merchandise Authorization and Notification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "180")]
    public class TS180 : EdiMessage
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
        // Return Disposition Reason
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual RDR RDR { get; set; }
        /// <summary>
        // Purchase Order Reference
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual PRF PRF { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        // Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(6)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        // Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(7)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        // Service
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(8)]
        public virtual List<SAC> SAC { get; set; }
        /// <summary>
        // Claim Payment Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual G38 G38 { get; set; }
        /// <summary>
        // Marking
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(10)]
        public virtual List<PKG> PKG { get; set; }
        /// <summary>
        // Carrier Details (Quantity and Weight)
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(11)]
        public virtual List<TD1> TD1 { get; set; }
        /// <summary>
        // Carrier Details (Routing Sequence/Transit Time)
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(12)]
        public virtual List<TD5> TD5 { get; set; }
        /// <summary>
        // Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(13)]
        public virtual List<NTE> NTE { get; set; }
        [DataMember]
        [ListCount(200)]
        [Pos(14)]
        public virtual List<Loop_N1_180> LoopN1 { get; set; }
        [DataMember]
        [ListCount(10)]
        [Pos(15)]
        public virtual List<Loop_LM_180> LoopLM { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(16)]
        public virtual List<Loop_BLI_180> LoopBLI { get; set; }
        /// <summary>
        // Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(17)]
        public virtual SE SE { get; set; }
    }
}
