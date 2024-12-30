using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZatcaInvoice
{
    //كو  متغيرات عناصر الفاتوره
    public class InvoiceItemModel
    {
       
        public string Id { get; set; }
        public string Name { get; set; }
        public string Qty { get; set; }
        public string Price { get; set; }
        public string NetValue { get; set; }
        public string TotalDiscount { get; set; }
        public string VAT { get; set; }
        public string VATPercentage { get; set; }
       
    }
   //كود متغيرات  الفاتوره كاملة قبل الارسال للزكاخ
    public class InvoiceToZatca
    {
        public Guid Id { get; set; }
        public long DetailId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyTaxNumber { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyAddressCity { get; set; }
        public string CompanyAddressDistrict { get; set; }
        public string Currency { get; set; }
        public long? InvoiceId { get; set; }
        public DateTime? InvoiceCreationDate { get; set; }
        public bool? IsSalesInvoice { get; set; }
        public bool? IsRefundInvoice { get; set; }
        public bool? IsTaxInvoice { get; set; }
        public bool? IsSimplifiedInvoice { get; set; }
        public int? CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerAddressCity { get; set; }
        public string CustomerAddressDistrict { get; set; }
        public DateTime? InvoiceDeliveryDate { get; set; }
        public string RefundReason { get; set; }
        public decimal? TotalDiscount { get; set; }
        public decimal? TaxAmount { get; set; }
        public decimal? TaxPercentage { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? TotalForItems { get; set; }
        public decimal? NetWithoutVAT { get; set; }
        public List<InvoiceItemModel> InvoiceItems { get; set; }
        //public string InvoiceItemsJson { get; set; }
        public int? InsertFlag { get; set; }
        public int? UpdateFlag { get; set; }
        public int? DeleteFlag { get; set; }
        public bool? IsDeleted { get; set; }
        public int? CreatorId { get; set; }
        public int? ModifierId { get; set; }
        public string PaymentMeans { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
        public bool IsSent { get; set; }
        public bool IsAccepted { get; set; }
        public int CountOfRetries { get; set; }
        public string CustomerIdentityNumber { get; set; }
        public string CustomerIdentityType { get; set; }
        public string CustomerAddressVatRegNumber { get; set; }
        public string CustomerAddressStreetName { get; set; }
        public string CustomerAddressBuildingNumber { get; set; }
        public string CustomerAddressZipCode { get; set; }
        public string CustomerAddressRegionName { get; set; }
        public string PreviousInvoiceHash { get; set; }
        public InvoiceTypeCode invoTypeCode { get; set; }
    }
// معداد ب انوع الفواتير حسب متطلبات هيئة الزكاه
    public enum InvoiceTypeCode
    {
        Invoice = 388,
        Debit = 383,
        Credit = 381,
        Prepayment = 386
    }
    // متغيرات الرد من هيئة الزكاه
    public class Invoice
    {
        public Guid Id { get; set; }
        public int InvoiceType { get; set;}
        public int InvoiceTypeCode { get; set;}
        public string InvoiceHash { get; set;}
        public bool ReportedToZatca { get; set;}
        public string ReportingResult { get; set;}
        public string ReportingStatus { get; set;}
        public string QrCode { get; set;}
        public string SignedXml { get; set;}
        public DateTime SubmissionDate { get; set;}
    }
}
