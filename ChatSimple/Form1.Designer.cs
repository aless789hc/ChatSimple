namespace ChatSimple
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
            rtbHistorial = new RichTextBox();
            label1 = new Label();
            txtIP = new TextBox();
            txtPuerto = new TextBox();
            label2 = new Label();
            btnIniciar = new Button();
            label3 = new Label();
            txtMensaje = new TextBox();
            label4 = new Label();
            btnEnviar = new Button();
            SuspendLayout();
            // 
            // rtbHistorial
            // 
            rtbHistorial.Location = new Point(71, 192);
            rtbHistorial.Name = "rtbHistorial";
            rtbHistorial.Size = new Size(632, 165);
            rtbHistorial.TabIndex = 0;
            rtbHistorial.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 21);
            label1.Name = "label1";
            label1.Size = new Size(21, 20);
            label1.TabIndex = 1;
            label1.Text = "IP";
            // 
            // txtIP
            // 
            txtIP.Location = new Point(44, 59);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(132, 27);
            txtIP.TabIndex = 2;
            // 
            // txtPuerto
            // 
            txtPuerto.Location = new Point(228, 59);
            txtPuerto.Name = "txtPuerto";
            txtPuerto.Size = new Size(125, 27);
            txtPuerto.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(224, 31);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 4;
            label2.Text = "Puerto";
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(433, 57);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(168, 29);
            btnIniciar.TabIndex = 5;
            btnIniciar.Text = "Iniciar Servidor";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 158);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 6;
            label3.Text = "Mensajes";
            // 
            // txtMensaje
            // 
            txtMensaje.Location = new Point(66, 394);
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(239, 27);
            txtMensaje.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 370);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 8;
            label4.Text = "Mensaje";
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(338, 387);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(94, 29);
            btnEnviar.TabIndex = 9;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEnviar);
            Controls.Add(label4);
            Controls.Add(txtMensaje);
            Controls.Add(label3);
            Controls.Add(btnIniciar);
            Controls.Add(label2);
            Controls.Add(txtPuerto);
            Controls.Add(txtIP);
            Controls.Add(label1);
            Controls.Add(rtbHistorial);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbHistorial;
        private Label label1;
        private TextBox txtIP;
        private TextBox txtPuerto;
        private Label label2;
        private Button btnIniciar;
        private Label label3;
        private TextBox txtMensaje;
        private Label label4;
        private Button btnEnviar;
    }
}
