using CustodianEverywhere.V3.Docs.Request.Agent;
using CustodianEverywhere.V3.Docs.Response.Agent;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustodianEverywhere.V3.Docs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgentController : ControllerBase
    {

        //POST /api/Agent/GetPolicyDetails
        [HttpPost]
        [Route("GetPolicyDetails")]
        public IActionResult GetPolicyDetails(policydetails policydetails)
        {
            PolicyDetailsResponse policyDetailsResponse = new PolicyDetailsResponse();

            return Ok(policyDetailsResponse);
        }



        [HttpPost]
        [Route("posttransaction")]
        public IActionResult PostTransaction(PostTransaction postTransaction)
        {
            PolicyDetailsResponse policyDetailsResponse = new PolicyDetailsResponse();

            return Ok(policyDetailsResponse);
        }


        //GET /api/Agent/GetTransactionWithReferenceNumber


        [HttpGet]
        [Route("GetTransactionWithReferenceNumber")]
        public IActionResult GetTransactionWithReferenceNumber(string reference_no, string merchant_id , string checksum)
        {
            PolicyDetailsResponse policyDetailsResponse = new PolicyDetailsResponse();

            return Ok(policyDetailsResponse);
        }

        //POST /api/Agent/SetupAgent

        [HttpPost]
        [Route("SetUpAgent")]
        public IActionResult SetUpAgent(AgentModel agentModel)
        {
            PolicyDetailsResponse policyDetailsResponse = new PolicyDetailsResponse();

            return Ok(policyDetailsResponse);
        }

        //GET /api/Agent/ResetAgentPIN


        [HttpPost]
        [Route("ResetAgentPIN")]
        public IActionResult ResetAgentPIN(AgentModel agentModel)
        {
            PolicyDetailsResponse policyDetailsResponse = new PolicyDetailsResponse();

            return Ok(policyDetailsResponse);
        }



    }
}
