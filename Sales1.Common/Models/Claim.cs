
namespace Sales1.Common.Models
{
    public class Claim
    {
        public Claim(string givenName, string firstName)
        {
        }

        public int Id { get; set; }
        public string UserId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }
    }
}