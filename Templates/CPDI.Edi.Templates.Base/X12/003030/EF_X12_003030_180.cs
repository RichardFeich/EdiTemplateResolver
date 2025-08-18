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
    /// Loop for Baseline Item Data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(BLI))]
    public class Loop_BLI_180
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Baseline Item Data
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual BLI BLI { get; set; }
        /// <summary>
        /// Product/Item Description
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(2)]
        public virtual List<PID> PID { get; set; }
        /// <summary>
        /// Return Disposition Reason
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual RDR RDR { get; set; }
        /// <summary>
        /// Allowance, Charge or Service
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(4)]
        public virtual List<ITA> ITA { get; set; }
        /// <summary>
        /// Purchase Order Reference
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual PRF PRF { get; set; }
        /// <summary>
        /// Loop for Name
        /// </summary>
        [DataMember]
        [ListCount(200)]
        [Pos(6)]
        public virtual List<Loop_N1_180> N1Loop { get; set; }
    }
    
    /// <summary>
    /// Loop for Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_180
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
        [ListCount(2)]
        [Pos(2)]
        public virtual List<N2> N2 { get; set; }
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
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(5)]
        public virtual List<PER> PER { get; set; }
    }
    
    /// <summary>
    /// Return Merchandise Authorization and Notification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "180")]
    public class TS180 : EdiMessage
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
        /// Return Disposition Reason
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual RDR RDR { get; set; }
        /// <summary>
        /// Purchase Order Reference
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual PRF PRF { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(6)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Administrative Communications Contact
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(7)]
        public virtual List<PER> PER { get; set; }
        /// <summary>
        /// Allowance, Charge or Service
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(8)]
        public virtual List<ITA> ITA { get; set; }
        /// <summary>
        /// Marking, Packaging, Loading
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(9)]
        public virtual List<PKG> PKG { get; set; }
        /// <summary>
        /// Carrier Details (Quantity and Weight)
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(10)]
        public virtual List<TD1> TD1 { get; set; }
        /// <summary>
        /// Carrier Details (Routing Sequence/Transit Time)
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(11)]
        public virtual List<TD5> TD5 { get; set; }
        /// <summary>
        /// Loop for Name
        /// </summary>
        [DataMember]
        [ListCount(200)]
        [Pos(12)]
        public virtual List<Loop_N1_180> N1Loop { get; set; }
        /// <summary>
        /// Loop for Baseline Item Data
        /// </summary>
        [DataMember]
        [ListCount(500)]
        [Pos(13)]
        public virtual List<Loop_BLI_180> BLILoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual SE SE { get; set; }
    }
}
