using ConsumeMusicAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsumeMusicAPI.Controllers
{
    public class MusicController : Controller
    {
       
        public async Task<IActionResult> Index()
        {
            List<MusicFile> musicFiles = new List<MusicFile>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:44366/api/MusicFile/Music-files"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    musicFiles = JsonConvert.DeserializeObject<List<MusicFile>>(apiResponse);
                }
            }
            return View(musicFiles);
        }
    }
}
