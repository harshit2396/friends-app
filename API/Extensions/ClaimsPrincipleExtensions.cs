using System.Security.Claims;
namespace API.Extensions
{
    public static class ClaimsPrincipleExtensions
    {
        public static string GetUsername(this ClaimsPrincipal user)
        {
            var claimsIdentity = user.Identity as System.Security.Claims.ClaimsIdentity;
            var username = claimsIdentity.Name;
            return username;
        }

        public static int GetUserId(this ClaimsPrincipal user)
        {
            var claimsIdentity = user.Identity as System.Security.Claims.ClaimsIdentity;
            var username = user.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            return int.Parse(user.FindFirst(ClaimTypes.NameIdentifier)?.Value);
        }
    }
}
    