namespace prjCalculadora
{
    partial class FormCalculadora
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
            this.pnSuperior = new System.Windows.Forms.Panel();
            this.lblVisor = new System.Windows.Forms.Label();
            this.bt0 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.btC = new System.Windows.Forms.Button();
            this.btCE = new System.Windows.Forms.Button();
            this.btBackspace = new System.Windows.Forms.Button();
            this.btPontoDecimal = new System.Windows.Forms.Button();
            this.btInverterSinal = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btSomar = new System.Windows.Forms.Button();
            this.btSubtrair = new System.Windows.Forms.Button();
            this.btMultiplicar = new System.Windows.Forms.Button();
            this.btDividir = new System.Windows.Forms.Button();
            this.btRaiz = new System.Windows.Forms.Button();
            this.btSeno = new System.Windows.Forms.Button();
            this.btCosseno = new System.Windows.Forms.Button();
            this.btTangente = new System.Windows.Forms.Button();
            this.btFracao = new System.Windows.Forms.Button();
            this.btPorcentagem = new System.Windows.Forms.Button();
            this.btPotencia = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.mnSair = new System.Windows.Forms.ToolStripMenuItem();
            this.pnSuperior.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSuperior
            // 
            this.pnSuperior.Controls.Add(this.lblVisor);
            this.pnSuperior.Controls.Add(this.menu);
            this.pnSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnSuperior.Name = "pnSuperior";
            this.pnSuperior.Size = new System.Drawing.Size(515, 97);
            this.pnSuperior.TabIndex = 0;
            // 
            // lblVisor
            // 
            this.lblVisor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVisor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblVisor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblVisor.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisor.Location = new System.Drawing.Point(0, 29);
            this.lblVisor.Name = "lblVisor";
            this.lblVisor.Padding = new System.Windows.Forms.Padding(2);
            this.lblVisor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblVisor.Size = new System.Drawing.Size(515, 68);
            this.lblVisor.TabIndex = 0;
            this.lblVisor.Text = "0";
            this.lblVisor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bt0
            // 
            this.bt0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt0.Font = new System.Drawing.Font("Cambria", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt0.Location = new System.Drawing.Point(106, 459);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(97, 83);
            this.bt0.TabIndex = 1;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.bt0_Click);
            // 
            // bt2
            // 
            this.bt2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt2.Font = new System.Drawing.Font("Cambria", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2.Location = new System.Drawing.Point(106, 370);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(97, 83);
            this.bt2.TabIndex = 1;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt3
            // 
            this.bt3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt3.Font = new System.Drawing.Font("Cambria", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt3.Location = new System.Drawing.Point(209, 370);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(97, 83);
            this.bt3.TabIndex = 1;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // bt1
            // 
            this.bt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt1.Font = new System.Drawing.Font("Cambria", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.Location = new System.Drawing.Point(3, 370);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(97, 83);
            this.bt1.TabIndex = 1;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt5
            // 
            this.bt5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt5.Font = new System.Drawing.Font("Cambria", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt5.Location = new System.Drawing.Point(106, 281);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(97, 83);
            this.bt5.TabIndex = 1;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // bt4
            // 
            this.bt4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt4.Font = new System.Drawing.Font("Cambria", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt4.Location = new System.Drawing.Point(3, 281);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(97, 83);
            this.bt4.TabIndex = 1;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // bt6
            // 
            this.bt6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt6.Font = new System.Drawing.Font("Cambria", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt6.Location = new System.Drawing.Point(209, 281);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(97, 83);
            this.bt6.TabIndex = 1;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.bt6_Click);
            // 
            // bt8
            // 
            this.bt8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt8.Font = new System.Drawing.Font("Cambria", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt8.Location = new System.Drawing.Point(106, 192);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(97, 83);
            this.bt8.TabIndex = 1;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.bt8_Click);
            // 
            // bt7
            // 
            this.bt7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt7.Font = new System.Drawing.Font("Cambria", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt7.Location = new System.Drawing.Point(3, 192);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(97, 83);
            this.bt7.TabIndex = 1;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.bt7_Click);
            // 
            // bt9
            // 
            this.bt9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt9.Font = new System.Drawing.Font("Cambria", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt9.Location = new System.Drawing.Point(209, 192);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(97, 83);
            this.bt9.TabIndex = 1;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.bt9_Click);
            // 
            // btC
            // 
            this.btC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btC.Font = new System.Drawing.Font("Cambria", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btC.Location = new System.Drawing.Point(3, 103);
            this.btC.Name = "btC";
            this.btC.Size = new System.Drawing.Size(97, 83);
            this.btC.TabIndex = 1;
            this.btC.Text = "C";
            this.btC.UseVisualStyleBackColor = true;
            this.btC.Click += new System.EventHandler(this.btC_Click);
            // 
            // btCE
            // 
            this.btCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCE.Font = new System.Drawing.Font("Cambria", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCE.Location = new System.Drawing.Point(106, 103);
            this.btCE.Name = "btCE";
            this.btCE.Size = new System.Drawing.Size(97, 83);
            this.btCE.TabIndex = 1;
            this.btCE.Text = "CE";
            this.btCE.UseVisualStyleBackColor = true;
            this.btCE.Click += new System.EventHandler(this.btCE_Click);
            // 
            // btBackspace
            // 
            this.btBackspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBackspace.Font = new System.Drawing.Font("Verdana", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBackspace.Location = new System.Drawing.Point(209, 103);
            this.btBackspace.Name = "btBackspace";
            this.btBackspace.Size = new System.Drawing.Size(97, 83);
            this.btBackspace.TabIndex = 1;
            this.btBackspace.Text = "←";
            this.btBackspace.UseVisualStyleBackColor = true;
            this.btBackspace.Click += new System.EventHandler(this.btBackspace_Click);
            // 
            // btPontoDecimal
            // 
            this.btPontoDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPontoDecimal.Font = new System.Drawing.Font("Cambria", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPontoDecimal.Location = new System.Drawing.Point(3, 459);
            this.btPontoDecimal.Name = "btPontoDecimal";
            this.btPontoDecimal.Size = new System.Drawing.Size(97, 83);
            this.btPontoDecimal.TabIndex = 1;
            this.btPontoDecimal.Text = "∙";
            this.btPontoDecimal.UseVisualStyleBackColor = true;
            this.btPontoDecimal.Click += new System.EventHandler(this.btPontoDecimal_Click);
            // 
            // btInverterSinal
            // 
            this.btInverterSinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInverterSinal.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInverterSinal.Location = new System.Drawing.Point(209, 459);
            this.btInverterSinal.Name = "btInverterSinal";
            this.btInverterSinal.Size = new System.Drawing.Size(97, 83);
            this.btInverterSinal.TabIndex = 1;
            this.btInverterSinal.Text = "±";
            this.btInverterSinal.UseVisualStyleBackColor = true;
            this.btInverterSinal.Click += new System.EventHandler(this.btInverterSinal_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Cambria", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(3, 548);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(406, 83);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "=";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btSomar
            // 
            this.btSomar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSomar.Font = new System.Drawing.Font("Cambria", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSomar.Location = new System.Drawing.Point(312, 192);
            this.btSomar.Name = "btSomar";
            this.btSomar.Size = new System.Drawing.Size(97, 83);
            this.btSomar.TabIndex = 1;
            this.btSomar.Text = "+";
            this.btSomar.UseVisualStyleBackColor = true;
            this.btSomar.Click += new System.EventHandler(this.btSomar_Click);
            // 
            // btSubtrair
            // 
            this.btSubtrair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSubtrair.Font = new System.Drawing.Font("Cambria", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSubtrair.Location = new System.Drawing.Point(312, 281);
            this.btSubtrair.Name = "btSubtrair";
            this.btSubtrair.Size = new System.Drawing.Size(97, 83);
            this.btSubtrair.TabIndex = 1;
            this.btSubtrair.Text = "-";
            this.btSubtrair.UseVisualStyleBackColor = true;
            this.btSubtrair.Click += new System.EventHandler(this.btSubtrair_Click);
            // 
            // btMultiplicar
            // 
            this.btMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMultiplicar.Font = new System.Drawing.Font("Cambria", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMultiplicar.Location = new System.Drawing.Point(312, 370);
            this.btMultiplicar.Name = "btMultiplicar";
            this.btMultiplicar.Size = new System.Drawing.Size(97, 83);
            this.btMultiplicar.TabIndex = 1;
            this.btMultiplicar.Text = "×";
            this.btMultiplicar.UseVisualStyleBackColor = true;
            this.btMultiplicar.Click += new System.EventHandler(this.btMultiplicar_Click);
            // 
            // btDividir
            // 
            this.btDividir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDividir.Font = new System.Drawing.Font("Cambria", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDividir.Location = new System.Drawing.Point(312, 459);
            this.btDividir.Name = "btDividir";
            this.btDividir.Size = new System.Drawing.Size(97, 83);
            this.btDividir.TabIndex = 1;
            this.btDividir.Text = "÷";
            this.btDividir.UseVisualStyleBackColor = true;
            this.btDividir.Click += new System.EventHandler(this.btDividir_Click);
            // 
            // btRaiz
            // 
            this.btRaiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRaiz.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRaiz.Location = new System.Drawing.Point(309, 103);
            this.btRaiz.Name = "btRaiz";
            this.btRaiz.Size = new System.Drawing.Size(100, 83);
            this.btRaiz.TabIndex = 1;
            this.btRaiz.Text = "SQRT";
            this.btRaiz.UseVisualStyleBackColor = true;
            this.btRaiz.Click += new System.EventHandler(this.btRaiz_Click);
            // 
            // btSeno
            // 
            this.btSeno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSeno.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSeno.Location = new System.Drawing.Point(415, 192);
            this.btSeno.Name = "btSeno";
            this.btSeno.Size = new System.Drawing.Size(97, 83);
            this.btSeno.TabIndex = 1;
            this.btSeno.Text = "Sen";
            this.btSeno.UseVisualStyleBackColor = true;
            this.btSeno.Click += new System.EventHandler(this.btSeno_Click);
            // 
            // btCosseno
            // 
            this.btCosseno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCosseno.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCosseno.Location = new System.Drawing.Point(415, 281);
            this.btCosseno.Name = "btCosseno";
            this.btCosseno.Size = new System.Drawing.Size(97, 83);
            this.btCosseno.TabIndex = 1;
            this.btCosseno.Text = "Cos";
            this.btCosseno.UseVisualStyleBackColor = true;
            this.btCosseno.Click += new System.EventHandler(this.btCosseno_Click);
            // 
            // btTangente
            // 
            this.btTangente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTangente.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTangente.Location = new System.Drawing.Point(415, 370);
            this.btTangente.Name = "btTangente";
            this.btTangente.Size = new System.Drawing.Size(97, 83);
            this.btTangente.TabIndex = 1;
            this.btTangente.Text = "Tan";
            this.btTangente.UseVisualStyleBackColor = true;
            this.btTangente.Click += new System.EventHandler(this.btTangente_Click);
            // 
            // btFracao
            // 
            this.btFracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFracao.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFracao.Location = new System.Drawing.Point(415, 459);
            this.btFracao.Name = "btFracao";
            this.btFracao.Size = new System.Drawing.Size(97, 83);
            this.btFracao.TabIndex = 1;
            this.btFracao.Text = "1/x";
            this.btFracao.UseVisualStyleBackColor = true;
            this.btFracao.Click += new System.EventHandler(this.btFracao_Click);
            // 
            // btPorcentagem
            // 
            this.btPorcentagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPorcentagem.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPorcentagem.Location = new System.Drawing.Point(415, 103);
            this.btPorcentagem.Name = "btPorcentagem";
            this.btPorcentagem.Size = new System.Drawing.Size(97, 83);
            this.btPorcentagem.TabIndex = 1;
            this.btPorcentagem.Text = "%";
            this.btPorcentagem.UseVisualStyleBackColor = true;
            this.btPorcentagem.Click += new System.EventHandler(this.btPorcentagem_Click);
            // 
            // btPotencia
            // 
            this.btPotencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPotencia.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPotencia.Location = new System.Drawing.Point(415, 548);
            this.btPotencia.Name = "btPotencia";
            this.btPotencia.Size = new System.Drawing.Size(97, 83);
            this.btPotencia.TabIndex = 1;
            this.btPotencia.Text = "x^y";
            this.btPotencia.UseVisualStyleBackColor = true;
            this.btPotencia.Click += new System.EventHandler(this.btPotencia_Click);
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnSair});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(515, 28);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // mnSair
            // 
            this.mnSair.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnSair.Name = "mnSair";
            this.mnSair.Size = new System.Drawing.Size(55, 24);
            this.mnSair.Text = "SAIR";
            this.mnSair.Click += new System.EventHandler(this.mnSair_Click);
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(515, 636);
            this.Controls.Add(this.btDividir);
            this.Controls.Add(this.btMultiplicar);
            this.Controls.Add(this.btSubtrair);
            this.Controls.Add(this.btRaiz);
            this.Controls.Add(this.btPotencia);
            this.Controls.Add(this.btFracao);
            this.Controls.Add(this.btTangente);
            this.Controls.Add(this.btCosseno);
            this.Controls.Add(this.btPorcentagem);
            this.Controls.Add(this.btSeno);
            this.Controls.Add(this.btSomar);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.btBackspace);
            this.Controls.Add(this.btCE);
            this.Controls.Add(this.btC);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.btPontoDecimal);
            this.Controls.Add(this.btInverterSinal);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.pnSuperior);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALCULADORA";
            this.Load += new System.EventHandler(this.FormCalculadora_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCalculadora_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormCalculadora_KeyPress);
            this.pnSuperior.ResumeLayout(false);
            this.pnSuperior.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnSuperior;
        private System.Windows.Forms.Label lblVisor;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button btC;
        private System.Windows.Forms.Button btCE;
        private System.Windows.Forms.Button btBackspace;
        private System.Windows.Forms.Button btPontoDecimal;
        private System.Windows.Forms.Button btInverterSinal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btSomar;
        private System.Windows.Forms.Button btSubtrair;
        private System.Windows.Forms.Button btMultiplicar;
        private System.Windows.Forms.Button btDividir;
        private System.Windows.Forms.Button btRaiz;
        private System.Windows.Forms.Button btSeno;
        private System.Windows.Forms.Button btCosseno;
        private System.Windows.Forms.Button btTangente;
        private System.Windows.Forms.Button btFracao;
        private System.Windows.Forms.Button btPorcentagem;
        private System.Windows.Forms.Button btPotencia;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem mnSair;
    }
}

