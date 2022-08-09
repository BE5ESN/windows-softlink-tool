
namespace SoftLinkTool
{
    partial class softLink
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_target = new System.Windows.Forms.TextBox();
            this.button_target = new System.Windows.Forms.Button();
            this.textBox_dest = new System.Windows.Forms.TextBox();
            this.button_dest = new System.Windows.Forms.Button();
            this.button_create = new System.Windows.Forms.Button();
            this.textBox_linkName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_target
            // 
            this.textBox_target.Location = new System.Drawing.Point(12, 12);
            this.textBox_target.Name = "textBox_target";
            this.textBox_target.Size = new System.Drawing.Size(205, 21);
            this.textBox_target.TabIndex = 0;
            // 
            // button_target
            // 
            this.button_target.Location = new System.Drawing.Point(223, 12);
            this.button_target.Name = "button_target";
            this.button_target.Size = new System.Drawing.Size(75, 21);
            this.button_target.TabIndex = 1;
            this.button_target.Text = "Source";
            this.button_target.UseVisualStyleBackColor = true;
            this.button_target.Click += new System.EventHandler(this.button_target_Click);
            // 
            // textBox_dest
            // 
            this.textBox_dest.Location = new System.Drawing.Point(12, 43);
            this.textBox_dest.Name = "textBox_dest";
            this.textBox_dest.Size = new System.Drawing.Size(124, 21);
            this.textBox_dest.TabIndex = 2;
            // 
            // button_dest
            // 
            this.button_dest.Location = new System.Drawing.Point(223, 43);
            this.button_dest.Name = "button_dest";
            this.button_dest.Size = new System.Drawing.Size(75, 21);
            this.button_dest.TabIndex = 3;
            this.button_dest.Text = "Link to";
            this.button_dest.UseVisualStyleBackColor = true;
            this.button_dest.Click += new System.EventHandler(this.button_dest_Click);
            // 
            // button_create
            // 
            this.button_create.Location = new System.Drawing.Point(304, 10);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(75, 54);
            this.button_create.TabIndex = 4;
            this.button_create.Text = "Generate";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // textBox_linkName
            // 
            this.textBox_linkName.Location = new System.Drawing.Point(142, 43);
            this.textBox_linkName.Name = "textBox_linkName";
            this.textBox_linkName.Size = new System.Drawing.Size(75, 21);
            this.textBox_linkName.TabIndex = 5;
            this.textBox_linkName.Text = "Folder";
            // 
            // softLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 73);
            this.Controls.Add(this.textBox_linkName);
            this.Controls.Add(this.button_create);
            this.Controls.Add(this.button_dest);
            this.Controls.Add(this.textBox_dest);
            this.Controls.Add(this.button_target);
            this.Controls.Add(this.textBox_target);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(404, 112);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(404, 112);
            this.Name = "softLink";
            this.ShowIcon = false;
            this.Text = "windows soft link tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_target;
        private System.Windows.Forms.Button button_target;
        private System.Windows.Forms.TextBox textBox_dest;
        private System.Windows.Forms.Button button_dest;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.TextBox textBox_linkName;
    }
}

