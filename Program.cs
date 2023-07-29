using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AntiCrack_James
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Anticrack_james";
            new Thread(new ThreadStart(Detect)).Start();
        }

        internal static void Detect()
        {

            for (; ; )
            {
                Process[] processes = Process.GetProcesses();
                string text = string.Empty;
                for (int i = 0; i < processes.Length; i++)
                {
                    text = processes[i].MainWindowTitle;
                    if (text.Contains("CodeCracker") || text.Contains("ProcessHacker") || text.Contains("Hacker") || text.Contains("dnSpy") || text.Contains("CheatEngine") || text.Contains("Engine") || text.Contains("Cheat") || text.Contains("MegaDumper") || text.Contains("OllyDbg") || text.Contains("HxD") || text.Contains("xVenoxi Dumper") || text.Contains("NativeDumper MFC Application") || text.Contains("JetBrains dotPeek") || text.Contains("ILSpy") || text.Contains("Reflector") || text.Contains("KsDumper") || text.Contains("IIDA v7.7.220118") || text.Contains("The Interactive Disassembler") || text.Contains("ExtremeDumper") || text.Contains("scylla") || text.Contains("dbg") || text.Contains("dumper") || text.Contains("ollydbg") || text.Contains("ProcessHacker") || text.Contains("Dump-Fixer") || text.Contains("kdstinker") || text.Contains("tcpview") || text.Contains("autoruns") || text.Contains("ida64") || text.Contains("x64dbg") || text.Contains("KsDumper") || text.Contains("HTTPDebuggerSvc") || text.Contains("Fiddler.WebUi") || text.Contains("twistedlulu-x86_64-SSE4-AVX2") || text.Contains("twistedlulu-x86_64") || text.Contains("twistedlulu-i386") || text.Contains("Fiddler Everywhere") || text.Contains("cheatengine-x86_64") || text.Contains("OLLYDBG") || text.Contains("Cheat Engine") || text.Contains("de4dot") || text.Contains("de4dot-x64") || text.Contains("Detect It Easy") || text.Contains("diel") || text.Contains("diec") || text.Contains("Extreme Dumper x64") || text.Contains("Extreme Dumper x32") || text.Contains("File Grab") || text.Contains("Mega Dumper") || text.Contains("Beamer x96") || text.Contains("Beamer x64") || text.Contains("loaddll") || text.Contains("Beamer x32") || text.Contains("x32") || text.Contains("x64") || text.Contains("UnConfuser") || text.Contains("windbg") || text.Contains("ida") || text.Contains("idaq64") || text.Contains("LordPE") || text.Contains("CFF Explorer"))
                    {
                        string location = Assembly.GetExecutingAssembly().Location;
                        if (location == "" || location == null)
                        {
                            location = Assembly.GetEntryAssembly().Location;
                        }
                        //  PreventHttpDebuggerAndFiddler.SendMessage("Ilegal process: " + text + "", " ```HWID: " + System.Security.Principal.WindowsIdentity.GetCurrent().User.Value + "```", "AntiDump");
                        Console.WriteLine("Ilegal Process Found : " + text);
                        Thread.Sleep(1000000000);
                    }

                }
            }
        }
    }
}
