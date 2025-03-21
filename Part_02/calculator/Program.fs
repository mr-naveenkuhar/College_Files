open Microsoft.AspNetCore.Builder
open Microsoft.Extensions.Hosting
open Microsoft.AspNetCore.Http

// Set up the web application builder
let builder = WebApplication.CreateBuilder()

// Register services (optional f0or now)
builder.Services.AddRazorPages()

// Build the app
let app = builder.Build()

// Serve static files (including the calculator HTML page)
app.UseStaticFiles()
s
// Define a simple endpoint to handle requests (optional for backend calculation)
app.MapGet("/api/calculate", fun (context: HttpContext) ->
    let queryParams = context.Request.Query
    let expression = queryParams["expression"]
    let result = 
        try
            let evalResult = System.Data.DataTable().Compute(expression, null)
            evalResult.ToString()
        with
        | :? System.Exception -> "Error"
    context.Response.WriteAsync(result)
)

// Run the application
app.Run()
