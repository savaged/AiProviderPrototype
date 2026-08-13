using Savaged.Data.AiProvider.API.Interfaces;

namespace Savaged.Data.AiProvider.API.Models;

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Root
    {
        public string result { get; set; }
        public string request_id { get; set; }
        public Data data { get; set; }
    }

    public class Data
    {
        public Components components { get; set; }
        public string data_source { get; set; }
        public string version { get; set; }
    }

    public class Components
    {
        public AmountDetails amount_details { get; set; }
        public object barcode { get; set; }
        public object chain_liability { get; set; }
        public DateDetails date_details { get; set; }
        public DocumentClassification document_classification { get; set; }
        public object document_country_code { get; set; }
        public object document_language { get; set; }
        public Financial financial { get; set; }
        public object hash { get; set; }
        public object healthcare_details { get; set; }
        public object keyword_matching { get; set; }
        public LineItems line_items { get; set; }
        public object ocr { get; set; }
        public PaymentDetails payment_details { get; set; }
        public object project_code { get; set; }
        public ReferenceDetails reference_details { get; set; }
        public object transport_details { get; set; }
        public object travel_details { get; set; }
        public CustomFields custom_fields { get; set; }
        public RelationAddress relation_address { get; set; }
        public RelationDetails relation_details { get; set; }
        public object relation_matching { get; set; }
        public object line_item_matching { get; set; }
        public object matched_data_sources { get; set; }
    }

    public class Financial
    {
        public object candidates { get; set; }
        public string currency { get; set; }
        public Customer customer { get; set; }
        public DateTime document_date { get; set; }
        public string invoice_number { get; set; }
        public Merchant merchant { get; set; }
        public TaxDetails tax_details { get; set; }
        public double total_amount { get; set; }
    }

    public class Merchant
    {
        public string brand_name { get; set; }
        public object candidates { get; set; }
        public object company_name { get; set; }
        public Components components { get; set; }
    }

    public class Customer
    {
        public object candidates { get; set; }
        public string company_name { get; set; }
        public Components components { get; set; }
        public object delivery_name { get; set; }
        public object person { get; set; }
    }

    public class LineItems
    {
        public List<LineItemSection> line_item_sections { get; set; }
    }

    public class LineItemSection
    {
        public List<Item> items { get; set; }
    }

    public class Item
    {
        public double amount { get; set; }
        public double amount_excl_vat { get; set; }
        public double amount_incl_vat { get; set; }
        public object code { get; set; }
        public int percentage { get; set; }
        public string type { get; set; }
        public double amount_each { get; set; }
        public double amount_each_ex_vat { get; set; }
        public double amount_ex_vat { get; set; }
        public int amount_sub_total { get; set; }
        public object candidates { get; set; }
        public int commission { get; set; }
        public Components components { get; set; }
        public string country_of_origin { get; set; }
        public bool credit { get; set; }
        public string currency { get; set; }
        public string date { get; set; }
        public string description { get; set; }
        public int discount_amount { get; set; }
        public string discount_code { get; set; }
        public int discount_percentage { get; set; }
        public string ean { get; set; }
        public string end_date { get; set; }
        public int gross_weight { get; set; }
        public string hs_code { get; set; }
        public string line_number { get; set; }
        public object matched_purchase_order { get; set; }
        public int net_weight { get; set; }
        public string order_number { get; set; }
        public string period { get; set; }
        public string product_type { get; set; }
        public int quantity { get; set; }
        public string sku { get; set; }
        public string time { get; set; }
        public string title { get; set; }
        public string unit_of_measurement { get; set; }
        public double vat_amount { get; set; }
        public string vat_code { get; set; }
        public int vat_percentage { get; set; }
    }

    public class LineItemDescription
    {
        public string From_date { get; set; }
        public string line_item { get; set; }
        public string service_type { get; set; }
        public string to_date { get; set; }
    }

    public class AmountDetails
    {
        public object amount_change { get; set; }
        public object amount_shipping { get; set; }
        public object amount_tip { get; set; }
        public object candidates { get; set; }
        public List<object> discounts { get; set; }
        public object payment_description { get; set; }
        public List<Payment> payments { get; set; }
    }

    public class Address
    {
        public object candidates { get; set; }
        public string city { get; set; }
        public object context { get; set; }
        public string country { get; set; }
        public string country_code { get; set; }
        public object house_number { get; set; }
        public object municipality { get; set; }
        public object post_box { get; set; }
        public string postal_code { get; set; }
        public object province { get; set; }
        public string raw_address { get; set; }
        public object state { get; set; }
        public string street_name { get; set; }
    }

    public class CocNumber
    {
        public string country_code { get; set; }
        public string value { get; set; }
        public object verifications { get; set; }
    }

    public class CustomFields
    {
        public Prompt prompt { get; set; }
    }

    public class DateDetails
    {
        public object candidates { get; set; }
        public object date_of_service_end { get; set; }
        public object date_of_service_start { get; set; }
        public object delivery_date { get; set; }
        public object payment_due_date { get; set; }
    }

    public class DocumentClassification
    {
        public object candidates { get; set; }
        public List<Value> value { get; set; }
    }

    public class Payment
    {
        public object amount { get; set; }
        public object method { get; set; }
    }

    public class PaymentDetails
    {
        public object auth_code { get; set; }
        public object candidates { get; set; }
        public object card_account_number { get; set; }
        public object card_issuer { get; set; }
        public object card_number { get; set; }
        public object payment_reference { get; set; }
        public object payment_slip { get; set; }
        public object terminal_number { get; set; }
    }

    public class Prompt
    {
        public List<LineItemDescription> Line_item_description { get; set; }
    }

    public class ReferenceDetails
    {
        public object candidates { get; set; }
        public object credit_note_number { get; set; }
        public object customer_number { get; set; }
        public string order_number { get; set; }
        public object purchase_order_number { get; set; }
        public object shop_number { get; set; }
        public object transaction_number { get; set; }
    }

    public class RelationAddress
    {
        public List<Address> addresses { get; set; }
        public object candidates { get; set; }
    }

    public class RelationDetails
    {
        public object activity_code { get; set; }
        public object bank { get; set; }
        public object candidates { get; set; }
        public object coc_number { get; set; }
        public object email { get; set; }
        public object eori_number { get; set; }
        public object fiscal_number { get; set; }
        public object phone { get; set; }
        public object vat_number { get; set; }
        public object website { get; set; }
    }

    public class TaxDetails
    {
        public object candidates { get; set; }
        public List<Item> items { get; set; }
    }

    public class Value
    {
        public string classification { get; set; }
        public double confidence { get; set; }
        public string type { get; set; }
    }

    public class VatNumber
    {
        public string country_code { get; set; }
        public string standardized_value { get; set; }
        public string value { get; set; }
        public object verifications { get; set; }
    }

