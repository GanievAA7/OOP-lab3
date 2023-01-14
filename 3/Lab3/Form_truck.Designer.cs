namespace Lab3
{
    partial class Form_truck
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
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.truck_y = new System.Windows.Forms.TextBox();
            this.truck_x = new System.Windows.Forms.TextBox();
            this.BtnDraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(27, 50);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 25);
            this.label17.TabIndex = 55;
            this.label17.Text = "Y:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(25, 12);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 25);
            this.label18.TabIndex = 54;
            this.label18.Text = "X:";
            // 
            // truck_y
            // 
            this.truck_y.Location = new System.Drawing.Point(64, 50);
            this.truck_y.Name = "truck_y";
            this.truck_y.Size = new System.Drawing.Size(175, 22);
            this.truck_y.TabIndex = 53;
            // 
            // truck_x
            // 
            this.truck_x.Location = new System.Drawing.Point(64, 12);
            this.truck_x.Name = "truck_x";
            this.truck_x.Size = new System.Drawing.Size(175, 22);
            this.truck_x.TabIndex = 52;
            // 
            // BtnDraw
            // 
            this.BtnDraw.Location = new System.Drawing.Point(25, 91);
            this.BtnDraw.Name = "BtnDraw";
            this.BtnDraw.Size = new System.Drawing.Size(214, 37);
            this.BtnDraw.TabIndex = 51;
            this.BtnDraw.Text = "создать";
            this.BtnDraw.UseVisualStyleBackColor = true;
            this.BtnDraw.Click += new System.EventHandler(this.BtnDraw_Click);
            // 
            // Form_truck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 168);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.truck_y);
            this.Controls.Add(this.truck_x);
            this.Controls.Add(this.BtnDraw);
            this.Name = "Form_truck";
            this.Text = "Form_truck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox truck_y;
        private System.Windows.Forms.TextBox truck_x;
        private System.Windows.Forms.Button BtnDraw;
    }
}