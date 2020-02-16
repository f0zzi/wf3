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
                cbFontBackColor.Items.Add(item);
            }
            cbFontColor.SelectedItem = KnownColor.Black;
            cbFontBackColor.SelectedItem = KnownColor.White;

        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text document (*.txt)|*.txt|Richtext document (*.rtf)|**.rtf";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(openFileDialog1.FileName) == "rtf")
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
                if (Path.GetExtension(saveFileDialog1.FileName) == "rtf")
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

        private void ToolStripComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionBackColor = Color.FromKnownColor((KnownColor)cbFontBackColor.SelectedItem);
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
            cbFontBackColor.SelectedItem = Enum.Parse(typeof(KnownColor), richTextBox1.SelectionBackColor.Name);
            cbFontColor.SelectedItem = Enum.Parse(typeof(KnownColor), richTextBox1.SelectionColor.Name);
            cbFontSize.SelectedItem = (int)richTextBox1.SelectionFont.Size;
        }
    }
}
