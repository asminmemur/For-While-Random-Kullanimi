namespace for_while_random
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
            this.btn_for = new System.Windows.Forms.Button();
            this.lstbox_for = new System.Windows.Forms.ListBox();
            this.lstbox_while = new System.Windows.Forms.ListBox();
            this.btn_while = new System.Windows.Forms.Button();
            this.lstbox_random = new System.Windows.Forms.ListBox();
            this.btn_random = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_for
            // 
            this.btn_for.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_for.Location = new System.Drawing.Point(12, 54);
            this.btn_for.Name = "btn_for";
            this.btn_for.Size = new System.Drawing.Size(87, 47);
            this.btn_for.TabIndex = 0;
            this.btn_for.Text = "FOR DÖNGÜSÜ";
            this.btn_for.UseVisualStyleBackColor = true;
            this.btn_for.Click += new System.EventHandler(this.btn_for_Click);
            // 
            // lstbox_for
            // 
            this.lstbox_for.FormattingEnabled = true;
            this.lstbox_for.Location = new System.Drawing.Point(105, 54);
            this.lstbox_for.Name = "lstbox_for";
            this.lstbox_for.Size = new System.Drawing.Size(120, 238);
            this.lstbox_for.TabIndex = 3;
            // 
            // lstbox_while
            // 
            this.lstbox_while.FormattingEnabled = true;
            this.lstbox_while.Location = new System.Drawing.Point(375, 54);
            this.lstbox_while.Name = "lstbox_while";
            this.lstbox_while.Size = new System.Drawing.Size(120, 238);
            this.lstbox_while.TabIndex = 5;
            // 
            // btn_while
            // 
            this.btn_while.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_while.Location = new System.Drawing.Point(282, 54);
            this.btn_while.Name = "btn_while";
            this.btn_while.Size = new System.Drawing.Size(87, 47);
            this.btn_while.TabIndex = 4;
            this.btn_while.Text = "WHILE DÖNGÜSÜ";
            this.btn_while.UseVisualStyleBackColor = true;
            this.btn_while.Click += new System.EventHandler(this.btn_while_Click);
            // 
            // lstbox_random
            // 
            this.lstbox_random.FormattingEnabled = true;
            this.lstbox_random.Location = new System.Drawing.Point(653, 54);
            this.lstbox_random.Name = "lstbox_random";
            this.lstbox_random.Size = new System.Drawing.Size(120, 238);
            this.lstbox_random.TabIndex = 7;
            // 
            // btn_random
            // 
            this.btn_random.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_random.Location = new System.Drawing.Point(560, 54);
            this.btn_random.Name = "btn_random";
            this.btn_random.Size = new System.Drawing.Size(87, 47);
            this.btn_random.TabIndex = 6;
            this.btn_random.Text = "RANDOM KÜTÜP.";
            this.btn_random.UseVisualStyleBackColor = true;
            this.btn_random.Click += new System.EventHandler(this.btn_random_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstbox_random);
            this.Controls.Add(this.btn_random);
            this.Controls.Add(this.lstbox_while);
            this.Controls.Add(this.btn_while);
            this.Controls.Add(this.lstbox_for);
            this.Controls.Add(this.btn_for);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_for;
        private System.Windows.Forms.ListBox lstbox_for;
        private System.Windows.Forms.ListBox lstbox_while;
        private System.Windows.Forms.Button btn_while;
        private System.Windows.Forms.ListBox lstbox_random;
        private System.Windows.Forms.Button btn_random;
    }
}

