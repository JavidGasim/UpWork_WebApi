using UpWork.Entities;

namespace UpWork.Repositories.Abstracts
{
    public interface IApplicantRepository
    {
        Task<List<Applicant>> GetAllApplicant();
        Task<Applicant> GetApplicantById(string id);
        Task AddApplicant(Applicant applicant);
        Task DeleteApplicant(Applicant applicant);
        Task UpdateApplicant(Applicant applicant);

    }
}
