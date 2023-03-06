namespace winArray
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.intersectionLabel = new System.Windows.Forms.Label();
            this.differenceLabel = new System.Windows.Forms.Label();
            this.sDifferenceLabel = new System.Windows.Forms.Label();
            this.unionLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(298, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 20);
            this.textBox1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(298, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(162, 20);
            this.textBox2.TabIndex = 0;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(267, 312);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(231, 56);
            this.calcButton.TabIndex = 2;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "B";
            // 
            // intersectionLabel
            // 
            this.intersectionLabel.AutoSize = true;
            this.intersectionLabel.Location = new System.Drawing.Point(295, 177);
            this.intersectionLabel.Name = "intersectionLabel";
            this.intersectionLabel.Size = new System.Drawing.Size(65, 13);
            this.intersectionLabel.TabIndex = 3;
            this.intersectionLabel.Text = "Intersection:";
            // 
            // differenceLabel
            // 
            this.differenceLabel.AutoSize = true;
            this.differenceLabel.Location = new System.Drawing.Point(295, 204);
            this.differenceLabel.Name = "differenceLabel";
            this.differenceLabel.Size = new System.Drawing.Size(59, 13);
            this.differenceLabel.TabIndex = 3;
            this.differenceLabel.Text = "Difference:";
            // 
            // sDifferenceLabel
            // 
            this.sDifferenceLabel.AutoSize = true;
            this.sDifferenceLabel.Location = new System.Drawing.Point(295, 232);
            this.sDifferenceLabel.Name = "sDifferenceLabel";
            this.sDifferenceLabel.Size = new System.Drawing.Size(118, 13);
            this.sDifferenceLabel.TabIndex = 3;
            this.sDifferenceLabel.Text = "Symmetrical Difference:";
            // 
            // unionLabel
            // 
            this.unionLabel.AutoSize = true;
            this.unionLabel.Location = new System.Drawing.Point(295, 259);
            this.unionLabel.Name = "unionLabel";
            this.unionLabel.Size = new System.Drawing.Size(38, 13);
            this.unionLabel.TabIndex = 3;
            this.unionLabel.Text = "Union:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(323, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "Array";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(758, 430);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.unionLabel);
            this.Controls.Add(this.sDifferenceLabel);
            this.Controls.Add(this.differenceLabel);
            this.Controls.Add(this.intersectionLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "winArray";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label intersectionLabel;
        private System.Windows.Forms.Label differenceLabel;
        private System.Windows.Forms.Label sDifferenceLabel;
        private System.Windows.Forms.Label unionLabel;
        private System.Windows.Forms.Label label3;
    }
}

