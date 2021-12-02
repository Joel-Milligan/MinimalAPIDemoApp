using MinimalAPIDemo;

// Create app with dependency injection
var app = Services.CreateApp(args);

// Add modules to the app
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Map endpoints and run the app
app.MapEndpoints();
app.Run();
