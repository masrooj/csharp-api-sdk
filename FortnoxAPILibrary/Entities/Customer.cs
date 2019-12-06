using System;
using System.ComponentModel;
using FortnoxAPILibrary.Connectors;

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming

namespace FortnoxAPILibrary.Entities
{
    /// <remarks/>
	public class Customer
	{
		/// <remarks/>
		public string Active { get; set; }

		/// <remarks/>
		public string Address1 { get; set; }

        /// <remarks/>
        public string Address2 { get; set; }

        /// <remarks/>
        public string City { get; set; }

        /// <summary>This field is Read-Only in Fortnox</summary>
		public string Country { get; private set; }

        /// <remarks/>
        public string Comments { get; set; }

        /// <remarks/>
        public string Currency { get; set; }

        /// <remarks/>
        public string CostCenter { get; set; }

        /// <remarks/>
        public string CountryCode { get; set; }

        /// <remarks/>
        public string CustomerNumber { get; set; }

        /// <remarks/>
        public InvoiceDefaultDeliveryTypes DefaultDeliveryTypes { get; set; }

        /// <remarks/>
        public InvoiceDefaultTemplates DefaultTemplates { get; set; }

        /// <remarks/>
        public string DeliveryAddress1 { get; set; }

        /// <remarks/>
        public string DeliveryAddress2 { get; set; }

        /// <remarks/>
        public string DeliveryCity { get; set; }

        /// <summary>This field is Read-Only in Fortnox</summary>
		public string DeliveryCountry { get; private set; }

        /// <remarks/>
        public string DeliveryCountryCode { get; set; }

        /// <remarks/>
        public string DeliveryFax { get; set; }

        /// <remarks/>
        public string DeliveryName { get; set; }

        /// <remarks/>
        public string DeliveryPhone1 { get; set; }

        /// <remarks/>
        public string DeliveryPhone2 { get; set; }

        /// <remarks/>
        public string DeliveryZipCode { get; set; }

        /// <remarks/>
        public string Email { get; set; }

        /// <remarks/>
        public string EmailInvoice { get; set; }

        /// <remarks/>
        public string EmailInvoiceBCC { get; set; }

        /// <remarks/>
        public string EmailInvoiceCC { get; set; }
        /// <remarks/>
        public string EmailOffer { get; set; }

        /// <remarks/>
        public string EmailOfferBCC { get; set; }

        /// <remarks/>
        public string EmailOfferCC { get; set; }

        /// <remarks/>
        public string EmailOrder { get; set; }

        /// <remarks/>
        public string EmailOrderBCC { get; set; }

        /// <remarks/>
        public string EmailOrderCC { get; set; }

        /// <remarks/>
        public string Fax { get; set; }

        /// <remarks/>
        public string GLN { get; set; }

        /// <remarks/>
        public string GLNDelivery { get; set; }

        /// <remarks/>
        public string InvoiceAdministrationFee { get; set; }

        /// <remarks/>
        public string InvoiceDiscount { get; set; }

        /// <remarks/>
        public string InvoiceFreight { get; set; }

        /// <remarks/>
        public string InvoiceRemark { get; set; }

        /// <remarks/>
        public string Name { get; set; }

        /// <remarks/>
        public string OrganisationNumber { get; set; }

        /// <remarks/>
        public string OurReference { get; set; }

        /// <remarks/>
        public string Phone1 { get; set; }

        /// <remarks/>
        public string Phone2 { get; set; }

        /// <remarks/>
        public string PriceList { get; set; }

        /// <remarks/>
        public string Project { get; set; }

        /// <remarks/>
        public string SalesAccount { get; set; }

        /// <remarks/>
        public string ShowPriceVATIncluded { get; set; }

        /// <remarks/>
        public string TermsOfDelivery { get; set; }

        /// <remarks/>
        public string TermsOfPayment { get; set; }

        /// <remarks/>
        public CustomerConnector.Type? Type { get; set; }
        public bool TypeSpecified => Type != null;

		/// <remarks/>
		public string VATNumber { get; set; }

        /// <remarks/>
        public CustomerConnector.VATType? VATType { get; set; }
        public bool VATTypeSpecified => VATType != null;

        /// <remarks/>
        public string VisitingAddress { get; set; }

        /// <remarks/>
        public string VisitingCity { get; set; }

        /// <summary>This field is Read-Only in Fortnox</summary>
		public string VisitingCountry { get; private set; }

        /// <summary>This field is Read-Only in Fortnox</summary>
        public string VisitingCountryCode { get; private set; }

        /// <remarks/>
        public string VisitingZipCode { get; set; }

        /// <remarks/>
        public string WayOfDelivery { get; set; }

        /// <remarks/>
        public string WWW { get; set; }

		/// <remarks/>
		public string YourReference { get; set; }

        /// <remarks/>
        public string ZipCode { get; set; }

        /// <summary>This field is Read-Only in Fortnox</summary>
		public string url { get; private set; }
    }

	/// <remarks/>
	public class InvoiceDefaultDeliveryTypes
	{
		/// <remarks/>
		public CustomerConnector.DefaultInvoiceDeliveryType? Invoice { get; set; }
        public bool InvoiceSpecified => Invoice != null;

        /// <remarks/>
        public CustomerConnector.DefaultOfferDeliveryType? Offer { get; set; }
        public bool OfferSpecified => Offer != null;

        /// <remarks/>
        public CustomerConnector.DefaultOrderDeliveryType? Order { get; set; }
        public bool OrderSpecified => Order != null;
    }

	/// <remarks/>
	public class InvoiceDefaultTemplates
	{
        /// <remarks/>
		public string CashInvoice { get; set; }

        /// <remarks/>
        public string Invoice { get; set; }

        /// <remarks/>
        public string Offer { get; set; }

        /// <remarks/>
        public string Order { get; set; }
    }
}
