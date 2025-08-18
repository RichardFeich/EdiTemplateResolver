namespace EdiFabric.Templates.X12003040
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.X12;
    using System.Xml.Serialization;
    
    
    /// <summary>
    /// Loop for Assigned Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_214
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
        /// Status Details
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<Q5> Q5 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Marks and Numbers
        /// </summary>
        [DataMember]
        [ListCount(300)]
        [Pos(4)]
        public virtual List<MAN> MAN { get; set; }
        /// <summary>
        /// Lading Exception Code
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<Q7> Q7 { get; set; }
        /// <summary>
        /// Remarks
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(6)]
        public virtual List<K1> K1 { get; set; }
        /// <summary>
        /// Special Handling Instructions
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(7)]
        public virtual List<H3> H3 { get; set; }
        /// <summary>
        /// Signature
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual G86 G86 { get; set; }
        /// <summary>
        /// Shipment Details
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual Q6 Q6 { get; set; }
    }
    
    /// <summary>
    /// Loop for Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_214
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
        [Pos(2)]
        public virtual N2 N2 { get; set; }
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
        /// Contact
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual G61 G61 { get; set; }
        /// <summary>
        /// Date/Time
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual G62 G62 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(7)]
        public virtual List<N9> N9 { get; set; }
    }
    
    /// <summary>
    /// Transportation Carrier Shipment Status Message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "214")]
    public class TS214 : EdiMessage
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
        /// Beginning Segment for Shipment Status Message
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual B10 B10 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [ListCount(300)]
        [Pos(3)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Marks and Numbers
        /// </summary>
        [DataMember]
        [ListCount(300)]
        [Pos(4)]
        public virtual List<MAN> MAN { get; set; }
        /// <summary>
        /// Remarks
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<K1> K1 { get; set; }
        /// <summary>
        /// Loop for Name
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(6)]
        public virtual List<Loop_N1_214> N1Loop { get; set; }
        /// <summary>
        /// Route Information - Motor
        /// </summary>
        [DataMember]
        [ListCount(12)]
        [Pos(7)]
        public virtual List<R3> R3 { get; set; }
        /// <summary>
        /// Loop for Assigned Number
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(8)]
        public virtual List<Loop_LX_214> LXLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual SE SE { get; set; }
    }
}
