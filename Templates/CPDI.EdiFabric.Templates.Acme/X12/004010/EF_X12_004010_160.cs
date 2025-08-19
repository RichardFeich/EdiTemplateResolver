namespace CPDI.EdiFabric.Templates.X12004010.Acme
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;


    /// <summary>
    /// Loop for Automatic Equipment Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(EI))]
    public class Loop_EI_160
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Automatic Equipment Identification
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual EI EI { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(2)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(3)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(4)]
        public virtual List<DTM> DTM { get; set; }
        /// <summary>
        /// Loop for Automatic Equipment Tag Status Information
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(5)]
        public virtual List<Loop_TSI_160> TSILoop { get; set; }
    }

    /// <summary>
    /// Loop for Quantity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(QTY))]
    public class Loop_QTY_160
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual QTY QTY { get; set; }
        /// <summary>
        /// Date/Time Reference
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
    }

    /// <summary>
    /// Loop for Automatic Equipment Tag Status Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TSI))]
    public class Loop_TSI_160
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Automatic Equipment Tag Status Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual TSI TSI { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(2)]
        public virtual List<YNQ> YNQ { get; set; }
        /// <summary>
        /// Industry Code
        /// </summary>
        [DataMember]
        [ListCount(25)]
        [Pos(3)]
        public virtual List<LQ> LQ { get; set; }
        /// <summary>
        /// Loop for Quantity
        /// </summary>
        [DataMember]
        [ListCount(20)]
        [Pos(4)]
        public virtual List<Loop_QTY_160> QTYLoop { get; set; }
    }

    /// <summary>
    /// Transportation Automatic Equipment Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "160")]
    public class TS160 : EdiMessage, ITS160
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
        /// Beginning Segment for Advance Consist and Transportation Automatic Equipment ID
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BAX BAX { get; set; }
        /// <summary>
        /// Automatic Equipment Identification Site Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual AES AES { get; set; }
        /// <summary>
        /// Yes/No Question
        /// </summary>
        [DataMember]
        [Required]
        [Pos(4)]
        public virtual YNQ YNQ { get; set; }
        /// <summary>
        /// Reference Identification
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(5)]
        public virtual List<N9> N9 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [ListCount(5)]
        [Pos(6)]
        public virtual List<QTY> QTY { get; set; }
        /// <summary>
        /// Measurements
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(7)]
        public virtual List<MEA> MEA { get; set; }
        /// <summary>
        /// Equipment Information Summary
        /// </summary>
        [DataMember]
        [ListCount(16)]
        [Pos(8)]
        public virtual List<AEI> AEI { get; set; }
        /// <summary>
        /// Loop for Automatic Equipment Identification
        /// </summary>
        [DataMember]
        [Required]
        [ListCount(500)]
        [Pos(9)]
        public virtual List<Loop_EI_160> EILoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual SE SE { get; set; }
    }
}

