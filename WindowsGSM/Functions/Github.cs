﻿using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace WindowsGSM.Functions
{
    //Link: https://github.com/WindowsGSM/Game-Server-Configs

    class Github
    {
        public static async Task<bool> DownloadGameServerConfig(string filePath, string gameFullName, string fileName)
        {
            using (WebClient webClient = new WebClient())
            {
                await webClient.DownloadFileTaskAsync("https://" + $"github.com/WindowsGSM/Game-Server-Configs/raw/master/{gameFullName.Replace(":", "")}/{fileName}", filePath);
            }

            return File.Exists(filePath);
        }
    }
}