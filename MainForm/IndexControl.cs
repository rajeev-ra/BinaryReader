using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class IndexControl : TextBox
    {
        public IndexControl()
        {
            InitializeComponent();
        }

        public void UpdateIndex(int iLines)
        {
            if (this.Lines.Count() <= iLines)
            {
                string txt = "";
                for (int i = (this.Lines.Count() == 0 ? 0 : this.Lines.Count() - 1); i < iLines; i++)
                    txt += i.ToString("X3") + "0 \r\n";
                this.Text = txt;
            }
        }
    }
}
