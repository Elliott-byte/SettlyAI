namespace SettlyModels.Dtos;

public class PropertyDetailDto
{
    public string Id { get; set; } = string.Empty;

    public string Suburb { get; set; } = String.Empty;

    public string Address { get; set; } = null!;
    public int Price { get; set; }

    public int Bedrooms { get; set; }
    public int Bathrooms { get; set; }
    public int CarSpaces { get; set; }

    public int InternalArea { get; set; }
    public int LandSize { get; set; }

    public int YearBuilt { get; set; }

    public string Features { get; set; } = null!;

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public string Summary { get; set; } = String.Empty;
    public string ImageUrl { get; set; } = String.Empty;

}