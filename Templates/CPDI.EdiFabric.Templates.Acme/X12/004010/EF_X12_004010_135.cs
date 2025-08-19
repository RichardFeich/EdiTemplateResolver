namespace CPDI.EdiFabric.Templates.X12004010.Acme
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;


    /// <summary>
    /// Loop for Entity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(ENT))]
    public class Loop_ENT_135
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Entity
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ENT ENT { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// School Enrollment Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual ENR ENR { get; set; }
        /// <summary>
        /// Financial Status Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual FNA FNA { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [ListCount(15)]
        [Pos(5)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(6)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// School Type
        /// </summary>
        [DataMember]
        [ListCount(8)]
        [Pos(7)]
        public virtual List<SCT> SCT { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual DTP DTP { get; set; }
        /// <summary>
        /// Authentication
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual Y6 Y6 { get; set; }
        /// <summary>
        /// Loop for Name
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(10)]
        public virtual List<Loop_N1_135> N1Loop { get; set; }
        /// <summary>
        /// Loop for Previous Loan Information
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(11)]
        public virtual List<Loop_PLI_135> PLILoop { get; set; }
        /// <summary>
        /// Loop for Individual Identification
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(12)]
        public virtual List<Loop_IN1_135> IN1Loop { get; set; }
    }

    /// <summary>
    /// Loop for Individual Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(IN1))]
    public class Loop_IN1_135
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
        [ListCount(5)]
        [Pos(2)]
        public virtual List<IN2> IN2 { get; set; }
        /// <summary>
        /// Demographic Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual DMG DMG { get; set; }
        /// <summary>
        /// Additional Demographic Information
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual DMA DMA { get; set; }
        /// <summary>
        /// Loop for Assigned Number
        /// </summary>
        [DataMember]
        [ListCount(4)]
        [Pos(5)]
        public virtual List<Loop_LX_135> LXLoop { get; set; }
    }

    /// <summary>
    /// Loop for Assigned Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_135
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
        [Pos(2)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual DTP DTP { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(6)]
        public virtual List<PER> PER { get; set; }
    }

    /// <summary>
    /// Loop for Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_135
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
        /// Address Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(4)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(5)]
        public virtual List<PER> PER { get; set; }
    }

    /// <summary>
    /// Loop for Previous Loan Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PLI))]
    public class Loop_PLI_135
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Previous Loan Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PLI PLI { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<N1> N1 { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N4 N4 { get; set; }
    }

    /// <summary>
    /// Student Loan Application
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "135")]
    public class TS135 : EdiMessage, ITS135
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
        /// Specific Loan Information
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(3)]
        [Pos(3)]
        public virtual List<SLI> SLI { get; set; }
        /// <summary>
        /// Disbursement Information
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(10)]
        [Pos(4)]
        public virtual List<DB> DB { get; set; }
        /// <summary>
        /// Delayed Repayment
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual DEF DEF { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(6)]
        public virtual List<DTP> DTP { get; set; }
        /// <summary>
        /// Loop for Entity
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(6)]
        [Pos(7)]
        public virtual List<Loop_ENT_135> ENTLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual SE SE { get; set; }
    }
}

