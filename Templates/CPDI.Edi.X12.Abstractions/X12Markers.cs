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

    // ---------------------------
    // Other
    // ---------------------------

    public interface ITS100 : IX12Transaction { }
    public interface ITS101 : IX12Transaction { }
    public interface ITS102 : IX12Transaction { }
    public interface ITS103 : IX12Transaction { }
    public interface ITS104 : IX12Transaction { }
    public interface ITS105 : IX12Transaction { }
    public interface ITS106 : IX12Transaction { }
    public interface ITS107 : IX12Transaction { }
    public interface ITS108 : IX12Transaction { }
    public interface ITS109 : IX12Transaction { }
    public interface ITS110 : IX12Transaction { }
    public interface ITS111 : IX12Transaction { }
    public interface ITS112 : IX12Transaction { }
    public interface ITS113 : IX12Transaction { }
    public interface ITS120 : IX12Transaction { }
    public interface ITS121 : IX12Transaction { }
    public interface ITS124 : IX12Transaction { }
    public interface ITS125 : IX12Transaction { }
    public interface ITS126 : IX12Transaction { }
    public interface ITS127 : IX12Transaction { }
    public interface ITS128 : IX12Transaction { }
    public interface ITS129 : IX12Transaction { }
    public interface ITS130 : IX12Transaction { }
    public interface ITS131 : IX12Transaction { }
    public interface ITS132 : IX12Transaction { }
    public interface ITS133 : IX12Transaction { }
    public interface ITS135 : IX12Transaction { }
    public interface ITS138 : IX12Transaction { }
    public interface ITS139 : IX12Transaction { }
    public interface ITS140 : IX12Transaction { }
    public interface ITS141 : IX12Transaction { }
    public interface ITS142 : IX12Transaction { }
    public interface ITS143 : IX12Transaction { }
    public interface ITS144 : IX12Transaction { }
    public interface ITS146 : IX12Transaction { }
    public interface ITS147 : IX12Transaction { }
    public interface ITS148 : IX12Transaction { }
    public interface ITS149 : IX12Transaction { }
    public interface ITS150 : IX12Transaction { }
    public interface ITS151 : IX12Transaction { }
    public interface ITS152 : IX12Transaction { }
    public interface ITS153 : IX12Transaction { }
    public interface ITS154 : IX12Transaction { }
    public interface ITS155 : IX12Transaction { }
    public interface ITS157 : IX12Transaction { }
    public interface ITS158 : IX12Transaction { }
    public interface ITS159 : IX12Transaction { }
    public interface ITS160 : IX12Transaction { }
    public interface ITS161 : IX12Transaction { }
    public interface ITS163 : IX12Transaction { }
    public interface ITS170 : IX12Transaction { }
    public interface ITS175 : IX12Transaction { }
    public interface ITS176 : IX12Transaction { }
    public interface ITS179 : IX12Transaction { }
    public interface ITS180 : IX12Transaction { }
    public interface ITS185 : IX12Transaction { }
    public interface ITS186 : IX12Transaction { }
    public interface ITS187 : IX12Transaction { }
    public interface ITS188 : IX12Transaction { }
    public interface ITS189 : IX12Transaction { }
    public interface ITS190 : IX12Transaction { }
    public interface ITS191 : IX12Transaction { }
    public interface ITS194 : IX12Transaction { }
    public interface ITS195 : IX12Transaction { }
    public interface ITS196 : IX12Transaction { }
    public interface ITS197 : IX12Transaction { }
    public interface ITS198 : IX12Transaction { }
    public interface ITS199 : IX12Transaction { }
    public interface ITS200 : IX12Transaction { }
    public interface ITS201 : IX12Transaction { }
    public interface ITS202 : IX12Transaction { }
    public interface ITS203 : IX12Transaction { }
    public interface ITS205 : IX12Transaction { }
    public interface ITS206 : IX12Transaction { }
    public interface ITS211 : IX12Transaction { }
    public interface ITS212 : IX12Transaction { }
    public interface ITS213 : IX12Transaction { }
    public interface ITS215 : IX12Transaction { }
    public interface ITS216 : IX12Transaction { }
    public interface ITS217 : IX12Transaction { }
    public interface ITS218 : IX12Transaction { }
    public interface ITS219 : IX12Transaction { }
    public interface ITS220 : IX12Transaction { }
    public interface ITS222 : IX12Transaction { }
    public interface ITS223 : IX12Transaction { }
    public interface ITS224 : IX12Transaction { }
    public interface ITS225 : IX12Transaction { }
    public interface ITS227 : IX12Transaction { }
    public interface ITS228 : IX12Transaction { }
    public interface ITS240 : IX12Transaction { }
    public interface ITS242 : IX12Transaction { }
    public interface ITS244 : IX12Transaction { }
    public interface ITS245 : IX12Transaction { }
    public interface ITS248 : IX12Transaction { }
    public interface ITS249 : IX12Transaction { }
    public interface ITS250 : IX12Transaction { }
    public interface ITS251 : IX12Transaction { }
    public interface ITS252 : IX12Transaction { }
    public interface ITS255 : IX12Transaction { }
    public interface ITS256 : IX12Transaction { }
    public interface ITS259 : IX12Transaction { }
    public interface ITS260 : IX12Transaction { }
    public interface ITS261 : IX12Transaction { }
    public interface ITS262 : IX12Transaction { }
    public interface ITS263 : IX12Transaction { }
    public interface ITS264 : IX12Transaction { }
    public interface ITS265 : IX12Transaction { }
    public interface ITS266 : IX12Transaction { }
    public interface ITS267 : IX12Transaction { }
    public interface ITS268 : IX12Transaction { }
    public interface ITS269 : IX12Transaction { }
    public interface ITS272 : IX12Transaction { }
    public interface ITS273 : IX12Transaction { }
    public interface ITS274 : IX12Transaction { }
    public interface ITS275 : IX12Transaction { }
    public interface ITS276 : IX12Transaction { }
    public interface ITS277 : IX12Transaction { }
    public interface ITS278 : IX12Transaction { }
    public interface ITS280 : IX12Transaction { }
    public interface ITS283 : IX12Transaction { }
    public interface ITS284 : IX12Transaction { }
    public interface ITS285 : IX12Transaction { }
    public interface ITS286 : IX12Transaction { }
    public interface ITS288 : IX12Transaction { }
    public interface ITS290 : IX12Transaction { }
    public interface ITS300 : IX12Transaction { }
    public interface ITS301 : IX12Transaction { }
    public interface ITS303 : IX12Transaction { }
    public interface ITS304 : IX12Transaction { }
    public interface ITS309 : IX12Transaction { }
    public interface ITS310 : IX12Transaction { }
    public interface ITS311 : IX12Transaction { }
    public interface ITS312 : IX12Transaction { }
    public interface ITS313 : IX12Transaction { }
    public interface ITS315 : IX12Transaction { }
    public interface ITS317 : IX12Transaction { }
    public interface ITS319 : IX12Transaction { }
    public interface ITS322 : IX12Transaction { }
    public interface ITS323 : IX12Transaction { }
    public interface ITS324 : IX12Transaction { }
    public interface ITS325 : IX12Transaction { }
    public interface ITS326 : IX12Transaction { }
    public interface ITS350 : IX12Transaction { }
    public interface ITS352 : IX12Transaction { }
    public interface ITS353 : IX12Transaction { }
    public interface ITS354 : IX12Transaction { }
    public interface ITS355 : IX12Transaction { }
    public interface ITS356 : IX12Transaction { }
    public interface ITS357 : IX12Transaction { }
    public interface ITS358 : IX12Transaction { }
    public interface ITS361 : IX12Transaction { }
    public interface ITS362 : IX12Transaction { }
    public interface ITS404 : IX12Transaction { }
    public interface ITS410 : IX12Transaction { }
    public interface ITS412 : IX12Transaction { }
    public interface ITS414 : IX12Transaction { }
    public interface ITS417 : IX12Transaction { }
    public interface ITS418 : IX12Transaction { }
    public interface ITS419 : IX12Transaction { }
    public interface ITS420 : IX12Transaction { }
    public interface ITS421 : IX12Transaction { }
    public interface ITS422 : IX12Transaction { }
    public interface ITS423 : IX12Transaction { }
    public interface ITS424 : IX12Transaction { }
    public interface ITS425 : IX12Transaction { }
    public interface ITS426 : IX12Transaction { }
    public interface ITS429 : IX12Transaction { }
    public interface ITS431 : IX12Transaction { }
    public interface ITS432 : IX12Transaction { }
    public interface ITS433 : IX12Transaction { }
    public interface ITS434 : IX12Transaction { }
    public interface ITS435 : IX12Transaction { }
    public interface ITS436 : IX12Transaction { }
    public interface ITS437 : IX12Transaction { }
    public interface ITS440 : IX12Transaction { }
    public interface ITS451 : IX12Transaction { }
    public interface ITS452 : IX12Transaction { }
    public interface ITS453 : IX12Transaction { }
    public interface ITS455 : IX12Transaction { }
    public interface ITS456 : IX12Transaction { }
    public interface ITS460 : IX12Transaction { }
    public interface ITS463 : IX12Transaction { }
    public interface ITS466 : IX12Transaction { }
    public interface ITS468 : IX12Transaction { }
    public interface ITS470 : IX12Transaction { }
    public interface ITS475 : IX12Transaction { }
    public interface ITS485 : IX12Transaction { }
    public interface ITS486 : IX12Transaction { }
    public interface ITS490 : IX12Transaction { }
    public interface ITS492 : IX12Transaction { }
    public interface ITS494 : IX12Transaction { }
    public interface ITS500 : IX12Transaction { }
    public interface ITS501 : IX12Transaction { }
    public interface ITS503 : IX12Transaction { }
    public interface ITS504 : IX12Transaction { }
    public interface ITS511 : IX12Transaction { }
    public interface ITS517 : IX12Transaction { }
    public interface ITS521 : IX12Transaction { }
    public interface ITS527 : IX12Transaction { }
    public interface ITS536 : IX12Transaction { }
    public interface ITS540 : IX12Transaction { }
    public interface ITS561 : IX12Transaction { }
    public interface ITS567 : IX12Transaction { }
    public interface ITS568 : IX12Transaction { }
    public interface ITS601 : IX12Transaction { }
    public interface ITS602 : IX12Transaction { }
    public interface ITS620 : IX12Transaction { }
    public interface ITS625 : IX12Transaction { }
    public interface ITS650 : IX12Transaction { }
    public interface ITS715 : IX12Transaction { }
    public interface ITS753 : IX12Transaction { }
    public interface ITS754 : IX12Transaction { }
    public interface ITS805 : IX12Transaction { }
    public interface ITS806 : IX12Transaction { }
    public interface ITS811 : IX12Transaction { }
    public interface ITS813 : IX12Transaction { }
    public interface ITS814 : IX12Transaction { }
    public interface ITS815 : IX12Transaction { }
    public interface ITS816 : IX12Transaction { }
    public interface ITS818 : IX12Transaction { }
    public interface ITS819 : IX12Transaction { }
    public interface ITS821 : IX12Transaction { }
    public interface ITS822 : IX12Transaction { }
    public interface ITS823 : IX12Transaction { }
    public interface ITS826 : IX12Transaction { }
    public interface ITS827 : IX12Transaction { }
    public interface ITS828 : IX12Transaction { }
    public interface ITS829 : IX12Transaction { }
    public interface ITS830 : IX12Transaction { }
    public interface ITS831 : IX12Transaction { }
    public interface ITS833 : IX12Transaction { }
    public interface ITS836 : IX12Transaction { }
    public interface ITS838 : IX12Transaction { }
    public interface ITS839 : IX12Transaction { }
    public interface ITS840 : IX12Transaction { }
    public interface ITS841 : IX12Transaction { }
    public interface ITS842 : IX12Transaction { }
    public interface ITS843 : IX12Transaction { }
    public interface ITS844 : IX12Transaction { }
    public interface ITS845 : IX12Transaction { }
    public interface ITS847 : IX12Transaction { }
    public interface ITS848 : IX12Transaction { }
    public interface ITS849 : IX12Transaction { }
    public interface ITS851 : IX12Transaction { }
    public interface ITS854 : IX12Transaction { }
    public interface ITS857 : IX12Transaction { }
    public interface ITS858 : IX12Transaction { }
    public interface ITS859 : IX12Transaction { }
    public interface ITS861 : IX12Transaction { }
    public interface ITS862 : IX12Transaction { }
    public interface ITS863 : IX12Transaction { }
    public interface ITS866 : IX12Transaction { }
    public interface ITS868 : IX12Transaction { }
    public interface ITS871 : IX12Transaction { }
    public interface ITS872 : IX12Transaction { }
    public interface ITS873 : IX12Transaction { }
    public interface ITS874 : IX12Transaction { }
    public interface ITS876 : IX12Transaction { }
    public interface ITS877 : IX12Transaction { }
    public interface ITS878 : IX12Transaction { }
    public interface ITS879 : IX12Transaction { }
    public interface ITS881 : IX12Transaction { }
    public interface ITS882 : IX12Transaction { }
    public interface ITS883 : IX12Transaction { }
    public interface ITS884 : IX12Transaction { }
    public interface ITS885 : IX12Transaction { }
    public interface ITS886 : IX12Transaction { }
    public interface ITS887 : IX12Transaction { }
    public interface ITS888 : IX12Transaction { }
    public interface ITS889 : IX12Transaction { }
    public interface ITS891 : IX12Transaction { }
    public interface ITS893 : IX12Transaction { }
    public interface ITS894 : IX12Transaction { }
    public interface ITS895 : IX12Transaction { }
    public interface ITS896 : IX12Transaction { }
    public interface ITS920 : IX12Transaction { }
    public interface ITS924 : IX12Transaction { }
    public interface ITS925 : IX12Transaction { }
    public interface ITS926 : IX12Transaction { }
    public interface ITS928 : IX12Transaction { }
    public interface ITS980 : IX12Transaction { }
    public interface ITS993 : IX12Transaction { }
    public interface ITS996 : IX12Transaction { }
    public interface ITS998 : IX12Transaction { }
}

