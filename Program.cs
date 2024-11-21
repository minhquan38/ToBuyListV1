
using ToBuyListV1;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddRazorPages().Services
    .AddServerSideBlazor().Services
    .AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie().Services
    .AddAuthentication().AddGoogle(options =>
    {
        options.ClientId = "903471121943-q0n3fqpnl9cqn03cml3hkcveg29a7420.apps.googleusercontent.com";
        options.ClientSecret = "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";
        options.ClaimActions.MapJsonKey("urn:google:profile", "link");
        options.ClaimActions.MapJsonKey("urn:google:image", "picture");
    });

var app = builder.Build();

if (!app.Environment.IsDevelopment())
    app.UseExceptionHandler("/Error")
        .UseHsts();

app.UseHttpsRedirection()
    .UseStaticFiles()
    .UseCookiePolicy()
    .UseAuthentication()
    .UseRouting();
    
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

await app.RunAsync().ConfigureAwait(false);