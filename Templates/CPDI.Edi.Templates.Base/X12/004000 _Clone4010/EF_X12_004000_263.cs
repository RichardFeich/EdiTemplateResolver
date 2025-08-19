namespace EdiFabric.Templates.X12004000
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
    /// Loop for Period
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(G63))]
    public class Loop_G63_263
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Period
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual G63 G63 { get; set; }
        /// <summary>
        /// Percent Amounts
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual PCT PCT { get; set; }
    }

    /// <summary>
    /// Loop for Assigned Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_263
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
        /// Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        /// Loop for Reference Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual List<Loop_REF_263> REFLoop { get; set; }
    }

    /// <summary>
    /// Loop for Reference Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(REF))]
    public class Loop_REF_263
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual REF REF { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        /// Mortgage Insurance Response
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual MIR MIR { get; set; }
        /// <summary>
        /// Tax Information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(4)]
        public virtual List<TXI> TXI { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Loop for Period
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual List<Loop_G63_263> G63Loop { get; set; }
    }

    /// <summary>
    /// Residential Mortgage Insurance Application Response
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "263")]
    public class TS263 : EdiMessage
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
        [ListCount(2)]
        [Pos(3)]
        public virtual List<N1> N1 { get; set; }
        /// <summary>
        /// Loop for Assigned Number
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual List<Loop_LX_263> LXLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual SE SE { get; set; }
    }
}
