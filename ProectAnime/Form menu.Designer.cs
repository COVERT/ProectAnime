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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAgent
            // 
            this.buttonAgent.Location = new System.Drawing.Point(53, 129);
            this.buttonAgent.Name = "buttonAgent";
            this.buttonAgent.Size = new System.Drawing.Size(167, 30);
            this.buttonAgent.TabIndex = 0;
            this.buttonAgent.Text = "Преподаватель";
            this.buttonAgent.UseVisualStyleBackColor = true;
            this.buttonAgent.Click += new System.EventHandler(this.buttonAgent_Click);
            // 
            // buttonClient
            // 
            this.buttonClient.Location = new System.Drawing.Point(53, 165);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(167, 30);
            this.buttonClient.TabIndex = 1;
            this.buttonClient.Text = "Учиник";
            this.buttonClient.UseVisualStyleBackColor = true;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // buttonAssortiment
            // 
            this.buttonAssortiment.Location = new System.Drawing.Point(53, 201);
            this.buttonAssortiment.Name = "buttonAssortiment";
            this.buttonAssortiment.Size = new System.Drawing.Size(167, 30);
            this.buttonAssortiment.TabIndex = 2;
            this.buttonAssortiment.Text = "запись на крус";
            this.buttonAssortiment.UseVisualStyleBackColor = true;
            this.buttonAssortiment.Click += new System.EventHandler(this.buttonAssortiment_Click);
            // 
            // buttonProvader
            // 
            this.buttonProvader.Location = new System.Drawing.Point(53, 237);
            this.buttonProvader.Name = "buttonProvader";
            this.buttonProvader.Size = new System.Drawing.Size(167, 30);
            this.buttonProvader.TabIndex = 4;
            this.buttonProvader.Text = "контакты";
            this.buttonProvader.UseVisualStyleBackColor = true;
            this.buttonProvader.Click += new System.EventHandler(this.buttonProvader_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProectAnime.Properties.Resources.dfsfsdsdf;
            this.pictureBox1.Location = new System.Drawing.Point(78, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(270, 305);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonProvader);
            this.Controls.Add(this.buttonAssortiment);
            this.Controls.Add(this.buttonClient);
            this.Controls.Add(this.buttonAgent);
            this.Name = "Menu";
            this.Text = "Меню";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAgent;
        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.Button buttonAssortiment;
        private System.Windows.Forms.Button buttonProvader;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

