namespace EdiFabric.Templates.X12006040
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
    [Group(typeof(AT5))]
    public class Loop_0050_204
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Bill of Lading Handling Requirements
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual AT5 AT5 { get; set; }
        /// <summary>
        // Freight Rate Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual RTT RTT { get; set; }
        /// <summary>
        // Currency Identifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C3 C3 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_0100_204
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
        // Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual L11 L11 { get; set; }
        /// <summary>
        // Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(6)]
        public virtual List<G61> G61 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(N7))]
    public class Loop_0200_204
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
        /// <summary>
        // Seal Numbers
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(5)]
        public virtual List<M7> M7 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(S5))]
    public class Loop_0300_204
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
        // Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<L11> L11 { get; set; }
        /// <summary>
        // Date/Time
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(3)]
        public virtual List<G62> G62 { get; set; }
        /// <summary>
        // Shipment Weight
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual AT8 AT8 { get; set; }
        /// <summary>
        // Lading Detail
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<LAD> LAD { get; set; }
        [DataMember]
        [ListCount(99)]
        [Pos(6)]
        public virtual List<Loop_0305_204> Loop0305 { get; set; }
        /// <summary>
        // Pallet Shipment Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual PLD PLD { get; set; }
        /// <summary>
        // Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(8)]
        public virtual List<NTE> NTE { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual Loop_N1_204 LoopN1 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(10)]
        public virtual List<Loop_0320_204> Loop0320 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(11)]
        public virtual List<Loop_0350_204> Loop0350 { get; set; }
        [DataMember]
        [ListCount(10)]
        [Pos(12)]
        public virtual List<Loop_0380_204> Loop0380 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(AT5))]
    public class Loop_0305_204
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Bill of Lading Handling Requirements
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual AT5 AT5 { get; set; }
        /// <summary>
        // Freight Rate Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual RTT RTT { get; set; }
        /// <summary>
        // Currency Identifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C3 C3 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(L5))]
    public class Loop_0320_204
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Description
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual L5 L5 { get; set; }
        /// <summary>
        // Shipment Weight
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual AT8 AT8 { get; set; }
        [DataMember]
        [ListCount(99)]
        [Pos(3)]
        public virtual List<Loop_0323_204> Loop0323 { get; set; }
        /// <summary>
        // Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<L11> L11 { get; set; }
        /// <summary>
        // Measurements
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        // Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual PER PER { get; set; }
        /// <summary>
        // Measurement
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual L4 L4 { get; set; }
        [DataMember]
        [ListCount(99)]
        [Pos(8)]
        public virtual List<Loop_0325_204> Loop0325 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(AT5))]
    public class Loop_0323_204
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Bill of Lading Handling Requirements
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual AT5 AT5 { get; set; }
        /// <summary>
        // Freight Rate Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual RTT RTT { get; set; }
        /// <summary>
        // Currency Identifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual C3 C3 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(G61))]
    public class Loop_0325_204
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
        public virtual List<Loop_0330_204> Loop0330 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(LH1))]
    public class Loop_0330_204
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
    [Group(typeof(OID))]
    public class Loop_0350_204
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Order Information Detail
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual OID OID { get; set; }
        /// <summary>
        // Date/Time
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<G62> G62 { get; set; }
        /// <summary>
        // Lading Detail
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<LAD> LAD { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(4)]
        public virtual List<Loop_0360_204> Loop0360 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(L5))]
    public class Loop_0360_204
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Description
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual L5 L5 { get; set; }
        /// <summary>
        // Shipment Weight
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual AT8 AT8 { get; set; }
        /// <summary>
        // Measurement
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual L4 L4 { get; set; }
        [DataMember]
        [ListCount(99)]
        [Pos(4)]
        public virtual List<Loop_0365_204> Loop0365 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(G61))]
    public class Loop_0365_204
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
        public virtual List<Loop_0370_204> Loop0370 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(LH1))]
    public class Loop_0370_204
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
    [Group(typeof(N7))]
    public class Loop_0380_204
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
        /// <summary>
        // Seal Numbers
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(5)]
        public virtual List<M7> M7 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_204
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
        // Measurement
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual L4 L4 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_204
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
        // Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(5)]
        public virtual List<G61> G61 { get; set; }
    }

    /// <summary>
    // Motor Carrier Load Tender
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "204")]
    public class TS204 : EdiMessage
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
        // Beginning Segment for Shipment Information Transaction
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual B2 B2 { get; set; }
        /// <summary>
        // Set Purpose
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual B2A B2A { get; set; }
        /// <summary>
        // Currency Identifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual C3 C3 { get; set; }
        /// <summary>
        // Business Instructions and Reference Number
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(5)]
        public virtual List<L11> L11 { get; set; }
        /// <summary>
        // Date/Time
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual G62 G62 { get; set; }
        /// <summary>
        // Interline Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual MS3 MS3 { get; set; }
        [DataMember]
        [ListCount(99)]
        [Pos(8)]
        public virtual List<Loop_0050_204> Loop0050 { get; set; }
        /// <summary>
        // Pallet Shipment Information
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual PLD PLD { get; set; }
        /// <summary>
        // Hazardous Certification
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(10)]
        public virtual List<LH6> LH6 { get; set; }
        /// <summary>
        // Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(11)]
        public virtual List<NTE> NTE { get; set; }
        [DataMember]
        [ListCount(5)]
        [Pos(12)]
        public virtual List<Loop_0100_204> Loop0100 { get; set; }
        [DataMember]
        [ListCount(10)]
        [Pos(13)]
        public virtual List<Loop_0200_204> Loop0200 { get; set; }
        [DataMember]
        [Required]
        [ListCount(999)]
        [Pos(14)]
        public virtual List<Loop_0300_204> Loop0300 { get; set; }
        /// <summary>
        // Total Weight and Charges
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual L3 L3 { get; set; }
        [DataMember]
        [Pos(16)]
        public virtual Loop_LX_204 LoopLX { get; set; }
        /// <summary>
        // Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(17)]
        public virtual SE SE { get; set; }
    }
}
