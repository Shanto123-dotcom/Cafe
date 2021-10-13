
using System;

namespace Cafe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtwat = new System.Windows.Forms.TextBox();
            this.txtcof = new System.Windows.Forms.TextBox();
            this.txttea = new System.Windows.Forms.TextBox();
            this.txtoj = new System.Windows.Forms.TextBox();
            this.txtmj = new System.Windows.Forms.TextBox();
            this.txtsprite = new System.Windows.Forms.TextBox();
            this.txtcoca = new System.Windows.Forms.TextBox();
            this.ckwat = new System.Windows.Forms.CheckBox();
            this.ckcof = new System.Windows.Forms.CheckBox();
            this.cktea = new System.Windows.Forms.CheckBox();
            this.ckoj = new System.Windows.Forms.CheckBox();
            this.ckmj = new System.Windows.Forms.CheckBox();
            this.cksp = new System.Windows.Forms.CheckBox();
            this.ckcoca = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtcake = new System.Windows.Forms.TextBox();
            this.txtvege = new System.Windows.Forms.TextBox();
            this.txtmeat = new System.Windows.Forms.TextBox();
            this.txtrice = new System.Windows.Forms.TextBox();
            this.txtno = new System.Windows.Forms.TextBox();
            this.txtpiz = new System.Windows.Forms.TextBox();
            this.txtbur = new System.Windows.Forms.TextBox();
            this.ckcake = new System.Windows.Forms.CheckBox();
            this.ckvege = new System.Windows.Forms.CheckBox();
            this.ckmeat = new System.Windows.Forms.CheckBox();
            this.ckrice = new System.Windows.Forms.CheckBox();
            this.ckno = new System.Windows.Forms.CheckBox();
            this.ckpiz = new System.Windows.Forms.CheckBox();
            this.ckbur = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.rtfRecept = new System.Windows.Forms.RichTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtser = new System.Windows.Forms.TextBox();
            this.lblcoc = new System.Windows.Forms.TextBox();
            this.lblcod = new System.Windows.Forms.TextBox();
            this.lblser = new System.Windows.Forms.Label();
            this.ckcoc = new System.Windows.Forms.Label();
            this.ckcod = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtsub = new System.Windows.Forms.TextBox();
            this.txttax = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblsub = new System.Windows.Forms.Label();
            this.lbltax = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnreceipt = new System.Windows.Forms.Button();
            this.btntotal = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1344, 81);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(353, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(622, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Canteen of AIUB University";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.txtwat);
            this.panel2.Controls.Add(this.txtcof);
            this.panel2.Controls.Add(this.txttea);
            this.panel2.Controls.Add(this.txtoj);
            this.panel2.Controls.Add(this.txtmj);
            this.panel2.Controls.Add(this.txtsprite);
            this.panel2.Controls.Add(this.txtcoca);
            this.panel2.Controls.Add(this.ckwat);
            this.panel2.Controls.Add(this.ckcof);
            this.panel2.Controls.Add(this.cktea);
            this.panel2.Controls.Add(this.ckoj);
            this.panel2.Controls.Add(this.ckmj);
            this.panel2.Controls.Add(this.cksp);
            this.panel2.Controls.Add(this.ckcoca);
            this.panel2.Location = new System.Drawing.Point(2, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(445, 349);
            this.panel2.TabIndex = 1;
            // 
            // txtwat
            // 
            this.txtwat.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtwat.Location = new System.Drawing.Point(248, 270);
            this.txtwat.Multiline = true;
            this.txtwat.Name = "txtwat";
            this.txtwat.Size = new System.Drawing.Size(125, 34);
            this.txtwat.TabIndex = 11;
            this.txtwat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtcof
            // 
            this.txtcof.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtcof.Location = new System.Drawing.Point(248, 230);
            this.txtcof.Multiline = true;
            this.txtcof.Name = "txtcof";
            this.txtcof.Size = new System.Drawing.Size(125, 34);
            this.txtcof.TabIndex = 10;
            this.txtcof.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txttea
            // 
            this.txttea.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txttea.Location = new System.Drawing.Point(248, 190);
            this.txttea.Multiline = true;
            this.txttea.Name = "txttea";
            this.txttea.Size = new System.Drawing.Size(125, 34);
            this.txttea.TabIndex = 9;
            this.txttea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtoj
            // 
            this.txtoj.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtoj.Location = new System.Drawing.Point(248, 150);
            this.txtoj.Multiline = true;
            this.txtoj.Name = "txtoj";
            this.txtoj.Size = new System.Drawing.Size(125, 34);
            this.txtoj.TabIndex = 8;
            this.txtoj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtmj
            // 
            this.txtmj.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtmj.Location = new System.Drawing.Point(248, 110);
            this.txtmj.Multiline = true;
            this.txtmj.Name = "txtmj";
            this.txtmj.Size = new System.Drawing.Size(125, 34);
            this.txtmj.TabIndex = 7;
            this.txtmj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtmj.TextChanged += new System.EventHandler(this.txtmj_TextChanged);
            // 
            // txtsprite
            // 
            this.txtsprite.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtsprite.Location = new System.Drawing.Point(248, 70);
            this.txtsprite.Multiline = true;
            this.txtsprite.Name = "txtsprite";
            this.txtsprite.Size = new System.Drawing.Size(125, 34);
            this.txtsprite.TabIndex = 7;
            this.txtsprite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtcoca
            // 
            this.txtcoca.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtcoca.Location = new System.Drawing.Point(248, 30);
            this.txtcoca.Multiline = true;
            this.txtcoca.Name = "txtcoca";
            this.txtcoca.Size = new System.Drawing.Size(125, 34);
            this.txtcoca.TabIndex = 7;
            this.txtcoca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcoca.TextChanged += new System.EventHandler(this.txtcoca_TextChanged);
            // 
            // ckwat
            // 
            this.ckwat.AutoSize = true;
            this.ckwat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckwat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ckwat.Location = new System.Drawing.Point(20, 273);
            this.ckwat.Name = "ckwat";
            this.ckwat.Size = new System.Drawing.Size(91, 32);
            this.ckwat.TabIndex = 6;
            this.ckwat.Text = "Water";
            this.ckwat.UseVisualStyleBackColor = true;
            this.ckwat.CheckedChanged += new System.EventHandler(this.ckwat_CheckedChanged);
            // 
            // ckcof
            // 
            this.ckcof.AutoSize = true;
            this.ckcof.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckcof.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ckcof.Location = new System.Drawing.Point(20, 230);
            this.ckcof.Name = "ckcof";
            this.ckcof.Size = new System.Drawing.Size(96, 32);
            this.ckcof.TabIndex = 5;
            this.ckcof.Text = "Coffee";
            this.ckcof.UseVisualStyleBackColor = true;
            this.ckcof.CheckedChanged += new System.EventHandler(this.ckcof_CheckedChanged);
            // 
            // cktea
            // 
            this.cktea.AutoSize = true;
            this.cktea.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cktea.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cktea.Location = new System.Drawing.Point(20, 190);
            this.cktea.Name = "cktea";
            this.cktea.Size = new System.Drawing.Size(66, 32);
            this.cktea.TabIndex = 4;
            this.cktea.Text = "Tea";
            this.cktea.UseVisualStyleBackColor = true;
            this.cktea.CheckedChanged += new System.EventHandler(this.cktea_CheckedChanged);
            // 
            // ckoj
            // 
            this.ckoj.AutoSize = true;
            this.ckoj.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckoj.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ckoj.Location = new System.Drawing.Point(20, 150);
            this.ckoj.Name = "ckoj";
            this.ckoj.Size = new System.Drawing.Size(157, 32);
            this.ckoj.TabIndex = 3;
            this.ckoj.Text = "Orange Juice";
            this.ckoj.UseVisualStyleBackColor = true;
            this.ckoj.CheckedChanged += new System.EventHandler(this.ckoj_CheckedChanged);
            // 
            // ckmj
            // 
            this.ckmj.AutoSize = true;
            this.ckmj.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckmj.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ckmj.Location = new System.Drawing.Point(20, 110);
            this.ckmj.Name = "ckmj";
            this.ckmj.Size = new System.Drawing.Size(154, 32);
            this.ckmj.TabIndex = 2;
            this.ckmj.Text = "Mango Juice";
            this.ckmj.UseVisualStyleBackColor = true;
            this.ckmj.CheckedChanged += new System.EventHandler(this.ckmj_CheckedChanged);
            // 
            // cksp
            // 
            this.cksp.AutoSize = true;
            this.cksp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cksp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cksp.Location = new System.Drawing.Point(20, 68);
            this.cksp.Name = "cksp";
            this.cksp.Size = new System.Drawing.Size(90, 32);
            this.cksp.TabIndex = 1;
            this.cksp.Text = "Sprite";
            this.cksp.UseVisualStyleBackColor = true;
            this.cksp.CheckedChanged += new System.EventHandler(this.cksp_CheckedChanged);
            // 
            // ckcoca
            // 
            this.ckcoca.AutoSize = true;
            this.ckcoca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckcoca.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ckcoca.Location = new System.Drawing.Point(20, 30);
            this.ckcoca.Name = "ckcoca";
            this.ckcoca.Size = new System.Drawing.Size(118, 32);
            this.ckcoca.TabIndex = 0;
            this.ckcoca.Text = "Cocacola";
            this.ckcoca.UseVisualStyleBackColor = true;
            this.ckcoca.CheckedChanged += new System.EventHandler(this.ckcoca_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.txtcake);
            this.panel3.Controls.Add(this.txtvege);
            this.panel3.Controls.Add(this.txtmeat);
            this.panel3.Controls.Add(this.txtrice);
            this.panel3.Controls.Add(this.txtno);
            this.panel3.Controls.Add(this.txtpiz);
            this.panel3.Controls.Add(this.txtbur);
            this.panel3.Controls.Add(this.ckcake);
            this.panel3.Controls.Add(this.ckvege);
            this.panel3.Controls.Add(this.ckmeat);
            this.panel3.Controls.Add(this.ckrice);
            this.panel3.Controls.Add(this.ckno);
            this.panel3.Controls.Add(this.ckpiz);
            this.panel3.Controls.Add(this.ckbur);
            this.panel3.Location = new System.Drawing.Point(453, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(424, 349);
            this.panel3.TabIndex = 2;
            // 
            // txtcake
            // 
            this.txtcake.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtcake.Location = new System.Drawing.Point(245, 270);
            this.txtcake.Multiline = true;
            this.txtcake.Name = "txtcake";
            this.txtcake.Size = new System.Drawing.Size(125, 34);
            this.txtcake.TabIndex = 25;
            this.txtcake.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtvege
            // 
            this.txtvege.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtvege.Location = new System.Drawing.Point(245, 230);
            this.txtvege.Multiline = true;
            this.txtvege.Name = "txtvege";
            this.txtvege.Size = new System.Drawing.Size(125, 34);
            this.txtvege.TabIndex = 24;
            this.txtvege.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtmeat
            // 
            this.txtmeat.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtmeat.Location = new System.Drawing.Point(245, 190);
            this.txtmeat.Multiline = true;
            this.txtmeat.Name = "txtmeat";
            this.txtmeat.Size = new System.Drawing.Size(125, 34);
            this.txtmeat.TabIndex = 23;
            this.txtmeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtrice
            // 
            this.txtrice.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtrice.Location = new System.Drawing.Point(245, 150);
            this.txtrice.Multiline = true;
            this.txtrice.Name = "txtrice";
            this.txtrice.Size = new System.Drawing.Size(125, 34);
            this.txtrice.TabIndex = 22;
            this.txtrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtno
            // 
            this.txtno.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtno.Location = new System.Drawing.Point(245, 110);
            this.txtno.Multiline = true;
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(125, 34);
            this.txtno.TabIndex = 19;
            this.txtno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtpiz
            // 
            this.txtpiz.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtpiz.Location = new System.Drawing.Point(245, 70);
            this.txtpiz.Multiline = true;
            this.txtpiz.Name = "txtpiz";
            this.txtpiz.Size = new System.Drawing.Size(125, 34);
            this.txtpiz.TabIndex = 20;
            this.txtpiz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbur
            // 
            this.txtbur.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtbur.Location = new System.Drawing.Point(245, 30);
            this.txtbur.Multiline = true;
            this.txtbur.Name = "txtbur";
            this.txtbur.Size = new System.Drawing.Size(125, 34);
            this.txtbur.TabIndex = 21;
            this.txtbur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ckcake
            // 
            this.ckcake.AutoSize = true;
            this.ckcake.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckcake.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ckcake.Location = new System.Drawing.Point(17, 273);
            this.ckcake.Name = "ckcake";
            this.ckcake.Size = new System.Drawing.Size(79, 32);
            this.ckcake.TabIndex = 18;
            this.ckcake.Text = "Cake";
            this.ckcake.UseVisualStyleBackColor = true;
            this.ckcake.CheckedChanged += new System.EventHandler(this.ckcake_CheckedChanged);
            // 
            // ckvege
            // 
            this.ckvege.AutoSize = true;
            this.ckvege.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckvege.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ckvege.Location = new System.Drawing.Point(17, 230);
            this.ckvege.Name = "ckvege";
            this.ckvege.Size = new System.Drawing.Size(128, 32);
            this.ckvege.TabIndex = 17;
            this.ckvege.Text = "Vegetable";
            this.ckvege.UseVisualStyleBackColor = true;
            this.ckvege.CheckedChanged += new System.EventHandler(this.ckvege_CheckedChanged);
            // 
            // ckmeat
            // 
            this.ckmeat.AutoSize = true;
            this.ckmeat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckmeat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ckmeat.Location = new System.Drawing.Point(17, 190);
            this.ckmeat.Name = "ckmeat";
            this.ckmeat.Size = new System.Drawing.Size(83, 32);
            this.ckmeat.TabIndex = 16;
            this.ckmeat.Text = "Meat";
            this.ckmeat.UseVisualStyleBackColor = true;
            this.ckmeat.CheckedChanged += new System.EventHandler(this.ckmeat_CheckedChanged);
            // 
            // ckrice
            // 
            this.ckrice.AutoSize = true;
            this.ckrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ckrice.Location = new System.Drawing.Point(17, 150);
            this.ckrice.Name = "ckrice";
            this.ckrice.Size = new System.Drawing.Size(74, 32);
            this.ckrice.TabIndex = 15;
            this.ckrice.Text = "Rice";
            this.ckrice.UseVisualStyleBackColor = true;
            this.ckrice.CheckedChanged += new System.EventHandler(this.ckrice_CheckedChanged);
            // 
            // ckno
            // 
            this.ckno.AutoSize = true;
            this.ckno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ckno.Location = new System.Drawing.Point(17, 110);
            this.ckno.Name = "ckno";
            this.ckno.Size = new System.Drawing.Size(103, 32);
            this.ckno.TabIndex = 14;
            this.ckno.Text = "Noodle";
            this.ckno.UseVisualStyleBackColor = true;
            this.ckno.CheckedChanged += new System.EventHandler(this.ckno_CheckedChanged);
            // 
            // ckpiz
            // 
            this.ckpiz.AutoSize = true;
            this.ckpiz.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckpiz.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ckpiz.Location = new System.Drawing.Point(17, 68);
            this.ckpiz.Name = "ckpiz";
            this.ckpiz.Size = new System.Drawing.Size(83, 32);
            this.ckpiz.TabIndex = 13;
            this.ckpiz.Text = "Pizza";
            this.ckpiz.UseVisualStyleBackColor = true;
            this.ckpiz.CheckedChanged += new System.EventHandler(this.ckpiz_CheckedChanged);
            // 
            // ckbur
            // 
            this.ckbur.AutoSize = true;
            this.ckbur.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbur.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ckbur.Location = new System.Drawing.Point(17, 30);
            this.ckbur.Name = "ckbur";
            this.ckbur.Size = new System.Drawing.Size(98, 32);
            this.ckbur.TabIndex = 12;
            this.ckbur.Text = "Burger";
            this.ckbur.UseVisualStyleBackColor = true;
            this.ckbur.CheckedChanged += new System.EventHandler(this.ckbur_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.Controls.Add(this.toolStrip1);
            this.panel4.Controls.Add(this.rtfRecept);
            this.panel4.Location = new System.Drawing.Point(883, 89);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(463, 498);
            this.panel4.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(463, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked_4);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.printToolStripButton.Text = "&Print";
            // 
            // rtfRecept
            // 
            this.rtfRecept.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rtfRecept.Location = new System.Drawing.Point(0, 28);
            this.rtfRecept.Name = "rtfRecept";
            this.rtfRecept.Size = new System.Drawing.Size(463, 472);
            this.rtfRecept.TabIndex = 0;
            this.rtfRecept.Text = "";
            this.rtfRecept.TextChanged += new System.EventHandler(this.rtfRecept_TextChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel5.Controls.Add(this.txtser);
            this.panel5.Controls.Add(this.lblcoc);
            this.panel5.Controls.Add(this.lblcod);
            this.panel5.Controls.Add(this.lblser);
            this.panel5.Controls.Add(this.ckcoc);
            this.panel5.Controls.Add(this.ckcod);
            this.panel5.Location = new System.Drawing.Point(2, 444);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(445, 235);
            this.panel5.TabIndex = 3;
            // 
            // txtser
            // 
            this.txtser.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtser.Location = new System.Drawing.Point(248, 166);
            this.txtser.Multiline = true;
            this.txtser.Name = "txtser";
            this.txtser.Size = new System.Drawing.Size(125, 34);
            this.txtser.TabIndex = 14;
            this.txtser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblcoc
            // 
            this.lblcoc.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblcoc.Location = new System.Drawing.Point(248, 94);
            this.lblcoc.Multiline = true;
            this.lblcoc.Name = "lblcoc";
            this.lblcoc.Size = new System.Drawing.Size(125, 34);
            this.lblcoc.TabIndex = 13;
            this.lblcoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblcod
            // 
            this.lblcod.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblcod.Location = new System.Drawing.Point(248, 31);
            this.lblcod.Multiline = true;
            this.lblcod.Name = "lblcod";
            this.lblcod.Size = new System.Drawing.Size(125, 34);
            this.lblcod.TabIndex = 12;
            this.lblcod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblcod.TextChanged += new System.EventHandler(this.txtcod_TextChanged);
            // 
            // lblser
            // 
            this.lblser.AutoSize = true;
            this.lblser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblser.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblser.Location = new System.Drawing.Point(11, 169);
            this.lblser.Name = "lblser";
            this.lblser.Size = new System.Drawing.Size(174, 33);
            this.lblser.TabIndex = 2;
            this.lblser.Text = "Service Charge";
            // 
            // ckcoc
            // 
            this.ckcoc.AutoSize = true;
            this.ckcoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ckcoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ckcoc.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckcoc.Location = new System.Drawing.Point(11, 97);
            this.ckcoc.Name = "ckcoc";
            this.ckcoc.Size = new System.Drawing.Size(162, 33);
            this.ckcoc.TabIndex = 1;
            this.ckcoc.Text = "Cost of Foods";
            this.ckcoc.Click += new System.EventHandler(this.ckcoc_Click);
            // 
            // ckcod
            // 
            this.ckcod.AutoSize = true;
            this.ckcod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ckcod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ckcod.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckcod.Location = new System.Drawing.Point(11, 31);
            this.ckcod.Name = "ckcod";
            this.ckcod.Size = new System.Drawing.Size(168, 33);
            this.ckcod.TabIndex = 0;
            this.ckcod.Text = "Cost of Drinks";
            this.ckcod.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel6.Controls.Add(this.txttotal);
            this.panel6.Controls.Add(this.txtsub);
            this.panel6.Controls.Add(this.txttax);
            this.panel6.Controls.Add(this.lbltotal);
            this.panel6.Controls.Add(this.lblsub);
            this.panel6.Controls.Add(this.lbltax);
            this.panel6.Location = new System.Drawing.Point(453, 444);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(424, 235);
            this.panel6.TabIndex = 2;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txttotal.Location = new System.Drawing.Point(245, 171);
            this.txttotal.Multiline = true;
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(125, 34);
            this.txttotal.TabIndex = 14;
            // 
            // txtsub
            // 
            this.txtsub.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtsub.Location = new System.Drawing.Point(245, 97);
            this.txtsub.Multiline = true;
            this.txtsub.Name = "txtsub";
            this.txtsub.Size = new System.Drawing.Size(125, 34);
            this.txtsub.TabIndex = 13;
            // 
            // txttax
            // 
            this.txttax.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txttax.Location = new System.Drawing.Point(245, 31);
            this.txttax.Multiline = true;
            this.txttax.Name = "txttax";
            this.txttax.Size = new System.Drawing.Size(125, 34);
            this.txttax.TabIndex = 12;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbltotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltotal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltotal.Location = new System.Drawing.Point(17, 169);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(69, 33);
            this.lbltotal.TabIndex = 5;
            this.lbltotal.Text = "Total";
            // 
            // lblsub
            // 
            this.lblsub.AutoSize = true;
            this.lblsub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblsub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblsub.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblsub.Location = new System.Drawing.Point(17, 97);
            this.lblsub.Name = "lblsub";
            this.lblsub.Size = new System.Drawing.Size(110, 33);
            this.lblsub.TabIndex = 4;
            this.lblsub.Text = "SubTotal";
            // 
            // lbltax
            // 
            this.lbltax.AutoSize = true;
            this.lbltax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbltax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltax.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltax.Location = new System.Drawing.Point(17, 31);
            this.lbltax.Name = "lbltax";
            this.lbltax.Size = new System.Drawing.Size(52, 33);
            this.lbltax.TabIndex = 3;
            this.lbltax.Text = "Tax";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel7.Controls.Add(this.btnexit);
            this.panel7.Controls.Add(this.btnreset);
            this.panel7.Controls.Add(this.btnreceipt);
            this.panel7.Controls.Add(this.btntotal);
            this.panel7.Location = new System.Drawing.Point(883, 593);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(463, 86);
            this.panel7.TabIndex = 2;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Lime;
            this.btnexit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnexit.Location = new System.Drawing.Point(352, 17);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(94, 48);
            this.btnexit.TabIndex = 3;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.Lime;
            this.btnreset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnreset.Location = new System.Drawing.Point(241, 17);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(94, 48);
            this.btnreset.TabIndex = 2;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnreceipt
            // 
            this.btnreceipt.BackColor = System.Drawing.Color.Lime;
            this.btnreceipt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnreceipt.Location = new System.Drawing.Point(129, 17);
            this.btnreceipt.Name = "btnreceipt";
            this.btnreceipt.Size = new System.Drawing.Size(94, 48);
            this.btnreceipt.TabIndex = 1;
            this.btnreceipt.Text = "Receipt";
            this.btnreceipt.UseVisualStyleBackColor = false;
            this.btnreceipt.Click += new System.EventHandler(this.btnreceipt_Click);
            // 
            // btntotal
            // 
            this.btntotal.BackColor = System.Drawing.Color.Lime;
            this.btntotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btntotal.Location = new System.Drawing.Point(16, 17);
            this.btntotal.Name = "btntotal";
            this.btntotal.Size = new System.Drawing.Size(94, 48);
            this.btntotal.TabIndex = 0;
            this.btntotal.Text = "Total";
            this.btntotal.UseVisualStyleBackColor = false;
            this.btntotal.Click += new System.EventHandler(this.btntotal_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 683);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void ckcoc_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtwat;
        private System.Windows.Forms.TextBox txtcof;
        private System.Windows.Forms.TextBox txttea;
        private System.Windows.Forms.TextBox txtoj;
        private System.Windows.Forms.TextBox txtmj;
        private System.Windows.Forms.TextBox txtsprite;
        private System.Windows.Forms.TextBox txtcoca;
        private System.Windows.Forms.CheckBox ckwat;
        private System.Windows.Forms.CheckBox ckcof;
        private System.Windows.Forms.CheckBox cktea;
        private System.Windows.Forms.CheckBox ckoj;
        private System.Windows.Forms.CheckBox ckmj;
        private System.Windows.Forms.CheckBox cksp;
        private System.Windows.Forms.CheckBox ckcoca;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtcake;
        private System.Windows.Forms.TextBox txtvege;
        private System.Windows.Forms.TextBox txtmeat;
        private System.Windows.Forms.TextBox txtrice;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.TextBox txtpiz;
        private System.Windows.Forms.TextBox txtbur;
        private System.Windows.Forms.CheckBox ckcake;
        private System.Windows.Forms.CheckBox ckvege;
        private System.Windows.Forms.CheckBox ckmeat;
        private System.Windows.Forms.CheckBox ckrice;
        private System.Windows.Forms.CheckBox ckno;
        private System.Windows.Forms.CheckBox ckpiz;
        private System.Windows.Forms.CheckBox ckbur;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox rtfRecept;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblser;
        private System.Windows.Forms.Label ckcoc;
        private System.Windows.Forms.Label ckcod;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblsub;
        private System.Windows.Forms.Label lbltax;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnreceipt;
        private System.Windows.Forms.Button btntotal;
        private System.Windows.Forms.TextBox txtser;
        private System.Windows.Forms.TextBox lblcod;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtsub;
        private System.Windows.Forms.TextBox txttax;
        private System.Windows.Forms.Timer timer1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TextBox lblb;
        private System.Windows.Forms.TextBox txtcoc;
        private System.Windows.Forms.TextBox lblcoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
    }
}

