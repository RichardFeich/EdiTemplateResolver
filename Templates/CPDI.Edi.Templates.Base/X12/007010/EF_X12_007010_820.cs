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
    public class Loop_1000_820
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
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<N2> N2 { get; set; }
        /// <summary>
        // Party Location
        /// </summary>
        [DataMember]
        [ListCount(99999)]
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
        // Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        // Remittance Delivery Method
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual RDM RDM { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual DTM DTM { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(ENT))]
    public class Loop_2000_820
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
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<Loop_2100_820> Loop2100 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<Loop_2200_820> Loop2200 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<Loop_2300_820> Loop2300 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<Loop_2400_820> Loop2400 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(FA1))]
    public class Loop_2100_820
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
    [Group(typeof(NM1))]
    public class Loop_2200_820
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
        // Additional Name Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<N2> N2 { get; set; }
        /// <summary>
        // Party Location
        /// </summary>
        [DataMember]
        [ListCount(99999)]
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
        // Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<PER> PER { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(ADX))]
    public class Loop_2300_820
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
        public virtual List<Loop_2310_820> Loop2310 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<Loop_2320_820> Loop2320 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<Loop_2330_820> Loop2330 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(REF))]
    public class Loop_2310_820
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
    public class Loop_23131_820
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
    [Group(typeof(IT1))]
    public class Loop_2320_820
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
        /// <summary>
        // Rate Amounts or Percents
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual RPA RPA { get; set; }
        /// <summary>
        // Quantity Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual QTY QTY { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<Loop_2321_820> Loop2321 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<Loop_2322_820> Loop2322 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<Loop_2323_820> Loop2323 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(REF))]
    public class Loop_2321_820
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
    [Group(typeof(SAC))]
    public class Loop_2322_820
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
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(SLN))]
    public class Loop_2323_820
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
        public virtual List<Loop_23131_820> Loop23131 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<Loop_23232_820> Loop23232 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(SAC))]
    public class Loop_23232_820
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
    [Group(typeof(FA1))]
    public class Loop_2330_820
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
    [Group(typeof(RMR))]
    public class Loop_2400_820
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
        // Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        // Vehicle Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual VEH VEH { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<Loop_2410_820> Loop2410 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<Loop_2420_820> Loop2420 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(8)]
        public virtual List<Loop_2430_820> Loop2430 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(IT1))]
    public class Loop_2410_820
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
        /// <summary>
        // Rate Amounts or Percents
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual RPA RPA { get; set; }
        /// <summary>
        // Quantity Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual QTY QTY { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<Loop_2411_820> Loop2411 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<Loop_2412_820> Loop2412 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<Loop_2413_820> Loop2413 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(REF))]
    public class Loop_2411_820
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
    [Group(typeof(SAC))]
    public class Loop_2412_820
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
    public class Loop_2413_820
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
        public virtual List<Loop_24131_820> Loop24131 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<Loop_24132_820> Loop24132 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(REF))]
    public class Loop_24131_820
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
    [Group(typeof(SAC))]
    public class Loop_24132_820
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
    [Group(typeof(ADX))]
    public class Loop_2420_820
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
        public virtual List<Loop_2421_820> Loop2421 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<Loop_2422_820> Loop2422 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(REF))]
    public class Loop_2421_820
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
    [Group(typeof(IT1))]
    public class Loop_2422_820
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
        /// <summary>
        // Rate Amounts or Percents
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual RPA RPA { get; set; }
        /// <summary>
        // Quantity Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual QTY QTY { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<Loop_24221_820> Loop24221 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<Loop_24222_820> Loop24222 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<Loop_24223_820> Loop24223 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(REF))]
    public class Loop_24221_820
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
    [Group(typeof(SAC))]
    public class Loop_24222_820
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
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(SLN))]
    public class Loop_24223_820
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
        public virtual List<Loop_242231_820> Loop242231 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<Loop_242232_820> Loop242232 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(REF))]
    public class Loop_242231_820
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
    [Group(typeof(SAC))]
    public class Loop_242232_820
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
    [Group(typeof(FA1))]
    public class Loop_2430_820
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
    [Group(typeof(TXP))]
    public class Loop_3000_820
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
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(DED))]
    public class Loop_4000_820
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
    [Group(typeof(LX))]
    public class Loop_5000_820
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
        public virtual List<Loop_5100_820> Loop5100 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_5100_820
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
        [Pos(3)]
        public virtual G53 G53 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<Loop_5110_820> Loop5110 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<Loop_5120_820> Loop5120 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(AIN))]
    public class Loop_5110_820
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
    [Group(typeof(PEN))]
    public class Loop_5120_820
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
        public virtual List<Loop_5121_820> Loop5121 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(INV))]
    public class Loop_5121_820
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
    [Group(typeof(AMT))]
    public class Loop_6100_820
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Monetary Amount Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual AMT AMT { get; set; }
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
    [Group(typeof(N1))]
    public class Loop_6200_820
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
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<Loop_6210_820> Loop6210 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(EMS))]
    public class Loop_6210_820
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Employment Position
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual EMS EMS { get; set; }
        /// <summary>
        // Attendance
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<ATN> ATN { get; set; }
        /// <summary>
        // Income
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<AIN> AIN { get; set; }
        /// <summary>
        // Payroll Deduction
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<PYD> PYD { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(RYL))]
    public class Loop_7000_820
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Royalty Payment
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual RYL RYL { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<Loop_7100_820> Loop7100 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_7100_820
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
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<Loop_7110_820> Loop7110 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual Loop_ASM_820 LoopASM { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(LOC))]
    public class Loop_7110_820
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Location
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LOC LOC { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<Loop_7111_820> Loop7111 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(PID))]
    public class Loop_7111_820
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
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual DTM DTM { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<Loop_71111_820> Loop71111 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(PCT))]
    public class Loop_71111_820
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Percent Amounts
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PCT PCT { get; set; }
        /// <summary>
        // Quantity Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual QTY QTY { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<Loop_711111_820> Loop711111 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(AMT))]
    public class Loop_711111_820
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Monetary Amount Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual AMT AMT { get; set; }
        /// <summary>
        // Adjustment
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<ADX> ADX { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(INS))]
    public class Loop_8000_820
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Insured Benefit
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual INS INS { get; set; }
        /// <summary>
        // Quantity Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        // Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual NM1 NM1 { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        // Demographic Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual DMG DMG { get; set; }
        /// <summary>
        // Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<DTP> DTP { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<Loop_8100_820> Loop8100 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(8)]
        public virtual List<Loop_8200_820> Loop8200 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(9)]
        public virtual List<Loop_8300_820> Loop8300 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(ADX))]
    public class Loop_8100_820
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
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual DTM DTM { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(HD))]
    public class Loop_8200_820
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Health Coverage
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual HD HD { get; set; }
        /// <summary>
        // Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<REF> REF { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<Loop_8210_820> Loop8210 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(RMR))]
    public class Loop_8210_820
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
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<Loop_8211_820> Loop8211 { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(ADX))]
    public class Loop_8211_820
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
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_8300_820
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
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(TPP))]
    public class Loop_9000_820
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Third Party Payment
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual TPP TPP { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(ASM))]
    public class Loop_ASM_820
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
        // Adjustment
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual ADX ADX { get; set; }
    }
    
    [Serializable()]
    [DataContract()]
    [Group(typeof(N9))]
    public class Loop_N9_820
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Extended Reference Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N9 N9 { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<Loop_6100_820> Loop6100 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<Loop_6200_820> Loop6200 { get; set; }
    }
    
    /// <summary>
    // Payment Order/Remittance Advice
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "820")]
    public class TS820 : EdiMessage
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
        // Beginning Segment for Payment Order/Remittance Advice
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BPR BPR { get; set; }
        /// <summary>
        // Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        // Trace
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual TRN TRN { get; set; }
        /// <summary>
        // Currency
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual CUR CUR { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<DTM> DTM { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(8)]
        public virtual List<Loop_1000_820> Loop1000 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(9)]
        public virtual List<Loop_2000_820> Loop2000 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(10)]
        public virtual List<Loop_3000_820> Loop3000 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(11)]
        public virtual List<Loop_4000_820> Loop4000 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(12)]
        public virtual List<Loop_5000_820> Loop5000 { get; set; }
        [DataMember]
        [Pos(13)]
        public virtual Loop_N9_820 LoopN9 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(14)]
        public virtual List<Loop_7000_820> Loop7000 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(15)]
        public virtual List<Loop_8000_820> Loop8000 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(16)]
        public virtual List<Loop_9000_820> Loop9000 { get; set; }
        /// <summary>
        // Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(17)]
        public virtual SE SE { get; set; }
    }
}
