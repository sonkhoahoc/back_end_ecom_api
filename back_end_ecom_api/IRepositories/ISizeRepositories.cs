using back_end_ecom_api.Entities;

namespace back_end_ecom_api.IRepositories
{
    public interface ISizeRepositories
    {
        Task<List<Sizes>> GetListSize();
        Task<Sizes> GetSizebyId(long id);
        Task<Sizes> CreateSize(Sizes size);
        Task<Sizes> ModifySize(long id, Sizes size);
        Task<bool> DeleteSize(long id);
    }
}
