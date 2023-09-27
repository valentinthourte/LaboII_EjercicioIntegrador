namespace Calculadora_ValentinThourte
{
    partial class frmCalculadora
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
            lblResultado = new Label();
            panel1 = new Panel();
            rbBinario = new RadioButton();
            rbDecimal = new RadioButton();
            lblSistemaResultado = new Label();
            lblPrimerOperador = new Label();
            lblOperacion = new Label();
            lblSegundoOperador = new Label();
            tbPrimerOperador = new TextBox();
            tbSegundoOperador = new TextBox();
            cbOperacion = new ComboBox();
            btnOperar = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.Location = new Point(29, 23);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(218, 54);
            lblResultado.TabIndex = 0;
            lblResultado.Text = "Resultado: ";
            // 
            // panel1
            // 
            panel1.Controls.Add(rbBinario);
            panel1.Controls.Add(rbDecimal);
            panel1.Location = new Point(285, 165);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 82);
            panel1.TabIndex = 1;
            // 
            // rbBinario
            // 
            rbBinario.AutoSize = true;
            rbBinario.Location = new Point(107, 46);
            rbBinario.Name = "rbBinario";
            rbBinario.Size = new Size(62, 19);
            rbBinario.TabIndex = 1;
            rbBinario.Text = "Binario";
            rbBinario.UseVisualStyleBackColor = true;
            rbBinario.CheckedChanged += rbBinario_CheckedChanged;
            // 
            // rbDecimal
            // 
            rbDecimal.AutoSize = true;
            rbDecimal.Checked = true;
            rbDecimal.Location = new Point(19, 46);
            rbDecimal.Name = "rbDecimal";
            rbDecimal.Size = new Size(68, 19);
            rbDecimal.TabIndex = 0;
            rbDecimal.TabStop = true;
            rbDecimal.Text = "Decimal";
            rbDecimal.UseVisualStyleBackColor = true;
            rbDecimal.CheckedChanged += rbDecimal_CheckedChanged;
            // 
            // lblSistemaResultado
            // 
            lblSistemaResultado.AutoSize = true;
            lblSistemaResultado.Location = new Point(288, 165);
            lblSistemaResultado.Name = "lblSistemaResultado";
            lblSistemaResultado.Size = new Size(143, 15);
            lblSistemaResultado.TabIndex = 2;
            lblSistemaResultado.Text = "Representar resultado en: ";
            // 
            // lblPrimerOperador
            // 
            lblPrimerOperador.AutoSize = true;
            lblPrimerOperador.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrimerOperador.Location = new Point(36, 285);
            lblPrimerOperador.Name = "lblPrimerOperador";
            lblPrimerOperador.Size = new Size(217, 37);
            lblPrimerOperador.TabIndex = 3;
            lblPrimerOperador.Text = "Primer operador:";
            // 
            // lblOperacion
            // 
            lblOperacion.AutoSize = true;
            lblOperacion.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblOperacion.Location = new Point(319, 285);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(146, 37);
            lblOperacion.TabIndex = 4;
            lblOperacion.Text = "Operacion:";
            // 
            // lblSegundoOperador
            // 
            lblSegundoOperador.AutoSize = true;
            lblSegundoOperador.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblSegundoOperador.Location = new Point(522, 285);
            lblSegundoOperador.Name = "lblSegundoOperador";
            lblSegundoOperador.Size = new Size(246, 37);
            lblSegundoOperador.TabIndex = 5;
            lblSegundoOperador.Text = "Segundo operador:";
            // 
            // tbPrimerOperador
            // 
            tbPrimerOperador.Location = new Point(47, 337);
            tbPrimerOperador.Name = "tbPrimerOperador";
            tbPrimerOperador.Size = new Size(191, 23);
            tbPrimerOperador.TabIndex = 6;
            tbPrimerOperador.Text = "0";
            tbPrimerOperador.TextChanged += tbPrimerOperador_TextChanged;
            tbPrimerOperador.KeyPress += tbOperadores_KeyPress;
            // 
            // tbSegundoOperador
            // 
            tbSegundoOperador.Location = new Point(547, 337);
            tbSegundoOperador.Name = "tbSegundoOperador";
            tbSegundoOperador.Size = new Size(191, 23);
            tbSegundoOperador.TabIndex = 8;
            tbSegundoOperador.Text = "0";
            tbSegundoOperador.TextChanged += tbSegundoOperador_TextChanged;
            tbSegundoOperador.KeyPress += tbOperadores_KeyPress;
            // 
            // cbOperacion
            // 
            cbOperacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOperacion.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cbOperacion.FormattingEnabled = true;
            cbOperacion.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cbOperacion.Location = new Point(294, 326);
            cbOperacion.Name = "cbOperacion";
            cbOperacion.Size = new Size(191, 36);
            cbOperacion.TabIndex = 2;
            // 
            // btnOperar
            // 
            btnOperar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnOperar.Location = new Point(294, 375);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(191, 43);
            btnOperar.TabIndex = 9;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = true;
            btnOperar.Click += btnOperar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(47, 375);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(191, 43);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrar.Location = new Point(547, 375);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(191, 43);
            btnCerrar.TabIndex = 11;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // frmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnOperar);
            Controls.Add(cbOperacion);
            Controls.Add(tbSegundoOperador);
            Controls.Add(tbPrimerOperador);
            Controls.Add(lblSegundoOperador);
            Controls.Add(lblOperacion);
            Controls.Add(lblPrimerOperador);
            Controls.Add(lblSistemaResultado);
            Controls.Add(panel1);
            Controls.Add(lblResultado);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora de Valentin Thourte";
            FormClosing += frmCalculadora_FormClosing;
            Load += frmCalculadora_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResultado;
        private Panel panel1;
        private RadioButton rbBinario;
        private RadioButton rbDecimal;
        private Label lblSistemaResultado;
        private Label lblPrimerOperador;
        private Label lblOperacion;
        private Label lblSegundoOperador;
        private TextBox tbPrimerOperador;
        private TextBox tbSegundoOperador;
        private ComboBox cbOperacion;
        private Button btnOperar;
        private Button btnLimpiar;
        private Button btnCerrar;
    }
}