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
    /// Loop for Origin Station
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(F9))]
    public class Loop_F9_422
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Origin Station
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual F9 F9 { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Route Information
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<R2> R2 { get; set; }
        /// <summary>
        /// Loop for Shipper's Car Ordered
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(9999)]
        [Pos(4)]
        public virtual List<Loop_SCO_422> SCOLoop { get; set; }
    }

    /// <summary>
    /// Loop for Assigned Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_422
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
        /// Date/Time
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<G62> G62 { get; set; }
        /// <summary>
        /// Destination Station
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual D9 D9 { get; set; }
        /// <summary>
        /// Loop for Origin Station
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(31)]
        [Pos(4)]
        public virtual List<Loop_F9_422> F9Loop { get; set; }
    }

    /// <summary>
    /// Loop for Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_422
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
        [Pos(2)]
        public virtual N3 N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(4)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [ListCount(4)]
        [Pos(5)]
        public virtual List<N9> N9 { get; set; }
    }

    /// <summary>
    /// Loop for Equipment Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N7))]
    public class Loop_N7_422
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Equipment Details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N7 N7 { get; set; }
        /// <summary>
        /// Cross-Reference Equipment
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual NA NA { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(3)]
        public virtual List<N9> N9 { get; set; }
    }

    /// <summary>
    /// Loop for Shipper's Car Ordered
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SCO))]
    public class Loop_SCO_422
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Shipper's Car Ordered
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SCO SCO { get; set; }
        /// <summary>
        /// Date/Time
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual G62 G62 { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [ListCount(4)]
        [Pos(3)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Loop for Equipment Details
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(4)]
        public virtual List<Loop_N7_422> N7Loop { get; set; }
    }

    /// <summary>
    /// Shipper's Car Order
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "422")]
    public class TS422 : EdiMessage, ITS422
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
        /// Beginning Segment for Shipper's Car Order
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BCQ BCQ { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual QTY QTY { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(5)]
        public virtual List<NTE> NTE { get; set; }
        /// <summary>
        /// Loop for Name
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(5)]
        [Pos(6)]
        public virtual List<Loop_N1_422> N1Loop { get; set; }
        /// <summary>
        /// Loop for Assigned Number
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(31)]
        [Pos(7)]
        public virtual List<Loop_LX_422> LXLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual SE SE { get; set; }
    }
}

