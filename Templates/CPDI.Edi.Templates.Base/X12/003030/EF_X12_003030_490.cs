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
    /// Loop for Shipment Conditions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(CD))]
    public class Loop_CD_490
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
        /// External Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual PRI PRI { get; set; }
    }

    /// <summary>
    /// Loop for Geography
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(GY))]
    public class Loop_GY_490
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Geography
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual GY GY { get; set; }
        /// <summary>
        /// External Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual PRI PRI { get; set; }
    }

    /// <summary>
    /// Loop for Product (Commodity)
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PR))]
    public class Loop_PR_490
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Product (Commodity)
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PR PR { get; set; }
        /// <summary>
        /// External Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual PRI PRI { get; set; }
    }

    /// <summary>
    /// Loop for Patron
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(PT))]
    public class Loop_PT_490
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Patron
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PT PT { get; set; }
        /// <summary>
        /// External Reference Identifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual PRI PRI { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual N3 N3 { get; set; }
        /// <summary>
        /// Geographic Location
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N4 N4 { get; set; }
    }

    /// <summary>
    /// Rate Group Definition
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "490")]
    public class TS490 : EdiMessage
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
        /// Docket Header
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual DK DK { get; set; }
        /// <summary>
        /// External Reference Identifier
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(8)]
        [Pos(3)]
        public virtual List<PRI> PRI { get; set; }
        /// <summary>
        /// Group Header
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual GH GH { get; set; }
        /// <summary>
        /// External Reference Identifier
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(5)]
        public virtual List<PRI> PRI2 { get; set; }
        /// <summary>
        /// Term Text
        /// </summary>
        [DataMember]
        [ListCount(500)]
        [Pos(6)]
        public virtual List<TT> TT { get; set; }
        /// <summary>
        /// Loop for Geography
        /// </summary>
        [DataMember]
        [ListCount(500)]
        [Pos(7)]
        public virtual List<Loop_GY_490> GYLoop { get; set; }
        /// <summary>
        /// Loop for Product (Commodity)
        /// </summary>
        [DataMember]
        [ListCount(500)]
        [Pos(8)]
        public virtual List<Loop_PR_490> PRLoop { get; set; }
        /// <summary>
        /// Loop for Patron
        /// </summary>
        [DataMember]
        [ListCount(500)]
        [Pos(9)]
        public virtual List<Loop_PT_490> PTLoop { get; set; }
        /// <summary>
        /// Loop for Shipment Conditions
        /// </summary>
        [DataMember]
        [ListCount(500)]
        [Pos(10)]
        public virtual List<Loop_CD_490> CDLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual SE SE { get; set; }
    }
}
