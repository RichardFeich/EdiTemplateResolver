namespace EdiFabric.Templates.X12003030
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
    /// Loop for Hazardous Material
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(H1))]
    public class Loop_H1_300
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Hazardous Material
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual H1 H1 { get; set; }
        /// <summary>
        /// Additional Hazardous Material Description
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<H2> H2 { get; set; }
    }
    
    /// <summary>
    /// Loop for Assigned Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_300
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
        /// Equipment Details
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual N7 N7 { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual DTM DTM { get; set; }
        /// <summary>
        /// Line Item - Quantity and Weight
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual L0 L0 { get; set; }
        /// <summary>
        /// Description, Marks and Numbers
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual L5 L5 { get; set; }
        /// <summary>
        /// Measurement
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual L4 L4 { get; set; }
        /// <summary>
        /// Loop for Hazardous Material
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(7)]
        public virtual List<Loop_H1_300> H1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_300
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
    }
    
    /// <summary>
    /// Loop for Port
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(R4))]
    public class Loop_R4_300
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Port
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual R4 R4 { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(15)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
    }
    
    /// <summary>
    /// Reservation (Booking Request) (Ocean)
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "300")]
    public class TS300 : EdiMessage
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
        /// Beginning Segment for Booking or Pick-up/Delivery
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual B1 B1 { get; set; }
        /// <summary>
        /// Authentication
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<Y6> Y6 { get; set; }
        /// <summary>
        /// Priority
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual Y7 Y7 { get; set; }
        /// <summary>
        /// Space Reservation Request
        /// </summary>
        [DataMember]
        [Required]
        [Pos(5)]
        public virtual Y1 Y1 { get; set; }
        /// <summary>
        /// Container Details
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(6)]
        public virtual List<Y2> Y2 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(7)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Loop for Name
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(10)]
        [Pos(8)]
        public virtual List<Loop_N1_300> N1Loop { get; set; }
        /// <summary>
        /// Contact
        /// </summary>
        [DataMember]
        [ListCount(3)]
        [Pos(9)]
        public virtual List<G61> G61 { get; set; }
        /// <summary>
        /// Loop for Port
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(20)]
        [Pos(10)]
        public virtual List<Loop_R4_300> R4Loop { get; set; }
        /// <summary>
        /// Equipment and Temperature
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual W09 W09 { get; set; }
        /// <summary>
        /// Special Handling Instructions
        /// </summary>
        [DataMember]
        [ListCount(6)]
        [Pos(12)]
        public virtual List<H3> H3 { get; set; }
        /// <summary>
        /// Loop for Assigned Number
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(999)]
        [Pos(13)]
        public virtual List<Loop_LX_300> LXLoop { get; set; }
        /// <summary>
        /// Vessel Identification
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(14)]
        public virtual List<V1> V1 { get; set; }
        /// <summary>
        /// Event Detail
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(15)]
        public virtual List<V9> V9 { get; set; }
        /// <summary>
        /// Remarks
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(16)]
        public virtual List<K1> K1 { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(17)]
        public virtual SE SE { get; set; }
    }
}
