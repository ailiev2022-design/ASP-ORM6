using Microsoft.AspNetCore.Mvc;

using WebDogApp.Core.Contacts;
using WebDogApp.Models.UserComment;

namespace WebDogApp.Controllers
{
    public class UserCommentController : Controller
    {
        private readonly IUserCommentService _commentService;

        public UserCommentController(IUserCommentService commentService)
        {
            _commentService = commentService;
        }

        // GET: UserComment
        public IActionResult Index()
        {
            var comments = _commentService.GetAllComments()
                .Select(c => new UserCommentIndexVM
                {
                    Id = c.Id,
                    UserName = c.UserName,
                    Email = c.Email,
                    Comment = c.Comment
                }).ToList();

            return View(comments);
        }

        // GET: UserComment/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UserComment/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(UserCommentCreateVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var created = _commentService.Create(model.UserName, model.Email, model.Comment);
            if (created)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }
    }
}
