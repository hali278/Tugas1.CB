using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private string currentFilePath = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buka_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = openFileDialog.FileName;
                try
                {
                    text_edit.Text = File.ReadAllText(currentFilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void simpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        currentFilePath = saveFileDialog.FileName;
                    }
                }
            }
            File.WriteAllText(currentFilePath, text_edit.Text);
        }

        private void hapus_Click(object sender, EventArgs e)
        {
            text_edit.Clear(); // Menghapus isi editor
            currentFilePath = ""; // Reset currentFilePath untuk menunjukkan file baru
        }

        private void cari_Click(object sender, EventArgs e)
        {
            string searchTerm = text_cari.Text;
            if (text_edit.Text.Contains(searchTerm))
            {
                MessageBox.Show("File ditemukan!");
            }
            else
            {
                MessageBox.Show("File tidak ditemukan.");
            }
        }
    }
}
