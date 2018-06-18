namespace KitBox
{
    partial class LaunchScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaunchScreen));
            this.new_order_button = new System.Windows.Forms.Button();
            this.storekeeper_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // new_order_button
            // 
            this.new_order_button.BackColor = System.Drawing.Color.Transparent;
            this.new_order_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.new_order_button.FlatAppearance.BorderSize = 0;
            this.new_order_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.new_order_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.new_order_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_order_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_order_button.ForeColor = System.Drawing.Color.White;
            this.new_order_button.Location = new System.Drawing.Point(333, 0);
            this.new_order_button.Name = "new_order_button";
            this.new_order_button.Size = new System.Drawing.Size(103, 37);
            this.new_order_button.TabIndex = 43;
            this.new_order_button.UseVisualStyleBackColor = false;
            this.new_order_button.Click += new System.EventHandler(this.new_order_button_Click);
            this.new_order_button.MouseEnter += new System.EventHandler(this.new_order_button_MouseEnter);
            // 
            // storekeeper_button
            // 
            this.storekeeper_button.BackColor = System.Drawing.Color.Transparent;
            this.storekeeper_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.storekeeper_button.FlatAppearance.BorderSize = 0;
            this.storekeeper_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.storekeeper_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.storekeeper_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.storekeeper_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storekeeper_button.ForeColor = System.Drawing.Color.White;
            this.storekeeper_button.Location = new System.Drawing.Point(938, 0);
            this.storekeeper_button.Name = "storekeeper_button";
            this.storekeeper_button.Size = new System.Drawing.Size(143, 37);
            this.storekeeper_button.TabIndex = 46;
            this.storekeeper_button.UseVisualStyleBackColor = false;
            this.storekeeper_button.Click += new System.EventHandler(this.storekeeper_button_Click);
            // 
            // LaunchScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.storekeeper_button);
            this.Controls.Add(this.new_order_button);
            this.Name = "LaunchScreen";
            this.Size = new System.Drawing.Size(1280, 800);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button new_order_button;
        private System.Windows.Forms.Button storekeeper_button;
    }
}
