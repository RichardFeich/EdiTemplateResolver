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
    /// Loop for Assigned Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_355
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
        /// Loop for Manifest Amendment Details
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual Loop_M13_355 M13Loop { get; set; }
        /// <summary>
        /// Loop for Manifest Bill of Lading Details
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual Loop_M11_355 M11Loop { get; set; }
        /// <summary>
        /// Loop for Export License
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual Loop_X1_355 X1Loop { get; set; }
        /// <summary>
        /// Loop for Reference Number
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(5)]
        public virtual List<Loop_N9_355> N9Loop { get; set; }
        /// <summary>
        /// Loop for Name
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(6)]
        public virtual List<Loop_N1_355> N1Loop { get; set; }
        /// <summary>
        /// Loop for In-bond Identifying Information
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual Loop_M12_355 M12Loop { get; set; }
        /// <summary>
        /// Loop for Vehicle ID
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(8)]
        public virtual List<Loop_VID_355> VIDLoop { get; set; }
    }

    /// <summary>
    /// Loop for Manifest Bill of Lading Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(M11))]
    public class Loop_M11_355
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Manifest Bill of Lading Details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual M11 M11 { get; set; }
        /// <summary>
        /// Remarks
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<K1> K1 { get; set; }
    }

    /// <summary>
    /// Loop for In-bond Identifying Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(M12))]
    public class Loop_M12_355
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// In-bond Identifying Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual M12 M12 { get; set; }
        /// <summary>
        /// Remarks
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<K1> K1 { get; set; }
    }

    /// <summary>
    /// Loop for Manifest Amendment Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(M13))]
    public class Loop_M13_355
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Manifest Amendment Details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual M13 M13 { get; set; }
        /// <summary>
        /// Remarks
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<K1> K1 { get; set; }
    }

    /// <summary>
    /// Loop for Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_355
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
        /// Remarks
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<K1> K1 { get; set; }
        /// <summary>
        /// Loop for Address Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<Loop_N3_355> N3Loop { get; set; }
    }

    /// <summary>
    /// Loop for Quantity and Description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N10))]
    public class Loop_N10_355
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity and Description
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N10 N10 { get; set; }
        /// <summary>
        /// Remarks
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<K1> K1 { get; set; }
    }

    /// <summary>
    /// Loop for Address Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N3))]
    public class Loop_N3_355
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N3 N3 { get; set; }
        /// <summary>
        /// Remarks
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<K1> K1 { get; set; }
    }

    /// <summary>
    /// Loop for Reference Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N9))]
    public class Loop_N9_355
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N9 N9 { get; set; }
        /// <summary>
        /// Remarks
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<K1> K1 { get; set; }
    }

    /// <summary>
    /// Loop for Port of Discharge Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(P4))]
    public class Loop_P4_355
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Port of Discharge Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual P4 P4 { get; set; }
        /// <summary>
        /// Remarks
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<K1> K1 { get; set; }
        /// <summary>
        /// Loop for Assigned Number
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(9999)]
        [Pos(3)]
        public virtual List<Loop_LX_355> LXLoop { get; set; }
    }

    /// <summary>
    /// Loop for Vehicle ID
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(VID))]
    public class Loop_VID_355
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Vehicle ID
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual VID VID { get; set; }
        /// <summary>
        /// Remarks
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<K1> K1 { get; set; }
        /// <summary>
        /// Loop for Quantity and Description
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(3)]
        public virtual List<Loop_N10_355> N10Loop { get; set; }
    }

    /// <summary>
    /// Loop for Export License
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(X1))]
    public class Loop_X1_355
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Export License
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual X1 X1 { get; set; }
        /// <summary>
        /// Remarks
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<K1> K1 { get; set; }
    }

    /// <summary>
    /// U.S. Customs Manifest Rejection
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "355")]
    public class TS355 : EdiMessage
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
        /// Manifest Identifying Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual M10 M10 { get; set; }
        /// <summary>
        /// Remarks
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<K1> K1 { get; set; }
        /// <summary>
        /// Loop for Port of Discharge Information
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(20)]
        [Pos(4)]
        public virtual List<Loop_P4_355> P4Loop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual SE SE { get; set; }
    }
}
