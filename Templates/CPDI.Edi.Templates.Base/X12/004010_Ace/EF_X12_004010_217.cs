namespace CPDI.EdiFabric.Templates.Base.X12004000_Ace
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
    /// Loop for Loop Header
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LS))]
    public class Loop_LS_217
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Loop Header
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LS LS { get; set; }
        /// <summary>
        /// Loop for Name
        /// </summary>
        [DataMember]
        [ListCount(999999)]
        [Pos(2)]
        public virtual List<Loop_N1_217_2> N1Loop { get; set; }
        /// <summary>
        /// Loop Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual LE LE { get; set; }
    }

    /// <summary>
    /// Loop for Loop Header
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LS))]
    public class Loop_LS_217_2
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Loop Header
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LS LS { get; set; }
        /// <summary>
        /// Loop for Assigned Number
        /// </summary>
        [DataMember]
        [ListCount(999999)]
        [Pos(2)]
        public virtual List<Loop_LX_217> LXLoop { get; set; }
        /// <summary>
        /// Loop Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual LE LE { get; set; }
    }

    /// <summary>
    /// Loop for Assigned Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_217
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
        [ListCount(3)]
        [Pos(2)]
        public virtual List<N1> N1 { get; set; }
        /// <summary>
        /// Geography
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(3)]
        public virtual List<GY> GY { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(4)]
        public virtual List<N4> N4 { get; set; }
        /// <summary>
        /// Service Description
        /// </summary>
        [DataMember]
        [Required]
        [Pos(5)]
        public virtual SV SV { get; set; }
        /// <summary>
        /// Carrier Restriction
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(6)]
        public virtual List<RST> RST { get; set; }
    }

    /// <summary>
    /// Loop for Assigned Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_217_2
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
        [ListCount(2)]
        [Pos(2)]
        public virtual List<N1> N1 { get; set; }
        /// <summary>
        /// Geography
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(3)]
        public virtual List<GY> GY { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(4)]
        public virtual List<N4> N4 { get; set; }
        /// <summary>
        /// Service Description
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual SV SV { get; set; }
        /// <summary>
        /// Carrier Restriction
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(6)]
        public virtual List<RST> RST { get; set; }
    }

    /// <summary>
    /// Loop for Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_217
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
        [Pos(4)]
        public virtual N9 N9 { get; set; }
        /// <summary>
        /// Contact
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual G61 G61 { get; set; }
    }

    /// <summary>
    /// Loop for Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_217_2
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
        /// Geography
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(2)]
        public virtual List<GY> GY { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(3)]
        public virtual List<N4> N4 { get; set; }
        /// <summary>
        /// Loop for Loop Header
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual Loop_LS_217_2 LSLoop { get; set; }
    }

    /// <summary>
    /// Motor Carrier Loading and Route Guide
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "217")]
    public class TS217 : EdiMessage, ITS217
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
        /// Transportation Carrier Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BLR BLR { get; set; }
        /// <summary>
        /// Loop for Name
        /// </summary>
        [DataMember]
        [ListCount(999999)]
        [Pos(3)]
        public virtual List<Loop_N1_217> N1Loop { get; set; }
        /// <summary>
        /// Loop for Loop Header
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual Loop_LS_217 LSLoop { get; set; }
        /// <summary>
        /// Loop for Assigned Number
        /// </summary>
        [DataMember]
        [ListCount(999999)]
        [Pos(5)]
        public virtual List<Loop_LX_217_2> LXLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual SE SE { get; set; }
    }
}

