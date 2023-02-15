using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddOptions();
builder.Services.AddAuthentication(options =>
    {
        options.DefaultScheme = "Cookies";
        options.DefaultChallengeScheme = "oidc";
    })
    .AddCookie("Cookies")
    .AddOpenIdConnect("oidc", options =>
    {
        options.Authority = "https://accounts.google.com";
        //options.Authority = "https://shibboleth.umich.edu/";
        options.SignInScheme = "Cookies";
        options.ClientId = builder.Configuration.GetValue<string>("OIDC_ID");
        options.ClientSecret = builder.Configuration.GetValue<string>("OIDC_SECRET");
        options.ResponseType = "code";
        options.SaveTokens = true;
        // options.CallbackPath = ; //Default for openid is /signin-oidc
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true
        };
        options.GetClaimsFromUserInfoEndpoint = true;
        options.CorrelationCookie.SecurePolicy = CookieSecurePolicy.Always;
        options.NonceCookie.SecurePolicy = CookieSecurePolicy.Always;
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/");
app.MapRazorPages();

app.Run();
