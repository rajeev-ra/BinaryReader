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
    public partial class StatusControl : UserControl
    {
        private List<Button> _buttons = new List<Button>();
        private int _count = 0;
        Func<int, int> _call;

        public StatusControl()
        {
            InitializeComponent();
        }

        public void SetMethod(Func<int, int> call)
        {
            _call = call;
        }

        public void ClearButtons()
        {
            this.Controls.Clear();
            this.Controls.Add(this.textBox1);
        }

        public void AddButtons(int count)
        {
            ClearButtons();
            _count = count;
            AddButtonsAccoedingToPage(_count, 0);
        }

        public void CurrentPage(int index)
        {
            ClearButtons();
            AddButtonsAccoedingToPage(_count, index);
        }

        private void AddButtonsAccoedingToPage(int count, int curPage)
        {
            for (int i = curPage - 5, n = 0, pos = 110; i < count && n < 10; i++)
            {
                if(i >= 0)
                {
                    n++;
                    Button newButton = new Button();
                    newButton.Size = new Size(35, 21);
                    newButton.Text = (i + 1).ToString();
                    newButton.Left = pos;
                    newButton.Top = 0;
                    newButton.Margin = new Padding(0);
                    newButton.Click += OnButtonClick;
                    if (i == curPage)
                        newButton.BackColor = Color.White;

                    this.Controls.Add(newButton);
                    pos += 40;
                }
            }
        }

        private void OnButtonClick(object sender, EventArgs e)
        {
            int a = Convert.ToInt32((sender as Button).Text);
            _call(a - 1);
        }
    }
}
