namespace TaskManager.Application.Common.Settings;

public class CosmosDbSettings
{
    public String Account { get; set; } = default!;
    public String Key { get; set; } = default!;
    public String DatabaseName { get; set; } = default!;
}