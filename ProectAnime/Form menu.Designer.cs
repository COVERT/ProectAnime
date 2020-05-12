namespace ProectAnime
{
    partial class Menu
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
            this.buttonAgent = new System.Windows.Forms.Button();
            this.buttonClient = new System.Windows.Forms.Button();
            this.buttonAssortiment = new System.Windows.Forms.Button();
            this.buttonProvader = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAgent
            // 
            this.buttonAgent.Location = new System.Drawing.Point(58, 58);
            this.buttonAgent.Name = "buttonAgent";
            this.buttonAgent.Size = new System.Drawing.Size(167, 30);
            this.buttonAgent.TabIndex = 0;
            this.buttonAgent.Text = "Менеджер";
            this.buttonAgent.UseVisualStyleBackColor = true;
            this.buttonAgent.Click += new System.EventHandler(this.buttonAgent_Click);
            // 
            // buttonClient
            // 
            this.buttonClient.Location = new System.Drawing.Point(58, 94);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(167, 30);
            this.buttonClient.TabIndex = 1;
            this.buttonClient.Text = "Клиент";
            this.buttonClient.UseVisualStyleBackColor = true;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // buttonAssortiment
            // 
            this.buttonAssortiment.Location = new System.Drawing.Point(58, 130);
            this.buttonAssortiment.Name = "buttonAssortiment";
            this.buttonAssortiment.Size = new System.Drawing.Size(167, 30);
            this.buttonAssortiment.TabIndex = 2;
            this.buttonAssortiment.Text = "сделка";
            this.buttonAssortiment.UseVisualStyleBackColor = true;
            this.buttonAssortiment.Click += new System.EventHandler(this.buttonAssortiment_Click);
            // 
            // buttonProvader
            // 
            this.buttonProvader.Location = new System.Drawing.Point(58, 166);
            this.buttonProvader.Name = "buttonProvader";
            this.buttonProvader.Size = new System.Drawing.Size(167, 30);
            this.buttonProvader.TabIndex = 4;
            this.buttonProvader.Text = "Поставщик";
            this.buttonProvader.UseVisualStyleBackColor = true;
            this.buttonProvader.Click += new System.EventHandler(this.buttonProvader_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 233);
            this.Controls.Add(this.buttonProvader);
            this.Controls.Add(this.buttonAssortiment);
            this.Controls.Add(this.buttonClient);
            this.Controls.Add(this.buttonAgent);
            this.Name = "Menu";
            this.Text = "Меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAgent;
        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.Button buttonAssortiment;
        private System.Windows.Forms.Button buttonProvader;
    }
}

