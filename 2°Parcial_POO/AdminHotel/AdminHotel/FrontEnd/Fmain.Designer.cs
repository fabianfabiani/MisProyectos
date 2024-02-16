namespace FrontEnd
{
    partial class Fmain
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
            this.Lhotel = new System.Windows.Forms.Label();
            this.bConsulta = new System.Windows.Forms.Button();
            this.bSalir = new System.Windows.Forms.Button();
            this.bHabitaciones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lhotel
            // 
            this.Lhotel.AutoSize = true;
            this.Lhotel.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lhotel.Location = new System.Drawing.Point(271, 63);
            this.Lhotel.Name = "Lhotel";
            this.Lhotel.Size = new System.Drawing.Size(185, 41);
            this.Lhotel.TabIndex = 0;
            this.Lhotel.Text = "Admin Hotel";
            this.Lhotel.Click += new System.EventHandler(this.label1_Click);
            // 
            // bConsulta
            // 
            this.bConsulta.Location = new System.Drawing.Point(310, 143);
            this.bConsulta.Name = "bConsulta";
            this.bConsulta.Size = new System.Drawing.Size(104, 47);
            this.bConsulta.TabIndex = 1;
            this.bConsulta.Text = "Clientes";
            this.bConsulta.UseVisualStyleBackColor = true;
            this.bConsulta.Click += new System.EventHandler(this.bConsulta_Click);
            // 
            // bSalir
            // 
            this.bSalir.Location = new System.Drawing.Point(583, 369);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(75, 23);
            this.bSalir.TabIndex = 2;
            this.bSalir.Text = "Salir";
            this.bSalir.UseVisualStyleBackColor = true;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // bHabitaciones
            // 
            this.bHabitaciones.Location = new System.Drawing.Point(310, 196);
            this.bHabitaciones.Name = "bHabitaciones";
            this.bHabitaciones.Size = new System.Drawing.Size(104, 52);
            this.bHabitaciones.TabIndex = 3;
            this.bHabitaciones.Text = "Habitaciones";
            this.bHabitaciones.UseVisualStyleBackColor = true;
            this.bHabitaciones.Click += new System.EventHandler(this.bHabitaciones_Click);
            // 
            // Fmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bHabitaciones);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.bConsulta);
            this.Controls.Add(this.Lhotel);
            this.Name = "Fmain";
            this.Text = "Fmain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Lhotel;
        private Button bConsulta;
        private Button bSalir;
        private Button bHabitaciones;
    }
}