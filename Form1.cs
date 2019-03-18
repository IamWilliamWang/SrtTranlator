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

namespace SrtTranlatorGUI
{
    public partial class Form1 : Form
    {
        String[] originalLines = null;
        String originalTexts = null;
        String[] translatedLines = null;

        public Form1()
        {
            InitializeComponent();
        }

        private string ReadAllText(string filename)
        {
            StringBuilder fullText = new StringBuilder();
            using (FileStream file = new FileStream(filename, FileMode.Open))
            {
                StreamReader reader = new StreamReader(file);
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    fullText.AppendLine(line);
                }
            }
            return fullText.ToString().TrimEnd(new char[] { '\n', '\r' });
        }

        private void button选择文件_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            this.textBoxFilename.Text = openFileDialog.FileName;
            originalTexts = ReadAllText(openFileDialog.FileName);
            originalLines = originalTexts.Replace("\r","").Split('\n');
            textBoxLeft.Lines = originalLines;
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            StringBuilder textbox3Str = new StringBuilder();
            for (int lineIndex = 0; lineIndex < originalLines.Count(); lineIndex++) 
            {
                if (originalLines[lineIndex].Contains(" --> "))
                    textbox3Str.AppendLine(originalLines[++lineIndex]);
            }
            textBoxRight.Text = textbox3Str.ToString();
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            translatedLines = this.textBoxRight.Text.Replace("\r","").Split('\n');
            int i = 0, j = 0;
            for(;i<originalLines.Count();i++)
            {
                string line = originalLines[i];
                if (line.Contains(" --> "))
                {
                    i++;
                    if (IsEmptyString(originalLines[i]))
                        continue;
                    try
                    {
                        originalLines[i] = translatedLines[j++];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        break;
                    }
                }
            }
            if (j < translatedLines.Length || i < originalLines.Count())
            {
                this.originalTexts = this.textBoxLeft.Text;
                this.originalLines = originalTexts.Replace("\r", "").Split('\n');
                MessageBox.Show("检测到右方行数与左边对应行数不一致，请重新检查译文的正确性！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            printNewTexts();
        }

        private bool IsEmptyString(string str)
        {
            StringBuilder sb = new StringBuilder(str);
            return 
                sb.Replace(" ","").Replace("\n","").Replace("\r","").Replace("\t","")
                  .ToString() == "";
        }

        private void printNewTexts()
        {
            StringBuilder sb = new StringBuilder();
            foreach(string line in originalLines)
            {
                sb.AppendLine(line);
            }
            this.textBoxLeft.Text = sb.ToString();
        }

        private void button粘贴_Click(object sender, EventArgs e)
        {
            this.textBoxRight.Text = Clipboard.GetText();
        }

        private void button复制右边_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.textBoxRight.Text);
        }

        private void button存储左边_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
            File.WriteAllLines(saveFileDialog.FileName, this.textBoxLeft.Lines);
        }

        private void textBoxFilename_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void textBoxFilename_DragDrop(object sender, DragEventArgs e)
        {
            this.textBoxFilename.Text = ( (string[]) e.Data.GetData(DataFormats.FileDrop) )[0];
            originalTexts = ReadAllText(this.textBoxFilename.Text);
            originalLines = originalTexts.Replace("\r","").Split('\n');
            textBoxLeft.Lines = originalLines;
        }
    }
}
