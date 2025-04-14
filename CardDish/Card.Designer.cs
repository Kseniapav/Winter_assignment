namespace CardDish
{
    partial class Card
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.picDishImage = new System.Windows.Forms.PictureBox();
            this.lblDishName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDishImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picDishImage
            // 
            this.picDishImage.Location = new System.Drawing.Point(3, 12);
            this.picDishImage.Name = "picDishImage";
            this.picDishImage.Size = new System.Drawing.Size(206, 195);
            this.picDishImage.TabIndex = 0;
            this.picDishImage.TabStop = false;
            // 
            // lblDishName
            // 
            this.lblDishName.AutoSize = true;
            this.lblDishName.Location = new System.Drawing.Point(13, 220);
            this.lblDishName.Name = "lblDishName";
            this.lblDishName.Size = new System.Drawing.Size(35, 13);
            this.lblDishName.TabIndex = 1;
            this.lblDishName.Text = "label1";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(154, 257);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(35, 13);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "label1";
            // 
            // Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDishName);
            this.Controls.Add(this.picDishImage);
            this.Name = "Card";
            this.Size = new System.Drawing.Size(212, 286);
            this.Load += new System.EventHandler(this.CardDish_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDishImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDishImage;
        private System.Windows.Forms.Label lblDishName;
        private System.Windows.Forms.Label lblPrice;
    }
}
