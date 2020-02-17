namespace WindowsFormsApp9
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btFontParam = new System.Windows.Forms.ToolStripButton();
            this.cbFontSize = new System.Windows.Forms.ToolStripComboBox();
            this.cbFontColor = new System.Windows.Forms.ToolStripComboBox();
            this.cbFontBackColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btAlignLeft = new System.Windows.Forms.ToolStripButton();
            this.btAlignCenter = new System.Windows.Forms.ToolStripButton();
            this.btAlignRight = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btTextBold = new System.Windows.Forms.ToolStripButton();
            this.btTextItalic = new System.Windows.Forms.ToolStripButton();
            this.btTextUnderline = new System.Windows.Forms.ToolStripButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(790, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btFontParam,
            this.cbFontSize,
            this.cbFontColor,
            this.cbFontBackColor,
            this.toolStripSeparator1,
            this.btAlignLeft,
            this.btAlignCenter,
            this.btAlignRight,
            this.toolStripSeparator2,
            this.btTextBold,
            this.btTextItalic,
            this.btTextUnderline});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(790, 28);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btFontParam
            // 
            this.btFontParam.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btFontParam.Image = ((System.Drawing.Image)(resources.GetObject("btFontParam.Image")));
            this.btFontParam.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btFontParam.Name = "btFontParam";
            this.btFontParam.Size = new System.Drawing.Size(24, 25);
            this.btFontParam.Text = "toolStripButton1";
            this.btFontParam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btFontParam.ToolTipText = "Font parameters";
            this.btFontParam.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // cbFontSize
            // 
            this.cbFontSize.Name = "cbFontSize";
            this.cbFontSize.Size = new System.Drawing.Size(75, 28);
            this.cbFontSize.ToolTipText = "Font Size";
            this.cbFontSize.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // cbFontColor
            // 
            this.cbFontColor.AutoToolTip = true;
            this.cbFontColor.Name = "cbFontColor";
            this.cbFontColor.Size = new System.Drawing.Size(160, 28);
            this.cbFontColor.ToolTipText = "Font Color";
            this.cbFontColor.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox2_SelectedIndexChanged);
            // 
            // cbFontBackColor
            // 
            this.cbFontBackColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cbFontBackColor.Image = ((System.Drawing.Image)(resources.GetObject("cbFontBackColor.Image")));
            this.cbFontBackColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cbFontBackColor.Name = "cbFontBackColor";
            this.cbFontBackColor.Size = new System.Drawing.Size(111, 25);
            this.cbFontBackColor.Text = "Text BackColor";
            this.cbFontBackColor.ToolTipText = "Back Color";
            this.cbFontBackColor.Click += new System.EventHandler(this.CbFontBackColor_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // btAlignLeft
            // 
            this.btAlignLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btAlignLeft.Image = ((System.Drawing.Image)(resources.GetObject("btAlignLeft.Image")));
            this.btAlignLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAlignLeft.Name = "btAlignLeft";
            this.btAlignLeft.Size = new System.Drawing.Size(24, 25);
            this.btAlignLeft.Tag = "Align";
            this.btAlignLeft.Text = "toolStripButton2";
            this.btAlignLeft.ToolTipText = "Left Align";
            this.btAlignLeft.Click += new System.EventHandler(this.ToolStripButton2_Click);
            // 
            // btAlignCenter
            // 
            this.btAlignCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btAlignCenter.Image = ((System.Drawing.Image)(resources.GetObject("btAlignCenter.Image")));
            this.btAlignCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAlignCenter.Name = "btAlignCenter";
            this.btAlignCenter.Size = new System.Drawing.Size(24, 25);
            this.btAlignCenter.Tag = "Align";
            this.btAlignCenter.Text = "toolStripButton3";
            this.btAlignCenter.ToolTipText = "Center Align";
            this.btAlignCenter.Click += new System.EventHandler(this.BtAlignCenter_Click);
            // 
            // btAlignRight
            // 
            this.btAlignRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btAlignRight.Image = ((System.Drawing.Image)(resources.GetObject("btAlignRight.Image")));
            this.btAlignRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAlignRight.Name = "btAlignRight";
            this.btAlignRight.Size = new System.Drawing.Size(24, 25);
            this.btAlignRight.Tag = "Align";
            this.btAlignRight.Text = "toolStripButton4";
            this.btAlignRight.ToolTipText = "Right Align";
            this.btAlignRight.Click += new System.EventHandler(this.BtAlignRight_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // btTextBold
            // 
            this.btTextBold.CheckOnClick = true;
            this.btTextBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btTextBold.Image = ((System.Drawing.Image)(resources.GetObject("btTextBold.Image")));
            this.btTextBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btTextBold.Name = "btTextBold";
            this.btTextBold.Size = new System.Drawing.Size(24, 25);
            this.btTextBold.Tag = "TextStyle";
            this.btTextBold.Text = "toolStripButton5";
            this.btTextBold.ToolTipText = "Bold";
            this.btTextBold.Click += new System.EventHandler(this.BtTextStyle_Click);
            // 
            // btTextItalic
            // 
            this.btTextItalic.CheckOnClick = true;
            this.btTextItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btTextItalic.Image = ((System.Drawing.Image)(resources.GetObject("btTextItalic.Image")));
            this.btTextItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btTextItalic.Name = "btTextItalic";
            this.btTextItalic.Size = new System.Drawing.Size(24, 25);
            this.btTextItalic.Tag = "TextStyle";
            this.btTextItalic.Text = "toolStripButton6";
            this.btTextItalic.ToolTipText = "Italic";
            this.btTextItalic.Click += new System.EventHandler(this.BtTextStyle_Click);
            // 
            // btTextUnderline
            // 
            this.btTextUnderline.CheckOnClick = true;
            this.btTextUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btTextUnderline.Image = ((System.Drawing.Image)(resources.GetObject("btTextUnderline.Image")));
            this.btTextUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btTextUnderline.Name = "btTextUnderline";
            this.btTextUnderline.Size = new System.Drawing.Size(24, 25);
            this.btTextUnderline.Tag = "TextStyle";
            this.btTextUnderline.Text = "toolStripButton7";
            this.btTextUnderline.ToolTipText = "Underline";
            this.btTextUnderline.Click += new System.EventHandler(this.BtTextStyle_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 56);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(790, 498);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.SelectionChanged += new System.EventHandler(this.RichTextBox1_SelectionChanged);
            this.richTextBox1.Resize += new System.EventHandler(this.RichTextBox1_Resize);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 532);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(790, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "I am still working";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseDoubleClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 500;
            this.errorProvider1.ContainerControl = this;
            // 
            // btButton
            // 
            this.btButton.Location = new System.Drawing.Point(666, 31);
            this.btButton.Name = "btButton";
            this.btButton.Size = new System.Drawing.Size(75, 23);
            this.btButton.TabIndex = 4;
            this.btButton.Text = "Button";
            this.btButton.UseVisualStyleBackColor = true;
            this.btButton.Click += new System.EventHandler(this.BtButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 554);
            this.Controls.Add(this.btButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btFontParam;
        private System.Windows.Forms.ToolStripComboBox cbFontSize;
        private System.Windows.Forms.ToolStripComboBox cbFontColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btAlignLeft;
        private System.Windows.Forms.ToolStripButton btAlignCenter;
        private System.Windows.Forms.ToolStripButton btAlignRight;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btTextBold;
        private System.Windows.Forms.ToolStripButton btTextItalic;
        private System.Windows.Forms.ToolStripButton btTextUnderline;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripButton cbFontBackColor;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btButton;
    }
}

