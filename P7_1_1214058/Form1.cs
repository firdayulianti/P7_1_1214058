using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P7_1_1214058
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(816, 268);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbNIM.Text != "")
            {
                if (tbNama.Text!= "")
                {
                    if (rbL.Checked || rbP.Checked)
                    {
                        if (tbAlamat.Text !="")
                        {
                            if (cbProgramStudi.Text != "")
                            {
                                if (tbTahunAkademik.Text != "")
                                {
                                    if (tbSemester.Text != "")
                                    {
                                    MessageBox.Show
                                    (" Lengkap",
                                    "Informasi Data Submit",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Size = new Size(816, 526);
                                    }
                                    else
                                    {
                                    MessageBox.Show
                                    ("NIM belum Diisi",
                                    "Informasi Data Submit",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                MessageBox.Show
                                ("Tahun akademik belum Diisi",
                                "Informasi Data Submit",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                            MessageBox.Show
                            ("Program studi belum Diisi",
                            "Informasi Data Submit",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                        MessageBox.Show
                        ("Alamat belum Diisi",
                        "Informasi Data Submit",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                    MessageBox.Show
                    ("Jenis kelamin belum Diisi",
                    "Informasi Data Submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show
                    ("Nama belum Diisi",
                    "Informasi Data Submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show
                ("NIM belum Diisi",
                "Informasi Data Submit",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void tbTahunAkademik_TextChanged(object sender, EventArgs e)
        {
            if (tbTahunAkademik.Text == "")
            {
                epWrong.SetError(tbTahunAkademik, "");
            }
            else
            {
                if (Regex.IsMatch(tbTahunAkademik.Text, @"^\d{4}/\d{4}$"))
                {
                    epWrong.SetError(tbTahunAkademik, "");
                }
                else
                {
                    epWrong.SetError(tbTahunAkademik, "Format tahun akademik salah!");
                }
            }
        }

        private void tbSemester_TextChanged(object sender, EventArgs e)
        {
            if (tbSemester.Text == "")
            {
                epWrong.SetError(tbSemester,"");
            }
            else
            {
                if ((tbSemester.Text).All(Char.IsNumber))
                {
                    epWrong.SetError(tbSemester, "");
                }
                else
                {
                    epWrong.SetError(tbSemester, "Inputan semester hanya boleh angka!");
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                checkBox1.Enabled = true; checkBox1.Checked = false;
                checkBox2.Enabled = true; checkBox2.Checked = false;
                checkBox3.Enabled = true; checkBox3.Checked = false;
                checkBox4.Enabled = true; checkBox4.Checked = false;
                checkBox5.Enabled = true; checkBox5.Checked = false;
                checkBox6.Enabled = true; checkBox6.Checked = false;
                checkBox7.Enabled = true; checkBox7.Checked = false;
                checkBox8.Enabled = true; checkBox8.Checked = false;
                checkBox9.Enabled = false; checkBox9.Checked = false;
                checkBox10.Enabled = true; checkBox10.Checked = false;
                checkBox11.Enabled = true; checkBox11.Checked = false;
                checkBox12.Enabled = false; checkBox12.Checked = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                checkBox1.Enabled = false; checkBox1.Checked = false;
                checkBox2.Enabled = true; checkBox2.Checked = false;
                checkBox3.Enabled = true; checkBox3.Checked = false;
                checkBox4.Enabled = true; checkBox4.Checked = false;
                checkBox5.Enabled = true; checkBox5.Checked = false;
                checkBox6.Enabled = true; checkBox6.Checked = false;
                checkBox7.Enabled = true; checkBox7.Checked = false;
                checkBox8.Enabled = true; checkBox8.Checked = false;
                checkBox9.Enabled = false; checkBox9.Checked = false;
                checkBox10.Enabled = true; checkBox10.Checked = false;
                checkBox11.Enabled = true; checkBox11.Checked = false;
                checkBox12.Enabled = true; checkBox12.Checked = false;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                checkBox1.Enabled = false; checkBox1.Checked = false;
                checkBox2.Enabled = true; checkBox2.Checked = false;
                checkBox3.Enabled = true; checkBox3.Checked = false;
                checkBox4.Enabled = true; checkBox4.Checked = false;
                checkBox5.Enabled = true; checkBox5.Checked = false;
                checkBox6.Enabled = true; checkBox6.Checked = false;
                checkBox7.Enabled = true; checkBox7.Checked = false;
                checkBox8.Enabled = true; checkBox8.Checked = false;
                checkBox9.Enabled = true; checkBox9.Checked = false;
                checkBox10.Enabled = true; checkBox10.Checked = false;
                checkBox11.Enabled = true; checkBox11.Checked = false;
                checkBox12.Enabled = false; checkBox12.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show
            (" Form telah direset",
            "Informasi Data Submit",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Size = new Size(816, 264);

        }
    }
}
