namespace Encapsulation
{
    partial class frmCharacter
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numHealth = new System.Windows.Forms.NumericUpDown();
            this.txtStatusCharacter = new System.Windows.Forms.TextBox();
            this.txtCharacMaxLife = new System.Windows.Forms.TextBox();
            this.lstCharacters = new System.Windows.Forms.ListBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numHealth)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Health";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Characters";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Character with max health";
            // 
            // numHealth
            // 
            this.numHealth.Location = new System.Drawing.Point(103, 59);
            this.numHealth.Name = "numHealth";
            this.numHealth.Size = new System.Drawing.Size(62, 22);
            this.numHealth.TabIndex = 4;
            this.numHealth.ValueChanged += new System.EventHandler(this.numHealth_ValueChanged);
            // 
            // txtStatusCharacter
            // 
            this.txtStatusCharacter.Location = new System.Drawing.Point(29, 87);
            this.txtStatusCharacter.Name = "txtStatusCharacter";
            this.txtStatusCharacter.Size = new System.Drawing.Size(225, 22);
            this.txtStatusCharacter.TabIndex = 5;
            // 
            // txtCharacMaxLife
            // 
            this.txtCharacMaxLife.Location = new System.Drawing.Point(29, 351);
            this.txtCharacMaxLife.Name = "txtCharacMaxLife";
            this.txtCharacMaxLife.Size = new System.Drawing.Size(225, 22);
            this.txtCharacMaxLife.TabIndex = 6;
            // 
            // lstCharacters
            // 
            this.lstCharacters.FormattingEnabled = true;
            this.lstCharacters.ItemHeight = 16;
            this.lstCharacters.Location = new System.Drawing.Point(29, 145);
            this.lstCharacters.Name = "lstCharacters";
            this.lstCharacters.Size = new System.Drawing.Size(225, 180);
            this.lstCharacters.TabIndex = 7;
            this.lstCharacters.SelectedIndexChanged += new System.EventHandler(this.lstCharacters_SelectedIndexChanged);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(75, 18);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(179, 22);
            this.txtLogin.TabIndex = 8;
            this.txtLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogin_KeyPress);
            // 
            // frmCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 385);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lstCharacters);
            this.Controls.Add(this.txtCharacMaxLife);
            this.Controls.Add(this.txtStatusCharacter);
            this.Controls.Add(this.numHealth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCharacter";
            this.Text = "Character";
            this.Load += new System.EventHandler(this.frmCharacter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numHealth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numHealth;
        private System.Windows.Forms.TextBox txtStatusCharacter;
        private System.Windows.Forms.TextBox txtCharacMaxLife;
        private System.Windows.Forms.ListBox lstCharacters;
        private System.Windows.Forms.TextBox txtLogin;
    }
}

