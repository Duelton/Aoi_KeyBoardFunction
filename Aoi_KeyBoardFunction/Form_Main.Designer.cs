namespace Aoi_KeyBoardFunction
{
    partial class Form_Main
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
            this.TabPl_Format = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_Setting = new System.Windows.Forms.Button();
            this.Btn_Enable = new System.Windows.Forms.Button();
            this.TabPl_Format.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabPl_Format
            // 
            this.TabPl_Format.ColumnCount = 1;
            this.TabPl_Format.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TabPl_Format.Controls.Add(this.Btn_Setting, 0, 1);
            this.TabPl_Format.Controls.Add(this.Btn_Enable, 0, 0);
            this.TabPl_Format.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabPl_Format.Location = new System.Drawing.Point(0, 0);
            this.TabPl_Format.Name = "TabPl_Format";
            this.TabPl_Format.RowCount = 2;
            this.TabPl_Format.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TabPl_Format.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TabPl_Format.Size = new System.Drawing.Size(207, 189);
            this.TabPl_Format.TabIndex = 0;
            // 
            // Btn_Setting
            // 
            this.Btn_Setting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Setting.Location = new System.Drawing.Point(66, 127);
            this.Btn_Setting.Name = "Btn_Setting";
            this.Btn_Setting.Size = new System.Drawing.Size(75, 29);
            this.Btn_Setting.TabIndex = 1;
            this.Btn_Setting.Text = "Setting";
            this.Btn_Setting.UseVisualStyleBackColor = true;
            this.Btn_Setting.Click += new System.EventHandler(this.Btn_Setting_Click);
            // 
            // Btn_Enable
            // 
            this.Btn_Enable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Enable.Location = new System.Drawing.Point(66, 32);
            this.Btn_Enable.Name = "Btn_Enable";
            this.Btn_Enable.Size = new System.Drawing.Size(75, 29);
            this.Btn_Enable.TabIndex = 0;
            this.Btn_Enable.Text = "Enabled";
            this.Btn_Enable.UseVisualStyleBackColor = true;
            this.Btn_Enable.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Btn_Enable_MouseClick);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 189);
            this.Controls.Add(this.TabPl_Format);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.Text = "Aoi_KB";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.TabPl_Format.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TabPl_Format;
        private System.Windows.Forms.Button Btn_Setting;
        private System.Windows.Forms.Button Btn_Enable;
    }
}