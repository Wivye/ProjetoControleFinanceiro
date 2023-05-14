using System.Windows.Forms;

namespace Projeto1
{
    partial class Form1
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
            this.menuSuperior = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnRodape = new System.Windows.Forms.Panel();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.pnCabecalho = new System.Windows.Forms.Panel();
            this.lblMenuPrincipal = new System.Windows.Forms.Label();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imgFinanceiro = new System.Windows.Forms.PictureBox();
            this.imgCadastro = new System.Windows.Forms.PictureBox();
            this.pnMenuPrincipal = new System.Windows.Forms.Panel();
            this.menuSuperior.SuspendLayout();
            this.pnRodape.SuspendLayout();
            this.pnCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFinanceiro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCadastro)).BeginInit();
            this.pnMenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuSuperior
            // 
            this.menuSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuSuperior.Location = new System.Drawing.Point(0, 0);
            this.menuSuperior.Name = "menuSuperior";
            this.menuSuperior.Size = new System.Drawing.Size(889, 24);
            this.menuSuperior.TabIndex = 2;
            this.menuSuperior.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // pnRodape
            // 
            this.pnRodape.Controls.Add(this.btnIniciar);
            this.pnRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnRodape.Location = new System.Drawing.Point(0, 536);
            this.pnRodape.Name = "pnRodape";
            this.pnRodape.Size = new System.Drawing.Size(889, 23);
            this.pnRodape.TabIndex = 4;
            this.pnRodape.TabStop = true;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(3, 0);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Visible = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // pnCabecalho
            // 
            this.pnCabecalho.Controls.Add(this.lblMenuPrincipal);
            this.pnCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCabecalho.Location = new System.Drawing.Point(0, 24);
            this.pnCabecalho.Name = "pnCabecalho";
            this.pnCabecalho.Size = new System.Drawing.Size(889, 66);
            this.pnCabecalho.TabIndex = 5;
            // 
            // lblMenuPrincipal
            // 
            this.lblMenuPrincipal.AutoSize = true;
            this.lblMenuPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuPrincipal.Location = new System.Drawing.Point(21, 24);
            this.lblMenuPrincipal.Name = "lblMenuPrincipal";
            this.lblMenuPrincipal.Size = new System.Drawing.Size(260, 31);
            this.lblMenuPrincipal.TabIndex = 0;
            this.lblMenuPrincipal.Text = "MENU PRINCIPAL";
            this.lblMenuPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCadastro
            // 
            this.lblCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.Location = new System.Drawing.Point(40, 136);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(100, 21);
            this.lblCadastro.TabIndex = 7;
            this.lblCadastro.Text = "Cadastro";
            this.lblCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Financeiro";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgFinanceiro
            // 
            this.imgFinanceiro.Image = global::Projeto1.Properties.Resources.Financeiro;
            this.imgFinanceiro.Location = new System.Drawing.Point(177, 33);
            this.imgFinanceiro.Name = "imgFinanceiro";
            this.imgFinanceiro.Size = new System.Drawing.Size(100, 100);
            this.imgFinanceiro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFinanceiro.TabIndex = 8;
            this.imgFinanceiro.TabStop = false;
            this.imgFinanceiro.MouseEnter += new System.EventHandler(this.imgFinanceiro_MouseEnter);
            this.imgFinanceiro.MouseLeave += new System.EventHandler(this.imgFinanceiro_MouseLeave);
            // 
            // imgCadastro
            // 
            this.imgCadastro.Image = global::Projeto1.Properties.Resources.Cadastro;
            this.imgCadastro.Location = new System.Drawing.Point(44, 33);
            this.imgCadastro.Name = "imgCadastro";
            this.imgCadastro.Size = new System.Drawing.Size(100, 100);
            this.imgCadastro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCadastro.TabIndex = 6;
            this.imgCadastro.TabStop = false;
            this.imgCadastro.MouseEnter += new System.EventHandler(this.imgCadastro_MouseEnter);
            this.imgCadastro.MouseLeave += new System.EventHandler(this.imgCadastro_MouseLeave);
            // 
            // pnMenuPrincipal
            // 
            this.pnMenuPrincipal.Controls.Add(this.imgCadastro);
            this.pnMenuPrincipal.Controls.Add(this.label1);
            this.pnMenuPrincipal.Controls.Add(this.lblCadastro);
            this.pnMenuPrincipal.Controls.Add(this.imgFinanceiro);
            this.pnMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMenuPrincipal.Location = new System.Drawing.Point(0, 90);
            this.pnMenuPrincipal.Name = "pnMenuPrincipal";
            this.pnMenuPrincipal.Size = new System.Drawing.Size(889, 446);
            this.pnMenuPrincipal.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 559);
            this.Controls.Add(this.pnMenuPrincipal);
            this.Controls.Add(this.pnCabecalho);
            this.Controls.Add(this.pnRodape);
            this.Controls.Add(this.menuSuperior);
            this.MainMenuStrip = this.menuSuperior;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.btnIniciar_Click);
            this.menuSuperior.ResumeLayout(false);
            this.menuSuperior.PerformLayout();
            this.pnRodape.ResumeLayout(false);
            this.pnCabecalho.ResumeLayout(false);
            this.pnCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFinanceiro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCadastro)).EndInit();
            this.pnMenuPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuSuperior;
        private System.Windows.Forms.Panel pnRodape;
        private System.Windows.Forms.Panel pnCabecalho;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.PictureBox imgCadastro;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgFinanceiro;
        private System.Windows.Forms.Panel pnMenuPrincipal;
        private Label lblMenuPrincipal;
        private Button btnIniciar;
    }
}

