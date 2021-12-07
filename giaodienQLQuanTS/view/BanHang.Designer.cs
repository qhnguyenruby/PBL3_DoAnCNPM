namespace giaodienQLQuanTS
{
    partial class BanHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpBan = new System.Windows.Forms.FlowLayoutPanel();
            this.but_MuaVe = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flpBan);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 443);
            this.panel1.TabIndex = 3;
            // 
            // flpBan
            // 
            this.flpBan.AutoScroll = true;
            this.flpBan.Location = new System.Drawing.Point(3, 3);
            this.flpBan.Name = "flpBan";
            this.flpBan.Size = new System.Drawing.Size(481, 437);
            this.flpBan.TabIndex = 0;
            // 
            // but_MuaVe
            // 
            this.but_MuaVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.but_MuaVe.Location = new System.Drawing.Point(508, 15);
            this.but_MuaVe.Margin = new System.Windows.Forms.Padding(4);
            this.but_MuaVe.Name = "but_MuaVe";
            this.but_MuaVe.Size = new System.Drawing.Size(165, 143);
            this.but_MuaVe.TabIndex = 6;
            this.but_MuaVe.Text = "Mua về";
            this.but_MuaVe.UseVisualStyleBackColor = true;
            this.but_MuaVe.Click += new System.EventHandler(this.but_MuaVe_Click);
            // 
            // BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 465);
            this.Controls.Add(this.but_MuaVe);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BanHang";
            this.Text = "Bán Hàng";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button but_MuaVe;
        private System.Windows.Forms.FlowLayoutPanel flpBan;
    }
}