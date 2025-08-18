namespace EdiFabric.Templates.X12005040
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
    /// Loop for Transaction Set Response Header
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(AK2))]
    public class Loop_AK2_999
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transaction Set Response Header
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual AK2 AK2 { get; set; }
        /// <summary>
        /// Loop for Implementation Data Segment Note
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<Loop_IK3_999> IK3Loop { get; set; }
        /// <summary>
        /// Implementation Transaction Set Response Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual IK5 IK5 { get; set; }
    }

    /// <summary>
    /// Loop for Implementation Data Segment Note
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(IK3))]
    public class Loop_IK3_999
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Implementation Data Segment Note
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual IK3 IK3 { get; set; }
        /// <summary>
        /// Context
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<CTX> CTX { get; set; }
        /// <summary>
        /// Loop for Implementation Data Element Note
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_IK4_999> IK4Loop { get; set; }
    }

    /// <summary>
    /// Loop for Implementation Data Element Note
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(IK4))]
    public class Loop_IK4_999
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Implementation Data Element Note
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual IK4 IK4 { get; set; }
        /// <summary>
        /// Context
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<CTX> CTX { get; set; }
    }

    /// <summary>
    /// Implementation Acknowledgment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "999")]
    public class TS999 : EdiMessage
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
        /// Functional Group Response Header
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual AK1 AK1 { get; set; }
        /// <summary>
        /// Loop for Transaction Set Response Header
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_AK2_999> AK2Loop { get; set; }
        /// <summary>
        /// Functional Group Response Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual AK9 AK9 { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual SE SE { get; set; }
    }
}
