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
    /// Loop for Scheduled Events
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(IS2))]
    public class Loop_IS2_421
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Scheduled Events
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual IS2 IS2 { get; set; }
        /// <summary>
        /// Waybill Reference
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N8 N8 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Origin Station
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual F9 F9 { get; set; }
        /// <summary>
        /// Destination Station
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual D9 D9 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(6)]
        public virtual List<N1> N1 { get; set; }
        /// <summary>
        /// Stop-off Station
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(7)]
        public virtual List<S9> S9 { get; set; }
        /// <summary>
        /// Route Information
        /// </summary>
        [DataMember]
        [ListCount(13)]
        [Pos(8)]
        public virtual List<R2> R2 { get; set; }
        /// <summary>
        /// Description, Marks and Numbers
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual L5 L5 { get; set; }
        /// <summary>
        /// Special Handling Instructions
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(10)]
        public virtual List<H3> H3 { get; set; }
    }

    /// <summary>
    /// Estimated Time of Arrival and Car Scheduling
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "421")]
    public class TS421 : EdiMessage
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
        /// Beginning Segment for Estimated Time of Arrival and Car Scheduling
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual IS1 IS1 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Loop for Scheduled Events
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(20)]
        [Pos(4)]
        public virtual List<Loop_IS2_421> IS2Loop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual SE SE { get; set; }
    }
}
