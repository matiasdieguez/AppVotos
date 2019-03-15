using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using AppVotos.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppVotos.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoteController : ControllerBase
    {
        // GET api/vote
        [HttpGet]
        public IActionResult Get()
        {
            var results = new List<Vote>();

            using (var connection = new SqlConnection("Server=.;Initial Catalog=AppVotos;Integrated Security=true;Connection Timeout=30;")) 
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM Votes", connection)) 
                {
                    using(var reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            var objVote = new Vote 
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                CandidateId = Convert.ToInt32(reader["CandidateId"]),
                                VotesCount = Convert.ToInt32(reader["VotesCount"]),
                                VotingTable = Convert.ToInt32(reader["VotingTable"])
                            };

                            results.Add(objVote);
                        }


                        return Ok(results);
                    }
                }
            }

        }

        // GET api/vote/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/vote
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/vote/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/vote/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
