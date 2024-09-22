﻿using Template.Contracts.Authentication;
using Template.Application.Services.Authentication;
using Microsoft.AspNetCore.Mvc;
using Template.Application.PaginationFilter;
using Template.Api.Filters;

namespace Template.Api.Controllers
{
    [ApiController]
    [Route("auth")]
    [ErrorHandlingFilter]
    public class AuthenticationController : Controller
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly ILogger<AuthenticationController> _logger;
        
        //TODO: Adding Logging message
        // TODO: Controllers should not retrieve sensitive data like token or Id

        public AuthenticationController(
            IAuthenticationService authenticationService, 
            ILogger<AuthenticationController> logger)
        {
            _authenticationService = authenticationService;
            _logger = logger;
        }

        [HttpPost("register", Name = "register")]
        public IActionResult Register(RegisterRequest request)
        {
            var authResult = _authenticationService.Register(
                request.FirstName,
                request.LastName,
                request.Email,
                request.Password
                );

            var response = new AuthenticationResponse(
                authResult.User.FirstName,
                authResult.User.LastName,
                authResult.User.Email,
                authResult.Token
                );

            return Ok(response);
        }

        [HttpPost("login", Name = "login")]
        public IActionResult Login(LoginRequest request)
        {
            var authResult = _authenticationService.Login(
                request.Email,
                request.Password);

            var response = new AuthenticationResponse(
                authResult.User.FirstName,
                authResult.User.LastName,
                authResult.User.Email,
                authResult.Token
                );

            return Ok(response);
        }

    }
}
