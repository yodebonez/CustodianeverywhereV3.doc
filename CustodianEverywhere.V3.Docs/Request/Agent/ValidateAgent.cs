namespace CustodianEverywhere.V3.Docs.Request.Agent
{
    public class ValidateAgent
    {
        public string merchant_id { get; set; }
        public string validationValue { get; set; }
        public string otp { get; set; }
        public string hash { get; set; }
        public string pin { get; set; }
        public string agent_ref_id { get; set; }
        public string validationKey { get; set; }
    }
}
