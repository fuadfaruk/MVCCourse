using Microsoft.AspNetCore.Mvc.Formatters;
using System.Net.Mime;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", (HttpContext context) => {
    WriteHtml(context, @$"
        <!DOCTYPE html>
        <html>
        <body>
        <h1>Login</h1>
        <form method=""post"" action=""/login"">
            <label for=""username"">Username:</label>
            <input type=""text"" id=""username"" name=""username""><br><br>
            <label for=""password"">Password:</label>
            <input type=""password"" id=""password"" name=""password""><br><br>
            <input type=""submit"" value=""Login"">
        </form>
        </body>
        </html>
    ");
});

app.MapPost("/login", (HttpContext context) => {
    var form = context.Request.Form;
    var username = form["username"];
    var password = form["password"];
    if (username == "admin" && password == "admin")
    {
        WriteHtml(context, @$"
            <!docktype html>
            <html>
                <head><title>miniHTML</title></head>
                <body>
                    <h1>Simple Framework</h1>
                    <br/>
                    Welcome to our simple framework!
                </body>
                </html>
        ");
    }
    else
    {
        WriteHtml(context, @$"
            <!DOCTYPE html>
            <html>
            <body>
            <h1>Login</h1>
            <form method=""post"" action=""/login"">
                <label for=""username"">Username:</label>
                <input type=""text"" id=""username"" name=""username""><br><br>
                <label for=""password"">Password:</label>
                <input type=""password"" id=""password"" name=""password""><br><br>
                <input type=""submit"" value=""Login"">
            </form>
            </body>
            </html>
        ");
    }
});

app.Run();

void WriteHtml(HttpContext context, string html)
{
    context.Response.ContentType = MediaTypeNames.Text.Html;
    context.Response.ContentLength = Encoding.UTF8.GetByteCount(html);
    context.Response.WriteAsync(html);
}
