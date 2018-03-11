using System.Security.Principal;

namespace Profile_Evalution.Services.JWT
{
    public class JwtAuthenticationIdentity : GenericIdentity
    {
        public string UserName { get; set; }
        public string UserId { get; set; }

        public JwtAuthenticationIdentity(string userName): base(userName) => UserName = userName;

    }
}