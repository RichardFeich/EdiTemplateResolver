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
    /// Permit To Transfer Request
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "356")]
    public class TS356 : EdiMessage
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
        /// Manifest Identifying Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual M10 M10 { get; set; }
        /// <summary>
        /// Port of Discharge Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual P4 P4 { get; set; }
        /// <summary>
        /// Permit to Transfer Request Details
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(999)]
        [Pos(4)]
        public virtual List<M20> M20 { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual SE SE { get; set; }
    }
}
