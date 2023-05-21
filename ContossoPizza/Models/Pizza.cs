namespace ContossoPizza.Models;

/// <summary>
/// JEZ:  Who loves Pizza?  Everybody loves pizza!!!
/// </summary>
public class Pizza
{
    /// <summary>
    /// JEZ:  Record ID
    /// </summary>
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool IsGlutenFree { get; set; }
}