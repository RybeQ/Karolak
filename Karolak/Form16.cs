using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Karolak
{
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
            {
                RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer");
                if (key.GetValue("TaskbarLockAll") == null)
                    key.SetValue("TaskbarLockAll", "00000001");
            }
        }
    }
}
