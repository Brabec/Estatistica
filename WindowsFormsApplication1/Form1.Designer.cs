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
            this.playerName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(244, 256);
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
            this.title.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(251, 127);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(93, 19);
            this.title.TabIndex = 1;
            this.title.Text = "Fast Fingers";
            this.title.Click += new System.EventHandler(this.label_Click);
            // 
            // calcBtn
            // 
            this.calcBtn.Enabled = false;
            this.calcBtn.Location = new System.Drawing.Point(255, 350);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(75, 23);
            this.calcBtn.TabIndex = 2;
            this.calcBtn.Text = "calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(255, 321);
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
            this.labelTempo.Location = new System.Drawing.Point(58, 160);
            this.labelTempo.Name = "labelTempo";
            this.labelTempo.Size = new System.Drawing.Size(42, 17);
            this.labelTempo.TabIndex = 4;
            this.labelTempo.Text = "label1";
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
            this.nameLabel.Location = new System.Drawing.Point(252, 215);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(137, 13);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Digite o caractere desejado";
            this.nameLabel.Visible = false;
            // 
            // playerName
            // 
            this.playerName.Location = new System.Drawing.Point(244, 236);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(100, 20);
            this.playerName.TabIndex = 8;
            this.playerName.Visible = false;
            this.playerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.playerName_KeyDown);
            this.playerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.playerName_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 562);
            this.Controls.Add(this.playerName);
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
        private System.Windows.Forms.TextBox playerName;
    }
}

