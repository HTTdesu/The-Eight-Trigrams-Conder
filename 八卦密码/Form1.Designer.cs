using System;

namespace 八卦密码
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rtboxText = new System.Windows.Forms.RichTextBox();
            this.rtboxCipher = new System.Windows.Forms.RichTextBox();
            this.btnEncode = new System.Windows.Forms.Button();
            this.btnDecode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // rtboxText
            // 
            this.rtboxText.Location = new System.Drawing.Point(10, 10);
            this.rtboxText.Name = "rtboxText";
            this.rtboxText.Size = new System.Drawing.Size(200, 390);
            this.rtboxText.TabIndex = 2;
            this.rtboxText.Text = "";
            // 
            // rtboxCipher
            // 
            this.rtboxCipher.Location = new System.Drawing.Point(373, 10);
            this.rtboxCipher.Name = "rtboxCipher";
            this.rtboxCipher.Size = new System.Drawing.Size(200, 390);
            this.rtboxCipher.TabIndex = 3;
            this.rtboxCipher.Text = "";
            // 
            // btnEncode
            // 
            this.btnEncode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEncode.Location = new System.Drawing.Point(240, 100);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(100, 60);
            this.btnEncode.TabIndex = 4;
            this.btnEncode.Text = "加密";
            this.btnEncode.UseVisualStyleBackColor = true;
            // 
            // btnDecode
            // 
            this.btnDecode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDecode.Location = new System.Drawing.Point(240, 240);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(100, 60);
            this.btnDecode.TabIndex = 5;
            this.btnDecode.Text = "解密";
            this.btnDecode.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.btnEncode);
            this.Controls.Add(this.rtboxCipher);
            this.Controls.Add(this.rtboxText);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "八卦密码";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox rtboxText;
        private System.Windows.Forms.RichTextBox rtboxCipher;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.Button btnDecode;
    }
}

