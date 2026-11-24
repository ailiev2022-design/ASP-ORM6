using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WebDogApp.Infrastructure.Data.Domain;

namespace WebDogApp.Core.Contacts
{
    public interface IUserCommentService
    {
        bool Create(string userName, string email, string comment);
        List<UserComment> GetAllComments();
    }
}
