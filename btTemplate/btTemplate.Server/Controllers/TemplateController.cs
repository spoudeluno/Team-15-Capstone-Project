using Microsoft.AspNetCore.Mvc;
using System.IO;

/*using btTemplate.Server.TemplateModels;*/
using btTemplate.Server.ProposalCompleteModel;
using HandlebarsDotNet;
using Newtonsoft.Json;


// Uncomment ConfigureProposal and using btTemplate.Server.TemplateModels; to make the milestone 1 running and
// make sure to Comment using btTemplate.Server.ProposalCompleteModel; and getProposal to make the milestone 1 running 
namespace btTemplate.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TemplateController : ControllerBase
    {
        private readonly ILogger<TemplateController> _logger;

        public TemplateController(ILogger<TemplateController> logger)
        {
            _logger = logger;
        }
        
        /*// A POST request to create a configured proposal
        [HttpPost]
        [Route("/ConfigureProposal")]
        public string ConfigureProposal(Proposal proposal)
        {
            Console.WriteLine("Proposal: " + proposal);
            if (proposal == null) 
            {
                return "Bad request, proposal is null.";
            }

            try
            {
                var proposalString = System.IO.File.ReadAllText("/Users/dreamxia/git/Team-15-Capstone-Project/btTemplate/btTemplate.Server/HandlebarTemplates/proposal.handlebars");
                var proposalTemplate = Handlebars.Compile(proposalString);

                var result = proposalTemplate(proposal);
                Console.WriteLine("RESULT: " + result);
                return result;
            }
            catch (Exception ex) 
            {
                return "Server error:\n"
                    + ex.Message 
                    + ex.StackTrace;
            }
        }*/

        // A GET request to return a created proposal with a given proposalID
        // A GET request to return a created proposal templete


        [HttpGet]
        [Route("/getProposal")]
        public string getProposal()
        {
            try
            {
                var serializer = new JsonSerializer();
                var proposalString = System.IO.File.ReadAllText("./HandlebarTemplates/proposal.handlebars");
                var proposalTemplate = Handlebars.Compile(proposalString);

                using StreamReader reader = new("../btTemplate.Server/UNO Sample Proposal API Response.json");
                var json = reader.ReadToEnd();
                Proposal proposal = JsonConvert.DeserializeObject<Proposal>(json);

                /*Console.WriteLine(proposal);*/


                var result = proposalTemplate(proposal);

                /*Console.WriteLine("RESULT: " + result);*/
                return result;
            }
            catch (Exception ex)
            {
                return "Server error:\n"
                    + ex.Message
                    + ex.StackTrace;
            }
        }
    }
}
