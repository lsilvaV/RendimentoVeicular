
namespace RendimentoVeicular
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lblKM = new System.Windows.Forms.Label();
            this.lblLitros = new System.Windows.Forms.Label();
            this.lblRendimento = new System.Windows.Forms.Label();
            this.lblConsumo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxKM = new System.Windows.Forms.TextBox();
            this.tbxLitros = new System.Windows.Forms.TextBox();
            this.lblConResul = new System.Windows.Forms.Label();
            this.lblRendResul = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKM
            // 
            this.lblKM.AutoSize = true;
            this.lblKM.Location = new System.Drawing.Point(151, 64);
            this.lblKM.Name = "lblKM";
            this.lblKM.Size = new System.Drawing.Size(32, 16);
            this.lblKM.TabIndex = 1;
            this.lblKM.Text = "&KM:";
            // 
            // lblLitros
            // 
            this.lblLitros.AutoSize = true;
            this.lblLitros.Location = new System.Drawing.Point(134, 93);
            this.lblLitros.Name = "lblLitros";
            this.lblLitros.Size = new System.Drawing.Size(49, 16);
            this.lblLitros.TabIndex = 2;
            this.lblLitros.Text = "&Litros:";
            // 
            // lblRendimento
            // 
            this.lblRendimento.AutoSize = true;
            this.lblRendimento.Location = new System.Drawing.Point(151, 175);
            this.lblRendimento.Name = "lblRendimento";
            this.lblRendimento.Size = new System.Drawing.Size(167, 16);
            this.lblRendimento.TabIndex = 3;
            this.lblRendimento.Text = "Rendimento - KM/Litros:";
            // 
            // lblConsumo
            // 
            this.lblConsumo.AutoSize = true;
            this.lblConsumo.Location = new System.Drawing.Point(151, 240);
            this.lblConsumo.Name = "lblConsumo";
            this.lblConsumo.Size = new System.Drawing.Size(150, 16);
            this.lblConsumo.TabIndex = 4;
            this.lblConsumo.Text = "Consumo - Litros/KM:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(96, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cálculo de Combustível";
            // 
            // tbxKM
            // 
            this.tbxKM.Location = new System.Drawing.Point(195, 61);
            this.tbxKM.Name = "tbxKM";
            this.tbxKM.Size = new System.Drawing.Size(100, 23);
            this.tbxKM.TabIndex = 6;
            // 
            // tbxLitros
            // 
            this.tbxLitros.Location = new System.Drawing.Point(195, 90);
            this.tbxLitros.Name = "tbxLitros";
            this.tbxLitros.Size = new System.Drawing.Size(100, 23);
            this.tbxLitros.TabIndex = 7;
            // 
            // lblConResul
            // 
            this.lblConResul.BackColor = System.Drawing.Color.SlateGray;
            this.lblConResul.Location = new System.Drawing.Point(151, 265);
            this.lblConResul.Name = "lblConResul";
            this.lblConResul.Size = new System.Drawing.Size(167, 23);
            this.lblConResul.TabIndex = 9;
            this.lblConResul.Tag = "1";
            // 
            // lblRendResul
            // 
            this.lblRendResul.BackColor = System.Drawing.Color.SlateGray;
            this.lblRendResul.Location = new System.Drawing.Point(151, 202);
            this.lblRendResul.Name = "lblRendResul";
            this.lblRendResul.Size = new System.Drawing.Size(167, 23);
            this.lblRendResul.TabIndex = 10;
            this.lblRendResul.Tag = "1";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(195, 134);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Main
            // 
            this.AcceptButton = this.btnCalcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblRendResul);
            this.Controls.Add(this.lblConResul);
            this.Controls.Add(this.tbxLitros);
            this.Controls.Add(this.tbxKM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblConsumo);
            this.Controls.Add(this.lblRendimento);
            this.Controls.Add(this.lblLitros);
            this.Controls.Add(this.lblKM);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Consumo de Combustível";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Main_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblKM;
        private System.Windows.Forms.Label lblLitros;
        private System.Windows.Forms.Label lblRendimento;
        private System.Windows.Forms.Label lblConsumo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxKM;
        private System.Windows.Forms.TextBox tbxLitros;
        private System.Windows.Forms.Label lblConResul;
        private System.Windows.Forms.Label lblRendResul;
        private System.Windows.Forms.Button btnCalcular;
    }
}