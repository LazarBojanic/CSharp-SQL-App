﻿namespace CSharp_SQL_App {
    partial class UpdateForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
            this.textBoxNazivPlana = new System.Windows.Forms.TextBox();
            this.textBoxUrbanista = new System.Windows.Forms.TextBox();
            this.textBoxObim = new System.Windows.Forms.TextBox();
            this.textBoxRokPoUgovoru = new System.Windows.Forms.TextBox();
            this.textBoxPrioritet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonSacuvaj = new System.Windows.Forms.Button();
            this.buttonOtkazi = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.dateTimeKrajnjiRok = new System.Windows.Forms.DateTimePicker();
            this.dateTimeDatumUgovora = new System.Windows.Forms.DateTimePicker();
            this.comboBoxOpstina = new System.Windows.Forms.ComboBox();
            this.labelUGuid = new System.Windows.Forms.Label();
            this.textBoxUGuid = new System.Windows.Forms.TextBox();
            this.opstinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ugovorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxRokPoUgovoru = new System.Windows.Forms.ComboBox();
            this.comboBoxTipUgovora = new System.Windows.Forms.ComboBox();
            this.labelTipUgovora = new System.Windows.Forms.Label();
            this.labelCena = new System.Windows.Forms.Label();
            this.textBoxCena = new System.Windows.Forms.TextBox();
            this.labelUsvojen = new System.Windows.Forms.Label();
            this.textBoxFaza = new System.Windows.Forms.TextBox();
            this.textBoxNapomena = new System.Windows.Forms.TextBox();
            this.checkBoxUsvojen = new System.Windows.Forms.CheckBox();
            this.dateTimeDatumUsvajanja = new System.Windows.Forms.DateTimePicker();
            this.labelDatumUsvajanja = new System.Windows.Forms.Label();
            this.labelUsvajac = new System.Windows.Forms.Label();
            this.textBoxUsvajac = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.opstinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugovorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNazivPlana
            // 
            this.textBoxNazivPlana.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.textBoxNazivPlana.Location = new System.Drawing.Point(118, 101);
            this.textBoxNazivPlana.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNazivPlana.Name = "textBoxNazivPlana";
            this.textBoxNazivPlana.Size = new System.Drawing.Size(227, 21);
            this.textBoxNazivPlana.TabIndex = 2;
            // 
            // textBoxUrbanista
            // 
            this.textBoxUrbanista.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.textBoxUrbanista.Location = new System.Drawing.Point(118, 138);
            this.textBoxUrbanista.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUrbanista.Name = "textBoxUrbanista";
            this.textBoxUrbanista.Size = new System.Drawing.Size(227, 21);
            this.textBoxUrbanista.TabIndex = 3;
            // 
            // textBoxObim
            // 
            this.textBoxObim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxObim.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.textBoxObim.Location = new System.Drawing.Point(498, 101);
            this.textBoxObim.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxObim.Name = "textBoxObim";
            this.textBoxObim.Size = new System.Drawing.Size(227, 21);
            this.textBoxObim.TabIndex = 11;
            this.textBoxObim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxObim_KeyPress);
            // 
            // textBoxRokPoUgovoru
            // 
            this.textBoxRokPoUgovoru.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRokPoUgovoru.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.textBoxRokPoUgovoru.Location = new System.Drawing.Point(498, 24);
            this.textBoxRokPoUgovoru.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRokPoUgovoru.Name = "textBoxRokPoUgovoru";
            this.textBoxRokPoUgovoru.Size = new System.Drawing.Size(136, 21);
            this.textBoxRokPoUgovoru.TabIndex = 8;
            this.textBoxRokPoUgovoru.TextChanged += new System.EventHandler(this.textBoxRokPoUgovoru_TextChanged);
            this.textBoxRokPoUgovoru.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxRokPoUgovoru_KeyPress);
            // 
            // textBoxPrioritet
            // 
            this.textBoxPrioritet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPrioritet.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.textBoxPrioritet.Location = new System.Drawing.Point(498, 138);
            this.textBoxPrioritet.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPrioritet.Name = "textBoxPrioritet";
            this.textBoxPrioritet.Size = new System.Drawing.Size(227, 21);
            this.textBoxPrioritet.TabIndex = 12;
            this.textBoxPrioritet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrioritet_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opština";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Naziv plana";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Urbanista";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 217);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Faza";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 254);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Napomena";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 291);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Datum ugovora";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(392, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Rok po ugovoru";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(392, 103);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Obim";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(392, 65);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Krajnji rok";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(392, 140);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Prioritet";
            // 
            // buttonSacuvaj
            // 
            this.buttonSacuvaj.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSacuvaj.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSacuvaj.Location = new System.Drawing.Point(118, 383);
            this.buttonSacuvaj.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSacuvaj.Name = "buttonSacuvaj";
            this.buttonSacuvaj.Size = new System.Drawing.Size(200, 63);
            this.buttonSacuvaj.TabIndex = 17;
            this.buttonSacuvaj.Text = "Sačuvaj";
            this.buttonSacuvaj.UseVisualStyleBackColor = true;
            this.buttonSacuvaj.Click += new System.EventHandler(this.buttonSacuvaj_Click);
            // 
            // buttonOtkazi
            // 
            this.buttonOtkazi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonOtkazi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonOtkazi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOtkazi.Location = new System.Drawing.Point(434, 383);
            this.buttonOtkazi.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOtkazi.Name = "buttonOtkazi";
            this.buttonOtkazi.Size = new System.Drawing.Size(200, 63);
            this.buttonOtkazi.TabIndex = 18;
            this.buttonOtkazi.Text = "Otkaži";
            this.buttonOtkazi.UseVisualStyleBackColor = true;
            this.buttonOtkazi.Click += new System.EventHandler(this.buttonOtkazi_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 26);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Id";
            // 
            // textBoxId
            // 
            this.textBoxId.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxId.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.textBoxId.Location = new System.Drawing.Point(118, 24);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(227, 21);
            this.textBoxId.TabIndex = 0;
            this.textBoxId.TabStop = false;
            // 
            // dateTimeKrajnjiRok
            // 
            this.dateTimeKrajnjiRok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeKrajnjiRok.Enabled = false;
            this.dateTimeKrajnjiRok.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.dateTimeKrajnjiRok.Location = new System.Drawing.Point(498, 63);
            this.dateTimeKrajnjiRok.Name = "dateTimeKrajnjiRok";
            this.dateTimeKrajnjiRok.Size = new System.Drawing.Size(227, 21);
            this.dateTimeKrajnjiRok.TabIndex = 10;
            // 
            // dateTimeDatumUgovora
            // 
            this.dateTimeDatumUgovora.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.dateTimeDatumUgovora.Location = new System.Drawing.Point(118, 289);
            this.dateTimeDatumUgovora.Name = "dateTimeDatumUgovora";
            this.dateTimeDatumUgovora.Size = new System.Drawing.Size(227, 21);
            this.dateTimeDatumUgovora.TabIndex = 7;
            this.dateTimeDatumUgovora.ValueChanged += new System.EventHandler(this.dateTimeDatumUgovora_ValueChanged);
            // 
            // comboBoxOpstina
            // 
            this.comboBoxOpstina.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxOpstina.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxOpstina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOpstina.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.comboBoxOpstina.FormattingEnabled = true;
            this.comboBoxOpstina.Location = new System.Drawing.Point(118, 61);
            this.comboBoxOpstina.Name = "comboBoxOpstina";
            this.comboBoxOpstina.Size = new System.Drawing.Size(227, 24);
            this.comboBoxOpstina.TabIndex = 1;
            // 
            // labelUGuid
            // 
            this.labelUGuid.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelUGuid.AutoSize = true;
            this.labelUGuid.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUGuid.Location = new System.Drawing.Point(236, 335);
            this.labelUGuid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUGuid.Name = "labelUGuid";
            this.labelUGuid.Size = new System.Drawing.Size(41, 16);
            this.labelUGuid.TabIndex = 28;
            this.labelUGuid.Text = "uGuid";
            // 
            // textBoxUGuid
            // 
            this.textBoxUGuid.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxUGuid.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.textBoxUGuid.Location = new System.Drawing.Point(281, 333);
            this.textBoxUGuid.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUGuid.Name = "textBoxUGuid";
            this.textBoxUGuid.ReadOnly = true;
            this.textBoxUGuid.Size = new System.Drawing.Size(227, 21);
            this.textBoxUGuid.TabIndex = 19;
            this.textBoxUGuid.TabStop = false;
            // 
            // opstinaBindingSource
            // 
            this.opstinaBindingSource.DataMember = "opstina";
            // 
            // ugovorBindingSource
            // 
            this.ugovorBindingSource.DataMember = "ugovor";
            // 
            // comboBoxRokPoUgovoru
            // 
            this.comboBoxRokPoUgovoru.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxRokPoUgovoru.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.comboBoxRokPoUgovoru.FormattingEnabled = true;
            this.comboBoxRokPoUgovoru.Items.AddRange(new object[] {
            "Dani",
            "Nedelje",
            "Meseci",
            "Godine"});
            this.comboBoxRokPoUgovoru.Location = new System.Drawing.Point(637, 22);
            this.comboBoxRokPoUgovoru.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxRokPoUgovoru.Name = "comboBoxRokPoUgovoru";
            this.comboBoxRokPoUgovoru.Size = new System.Drawing.Size(87, 24);
            this.comboBoxRokPoUgovoru.TabIndex = 9;
            this.comboBoxRokPoUgovoru.SelectedValueChanged += new System.EventHandler(this.comboBoxRokPoUgovoru_SelectedValueChanged);
            // 
            // comboBoxTipUgovora
            // 
            this.comboBoxTipUgovora.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxTipUgovora.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxTipUgovora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipUgovora.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.comboBoxTipUgovora.FormattingEnabled = true;
            this.comboBoxTipUgovora.Location = new System.Drawing.Point(118, 175);
            this.comboBoxTipUgovora.Name = "comboBoxTipUgovora";
            this.comboBoxTipUgovora.Size = new System.Drawing.Size(227, 24);
            this.comboBoxTipUgovora.TabIndex = 4;
            // 
            // labelTipUgovora
            // 
            this.labelTipUgovora.AutoSize = true;
            this.labelTipUgovora.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipUgovora.Location = new System.Drawing.Point(19, 179);
            this.labelTipUgovora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTipUgovora.Name = "labelTipUgovora";
            this.labelTipUgovora.Size = new System.Drawing.Size(72, 16);
            this.labelTipUgovora.TabIndex = 0;
            this.labelTipUgovora.Text = "Tip ugovora";
            // 
            // labelCena
            // 
            this.labelCena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCena.AutoSize = true;
            this.labelCena.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCena.Location = new System.Drawing.Point(392, 179);
            this.labelCena.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCena.Name = "labelCena";
            this.labelCena.Size = new System.Drawing.Size(38, 16);
            this.labelCena.TabIndex = 0;
            this.labelCena.Text = "Cena";
            // 
            // textBoxCena
            // 
            this.textBoxCena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCena.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.textBoxCena.Location = new System.Drawing.Point(498, 177);
            this.textBoxCena.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCena.Name = "textBoxCena";
            this.textBoxCena.Size = new System.Drawing.Size(227, 21);
            this.textBoxCena.TabIndex = 13;
            this.textBoxCena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCena_KeyPress);
            // 
            // labelUsvojen
            // 
            this.labelUsvojen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUsvojen.AutoSize = true;
            this.labelUsvojen.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsvojen.Location = new System.Drawing.Point(392, 217);
            this.labelUsvojen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUsvojen.Name = "labelUsvojen";
            this.labelUsvojen.Size = new System.Drawing.Size(50, 16);
            this.labelUsvojen.TabIndex = 0;
            this.labelUsvojen.Text = "Usvojen";
            // 
            // textBoxFaza
            // 
            this.textBoxFaza.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.textBoxFaza.Location = new System.Drawing.Point(118, 215);
            this.textBoxFaza.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFaza.Name = "textBoxFaza";
            this.textBoxFaza.Size = new System.Drawing.Size(227, 21);
            this.textBoxFaza.TabIndex = 5;
            // 
            // textBoxNapomena
            // 
            this.textBoxNapomena.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.textBoxNapomena.Location = new System.Drawing.Point(118, 252);
            this.textBoxNapomena.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNapomena.Name = "textBoxNapomena";
            this.textBoxNapomena.Size = new System.Drawing.Size(227, 21);
            this.textBoxNapomena.TabIndex = 6;
            // 
            // checkBoxUsvojen
            // 
            this.checkBoxUsvojen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxUsvojen.AutoSize = true;
            this.checkBoxUsvojen.Location = new System.Drawing.Point(498, 218);
            this.checkBoxUsvojen.Name = "checkBoxUsvojen";
            this.checkBoxUsvojen.Size = new System.Drawing.Size(15, 14);
            this.checkBoxUsvojen.TabIndex = 14;
            this.checkBoxUsvojen.UseVisualStyleBackColor = true;
            this.checkBoxUsvojen.CheckedChanged += new System.EventHandler(this.checkBoxUsvojen_CheckedChanged);
            // 
            // dateTimeDatumUsvajanja
            // 
            this.dateTimeDatumUsvajanja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimeDatumUsvajanja.Location = new System.Drawing.Point(498, 252);
            this.dateTimeDatumUsvajanja.Name = "dateTimeDatumUsvajanja";
            this.dateTimeDatumUsvajanja.Size = new System.Drawing.Size(227, 20);
            this.dateTimeDatumUsvajanja.TabIndex = 15;
            // 
            // labelDatumUsvajanja
            // 
            this.labelDatumUsvajanja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDatumUsvajanja.AutoSize = true;
            this.labelDatumUsvajanja.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatumUsvajanja.Location = new System.Drawing.Point(392, 254);
            this.labelDatumUsvajanja.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDatumUsvajanja.Name = "labelDatumUsvajanja";
            this.labelDatumUsvajanja.Size = new System.Drawing.Size(101, 16);
            this.labelDatumUsvajanja.TabIndex = 0;
            this.labelDatumUsvajanja.Text = "Datum usvajanja";
            // 
            // labelUsvajac
            // 
            this.labelUsvajac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUsvajac.AutoSize = true;
            this.labelUsvajac.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsvajac.Location = new System.Drawing.Point(392, 291);
            this.labelUsvajac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUsvajac.Name = "labelUsvajac";
            this.labelUsvajac.Size = new System.Drawing.Size(52, 16);
            this.labelUsvajac.TabIndex = 0;
            this.labelUsvajac.Text = "Usvajač";
            // 
            // textBoxUsvajac
            // 
            this.textBoxUsvajac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUsvajac.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.textBoxUsvajac.Location = new System.Drawing.Point(498, 289);
            this.textBoxUsvajac.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUsvajac.Name = "textBoxUsvajac";
            this.textBoxUsvajac.Size = new System.Drawing.Size(227, 21);
            this.textBoxUsvajac.TabIndex = 16;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 478);
            this.Controls.Add(this.textBoxUsvajac);
            this.Controls.Add(this.labelUsvajac);
            this.Controls.Add(this.labelDatumUsvajanja);
            this.Controls.Add(this.dateTimeDatumUsvajanja);
            this.Controls.Add(this.checkBoxUsvojen);
            this.Controls.Add(this.labelUsvojen);
            this.Controls.Add(this.textBoxCena);
            this.Controls.Add(this.labelCena);
            this.Controls.Add(this.labelTipUgovora);
            this.Controls.Add(this.comboBoxTipUgovora);
            this.Controls.Add(this.comboBoxRokPoUgovoru);
            this.Controls.Add(this.labelUGuid);
            this.Controls.Add(this.textBoxUGuid);
            this.Controls.Add(this.comboBoxOpstina);
            this.Controls.Add(this.dateTimeDatumUgovora);
            this.Controls.Add(this.dateTimeKrajnjiRok);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.buttonOtkazi);
            this.Controls.Add(this.buttonSacuvaj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPrioritet);
            this.Controls.Add(this.textBoxRokPoUgovoru);
            this.Controls.Add(this.textBoxObim);
            this.Controls.Add(this.textBoxNapomena);
            this.Controls.Add(this.textBoxFaza);
            this.Controls.Add(this.textBoxUrbanista);
            this.Controls.Add(this.textBoxNazivPlana);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(731, 468);
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodavanje/izmena ugovora";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.opstinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugovorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxNazivPlana;
        private System.Windows.Forms.TextBox textBoxUrbanista;
        private System.Windows.Forms.TextBox textBoxObim;
        private System.Windows.Forms.TextBox textBoxRokPoUgovoru;
        private System.Windows.Forms.TextBox textBoxPrioritet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonSacuvaj;
        private System.Windows.Forms.Button buttonOtkazi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.DateTimePicker dateTimeKrajnjiRok;
        private System.Windows.Forms.DateTimePicker dateTimeDatumUgovora;
        private System.Windows.Forms.ComboBox comboBoxOpstina;
        private System.Windows.Forms.BindingSource opstinaBindingSource;
        private System.Windows.Forms.BindingSource ugovorBindingSource;
        private System.Windows.Forms.Label labelUGuid;
        private System.Windows.Forms.TextBox textBoxUGuid;
        private System.Windows.Forms.ComboBox comboBoxRokPoUgovoru;
        private System.Windows.Forms.ComboBox comboBoxTipUgovora;
        private System.Windows.Forms.Label labelTipUgovora;
        private System.Windows.Forms.Label labelCena;
        private System.Windows.Forms.TextBox textBoxCena;
        private System.Windows.Forms.Label labelUsvojen;
        private System.Windows.Forms.TextBox textBoxFaza;
        private System.Windows.Forms.TextBox textBoxNapomena;
        private System.Windows.Forms.CheckBox checkBoxUsvojen;
        private System.Windows.Forms.DateTimePicker dateTimeDatumUsvajanja;
        private System.Windows.Forms.Label labelDatumUsvajanja;
        private System.Windows.Forms.Label labelUsvajac;
        private System.Windows.Forms.TextBox textBoxUsvajac;
    }
}