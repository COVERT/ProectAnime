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
            this.buttonPocupka = new System.Windows.Forms.Button();
            this.buttonProvader = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAgent
            // 
            this.buttonAgent.Location = new System.Drawing.Point(124, 69);
            this.buttonAgent.Name = "buttonAgent";
            this.buttonAgent.Size = new System.Drawing.Size(167, 30);
            this.buttonAgent.TabIndex = 0;
            this.buttonAgent.Text = "Менеджер";
            this.buttonAgent.UseVisualStyleBackColor = true;
            // 
            // buttonClient
            // 
            this.buttonClient.Location = new System.Drawing.Point(124, 114);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(167, 30);
            this.buttonClient.TabIndex = 1;
            this.buttonClient.Text = "Клиент";
            this.buttonClient.UseVisualStyleBackColor = true;
            // 
            // buttonAssortiment
            // 
            this.buttonAssortiment.Location = new System.Drawing.Point(124, 161);
            this.buttonAssortiment.Name = "buttonAssortiment";
            this.buttonAssortiment.Size = new System.Drawing.Size(167, 30);
            this.buttonAssortiment.TabIndex = 2;
            this.buttonAssortiment.Text = "ассортимент";
            this.buttonAssortiment.UseVisualStyleBackColor = true;
            // 
            // buttonPocupka
            // 
            this.buttonPocupka.Location = new System.Drawing.Point(124, 211);
            this.buttonPocupka.Name = "buttonPocupka";
            this.buttonPocupka.Size = new System.Drawing.Size(167, 30);
            this.buttonPocupka.TabIndex = 3;
            this.buttonPocupka.Text = "покупка";
            this.buttonPocupka.UseVisualStyleBackColor = true;
            // 
            // buttonProvader
            // 
            this.buttonProvader.Location = new System.Drawing.Point(124, 260);
            this.buttonProvader.Name = "buttonProvader";
            this.buttonProvader.Size = new System.Drawing.Size(167, 30);
            this.buttonProvader.TabIndex = 4;
            this.buttonProvader.Text = "Поставщик";
            this.buttonProvader.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 450);
            this.Controls.Add(this.buttonProvader);
            this.Controls.Add(this.buttonPocupka);
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
        private System.Windows.Forms.Button buttonPocupka;
        private System.Windows.Forms.Button buttonProvader;
    }
}

