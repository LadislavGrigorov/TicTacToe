using Microsoft.AspNetCore.Mvc;
using TicTacToe.Models;
using TicTacToe.Services;

namespace TicTacToe.Controllers
{
    public class GameInvitationController : Controller
    {
        private IUserService _userService;

        public GameInvitationController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index(string email)
        {
            GameInvitationModel gameInvitationModel = new GameInvitationModel()
            {
                InvitedBy = email
            };

            return View(gameInvitationModel);
        }
    }
}
