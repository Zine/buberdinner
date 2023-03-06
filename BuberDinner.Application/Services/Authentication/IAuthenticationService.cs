using System;
namespace BuberDinner.Application.Services.Authentication;

public interface IAuthenticationService
{
	AuthenticationResult Register(string FirstName, string LastName, string Email, string Token);
	AuthenticationResult Login(string Email, string Password);
}

