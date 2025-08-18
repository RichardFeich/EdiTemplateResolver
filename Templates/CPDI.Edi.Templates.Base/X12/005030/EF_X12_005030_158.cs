namespace EdiFabric.Templates.X12005030
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
    /// Loop for Date or Time or Period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(DTP))]
    public class Loop_DTP_158
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date or Time or Period
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual DTP DTP { get; set; }
        /// <summary>
        /// Loop for Transaction Set Line Number
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual List<Loop_LX_158> LXLoop { get; set; }
    }
    
    /// <summary>
    /// Loop for Transaction Set Line Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_158
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transaction Set Line Number
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LX LX { get; set; }
        /// <summary>
        /// Location ID Component
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual List<NX2> NX2 { get; set; }
        /// <summary>
        /// Property Location
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual PPA PPA { get; set; }
        /// <summary>
        /// Tax Authority
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual List<TA> TA { get; set; }
        /// <summary>
        /// Action or Status Indicator
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual ASI ASI { get; set; }
    }
    
    /// <summary>
    /// Tax Jurisdiction Sourcing
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "158")]
    public class TS158 : EdiMessage
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
        /// Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<N1> N1 { get; set; }
        /// <summary>
        /// Loop for Date or Time or Period
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual List<Loop_DTP_158> DTPLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual SE SE { get; set; }
    }
}
