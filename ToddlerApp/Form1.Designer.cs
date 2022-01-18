namespace ToddlerApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPurple = new System.Windows.Forms.Button();
            this.btnPink = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnBrown = new System.Windows.Forms.Button();
            this.btnOrange = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnBlack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(12, 8);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(877, 48);
            this.txtInput.TabIndex = 1;
            this.txtInput.Text = "Anna";
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlay.BackColor = System.Drawing.Color.LawnGreen;
            this.btnPlay.Font = new System.Drawing.Font("Webdings", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnPlay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPlay.Location = new System.Drawing.Point(895, 12);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 45);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "4";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPurple
            // 
            this.btnPurple.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPurple.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurple.ForeColor = System.Drawing.Color.White;
            this.btnPurple.Location = new System.Drawing.Point(12, 291);
            this.btnPurple.Name = "btnPurple";
            this.btnPurple.Size = new System.Drawing.Size(120, 50);
            this.btnPurple.TabIndex = 4;
            this.btnPurple.Text = "purple";
            this.btnPurple.UseVisualStyleBackColor = true;
            this.btnPurple.Click += new System.EventHandler(this.btnPurple_Click);
            // 
            // btnPink
            // 
            this.btnPink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPink.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPink.ForeColor = System.Drawing.Color.White;
            this.btnPink.Location = new System.Drawing.Point(138, 291);
            this.btnPink.Name = "btnPink";
            this.btnPink.Size = new System.Drawing.Size(120, 50);
            this.btnPink.TabIndex = 5;
            this.btnPink.Text = "pink";
            this.btnPink.UseVisualStyleBackColor = true;
            this.btnPink.Click += new System.EventHandler(this.btnPink_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBlue.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlue.ForeColor = System.Drawing.Color.White;
            this.btnBlue.Location = new System.Drawing.Point(264, 291);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(120, 50);
            this.btnBlue.TabIndex = 6;
            this.btnBlue.Text = "blue";
            this.btnBlue.UseVisualStyleBackColor = true;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(12, 109);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(598, 106);
            this.lblDisplay.TabIndex = 7;
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBrown
            // 
            this.btnBrown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBrown.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrown.ForeColor = System.Drawing.Color.White;
            this.btnBrown.Location = new System.Drawing.Point(642, 291);
            this.btnBrown.Name = "btnBrown";
            this.btnBrown.Size = new System.Drawing.Size(120, 50);
            this.btnBrown.TabIndex = 10;
            this.btnBrown.Text = "brown";
            this.btnBrown.UseVisualStyleBackColor = true;
            this.btnBrown.Click += new System.EventHandler(this.btnBrown_Click);
            // 
            // btnOrange
            // 
            this.btnOrange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOrange.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrange.ForeColor = System.Drawing.Color.White;
            this.btnOrange.Location = new System.Drawing.Point(516, 291);
            this.btnOrange.Name = "btnOrange";
            this.btnOrange.Size = new System.Drawing.Size(120, 50);
            this.btnOrange.TabIndex = 9;
            this.btnOrange.Text = "orange";
            this.btnOrange.UseVisualStyleBackColor = true;
            this.btnOrange.Click += new System.EventHandler(this.btnOrange_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGreen.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGreen.ForeColor = System.Drawing.Color.White;
            this.btnGreen.Location = new System.Drawing.Point(390, 291);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(120, 50);
            this.btnGreen.TabIndex = 8;
            this.btnGreen.Text = "green";
            this.btnGreen.UseVisualStyleBackColor = true;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnBlack
            // 
            this.btnBlack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBlack.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlack.ForeColor = System.Drawing.Color.White;
            this.btnBlack.Location = new System.Drawing.Point(768, 291);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(120, 50);
            this.btnBlack.TabIndex = 11;
            this.btnBlack.Text = "black";
            this.btnBlack.UseVisualStyleBackColor = true;
            this.btnBlack.Click += new System.EventHandler(this.btnBlack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(982, 353);
            this.Controls.Add(this.btnBlack);
            this.Controls.Add(this.btnBrown);
            this.Controls.Add(this.btnOrange);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnPink);
            this.Controls.Add(this.btnPurple);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form1";
            this.Text = "Anna\'s app";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPurple;
        private System.Windows.Forms.Button btnPink;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnBrown;
        private System.Windows.Forms.Button btnOrange;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnBlack;
    }
}

