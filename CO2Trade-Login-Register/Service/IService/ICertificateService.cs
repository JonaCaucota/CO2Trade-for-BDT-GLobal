using CO2Trade_Login_Register.DTO.RequestDTO;
using CO2Trade_Login_Register.DTO.ResponseDTO;
using CO2Trade_Login_Register.Models;

namespace CO2Trade_Login_Register.Service.IService;

public interface ICertificateService
{
    Task<CertificateResponseDTO> GetCertificate(CertificateRequestDTO certificateRequest);
    Task<CertificateResponseDTO> BuildCertificate(CertificateRequestDTO certificateRequest);
}