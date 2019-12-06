namespace WebHelper
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textBoxURI = new System.Windows.Forms.TextBox();
            this.labelURI = new System.Windows.Forms.Label();
            this.labelHeaders = new System.Windows.Forms.Label();
            this.textBoxHeaders = new System.Windows.Forms.TextBox();
            this.buttonURI = new System.Windows.Forms.Button();
            this.buttonHeaders = new System.Windows.Forms.Button();
            this.buttonGetFunction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxURI
            // 
            this.textBoxURI.Location = new System.Drawing.Point(76, 12);
            this.textBoxURI.Name = "textBoxURI";
            this.textBoxURI.Size = new System.Drawing.Size(600, 22);
            this.textBoxURI.TabIndex = 0;
            // 
            // labelURI
            // 
            this.labelURI.AutoSize = true;
            this.labelURI.Location = new System.Drawing.Point(14, 16);
            this.labelURI.Name = "labelURI";
            this.labelURI.Size = new System.Drawing.Size(28, 14);
            this.labelURI.TabIndex = 1;
            this.labelURI.Text = "URI";
            // 
            // labelHeaders
            // 
            this.labelHeaders.AutoSize = true;
            this.labelHeaders.Location = new System.Drawing.Point(14, 44);
            this.labelHeaders.Name = "labelHeaders";
            this.labelHeaders.Size = new System.Drawing.Size(56, 14);
            this.labelHeaders.TabIndex = 3;
            this.labelHeaders.Text = "Headers";
            // 
            // textBoxHeaders
            // 
            this.textBoxHeaders.Location = new System.Drawing.Point(76, 40);
            this.textBoxHeaders.Multiline = true;
            this.textBoxHeaders.Name = "textBoxHeaders";
            this.textBoxHeaders.Size = new System.Drawing.Size(600, 180);
            this.textBoxHeaders.TabIndex = 2;
            // 
            // buttonURI
            // 
            this.buttonURI.Location = new System.Drawing.Point(696, 12);
            this.buttonURI.Name = "buttonURI";
            this.buttonURI.Size = new System.Drawing.Size(103, 22);
            this.buttonURI.TabIndex = 4;
            this.buttonURI.Text = "Set URI";
            this.buttonURI.UseVisualStyleBackColor = true;
            this.buttonURI.Click += new System.EventHandler(this.buttonURI_Click);
            // 
            // buttonHeaders
            // 
            this.buttonHeaders.Location = new System.Drawing.Point(696, 40);
            this.buttonHeaders.Name = "buttonHeaders";
            this.buttonHeaders.Size = new System.Drawing.Size(103, 22);
            this.buttonHeaders.TabIndex = 5;
            this.buttonHeaders.Text = "Set Headers";
            this.buttonHeaders.UseVisualStyleBackColor = true;
            this.buttonHeaders.Click += new System.EventHandler(this.buttonHeaders_Click);
            // 
            // buttonGetFunction
            // 
            this.buttonGetFunction.Location = new System.Drawing.Point(696, 68);
            this.buttonGetFunction.Name = "buttonGetFunction";
            this.buttonGetFunction.Size = new System.Drawing.Size(103, 22);
            this.buttonGetFunction.TabIndex = 6;
            this.buttonGetFunction.Text = "Get Function";
            this.buttonGetFunction.UseVisualStyleBackColor = true;
            this.buttonGetFunction.Click += new System.EventHandler(this.buttonGetFunction_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 234);
            this.Controls.Add(this.buttonGetFunction);
            this.Controls.Add(this.buttonHeaders);
            this.Controls.Add(this.buttonURI);
            this.Controls.Add(this.labelHeaders);
            this.Controls.Add(this.textBoxHeaders);
            this.Controls.Add(this.labelURI);
            this.Controls.Add(this.textBoxURI);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "NetWebHelper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxURI;
        private System.Windows.Forms.Label labelURI;
        private System.Windows.Forms.Label labelHeaders;
        private System.Windows.Forms.TextBox textBoxHeaders;
        private System.Windows.Forms.Button buttonURI;
        private System.Windows.Forms.Button buttonHeaders;
        private System.Windows.Forms.Button buttonGetFunction;
    }
}

