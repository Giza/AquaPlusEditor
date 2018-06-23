﻿using AquaPlusEditor;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace APEGUI {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        bool DBMode = false;

        DBD DBEditor;
        CSTS ScriptEditor;
        private void extractToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "All *.pak packgets|*.pak;*.dat;*.sdat";
            if (fd.ShowDialog() != DialogResult.OK)
                return;

            Stream Packget = new StreamReader(fd.FileName).BaseStream;
            string Outdir = fd.FileName + "~\\";
            if (Directory.Exists(Outdir))
                Directory.Delete(Outdir, true);
            Directory.CreateDirectory(Outdir);

            Entry[] Entries = PAK.Open(Packget);

            foreach (var File in Entries) {
                string OP = Outdir + File.Filename;
                Stream Output = new StreamWriter(OP).BaseStream;
                File.Content.CopyTo(Output);
                Output.Flush();
                Output.Close();
            }
            MessageBox.Show("Packget extracted");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                textBox1.Text = listBox1.Items[listBox1.SelectedIndex].ToString();
                Text = "id: " + listBox1.SelectedIndex;
            } catch { }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == '\n' || e.KeyChar == '\r') {
                try {
                    listBox1.Items[listBox1.SelectedIndex] = textBox1.Text;
                } catch {

                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "All Script Files|*.bin";
            if (fd.ShowDialog() != DialogResult.OK)
                return;

            byte[] Script = File.ReadAllBytes(fd.FileName);
            string[] Strings;

            try {
                ScriptEditor = new CSTS(Script);
                Strings = ScriptEditor.Import();
            } catch {
                DBMode = true;
                DBEditor = new DBD(Script);
                Strings = DBEditor.Import();
            }

            listBox1.Items.Clear();
            foreach (string str in Strings)
                listBox1.Items.Add(str);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "All Script Files|*.bin";
            if (fd.ShowDialog() != DialogResult.OK)
                return;

            string[] Strings = listBox1.Items.Cast<string>().ToArray();
            byte[] Script = DBMode ? DBEditor.Export(Strings) : ScriptEditor.Export(Strings);
            File.WriteAllBytes(fd.FileName, Script);

            MessageBox.Show("Script Saved");
        }

        private void repackToolStripMenuItem_Click(object sender, EventArgs e) {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Folder to pack";
            if (fbd.ShowDialog() != DialogResult.OK)
                return;

            SaveFileDialog fd = new SaveFileDialog();
            fd.Title = "Save as...";
            fd.Filter = "All *.pak packgets|*.pak;*.dat;*.sdat";

            if (fd.ShowDialog() != DialogResult.OK)
                return;

            bool BigEnddian = MessageBox.Show("Pack with BigEnddian?\nYes: PS3 Format\nNo: PSV/PS4 Format", "APEGUI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;

            if (!fbd.SelectedPath.EndsWith("\\"))
                fbd.SelectedPath += '\\';

            string[] Files = Directory.GetFiles(fbd.SelectedPath, "*.*");

            Entry[] Entries = (from x in Files
                               select new Entry() {
                                   Filename = x.Substring(fbd.SelectedPath.Length),
                                   Content = new StreamReader(x).BaseStream
                               }).ToArray();

            Stream Output = new StreamWriter(fd.FileName).BaseStream;

            PAK.Save(Output, Entries, BigEnddian);
            MessageBox.Show("Packget Saved");
        }

        private void fntToolStripMenuItem_Click(object sender, EventArgs e) {
            Form2 form = new Form2();
            form.Show();
        }

        private void decodeToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "All Texture Files|*.tex";
            if (fd.ShowDialog() != DialogResult.OK)
                return;

            Stream Text = new StreamReader(fd.FileName).BaseStream;
            var Texture = new TEX(Text).Open();

            Stream Writer = new StreamWriter(fd.FileName + ".png").BaseStream;
            Texture.CopyTo(Writer);
            Writer.Close();
            Text?.Close();

            MessageBox.Show("Texture Decoded");
        }

        private void encodeToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "All Texture Files|*.tex";
            if (fd.ShowDialog() != DialogResult.OK)
                return;

            OpenFileDialog pfd = new OpenFileDialog();
            pfd.Filter = "All PNG Files|*.png";
            if (pfd.ShowDialog() != DialogResult.OK)
                return;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = fd.Filter;
            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            Stream Text = new StreamReader(fd.FileName).BaseStream;
            var Texture = new TEX(Text);
            Texture.Decode();

            Stream Output = new StreamWriter(sfd.FileName).BaseStream;
            Texture.Encode(Image.FromFile(pfd.FileName) as Bitmap, Output, true);
            Text.Close();
        }
    }
}
