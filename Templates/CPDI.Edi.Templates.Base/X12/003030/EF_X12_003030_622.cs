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
    /// Loop for Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_622
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
        [ListCount(2)]
        [Pos(2)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N4 N4 { get; set; }
    }
    
    /// <summary>
    /// Intermodal Ramp Activity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "622")]
    public class TS622 : EdiMessage
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
        /// Equipment Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual W2A W2A { get; set; }
        /// <summary>
        /// Cross-Reference Equipment
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<NA> NA { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [ListCount(30)]
        [Pos(4)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Seal Numbers
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual M7 M7 { get; set; }
        /// <summary>
        /// Status Details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(6)]
        public virtual Q5 Q5 { get; set; }
        /// <summary>
        /// Note/Special Instruction
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual NTE NTE { get; set; }
        /// <summary>
        /// Protective Service Information
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual PRO PRO { get; set; }
        /// <summary>
        /// Vessel Identification
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual V1 V1 { get; set; }
        /// <summary>
        /// Port
        /// </summary>
        [DataMember]
        [ListCount(8)]
        [Pos(10)]
        public virtual List<R4> R4 { get; set; }
        /// <summary>
        /// Loop for Name
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(11)]
        public virtual List<Loop_N1_622> N1Loop { get; set; }
        /// <summary>
        /// Special Handling Instructions
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(12)]
        public virtual List<H3> H3 { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual SE SE { get; set; }
    }
}
