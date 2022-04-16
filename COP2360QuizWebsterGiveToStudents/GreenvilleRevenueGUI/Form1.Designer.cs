namespace GreenvilleRevenueGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.msglabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.CapitalAnswertextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numcorrectlabel = new System.Windows.Forms.Label();
            this.Instructionslabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "The Capital is: ";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(9, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 55);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(145, 83);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 26);
            this.label5.TabIndex = 16;
            this.label5.Text = "What is the Capital of: ";
            // 
            // msglabel
            // 
            this.msglabel.AutoSize = true;
            this.msglabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.msglabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.msglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msglabel.Location = new System.Drawing.Point(149, 149);
            this.msglabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.msglabel.Name = "msglabel";
            this.msglabel.Size = new System.Drawing.Size(122, 22);
            this.msglabel.TabIndex = 17;
            this.msglabel.Text = "Found N Words";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Dr. Webster\'s COP2360 STATE CAPITAL GAME";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 149);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 29);
            this.button2.TabIndex = 22;
            this.button2.Text = "Cheat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // CapitalAnswertextBox
            // 
            this.CapitalAnswertextBox.Location = new System.Drawing.Point(361, 118);
            this.CapitalAnswertextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CapitalAnswertextBox.Name = "CapitalAnswertextBox";
            this.CapitalAnswertextBox.Size = new System.Drawing.Size(177, 20);
            this.CapitalAnswertextBox.TabIndex = 23;
            this.CapitalAnswertextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(363, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 26);
            this.label3.TabIndex = 24;
            this.label3.Text = "Massachusetts";
            // 
            // numcorrectlabel
            // 
            this.numcorrectlabel.AutoSize = true;
            this.numcorrectlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numcorrectlabel.Location = new System.Drawing.Point(175, 45);
            this.numcorrectlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numcorrectlabel.Name = "numcorrectlabel";
            this.numcorrectlabel.Size = new System.Drawing.Size(297, 18);
            this.numcorrectlabel.TabIndex = 25;
            this.numcorrectlabel.Text = "Number Correct: 0 Out of 0 Total Questions";
            // 
            // Instructionslabel
            // 
            this.Instructionslabel.AutoSize = true;
            this.Instructionslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instructionslabel.Location = new System.Drawing.Point(18, 192);
            this.Instructionslabel.Name = "Instructionslabel";
            this.Instructionslabel.Size = new System.Drawing.Size(72, 15);
            this.Instructionslabel.TabIndex = 26;
            this.Instructionslabel.Text = "Instructions ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 244);
            this.Controls.Add(this.Instructionslabel);
            this.Controls.Add(this.numcorrectlabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CapitalAnswertextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msglabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "State Capital Game!!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label msglabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox CapitalAnswertextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label numcorrectlabel;
        private System.Windows.Forms.Label Instructionslabel;
    }
}

