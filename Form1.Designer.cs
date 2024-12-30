namespace ResistorsWithUI
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
            this.precision = new System.Windows.Forms.TextBox();
            this.go = new System.Windows.Forms.Button();
            this.precisionLabel = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.target = new System.Windows.Forms.TextBox();
            this.targetLabel = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // precision
            // 
            this.precision.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.precision.Location = new System.Drawing.Point(12, 382);
            this.precision.Name = "precision";
            this.precision.Size = new System.Drawing.Size(458, 22);
            this.precision.TabIndex = 0;
            this.precision.TextChanged += new System.EventHandler(this.precision_TextChanged);
            // 
            // go
            // 
            this.go.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.go.Location = new System.Drawing.Point(12, 410);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(458, 25);
            this.go.TabIndex = 1;
            this.go.Text = "Go";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // precisionLabel
            // 
            this.precisionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.precisionLabel.AutoSize = true;
            this.precisionLabel.Location = new System.Drawing.Point(12, 363);
            this.precisionLabel.Name = "precisionLabel";
            this.precisionLabel.Size = new System.Drawing.Size(63, 16);
            this.precisionLabel.TabIndex = 2;
            this.precisionLabel.Text = "Precision";
            // 
            // add
            // 
            this.add.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add.Location = new System.Drawing.Point(12, 291);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(458, 25);
            this.add.TabIndex = 3;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // target
            // 
            this.target.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.target.Location = new System.Drawing.Point(12, 338);
            this.target.Name = "target";
            this.target.Size = new System.Drawing.Size(458, 22);
            this.target.TabIndex = 4;
            this.target.TextChanged += new System.EventHandler(this.target_TextChanged);
            // 
            // targetLabel
            // 
            this.targetLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.targetLabel.AutoSize = true;
            this.targetLabel.Location = new System.Drawing.Point(12, 319);
            this.targetLabel.Name = "targetLabel";
            this.targetLabel.Size = new System.Drawing.Size(47, 16);
            this.targetLabel.TabIndex = 5;
            this.targetLabel.Text = "Target";
            // 
            // result
            // 
            this.result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(9, 448);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(143, 16);
            this.result.TabIndex = 6;
            this.result.Text = "Result will appear here";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 478);
            this.Controls.Add(this.result);
            this.Controls.Add(this.targetLabel);
            this.Controls.Add(this.target);
            this.Controls.Add(this.add);
            this.Controls.Add(this.precisionLabel);
            this.Controls.Add(this.go);
            this.Controls.Add(this.precision);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Optimal Resistor Combination";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox precision;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.Label precisionLabel;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox target;
        private System.Windows.Forms.Label targetLabel;
        private System.Windows.Forms.Label result;
    }
}

