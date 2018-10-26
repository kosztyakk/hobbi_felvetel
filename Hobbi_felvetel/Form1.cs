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

namespace Hobbi_felvetel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hobbi_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void hozzad_button_Click(object sender, EventArgs e)
        {
            hobbi_listBox.Items.Add(ujhobbi_textbox.Text);
        }

        private void mentes_button_Click(object sender, EventArgs e)
        {
            string sor = "";
            if (FERFI_radioButton.Checked)
            {
                sor = nev_textBox.Text + ";" + szuletes_picker.Text + ";" +"Férfi"+";" + hobbi_listBox.SelectedItem;
            }
            if (NO_radioButton.Checked)
            {
                sor = nev_textBox.Text + ";" + szuletes_picker.Text + ";" +"Nő"+";" + hobbi_listBox.SelectedItem;
            }
           
            SaveFileDialog dlg = new SaveFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(dlg.FileName);
                writer.WriteLine(sor);
                for (int i = 0; i < hobbi_listBox.Items.Count-1; i++)
                {
                    writer.Write((string)hobbi_listBox.Items[i]+";");

                }
                writer.Write((string)hobbi_listBox.Items[hobbi_listBox.Items.Count - 1]);
                writer.Close();
            }

            dlg.Dispose();
        }

        private void megnyitas_button_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog fl = new OpenFileDialog();
            if (fl.ShowDialog()==DialogResult.OK)
            {
                hobbi_listBox.Items.Clear();
                List<string> lines = new List<string>();
                using (StreamReader r = new StreamReader(fl.OpenFile()))
                {
                    string elsosor = r.ReadLine();
                    string masodiksor = r.ReadLine();
                    hobbi_listBox.Items.AddRange(masodiksor.Split(';'));
                    hobbi_listBox.SelectedItem = elsosor.Split(';')[3];
                    nev_textBox.Text = elsosor.Split(';')[0];
                    szuletes_picker.Text = elsosor.Split(';')[1];
                    if (elsosor.Split(';')[2] == "Férfi")
                    {
                        FERFI_radioButton.Checked = true;

                    }
                    else
                    {
                        NO_radioButton.Checked = true;
                    }
                    


                }
            }
        }
    }
}
