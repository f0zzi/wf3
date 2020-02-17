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

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            errorProvider1.SetError(btButton, "Click Button!");
            saveFileDialog1.Filter = "Text document (*.txt)|*.txt|Richtext document (*.rtf)|**.rtf";
            for (int i = 6; i < 36; i += 2)
            {
                cbFontSize.Items.Add(i);
            }
            cbFontSize.SelectedIndex = 3;

            List<KnownColor> myColors = new List<KnownColor>();
            myColors.AddRange(typeof(KnownColor).GetEnumValues() as KnownColor[]);
            foreach (var item in myColors)
            {
                cbFontColor.Items.Add(item);
            }
            cbFontColor.SelectedItem = KnownColor.Black;

        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text document (*.txt)|*.txt|Richtext document (*.rtf)|**.rtf";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(openFileDialog1.FileName) == ".rtf")
                    richTextBox1.LoadFile(openFileDialog1.FileName);
                else
                    richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(saveFileDialog1.FileName) == ".rtf")
                    richTextBox1.SaveFile(saveFileDialog1.FileName);
                else
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(saveFileDialog1.FileName))
                richTextBox1.SaveFile(saveFileDialog1.FileName);
            else
                saveAsToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, (float)Convert.ToDouble(cbFontSize.SelectedItem));
            BtTextStyle_Click(null, null);
        }

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.FromKnownColor((KnownColor)cbFontColor.SelectedItem);
        }
        private void ResetAlign()
        {
            foreach (var item in toolStrip1.Items)
            {
                if (item is ToolStripButton
                    && (item as ToolStripButton).Tag != null
                    && (item as ToolStripButton).Tag.ToString() == "Align")
                    (item as ToolStripButton).Checked = false;
            }
        }
        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            ResetAlign();
            (sender as ToolStripButton).Checked = true;
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void BtAlignCenter_Click(object sender, EventArgs e)
        {
            ResetAlign();
            (sender as ToolStripButton).Checked = true;
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void BtAlignRight_Click(object sender, EventArgs e)
        {
            ResetAlign();
            (sender as ToolStripButton).Checked = true;
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }
        private FontStyle NewStyle()
        {
            int style = 0;
            if (btTextBold.Checked)
                style += 1;
            if (btTextItalic.Checked)
                style += 2;
            if (btTextUnderline.Checked)
                style += 4;
            return (FontStyle)style;
        }
        private void BtTextStyle_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, NewStyle());
        }
        private void RichTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            cbFontColor.SelectedItem = Enum.Parse(typeof(KnownColor), richTextBox1.SelectionColor.Name);
            cbFontSize.SelectedItem = (int)richTextBox1.SelectionFont.Size;
            btTextBold.Checked = richTextBox1.SelectionFont.Bold;
            btTextItalic.Checked = richTextBox1.SelectionFont.Italic;
            btTextUnderline.Checked = richTextBox1.SelectionFont.Underline;
            ResetAlign();
            switch (richTextBox1.SelectionAlignment.ToString())
            {
                case "Left":
                    btAlignLeft.Checked = true;
                    break;
                case "Center":
                    btAlignCenter.Checked = true;
                    break;
                case "Right":
                    btAlignRight.Checked = true;
                    break;
                default:
                    break;
            }
        }
        private void CbFontBackColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionBackColor = colorDialog1.Color;
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
                ShowInTaskbar = false;
                notifyIcon1.BalloonTipText = "I am still working";
                notifyIcon1.ShowBalloonTip(2000);
            }
            else if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
                ShowInTaskbar = true;
            }
        }
        private void RichTextBox1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                notifyIcon1.BalloonTipText = "Normal";
                notifyIcon1.ShowBalloonTip(2000);
                ShowInTaskbar = true;
            }
            else if (WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.BalloonTipText = "I am still working";
                notifyIcon1.ShowBalloonTip(2000);
                ShowInTaskbar = false;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                notifyIcon1.BalloonTipText = "Maximized";
                notifyIcon1.ShowBalloonTip(2000);
                ShowInTaskbar = true;
            }
        }

        private void BtButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
    }
}
