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
            btnCapturar = new Button();
            btnFinalizar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(321, 33);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 0;
            label1.Text = "Tipo de material";
            // 
            // cmbTipoMaterial
            // 
            cmbTipoMaterial.FormattingEnabled = true;
            cmbTipoMaterial.Location = new Point(302, 65);
            cmbTipoMaterial.Name = "cmbTipoMaterial";
            cmbTipoMaterial.Size = new Size(151, 28);
            cmbTipoMaterial.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(330, 113);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 2;
            label2.Text = "Cantidad (kg)";
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(302, 154);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(150, 27);
            nudCantidad.TabIndex = 3;
            // 
            // btnCapturar
            // 
            btnCapturar.BackColor = Color.FromArgb(128, 255, 128);
            btnCapturar.Location = new Point(326, 204);
            btnCapturar.Name = "btnCapturar";
            btnCapturar.Size = new Size(103, 54);
            btnCapturar.TabIndex = 4;
            btnCapturar.Text = "Registrar material";
            btnCapturar.UseVisualStyleBackColor = false;
            btnCapturar.Click += btnCapturar_Click;
            // 
            // btnFinalizar
            // 
            btnFinalizar.BackColor = Color.Red;
            btnFinalizar.Location = new Point(287, 291);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(175, 56);
            btnFinalizar.TabIndex = 5;
            btnFinalizar.Text = "Finalizar Captura y Ver Inventario";
            btnFinalizar.UseVisualStyleBackColor = false;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFinalizar);
            Controls.Add(btnCapturar);
            Controls.Add(nudCantidad);
            Controls.Add(label2);
            Controls.Add(cmbTipoMaterial);
            Controls.Add(label1);
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
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Button btnFinalizar;
    }
}