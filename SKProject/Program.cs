using Microsoft.SemanticKernel;

var builder = Kernel.CreateBuilder();
builder.Services.AddAzureOpenAIChatCompletion(
"your-resource-name",
"your-endpoint",
"your-resource-key",
"deployment-model");

var kernel = builder.Build();

var result = await kernel.InvokePromptAsync(
"Give me a list of breakfast foods with eggs and cheese");
Console.WriteLine(result);
