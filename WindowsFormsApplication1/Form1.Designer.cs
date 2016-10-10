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
            this.label = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelTempo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(92, 144);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(100, 20);
            this.input.TabIndex = 0;
            this.input.Visible = false;
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            this.input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_KeyDown);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(116, 112);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(64, 13);
            this.label.TabIndex = 1;
            this.label.Text = "Fast Fingers";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // btn
            // 
            this.btn.Enabled = false;
            this.btn.Location = new System.Drawing.Point(105, 218);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 2;
            this.btn.Text = "calculate";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.start_Click);
            // 
            // labelTempo
            // 
            this.labelTempo.AutoSize = true;
            this.labelTempo.Location = new System.Drawing.Point(133, 70);
            this.labelTempo.Name = "labelTempo";
            this.labelTempo.Size = new System.Drawing.Size(35, 13);
            this.labelTempo.TabIndex = 4;
            this.labelTempo.Text = "label1";
            this.labelTempo.Visible = false;
            this.labelTempo.Click += new System.EventHandler(this.labelTempo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.labelTempo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.label);
            this.Controls.Add(this.input);
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

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelTempo;
    }
}

