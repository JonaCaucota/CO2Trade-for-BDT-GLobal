namespace MagicVilla_VillaAPI.Dto.RequestDTO;

public class RegistrationRequestDTO
{
    public string UserName { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }
    public int EntityType { get; set; }
}