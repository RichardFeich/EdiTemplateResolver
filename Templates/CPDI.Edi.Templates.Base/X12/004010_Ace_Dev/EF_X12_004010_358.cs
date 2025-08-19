namespace CPDI.EdiFabric.Templates.Base.X12004000_Ace_Dev
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
    public class Loop_LX_358
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
        /// Conveyance Identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual VID VID { get; set; }
        /// <summary>
        /// Loop for Bill of Lading
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(9999)]
        [Pos(3)]
        public virtual List<Loop_MBL_358> MBLLoop { get; set; }
    }

    /// <summary>
    /// Loop for Bill of Lading
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(MBL))]
    public class Loop_MBL_358
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Bill of Lading
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual MBL MBL { get; set; }
        /// <summary>
        /// Manifest Amendment Details
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual M13 M13 { get; set; }
        /// <summary>
        /// Conveyance Identification
        /// </summary>
        [DataMember]
        [ListCount(500)]
        [Pos(3)]
        public virtual List<VID> VID { get; set; }
    }

    /// <summary>
    /// Loop for U.S. Port Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(P4))]
    public class Loop_P4_358
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// U.S. Port Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual P4 P4 { get; set; }
        /// <summary>
        /// Loop for Assigned Number
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(500)]
        [Pos(2)]
        public virtual List<Loop_LX_358> LXLoop { get; set; }
    }

    /// <summary>
    /// U.S. Customs Consist Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "358")]
    public class TS358 : EdiMessage, ITS358
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
        /// Loop for U.S. Port Information
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(20)]
        [Pos(3)]
        public virtual List<Loop_P4_358> P4Loop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual SE SE { get; set; }
    }
}

