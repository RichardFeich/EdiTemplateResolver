namespace EdiFabric.Templates.X12003020
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
    /// U.S. Customs Automated Manifest Archive Status (Ocean)
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "354")]
    public class TS354 : EdiMessage
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
        /// Automated Manifest Archive Status Details
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual X01 X01 { get; set; }
        /// <summary>
        /// Automated Manifest Bills Eligible/Overdue Archive Details
        /// </summary>
        [DataMember]
        [ListCount(9999)]
        [Pos(5)]
        public virtual List<X02> X02 { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual SE SE { get; set; }
    }
}
