using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtcoca.Text = "0";
            txtsprite.Text = "0";
            txtmj.Text = "0";
            txtoj.Text = "0";
            txttea.Text = "0"; 
            txtcof.Text = "0";
            txtwat.Text = "0";
            txtbur.Text = "0";
            txtpiz.Text = "0";
            txtno.Text = "0";
            txtrice.Text = "0";
            txtmeat.Text = "0";
            txtvege.Text = "0";
            txtcake.Text = "0";
            lblcod.Text = "0";
            lblcoc.Text = "0";
            txtser.Text = "1.2";
            txttax.Text = "0";
            txtsub.Text = "0";
            txttotal.Text = "0";
            rtfRecept.Clear();



        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtmj_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtcoca.Text = "0";
            txtsprite.Text = "0";
            txtmj.Text = "0";
            txtoj.Text = "0";
            txttea.Text = "0";
            txtcof.Text = "0";
            txtwat.Text = "0";
            txtbur.Text = "0";
            txtpiz.Text = "0";
            txtno.Text = "0";
            txtrice.Text = "0";
            txtmeat.Text = "0";
            txtvege.Text = "0";
            txtcake.Text = "0";
            lblcod.Text = "0";
            lblcoc.Text = "0";
            txtser.Text = "1.2";
           

            txtcoca.Enabled = false;
            txtsprite.Enabled = false; 
            txtmj.Enabled = false;
            txtoj.Enabled = false;
            txttea.Enabled = false;
            txtcof.Enabled = false;
            txtwat.Enabled = false;
            txtbur.Enabled = false;
            txtpiz.Enabled = false;
            txtno.Enabled = false;
            txtrice.Enabled = false;
            txtmeat.Enabled = false;
            txtvege.Enabled = false;
            txtcake.Enabled = false;

            ckcoca.Checked = false;
            cksp.Checked = false;
            ckmj.Checked = false;
            ckoj.Checked = false;
            cktea.Checked = false;
            ckcof.Checked = false;
            ckwat.Checked = false;
            ckbur.Checked = false;
            ckpiz.Checked = false;
            ckno.Checked = false;
            ckrice.Checked = false;
            ckmeat.Checked = false;
            ckvege.Checked = false;
            ckcake.Checked = false;
            
        }

        private void txtcod_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ckcoca_CheckedChanged(object sender, EventArgs e)
        {
            if (ckcoca.Checked == true)
            {
                txtcoca.Enabled = true;
            }
            if (ckcoca.Checked == false)
            {
                txtcoca.Enabled = false;
                txtcoca.Text = "0";
            }
        }

        private void cksp_CheckedChanged(object sender, EventArgs e)
        {
            if (cksp.Checked == true)
            {
                txtsprite.Enabled = true;
            }
            if (cksp.Checked == false)
            {
                txtsprite.Enabled = false;
                txtsprite.Text = "0";
            }
        }

        private void ckmj_CheckedChanged(object sender, EventArgs e)
        {
            if (ckmj.Checked == true)
            {
                txtmj.Enabled = true;
            }
            if (ckmj.Checked == false)
            {
                txtmj.Enabled = false;
                txtmj.Text = "0";
            }
        }

        private void ckoj_CheckedChanged(object sender, EventArgs e)
        {
            if (ckoj.Checked == true)
            {
                txtoj.Enabled = true;
            }
            if (ckoj.Checked == false)
            {
                txtoj.Enabled = false;
                txtoj.Text = "0";
            }
        }

        private void cktea_CheckedChanged(object sender, EventArgs e)
        {
            if (cktea.Checked == true)
            {
                txttea.Enabled = true;
            }
            if (cktea.Checked == false)
            {
                txttea.Enabled = false;
                txttea.Text = "0";
            }
        }

        private void ckcof_CheckedChanged(object sender, EventArgs e)
        {
            if (ckcof.Checked == true)
            {
                txtcof.Enabled = true;
            }
            if (ckcof.Checked == false)
            {
                txtcof.Enabled = false;
                txtcof.Text = "0";
            }
        }

        private void ckwat_CheckedChanged(object sender, EventArgs e)
        {
            if (ckwat.Checked == true)
            {
                txtwat.Enabled = true;
            }
            if (ckwat.Checked == false)
            {
                txtwat.Enabled = false;
                txtwat.Text = "0";
            }
        }

        private void ckbur_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbur.Checked == true)
            {
                txtbur.Enabled = true;
            }
            if (ckbur.Checked == false)
            {
                txtbur.Enabled = false;
                txtbur.Text = "0";
            }
        }

        private void ckpiz_CheckedChanged(object sender, EventArgs e)
        {
            if (ckpiz.Checked == true)
            {
                txtpiz.Enabled = true;
            }
            if (ckpiz.Checked == false)
            {
                txtpiz.Enabled = false;
                txtpiz.Text = "0";
            }
        }

        private void ckno_CheckedChanged(object sender, EventArgs e)
        {
            if (ckno.Checked == true)
            {
                txtno.Enabled = true;
            }
            if (ckno.Checked == false)
            {
                txtno.Enabled = false;
                txtno.Text = "0";
            }
        }

        private void ckrice_CheckedChanged(object sender, EventArgs e)
        {
            if (ckrice.Checked == true)
            {
                txtrice.Enabled = true;
            }
            if (ckrice.Checked == false)
            {
                txtrice.Enabled = false;
                txtrice.Text = "0";
            }
        }

        private void ckmeat_CheckedChanged(object sender, EventArgs e)
        {
            if (ckmeat.Checked == true)
            {
                txtmeat.Enabled = true;
            }
            if (ckmeat.Checked == false)
            {
                txtmeat.Enabled = false;
                txtmeat.Text = "0";
            }
        }

        private void ckvege_CheckedChanged(object sender, EventArgs e)
        {
            if (ckvege.Checked == true)
            {
                txtvege.Enabled = true;
            }
            if (ckvege.Checked == false)
            {
                txtvege.Enabled = false;
                txtvege.Text = "0";
            }
        }

        private void ckcake_CheckedChanged(object sender, EventArgs e)
        {
            if (ckcake.Checked == true)
            {
                txtcake.Enabled = true;
            }
            if (ckcake.Checked == false)
            {
                txtcake.Enabled = false;
                txtcake.Text = "0";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtcoca_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtfRecept.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        private void toolStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnreceipt_Click(object sender, EventArgs e)
        {
            rtfRecept.Clear();

            rtfRecept.AppendText(Environment.NewLine);
            rtfRecept.AppendText("\t\t\t" + "AIUB Canteen" + Environment.NewLine);
            rtfRecept.AppendText("____________________________________________________" + Environment.NewLine + Environment.NewLine);
            rtfRecept.AppendText("CocaCola \t\t\t\t" + txtcoca.Text + Environment.NewLine);
            rtfRecept.AppendText("Sprite \t\t\t\t" + txtsprite.Text + Environment.NewLine);
            rtfRecept.AppendText("Mango Juice \t\t\t" + txtmj.Text + Environment.NewLine);
            rtfRecept.AppendText("Orange Juice \t\t\t" + txtoj.Text + Environment.NewLine);
            rtfRecept.AppendText("Tea \t\t\t\t\t" + txttea.Text + Environment.NewLine);
            rtfRecept.AppendText("Coffee \t\t\t\t" + txtcof.Text + Environment.NewLine);
            rtfRecept.AppendText("Water \t\t\t\t" + txtwat.Text + Environment.NewLine);
            rtfRecept.AppendText("Burger \t\t\t\t" + txtbur.Text + Environment.NewLine);
            rtfRecept.AppendText("Pizza \t\t\t\t\t" + txtpiz.Text + Environment.NewLine);
            rtfRecept.AppendText("Noodle \t\t\t\t" + txtno.Text + Environment.NewLine);
            rtfRecept.AppendText("Rice \t\t\t\t\t" + txtrice.Text + Environment.NewLine);
            rtfRecept.AppendText("Meat \t\t\t\t\t" + txtmeat.Text + Environment.NewLine);
            rtfRecept.AppendText("Vegetable \t\t\t\t" + txtvege.Text + Environment.NewLine);
            rtfRecept.AppendText("Cake \t\t\t\t\t" + txtcake.Text + Environment.NewLine);
            rtfRecept.AppendText("___________________________________________________" + Environment.NewLine);
            rtfRecept.AppendText("Service Charge \t\t\t" + txtser.Text + Environment.NewLine);
            rtfRecept.AppendText("___________________________________________________" + Environment.NewLine);
            rtfRecept.AppendText("Tax \t\t\t\t\t" + txttax.Text + Environment.NewLine);
            rtfRecept.AppendText("Sub Total \t\t\t\t" + txtsub.Text + Environment.NewLine);
            rtfRecept.AppendText("Total \t\t\t\t\t" + txttotal.Text + Environment.NewLine);

        }

        private void btntotal_Click(object sender, EventArgs e)
        {
            double coca, sp, mj, oj, tea, cof, wat;
            double bur, piz, no, rice, meat, vege, cake;

            coca = 20; sp = 15; mj = 30; oj = 25; tea = 10; cof = 12.50; wat = 10.20;

            double cocap = Convert.ToDouble(txtcoca.Text);
            double spp = Convert.ToDouble(txtsprite.Text);
            double mjp = Convert.ToDouble(txtmj.Text);
            double ojp = Convert.ToDouble(txtoj.Text);
            double teap = Convert.ToDouble(txttea.Text);
            double cofp = Convert.ToDouble(txtcof.Text);
            double watp = Convert.ToDouble(txtwat.Text);

            bur = 50; piz = 150; no = 45; rice = 15; meat = 60; vege = 40; cake = 60;

            double burp = Convert.ToDouble(txtbur.Text);
            double pizp = Convert.ToDouble(txtpiz.Text);
            double nop = Convert.ToDouble(txtno.Text);
            double ricep = Convert.ToDouble(txtrice.Text);
            double meatp = Convert.ToDouble(txtmeat.Text);
            double vegep = Convert.ToDouble(txtvege.Text);
            double cakep = Convert.ToDouble(txtcake.Text);

            Cafe eat_in_Cafe = new Cafe(cocap, spp, mjp, ojp, teap, cofp, watp, burp, pizp, nop, ricep, meatp, vegep, cakep);

            double cost_of_drinks = (cocap * coca) + (spp * sp) + (mjp * mj) + (ojp * oj) + (teap * tea) + (cofp * cof) + (watp * wat);
            lblcod.Text = Convert.ToString(cost_of_drinks);

            double cost_of_cakes = (burp * bur) + (pizp * piz) + (nop * no) + (ricep * rice) + (meatp * meat) + (vegep * vege) + (cakep * cake);
            lblcoc.Text = Convert.ToString(cost_of_cakes);

            Double service_charge = Convert.ToDouble(txtser.Text);

            txtsub.Text = Convert.ToString(cost_of_cakes + cost_of_drinks + service_charge);
            double tax = (((cost_of_cakes + cost_of_drinks + service_charge) * 2)) / 100;
            string v = Convert.ToString(tax);
            txttax.Text = v;
            double itax = Convert.ToDouble(txttax.Text);
            txttotal.Text = Convert.ToString(cost_of_cakes + cost_of_drinks + itax + service_charge);

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void rtfRecept_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void toolStrip1_ItemClicked_2(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void toolStrip1_ItemClicked_3(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void toolStrip1_ItemClicked_4(object sender, ToolStripItemClickedEventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

            rtfRecept.Clear();
        }
    }
}
