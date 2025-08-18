// ReSharper disable UnusedMember.Global
// CA1040: Empty interfaces are intentional as markers.
#pragma warning disable CA1040

namespace CPDI.Edi.X12.Abstractions
{
    /// <summary>Base marker for any X12 transaction set.</summary>
    public interface IX12Transaction { }

    // ---------------------------
    // Acknowledgments
    // ---------------------------
    public interface ITS997 : IX12Transaction { } // Functional Acknowledgment
    public interface ITS999 : IX12Transaction { } // Implementation Acknowledgment

    // ---------------------------
    // Purchasing / Orders
    // ---------------------------
    public interface ITS850 : IX12Transaction { } // Purchase Order
    public interface ITS855 : IX12Transaction { } // PO Acknowledgment
    public interface ITS856 : IX12Transaction { } // Ship Notice/Manifest (ASN)
    public interface ITS860 : IX12Transaction { } // PO Change Request
    public interface ITS865 : IX12Transaction { } // PO Change Acknowledgment/Request
    public interface ITS832 : IX12Transaction { } // Price/Sales Catalog
    public interface ITS846 : IX12Transaction { } // Inventory Inquiry/Advice
    public interface ITS852 : IX12Transaction { } // Product Activity
    public interface ITS853 : IX12Transaction { } // Routing and Carrier Instructions
    public interface ITS867 : IX12Transaction { } // Product Transfer and Resale

    // ---------------------------
    // Invoicing / Payments
    // ---------------------------
    public interface ITS810 : IX12Transaction { } // Invoice
    public interface ITS820 : IX12Transaction { } // Payment Order/Remittance Advice
    public interface ITS824 : IX12Transaction { } // Application Advice
    public interface ITS812 : IX12Transaction { } // Credit/Debit Adjustment
    public interface ITS864 : IX12Transaction { } // Text Message

    // ---------------------------
    // Warehouse / 3PL
    // ---------------------------
    public interface ITS940 : IX12Transaction { } // Warehouse Shipping Order
    public interface ITS943 : IX12Transaction { } // Warehouse Stock Transfer Shipment Advice
    public interface ITS944 : IX12Transaction { } // Warehouse Stock Transfer Receipt Advice
    public interface ITS945 : IX12Transaction { } // Warehouse Shipping Advice
    public interface ITS947 : IX12Transaction { } // Warehouse Inventory Adjustment Advice

    // ---------------------------
    // Transportation
    // ---------------------------
    public interface ITS204 : IX12Transaction { } // Motor Carrier Load Tender
    public interface ITS210 : IX12Transaction { } // Motor Carrier Freight Details and Invoice
    public interface ITS214 : IX12Transaction { } // Transportation Carrier Shipment Status
    public interface ITS990 : IX12Transaction { } // Response to Load Tender

    // ---------------------------
    // Healthcare / Admin (common ones)
    // ---------------------------
    public interface ITS270 : IX12Transaction { } // Eligibility, Coverage
    public interface ITS271 : IX12Transaction { } // Eligibility Response
    public interface ITS834 : IX12Transaction { } // Benefit Enrollment
    public interface ITS835 : IX12Transaction { } // Payment/Remittance
    public interface ITS837 : IX12Transaction { } // Health Care Claim

    // ---------------------------
    // Misc. Retail/Grocery
    // ---------------------------
    public interface ITS869 : IX12Transaction { } // Order Status Inquiry
    public interface ITS870 : IX12Transaction { } // Order Status Report
    public interface ITS875 : IX12Transaction { } // Grocery Products Purchase Order
    public interface ITS880 : IX12Transaction { } // Grocery Products Invoice

    /// <summary>
    /// Optional: annotate concrete template classes with version/ST (and partner if desired)
    /// to help with diagnostics and verification in tests.
    /// </summary>
    [System.AttributeUsage(System.AttributeTargets.Class, Inherited = false)]
    public sealed class X12TransactionAttribute : System.Attribute
    {
        public string Version { get; }
        public string St01 { get; }
        public string? Partner { get; }
        public X12TransactionAttribute(string version, string st01, string? partner = null)
            => (Version, St01, Partner) = (version, st01, partner);
    }
}

