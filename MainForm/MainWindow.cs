using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class MainWindow : Form
    {
        public static int _page_size = 4096;
        public MainWindow()
        {
            InitializeComponent();
            InitializeForm();
            this.statusControl1.SetMethod(PageSelect);
        }

        private void InitializeForm()
        {
            this.MinimumSize = new Size(940, 600);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog odlg = new OpenFileDialog();
            if (odlg.ShowDialog() == DialogResult.OK)
            {
                DataManager dataMgr = new DataManager(odlg.FileName);
                int nPages = dataMgr.GetByteCount() / _page_size + (dataMgr.GetByteCount() % _page_size == 0 ? 0 : 1);
                this.statusControl1.AddButtons(nPages);

                this.dataViewControl1.SetDataManager(dataMgr);
                this.dataViewControl1.UpdateView(0);
                this.dataViewControl1.UpdateView(0);
                this.textBox1.Visible = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int PageSelect(int i)
        {
            this.statusControl1.CurrentPage(i);
            this.dataViewControl1.UpdateView(i);
            return 0;
        }
    }
}
