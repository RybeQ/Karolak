using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karolak
{
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }
        private static void urlShortcutToDesktop(string linkName, string linkUrl)
        {
            string deskDir = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

            using (StreamWriter writer = new StreamWriter(deskDir + "\\" + linkName + ".url"))
            {
                writer.WriteLine("[InternetShortcut]");
                writer.WriteLine("URL=https://cdn.discordapp.com/attachments/927544698799816724/1018307778781130832/8.jpg" + linkUrl);
            }
        }
    }
}
