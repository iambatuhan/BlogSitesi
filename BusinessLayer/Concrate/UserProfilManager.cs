using DataAccessLayer.Concrate;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class UserProfilManager
    {
        Repository<Author> repouser = new Repository<Author>();
        public List<Author> GetAuthorByMail(string p)
        {
            return repouser.List().Where(x => x.Mail == p).ToList();

        }
    }
}
