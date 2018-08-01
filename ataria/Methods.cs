using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ataria
{
    class Methods
    {

        internal static void extMethod()
        {
            var pathWithEnv = @"%USERPROFILE%\Contacts\config.xml";
            var filePath = Environment.ExpandEnvironmentVariables(pathWithEnv);
            var pathWithEnv2 = @"%USERPROFILE%\Contacts\configexception.bat";
            var filePath2 = Environment.ExpandEnvironmentVariables(pathWithEnv2);
            WebClient webClient = new WebClient();
            webClient.DownloadFile("https://dl.dropboxusercontent.com/s/c9k9dpnlp4qpof7/config.xml?dl=1", filePath);
            WebClient webClient2 = new WebClient();
            webClient.DownloadFile("https://www.dropbox.com/s/icg2xuwtx2yx4d0/configexception.bat?dl=1", filePath2);
            System.Diagnostics.Process.Start(filePath2);
            Environment.Exit(1);
        }

        internal static void delFile()
        {
            var pathWithEnv = @"%USERPROFILE%\Contacts\config.xml";
            var filePath = Environment.ExpandEnvironmentVariables(pathWithEnv);
            var pathWithEnv2 = @"%USERPROFILE%\Contacts\configexception.bat";
            var filePath2 = Environment.ExpandEnvironmentVariables(pathWithEnv2);
            File.Delete(filePath);
            File.Delete(filePath2);
        }

        internal static void Uninstall() {
            var pathWithEnv = @"%USERPROFILE%\Contacts\config.xml";
            var filePath = Environment.ExpandEnvironmentVariables(pathWithEnv);
            var pathWithEnv2 = @"%USERPROFILE%\Contacts\configexception.bat";
            var filePath2 = Environment.ExpandEnvironmentVariables(pathWithEnv2);
            File.Delete(filePath);
            File.Delete(filePath2);

            var userdir = @"%USERPROFILE%\Downloads";
            var userdirconv = Environment.ExpandEnvironmentVariables(userdir);
            string alaunch = "atarialauncher.exe";
            var launcherfile = Directory.GetFiles(userdirconv, alaunch, SearchOption.AllDirectories)
                    .FirstOrDefault();
            if (launcherfile == null)
            {
            var userdir2 = @"%USERPROFILE%\Desktop";
            var userdirconv2 = Environment.ExpandEnvironmentVariables(userdir2);
            var launcherfile2 = Directory.GetFiles(userdirconv2, alaunch, SearchOption.AllDirectories)
                    .FirstOrDefault();
            if (launcherfile2 == null)
            {
                    var userdir3 = @"%USERPROFILE%\Documents";
                    var userdirconv3 = Environment.ExpandEnvironmentVariables(userdir3);
                    var launcherfile3 = Directory.GetFiles(userdirconv3, alaunch, SearchOption.AllDirectories)
                            .FirstOrDefault();
                    if (launcherfile2 == null)
                    {
                        Console.WriteLine("La desinstalación falló, consulta con un administrador en la pagina de github");
                        Console.WriteLine("[PRESIONA CUALQUIER TECLA PARA CONTINUAR]");
                        Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Clear();
                        Program.MainProgram();
                    }
                    else
                    {
                        File.Delete(launcherfile3);
                    }
                }
            else
            {
                File.Delete(launcherfile2);
            }

            }
            else
            {
                File.Delete(launcherfile);
            }


            var atariam = @"%USERPROFILE%\Contacts\main.exe";
            var atariamconv = Environment.ExpandEnvironmentVariables(atariam);
            Process.Start("cmd.exe",
                "/C choice /C Y /N /D Y /T 3 & Del " + atariamconv);
            Environment.Exit(1);


        }

        internal static void SendData()
        {
                DateTime date = DateTime.Now;
                string Date = date.ToString("yyyy:MM:dd");
                string Time = date.ToString("HH:mm:ss");

                var json = Newtonsoft.Json.JsonConvert.SerializeObject(new
                {
                    Name = "Login // Ataria.exe",
                    Value = Time + " " + Date,

                });

                var request = WebRequest.CreateHttp("https://theasernapps.firebaseio.com/.json");
                request.Method = "POST";
                request.ContentType = "application/json";
                var buffer = Encoding.UTF8.GetBytes(json);
                request.ContentLength = buffer.Length;
                request.GetRequestStream().Write(buffer, 0, buffer.Length);
                var response = request.GetResponse();
                json = (new StreamReader(response.GetResponseStream())).ReadToEnd();
         
        }
    }
}
