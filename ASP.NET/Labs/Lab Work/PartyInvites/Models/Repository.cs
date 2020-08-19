using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class Repository
    {
        private static List<GuestResponse> responses = new List<GuestResponse>(); //field
        public static IEnumerable<GuestResponse> Responses => responses;//property
        public static void AddResponse(GuestResponse response)//method
        {
            responses.Add(response);//add a response to the end of the list 
        }
    }
}
