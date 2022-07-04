namespace EmailClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRemitente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDestinatario = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMensaje = new System.Windows.Forms.RichTextBox();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEnviarEmail = new System.Windows.Forms.Button();
            this.listArchivos = new System.Windows.Forms.ListBox();
            this.btnAdjuntar = new System.Windows.Forms.Button();
            this.rbGmail = new System.Windows.Forms.RadioButton();
            this.rbHotmail = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "De:";
            // 
            // txtRemitente
            // 
            this.txtRemitente.Location = new System.Drawing.Point(68, 33);
            this.txtRemitente.Name = "txtRemitente";
            this.txtRemitente.Size = new System.Drawing.Size(350, 27);
            this.txtRemitente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(123, 76);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(295, 27);
            this.txtPassword.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Destinatario:";
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.Location = new System.Drawing.Point(130, 118);
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.Size = new System.Drawing.Size(288, 27);
            this.txtDestinatario.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMensaje);
            this.groupBox1.Controls.Add(this.txtAsunto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(31, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 338);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(45, 122);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(297, 210);
            this.txtMensaje.TabIndex = 3;
            this.txtMensaje.Text = "";
            // 
            // txtAsunto
            // 
            this.txtAsunto.Location = new System.Drawing.Point(45, 53);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(297, 27);
            this.txtAsunto.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mensaje";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Asunto";
            // 
            // btnEnviarEmail
            // 
            this.btnEnviarEmail.Location = new System.Drawing.Point(502, 118);
            this.btnEnviarEmail.Name = "btnEnviarEmail";
            this.btnEnviarEmail.Size = new System.Drawing.Size(148, 61);
            this.btnEnviarEmail.TabIndex = 7;
            this.btnEnviarEmail.Text = "Enviar";
            this.btnEnviarEmail.UseVisualStyleBackColor = true;
            this.btnEnviarEmail.Click += new System.EventHandler(this.btnEnviarEmail_Click);
            // 
            // listArchivos
            // 
            this.listArchivos.FormattingEnabled = true;
            this.listArchivos.ItemHeight = 20;
            this.listArchivos.Location = new System.Drawing.Point(482, 200);
            this.listArchivos.Name = "listArchivos";
            this.listArchivos.Size = new System.Drawing.Size(188, 244);
            this.listArchivos.TabIndex = 8;
            // 
            // btnAdjuntar
            // 
            this.btnAdjuntar.Location = new System.Drawing.Point(482, 463);
            this.btnAdjuntar.Name = "btnAdjuntar";
            this.btnAdjuntar.Size = new System.Drawing.Size(188, 57);
            this.btnAdjuntar.TabIndex = 9;
            this.btnAdjuntar.Text = "Adjuntar";
            this.btnAdjuntar.UseVisualStyleBackColor = true;
            this.btnAdjuntar.Click += new System.EventHandler(this.btnAdjuntar_Click);
            // 
            // rbGmail
            // 
            this.rbGmail.AutoSize = true;
            this.rbGmail.Location = new System.Drawing.Point(482, 64);
            this.rbGmail.Name = "rbGmail";
            this.rbGmail.Size = new System.Drawing.Size(69, 24);
            this.rbGmail.TabIndex = 10;
            this.rbGmail.TabStop = true;
            this.rbGmail.Text = "Gmail";
            this.rbGmail.UseVisualStyleBackColor = true;
            // 
            // rbHotmail
            // 
            this.rbHotmail.AutoSize = true;
            this.rbHotmail.Location = new System.Drawing.Point(566, 64);
            this.rbHotmail.Name = "rbHotmail";
            this.rbHotmail.Size = new System.Drawing.Size(84, 24);
            this.rbHotmail.TabIndex = 11;
            this.rbHotmail.TabStop = true;
            this.rbHotmail.Text = "Hotmail";
            this.rbHotmail.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 553);
            this.Controls.Add(this.rbHotmail);
            this.Controls.Add(this.rbGmail);
            this.Controls.Add(this.btnAdjuntar);
            this.Controls.Add(this.listArchivos);
            this.Controls.Add(this.btnEnviarEmail);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDestinatario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRemitente);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtRemitente;
        private Label label2;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtDestinatario;
        private GroupBox groupBox1;
        private RichTextBox txtMensaje;
        private TextBox txtAsunto;
        private Label label5;
        private Label label4;
        private Button btnEnviarEmail;
        private MaskedTextBox maskedTextBox1;
        private ListBox listArchivos;
        private Button btnAdjuntar;
        private RadioButton rbGmail;
        private RadioButton rbHotmail;
    }
}