﻿namespace CRUD_Prospectos
{
    partial class ListadoProspectos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gvProspectos = new System.Windows.Forms.DataGridView();
            this.label = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtCodPost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtApePaProsp = new System.Windows.Forms.TextBox();
            this.txtApeMProsp = new System.Windows.Forms.TextBox();
            this.txtNomProsp = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpenDoc = new System.Windows.Forms.Button();
            this.gvDoc = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvProspectos)).BeginInit();
            this.label.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDoc)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvProspectos
            // 
            this.gvProspectos.AllowUserToAddRows = false;
            this.gvProspectos.AllowUserToDeleteRows = false;
            this.gvProspectos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvProspectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProspectos.Location = new System.Drawing.Point(64, 44);
            this.gvProspectos.Name = "gvProspectos";
            this.gvProspectos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvProspectos.Size = new System.Drawing.Size(646, 189);
            this.gvProspectos.TabIndex = 0;
            this.gvProspectos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvProspectos_CellContentClick);
            // 
            // label
            // 
            this.label.Controls.Add(this.label9);
            this.label.Controls.Add(this.label8);
            this.label.Controls.Add(this.label7);
            this.label.Controls.Add(this.txtRFC);
            this.label.Controls.Add(this.txtTel);
            this.label.Controls.Add(this.txtCodPost);
            this.label.Controls.Add(this.label6);
            this.label.Controls.Add(this.label5);
            this.label.Controls.Add(this.label4);
            this.label.Controls.Add(this.label3);
            this.label.Controls.Add(this.label2);
            this.label.Controls.Add(this.label1);
            this.label.Controls.Add(this.txtColonia);
            this.label.Controls.Add(this.txtNumero);
            this.label.Controls.Add(this.txtCalle);
            this.label.Controls.Add(this.txtApePaProsp);
            this.label.Controls.Add(this.txtApeMProsp);
            this.label.Controls.Add(this.txtNomProsp);
            this.label.Location = new System.Drawing.Point(35, 267);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(690, 217);
            this.label.TabIndex = 2;
            this.label.TabStop = false;
            this.label.Text = "Datos del Prospecto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(499, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "RFC";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(499, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Teléfono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(499, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Código Postal";
            // 
            // txtRFC
            // 
            this.txtRFC.Location = new System.Drawing.Point(502, 139);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.ReadOnly = true;
            this.txtRFC.Size = new System.Drawing.Size(161, 20);
            this.txtRFC.TabIndex = 14;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(502, 98);
            this.txtTel.Name = "txtTel";
            this.txtTel.ReadOnly = true;
            this.txtTel.Size = new System.Drawing.Size(161, 20);
            this.txtTel.TabIndex = 13;
            // 
            // txtCodPost
            // 
            this.txtCodPost.Location = new System.Drawing.Point(502, 56);
            this.txtCodPost.Name = "txtCodPost";
            this.txtCodPost.ReadOnly = true;
            this.txtCodPost.Size = new System.Drawing.Size(161, 20);
            this.txtCodPost.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Colonia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Número";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Calle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apellido Materno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Apellido Paterno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // txtColonia
            // 
            this.txtColonia.Location = new System.Drawing.Point(261, 139);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.ReadOnly = true;
            this.txtColonia.Size = new System.Drawing.Size(161, 20);
            this.txtColonia.TabIndex = 5;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(261, 98);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(161, 20);
            this.txtNumero.TabIndex = 4;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(261, 56);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.ReadOnly = true;
            this.txtCalle.Size = new System.Drawing.Size(161, 20);
            this.txtCalle.TabIndex = 3;
            // 
            // txtApePaProsp
            // 
            this.txtApePaProsp.Location = new System.Drawing.Point(18, 139);
            this.txtApePaProsp.Name = "txtApePaProsp";
            this.txtApePaProsp.ReadOnly = true;
            this.txtApePaProsp.Size = new System.Drawing.Size(161, 20);
            this.txtApePaProsp.TabIndex = 2;
            // 
            // txtApeMProsp
            // 
            this.txtApeMProsp.Location = new System.Drawing.Point(18, 98);
            this.txtApeMProsp.Name = "txtApeMProsp";
            this.txtApeMProsp.ReadOnly = true;
            this.txtApeMProsp.Size = new System.Drawing.Size(161, 20);
            this.txtApeMProsp.TabIndex = 1;
            // 
            // txtNomProsp
            // 
            this.txtNomProsp.Location = new System.Drawing.Point(18, 56);
            this.txtNomProsp.Name = "txtNomProsp";
            this.txtNomProsp.ReadOnly = true;
            this.txtNomProsp.Size = new System.Drawing.Size(161, 20);
            this.txtNomProsp.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOpenDoc);
            this.groupBox1.Controls.Add(this.gvDoc);
            this.groupBox1.Location = new System.Drawing.Point(776, 267);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 250);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Documentos Del Prospecto";
            // 
            // btnOpenDoc
            // 
            this.btnOpenDoc.Location = new System.Drawing.Point(125, 206);
            this.btnOpenDoc.Name = "btnOpenDoc";
            this.btnOpenDoc.Size = new System.Drawing.Size(75, 23);
            this.btnOpenDoc.TabIndex = 1;
            this.btnOpenDoc.Text = "Ver Archivo";
            this.btnOpenDoc.UseVisualStyleBackColor = true;
            this.btnOpenDoc.Click += new System.EventHandler(this.btnOpenDoc_Click);
            // 
            // gvDoc
            // 
            this.gvDoc.AllowUserToAddRows = false;
            this.gvDoc.AllowUserToDeleteRows = false;
            this.gvDoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDoc.Location = new System.Drawing.Point(6, 29);
            this.gvDoc.Name = "gvDoc";
            this.gvDoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvDoc.Size = new System.Drawing.Size(280, 170);
            this.gvDoc.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtObs);
            this.groupBox2.Location = new System.Drawing.Point(816, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 166);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Observaciones";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(6, 19);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.ReadOnly = true;
            this.txtObs.Size = new System.Drawing.Size(214, 141);
            this.txtObs.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(296, 502);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(104, 54);
            this.btnMenu.TabIndex = 5;
            this.btnMenu.Text = "Regresar al menú anterior";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(574, 502);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 54);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ListadoProspectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 578);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.gvProspectos);
            this.Name = "ListadoProspectos";
            this.Text = "ListadoProspectos";
            this.Load += new System.EventHandler(this.ListadoProspectos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvProspectos)).EndInit();
            this.label.ResumeLayout(false);
            this.label.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDoc)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvProspectos;
        private System.Windows.Forms.GroupBox label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtCodPost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtColonia;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.TextBox txtApePaProsp;
        private System.Windows.Forms.TextBox txtApeMProsp;
        private System.Windows.Forms.TextBox txtNomProsp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gvDoc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Button btnOpenDoc;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnExit;
    }
}