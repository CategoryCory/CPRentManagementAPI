﻿using CPRentManagement.API.Services;
using CPRentManagement.Repository;
using CPRentManagement.Repository.IdentityModels;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Text;

namespace CPRentManagement.API.Extensions
{
    public static class IdentityServiceExtensions
    {
        public static void ConfigureIdentity(this IServiceCollection services, IConfiguration config)
        {
            services.AddIdentityCore<ApplicationUser>(options => { })
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddSignInManager<SignInManager<ApplicationUser>>();

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config.GetValue<string>("TokenKey")));

            services.AddAuthentication(authOptions =>
            {
                authOptions.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                authOptions.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(bearerOptions =>
                {
                    bearerOptions.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = key,
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        ValidateLifetime = true,
                        ClockSkew = TimeSpan.FromMinutes(5)
                    };
                });

            services.AddScoped<TokenService>();
        }
    }
}