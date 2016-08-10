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
    public partial class HexViewControl : RichTextBox
    {
        public HexViewControl()
        {
            InitializeComponent();
        }

        public void InsertData(ref Byte[] iData)
        {
            string hexStr = "";
            int size = iData.Count();
            for (int i = 0; i < size; i++)
            {
                hexStr += ToHex(iData[i]);
                if (i % 16 == 15)
                    hexStr += "\r\n";
                else if (i % 8 == 7)
                    hexStr += "  ";
                else
                    hexStr += " ";
            }
            this.Text = hexStr;
        }

        private string ToHex(byte bt)
        {
            char[] c = new char[2];

            byte b = ((byte)(bt >> 4));
            c[0] = (char)(b > 9 ? b + 0x37 : b + 0x30);

            b = ((byte)(bt & 0x0F));
            c[1] = (char)(b > 9 ? b + 0x37 : b + 0x30);

            return new string(c);
        }
    }
}
