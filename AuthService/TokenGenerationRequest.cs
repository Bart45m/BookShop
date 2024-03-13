using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using System.Text.Json;

namespace AuthService
{
    public class TokenGenerationRequest
    {
        public string UserId { get; set; }

        public string Email { get; set; }

        public int Role {  get; set; }
    }
}
