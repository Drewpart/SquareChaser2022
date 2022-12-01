namespace SquareChaser
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.p1Score = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.p2Score = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.yesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player1 Score ";
            // 
            // p1Score
            // 
            this.p1Score.BackColor = System.Drawing.Color.Transparent;
            this.p1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1Score.ForeColor = System.Drawing.Color.White;
            this.p1Score.Location = new System.Drawing.Point(117, 313);
            this.p1Score.Name = "p1Score";
            this.p1Score.Size = new System.Drawing.Size(57, 27);
            this.p1Score.TabIndex = 1;
            this.p1Score.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(228, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Player2 Score ";
            // 
            // p2Score
            // 
            this.p2Score.BackColor = System.Drawing.Color.Transparent;
            this.p2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2Score.ForeColor = System.Drawing.Color.White;
            this.p2Score.Location = new System.Drawing.Point(337, 313);
            this.p2Score.Name = "p2Score";
            this.p2Score.Size = new System.Drawing.Size(57, 27);
            this.p2Score.TabIndex = 3;
            this.p2Score.Text = "0";
            // 
            // endLabel
            // 
            this.endLabel.BackColor = System.Drawing.Color.Transparent;
            this.endLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endLabel.ForeColor = System.Drawing.Color.White;
            this.endLabel.Location = new System.Drawing.Point(35, 163);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(359, 54);
            this.endLabel.TabIndex = 4;
            this.endLabel.Click += new System.EventHandler(this.endLabel_Click);
            // 
            // yesButton
            // 
            this.yesButton.Location = new System.Drawing.Point(257, 249);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(75, 23);
            this.yesButton.TabIndex = 5;
            this.yesButton.Text = "Yes";
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.Visible = false;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // noButton
            // 
            this.noButton.Location = new System.Drawing.Point(40, 249);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(75, 23);
            this.noButton.TabIndex = 6;
            this.noButton.Text = "No";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Visible = false;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(403, 361);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.p2Score);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.p1Score);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Square Chaser";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label p1Score;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label p2Score;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button noButton;
    }
}

