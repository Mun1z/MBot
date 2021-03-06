﻿namespace MBot
{
    partial class mBot
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTrainer = new System.Windows.Forms.Button();
            this.btnMana = new System.Windows.Forms.Button();
            this.btnCura = new System.Windows.Forms.Button();
            this.btnBasico = new System.Windows.Forms.Button();
            this.tabTrainer = new System.Windows.Forms.TabPage();
            this.gbTrainer = new System.Windows.Forms.GroupBox();
            this.tabMana = new System.Windows.Forms.TabPage();
            this.gbMana = new System.Windows.Forms.GroupBox();
            this.tabHeal = new System.Windows.Forms.TabPage();
            this.gbHeal = new System.Windows.Forms.GroupBox();
            this.btnComerCarne = new System.Windows.Forms.Button();
            this.tabBasics = new System.Windows.Forms.TabPage();
            this.gbBasicf = new System.Windows.Forms.GroupBox();
            this.btnBlackSkull = new System.Windows.Forms.Button();
            this.chkEsconderArvores = new System.Windows.Forms.CheckBox();
            this.chkRaioX = new System.Windows.Forms.CheckBox();
            this.chkLuzTotal = new System.Windows.Forms.CheckBox();
            this.btnOutfitDeamon = new System.Windows.Forms.Button();
            this.btnOutfitWizard = new System.Windows.Forms.Button();
            this.btnEnviarMenssagem = new System.Windows.Forms.Button();
            this.btnVirarBaixo = new System.Windows.Forms.Button();
            this.btnAndarCima = new System.Windows.Forms.Button();
            this.btnEspiarClear = new System.Windows.Forms.Button();
            this.btnEspiarBaixo = new System.Windows.Forms.Button();
            this.btnEspiarCima = new System.Windows.Forms.Button();
            this.tabSelect = new System.Windows.Forms.TabControl();
            this.tmrExura = new System.Windows.Forms.Timer(this.components);
            this.tmrAfk = new System.Windows.Forms.Timer(this.components);
            this.chkAfk = new System.Windows.Forms.CheckBox();
            this.chkExura = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.tabTrainer.SuspendLayout();
            this.gbTrainer.SuspendLayout();
            this.tabMana.SuspendLayout();
            this.tabHeal.SuspendLayout();
            this.gbHeal.SuspendLayout();
            this.tabBasics.SuspendLayout();
            this.gbBasicf.SuspendLayout();
            this.tabSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTrainer);
            this.panel1.Controls.Add(this.btnMana);
            this.panel1.Controls.Add(this.btnCura);
            this.panel1.Controls.Add(this.btnBasico);
            this.panel1.Location = new System.Drawing.Point(6, -15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 68);
            this.panel1.TabIndex = 1;
            // 
            // btnTrainer
            // 
            this.btnTrainer.Image = global::MBot.Properties.Resources.img_trainer;
            this.btnTrainer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrainer.Location = new System.Drawing.Point(260, 18);
            this.btnTrainer.Name = "btnTrainer";
            this.btnTrainer.Size = new System.Drawing.Size(85, 50);
            this.btnTrainer.TabIndex = 3;
            this.btnTrainer.Text = "Trainer";
            this.btnTrainer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrainer.UseVisualStyleBackColor = true;
            this.btnTrainer.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnMana
            // 
            this.btnMana.Image = global::MBot.Properties.Resources.img_mana;
            this.btnMana.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMana.Location = new System.Drawing.Point(175, 18);
            this.btnMana.Name = "btnMana";
            this.btnMana.Size = new System.Drawing.Size(85, 50);
            this.btnMana.TabIndex = 2;
            this.btnMana.Text = "Mana";
            this.btnMana.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMana.UseVisualStyleBackColor = true;
            this.btnMana.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCura
            // 
            this.btnCura.Image = global::MBot.Properties.Resources.img_heal;
            this.btnCura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCura.Location = new System.Drawing.Point(90, 18);
            this.btnCura.Name = "btnCura";
            this.btnCura.Size = new System.Drawing.Size(85, 50);
            this.btnCura.TabIndex = 1;
            this.btnCura.Text = "Cura";
            this.btnCura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCura.UseVisualStyleBackColor = true;
            this.btnCura.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBasico
            // 
            this.btnBasico.Image = global::MBot.Properties.Resources.img_basics;
            this.btnBasico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBasico.Location = new System.Drawing.Point(5, 18);
            this.btnBasico.Name = "btnBasico";
            this.btnBasico.Size = new System.Drawing.Size(85, 50);
            this.btnBasico.TabIndex = 0;
            this.btnBasico.Text = "Basico";
            this.btnBasico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBasico.UseVisualStyleBackColor = true;
            this.btnBasico.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabTrainer
            // 
            this.tabTrainer.Controls.Add(this.gbTrainer);
            this.tabTrainer.Location = new System.Drawing.Point(4, 25);
            this.tabTrainer.Name = "tabTrainer";
            this.tabTrainer.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrainer.Size = new System.Drawing.Size(337, 205);
            this.tabTrainer.TabIndex = 4;
            this.tabTrainer.Text = "Trainer";
            this.tabTrainer.UseVisualStyleBackColor = true;
            // 
            // gbTrainer
            // 
            this.gbTrainer.Controls.Add(this.chkAfk);
            this.gbTrainer.Location = new System.Drawing.Point(6, 11);
            this.gbTrainer.Name = "gbTrainer";
            this.gbTrainer.Size = new System.Drawing.Size(321, 188);
            this.gbTrainer.TabIndex = 0;
            this.gbTrainer.TabStop = false;
            this.gbTrainer.Text = "Trainer";
            // 
            // tabMana
            // 
            this.tabMana.Controls.Add(this.gbMana);
            this.tabMana.Location = new System.Drawing.Point(4, 25);
            this.tabMana.Name = "tabMana";
            this.tabMana.Padding = new System.Windows.Forms.Padding(3);
            this.tabMana.Size = new System.Drawing.Size(337, 205);
            this.tabMana.TabIndex = 3;
            this.tabMana.Text = "Mana";
            this.tabMana.UseVisualStyleBackColor = true;
            // 
            // gbMana
            // 
            this.gbMana.Location = new System.Drawing.Point(6, 11);
            this.gbMana.Name = "gbMana";
            this.gbMana.Size = new System.Drawing.Size(321, 188);
            this.gbMana.TabIndex = 0;
            this.gbMana.TabStop = false;
            this.gbMana.Text = "Restaurar Mana  / Treinar Mana";
            // 
            // tabHeal
            // 
            this.tabHeal.Controls.Add(this.gbHeal);
            this.tabHeal.Location = new System.Drawing.Point(4, 25);
            this.tabHeal.Name = "tabHeal";
            this.tabHeal.Padding = new System.Windows.Forms.Padding(3);
            this.tabHeal.Size = new System.Drawing.Size(337, 205);
            this.tabHeal.TabIndex = 1;
            this.tabHeal.Text = "Healer";
            this.tabHeal.UseVisualStyleBackColor = true;
            // 
            // gbHeal
            // 
            this.gbHeal.Controls.Add(this.chkExura);
            this.gbHeal.Controls.Add(this.btnComerCarne);
            this.gbHeal.Location = new System.Drawing.Point(6, 10);
            this.gbHeal.Name = "gbHeal";
            this.gbHeal.Size = new System.Drawing.Size(321, 188);
            this.gbHeal.TabIndex = 0;
            this.gbHeal.TabStop = false;
            this.gbHeal.Text = "Restaurar Vida";
            // 
            // btnComerCarne
            // 
            this.btnComerCarne.Location = new System.Drawing.Point(6, 19);
            this.btnComerCarne.Name = "btnComerCarne";
            this.btnComerCarne.Size = new System.Drawing.Size(104, 23);
            this.btnComerCarne.TabIndex = 16;
            this.btnComerCarne.Text = "Comer Carne";
            this.btnComerCarne.UseVisualStyleBackColor = true;
            this.btnComerCarne.Click += new System.EventHandler(this.btnComerCarne_Click);
            // 
            // tabBasics
            // 
            this.tabBasics.Controls.Add(this.gbBasicf);
            this.tabBasics.Location = new System.Drawing.Point(4, 25);
            this.tabBasics.Name = "tabBasics";
            this.tabBasics.Padding = new System.Windows.Forms.Padding(3);
            this.tabBasics.Size = new System.Drawing.Size(337, 205);
            this.tabBasics.TabIndex = 0;
            this.tabBasics.Text = "Basics";
            this.tabBasics.UseVisualStyleBackColor = true;
            // 
            // gbBasicf
            // 
            this.gbBasicf.Controls.Add(this.btnBlackSkull);
            this.gbBasicf.Controls.Add(this.chkEsconderArvores);
            this.gbBasicf.Controls.Add(this.chkRaioX);
            this.gbBasicf.Controls.Add(this.chkLuzTotal);
            this.gbBasicf.Controls.Add(this.btnOutfitDeamon);
            this.gbBasicf.Controls.Add(this.btnOutfitWizard);
            this.gbBasicf.Controls.Add(this.btnEnviarMenssagem);
            this.gbBasicf.Controls.Add(this.btnVirarBaixo);
            this.gbBasicf.Controls.Add(this.btnAndarCima);
            this.gbBasicf.Controls.Add(this.btnEspiarClear);
            this.gbBasicf.Controls.Add(this.btnEspiarBaixo);
            this.gbBasicf.Controls.Add(this.btnEspiarCima);
            this.gbBasicf.Location = new System.Drawing.Point(6, 10);
            this.gbBasicf.Name = "gbBasicf";
            this.gbBasicf.Size = new System.Drawing.Size(321, 188);
            this.gbBasicf.TabIndex = 0;
            this.gbBasicf.TabStop = false;
            this.gbBasicf.Text = "Basico";
            this.gbBasicf.Enter += new System.EventHandler(this.gbBasicf_Enter);
            // 
            // btnBlackSkull
            // 
            this.btnBlackSkull.Location = new System.Drawing.Point(108, 74);
            this.btnBlackSkull.Name = "btnBlackSkull";
            this.btnBlackSkull.Size = new System.Drawing.Size(104, 23);
            this.btnBlackSkull.TabIndex = 13;
            this.btnBlackSkull.Text = "Black Skull";
            this.btnBlackSkull.UseVisualStyleBackColor = true;
            this.btnBlackSkull.Click += new System.EventHandler(this.btnBlackSkull_Click);
            // 
            // chkEsconderArvores
            // 
            this.chkEsconderArvores.AutoSize = true;
            this.chkEsconderArvores.Location = new System.Drawing.Point(218, 68);
            this.chkEsconderArvores.Name = "chkEsconderArvores";
            this.chkEsconderArvores.Size = new System.Drawing.Size(110, 17);
            this.chkEsconderArvores.TabIndex = 11;
            this.chkEsconderArvores.Text = "Esconder Arvores";
            this.chkEsconderArvores.UseVisualStyleBackColor = true;
            this.chkEsconderArvores.CheckedChanged += new System.EventHandler(this.chkEsconderArvores_CheckedChanged);
            // 
            // chkRaioX
            // 
            this.chkRaioX.AutoSize = true;
            this.chkRaioX.Location = new System.Drawing.Point(218, 44);
            this.chkRaioX.Name = "chkRaioX";
            this.chkRaioX.Size = new System.Drawing.Size(56, 17);
            this.chkRaioX.TabIndex = 10;
            this.chkRaioX.Text = "Raio x";
            this.chkRaioX.UseVisualStyleBackColor = true;
            this.chkRaioX.CheckedChanged += new System.EventHandler(this.chkRaioX_CheckedChanged);
            // 
            // chkLuzTotal
            // 
            this.chkLuzTotal.AutoSize = true;
            this.chkLuzTotal.Location = new System.Drawing.Point(218, 20);
            this.chkLuzTotal.Name = "chkLuzTotal";
            this.chkLuzTotal.Size = new System.Drawing.Size(70, 17);
            this.chkLuzTotal.TabIndex = 9;
            this.chkLuzTotal.Text = "Luz Total";
            this.chkLuzTotal.UseVisualStyleBackColor = true;
            this.chkLuzTotal.CheckedChanged += new System.EventHandler(this.chkLuzTotal_CheckedChanged);
            // 
            // btnOutfitDeamon
            // 
            this.btnOutfitDeamon.Location = new System.Drawing.Point(108, 45);
            this.btnOutfitDeamon.Name = "btnOutfitDeamon";
            this.btnOutfitDeamon.Size = new System.Drawing.Size(104, 23);
            this.btnOutfitDeamon.TabIndex = 8;
            this.btnOutfitDeamon.Text = "Outfit Demon";
            this.btnOutfitDeamon.UseVisualStyleBackColor = true;
            this.btnOutfitDeamon.Click += new System.EventHandler(this.btnOutfitDeamon_Click);
            // 
            // btnOutfitWizard
            // 
            this.btnOutfitWizard.Location = new System.Drawing.Point(108, 16);
            this.btnOutfitWizard.Name = "btnOutfitWizard";
            this.btnOutfitWizard.Size = new System.Drawing.Size(104, 23);
            this.btnOutfitWizard.TabIndex = 7;
            this.btnOutfitWizard.Text = "Outfit Wizard";
            this.btnOutfitWizard.UseVisualStyleBackColor = true;
            this.btnOutfitWizard.Click += new System.EventHandler(this.btnMudarOutfit_Click);
            // 
            // btnEnviarMenssagem
            // 
            this.btnEnviarMenssagem.Location = new System.Drawing.Point(3, 161);
            this.btnEnviarMenssagem.Name = "btnEnviarMenssagem";
            this.btnEnviarMenssagem.Size = new System.Drawing.Size(104, 23);
            this.btnEnviarMenssagem.TabIndex = 5;
            this.btnEnviarMenssagem.Text = "Enviar menssagem";
            this.btnEnviarMenssagem.UseVisualStyleBackColor = true;
            this.btnEnviarMenssagem.Click += new System.EventHandler(this.btnEnviarMenssagem_Click);
            // 
            // btnVirarBaixo
            // 
            this.btnVirarBaixo.Location = new System.Drawing.Point(3, 132);
            this.btnVirarBaixo.Name = "btnVirarBaixo";
            this.btnVirarBaixo.Size = new System.Drawing.Size(104, 23);
            this.btnVirarBaixo.TabIndex = 4;
            this.btnVirarBaixo.Text = "Virar para baixo";
            this.btnVirarBaixo.UseVisualStyleBackColor = true;
            this.btnVirarBaixo.Click += new System.EventHandler(this.btnVirarBaixo_Click);
            // 
            // btnAndarCima
            // 
            this.btnAndarCima.Location = new System.Drawing.Point(3, 103);
            this.btnAndarCima.Name = "btnAndarCima";
            this.btnAndarCima.Size = new System.Drawing.Size(104, 23);
            this.btnAndarCima.TabIndex = 3;
            this.btnAndarCima.Text = "Andar para cima";
            this.btnAndarCima.UseVisualStyleBackColor = true;
            this.btnAndarCima.Click += new System.EventHandler(this.btnAndarCima_Click);
            // 
            // btnEspiarClear
            // 
            this.btnEspiarClear.Location = new System.Drawing.Point(3, 74);
            this.btnEspiarClear.Name = "btnEspiarClear";
            this.btnEspiarClear.Size = new System.Drawing.Size(104, 23);
            this.btnEspiarClear.TabIndex = 2;
            this.btnEspiarClear.Text = "Limpar espiar";
            this.btnEspiarClear.UseVisualStyleBackColor = true;
            this.btnEspiarClear.Click += new System.EventHandler(this.btnEspiarClear_Click);
            // 
            // btnEspiarBaixo
            // 
            this.btnEspiarBaixo.Location = new System.Drawing.Point(3, 45);
            this.btnEspiarBaixo.Name = "btnEspiarBaixo";
            this.btnEspiarBaixo.Size = new System.Drawing.Size(104, 23);
            this.btnEspiarBaixo.TabIndex = 1;
            this.btnEspiarBaixo.Text = "Espiar pra baixo";
            this.btnEspiarBaixo.UseVisualStyleBackColor = true;
            this.btnEspiarBaixo.Click += new System.EventHandler(this.btnEspiarBaixo_Click);
            // 
            // btnEspiarCima
            // 
            this.btnEspiarCima.Location = new System.Drawing.Point(3, 16);
            this.btnEspiarCima.Name = "btnEspiarCima";
            this.btnEspiarCima.Size = new System.Drawing.Size(104, 23);
            this.btnEspiarCima.TabIndex = 0;
            this.btnEspiarCima.Text = "Espiar pra cima";
            this.btnEspiarCima.UseVisualStyleBackColor = true;
            this.btnEspiarCima.Click += new System.EventHandler(this.btnEspiarCima_Click);
            // 
            // tabSelect
            // 
            this.tabSelect.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabSelect.Controls.Add(this.tabBasics);
            this.tabSelect.Controls.Add(this.tabHeal);
            this.tabSelect.Controls.Add(this.tabMana);
            this.tabSelect.Controls.Add(this.tabTrainer);
            this.tabSelect.Location = new System.Drawing.Point(9, 29);
            this.tabSelect.Multiline = true;
            this.tabSelect.Name = "tabSelect";
            this.tabSelect.SelectedIndex = 0;
            this.tabSelect.Size = new System.Drawing.Size(345, 234);
            this.tabSelect.TabIndex = 2;
            // 
            // tmrExura
            // 
            this.tmrExura.Interval = 200;
            this.tmrExura.Tick += new System.EventHandler(this.tmrExura_Tick);
            // 
            // tmrAfk
            // 
            this.tmrAfk.Interval = 1000;
            this.tmrAfk.Tick += new System.EventHandler(this.tmrAfk_Tick);
            // 
            // chkAfk
            // 
            this.chkAfk.AutoSize = true;
            this.chkAfk.Location = new System.Drawing.Point(6, 19);
            this.chkAfk.Name = "chkAfk";
            this.chkAfk.Size = new System.Drawing.Size(42, 17);
            this.chkAfk.TabIndex = 13;
            this.chkAfk.Text = "Afk";
            this.chkAfk.UseVisualStyleBackColor = true;
            this.chkAfk.CheckedChanged += new System.EventHandler(this.chkAfk_CheckedChanged_1);
            // 
            // chkExura
            // 
            this.chkExura.AutoSize = true;
            this.chkExura.Location = new System.Drawing.Point(6, 48);
            this.chkExura.Name = "chkExura";
            this.chkExura.Size = new System.Drawing.Size(78, 17);
            this.chkExura.TabIndex = 17;
            this.chkExura.Text = "Auto Exura";
            this.chkExura.UseVisualStyleBackColor = true;
            this.chkExura.CheckedChanged += new System.EventHandler(this.chkExura_CheckedChanged);
            // 
            // mBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 263);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "mBot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MBot";
            this.Load += new System.EventHandler(this.mBot_Load);
            this.panel1.ResumeLayout(false);
            this.tabTrainer.ResumeLayout(false);
            this.gbTrainer.ResumeLayout(false);
            this.gbTrainer.PerformLayout();
            this.tabMana.ResumeLayout(false);
            this.tabHeal.ResumeLayout(false);
            this.gbHeal.ResumeLayout(false);
            this.gbHeal.PerformLayout();
            this.tabBasics.ResumeLayout(false);
            this.gbBasicf.ResumeLayout(false);
            this.gbBasicf.PerformLayout();
            this.tabSelect.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBasico;
        private System.Windows.Forms.Button btnCura;
        private System.Windows.Forms.Button btnMana;
        private System.Windows.Forms.Button btnTrainer;
        private System.Windows.Forms.TabPage tabTrainer;
        private System.Windows.Forms.GroupBox gbTrainer;
        private System.Windows.Forms.TabPage tabMana;
        private System.Windows.Forms.GroupBox gbMana;
        private System.Windows.Forms.TabPage tabHeal;
        private System.Windows.Forms.GroupBox gbHeal;
        private System.Windows.Forms.TabPage tabBasics;
        private System.Windows.Forms.GroupBox gbBasicf;
        private System.Windows.Forms.TabControl tabSelect;
        private System.Windows.Forms.Button btnEspiarClear;
        private System.Windows.Forms.Button btnEspiarBaixo;
        private System.Windows.Forms.Button btnEspiarCima;
        private System.Windows.Forms.Button btnVirarBaixo;
        private System.Windows.Forms.Button btnAndarCima;
        private System.Windows.Forms.Button btnEnviarMenssagem;
        private System.Windows.Forms.Button btnOutfitWizard;
        private System.Windows.Forms.Button btnOutfitDeamon;
        private System.Windows.Forms.CheckBox chkLuzTotal;
        private System.Windows.Forms.CheckBox chkRaioX;
        private System.Windows.Forms.CheckBox chkEsconderArvores;
        private System.Windows.Forms.Button btnBlackSkull;
        private System.Windows.Forms.Timer tmrExura;
        private System.Windows.Forms.Timer tmrAfk;
        private System.Windows.Forms.Button btnComerCarne;
        private System.Windows.Forms.CheckBox chkAfk;
        private System.Windows.Forms.CheckBox chkExura;
    }
}

