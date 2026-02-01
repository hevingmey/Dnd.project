using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace D_D_project.Music
{
    public static class Soundtrack
    {
        private static Process? _p;
        private static volatile bool _loop;

        
        public static void Start(string fileName = "mus.wav")
        {
            string path = Path.Combine(AppContext.BaseDirectory, "muss", fileName);

            if (!File.Exists(path))
            {
                Console.WriteLine("Soundtrack not found: " + path);
                return;
            }

            if (_loop) return; 

            _loop = true;

            ThreadPool.QueueUserWorkItem(_ =>
            {
                while (_loop)
                {
                    _p = Process.Start(new ProcessStartInfo("afplay", $"\"{path}\"")
                    {
                        UseShellExecute = false,
                        CreateNoWindow = true
                    });

                    _p?.WaitForExit();
                }
            });
        }

        
        public static void Stop()
        {
            _loop = false;
            try { if (_p is { HasExited: false }) _p.Kill(); } catch { }
            _p = null;
        }
    }
}