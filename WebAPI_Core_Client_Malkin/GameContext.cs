using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI_Core_Client_Malkin.Models;

namespace WebAPI_Core_Client_Malkin
{
    public static class GameContext
    {
        public static string urls;

        static GameContext()
        {
            urls = Environment.GetEnvironmentVariable("URLS", EnvironmentVariableTarget.User);
            if (urls == null)
            {
                throw new Exception("Ошибка получения перменных окружения")
                {
                    HelpLink = "Создайте config.bat вне проекта" +
                    "setx URLS http://192.168.43.192:33833"
                };
            }
        }
    }
}
