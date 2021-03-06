namespace CPRentManagement.API.Dtos
{
    public class UserLoginResponseDto
    {
        public bool IsAuthenticationSuccessful { get; set; }
        public string ErrorMessage { get; set; }
        public string DisplayName { get; set; }
        public string UserName { get; set; }
        public string Token { get; set; }
    }
}
