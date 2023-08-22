namespace CustodianEverywhere.V3.Docs.Request.PolicyService
{
    public class ValidateOtp
    {
        public string merchant_id { get; set; }
        public string email { get; set; }
        public string otp { get; set; }
        public string hash { get; set; }
        public string pin { get; set; }
        public string customerid { get; set; }
    }
}
