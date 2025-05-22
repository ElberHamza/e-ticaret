using DataAccess2.Repository.IRepository;
using Models2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess2.Repository
{
    public interface ICompanyRepository : IRepository<Company>
    {
        void Update(Company obj);
    }
}