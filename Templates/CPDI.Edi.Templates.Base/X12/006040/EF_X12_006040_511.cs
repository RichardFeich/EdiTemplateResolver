namespace EdiFabric.Templates.X12006040
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.X12;


    [Serializable()]
    [DataContract()]
    [Group(typeof(FA1))]
    public class Loop_FA1_511
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Type of Financial Accounting Data
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual FA1 FA1 { get; set; }
        /// <summary>
        // Accounting Data
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<FA2> FA2 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(LM))]
    public class Loop_LM_511
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Code Source Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LM LM { get; set; }
        /// <summary>
        // Industry Code Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(100)]
        [Pos(2)]
        public virtual List<LQ> LQ { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(LX))]
    public class Loop_LX_511
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Transaction Set Line Number
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LX LX { get; set; }
        /// <summary>
        // Extended Reference Information
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(99999)]
        [Pos(2)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        // Baseline Item Data
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<PO1> PO1 { get; set; }
        /// <summary>
        // Paperwork
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual PWK PWK { get; set; }
        /// <summary>
        // Demand Detail
        /// </summary>
        [DataMember]
        [ListCount(100)]
        [Pos(5)]
        public virtual List<DD> DD { get; set; }
        /// <summary>
        // Furnished Goods and Services
        /// </summary>
        [DataMember]
        [Pos(6)]
        public virtual GF GF { get; set; }
        /// <summary>
        // Date/Time
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(7)]
        public virtual List<G62> G62 { get; set; }
        /// <summary>
        // Marks and Numbers Information
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(8)]
        public virtual List<MAN> MAN { get; set; }
        /// <summary>
        // Item Identification
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(9)]
        public virtual List<LIN> LIN { get; set; }
        /// <summary>
        // Measurements
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(10)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        // Line Item Detail - Description
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(11)]
        public virtual List<G69> G69 { get; set; }
        /// <summary>
        // Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(12)]
        public virtual List<NTE> NTE { get; set; }
        [DataMember]
        [ListCount(50)]
        [Pos(13)]
        public virtual List<Loop_LM_511> LoopLM { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(14)]
        public virtual List<Loop_QTY_511> LoopQTY { get; set; }
        [DataMember]
        [ListCount(100)]
        [Pos(15)]
        public virtual List<Loop_N1_511> LoopN1 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(16)]
        public virtual List<Loop_REF_511> LoopREF { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(17)]
        public virtual List<Loop_FA1_511> LoopFA1 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(N1))]
    public class Loop_N1_511
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Party Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        // Additional Name Information
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<N2> N2 { get; set; }
        /// <summary>
        // Party Location
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(3)]
        public virtual List<N3> N3 { get; set; }
        /// <summary>
        // Geographic Location
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N4 N4 { get; set; }
        /// <summary>
        // Contact
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(5)]
        public virtual List<G61> G61 { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(QTY))]
    public class Loop_QTY_511
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Quantity Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual QTY QTY { get; set; }
        [DataMember]
        [ListCount(50)]
        [Pos(2)]
        public virtual List<Loop_LM_511> LoopLM { get; set; }
    }

    [Serializable()]
    [DataContract()]
    [Group(typeof(REF))]
    public class Loop_REF_511
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Reference Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual REF REF { get; set; }
        /// <summary>
        // Date/Time
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<G62> G62 { get; set; }
        /// <summary>
        // Extended Reference Information
        /// </summary>
        [DataMember]
        [ListCount(99999)]
        [Pos(3)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        // Party Identification
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual N1 N1 { get; set; }
        /// <summary>
        // Port or Terminal
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual R4 R4 { get; set; }
        [DataMember]
        [ListCount(50)]
        [Pos(6)]
        public virtual List<Loop_LM_511> LoopLM { get; set; }
    }

    /// <summary>
    // Requisition
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "511")]
    public class TS511 : EdiMessage
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        // Transaction Set Header
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ST ST { get; set; }
        /// <summary>
        // Beginning Segment for Material Management
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BR BR { get; set; }
        /// <summary>
        // Date/Time
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(3)]
        public virtual List<G62> G62 { get; set; }
        /// <summary>
        // Note/Special Instruction
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(4)]
        public virtual List<NTE> NTE { get; set; }
        [DataMember]
        [ListCount(50)]
        [Pos(5)]
        public virtual List<Loop_LM_511> LoopLM { get; set; }
        [DataMember]
        [Required]
        [ListCount(20)]
        [Pos(6)]
        public virtual List<Loop_N1_511> LoopN1 { get; set; }
        [DataMember]
        [ListCount(99999)]
        [Pos(7)]
        public virtual List<Loop_LX_511> LoopLX { get; set; }
        /// <summary>
        // Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Required]
        [Pos(8)]
        public virtual SE SE { get; set; }
    }
}
