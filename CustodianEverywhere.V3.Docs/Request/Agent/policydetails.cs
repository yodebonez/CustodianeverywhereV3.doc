namespace CustodianEverywhere.V3.Docs.Request.Agent
{
    public class policydetails
    {
        public string policy_number { get; set; }
        public string merchant_id { get; set; }
        public int subsidiary { get; set; }
        public string checksum { get; set; }
        public List<string> vehicle_regs { get; set; }
        public bool use_vehicle_reg_only { get; set; }


    }
}
