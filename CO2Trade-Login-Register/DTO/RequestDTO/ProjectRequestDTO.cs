using CO2Trade_Login_Register.Models.GeneralSettings;

namespace CO2Trade_Login_Register.DTO.RequestDTO;

public class ProjectRequestDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal TonsOfOxygen { get; set; }
    public decimal Price { get; set; }
    public int IdProjectType { get; set; }
    public string Description { get; set; }
    public int IdImage { get; set; }
    public ImageRequestDTO? Image { get; set; }
}