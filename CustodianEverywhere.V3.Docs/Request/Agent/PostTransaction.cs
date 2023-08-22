namespace CustodianEverywhere.V3.Docs.Request.Agent
{
    public class PostTransaction
    {
        public string policy_number { get; set; }
        public int subsidiary { get; set; }
        public string payment_narrtn { get; set; }
        public string reference_no { get; set; }
        public string biz_unit { get; set; }
        public int premium { get; set; }
        public string merchant_id { get; set; }
        public string description { get; set; }
        public string issured_name { get; set; }
        public string phone_no { get; set; }
        public string email_address { get; set; }
        public string checksum { get; set; }
        public string status { get; set; }
        public string vehicle_reg_no { get; set; }
    }
}
