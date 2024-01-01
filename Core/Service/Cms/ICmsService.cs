namespace Core.Service.Cms
{
    public interface ICmsService
    {
        Task<ResponseModel> GetRoutesConfig();
    }
}
