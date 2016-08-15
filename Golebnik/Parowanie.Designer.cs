namespace Golebnik
{
    partial class Parowanie
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
            this.Button_Golebnik_Form = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_Golebnik_Form
            // 
            this.Button_Golebnik_Form.Location = new System.Drawing.Point(432, 159);
            this.Button_Golebnik_Form.Name = "Button_Golebnik_Form";
            this.Button_Golebnik_Form.Size = new System.Drawing.Size(75, 23);
            this.Button_Golebnik_Form.TabIndex = 0;
            this.Button_Golebnik_Form.Text = "Gołebnik";
            this.Button_Golebnik_Form.UseVisualStyleBackColor = true;
            this.Button_Golebnik_Form.Click += new System.EventHandler(this.Button_Golebnik_Form_Click);
            // 
            // Parowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 347);
            this.Controls.Add(this.Button_Golebnik_Form);
            this.Name = "Parowanie";
            this.Text = "Parowanie";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_Golebnik_Form;
    }
}