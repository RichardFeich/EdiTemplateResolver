namespace EdiFabric.Templates.X12007040
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.X12;


    [Serializable()]
    [DataContract()]
    [Group(typeof(FA1))]
    public class Loop_FA1_857
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
    [Group(typeof(G05))]
    public class Loop_G05_857
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Total Shipment Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual G05 G05 { get; set; }
        /// <summary>
        // Carrier Details (Quantity and Weight)
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<TD1> TD1 { get; set; }
        /// <summary>
        // Carrier Details (Equipment)
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<TD3> TD3 { get; set; }
        /// <summary>
        // Carrier Details (Special Handling
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<TD4> TD4 { get; set; }
        /// <summary>
        // Carrier Details (Routing Sequence/Transit Time)
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<TD5> TD5 { get; set; }
        /// <summary>
        // F.O.B. Related Instructions
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual FOB FOB { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(7)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        // Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(8)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        // Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(9)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        // Currency
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual CUR CUR { get; set; }
        [DataMember]
        [ListCount(10)]
        [Pos(11)]
        public virtual List<Loop_N1_857> LoopN1 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(12)]
        public virtual List<Loop_LM_857> LoopLM { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(HL))]
    public class Loop_HL_857
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
        [DataMember]
        [Pos(2)]
        public virtual Loop_G05_857 LoopG05 { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual Loop_TDS_857 LoopTDS { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual Loop_PAL_857 LoopPAL { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual Loop_LX_857 LoopLX { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual Loop_IT1_857 LoopIT1 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(IT1))]
    public class Loop_IT1_857
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
        // Additional Item Data
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual IT3 IT3 { get; set; }
        /// <summary>
        // Item Physical Details
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual PO4 PO4 { get; set; }
        /// <summary>
        // Carrier Details (Special Handling
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<TD4> TD4 { get; set; }
        /// <summary>
        // Commodity
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(5)]
        public virtual List<TC2> TC2 { get; set; }
        /// <summary>
        // Tax Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(6)]
        public virtual List<TXI> TXI { get; set; }
        /// <summary>
        // Pricing Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(7)]
        public virtual List<CTP> CTP { get; set; }
        /// <summary>
        // Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(8)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        // Measurements
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(9)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(10)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        // Terms of Sale/Deferred Terms of Sale
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(11)]
        public virtual List<ITD> ITD { get; set; }
        [DataMember]
        [ListCount(25)]
        [Pos(12)]
        public virtual List<Loop_PID_857> LoopPID { get; set; }
        [DataMember]
        [ListCount(1000)]
        [Pos(13)]
        public virtual List<Loop_SLN_857> LoopSLN { get; set; }
        [DataMember]
        [ListCount(25)]
        [Pos(14)]
        public virtual List<Loop_SAC_857> LoopSAC { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(15)]
        public virtual List<Loop_LM_857> LoopLM { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(16)]
        public virtual List<Loop_FA1_857> LoopFA1 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(LM))]
    public class Loop_LM_857
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
    [Group(typeof(LX))]
    public class Loop_LX_857
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
        [ListCount(15)]
        [Pos(2)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        // Item Detail (Shipment)
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual SN1 SN1 { get; set; }
        /// <summary>
        // Item Physical Details
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual PO4 PO4 { get; set; }
        /// <summary>
        // Measurements
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        // Marking
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(6)]
        public virtual List<PKG> PKG { get; set; }
        /// <summary>
        // Marks and Numbers Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(7)]
        public virtual List<MAN> MAN { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_857
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
    [Group(typeof(PAL))]
    public class Loop_PAL_857
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Pallet Type and Load Characteristics
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PAL PAL { get; set; }
        /// <summary>
        // Item Detail (Shipment)
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual SN1 SN1 { get; set; }
        /// <summary>
        // Marks and Numbers Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<MAN> MAN { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(PID))]
    public class Loop_PID_857
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
        [ListCount(10)]
        [Pos(2)]
        public virtual List<MEA> MEA { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(SAC))]
    public class Loop_SAC_857
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
        [ListCount(10)]
        [Pos(2)]
        public virtual List<TXI> TXI { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(SLN))]
    public class Loop_SLN_857
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
        /// <summary>
        // Product/Item Description
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(2)]
        public virtual List<PID> PID { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(TDS))]
    public class Loop_TDS_857
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Total Monetary Value Summary
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual TDS TDS { get; set; }
        /// <summary>
        // Purchase Order Reference
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual PRF PRF { get; set; }
        /// <summary>
        // Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        // Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(4)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        // Text
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(5)]
        public virtual List<MTX> MTX { get; set; }
        /// <summary>
        // Terms of Sale/Deferred Terms of Sale
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(6)]
        public virtual List<ITD> ITD { get; set; }
        /// <summary>
        // Tax Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(7)]
        public virtual List<TXI> TXI { get; set; }
        /// <summary>
        // Item Detail (Shipment)
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual SN1 SN1 { get; set; }
        /// <summary>
        // Invoice Shipment Summary
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual ISS ISS { get; set; }
        [DataMember]
        [ListCount(25)]
        [Pos(10)]
        public virtual List<Loop_SAC_857> LoopSAC { get; set; }
        [DataMember]
        [ListCount(10)]
        [Pos(11)]
        public virtual List<Loop_N1_857> LoopN1 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(12)]
        public virtual List<Loop_FA1_857> LoopFA1 { get; set; }
    }

    /// <summary>
    // Shipment and Billing Notice
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "857")]
    public class TS857 : EdiMessage
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
        // Beginning of Hierarchical Transaction
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BHT BHT { get; set; }
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<Loop_HL_857> LoopHL { get; set; }
        /// <summary>
        // Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual SE SE { get; set; }
    }
}
