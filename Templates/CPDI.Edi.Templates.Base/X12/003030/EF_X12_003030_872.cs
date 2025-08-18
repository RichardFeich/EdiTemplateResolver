namespace EdiFabric.Templates.X12003030
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.X12;


    /// <summary>
    /// Loop for Loan Buydown
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(BUY))]
    public class Loop_BUY_872
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Loan Buydown
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual BUY BUY { get; set; }
        /// <summary>
        /// Temporary Buydown Adjustment
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<TBA> TBA { get; set; }
    }

    /// <summary>
    /// Loop for Individual Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(IN1))]
    public class Loop_IN1_872
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Individual Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual IN1 IN1 { get; set; }
        /// <summary>
        /// Individual Name Structure Components
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<IN2> IN2 { get; set; }
        /// <summary>
        /// Demographic Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual DMG DMG { get; set; }
        /// <summary>
        /// Quantity and Description
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N10 N10 { get; set; }
        /// <summary>
        /// Borrower Financial Summary
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual BFS BFS { get; set; }
    }

    /// <summary>
    /// Loop for Assigned Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_872
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Assigned Number
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LX LX { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        /// Additional Name Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<N2> N2 { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(4)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Reference Numbers
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(12)]
        [Pos(6)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Loop for Mortgage Insurance Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(7)]
        public virtual List<Loop_MII_872> MIILoop { get; set; }
    }

    /// <summary>
    /// Loop for Mortgage Closing Data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(MCD))]
    public class Loop_MCD_872
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Mortgage Closing Data
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual MCD MCD { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<AMT> AMT { get; set; }
    }

    /// <summary>
    /// Loop for Mortgage Insurance Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(MII))]
    public class Loop_MII_872
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Mortgage Insurance Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual MII MII { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Mortgage Characteristics Requested
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual LRQ LRQ { get; set; }
        /// <summary>
        /// Reference Numbers
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Property or Housing Expense
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(5)]
        public virtual List<PEX> PEX { get; set; }
        /// <summary>
        /// Loan Specific Data
        /// </summary>
        [DataMember]
        [Required]
        [Pos(6)]
        public virtual LN1 LN1 { get; set; }
        /// <summary>
        /// Down Payment Data
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(5)]
        [Pos(7)]
        public virtual List<RLD> RLD { get; set; }
        /// <summary>
        /// Mortgage Loan Product Description
        /// </summary>
        [DataMember]
        [Required]
        [Pos(8)]
        public virtual PRD PRD { get; set; }
        /// <summary>
        /// Adjustable Payment Description
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual PAY PAY { get; set; }
        /// <summary>
        /// Adjustable Rate Description
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual RAT RAT { get; set; }
        /// <summary>
        /// Loop for Real Estate Property Information
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual Loop_REA_872 REALoop { get; set; }
        /// <summary>
        /// Loop for Mortgage Closing Data
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual Loop_MCD_872 MCDLoop { get; set; }
        /// <summary>
        /// Loop for Loan Buydown
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(13)]
        public virtual List<Loop_BUY_872> BUYLoop { get; set; }
        /// <summary>
        /// Loop for Multifamily Housing Project
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual Loop_PRJ_872 PRJLoop { get; set; }
        /// <summary>
        /// Loop for Paperwork
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(15)]
        public virtual List<Loop_PWK_872> PWKLoop { get; set; }
        /// <summary>
        /// Loop for Real Estate Property Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(5)]
        [Pos(16)]
        public virtual List<Loop_NX1_872> NX1Loop { get; set; }
        /// <summary>
        /// Loop for Individual Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(12)]
        [Pos(17)]
        public virtual List<Loop_IN1_872> IN1Loop { get; set; }
    }

    /// <summary>
    /// Loop for Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_872
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        /// Additional Name Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<N2> N2 { get; set; }
        /// <summary>
        /// Reference Numbers
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(3)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(4)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Loop for Geographic Location
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(5)]
        public virtual List<Loop_N4_872> N4Loop { get; set; }
    }

    /// <summary>
    /// Loop for Geographic Location
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N4))]
    public class Loop_N4_872
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<N3> N3 { get; set; }
    }

    /// <summary>
    /// Loop for Real Estate Property Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NX1))]
    public class Loop_NX1_872
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Real Estate Property Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NX1 NX1 { get; set; }
        /// <summary>
        /// Real Estate Property ID Component
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(30)]
        [Pos(2)]
        public virtual List<NX2> NX2 { get; set; }
        /// <summary>
        /// Loop for Property Appraisal Summary
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<Loop_PAS_872> PASLoop { get; set; }
    }

    /// <summary>
    /// Loop for Property Appraisal Summary
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PAS))]
    public class Loop_PAS_872
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Property Appraisal Summary
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PAS PAS { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Message Text
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(4)]
        public virtual List<MSG> MSG { get; set; }
    }

    /// <summary>
    /// Loop for Multifamily Housing Project
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PRJ))]
    public class Loop_PRJ_872
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Multifamily Housing Project
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PRJ PRJ { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<PER> PER { get; set; }
    }

    /// <summary>
    /// Loop for Paperwork
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PWK))]
    public class Loop_PWK_872
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Paperwork
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PWK PWK { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        /// Additional Name Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<N2> N2 { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(4)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Reference Numbers
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(6)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(7)]
        public virtual List<PER> PER { get; set; }
    }

    /// <summary>
    /// Loop for Real Estate Property Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(REA))]
    public class Loop_REA_872
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Real Estate Property Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual REA REA { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<AMT> AMT { get; set; }
    }

    /// <summary>
    /// Residential Mortgage Insurance Application
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "872")]
    public class TS872 : EdiMessage
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transaction Set Header
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual ST ST { get; set; }
        /// <summary>
        /// Beginning Segment
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BGN BGN { get; set; }
        /// <summary>
        /// Loop for Name
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<Loop_N1_872> N1Loop { get; set; }
        /// <summary>
        /// Loop for Assigned Number
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual List<Loop_LX_872> LXLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual SE SE { get; set; }
    }
}
