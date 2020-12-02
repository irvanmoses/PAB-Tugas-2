using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_Kelompok___Tugas_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal subtotal, pesanbaju, pesanselimut, pesanancelana, pesangorden, pesanboneka, pesanseprei, diskon, ongkir;
        decimal baju = 5000, celana = 5500, sprei = 6000, boneka = 6500, selimut = 7000, gorden = 7500;

        private void chkSelimut_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSelimut.Checked)
            {
                pesanselimut = selimut * nudSelimut.Value;
            }
            else
            {
                pesanselimut -= selimut;
                nudSelimut.Value = 1;
            }
            Hitung();
        }

        private void chkGorden_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGorden.Checked)
            {
                pesangorden = gorden * nudGorden.Value;
            }
            else
            {
                pesangorden -= gorden;
                nudGorden.Value = 1;
            }
            Hitung();
        }


        private void chkBoneka_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoneka.Checked)
            {
                pesanboneka = boneka * nudBoneka.Value;
            }
            else
            {
                pesanboneka -= boneka;
                nudBoneka.Value = 1;
            }
            Hitung();
        }

        private void chkSprei_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSprei.Checked)
            {

                pesanseprei = sprei * nudSprei.Value;
            }
            else
            {
                pesanseprei -= sprei;
                nudSprei.Value = 1;
            }
            Hitung();
        }

        private void btnPesan_Click(object sender, EventArgs e)
        {
            string jenispaket, jenispakaian,delivery;
            rtbTampil.Clear();
            rtbTampil.Text += new string('*', 57) + "\n";
            rtbTampil.Text += new string(' ', 20) + "DUA NYONYA LAUNDRY" + "\n";
            rtbTampil.Text += new string('*', 57) + "\n";
            rtbTampil.Text += "Tanggal         : " + DateTime.Now.ToString("dd MMMM yyyy") + "\n";
            if (rdoReguler.Checked)
            {
                jenispaket = "Regular";
            }
            else if (rdoExpress.Checked)
            {
                jenispaket = "Express";
            }
            else
            {
                jenispaket = "-";
            }
            rtbTampil.Text += "Paket           : " + jenispaket + "\n";
            rtbTampil.Text += "Nama Outlet     : " + cboNamaOtlet.Text + "\n";
            rtbTampil.Text += "Alamat Outlet   : " + lblAlamatOtlet.Text + "\n";
            rtbTampil.Text += new string('*', 57) + "\n";
            rtbTampil.Text += new string(' ', 20) + "Data Customer" + "\n";
            rtbTampil.Text += new string('*', 57) + "\n";
            rtbTampil.Text += "Nama            : " + txtNama.Text + "\n";
            rtbTampil.Text += "No Hp           : " + txtNoHP.Text + "\n";
            rtbTampil.Text += "Alamat          : " + txtAlamat.Text + "\n";
            if (rdoAmbilSendiri.Checked)
            {
                delivery = "Ambil Sendiri";
            }
            else if (rdoDiantar.Checked)
            {
                
                delivery = "Diantar";
                
            }
            else
            {
                delivery = "-";
            }
            rtbTampil.Text += "Delivery        : " + delivery + "\n";
            rtbTampil.Text += new string('*', 57) + "\n";
            rtbTampil.Text += new string(' ', 20) + "Jenis Pakaian" + "\n";
            rtbTampil.Text += new string('*', 57) + "\n";
            if (chkBaju.Checked)
            {
                jenispakaian = "Baju            ";
                rtbTampil.Text += jenispakaian + ": " + nudBaju.Value + " Kg" + "\n";
            }
             else
            {
                jenispakaian = "";
            }
            
            if (chkCelana.Checked)
            {
                jenispakaian = "Celana          ";
                rtbTampil.Text += jenispakaian + ": " + nudCelana.Value + " Kg" + "\n";
            }
            else
            {
                jenispakaian = "";
            }
            
            if (chkSprei.Checked)
            {
                jenispakaian = "Sprei           ";
                rtbTampil.Text += jenispakaian + ": " + nudSprei.Value + " Kg" + "\n";
            }
            else
            {
                jenispakaian = "";
            }
            
            if (chkBoneka.Checked)
            {
                jenispakaian = "Boneka          ";
                rtbTampil.Text += jenispakaian + ": " + nudBoneka.Value + " Kg" + "\n";
            }
            else
            {
                jenispakaian = "";
            }
          
            if (chkSelimut.Checked)
            {
                jenispakaian = "Selimut         ";
                rtbTampil.Text += jenispakaian + ": " + nudSelimut.Value + " Kg" + "\n";
            }
            else
            {
                jenispakaian = "";
            }

            
            if (chkGorden.Checked)
            {
                jenispakaian = "Gorden          ";
                rtbTampil.Text += jenispakaian + ": " + nudGorden.Value + " Kg" + "\n";
            }
            else
            {
                jenispakaian = "";
            }
            rtbTampil.Text += new string('*', 57) + "\n";
            rtbTampil.Text += "Total           : " + lblSubtotal.Text + "\n";

            rtbTampil.SaveFile("Pesanan.rtf");

        }

        private void cboNamaOtlet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboNamaOtlet.SelectedIndex == 0)
            {
                lblAlamatOtlet.Text = "Jl. Thamrin No. 121 A";
            }
            else if(cboNamaOtlet.SelectedIndex==1)
            {
                lblAlamatOtlet.Text = "Jl. Bhayangkara No. 30 ";
            }
            else if (cboNamaOtlet.SelectedIndex == 2)
            {
                lblAlamatOtlet.Text = "Jl. Setia Budi No. 2";
            }
            else if (cboNamaOtlet.SelectedIndex == 3)
            {
                lblAlamatOtlet.Text = "Jl. Gatot Subroto No 4C ";
            }
            else if (cboNamaOtlet.SelectedIndex == 4)
            {
                lblAlamatOtlet.Text = "Jl. Yos Sudarso no 10";
            }
            else
            {
                lblAlamatOtlet.Text = "-";
            }
        }

        private void rdoDiantar_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoDiantar.Checked)
            {
                txtAlamat.Enabled = true;
                lblKeterangan_Ongkir.Text = "Biaya ongkir sebesar 7.000";
                Hitung();
            }
            else
            {
                lblKeterangan_Ongkir.Text = "";
            }
        }

        private void rdoAmbilSendiri_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoAmbilSendiri.Checked)
            {
                lblKeterangan_Ongkir.Text = "";
                txtAlamat.Enabled = false;
                txtAlamat.Text = "";
            }
            else
            {
                lblKeterangan_Ongkir.Text = "";
            }
            Hitung();
        }

        private void chkDiskon_CheckedChanged(object sender, EventArgs e)
        {
            Hitung();
        }


        private void chkCelana_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCelana.Checked)
            {
                pesanancelana = celana * nudCelana.Value;
            }
            else
            {
                pesanancelana -= celana;
                nudCelana.Value = 1;
            }
            Hitung();
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Pesanan.rtf");
        }

        private void chkBaju_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBaju.Checked)
            {
                pesanbaju = baju * nudBaju.Value; 
            }
            else
            {
                pesanbaju -= baju;
                nudBaju.Value = 1;
            }
            Hitung();
        }


        private void nudBaju_ValueChanged(object sender, EventArgs e)
        {
            Hitung();
        }

        

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void rtbTampil_TextChanged(object sender, EventArgs e)
        {

        }

        private void nudCelana_ValueChanged(object sender, EventArgs e)
        {
            Hitung();
        }

        private void nudSprei_ValueChanged(object sender, EventArgs e)
        {
            Hitung();
        }

        private void nudBoneka_ValueChanged(object sender, EventArgs e)
        {
            Hitung();
        }

        private void nudSelimut_ValueChanged(object sender, EventArgs e)
        {
            Hitung();
        }

        private void nudGorden_ValueChanged(object sender, EventArgs e)
        {
            Hitung();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTanggal.Text = DateTime.Now.ToString("dd - MMMM - yyyy");
            cboNamaOtlet.Items.Add("Dua Nyonya 1");
            cboNamaOtlet.Items.Add("Dua Nyonya 2");
            cboNamaOtlet.Items.Add("Dua Nyonya 3");
            cboNamaOtlet.Items.Add("Dua Nyonya 4");
            cboNamaOtlet.Items.Add("Dua Nyonya 5");
            cboNamaOtlet.DropDownStyle = ComboBoxStyle.DropDownList;
            rtbTampil.ReadOnly = true;
            txtAlamat.Enabled = false;
        }



        private void btnKeluar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda yakin ingin keluar?", "Keluar Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnKosong_Click(object sender, EventArgs e)
        {
            rdoExpress.Checked = false;
            rdoReguler.Checked = false;
            rdoDiantar.Checked = false;
            rdoAmbilSendiri.Checked = false;
            chkBaju.Checked = false;
            chkBoneka.Checked = false;
            chkSprei.Checked = false;
            chkCelana.Checked = false;
            chkDiskon.Checked = false;
            lblSubtotal.Text = "";
            lblKeterangan_Ongkir.Text = "";
            lblAlamatOtlet.Text = "";
            txtNama.Clear();
            txtNoHP.Clear();
            txtAlamat.Clear();
            rtbTampil.Clear();
            nudBaju.Value = 1;
            cboNamaOtlet.SelectedIndex = -1;
            baju = 5000;
            celana = 5500;
            sprei = 6000;
            boneka = 6500; 
            selimut = 7000; 
            gorden = 7500;
        }

        private void rdoReguler_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoReguler.Checked)
            {
                baju = 5000;
                celana = 5500;
                sprei = 6000;
                boneka = 6500;
                selimut = 7000;
                gorden = 7500;
            }

            Hitung();
        }

        private void rdoExpress_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoExpress.Checked)
            {
                baju += 3000 * nudBaju.Value;
                celana += 3000 * nudCelana.Value;
                sprei += 3000 * nudSprei.Value;
                boneka += 3000 * nudBoneka.Value;
                selimut += 3000 * nudSelimut.Value;
                gorden += 3000 * nudGorden.Value;
            }

            Hitung();
        }

        private void Hitung()
        {
           if(chkDiskon.Checked)
           {
                diskon = (pesanbaju * nudBaju.Value + pesanancelana * nudCelana.Value + pesanseprei * nudSprei.Value + pesanboneka * nudBoneka.Value + pesangorden * nudGorden.Value + pesanselimut * nudSelimut.Value) * 10/100m;
           }
           else
           {
               diskon = 0;
            }

            if(rdoDiantar.Checked)
            {
                ongkir = 7000;
            }
            else  
            {
                ongkir = 0;
            }
            
            subtotal = (pesanbaju * nudBaju.Value + pesanancelana * nudCelana.Value + pesanseprei * nudSprei.Value + pesanboneka * nudBoneka.Value + pesangorden * nudGorden.Value + pesanselimut * nudSelimut.Value + ongkir) - diskon;
            lblSubtotal.Text = subtotal.ToString("Rp #,##0.00");
        }
    }
}
