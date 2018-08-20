namespace frmInicio
{
    partial class frmListar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListar));
            this.lbxIzq = new System.Windows.Forms.ListBox();
            this.lbxDer = new System.Windows.Forms.ListBox();
            this.txbIngreso = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.btnPasarTodos = new System.Windows.Forms.Button();
            this.btnPasarUno = new System.Windows.Forms.Button();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxIzq
            // 
            this.lbxIzq.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbxIzq.Font = new System.Drawing.Font("Consolas", 12.75F);
            this.lbxIzq.FormattingEnabled = true;
            this.lbxIzq.ItemHeight = 20;
            this.lbxIzq.Location = new System.Drawing.Point(13, 73);
            this.lbxIzq.Name = "lbxIzq";
            this.lbxIzq.Size = new System.Drawing.Size(235, 284);
            this.lbxIzq.TabIndex = 0;
            // 
            // lbxDer
            // 
            this.lbxDer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbxDer.Font = new System.Drawing.Font("Consolas", 12.75F);
            this.lbxDer.FormattingEnabled = true;
            this.lbxDer.ItemHeight = 20;
            this.lbxDer.Location = new System.Drawing.Point(335, 74);
            this.lbxDer.Name = "lbxDer";
            this.lbxDer.Size = new System.Drawing.Size(235, 284);
            this.lbxDer.TabIndex = 1;
            // 
            // txbIngreso
            // 
            this.txbIngreso.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.txbIngreso.Location = new System.Drawing.Point(211, 22);
            this.txbIngreso.Name = "txbIngreso";
            this.txbIngreso.Size = new System.Drawing.Size(175, 27);
            this.txbIngreso.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Mistral", 20.75F);
            this.btnAgregar.Location = new System.Drawing.Point(412, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 42);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Font = new System.Drawing.Font("Consolas", 12.25F);
            this.lblIngreso.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblIngreso.Location = new System.Drawing.Point(70, 26);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(135, 20);
            this.lblIngreso.TabIndex = 4;
            this.lblIngreso.Text = "Ingresar datos";
            // 
            // btnPasarTodos
            // 
            this.btnPasarTodos.BackColor = System.Drawing.Color.GreenYellow;
            this.btnPasarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPasarTodos.Font = new System.Drawing.Font("Mistral", 20.75F);
            this.btnPasarTodos.Location = new System.Drawing.Point(266, 127);
            this.btnPasarTodos.Name = "btnPasarTodos";
            this.btnPasarTodos.Size = new System.Drawing.Size(54, 34);
            this.btnPasarTodos.TabIndex = 5;
            this.btnPasarTodos.Text = ">>";
            this.btnPasarTodos.UseVisualStyleBackColor = false;
            this.btnPasarTodos.Click += new System.EventHandler(this.btnPasarTodos_Click);
            // 
            // btnPasarUno
            // 
            this.btnPasarUno.BackColor = System.Drawing.Color.GreenYellow;
            this.btnPasarUno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPasarUno.Font = new System.Drawing.Font("Mistral", 20.75F);
            this.btnPasarUno.Location = new System.Drawing.Point(266, 181);
            this.btnPasarUno.Name = "btnPasarUno";
            this.btnPasarUno.Size = new System.Drawing.Size(54, 34);
            this.btnPasarUno.TabIndex = 6;
            this.btnPasarUno.Text = ">";
            this.btnPasarUno.UseVisualStyleBackColor = false;
            this.btnPasarUno.Click += new System.EventHandler(this.btnPasarUno_Click);
            // 
            // btnDevolver
            // 
            this.btnDevolver.BackColor = System.Drawing.Color.GreenYellow;
            this.btnDevolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDevolver.Font = new System.Drawing.Font("Mistral", 20.75F);
            this.btnDevolver.Location = new System.Drawing.Point(266, 235);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(54, 34);
            this.btnDevolver.TabIndex = 7;
            this.btnDevolver.Text = "<";
            this.btnDevolver.UseVisualStyleBackColor = false;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.GreenYellow;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorrar.Font = new System.Drawing.Font("Mistral", 20.75F);
            this.btnBorrar.Location = new System.Drawing.Point(266, 290);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(54, 34);
            this.btnBorrar.TabIndex = 8;
            this.btnBorrar.Text = "...";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.GreenYellow;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Mistral", 20.75F);
            this.btnSalir.Location = new System.Drawing.Point(239, 396);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(109, 42);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(589, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.btnPasarUno);
            this.Controls.Add(this.btnPasarTodos);
            this.Controls.Add(this.lblIngreso);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txbIngreso);
            this.Controls.Add(this.lbxDer);
            this.Controls.Add(this.lbxIzq);
            this.Name = "frmListar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxIzq;
        private System.Windows.Forms.ListBox lbxDer;
        private System.Windows.Forms.TextBox txbIngreso;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.Button btnPasarTodos;
        private System.Windows.Forms.Button btnPasarUno;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnSalir;
    }
}