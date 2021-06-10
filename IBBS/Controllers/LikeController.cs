using IBBS.Data;
using IBBS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IBBS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LikeController : ControllerBase
    {
        private readonly BurgerDbContext _context;
        private readonly UserManager<Users> _userManager;

        public LikeController(BurgerDbContext context, UserManager<Users> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Likes>>> GetLikes()
        {
            return await _context.Likes.ToListAsync();
        }

        [HttpPost]
        public async Task<LikesDTO> PostLikes(LikesDTO LikesDTO)
        {
            var user = await _userManager.GetUserAsync(User);
            SavedHamburgers burger = new SavedHamburgers();

            Likes likes = new Likes()
            {
                Dislike = LikesDTO.Dislike,
                Like = LikesDTO.Like,
                Users = user,
                Burgers = burger

            };

            _context.Add(likes);
            _context.SaveChanges();
            return LikesDTO;
        }


    }
}

