namespace WindowsFormsApplication1
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
            this.input = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.calcBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.labelTempo = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.playerInput = new System.Windows.Forms.TextBox();
            this.word = new System.Windows.Forms.Label();
            this.moda = new System.Windows.Forms.Label();
            this.medianLabel = new System.Windows.Forms.Label();
            this.varLabel = new System.Windows.Forms.Label();
            this.sdLabel = new System.Windows.Forms.Label();
            this.erroLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(292, 269);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(100, 20);
            this.input.TabIndex = 0;
            this.input.Visible = false;
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            this.input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_KeyDown);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(280, 57);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(125, 25);
            this.title.TabIndex = 1;
            this.title.Text = "Fast Fingers";
            this.title.Click += new System.EventHandler(this.label_Click);
            // 
            // calcBtn
            // 
            this.calcBtn.Enabled = false;
            this.calcBtn.Location = new System.Drawing.Point(309, 356);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(75, 23);
            this.calcBtn.TabIndex = 2;
            this.calcBtn.Text = "calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(309, 311);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 3;
            this.startBtn.Text = "start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.start_Click);
            // 
            // labelTempo
            // 
            this.labelTempo.AutoSize = true;
            this.labelTempo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTempo.Location = new System.Drawing.Point(62, 125);
            this.labelTempo.Name = "labelTempo";
            this.labelTempo.Size = new System.Drawing.Size(130, 17);
            this.labelTempo.TabIndex = 4;
            this.labelTempo.Text = "Tempo de Digitação";
            this.labelTempo.Visible = false;
            this.labelTempo.Click += new System.EventHandler(this.labelTempo_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(61, 215);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(54, 19);
            this.scoreLabel.TabIndex = 6;
            this.scoreLabel.Text = "Score:";
            this.scoreLabel.Visible = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(282, 215);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(137, 13);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Digite o caractere desejado";
            this.nameLabel.Visible = false;
            // 
            // playerInput
            // 
            this.playerInput.Location = new System.Drawing.Point(292, 243);
            this.playerInput.Name = "playerInput";
            this.playerInput.Size = new System.Drawing.Size(100, 20);
            this.playerInput.TabIndex = 8;
            this.playerInput.Visible = false;
            this.playerInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.playerInput_KeyDown);
            this.playerInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.playerInput_KeyPress);
            // 
            // word
            // 
            this.word.AutoSize = true;
            this.word.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word.Location = new System.Drawing.Point(312, 141);
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(72, 18);
            this.word.TabIndex = 9;
            this.word.Text = "randWord";
            this.word.Visible = false;
            // 
            // moda
            // 
            this.moda.AutoSize = true;
            this.moda.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moda.Location = new System.Drawing.Point(65, 292);
            this.moda.Name = "moda";
            this.moda.Size = new System.Drawing.Size(39, 16);
            this.moda.TabIndex = 10;
            this.moda.Text = "Moda";
            this.moda.Visible = false;
            // 
            // medianLabel
            // 
            this.medianLabel.AutoSize = true;
            this.medianLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medianLabel.Location = new System.Drawing.Point(68, 337);
            this.medianLabel.Name = "medianLabel";
            this.medianLabel.Size = new System.Drawing.Size(56, 16);
            this.medianLabel.TabIndex = 11;
            this.medianLabel.Text = "Mediana";
            this.medianLabel.Visible = false;
            // 
            // varLabel
            // 
            this.varLabel.AutoSize = true;
            this.varLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.varLabel.Location = new System.Drawing.Point(371, 292);
            this.varLabel.Name = "varLabel";
            this.varLabel.Size = new System.Drawing.Size(61, 16);
            this.varLabel.TabIndex = 12;
            this.varLabel.Text = "Variancia";
            this.varLabel.Visible = false;
            // 
            // sdLabel
            // 
            this.sdLabel.AutoSize = true;
            this.sdLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdLabel.Location = new System.Drawing.Point(371, 337);
            this.sdLabel.Name = "sdLabel";
            this.sdLabel.Size = new System.Drawing.Size(89, 16);
            this.sdLabel.TabIndex = 13;
            this.sdLabel.Text = "Desvio Padrão";
            this.sdLabel.Visible = false;
            // 
            // erroLabel
            // 
            this.erroLabel.AutoSize = true;
            this.erroLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erroLabel.Location = new System.Drawing.Point(424, 125);
            this.erroLabel.Name = "erroLabel";
            this.erroLabel.Size = new System.Drawing.Size(84, 16);
            this.erroLabel.TabIndex = 14;
            this.erroLabel.Text = "Prob. de Erro";
            this.erroLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.erroLabel);
            this.Controls.Add(this.sdLabel);
            this.Controls.Add(this.varLabel);
            this.Controls.Add(this.medianLabel);
            this.Controls.Add(this.moda);
            this.Controls.Add(this.word);
            this.Controls.Add(this.playerInput);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.labelTempo);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.title);
            this.Controls.Add(this.input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Keystroke Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;

        public string getString()
        {
            string word = this.input.Text;
            return word;
        }

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label labelTempo;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox playerInput;
        private System.Windows.Forms.Label word;
        private System.Windows.Forms.Label moda;
        private System.Windows.Forms.Label medianLabel;
        private System.Windows.Forms.Label varLabel;
        private System.Windows.Forms.Label sdLabel;
        private System.Windows.Forms.Label erroLabel;
    }
}

