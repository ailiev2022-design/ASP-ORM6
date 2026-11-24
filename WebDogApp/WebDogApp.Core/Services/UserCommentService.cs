using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WebDogApp.Core.Contacts;
using WebDogApp.Infrastructure.Data;
using WebDogApp.Infrastructure.Data.Domain;

namespace WebDogApp.Core.Services
{
    public class UserCommentService : IUserCommentService
    {
        private readonly ApplicationDbContext _context;

        public UserCommentService(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool Create(string userName, string email, string comment)
        {
            var userComment = new UserComment
            {
                UserName = userName,
                Email = email,
                Comment = comment
            };

            _context.UserComments.Add(userComment);
            return _context.SaveChanges() != 0;
        }

        public List<UserComment> GetAllComments()
        {
            return _context.UserComments.ToList();
        }
    }
}
