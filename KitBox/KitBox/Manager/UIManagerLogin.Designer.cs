namespace KitBox
{
    partial class UIManagerLogin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.enter_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(754, 80);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '*';
            this.password_textbox.Size = new System.Drawing.Size(276, 20);
            this.password_textbox.TabIndex = 0;
            this.password_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_textbox_KeyDown);
            // 
            // enter_button
            // 
            this.enter_button.BackColor = System.Drawing.Color.Transparent;
            this.enter_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.enter_button.FlatAppearance.BorderSize = 0;
            this.enter_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.enter_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.enter_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enter_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_button.ForeColor = System.Drawing.Color.White;
            this.enter_button.Location = new System.Drawing.Point(1036, 80);
            this.enter_button.Name = "enter_button";
            this.enter_button.Size = new System.Drawing.Size(103, 22);
            this.enter_button.TabIndex = 44;
            this.enter_button.UseVisualStyleBackColor = false;
            this.enter_button.Click += new System.EventHandler(this.enter_button_Click);
            this.enter_button.MouseEnter += new System.EventHandler(this.enter_button_MouseEnter);
            // 
            // UIManagerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KitBox.Properties.Resources.storekeeper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.enter_button);
            this.Controls.Add(this.password_textbox);
            this.Name = "UIManagerLogin";
            this.Size = new System.Drawing.Size(1280, 800);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Button enter_button;
    }
}
