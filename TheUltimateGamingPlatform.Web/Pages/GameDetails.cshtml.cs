using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TheUltimateGamingPlatform.Database.Repository.Interfaces;
using TheUltimateGamingPlatform.Model;

namespace TheUltimateGamingPlatform.Web.Pages
{
    public class GameDetailsModel(IRepositoryGame repositoryGame) : PageModel
    {
        public Game? Game { get; set; }
        public async Task OnGetAsync(int id)
        {
            Game = await repositoryGame.GetDetailsAsync(id);
        }
    }
}
