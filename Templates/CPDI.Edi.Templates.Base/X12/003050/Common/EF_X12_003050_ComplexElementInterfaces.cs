namespace EdiFabric.Templates.X12003050
{


    public interface I_C001
    {

        string UnitorBasisforMeasurementCode_01 { get; set; }
        string Exponent_02 { get; set; }
        string Multiplier_03 { get; set; }
        string UnitorBasisforMeasurementCode_04 { get; set; }
        string Exponent_05 { get; set; }
        string Multiplier_06 { get; set; }
        string UnitorBasisforMeasurementCode_07 { get; set; }
        string Exponent_08 { get; set; }
        string Multiplier_09 { get; set; }
        string UnitorBasisforMeasurementCode_10 { get; set; }
        string Exponent_11 { get; set; }
        string Multiplier_12 { get; set; }
        string UnitorBasisforMeasurementCode_13 { get; set; }
        string Exponent_14 { get; set; }
        string Multiplier_15 { get; set; }
    }

    public interface I_C002
    {

        string PaperworkReportActionCode_01 { get; set; }
        string PaperworkReportActionCode_02 { get; set; }
        string PaperworkReportActionCode_03 { get; set; }
        string PaperworkReportActionCode_04 { get; set; }
        string PaperworkReportActionCode_05 { get; set; }
    }

    public interface I_C003
    {

        string ProductServiceIDQualifier_01 { get; set; }
        string ProductServiceID_02 { get; set; }
        string ProcedureModifier_03 { get; set; }
        string ProcedureModifier_04 { get; set; }
        string ProcedureModifier_05 { get; set; }
        string ProcedureModifier_06 { get; set; }
        string Description_07 { get; set; }
    }

    public interface I_C004
    {

        string DiagnosisCodePointer_01 { get; set; }
        string DiagnosisCodePointer_02 { get; set; }
        string DiagnosisCodePointer_03 { get; set; }
        string DiagnosisCodePointer_04 { get; set; }
    }

    public interface I_C005
    {

        string ToothSurfaceCode_01 { get; set; }
        string ToothSurfaceCode_02 { get; set; }
        string ToothSurfaceCode_03 { get; set; }
        string ToothSurfaceCode_04 { get; set; }
        string ToothSurfaceCode_05 { get; set; }
    }

    public interface I_C006
    {

        string OralCavityDesignationCode_01 { get; set; }
        string OralCavityDesignationCode_02 { get; set; }
        string OralCavityDesignationCode_03 { get; set; }
        string OralCavityDesignationCode_04 { get; set; }
        string OralCavityDesignationCode_05 { get; set; }
    }

    public interface I_C022
    {

        string CodeListQualifierCode_01 { get; set; }
        string IndustryCode_02 { get; set; }
        string DateTimePeriodFormatQualifier_03 { get; set; }
        string DateTimePeriod_04 { get; set; }
        string MonetaryAmount_05 { get; set; }
        string Quantity_06 { get; set; }
    }

    public interface I_C023
    {

        string FacilityCodeValue_01 { get; set; }
        string FacilityCodeQualifier_02 { get; set; }
        string ClaimFrequencyTypeCode_03 { get; set; }
    }

    public interface I_C024
    {

        string RelatedCausesCode_01 { get; set; }
        string RelatedCausesCode_02 { get; set; }
        string RelatedCausesCode_03 { get; set; }
        string StateorProvinceCode_04 { get; set; }
        string CountryCode_05 { get; set; }
    }

    public interface I_C030
    {

        string ElementPositioninSegment_01 { get; set; }
        string ComponentDataElementPositioninComposite_02 { get; set; }
    }
}
