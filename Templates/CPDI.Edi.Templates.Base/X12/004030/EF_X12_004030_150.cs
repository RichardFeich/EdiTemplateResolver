namespace CPDI.EdiFabric.Templates.Base.X12004030
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;


    /// <summary>
    /// Loop for Form Group
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(FGS))]
    public class Loop_FGS_150
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Form Group
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual FGS FGS { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual DTP DTP { get; set; }
        /// <summary>
        /// Loop for Tax Rate
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(100000)]
        [Pos(3)]
        public virtual List<Loop_TRS_150> TRSLoop { get; set; }
    }

    /// <summary>
    /// Loop for Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_150
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
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual DTP DTP { get; set; }
    }

    /// <summary>
    /// Loop for Tax Form
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TFS))]
    public class Loop_TFS_150
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Tax Form
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual TFS TFS { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual DTP DTP { get; set; }
        /// <summary>
        /// Loop for Tax Rate
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(100000)]
        [Pos(3)]
        public virtual List<Loop_TRS_150> TRSLoop { get; set; }
        /// <summary>
        /// Loop for Form Group
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(1000)]
        [Pos(4)]
        public virtual List<Loop_FGS_150> FGSLoop { get; set; }
    }

    /// <summary>
    /// Loop for Tax Rate
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TRS))]
    public class Loop_TRS_150
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Tax Rate
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual TRS TRS { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<AMT> AMT { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Loop for Name
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(4)]
        public virtual List<Loop_N1_150> N1Loop { get; set; }
    }

    /// <summary>
    /// Tax Rate Notification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "150")]
    public class TS150 : EdiMessage, ITS150
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
        /// Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        /// Additional Name Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(4)]
        public virtual List<N2> N2 { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(5)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(7)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual DTP DTP { get; set; }
        /// <summary>
        /// Loop for Tax Form
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(1000)]
        [Pos(9)]
        public virtual List<Loop_TFS_150> TFSLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual SE SE { get; set; }
    }
}

