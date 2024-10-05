using UpWork.Entities;

namespace UpWork.Services.Abstracts
{
    public interface IApplicantService
    {
        Task<List<Applicant>> GetAllApplicant();
        Task<Applicant> GetApplicantById(string id);
        Task AddApplicant(Applicant applicant);
        Task DeleteApplicant(Applicant applicant);
        Task UpdateApplicant(Applicant applicant);
    }
}
