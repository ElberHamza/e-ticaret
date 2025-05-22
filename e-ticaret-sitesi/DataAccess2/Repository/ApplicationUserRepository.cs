//using Models2;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using DataAccess2.data;
//using DataAccess2.Repository;
//using DataAccess2.Repository.IRepository;

//namespace DataAccess2.Repository
//{
//    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
//    {
//        private ApplicationDbContext _db;
//        public ApplicationUserRepository(ApplicationDbContext db) : base(db)
//        {
//            _db = db;
//        }

//        public void Update(ApplicationUser applicationUser)
//        {
//            _db.ApplicationUsers.Update(applicationUser);
//        }
//    }
//}
