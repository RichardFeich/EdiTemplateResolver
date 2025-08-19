namespace EdiFabric.Templates.X12002040
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using EdiFabric.Core.Annotations.Edi;
    using EdiFabric.Core.Annotations.Validation;
    using EdiFabric.Core.Model.Edi;
    using EdiFabric.Core.Model.Edi.X12;
    using System.Xml.Serialization;
    
    
    public interface I_AAA
    {
        
        string ValidityCode_01 { get; set; }
        string ItemDescriptionQualifier_02 { get; set; }
        string RejectReasonCode_03 { get; set; }
        string FollowupActionCode_04 { get; set; }
    }
    
    public interface I_ACK
    {
        
        string LineItemStatusCode_01 { get; set; }
        string Quantity_02 { get; set; }
        string UnitofMeasurementCode_03 { get; set; }
        string DateTimeQualifier_04 { get; set; }
        string Date_05 { get; set; }
        string RequestReferenceNumber_06 { get; set; }
        string ProductServiceIDQualifier_07 { get; set; }
        string ProductServiceID_08 { get; set; }
        string ProductServiceIDQualifier_09 { get; set; }
        string ProductServiceID_10 { get; set; }
        string ProductServiceIDQualifier_11 { get; set; }
        string ProductServiceID_12 { get; set; }
        string ProductServiceIDQualifier_13 { get; set; }
        string ProductServiceID_14 { get; set; }
        string ProductServiceIDQualifier_15 { get; set; }
        string ProductServiceID_16 { get; set; }
        string ProductServiceIDQualifier_17 { get; set; }
        string ProductServiceID_18 { get; set; }
        string ProductServiceIDQualifier_19 { get; set; }
        string ProductServiceID_20 { get; set; }
        string ProductServiceIDQualifier_21 { get; set; }
        string ProductServiceID_22 { get; set; }
        string ProductServiceIDQualifier_23 { get; set; }
        string ProductServiceID_24 { get; set; }
        string ProductServiceIDQualifier_25 { get; set; }
        string ProductServiceID_26 { get; set; }
    }
    
    public interface I_ACT
    {
        
        string AccountNumber_01 { get; set; }
        string Name_02 { get; set; }
        string IdentificationCodeQualifier_03 { get; set; }
        string IdentificationCode_04 { get; set; }
        string AccountNumberQualifier_05 { get; set; }
        string AccountNumber_06 { get; set; }
        string FreeFormMessage_07 { get; set; }
    }
    
    public interface I_ADJ
    {
        
        string AdjustmentApplicationCode_01 { get; set; }
        string MonetaryAmount_02 { get; set; }
        string MonetaryAmount_03 { get; set; }
        string Date_04 { get; set; }
        string Date_05 { get; set; }
        string NumberofDays_06 { get; set; }
        string Description_07 { get; set; }
    }
    
    public interface I_AK1
    {
        
        string FunctionalIdentifierCode_01 { get; set; }
        string GroupControlNumber_02 { get; set; }
    }
    
    public interface I_AK2
    {
        
        string TransactionSetIdentifierCode_01 { get; set; }
        string TransactionSetControlNumber_02 { get; set; }
    }
    
    public interface I_AK3
    {
        
        string SegmentIDCode_01 { get; set; }
        string SegmentPositioninTransactionSet_02 { get; set; }
        string LoopIdentifierCode_03 { get; set; }
        string SegmentSyntaxErrorCode_04 { get; set; }
        string SegmentSyntaxErrorCode_05 { get; set; }
        string SegmentSyntaxErrorCode_06 { get; set; }
        string SegmentSyntaxErrorCode_07 { get; set; }
        string SegmentSyntaxErrorCode_08 { get; set; }
    }
    
    public interface I_AK4
    {
        
        string ElementPositioninSegment_01 { get; set; }
        string DataElementReferenceNumber_02 { get; set; }
        string DataElementSyntaxErrorCode_03 { get; set; }
        string CopyofBadDataElement_04 { get; set; }
    }
    
    public interface I_AK5
    {
        
        string TransactionSetAcknowledgmentCode_01 { get; set; }
        string TransactionSetSyntaxErrorCode_02 { get; set; }
        string TransactionSetSyntaxErrorCode_03 { get; set; }
        string TransactionSetSyntaxErrorCode_04 { get; set; }
        string TransactionSetSyntaxErrorCode_05 { get; set; }
        string TransactionSetSyntaxErrorCode_06 { get; set; }
    }
    
    public interface I_AK9
    {
        
        string FunctionalGroupAcknowledgeCode_01 { get; set; }
        string NumberofTransactionSetsIncluded_02 { get; set; }
        string NumberofReceivedTransactionSets_03 { get; set; }
        string NumberofAcceptedTransactionSets_04 { get; set; }
        string FunctionalGroupSyntaxErrorCode_05 { get; set; }
        string FunctionalGroupSyntaxErrorCode_06 { get; set; }
        string FunctionalGroupSyntaxErrorCode_07 { get; set; }
        string FunctionalGroupSyntaxErrorCode_08 { get; set; }
        string FunctionalGroupSyntaxErrorCode_09 { get; set; }
    }
    
    public interface I_AMT
    {
        
        string AmountQualifierCode_01 { get; set; }
        string MonetaryAmount_02 { get; set; }
    }
    
    public interface I_ATH
    {
        
        string ResourceAuthorizationCode_01 { get; set; }
        string Date_02 { get; set; }
        string Quantity_03 { get; set; }
        string Quantity_04 { get; set; }
        string Date_05 { get; set; }
    }
    
    public interface I_AVA
    {
        
        string MonetaryAmount_01 { get; set; }
        string Availability_02 { get; set; }
    }
    
    public interface I_BAA
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string TransactionTypeCode_02 { get; set; }
        string Date_03 { get; set; }
        string ReferenceNumberQualifier_04 { get; set; }
        string ReferenceNumber_05 { get; set; }
        string Time_06 { get; set; }
    }
    
    public interface I_BAK
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string AcknowledgmentType_02 { get; set; }
        string PurchaseOrderNumber_03 { get; set; }
        string PurchaseOrderDate_04 { get; set; }
        string ReleaseNumber_05 { get; set; }
        string RequestReferenceNumber_06 { get; set; }
        string ContractNumber_07 { get; set; }
        string ReferenceNumber_08 { get; set; }
        string AcknowledgmentDate_09 { get; set; }
    }
    
    public interface I_BAL
    {
        
        string BalanceTypeCode_01 { get; set; }
        string AmountQualifierCode_02 { get; set; }
        string MonetaryAmount_03 { get; set; }
    }
    
    public interface I_BAT
    {
        
        string Date_01 { get; set; }
        string Time_02 { get; set; }
        string ReferenceNumber_03 { get; set; }
        string BatchTypeCode_04 { get; set; }
    }
    
    public interface I_BCA
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string AcknowledgmentType_02 { get; set; }
        string PurchaseOrderNumber_03 { get; set; }
        string ReleaseNumber_04 { get; set; }
        string ChangeOrderSequenceNumber_05 { get; set; }
        string PurchaseOrderDate_06 { get; set; }
        string RequestReferenceNumber_07 { get; set; }
        string ContractNumber_08 { get; set; }
        string ReferenceNumber_09 { get; set; }
        string AcknowledgmentDate_10 { get; set; }
        string PurchaseOrderChangeRequestDate_11 { get; set; }
        string Date_12 { get; set; }
        string PurchaseOrderTypeCode_13 { get; set; }
    }
    
    public interface I_BCH
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string PurchaseOrderTypeCode_02 { get; set; }
        string PurchaseOrderNumber_03 { get; set; }
        string ReleaseNumber_04 { get; set; }
        string ChangeOrderSequenceNumber_05 { get; set; }
        string PurchaseOrderDate_06 { get; set; }
        string RequestReferenceNumber_07 { get; set; }
        string ContractNumber_08 { get; set; }
        string ReferenceNumber_09 { get; set; }
        string AcknowledgmentDate_10 { get; set; }
        string PurchaseOrderChangeRequestDate_11 { get; set; }
    }
    
    public interface I_BCT
    {
        
        string CatalogPurposeCode_01 { get; set; }
        string CatalogNumber_02 { get; set; }
        string CatalogVersionNumber_03 { get; set; }
        string CatalogRevisionNumber_04 { get; set; }
        string UnitofMeasurementCode_05 { get; set; }
        string CatalogNumber_06 { get; set; }
        string CatalogVersionNumber_07 { get; set; }
        string CatalogRevisionNumber_08 { get; set; }
        string Description_09 { get; set; }
        string TransactionSetPurposeCode_10 { get; set; }
    }
    
    public interface I_BEG
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string PurchaseOrderTypeCode_02 { get; set; }
        string PurchaseOrderNumber_03 { get; set; }
        string ReleaseNumber_04 { get; set; }
        string PurchaseOrderDate_05 { get; set; }
        string ContractNumber_06 { get; set; }
        string AcknowledgmentType_07 { get; set; }
    }
    
    public interface I_BFR
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string ReferenceNumber_02 { get; set; }
        string ReleaseNumber_03 { get; set; }
        string ScheduleTypeQualifier_04 { get; set; }
        string ScheduleQuantityQualifier_05 { get; set; }
        string Date_06 { get; set; }
        string Date_07 { get; set; }
        string Date_08 { get; set; }
        string Date_09 { get; set; }
        string ContractNumber_10 { get; set; }
        string PurchaseOrderNumber_11 { get; set; }
    }
    
    public interface I_BGN
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string ReferenceNumber_02 { get; set; }
        string Date_03 { get; set; }
        string Time_04 { get; set; }
        string TimeCode_05 { get; set; }
    }
    
    public interface I_BIA
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string ReportTypeCode_02 { get; set; }
        string ReferenceNumber_03 { get; set; }
        string Date_04 { get; set; }
        string Time_05 { get; set; }
    }
    
    public interface I_BIG
    {
        
        string InvoiceDate_01 { get; set; }
        string InvoiceNumber_02 { get; set; }
        string PurchaseOrderDate_03 { get; set; }
        string PurchaseOrderNumber_04 { get; set; }
        string ReleaseNumber_05 { get; set; }
        string ChangeOrderSequenceNumber_06 { get; set; }
        string TransactionTypeCode_07 { get; set; }
    }
    
    public interface I_BMG
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string Description_02 { get; set; }
    }
    
    public interface I_BNX
    {
        
        string ShipmentWeightCode_01 { get; set; }
        string ReferencedPatternIdentifier_02 { get; set; }
        string BillingCode_03 { get; set; }
    }
    
    public interface I_BOS
    {
        
        string StatementNumber_01 { get; set; }
        string Date_02 { get; set; }
        string AssociationQualifierCode_03 { get; set; }
        string StatementFormatCode_04 { get; set; }
        string TransactionTypeCode_05 { get; set; }
    }
    
    public interface I_BPA
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string Date_02 { get; set; }
        string ReferenceNumberQualifier_03 { get; set; }
        string ReferenceNumber_04 { get; set; }
        string Time_05 { get; set; }
    }
    
    public interface I_BPS
    {
        
        string PaymentMethodCode_01 { get; set; }
        string MonetaryAmount_02 { get; set; }
        string TransactionHandlingCode_03 { get; set; }
        string DFIIDNumberQualifier_04 { get; set; }
        string DFIIdentificationNumber_05 { get; set; }
        string AccountNumber_06 { get; set; }
        string OriginatingCompanyIDNumber_07 { get; set; }
        string OriginatingCompanySupplementalCode_08 { get; set; }
        string DFIIDNumberQualifier_09 { get; set; }
        string DFIIdentificationNumber_10 { get; set; }
        string AccountNumber_11 { get; set; }
        string EffectiveEntryDate_12 { get; set; }
        string SettlementDate_13 { get; set; }
    }
    
    public interface I_BPT
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string ReferenceNumber_02 { get; set; }
        string Date_03 { get; set; }
        string ReportTypeCode_04 { get; set; }
        string PriceMultiplierQualifier_05 { get; set; }
        string Multiplier_06 { get; set; }
    }
    
    public interface I_BQR
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string RequestforQuoteReferenceNumber_02 { get; set; }
        string RequestQuotationControlDate_03 { get; set; }
        string DateTimeQualifier_04 { get; set; }
        string Date_05 { get; set; }
        string BidTypeResponseCode_06 { get; set; }
    }
    
    public interface I_BQT
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string RequestforQuoteReferenceNumber_02 { get; set; }
        string RequestQuotationControlDate_03 { get; set; }
        string DateTimeQualifier_04 { get; set; }
        string Date_05 { get; set; }
        string PurchaseOrderTypeCode_06 { get; set; }
        string RequestforQuoteTypeCode_07 { get; set; }
    }
    
    public interface I_BRA
    {
        
        string ReferenceNumber_01 { get; set; }
        string Date_02 { get; set; }
        string TransactionSetPurposeCode_03 { get; set; }
        string ReceivingAdviceTypeCode_04 { get; set; }
    }
    
    public interface I_BRC
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string Date_02 { get; set; }
        string ReferenceNumberQualifier_03 { get; set; }
        string ReferenceNumber_04 { get; set; }
        string Time_05 { get; set; }
    }
    
    public interface I_BSI
    {
        
        string ReferenceNumber_01 { get; set; }
        string Date_02 { get; set; }
        string OrderItemCode_03 { get; set; }
        string ProductDateCode_04 { get; set; }
        string LocationCode_05 { get; set; }
        string Time_06 { get; set; }
    }
    
    public interface I_BSN
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string ShipmentIdentification_02 { get; set; }
        string Date_03 { get; set; }
        string Time_04 { get; set; }
    }
    
    public interface I_BSR
    {
        
        string StatusReportCode_01 { get; set; }
        string OrderItemCode_02 { get; set; }
        string ReferenceNumber_03 { get; set; }
        string Date_04 { get; set; }
        string ProductDateCode_05 { get; set; }
        string LocationCode_06 { get; set; }
        string Time_07 { get; set; }
        string ReferenceNumber_08 { get; set; }
        string Date_09 { get; set; }
        string Time_10 { get; set; }
    }
    
    public interface I_BSS
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string ReferenceNumber_02 { get; set; }
        string Date_03 { get; set; }
        string ScheduleTypeQualifier_04 { get; set; }
        string Date_05 { get; set; }
        string Date_06 { get; set; }
        string ReleaseNumber_07 { get; set; }
        string ReferenceNumber_08 { get; set; }
        string ContractNumber_09 { get; set; }
        string PurchaseOrderNumber_10 { get; set; }
        string ScheduleQuantityQualifier_11 { get; set; }
    }
    
    public interface I_BTR
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string Date_02 { get; set; }
        string Time_03 { get; set; }
        string ReportTypeCode_04 { get; set; }
        string ReferenceNumber_05 { get; set; }
        string ReferenceNumber_06 { get; set; }
    }
    
    public interface I_BX
    {
        
        string TransactionSetPurposeCode_01 { get; set; }
        string TransportationMethodCode_02 { get; set; }
        string ShipmentMethodofPayment_03 { get; set; }
        string ShipmentIdentificationNumber_04 { get; set; }
        string StandardCarrierAlphaCode_05 { get; set; }
        string WeightUnitQualifier_06 { get; set; }
        string ShipmentQualifier_07 { get; set; }
        string SectionSevenCode_08 { get; set; }
        string CapacityLoadCode_09 { get; set; }
        string StatusReportRequestCode_10 { get; set; }
        string CustomsDocumentationHandlingCode_11 { get; set; }
        string ConfidentialBillingRequestCode_12 { get; set; }
    }
    
    public interface I_C3
    {
        
        string CurrencyCode_01 { get; set; }
        string ExchangeRate_02 { get; set; }
        string CurrencyCode_03 { get; set; }
    }
    
    public interface I_CAD
    {
        
        string TransportationMethodCode_01 { get; set; }
        string EquipmentInitial_02 { get; set; }
        string EquipmentNumber_03 { get; set; }
        string StandardCarrierAlphaCode_04 { get; set; }
        string Routing_05 { get; set; }
        string ShipmentOrderStatusCode_06 { get; set; }
        string ReferenceNumberQualifier_07 { get; set; }
        string ReferenceNumber_08 { get; set; }
    }
    
    public interface I_CID
    {
        
        string MeasurementQualifier_01 { get; set; }
        string ProductProcessCharacteristicCode_02 { get; set; }
        string ItemDescriptionQualifier_03 { get; set; }
        string ProductDescriptionCode_04 { get; set; }
        string Description_05 { get; set; }
    }
    
    public interface I_CLD
    {
        
        string NumberofLoads_01 { get; set; }
        string NumberofUnitsShipped_02 { get; set; }
        string PackagingCode_03 { get; set; }
        string Size_04 { get; set; }
        string UnitofMeasurementCode_05 { get; set; }
    }
    
    public interface I_CON
    {
        
        string ReferenceNumberQualifier_01 { get; set; }
        string ReferenceNumber_02 { get; set; }
        string ContractStatusCode_03 { get; set; }
    }
    
    public interface I_CSH
    {
        
        string BackOrderCode_01 { get; set; }
        string DoNotExceedActionCode_02 { get; set; }
        string DoNotExceedAmount_03 { get; set; }
        string AccountNumber_04 { get; set; }
        string RequiredInvoiceDate_05 { get; set; }
        string AssociationQualifierCode_06 { get; set; }
        string SpecialServicesCode_07 { get; set; }
    }
    
    public interface I_CST
    {
        
        string CostCode_01 { get; set; }
        string MonetaryAmount_02 { get; set; }
        string UnitofMeasurementCode_03 { get; set; }
        string Quantity_04 { get; set; }
    }
    
    public interface I_CTB
    {
        
        string RestrictionQualifier_01 { get; set; }
        string Description_02 { get; set; }
        string QuantityQualifier_03 { get; set; }
        string Quantity_04 { get; set; }
    }
    
    public interface I_CTP
    {
        
        string ClassofTradeCode_01 { get; set; }
        string PriceQualifier_02 { get; set; }
        string UnitPrice_03 { get; set; }
        string Quantity_04 { get; set; }
        string UnitofMeasurementCode_05 { get; set; }
        string PriceMultiplierQualifier_06 { get; set; }
        string Multiplier_07 { get; set; }
    }
    
    public interface I_CTT
    {
        
        string NumberofLineItems_01 { get; set; }
        string HashTotal_02 { get; set; }
        string Weight_03 { get; set; }
        string UnitofMeasurementCode_04 { get; set; }
        string Volume_05 { get; set; }
        string UnitofMeasurementCode_06 { get; set; }
        string Description_07 { get; set; }
    }
    
    public interface I_CUR
    {
        
        string EntityIdentifierCode_01 { get; set; }
        string CurrencyCode_02 { get; set; }
        string ExchangeRate_03 { get; set; }
        string EntityIdentifierCode_04 { get; set; }
        string CurrencyCode_05 { get; set; }
        string CurrencyMarketExchangeCode_06 { get; set; }
        string DateTimeQualifier_07 { get; set; }
        string Date_08 { get; set; }
        string Time_09 { get; set; }
        string DateTimeQualifier_10 { get; set; }
        string Date_11 { get; set; }
        string Time_12 { get; set; }
        string DateTimeQualifier_13 { get; set; }
        string Date_14 { get; set; }
        string Time_15 { get; set; }
        string DateTimeQualifier_16 { get; set; }
        string Date_17 { get; set; }
        string Time_18 { get; set; }
        string DateTimeQualifier_19 { get; set; }
        string Date_20 { get; set; }
        string Time_21 { get; set; }
    }
    
    public interface I_D9
    {
        
        string FreightStationAccountingCode_01 { get; set; }
        string DestinationStation_02 { get; set; }
        string StateorProvinceCode_03 { get; set; }
        string CountryCode_04 { get; set; }
        string BilledAtStationCode_05 { get; set; }
        string CityName_06 { get; set; }
        string StateorProvinceCode_07 { get; set; }
        string StandardPointLocationCode_08 { get; set; }
        string PostalCode_09 { get; set; }
    }
    
    public interface I_DEP
    {
        
        string ReferenceNumber_01 { get; set; }
        string Date_02 { get; set; }
        string Time_03 { get; set; }
        string ReferenceNumber_04 { get; set; }
        string DFIIDNumberQualifier_05 { get; set; }
        string DFIIdentificationNumber_06 { get; set; }
        string AccountNumberQualifierCode_07 { get; set; }
        string AccountNumber_08 { get; set; }
    }
    
    public interface I_DIS
    {
        
        string DiscountTermsTypeCode_01 { get; set; }
        string DiscountBaseQualifier_02 { get; set; }
        string DiscountBaseValue_03 { get; set; }
        string DiscountControlLimitQualifier_04 { get; set; }
        string LowerDiscountControlLimit_05 { get; set; }
        string UpperDiscountControlLimit_06 { get; set; }
    }
    
    public interface I_DTM
    {
        
        string DateTimeQualifier_01 { get; set; }
        string Date_02 { get; set; }
        string Time_03 { get; set; }
        string TimeCode_04 { get; set; }
    }
    
    public interface I_E1
    {
        
        string NameCharacterFormat_01 { get; set; }
        string IdentificationCodeQualifier_02 { get; set; }
        string IdentificationCode_03 { get; set; }
    }
    
    public interface I_E4
    {
        
        string CityName_01 { get; set; }
        string StateorProvinceCode_02 { get; set; }
        string PostalCode_03 { get; set; }
        string CountryCode_04 { get; set; }
    }
    
    public interface I_E5
    {
        
        string StandardCarrierAlphaCode_01 { get; set; }
        string RoutingSequenceCode_02 { get; set; }
        string CityName_03 { get; set; }
        string StandardPointLocationCode_04 { get; set; }
    }
    
    public interface I_ETD
    {
        
        string ExcessTransportationReasonCode_01 { get; set; }
        string ExcessTransportationResponsibilityCode_02 { get; set; }
        string ReferenceNumberQualifier_03 { get; set; }
        string ReferenceNumber_04 { get; set; }
        string ReturnableContainerFreightPaymentResponsibilityCode_05 { get; set; }
    }
    
    public interface I_F9
    {
        
        string FreightStationAccountingCode_01 { get; set; }
        string OriginStation_02 { get; set; }
        string StateorProvinceCode_03 { get; set; }
        string CountryCode_04 { get; set; }
        string BilledAtStationCode_05 { get; set; }
        string CityName_06 { get; set; }
        string StateorProvinceCode_07 { get; set; }
        string StandardPointLocationCode_08 { get; set; }
        string PostalCode_09 { get; set; }
    }
    
    public interface I_FIR
    {
        
        string FinancialTransactionCode_01 { get; set; }
        string MonetaryAmount_02 { get; set; }
        string Quantity_03 { get; set; }
        string Quantity_04 { get; set; }
        string FinancialInformationTypeCode_05 { get; set; }
        string CreditDebitFlagCode_06 { get; set; }
        string Date_07 { get; set; }
        string Time_08 { get; set; }
        string TimeCode_09 { get; set; }
        string CurrencyCode_10 { get; set; }
    }
    
    public interface I_FOB
    {
        
        string ShipmentMethodofPayment_01 { get; set; }
        string LocationQualifier_02 { get; set; }
        string Description_03 { get; set; }
        string TransportationTermsQualifierCode_04 { get; set; }
        string TransportationTermsCode_05 { get; set; }
        string LocationQualifier_06 { get; set; }
        string Description_07 { get; set; }
        string RiskofLossQualifier_08 { get; set; }
        string Description_09 { get; set; }
    }
    
    public interface I_FST
    {
        
        string Quantity_01 { get; set; }
        string ForecastQualifier_02 { get; set; }
        string ForecastTimingQualifier_03 { get; set; }
        string Date_04 { get; set; }
        string Date_05 { get; set; }
        string DateTimeQualifier_06 { get; set; }
        string Time_07 { get; set; }
        string ReferenceNumberQualifier_08 { get; set; }
        string ReferenceNumber_09 { get; set; }
    }
    
    public interface I_G62
    {
        
        string DateQualifier_01 { get; set; }
        string Date_02 { get; set; }
        string TimeQualifier_03 { get; set; }
        string Time_04 { get; set; }
    }
    
    public interface I_GA
    {
        
        string CommodityCodeQualifier_01 { get; set; }
        string CommodityCode_02 { get; set; }
        string WeightQualifier_03 { get; set; }
        string ReferenceNumberQualifier_04 { get; set; }
        string ReferenceNumber_05 { get; set; }
        string Week_06 { get; set; }
        string UnloadTerminal_07 { get; set; }
        string Date_08 { get; set; }
        string IncentiveGrainRateIndicator_09 { get; set; }
    }
    
    public interface I_H1
    {
        
        string HazardousMaterialCode_01 { get; set; }
        string HazardousMaterialClassCode_02 { get; set; }
        string HazardousMaterialCodeQualifier_03 { get; set; }
        string HazardousMaterialDescription_04 { get; set; }
        string HazardousMaterialContact_05 { get; set; }
        string HazardousMaterialsPage_06 { get; set; }
        string FlashpointTemperature_07 { get; set; }
        string UnitofMeasurementCode_08 { get; set; }
    }
    
    public interface I_H2
    {
        
        string HazardousMaterialDescription_01 { get; set; }
        string HazardousMaterialClassification_02 { get; set; }
    }
    
    public interface I_H3
    {
        
        string SpecialHandlingCode_01 { get; set; }
        string SpecialHandlingDescription_02 { get; set; }
        string ProtectiveServiceCode_03 { get; set; }
        string VentInstructionCode_04 { get; set; }
        string TariffApplicationCode_05 { get; set; }
    }
    
    public interface I_H6
    {
        
        string SpecialServicesCode_01 { get; set; }
        string SpecialServicesCode_02 { get; set; }
        string QuantityofPalletsShipped_03 { get; set; }
        string PalletExchangeCode_04 { get; set; }
        string Weight_05 { get; set; }
        string WeightUnitQualifier_06 { get; set; }
    }
    
    public interface I_HL
    {
        
        string HierarchicalIDNumber_01 { get; set; }
        string HierarchicalParentIDNumber_02 { get; set; }
        string HierarchicalLevelCode_03 { get; set; }
        string HierarchicalChildCode_04 { get; set; }
    }
    
    public interface I_IC
    {
        
        string EquipmentInitial_01 { get; set; }
        string EquipmentNumber_02 { get; set; }
        string TareWeight_03 { get; set; }
        string TareQualifierCode_04 { get; set; }
        string EquipmentOwnerCode_05 { get; set; }
        string EquipmentLength_06 { get; set; }
    }
    
    public interface I_ISR
    {
        
        string ShipmentOrderStatusCode_01 { get; set; }
        string Date_02 { get; set; }
        string StatusReasonCode_03 { get; set; }
    }
    
    public interface I_ISS
    {
        
        string NumberofUnitsShipped_01 { get; set; }
        string UnitofMeasurementCode_02 { get; set; }
        string Weight_03 { get; set; }
        string UnitofMeasurementCode_04 { get; set; }
        string Volume_05 { get; set; }
        string UnitofMeasurementCode_06 { get; set; }
    }
    
    public interface I_IT1
    {
        
        string AssignedIdentification_01 { get; set; }
        string QuantityInvoiced_02 { get; set; }
        string UnitofMeasurementCode_03 { get; set; }
        string UnitPrice_04 { get; set; }
        string BasisofUnitPriceCode_05 { get; set; }
        string ProductServiceIDQualifier_06 { get; set; }
        string ProductServiceID_07 { get; set; }
        string ProductServiceIDQualifier_08 { get; set; }
        string ProductServiceID_09 { get; set; }
        string ProductServiceIDQualifier_10 { get; set; }
        string ProductServiceID_11 { get; set; }
        string ProductServiceIDQualifier_12 { get; set; }
        string ProductServiceID_13 { get; set; }
        string ProductServiceIDQualifier_14 { get; set; }
        string ProductServiceID_15 { get; set; }
        string ProductServiceIDQualifier_16 { get; set; }
        string ProductServiceID_17 { get; set; }
        string ProductServiceIDQualifier_18 { get; set; }
        string ProductServiceID_19 { get; set; }
        string ProductServiceIDQualifier_20 { get; set; }
        string ProductServiceID_21 { get; set; }
        string ProductServiceIDQualifier_22 { get; set; }
        string ProductServiceID_23 { get; set; }
        string ProductServiceIDQualifier_24 { get; set; }
        string ProductServiceID_25 { get; set; }
    }
    
    public interface I_IT3
    {
        
        string NumberofUnitsShipped_01 { get; set; }
        string UnitofMeasurementCode_02 { get; set; }
        string ShipmentOrderStatusCode_03 { get; set; }
        string QuantityDifference_04 { get; set; }
        string ChangeReasonCode_05 { get; set; }
    }
    
    public interface I_IT8
    {
        
        string BackOrderCode_01 { get; set; }
        string DoNotExceedActionCode_02 { get; set; }
        string DoNotExceedAmount_03 { get; set; }
        string AccountNumber_04 { get; set; }
        string RequiredInvoiceDate_05 { get; set; }
        string AssociationQualifierCode_06 { get; set; }
        string ProductServiceSubstitutionCode_07 { get; set; }
        string ProductServiceIDQualifier_08 { get; set; }
        string ProductServiceID_09 { get; set; }
        string ProductServiceIDQualifier_10 { get; set; }
        string ProductServiceID_11 { get; set; }
        string ProductServiceIDQualifier_12 { get; set; }
        string ProductServiceID_13 { get; set; }
        string ProductServiceIDQualifier_14 { get; set; }
        string ProductServiceID_15 { get; set; }
        string ProductServiceIDQualifier_16 { get; set; }
        string ProductServiceID_17 { get; set; }
        string ProductServiceIDQualifier_18 { get; set; }
        string ProductServiceID_19 { get; set; }
        string ProductServiceIDQualifier_20 { get; set; }
        string ProductServiceID_21 { get; set; }
        string ProductServiceIDQualifier_22 { get; set; }
        string ProductServiceID_23 { get; set; }
        string ProductServiceIDQualifier_24 { get; set; }
        string ProductServiceID_25 { get; set; }
        string ProductServiceIDQualifier_26 { get; set; }
        string ProductServiceID_27 { get; set; }
    }
    
    public interface I_ITA
    {
        
        string AllowanceorChargeIndicator_01 { get; set; }
        string AssociationQualifierCode_02 { get; set; }
        string SpecialServicesCode_03 { get; set; }
        string AllowanceorChargeMethodofHandlingCode_04 { get; set; }
        string AllowanceorChargeNumber_05 { get; set; }
        string AllowanceorChargeRate_06 { get; set; }
        string AllowanceorChargeTotalAmount_07 { get; set; }
        string AllowanceChargePercentQualifier_08 { get; set; }
        string AllowanceorChargePercent_09 { get; set; }
        string AllowanceorChargeQuantity_10 { get; set; }
        string UnitofMeasurementCode_11 { get; set; }
        string Quantity_12 { get; set; }
        string Description_13 { get; set; }
        string SpecialChargeCode_14 { get; set; }
    }
    
    public interface I_ITD
    {
        
        string TermsTypeCode_01 { get; set; }
        string TermsBasisDateCode_02 { get; set; }
        string TermsDiscountPercent_03 { get; set; }
        string TermsDiscountDueDate_04 { get; set; }
        string TermsDiscountDaysDue_05 { get; set; }
        string TermsNetDueDate_06 { get; set; }
        string TermsNetDays_07 { get; set; }
        string TermsDiscountAmount_08 { get; set; }
        string TermsDeferredDueDate_09 { get; set; }
        string DeferredAmountDue_10 { get; set; }
        string PercentofInvoicePayable_11 { get; set; }
        string Description_12 { get; set; }
        string DayofMonth_13 { get; set; }
    }
    
    public interface I_JID
    {
        
        string ProductServiceIDQualifier_01 { get; set; }
        string ProductServiceID_02 { get; set; }
        string Quantity_03 { get; set; }
        string UnitofMeasurementCode_04 { get; set; }
        string ProductServiceConditionCode_05 { get; set; }
        string MonetaryAmount_06 { get; set; }
    }
    
    public interface I_JIL
    {
        
        string ProductServiceIDQualifier_01 { get; set; }
        string ProductServiceID_02 { get; set; }
        string MonetaryAmount_03 { get; set; }
        string ReferenceNumberQualifier_04 { get; set; }
        string ReferenceNumber_05 { get; set; }
        string Date_06 { get; set; }
    }
    
    public interface I_JIT
    {
        
        string Quantity_01 { get; set; }
        string Time_02 { get; set; }
    }
    
    public interface I_L0
    {
        
        string LadingLineItemNumber_01 { get; set; }
        string BilledRateasQuantity_02 { get; set; }
        string BilledRatedasQualifier_03 { get; set; }
        string Weight_04 { get; set; }
        string WeightQualifier_05 { get; set; }
        string Volume_06 { get; set; }
        string VolumeUnitQualifier_07 { get; set; }
        string LadingQuantity_08 { get; set; }
        string LadingQuantityQualifier_09 { get; set; }
        string DunnageDescription_10 { get; set; }
        string WeightUnitQualifier_11 { get; set; }
    }
    
    public interface I_L1
    {
        
        string LadingLineItemNumber_01 { get; set; }
        string FreightRate_02 { get; set; }
        string RateValueQualifier_03 { get; set; }
        string Charge_04 { get; set; }
        string Advances_05 { get; set; }
        string PrepaidAmount_06 { get; set; }
        string RateCombinationPointCode_07 { get; set; }
        string SpecialChargeCode_08 { get; set; }
        string RateClassCode_09 { get; set; }
        string EntitlementCode_10 { get; set; }
        string ChargeMethodofPayment_11 { get; set; }
        string SpecialChargeDescription_12 { get; set; }
        string TariffApplicationCode_13 { get; set; }
        string DeclaredValue_14 { get; set; }
        string RateValueQualifier_15 { get; set; }
        string LadingLiabilityCode_16 { get; set; }
    }
    
    public interface I_L3
    {
        
        string Weight_01 { get; set; }
        string WeightQualifier_02 { get; set; }
        string FreightRate_03 { get; set; }
        string RateValueQualifier_04 { get; set; }
        string Charge_05 { get; set; }
        string Advances_06 { get; set; }
        string PrepaidAmount_07 { get; set; }
        string SpecialChargeCode_08 { get; set; }
        string Volume_09 { get; set; }
        string VolumeUnitQualifier_10 { get; set; }
        string LadingQuantity_11 { get; set; }
        string WeightUnitQualifier_12 { get; set; }
        string TariffNumber_13 { get; set; }
        string DeclaredValue_14 { get; set; }
        string RateValueQualifier_15 { get; set; }
    }
    
    public interface I_L4
    {
        
        string Length_01 { get; set; }
        string Width_02 { get; set; }
        string Height_03 { get; set; }
        string MeasurementUnitQualifier_04 { get; set; }
        string Quantity_05 { get; set; }
    }
    
    public interface I_L5
    {
        
        string LadingLineItemNumber_01 { get; set; }
        string LadingDescription_02 { get; set; }
        string CommodityCode_03 { get; set; }
        string CommodityCodeQualifier_04 { get; set; }
        string PackagingCode_05 { get; set; }
        string MarksandNumbers_06 { get; set; }
        string MarksandNumbersQualifier_07 { get; set; }
    }
    
    public interface I_L7
    {
        
        string LadingLineItemNumber_01 { get; set; }
        string TariffAgencyCode_02 { get; set; }
        string TariffNumber_03 { get; set; }
        string TariffSection_04 { get; set; }
        string TariffItemNumber_05 { get; set; }
        string TariffItemPart_06 { get; set; }
        string FreightClassCode_07 { get; set; }
        string TariffSupplementIdentifier_08 { get; set; }
        string ExParte_09 { get; set; }
        string EffectiveDate_10 { get; set; }
        string RateBasisNumber_11 { get; set; }
        string TariffColumn_12 { get; set; }
        string TariffDistance_13 { get; set; }
        string DistanceQualifier_14 { get; set; }
        string CityName_15 { get; set; }
        string StateorProvinceCode_16 { get; set; }
    }
    
    public interface I_LDT
    {
        
        string LeadTimeCode_01 { get; set; }
        string Quantity_02 { get; set; }
        string UnitofTimePeriodCode_03 { get; set; }
        string Date_04 { get; set; }
    }
    
    public interface I_LE
    {
        
        string LoopIdentifierCode_01 { get; set; }
    }
    
    public interface I_LH
    {
        
        string LadingLineItemNumber_01 { get; set; }
        string HazardousMnemonicCode_02 { get; set; }
        string ReferenceNumber_03 { get; set; }
        string ReferenceNumberQualifier_04 { get; set; }
        string ReportableQuantityCode_05 { get; set; }
        string LimitedQuantityIndicationCode_06 { get; set; }
    }
    
    public interface I_LIN
    {
        
        string AssignedIdentification_01 { get; set; }
        string ProductServiceIDQualifier_02 { get; set; }
        string ProductServiceID_03 { get; set; }
        string ProductServiceIDQualifier_04 { get; set; }
        string ProductServiceID_05 { get; set; }
        string ProductServiceIDQualifier_06 { get; set; }
        string ProductServiceID_07 { get; set; }
        string ProductServiceIDQualifier_08 { get; set; }
        string ProductServiceID_09 { get; set; }
        string ProductServiceIDQualifier_10 { get; set; }
        string ProductServiceID_11 { get; set; }
        string ProductServiceIDQualifier_12 { get; set; }
        string ProductServiceID_13 { get; set; }
        string ProductServiceIDQualifier_14 { get; set; }
        string ProductServiceID_15 { get; set; }
        string ProductServiceIDQualifier_16 { get; set; }
        string ProductServiceID_17 { get; set; }
        string ProductServiceIDQualifier_18 { get; set; }
        string ProductServiceID_19 { get; set; }
        string ProductServiceIDQualifier_20 { get; set; }
        string ProductServiceID_21 { get; set; }
        string ProductServiceIDQualifier_22 { get; set; }
        string ProductServiceID_23 { get; set; }
        string ProductServiceIDQualifier_24 { get; set; }
        string ProductServiceID_25 { get; set; }
        string ProductServiceIDQualifier_26 { get; set; }
        string ProductServiceID_27 { get; set; }
        string ProductServiceIDQualifier_28 { get; set; }
        string ProductServiceID_29 { get; set; }
        string ProductServiceIDQualifier_30 { get; set; }
        string ProductServiceID_31 { get; set; }
    }
    
    public interface I_LS
    {
        
        string LoopIdentifierCode_01 { get; set; }
    }
    
    public interface I_LX
    {
        
        string AssignedNumber_01 { get; set; }
    }
    
    public interface I_M1
    {
        
        string CountryCode_01 { get; set; }
        string CarriageValue_02 { get; set; }
        string DeclaredValue_03 { get; set; }
        string RateValueQualifier_04 { get; set; }
        string EntityIdentifierCode_05 { get; set; }
        string FreeFormMessage_06 { get; set; }
    }
    
    public interface I_M2
    {
        
        string SalesTermsCode_01 { get; set; }
        string SalesReferenceNumber_02 { get; set; }
        string SalesReferenceDate_03 { get; set; }
        string TransportationTermsCode_04 { get; set; }
        string SalesComment_05 { get; set; }
        string DeliveryDate_06 { get; set; }
    }
    
    public interface I_M3
    {
        
        string ReleaseCode_01 { get; set; }
        string Date_02 { get; set; }
        string Time_03 { get; set; }
    }
    
    public interface I_M7
    {
        
        string SealNumber_01 { get; set; }
        string SealNumber_02 { get; set; }
        string SealNumber_03 { get; set; }
        string SealNumber_04 { get; set; }
    }
    
    public interface I_MAN
    {
        
        string MarksandNumbersQualifier_01 { get; set; }
        string MarksandNumbers_02 { get; set; }
    }
    
    public interface I_MEA
    {
        
        string MeasurementReferenceIDCode_01 { get; set; }
        string MeasurementQualifier_02 { get; set; }
        string MeasurementValue_03 { get; set; }
        string UnitofMeasurementCode_04 { get; set; }
        string RangeMinimum_05 { get; set; }
        string RangeMaximum_06 { get; set; }
        string MeasurementSignificanceCode_07 { get; set; }
        string MeasurementAttributeCode_08 { get; set; }
        string SurfaceLayerPositionCode_09 { get; set; }
    }
    
    public interface I_MIT
    {
        
        string ReferenceNumber_01 { get; set; }
        string Description_02 { get; set; }
        string PageWidth_03 { get; set; }
        string PageLengthLines_04 { get; set; }
    }
    
    public interface I_MSG
    {
        
        string FreeFormMessageText_01 { get; set; }
        string PrinterCarriageControlCode_02 { get; set; }
    }
    
    public interface I_N1
    {
        
        string EntityIdentifierCode_01 { get; set; }
        string Name_02 { get; set; }
        string IdentificationCodeQualifier_03 { get; set; }
        string IdentificationCode_04 { get; set; }
    }
    
    public interface I_N2
    {
        
        string Name_01 { get; set; }
        string Name_02 { get; set; }
    }
    
    public interface I_N3
    {
        
        string AddressInformation_01 { get; set; }
        string AddressInformation_02 { get; set; }
    }
    
    public interface I_N4
    {
        
        string CityName_01 { get; set; }
        string StateorProvinceCode_02 { get; set; }
        string PostalCode_03 { get; set; }
        string CountryCode_04 { get; set; }
        string LocationQualifier_05 { get; set; }
        string LocationIdentifier_06 { get; set; }
    }
    
    public interface I_N5
    {
        
        string EquipmentLength_01 { get; set; }
        string WeightCapacity_02 { get; set; }
        string CubicCapacity_03 { get; set; }
        string MechanicalCarCode_04 { get; set; }
        string MetricQualifier_05 { get; set; }
        string Height_06 { get; set; }
        string LadingPercentage_07 { get; set; }
        string LadingPercentQualifier_08 { get; set; }
        string EquipmentDescriptionCode_09 { get; set; }
    }
    
    public interface I_N7
    {
        
        string EquipmentInitial_01 { get; set; }
        string EquipmentNumber_02 { get; set; }
        string Weight_03 { get; set; }
        string WeightQualifier_04 { get; set; }
        string TareWeight_05 { get; set; }
        string WeightAllowance_06 { get; set; }
        string Dunnage_07 { get; set; }
        string Volume_08 { get; set; }
        string VolumeUnitQualifier_09 { get; set; }
        string OwnershipCode_10 { get; set; }
        string EquipmentDescriptionCode_11 { get; set; }
        string EquipmentOwnerCode_12 { get; set; }
        string TemperatureControl_13 { get; set; }
        string Position_14 { get; set; }
        string EquipmentLength_15 { get; set; }
        string TareQualifierCode_16 { get; set; }
        string WeightUnitQualifier_17 { get; set; }
        string EquipmentNumberCheckDigit_18 { get; set; }
        string TypeofServiceCode_19 { get; set; }
        string Height_20 { get; set; }
        string Width_21 { get; set; }
        string ContainerSizeTypeCode_22 { get; set; }
    }
    
    public interface I_N9
    {
        
        string ReferenceNumberQualifier_01 { get; set; }
        string ReferenceNumber_02 { get; set; }
        string FreeformDescription_03 { get; set; }
        string Date_04 { get; set; }
        string Time_05 { get; set; }
    }
    
    public interface I_NA
    {
        
        string ReferenceNumberQualifier_01 { get; set; }
        string ReferenceNumber_02 { get; set; }
        string EquipmentInitial_03 { get; set; }
        string EquipmentNumber_04 { get; set; }
        string CrossReferenceTypeCode_05 { get; set; }
        string Position_06 { get; set; }
    }
    
    public interface I_NTE
    {
        
        string NoteReferenceCode_01 { get; set; }
        string FreeFormMessage_02 { get; set; }
    }
    
    public interface I_PAD
    {
        
        string AssignedIdentification_01 { get; set; }
        string ProductTransferTypeCode_02 { get; set; }
        string LineItemChangeorResponseType_03 { get; set; }
        string PriceMultiplierQualifier_04 { get; set; }
        string Multiplier_05 { get; set; }
    }
    
    public interface I_PER
    {
        
        string ContactFunctionCode_01 { get; set; }
        string Name_02 { get; set; }
        string CommunicationNumberQualifier_03 { get; set; }
        string CommunicationNumber_04 { get; set; }
    }
    
    public interface I_PID
    {
        
        string ItemDescriptionType_01 { get; set; }
        string ProductProcessCharacteristicCode_02 { get; set; }
        string ItemDescriptionQualifier_03 { get; set; }
        string ProductDescriptionCode_04 { get; set; }
        string Description_05 { get; set; }
        string SurfaceLayerPositionCode_06 { get; set; }
    }
    
    public interface I_PKG
    {
        
        string ItemDescriptionType_01 { get; set; }
        string PackagingCharacteristicCode_02 { get; set; }
        string ItemDescriptionQualifier_03 { get; set; }
        string PackagingDescriptionCode_04 { get; set; }
        string Description_05 { get; set; }
    }
    
    public interface I_PO1
    {
        
        string AssignedIdentification_01 { get; set; }
        string QuantityOrdered_02 { get; set; }
        string UnitofMeasurementCode_03 { get; set; }
        string UnitPrice_04 { get; set; }
        string BasisofUnitPriceCode_05 { get; set; }
        string ProductServiceIDQualifier_06 { get; set; }
        string ProductServiceID_07 { get; set; }
        string ProductServiceIDQualifier_08 { get; set; }
        string ProductServiceID_09 { get; set; }
        string ProductServiceIDQualifier_10 { get; set; }
        string ProductServiceID_11 { get; set; }
        string ProductServiceIDQualifier_12 { get; set; }
        string ProductServiceID_13 { get; set; }
        string ProductServiceIDQualifier_14 { get; set; }
        string ProductServiceID_15 { get; set; }
        string ProductServiceIDQualifier_16 { get; set; }
        string ProductServiceID_17 { get; set; }
        string ProductServiceIDQualifier_18 { get; set; }
        string ProductServiceID_19 { get; set; }
        string ProductServiceIDQualifier_20 { get; set; }
        string ProductServiceID_21 { get; set; }
        string ProductServiceIDQualifier_22 { get; set; }
        string ProductServiceID_23 { get; set; }
        string ProductServiceIDQualifier_24 { get; set; }
        string ProductServiceID_25 { get; set; }
    }
    
    public interface I_PO3
    {
        
        string ChangeReasonCode_01 { get; set; }
        string Date_02 { get; set; }
        string PriceQualifier_03 { get; set; }
        string UnitPrice_04 { get; set; }
        string BasisofUnitPriceCode_05 { get; set; }
        string Quantity_06 { get; set; }
        string UnitofMeasurementCode_07 { get; set; }
        string Description_08 { get; set; }
    }
    
    public interface I_PO4
    {
        
        string Pack_01 { get; set; }
        string Size_02 { get; set; }
        string UnitofMeasurementCode_03 { get; set; }
        string PackagingCode_04 { get; set; }
        string WeightQualifier_05 { get; set; }
        string GrossWeightperPack_06 { get; set; }
        string UnitofMeasurementCode_07 { get; set; }
        string GrossVolumeperPack_08 { get; set; }
        string UnitofMeasurementCode_09 { get; set; }
        string Length_10 { get; set; }
        string Width_11 { get; set; }
        string Height_12 { get; set; }
        string UnitofMeasurementCode_13 { get; set; }
    }
    
    public interface I_POC
    {
        
        string AssignedIdentification_01 { get; set; }
        string LineItemChangeorResponseType_02 { get; set; }
        string QuantityOrdered_03 { get; set; }
        string QuantityLefttoReceive_04 { get; set; }
        string UnitofMeasurementCode_05 { get; set; }
        string UnitPrice_06 { get; set; }
        string BasisofUnitPriceCode_07 { get; set; }
        string ProductServiceIDQualifier_08 { get; set; }
        string ProductServiceID_09 { get; set; }
        string ProductServiceIDQualifier_10 { get; set; }
        string ProductServiceID_11 { get; set; }
        string ProductServiceIDQualifier_12 { get; set; }
        string ProductServiceID_13 { get; set; }
        string ProductServiceIDQualifier_14 { get; set; }
        string ProductServiceID_15 { get; set; }
        string ProductServiceIDQualifier_16 { get; set; }
        string ProductServiceID_17 { get; set; }
        string ProductServiceIDQualifier_18 { get; set; }
        string ProductServiceID_19 { get; set; }
        string ProductServiceIDQualifier_20 { get; set; }
        string ProductServiceID_21 { get; set; }
        string ProductServiceIDQualifier_22 { get; set; }
        string ProductServiceID_23 { get; set; }
        string ProductServiceIDQualifier_24 { get; set; }
        string ProductServiceID_25 { get; set; }
        string ProductServiceIDQualifier_26 { get; set; }
        string ProductServiceID_27 { get; set; }
    }
    
    public interface I_PRF
    {
        
        string PurchaseOrderNumber_01 { get; set; }
        string ReleaseNumber_02 { get; set; }
        string ChangeOrderSequenceNumber_03 { get; set; }
        string PurchaseOrderDate_04 { get; set; }
        string AssignedIdentification_05 { get; set; }
        string ContractNumber_06 { get; set; }
    }
    
    public interface I_PRS
    {
        
        string PartReleaseStatusCode_01 { get; set; }
        string Description_02 { get; set; }
    }
    
    public interface I_PSA
    {
        
        string IdentificationCodeQualifier_01 { get; set; }
        string IdentificationCode_02 { get; set; }
        string OwnersShare_03 { get; set; }
        string MonetaryAmount_04 { get; set; }
    }
    
    public interface I_PSD
    {
        
        string SampleProcessStatusCode_01 { get; set; }
        string SampleSelectionMethodCode_02 { get; set; }
        string SampleFrequencyValueperUnitofMeasurementCode_03 { get; set; }
        string UnitofMeasurementCode_04 { get; set; }
        string SampleDescriptionCode_05 { get; set; }
        string SampleDirectionCode_06 { get; set; }
        string SampleLocationCode_07 { get; set; }
    }
    
    public interface I_PTD
    {
        
        string ProductTransferTypeCode_01 { get; set; }
        string PriceMultiplierQualifier_02 { get; set; }
        string Multiplier_03 { get; set; }
        string ReferenceNumberQualifier_04 { get; set; }
        string ReferenceNumber_05 { get; set; }
        string ProductTransferMovementTypeCode_06 { get; set; }
    }
    
    public interface I_PWK
    {
        
        string ReportTypeCode_01 { get; set; }
        string ReportTransmissionCode_02 { get; set; }
        string ReportCopiesNeeded_03 { get; set; }
        string EntityIdentifierCode_04 { get; set; }
        string IdentificationCodeQualifier_05 { get; set; }
        string IdentificationCode_06 { get; set; }
        string Description_07 { get; set; }
    }
    
    public interface I_QTY
    {
        
        string QuantityQualifier_01 { get; set; }
        string Quantity_02 { get; set; }
        string UnitofMeasurementCode_03 { get; set; }
    }
    
    public interface I_R1
    {
        
        string StandardCarrierAlphaCode_01 { get; set; }
        string StandardCarrierAlphaCode_02 { get; set; }
        string AirportCode_03 { get; set; }
        string AirCarrierCode_04 { get; set; }
        string AirportCode_05 { get; set; }
        string AirCarrierCode_06 { get; set; }
        string AirportCode_07 { get; set; }
        string AirCarrierCode_08 { get; set; }
        string AirportCode_09 { get; set; }
        string AirCarrierCode_10 { get; set; }
        string AirportCode_11 { get; set; }
        string AirCarrierCode_12 { get; set; }
        string AirportCode_13 { get; set; }
    }
    
    public interface I_R2
    {
        
        string StandardCarrierAlphaCode_01 { get; set; }
        string RoutingSequenceCode_02 { get; set; }
        string CityName_03 { get; set; }
        string StandardPointLocationCode_04 { get; set; }
        string TOFCIntermodalCodeQualifier_05 { get; set; }
        string TransportationMethodCode_06 { get; set; }
        string IntermediateSwitchCarrier_07 { get; set; }
        string IntermediateSwitchCarrier_08 { get; set; }
        string InvoiceNumber_09 { get; set; }
        string BillingDate_10 { get; set; }
        string FreeformDescription_11 { get; set; }
        string TypeofServiceCode_12 { get; set; }
        string RouteDescription_13 { get; set; }
    }
    
    public interface I_R4
    {
        
        string PortFunctionCode_01 { get; set; }
        string LocationQualifier_02 { get; set; }
        string LocationIdentifier_03 { get; set; }
        string PortName_04 { get; set; }
        string CountryCode_05 { get; set; }
        string TerminalName_06 { get; set; }
        string PierNumber_07 { get; set; }
        string StateorProvinceCode_08 { get; set; }
    }
    
    public interface I_RCD
    {
        
        string AssignedIdentification_01 { get; set; }
        string QuantityUnitsReceived_02 { get; set; }
        string UnitofMeasurementCode_03 { get; set; }
        string QuantityUnitsReturned_04 { get; set; }
        string UnitofMeasurementCode_05 { get; set; }
        string QuantityinQuestion_06 { get; set; }
        string UnitofMeasurementCode_07 { get; set; }
        string ReceivingConditionCode_08 { get; set; }
        string QuantityinQuestion_09 { get; set; }
        string UnitofMeasurementCode_10 { get; set; }
        string ReceivingConditionCode_11 { get; set; }
        string QuantityinQuestion_12 { get; set; }
        string UnitofMeasurementCode_13 { get; set; }
        string ReceivingConditionCode_14 { get; set; }
        string QuantityinQuestion_15 { get; set; }
        string UnitofMeasurementCode_16 { get; set; }
        string ReceivingConditionCode_17 { get; set; }
        string QuantityinQuestion_18 { get; set; }
        string UnitofMeasurementCode_19 { get; set; }
        string ReceivingConditionCode_20 { get; set; }
    }
    
    public interface I_REF
    {
        
        string ReferenceNumberQualifier_01 { get; set; }
        string ReferenceNumber_02 { get; set; }
        string Description_03 { get; set; }
    }
    
    public interface I_RMT
    {
        
        string ReferenceNumberQualifier_01 { get; set; }
        string ReferenceNumber_02 { get; set; }
        string MonetaryAmount_03 { get; set; }
        string TotalInvoiceAmount_04 { get; set; }
        string AmountSubjecttoTermsDiscount_05 { get; set; }
        string DiscountedAmountDue_06 { get; set; }
        string DiscountAmount_07 { get; set; }
        string MonetaryAmount_08 { get; set; }
        string AdjustmentReasonCode_09 { get; set; }
        string Description_10 { get; set; }
    }
    
    public interface I_RRA
    {
        
        string InformationType_01 { get; set; }
        string ReferenceNumber_02 { get; set; }
    }
    
    public interface I_RTE
    {
        
        string InterestRate_01 { get; set; }
        string InterestRate_02 { get; set; }
        string InterestRate_03 { get; set; }
        string MonetaryAmount_04 { get; set; }
        string MonetaryAmount_05 { get; set; }
        string Date_06 { get; set; }
    }
    
    public interface I_S5
    {
        
        string StopSequenceNumber_01 { get; set; }
        string StopReasonCode_02 { get; set; }
        string Weight_03 { get; set; }
        string WeightUnitQualifier_04 { get; set; }
        string NumberofUnitsShipped_05 { get; set; }
        string UnitofMeasurementCode_06 { get; set; }
        string Volume_07 { get; set; }
        string VolumeUnitQualifier_08 { get; set; }
        string Description_09 { get; set; }
        string StandardPointLocationCode_10 { get; set; }
        string AccomplishCode_11 { get; set; }
    }
    
    public interface I_SCH
    {
        
        string Quantity_01 { get; set; }
        string UnitofMeasurementCode_02 { get; set; }
        string EntityIdentifierCode_03 { get; set; }
        string Name_04 { get; set; }
        string DateTimeQualifier_05 { get; set; }
        string Date_06 { get; set; }
        string Time_07 { get; set; }
        string DateTimeQualifier_08 { get; set; }
        string Date_09 { get; set; }
        string Time_10 { get; set; }
    }
    
    public interface I_SDP
    {
        
        string ShipDeliveryPatternCode_01 { get; set; }
        string ShipDeliveryPatternTimeCode_02 { get; set; }
        string ShipDeliveryPatternCode_03 { get; set; }
        string ShipDeliveryPatternTimeCode_04 { get; set; }
        string ShipDeliveryPatternCode_05 { get; set; }
        string ShipDeliveryPatternTimeCode_06 { get; set; }
        string ShipDeliveryPatternCode_07 { get; set; }
        string ShipDeliveryPatternTimeCode_08 { get; set; }
    }
    
    public interface I_SDQ
    {
        
        string UnitofMeasurementCode_01 { get; set; }
        string IdentificationCodeQualifier_02 { get; set; }
        string IdentificationCode_03 { get; set; }
        string Quantity_04 { get; set; }
        string IdentificationCode_05 { get; set; }
        string Quantity_06 { get; set; }
        string IdentificationCode_07 { get; set; }
        string Quantity_08 { get; set; }
        string IdentificationCode_09 { get; set; }
        string Quantity_10 { get; set; }
        string IdentificationCode_11 { get; set; }
        string Quantity_12 { get; set; }
        string IdentificationCode_13 { get; set; }
        string Quantity_14 { get; set; }
        string IdentificationCode_15 { get; set; }
        string Quantity_16 { get; set; }
        string IdentificationCode_17 { get; set; }
        string Quantity_18 { get; set; }
        string IdentificationCode_19 { get; set; }
        string Quantity_20 { get; set; }
        string IdentificationCode_21 { get; set; }
        string Quantity_22 { get; set; }
    }
    
    public interface I_SER
    {
        
        string ProductServiceIDQualifier_01 { get; set; }
        string ProductServiceID_02 { get; set; }
        string MonetaryAmount_03 { get; set; }
        string MonetaryAmount_04 { get; set; }
        string UnitPrice_05 { get; set; }
        string Quantity_06 { get; set; }
        string Description_07 { get; set; }
    }
    
    public interface I_SHH
    {
        
        string SchedulingShippingCode_01 { get; set; }
        string DateTimeQualifier_02 { get; set; }
        string Date_03 { get; set; }
        string Time_04 { get; set; }
    }
    
    public interface I_SHP
    {
        
        string QuantityQualifier_01 { get; set; }
        string Quantity_02 { get; set; }
        string DateTimeQualifier_03 { get; set; }
        string Date_04 { get; set; }
        string Time_05 { get; set; }
        string Date_06 { get; set; }
        string Time_07 { get; set; }
    }
    
    public interface I_SLN
    {
        
        string AssignedIdentification_01 { get; set; }
        string AssignedIdentification_02 { get; set; }
        string ConfigurationCode_03 { get; set; }
        string Quantity_04 { get; set; }
        string UnitofMeasurementCode_05 { get; set; }
        string UnitPrice_06 { get; set; }
        string BasisofUnitPriceCode_07 { get; set; }
        string SublinePriceChangeCodeID_08 { get; set; }
        string ProductServiceIDQualifier_09 { get; set; }
        string ProductServiceID_10 { get; set; }
        string ProductServiceIDQualifier_11 { get; set; }
        string ProductServiceID_12 { get; set; }
        string ProductServiceIDQualifier_13 { get; set; }
        string ProductServiceID_14 { get; set; }
        string ProductServiceIDQualifier_15 { get; set; }
        string ProductServiceID_16 { get; set; }
        string ProductServiceIDQualifier_17 { get; set; }
        string ProductServiceID_18 { get; set; }
        string ProductServiceIDQualifier_19 { get; set; }
        string ProductServiceID_20 { get; set; }
        string ProductServiceIDQualifier_21 { get; set; }
        string ProductServiceID_22 { get; set; }
        string ProductServiceIDQualifier_23 { get; set; }
        string ProductServiceID_24 { get; set; }
        string ProductServiceIDQualifier_25 { get; set; }
        string ProductServiceID_26 { get; set; }
        string ProductServiceIDQualifier_27 { get; set; }
        string ProductServiceID_28 { get; set; }
    }
    
    public interface I_SN1
    {
        
        string AssignedIdentification_01 { get; set; }
        string NumberofUnitsShipped_02 { get; set; }
        string UnitofMeasurementCode_03 { get; set; }
        string QuantityShippedtoDate_04 { get; set; }
        string QuantityOrdered_05 { get; set; }
        string UnitofMeasurementCode_06 { get; set; }
        string ReturnableContainerLoadMakeUpCode_07 { get; set; }
        string LineItemStatusCode_08 { get; set; }
    }
    
    public interface I_SPS
    {
        
        string PopulationSizeCount_01 { get; set; }
        string SampleSizeCount_02 { get; set; }
        string SubgroupSizeCount_03 { get; set; }
        string ConfidenceLimit_04 { get; set; }
        string SampleFrequencyCode_05 { get; set; }
        string SampleFrequencyValueperUnitofMeasurementCode_06 { get; set; }
    }
    
    public interface I_SSS
    {
        
        string AllowanceorChargeIndicator_01 { get; set; }
        string AssociationQualifierCode_02 { get; set; }
        string SpecialServicesCode_03 { get; set; }
        string ServiceMarksandNumbers_04 { get; set; }
        string AllowanceorChargeRate_05 { get; set; }
        string AllowanceorChargeTotalAmount_06 { get; set; }
        string Description_07 { get; set; }
    }
    
    public interface I_STA
    {
        
        string StatisticCode_01 { get; set; }
        string MeasurementValue_02 { get; set; }
        string UnitofMeasurementCode_03 { get; set; }
        string MeasurementQualifier_04 { get; set; }
    }
    
    public interface I_TAX
    {
        
        string TaxIdentificationNumber_01 { get; set; }
        string LocationQualifier_02 { get; set; }
        string LocationIdentifier_03 { get; set; }
        string LocationQualifier_04 { get; set; }
        string LocationIdentifier_05 { get; set; }
        string LocationQualifier_06 { get; set; }
        string LocationIdentifier_07 { get; set; }
        string LocationQualifier_08 { get; set; }
        string LocationIdentifier_09 { get; set; }
        string LocationQualifier_10 { get; set; }
        string LocationIdentifier_11 { get; set; }
        string TaxExemptCode_12 { get; set; }
    }
    
    public interface I_TD1
    {
        
        string PackagingCode_01 { get; set; }
        string LadingQuantity_02 { get; set; }
        string CommodityCodeQualifier_03 { get; set; }
        string CommodityCode_04 { get; set; }
        string LadingDescription_05 { get; set; }
        string WeightQualifier_06 { get; set; }
        string Weight_07 { get; set; }
        string UnitofMeasurementCode_08 { get; set; }
    }
    
    public interface I_TD3
    {
        
        string EquipmentDescriptionCode_01 { get; set; }
        string EquipmentInitial_02 { get; set; }
        string EquipmentNumber_03 { get; set; }
        string WeightQualifier_04 { get; set; }
        string Weight_05 { get; set; }
        string UnitofMeasurementCode_06 { get; set; }
        string OwnershipCode_07 { get; set; }
    }
    
    public interface I_TD4
    {
        
        string SpecialHandlingCode_01 { get; set; }
        string HazardousMaterialCodeQualifier_02 { get; set; }
        string HazardousMaterialClassCode_03 { get; set; }
        string Description_04 { get; set; }
    }
    
    public interface I_TD5
    {
        
        string RoutingSequenceCode_01 { get; set; }
        string IdentificationCodeQualifier_02 { get; set; }
        string IdentificationCode_03 { get; set; }
        string TransportationMethodCode_04 { get; set; }
        string Routing_05 { get; set; }
        string ShipmentOrderStatusCode_06 { get; set; }
        string LocationQualifier_07 { get; set; }
        string LocationIdentifier_08 { get; set; }
        string TransitDirectionCode_09 { get; set; }
        string TransitTimeDirectionQualifier_10 { get; set; }
        string TransitTime_11 { get; set; }
    }
    
    public interface I_TDS
    {
        
        string TotalInvoiceAmount_01 { get; set; }
        string AmountSubjecttoTermsDiscount_02 { get; set; }
        string DiscountedAmountDue_03 { get; set; }
        string TermsDiscountAmount_04 { get; set; }
    }
    
    public interface I_TMD
    {
        
        string ProductProcessCharacteristicCode_01 { get; set; }
        string ItemDescriptionQualifier_02 { get; set; }
        string ProductDescriptionCode_03 { get; set; }
        string TestAdministrationMethodCode_04 { get; set; }
        string TestMediumCode_05 { get; set; }
        string Description_06 { get; set; }
        string Date_07 { get; set; }
        string ReferenceNumber_08 { get; set; }
    }
    
    public interface I_TRN
    {
        
        string TraceTypeCode_01 { get; set; }
        string EntityIdentifierCode_02 { get; set; }
        string IdentificationCodeQualifier_03 { get; set; }
        string IdentificationCode_04 { get; set; }
        string ReferenceNumber_05 { get; set; }
        string ApplicationBatchIdentifier_06 { get; set; }
        string ApplicationItemIdentifier_07 { get; set; }
        string ReferenceNumberQualifier_08 { get; set; }
        string ReferenceNumber_09 { get; set; }
    }
    
    public interface I_TXI
    {
        
        string TaxTypeCode_01 { get; set; }
        string MonetaryAmount_02 { get; set; }
        string Percent_03 { get; set; }
        string TaxJurisdictionCodeQualifier_04 { get; set; }
        string TaxJurisdictionCode_05 { get; set; }
    }
    
    public interface I_UIT
    {
        
        string UnitofMeasurementCode_01 { get; set; }
        string UnitPrice_02 { get; set; }
        string BasisofUnitPriceCode_03 { get; set; }
    }
    
    public interface I_VC
    {
        
        string VehicleIdentificationNumber_01 { get; set; }
        string VehicleDeckPositionCode_02 { get; set; }
        string VehicleTypeCode_03 { get; set; }
        string DealerCode_04 { get; set; }
        string RouteCode_05 { get; set; }
        string BayLocation_06 { get; set; }
        string AutomotiveManufacturersCode_07 { get; set; }
        string DamageExceptionIndicator_08 { get; set; }
        string SupplementalInspectionCode_09 { get; set; }
        string FactoryCarOrderNumber_10 { get; set; }
    }
    
    public interface I_X1
    {
        
        string LicensingAgencyCode_01 { get; set; }
        string ExportLicenseNumber_02 { get; set; }
        string ExportLicenseStatusCode_03 { get; set; }
        string ExportLicenseExpirationDate_04 { get; set; }
        string ExportLicenseSymbolCode_05 { get; set; }
        string ExportLicenseControlCode_06 { get; set; }
        string CountryCode_07 { get; set; }
        string ScheduleBCode_08 { get; set; }
        string InternationalDomesticCode_09 { get; set; }
        string LadingQuantity_10 { get; set; }
        string LadingValue_11 { get; set; }
        string ExportFilingKeyCode_12 { get; set; }
        string UnitofMeasurementCode_13 { get; set; }
        string UnitPrice_14 { get; set; }
    }
    
    public interface I_X2
    {
        
        string ImportLicenseNumber_01 { get; set; }
        string ImportLicenseIssueDate_02 { get; set; }
        string ImportLicenseExpirationDate_03 { get; set; }
    }
    
    public interface I_XH
    {
        
        string CurrencyCode_01 { get; set; }
        string RelatedCompanyIndicationCode_02 { get; set; }
        string SpecialChargeCode_03 { get; set; }
        string Charge_04 { get; set; }
        string BlockCode_05 { get; set; }
        string ChemicalAnalysisPercentage_06 { get; set; }
        string UnitPrice_07 { get; set; }
    }
    
    public interface I_Y6
    {
        
        string AuthorityIdentifierCode_01 { get; set; }
        string Authority_02 { get; set; }
        string AuthorizationDate_03 { get; set; }
    }
    
    public interface I_Y7
    {
        
        string Priority_01 { get; set; }
        string PriorityCode_02 { get; set; }
        string PriorityCodeQualifier_03 { get; set; }
        string PortCallFileNumber_04 { get; set; }
        string RequiredDeliveryDate_05 { get; set; }
    }
    
    public interface I_ZC
    {
        
        string TransactionSetIdentifierCode_01 { get; set; }
        string ShipmentIdentificationNumber_02 { get; set; }
        string EquipmentInitial_03 { get; set; }
        string EquipmentNumber_04 { get; set; }
        string TransactionReferenceNumber_05 { get; set; }
        string TransactionReferenceDate_06 { get; set; }
        string CorrectionIndicator_07 { get; set; }
        string StandardCarrierAlphaCode_08 { get; set; }
    }
}
