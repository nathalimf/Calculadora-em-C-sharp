namespace Calculadora
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
            txtResultado = new TextBox();
            btnZero = new Button();
            btnDois = new Button();
            btnUm = new Button();
            btnTres = new Button();
            btnQuatro = new Button();
            btnCinco = new Button();
            btnSeis = new Button();
            btnSete = new Button();
            btnOito = new Button();
            btnNove = new Button();
            btnDiv = new Button();
            btnVirgula = new Button();
            btnMulti = new Button();
            btnSub = new Button();
            btnAdd = new Button();
            btnIgual = new Button();
            C = new Button();
            btnApaga = new Button();
            lblOperacao = new Label();
            btnCE = new Button();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResultado.Location = new Point(12, 14);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(309, 51);
            txtResultado.TabIndex = 0;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btnZero
            // 
            btnZero.Location = new Point(90, 331);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(73, 59);
            btnZero.TabIndex = 1;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnDois
            // 
            btnDois.Location = new Point(90, 266);
            btnDois.Name = "btnDois";
            btnDois.Size = new Size(73, 59);
            btnDois.TabIndex = 2;
            btnDois.Text = "2";
            btnDois.UseVisualStyleBackColor = true;
            btnDois.Click += btnDois_Click;
            // 
            // btnUm
            // 
            btnUm.Location = new Point(11, 266);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(73, 59);
            btnUm.TabIndex = 3;
            btnUm.Text = "1";
            btnUm.UseVisualStyleBackColor = true;
            btnUm.Click += btnUm_Click;
            // 
            // btnTres
            // 
            btnTres.Location = new Point(169, 266);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(73, 59);
            btnTres.TabIndex = 4;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = true;
            btnTres.Click += btnTres_Click;
            // 
            // btnQuatro
            // 
            btnQuatro.Location = new Point(11, 201);
            btnQuatro.Name = "btnQuatro";
            btnQuatro.Size = new Size(73, 59);
            btnQuatro.TabIndex = 5;
            btnQuatro.Text = "4";
            btnQuatro.UseVisualStyleBackColor = true;
            btnQuatro.Click += btnQuatro_Click;
            // 
            // btnCinco
            // 
            btnCinco.Location = new Point(90, 201);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(73, 59);
            btnCinco.TabIndex = 6;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = true;
            btnCinco.Click += btnCinco_Click;
            // 
            // btnSeis
            // 
            btnSeis.Location = new Point(169, 201);
            btnSeis.Name = "btnSeis";
            btnSeis.RightToLeft = RightToLeft.No;
            btnSeis.Size = new Size(73, 59);
            btnSeis.TabIndex = 7;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            btnSeis.Click += btnSeis_Click;
            // 
            // btnSete
            // 
            btnSete.Location = new Point(11, 136);
            btnSete.Name = "btnSete";
            btnSete.Size = new Size(73, 59);
            btnSete.TabIndex = 8;
            btnSete.Text = "7";
            btnSete.UseVisualStyleBackColor = true;
            btnSete.Click += btnSete_Click;
            // 
            // btnOito
            // 
            btnOito.Location = new Point(90, 136);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(73, 59);
            btnOito.TabIndex = 9;
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = true;
            btnOito.Click += btnOito_Click;
            // 
            // btnNove
            // 
            btnNove.Location = new Point(169, 136);
            btnNove.Name = "btnNove";
            btnNove.Size = new Size(73, 59);
            btnNove.TabIndex = 10;
            btnNove.Text = "9";
            btnNove.UseVisualStyleBackColor = true;
            btnNove.Click += btnNove_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(248, 136);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(73, 59);
            btnDiv.TabIndex = 11;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnVirgula
            // 
            btnVirgula.Location = new Point(12, 331);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(73, 59);
            btnVirgula.TabIndex = 12;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = true;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // btnMulti
            // 
            btnMulti.Location = new Point(248, 201);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(73, 59);
            btnMulti.TabIndex = 13;
            btnMulti.Text = "x";
            btnMulti.UseVisualStyleBackColor = true;
            btnMulti.Click += btnMulti_Click;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(248, 266);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(73, 59);
            btnSub.TabIndex = 14;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(248, 331);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(73, 59);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = SystemColors.HotTrack;
            btnIgual.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIgual.ForeColor = SystemColors.ButtonHighlight;
            btnIgual.Location = new Point(169, 331);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(73, 59);
            btnIgual.TabIndex = 16;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // C
            // 
            C.Location = new Point(169, 71);
            C.Name = "C";
            C.Size = new Size(73, 59);
            C.TabIndex = 17;
            C.Text = "C";
            C.UseVisualStyleBackColor = true;
            C.Click += C_Click;
            // 
            // btnApaga
            // 
            btnApaga.Location = new Point(248, 71);
            btnApaga.Name = "btnApaga";
            btnApaga.Size = new Size(73, 59);
            btnApaga.TabIndex = 19;
            btnApaga.Text = "<-";
            btnApaga.UseVisualStyleBackColor = true;
            btnApaga.Click += btnApaga_Click;
            // 
            // lblOperacao
            // 
            lblOperacao.AutoSize = true;
            lblOperacao.ForeColor = SystemColors.ButtonShadow;
            lblOperacao.Location = new Point(27, 33);
            lblOperacao.Name = "lblOperacao";
            lblOperacao.Size = new Size(0, 15);
            lblOperacao.TabIndex = 20;
            // 
            // btnCE
            // 
            btnCE.Location = new Point(90, 71);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(73, 59);
            btnCE.TabIndex = 21;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            btnCE.Click += btnCE_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 411);
            Controls.Add(btnCE);
            Controls.Add(lblOperacao);
            Controls.Add(btnApaga);
            Controls.Add(C);
            Controls.Add(btnIgual);
            Controls.Add(btnAdd);
            Controls.Add(btnSub);
            Controls.Add(btnMulti);
            Controls.Add(btnVirgula);
            Controls.Add(btnDiv);
            Controls.Add(btnNove);
            Controls.Add(btnOito);
            Controls.Add(btnSete);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnQuatro);
            Controls.Add(btnTres);
            Controls.Add(btnUm);
            Controls.Add(btnDois);
            Controls.Add(btnZero);
            Controls.Add(txtResultado);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button btnZero;
        private Button btnDois;
        private Button btnUm;
        private Button btnTres;
        private Button btnQuatro;
        private Button btnCinco;
        private Button btnSeis;
        private Button btnSete;
        private Button btnOito;
        private Button btnNove;
        private Button btnDiv;
        private Button btnVirgula;
        private Button btnMulti;
        private Button btnSub;
        private Button btnAdd;
        private Button btnIgual;
        private Button C;
        private Button btnApaga;
        private Label lblOperacao;
        private Button btnCE;
    }
}
