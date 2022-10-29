using System.Security.Claims;

namespace JwtWebApiTut.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public UserService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        string IUserService.GetMyName()
        {
            var resault = string.Empty;
            if (_httpContextAccessor.HttpContext != null)
            {
                resault = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Name);
            }
            return resault;
        }
    }
}
