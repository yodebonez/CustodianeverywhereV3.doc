namespace CustodianEverywhere.V3.Docs.Response.Agent
{
    public class PostTransactionResponse
    {

        public int status { get; set; }
        public string message { get; set; }
        public Data data { get; set; }
        public Hash hash { get; set; }
        public Vehiclelist vehiclelist { get; set; }
    }

   
}
