namespace Bag_of_Words
{
    partial class TextEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCreateIndex = new MetroFramework.Controls.MetroButton();
            this.btnSplitSpaces = new MetroFramework.Controls.MetroButton();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.btnFindAndReplace = new MetroFramework.Controls.MetroButton();
            this.tileTextLarger = new MetroFramework.Controls.MetroTile();
            this.tileTextSmaller = new MetroFramework.Controls.MetroTile();
            this.tileItalic = new MetroFramework.Controls.MetroTile();
            this.tileBold = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cmbBoxFonts = new MetroFramework.Controls.MetroComboBox();
            this.tileAlignLeft = new MetroFramework.Controls.MetroTile();
            this.tileAlignCenter = new MetroFramework.Controls.MetroTile();
            this.tileAlignRight = new MetroFramework.Controls.MetroTile();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.textBox = new System.Windows.Forms.TextBox();
            this.panelEnterText = new MetroFramework.Controls.MetroPanel();
            this.btnSaveFile = new MetroFramework.Controls.MetroButton();
            this.btnNewFile = new MetroFramework.Controls.MetroButton();
            this.btnOpenFile = new MetroFramework.Controls.MetroButton();
            this.btnSaveAs = new MetroFramework.Controls.MetroButton();
            this.lblLetterCounter = new MetroFramework.Controls.MetroLabel();
            this.txtBoxSearch = new MetroFramework.Controls.MetroTextBox();
            this.lblWordCounter = new MetroFramework.Controls.MetroLabel();
            this.gridViewResults = new MetroFramework.Controls.MetroGrid();
            this.wordNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWords = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.panelResults = new MetroFramework.Controls.MetroPanel();
            this.txtBoxFind = new MetroFramework.Controls.MetroTextBox();
            this.txtBoxReplace = new MetroFramework.Controls.MetroTextBox();
            this.btnReplace = new MetroFramework.Controls.MetroButton();
            this.panelFindAndReplace = new MetroFramework.Controls.MetroPanel();
            this.btnBack1 = new MetroFramework.Controls.MetroButton();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tileSwitchLang = new MetroFramework.Controls.MetroTile();
            this.panelEnterText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewResults)).BeginInit();
            this.panelResults.SuspendLayout();
            this.panelFindAndReplace.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateIndex
            // 
            this.btnCreateIndex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreateIndex.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCreateIndex.Location = new System.Drawing.Point(1066, 143);
            this.btnCreateIndex.Name = "btnCreateIndex";
            this.btnCreateIndex.Size = new System.Drawing.Size(180, 80);
            this.btnCreateIndex.TabIndex = 0;
            this.btnCreateIndex.Text = "تهميش النص";
            this.btnCreateIndex.UseSelectable = true;
            this.btnCreateIndex.Click += new System.EventHandler(this.btnCreateIndex_Click);
            // 
            // btnSplitSpaces
            // 
            this.btnSplitSpaces.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSplitSpaces.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSplitSpaces.Location = new System.Drawing.Point(1066, 277);
            this.btnSplitSpaces.Name = "btnSplitSpaces";
            this.btnSplitSpaces.Size = new System.Drawing.Size(180, 80);
            this.btnSplitSpaces.TabIndex = 2;
            this.btnSplitSpaces.Text = "تقسيم النص";
            this.btnSplitSpaces.UseSelectable = true;
            this.btnSplitSpaces.Click += new System.EventHandler(this.btnSplitSpaces_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSearch.Location = new System.Drawing.Point(1066, 412);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(180, 80);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "بحث";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.MouseHover += new System.EventHandler(this.btnSearch_MouseHover);
            // 
            // btnFindAndReplace
            // 
            this.btnFindAndReplace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFindAndReplace.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnFindAndReplace.Location = new System.Drawing.Point(1066, 547);
            this.btnFindAndReplace.Name = "btnFindAndReplace";
            this.btnFindAndReplace.Size = new System.Drawing.Size(180, 80);
            this.btnFindAndReplace.TabIndex = 4;
            this.btnFindAndReplace.Text = "بحث و إستبدال";
            this.btnFindAndReplace.UseSelectable = true;
            this.btnFindAndReplace.Click += new System.EventHandler(this.btnFindAndReplace_Click);
            // 
            // tileTextLarger
            // 
            this.tileTextLarger.ActiveControl = null;
            this.tileTextLarger.Location = new System.Drawing.Point(24, 29);
            this.tileTextLarger.Name = "tileTextLarger";
            this.tileTextLarger.Size = new System.Drawing.Size(70, 70);
            this.tileTextLarger.Style = MetroFramework.MetroColorStyle.Silver;
            this.tileTextLarger.TabIndex = 5;
            this.tileTextLarger.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tileTextLarger.TileImage = ((System.Drawing.Image)(resources.GetObject("tileTextLarger.TileImage")));
            this.tileTextLarger.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileTextLarger.UseSelectable = true;
            this.tileTextLarger.UseTileImage = true;
            this.tileTextLarger.Click += new System.EventHandler(this.tileTextLarger_Click);
            // 
            // tileTextSmaller
            // 
            this.tileTextSmaller.ActiveControl = null;
            this.tileTextSmaller.Location = new System.Drawing.Point(100, 29);
            this.tileTextSmaller.Name = "tileTextSmaller";
            this.tileTextSmaller.Size = new System.Drawing.Size(70, 70);
            this.tileTextSmaller.Style = MetroFramework.MetroColorStyle.Silver;
            this.tileTextSmaller.TabIndex = 6;
            this.tileTextSmaller.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tileTextSmaller.TileImage = ((System.Drawing.Image)(resources.GetObject("tileTextSmaller.TileImage")));
            this.tileTextSmaller.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileTextSmaller.UseSelectable = true;
            this.tileTextSmaller.UseTileImage = true;
            this.tileTextSmaller.Click += new System.EventHandler(this.tileTextSmaller_Click);
            // 
            // tileItalic
            // 
            this.tileItalic.ActiveControl = null;
            this.tileItalic.Location = new System.Drawing.Point(176, 29);
            this.tileItalic.Name = "tileItalic";
            this.tileItalic.Size = new System.Drawing.Size(70, 70);
            this.tileItalic.Style = MetroFramework.MetroColorStyle.Silver;
            this.tileItalic.TabIndex = 7;
            this.tileItalic.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tileItalic.TileImage = ((System.Drawing.Image)(resources.GetObject("tileItalic.TileImage")));
            this.tileItalic.UseSelectable = true;
            this.tileItalic.UseTileImage = true;
            this.tileItalic.Click += new System.EventHandler(this.tileItalic_Click);
            // 
            // tileBold
            // 
            this.tileBold.ActiveControl = null;
            this.tileBold.Location = new System.Drawing.Point(252, 29);
            this.tileBold.Name = "tileBold";
            this.tileBold.Size = new System.Drawing.Size(70, 70);
            this.tileBold.Style = MetroFramework.MetroColorStyle.Silver;
            this.tileBold.TabIndex = 8;
            this.tileBold.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tileBold.TileImage = ((System.Drawing.Image)(resources.GetObject("tileBold.TileImage")));
            this.tileBold.UseSelectable = true;
            this.tileBold.UseTileImage = true;
            this.tileBold.Click += new System.EventHandler(this.tileBold_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(329, 29);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "إختيار الخط";
            // 
            // cmbBoxFonts
            // 
            this.cmbBoxFonts.FormattingEnabled = true;
            this.cmbBoxFonts.ItemHeight = 23;
            this.cmbBoxFonts.Location = new System.Drawing.Point(329, 62);
            this.cmbBoxFonts.Name = "cmbBoxFonts";
            this.cmbBoxFonts.Size = new System.Drawing.Size(165, 29);
            this.cmbBoxFonts.Style = MetroFramework.MetroColorStyle.Silver;
            this.cmbBoxFonts.TabIndex = 10;
            this.cmbBoxFonts.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cmbBoxFonts.UseSelectable = true;
            this.cmbBoxFonts.SelectedIndexChanged += new System.EventHandler(this.cmbBoxFonts_SelectedIndexChanged);
            // 
            // tileAlignLeft
            // 
            this.tileAlignLeft.ActiveControl = null;
            this.tileAlignLeft.Location = new System.Drawing.Point(575, 29);
            this.tileAlignLeft.Name = "tileAlignLeft";
            this.tileAlignLeft.Size = new System.Drawing.Size(70, 70);
            this.tileAlignLeft.Style = MetroFramework.MetroColorStyle.Silver;
            this.tileAlignLeft.TabIndex = 11;
            this.tileAlignLeft.Text = " ";
            this.tileAlignLeft.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tileAlignLeft.TileImage = ((System.Drawing.Image)(resources.GetObject("tileAlignLeft.TileImage")));
            this.tileAlignLeft.UseSelectable = true;
            this.tileAlignLeft.UseTileImage = true;
            this.tileAlignLeft.Click += new System.EventHandler(this.tileAlignLeft_Click);
            // 
            // tileAlignCenter
            // 
            this.tileAlignCenter.ActiveControl = null;
            this.tileAlignCenter.Location = new System.Drawing.Point(651, 29);
            this.tileAlignCenter.Name = "tileAlignCenter";
            this.tileAlignCenter.Size = new System.Drawing.Size(70, 70);
            this.tileAlignCenter.Style = MetroFramework.MetroColorStyle.Silver;
            this.tileAlignCenter.TabIndex = 12;
            this.tileAlignCenter.Text = " ";
            this.tileAlignCenter.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tileAlignCenter.TileImage = ((System.Drawing.Image)(resources.GetObject("tileAlignCenter.TileImage")));
            this.tileAlignCenter.UseSelectable = true;
            this.tileAlignCenter.UseTileImage = true;
            this.tileAlignCenter.Click += new System.EventHandler(this.tileAlignCenter_Click);
            // 
            // tileAlignRight
            // 
            this.tileAlignRight.ActiveControl = null;
            this.tileAlignRight.Location = new System.Drawing.Point(727, 29);
            this.tileAlignRight.Name = "tileAlignRight";
            this.tileAlignRight.Size = new System.Drawing.Size(70, 70);
            this.tileAlignRight.Style = MetroFramework.MetroColorStyle.Silver;
            this.tileAlignRight.TabIndex = 13;
            this.tileAlignRight.Text = " ";
            this.tileAlignRight.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tileAlignRight.TileImage = ((System.Drawing.Image)(resources.GetObject("tileAlignRight.TileImage")));
            this.tileAlignRight.UseSelectable = true;
            this.tileAlignRight.UseTileImage = true;
            this.tileAlignRight.Click += new System.EventHandler(this.tileAlignRight_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(500, 29);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(51, 19);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "المحاذاة";
            // 
            // textBox
            // 
            this.textBox.AcceptsReturn = true;
            this.textBox.AcceptsTab = true;
            this.textBox.Location = new System.Drawing.Point(24, 143);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(998, 453);
            this.textBox.TabIndex = 15;
            this.textBox.Text = "أدخل النص هنا...";
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox.Click += new System.EventHandler(this.textBox_Click);
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // panelEnterText
            // 
            this.panelEnterText.Controls.Add(this.btnSaveFile);
            this.panelEnterText.Controls.Add(this.btnNewFile);
            this.panelEnterText.Controls.Add(this.btnOpenFile);
            this.panelEnterText.Controls.Add(this.btnSaveAs);
            this.panelEnterText.Controls.Add(this.lblLetterCounter);
            this.panelEnterText.Controls.Add(this.txtBoxSearch);
            this.panelEnterText.Controls.Add(this.lblWordCounter);
            this.panelEnterText.Controls.Add(this.textBox);
            this.panelEnterText.Controls.Add(this.metroLabel2);
            this.panelEnterText.Controls.Add(this.tileAlignRight);
            this.panelEnterText.Controls.Add(this.tileAlignCenter);
            this.panelEnterText.Controls.Add(this.tileAlignLeft);
            this.panelEnterText.Controls.Add(this.cmbBoxFonts);
            this.panelEnterText.Controls.Add(this.metroLabel1);
            this.panelEnterText.Controls.Add(this.tileBold);
            this.panelEnterText.Controls.Add(this.tileItalic);
            this.panelEnterText.Controls.Add(this.tileTextSmaller);
            this.panelEnterText.Controls.Add(this.tileTextLarger);
            this.panelEnterText.Controls.Add(this.btnFindAndReplace);
            this.panelEnterText.Controls.Add(this.btnSearch);
            this.panelEnterText.Controls.Add(this.btnSplitSpaces);
            this.panelEnterText.Controls.Add(this.btnCreateIndex);
            this.panelEnterText.HorizontalScrollbarBarColor = true;
            this.panelEnterText.HorizontalScrollbarHighlightOnWheel = false;
            this.panelEnterText.HorizontalScrollbarSize = 10;
            this.panelEnterText.Location = new System.Drawing.Point(0, 67);
            this.panelEnterText.Name = "panelEnterText";
            this.panelEnterText.Size = new System.Drawing.Size(1289, 633);
            this.panelEnterText.TabIndex = 16;
            this.panelEnterText.VerticalScrollbarBarColor = true;
            this.panelEnterText.VerticalScrollbarHighlightOnWheel = false;
            this.panelEnterText.VerticalScrollbarSize = 10;
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(395, 602);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(116, 31);
            this.btnSaveFile.TabIndex = 22;
            this.btnSaveFile.Text = "حفظ الملف";
            this.btnSaveFile.UseSelectable = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnNewFile
            // 
            this.btnNewFile.Location = new System.Drawing.Point(242, 602);
            this.btnNewFile.Name = "btnNewFile";
            this.btnNewFile.Size = new System.Drawing.Size(116, 31);
            this.btnNewFile.TabIndex = 21;
            this.btnNewFile.Text = "ملف جديد";
            this.btnNewFile.UseSelectable = true;
            this.btnNewFile.Click += new System.EventHandler(this.btnNewFile_Click_1);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(700, 602);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(116, 31);
            this.btnOpenFile.TabIndex = 20;
            this.btnOpenFile.Text = "فتح ملف";
            this.btnOpenFile.UseSelectable = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Location = new System.Drawing.Point(547, 602);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(116, 31);
            this.btnSaveAs.TabIndex = 19;
            this.btnSaveAs.Text = "حفظ كملف جديد";
            this.btnSaveAs.UseSelectable = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // lblLetterCounter
            // 
            this.lblLetterCounter.AutoSize = true;
            this.lblLetterCounter.Location = new System.Drawing.Point(920, 97);
            this.lblLetterCounter.Name = "lblLetterCounter";
            this.lblLetterCounter.Size = new System.Drawing.Size(79, 19);
            this.lblLetterCounter.TabIndex = 18;
            this.lblLetterCounter.Text = "عدد الحروف: ";
            // 
            // txtBoxSearch
            // 
            // 
            // 
            // 
            this.txtBoxSearch.CustomButton.Image = null;
            this.txtBoxSearch.CustomButton.Location = new System.Drawing.Point(158, 1);
            this.txtBoxSearch.CustomButton.Name = "";
            this.txtBoxSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBoxSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxSearch.CustomButton.TabIndex = 1;
            this.txtBoxSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxSearch.CustomButton.UseSelectable = true;
            this.txtBoxSearch.CustomButton.Visible = false;
            this.txtBoxSearch.Lines = new string[0];
            this.txtBoxSearch.Location = new System.Drawing.Point(1066, 498);
            this.txtBoxSearch.MaxLength = 32767;
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.PasswordChar = '\0';
            this.txtBoxSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxSearch.SelectedText = "";
            this.txtBoxSearch.SelectionLength = 0;
            this.txtBoxSearch.SelectionStart = 0;
            this.txtBoxSearch.Size = new System.Drawing.Size(180, 23);
            this.txtBoxSearch.TabIndex = 17;
            this.txtBoxSearch.UseSelectable = true;
            this.txtBoxSearch.Visible = false;
            this.txtBoxSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblWordCounter
            // 
            this.lblWordCounter.AutoSize = true;
            this.lblWordCounter.Location = new System.Drawing.Point(920, 119);
            this.lblWordCounter.Name = "lblWordCounter";
            this.lblWordCounter.Size = new System.Drawing.Size(82, 19);
            this.lblWordCounter.TabIndex = 16;
            this.lblWordCounter.Text = "عدد الكلمات: ";
            // 
            // gridViewResults
            // 
            this.gridViewResults.AllowUserToResizeRows = false;
            this.gridViewResults.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridViewResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridViewResults.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridViewResults.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wordNumber,
            this.colWords,
            this.colFrequency});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewResults.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridViewResults.EnableHeadersVisualStyles = false;
            this.gridViewResults.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridViewResults.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridViewResults.Location = new System.Drawing.Point(23, 0);
            this.gridViewResults.Name = "gridViewResults";
            this.gridViewResults.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewResults.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridViewResults.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridViewResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridViewResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewResults.Size = new System.Drawing.Size(414, 597);
            this.gridViewResults.Style = MetroFramework.MetroColorStyle.Silver;
            this.gridViewResults.TabIndex = 17;
            this.gridViewResults.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // wordNumber
            // 
            this.wordNumber.HeaderText = "#";
            this.wordNumber.Name = "wordNumber";
            this.wordNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.wordNumber.Width = 25;
            // 
            // colWords
            // 
            this.colWords.HeaderText = "الكلمات";
            this.colWords.Name = "colWords";
            this.colWords.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colWords.Width = 250;
            // 
            // colFrequency
            // 
            this.colFrequency.HeaderText = "التردد";
            this.colFrequency.Name = "colFrequency";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(146, 611);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "عودة";
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panelResults
            // 
            this.panelResults.Controls.Add(this.gridViewResults);
            this.panelResults.Controls.Add(this.btnBack);
            this.panelResults.HorizontalScrollbarBarColor = true;
            this.panelResults.HorizontalScrollbarHighlightOnWheel = false;
            this.panelResults.HorizontalScrollbarSize = 10;
            this.panelResults.Location = new System.Drawing.Point(0, 58);
            this.panelResults.Name = "panelResults";
            this.panelResults.Size = new System.Drawing.Size(465, 658);
            this.panelResults.TabIndex = 19;
            this.panelResults.VerticalScrollbarBarColor = true;
            this.panelResults.VerticalScrollbarHighlightOnWheel = false;
            this.panelResults.VerticalScrollbarSize = 10;
            this.panelResults.Visible = false;
            // 
            // txtBoxFind
            // 
            this.txtBoxFind.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtBoxFind.CustomButton.Image = null;
            this.txtBoxFind.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.txtBoxFind.CustomButton.Name = "";
            this.txtBoxFind.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBoxFind.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxFind.CustomButton.TabIndex = 1;
            this.txtBoxFind.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxFind.CustomButton.UseSelectable = true;
            this.txtBoxFind.CustomButton.Visible = false;
            this.txtBoxFind.Lines = new string[0];
            this.txtBoxFind.Location = new System.Drawing.Point(443, 36);
            this.txtBoxFind.MaxLength = 32767;
            this.txtBoxFind.Name = "txtBoxFind";
            this.txtBoxFind.PasswordChar = '\0';
            this.txtBoxFind.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxFind.SelectedText = "";
            this.txtBoxFind.SelectionLength = 0;
            this.txtBoxFind.SelectionStart = 0;
            this.txtBoxFind.Size = new System.Drawing.Size(172, 23);
            this.txtBoxFind.TabIndex = 20;
            this.txtBoxFind.UseSelectable = true;
            this.txtBoxFind.WaterMark = "النص القديم...";
            this.txtBoxFind.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxFind.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBoxReplace
            // 
            this.txtBoxReplace.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtBoxReplace.CustomButton.Image = null;
            this.txtBoxReplace.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.txtBoxReplace.CustomButton.Name = "";
            this.txtBoxReplace.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBoxReplace.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxReplace.CustomButton.TabIndex = 1;
            this.txtBoxReplace.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxReplace.CustomButton.UseSelectable = true;
            this.txtBoxReplace.CustomButton.Visible = false;
            this.txtBoxReplace.Lines = new string[0];
            this.txtBoxReplace.Location = new System.Drawing.Point(664, 36);
            this.txtBoxReplace.MaxLength = 32767;
            this.txtBoxReplace.Name = "txtBoxReplace";
            this.txtBoxReplace.PasswordChar = '\0';
            this.txtBoxReplace.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxReplace.SelectedText = "";
            this.txtBoxReplace.SelectionLength = 0;
            this.txtBoxReplace.SelectionStart = 0;
            this.txtBoxReplace.Size = new System.Drawing.Size(172, 23);
            this.txtBoxReplace.TabIndex = 21;
            this.txtBoxReplace.UseSelectable = true;
            this.txtBoxReplace.WaterMark = "النص الجديد...";
            this.txtBoxReplace.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxReplace.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnReplace
            // 
            this.btnReplace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReplace.Location = new System.Drawing.Point(443, 103);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(393, 38);
            this.btnReplace.TabIndex = 22;
            this.btnReplace.Text = "بحث و إستبدال";
            this.btnReplace.UseSelectable = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // panelFindAndReplace
            // 
            this.panelFindAndReplace.Controls.Add(this.btnBack1);
            this.panelFindAndReplace.Controls.Add(this.btnReplace);
            this.panelFindAndReplace.Controls.Add(this.txtBoxReplace);
            this.panelFindAndReplace.Controls.Add(this.txtBoxFind);
            this.panelFindAndReplace.HorizontalScrollbarBarColor = true;
            this.panelFindAndReplace.HorizontalScrollbarHighlightOnWheel = false;
            this.panelFindAndReplace.HorizontalScrollbarSize = 10;
            this.panelFindAndReplace.Location = new System.Drawing.Point(0, 119);
            this.panelFindAndReplace.Name = "panelFindAndReplace";
            this.panelFindAndReplace.Size = new System.Drawing.Size(1278, 217);
            this.panelFindAndReplace.TabIndex = 23;
            this.panelFindAndReplace.VerticalScrollbarBarColor = true;
            this.panelFindAndReplace.VerticalScrollbarHighlightOnWheel = false;
            this.panelFindAndReplace.VerticalScrollbarSize = 10;
            this.panelFindAndReplace.Visible = false;
            // 
            // btnBack1
            // 
            this.btnBack1.Location = new System.Drawing.Point(553, 168);
            this.btnBack1.Name = "btnBack1";
            this.btnBack1.Size = new System.Drawing.Size(175, 23);
            this.btnBack1.TabIndex = 23;
            this.btnBack1.Text = "عودة";
            this.btnBack1.UseSelectable = true;
            this.btnBack1.Click += new System.EventHandler(this.btnBack1_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // tileSwitchLang
            // 
            this.tileSwitchLang.ActiveControl = null;
            this.tileSwitchLang.Location = new System.Drawing.Point(1066, 38);
            this.tileSwitchLang.Name = "tileSwitchLang";
            this.tileSwitchLang.Size = new System.Drawing.Size(180, 23);
            this.tileSwitchLang.Style = MetroFramework.MetroColorStyle.Silver;
            this.tileSwitchLang.TabIndex = 25;
            this.tileSwitchLang.Text = "اللغة: العربية";
            this.tileSwitchLang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileSwitchLang.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tileSwitchLang.UseSelectable = true;
            this.tileSwitchLang.Click += new System.EventHandler(this.tileSwitchLang_Click);
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.tileSwitchLang);
            this.Controls.Add(this.panelFindAndReplace);
            this.Controls.Add(this.panelResults);
            this.Controls.Add(this.panelEnterText);
            this.MaximizeBox = false;
            this.Name = "TextEditor";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "محرر النص";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelEnterText.ResumeLayout(false);
            this.panelEnterText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewResults)).EndInit();
            this.panelResults.ResumeLayout(false);
            this.panelFindAndReplace.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnCreateIndex;
        private MetroFramework.Controls.MetroButton btnSplitSpaces;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroButton btnFindAndReplace;
        private MetroFramework.Controls.MetroTile tileTextLarger;
        private MetroFramework.Controls.MetroTile tileTextSmaller;
        private MetroFramework.Controls.MetroTile tileItalic;
        private MetroFramework.Controls.MetroTile tileBold;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmbBoxFonts;
        private MetroFramework.Controls.MetroTile tileAlignLeft;
        private MetroFramework.Controls.MetroTile tileAlignCenter;
        private MetroFramework.Controls.MetroTile tileAlignRight;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.TextBox textBox;
        private MetroFramework.Controls.MetroPanel panelEnterText;
        private MetroFramework.Controls.MetroGrid gridViewResults;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroLabel lblWordCounter;
        private MetroFramework.Controls.MetroTextBox txtBoxSearch;
        private MetroFramework.Controls.MetroLabel lblLetterCounter;
        private MetroFramework.Controls.MetroPanel panelResults;
        private MetroFramework.Controls.MetroTextBox txtBoxFind;
        private MetroFramework.Controls.MetroTextBox txtBoxReplace;
        private MetroFramework.Controls.MetroButton btnReplace;
        private MetroFramework.Controls.MetroPanel panelFindAndReplace;
        private MetroFramework.Controls.MetroButton btnSaveAs;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private MetroFramework.Controls.MetroButton btnNewFile;
        private MetroFramework.Controls.MetroButton btnOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWords;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFrequency;
        private MetroFramework.Controls.MetroButton btnBack1;
        private MetroFramework.Controls.MetroTile tileSwitchLang;
        private MetroFramework.Controls.MetroButton btnSaveFile;
    }
}

