namespace EdiFabric.Templates.X12003060
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
    /// Loop for Shipment Conditions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CD))]
    public class Loop_CD_433
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Shipment Conditions
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CD CD { get; set; }
        /// <summary>
        /// Standard Transportation Commodity Code Identification
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<SID> SID { get; set; }
        /// <summary>
        /// Transportation Carrier Identification
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(3)]
        public virtual List<BLR> BLR { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [ListCount(50)]
        [Pos(4)]
        public virtual List<N4> N4 { get; set; }
    }
    
    /// <summary>
    /// Loop for Station Codes Segment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(SMS))]
    public class Loop_SMS_433
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Station Codes Segment
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SMS SMS { get; set; }
        /// <summary>
        /// Cross Reference
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual SMR SMR { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Price Authority Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual PI PI { get; set; }
        /// <summary>
        /// Loop for Shipment Conditions
        /// </summary>
        [DataMember]
        [ListCount(150)]
        [Pos(5)]
        public virtual List<Loop_CD_433> CDLoop { get; set; }
    }
    
    /// <summary>
    /// Railroad Reciprocal Switch File
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "433")]
    public class TS433 : EdiMessage
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
        /// Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        /// Additional Name Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(4)]
        public virtual List<N2> N2 { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual N3 N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        /// Loop for Station Codes Segment
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(4)]
        [Pos(7)]
        public virtual List<Loop_SMS_433> SMSLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual SE SE { get; set; }
    }
}
