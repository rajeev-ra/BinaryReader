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
    public partial class DataViewControl : UserControl
    {
        private DataManager _dataManager = null;
        private int _curr_page = 0;
        public DataViewControl()
        {
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
            this.AutoScroll = true;
            InitializeComponent();
            this.AutoScrollMinSize = new Size(0, 100);
        }

        public void SetDataManager(DataManager dataMgr)
        {
            _dataManager = dataMgr;
        }

        public void UpdateView(int page)
        {
            _curr_page = page;
            ClearAll();
            int length = _dataManager.GetByteCount();
            Byte[] data = _dataManager.ReadBytes(page * MainWindow._page_size, MainWindow._page_size);
            this.hexViewControl1.InsertData(ref data);
        }
        private void hexView_TextChanged(object sender, EventArgs e)
        {
            int iHeight = TextRenderer.MeasureText(this.hexViewControl1.Text + "\r\n", this.hexViewControl1.Font).Height;
            this.AutoScrollMinSize = new Size(0, iHeight);
            this.indexControl1.UpdateIndex(this.hexViewControl1.Lines.Count(), _curr_page);
        }

        private void ClearAll()
        {
            this.hexViewControl1.Clear();
            this.indexControl1.Clear();
            this.outViewControl1.Clear();
        }
    }
}
