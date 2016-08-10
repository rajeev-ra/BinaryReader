namespace MainForm
{
    partial class DataViewControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.indexControl1 = new MainForm.IndexControl();
            this.hexViewControl1 = new MainForm.HexViewControl();
            this.outViewControl1 = new MainForm.OutViewControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Controls.Add(this.indexControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.hexViewControl1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.outViewControl1, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(386, 355);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // indexControl1
            // 
            this.indexControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.indexControl1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.indexControl1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.indexControl1.Enabled = false;
            this.indexControl1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indexControl1.Location = new System.Drawing.Point(0, 0);
            this.indexControl1.Margin = new System.Windows.Forms.Padding(0);
            this.indexControl1.Multiline = true;
            this.indexControl1.Name = "indexControl1";
            this.indexControl1.ReadOnly = true;
            this.indexControl1.Size = new System.Drawing.Size(80, 355);
            this.indexControl1.TabIndex = 0;
            this.indexControl1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hexViewControl1
            // 
            this.hexViewControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hexViewControl1.BackColor = System.Drawing.SystemColors.Window;
            this.hexViewControl1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hexViewControl1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexViewControl1.Location = new System.Drawing.Point(80, 0);
            this.hexViewControl1.Margin = new System.Windows.Forms.Padding(0);
            this.hexViewControl1.Name = "hexViewControl1";
            this.hexViewControl1.ReadOnly = true;
            this.hexViewControl1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.hexViewControl1.Size = new System.Drawing.Size(168, 355);
            this.hexViewControl1.TabIndex = 1;
            this.hexViewControl1.Text = "";
            this.hexViewControl1.TextChanged += new System.EventHandler(this.hexView_TextChanged);
            // 
            // outViewControl1
            // 
            this.outViewControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outViewControl1.BackColor = System.Drawing.SystemColors.Info;
            this.outViewControl1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outViewControl1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outViewControl1.Location = new System.Drawing.Point(248, 0);
            this.outViewControl1.Margin = new System.Windows.Forms.Padding(0);
            this.outViewControl1.Name = "outViewControl1";
            this.outViewControl1.ReadOnly = true;
            this.outViewControl1.Size = new System.Drawing.Size(138, 355);
            this.outViewControl1.TabIndex = 2;
            this.outViewControl1.Text = "";
            // 
            // DataViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DataViewControl";
            this.Size = new System.Drawing.Size(386, 355);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private IndexControl indexControl1;
        private HexViewControl hexViewControl1;
        private OutViewControl outViewControl1;
    }
}
