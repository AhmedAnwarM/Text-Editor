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
        bool Arabic = true;
        List<String> index;
        List<int> frequency;
        public TextEditor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            switchToEnglish();
            index = new List<string>();
            frequency = new List<int>();
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
                    frequency.Add(1);
                }
                else
                {
                    int i = index.BinarySearch(word);
                    frequency[i]++;
                }
            }
            for (int i = 0; i < index.Count; i++)
            {
                gridViewResults.Rows.Add((i + 1), index[i], frequency[i]);
            }
            this.Width = 465;
            gridViewResults.Columns[2].Visible = true;
            btnBack.Width = 175;
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
            if (Arabic)
            {
                lblWordCounter.Text = "عدد الكلمات: " + (textBox.Text.Split(' ', '\n').Length);
                lblLetterCounter.Text = "عدد الحروف: " + textBox.Text.Length;
            }
            else
            {
                lblWordCounter.Text = "Word Count: " + (textBox.Text.Split(' ', '\n').Length);
                lblLetterCounter.Text = "Letter Count: " + textBox.Text.Length;
            }
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
            this.Width = 362;
            gridViewResults.Columns[2].Visible = false;
            btnBack.Width = 75;
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
                        if(Arabic)
                            MetroFramework.MetroMessageBox.Show(this, "تم العثور على الكلمة\nرقم الكلمة #" + (i + 1) + "\nوقت البحث: " + timeElapsed.ToString(), "نتيجة البحث");
                        else
                            MetroFramework.MetroMessageBox.Show(this, "Found!\nWord #" + (i + 1) + "\nTime Elapsed: " + timeElapsed.ToString(), "Search Result");
                        textBox.SelectionStart = count;
                        textBox.SelectionLength = words[i].Length;
                        this.ActiveControl = textBox;
                        txtBoxSearch.Clear();
                        return;
                    }
                    count += (words[i].Length + 1);
                }
                if(Arabic)
                    MetroFramework.MetroMessageBox.Show(this, "لم يتم العثور على الكلمة\n", "نتيجة البحث");
                else
                MetroFramework.MetroMessageBox.Show(this, "Not Found.\n", "Search Result");
                txtBoxSearch.Clear();
            }
        }

        private void btnSearch_MouseHover(object sender, EventArgs e)
        {
            txtBoxSearch.Visible = true;
        }

        private void textBox_Click(object sender, EventArgs e)
        {
            if ((Arabic && textBox.Text == "أدخل النص هنا...") || (!Arabic && textBox.Text == "Enter Text Here..."))
                textBox.Text = "";
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
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                path = saveFileDialog.FileName;
                FileStream FS = new FileStream(path, FileMode.Create);
                StreamWriter SW = new StreamWriter(FS);
                SW.Write(textBox.Text);
                SW.Close();
                FS.Close();
            }
            this.ActiveControl = textBox;
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            String path = "";
            String file = "";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                path = openFileDialog.FileName;
                FileStream FS = new FileStream(path, FileMode.Open);
                StreamReader SR = new StreamReader(FS);

                while(SR.Peek() != -1)
                {
                    file += (SR.ReadLine() + Environment.NewLine);
                }
                textBox.Text = file;
                SR.Close();
                FS.Close();
                this.ActiveControl = textBox;
            }
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            panelEnterText.Visible = true;
            panelFindAndReplace.Visible = false;
            txtBoxFind.Clear();
            txtBoxReplace.Clear();
        }

        private void btnNewFile_Click_1(object sender, EventArgs e)
        {
            textBox.Clear();
            this.ActiveControl = textBox;
        }
        private void switchToEnglish()
        {
            lblLetterCounter.TextAlign = ContentAlignment.MiddleLeft;
            lblWordCounter.TextAlign = ContentAlignment.MiddleLeft;
            tileSwitchLang.Text = "Language: English";
            btnCreateIndex.Text = "Create Index";
            btnSplitSpaces.Text = "Split Text";
            btnSearch.Text = "Search";
            btnFindAndReplace.Text = "Find and Replace";
            metroLabel1.Text = "Font Selection:";
            metroLabel2.Text = "Alignment";
            textBox.TextAlign = HorizontalAlignment.Left;
            textBox.Text = "Enter Text Here...";
            btnNewFile.Text = "New File";
            btnOpenFile.Text = "Open File";
            btnSaveFile.Text = "Save File";
            lblLetterCounter.Text = "Letter Count: ";
            lblWordCounter.Text = "Word Count: ";
            btnBack.Text = "Back";
            txtBoxFind.WaterMark = "Old Text...";
            txtBoxReplace.WaterMark = "New Text...";
            colWords.HeaderText = "Words";
            colFrequency.HeaderText = "Frequency";
            btnBack1.Text = "Back";
            this.Text = "Text Editor";
            btnReplace.Text = "Find and Replace";
            Arabic = false;
        }

        private void switchToArabic()
        {
            lblLetterCounter.TextAlign = ContentAlignment.MiddleRight;
            lblWordCounter.TextAlign = ContentAlignment.MiddleRight;
            tileSwitchLang.Text = "اللغة: العربية";
            btnCreateIndex.Text = "تهميش النص";
            btnSplitSpaces.Text = "تقسيم النص";
            btnSearch.Text = "بحث";
            btnFindAndReplace.Text = "بحث و إستبدال";
            metroLabel1.Text = "إختيار الخط";
            metroLabel2.Text = "المحاذاة";
            textBox.TextAlign = HorizontalAlignment.Right;
            textBox.Text = "أدخل النص هنا...";
            btnNewFile.Text = "ملف جديد";
            btnOpenFile.Text = "فتح ملف";
            btnSaveFile.Text = "حفظ الملف";
            lblLetterCounter.Text = "عدد الحروف: ";
            lblWordCounter.Text = "عدد الكلمات: ";
            btnBack.Text = "عودة";
            txtBoxFind.WaterMark = "النص القديم...";
            txtBoxReplace.WaterMark = "النص الجديد...";
            colWords.HeaderText = "الكلمات";
            colFrequency.HeaderText = "التردد";
            btnBack1.Text = "عودة";
            this.Text = "محرر النص";
            btnReplace.Text = "بحث و إستبدال";
            Arabic = true;
        }
        private void tileSwitchLang_Click(object sender, EventArgs e)
        {
            if (Arabic)
            {
                switchToEnglish();
            }
            else
            {
                switchToArabic();
            }
        }
    }
}

