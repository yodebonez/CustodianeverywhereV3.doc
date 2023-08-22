using CustodianEverywhere.V3.Docs.Response.Agent;

namespace CustodianEverywhere.V3.Docs.Response.PolicyService
{
    public class PolicyServiceResponse
    {
        public string message { get; set; }
        public int status { get; set; }
        public Data data { get; set; }
        public ExtraData extra_data { get; set; }
    }

    public class ExtraData
    {
    }
}
