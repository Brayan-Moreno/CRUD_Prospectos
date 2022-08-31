namespace CRUD_Prospectos
{
    partial class Menu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnListado = new System.Windows.Forms.Button();
            this.btnEvaluacion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnEvaluacion);
            this.groupBox1.Controls.Add(this.btnListado);
            this.groupBox1.Controls.Add(this.btnRegistro);
            this.groupBox1.Location = new System.Drawing.Point(55, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controles";
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackgroundImage = global::CRUD_Prospectos.Properties.Resources.registro;
            this.btnRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRegistro.Location = new System.Drawing.Point(18, 73);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(102, 95);
            this.btnRegistro.TabIndex = 0;
            this.btnRegistro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnListado
            // 
            this.btnListado.BackgroundImage = global::CRUD_Prospectos.Properties.Resources.Lista;
            this.btnListado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnListado.Location = new System.Drawing.Point(169, 73);
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(102, 95);
            this.btnListado.TabIndex = 1;
            this.btnListado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListado.UseVisualStyleBackColor = true;
            this.btnListado.Click += new System.EventHandler(this.btnListado_Click);
            // 
            // btnEvaluacion
            // 
            this.btnEvaluacion.BackgroundImage = global::CRUD_Prospectos.Properties.Resources.evaluacion;
            this.btnEvaluacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEvaluacion.Location = new System.Drawing.Point(308, 73);
            this.btnEvaluacion.Name = "btnEvaluacion";
            this.btnEvaluacion.Size = new System.Drawing.Size(102, 95);
            this.btnEvaluacion.TabIndex = 2;
            this.btnEvaluacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEvaluacion.UseVisualStyleBackColor = true;
            this.btnEvaluacion.Click += new System.EventHandler(this.btnEvaluacion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Registro de Datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Listado de Datos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Evaluación de Datos";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(251, 278);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 311);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnListado;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEvaluacion;
        private System.Windows.Forms.Button btnExit;
    }
}