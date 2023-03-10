var builder = WebApplication.CreateBuilder(args);

// Dienst zum Container hinzufügen
builder.Services.AddRazorPages();

var app = builder.Build();

// HTTP-Anforderungspipeline konfigurieren
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // Der Standard-HSTS-Wert beträgt 30 Tage
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
