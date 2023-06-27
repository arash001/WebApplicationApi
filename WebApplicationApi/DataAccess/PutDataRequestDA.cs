using Microsoft.EntityFrameworkCore;
using WebApplicationApi.Model;

namespace WebApplicationApi.DataAccess
{
    public class PutDataRequestDA
    {
        AppDbContext _appDbContext;
        public PutDataRequestDA(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public List<PutDataRequest> GetAllPutDataRequest()
        {
            return _appDbContext.PutDataRequests.ToList();
        }

        public void AddPutDataRequest(PutDataRequest putDataRequest)
        {
            _appDbContext.Set<PutDataRequest>().Add(putDataRequest);
            _appDbContext.SaveChanges();
        }

        public List<PutDataRequest> GetPutDataRequestList()
        {
            return _appDbContext.Set<PutDataRequest>().ToList();
        }
    }
}
