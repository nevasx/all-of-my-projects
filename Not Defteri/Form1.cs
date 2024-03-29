﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Not_Defteri
{
    public partial class Form1 : Form
    {
        private int TabCount = 0;           //Sekme Sayısı (anlık olarak aktif olan belgeler)
        public Form1()
        {
            InitializeComponent();
        }

        #region Metotlar
        #region Sekmeler
        private void AddTab()                //Sekme Ekleme
        {
            RichTextBox Body = new RichTextBox();
            Body.Name = "Body";
            Body.Dock = DockStyle.Fill;
            Body.ContextMenuStrip = contextMenuStrip1;


            TabPage NewPage = new TabPage();
            TabCount += 1;

                string DocumentText = "Belge" + TabCount;
            NewPage.Name = DocumentText;
            NewPage.Text = DocumentText;
            NewPage.Controls.Add(Body);

            tabControl1.TabPages.Add(NewPage);
        }
        private void RemoveTab()            //Sekme Kaldır
        {
            if(tabControl1.TabPages.Count !=1)
            {
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            }
            else
            {
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
                AddTab();
            }
        }
        private void RemoveAllTabs()         //Tüm Sekmeleri Kapat
        {
            foreach(TabPage Page in tabControl1.TabPages)
            {
                tabControl1.TabPages.Remove(Page);
            }
            AddTab();
        }
        private void RemoveAllTabButThis()   //Açık Olan Haricindeki Sekmeleri Kaldır
        {
            foreach (TabPage Page in tabControl1.TabPages)
            {
                if(Page.Name != tabControl1 .SelectedTab .Name)
                {
                    tabControl1.TabPages.Remove(Page);
                }
            }
        }
        #endregion
        #region SaveAndOpen (KaydetVeAç)
        private void Save()                  //Kaydetme İşlemi
        {
            saveFileDialog1.FileName = tabControl1.SelectedTab.Name;
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog1.Filter = "RTF|*.rtf";
            saveFileDialog1.Title = "save";

            if (saveFileDialog1 .ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if(saveFileDialog1 .FileName .Length > 0)
                {
                    GetCurrentDocument.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                }
            }
        }
        private void SaveAs()                //Farklı Kaydet
        {
            saveFileDialog1.FileName = tabControl1.SelectedTab.Name;
            saveFileDialog1.InitialDirectory =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog1.Filter = "Text Files|*.txt|C# dosyası|*.cs|Tüm Dosyalar|*.*";
            saveFileDialog1.Title = "Farklı Kaydet";

            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (saveFileDialog1.FileName.Length > 0)
                {
                    GetCurrentDocument.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                }
            }
        }
        private void Open()                  //Belgeyi Açma
        {
            openFileDialog1.InitialDirectory =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog1.Filter = "RTF|*.rtf|Text dosyası|*.txt|Tüm dosyalar|*.*";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if(openFileDialog1.FileName.Length > 0)
                {
                    GetCurrentDocument.LoadFile(openFileDialog1.FileName,
                        RichTextBoxStreamType.PlainText);
                }
            }
        }
        #endregion
        #region Özellikler
        private RichTextBox GetCurrentDocument//Aktif Belgeyi Al
        {
            get { return (RichTextBox)tabControl1.SelectedTab.Controls["Body"]; }
        }
        #endregion
        #region TextFunctions
        private void Undo()
        {
            GetCurrentDocument.Undo();
        }
        private void Redo()
        {
            GetCurrentDocument.Redo();
        }
        private void Cut()
        {
            GetCurrentDocument.Cut();
        }
        private void Copy()
        {
            GetCurrentDocument.Copy();
        }
        private void Paste()
        {
            GetCurrentDocument.Paste();
        }
        private void SelectAll()
        {
            GetCurrentDocument.SelectAll();
        }
        #endregion
        #region Font
        private void GetFontCollection()            //Fontların Yüklenmesi
        {
            InstalledFontCollection InsFonts = new InstalledFontCollection();
            foreach (FontFamily item in InsFonts.Families)
            {
                toolStripComboBoxFontType.Items.Add(item.Name);
            }
            toolStripComboBoxFontType.SelectedIndex = 0;
        }
        private void PopulateFontSize()             //Font Ölçeklerini Oluştur
        {
            for (int i=1; i<=75; i++)
            {
                toolStripComboBoxFontSize.Items.Add(i);
            }
            toolStripComboBoxFontSize.SelectedIndex = 12;
        }
        #endregion

        #endregion

        private void geriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void yineleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Redo();
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void tümünüSeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectAll();
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTab();
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void farklıKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void yeniToolStripButton_Click(object sender, EventArgs e)
        {
            AddTab();
        }

        private void removeToolStripButton_Click(object sender, EventArgs e)
        {
            RemoveTab();
        }

        private void açToolStripButton_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void kaydetToolStripButton_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void kesToolStripButton_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void kopyalaToolStripButton_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void yapıştırToolStripButton_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void toolStripButtonBOLD_Click(object sender, EventArgs e)
        {
            Font BoldFont = new Font(
                GetCurrentDocument.SelectionFont.FontFamily,
                GetCurrentDocument.SelectionFont.SizeInPoints, FontStyle.Bold);
            Font RegularFont = new Font(
                GetCurrentDocument.SelectionFont.FontFamily,
                GetCurrentDocument.SelectionFont.SizeInPoints, FontStyle.Regular);
            if (GetCurrentDocument.SelectionFont.Bold)
            {
                GetCurrentDocument.SelectionFont = RegularFont;
            }
            else
            {
                GetCurrentDocument.SelectionFont = BoldFont;
            }
        }

        private void toolStripButtonItalic_Click(object sender, EventArgs e)
        {
            Font ItalicFont = new Font(
                GetCurrentDocument.SelectionFont.FontFamily,
                GetCurrentDocument.SelectionFont.SizeInPoints, FontStyle.Italic);
            Font RegularFont = new Font(
                GetCurrentDocument.SelectionFont.FontFamily,
                GetCurrentDocument.SelectionFont.SizeInPoints, FontStyle.Regular);
            if (GetCurrentDocument.SelectionFont.Bold)
            {
                GetCurrentDocument.SelectionFont = RegularFont;
            }
            else
            {
                GetCurrentDocument.SelectionFont = ItalicFont;
            }
        }

        private void toolStripButtonUnderline_Click(object sender, EventArgs e)
        {
            Font UnderlineFont = new Font(
                GetCurrentDocument.SelectionFont.FontFamily,
                GetCurrentDocument.SelectionFont.SizeInPoints, FontStyle.Underline);
            Font RegularFont = new Font(
                GetCurrentDocument.SelectionFont.FontFamily,
                GetCurrentDocument.SelectionFont.SizeInPoints, FontStyle.Regular);
            if (GetCurrentDocument.SelectionFont.Bold)
            {
                GetCurrentDocument.SelectionFont = RegularFont;
            }
            else
            {
                GetCurrentDocument.SelectionFont = UnderlineFont;
            }
        }

        private void toolStripButtonStrikeout_Click(object sender, EventArgs e)
        {
            Font StrikeoutFont = new Font(
                GetCurrentDocument.SelectionFont.FontFamily,
                GetCurrentDocument.SelectionFont.SizeInPoints, FontStyle.Strikeout);
            Font RegularFont = new Font(
                GetCurrentDocument.SelectionFont.FontFamily,
                GetCurrentDocument.SelectionFont.SizeInPoints, FontStyle.Regular);
            if (GetCurrentDocument.SelectionFont.Bold)
            {
                GetCurrentDocument.SelectionFont = RegularFont;
            }
            else
            {
                GetCurrentDocument.SelectionFont = StrikeoutFont;
            }
        }

        private void toolStripButtonIncrease_Click(object sender, EventArgs e)
        {
            float NewFontSize = GetCurrentDocument.SelectionFont.SizeInPoints + 2;

            Font NewSize = new Font(GetCurrentDocument.SelectionFont.Name,
                NewFontSize, GetCurrentDocument.SelectionFont.Style);

            GetCurrentDocument.SelectionFont = NewSize;
        }

        private void toolStripButtonUpper_Click(object sender, EventArgs e)
        {
            GetCurrentDocument.SelectedText = GetCurrentDocument.SelectedText.ToUpper();
        }

        private void toolStripButtonLower_Click(object sender, EventArgs e)
        {
            GetCurrentDocument.SelectedText = GetCurrentDocument.SelectedText.ToLower();
        }

        private void toolStripButtonDecrease_Click(object sender, EventArgs e)
        {
            float NewFontSize = GetCurrentDocument.SelectionFont.SizeInPoints - 2;

            Font NewSize = new Font(GetCurrentDocument.SelectionFont.Name,
                NewFontSize, GetCurrentDocument.SelectionFont.Style);

            GetCurrentDocument.SelectionFont = NewSize;
        }

        private void toolStripButtonFontColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1 .ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                GetCurrentDocument.SelectionColor = colorDialog1.Color;
            }
        }

        private void toolStripMenuItemGreen_Click(object sender, EventArgs e)
        {
            GetCurrentDocument.SelectionBackColor = Color.Lime;
        }

        private void toolStripMenuItemOrange_Click(object sender, EventArgs e)
        {
            GetCurrentDocument.SelectionBackColor = Color.DarkOrange;
        }

        private void toolStripMenuItemYellow_Click(object sender, EventArgs e)
        {
            GetCurrentDocument.SelectionBackColor = Color.Gold;
        }

        private void toolStripComboBoxFontType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Font NewFont = new Font(toolStripComboBoxFontType.SelectedItem.ToString(),
                GetCurrentDocument.SelectionFont.Size,
                GetCurrentDocument.SelectionFont.Style);
            GetCurrentDocument.SelectionFont = NewFont;
        }

        private void toolStripComboBoxFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            float NewSize;
            float.TryParse(
                toolStripComboBoxFontSize.SelectedItem.ToString(),
                out NewSize);
            Font NewFont = new Font(
                GetCurrentDocument.SelectionFont.Name,
                NewSize,
                GetCurrentDocument.SelectionFont.Style);
            GetCurrentDocument.SelectionFont = NewFont;
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Redo();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            RemoveTab();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            RemoveAllTabs();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            RemoveAllTabButThis();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddTab();
            GetFontCollection();
            PopulateFontSize();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if  (GetCurrentDocument .Text .Length > 0)
            {
                toolStripStatusLabel1.Text = "Toplam Karakter Sayısı = " +
                    GetCurrentDocument.Text.Length.ToString();
            }
        }
    }
}
