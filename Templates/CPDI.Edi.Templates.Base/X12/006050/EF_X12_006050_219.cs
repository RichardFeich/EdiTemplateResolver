namespace EdiFabric.Templates.X12006050
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
    [Group(typeof(N7))]
    public class Loop_1000_219
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Equipment Details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N7 N7 { get; set; }
        /// <summary>
        // Accessorial Equipment Details
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N7A N7A { get; set; }
        /// <summary>
        // Additional Equipment Details
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N7B N7B { get; set; }
        /// <summary>
        // Measurements
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual MEA MEA { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(S5))]
    public class Loop_2000_219
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Stop-off Details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual S5 S5 { get; set; }
        /// <summary>
        // Date/Time
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(2)]
        public virtual List<G62> G62 { get; set; }
        /// <summary>
        // Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<L11> L11 { get; set; }
        /// <summary>
        // Allowance
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(4)]
        public virtual List<ITA> ITA { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual Loop_N1_219 LoopN1 { get; set; }
        [DataMember]
        [ListCount(99)]
        [Pos(6)]
        public virtual List<Loop_2200_219> Loop2200 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<Loop_2300_219> Loop2300 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(G61))]
    public class Loop_2200_219
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Contact
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual G61 G61 { get; set; }
        /// <summary>
        // Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<L11> L11 { get; set; }
        /// <summary>
        // Hazardous Certification
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<LH6> LH6 { get; set; }
        [DataMember]
        [ListCount(25)]
        [Pos(4)]
        public virtual List<Loop_2250_219> Loop2250 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(LH1))]
    public class Loop_2250_219
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Hazardous Identification Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LH1 LH1 { get; set; }
        /// <summary>
        // Hazardous Classification Information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<LH2> LH2 { get; set; }
        /// <summary>
        // Hazardous Material Shipping Name Information
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(3)]
        public virtual List<LH3> LH3 { get; set; }
        /// <summary>
        // Free-form Hazardous Material Information
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(4)]
        public virtual List<LFH> LFH { get; set; }
        /// <summary>
        // EPA Required Data
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(5)]
        public virtual List<LEP> LEP { get; set; }
        /// <summary>
        // Canadian Dangerous Requirements
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual LH4 LH4 { get; set; }
        /// <summary>
        // Transborder Hazardous Requirements
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(7)]
        public virtual List<LHT> LHT { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_2300_219
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
        // Logistics Container Tracking Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual LCT LCT { get; set; }
        /// <summary>
        // Marks and Numbers Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<MAN> MAN { get; set; }
        /// <summary>
        // Bill of Lading Handling Requirements
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(4)]
        public virtual List<AT5> AT5 { get; set; }
        /// <summary>
        // Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual AMT AMT { get; set; }
        /// <summary>
        // Currency
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual CUR CUR { get; set; }
        /// <summary>
        // Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<L11> L11 { get; set; }
        [DataMember]
        [ListCount(99)]
        [Pos(8)]
        public virtual List<Loop_2350_219> Loop2350 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(9)]
        public virtual List<Loop_2370_219> Loop2370 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(G61))]
    public class Loop_2350_219
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Contact
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual G61 G61 { get; set; }
        /// <summary>
        // Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<L11> L11 { get; set; }
        /// <summary>
        // Hazardous Certification
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(3)]
        public virtual List<LH6> LH6 { get; set; }
        [DataMember]
        [ListCount(25)]
        [Pos(4)]
        public virtual List<Loop_2355_219> Loop2355 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(LH1))]
    public class Loop_2355_219
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Hazardous Identification Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LH1 LH1 { get; set; }
        /// <summary>
        // Hazardous Classification Information
        /// </summary>
        [DataMember]
        [ListCount(4)]
        [Pos(2)]
        public virtual List<LH2> LH2 { get; set; }
        /// <summary>
        // Hazardous Material Shipping Name Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<LH3> LH3 { get; set; }
        /// <summary>
        // Free-form Hazardous Material Information
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(4)]
        public virtual List<LFH> LFH { get; set; }
        /// <summary>
        // EPA Required Data
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(5)]
        public virtual List<LEP> LEP { get; set; }
        /// <summary>
        // Canadian Dangerous Requirements
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual LH4 LH4 { get; set; }
        /// <summary>
        // Transborder Hazardous Requirements
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(7)]
        public virtual List<LHT> LHT { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(LAD))]
    public class Loop_2370_219
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Lading Detail
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LAD LAD { get; set; }
        /// <summary>
        // Item Physical Details
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual PO4 PO4 { get; set; }
        /// <summary>
        // Line Item Detail - Description
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(3)]
        public virtual List<G69> G69 { get; set; }
        /// <summary>
        // Bill of Lading Handling Requirements
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(4)]
        public virtual List<AT5> AT5 { get; set; }
        /// <summary>
        // Monetary Amount Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual AMT AMT { get; set; }
        /// <summary>
        // Currency
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual CUR CUR { get; set; }
        /// <summary>
        // Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<L11> L11 { get; set; }
        /// <summary>
        // Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual PER PER { get; set; }
        [DataMember]
        [ListCount(99)]
        [Pos(9)]
        public virtual List<Loop_2375_219> Loop2375 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(G61))]
    public class Loop_2375_219
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Contact
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual G61 G61 { get; set; }
        /// <summary>
        // Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<L11> L11 { get; set; }
        /// <summary>
        // Hazardous Certification
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(3)]
        public virtual List<LH6> LH6 { get; set; }
        [DataMember]
        [ListCount(25)]
        [Pos(4)]
        public virtual List<Loop_2378_219> Loop2378 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(LH1))]
    public class Loop_2378_219
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Hazardous Identification Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LH1 LH1 { get; set; }
        /// <summary>
        // Hazardous Classification Information
        /// </summary>
        [DataMember]
        [ListCount(4)]
        [Pos(2)]
        public virtual List<LH2> LH2 { get; set; }
        /// <summary>
        // Hazardous Material Shipping Name Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<LH3> LH3 { get; set; }
        /// <summary>
        // Free-form Hazardous Material Information
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(4)]
        public virtual List<LFH> LFH { get; set; }
        /// <summary>
        // EPA Required Data
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(5)]
        public virtual List<LEP> LEP { get; set; }
        /// <summary>
        // Canadian Dangerous Requirements
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual LH4 LH4 { get; set; }
        /// <summary>
        // Transborder Hazardous Requirements
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(7)]
        public virtual List<LHT> LHT { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_219
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
    // Logistics Service Request
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "219")]
    public class TS219 : EdiMessage
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
        // Beginning Segment for Logistics Services
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual B9 B9 { get; set; }
        /// <summary>
        // Service Request
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(7)]
        [Pos(3)]
        public virtual List<B9A> B9A { get; set; }
        /// <summary>
        // Bill of Lading Handling Requirements
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(4)]
        public virtual List<AT5> AT5 { get; set; }
        /// <summary>
        // Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<L11> L11 { get; set; }
        /// <summary>
        // Interline Information
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(6)]
        public virtual List<MS3> MS3 { get; set; }
        /// <summary>
        // Allowance
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(7)]
        public virtual List<ITA> ITA { get; set; }
        /// <summary>
        // Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(8)]
        public virtual List<NTE> NTE { get; set; }
        [DataMember]
        [ListCount(99)]
        [Pos(9)]
        public virtual List<Loop_1000_219> Loop1000 { get; set; }
        [DataMember]
        [ListCount(99)]
        [Pos(10)]
        public virtual List<Loop_2000_219> Loop2000 { get; set; }
        /// <summary>
        // Total Weight and Charges
        /// </summary>
        [DataMember]
        [Required]
        [Pos(11)]
        public virtual L3 L3 { get; set; }
        /// <summary>
        // Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(12)]
        public virtual SE SE { get; set; }
    }
}
