using Microsoft.AspNetCore.Mvc;

namespace GamesDBApp.Models
{
    public class RatingViewModel
    {
        [HiddenInput]
        public int Rating { get; set; }
    }
}
