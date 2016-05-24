using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace Bag_of_Words
{
    public partial class TextEditor : MetroForm
    {
        bool isBold = false;
        bool isItalic = false;
        List<String> index;
        public TextEditor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            index = new List<string>();
            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                cmbBoxFonts.Items.Add(font.Name);
            }
        }

        private void btnCreateIndex_Click(object sender, EventArgs e)
        {
            String str = textBox.Text;
            str = str.Replace(System.Environment.NewLine, " ");
            panelEnterText.Visible = false;
            index = new List<string>();
            String[] words = str.Split(' ');
            foreach (String word in words)
            {
                if (!index.Contains<String>(word.ToLower()))
                {
                    index.Add(word.ToLower());
                }
            }
            for (int i = 0; i < index.Count; i++)
            {
                gridViewResults.Rows.Add((i + 1), index[i]);
            }
            this.Width = 375;
            panelResults.Visible = true;
        }

//Font size, style and color controls

        private void tileTextLarger_Click(object sender, EventArgs e)
        {
            textBox.Font = new Font(textBox.Font.FontFamily, (textBox.Font.Size + 1));
        }

        private void tileTextSmaller_Click(object sender, EventArgs e)
        {
            textBox.Font = new Font(textBox.Font.FontFamily, (textBox.Font.Size - 1));
        }

        private void tileItalic_Click(object sender, EventArgs e)
        {
            if (!isItalic)
            {
                textBox.Font = new Font(textBox.Font, FontStyle.Italic);
                isItalic = true;
            }
            else
            {
                textBox.Font = new Font(textBox.Font, FontStyle.Regular);
                isItalic = false;
            }
        }

        private void tileBold_Click(object sender, EventArgs e)
        {
            if (!isBold)
            {
                textBox.Font = new Font(textBox.Font, FontStyle.Bold);
                isBold = true;
            }
            else
            {
                textBox.Font = new Font(textBox.Font, FontStyle.Regular);
                isBold = false;
            }
        }

        private void cmbBoxFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox.Font = new Font(new FontFamily(cmbBoxFonts.SelectedItem.ToString()), 15);
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            lblWordCounter.Text = "Word count: " + (textBox.Text.Split(' ', '\n').Length);
            lblLetterCounter.Text = "Letter Count: " + textBox.Text.Length;
        }

        private void tileAlignLeft_Click(object sender, EventArgs e)
        {
            textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
        }

        private void tileAlignCenter_Click(object sender, EventArgs e)
        {

            textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        }

        private void tileAlignRight_Click(object sender, EventArgs e)
        {

            textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panelEnterText.Visible = true;
            panelResults.Visible = false;
            this.Width = 1280;
            gridViewResults.Rows.Clear();
        }

        private void btnSplitSpaces_Click(object sender, EventArgs e)
        {
            String str = textBox.Text;
            str = str.Replace(System.Environment.NewLine, " ");
            panelEnterText.Visible = false;
            String[] words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                gridViewResults.Rows.Add((i + 1), words[i]);
            }
            this.Width = 375;
            panelResults.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int count = 0;
            txtBoxSearch.Visible = false;
            if (txtBoxSearch.Text != "" || true)
            {
                String str = textBox.Text.ToLower();
                String[] words = str.Split(' ');
                DateTime before = DateTime.Now;
                for (int i = 0; i < words.Length; i++)
                {
                    if (txtBoxSearch.Text.ToLower() == words[i])
                    {
                        DateTime after = DateTime.Now;
                        TimeSpan timeElapsed = after - before;
                        MetroFramework.MetroMessageBox.Show(this, "Found\nWord #" + (i + 1) + "\nTime Elapsed: " + timeElapsed.ToString(), "Search Results");
                        textBox.SelectionStart = count;
                        textBox.SelectionLength = words[i].Length;
                        this.ActiveControl = textBox;
                        txtBoxSearch.Clear();
                        return;
                    }
                    count += (words[i].Length + 1);
                }
                MetroFramework.MetroMessageBox.Show(this, "Not Found\n", "Search Results");
                txtBoxSearch.Clear();
            }
        }

        private void btnSearch_MouseHover(object sender, EventArgs e)
        {
            txtBoxSearch.Visible = true;
        }

        private void textBox_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "Enter Text Here...")
            {
                textBox.Text = "";
            }
        }

        private void btnFindAndReplace_Click(object sender, EventArgs e)
        {
            panelEnterText.Visible = false;
            panelFindAndReplace.Visible = true;
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            panelEnterText.Visible = true;
            panelFindAndReplace.Visible = false;
            textBox.Text = textBox.Text.Replace(txtBoxFind.Text, txtBoxReplace.Text);
            txtBoxFind.Clear();
            txtBoxReplace.Clear();
        }

        private void btnSaveText_Click(object sender, EventArgs e)
        {
            String path = "";
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                path = saveFileDialog1.FileName;
                MessageBox.Show(path);
                FileStream FS = new FileStream(path, FileMode.Create);
                StreamWriter SW = new StreamWriter(FS);
                SW.Write(textBox.Text);
                SW.Close();
                FS.Close();
            }
        }
    }
}
