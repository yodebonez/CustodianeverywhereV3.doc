using CustodianEverywhere.V3.Docs.Request.Agent;
using CustodianEverywhere.V3.Docs.Request.PolicyService;
using CustodianEverywhere.V3.Docs.Response.Agent;
using CustodianEverywhere.V3.Docs.Response.PolicyService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustodianEverywhere.V3.Docs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PolicyServicesController : ControllerBase
    {




        [HttpPost]
        [Route("SetUp")]
        public IActionResult PostTransaction(SetUp setUp)
        {
            PolicyServiceResponse policyServiceResponse = new PolicyServiceResponse();

            return Ok(policyServiceResponse);
        }



        [HttpPost]
        [Route("ValidateOtp")]
        public IActionResult PostTransaction(ValidateOtp validateOtp)
        {
            PolicyServiceResponse policyServiceResponse = new PolicyServiceResponse();

            return Ok(policyServiceResponse);
        }




        [HttpGet]
        [Route("GetPolicies")]
        public IActionResult GetPolicies(string merchant_id, string pin, string customer_id, string hash)
        {
            PolicyDetailsResponse policyDetailsResponse = new PolicyDetailsResponse();

            return Ok(policyDetailsResponse);
        }



        [HttpGet]
        [Route("ResetPin")]
        public IActionResult ResetPin(string merchant_id, string newpin, string otp, string customer_id, string hash)
        {
            PolicyDetailsResponse policyDetailsResponse = new PolicyDetailsResponse();

            return Ok(policyDetailsResponse);
        }


        [HttpGet]
        [Route("GetPoliciesDetails")]
        public IActionResult GetPoliciesDetails(string merchant_id, string source, string pin, string policynumber, string customer_id, string hash)
        {
            PolicyDetailsResponse policyDetailsResponse = new PolicyDetailsResponse();

            return Ok(policyDetailsResponse);
        }


        [HttpGet]
        [Route("GenerateOtp")]
        public IActionResult GenerateOtp(string customer_id, string merchant_id, string hash)
        {
            PolicyDetailsResponse policyDetailsResponse = new PolicyDetailsResponse();

            return Ok(policyDetailsResponse);
        }



        [HttpGet]
        [Route("GetLifeTransactions")]
        public IActionResult GetLifeTransactions(string merchant_id, string policy_number, string hash)
        {
            PolicyDetailsResponse policyDetailsResponse = new PolicyDetailsResponse();

            return Ok(policyDetailsResponse);
        }





        //POST /api/PolicyServices/Setup
    }
}
