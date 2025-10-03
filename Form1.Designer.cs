namespace Inventory_App // ¡IMPORTANTE! Asegúrate de que este 'namespace' coincida con el de tu proyecto
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
            label1 = new Label();
            cmbTipoMaterial = new ComboBox();
            label2 = new Label();
            nudCantidad = new NumericUpDown();
            BtnCapturar = new Button();
            BtnFinalizar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(272, 25);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 0;
            label1.Text = "Tipo de material";
            // 
            // cmbTipoMaterial
            // 
            cmbTipoMaterial.FormattingEnabled = true;
            cmbTipoMaterial.Location = new Point(272, 139);
            cmbTipoMaterial.Margin = new Padding(3, 2, 3, 2);
            cmbTipoMaterial.Name = "cmbTipoMaterial";
            cmbTipoMaterial.Size = new Size(198, 23);
            cmbTipoMaterial.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(529, 25);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 2;
            label2.Text = "Cantidad (kg)";
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(529, 139);
            nudCantidad.Margin = new Padding(3, 2, 3, 2);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(181, 23);
            nudCantidad.TabIndex = 3;
            // 
            // BtnCapturar
            // 
            BtnCapturar.BackColor = Color.FromArgb(128, 255, 128);
            BtnCapturar.Location = new Point(620, 287);
            BtnCapturar.Margin = new Padding(3, 2, 3, 2);
            BtnCapturar.Name = "BtnCapturar";
            BtnCapturar.Size = new Size(90, 40);
            BtnCapturar.TabIndex = 4;
            BtnCapturar.Text = "Registrar material";
            BtnCapturar.UseVisualStyleBackColor = false;
            BtnCapturar.Click += BtnCapturar_Click;
            // 
            // BtnFinalizar
            // 
            BtnFinalizar.BackColor = Color.Red;
            BtnFinalizar.Location = new Point(272, 285);
            BtnFinalizar.Margin = new Padding(3, 2, 3, 2);
            BtnFinalizar.Name = "BtnFinalizar";
            BtnFinalizar.Size = new Size(153, 42);
            BtnFinalizar.TabIndex = 5;
            BtnFinalizar.Text = "Finalizar Captura y Ver Inventario";
            BtnFinalizar.UseVisualStyleBackColor = false;
            BtnFinalizar.Click += BtnFinalizar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 338);
            Controls.Add(BtnFinalizar);
            Controls.Add(BtnCapturar);
            Controls.Add(nudCantidad);
            Controls.Add(label2);
            Controls.Add(cmbTipoMaterial);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Captura de materiales";
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoMaterial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button BtnCapturar;
        private System.Windows.Forms.Button BtnFinalizar;
    }
}