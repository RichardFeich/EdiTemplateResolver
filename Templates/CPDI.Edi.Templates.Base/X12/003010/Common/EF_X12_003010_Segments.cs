namespace EdiFabric.Templates.X12003010
{
    using System;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi.X12;


    /// <summary>
    /// Request Validation
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AAA")]
    public class AAA : I_AAA
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Validity Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("900", typeof(X12_ID_900))]
        [Pos(1)]
        public string ValidityCode_01 { get; set; }
        /// <summary>
        /// Association Qualifier Code
        /// </summary>
        [DataMember]
        [DataElement("559", typeof(X12_ID_559))]
        [Pos(2)]
        public string AssociationQualifierCode_02 { get; set; }
        /// <summary>
        /// Reject Reason Code
        /// </summary>
        [DataMember]
        [DataElement("901", typeof(X12_ID_901))]
        [Pos(3)]
        public string RejectReasonCode_03 { get; set; }
        /// <summary>
        /// Follow-up Action Code
        /// </summary>
        [DataMember]
        [DataElement("889", typeof(X12_ID_889))]
        [Pos(4)]
        public string FollowupActionCode_04 { get; set; }
    }

    /// <summary>
    /// Line Item Acknowledgment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ACK")]
    public class ACK : I_ACK
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Line Item Status Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("668", typeof(X12_ID_668))]
        [Pos(1)]
        public string LineItemStatusCode_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Conditional(3)]
        [StringLength(1, 10)]
        [DataElement("380", typeof(X12_R))]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(3)]
        public string UnitofMeasurementCode_03 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Conditional(5)]
        [DataElement("374", typeof(X12_ID_374))]
        [Pos(4)]
        public string DateTimeQualifier_04 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(5)]
        public string Date_05 { get; set; }
        /// <summary>
        /// Request Reference Number
        /// </summary>
        [DataMember]
        [StringLength(1, 45)]
        [DataElement("326", typeof(X12_AN))]
        [Pos(6)]
        public string RequestReferenceNumber_06 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(8)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(7)]
        public string ProductServiceIDQualifier_07 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(8)]
        public string ProductServiceID_08 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(10)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(9)]
        public string ProductServiceIDQualifier_09 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(10)]
        public string ProductServiceID_10 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(12)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(11)]
        public string ProductServiceIDQualifier_11 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(12)]
        public string ProductServiceID_12 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(14)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(13)]
        public string ProductServiceIDQualifier_13 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(14)]
        public string ProductServiceID_14 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(16)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(15)]
        public string ProductServiceIDQualifier_15 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(16)]
        public string ProductServiceID_16 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(18)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(17)]
        public string ProductServiceIDQualifier_17 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(18)]
        public string ProductServiceID_18 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(20)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(19)]
        public string ProductServiceIDQualifier_19 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(20)]
        public string ProductServiceID_20 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(22)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(21)]
        public string ProductServiceIDQualifier_21 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(22)]
        public string ProductServiceID_22 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(24)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(23)]
        public string ProductServiceIDQualifier_23 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(24)]
        public string ProductServiceID_24 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(26)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(25)]
        public string ProductServiceIDQualifier_25 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(26)]
        public string ProductServiceID_26 { get; set; }
    }

    /// <summary>
    /// Account Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ACT")]
    public class ACT : I_ACT
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Account Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("508", typeof(X12_AN))]
        [Pos(1)]
        public string AccountNumber_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(2)]
        public string Name_02 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Paired(4)]
        [DataElement("66", typeof(X12_ID_66))]
        [Pos(3)]
        public string IdentificationCodeQualifier_03 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [StringLength(2, 17)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(4)]
        public string IdentificationCode_04 { get; set; }
        /// <summary>
        /// Account Number Qualifier
        /// </summary>
        [DataMember]
        [Paired(6)]
        [DataElement("569", typeof(X12_ID_569))]
        [Pos(5)]
        public string AccountNumberQualifier_05 { get; set; }
        /// <summary>
        /// Account Number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("508", typeof(X12_AN))]
        [Pos(6)]
        public string AccountNumber_06 { get; set; }
        /// <summary>
        /// Free Form Message
        /// </summary>
        [DataMember]
        [Conditional(5)]
        [StringLength(1, 60)]
        [DataElement("3", typeof(X12_AN))]
        [Pos(7)]
        public string FreeFormMessage_07 { get; set; }
    }

    /// <summary>
    /// Adjustments to balances or services.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ADJ")]
    public class ADJ : I_ADJ
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Adjustment Application Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("952", typeof(X12_ID_952))]
        [Pos(1)]
        public string AdjustmentApplicationCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 15)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string MonetaryAmount_02 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 15)]
        [DataElement("782", typeof(X12_R))]
        [Pos(3)]
        public string MonetaryAmount_03 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(4)]
        public string Date_04 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(5)]
        public string Date_05 { get; set; }
        /// <summary>
        /// Number of Days
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("607", typeof(X12_N0))]
        [Pos(6)]
        public string NumberofDays_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(7)]
        public string Description_07 { get; set; }
    }

    /// <summary>
    /// Functional Group Response Header
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AK1")]
    public class AK1 : I_AK1
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Functional Identifier Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("479", typeof(X12_ID_479))]
        [Pos(1)]
        public string FunctionalIdentifierCode_01 { get; set; }
        /// <summary>
        /// Group Control Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 9)]
        [DataElement("28", typeof(X12_N0))]
        [Pos(2)]
        public string GroupControlNumber_02 { get; set; }
    }

    /// <summary>
    /// Transaction Set Response Header
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AK2")]
    public class AK2 : I_AK2
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transaction Set Identifier Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("143", typeof(X12_ID_143))]
        [Pos(1)]
        public string TransactionSetIdentifierCode_01 { get; set; }
        /// <summary>
        /// Transaction Set Control Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(4, 9)]
        [DataElement("329", typeof(X12_AN))]
        [Pos(2)]
        public string TransactionSetControlNumber_02 { get; set; }
    }

    /// <summary>
    /// Data Segment Note
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AK3")]
    public class AK3 : I_AK3
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Segment ID Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 3)]
        [DataElement("721", typeof(X12_AN))]
        [Pos(1)]
        public string SegmentIDCode_01 { get; set; }
        /// <summary>
        /// Segment Position in Transaction Set
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 6)]
        [DataElement("719", typeof(X12_N0))]
        [Pos(2)]
        public string SegmentPositioninTransactionSet_02 { get; set; }
        /// <summary>
        /// Loop Identifier Code
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("447", typeof(X12_AN))]
        [Pos(3)]
        public string LoopIdentifierCode_03 { get; set; }
        /// <summary>
        /// Segment Syntax Error Code
        /// </summary>
        [DataMember]
        [DataElement("720", typeof(X12_ID_720))]
        [Pos(4)]
        public string SegmentSyntaxErrorCode_04 { get; set; }
        /// <summary>
        /// Segment Syntax Error Code
        /// </summary>
        [DataMember]
        [DataElement("720", typeof(X12_ID_720))]
        [Pos(5)]
        public string SegmentSyntaxErrorCode_05 { get; set; }
        /// <summary>
        /// Segment Syntax Error Code
        /// </summary>
        [DataMember]
        [DataElement("720", typeof(X12_ID_720))]
        [Pos(6)]
        public string SegmentSyntaxErrorCode_06 { get; set; }
        /// <summary>
        /// Segment Syntax Error Code
        /// </summary>
        [DataMember]
        [DataElement("720", typeof(X12_ID_720))]
        [Pos(7)]
        public string SegmentSyntaxErrorCode_07 { get; set; }
        /// <summary>
        /// Segment Syntax Error Code
        /// </summary>
        [DataMember]
        [DataElement("720", typeof(X12_ID_720))]
        [Pos(8)]
        public string SegmentSyntaxErrorCode_08 { get; set; }
    }

    /// <summary>
    /// Data Element Note
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AK4")]
    public class AK4 : I_AK4
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Element Position in Segment
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 2)]
        [DataElement("722", typeof(X12_N0))]
        [Pos(1)]
        public string ElementPositioninSegment_01 { get; set; }
        /// <summary>
        /// Data Element Reference Number
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("725", typeof(X12_N0))]
        [Pos(2)]
        public string DataElementReferenceNumber_02 { get; set; }
        /// <summary>
        /// Data Element Syntax Error Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("723", typeof(X12_ID_723))]
        [Pos(3)]
        public string DataElementSyntaxErrorCode_03 { get; set; }
        /// <summary>
        /// Copy of Bad Data Element
        /// </summary>
        [DataMember]
        [StringLength(1, 99)]
        [DataElement("724", typeof(X12_AN))]
        [Pos(4)]
        public string CopyofBadDataElement_04 { get; set; }
    }

    /// <summary>
    /// Transaction Set Response Trailer
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AK5")]
    public class AK5 : I_AK5
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transaction Set Acknowledgment Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("717", typeof(X12_ID_717))]
        [Pos(1)]
        public string TransactionSetAcknowledgmentCode_01 { get; set; }
        /// <summary>
        /// Transaction Set Syntax Error Code
        /// </summary>
        [DataMember]
        [DataElement("718", typeof(X12_ID_718))]
        [Pos(2)]
        public string TransactionSetSyntaxErrorCode_02 { get; set; }
        /// <summary>
        /// Transaction Set Syntax Error Code
        /// </summary>
        [DataMember]
        [DataElement("718", typeof(X12_ID_718))]
        [Pos(3)]
        public string TransactionSetSyntaxErrorCode_03 { get; set; }
        /// <summary>
        /// Transaction Set Syntax Error Code
        /// </summary>
        [DataMember]
        [DataElement("718", typeof(X12_ID_718))]
        [Pos(4)]
        public string TransactionSetSyntaxErrorCode_04 { get; set; }
        /// <summary>
        /// Transaction Set Syntax Error Code
        /// </summary>
        [DataMember]
        [DataElement("718", typeof(X12_ID_718))]
        [Pos(5)]
        public string TransactionSetSyntaxErrorCode_05 { get; set; }
        /// <summary>
        /// Transaction Set Syntax Error Code
        /// </summary>
        [DataMember]
        [DataElement("718", typeof(X12_ID_718))]
        [Pos(6)]
        public string TransactionSetSyntaxErrorCode_06 { get; set; }
    }

    /// <summary>
    /// Functional Group Response Trailer
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AK9")]
    public class AK9 : I_AK9
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Functional Group Acknowledge Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("715", typeof(X12_ID_715))]
        [Pos(1)]
        public string FunctionalGroupAcknowledgeCode_01 { get; set; }
        /// <summary>
        /// Number of Transaction Sets Included
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 6)]
        [DataElement("97", typeof(X12_N0))]
        [Pos(2)]
        public string NumberofTransactionSetsIncluded_02 { get; set; }
        /// <summary>
        /// Number of Received Transaction Sets
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 6)]
        [DataElement("123", typeof(X12_N0))]
        [Pos(3)]
        public string NumberofReceivedTransactionSets_03 { get; set; }
        /// <summary>
        /// Number of Accepted Transaction Sets
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 6)]
        [DataElement("2", typeof(X12_N0))]
        [Pos(4)]
        public string NumberofAcceptedTransactionSets_04 { get; set; }
        /// <summary>
        /// Functional Group Syntax Error Code
        /// </summary>
        [DataMember]
        [DataElement("716", typeof(X12_ID_716))]
        [Pos(5)]
        public string FunctionalGroupSyntaxErrorCode_05 { get; set; }
        /// <summary>
        /// Functional Group Syntax Error Code
        /// </summary>
        [DataMember]
        [DataElement("716", typeof(X12_ID_716))]
        [Pos(6)]
        public string FunctionalGroupSyntaxErrorCode_06 { get; set; }
        /// <summary>
        /// Functional Group Syntax Error Code
        /// </summary>
        [DataMember]
        [DataElement("716", typeof(X12_ID_716))]
        [Pos(7)]
        public string FunctionalGroupSyntaxErrorCode_07 { get; set; }
        /// <summary>
        /// Functional Group Syntax Error Code
        /// </summary>
        [DataMember]
        [DataElement("716", typeof(X12_ID_716))]
        [Pos(8)]
        public string FunctionalGroupSyntaxErrorCode_08 { get; set; }
        /// <summary>
        /// Functional Group Syntax Error Code
        /// </summary>
        [DataMember]
        [DataElement("716", typeof(X12_ID_716))]
        [Pos(9)]
        public string FunctionalGroupSyntaxErrorCode_09 { get; set; }
    }

    /// <summary>
    /// Monetary Amount
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AMT")]
    public class AMT : I_AMT
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("522", typeof(X12_ID_522))]
        [Pos(1)]
        public string AmountQualifierCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 15)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string MonetaryAmount_02 { get; set; }
    }

    /// <summary>
    /// Resource Authorization
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ATH")]
    public class ATH : I_ATH
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Resource Authorization Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("672", typeof(X12_ID_672))]
        [Pos(1)]
        public string ResourceAuthorizationCode_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [RequiredAny(3)]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(2)]
        public string Date_02 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Conditional(5)]
        [StringLength(1, 10)]
        [DataElement("380", typeof(X12_R))]
        [Pos(3)]
        public string Quantity_03 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Conditional(5)]
        [StringLength(1, 10)]
        [DataElement("380", typeof(X12_R))]
        [Pos(4)]
        public string Quantity_04 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(5)]
        public string Date_05 { get; set; }
    }

    /// <summary>
    /// Funds Availability
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("AVA")]
    public class AVA : I_AVA
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 15)]
        [DataElement("782", typeof(X12_R))]
        [Pos(1)]
        public string MonetaryAmount_01 { get; set; }
        /// <summary>
        /// Availability
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 6)]
        [DataElement("895", typeof(X12_R))]
        [Pos(2)]
        public string Availability_02 { get; set; }
    }

    /// <summary>
    /// Beginning Segment for Carrier's Invoice
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("B3")]
    public class B3 : I_B3
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transaction Set Identifier Code
        /// </summary>
        [DataMember]
        [DataElement("143", typeof(X12_ID_143))]
        [Pos(1)]
        public string TransactionSetIdentifierCode_01 { get; set; }
        /// <summary>
        /// Invoice Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 22)]
        [DataElement("76", typeof(X12_AN))]
        [Pos(2)]
        public string InvoiceNumber_02 { get; set; }
        /// <summary>
        /// Shipment Identification Number
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("145", typeof(X12_AN))]
        [Pos(3)]
        public string ShipmentIdentificationNumber_03 { get; set; }
        /// <summary>
        /// Shipment Method of Payment
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("146", typeof(X12_ID_146))]
        [Pos(4)]
        public string ShipmentMethodofPayment_04 { get; set; }
        /// <summary>
        /// Weight Unit Qualifier
        /// </summary>
        [DataMember]
        [DataElement("188", typeof(X12_ID_188))]
        [Pos(5)]
        public string WeightUnitQualifier_05 { get; set; }
        /// <summary>
        /// Billing Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(6, 6)]
        [DataElement("12", typeof(X12_DT))]
        [Pos(6)]
        public string BillingDate_06 { get; set; }
        /// <summary>
        /// Net Amount Due
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 9)]
        [DataElement("193", typeof(X12_N2))]
        [Pos(7)]
        public string NetAmountDue_07 { get; set; }
        /// <summary>
        /// Correction Indicator
        /// </summary>
        [DataMember]
        [DataElement("202", typeof(X12_ID_202))]
        [Pos(8)]
        public string CorrectionIndicator_08 { get; set; }
        /// <summary>
        /// Delivery Date
        /// </summary>
        [DataMember]
        [Paired(10)]
        [StringLength(6, 6)]
        [DataElement("32", typeof(X12_DT))]
        [Pos(9)]
        public string DeliveryDate_09 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [DataElement("374", typeof(X12_ID_374))]
        [Pos(10)]
        public string DateTimeQualifier_10 { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 4)]
        [DataElement("140", typeof(X12_AN))]
        [Pos(11)]
        public string StandardCarrierAlphaCode_11 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(12)]
        public string Date_12 { get; set; }
    }

    /// <summary>
    /// Invoice Type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("B3A")]
    public class B3A : I_B3A
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transaction Type Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("640", typeof(X12_ID_640))]
        [Pos(1)]
        public string TransactionTypeCode_01 { get; set; }
        /// <summary>
        /// Number of Shipments
        /// </summary>
        [DataMember]
        [StringLength(1, 5)]
        [DataElement("21", typeof(X12_N0))]
        [Pos(2)]
        public string NumberofShipments_02 { get; set; }
    }

    /// <summary>
    /// Beginning Segment for Product Transfer Account Adjustment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BAA")]
    public class BAA : I_BAA
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("353", typeof(X12_ID_353))]
        [Pos(1)]
        public string TransactionSetPurposeCode_01 { get; set; }
        /// <summary>
        /// Transaction Type Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("640", typeof(X12_ID_640))]
        [Pos(2)]
        public string TransactionTypeCode_02 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(3)]
        public string Date_03 { get; set; }
        /// <summary>
        /// Reference Number Qualifier
        /// </summary>
        [DataMember]
        [Paired(5)]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(4)]
        public string ReferenceNumberQualifier_04 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(5)]
        public string ReferenceNumber_05 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(6)]
        public string Time_06 { get; set; }
    }

    /// <summary>
    /// Beginning Segment for Purchase Order Acknowledgment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BAK")]
    public class BAK : I_BAK
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("353", typeof(X12_ID_353))]
        [Pos(1)]
        public string TransactionSetPurposeCode_01 { get; set; }
        /// <summary>
        /// Acknowledgment Type
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("587", typeof(X12_ID_587))]
        [Pos(2)]
        public string AcknowledgmentType_02 { get; set; }
        /// <summary>
        /// Purchase Order Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 22)]
        [DataElement("324", typeof(X12_AN))]
        [Pos(3)]
        public string PurchaseOrderNumber_03 { get; set; }
        /// <summary>
        /// Purchase Order Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(6, 6)]
        [DataElement("323", typeof(X12_DT))]
        [Pos(4)]
        public string PurchaseOrderDate_04 { get; set; }
        /// <summary>
        /// Release Number
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("328", typeof(X12_AN))]
        [Pos(5)]
        public string ReleaseNumber_05 { get; set; }
        /// <summary>
        /// Request Reference Number
        /// </summary>
        [DataMember]
        [StringLength(1, 45)]
        [DataElement("326", typeof(X12_AN))]
        [Pos(6)]
        public string RequestReferenceNumber_06 { get; set; }
        /// <summary>
        /// Contract Number
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("367", typeof(X12_AN))]
        [Pos(7)]
        public string ContractNumber_07 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(8)]
        public string ReferenceNumber_08 { get; set; }
        /// <summary>
        /// Acknowledgment Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("588", typeof(X12_DT))]
        [Pos(9)]
        public string AcknowledgmentDate_09 { get; set; }
    }

    /// <summary>
    /// Balance Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BAL")]
    public class BAL : I_BAL
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Balance Type Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("951", typeof(X12_ID_951))]
        [Pos(1)]
        public string BalanceTypeCode_01 { get; set; }
        /// <summary>
        /// Amount Qualifier Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("522", typeof(X12_ID_522))]
        [Pos(2)]
        public string AmountQualifierCode_02 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 15)]
        [DataElement("782", typeof(X12_R))]
        [Pos(3)]
        public string MonetaryAmount_03 { get; set; }
    }

    /// <summary>
    /// Batch
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BAT")]
    public class BAT : I_BAT
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [RequiredAny(3)]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(1)]
        public string Date_01 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(2)]
        public string Time_02 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(3)]
        public string ReferenceNumber_03 { get; set; }
        /// <summary>
        /// Batch Type Code
        /// </summary>
        [DataMember]
        [DataElement("894", typeof(X12_ID_894))]
        [Pos(4)]
        public string BatchTypeCode_04 { get; set; }
    }

    /// <summary>
    /// Beginning Segment for Purchase Order Change Acknowledgment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BCA")]
    public class BCA : I_BCA
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("353", typeof(X12_ID_353))]
        [Pos(1)]
        public string TransactionSetPurposeCode_01 { get; set; }
        /// <summary>
        /// Acknowledgment Type
        /// </summary>
        [DataMember]
        [DataElement("587", typeof(X12_ID_587))]
        [Pos(2)]
        public string AcknowledgmentType_02 { get; set; }
        /// <summary>
        /// Purchase Order Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 22)]
        [DataElement("324", typeof(X12_AN))]
        [Pos(3)]
        public string PurchaseOrderNumber_03 { get; set; }
        /// <summary>
        /// Release Number
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("328", typeof(X12_AN))]
        [Pos(4)]
        public string ReleaseNumber_04 { get; set; }
        /// <summary>
        /// Change Order Sequence Number
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("327", typeof(X12_AN))]
        [Pos(5)]
        public string ChangeOrderSequenceNumber_05 { get; set; }
        /// <summary>
        /// Purchase Order Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(6, 6)]
        [DataElement("323", typeof(X12_DT))]
        [Pos(6)]
        public string PurchaseOrderDate_06 { get; set; }
        /// <summary>
        /// Request Reference Number
        /// </summary>
        [DataMember]
        [StringLength(1, 45)]
        [DataElement("326", typeof(X12_AN))]
        [Pos(7)]
        public string RequestReferenceNumber_07 { get; set; }
        /// <summary>
        /// Contract Number
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("367", typeof(X12_AN))]
        [Pos(8)]
        public string ContractNumber_08 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(9)]
        public string ReferenceNumber_09 { get; set; }
        /// <summary>
        /// Acknowledgment Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("588", typeof(X12_DT))]
        [Pos(10)]
        public string AcknowledgmentDate_10 { get; set; }
        /// <summary>
        /// Purchase Order Change Request Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("279", typeof(X12_DT))]
        [Pos(11)]
        public string PurchaseOrderChangeRequestDate_11 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(12)]
        public string Date_12 { get; set; }
        /// <summary>
        /// Purchase Order Type Code
        /// </summary>
        [DataMember]
        [DataElement("92", typeof(X12_ID_92))]
        [Pos(13)]
        public string PurchaseOrderTypeCode_13 { get; set; }
    }

    /// <summary>
    /// Beginning Segment for Purchase Order Change
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BCH")]
    public class BCH : I_BCH
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("353", typeof(X12_ID_353))]
        [Pos(1)]
        public string TransactionSetPurposeCode_01 { get; set; }
        /// <summary>
        /// Purchase Order Type Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("92", typeof(X12_ID_92))]
        [Pos(2)]
        public string PurchaseOrderTypeCode_02 { get; set; }
        /// <summary>
        /// Purchase Order Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 22)]
        [DataElement("324", typeof(X12_AN))]
        [Pos(3)]
        public string PurchaseOrderNumber_03 { get; set; }
        /// <summary>
        /// Release Number
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("328", typeof(X12_AN))]
        [Pos(4)]
        public string ReleaseNumber_04 { get; set; }
        /// <summary>
        /// Change Order Sequence Number
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("327", typeof(X12_AN))]
        [Pos(5)]
        public string ChangeOrderSequenceNumber_05 { get; set; }
        /// <summary>
        /// Purchase Order Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(6, 6)]
        [DataElement("323", typeof(X12_DT))]
        [Pos(6)]
        public string PurchaseOrderDate_06 { get; set; }
        /// <summary>
        /// Request Reference Number
        /// </summary>
        [DataMember]
        [StringLength(1, 45)]
        [DataElement("326", typeof(X12_AN))]
        [Pos(7)]
        public string RequestReferenceNumber_07 { get; set; }
        /// <summary>
        /// Contract Number
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("367", typeof(X12_AN))]
        [Pos(8)]
        public string ContractNumber_08 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(9)]
        public string ReferenceNumber_09 { get; set; }
        /// <summary>
        /// Acknowledgment Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("588", typeof(X12_DT))]
        [Pos(10)]
        public string AcknowledgmentDate_10 { get; set; }
        /// <summary>
        /// Purchase Order Change Request Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("279", typeof(X12_DT))]
        [Pos(11)]
        public string PurchaseOrderChangeRequestDate_11 { get; set; }
    }

    /// <summary>
    /// Beginning Segment For Contract Award.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BCO")]
    public class BCO : I_BCO
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("353", typeof(X12_ID_353))]
        [Pos(1)]
        public string TransactionSetPurposeCode_01 { get; set; }
        /// <summary>
        /// Request for Quote Reference Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 45)]
        [DataElement("586", typeof(X12_AN))]
        [Pos(2)]
        public string RequestforQuoteReferenceNumber_02 { get; set; }
        /// <summary>
        /// Request Quotation Control Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(6, 6)]
        [DataElement("652", typeof(X12_DT))]
        [Pos(3)]
        public string RequestQuotationControlDate_03 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceNumber_04 { get; set; }
        /// <summary>
        /// Contract Status Code
        /// </summary>
        [DataMember]
        [DataElement("846", typeof(X12_ID_846))]
        [Pos(5)]
        public string ContractStatusCode_05 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(6)]
        public string Date_06 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(7)]
        public string Date_07 { get; set; }
        /// <summary>
        /// Acknowledgment Type
        /// </summary>
        [DataMember]
        [DataElement("587", typeof(X12_ID_587))]
        [Pos(8)]
        public string AcknowledgmentType_08 { get; set; }
    }

    /// <summary>
    /// Beginning Segment for Price/Sales Catalog
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BCT")]
    public class BCT : I_BCT
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Catalog Purpose Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("683", typeof(X12_ID_683))]
        [Pos(1)]
        public string CatalogPurposeCode_01 { get; set; }
        /// <summary>
        /// Catalog Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 15)]
        [DataElement("684", typeof(X12_AN))]
        [Pos(2)]
        public string CatalogNumber_02 { get; set; }
        /// <summary>
        /// Catalog Version Number
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("685", typeof(X12_AN))]
        [Pos(3)]
        public string CatalogVersionNumber_03 { get; set; }
        /// <summary>
        /// Catalog Revision Number
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("686", typeof(X12_AN))]
        [Pos(4)]
        public string CatalogRevisionNumber_04 { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(5)]
        public string UnitofMeasurementCode_05 { get; set; }
        /// <summary>
        /// Catalog Number
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("684", typeof(X12_AN))]
        [Pos(6)]
        public string CatalogNumber_06 { get; set; }
        /// <summary>
        /// Catalog Version Number
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("685", typeof(X12_AN))]
        [Pos(7)]
        public string CatalogVersionNumber_07 { get; set; }
        /// <summary>
        /// Catalog Revision Number
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("686", typeof(X12_AN))]
        [Pos(8)]
        public string CatalogRevisionNumber_08 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(9)]
        public string Description_09 { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [DataMember]
        [DataElement("353", typeof(X12_ID_353))]
        [Pos(10)]
        public string TransactionSetPurposeCode_10 { get; set; }
    }

    /// <summary>
    /// Beginning Segment for Purchase Order
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BEG")]
    public class BEG : I_BEG
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("353", typeof(X12_ID_353))]
        [Pos(1)]
        public string TransactionSetPurposeCode_01 { get; set; }
        /// <summary>
        /// Purchase Order Type Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("92", typeof(X12_ID_92))]
        [Pos(2)]
        public string PurchaseOrderTypeCode_02 { get; set; }
        /// <summary>
        /// Purchase Order Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 22)]
        [DataElement("324", typeof(X12_AN))]
        [Pos(3)]
        public string PurchaseOrderNumber_03 { get; set; }
        /// <summary>
        /// Release Number
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("328", typeof(X12_AN))]
        [Pos(4)]
        public string ReleaseNumber_04 { get; set; }
        /// <summary>
        /// Purchase Order Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(6, 6)]
        [DataElement("323", typeof(X12_DT))]
        [Pos(5)]
        public string PurchaseOrderDate_05 { get; set; }
        /// <summary>
        /// Contract Number
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("367", typeof(X12_AN))]
        [Pos(6)]
        public string ContractNumber_06 { get; set; }
        /// <summary>
        /// Acknowledgment Type
        /// </summary>
        [DataMember]
        [DataElement("587", typeof(X12_ID_587))]
        [Pos(7)]
        public string AcknowledgmentType_07 { get; set; }
    }

    /// <summary>
    /// Beginning Segment for Planning Schedule
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BFR")]
    public class BFR : I_BFR
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("353", typeof(X12_ID_353))]
        [Pos(1)]
        public string TransactionSetPurposeCode_01 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [Exclusion(3)]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceNumber_02 { get; set; }
        /// <summary>
        /// Release Number
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("328", typeof(X12_AN))]
        [Pos(3)]
        public string ReleaseNumber_03 { get; set; }
        /// <summary>
        /// Schedule Type Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("675", typeof(X12_ID_675))]
        [Pos(4)]
        public string ScheduleTypeQualifier_04 { get; set; }
        /// <summary>
        /// Schedule Quantity Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("676", typeof(X12_ID_676))]
        [Pos(5)]
        public string ScheduleQuantityQualifier_05 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(6)]
        public string Date_06 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(7)]
        public string Date_07 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(8)]
        public string Date_08 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(9)]
        public string Date_09 { get; set; }
        /// <summary>
        /// Contract Number
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("367", typeof(X12_AN))]
        [Pos(10)]
        public string ContractNumber_10 { get; set; }
        /// <summary>
        /// Purchase Order Number
        /// </summary>
        [DataMember]
        [StringLength(1, 22)]
        [DataElement("324", typeof(X12_AN))]
        [Pos(11)]
        public string PurchaseOrderNumber_11 { get; set; }
        /// <summary>
        /// Planning Schedule Type Code
        /// </summary>
        [DataMember]
        [DataElement("783", typeof(X12_ID_783))]
        [Pos(12)]
        public string PlanningScheduleTypeCode_12 { get; set; }
    }

    /// <summary>
    /// Beginning Segment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BGN")]
    public class BGN : I_BGN
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("353", typeof(X12_ID_353))]
        [Pos(1)]
        public string TransactionSetPurposeCode_01 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceNumber_02 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(3)]
        public string Date_03 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(4)]
        public string Time_04 { get; set; }
        /// <summary>
        /// Time Code
        /// </summary>
        [DataMember]
        [Conditional(4)]
        [DataElement("623", typeof(X12_ID_623))]
        [Pos(5)]
        public string TimeCode_05 { get; set; }
    }

    /// <summary>
    /// Beginning Segment for Inventory Inquiry/Advice
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BIA")]
    public class BIA : I_BIA
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("353", typeof(X12_ID_353))]
        [Pos(1)]
        public string TransactionSetPurposeCode_01 { get; set; }
        /// <summary>
        /// Report Type Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("755", typeof(X12_ID_755))]
        [Pos(2)]
        public string ReportTypeCode_02 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(3)]
        public string ReferenceNumber_03 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(4)]
        public string Date_04 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(5)]
        public string Time_05 { get; set; }
    }

    /// <summary>
    /// Beginning Segment for Invoice
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BIG")]
    public class BIG : I_BIG
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Invoice Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(6, 6)]
        [DataElement("245", typeof(X12_DT))]
        [Pos(1)]
        public string InvoiceDate_01 { get; set; }
        /// <summary>
        /// Invoice Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 22)]
        [DataElement("76", typeof(X12_AN))]
        [Pos(2)]
        public string InvoiceNumber_02 { get; set; }
        /// <summary>
        /// Purchase Order Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("323", typeof(X12_DT))]
        [Pos(3)]
        public string PurchaseOrderDate_03 { get; set; }
        /// <summary>
        /// Purchase Order Number
        /// </summary>
        [DataMember]
        [StringLength(1, 22)]
        [DataElement("324", typeof(X12_AN))]
        [Pos(4)]
        public string PurchaseOrderNumber_04 { get; set; }
        /// <summary>
        /// Release Number
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("328", typeof(X12_AN))]
        [Pos(5)]
        public string ReleaseNumber_05 { get; set; }
        /// <summary>
        /// Change Order Sequence Number
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("327", typeof(X12_AN))]
        [Pos(6)]
        public string ChangeOrderSequenceNumber_06 { get; set; }
        /// <summary>
        /// Transaction Type Code
        /// </summary>
        [DataMember]
        [DataElement("640", typeof(X12_ID_640))]
        [Pos(7)]
        public string TransactionTypeCode_07 { get; set; }
    }

    /// <summary>
    /// Binary Data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BIN")]
    public class BIN : I_BIN
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Length of Binary Data
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 15)]
        [DataElement("784", typeof(X12_N0))]
        [Pos(1)]
        public string LengthofBinaryData_01 { get; set; }
        /// <summary>
        /// Binary Data
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 1000000)]
        [DataElement("785", typeof(X12_AN))]
        [Pos(2)]
        public string BinaryData_02 { get; set; }
    }

    /// <summary>
    /// Beginning Segment for Text Transaction
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BMG")]
    public class BMG : I_BMG
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("353", typeof(X12_ID_353))]
        [Pos(1)]
        public string TransactionSetPurposeCode_01 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(2)]
        public string Description_02 { get; set; }
    }

    /// <summary>
    /// Beginning Segment For Nonconformance Report
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BNR")]
    public class BNR : I_BNR
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("353", typeof(X12_ID_353))]
        [Pos(1)]
        public string TransactionSetPurposeCode_01 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceNumber_02 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(3)]
        public string Date_03 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(4)]
        public string Time_04 { get; set; }
        /// <summary>
        /// Nonconformance Report Status Code
        /// </summary>
        [DataMember]
        [DataElement("886", typeof(X12_ID_886))]
        [Pos(5)]
        public string NonconformanceReportStatusCode_05 { get; set; }
    }

    /// <summary>
    /// Rail Shipment Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BNX")]
    public class BNX : I_BNX
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Shipment Weight Code
        /// </summary>
        [DataMember]
        [DataElement("460", typeof(X12_ID_460))]
        [Pos(1)]
        public string ShipmentWeightCode_01 { get; set; }
        /// <summary>
        /// Referenced Pattern Identifier
        /// </summary>
        [DataMember]
        [Exclusion(4)]
        [StringLength(1, 13)]
        [DataElement("129", typeof(X12_AN))]
        [Pos(2)]
        public string ReferencedPatternIdentifier_02 { get; set; }
        /// <summary>
        /// Billing Code
        /// </summary>
        [DataMember]
        [DataElement("11", typeof(X12_ID_11))]
        [Pos(3)]
        public string BillingCode_03 { get; set; }
        /// <summary>
        /// Repetitive Pattern Number
        /// </summary>
        [DataMember]
        [StringLength(5, 5)]
        [DataElement("223", typeof(X12_N0))]
        [Pos(4)]
        public string RepetitivePatternNumber_04 { get; set; }
    }

    /// <summary>
    /// Beginning Segment for the Operating Expense Statement
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BOS")]
    public class BOS : I_BOS
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Statement Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 16)]
        [DataElement("613", typeof(X12_AN))]
        [Pos(1)]
        public string StatementNumber_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(2)]
        public string Date_02 { get; set; }
        /// <summary>
        /// Association Qualifier Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("559", typeof(X12_ID_559))]
        [Pos(3)]
        public string AssociationQualifierCode_03 { get; set; }
        /// <summary>
        /// Statement Format Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(6, 6)]
        [DataElement("781", typeof(X12_AN))]
        [Pos(4)]
        public string StatementFormatCode_04 { get; set; }
        /// <summary>
        /// Transaction Type Code
        /// </summary>
        [DataMember]
        [DataElement("640", typeof(X12_ID_640))]
        [Pos(5)]
        public string TransactionTypeCode_05 { get; set; }
    }

    /// <summary>
    /// Beginning Segment for Price Authorization Acknowledgment/Status
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BPA")]
    public class BPA : I_BPA
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("353", typeof(X12_ID_353))]
        [Pos(1)]
        public string TransactionSetPurposeCode_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(2)]
        public string Date_02 { get; set; }
        /// <summary>
        /// Reference Number Qualifier
        /// </summary>
        [DataMember]
        [Paired(4)]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(3)]
        public string ReferenceNumberQualifier_03 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceNumber_04 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(5)]
        public string Time_05 { get; set; }
    }

    /// <summary>
    /// Beginning Segment for Payment Order/Remittance Advice
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BPS")]
    public class BPS : I_BPS
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Payment Method Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("591", typeof(X12_ID_591))]
        [Pos(1)]
        public string PaymentMethodCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 15)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string MonetaryAmount_02 { get; set; }
        /// <summary>
        /// Transaction Handling Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("305", typeof(X12_ID_305))]
        [Pos(3)]
        public string TransactionHandlingCode_03 { get; set; }
        /// <summary>
        /// (DFI) ID Number Qualifier
        /// </summary>
        [DataMember]
        [DataElement("506", typeof(X12_ID_506))]
        [Pos(4)]
        public string DFIIDNumberQualifier_04 { get; set; }
        /// <summary>
        /// (DFI) Identification Number
        /// </summary>
        [DataMember]
        [StringLength(3, 12)]
        [DataElement("507", typeof(X12_AN))]
        [Pos(5)]
        public string DFIIdentificationNumber_05 { get; set; }
        /// <summary>
        /// Account Number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("508", typeof(X12_AN))]
        [Pos(6)]
        public string AccountNumber_06 { get; set; }
        /// <summary>
        /// Originating Company ID Number
        /// </summary>
        [DataMember]
        [StringLength(10, 10)]
        [DataElement("509", typeof(X12_AN))]
        [Pos(7)]
        public string OriginatingCompanyIDNumber_07 { get; set; }
        /// <summary>
        /// Originating Company Supplemental Code
        /// </summary>
        [DataMember]
        [StringLength(9, 9)]
        [DataElement("510", typeof(X12_AN))]
        [Pos(8)]
        public string OriginatingCompanySupplementalCode_08 { get; set; }
        /// <summary>
        /// (DFI) ID Number Qualifier
        /// </summary>
        [DataMember]
        [DataElement("506", typeof(X12_ID_506))]
        [Pos(9)]
        public string DFIIDNumberQualifier_09 { get; set; }
        /// <summary>
        /// (DFI) Identification Number
        /// </summary>
        [DataMember]
        [StringLength(3, 12)]
        [DataElement("507", typeof(X12_AN))]
        [Pos(10)]
        public string DFIIdentificationNumber_10 { get; set; }
        /// <summary>
        /// Account Number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("508", typeof(X12_AN))]
        [Pos(11)]
        public string AccountNumber_11 { get; set; }
        /// <summary>
        /// Effective Entry Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("513", typeof(X12_DT))]
        [Pos(12)]
        public string EffectiveEntryDate_12 { get; set; }
        /// <summary>
        /// Settlement Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("727", typeof(X12_DT))]
        [Pos(13)]
        public string SettlementDate_13 { get; set; }
    }

    /// <summary>
    /// Beginning Segment for Product Transfer and Resale
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BPT")]
    public class BPT : I_BPT
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("353", typeof(X12_ID_353))]
        [Pos(1)]
        public string TransactionSetPurposeCode_01 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceNumber_02 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(3)]
        public string Date_03 { get; set; }
        /// <summary>
        /// Report Type Code
        /// </summary>
        [DataMember]
        [DataElement("755", typeof(X12_ID_755))]
        [Pos(4)]
        public string ReportTypeCode_04 { get; set; }
        /// <summary>
        /// Price Multiplier Qualifier
        /// </summary>
        [DataMember]
        [Paired(6)]
        [DataElement("648", typeof(X12_ID_648))]
        [Pos(5)]
        public string PriceMultiplierQualifier_05 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(6)]
        public string Multiplier_06 { get; set; }
    }

    /// <summary>
    /// Beginning Segment for Response to Request For Quotation
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BQR")]
    public class BQR : I_BQR
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("353", typeof(X12_ID_353))]
        [Pos(1)]
        public string TransactionSetPurposeCode_01 { get; set; }
        /// <summary>
        /// Request for Quote Reference Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 45)]
        [DataElement("586", typeof(X12_AN))]
        [Pos(2)]
        public string RequestforQuoteReferenceNumber_02 { get; set; }
        /// <summary>
        /// Request Quotation Control Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(6, 6)]
        [DataElement("652", typeof(X12_DT))]
        [Pos(3)]
        public string RequestQuotationControlDate_03 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [DataElement("374", typeof(X12_ID_374))]
        [Pos(4)]
        public string DateTimeQualifier_04 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Conditional(4)]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(5)]
        public string Date_05 { get; set; }
        /// <summary>
        /// Bid Type Response Code
        /// </summary>
        [DataMember]
        [DataElement("379", typeof(X12_ID_379))]
        [Pos(6)]
        public string BidTypeResponseCode_06 { get; set; }
    }

    /// <summary>
    /// Beginning Segment for Request For Quotation
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BQT")]
    public class BQT : I_BQT
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("353", typeof(X12_ID_353))]
        [Pos(1)]
        public string TransactionSetPurposeCode_01 { get; set; }
        /// <summary>
        /// Request for Quote Reference Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 45)]
        [DataElement("586", typeof(X12_AN))]
        [Pos(2)]
        public string RequestforQuoteReferenceNumber_02 { get; set; }
        /// <summary>
        /// Request Quotation Control Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(6, 6)]
        [DataElement("652", typeof(X12_DT))]
        [Pos(3)]
        public string RequestQuotationControlDate_03 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [DataElement("374", typeof(X12_ID_374))]
        [Pos(4)]
        public string DateTimeQualifier_04 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Conditional(4)]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(5)]
        public string Date_05 { get; set; }
        /// <summary>
        /// Purchase Order Type Code
        /// </summary>
        [DataMember]
        [DataElement("92", typeof(X12_ID_92))]
        [Pos(6)]
        public string PurchaseOrderTypeCode_06 { get; set; }
        /// <summary>
        /// Request for Quote Type Code
        /// </summary>
        [DataMember]
        [DataElement("960", typeof(X12_ID_960))]
        [Pos(7)]
        public string RequestforQuoteTypeCode_07 { get; set; }
    }

    /// <summary>
    /// Beginning Segment for Receiving Advice
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BRA")]
    public class BRA : I_BRA
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(1)]
        public string ReferenceNumber_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(2)]
        public string Date_02 { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("353", typeof(X12_ID_353))]
        [Pos(3)]
        public string TransactionSetPurposeCode_03 { get; set; }
        /// <summary>
        /// Receiving Advice Type Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("962", typeof(X12_ID_962))]
        [Pos(4)]
        public string ReceivingAdviceTypeCode_04 { get; set; }
    }

    /// <summary>
    /// Beginning Segment (Response to Product Transfer Account Adjustment)
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BRC")]
    public class BRC : I_BRC
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("353", typeof(X12_ID_353))]
        [Pos(1)]
        public string TransactionSetPurposeCode_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(2)]
        public string Date_02 { get; set; }
        /// <summary>
        /// Reference Number Qualifier
        /// </summary>
        [DataMember]
        [Paired(4)]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(3)]
        public string ReferenceNumberQualifier_03 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceNumber_04 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(5)]
        public string Time_05 { get; set; }
    }

    /// <summary>
    /// Beginning Segment for Order Status Inquiry
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BSI")]
    public class BSI : I_BSI
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(1)]
        public string ReferenceNumber_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(2)]
        public string Date_02 { get; set; }
        /// <summary>
        /// Order/Item Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("847", typeof(X12_ID_847))]
        [Pos(3)]
        public string OrderItemCode_03 { get; set; }
        /// <summary>
        /// Product/Date Code
        /// </summary>
        [DataMember]
        [DataElement("848", typeof(X12_ID_848))]
        [Pos(4)]
        public string ProductDateCode_04 { get; set; }
        /// <summary>
        /// Location Code
        /// </summary>
        [DataMember]
        [DataElement("849", typeof(X12_ID_849))]
        [Pos(5)]
        public string LocationCode_05 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(6)]
        public string Time_06 { get; set; }
    }

    /// <summary>
    /// Beginning Segment for Ship Notice
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BSN")]
    public class BSN : I_BSN
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("353", typeof(X12_ID_353))]
        [Pos(1)]
        public string TransactionSetPurposeCode_01 { get; set; }
        /// <summary>
        /// Shipment Identification
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 30)]
        [DataElement("396", typeof(X12_AN))]
        [Pos(2)]
        public string ShipmentIdentification_02 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(3)]
        public string Date_03 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(4, 4)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(4)]
        public string Time_04 { get; set; }
    }

    /// <summary>
    /// Beginning Segment for Order Status Report
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BSR")]
    public class BSR : I_BSR
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Status Report Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("850", typeof(X12_ID_850))]
        [Pos(1)]
        public string StatusReportCode_01 { get; set; }
        /// <summary>
        /// Order/Item Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("847", typeof(X12_ID_847))]
        [Pos(2)]
        public string OrderItemCode_02 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(3)]
        public string ReferenceNumber_03 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(4)]
        public string Date_04 { get; set; }
        /// <summary>
        /// Product/Date Code
        /// </summary>
        [DataMember]
        [DataElement("848", typeof(X12_ID_848))]
        [Pos(5)]
        public string ProductDateCode_05 { get; set; }
        /// <summary>
        /// Location Code
        /// </summary>
        [DataMember]
        [DataElement("849", typeof(X12_ID_849))]
        [Pos(6)]
        public string LocationCode_06 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(7)]
        public string Time_07 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(8)]
        public string ReferenceNumber_08 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(9)]
        public string Date_09 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(10)]
        public string Time_10 { get; set; }
    }

    /// <summary>
    /// Beginning Segment For Shipping Schedule/Production Sequence.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BSS")]
    public class BSS : I_BSS
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("353", typeof(X12_ID_353))]
        [Pos(1)]
        public string TransactionSetPurposeCode_01 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceNumber_02 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(3)]
        public string Date_03 { get; set; }
        /// <summary>
        /// Schedule Type Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("675", typeof(X12_ID_675))]
        [Pos(4)]
        public string ScheduleTypeQualifier_04 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(5)]
        public string Date_05 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(6)]
        public string Date_06 { get; set; }
        /// <summary>
        /// Release Number
        /// </summary>
        [DataMember]
        [RequiredAny(8)]
        [StringLength(1, 30)]
        [DataElement("328", typeof(X12_AN))]
        [Pos(7)]
        public string ReleaseNumber_07 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(8)]
        public string ReferenceNumber_08 { get; set; }
        /// <summary>
        /// Contract Number
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("367", typeof(X12_AN))]
        [Pos(9)]
        public string ContractNumber_09 { get; set; }
        /// <summary>
        /// Purchase Order Number
        /// </summary>
        [DataMember]
        [StringLength(1, 22)]
        [DataElement("324", typeof(X12_AN))]
        [Pos(10)]
        public string PurchaseOrderNumber_10 { get; set; }
        /// <summary>
        /// Schedule Quantity Qualifier
        /// </summary>
        [DataMember]
        [DataElement("676", typeof(X12_ID_676))]
        [Pos(11)]
        public string ScheduleQuantityQualifier_11 { get; set; }
    }

    /// <summary>
    /// Beginning Tax Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BTI")]
    public class BTI : I_BTI
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference Number Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(1)]
        public string ReferenceNumberQualifier_01 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceNumber_02 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("66", typeof(X12_ID_66))]
        [Pos(3)]
        public string IdentificationCodeQualifier_03 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 17)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(4)]
        public string IdentificationCode_04 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(5)]
        public string Date_05 { get; set; }
    }

    /// <summary>
    /// Beginning Segment for Test Results
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BTR")]
    public class BTR : I_BTR
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("353", typeof(X12_ID_353))]
        [Pos(1)]
        public string TransactionSetPurposeCode_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(2)]
        public string Date_02 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(3)]
        public string Time_03 { get; set; }
        /// <summary>
        /// Report Type Code
        /// </summary>
        [DataMember]
        [DataElement("755", typeof(X12_ID_755))]
        [Pos(4)]
        public string ReportTypeCode_04 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(5)]
        public string ReferenceNumber_05 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(6)]
        public string ReferenceNumber_06 { get; set; }
    }

    /// <summary>
    /// General Shipment Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("BX")]
    public class BX : I_BX
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("353", typeof(X12_ID_353))]
        [Pos(1)]
        public string TransactionSetPurposeCode_01 { get; set; }
        /// <summary>
        /// Transportation Method/Type Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("91", typeof(X12_ID_91))]
        [Pos(2)]
        public string TransportationMethodTypeCode_02 { get; set; }
        /// <summary>
        /// Shipment Method of Payment
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("146", typeof(X12_ID_146))]
        [Pos(3)]
        public string ShipmentMethodofPayment_03 { get; set; }
        /// <summary>
        /// Shipment Identification Number
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("145", typeof(X12_AN))]
        [Pos(4)]
        public string ShipmentIdentificationNumber_04 { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [StringLength(2, 4)]
        [DataElement("140", typeof(X12_AN))]
        [Pos(5)]
        public string StandardCarrierAlphaCode_05 { get; set; }
        /// <summary>
        /// Weight Unit Qualifier
        /// </summary>
        [DataMember]
        [DataElement("188", typeof(X12_ID_188))]
        [Pos(6)]
        public string WeightUnitQualifier_06 { get; set; }
        /// <summary>
        /// Shipment Qualifier
        /// </summary>
        [DataMember]
        [DataElement("147", typeof(X12_ID_147))]
        [Pos(7)]
        public string ShipmentQualifier_07 { get; set; }
        /// <summary>
        /// Section Seven Code
        /// </summary>
        [DataMember]
        [DataElement("226", typeof(X12_ID_226))]
        [Pos(8)]
        public string SectionSevenCode_08 { get; set; }
        /// <summary>
        /// Capacity Load Code
        /// </summary>
        [DataMember]
        [DataElement("195", typeof(X12_ID_195))]
        [Pos(9)]
        public string CapacityLoadCode_09 { get; set; }
        /// <summary>
        /// Status Report Request Code
        /// </summary>
        [DataMember]
        [DataElement("160", typeof(X12_ID_160))]
        [Pos(10)]
        public string StatusReportRequestCode_10 { get; set; }
        /// <summary>
        /// Customs Documentation Handling Code
        /// </summary>
        [DataMember]
        [DataElement("501", typeof(X12_ID_501))]
        [Pos(11)]
        public string CustomsDocumentationHandlingCode_11 { get; set; }
        /// <summary>
        /// Confidential Billing Request Code
        /// </summary>
        [DataMember]
        [DataElement("199", typeof(X12_ID_199))]
        [Pos(12)]
        public string ConfidentialBillingRequestCode_12 { get; set; }
    }

    /// <summary>
    /// Currency
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("C3")]
    public class C3 : I_C3
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Currency Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(3, 3)]
        [DataElement("100", typeof(X12_AN))]
        [Pos(1)]
        public string CurrencyCode_01 { get; set; }
        /// <summary>
        /// Exchange Rate
        /// </summary>
        [DataMember]
        [StringLength(4, 6)]
        [DataElement("280", typeof(X12_R))]
        [Pos(2)]
        public string ExchangeRate_02 { get; set; }
        /// <summary>
        /// Currency Code
        /// </summary>
        [DataMember]
        [StringLength(3, 3)]
        [DataElement("100", typeof(X12_AN))]
        [Pos(3)]
        public string CurrencyCode_03 { get; set; }
    }

    /// <summary>
    /// Carrier Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CAD")]
    public class CAD : I_CAD
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transportation Method/Type Code
        /// </summary>
        [DataMember]
        [DataElement("91", typeof(X12_ID_91))]
        [Pos(1)]
        public string TransportationMethodTypeCode_01 { get; set; }
        /// <summary>
        /// Equipment Initial
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("206", typeof(X12_AN))]
        [Pos(2)]
        public string EquipmentInitial_02 { get; set; }
        /// <summary>
        /// Equipment Number
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("207", typeof(X12_AN))]
        [Pos(3)]
        public string EquipmentNumber_03 { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [StringLength(2, 4)]
        [DataElement("140", typeof(X12_AN))]
        [Pos(4)]
        public string StandardCarrierAlphaCode_04 { get; set; }
        /// <summary>
        /// Routing
        /// </summary>
        [DataMember]
        [RequiredAny(4)]
        [StringLength(1, 35)]
        [DataElement("387", typeof(X12_AN))]
        [Pos(5)]
        public string Routing_05 { get; set; }
        /// <summary>
        /// Shipment/Order Status Code
        /// </summary>
        [DataMember]
        [DataElement("368", typeof(X12_ID_368))]
        [Pos(6)]
        public string ShipmentOrderStatusCode_06 { get; set; }
        /// <summary>
        /// Reference Number Qualifier
        /// </summary>
        [DataMember]
        [Conditional(8)]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(7)]
        public string ReferenceNumberQualifier_07 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(8)]
        public string ReferenceNumber_08 { get; set; }
    }

    /// <summary>
    /// Characteristic/Class ID
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CID")]
    public class CID : I_CID
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Measurement Qualifier
        /// </summary>
        [DataMember]
        [RequiredAny(2, 4)]
        [DataElement("738", typeof(X12_ID_738))]
        [Pos(1)]
        public string MeasurementQualifier_01 { get; set; }
        /// <summary>
        /// Product/Process Characteristic Code
        /// </summary>
        [DataMember]
        [DataElement("750", typeof(X12_ID_750))]
        [Pos(2)]
        public string ProductProcessCharacteristicCode_02 { get; set; }
        /// <summary>
        /// Association Qualifier Code
        /// </summary>
        [DataMember]
        [Paired(4)]
        [DataElement("559", typeof(X12_ID_559))]
        [Pos(3)]
        public string AssociationQualifierCode_03 { get; set; }
        /// <summary>
        /// Product Description Code
        /// </summary>
        [DataMember]
        [StringLength(1, 12)]
        [DataElement("751", typeof(X12_AN))]
        [Pos(4)]
        public string ProductDescriptionCode_04 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(5)]
        public string Description_05 { get; set; }
    }

    /// <summary>
    /// Load Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CLD")]
    public class CLD : I_CLD
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Number of Loads
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 5)]
        [DataElement("622", typeof(X12_N0))]
        [Pos(1)]
        public string NumberofLoads_01 { get; set; }
        /// <summary>
        /// Number of Units Shipped
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 10)]
        [DataElement("382", typeof(X12_R))]
        [Pos(2)]
        public string NumberofUnitsShipped_02 { get; set; }
        /// <summary>
        /// Packaging Code
        /// </summary>
        [DataMember]
        [StringLength(5, 5)]
        [DataElement("103", typeof(X12_AN))]
        [Pos(3)]
        public string PackagingCode_03 { get; set; }
        /// <summary>
        /// Size
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("357", typeof(X12_R))]
        [Pos(4)]
        public string Size_04 { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(5)]
        public string UnitofMeasurementCode_05 { get; set; }
    }

    /// <summary>
    /// Cargo Manifest
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CM")]
    public class CM : I_CM
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Flight/Voyage Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 10)]
        [DataElement("55", typeof(X12_AN))]
        [Pos(1)]
        public string FlightVoyageNumber_01 { get; set; }
        /// <summary>
        /// Port Function Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("115", typeof(X12_ID_115))]
        [Pos(2)]
        public string PortFunctionCode_02 { get; set; }
        /// <summary>
        /// Port Name
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 24)]
        [DataElement("114", typeof(X12_AN))]
        [Pos(3)]
        public string PortName_03 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(4)]
        public string Date_04 { get; set; }
        /// <summary>
        /// Booking Number
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("13", typeof(X12_AN))]
        [Pos(5)]
        public string BookingNumber_05 { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [StringLength(2, 4)]
        [DataElement("140", typeof(X12_AN))]
        [Pos(6)]
        public string StandardCarrierAlphaCode_06 { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [StringLength(2, 4)]
        [DataElement("140", typeof(X12_AN))]
        [Pos(7)]
        public string StandardCarrierAlphaCode_07 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(8)]
        public string Date_08 { get; set; }
        /// <summary>
        /// Vessel Name
        /// </summary>
        [DataMember]
        [StringLength(2, 28)]
        [DataElement("182", typeof(X12_AN))]
        [Pos(9)]
        public string VesselName_09 { get; set; }
        /// <summary>
        /// Pier Number
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("113", typeof(X12_AN))]
        [Pos(10)]
        public string PierNumber_10 { get; set; }
        /// <summary>
        /// Pier Name
        /// </summary>
        [DataMember]
        [StringLength(2, 14)]
        [DataElement("112", typeof(X12_AN))]
        [Pos(11)]
        public string PierName_11 { get; set; }
        /// <summary>
        /// Terminal Name
        /// </summary>
        [DataMember]
        [StringLength(2, 30)]
        [DataElement("174", typeof(X12_AN))]
        [Pos(12)]
        public string TerminalName_12 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_AN))]
        [Pos(13)]
        public string StateorProvinceCode_13 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("26", typeof(X12_AN))]
        [Pos(14)]
        public string CountryCode_14 { get; set; }
    }

    /// <summary>
    /// Contract Number Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CON")]
    public class CON : I_CON
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference Number Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(1)]
        public string ReferenceNumberQualifier_01 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceNumber_02 { get; set; }
        /// <summary>
        /// Contract Status Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("846", typeof(X12_ID_846))]
        [Pos(3)]
        public string ContractStatusCode_03 { get; set; }
    }

    /// <summary>
    /// Header Sale Condition
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CSH")]
    public class CSH : I_CSH
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Sales Requirement Code
        /// </summary>
        [DataMember]
        [DataElement("563", typeof(X12_ID_563))]
        [Pos(1)]
        public string SalesRequirementCode_01 { get; set; }
        /// <summary>
        /// Do-Not-Exceed Action Code
        /// </summary>
        [DataMember]
        [Conditional(3)]
        [DataElement("564", typeof(X12_ID_564))]
        [Pos(2)]
        public string DoNotExceedActionCode_02 { get; set; }
        /// <summary>
        /// Do-Not-Exceed Amount
        /// </summary>
        [DataMember]
        [StringLength(2, 9)]
        [DataElement("565", typeof(X12_N2))]
        [Pos(3)]
        public string DoNotExceedAmount_03 { get; set; }
        /// <summary>
        /// Account Number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("508", typeof(X12_AN))]
        [Pos(4)]
        public string AccountNumber_04 { get; set; }
        /// <summary>
        /// Required Invoice Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("596", typeof(X12_DT))]
        [Pos(5)]
        public string RequiredInvoiceDate_05 { get; set; }
        /// <summary>
        /// Association Qualifier Code
        /// </summary>
        [DataMember]
        [Conditional(7)]
        [DataElement("559", typeof(X12_ID_559))]
        [Pos(6)]
        public string AssociationQualifierCode_06 { get; set; }
        /// <summary>
        /// Special Services Code
        /// </summary>
        [DataMember]
        [DataElement("560", typeof(X12_ID_560))]
        [Pos(7)]
        public string SpecialServicesCode_07 { get; set; }
    }

    /// <summary>
    /// Cost Analysis
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CST")]
    public class CST : I_CST
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Cost Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("964", typeof(X12_ID_964))]
        [Pos(1)]
        public string CostCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 15)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string MonetaryAmount_02 { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(3)]
        public string UnitofMeasurementCode_03 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Conditional(3)]
        [StringLength(1, 10)]
        [DataElement("380", typeof(X12_R))]
        [Pos(4)]
        public string Quantity_04 { get; set; }
    }

    /// <summary>
    /// Restrictions/ Conditions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CTB")]
    public class CTB : I_CTB
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Restrictions/Conditions Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("688", typeof(X12_ID_688))]
        [Pos(1)]
        public string RestrictionsConditionsQualifier_01 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [RequiredAny(4)]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(2)]
        public string Description_02 { get; set; }
        /// <summary>
        /// Quantity Qualifier
        /// </summary>
        [DataMember]
        [Paired(4)]
        [DataElement("673", typeof(X12_ID_673))]
        [Pos(3)]
        public string QuantityQualifier_03 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("380", typeof(X12_R))]
        [Pos(4)]
        public string Quantity_04 { get; set; }
    }

    /// <summary>
    /// Pricing Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CTP")]
    public class CTP : I_CTP
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Class of Trade Code
        /// </summary>
        [DataMember]
        [DataElement("687", typeof(X12_ID_687))]
        [Pos(1)]
        public string ClassofTradeCode_01 { get; set; }
        /// <summary>
        /// Price Qualifier
        /// </summary>
        [DataMember]
        [Conditional(3)]
        [DataElement("236", typeof(X12_ID_236))]
        [Pos(2)]
        public string PriceQualifier_02 { get; set; }
        /// <summary>
        /// Unit Price
        /// </summary>
        [DataMember]
        [StringLength(1, 14)]
        [DataElement("212", typeof(X12_R))]
        [Pos(3)]
        public string UnitPrice_03 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Conditional(5)]
        [StringLength(1, 10)]
        [DataElement("380", typeof(X12_R))]
        [Pos(4)]
        public string Quantity_04 { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(5)]
        public string UnitofMeasurementCode_05 { get; set; }
        /// <summary>
        /// Price Multiplier Qualifier
        /// </summary>
        [DataMember]
        [Conditional(7)]
        [DataElement("648", typeof(X12_ID_648))]
        [Pos(6)]
        public string PriceMultiplierQualifier_06 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(7)]
        public string Multiplier_07 { get; set; }
    }

    /// <summary>
    /// Transaction Totals
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CTT")]
    public class CTT : I_CTT
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Number of Line Items
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 6)]
        [DataElement("354", typeof(X12_N0))]
        [Pos(1)]
        public string NumberofLineItems_01 { get; set; }
        /// <summary>
        /// Hash Total
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("347", typeof(X12_R))]
        [Pos(2)]
        public string HashTotal_02 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [DataMember]
        [Conditional(4)]
        [StringLength(1, 8)]
        [DataElement("81", typeof(X12_R))]
        [Pos(3)]
        public string Weight_03 { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(4)]
        public string UnitofMeasurementCode_04 { get; set; }
        /// <summary>
        /// Volume
        /// </summary>
        [DataMember]
        [Conditional(6)]
        [StringLength(1, 8)]
        [DataElement("183", typeof(X12_R))]
        [Pos(5)]
        public string Volume_05 { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(6)]
        public string UnitofMeasurementCode_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(7)]
        public string Description_07 { get; set; }
    }

    /// <summary>
    /// Currency
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("CUR")]
    public class CUR : I_CUR
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("98", typeof(X12_ID_98))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Currency Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(3, 3)]
        [DataElement("100", typeof(X12_AN))]
        [Pos(2)]
        public string CurrencyCode_02 { get; set; }
        /// <summary>
        /// Exchange Rate
        /// </summary>
        [DataMember]
        [StringLength(4, 6)]
        [DataElement("280", typeof(X12_R))]
        [Pos(3)]
        public string ExchangeRate_03 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [DataElement("98", typeof(X12_ID_98))]
        [Pos(4)]
        public string EntityIdentifierCode_04 { get; set; }
        /// <summary>
        /// Currency Code
        /// </summary>
        [DataMember]
        [StringLength(3, 3)]
        [DataElement("100", typeof(X12_AN))]
        [Pos(5)]
        public string CurrencyCode_05 { get; set; }
        /// <summary>
        /// Currency Market/Exchange Code
        /// </summary>
        [DataMember]
        [DataElement("669", typeof(X12_ID_669))]
        [Pos(6)]
        public string CurrencyMarketExchangeCode_06 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [DataElement("374", typeof(X12_ID_374))]
        [Pos(7)]
        public string DateTimeQualifier_07 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Conditional(7)]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(8)]
        public string Date_08 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Conditional(7)]
        [StringLength(4, 4)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(9)]
        public string Time_09 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [DataElement("374", typeof(X12_ID_374))]
        [Pos(10)]
        public string DateTimeQualifier_10 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Conditional(10)]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(11)]
        public string Date_11 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Conditional(10)]
        [StringLength(4, 4)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(12)]
        public string Time_12 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [DataElement("374", typeof(X12_ID_374))]
        [Pos(13)]
        public string DateTimeQualifier_13 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Conditional(13)]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(14)]
        public string Date_14 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Conditional(13)]
        [StringLength(4, 4)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(15)]
        public string Time_15 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [DataElement("374", typeof(X12_ID_374))]
        [Pos(16)]
        public string DateTimeQualifier_16 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Conditional(16)]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(17)]
        public string Date_17 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Conditional(16)]
        [StringLength(4, 4)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(18)]
        public string Time_18 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [DataElement("374", typeof(X12_ID_374))]
        [Pos(19)]
        public string DateTimeQualifier_19 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Conditional(19)]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(20)]
        public string Date_20 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Conditional(19)]
        [StringLength(4, 4)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(21)]
        public string Time_21 { get; set; }
    }

    /// <summary>
    /// Destination Station
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("D9")]
    public class D9 : I_D9
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Freight Station Accounting Code
        /// </summary>
        [DataMember]
        [StringLength(1, 5)]
        [DataElement("573", typeof(X12_AN))]
        [Pos(1)]
        public string FreightStationAccountingCode_01 { get; set; }
        /// <summary>
        /// Destination Station
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 19)]
        [DataElement("300", typeof(X12_AN))]
        [Pos(2)]
        public string DestinationStation_02 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_AN))]
        [Pos(3)]
        public string StateorProvinceCode_03 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("26", typeof(X12_AN))]
        [Pos(4)]
        public string CountryCode_04 { get; set; }
        /// <summary>
        /// Billed At Station Code
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("194", typeof(X12_AN))]
        [Pos(5)]
        public string BilledAtStationCode_05 { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [StringLength(2, 19)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(6)]
        public string CityName_06 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_AN))]
        [Pos(7)]
        public string StateorProvinceCode_07 { get; set; }
        /// <summary>
        /// Standard Point Location Code
        /// </summary>
        [DataMember]
        [StringLength(6, 9)]
        [DataElement("154", typeof(X12_AN))]
        [Pos(8)]
        public string StandardPointLocationCode_08 { get; set; }
        /// <summary>
        /// Postal Code
        /// </summary>
        [DataMember]
        [StringLength(4, 9)]
        [DataElement("116", typeof(X12_AN))]
        [Pos(9)]
        public string PostalCode_09 { get; set; }
    }

    /// <summary>
    /// Appendix Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DAI")]
    public class DAI : I_DAI
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Maintenance Operation Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("487", typeof(X12_ID_487))]
        [Pos(1)]
        public string MaintenanceOperationCode_01 { get; set; }
        /// <summary>
        /// Code List Reference
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 6)]
        [DataElement("916", typeof(X12_AN))]
        [Pos(2)]
        public string CodeListReference_02 { get; set; }
        /// <summary>
        /// Note Identification Number
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("490", typeof(X12_N0))]
        [Pos(3)]
        public string NoteIdentificationNumber_03 { get; set; }
    }

    /// <summary>
    /// Description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DDI")]
    public class DDI : I_DDI
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(1)]
        public string Description_01 { get; set; }
    }

    /// <summary>
    /// Deposit
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DEP")]
    public class DEP : I_DEP
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(1)]
        public string ReferenceNumber_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(2)]
        public string Date_02 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(3)]
        public string Time_03 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceNumber_04 { get; set; }
        /// <summary>
        /// (DFI) ID Number Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("506", typeof(X12_ID_506))]
        [Pos(5)]
        public string DFIIDNumberQualifier_05 { get; set; }
        /// <summary>
        /// (DFI) Identification Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(3, 12)]
        [DataElement("507", typeof(X12_AN))]
        [Pos(6)]
        public string DFIIdentificationNumber_06 { get; set; }
        /// <summary>
        /// Account Number Qualifier Code
        /// </summary>
        [DataMember]
        [Paired(8)]
        [DataElement("896", typeof(X12_ID_896))]
        [Pos(7)]
        public string AccountNumberQualifierCode_07 { get; set; }
        /// <summary>
        /// Account Number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("508", typeof(X12_AN))]
        [Pos(8)]
        public string AccountNumber_08 { get; set; }
    }

    /// <summary>
    /// Discount Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DIS")]
    public class DIS : I_DIS
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Discount Terms Type Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("653", typeof(X12_ID_653))]
        [Pos(1)]
        public string DiscountTermsTypeCode_01 { get; set; }
        /// <summary>
        /// Discount Base Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("654", typeof(X12_ID_654))]
        [Pos(2)]
        public string DiscountBaseQualifier_02 { get; set; }
        /// <summary>
        /// Discount Base Value
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 10)]
        [DataElement("655", typeof(X12_R))]
        [Pos(3)]
        public string DiscountBaseValue_03 { get; set; }
        /// <summary>
        /// Discount Control Limit Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("656", typeof(X12_ID_656))]
        [Pos(4)]
        public string DiscountControlLimitQualifier_04 { get; set; }
        /// <summary>
        /// Lower Discount Control Limit
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 10)]
        [DataElement("657", typeof(X12_N0))]
        [Pos(5)]
        public string LowerDiscountControlLimit_05 { get; set; }
        /// <summary>
        /// Upper Discount Control Limit
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("658", typeof(X12_N0))]
        [Pos(6)]
        public string UpperDiscountControlLimit_06 { get; set; }
    }

    /// <summary>
    /// Data Maintenance Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DMI")]
    public class DMI : I_DMI
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Maintenance Operation Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("487", typeof(X12_ID_487))]
        [Pos(1)]
        public string MaintenanceOperationCode_01 { get; set; }
        /// <summary>
        /// Data Maintenance Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 6)]
        [DataElement("926", typeof(X12_AN))]
        [Pos(2)]
        public string DataMaintenanceNumber_02 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(3)]
        public string Name_03 { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(4)]
        public string AddressInformation_04 { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(5)]
        public string AddressInformation_05 { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [StringLength(2, 19)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(6)]
        public string CityName_06 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_AN))]
        [Pos(7)]
        public string StateorProvinceCode_07 { get; set; }
        /// <summary>
        /// Postal Code
        /// </summary>
        [DataMember]
        [StringLength(4, 9)]
        [DataElement("116", typeof(X12_AN))]
        [Pos(8)]
        public string PostalCode_08 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("26", typeof(X12_AN))]
        [Pos(9)]
        public string CountryCode_09 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [DataElement("365", typeof(X12_ID_365))]
        [Pos(10)]
        public string CommunicationNumberQualifier_10 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Conditional(10)]
        [StringLength(7, 21)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(11)]
        public string CommunicationNumber_11 { get; set; }
        /// <summary>
        /// Note Identification Number
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("490", typeof(X12_N0))]
        [Pos(12)]
        public string NoteIdentificationNumber_12 { get; set; }
    }

    /// <summary>
    /// Date/Time Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("DTM")]
    public class DTM : I_DTM
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("374", typeof(X12_ID_374))]
        [Pos(1)]
        public string DateTimeQualifier_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [RequiredAny(3)]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(2)]
        public string Date_02 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(3)]
        public string Time_03 { get; set; }
        /// <summary>
        /// Time Code
        /// </summary>
        [DataMember]
        [DataElement("623", typeof(X12_ID_623))]
        [Pos(4)]
        public string TimeCode_04 { get; set; }
    }

    /// <summary>
    /// Electronic Form Main Heading
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("E01")]
    public class E01 : I_E01
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Maintenance Operation Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("487", typeof(X12_ID_487))]
        [Pos(1)]
        public string MaintenanceOperationCode_01 { get; set; }
        /// <summary>
        /// Electronic Form Standards Type Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("922", typeof(X12_ID_922))]
        [Pos(2)]
        public string ElectronicFormStandardsTypeCode_02 { get; set; }
        /// <summary>
        /// Version / Release / Industry Identifier Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("480", typeof(X12_ID_480))]
        [Pos(3)]
        public string VersionReleaseIndustryIdentifierCode_03 { get; set; }
        /// <summary>
        /// Full or Partial Indicator
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("924", typeof(X12_ID_924))]
        [Pos(4)]
        public string FullorPartialIndicator_04 { get; set; }
    }

    /// <summary>
    /// Interchange Order of Segments
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("E03")]
    public class E03 : I_E03
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Maintenance Operation Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("487", typeof(X12_ID_487))]
        [Pos(1)]
        public string MaintenanceOperationCode_01 { get; set; }
        /// <summary>
        /// Level Number
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("906", typeof(X12_ID_906))]
        [Pos(2)]
        public string LevelNumber_02 { get; set; }
        /// <summary>
        /// Segment ID Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 3)]
        [DataElement("721", typeof(X12_AN))]
        [Pos(3)]
        public string SegmentIDCode_03 { get; set; }
        /// <summary>
        /// Envelope Indicator
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("903", typeof(X12_ID_903))]
        [Pos(4)]
        public string EnvelopeIndicator_04 { get; set; }
        /// <summary>
        /// Requirement Designator
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("904", typeof(X12_ID_904))]
        [Pos(5)]
        public string RequirementDesignator_05 { get; set; }
        /// <summary>
        /// Maximum Use
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 7)]
        [DataElement("905", typeof(X12_N0))]
        [Pos(6)]
        public string MaximumUse_06 { get; set; }
        /// <summary>
        /// Note Identification Number
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("490", typeof(X12_N0))]
        [Pos(7)]
        public string NoteIdentificationNumber_07 { get; set; }
    }

    /// <summary>
    /// Empty Car Disposition - Pended Destination Consignee
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("E1")]
    public class E1 : I_E1
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Name (30 Character Format)
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 30)]
        [DataElement("459", typeof(X12_AN))]
        [Pos(1)]
        public string NameCharacterFormat_01 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Paired(3)]
        [DataElement("66", typeof(X12_ID_66))]
        [Pos(2)]
        public string IdentificationCodeQualifier_02 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [StringLength(2, 17)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(3)]
        public string IdentificationCode_03 { get; set; }
    }

    /// <summary>
    /// Transaction Set Grouping
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("E10")]
    public class E10 : I_E10
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Maintenance Operation Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("487", typeof(X12_ID_487))]
        [Pos(1)]
        public string MaintenanceOperationCode_01 { get; set; }
        /// <summary>
        /// Transaction Set Identifier Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("143", typeof(X12_ID_143))]
        [Pos(2)]
        public string TransactionSetIdentifierCode_02 { get; set; }
        /// <summary>
        /// Functional Identifier Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("479", typeof(X12_ID_479))]
        [Pos(3)]
        public string FunctionalIdentifierCode_03 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(4)]
        public string Description_04 { get; set; }
        /// <summary>
        /// Note Identification Number
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("490", typeof(X12_N0))]
        [Pos(5)]
        public string NoteIdentificationNumber_05 { get; set; }
    }

    /// <summary>
    /// Section Indicator
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("E12")]
    public class E12 : I_E12
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Maintenance Operation Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("487", typeof(X12_ID_487))]
        [Pos(1)]
        public string MaintenanceOperationCode_01 { get; set; }
        /// <summary>
        /// Position in Set
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 6)]
        [DataElement("589", typeof(X12_N0))]
        [Pos(2)]
        public string PositioninSet_02 { get; set; }
        /// <summary>
        /// Section Designator
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("902", typeof(X12_ID_902))]
        [Pos(3)]
        public string SectionDesignator_03 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(4)]
        public string Description_04 { get; set; }
    }

    /// <summary>
    /// Segment Order in Transaction Set
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("E14")]
    public class E14 : I_E14
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Maintenance Operation Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("487", typeof(X12_ID_487))]
        [Pos(1)]
        public string MaintenanceOperationCode_01 { get; set; }
        /// <summary>
        /// Position in Set
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 6)]
        [DataElement("589", typeof(X12_N0))]
        [Pos(2)]
        public string PositioninSet_02 { get; set; }
        /// <summary>
        /// Segment ID Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 3)]
        [DataElement("721", typeof(X12_AN))]
        [Pos(3)]
        public string SegmentIDCode_03 { get; set; }
        /// <summary>
        /// Requirement Designator
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("904", typeof(X12_ID_904))]
        [Pos(4)]
        public string RequirementDesignator_04 { get; set; }
        /// <summary>
        /// Maximum Use
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 7)]
        [DataElement("905", typeof(X12_N0))]
        [Pos(5)]
        public string MaximumUse_05 { get; set; }
        /// <summary>
        /// Loop Name
        /// </summary>
        [DataMember]
        [StringLength(2, 4)]
        [DataElement("909", typeof(X12_AN))]
        [Pos(6)]
        public string LoopName_06 { get; set; }
        /// <summary>
        /// Loop Repeat Count
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("910", typeof(X12_N0))]
        [Pos(7)]
        public string LoopRepeatCount_07 { get; set; }
        /// <summary>
        /// Loop Level Number
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("489", typeof(X12_N0))]
        [Pos(8)]
        public string LoopLevelNumber_08 { get; set; }
        /// <summary>
        /// Note Identification Number
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("490", typeof(X12_N0))]
        [Pos(9)]
        public string NoteIdentificationNumber_09 { get; set; }
    }

    /// <summary>
    /// Segment Header Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("E20")]
    public class E20 : I_E20
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Maintenance Operation Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("487", typeof(X12_ID_487))]
        [Pos(1)]
        public string MaintenanceOperationCode_01 { get; set; }
        /// <summary>
        /// Segment ID Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 3)]
        [DataElement("721", typeof(X12_AN))]
        [Pos(2)]
        public string SegmentIDCode_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Note Identification Number
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("490", typeof(X12_N0))]
        [Pos(4)]
        public string NoteIdentificationNumber_04 { get; set; }
    }

    /// <summary>
    /// Data Element Relationships in a Segment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("E22")]
    public class E22 : I_E22
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Maintenance Operation Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("487", typeof(X12_ID_487))]
        [Pos(1)]
        public string MaintenanceOperationCode_01 { get; set; }
        /// <summary>
        /// Relation Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("912", typeof(X12_ID_912))]
        [Pos(2)]
        public string RelationCode_02 { get; set; }
        /// <summary>
        /// Position in Segment
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 2)]
        [DataElement("911", typeof(X12_N0))]
        [Pos(3)]
        public string PositioninSegment_03 { get; set; }
        /// <summary>
        /// Position in Segment
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("911", typeof(X12_N0))]
        [Pos(4)]
        public string PositioninSegment_04 { get; set; }
        /// <summary>
        /// Position in Segment
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("911", typeof(X12_N0))]
        [Pos(5)]
        public string PositioninSegment_05 { get; set; }
        /// <summary>
        /// Position in Segment
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("911", typeof(X12_N0))]
        [Pos(6)]
        public string PositioninSegment_06 { get; set; }
    }

    /// <summary>
    /// Data Element Sequence in a Segment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("E24")]
    public class E24 : I_E24
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Maintenance Operation Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("487", typeof(X12_ID_487))]
        [Pos(1)]
        public string MaintenanceOperationCode_01 { get; set; }
        /// <summary>
        /// Position in Segment
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 2)]
        [DataElement("911", typeof(X12_N0))]
        [Pos(2)]
        public string PositioninSegment_02 { get; set; }
        /// <summary>
        /// Data Element Reference Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 4)]
        [DataElement("725", typeof(X12_N0))]
        [Pos(3)]
        public string DataElementReferenceNumber_03 { get; set; }
        /// <summary>
        /// Requirement Designator
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("904", typeof(X12_ID_904))]
        [Pos(4)]
        public string RequirementDesignator_04 { get; set; }
        /// <summary>
        /// Data Element Type
        /// </summary>
        [DataMember]
        [DataElement("491", typeof(X12_ID_491))]
        [Pos(5)]
        public string DataElementType_05 { get; set; }
        /// <summary>
        /// Note Identification Number
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("490", typeof(X12_N0))]
        [Pos(6)]
        public string NoteIdentificationNumber_06 { get; set; }
    }

    /// <summary>
    /// Element Sequence in Composite
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("E26")]
    public class E26 : I_E26
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Maintenance Operation Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("487", typeof(X12_ID_487))]
        [Pos(1)]
        public string MaintenanceOperationCode_01 { get; set; }
        /// <summary>
        /// Position in Composite
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 2)]
        [DataElement("492", typeof(X12_N0))]
        [Pos(2)]
        public string PositioninComposite_02 { get; set; }
        /// <summary>
        /// Data Element Reference Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 4)]
        [DataElement("725", typeof(X12_N0))]
        [Pos(3)]
        public string DataElementReferenceNumber_03 { get; set; }
        /// <summary>
        /// Requirement Designator
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("904", typeof(X12_ID_904))]
        [Pos(4)]
        public string RequirementDesignator_04 { get; set; }
        /// <summary>
        /// Data Element Type
        /// </summary>
        [DataMember]
        [DataElement("491", typeof(X12_ID_491))]
        [Pos(5)]
        public string DataElementType_05 { get; set; }
        /// <summary>
        /// Note Identification Number
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("490", typeof(X12_N0))]
        [Pos(6)]
        public string NoteIdentificationNumber_06 { get; set; }
    }

    /// <summary>
    /// Data Element Attributes
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("E30")]
    public class E30 : I_E30
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Maintenance Operation Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("487", typeof(X12_ID_487))]
        [Pos(1)]
        public string MaintenanceOperationCode_01 { get; set; }
        /// <summary>
        /// Data Element Reference Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 4)]
        [DataElement("725", typeof(X12_N0))]
        [Pos(2)]
        public string DataElementReferenceNumber_02 { get; set; }
        /// <summary>
        /// Data Element Type
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("913", typeof(X12_ID_913))]
        [Pos(3)]
        public string DataElementType_03 { get; set; }
        /// <summary>
        /// Minimum Length
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 2)]
        [DataElement("914", typeof(X12_N0))]
        [Pos(4)]
        public string MinimumLength_04 { get; set; }
        /// <summary>
        /// Maximum Length
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 7)]
        [DataElement("915", typeof(X12_N0))]
        [Pos(5)]
        public string MaximumLength_05 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(6)]
        public string Description_06 { get; set; }
        /// <summary>
        /// Note Identification Number
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("490", typeof(X12_N0))]
        [Pos(7)]
        public string NoteIdentificationNumber_07 { get; set; }
    }

    /// <summary>
    /// Code List Values for a Data Element
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("E34")]
    public class E34 : I_E34
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Maintenance Operation Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("487", typeof(X12_ID_487))]
        [Pos(1)]
        public string MaintenanceOperationCode_01 { get; set; }
        /// <summary>
        /// Code Value
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 8)]
        [DataElement("918", typeof(X12_AN))]
        [Pos(2)]
        public string CodeValue_02 { get; set; }
        /// <summary>
        /// Partition Indicator
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("505", typeof(X12_AN))]
        [Pos(3)]
        public string PartitionIndicator_03 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(4)]
        public string Description_04 { get; set; }
    }

    /// <summary>
    /// Empty Car Disposition - Pended Destination City
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("E4")]
    public class E4 : I_E4
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 19)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(1)]
        public string CityName_01 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_AN))]
        [Pos(2)]
        public string StateorProvinceCode_02 { get; set; }
        /// <summary>
        /// Postal Code
        /// </summary>
        [DataMember]
        [StringLength(4, 9)]
        [DataElement("116", typeof(X12_AN))]
        [Pos(3)]
        public string PostalCode_03 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("26", typeof(X12_AN))]
        [Pos(4)]
        public string CountryCode_04 { get; set; }
    }

    /// <summary>
    /// EDI Standards Note Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("E40")]
    public class E40 : I_E40
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Maintenance Operation Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("487", typeof(X12_ID_487))]
        [Pos(1)]
        public string MaintenanceOperationCode_01 { get; set; }
        /// <summary>
        /// Note Identification Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 6)]
        [DataElement("490", typeof(X12_N0))]
        [Pos(2)]
        public string NoteIdentificationNumber_02 { get; set; }
        /// <summary>
        /// Electronic Form Note Reference Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("568", typeof(X12_ID_568))]
        [Pos(3)]
        public string ElectronicFormNoteReferenceCode_03 { get; set; }
        /// <summary>
        /// Assigned Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("350", typeof(X12_AN))]
        [Pos(4)]
        public string AssignedIdentification_04 { get; set; }
    }

    /// <summary>
    /// Empty Car Disposition - Pended Destination Route
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("E5")]
    public class E5 : I_E5
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 4)]
        [DataElement("140", typeof(X12_AN))]
        [Pos(1)]
        public string StandardCarrierAlphaCode_01 { get; set; }
        /// <summary>
        /// Routing Sequence Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("133", typeof(X12_ID_133))]
        [Pos(2)]
        public string RoutingSequenceCode_02 { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [StringLength(2, 19)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(3)]
        public string CityName_03 { get; set; }
        /// <summary>
        /// Standard Point Location Code
        /// </summary>
        [DataMember]
        [StringLength(6, 9)]
        [DataElement("154", typeof(X12_AN))]
        [Pos(4)]
        public string StandardPointLocationCode_04 { get; set; }
    }

    /// <summary>
    /// Electronic Format Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("EFI")]
    public class EFI : I_EFI
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Security Level Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("786", typeof(X12_ID_786))]
        [Pos(1)]
        public string SecurityLevelCode_01 { get; set; }
        /// <summary>
        /// Free-Form Message Text
        /// </summary>
        [DataMember]
        [StringLength(1, 264)]
        [DataElement("933", typeof(X12_AN))]
        [Pos(2)]
        public string FreeFormMessageText_02 { get; set; }
        /// <summary>
        /// Security Technique Code
        /// </summary>
        [DataMember]
        [DataElement("797", typeof(X12_ID_797))]
        [Pos(3)]
        public string SecurityTechniqueCode_03 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(4)]
        public string VersionIdentifier_04 { get; set; }
        /// <summary>
        /// Program Identifier
        /// </summary>
        [DataMember]
        [Conditional(4)]
        [StringLength(1, 30)]
        [DataElement("802", typeof(X12_AN))]
        [Pos(5)]
        public string ProgramIdentifier_05 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(6)]
        public string VersionIdentifier_06 { get; set; }
        /// <summary>
        /// Interchange Format
        /// </summary>
        [DataMember]
        [Conditional(6)]
        [StringLength(1, 30)]
        [DataElement("801", typeof(X12_AN))]
        [Pos(7)]
        public string InterchangeFormat_07 { get; set; }
        /// <summary>
        /// Version Identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("799", typeof(X12_AN))]
        [Pos(8)]
        public string VersionIdentifier_08 { get; set; }
        /// <summary>
        /// Compression Technique
        /// </summary>
        [DataMember]
        [Conditional(8)]
        [StringLength(1, 30)]
        [DataElement("800", typeof(X12_AN))]
        [Pos(9)]
        public string CompressionTechnique_09 { get; set; }
        /// <summary>
        /// Drawing Sheet Size Code
        /// </summary>
        [DataMember]
        [DataElement("789", typeof(X12_ID_789))]
        [Pos(10)]
        public string DrawingSheetSizeCode_10 { get; set; }
        /// <summary>
        /// File Name
        /// </summary>
        [DataMember]
        [StringLength(1, 64)]
        [DataElement("803", typeof(X12_AN))]
        [Pos(11)]
        public string FileName_11 { get; set; }
        /// <summary>
        /// Block Type
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("804", typeof(X12_AN))]
        [Pos(12)]
        public string BlockType_12 { get; set; }
        /// <summary>
        /// Record Length
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("787", typeof(X12_N))]
        [Pos(13)]
        public string RecordLength_13 { get; set; }
        /// <summary>
        /// Block Length
        /// </summary>
        [DataMember]
        [StringLength(1, 5)]
        [DataElement("788", typeof(X12_N))]
        [Pos(14)]
        public string BlockLength_14 { get; set; }
    }

    /// <summary>
    /// Excess Transportation Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ETD")]
    public class ETD : I_ETD
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Excess Transportation Reason Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("626", typeof(X12_ID_626))]
        [Pos(1)]
        public string ExcessTransportationReasonCode_01 { get; set; }
        /// <summary>
        /// Excess Transportation Responsibility Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("627", typeof(X12_ID_627))]
        [Pos(2)]
        public string ExcessTransportationResponsibilityCode_02 { get; set; }
        /// <summary>
        /// Reference Number Qualifier
        /// </summary>
        [DataMember]
        [Paired(4)]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(3)]
        public string ReferenceNumberQualifier_03 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceNumber_04 { get; set; }
        /// <summary>
        /// Returnable Container Freight Payment Responsibility Code
        /// </summary>
        [DataMember]
        [DataElement("743", typeof(X12_ID_743))]
        [Pos(5)]
        public string ReturnableContainerFreightPaymentResponsibilityCode_05 { get; set; }
    }

    /// <summary>
    /// Origin Station
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("F9")]
    public class F9 : I_F9
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Freight Station Accounting Code
        /// </summary>
        [DataMember]
        [StringLength(1, 5)]
        [DataElement("573", typeof(X12_AN))]
        [Pos(1)]
        public string FreightStationAccountingCode_01 { get; set; }
        /// <summary>
        /// Origin Station
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 19)]
        [DataElement("101", typeof(X12_AN))]
        [Pos(2)]
        public string OriginStation_02 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_AN))]
        [Pos(3)]
        public string StateorProvinceCode_03 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("26", typeof(X12_AN))]
        [Pos(4)]
        public string CountryCode_04 { get; set; }
        /// <summary>
        /// Billed At Station Code
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("194", typeof(X12_AN))]
        [Pos(5)]
        public string BilledAtStationCode_05 { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [StringLength(2, 19)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(6)]
        public string CityName_06 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_AN))]
        [Pos(7)]
        public string StateorProvinceCode_07 { get; set; }
        /// <summary>
        /// Standard Point Location Code
        /// </summary>
        [DataMember]
        [StringLength(6, 9)]
        [DataElement("154", typeof(X12_AN))]
        [Pos(8)]
        public string StandardPointLocationCode_08 { get; set; }
        /// <summary>
        /// Postal Code
        /// </summary>
        [DataMember]
        [StringLength(4, 9)]
        [DataElement("116", typeof(X12_AN))]
        [Pos(9)]
        public string PostalCode_09 { get; set; }
    }

    /// <summary>
    /// Financial Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FIR")]
    public class FIR : I_FIR
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Financial Transaction Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(6, 6)]
        [DataElement("702", typeof(X12_AN))]
        [Pos(1)]
        public string FinancialTransactionCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [RequiredAny(3, 4)]
        [StringLength(1, 15)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string MonetaryAmount_02 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("380", typeof(X12_R))]
        [Pos(3)]
        public string Quantity_03 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("380", typeof(X12_R))]
        [Pos(4)]
        public string Quantity_04 { get; set; }
        /// <summary>
        /// Financial Information Type Code
        /// </summary>
        [DataMember]
        [DataElement("703", typeof(X12_ID_703))]
        [Pos(5)]
        public string FinancialInformationTypeCode_05 { get; set; }
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        [DataMember]
        [DataElement("478", typeof(X12_ID_478))]
        [Pos(6)]
        public string CreditDebitFlagCode_06 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(7)]
        public string Date_07 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(8)]
        public string Time_08 { get; set; }
        /// <summary>
        /// Time Code
        /// </summary>
        [DataMember]
        [Conditional(8)]
        [DataElement("623", typeof(X12_ID_623))]
        [Pos(9)]
        public string TimeCode_09 { get; set; }
        /// <summary>
        /// Currency Code
        /// </summary>
        [DataMember]
        [StringLength(3, 3)]
        [DataElement("100", typeof(X12_AN))]
        [Pos(10)]
        public string CurrencyCode_10 { get; set; }
    }

    /// <summary>
    /// F.O.B. Related Instructions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FOB")]
    public class FOB : I_FOB
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Shipment Method of Payment
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("146", typeof(X12_ID_146))]
        [Pos(1)]
        public string ShipmentMethodofPayment_01 { get; set; }
        /// <summary>
        /// Location Qualifier
        /// </summary>
        [DataMember]
        [DataElement("309", typeof(X12_ID_309))]
        [Pos(2)]
        public string LocationQualifier_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Conditional(2)]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Transportation Terms Qualifier Code
        /// </summary>
        [DataMember]
        [Conditional(5)]
        [DataElement("334", typeof(X12_ID_334))]
        [Pos(4)]
        public string TransportationTermsQualifierCode_04 { get; set; }
        /// <summary>
        /// Transportation Terms Code
        /// </summary>
        [DataMember]
        [DataElement("335", typeof(X12_ID_335))]
        [Pos(5)]
        public string TransportationTermsCode_05 { get; set; }
        /// <summary>
        /// Location Qualifier
        /// </summary>
        [DataMember]
        [DataElement("309", typeof(X12_ID_309))]
        [Pos(6)]
        public string LocationQualifier_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [Conditional(6)]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(7)]
        public string Description_07 { get; set; }
        /// <summary>
        /// Risk of Loss Qualifier
        /// </summary>
        [DataMember]
        [Conditional(9)]
        [DataElement("54", typeof(X12_ID_54))]
        [Pos(8)]
        public string RiskofLossQualifier_08 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(9)]
        public string Description_09 { get; set; }
    }

    /// <summary>
    /// Forecast Schedule
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("FST")]
    public class FST : I_FST
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 10)]
        [DataElement("380", typeof(X12_R))]
        [Pos(1)]
        public string Quantity_01 { get; set; }
        /// <summary>
        /// Forecast Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("680", typeof(X12_ID_680))]
        [Pos(2)]
        public string ForecastQualifier_02 { get; set; }
        /// <summary>
        /// Forecast Timing Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("681", typeof(X12_ID_681))]
        [Pos(3)]
        public string ForecastTimingQualifier_03 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(4)]
        public string Date_04 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(5)]
        public string Date_05 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Paired(7)]
        [DataElement("374", typeof(X12_ID_374))]
        [Pos(6)]
        public string DateTimeQualifier_06 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(7)]
        public string Time_07 { get; set; }
        /// <summary>
        /// Reference Number Qualifier
        /// </summary>
        [DataMember]
        [Paired(9)]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(8)]
        public string ReferenceNumberQualifier_08 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(9)]
        public string ReferenceNumber_09 { get; set; }
    }

    /// <summary>
    /// Scale Identification Segment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("G4")]
    public class G4 : I_G4
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 19)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(1)]
        public string CityName_01 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_AN))]
        [Pos(2)]
        public string StateorProvinceCode_02 { get; set; }
        /// <summary>
        /// Name (30 Character Format)
        /// </summary>
        [DataMember]
        [StringLength(2, 30)]
        [DataElement("459", typeof(X12_AN))]
        [Pos(3)]
        public string NameCharacterFormat_03 { get; set; }
        /// <summary>
        /// Event Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(6, 6)]
        [DataElement("179", typeof(X12_DT))]
        [Pos(4)]
        public string EventDate_04 { get; set; }
        /// <summary>
        /// Event Time
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("180", typeof(X12_TM))]
        [Pos(5)]
        public string EventTime_05 { get; set; }
        /// <summary>
        /// Scale Type Code
        /// </summary>
        [DataMember]
        [DataElement("570", typeof(X12_ID_570))]
        [Pos(6)]
        public string ScaleTypeCode_06 { get; set; }
    }

    /// <summary>
    /// Date/Time
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("G62")]
    public class G62 : I_G62
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date Qualifier
        /// </summary>
        [DataMember]
        [RequiredAny(3)]
        [Paired(2)]
        [DataElement("432", typeof(X12_ID_432))]
        [Pos(1)]
        public string DateQualifier_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(2)]
        public string Date_02 { get; set; }
        /// <summary>
        /// Time Qualifier
        /// </summary>
        [DataMember]
        [Paired(4)]
        [DataElement("176", typeof(X12_ID_176))]
        [Pos(3)]
        public string TimeQualifier_03 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(4)]
        public string Time_04 { get; set; }
        /// <summary>
        /// Time Code
        /// </summary>
        [DataMember]
        [DataElement("623", typeof(X12_ID_623))]
        [Pos(5)]
        public string TimeCode_05 { get; set; }
    }

    /// <summary>
    /// Canadian Grain Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("GA")]
    public class GA : I_GA
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Commodity Code Qualifier
        /// </summary>
        [DataMember]
        [DataElement("23", typeof(X12_ID_23))]
        [Pos(1)]
        public string CommodityCodeQualifier_01 { get; set; }
        /// <summary>
        /// Commodity Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 16)]
        [DataElement("22", typeof(X12_AN))]
        [Pos(2)]
        public string CommodityCode_02 { get; set; }
        /// <summary>
        /// Weight Qualifier
        /// </summary>
        [DataMember]
        [DataElement("187", typeof(X12_ID_187))]
        [Pos(3)]
        public string WeightQualifier_03 { get; set; }
        /// <summary>
        /// Reference Number Qualifier
        /// </summary>
        [DataMember]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(4)]
        public string ReferenceNumberQualifier_04 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(5)]
        public string ReferenceNumber_05 { get; set; }
        /// <summary>
        /// Week
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("642", typeof(X12_N0))]
        [Pos(6)]
        public string Week_06 { get; set; }
        /// <summary>
        /// Unload Terminal
        /// </summary>
        [DataMember]
        [StringLength(3, 3)]
        [DataElement("899", typeof(X12_AN))]
        [Pos(7)]
        public string UnloadTerminal_07 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(8)]
        public string Date_08 { get; set; }
        /// <summary>
        /// Incentive Grain Rate Indicator
        /// </summary>
        [DataMember]
        [DataElement("898", typeof(X12_ID_898))]
        [Pos(9)]
        public string IncentiveGrainRateIndicator_09 { get; set; }
    }

    /// <summary>
    /// Military Standard 1840-A Record Definition
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("GOV")]
    public class GOV : I_GOV
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Association Qualifier Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("559", typeof(X12_ID_559))]
        [Pos(1)]
        public string AssociationQualifierCode_01 { get; set; }
        /// <summary>
        /// Record/File Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("793", typeof(X12_AN))]
        [Pos(2)]
        public string RecordFileQualifier_02 { get; set; }
        /// <summary>
        /// Record Format Data
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("794", typeof(X12_AN))]
        [Pos(3)]
        public string RecordFormatData_03 { get; set; }
    }

    /// <summary>
    /// Hazardous Material
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("H1")]
    public class H1 : I_H1
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Hazardous Material Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(4, 10)]
        [DataElement("62", typeof(X12_AN))]
        [Pos(1)]
        public string HazardousMaterialCode_01 { get; set; }
        /// <summary>
        /// Hazardous Material Class Code
        /// </summary>
        [DataMember]
        [StringLength(2, 4)]
        [DataElement("209", typeof(X12_AN))]
        [Pos(2)]
        public string HazardousMaterialClassCode_02 { get; set; }
        /// <summary>
        /// Hazardous Material Code Qualifier
        /// </summary>
        [DataMember]
        [DataElement("208", typeof(X12_ID_208))]
        [Pos(3)]
        public string HazardousMaterialCodeQualifier_03 { get; set; }
        /// <summary>
        /// Hazardous Material Description
        /// </summary>
        [DataMember]
        [StringLength(2, 30)]
        [DataElement("64", typeof(X12_AN))]
        [Pos(4)]
        public string HazardousMaterialDescription_04 { get; set; }
        /// <summary>
        /// Hazardous Material Contact
        /// </summary>
        [DataMember]
        [StringLength(1, 24)]
        [DataElement("63", typeof(X12_AN))]
        [Pos(5)]
        public string HazardousMaterialContact_05 { get; set; }
        /// <summary>
        /// Hazardous Materials Page
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("200", typeof(X12_AN))]
        [Pos(6)]
        public string HazardousMaterialsPage_06 { get; set; }
        /// <summary>
        /// Flashpoint Temperature
        /// </summary>
        [DataMember]
        [Paired(8)]
        [StringLength(1, 3)]
        [DataElement("77", typeof(X12_N))]
        [Pos(7)]
        public string FlashpointTemperature_07 { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(8)]
        public string UnitofMeasurementCode_08 { get; set; }
    }

    /// <summary>
    /// Additional Hazardous Material Description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("H2")]
    public class H2 : I_H2
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Hazardous Material Description
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 30)]
        [DataElement("64", typeof(X12_AN))]
        [Pos(1)]
        public string HazardousMaterialDescription_01 { get; set; }
        /// <summary>
        /// Hazardous Material Classification
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("274", typeof(X12_AN))]
        [Pos(2)]
        public string HazardousMaterialClassification_02 { get; set; }
    }

    /// <summary>
    /// Special Handling Instructions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("H3")]
    public class H3 : I_H3
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Special Handling Code
        /// </summary>
        [DataMember]
        [Exclusion(2)]
        [DataElement("152", typeof(X12_ID_152))]
        [Pos(1)]
        public string SpecialHandlingCode_01 { get; set; }
        /// <summary>
        /// Special Handling Description
        /// </summary>
        [DataMember]
        [StringLength(2, 30)]
        [DataElement("153", typeof(X12_AN))]
        [Pos(2)]
        public string SpecialHandlingDescription_02 { get; set; }
        /// <summary>
        /// Protective Service Code
        /// </summary>
        [DataMember]
        [DataElement("241", typeof(X12_ID_241))]
        [Pos(3)]
        public string ProtectiveServiceCode_03 { get; set; }
        /// <summary>
        /// Vent Instruction Code
        /// </summary>
        [DataMember]
        [DataElement("242", typeof(X12_ID_242))]
        [Pos(4)]
        public string VentInstructionCode_04 { get; set; }
        /// <summary>
        /// Tariff Application Code
        /// </summary>
        [DataMember]
        [DataElement("257", typeof(X12_ID_257))]
        [Pos(5)]
        public string TariffApplicationCode_05 { get; set; }
    }

    /// <summary>
    /// Special Services
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("H6")]
    public class H6 : I_H6
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Special Services Code
        /// </summary>
        [DataMember]
        [RequiredAny(2)]
        [DataElement("560", typeof(X12_ID_560))]
        [Pos(1)]
        public string SpecialServicesCode_01 { get; set; }
        /// <summary>
        /// Special Services Code
        /// </summary>
        [DataMember]
        [DataElement("560", typeof(X12_ID_560))]
        [Pos(2)]
        public string SpecialServicesCode_02 { get; set; }
        /// <summary>
        /// Quantity of Pallets Shipped
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("406", typeof(X12_N0))]
        [Pos(3)]
        public string QuantityofPalletsShipped_03 { get; set; }
        /// <summary>
        /// Pallet Exchange Code
        /// </summary>
        [DataMember]
        [DataElement("399", typeof(X12_ID_399))]
        [Pos(4)]
        public string PalletExchangeCode_04 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("81", typeof(X12_R))]
        [Pos(5)]
        public string Weight_05 { get; set; }
        /// <summary>
        /// Weight Unit Qualifier
        /// </summary>
        [DataMember]
        [DataElement("188", typeof(X12_ID_188))]
        [Pos(6)]
        public string WeightUnitQualifier_06 { get; set; }
    }

    /// <summary>
    /// Hierarchical Level
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("HL")]
    public class HL : I_HL
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Hierarchical ID Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 12)]
        [DataElement("628", typeof(X12_AN))]
        [Pos(1)]
        public string HierarchicalIDNumber_01 { get; set; }
        /// <summary>
        /// Hierarchical Parent ID Number
        /// </summary>
        [DataMember]
        [StringLength(1, 12)]
        [DataElement("734", typeof(X12_AN))]
        [Pos(2)]
        public string HierarchicalParentIDNumber_02 { get; set; }
        /// <summary>
        /// Hierarchical Level Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("735", typeof(X12_ID_735))]
        [Pos(3)]
        public string HierarchicalLevelCode_03 { get; set; }
        /// <summary>
        /// Hierarchical Child Code
        /// </summary>
        [DataMember]
        [DataElement("736", typeof(X12_ID_736))]
        [Pos(4)]
        public string HierarchicalChildCode_04 { get; set; }
    }

    /// <summary>
    /// Intermodal Chassis Equipment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IC")]
    public class IC : I_IC
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Equipment Initial
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 4)]
        [DataElement("206", typeof(X12_AN))]
        [Pos(1)]
        public string EquipmentInitial_01 { get; set; }
        /// <summary>
        /// Equipment Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 10)]
        [DataElement("207", typeof(X12_AN))]
        [Pos(2)]
        public string EquipmentNumber_02 { get; set; }
        /// <summary>
        /// Tare Weight
        /// </summary>
        [DataMember]
        [Paired(4)]
        [StringLength(3, 8)]
        [DataElement("167", typeof(X12_N0))]
        [Pos(3)]
        public string TareWeight_03 { get; set; }
        /// <summary>
        /// Tare Qualifier Code
        /// </summary>
        [DataMember]
        [DataElement("571", typeof(X12_ID_571))]
        [Pos(4)]
        public string TareQualifierCode_04 { get; set; }
        /// <summary>
        /// Equipment Owner Code
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("307", typeof(X12_AN))]
        [Pos(5)]
        public string EquipmentOwnerCode_05 { get; set; }
        /// <summary>
        /// Equipment Length
        /// </summary>
        [DataMember]
        [StringLength(4, 5)]
        [DataElement("567", typeof(X12_N0))]
        [Pos(6)]
        public string EquipmentLength_06 { get; set; }
        /// <summary>
        /// Equipment Owner Code
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("307", typeof(X12_AN))]
        [Pos(7)]
        public string EquipmentOwnerCode_07 { get; set; }
        /// <summary>
        /// Chassis Type
        /// </summary>
        [DataMember]
        [DataElement("845", typeof(X12_ID_845))]
        [Pos(8)]
        public string ChassisType_08 { get; set; }
    }

    /// <summary>
    /// Item Status Report
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ISR")]
    public class ISR : I_ISR
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Shipment/Order Status Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("368", typeof(X12_ID_368))]
        [Pos(1)]
        public string ShipmentOrderStatusCode_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(2)]
        public string Date_02 { get; set; }
        /// <summary>
        /// Status Reason Code
        /// </summary>
        [DataMember]
        [DataElement("641", typeof(X12_ID_641))]
        [Pos(3)]
        public string StatusReasonCode_03 { get; set; }
    }

    /// <summary>
    /// Invoice Shipment Summary
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ISS")]
    public class ISS : I_ISS
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Number of Units Shipped
        /// </summary>
        [DataMember]
        [RequiredAny(3, 5)]
        [Conditional(2)]
        [StringLength(1, 10)]
        [DataElement("382", typeof(X12_R))]
        [Pos(1)]
        public string NumberofUnitsShipped_01 { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(2)]
        public string UnitofMeasurementCode_02 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [DataMember]
        [Conditional(4)]
        [StringLength(1, 8)]
        [DataElement("81", typeof(X12_R))]
        [Pos(3)]
        public string Weight_03 { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(4)]
        public string UnitofMeasurementCode_04 { get; set; }
        /// <summary>
        /// Volume
        /// </summary>
        [DataMember]
        [Conditional(6)]
        [StringLength(1, 8)]
        [DataElement("183", typeof(X12_R))]
        [Pos(5)]
        public string Volume_05 { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(6)]
        public string UnitofMeasurementCode_06 { get; set; }
    }

    /// <summary>
    /// Baseline Item Data (Invoice)
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IT1")]
    public class IT1 : I_IT1
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Assigned Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("350", typeof(X12_AN))]
        [Pos(1)]
        public string AssignedIdentification_01 { get; set; }
        /// <summary>
        /// Quantity Invoiced
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 10)]
        [DataElement("358", typeof(X12_R))]
        [Pos(2)]
        public string QuantityInvoiced_02 { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(3)]
        public string UnitofMeasurementCode_03 { get; set; }
        /// <summary>
        /// Unit Price
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 14)]
        [DataElement("212", typeof(X12_R))]
        [Pos(4)]
        public string UnitPrice_04 { get; set; }
        /// <summary>
        /// Basis of Unit Price Code
        /// </summary>
        [DataMember]
        [DataElement("639", typeof(X12_ID_639))]
        [Pos(5)]
        public string BasisofUnitPriceCode_05 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(7)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(6)]
        public string ProductServiceIDQualifier_06 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(7)]
        public string ProductServiceID_07 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(9)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(8)]
        public string ProductServiceIDQualifier_08 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(9)]
        public string ProductServiceID_09 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(11)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(10)]
        public string ProductServiceIDQualifier_10 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(11)]
        public string ProductServiceID_11 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(13)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(12)]
        public string ProductServiceIDQualifier_12 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(13)]
        public string ProductServiceID_13 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(15)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(14)]
        public string ProductServiceIDQualifier_14 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(15)]
        public string ProductServiceID_15 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(17)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(16)]
        public string ProductServiceIDQualifier_16 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(17)]
        public string ProductServiceID_17 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(19)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(18)]
        public string ProductServiceIDQualifier_18 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(19)]
        public string ProductServiceID_19 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(21)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(20)]
        public string ProductServiceIDQualifier_20 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(21)]
        public string ProductServiceID_21 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(23)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(22)]
        public string ProductServiceIDQualifier_22 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(23)]
        public string ProductServiceID_23 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(25)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(24)]
        public string ProductServiceIDQualifier_24 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(25)]
        public string ProductServiceID_25 { get; set; }
    }

    /// <summary>
    /// Additional Item Data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IT3")]
    public class IT3 : I_IT3
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Number of Units Shipped
        /// </summary>
        [DataMember]
        [Conditional(3)]
        [RequiredAny(3, 4, 5)]
        [StringLength(1, 10)]
        [DataElement("382", typeof(X12_R))]
        [Pos(1)]
        public string NumberofUnitsShipped_01 { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(2)]
        public string UnitofMeasurementCode_02 { get; set; }
        /// <summary>
        /// Shipment/Order Status Code
        /// </summary>
        [DataMember]
        [DataElement("368", typeof(X12_ID_368))]
        [Pos(3)]
        public string ShipmentOrderStatusCode_03 { get; set; }
        /// <summary>
        /// Quantity Difference
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("383", typeof(X12_R))]
        [Pos(4)]
        public string QuantityDifference_04 { get; set; }
        /// <summary>
        /// Change Reason Code
        /// </summary>
        [DataMember]
        [DataElement("371", typeof(X12_ID_371))]
        [Pos(5)]
        public string ChangeReasonCode_05 { get; set; }
    }

    /// <summary>
    /// Conditions of Sale
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("IT8")]
    public class IT8 : I_IT8
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Sales Requirement Code
        /// </summary>
        [DataMember]
        [RequiredAny(2, 3, 5, 7)]
        [DataElement("563", typeof(X12_ID_563))]
        [Pos(1)]
        public string SalesRequirementCode_01 { get; set; }
        /// <summary>
        /// Do-Not-Exceed Action Code
        /// </summary>
        [DataMember]
        [DataElement("564", typeof(X12_ID_564))]
        [Pos(2)]
        public string DoNotExceedActionCode_02 { get; set; }
        /// <summary>
        /// Do-Not-Exceed Amount
        /// </summary>
        [DataMember]
        [StringLength(2, 9)]
        [DataElement("565", typeof(X12_N2))]
        [Pos(3)]
        public string DoNotExceedAmount_03 { get; set; }
        /// <summary>
        /// Account Number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("508", typeof(X12_AN))]
        [Pos(4)]
        public string AccountNumber_04 { get; set; }
        /// <summary>
        /// Required Invoice Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("596", typeof(X12_DT))]
        [Pos(5)]
        public string RequiredInvoiceDate_05 { get; set; }
        /// <summary>
        /// Association Qualifier Code
        /// </summary>
        [DataMember]
        [DataElement("559", typeof(X12_ID_559))]
        [Pos(6)]
        public string AssociationQualifierCode_06 { get; set; }
        /// <summary>
        /// Product/Service Substitution Code
        /// </summary>
        [DataMember]
        [DataElement("566", typeof(X12_ID_566))]
        [Pos(7)]
        public string ProductServiceSubstitutionCode_07 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(9)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(8)]
        public string ProductServiceIDQualifier_08 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(9)]
        public string ProductServiceID_09 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(11)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(10)]
        public string ProductServiceIDQualifier_10 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(11)]
        public string ProductServiceID_11 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(13)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(12)]
        public string ProductServiceIDQualifier_12 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(13)]
        public string ProductServiceID_13 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(15)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(14)]
        public string ProductServiceIDQualifier_14 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(15)]
        public string ProductServiceID_15 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(17)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(16)]
        public string ProductServiceIDQualifier_16 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(17)]
        public string ProductServiceID_17 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(19)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(18)]
        public string ProductServiceIDQualifier_18 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(19)]
        public string ProductServiceID_19 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(21)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(20)]
        public string ProductServiceIDQualifier_20 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(21)]
        public string ProductServiceID_21 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(23)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(22)]
        public string ProductServiceIDQualifier_22 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(23)]
        public string ProductServiceID_23 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(25)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(24)]
        public string ProductServiceIDQualifier_24 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(25)]
        public string ProductServiceID_25 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(27)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(26)]
        public string ProductServiceIDQualifier_26 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(27)]
        public string ProductServiceID_27 { get; set; }
    }

    /// <summary>
    /// Allowance, Charge or Service
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ITA")]
    public class ITA : I_ITA
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Allowance or Charge Indicator
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("248", typeof(X12_ID_248))]
        [Pos(1)]
        public string AllowanceorChargeIndicator_01 { get; set; }
        /// <summary>
        /// Association Qualifier Code
        /// </summary>
        [DataMember]
        [ConditionalAny(3, 13)]
        [DataElement("559", typeof(X12_ID_559))]
        [Pos(2)]
        public string AssociationQualifierCode_02 { get; set; }
        /// <summary>
        /// Special Services Code
        /// </summary>
        [DataMember]
        [DataElement("560", typeof(X12_ID_560))]
        [Pos(3)]
        public string SpecialServicesCode_03 { get; set; }
        /// <summary>
        /// Allowance or Charge Method of Handling Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("331", typeof(X12_ID_331))]
        [Pos(4)]
        public string AllowanceorChargeMethodofHandlingCode_04 { get; set; }
        /// <summary>
        /// Allowance or Charge Number
        /// </summary>
        [DataMember]
        [StringLength(1, 16)]
        [DataElement("341", typeof(X12_AN))]
        [Pos(5)]
        public string AllowanceorChargeNumber_05 { get; set; }
        /// <summary>
        /// Allowance or Charge Rate
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("359", typeof(X12_R))]
        [Pos(6)]
        public string AllowanceorChargeRate_06 { get; set; }
        /// <summary>
        /// Allowance or Charge Total Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("360", typeof(X12_N2))]
        [Pos(7)]
        public string AllowanceorChargeTotalAmount_07 { get; set; }
        /// <summary>
        /// Allowance/ Charge Percent Qualifier
        /// </summary>
        [DataMember]
        [Conditional(9)]
        [DataElement("378", typeof(X12_ID_378))]
        [Pos(8)]
        public string AllowanceChargePercentQualifier_08 { get; set; }
        /// <summary>
        /// Allowance or Charge Percent
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("332", typeof(X12_R))]
        [Pos(9)]
        public string AllowanceorChargePercent_09 { get; set; }
        /// <summary>
        /// Allowance or Charge Quantity
        /// </summary>
        [DataMember]
        [Conditional(11)]
        [StringLength(1, 10)]
        [DataElement("339", typeof(X12_R))]
        [Pos(10)]
        public string AllowanceorChargeQuantity_10 { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(11)]
        public string UnitofMeasurementCode_11 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("380", typeof(X12_R))]
        [Pos(12)]
        public string Quantity_12 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(13)]
        public string Description_13 { get; set; }
        /// <summary>
        /// Special Charge Code
        /// </summary>
        [DataMember]
        [DataElement("150", typeof(X12_ID_150))]
        [Pos(14)]
        public string SpecialChargeCode_14 { get; set; }
    }

    /// <summary>
    /// Terms of Sale/Deferred Terms of Sale
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ITD")]
    public class ITD : I_ITD
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Terms Type Code
        /// </summary>
        [DataMember]
        [DataElement("336", typeof(X12_ID_336))]
        [Pos(1)]
        public string TermsTypeCode_01 { get; set; }
        /// <summary>
        /// Terms Basis Date Code
        /// </summary>
        [DataMember]
        [DataElement("333", typeof(X12_ID_333))]
        [Pos(2)]
        public string TermsBasisDateCode_02 { get; set; }
        /// <summary>
        /// Terms Discount Percent
        /// </summary>
        [DataMember]
        [ConditionalAny(4, 5, 13)]
        [StringLength(1, 6)]
        [DataElement("338", typeof(X12_R))]
        [Pos(3)]
        public string TermsDiscountPercent_03 { get; set; }
        /// <summary>
        /// Terms Discount Due Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("370", typeof(X12_DT))]
        [Pos(4)]
        public string TermsDiscountDueDate_04 { get; set; }
        /// <summary>
        /// Terms Discount Days Due
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("351", typeof(X12_N0))]
        [Pos(5)]
        public string TermsDiscountDaysDue_05 { get; set; }
        /// <summary>
        /// Terms Net Due Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("446", typeof(X12_DT))]
        [Pos(6)]
        public string TermsNetDueDate_06 { get; set; }
        /// <summary>
        /// Terms Net Days
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("386", typeof(X12_N0))]
        [Pos(7)]
        public string TermsNetDays_07 { get; set; }
        /// <summary>
        /// Terms Discount Amount
        /// </summary>
        [DataMember]
        [ConditionalAny(4, 5, 13)]
        [StringLength(1, 10)]
        [DataElement("362", typeof(X12_N2))]
        [Pos(8)]
        public string TermsDiscountAmount_08 { get; set; }
        /// <summary>
        /// Terms Deferred Due Date
        /// </summary>
        [DataMember]
        [Conditional(10, 11)]
        [StringLength(6, 6)]
        [DataElement("388", typeof(X12_DT))]
        [Pos(9)]
        public string TermsDeferredDueDate_09 { get; set; }
        /// <summary>
        /// Deferred Amount Due
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("389", typeof(X12_N2))]
        [Pos(10)]
        public string DeferredAmountDue_10 { get; set; }
        /// <summary>
        /// Percent of Invoice Payable
        /// </summary>
        [DataMember]
        [StringLength(1, 5)]
        [DataElement("342", typeof(X12_R))]
        [Pos(11)]
        public string PercentofInvoicePayable_11 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(12)]
        public string Description_12 { get; set; }
        /// <summary>
        /// Day of Month
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("765", typeof(X12_N0))]
        [Pos(13)]
        public string DayofMonth_13 { get; set; }
        /// <summary>
        /// Payment Method Code
        /// </summary>
        [DataMember]
        [DataElement("107", typeof(X12_ID_107))]
        [Pos(14)]
        public string PaymentMethodCode_14 { get; set; }
    }

    /// <summary>
    /// Equipment Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("JID")]
    public class JID : I_JID
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(1)]
        public string ProductServiceIDQualifier_01 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(2)]
        public string ProductServiceID_02 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 10)]
        [DataElement("380", typeof(X12_R))]
        [Pos(3)]
        public string Quantity_03 { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(4)]
        public string UnitofMeasurementCode_04 { get; set; }
        /// <summary>
        /// Product/Service Condition Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("286", typeof(X12_ID_286))]
        [Pos(5)]
        public string ProductServiceConditionCode_05 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("782", typeof(X12_R))]
        [Pos(6)]
        public string MonetaryAmount_06 { get; set; }
    }

    /// <summary>
    /// Line Item Detail for the Operating Expense Statement
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("JIL")]
    public class JIL : I_JIL
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(1)]
        public string ProductServiceIDQualifier_01 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(2)]
        public string ProductServiceID_02 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("782", typeof(X12_R))]
        [Pos(3)]
        public string MonetaryAmount_03 { get; set; }
        /// <summary>
        /// Reference Number Qualifier
        /// </summary>
        [DataMember]
        [Paired(5)]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(4)]
        public string ReferenceNumberQualifier_04 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(5)]
        public string ReferenceNumber_05 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(6)]
        public string Date_06 { get; set; }
    }

    /// <summary>
    /// Just-In-Time Schedule
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("JIT")]
    public class JIT : I_JIT
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 10)]
        [DataElement("380", typeof(X12_R))]
        [Pos(1)]
        public string Quantity_01 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(4, 4)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(2)]
        public string Time_02 { get; set; }
    }

    /// <summary>
    /// Line Item - Quantity and Weight
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("L0")]
    public class L0 : I_L0
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Lading Line Item Number
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("213", typeof(X12_N0))]
        [Pos(1)]
        public string LadingLineItemNumber_01 { get; set; }
        /// <summary>
        /// Billed/Rated-as Quantity
        /// </summary>
        [DataMember]
        [Paired(3)]
        [StringLength(1, 11)]
        [DataElement("220", typeof(X12_R))]
        [Pos(2)]
        public string BilledRatedasQuantity_02 { get; set; }
        /// <summary>
        /// Billed/Rated-as Qualifier
        /// </summary>
        [DataMember]
        [DataElement("221", typeof(X12_ID_221))]
        [Pos(3)]
        public string BilledRatedasQualifier_03 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [DataMember]
        [Paired(5, 11)]
        [StringLength(1, 8)]
        [DataElement("81", typeof(X12_R))]
        [Pos(4)]
        public string Weight_04 { get; set; }
        /// <summary>
        /// Weight Qualifier
        /// </summary>
        [DataMember]
        [DataElement("187", typeof(X12_ID_187))]
        [Pos(5)]
        public string WeightQualifier_05 { get; set; }
        /// <summary>
        /// Volume
        /// </summary>
        [DataMember]
        [Paired(7)]
        [StringLength(1, 8)]
        [DataElement("183", typeof(X12_R))]
        [Pos(6)]
        public string Volume_06 { get; set; }
        /// <summary>
        /// Volume Unit Qualifier
        /// </summary>
        [DataMember]
        [DataElement("184", typeof(X12_ID_184))]
        [Pos(7)]
        public string VolumeUnitQualifier_07 { get; set; }
        /// <summary>
        /// Lading Quantity
        /// </summary>
        [DataMember]
        [Paired(9)]
        [StringLength(1, 7)]
        [DataElement("80", typeof(X12_N0))]
        [Pos(8)]
        public string LadingQuantity_08 { get; set; }
        /// <summary>
        /// Lading Quantity Qualifier
        /// </summary>
        [DataMember]
        [StringLength(3, 3)]
        [DataElement("211", typeof(X12_AN))]
        [Pos(9)]
        public string LadingQuantityQualifier_09 { get; set; }
        /// <summary>
        /// Dunnage Description
        /// </summary>
        [DataMember]
        [StringLength(2, 25)]
        [DataElement("458", typeof(X12_AN))]
        [Pos(10)]
        public string DunnageDescription_10 { get; set; }
        /// <summary>
        /// Weight Unit Qualifier
        /// </summary>
        [DataMember]
        [DataElement("188", typeof(X12_ID_188))]
        [Pos(11)]
        public string WeightUnitQualifier_11 { get; set; }
        /// <summary>
        /// Type of Service Code
        /// </summary>
        [DataMember]
        [DataElement("56", typeof(X12_ID_56))]
        [Pos(12)]
        public string TypeofServiceCode_12 { get; set; }
    }

    /// <summary>
    /// Rate and Charges
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("L1")]
    public class L1 : I_L1
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Lading Line Item Number
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("213", typeof(X12_N0))]
        [Pos(1)]
        public string LadingLineItemNumber_01 { get; set; }
        /// <summary>
        /// Freight Rate
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("60", typeof(X12_R))]
        [Pos(2)]
        public string FreightRate_02 { get; set; }
        /// <summary>
        /// Rate/Value Qualifier
        /// </summary>
        [DataMember]
        [DataElement("122", typeof(X12_ID_122))]
        [Pos(3)]
        public string RateValueQualifier_03 { get; set; }
        /// <summary>
        /// Charge
        /// </summary>
        [DataMember]
        [RequiredAny(5, 6)]
        [StringLength(1, 9)]
        [DataElement("58", typeof(X12_N2))]
        [Pos(4)]
        public string Charge_04 { get; set; }
        /// <summary>
        /// Advances
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("191", typeof(X12_N2))]
        [Pos(5)]
        public string Advances_05 { get; set; }
        /// <summary>
        /// Prepaid Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("117", typeof(X12_N2))]
        [Pos(6)]
        public string PrepaidAmount_06 { get; set; }
        /// <summary>
        /// Rate Combination Point Code
        /// </summary>
        [DataMember]
        [DataElement("120", typeof(X12_ID_120))]
        [Pos(7)]
        public string RateCombinationPointCode_07 { get; set; }
        /// <summary>
        /// Special Charge Code
        /// </summary>
        [DataMember]
        [DataElement("150", typeof(X12_ID_150))]
        [Pos(8)]
        public string SpecialChargeCode_08 { get; set; }
        /// <summary>
        /// Rate Class Code
        /// </summary>
        [DataMember]
        [DataElement("121", typeof(X12_ID_121))]
        [Pos(9)]
        public string RateClassCode_09 { get; set; }
        /// <summary>
        /// Entitlement Code
        /// </summary>
        [DataMember]
        [DataElement("39", typeof(X12_ID_39))]
        [Pos(10)]
        public string EntitlementCode_10 { get; set; }
        /// <summary>
        /// Charge Method of Payment
        /// </summary>
        [DataMember]
        [DataElement("16", typeof(X12_ID_16))]
        [Pos(11)]
        public string ChargeMethodofPayment_11 { get; set; }
        /// <summary>
        /// Special Charge Description
        /// </summary>
        [DataMember]
        [StringLength(2, 25)]
        [DataElement("276", typeof(X12_AN))]
        [Pos(12)]
        public string SpecialChargeDescription_12 { get; set; }
        /// <summary>
        /// Tariff Application Code
        /// </summary>
        [DataMember]
        [DataElement("257", typeof(X12_ID_257))]
        [Pos(13)]
        public string TariffApplicationCode_13 { get; set; }
        /// <summary>
        /// Declared Value
        /// </summary>
        [DataMember]
        [Paired(15)]
        [StringLength(2, 10)]
        [DataElement("74", typeof(X12_N2))]
        [Pos(14)]
        public string DeclaredValue_14 { get; set; }
        /// <summary>
        /// Rate/Value Qualifier
        /// </summary>
        [DataMember]
        [DataElement("122", typeof(X12_ID_122))]
        [Pos(15)]
        public string RateValueQualifier_15 { get; set; }
        /// <summary>
        /// Lading Liability Code
        /// </summary>
        [DataMember]
        [DataElement("372", typeof(X12_ID_372))]
        [Pos(16)]
        public string LadingLiabilityCode_16 { get; set; }
    }

    /// <summary>
    /// Total Weight and Charges
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("L3")]
    public class L3 : I_L3
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [DataMember]
        [Paired(2)]
        [StringLength(1, 8)]
        [DataElement("81", typeof(X12_R))]
        [Pos(1)]
        public string Weight_01 { get; set; }
        /// <summary>
        /// Weight Qualifier
        /// </summary>
        [DataMember]
        [DataElement("187", typeof(X12_ID_187))]
        [Pos(2)]
        public string WeightQualifier_02 { get; set; }
        /// <summary>
        /// Freight Rate
        /// </summary>
        [DataMember]
        [Paired(4)]
        [StringLength(1, 9)]
        [DataElement("60", typeof(X12_R))]
        [Pos(3)]
        public string FreightRate_03 { get; set; }
        /// <summary>
        /// Rate/Value Qualifier
        /// </summary>
        [DataMember]
        [DataElement("122", typeof(X12_ID_122))]
        [Pos(4)]
        public string RateValueQualifier_04 { get; set; }
        /// <summary>
        /// Charge
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("58", typeof(X12_N2))]
        [Pos(5)]
        public string Charge_05 { get; set; }
        /// <summary>
        /// Advances
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("191", typeof(X12_N2))]
        [Pos(6)]
        public string Advances_06 { get; set; }
        /// <summary>
        /// Prepaid Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("117", typeof(X12_N2))]
        [Pos(7)]
        public string PrepaidAmount_07 { get; set; }
        /// <summary>
        /// Special Charge Code
        /// </summary>
        [DataMember]
        [DataElement("150", typeof(X12_ID_150))]
        [Pos(8)]
        public string SpecialChargeCode_08 { get; set; }
        /// <summary>
        /// Volume
        /// </summary>
        [DataMember]
        [Paired(10)]
        [StringLength(1, 8)]
        [DataElement("183", typeof(X12_R))]
        [Pos(9)]
        public string Volume_09 { get; set; }
        /// <summary>
        /// Volume Unit Qualifier
        /// </summary>
        [DataMember]
        [DataElement("184", typeof(X12_ID_184))]
        [Pos(10)]
        public string VolumeUnitQualifier_10 { get; set; }
        /// <summary>
        /// Lading Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("80", typeof(X12_N0))]
        [Pos(11)]
        public string LadingQuantity_11 { get; set; }
        /// <summary>
        /// Weight Unit Qualifier
        /// </summary>
        [DataMember]
        [DataElement("188", typeof(X12_ID_188))]
        [Pos(12)]
        public string WeightUnitQualifier_12 { get; set; }
        /// <summary>
        /// Tariff Number
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("171", typeof(X12_AN))]
        [Pos(13)]
        public string TariffNumber_13 { get; set; }
        /// <summary>
        /// Declared Value
        /// </summary>
        [DataMember]
        [Paired(15)]
        [StringLength(2, 10)]
        [DataElement("74", typeof(X12_N2))]
        [Pos(14)]
        public string DeclaredValue_14 { get; set; }
        /// <summary>
        /// Rate/Value Qualifier
        /// </summary>
        [DataMember]
        [DataElement("122", typeof(X12_ID_122))]
        [Pos(15)]
        public string RateValueQualifier_15 { get; set; }
    }

    /// <summary>
    /// Description, Marks and Numbers
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("L5")]
    public class L5 : I_L5
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Lading Line Item Number
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("213", typeof(X12_N0))]
        [Pos(1)]
        public string LadingLineItemNumber_01 { get; set; }
        /// <summary>
        /// Lading Description
        /// </summary>
        [DataMember]
        [StringLength(1, 50)]
        [DataElement("79", typeof(X12_AN))]
        [Pos(2)]
        public string LadingDescription_02 { get; set; }
        /// <summary>
        /// Commodity Code
        /// </summary>
        [DataMember]
        [Paired(4)]
        [StringLength(1, 16)]
        [DataElement("22", typeof(X12_AN))]
        [Pos(3)]
        public string CommodityCode_03 { get; set; }
        /// <summary>
        /// Commodity Code Qualifier
        /// </summary>
        [DataMember]
        [DataElement("23", typeof(X12_ID_23))]
        [Pos(4)]
        public string CommodityCodeQualifier_04 { get; set; }
        /// <summary>
        /// Packaging Code
        /// </summary>
        [DataMember]
        [StringLength(5, 5)]
        [DataElement("103", typeof(X12_AN))]
        [Pos(5)]
        public string PackagingCode_05 { get; set; }
        /// <summary>
        /// Marks and Numbers
        /// </summary>
        [DataMember]
        [StringLength(1, 45)]
        [DataElement("87", typeof(X12_AN))]
        [Pos(6)]
        public string MarksandNumbers_06 { get; set; }
        /// <summary>
        /// Marks and Numbers Qualifier
        /// </summary>
        [DataMember]
        [DataElement("88", typeof(X12_ID_88))]
        [Pos(7)]
        public string MarksandNumbersQualifier_07 { get; set; }
    }

    /// <summary>
    /// Tariff Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("L7")]
    public class L7 : I_L7
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Lading Line Item Number
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("213", typeof(X12_N0))]
        [Pos(1)]
        public string LadingLineItemNumber_01 { get; set; }
        /// <summary>
        /// Tariff Agency Code
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("168", typeof(X12_AN))]
        [Pos(2)]
        public string TariffAgencyCode_02 { get; set; }
        /// <summary>
        /// Tariff Number
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("171", typeof(X12_AN))]
        [Pos(3)]
        public string TariffNumber_03 { get; set; }
        /// <summary>
        /// Tariff Section
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("172", typeof(X12_AN))]
        [Pos(4)]
        public string TariffSection_04 { get; set; }
        /// <summary>
        /// Tariff Item Number
        /// </summary>
        [DataMember]
        [StringLength(1, 16)]
        [DataElement("169", typeof(X12_AN))]
        [Pos(5)]
        public string TariffItemNumber_05 { get; set; }
        /// <summary>
        /// Tariff Item Part
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("170", typeof(X12_N0))]
        [Pos(6)]
        public string TariffItemPart_06 { get; set; }
        /// <summary>
        /// Freight Class Code
        /// </summary>
        [DataMember]
        [StringLength(2, 5)]
        [DataElement("59", typeof(X12_AN))]
        [Pos(7)]
        public string FreightClassCode_07 { get; set; }
        /// <summary>
        /// Tariff Supplement Identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("173", typeof(X12_AN))]
        [Pos(8)]
        public string TariffSupplementIdentifier_08 { get; set; }
        /// <summary>
        /// Ex Parte
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("46", typeof(X12_AN))]
        [Pos(9)]
        public string ExParte_09 { get; set; }
        /// <summary>
        /// Effective Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("37", typeof(X12_DT))]
        [Pos(10)]
        public string EffectiveDate_10 { get; set; }
        /// <summary>
        /// Rate Basis Number
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("119", typeof(X12_AN))]
        [Pos(11)]
        public string RateBasisNumber_11 { get; set; }
        /// <summary>
        /// Tariff Column
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("227", typeof(X12_AN))]
        [Pos(12)]
        public string TariffColumn_12 { get; set; }
        /// <summary>
        /// Tariff Distance
        /// </summary>
        [DataMember]
        [StringLength(1, 5)]
        [DataElement("294", typeof(X12_N0))]
        [Pos(13)]
        public string TariffDistance_13 { get; set; }
        /// <summary>
        /// Distance Qualifier
        /// </summary>
        [DataMember]
        [DataElement("295", typeof(X12_ID_295))]
        [Pos(14)]
        public string DistanceQualifier_14 { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [StringLength(2, 19)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(15)]
        public string CityName_15 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_AN))]
        [Pos(16)]
        public string StateorProvinceCode_16 { get; set; }
    }

    /// <summary>
    /// Line Item Subtotal
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("L8")]
    public class L8 : I_L8
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Billed/Rated-as Quantity
        /// </summary>
        [DataMember]
        [Paired(2)]
        [StringLength(1, 11)]
        [DataElement("220", typeof(X12_R))]
        [Pos(1)]
        public string BilledRatedasQuantity_01 { get; set; }
        /// <summary>
        /// Billed/Rated-as Qualifier
        /// </summary>
        [DataMember]
        [DataElement("221", typeof(X12_ID_221))]
        [Pos(2)]
        public string BilledRatedasQualifier_02 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [DataMember]
        [Paired(4, 5)]
        [StringLength(1, 8)]
        [DataElement("81", typeof(X12_R))]
        [Pos(3)]
        public string Weight_03 { get; set; }
        /// <summary>
        /// Weight Unit Qualifier
        /// </summary>
        [DataMember]
        [DataElement("188", typeof(X12_ID_188))]
        [Pos(4)]
        public string WeightUnitQualifier_04 { get; set; }
        /// <summary>
        /// Weight Qualifier
        /// </summary>
        [DataMember]
        [DataElement("187", typeof(X12_ID_187))]
        [Pos(5)]
        public string WeightQualifier_05 { get; set; }
        /// <summary>
        /// Freight Rate
        /// </summary>
        [DataMember]
        [Paired(7)]
        [StringLength(1, 9)]
        [DataElement("60", typeof(X12_R))]
        [Pos(6)]
        public string FreightRate_06 { get; set; }
        /// <summary>
        /// Rate/Value Qualifier
        /// </summary>
        [DataMember]
        [DataElement("122", typeof(X12_ID_122))]
        [Pos(7)]
        public string RateValueQualifier_07 { get; set; }
        /// <summary>
        /// Charge
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("58", typeof(X12_N2))]
        [Pos(8)]
        public string Charge_08 { get; set; }
        /// <summary>
        /// Special Charge Code
        /// </summary>
        [DataMember]
        [Conditional(8)]
        [DataElement("150", typeof(X12_ID_150))]
        [Pos(9)]
        public string SpecialChargeCode_09 { get; set; }
        /// <summary>
        /// Special Charge Description
        /// </summary>
        [DataMember]
        [StringLength(2, 25)]
        [DataElement("276", typeof(X12_AN))]
        [Pos(10)]
        public string SpecialChargeDescription_10 { get; set; }
        /// <summary>
        /// Charge Method of Payment
        /// </summary>
        [DataMember]
        [DataElement("16", typeof(X12_ID_16))]
        [Pos(11)]
        public string ChargeMethodofPayment_11 { get; set; }
    }

    /// <summary>
    /// Lead Time
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LDT")]
    public class LDT : I_LDT
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Lead Time Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("345", typeof(X12_ID_345))]
        [Pos(1)]
        public string LeadTimeCode_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 10)]
        [DataElement("380", typeof(X12_R))]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        /// <summary>
        /// Unit of Time Period Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("344", typeof(X12_ID_344))]
        [Pos(3)]
        public string UnitofTimePeriodCode_03 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(4)]
        public string Date_04 { get; set; }
    }

    /// <summary>
    /// Loop Trailer
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LE")]
    public class LE : I_LE
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Loop Identifier Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 4)]
        [DataElement("447", typeof(X12_AN))]
        [Pos(1)]
        public string LoopIdentifierCode_01 { get; set; }
    }

    /// <summary>
    /// Mixed Hazardous Commodities
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LH")]
    public class LH : I_LH
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Lading Line Item Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 3)]
        [DataElement("213", typeof(X12_N0))]
        [Pos(1)]
        public string LadingLineItemNumber_01 { get; set; }
        /// <summary>
        /// Hazardous Mnemonic Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("758", typeof(X12_ID_758))]
        [Pos(2)]
        public string HazardousMnemonicCode_02 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(3)]
        public string ReferenceNumber_03 { get; set; }
        /// <summary>
        /// Reference Number Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(4)]
        public string ReferenceNumberQualifier_04 { get; set; }
        /// <summary>
        /// Reportable Quantity Code
        /// </summary>
        [DataMember]
        [DataElement("759", typeof(X12_ID_759))]
        [Pos(5)]
        public string ReportableQuantityCode_05 { get; set; }
        /// <summary>
        /// Limited Quantity Indication Code
        /// </summary>
        [DataMember]
        [DataElement("760", typeof(X12_ID_760))]
        [Pos(6)]
        public string LimitedQuantityIndicationCode_06 { get; set; }
    }

    /// <summary>
    /// Hazardous Identification Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LH1")]
    public class LH1 : I_LH1
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(1)]
        public string UnitofMeasurementCode_01 { get; set; }
        /// <summary>
        /// Lading Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 7)]
        [DataElement("80", typeof(X12_N0))]
        [Pos(2)]
        public string LadingQuantity_02 { get; set; }
        /// <summary>
        /// UN/NA Identification Code
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("277", typeof(X12_AN))]
        [Pos(3)]
        public string UNNAIdentificationCode_03 { get; set; }
        /// <summary>
        /// Hazardous Materials Page
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("200", typeof(X12_AN))]
        [Pos(4)]
        public string HazardousMaterialsPage_04 { get; set; }
        /// <summary>
        /// Commodity Code
        /// </summary>
        [DataMember]
        [StringLength(1, 16)]
        [DataElement("22", typeof(X12_AN))]
        [Pos(5)]
        public string CommodityCode_05 { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(6)]
        public string UnitofMeasurementCode_06 { get; set; }
        /// <summary>
        /// Lading Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("80", typeof(X12_N0))]
        [Pos(7)]
        public string LadingQuantity_07 { get; set; }
        /// <summary>
        /// Compartment ID Code
        /// </summary>
        [DataMember]
        [DataElement("595", typeof(X12_ID_595))]
        [Pos(8)]
        public string CompartmentIDCode_08 { get; set; }
        /// <summary>
        /// Residue Indicator Code
        /// </summary>
        [DataMember]
        [DataElement("665", typeof(X12_ID_665))]
        [Pos(9)]
        public string ResidueIndicatorCode_09 { get; set; }
    }

    /// <summary>
    /// Hazardous Classification Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LH2")]
    public class LH2 : I_LH2
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Hazardous Classification
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 30)]
        [DataElement("215", typeof(X12_AN))]
        [Pos(1)]
        public string HazardousClassification_01 { get; set; }
        /// <summary>
        /// Hazardous Class Qualifier
        /// </summary>
        [DataMember]
        [DataElement("983", typeof(X12_ID_983))]
        [Pos(2)]
        public string HazardousClassQualifier_02 { get; set; }
        /// <summary>
        /// Hazardous Placard Notation
        /// </summary>
        [DataMember]
        [StringLength(16, 40)]
        [DataElement("218", typeof(X12_AN))]
        [Pos(3)]
        public string HazardousPlacardNotation_03 { get; set; }
        /// <summary>
        /// Hazardous Endorsement
        /// </summary>
        [DataMember]
        [StringLength(4, 25)]
        [DataElement("222", typeof(X12_AN))]
        [Pos(4)]
        public string HazardousEndorsement_04 { get; set; }
        /// <summary>
        /// Reportable Quantity Code
        /// </summary>
        [DataMember]
        [DataElement("759", typeof(X12_ID_759))]
        [Pos(5)]
        public string ReportableQuantityCode_05 { get; set; }
    }

    /// <summary>
    /// Hazardous Material Shipping Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LH3")]
    public class LH3 : I_LH3
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Hazardous Material Shipping Name
        /// </summary>
        [DataMember]
        [StringLength(1, 50)]
        [DataElement("224", typeof(X12_AN))]
        [Pos(1)]
        public string HazardousMaterialShippingName_01 { get; set; }
        /// <summary>
        /// Additional Hazardous Information
        /// </summary>
        [DataMember]
        [StringLength(1, 50)]
        [DataElement("228", typeof(X12_AN))]
        [Pos(2)]
        public string AdditionalHazardousInformation_02 { get; set; }
    }

    /// <summary>
    /// Canadian Dangerous Requirements
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LH4")]
    public class LH4 : I_LH4
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Emergency Response Plan Number
        /// </summary>
        [DataMember]
        [StringLength(1, 12)]
        [DataElement("238", typeof(X12_AN))]
        [Pos(1)]
        public string EmergencyResponsePlanNumber_01 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [StringLength(7, 21)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(2)]
        public string CommunicationNumber_02 { get; set; }
        /// <summary>
        /// Packing Group Code
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("254", typeof(X12_AN))]
        [Pos(3)]
        public string PackingGroupCode_03 { get; set; }
        /// <summary>
        /// Subsidiary Classification
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("230", typeof(X12_AN))]
        [Pos(4)]
        public string SubsidiaryClassification_04 { get; set; }
        /// <summary>
        /// Subsidiary Classification
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("230", typeof(X12_AN))]
        [Pos(5)]
        public string SubsidiaryClassification_05 { get; set; }
        /// <summary>
        /// Subsidiary Classification
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("230", typeof(X12_AN))]
        [Pos(6)]
        public string SubsidiaryClassification_06 { get; set; }
        /// <summary>
        /// Subsidiary Risk Indicator
        /// </summary>
        [DataMember]
        [DataElement("271", typeof(X12_ID_271))]
        [Pos(7)]
        public string SubsidiaryRiskIndicator_07 { get; set; }
        /// <summary>
        /// Net Explosive Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("267", typeof(X12_N0))]
        [Pos(8)]
        public string NetExplosiveQuantity_08 { get; set; }
        /// <summary>
        /// Canadian Hazardous Notation
        /// </summary>
        [DataMember]
        [StringLength(1, 25)]
        [DataElement("805", typeof(X12_AN))]
        [Pos(9)]
        public string CanadianHazardousNotation_09 { get; set; }
        /// <summary>
        /// Special Commodity Indicator Code
        /// </summary>
        [DataMember]
        [DataElement("986", typeof(X12_ID_986))]
        [Pos(10)]
        public string SpecialCommodityIndicatorCode_10 { get; set; }
    }

    /// <summary>
    /// Hazardous Material Shipment Contacts
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LH5")]
    public class LH5 : I_LH5
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(7, 21)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(1)]
        public string CommunicationNumber_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(2)]
        public string Name_02 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [StringLength(7, 21)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(3)]
        public string CommunicationNumber_03 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(4)]
        public string Name_04 { get; set; }
    }

    /// <summary>
    /// Hazardous Certification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LH6")]
    public class LH6 : I_LH6
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(1)]
        public string Name_01 { get; set; }
        /// <summary>
        /// Hazardous Certification Code
        /// </summary>
        [DataMember]
        [DataElement("272", typeof(X12_ID_272))]
        [Pos(2)]
        public string HazardousCertificationCode_02 { get; set; }
        /// <summary>
        /// Hazardous Certification Declaration
        /// </summary>
        [DataMember]
        [StringLength(1, 50)]
        [DataElement("273", typeof(X12_AN))]
        [Pos(3)]
        public string HazardousCertificationDeclaration_03 { get; set; }
    }

    /// <summary>
    /// Empty Equipment Hazardous Material Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LHE")]
    public class LHE : I_LHE
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Hazardous Material Shipping Name
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 50)]
        [DataElement("224", typeof(X12_AN))]
        [Pos(1)]
        public string HazardousMaterialShippingName_01 { get; set; }
        /// <summary>
        /// Hazardous Placard Notation
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(16, 40)]
        [DataElement("218", typeof(X12_AN))]
        [Pos(2)]
        public string HazardousPlacardNotation_02 { get; set; }
        /// <summary>
        /// Reference Number Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(3)]
        public string ReferenceNumberQualifier_03 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceNumber_04 { get; set; }
        /// <summary>
        /// Reportable Quantity Code
        /// </summary>
        [DataMember]
        [DataElement("759", typeof(X12_ID_759))]
        [Pos(5)]
        public string ReportableQuantityCode_05 { get; set; }
    }

    /// <summary>
    /// Hazardous Material Identifying Reference Numbers
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LHR")]
    public class LHR : I_LHR
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference Number Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(1)]
        public string ReferenceNumberQualifier_01 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceNumber_02 { get; set; }
    }

    /// <summary>
    /// Item Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LIN")]
    public class LIN : I_LIN
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Assigned Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("350", typeof(X12_AN))]
        [Pos(1)]
        public string AssignedIdentification_01 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(2)]
        public string ProductServiceIDQualifier_02 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(3)]
        public string ProductServiceID_03 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(5)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(4)]
        public string ProductServiceIDQualifier_04 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(5)]
        public string ProductServiceID_05 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(7)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(6)]
        public string ProductServiceIDQualifier_06 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(7)]
        public string ProductServiceID_07 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(9)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(8)]
        public string ProductServiceIDQualifier_08 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(9)]
        public string ProductServiceID_09 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(11)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(10)]
        public string ProductServiceIDQualifier_10 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(11)]
        public string ProductServiceID_11 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(13)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(12)]
        public string ProductServiceIDQualifier_12 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(13)]
        public string ProductServiceID_13 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(15)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(14)]
        public string ProductServiceIDQualifier_14 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(15)]
        public string ProductServiceID_15 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(17)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(16)]
        public string ProductServiceIDQualifier_16 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(17)]
        public string ProductServiceID_17 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(19)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(18)]
        public string ProductServiceIDQualifier_18 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(19)]
        public string ProductServiceID_19 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(21)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(20)]
        public string ProductServiceIDQualifier_20 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(21)]
        public string ProductServiceID_21 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(23)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(22)]
        public string ProductServiceIDQualifier_22 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(23)]
        public string ProductServiceID_23 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(25)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(24)]
        public string ProductServiceIDQualifier_24 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(25)]
        public string ProductServiceID_25 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(27)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(26)]
        public string ProductServiceIDQualifier_26 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(27)]
        public string ProductServiceID_27 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(29)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(28)]
        public string ProductServiceIDQualifier_28 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(29)]
        public string ProductServiceID_29 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(31)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(30)]
        public string ProductServiceIDQualifier_30 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(31)]
        public string ProductServiceID_31 { get; set; }
    }

    /// <summary>
    /// Loop Header
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LS")]
    public class LS : I_LS
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Loop Identifier Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 4)]
        [DataElement("447", typeof(X12_AN))]
        [Pos(1)]
        public string LoopIdentifierCode_01 { get; set; }
    }

    /// <summary>
    /// Assigned Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("LX")]
    public class LX : I_LX
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Assigned Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 6)]
        [DataElement("554", typeof(X12_N0))]
        [Pos(1)]
        public string AssignedNumber_01 { get; set; }
    }

    /// <summary>
    /// Insurance
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("M1")]
    public class M1 : I_M1
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 2)]
        [DataElement("26", typeof(X12_AN))]
        [Pos(1)]
        public string CountryCode_01 { get; set; }
        /// <summary>
        /// Carriage Value
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 8)]
        [DataElement("14", typeof(X12_N0))]
        [Pos(2)]
        public string CarriageValue_02 { get; set; }
        /// <summary>
        /// Declared Value
        /// </summary>
        [DataMember]
        [StringLength(2, 10)]
        [DataElement("74", typeof(X12_N2))]
        [Pos(3)]
        public string DeclaredValue_03 { get; set; }
        /// <summary>
        /// Rate/Value Qualifier
        /// </summary>
        [DataMember]
        [DataElement("122", typeof(X12_ID_122))]
        [Pos(4)]
        public string RateValueQualifier_04 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [DataElement("98", typeof(X12_ID_98))]
        [Pos(5)]
        public string EntityIdentifierCode_05 { get; set; }
        /// <summary>
        /// Free Form Message
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("61", typeof(X12_AN))]
        [Pos(6)]
        public string FreeFormMessage_06 { get; set; }
    }

    /// <summary>
    /// Sales/Delivery Terms
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("M2")]
    public class M2 : I_M2
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Sales Terms Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("139", typeof(X12_ID_139))]
        [Pos(1)]
        public string SalesTermsCode_01 { get; set; }
        /// <summary>
        /// Sales Reference Number
        /// </summary>
        [DataMember]
        [StringLength(4, 6)]
        [DataElement("138", typeof(X12_AN))]
        [Pos(2)]
        public string SalesReferenceNumber_02 { get; set; }
        /// <summary>
        /// Sales Reference Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("137", typeof(X12_DT))]
        [Pos(3)]
        public string SalesReferenceDate_03 { get; set; }
        /// <summary>
        /// Transportation Terms Code
        /// </summary>
        [DataMember]
        [DataElement("335", typeof(X12_ID_335))]
        [Pos(4)]
        public string TransportationTermsCode_04 { get; set; }
        /// <summary>
        /// Sales Comment
        /// </summary>
        [DataMember]
        [StringLength(2, 30)]
        [DataElement("136", typeof(X12_AN))]
        [Pos(5)]
        public string SalesComment_05 { get; set; }
        /// <summary>
        /// Delivery Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("32", typeof(X12_DT))]
        [Pos(6)]
        public string DeliveryDate_06 { get; set; }
    }

    /// <summary>
    /// Release
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("M3")]
    public class M3 : I_M3
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Release Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("132", typeof(X12_ID_132))]
        [Pos(1)]
        public string ReleaseCode_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(2)]
        public string Date_02 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(3)]
        public string Time_03 { get; set; }
    }

    /// <summary>
    /// Seal Numbers
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("M7")]
    public class M7 : I_M7
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Seal Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 15)]
        [DataElement("225", typeof(X12_AN))]
        [Pos(1)]
        public string SealNumber_01 { get; set; }
        /// <summary>
        /// Seal Number
        /// </summary>
        [DataMember]
        [StringLength(2, 15)]
        [DataElement("225", typeof(X12_AN))]
        [Pos(2)]
        public string SealNumber_02 { get; set; }
        /// <summary>
        /// Seal Number
        /// </summary>
        [DataMember]
        [StringLength(2, 15)]
        [DataElement("225", typeof(X12_AN))]
        [Pos(3)]
        public string SealNumber_03 { get; set; }
        /// <summary>
        /// Seal Number
        /// </summary>
        [DataMember]
        [StringLength(2, 15)]
        [DataElement("225", typeof(X12_AN))]
        [Pos(4)]
        public string SealNumber_04 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [DataElement("98", typeof(X12_ID_98))]
        [Pos(5)]
        public string EntityIdentifierCode_05 { get; set; }
    }

    /// <summary>
    /// Marks and Numbers
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MAN")]
    public class MAN : I_MAN
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Marks and Numbers Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("88", typeof(X12_ID_88))]
        [Pos(1)]
        public string MarksandNumbersQualifier_01 { get; set; }
        /// <summary>
        /// Marks and Numbers
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 45)]
        [DataElement("87", typeof(X12_AN))]
        [Pos(2)]
        public string MarksandNumbers_02 { get; set; }
    }

    /// <summary>
    /// Measurements
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MEA")]
    public class MEA : I_MEA
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Measurement Reference ID Code
        /// </summary>
        [DataMember]
        [DataElement("737", typeof(X12_ID_737))]
        [Pos(1)]
        public string MeasurementReferenceIDCode_01 { get; set; }
        /// <summary>
        /// Measurement Qualifier
        /// </summary>
        [DataMember]
        [DataElement("738", typeof(X12_ID_738))]
        [Pos(2)]
        public string MeasurementQualifier_02 { get; set; }
        /// <summary>
        /// Measurement Value
        /// </summary>
        [DataMember]
        [RequiredAny(5, 6, 8)]
        [Conditional(4)]
        [StringLength(1, 10)]
        [DataElement("739", typeof(X12_R))]
        [Pos(3)]
        public string MeasurementValue_03 { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(4)]
        public string UnitofMeasurementCode_04 { get; set; }
        /// <summary>
        /// Range Minimum
        /// </summary>
        [DataMember]
        [Conditional(4)]
        [StringLength(1, 10)]
        [DataElement("740", typeof(X12_R))]
        [Pos(5)]
        public string RangeMinimum_05 { get; set; }
        /// <summary>
        /// Range Maximum
        /// </summary>
        [DataMember]
        [Conditional(4)]
        [StringLength(1, 10)]
        [DataElement("741", typeof(X12_R))]
        [Pos(6)]
        public string RangeMaximum_06 { get; set; }
        /// <summary>
        /// Measurement Significance Code
        /// </summary>
        [DataMember]
        [Conditional(3)]
        [DataElement("935", typeof(X12_ID_935))]
        [Pos(7)]
        public string MeasurementSignificanceCode_07 { get; set; }
        /// <summary>
        /// Measurement Attribute Code
        /// </summary>
        [DataMember]
        [Exclusion(3)]
        [DataElement("936", typeof(X12_ID_936))]
        [Pos(8)]
        public string MeasurementAttributeCode_08 { get; set; }
        /// <summary>
        /// Surface/Layer/Position Code
        /// </summary>
        [DataMember]
        [DataElement("752", typeof(X12_ID_752))]
        [Pos(9)]
        public string SurfaceLayerPositionCode_09 { get; set; }
    }

    /// <summary>
    /// Message Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MIT")]
    public class MIT : I_MIT
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(1)]
        public string ReferenceNumber_01 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(2)]
        public string Description_02 { get; set; }
        /// <summary>
        /// Page Width
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("931", typeof(X12_N0))]
        [Pos(3)]
        public string PageWidth_03 { get; set; }
        /// <summary>
        /// Page Length Lines
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("932", typeof(X12_N0))]
        [Pos(4)]
        public string PageLengthLines_04 { get; set; }
    }

    /// <summary>
    /// Message Text
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("MSG")]
    public class MSG : I_MSG
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Free-Form Message Text
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 264)]
        [DataElement("933", typeof(X12_AN))]
        [Pos(1)]
        public string FreeFormMessageText_01 { get; set; }
        /// <summary>
        /// Printer Carriage Control Code
        /// </summary>
        [DataMember]
        [DataElement("934", typeof(X12_ID_934))]
        [Pos(2)]
        public string PrinterCarriageControlCode_02 { get; set; }
    }

    /// <summary>
    /// Name
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("N1")]
    public class N1 : I_N1
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("98", typeof(X12_ID_98))]
        [Pos(1)]
        public string EntityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [RequiredAny(3)]
        [StringLength(1, 35)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(2)]
        public string Name_02 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Paired(4)]
        [DataElement("66", typeof(X12_ID_66))]
        [Pos(3)]
        public string IdentificationCodeQualifier_03 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [StringLength(2, 17)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(4)]
        public string IdentificationCode_04 { get; set; }
    }

    /// <summary>
    /// Additional Name Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("N2")]
    public class N2 : I_N2
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(1)]
        public string Name_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(2)]
        public string Name_02 { get; set; }
    }

    /// <summary>
    /// Address Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("N3")]
    public class N3 : I_N3
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(1)]
        public string AddressInformation_01 { get; set; }
        /// <summary>
        /// Address Information
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("166", typeof(X12_AN))]
        [Pos(2)]
        public string AddressInformation_02 { get; set; }
    }

    /// <summary>
    /// Geographic Location
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("N4")]
    public class N4 : I_N4
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [RequiredAny(5)]
        [Conditional(2)]
        [StringLength(2, 19)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(1)]
        public string CityName_01 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_AN))]
        [Pos(2)]
        public string StateorProvinceCode_02 { get; set; }
        /// <summary>
        /// Postal Code
        /// </summary>
        [DataMember]
        [StringLength(4, 9)]
        [DataElement("116", typeof(X12_AN))]
        [Pos(3)]
        public string PostalCode_03 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("26", typeof(X12_AN))]
        [Pos(4)]
        public string CountryCode_04 { get; set; }
        /// <summary>
        /// Location Qualifier
        /// </summary>
        [DataMember]
        [Paired(6)]
        [DataElement("309", typeof(X12_ID_309))]
        [Pos(5)]
        public string LocationQualifier_05 { get; set; }
        /// <summary>
        /// Location Identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 25)]
        [DataElement("310", typeof(X12_AN))]
        [Pos(6)]
        public string LocationIdentifier_06 { get; set; }
    }

    /// <summary>
    /// Equipment Ordered
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("N5")]
    public class N5 : I_N5
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Equipment Length
        /// </summary>
        [DataMember]
        [StringLength(4, 5)]
        [DataElement("567", typeof(X12_N0))]
        [Pos(1)]
        public string EquipmentLength_01 { get; set; }
        /// <summary>
        /// Weight Capacity
        /// </summary>
        [DataMember]
        [StringLength(2, 3)]
        [DataElement("233", typeof(X12_N0))]
        [Pos(2)]
        public string WeightCapacity_02 { get; set; }
        /// <summary>
        /// Cubic Capacity
        /// </summary>
        [DataMember]
        [StringLength(2, 4)]
        [DataElement("203", typeof(X12_N0))]
        [Pos(3)]
        public string CubicCapacity_03 { get; set; }
        /// <summary>
        /// Car Type Code
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("301", typeof(X12_AN))]
        [Pos(4)]
        public string CarTypeCode_04 { get; set; }
        /// <summary>
        /// Metric Qualifier
        /// </summary>
        [DataMember]
        [DataElement("216", typeof(X12_ID_216))]
        [Pos(5)]
        public string MetricQualifier_05 { get; set; }
        /// <summary>
        /// Height
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("65", typeof(X12_R))]
        [Pos(6)]
        public string Height_06 { get; set; }
        /// <summary>
        /// Lading Percentage
        /// </summary>
        [DataMember]
        [Paired(8)]
        [StringLength(2, 4)]
        [DataElement("643", typeof(X12_N2))]
        [Pos(7)]
        public string LadingPercentage_07 { get; set; }
        /// <summary>
        /// Lading Percent Qualifier
        /// </summary>
        [DataMember]
        [DataElement("644", typeof(X12_ID_644))]
        [Pos(8)]
        public string LadingPercentQualifier_08 { get; set; }
        /// <summary>
        /// Equipment Description Code
        /// </summary>
        [DataMember]
        [DataElement("40", typeof(X12_ID_40))]
        [Pos(9)]
        public string EquipmentDescriptionCode_09 { get; set; }
    }

    /// <summary>
    /// Equipment Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("N7")]
    public class N7 : I_N7
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Equipment Initial
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("206", typeof(X12_AN))]
        [Pos(1)]
        public string EquipmentInitial_01 { get; set; }
        /// <summary>
        /// Equipment Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 10)]
        [DataElement("207", typeof(X12_AN))]
        [Pos(2)]
        public string EquipmentNumber_02 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [DataMember]
        [Conditional(4)]
        [StringLength(1, 8)]
        [DataElement("81", typeof(X12_R))]
        [Pos(3)]
        public string Weight_03 { get; set; }
        /// <summary>
        /// Weight Qualifier
        /// </summary>
        [DataMember]
        [DataElement("187", typeof(X12_ID_187))]
        [Pos(4)]
        public string WeightQualifier_04 { get; set; }
        /// <summary>
        /// Tare Weight
        /// </summary>
        [DataMember]
        [Paired(16)]
        [StringLength(3, 8)]
        [DataElement("167", typeof(X12_N0))]
        [Pos(5)]
        public string TareWeight_05 { get; set; }
        /// <summary>
        /// Weight Allowance
        /// </summary>
        [DataMember]
        [StringLength(2, 6)]
        [DataElement("232", typeof(X12_N0))]
        [Pos(6)]
        public string WeightAllowance_06 { get; set; }
        /// <summary>
        /// Dunnage
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("205", typeof(X12_N0))]
        [Pos(7)]
        public string Dunnage_07 { get; set; }
        /// <summary>
        /// Volume
        /// </summary>
        [DataMember]
        [Paired(9)]
        [StringLength(1, 8)]
        [DataElement("183", typeof(X12_R))]
        [Pos(8)]
        public string Volume_08 { get; set; }
        /// <summary>
        /// Volume Unit Qualifier
        /// </summary>
        [DataMember]
        [DataElement("184", typeof(X12_ID_184))]
        [Pos(9)]
        public string VolumeUnitQualifier_09 { get; set; }
        /// <summary>
        /// Ownership Code
        /// </summary>
        [DataMember]
        [DataElement("102", typeof(X12_ID_102))]
        [Pos(10)]
        public string OwnershipCode_10 { get; set; }
        /// <summary>
        /// Equipment Description Code
        /// </summary>
        [DataMember]
        [DataElement("40", typeof(X12_ID_40))]
        [Pos(11)]
        public string EquipmentDescriptionCode_11 { get; set; }
        /// <summary>
        /// Equipment Owner Code
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("307", typeof(X12_AN))]
        [Pos(12)]
        public string EquipmentOwnerCode_12 { get; set; }
        /// <summary>
        /// Temperature Control
        /// </summary>
        [DataMember]
        [StringLength(3, 6)]
        [DataElement("319", typeof(X12_AN))]
        [Pos(13)]
        public string TemperatureControl_13 { get; set; }
        /// <summary>
        /// Position
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("219", typeof(X12_AN))]
        [Pos(14)]
        public string Position_14 { get; set; }
        /// <summary>
        /// Equipment Length
        /// </summary>
        [DataMember]
        [StringLength(4, 5)]
        [DataElement("567", typeof(X12_N0))]
        [Pos(15)]
        public string EquipmentLength_15 { get; set; }
        /// <summary>
        /// Tare Qualifier Code
        /// </summary>
        [DataMember]
        [DataElement("571", typeof(X12_ID_571))]
        [Pos(16)]
        public string TareQualifierCode_16 { get; set; }
        /// <summary>
        /// Weight Unit Qualifier
        /// </summary>
        [DataMember]
        [DataElement("188", typeof(X12_ID_188))]
        [Pos(17)]
        public string WeightUnitQualifier_17 { get; set; }
        /// <summary>
        /// Equipment Number Check Digit
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("761", typeof(X12_N0))]
        [Pos(18)]
        public string EquipmentNumberCheckDigit_18 { get; set; }
        /// <summary>
        /// Type of Service Code
        /// </summary>
        [DataMember]
        [DataElement("56", typeof(X12_ID_56))]
        [Pos(19)]
        public string TypeofServiceCode_19 { get; set; }
        /// <summary>
        /// Height
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("65", typeof(X12_R))]
        [Pos(20)]
        public string Height_20 { get; set; }
        /// <summary>
        /// Width
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("189", typeof(X12_R))]
        [Pos(21)]
        public string Width_21 { get; set; }
        /// <summary>
        /// Equipment Type
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("24", typeof(X12_AN))]
        [Pos(22)]
        public string EquipmentType_22 { get; set; }
    }

    /// <summary>
    /// Waybill Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("N8")]
    public class N8 : I_N8
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Waybill Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 6)]
        [DataElement("186", typeof(X12_N0))]
        [Pos(1)]
        public string WaybillNumber_01 { get; set; }
        /// <summary>
        /// Waybill Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(6, 6)]
        [DataElement("185", typeof(X12_DT))]
        [Pos(2)]
        public string WaybillDate_02 { get; set; }
        /// <summary>
        /// Cross Reference Type Code
        /// </summary>
        [DataMember]
        [Paired(4, 5)]
        [DataElement("231", typeof(X12_ID_231))]
        [Pos(3)]
        public string CrossReferenceTypeCode_03 { get; set; }
        /// <summary>
        /// Equipment Initial
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("206", typeof(X12_AN))]
        [Pos(4)]
        public string EquipmentInitial_04 { get; set; }
        /// <summary>
        /// Equipment Number
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("207", typeof(X12_AN))]
        [Pos(5)]
        public string EquipmentNumber_05 { get; set; }
        /// <summary>
        /// Waybill Number
        /// </summary>
        [DataMember]
        [Paired(7)]
        [StringLength(1, 6)]
        [DataElement("186", typeof(X12_N0))]
        [Pos(6)]
        public string WaybillNumber_06 { get; set; }
        /// <summary>
        /// Waybill Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("185", typeof(X12_DT))]
        [Pos(7)]
        public string WaybillDate_07 { get; set; }
        /// <summary>
        /// Destination Station
        /// </summary>
        [DataMember]
        [Paired(9)]
        [StringLength(2, 19)]
        [DataElement("300", typeof(X12_AN))]
        [Pos(8)]
        public string DestinationStation_08 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_AN))]
        [Pos(9)]
        public string StateorProvinceCode_09 { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [StringLength(2, 4)]
        [DataElement("140", typeof(X12_AN))]
        [Pos(10)]
        public string StandardCarrierAlphaCode_10 { get; set; }
        /// <summary>
        /// Freight Station Accounting Code
        /// </summary>
        [DataMember]
        [StringLength(1, 5)]
        [DataElement("573", typeof(X12_AN))]
        [Pos(11)]
        public string FreightStationAccountingCode_11 { get; set; }
    }

    /// <summary>
    /// Reference Number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("N9")]
    public class N9 : I_N9
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference Number Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(1)]
        public string ReferenceNumberQualifier_01 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [RequiredAny(3)]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceNumber_02 { get; set; }
        /// <summary>
        /// Free-form Description
        /// </summary>
        [DataMember]
        [StringLength(1, 45)]
        [DataElement("369", typeof(X12_AN))]
        [Pos(3)]
        public string FreeformDescription_03 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(4)]
        public string Date_04 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(5)]
        public string Time_05 { get; set; }
    }

    /// <summary>
    /// Cross-Reference Equipment
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NA")]
    public class NA : I_NA
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference Number Qualifier
        /// </summary>
        [DataMember]
        [Conditional(2)]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(1)]
        public string ReferenceNumberQualifier_01 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceNumber_02 { get; set; }
        /// <summary>
        /// Equipment Initial
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 4)]
        [DataElement("206", typeof(X12_AN))]
        [Pos(3)]
        public string EquipmentInitial_03 { get; set; }
        /// <summary>
        /// Equipment Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 10)]
        [DataElement("207", typeof(X12_AN))]
        [Pos(4)]
        public string EquipmentNumber_04 { get; set; }
        /// <summary>
        /// Cross Reference Type Code
        /// </summary>
        [DataMember]
        [DataElement("231", typeof(X12_ID_231))]
        [Pos(5)]
        public string CrossReferenceTypeCode_05 { get; set; }
        /// <summary>
        /// Position
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("219", typeof(X12_AN))]
        [Pos(6)]
        public string Position_06 { get; set; }
        /// <summary>
        /// Equipment Owner Code
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("307", typeof(X12_AN))]
        [Pos(7)]
        public string EquipmentOwnerCode_07 { get; set; }
        /// <summary>
        /// Equipment Length
        /// </summary>
        [DataMember]
        [StringLength(4, 5)]
        [DataElement("567", typeof(X12_N0))]
        [Pos(8)]
        public string EquipmentLength_08 { get; set; }
    }

    /// <summary>
    /// Nonconformance Action
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NCA")]
    public class NCA : I_NCA
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Assigned Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("350", typeof(X12_AN))]
        [Pos(1)]
        public string AssignedIdentification_01 { get; set; }
        /// <summary>
        /// Nonconformance Resultant Response Code
        /// </summary>
        [DataMember]
        [RequiredAny(3)]
        [DataElement("887", typeof(X12_ID_887))]
        [Pos(2)]
        public string NonconformanceResultantResponseCode_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Paired(5)]
        [StringLength(1, 10)]
        [DataElement("380", typeof(X12_R))]
        [Pos(4)]
        public string Quantity_04 { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(5)]
        public string UnitofMeasurementCode_05 { get; set; }
    }

    /// <summary>
    /// Nonconformance Description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NCD")]
    public class NCD : I_NCD
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Measurement Attribute Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("936", typeof(X12_ID_936))]
        [Pos(1)]
        public string MeasurementAttributeCode_01 { get; set; }
        /// <summary>
        /// Nonconformance Determination Code
        /// </summary>
        [DataMember]
        [DataElement("888", typeof(X12_ID_888))]
        [Pos(2)]
        public string NonconformanceDeterminationCode_02 { get; set; }
        /// <summary>
        /// Assigned Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("350", typeof(X12_AN))]
        [Pos(3)]
        public string AssignedIdentification_03 { get; set; }
        /// <summary>
        /// Product/Process Characteristic Code
        /// </summary>
        [DataMember]
        [DataElement("750", typeof(X12_ID_750))]
        [Pos(4)]
        public string ProductProcessCharacteristicCode_04 { get; set; }
        /// <summary>
        /// Association Qualifier Code
        /// </summary>
        [DataMember]
        [DataElement("559", typeof(X12_ID_559))]
        [Pos(5)]
        public string AssociationQualifierCode_05 { get; set; }
        /// <summary>
        /// Product Description Code
        /// </summary>
        [DataMember]
        [StringLength(1, 12)]
        [DataElement("751", typeof(X12_AN))]
        [Pos(6)]
        public string ProductDescriptionCode_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(7)]
        public string Description_07 { get; set; }
    }

    /// <summary>
    /// Note/Special Instruction
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("NTE")]
    public class NTE : I_NTE
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Note Reference Code
        /// </summary>
        [DataMember]
        [DataElement("363", typeof(X12_ID_363))]
        [Pos(1)]
        public string NoteReferenceCode_01 { get; set; }
        /// <summary>
        /// Free Form Message
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 60)]
        [DataElement("3", typeof(X12_AN))]
        [Pos(2)]
        public string FreeFormMessage_02 { get; set; }
    }

    /// <summary>
    /// Original Transaction Identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("OTI")]
    public class OTI : I_OTI
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Application Acknowledgment Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("110", typeof(X12_ID_110))]
        [Pos(1)]
        public string ApplicationAcknowledgmentCode_01 { get; set; }
        /// <summary>
        /// Reference Number Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(2)]
        public string ReferenceNumberQualifier_02 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(3)]
        public string ReferenceNumber_03 { get; set; }
        /// <summary>
        /// Application Sender's Code
        /// </summary>
        [DataMember]
        [StringLength(2, 12)]
        [DataElement("142", typeof(X12_AN))]
        [Pos(4)]
        public string ApplicationSendersCode_04 { get; set; }
        /// <summary>
        /// Application Receiver's Code
        /// </summary>
        [DataMember]
        [StringLength(2, 12)]
        [DataElement("124", typeof(X12_AN))]
        [Pos(5)]
        public string ApplicationReceiversCode_05 { get; set; }
        /// <summary>
        /// Group Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("29", typeof(X12_DT))]
        [Pos(6)]
        public string GroupDate_06 { get; set; }
        /// <summary>
        /// Group Time
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("30", typeof(X12_TM))]
        [Pos(7)]
        public string GroupTime_07 { get; set; }
        /// <summary>
        /// Group Control Number
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("28", typeof(X12_N0))]
        [Pos(8)]
        public string GroupControlNumber_08 { get; set; }
        /// <summary>
        /// Transaction Set Control Number
        /// </summary>
        [DataMember]
        [Conditional(8)]
        [StringLength(4, 9)]
        [DataElement("329", typeof(X12_AN))]
        [Pos(9)]
        public string TransactionSetControlNumber_09 { get; set; }
        /// <summary>
        /// Transaction Set Identifier Code
        /// </summary>
        [DataMember]
        [DataElement("143", typeof(X12_ID_143))]
        [Pos(10)]
        public string TransactionSetIdentifierCode_10 { get; set; }
        /// <summary>
        /// Version / Release / Industry Identifier Code
        /// </summary>
        [DataMember]
        [DataElement("480", typeof(X12_ID_480))]
        [Pos(11)]
        public string VersionReleaseIndustryIdentifierCode_11 { get; set; }
    }

    /// <summary>
    /// Pick-up
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("P1")]
    public class P1 : I_P1
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Pick-up or Delivery Code
        /// </summary>
        [DataMember]
        [DataElement("108", typeof(X12_ID_108))]
        [Pos(1)]
        public string PickuporDeliveryCode_01 { get; set; }
        /// <summary>
        /// Pick-up Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(6, 6)]
        [DataElement("109", typeof(X12_DT))]
        [Pos(2)]
        public string PickupDate_02 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("374", typeof(X12_ID_374))]
        [Pos(3)]
        public string DateTimeQualifier_03 { get; set; }
        /// <summary>
        /// Pick-up Time
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("111", typeof(X12_TM))]
        [Pos(4)]
        public string PickupTime_04 { get; set; }
        /// <summary>
        /// Equipment Initial
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("206", typeof(X12_AN))]
        [Pos(5)]
        public string EquipmentInitial_05 { get; set; }
        /// <summary>
        /// Equipment Number
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("207", typeof(X12_AN))]
        [Pos(6)]
        public string EquipmentNumber_06 { get; set; }
        /// <summary>
        /// Number of Shipments
        /// </summary>
        [DataMember]
        [StringLength(1, 5)]
        [DataElement("21", typeof(X12_N0))]
        [Pos(7)]
        public string NumberofShipments_07 { get; set; }
    }

    /// <summary>
    /// Delivery
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("P2")]
    public class P2 : I_P2
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Pick-up or Delivery Code
        /// </summary>
        [DataMember]
        [DataElement("108", typeof(X12_ID_108))]
        [Pos(1)]
        public string PickuporDeliveryCode_01 { get; set; }
        /// <summary>
        /// Delivery Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(6, 6)]
        [DataElement("32", typeof(X12_DT))]
        [Pos(2)]
        public string DeliveryDate_02 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("374", typeof(X12_ID_374))]
        [Pos(3)]
        public string DateTimeQualifier_03 { get; set; }
    }

    /// <summary>
    /// Product Adjustment Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PAD")]
    public class PAD : I_PAD
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Assigned Identification
        /// </summary>
        [DataMember]
        [RequiredAny(2)]
        [StringLength(1, 6)]
        [DataElement("350", typeof(X12_AN))]
        [Pos(1)]
        public string AssignedIdentification_01 { get; set; }
        /// <summary>
        /// Product Transfer Type Code
        /// </summary>
        [DataMember]
        [DataElement("521", typeof(X12_ID_521))]
        [Pos(2)]
        public string ProductTransferTypeCode_02 { get; set; }
        /// <summary>
        /// Change or Response Type Code
        /// </summary>
        [DataMember]
        [DataElement("670", typeof(X12_ID_670))]
        [Pos(3)]
        public string ChangeorResponseTypeCode_03 { get; set; }
        /// <summary>
        /// Price Multiplier Qualifier
        /// </summary>
        [DataMember]
        [DataElement("648", typeof(X12_ID_648))]
        [Pos(4)]
        public string PriceMultiplierQualifier_04 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(5)]
        public string Multiplier_05 { get; set; }
    }

    /// <summary>
    /// Payment Cancellation Request
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PCR")]
    public class PCR : I_PCR
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Payment Cancellation Type
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("959", typeof(X12_ID_959))]
        [Pos(1)]
        public string PaymentCancellationType_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 15)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string MonetaryAmount_02 { get; set; }
    }

    /// <summary>
    /// Administrative Communications Contact
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PER")]
    public class PER : I_PER
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Contact Function Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("366", typeof(X12_ID_366))]
        [Pos(1)]
        public string ContactFunctionCode_01 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(2)]
        public string Name_02 { get; set; }
        /// <summary>
        /// Communication Number Qualifier
        /// </summary>
        [DataMember]
        [Conditional(4)]
        [DataElement("365", typeof(X12_ID_365))]
        [Pos(3)]
        public string CommunicationNumberQualifier_03 { get; set; }
        /// <summary>
        /// Communication Number
        /// </summary>
        [DataMember]
        [StringLength(7, 21)]
        [DataElement("364", typeof(X12_AN))]
        [Pos(4)]
        public string CommunicationNumber_04 { get; set; }
    }

    /// <summary>
    /// Product/Item Description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PID")]
    public class PID : I_PID
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Item Description Type
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("349", typeof(X12_ID_349))]
        [Pos(1)]
        public string ItemDescriptionType_01 { get; set; }
        /// <summary>
        /// Product/Process Characteristic Code
        /// </summary>
        [DataMember]
        [DataElement("750", typeof(X12_ID_750))]
        [Pos(2)]
        public string ProductProcessCharacteristicCode_02 { get; set; }
        /// <summary>
        /// Association Qualifier Code
        /// </summary>
        [DataMember]
        [DataElement("559", typeof(X12_ID_559))]
        [Pos(3)]
        public string AssociationQualifierCode_03 { get; set; }
        /// <summary>
        /// Product Description Code
        /// </summary>
        [DataMember]
        [Conditional(3)]
        [RequiredAny(5)]
        [StringLength(1, 12)]
        [DataElement("751", typeof(X12_AN))]
        [Pos(4)]
        public string ProductDescriptionCode_04 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(5)]
        public string Description_05 { get; set; }
        /// <summary>
        /// Surface/Layer/Position Code
        /// </summary>
        [DataMember]
        [DataElement("752", typeof(X12_ID_752))]
        [Pos(6)]
        public string SurfaceLayerPositionCode_06 { get; set; }
    }

    /// <summary>
    /// Marking, Packaging, Loading
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PKG")]
    public class PKG : I_PKG
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Item Description Type
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("349", typeof(X12_ID_349))]
        [Pos(1)]
        public string ItemDescriptionType_01 { get; set; }
        /// <summary>
        /// Packaging Characteristic Code
        /// </summary>
        [DataMember]
        [DataElement("753", typeof(X12_ID_753))]
        [Pos(2)]
        public string PackagingCharacteristicCode_02 { get; set; }
        /// <summary>
        /// Association Qualifier Code
        /// </summary>
        [DataMember]
        [DataElement("559", typeof(X12_ID_559))]
        [Pos(3)]
        public string AssociationQualifierCode_03 { get; set; }
        /// <summary>
        /// Packaging Description Code
        /// </summary>
        [DataMember]
        [Conditional(3)]
        [RequiredAny(5)]
        [StringLength(1, 7)]
        [DataElement("754", typeof(X12_AN))]
        [Pos(4)]
        public string PackagingDescriptionCode_04 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(5)]
        public string Description_05 { get; set; }
    }

    /// <summary>
    /// Purchase Order Baseline Item Data
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PO1")]
    public class PO1 : I_PO1
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Assigned Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("350", typeof(X12_AN))]
        [Pos(1)]
        public string AssignedIdentification_01 { get; set; }
        /// <summary>
        /// Quantity Ordered
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 9)]
        [DataElement("330", typeof(X12_R))]
        [Pos(2)]
        public string QuantityOrdered_02 { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(3)]
        public string UnitofMeasurementCode_03 { get; set; }
        /// <summary>
        /// Unit Price
        /// </summary>
        [DataMember]
        [StringLength(1, 14)]
        [DataElement("212", typeof(X12_R))]
        [Pos(4)]
        public string UnitPrice_04 { get; set; }
        /// <summary>
        /// Basis of Unit Price Code
        /// </summary>
        [DataMember]
        [Conditional(4)]
        [DataElement("639", typeof(X12_ID_639))]
        [Pos(5)]
        public string BasisofUnitPriceCode_05 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(7)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(6)]
        public string ProductServiceIDQualifier_06 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(7)]
        public string ProductServiceID_07 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(9)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(8)]
        public string ProductServiceIDQualifier_08 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(9)]
        public string ProductServiceID_09 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(11)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(10)]
        public string ProductServiceIDQualifier_10 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(11)]
        public string ProductServiceID_11 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(13)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(12)]
        public string ProductServiceIDQualifier_12 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(13)]
        public string ProductServiceID_13 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(15)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(14)]
        public string ProductServiceIDQualifier_14 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(15)]
        public string ProductServiceID_15 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(17)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(16)]
        public string ProductServiceIDQualifier_16 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(17)]
        public string ProductServiceID_17 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(19)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(18)]
        public string ProductServiceIDQualifier_18 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(19)]
        public string ProductServiceID_19 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(21)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(20)]
        public string ProductServiceIDQualifier_20 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(21)]
        public string ProductServiceID_21 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(23)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(22)]
        public string ProductServiceIDQualifier_22 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(23)]
        public string ProductServiceID_23 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(25)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(24)]
        public string ProductServiceIDQualifier_24 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(25)]
        public string ProductServiceID_25 { get; set; }
    }

    /// <summary>
    /// Additional Item Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PO3")]
    public class PO3 : I_PO3
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Change Reason Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("371", typeof(X12_ID_371))]
        [Pos(1)]
        public string ChangeReasonCode_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(2)]
        public string Date_02 { get; set; }
        /// <summary>
        /// Price Qualifier
        /// </summary>
        [DataMember]
        [DataElement("236", typeof(X12_ID_236))]
        [Pos(3)]
        public string PriceQualifier_03 { get; set; }
        /// <summary>
        /// Unit Price
        /// </summary>
        [DataMember]
        [ConditionalAny(3, 5)]
        [StringLength(1, 14)]
        [DataElement("212", typeof(X12_R))]
        [Pos(4)]
        public string UnitPrice_04 { get; set; }
        /// <summary>
        /// Basis of Unit Price Code
        /// </summary>
        [DataMember]
        [DataElement("639", typeof(X12_ID_639))]
        [Pos(5)]
        public string BasisofUnitPriceCode_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 10)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(7)]
        public string UnitofMeasurementCode_07 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(8)]
        public string Description_08 { get; set; }
    }

    /// <summary>
    /// Item Physical Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PO4")]
    public class PO4 : I_PO4
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Pack
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("356", typeof(X12_N0))]
        [Pos(1)]
        public string Pack_01 { get; set; }
        /// <summary>
        /// Size
        /// </summary>
        [DataMember]
        [Conditional(3)]
        [StringLength(1, 8)]
        [DataElement("357", typeof(X12_R))]
        [Pos(2)]
        public string Size_02 { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(3)]
        public string UnitofMeasurementCode_03 { get; set; }
        /// <summary>
        /// Packaging Code
        /// </summary>
        [DataMember]
        [StringLength(5, 5)]
        [DataElement("103", typeof(X12_AN))]
        [Pos(4)]
        public string PackagingCode_04 { get; set; }
        /// <summary>
        /// Weight Qualifier
        /// </summary>
        [DataMember]
        [ConditionalAny(6, 7)]
        [DataElement("187", typeof(X12_ID_187))]
        [Pos(5)]
        public string WeightQualifier_05 { get; set; }
        /// <summary>
        /// Gross Weight per Pack
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("384", typeof(X12_R))]
        [Pos(6)]
        public string GrossWeightperPack_06 { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(7)]
        public string UnitofMeasurementCode_07 { get; set; }
        /// <summary>
        /// Gross Volume per Pack
        /// </summary>
        [DataMember]
        [Conditional(9)]
        [StringLength(1, 9)]
        [DataElement("385", typeof(X12_R))]
        [Pos(8)]
        public string GrossVolumeperPack_08 { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(9)]
        public string UnitofMeasurementCode_09 { get; set; }
        /// <summary>
        /// Length
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("82", typeof(X12_R))]
        [Pos(10)]
        public string Length_10 { get; set; }
        /// <summary>
        /// Width
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("189", typeof(X12_R))]
        [Pos(11)]
        public string Width_11 { get; set; }
        /// <summary>
        /// Height
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("65", typeof(X12_R))]
        [Pos(12)]
        public string Height_12 { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [ConditionalAny(10, 11, 12)]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(13)]
        public string UnitofMeasurementCode_13 { get; set; }
    }

    /// <summary>
    /// Line Item Change
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("POC")]
    public class POC : I_POC
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Assigned Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("350", typeof(X12_AN))]
        [Pos(1)]
        public string AssignedIdentification_01 { get; set; }
        /// <summary>
        /// Change or Response Type Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("670", typeof(X12_ID_670))]
        [Pos(2)]
        public string ChangeorResponseTypeCode_02 { get; set; }
        /// <summary>
        /// Quantity Ordered
        /// </summary>
        [DataMember]
        [Conditional(4, 5)]
        [StringLength(1, 9)]
        [DataElement("330", typeof(X12_R))]
        [Pos(3)]
        public string QuantityOrdered_03 { get; set; }
        /// <summary>
        /// Quantity Left to Receive
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("671", typeof(X12_R))]
        [Pos(4)]
        public string QuantityLefttoReceive_04 { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(5)]
        public string UnitofMeasurementCode_05 { get; set; }
        /// <summary>
        /// Unit Price
        /// </summary>
        [DataMember]
        [StringLength(1, 14)]
        [DataElement("212", typeof(X12_R))]
        [Pos(6)]
        public string UnitPrice_06 { get; set; }
        /// <summary>
        /// Basis of Unit Price Code
        /// </summary>
        [DataMember]
        [Conditional(6)]
        [DataElement("639", typeof(X12_ID_639))]
        [Pos(7)]
        public string BasisofUnitPriceCode_07 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(9)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(8)]
        public string ProductServiceIDQualifier_08 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(9)]
        public string ProductServiceID_09 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(11)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(10)]
        public string ProductServiceIDQualifier_10 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(11)]
        public string ProductServiceID_11 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(13)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(12)]
        public string ProductServiceIDQualifier_12 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(13)]
        public string ProductServiceID_13 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(15)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(14)]
        public string ProductServiceIDQualifier_14 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(15)]
        public string ProductServiceID_15 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(17)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(16)]
        public string ProductServiceIDQualifier_16 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(17)]
        public string ProductServiceID_17 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(19)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(18)]
        public string ProductServiceIDQualifier_18 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(19)]
        public string ProductServiceID_19 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(21)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(20)]
        public string ProductServiceIDQualifier_20 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(21)]
        public string ProductServiceID_21 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(23)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(22)]
        public string ProductServiceIDQualifier_22 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(23)]
        public string ProductServiceID_23 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(25)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(24)]
        public string ProductServiceIDQualifier_24 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(25)]
        public string ProductServiceID_25 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(27)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(26)]
        public string ProductServiceIDQualifier_26 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(27)]
        public string ProductServiceID_27 { get; set; }
    }

    /// <summary>
    /// Proof of Delivery
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("POD")]
    public class POD : I_POD
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(1)]
        public string Date_01 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(2)]
        public string Time_02 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 35)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(3)]
        public string Name_03 { get; set; }
    }

    /// <summary>
    /// Purchase Order Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PRF")]
    public class PRF : I_PRF
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Purchase Order Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 22)]
        [DataElement("324", typeof(X12_AN))]
        [Pos(1)]
        public string PurchaseOrderNumber_01 { get; set; }
        /// <summary>
        /// Release Number
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("328", typeof(X12_AN))]
        [Pos(2)]
        public string ReleaseNumber_02 { get; set; }
        /// <summary>
        /// Change Order Sequence Number
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("327", typeof(X12_AN))]
        [Pos(3)]
        public string ChangeOrderSequenceNumber_03 { get; set; }
        /// <summary>
        /// Purchase Order Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("323", typeof(X12_DT))]
        [Pos(4)]
        public string PurchaseOrderDate_04 { get; set; }
        /// <summary>
        /// Assigned Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("350", typeof(X12_AN))]
        [Pos(5)]
        public string AssignedIdentification_05 { get; set; }
        /// <summary>
        /// Contract Number
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("367", typeof(X12_AN))]
        [Pos(6)]
        public string ContractNumber_06 { get; set; }
    }

    /// <summary>
    /// Part Release Status
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PRS")]
    public class PRS : I_PRS
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Part Release Status Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("682", typeof(X12_ID_682))]
        [Pos(1)]
        public string PartReleaseStatusCode_01 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(2)]
        public string Description_02 { get; set; }
    }

    /// <summary>
    /// Protective Service Instructions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PS")]
    public class PS : I_PS
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Protective Service Rule Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(3, 9)]
        [DataElement("746", typeof(X12_AN))]
        [Pos(1)]
        public string ProtectiveServiceRuleCode_01 { get; set; }
        /// <summary>
        /// Protective Service Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("241", typeof(X12_ID_241))]
        [Pos(2)]
        public string ProtectiveServiceCode_02 { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(3)]
        public string UnitofMeasurementCode_03 { get; set; }
        /// <summary>
        /// Temperature
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("408", typeof(X12_N0))]
        [Pos(4)]
        public string Temperature_04 { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [StringLength(2, 4)]
        [DataElement("140", typeof(X12_AN))]
        [Pos(5)]
        public string StandardCarrierAlphaCode_05 { get; set; }
        /// <summary>
        /// Freight Station Accounting Code
        /// </summary>
        [DataMember]
        [StringLength(1, 5)]
        [DataElement("573", typeof(X12_AN))]
        [Pos(6)]
        public string FreightStationAccountingCode_06 { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [StringLength(2, 19)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(7)]
        public string CityName_07 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_AN))]
        [Pos(8)]
        public string StateorProvinceCode_08 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("81", typeof(X12_R))]
        [Pos(9)]
        public string Weight_09 { get; set; }
        /// <summary>
        /// Pre-Cooled (Rule 710) Code
        /// </summary>
        [DataMember]
        [DataElement("745", typeof(X12_ID_745))]
        [Pos(10)]
        public string PreCooledRuleCode_10 { get; set; }
    }

    /// <summary>
    /// Partner Share Accounting
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PSA")]
    public class PSA : I_PSA
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("66", typeof(X12_ID_66))]
        [Pos(1)]
        public string IdentificationCodeQualifier_01 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 17)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(2)]
        public string IdentificationCode_02 { get; set; }
        /// <summary>
        /// Owners Share
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 8)]
        [DataElement("826", typeof(X12_R))]
        [Pos(3)]
        public string OwnersShare_03 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 15)]
        [DataElement("782", typeof(X12_R))]
        [Pos(4)]
        public string MonetaryAmount_04 { get; set; }
    }

    /// <summary>
    /// Physical Sample Description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PSD")]
    public class PSD : I_PSD
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Sample Process Status Code
        /// </summary>
        [DataMember]
        [DataElement("939", typeof(X12_ID_939))]
        [Pos(1)]
        public string SampleProcessStatusCode_01 { get; set; }
        /// <summary>
        /// Sample Selection Method Code
        /// </summary>
        [DataMember]
        [DataElement("940", typeof(X12_ID_940))]
        [Pos(2)]
        public string SampleSelectionMethodCode_02 { get; set; }
        /// <summary>
        /// Sample Frequency Value per Unit of Measurement Code
        /// </summary>
        [DataMember]
        [Paired(4)]
        [StringLength(1, 9)]
        [DataElement("942", typeof(X12_N0))]
        [Pos(3)]
        public string SampleFrequencyValueperUnitofMeasurementCode_03 { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(4)]
        public string UnitofMeasurementCode_04 { get; set; }
        /// <summary>
        /// Sample Description Code
        /// </summary>
        [DataMember]
        [DataElement("943", typeof(X12_ID_943))]
        [Pos(5)]
        public string SampleDescriptionCode_05 { get; set; }
        /// <summary>
        /// Sample Direction Code
        /// </summary>
        [DataMember]
        [DataElement("944", typeof(X12_ID_944))]
        [Pos(6)]
        public string SampleDirectionCode_06 { get; set; }
        /// <summary>
        /// Sample Location Code
        /// </summary>
        [DataMember]
        [DataElement("945", typeof(X12_ID_945))]
        [Pos(7)]
        public string SampleLocationCode_07 { get; set; }
    }

    /// <summary>
    /// Product Transfer and Resale Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PTD")]
    public class PTD : I_PTD
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Product Transfer Type Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("521", typeof(X12_ID_521))]
        [Pos(1)]
        public string ProductTransferTypeCode_01 { get; set; }
        /// <summary>
        /// Price Multiplier Qualifier
        /// </summary>
        [DataMember]
        [Paired(3)]
        [DataElement("648", typeof(X12_ID_648))]
        [Pos(2)]
        public string PriceMultiplierQualifier_02 { get; set; }
        /// <summary>
        /// Multiplier
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("649", typeof(X12_R))]
        [Pos(3)]
        public string Multiplier_03 { get; set; }
        /// <summary>
        /// Reference Number Qualifier
        /// </summary>
        [DataMember]
        [Paired(5)]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(4)]
        public string ReferenceNumberQualifier_04 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(5)]
        public string ReferenceNumber_05 { get; set; }
        /// <summary>
        /// Product Transfer Movement Type Code
        /// </summary>
        [DataMember]
        [DataElement("486", typeof(X12_ID_486))]
        [Pos(6)]
        public string ProductTransferMovementTypeCode_06 { get; set; }
    }

    /// <summary>
    /// Paperwork
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("PWK")]
    public class PWK : I_PWK
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Report Type Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("755", typeof(X12_ID_755))]
        [Pos(1)]
        public string ReportTypeCode_01 { get; set; }
        /// <summary>
        /// Report Transmission Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("756", typeof(X12_ID_756))]
        [Pos(2)]
        public string ReportTransmissionCode_02 { get; set; }
        /// <summary>
        /// Report Copies Needed
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("757", typeof(X12_N0))]
        [Pos(3)]
        public string ReportCopiesNeeded_03 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [DataElement("98", typeof(X12_ID_98))]
        [Pos(4)]
        public string EntityIdentifierCode_04 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Paired(6)]
        [DataElement("66", typeof(X12_ID_66))]
        [Pos(5)]
        public string IdentificationCodeQualifier_05 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [StringLength(2, 17)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(6)]
        public string IdentificationCode_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(7)]
        public string Description_07 { get; set; }
        /// <summary>
        /// Paperwork/Report Action Code
        /// </summary>
        [DataMember]
        [DataElement("704", typeof(X12_ID_704))]
        [Pos(8)]
        public string PaperworkReportActionCode_08 { get; set; }
    }

    /// <summary>
    /// Quantity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("QTY")]
    public class QTY : I_QTY
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("673", typeof(X12_ID_673))]
        [Pos(1)]
        public string QuantityQualifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 10)]
        [DataElement("380", typeof(X12_R))]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(3)]
        public string UnitofMeasurementCode_03 { get; set; }
    }

    /// <summary>
    /// Route Information (Air)
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("R1")]
    public class R1 : I_R1
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [StringLength(2, 4)]
        [DataElement("140", typeof(X12_AN))]
        [Pos(1)]
        public string StandardCarrierAlphaCode_01 { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [StringLength(2, 4)]
        [DataElement("140", typeof(X12_AN))]
        [Pos(2)]
        public string StandardCarrierAlphaCode_02 { get; set; }
        /// <summary>
        /// Airport Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(3, 5)]
        [DataElement("5", typeof(X12_AN))]
        [Pos(3)]
        public string AirportCode_03 { get; set; }
        /// <summary>
        /// Air Carrier Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(3, 3)]
        [DataElement("4", typeof(X12_AN))]
        [Pos(4)]
        public string AirCarrierCode_04 { get; set; }
        /// <summary>
        /// Airport Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(3, 5)]
        [DataElement("5", typeof(X12_AN))]
        [Pos(5)]
        public string AirportCode_05 { get; set; }
        /// <summary>
        /// Air Carrier Code
        /// </summary>
        [DataMember]
        [Paired(7)]
        [StringLength(3, 3)]
        [DataElement("4", typeof(X12_AN))]
        [Pos(6)]
        public string AirCarrierCode_06 { get; set; }
        /// <summary>
        /// Airport Code
        /// </summary>
        [DataMember]
        [StringLength(3, 5)]
        [DataElement("5", typeof(X12_AN))]
        [Pos(7)]
        public string AirportCode_07 { get; set; }
        /// <summary>
        /// Air Carrier Code
        /// </summary>
        [DataMember]
        [Paired(9)]
        [StringLength(3, 3)]
        [DataElement("4", typeof(X12_AN))]
        [Pos(8)]
        public string AirCarrierCode_08 { get; set; }
        /// <summary>
        /// Airport Code
        /// </summary>
        [DataMember]
        [StringLength(3, 5)]
        [DataElement("5", typeof(X12_AN))]
        [Pos(9)]
        public string AirportCode_09 { get; set; }
        /// <summary>
        /// Air Carrier Code
        /// </summary>
        [DataMember]
        [Paired(11)]
        [StringLength(3, 3)]
        [DataElement("4", typeof(X12_AN))]
        [Pos(10)]
        public string AirCarrierCode_10 { get; set; }
        /// <summary>
        /// Airport Code
        /// </summary>
        [DataMember]
        [StringLength(3, 5)]
        [DataElement("5", typeof(X12_AN))]
        [Pos(11)]
        public string AirportCode_11 { get; set; }
        /// <summary>
        /// Air Carrier Code
        /// </summary>
        [DataMember]
        [Paired(13)]
        [StringLength(3, 3)]
        [DataElement("4", typeof(X12_AN))]
        [Pos(12)]
        public string AirCarrierCode_12 { get; set; }
        /// <summary>
        /// Airport Code
        /// </summary>
        [DataMember]
        [StringLength(3, 5)]
        [DataElement("5", typeof(X12_AN))]
        [Pos(13)]
        public string AirportCode_13 { get; set; }
    }

    /// <summary>
    /// Route Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("R2")]
    public class R2 : I_R2
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 4)]
        [DataElement("140", typeof(X12_AN))]
        [Pos(1)]
        public string StandardCarrierAlphaCode_01 { get; set; }
        /// <summary>
        /// Routing Sequence Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("133", typeof(X12_ID_133))]
        [Pos(2)]
        public string RoutingSequenceCode_02 { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [StringLength(2, 19)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(3)]
        public string CityName_03 { get; set; }
        /// <summary>
        /// Standard Point Location Code
        /// </summary>
        [DataMember]
        [StringLength(6, 9)]
        [DataElement("154", typeof(X12_AN))]
        [Pos(4)]
        public string StandardPointLocationCode_04 { get; set; }
        /// <summary>
        /// TOFC/Intermodal Code Qualifier
        /// </summary>
        [DataMember]
        [DataElement("177", typeof(X12_ID_177))]
        [Pos(5)]
        public string TOFCIntermodalCodeQualifier_05 { get; set; }
        /// <summary>
        /// Transportation Method/Type Code
        /// </summary>
        [DataMember]
        [DataElement("91", typeof(X12_ID_91))]
        [Pos(6)]
        public string TransportationMethodTypeCode_06 { get; set; }
        /// <summary>
        /// Intermediate Switch Carrier
        /// </summary>
        [DataMember]
        [StringLength(2, 4)]
        [DataElement("296", typeof(X12_AN))]
        [Pos(7)]
        public string IntermediateSwitchCarrier_07 { get; set; }
        /// <summary>
        /// Intermediate Switch Carrier
        /// </summary>
        [DataMember]
        [StringLength(2, 4)]
        [DataElement("296", typeof(X12_AN))]
        [Pos(8)]
        public string IntermediateSwitchCarrier_08 { get; set; }
        /// <summary>
        /// Invoice Number
        /// </summary>
        [DataMember]
        [StringLength(1, 22)]
        [DataElement("76", typeof(X12_AN))]
        [Pos(9)]
        public string InvoiceNumber_09 { get; set; }
        /// <summary>
        /// Billing Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("12", typeof(X12_DT))]
        [Pos(10)]
        public string BillingDate_10 { get; set; }
        /// <summary>
        /// Free-form Description
        /// </summary>
        [DataMember]
        [StringLength(1, 45)]
        [DataElement("369", typeof(X12_AN))]
        [Pos(11)]
        public string FreeformDescription_11 { get; set; }
        /// <summary>
        /// Type of Service Code
        /// </summary>
        [DataMember]
        [DataElement("56", typeof(X12_ID_56))]
        [Pos(12)]
        public string TypeofServiceCode_12 { get; set; }
        /// <summary>
        /// Route Description
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("742", typeof(X12_AN))]
        [Pos(13)]
        public string RouteDescription_13 { get; set; }
    }

    /// <summary>
    /// Route Information - Motor
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("R3")]
    public class R3 : I_R3
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 4)]
        [DataElement("140", typeof(X12_AN))]
        [Pos(1)]
        public string StandardCarrierAlphaCode_01 { get; set; }
        /// <summary>
        /// Routing Sequence Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("133", typeof(X12_ID_133))]
        [Pos(2)]
        public string RoutingSequenceCode_02 { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [StringLength(2, 19)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(3)]
        public string CityName_03 { get; set; }
        /// <summary>
        /// Transportation Method/Type Code
        /// </summary>
        [DataMember]
        [DataElement("91", typeof(X12_ID_91))]
        [Pos(4)]
        public string TransportationMethodTypeCode_04 { get; set; }
        /// <summary>
        /// Standard Point Location Code
        /// </summary>
        [DataMember]
        [StringLength(6, 9)]
        [DataElement("154", typeof(X12_AN))]
        [Pos(5)]
        public string StandardPointLocationCode_05 { get; set; }
        /// <summary>
        /// Invoice Number
        /// </summary>
        [DataMember]
        [StringLength(1, 22)]
        [DataElement("76", typeof(X12_AN))]
        [Pos(6)]
        public string InvoiceNumber_06 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(7)]
        public string Date_07 { get; set; }
        /// <summary>
        /// Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("610", typeof(X12_N2))]
        [Pos(8)]
        public string Amount_08 { get; set; }
        /// <summary>
        /// Free-form Description
        /// </summary>
        [DataMember]
        [StringLength(1, 45)]
        [DataElement("369", typeof(X12_AN))]
        [Pos(9)]
        public string FreeformDescription_09 { get; set; }
    }

    /// <summary>
    /// Port
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("R4")]
    public class R4 : I_R4
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Port Function Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("115", typeof(X12_ID_115))]
        [Pos(1)]
        public string PortFunctionCode_01 { get; set; }
        /// <summary>
        /// Location Qualifier
        /// </summary>
        [DataMember]
        [DataElement("309", typeof(X12_ID_309))]
        [Pos(2)]
        public string LocationQualifier_02 { get; set; }
        /// <summary>
        /// Location Identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 25)]
        [DataElement("310", typeof(X12_AN))]
        [Pos(3)]
        public string LocationIdentifier_03 { get; set; }
        /// <summary>
        /// Port Name
        /// </summary>
        [DataMember]
        [StringLength(2, 24)]
        [DataElement("114", typeof(X12_AN))]
        [Pos(4)]
        public string PortName_04 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("26", typeof(X12_AN))]
        [Pos(5)]
        public string CountryCode_05 { get; set; }
        /// <summary>
        /// Terminal Name
        /// </summary>
        [DataMember]
        [StringLength(2, 30)]
        [DataElement("174", typeof(X12_AN))]
        [Pos(6)]
        public string TerminalName_06 { get; set; }
        /// <summary>
        /// Pier Number
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("113", typeof(X12_AN))]
        [Pos(7)]
        public string PierNumber_07 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_AN))]
        [Pos(8)]
        public string StateorProvinceCode_08 { get; set; }
    }

    /// <summary>
    /// Route Code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("R9")]
    public class R9 : I_R9
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Route Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 13)]
        [DataElement("1", typeof(X12_AN))]
        [Pos(1)]
        public string RouteCode_01 { get; set; }
        /// <summary>
        /// Agent/Shipper Routing Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("192", typeof(X12_ID_192))]
        [Pos(2)]
        public string AgentShipperRoutingCode_02 { get; set; }
        /// <summary>
        /// TOFC/Intermodal Code Qualifier
        /// </summary>
        [DataMember]
        [DataElement("177", typeof(X12_ID_177))]
        [Pos(3)]
        public string TOFCIntermodalCodeQualifier_03 { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [StringLength(2, 4)]
        [DataElement("140", typeof(X12_AN))]
        [Pos(4)]
        public string StandardCarrierAlphaCode_04 { get; set; }
    }

    /// <summary>
    /// Receiving Conditions
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RCD")]
    public class RCD : I_RCD
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Assigned Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("350", typeof(X12_AN))]
        [Pos(1)]
        public string AssignedIdentification_01 { get; set; }
        /// <summary>
        /// Quantity Units Received
        /// </summary>
        [DataMember]
        [RequiredAny(4, 6)]
        [Conditional(3)]
        [StringLength(1, 9)]
        [DataElement("663", typeof(X12_R))]
        [Pos(2)]
        public string QuantityUnitsReceived_02 { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(3)]
        public string UnitofMeasurementCode_03 { get; set; }
        /// <summary>
        /// Quantity Units Returned
        /// </summary>
        [DataMember]
        [Conditional(5)]
        [StringLength(1, 9)]
        [DataElement("664", typeof(X12_R))]
        [Pos(4)]
        public string QuantityUnitsReturned_04 { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(5)]
        public string UnitofMeasurementCode_05 { get; set; }
        /// <summary>
        /// Quantity in Question
        /// </summary>
        [DataMember]
        [Conditional(7, 8)]
        [StringLength(1, 9)]
        [DataElement("667", typeof(X12_R))]
        [Pos(6)]
        public string QuantityinQuestion_06 { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(7)]
        public string UnitofMeasurementCode_07 { get; set; }
        /// <summary>
        /// Receiving Condition Code
        /// </summary>
        [DataMember]
        [DataElement("412", typeof(X12_ID_412))]
        [Pos(8)]
        public string ReceivingConditionCode_08 { get; set; }
        /// <summary>
        /// Quantity in Question
        /// </summary>
        [DataMember]
        [Conditional(10, 11)]
        [StringLength(1, 9)]
        [DataElement("667", typeof(X12_R))]
        [Pos(9)]
        public string QuantityinQuestion_09 { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(10)]
        public string UnitofMeasurementCode_10 { get; set; }
        /// <summary>
        /// Receiving Condition Code
        /// </summary>
        [DataMember]
        [DataElement("412", typeof(X12_ID_412))]
        [Pos(11)]
        public string ReceivingConditionCode_11 { get; set; }
        /// <summary>
        /// Quantity in Question
        /// </summary>
        [DataMember]
        [Conditional(13, 14)]
        [StringLength(1, 9)]
        [DataElement("667", typeof(X12_R))]
        [Pos(12)]
        public string QuantityinQuestion_12 { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(13)]
        public string UnitofMeasurementCode_13 { get; set; }
        /// <summary>
        /// Receiving Condition Code
        /// </summary>
        [DataMember]
        [DataElement("412", typeof(X12_ID_412))]
        [Pos(14)]
        public string ReceivingConditionCode_14 { get; set; }
        /// <summary>
        /// Quantity in Question
        /// </summary>
        [DataMember]
        [Conditional(16, 17)]
        [StringLength(1, 9)]
        [DataElement("667", typeof(X12_R))]
        [Pos(15)]
        public string QuantityinQuestion_15 { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(16)]
        public string UnitofMeasurementCode_16 { get; set; }
        /// <summary>
        /// Receiving Condition Code
        /// </summary>
        [DataMember]
        [DataElement("412", typeof(X12_ID_412))]
        [Pos(17)]
        public string ReceivingConditionCode_17 { get; set; }
        /// <summary>
        /// Quantity in Question
        /// </summary>
        [DataMember]
        [Conditional(19, 20)]
        [StringLength(1, 9)]
        [DataElement("667", typeof(X12_R))]
        [Pos(18)]
        public string QuantityinQuestion_18 { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(19)]
        public string UnitofMeasurementCode_19 { get; set; }
        /// <summary>
        /// Receiving Condition Code
        /// </summary>
        [DataMember]
        [DataElement("412", typeof(X12_ID_412))]
        [Pos(20)]
        public string ReceivingConditionCode_20 { get; set; }
    }

    /// <summary>
    /// Revision Date/Time
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RDT")]
    public class RDT : I_RDT
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Revision Level Code
        /// </summary>
        [DataMember]
        [Conditional(2)]
        [DataElement("795", typeof(X12_ID_795))]
        [Pos(1)]
        public string RevisionLevelCode_01 { get; set; }
        /// <summary>
        /// Revision Value
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("796", typeof(X12_AN))]
        [Pos(2)]
        public string RevisionValue_02 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [ConditionalAny(4, 5)]
        [DataElement("374", typeof(X12_ID_374))]
        [Pos(3)]
        public string DateTimeQualifier_03 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(4)]
        public string Date_04 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(5)]
        public string Time_05 { get; set; }
        /// <summary>
        /// Time Code
        /// </summary>
        [DataMember]
        [Conditional(5)]
        [DataElement("623", typeof(X12_ID_623))]
        [Pos(6)]
        public string TimeCode_06 { get; set; }
    }

    /// <summary>
    /// Reference Numbers
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("REF")]
    public class REF : I_REF
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference Number Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(1)]
        public string ReferenceNumberQualifier_01 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [RequiredAny(3)]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceNumber_02 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(3)]
        public string Description_03 { get; set; }
    }

    /// <summary>
    /// Financial Return
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RIC")]
    public class RIC : I_RIC
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Application Error Condition Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("647", typeof(X12_ID_647))]
        [Pos(1)]
        public string ApplicationErrorConditionCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 15)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string MonetaryAmount_02 { get; set; }
        /// <summary>
        /// Credit/Debit Flag Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("478", typeof(X12_ID_478))]
        [Pos(3)]
        public string CreditDebitFlagCode_03 { get; set; }
        /// <summary>
        /// Account Number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("508", typeof(X12_AN))]
        [Pos(4)]
        public string AccountNumber_04 { get; set; }
    }

    /// <summary>
    /// Remittance Advice
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RMT")]
    public class RMT : I_RMT
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference Number Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(1)]
        public string ReferenceNumberQualifier_01 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceNumber_02 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("782", typeof(X12_R))]
        [Pos(3)]
        public string MonetaryAmount_03 { get; set; }
        /// <summary>
        /// Total Invoice Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("777", typeof(X12_R))]
        [Pos(4)]
        public string TotalInvoiceAmount_04 { get; set; }
        /// <summary>
        /// Amount Subject to Terms Discount
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("778", typeof(X12_R))]
        [Pos(5)]
        public string AmountSubjecttoTermsDiscount_05 { get; set; }
        /// <summary>
        /// Discounted Amount Due
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("779", typeof(X12_R))]
        [Pos(6)]
        public string DiscountedAmountDue_06 { get; set; }
        /// <summary>
        /// Discount Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("780", typeof(X12_R))]
        [Pos(7)]
        public string DiscountAmount_07 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("782", typeof(X12_R))]
        [Pos(8)]
        public string MonetaryAmount_08 { get; set; }
        /// <summary>
        /// Adjustment Reason Code
        /// </summary>
        [DataMember]
        [DataElement("426", typeof(X12_ID_426))]
        [Pos(9)]
        public string AdjustmentReasonCode_09 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(10)]
        public string Description_10 { get; set; }
    }

    /// <summary>
    /// Required Response
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RRA")]
    public class RRA : I_RRA
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Information Type
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("701", typeof(X12_ID_701))]
        [Pos(1)]
        public string InformationType_01 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceNumber_02 { get; set; }
    }

    /// <summary>
    /// Rate Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("RTE")]
    public class RTE : I_RTE
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Interest Rate
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 6)]
        [DataElement("953", typeof(X12_R))]
        [Pos(1)]
        public string InterestRate_01 { get; set; }
        /// <summary>
        /// Interest Rate
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("953", typeof(X12_R))]
        [Pos(2)]
        public string InterestRate_02 { get; set; }
        /// <summary>
        /// Interest Rate
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("953", typeof(X12_R))]
        [Pos(3)]
        public string InterestRate_03 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("782", typeof(X12_R))]
        [Pos(4)]
        public string MonetaryAmount_04 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("782", typeof(X12_R))]
        [Pos(5)]
        public string MonetaryAmount_05 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(6)]
        public string Date_06 { get; set; }
    }

    /// <summary>
    /// Stop Off Details
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("S5")]
    public class S5 : I_S5
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Stop Sequence Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 2)]
        [DataElement("165", typeof(X12_N0))]
        [Pos(1)]
        public string StopSequenceNumber_01 { get; set; }
        /// <summary>
        /// Stop Reason Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("163", typeof(X12_ID_163))]
        [Pos(2)]
        public string StopReasonCode_02 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [DataMember]
        [Paired(4)]
        [StringLength(1, 8)]
        [DataElement("81", typeof(X12_R))]
        [Pos(3)]
        public string Weight_03 { get; set; }
        /// <summary>
        /// Weight Unit Qualifier
        /// </summary>
        [DataMember]
        [DataElement("188", typeof(X12_ID_188))]
        [Pos(4)]
        public string WeightUnitQualifier_04 { get; set; }
        /// <summary>
        /// Number of Units Shipped
        /// </summary>
        [DataMember]
        [Paired(6)]
        [StringLength(1, 10)]
        [DataElement("382", typeof(X12_R))]
        [Pos(5)]
        public string NumberofUnitsShipped_05 { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(6)]
        public string UnitofMeasurementCode_06 { get; set; }
        /// <summary>
        /// Volume
        /// </summary>
        [DataMember]
        [Paired(8)]
        [StringLength(1, 8)]
        [DataElement("183", typeof(X12_R))]
        [Pos(7)]
        public string Volume_07 { get; set; }
        /// <summary>
        /// Volume Unit Qualifier
        /// </summary>
        [DataMember]
        [DataElement("184", typeof(X12_ID_184))]
        [Pos(8)]
        public string VolumeUnitQualifier_08 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(9)]
        public string Description_09 { get; set; }
        /// <summary>
        /// Standard Point Location Code
        /// </summary>
        [DataMember]
        [StringLength(6, 9)]
        [DataElement("154", typeof(X12_AN))]
        [Pos(10)]
        public string StandardPointLocationCode_10 { get; set; }
        /// <summary>
        /// Accomplish Code
        /// </summary>
        [DataMember]
        [DataElement("190", typeof(X12_ID_190))]
        [Pos(11)]
        public string AccomplishCode_11 { get; set; }
    }

    /// <summary>
    /// Line Item Schedule
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SCH")]
    public class SCH : I_SCH
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 10)]
        [DataElement("380", typeof(X12_R))]
        [Pos(1)]
        public string Quantity_01 { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(2)]
        public string UnitofMeasurementCode_02 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Conditional(4)]
        [DataElement("98", typeof(X12_ID_98))]
        [Pos(3)]
        public string EntityIdentifierCode_03 { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("93", typeof(X12_AN))]
        [Pos(4)]
        public string Name_04 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("374", typeof(X12_ID_374))]
        [Pos(5)]
        public string DateTimeQualifier_05 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(6)]
        public string Date_06 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(7)]
        public string Time_07 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [DataElement("374", typeof(X12_ID_374))]
        [Pos(8)]
        public string DateTimeQualifier_08 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Conditional(8)]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(9)]
        public string Date_09 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(10)]
        public string Time_10 { get; set; }
    }

    /// <summary>
    /// Ship/Delivery Pattern
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SDP")]
    public class SDP : I_SDP
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Ship/Delivery Pattern Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("678", typeof(X12_ID_678))]
        [Pos(1)]
        public string ShipDeliveryPatternCode_01 { get; set; }
        /// <summary>
        /// Ship/Delivery Pattern Time Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("679", typeof(X12_ID_679))]
        [Pos(2)]
        public string ShipDeliveryPatternTimeCode_02 { get; set; }
        /// <summary>
        /// Ship/Delivery Pattern Code
        /// </summary>
        [DataMember]
        [DataElement("678", typeof(X12_ID_678))]
        [Pos(3)]
        public string ShipDeliveryPatternCode_03 { get; set; }
        /// <summary>
        /// Ship/Delivery Pattern Time Code
        /// </summary>
        [DataMember]
        [DataElement("679", typeof(X12_ID_679))]
        [Pos(4)]
        public string ShipDeliveryPatternTimeCode_04 { get; set; }
        /// <summary>
        /// Ship/Delivery Pattern Code
        /// </summary>
        [DataMember]
        [DataElement("678", typeof(X12_ID_678))]
        [Pos(5)]
        public string ShipDeliveryPatternCode_05 { get; set; }
        /// <summary>
        /// Ship/Delivery Pattern Time Code
        /// </summary>
        [DataMember]
        [DataElement("679", typeof(X12_ID_679))]
        [Pos(6)]
        public string ShipDeliveryPatternTimeCode_06 { get; set; }
        /// <summary>
        /// Ship/Delivery Pattern Code
        /// </summary>
        [DataMember]
        [DataElement("678", typeof(X12_ID_678))]
        [Pos(7)]
        public string ShipDeliveryPatternCode_07 { get; set; }
        /// <summary>
        /// Ship/Delivery Pattern Time Code
        /// </summary>
        [DataMember]
        [DataElement("679", typeof(X12_ID_679))]
        [Pos(8)]
        public string ShipDeliveryPatternTimeCode_08 { get; set; }
    }

    /// <summary>
    /// Destination Quantity
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SDQ")]
    public class SDQ : I_SDQ
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(1)]
        public string UnitofMeasurementCode_01 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [DataElement("66", typeof(X12_ID_66))]
        [Pos(2)]
        public string IdentificationCodeQualifier_02 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 17)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(3)]
        public string IdentificationCode_03 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 10)]
        [DataElement("380", typeof(X12_R))]
        [Pos(4)]
        public string Quantity_04 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Conditional(6)]
        [StringLength(2, 17)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(5)]
        public string IdentificationCode_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Conditional(8)]
        [StringLength(2, 17)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(7)]
        public string IdentificationCode_07 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("380", typeof(X12_R))]
        [Pos(8)]
        public string Quantity_08 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Conditional(10)]
        [StringLength(2, 17)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(9)]
        public string IdentificationCode_09 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("380", typeof(X12_R))]
        [Pos(10)]
        public string Quantity_10 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Conditional(12)]
        [StringLength(2, 17)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(11)]
        public string IdentificationCode_11 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("380", typeof(X12_R))]
        [Pos(12)]
        public string Quantity_12 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Conditional(14)]
        [StringLength(2, 17)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(13)]
        public string IdentificationCode_13 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("380", typeof(X12_R))]
        [Pos(14)]
        public string Quantity_14 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Conditional(16)]
        [StringLength(2, 17)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(15)]
        public string IdentificationCode_15 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("380", typeof(X12_R))]
        [Pos(16)]
        public string Quantity_16 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Conditional(18)]
        [StringLength(2, 17)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(17)]
        public string IdentificationCode_17 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("380", typeof(X12_R))]
        [Pos(18)]
        public string Quantity_18 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Conditional(20)]
        [StringLength(2, 17)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(19)]
        public string IdentificationCode_19 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("380", typeof(X12_R))]
        [Pos(20)]
        public string Quantity_20 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Conditional(22)]
        [StringLength(2, 17)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(21)]
        public string IdentificationCode_21 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("380", typeof(X12_R))]
        [Pos(22)]
        public string Quantity_22 { get; set; }
    }

    /// <summary>
    /// Service Charges
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SER")]
    public class SER : I_SER
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(1)]
        public string ProductServiceIDQualifier_01 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(2)]
        public string ProductServiceID_02 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [RequiredAny(4)]
        [StringLength(1, 15)]
        [DataElement("782", typeof(X12_R))]
        [Pos(3)]
        public string MonetaryAmount_03 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 15)]
        [DataElement("782", typeof(X12_R))]
        [Pos(4)]
        public string MonetaryAmount_04 { get; set; }
        /// <summary>
        /// Unit Price
        /// </summary>
        [DataMember]
        [StringLength(1, 14)]
        [DataElement("212", typeof(X12_R))]
        [Pos(5)]
        public string UnitPrice_05 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("380", typeof(X12_R))]
        [Pos(6)]
        public string Quantity_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(7)]
        public string Description_07 { get; set; }
    }

    /// <summary>
    /// Shipped/Received Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SHP")]
    public class SHP : I_SHP
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Quantity Qualifier
        /// </summary>
        [DataMember]
        [Conditional(2)]
        [DataElement("673", typeof(X12_ID_673))]
        [Pos(1)]
        public string QuantityQualifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("380", typeof(X12_R))]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Conditional(4)]
        [DataElement("374", typeof(X12_ID_374))]
        [Pos(3)]
        public string DateTimeQualifier_03 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(4)]
        public string Date_04 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(5)]
        public string Time_05 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(6)]
        public string Date_06 { get; set; }
        /// <summary>
        /// Time
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("337", typeof(X12_TM))]
        [Pos(7)]
        public string Time_07 { get; set; }
    }

    /// <summary>
    /// Tariff Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SL1")]
    public class SL1 : I_SL1
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Service Level Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("284", typeof(X12_ID_284))]
        [Pos(1)]
        public string ServiceLevelCode_01 { get; set; }
        /// <summary>
        /// Tariff Number
        /// </summary>
        [DataMember]
        [ConditionalAny(3, 4)]
        [StringLength(1, 7)]
        [DataElement("171", typeof(X12_AN))]
        [Pos(2)]
        public string TariffNumber_02 { get; set; }
        /// <summary>
        /// Commodity Code
        /// </summary>
        [DataMember]
        [RequiredAny(4)]
        [StringLength(1, 16)]
        [DataElement("22", typeof(X12_AN))]
        [Pos(3)]
        public string CommodityCode_03 { get; set; }
        /// <summary>
        /// Scale
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("320", typeof(X12_AN))]
        [Pos(4)]
        public string Scale_04 { get; set; }
        /// <summary>
        /// Effective Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("37", typeof(X12_DT))]
        [Pos(5)]
        public string EffectiveDate_05 { get; set; }
        /// <summary>
        /// Service Level Code
        /// </summary>
        [DataMember]
        [DataElement("284", typeof(X12_ID_284))]
        [Pos(6)]
        public string ServiceLevelCode_06 { get; set; }
        /// <summary>
        /// Shipment Method of Payment
        /// </summary>
        [DataMember]
        [DataElement("146", typeof(X12_ID_146))]
        [Pos(7)]
        public string ShipmentMethodofPayment_07 { get; set; }
        /// <summary>
        /// Data Source Code
        /// </summary>
        [DataMember]
        [DataElement("982", typeof(X12_ID_982))]
        [Pos(8)]
        public string DataSourceCode_08 { get; set; }
        /// <summary>
        /// International/Domestic Code
        /// </summary>
        [DataMember]
        [DataElement("210", typeof(X12_ID_210))]
        [Pos(9)]
        public string InternationalDomesticCode_09 { get; set; }
    }

    /// <summary>
    /// Subline Item Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SLN")]
    public class SLN : I_SLN
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Assigned Identification
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 6)]
        [DataElement("350", typeof(X12_AN))]
        [Pos(1)]
        public string AssignedIdentification_01 { get; set; }
        /// <summary>
        /// Assigned Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("350", typeof(X12_AN))]
        [Pos(2)]
        public string AssignedIdentification_02 { get; set; }
        /// <summary>
        /// Configuration Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("661", typeof(X12_ID_661))]
        [Pos(3)]
        public string ConfigurationCode_03 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 10)]
        [DataElement("380", typeof(X12_R))]
        [Pos(4)]
        public string Quantity_04 { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(5)]
        public string UnitofMeasurementCode_05 { get; set; }
        /// <summary>
        /// Unit Price
        /// </summary>
        [DataMember]
        [Conditional(8)]
        [StringLength(1, 14)]
        [DataElement("212", typeof(X12_R))]
        [Pos(6)]
        public string UnitPrice_06 { get; set; }
        /// <summary>
        /// Basis of Unit Price Code
        /// </summary>
        [DataMember]
        [Conditional(6)]
        [DataElement("639", typeof(X12_ID_639))]
        [Pos(7)]
        public string BasisofUnitPriceCode_07 { get; set; }
        /// <summary>
        /// Subline Price Change Code ID
        /// </summary>
        [DataMember]
        [DataElement("662", typeof(X12_ID_662))]
        [Pos(8)]
        public string SublinePriceChangeCodeID_08 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(10)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(9)]
        public string ProductServiceIDQualifier_09 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(10)]
        public string ProductServiceID_10 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(12)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(11)]
        public string ProductServiceIDQualifier_11 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(12)]
        public string ProductServiceID_12 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(14)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(13)]
        public string ProductServiceIDQualifier_13 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(14)]
        public string ProductServiceID_14 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(16)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(15)]
        public string ProductServiceIDQualifier_15 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(16)]
        public string ProductServiceID_16 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(18)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(17)]
        public string ProductServiceIDQualifier_17 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(18)]
        public string ProductServiceID_18 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(20)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(19)]
        public string ProductServiceIDQualifier_19 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(20)]
        public string ProductServiceID_20 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(22)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(21)]
        public string ProductServiceIDQualifier_21 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(22)]
        public string ProductServiceID_22 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(24)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(23)]
        public string ProductServiceIDQualifier_23 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(24)]
        public string ProductServiceID_24 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(26)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(25)]
        public string ProductServiceIDQualifier_25 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(26)]
        public string ProductServiceID_26 { get; set; }
        /// <summary>
        /// Product/Service ID Qualifier
        /// </summary>
        [DataMember]
        [Conditional(28)]
        [DataElement("235", typeof(X12_ID_235))]
        [Pos(27)]
        public string ProductServiceIDQualifier_27 { get; set; }
        /// <summary>
        /// Product/Service ID
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("234", typeof(X12_AN))]
        [Pos(28)]
        public string ProductServiceID_28 { get; set; }
    }

    /// <summary>
    /// Item Detail (Shipment)
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SN1")]
    public class SN1 : I_SN1
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Assigned Identification
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("350", typeof(X12_AN))]
        [Pos(1)]
        public string AssignedIdentification_01 { get; set; }
        /// <summary>
        /// Number of Units Shipped
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 10)]
        [DataElement("382", typeof(X12_R))]
        [Pos(2)]
        public string NumberofUnitsShipped_02 { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(3)]
        public string UnitofMeasurementCode_03 { get; set; }
        /// <summary>
        /// Quantity Shipped to Date
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("646", typeof(X12_R))]
        [Pos(4)]
        public string QuantityShippedtoDate_04 { get; set; }
        /// <summary>
        /// Quantity Ordered
        /// </summary>
        [DataMember]
        [Conditional(6)]
        [StringLength(1, 9)]
        [DataElement("330", typeof(X12_R))]
        [Pos(5)]
        public string QuantityOrdered_05 { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(6)]
        public string UnitofMeasurementCode_06 { get; set; }
        /// <summary>
        /// Returnable Container Load Make-Up Code
        /// </summary>
        [DataMember]
        [DataElement("728", typeof(X12_ID_728))]
        [Pos(7)]
        public string ReturnableContainerLoadMakeUpCode_07 { get; set; }
        /// <summary>
        /// Line Item Status Code
        /// </summary>
        [DataMember]
        [DataElement("668", typeof(X12_ID_668))]
        [Pos(8)]
        public string LineItemStatusCode_08 { get; set; }
    }

    /// <summary>
    /// Specification Identifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SPI")]
    public class SPI : I_SPI
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Security Level Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("786", typeof(X12_ID_786))]
        [Pos(1)]
        public string SecurityLevelCode_01 { get; set; }
        /// <summary>
        /// Reference Number Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(2)]
        public string ReferenceNumberQualifier_02 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(3)]
        public string ReferenceNumber_03 { get; set; }
        /// <summary>
        /// Entity Title
        /// </summary>
        [DataMember]
        [StringLength(1, 132)]
        [DataElement("790", typeof(X12_AN))]
        [Pos(4)]
        public string EntityTitle_04 { get; set; }
        /// <summary>
        /// Entity Purpose
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("791", typeof(X12_AN))]
        [Pos(5)]
        public string EntityPurpose_05 { get; set; }
        /// <summary>
        /// Entity Status Code
        /// </summary>
        [DataMember]
        [DataElement("792", typeof(X12_ID_792))]
        [Pos(6)]
        public string EntityStatusCode_06 { get; set; }
        /// <summary>
        /// Transaction Set Purpose Code
        /// </summary>
        [DataMember]
        [DataElement("353", typeof(X12_ID_353))]
        [Pos(7)]
        public string TransactionSetPurposeCode_07 { get; set; }
        /// <summary>
        /// Report Type Code
        /// </summary>
        [DataMember]
        [DataElement("755", typeof(X12_ID_755))]
        [Pos(8)]
        public string ReportTypeCode_08 { get; set; }
        /// <summary>
        /// Security Level Code
        /// </summary>
        [DataMember]
        [DataElement("786", typeof(X12_ID_786))]
        [Pos(9)]
        public string SecurityLevelCode_09 { get; set; }
    }

    /// <summary>
    /// Sampling Parameters for Summary Statistics
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SPS")]
    public class SPS : I_SPS
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Population Size (Count)
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("946", typeof(X12_N0))]
        [Pos(1)]
        public string PopulationSizeCount_01 { get; set; }
        /// <summary>
        /// Sample Size (Count)
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("947", typeof(X12_N0))]
        [Pos(2)]
        public string SampleSizeCount_02 { get; set; }
        /// <summary>
        /// Subgroup Size (Count)
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("948", typeof(X12_N0))]
        [Pos(3)]
        public string SubgroupSizeCount_03 { get; set; }
        /// <summary>
        /// Confidence Limit
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("949", typeof(X12_R))]
        [Pos(4)]
        public string ConfidenceLimit_04 { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [Paired(6)]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(5)]
        public string UnitofMeasurementCode_05 { get; set; }
        /// <summary>
        /// Sample Frequency Value per Unit of Measurement Code
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("942", typeof(X12_N0))]
        [Pos(6)]
        public string SampleFrequencyValueperUnitofMeasurementCode_06 { get; set; }
    }

    /// <summary>
    /// Special Services
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("SSS")]
    public class SSS : I_SSS
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Allowance or Charge Indicator
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("248", typeof(X12_ID_248))]
        [Pos(1)]
        public string AllowanceorChargeIndicator_01 { get; set; }
        /// <summary>
        /// Association Qualifier Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("559", typeof(X12_ID_559))]
        [Pos(2)]
        public string AssociationQualifierCode_02 { get; set; }
        /// <summary>
        /// Special Services Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("560", typeof(X12_ID_560))]
        [Pos(3)]
        public string SpecialServicesCode_03 { get; set; }
        /// <summary>
        /// Service Marks and Numbers
        /// </summary>
        [DataMember]
        [StringLength(1, 45)]
        [DataElement("561", typeof(X12_AN))]
        [Pos(4)]
        public string ServiceMarksandNumbers_04 { get; set; }
        /// <summary>
        /// Allowance or Charge Rate
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("359", typeof(X12_R))]
        [Pos(5)]
        public string AllowanceorChargeRate_05 { get; set; }
        /// <summary>
        /// Allowance or Charge Total Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("360", typeof(X12_N2))]
        [Pos(6)]
        public string AllowanceorChargeTotalAmount_06 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(7)]
        public string Description_07 { get; set; }
    }

    /// <summary>
    /// Statistics
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("STA")]
    public class STA : I_STA
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Statistic Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("950", typeof(X12_ID_950))]
        [Pos(1)]
        public string StatisticCode_01 { get; set; }
        /// <summary>
        /// Measurement Value
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 10)]
        [DataElement("739", typeof(X12_R))]
        [Pos(2)]
        public string MeasurementValue_02 { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(3)]
        public string UnitofMeasurementCode_03 { get; set; }
        /// <summary>
        /// Measurement Qualifier
        /// </summary>
        [DataMember]
        [DataElement("738", typeof(X12_ID_738))]
        [Pos(4)]
        public string MeasurementQualifier_04 { get; set; }
        /// <summary>
        /// Measurement Reference ID Code
        /// </summary>
        [DataMember]
        [DataElement("737", typeof(X12_ID_737))]
        [Pos(5)]
        public string MeasurementReferenceIDCode_05 { get; set; }
    }

    /// <summary>
    /// Sales Tax Reference
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TAX")]
    public class TAX : I_TAX
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Tax Identification Number
        /// </summary>
        [DataMember]
        [RequiredAny(2)]
        [StringLength(1, 20)]
        [DataElement("325", typeof(X12_AN))]
        [Pos(1)]
        public string TaxIdentificationNumber_01 { get; set; }
        /// <summary>
        /// Location Qualifier
        /// </summary>
        [DataMember]
        [Conditional(3)]
        [DataElement("309", typeof(X12_ID_309))]
        [Pos(2)]
        public string LocationQualifier_02 { get; set; }
        /// <summary>
        /// Location Identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 25)]
        [DataElement("310", typeof(X12_AN))]
        [Pos(3)]
        public string LocationIdentifier_03 { get; set; }
        /// <summary>
        /// Location Qualifier
        /// </summary>
        [DataMember]
        [Conditional(5)]
        [DataElement("309", typeof(X12_ID_309))]
        [Pos(4)]
        public string LocationQualifier_04 { get; set; }
        /// <summary>
        /// Location Identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 25)]
        [DataElement("310", typeof(X12_AN))]
        [Pos(5)]
        public string LocationIdentifier_05 { get; set; }
        /// <summary>
        /// Location Qualifier
        /// </summary>
        [DataMember]
        [Conditional(7)]
        [DataElement("309", typeof(X12_ID_309))]
        [Pos(6)]
        public string LocationQualifier_06 { get; set; }
        /// <summary>
        /// Location Identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 25)]
        [DataElement("310", typeof(X12_AN))]
        [Pos(7)]
        public string LocationIdentifier_07 { get; set; }
        /// <summary>
        /// Location Qualifier
        /// </summary>
        [DataMember]
        [Conditional(9)]
        [DataElement("309", typeof(X12_ID_309))]
        [Pos(8)]
        public string LocationQualifier_08 { get; set; }
        /// <summary>
        /// Location Identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 25)]
        [DataElement("310", typeof(X12_AN))]
        [Pos(9)]
        public string LocationIdentifier_09 { get; set; }
        /// <summary>
        /// Location Qualifier
        /// </summary>
        [DataMember]
        [Conditional(11)]
        [DataElement("309", typeof(X12_ID_309))]
        [Pos(10)]
        public string LocationQualifier_10 { get; set; }
        /// <summary>
        /// Location Identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 25)]
        [DataElement("310", typeof(X12_AN))]
        [Pos(11)]
        public string LocationIdentifier_11 { get; set; }
        /// <summary>
        /// Tax Exempt Code
        /// </summary>
        [DataMember]
        [DataElement("441", typeof(X12_ID_441))]
        [Pos(12)]
        public string TaxExemptCode_12 { get; set; }
    }

    /// <summary>
    /// Carrier Details (Quantity and Weight)
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TD1")]
    public class TD1 : I_TD1
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Packaging Code
        /// </summary>
        [DataMember]
        [Conditional(2)]
        [StringLength(5, 5)]
        [DataElement("103", typeof(X12_AN))]
        [Pos(1)]
        public string PackagingCode_01 { get; set; }
        /// <summary>
        /// Lading Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("80", typeof(X12_N0))]
        [Pos(2)]
        public string LadingQuantity_02 { get; set; }
        /// <summary>
        /// Commodity Code Qualifier
        /// </summary>
        [DataMember]
        [Conditional(4)]
        [DataElement("23", typeof(X12_ID_23))]
        [Pos(3)]
        public string CommodityCodeQualifier_03 { get; set; }
        /// <summary>
        /// Commodity Code
        /// </summary>
        [DataMember]
        [StringLength(1, 16)]
        [DataElement("22", typeof(X12_AN))]
        [Pos(4)]
        public string CommodityCode_04 { get; set; }
        /// <summary>
        /// Lading Description
        /// </summary>
        [DataMember]
        [StringLength(1, 50)]
        [DataElement("79", typeof(X12_AN))]
        [Pos(5)]
        public string LadingDescription_05 { get; set; }
        /// <summary>
        /// Weight Qualifier
        /// </summary>
        [DataMember]
        [Conditional(7, 8)]
        [DataElement("187", typeof(X12_ID_187))]
        [Pos(6)]
        public string WeightQualifier_06 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("81", typeof(X12_R))]
        [Pos(7)]
        public string Weight_07 { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(8)]
        public string UnitofMeasurementCode_08 { get; set; }
    }

    /// <summary>
    /// Carrier Details (Equipment)
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TD3")]
    public class TD3 : I_TD3
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Equipment Description Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("40", typeof(X12_ID_40))]
        [Pos(1)]
        public string EquipmentDescriptionCode_01 { get; set; }
        /// <summary>
        /// Equipment Initial
        /// </summary>
        [DataMember]
        [Conditional(3)]
        [StringLength(1, 4)]
        [DataElement("206", typeof(X12_AN))]
        [Pos(2)]
        public string EquipmentInitial_02 { get; set; }
        /// <summary>
        /// Equipment Number
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("207", typeof(X12_AN))]
        [Pos(3)]
        public string EquipmentNumber_03 { get; set; }
        /// <summary>
        /// Weight Qualifier
        /// </summary>
        [DataMember]
        [Conditional(5, 6)]
        [DataElement("187", typeof(X12_ID_187))]
        [Pos(4)]
        public string WeightQualifier_04 { get; set; }
        /// <summary>
        /// Weight
        /// </summary>
        [DataMember]
        [StringLength(1, 8)]
        [DataElement("81", typeof(X12_R))]
        [Pos(5)]
        public string Weight_05 { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(6)]
        public string UnitofMeasurementCode_06 { get; set; }
        /// <summary>
        /// Ownership Code
        /// </summary>
        [DataMember]
        [DataElement("102", typeof(X12_ID_102))]
        [Pos(7)]
        public string OwnershipCode_07 { get; set; }
    }

    /// <summary>
    /// Carrier Details (Special Handling/Hazardous Materials)
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TD4")]
    public class TD4 : I_TD4
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Special Handling Code
        /// </summary>
        [DataMember]
        [RequiredAny(4)]
        [DataElement("152", typeof(X12_ID_152))]
        [Pos(1)]
        public string SpecialHandlingCode_01 { get; set; }
        /// <summary>
        /// Hazardous Material Code Qualifier
        /// </summary>
        [DataMember]
        [Conditional(3)]
        [DataElement("208", typeof(X12_ID_208))]
        [Pos(2)]
        public string HazardousMaterialCodeQualifier_02 { get; set; }
        /// <summary>
        /// Hazardous Material Class Code
        /// </summary>
        [DataMember]
        [StringLength(2, 4)]
        [DataElement("209", typeof(X12_AN))]
        [Pos(3)]
        public string HazardousMaterialClassCode_03 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(4)]
        public string Description_04 { get; set; }
    }

    /// <summary>
    /// Carrier Details (Routing Sequence/Transit Time)
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TD5")]
    public class TD5 : I_TD5
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Routing Sequence Code
        /// </summary>
        [DataMember]
        [DataElement("133", typeof(X12_ID_133))]
        [Pos(1)]
        public string RoutingSequenceCode_01 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [RequiredAny(4, 5)]
        [Conditional(3)]
        [DataElement("66", typeof(X12_ID_66))]
        [Pos(2)]
        public string IdentificationCodeQualifier_02 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [StringLength(2, 17)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(3)]
        public string IdentificationCode_03 { get; set; }
        /// <summary>
        /// Transportation Method/Type Code
        /// </summary>
        [DataMember]
        [DataElement("91", typeof(X12_ID_91))]
        [Pos(4)]
        public string TransportationMethodTypeCode_04 { get; set; }
        /// <summary>
        /// Routing
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("387", typeof(X12_AN))]
        [Pos(5)]
        public string Routing_05 { get; set; }
        /// <summary>
        /// Shipment/Order Status Code
        /// </summary>
        [DataMember]
        [DataElement("368", typeof(X12_ID_368))]
        [Pos(6)]
        public string ShipmentOrderStatusCode_06 { get; set; }
        /// <summary>
        /// Location Qualifier
        /// </summary>
        [DataMember]
        [Conditional(8)]
        [DataElement("309", typeof(X12_ID_309))]
        [Pos(7)]
        public string LocationQualifier_07 { get; set; }
        /// <summary>
        /// Location Identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 25)]
        [DataElement("310", typeof(X12_AN))]
        [Pos(8)]
        public string LocationIdentifier_08 { get; set; }
        /// <summary>
        /// Transit Direction Code
        /// </summary>
        [DataMember]
        [DataElement("731", typeof(X12_ID_731))]
        [Pos(9)]
        public string TransitDirectionCode_09 { get; set; }
        /// <summary>
        /// Transit Time Direction Qualifier
        /// </summary>
        [DataMember]
        [Conditional(11)]
        [DataElement("732", typeof(X12_ID_732))]
        [Pos(10)]
        public string TransitTimeDirectionQualifier_10 { get; set; }
        /// <summary>
        /// Transit Time
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("733", typeof(X12_R))]
        [Pos(11)]
        public string TransitTime_11 { get; set; }
    }

    /// <summary>
    /// Total Monetary Value Summary
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TDS")]
    public class TDS : I_TDS
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Total Invoice Amount
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 10)]
        [DataElement("361", typeof(X12_N2))]
        [Pos(1)]
        public string TotalInvoiceAmount_01 { get; set; }
        /// <summary>
        /// Amount Subject to Terms Discount
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("390", typeof(X12_N2))]
        [Pos(2)]
        public string AmountSubjecttoTermsDiscount_02 { get; set; }
        /// <summary>
        /// Discounted Amount Due
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("391", typeof(X12_N2))]
        [Pos(3)]
        public string DiscountedAmountDue_03 { get; set; }
        /// <summary>
        /// Terms Discount Amount
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("362", typeof(X12_N2))]
        [Pos(4)]
        public string TermsDiscountAmount_04 { get; set; }
    }

    /// <summary>
    /// Technical Error Description
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TED")]
    public class TED : I_TED
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Application Error Condition Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("647", typeof(X12_ID_647))]
        [Pos(1)]
        public string ApplicationErrorConditionCode_01 { get; set; }
        /// <summary>
        /// Free Form Message
        /// </summary>
        [DataMember]
        [StringLength(1, 60)]
        [DataElement("3", typeof(X12_AN))]
        [Pos(2)]
        public string FreeFormMessage_02 { get; set; }
        /// <summary>
        /// Segment ID Code
        /// </summary>
        [DataMember]
        [StringLength(2, 3)]
        [DataElement("721", typeof(X12_AN))]
        [Pos(3)]
        public string SegmentIDCode_03 { get; set; }
        /// <summary>
        /// Segment Position in Transaction Set
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("719", typeof(X12_N0))]
        [Pos(4)]
        public string SegmentPositioninTransactionSet_04 { get; set; }
        /// <summary>
        /// Element Position in Segment
        /// </summary>
        [DataMember]
        [StringLength(1, 2)]
        [DataElement("722", typeof(X12_N0))]
        [Pos(5)]
        public string ElementPositioninSegment_05 { get; set; }
        /// <summary>
        /// Data Element Reference Number
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("725", typeof(X12_N0))]
        [Pos(6)]
        public string DataElementReferenceNumber_06 { get; set; }
        /// <summary>
        /// Copy of Bad Data Element
        /// </summary>
        [DataMember]
        [StringLength(1, 99)]
        [DataElement("724", typeof(X12_AN))]
        [Pos(7)]
        public string CopyofBadDataElement_07 { get; set; }
        /// <summary>
        /// Data Element New Content
        /// </summary>
        [DataMember]
        [StringLength(1, 99)]
        [DataElement("961", typeof(X12_AN))]
        [Pos(8)]
        public string DataElementNewContent_08 { get; set; }
    }

    /// <summary>
    /// Tax Form
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TFS")]
    public class TFS : I_TFS
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Reference Number Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(1)]
        public string ReferenceNumberQualifier_01 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(2)]
        public string ReferenceNumber_02 { get; set; }
        /// <summary>
        /// Reference Number Qualifier
        /// </summary>
        [DataMember]
        [Paired(4)]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(3)]
        public string ReferenceNumberQualifier_03 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(4)]
        public string ReferenceNumber_04 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Paired(6)]
        [DataElement("66", typeof(X12_ID_66))]
        [Pos(5)]
        public string IdentificationCodeQualifier_05 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [StringLength(2, 17)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(6)]
        public string IdentificationCode_06 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(7)]
        public string Date_07 { get; set; }
        /// <summary>
        /// Internal Revenue Service Record Control Identifier
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("818", typeof(X12_AN))]
        [Pos(8)]
        public string InternalRevenueServiceRecordControlIdentifier_08 { get; set; }
    }

    /// <summary>
    /// Tax Information and Amount
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TIA")]
    public class TIA : I_TIA
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Tax Information Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 5)]
        [DataElement("817", typeof(X12_AN))]
        [Pos(1)]
        public string TaxInformationCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [RequiredAny(3)]
        [StringLength(1, 15)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string MonetaryAmount_02 { get; set; }
        /// <summary>
        /// Fixed Format Information
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("449", typeof(X12_AN))]
        [Pos(3)]
        public string FixedFormatInformation_03 { get; set; }
    }

    /// <summary>
    /// Test Method
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TMD")]
    public class TMD : I_TMD
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Product/Process Characteristic Code
        /// </summary>
        [DataMember]
        [DataElement("750", typeof(X12_ID_750))]
        [Pos(1)]
        public string ProductProcessCharacteristicCode_01 { get; set; }
        /// <summary>
        /// Association Qualifier Code
        /// </summary>
        [DataMember]
        [Paired(3)]
        [DataElement("559", typeof(X12_ID_559))]
        [Pos(2)]
        public string AssociationQualifierCode_02 { get; set; }
        /// <summary>
        /// Product Description Code
        /// </summary>
        [DataMember]
        [StringLength(1, 12)]
        [DataElement("751", typeof(X12_AN))]
        [Pos(3)]
        public string ProductDescriptionCode_03 { get; set; }
        /// <summary>
        /// Test Administration Method Code
        /// </summary>
        [DataMember]
        [DataElement("937", typeof(X12_ID_937))]
        [Pos(4)]
        public string TestAdministrationMethodCode_04 { get; set; }
        /// <summary>
        /// Test Medium Code
        /// </summary>
        [DataMember]
        [DataElement("938", typeof(X12_ID_938))]
        [Pos(5)]
        public string TestMediumCode_05 { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        [DataMember]
        [StringLength(1, 80)]
        [DataElement("352", typeof(X12_AN))]
        [Pos(6)]
        public string Description_06 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(7)]
        public string Date_07 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(8)]
        public string ReferenceNumber_08 { get; set; }
    }

    /// <summary>
    /// Trace
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TRN")]
    public class TRN : I_TRN
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Trace Type Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("481", typeof(X12_ID_481))]
        [Pos(1)]
        public string TraceTypeCode_01 { get; set; }
        /// <summary>
        /// Entity Identifier Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("98", typeof(X12_ID_98))]
        [Pos(2)]
        public string EntityIdentifierCode_02 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("66", typeof(X12_ID_66))]
        [Pos(3)]
        public string IdentificationCodeQualifier_03 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 17)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(4)]
        public string IdentificationCode_04 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(5)]
        public string ReferenceNumber_05 { get; set; }
        /// <summary>
        /// Application Batch Identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("957", typeof(X12_AN))]
        [Pos(6)]
        public string ApplicationBatchIdentifier_06 { get; set; }
        /// <summary>
        /// Application Item Identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("958", typeof(X12_AN))]
        [Pos(7)]
        public string ApplicationItemIdentifier_07 { get; set; }
        /// <summary>
        /// Reference Number Qualifier
        /// </summary>
        [DataMember]
        [Paired(9)]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(8)]
        public string ReferenceNumberQualifier_08 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(9)]
        public string ReferenceNumber_09 { get; set; }
    }

    /// <summary>
    /// Tax Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("TXI")]
    public class TXI : I_TXI
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Tax Type Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("963", typeof(X12_ID_963))]
        [Pos(1)]
        public string TaxTypeCode_01 { get; set; }
        /// <summary>
        /// Monetary Amount
        /// </summary>
        [DataMember]
        [RequiredAny(3)]
        [StringLength(1, 15)]
        [DataElement("782", typeof(X12_R))]
        [Pos(2)]
        public string MonetaryAmount_02 { get; set; }
        /// <summary>
        /// Percent
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("954", typeof(X12_R))]
        [Pos(3)]
        public string Percent_03 { get; set; }
        /// <summary>
        /// Tax Jurisdiction Code Qualifier
        /// </summary>
        [DataMember]
        [Paired(5)]
        [DataElement("955", typeof(X12_ID_955))]
        [Pos(4)]
        public string TaxJurisdictionCodeQualifier_04 { get; set; }
        /// <summary>
        /// Tax Jurisdiction Code
        /// </summary>
        [DataMember]
        [StringLength(1, 10)]
        [DataElement("956", typeof(X12_AN))]
        [Pos(5)]
        public string TaxJurisdictionCode_05 { get; set; }
    }

    /// <summary>
    /// Unit Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("UIT")]
    public class UIT : I_UIT
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(1)]
        public string UnitofMeasurementCode_01 { get; set; }
        /// <summary>
        /// Unit Price
        /// </summary>
        [DataMember]
        [StringLength(1, 14)]
        [DataElement("212", typeof(X12_R))]
        [Pos(2)]
        public string UnitPrice_02 { get; set; }
        /// <summary>
        /// Basis of Unit Price Code
        /// </summary>
        [DataMember]
        [Conditional(2)]
        [DataElement("639", typeof(X12_ID_639))]
        [Pos(3)]
        public string BasisofUnitPriceCode_03 { get; set; }
    }

    /// <summary>
    /// Event Detail
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("V9")]
    public class V9 : I_V9
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Event Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("304", typeof(X12_ID_304))]
        [Pos(1)]
        public string EventCode_01 { get; set; }
        /// <summary>
        /// Event
        /// </summary>
        [DataMember]
        [StringLength(1, 25)]
        [DataElement("106", typeof(X12_AN))]
        [Pos(2)]
        public string Event_02 { get; set; }
        /// <summary>
        /// Event Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("179", typeof(X12_DT))]
        [Pos(3)]
        public string EventDate_03 { get; set; }
        /// <summary>
        /// Event Time
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("180", typeof(X12_TM))]
        [Pos(4)]
        public string EventTime_04 { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        [DataMember]
        [StringLength(2, 19)]
        [DataElement("19", typeof(X12_AN))]
        [Pos(5)]
        public string CityName_05 { get; set; }
        /// <summary>
        /// State or Province Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("156", typeof(X12_AN))]
        [Pos(6)]
        public string StateorProvinceCode_06 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("26", typeof(X12_AN))]
        [Pos(7)]
        public string CountryCode_07 { get; set; }
        /// <summary>
        /// Status Reason Code
        /// </summary>
        [DataMember]
        [DataElement("641", typeof(X12_ID_641))]
        [Pos(8)]
        public string StatusReasonCode_08 { get; set; }
    }

    /// <summary>
    /// Motor Vehicle Control
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("VC")]
    public class VC : I_VC
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Vehicle Identification Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(17, 17)]
        [DataElement("539", typeof(X12_AN))]
        [Pos(1)]
        public string VehicleIdentificationNumber_01 { get; set; }
        /// <summary>
        /// Vehicle Deck Position Code
        /// </summary>
        [DataMember]
        [DataElement("836", typeof(X12_ID_836))]
        [Pos(2)]
        public string VehicleDeckPositionCode_02 { get; set; }
        /// <summary>
        /// Vehicle Type Code
        /// </summary>
        [DataMember]
        [DataElement("837", typeof(X12_ID_837))]
        [Pos(3)]
        public string VehicleTypeCode_03 { get; set; }
        /// <summary>
        /// Dealer Code
        /// </summary>
        [DataMember]
        [StringLength(2, 9)]
        [DataElement("838", typeof(X12_AN))]
        [Pos(4)]
        public string DealerCode_04 { get; set; }
        /// <summary>
        /// Route Code
        /// </summary>
        [DataMember]
        [StringLength(1, 13)]
        [DataElement("1", typeof(X12_AN))]
        [Pos(5)]
        public string RouteCode_05 { get; set; }
        /// <summary>
        /// Bay Location
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("839", typeof(X12_AN))]
        [Pos(6)]
        public string BayLocation_06 { get; set; }
        /// <summary>
        /// Automotive Manufacturers Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("833", typeof(X12_AN))]
        [Pos(7)]
        public string AutomotiveManufacturersCode_07 { get; set; }
        /// <summary>
        /// Damage Exception Indicator
        /// </summary>
        [DataMember]
        [DataElement("308", typeof(X12_ID_308))]
        [Pos(8)]
        public string DamageExceptionIndicator_08 { get; set; }
        /// <summary>
        /// Supplemental Inspection Code
        /// </summary>
        [DataMember]
        [DataElement("835", typeof(X12_ID_835))]
        [Pos(9)]
        public string SupplementalInspectionCode_09 { get; set; }
        /// <summary>
        /// Factory Car Order Number
        /// </summary>
        [DataMember]
        [StringLength(6, 10)]
        [DataElement("583", typeof(X12_AN))]
        [Pos(10)]
        public string FactoryCarOrderNumber_10 { get; set; }
    }

    /// <summary>
    /// Export License
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("X1")]
    public class X1 : I_X1
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Licensing Agency Code
        /// </summary>
        [DataMember]
        [DataElement("83", typeof(X12_ID_83))]
        [Pos(1)]
        public string LicensingAgencyCode_01 { get; set; }
        /// <summary>
        /// Export License Number
        /// </summary>
        [DataMember]
        [StringLength(6, 12)]
        [DataElement("50", typeof(X12_AN))]
        [Pos(2)]
        public string ExportLicenseNumber_02 { get; set; }
        /// <summary>
        /// Export License Status Code
        /// </summary>
        [DataMember]
        [DataElement("51", typeof(X12_ID_51))]
        [Pos(3)]
        public string ExportLicenseStatusCode_03 { get; set; }
        /// <summary>
        /// Export License Expiration Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("49", typeof(X12_DT))]
        [Pos(4)]
        public string ExportLicenseExpirationDate_04 { get; set; }
        /// <summary>
        /// Export License Symbol Code
        /// </summary>
        [DataMember]
        [DataElement("52", typeof(X12_ID_52))]
        [Pos(5)]
        public string ExportLicenseSymbolCode_05 { get; set; }
        /// <summary>
        /// Export License Control Code
        /// </summary>
        [DataMember]
        [DataElement("48", typeof(X12_ID_48))]
        [Pos(6)]
        public string ExportLicenseControlCode_06 { get; set; }
        /// <summary>
        /// Country Code
        /// </summary>
        [DataMember]
        [StringLength(2, 2)]
        [DataElement("26", typeof(X12_AN))]
        [Pos(7)]
        public string CountryCode_07 { get; set; }
        /// <summary>
        /// Schedule B Code
        /// </summary>
        [DataMember]
        [StringLength(7, 7)]
        [DataElement("141", typeof(X12_AN))]
        [Pos(8)]
        public string ScheduleBCode_08 { get; set; }
        /// <summary>
        /// International/Domestic Code
        /// </summary>
        [DataMember]
        [DataElement("210", typeof(X12_ID_210))]
        [Pos(9)]
        public string InternationalDomesticCode_09 { get; set; }
        /// <summary>
        /// Lading Quantity
        /// </summary>
        [DataMember]
        [StringLength(1, 7)]
        [DataElement("80", typeof(X12_N0))]
        [Pos(10)]
        public string LadingQuantity_10 { get; set; }
        /// <summary>
        /// Lading Value
        /// </summary>
        [DataMember]
        [StringLength(2, 9)]
        [DataElement("148", typeof(X12_R))]
        [Pos(11)]
        public string LadingValue_11 { get; set; }
        /// <summary>
        /// Export Filing Key Code
        /// </summary>
        [DataMember]
        [DataElement("47", typeof(X12_ID_47))]
        [Pos(12)]
        public string ExportFilingKeyCode_12 { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(13)]
        public string UnitofMeasurementCode_13 { get; set; }
        /// <summary>
        /// Unit Price
        /// </summary>
        [DataMember]
        [StringLength(1, 14)]
        [DataElement("212", typeof(X12_R))]
        [Pos(14)]
        public string UnitPrice_14 { get; set; }
    }

    /// <summary>
    /// Import License
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("X2")]
    public class X2 : I_X2
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Import License Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(6, 30)]
        [DataElement("70", typeof(X12_AN))]
        [Pos(1)]
        public string ImportLicenseNumber_01 { get; set; }
        /// <summary>
        /// Import License Issue Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(6, 6)]
        [DataElement("69", typeof(X12_DT))]
        [Pos(2)]
        public string ImportLicenseIssueDate_02 { get; set; }
        /// <summary>
        /// Import License Expiration Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("68", typeof(X12_DT))]
        [Pos(3)]
        public string ImportLicenseExpirationDate_03 { get; set; }
    }

    /// <summary>
    /// Customs Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("X7")]
    public class X7 : I_X7
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Free Form Message
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 30)]
        [DataElement("61", typeof(X12_AN))]
        [Pos(1)]
        public string FreeFormMessage_01 { get; set; }
        /// <summary>
        /// Free Form Message
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("61", typeof(X12_AN))]
        [Pos(2)]
        public string FreeFormMessage_02 { get; set; }
    }

    /// <summary>
    /// Pro Forma - B13 Information
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("XH")]
    public class XH : I_XH
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Currency Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(3, 3)]
        [DataElement("100", typeof(X12_AN))]
        [Pos(1)]
        public string CurrencyCode_01 { get; set; }
        /// <summary>
        /// Related Company Indication Code
        /// </summary>
        [DataMember]
        [DataElement("645", typeof(X12_ID_645))]
        [Pos(2)]
        public string RelatedCompanyIndicationCode_02 { get; set; }
        /// <summary>
        /// Special Charge Code
        /// </summary>
        [DataMember]
        [DataElement("150", typeof(X12_ID_150))]
        [Pos(3)]
        public string SpecialChargeCode_03 { get; set; }
        /// <summary>
        /// Charge
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("58", typeof(X12_N2))]
        [Pos(4)]
        public string Charge_04 { get; set; }
        /// <summary>
        /// Block 20 Code
        /// </summary>
        [DataMember]
        [DataElement("503", typeof(X12_ID_503))]
        [Pos(5)]
        public string BlockCode_05 { get; set; }
        /// <summary>
        /// Chemical Analysis Percentage
        /// </summary>
        [DataMember]
        [StringLength(2, 9)]
        [DataElement("504", typeof(X12_N2))]
        [Pos(6)]
        public string ChemicalAnalysisPercentage_06 { get; set; }
        /// <summary>
        /// Unit Price
        /// </summary>
        [DataMember]
        [StringLength(1, 14)]
        [DataElement("212", typeof(X12_R))]
        [Pos(7)]
        public string UnitPrice_07 { get; set; }
    }

    /// <summary>
    /// Preassigned Purchase Order Numbers
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("XPO")]
    public class XPO : I_XPO
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Purchase Order Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 22)]
        [DataElement("324", typeof(X12_AN))]
        [Pos(1)]
        public string PurchaseOrderNumber_01 { get; set; }
        /// <summary>
        /// Purchase Order Number
        /// </summary>
        [DataMember]
        [StringLength(1, 22)]
        [DataElement("324", typeof(X12_AN))]
        [Pos(2)]
        public string PurchaseOrderNumber_02 { get; set; }
        /// <summary>
        /// Identification Code Qualifier
        /// </summary>
        [DataMember]
        [Paired(4)]
        [DataElement("66", typeof(X12_ID_66))]
        [Pos(3)]
        public string IdentificationCodeQualifier_03 { get; set; }
        /// <summary>
        /// Identification Code
        /// </summary>
        [DataMember]
        [StringLength(2, 17)]
        [DataElement("67", typeof(X12_AN))]
        [Pos(4)]
        public string IdentificationCode_04 { get; set; }
    }

    /// <summary>
    /// Reporting Date/Action
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("XQ")]
    public class XQ : I_XQ
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Transaction Handling Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("305", typeof(X12_ID_305))]
        [Pos(1)]
        public string TransactionHandlingCode_01 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(2)]
        public string Date_02 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(3)]
        public string Date_03 { get; set; }
    }

    /// <summary>
    /// Authentication
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("Y6")]
    public class Y6 : I_Y6
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Authority Identifier Code
        /// </summary>
        [DataMember]
        [DataElement("313", typeof(X12_ID_313))]
        [Pos(1)]
        public string AuthorityIdentifierCode_01 { get; set; }
        /// <summary>
        /// Authority
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 20)]
        [DataElement("151", typeof(X12_AN))]
        [Pos(2)]
        public string Authority_02 { get; set; }
        /// <summary>
        /// Authorization Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(6, 6)]
        [DataElement("275", typeof(X12_DT))]
        [Pos(3)]
        public string AuthorizationDate_03 { get; set; }
    }

    /// <summary>
    /// Priority
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("Y7")]
    public class Y7 : I_Y7
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Priority
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("467", typeof(X12_N0))]
        [Pos(1)]
        public string Priority_01 { get; set; }
        /// <summary>
        /// Priority Code
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("470", typeof(X12_N0))]
        [Pos(2)]
        public string PriorityCode_02 { get; set; }
        /// <summary>
        /// Priority Code Qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 1)]
        [DataElement("471", typeof(X12_AN))]
        [Pos(3)]
        public string PriorityCodeQualifier_03 { get; set; }
        /// <summary>
        /// Port Call File Number
        /// </summary>
        [DataMember]
        [StringLength(4, 4)]
        [DataElement("468", typeof(X12_N0))]
        [Pos(4)]
        public string PortCallFileNumber_04 { get; set; }
        /// <summary>
        /// Required Delivery Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("469", typeof(X12_DT))]
        [Pos(5)]
        public string RequiredDeliveryDate_05 { get; set; }
    }

    /// <summary>
    /// Product Activity Reporting
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ZA")]
    public class ZA : I_ZA
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Activity Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("859", typeof(X12_ID_859))]
        [Pos(1)]
        public string ActivityCode_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Paired(3)]
        [StringLength(1, 10)]
        [DataElement("380", typeof(X12_R))]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        /// <summary>
        /// Unit of Measurement Code
        /// </summary>
        [DataMember]
        [DataElement("355", typeof(X12_ID_355))]
        [Pos(3)]
        public string UnitofMeasurementCode_03 { get; set; }
        /// <summary>
        /// Date/Time Qualifier
        /// </summary>
        [DataMember]
        [Paired(5)]
        [DataElement("374", typeof(X12_ID_374))]
        [Pos(4)]
        public string DateTimeQualifier_04 { get; set; }
        /// <summary>
        /// Date
        /// </summary>
        [DataMember]
        [StringLength(6, 6)]
        [DataElement("373", typeof(X12_DT))]
        [Pos(5)]
        public string Date_05 { get; set; }
        /// <summary>
        /// Reference Number Qualifier
        /// </summary>
        [DataMember]
        [Paired(7)]
        [DataElement("128", typeof(X12_ID_128))]
        [Pos(6)]
        public string ReferenceNumberQualifier_06 { get; set; }
        /// <summary>
        /// Reference Number
        /// </summary>
        [DataMember]
        [StringLength(1, 30)]
        [DataElement("127", typeof(X12_AN))]
        [Pos(7)]
        public string ReferenceNumber_07 { get; set; }
    }

    /// <summary>
    /// Beginning Segment For Data Correction Or Change
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Segment("ZC1")]
    public class ZC1 : I_ZC1
    {

        [XmlIgnore]
        [IgnoreDataMember]
        public int Id { get; set; }
        /// <summary>
        /// Shipment Identification Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 30)]
        [DataElement("145", typeof(X12_AN))]
        [Pos(1)]
        public string ShipmentIdentificationNumber_01 { get; set; }
        /// <summary>
        /// Equipment Initial
        /// </summary>
        [DataMember]
        [StringLength(1, 4)]
        [DataElement("206", typeof(X12_AN))]
        [Pos(2)]
        public string EquipmentInitial_02 { get; set; }
        /// <summary>
        /// Equipment Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 10)]
        [DataElement("207", typeof(X12_AN))]
        [Pos(3)]
        public string EquipmentNumber_03 { get; set; }
        /// <summary>
        /// Transaction Reference Number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 16)]
        [DataElement("244", typeof(X12_AN))]
        [Pos(4)]
        public string TransactionReferenceNumber_04 { get; set; }
        /// <summary>
        /// Transaction Reference Date
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(6, 6)]
        [DataElement("243", typeof(X12_DT))]
        [Pos(5)]
        public string TransactionReferenceDate_05 { get; set; }
        /// <summary>
        /// Correction Indicator
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("202", typeof(X12_ID_202))]
        [Pos(6)]
        public string CorrectionIndicator_06 { get; set; }
        /// <summary>
        /// Standard Carrier Alpha Code
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(2, 4)]
        [DataElement("140", typeof(X12_AN))]
        [Pos(7)]
        public string StandardCarrierAlphaCode_07 { get; set; }
        /// <summary>
        /// Transportation Method/Type Code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("91", typeof(X12_ID_91))]
        [Pos(8)]
        public string TransportationMethodTypeCode_08 { get; set; }
    }
}
