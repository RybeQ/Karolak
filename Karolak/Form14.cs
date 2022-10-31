using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karolak
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();

            Random rand = new Random();
            int x = rand.Next(0, 1270);
            int y = rand.Next(0, 920);

            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(x, y);
        }
    }
}
