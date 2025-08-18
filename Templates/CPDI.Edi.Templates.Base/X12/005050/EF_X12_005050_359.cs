namespace EdiFabric.Templates.X12005050
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
    /// Loop for Individual or Organizational Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(NM1))]
    public class Loop_NM1_359
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Individual or Organizational Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NM1 NM1 { get; set; }
        /// <summary>
        /// Demographic Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual DMG DMG { get; set; }
        /// <summary>
        /// Additional Demographic Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual DMA DMA { get; set; }
        /// <summary>
        /// Reference Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(4)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Party Location
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
        /// Request Validation
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual AAA AAA { get; set; }
    }

    /// <summary>
    /// Loop for Vehicle Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(VEH))]
    public class Loop_VEH_359
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Vehicle Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual VEH VEH { get; set; }
        /// <summary>
        /// Conveyance Insurance Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual CII CII { get; set; }
        /// <summary>
        /// Request Validation
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual AAA AAA { get; set; }
    }

    /// <summary>
    /// Loop for Conveyance Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(VID))]
    public class Loop_VID_359
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Conveyance Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual VID VID { get; set; }
        /// <summary>
        /// Conveyance Insurance Information
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual CII CII { get; set; }
        /// <summary>
        /// Request Validation
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual AAA AAA { get; set; }
    }

    /// <summary>
    /// Customs Customer Profile Management
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "359")]
    public class TS359 : EdiMessage
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
        /// Customs Profile Management Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual CPM CPM { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual PER PER { get; set; }
        /// <summary>
        /// Loop for Individual or Organizational Name
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(4)]
        public virtual List<Loop_NM1_359> NM1Loop { get; set; }
        /// <summary>
        /// Loop for Vehicle Information
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(5)]
        public virtual List<Loop_VEH_359> VEHLoop { get; set; }
        /// <summary>
        /// Loop for Conveyance Identification
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(6)]
        public virtual List<Loop_VID_359> VIDLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual SE SE { get; set; }
    }
}
