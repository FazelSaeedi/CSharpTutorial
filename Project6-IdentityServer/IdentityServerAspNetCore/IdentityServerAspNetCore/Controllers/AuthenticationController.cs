using IdentityServerAspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace IdentityServerAspNetCore.Controllers
{

    [Route("api/Account")]
    [ApiController]
    public class AuthenticationController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;

        public AuthenticationController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
        }



        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel registerModel)
        {

            var userExist = await _userManager.FindByNameAsync(registerModel.Username);


            if (userExist != null)
                return StatusCode(StatusCodes.Status500InternalServerError,
                    new Response { Status = "Error", message = "User Already Exist" });


            ApplicationUser user = new ApplicationUser()
            {
                Email = registerModel.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = registerModel.Username
            };


            var result = await _userManager.CreateAsync(user, registerModel.Password);
            if(!result.Succeeded)
                return StatusCode(StatusCodes.Status500InternalServerError ,
                     new Response { Status = "Error", message = "User Creation Fail" });



            if (!await _roleManager.RoleExistsAsync(UserRoles.Admin))
                await _roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));


            
            if (!await _roleManager.RoleExistsAsync(UserRoles.User))
                await _roleManager.CreateAsync(new IdentityRole(UserRoles.User));



            if (await _roleManager.RoleExistsAsync(UserRoles.Admin))
                await _userManager.AddToRoleAsync(user, UserRoles.User);



            return Ok(new Response { Status = "Success", message = "User Created Successfully" });


        }



        [HttpPost]
        [Route("RegisterAdmin")]
        public async Task<IActionResult> RegisterAdmin([FromBody] RegisterModel registerModel)
        {
            var userExist = await _userManager.FindByNameAsync(registerModel.Username);


            if (userExist != null)
                return StatusCode(StatusCodes.Status500InternalServerError,
                    new Response { Status = "Error", message = "User Already Exist" });


            ApplicationUser user = new ApplicationUser()
            {
                Email = registerModel.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = registerModel.Username
            };


            var result = await _userManager.CreateAsync(user, registerModel.Password);
            if (!result.Succeeded)
                return StatusCode(StatusCodes.Status500InternalServerError,
                     new Response { Status = "Error", message = "User Creation Fail" });



            if (!await _roleManager.RoleExistsAsync(UserRoles.Admin))
                await _roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));



            if (!await _roleManager.RoleExistsAsync(UserRoles.User))
                await _roleManager.CreateAsync(new IdentityRole(UserRoles.User));



            if (await _roleManager.RoleExistsAsync(UserRoles.Admin))
                await _userManager.AddToRoleAsync(user, UserRoles.Admin);



            return Ok(new Response { Status = "Success", message = "User Created Successfully" });

        }



        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] LoginModel loginModel)
        {

            var user = await _userManager.FindByNameAsync(loginModel.Username);

            if(user != null && await _userManager.CheckPasswordAsync(user , loginModel.Password))
            {

                var userRoles = await _userManager.GetRolesAsync(user);

                var authClaim = new List<Claim>
                {
                    new Claim(ClaimTypes.Name , user.UserName) ,
                    new Claim(JwtRegisteredClaimNames.Jti , Guid.NewGuid().ToString() , user.UserName) ,
                };


                foreach (var userRole in userRoles)
                    authClaim.Add(new Claim(ClaimTypes.Role, userRole));


                var key = Encoding.ASCII.GetBytes("MY_BIG_SECRET_KEY_LKSHDJFLSDKFW@#($)(#)32234");
                var authSigningKey = new SymmetricSecurityKey(key);

                var token = new JwtSecurityToken(
                    issuer: _configuration["JWT:ValidIssuer"],
                    audience: _configuration["JWT:ValidAudience"],
                    expires: DateTime.Now.AddHours(3),
                    claims: authClaim,
                    signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                    );

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    Exception = token.ValidTo ,
                    User = user.UserName
                });
            }
            return Unauthorized();             
        }
    }
}
