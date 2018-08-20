namespace frmInicio
{
    partial class frmCarga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarga));
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblFNac = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.rbnFem = new System.Windows.Forms.RadioButton();
            this.rbnMasc = new System.Windows.Forms.RadioButton();
            this.lbxMusica = new System.Windows.Forms.ListBox();
            this.cbxColor = new System.Windows.Forms.ComboBox();
            this.lblMusica = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbApellido = new System.Windows.Forms.TextBox();
            this.txbEdad = new System.Windows.Forms.TextBox();
            this.gbxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblNombre.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.lblNombre.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblNombre.Location = new System.Drawing.Point(122, 31);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblApellido.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.lblApellido.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblApellido.Location = new System.Drawing.Point(104, 69);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(81, 20);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblFNac
            // 
            this.lblFNac.AutoSize = true;
            this.lblFNac.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.lblFNac.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblFNac.Location = new System.Drawing.Point(33, 112);
            this.lblFNac.Name = "lblFNac";
            this.lblFNac.Size = new System.Drawing.Size(153, 20);
            this.lblFNac.TabIndex = 2;
            this.lblFNac.Text = "Fecha Nacimiento";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.lblEdad.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblEdad.Location = new System.Drawing.Point(141, 142);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(45, 20);
            this.lblEdad.TabIndex = 3;
            this.lblEdad.Text = "Edad";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.dtpFechaNac.Location = new System.Drawing.Point(192, 106);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(258, 27);
            this.dtpFechaNac.TabIndex = 4;
            this.dtpFechaNac.ValueChanged += new System.EventHandler(this.dtpFechaNac_ValueChanged);
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rbnFem);
            this.gbxSexo.Controls.Add(this.rbnMasc);
            this.gbxSexo.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.gbxSexo.ForeColor = System.Drawing.Color.GreenYellow;
            this.gbxSexo.Location = new System.Drawing.Point(31, 172);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(419, 66);
            this.gbxSexo.TabIndex = 5;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // rbnFem
            // 
            this.rbnFem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbnFem.AutoSize = true;
            this.rbnFem.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.rbnFem.ForeColor = System.Drawing.Color.GreenYellow;
            this.rbnFem.Location = new System.Drawing.Point(239, 26);
            this.rbnFem.Name = "rbnFem";
            this.rbnFem.Size = new System.Drawing.Size(99, 24);
            this.rbnFem.TabIndex = 1;
            this.rbnFem.TabStop = true;
            this.rbnFem.Text = "Femenino";
            this.rbnFem.UseVisualStyleBackColor = true;
            // 
            // rbnMasc
            // 
            this.rbnMasc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbnMasc.AutoSize = true;
            this.rbnMasc.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.rbnMasc.ForeColor = System.Drawing.Color.GreenYellow;
            this.rbnMasc.Location = new System.Drawing.Point(81, 26);
            this.rbnMasc.Name = "rbnMasc";
            this.rbnMasc.Size = new System.Drawing.Size(108, 24);
            this.rbnMasc.TabIndex = 0;
            this.rbnMasc.TabStop = true;
            this.rbnMasc.Text = "Masculino";
            this.rbnMasc.UseVisualStyleBackColor = true;
            // 
            // lbxMusica
            // 
            this.lbxMusica.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.lbxMusica.FormattingEnabled = true;
            this.lbxMusica.ItemHeight = 19;
            this.lbxMusica.Items.AddRange(new object[] {
            "Cumbia",
            "Grunge",
            "Metal",
            "Pop",
            "Reggae",
            "Rock"});
            this.lbxMusica.Location = new System.Drawing.Point(192, 255);
            this.lbxMusica.MultiColumn = true;
            this.lbxMusica.Name = "lbxMusica";
            this.lbxMusica.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxMusica.Size = new System.Drawing.Size(258, 61);
            this.lbxMusica.Sorted = true;
            this.lbxMusica.TabIndex = 6;
            // 
            // cbxColor
            // 
            this.cbxColor.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.cbxColor.FormattingEnabled = true;
            this.cbxColor.Items.AddRange(new object[] {
            "Azul",
            "Rojo",
            "Verde",
            "Amarillo",
            "Negro",
            "Blanco",
            "Gris",
            "Violeta",
            "Naranja"});
            this.cbxColor.Location = new System.Drawing.Point(187, 330);
            this.cbxColor.Name = "cbxColor";
            this.cbxColor.Size = new System.Drawing.Size(263, 27);
            this.cbxColor.TabIndex = 7;
            // 
            // lblMusica
            // 
            this.lblMusica.AutoSize = true;
            this.lblMusica.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.lblMusica.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblMusica.Location = new System.Drawing.Point(33, 267);
            this.lblMusica.Name = "lblMusica";
            this.lblMusica.Size = new System.Drawing.Size(153, 20);
            this.lblMusica.TabIndex = 8;
            this.lblMusica.Text = "Gustos Musicales";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.lblColor.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblColor.Location = new System.Drawing.Point(131, 333);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(54, 20);
            this.lblColor.TabIndex = 9;
            this.lblColor.Text = "Color";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Font = new System.Drawing.Font("Mistral", 20.75F);
            this.btnAceptar.Location = new System.Drawing.Point(31, 393);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(126, 48);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.GreenYellow;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorrar.Font = new System.Drawing.Font("Mistral", 20.75F);
            this.btnBorrar.Location = new System.Drawing.Point(181, 393);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(125, 48);
            this.btnBorrar.TabIndex = 11;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.GreenYellow;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Mistral", 20.75F);
            this.btnCancelar.Location = new System.Drawing.Point(325, 393);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 48);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txbNombre
            // 
            this.txbNombre.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.txbNombre.Location = new System.Drawing.Point(192, 28);
            this.txbNombre.MaxLength = 50;
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(200, 27);
            this.txbNombre.TabIndex = 13;
            this.txbNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNombre_KeyPress);
            // 
            // txbApellido
            // 
            this.txbApellido.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.txbApellido.Location = new System.Drawing.Point(192, 66);
            this.txbApellido.MaxLength = 50;
            this.txbApellido.Name = "txbApellido";
            this.txbApellido.Size = new System.Drawing.Size(200, 27);
            this.txbApellido.TabIndex = 14;
            this.txbApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbApellido_KeyPress);
            // 
            // txbEdad
            // 
            this.txbEdad.Enabled = false;
            this.txbEdad.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.txbEdad.Location = new System.Drawing.Point(192, 139);
            this.txbEdad.Name = "txbEdad";
            this.txbEdad.Size = new System.Drawing.Size(45, 27);
            this.txbEdad.TabIndex = 15;
            this.txbEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(468, 453);
            this.Controls.Add(this.txbEdad);
            this.Controls.Add(this.txbApellido);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblMusica);
            this.Controls.Add(this.cbxColor);
            this.Controls.Add(this.lbxMusica);
            this.Controls.Add(this.gbxSexo);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblFNac);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmCarga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos persona";
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblFNac;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.RadioButton rbnFem;
        private System.Windows.Forms.RadioButton rbnMasc;
        private System.Windows.Forms.ListBox lbxMusica;
        private System.Windows.Forms.ComboBox cbxColor;
        private System.Windows.Forms.Label lblMusica;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbApellido;
        private System.Windows.Forms.TextBox txbEdad;
    }
}