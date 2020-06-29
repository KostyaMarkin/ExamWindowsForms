namespace Экзамен.Приветствие
{
    partial class Приветствие
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
            this.components = new System.ComponentModel.Container();
            this.txtEnterName = new System.Windows.Forms.TextBox();
            this.lbnEnterName = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.toolTipEnterName = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txtEnterName
            // 
            this.txtEnterName.Location = new System.Drawing.Point(12, 70);
            this.txtEnterName.Name = "txtEnterName";
            this.txtEnterName.Size = new System.Drawing.Size(119, 20);
            this.txtEnterName.TabIndex = 0;
            this.toolTipEnterName.SetToolTip(this.txtEnterName, "Введите ваше имя");
            // 
            // lbnEnterName
            // 
            this.lbnEnterName.AutoSize = true;
            this.lbnEnterName.Location = new System.Drawing.Point(23, 27);
            this.lbnEnterName.Name = "lbnEnterName";
            this.lbnEnterName.Size = new System.Drawing.Size(101, 13);
            this.lbnEnterName.TabIndex = 1;
            this.lbnEnterName.Text = "Введите ваше имя";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(29, 96);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Ввод";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // Приветствие
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(148, 129);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lbnEnterName);
            this.Controls.Add(this.txtEnterName);
            this.Name = "Приветствие";
            this.Text = "Приветствие";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEnterName;
        private System.Windows.Forms.Label lbnEnterName;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.ToolTip toolTipEnterName;
    }
}

