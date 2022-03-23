
namespace GoodsCatalog_M_20
{
    partial class Form1
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
            this.registrationMainButton = new System.Windows.Forms.Button();
            this.adminButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registrationMainButton
            // 
            this.registrationMainButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.registrationMainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationMainButton.Location = new System.Drawing.Point(273, 25);
            this.registrationMainButton.Name = "registrationMainButton";
            this.registrationMainButton.Size = new System.Drawing.Size(223, 40);
            this.registrationMainButton.TabIndex = 0;
            this.registrationMainButton.Text = "REGISTRATION";
            this.registrationMainButton.UseVisualStyleBackColor = false;
            // 
            // adminButton
            // 
            this.adminButton.Location = new System.Drawing.Point(12, 393);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(156, 36);
            this.adminButton.TabIndex = 1;
            this.adminButton.Text = "Admin initialize";
            this.adminButton.UseVisualStyleBackColor = true;
            this.adminButton.Visible = false;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.registrationMainButton);
            this.Name = "Form1";
            this.Text = "Автоматизированная система управления каталогом товаров";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button registrationMainButton;
        private System.Windows.Forms.Button adminButton;
    }
}

