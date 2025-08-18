namespace EdiFabric.Templates.X12003040
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
    /// Loop for Form Group
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(FGS))]
    public class Loop_FGS_151
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Form Group
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual FGS FGS { get; set; }
        /// <summary>
        /// Problem Identification
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(2)]
        public virtual List<PBI> PBI { get; set; }
    }
    
    /// <summary>
    /// Loop for Tax Form
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(typeof(TFS))]
    public class Loop_TFS_151
    {
        
        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Tax Form
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual TFS TFS { get; set; }
        /// <summary>
        /// Reference Numbers
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(2)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Problem Identification
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(3)]
        public virtual List<PBI> PBI { get; set; }
        /// <summary>
        /// Loop for Form Group
        /// </summary>
        [DataMember]
        [ListCount(100000)]
        [Pos(4)]
        public virtual List<Loop_FGS_151> FGSLoop { get; set; }
    }
    
    /// <summary>
    /// Electronic Filing of Tax Return Data Acknowledgment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("X12", "151")]
    public class TS151 : EdiMessage
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
        /// Beginning Tax Acknowledgment
        /// </summary>
        [DataMember]
        [Required]
        [Pos(2)]
        public virtual BTA BTA { get; set; }
        /// <summary>
        /// Beginning Tax Information
        /// </summary>
        [DataMember]
        [Required]
        [Pos(3)]
        public virtual BTI BTI { get; set; }
        /// <summary>
        /// Reference Numbers
        /// </summary>
        [DataMember]
        [ListCount(10)]
        [Pos(4)]
        public virtual List<REF> REF { get; set; }
        /// <summary>
        /// Problem Identification
        /// </summary>
        [DataMember]
        [ListCount(1000)]
        [Pos(5)]
        public virtual List<PBI> PBI { get; set; }
        /// <summary>
        /// Loop for Tax Form
        /// </summary>
        [DataMember]
        [ListCount(100000)]
        [Pos(6)]
        public virtual List<Loop_TFS_151> TFSLoop { get; set; }
        /// <summary>
        /// Transaction Set Trailer
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual SE SE { get; set; }
    }
}
