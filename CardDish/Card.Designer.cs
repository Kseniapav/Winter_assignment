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
            this.buttonAddToCart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDishImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picDishImage
            // 
            this.picDishImage.Location = new System.Drawing.Point(16, 15);
            this.picDishImage.Name = "picDishImage";
            this.picDishImage.Size = new System.Drawing.Size(315, 180);
            this.picDishImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDishImage.TabIndex = 0;
            this.picDishImage.TabStop = false;
            // 
            // lblDishName
            // 
            this.lblDishName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDishName.Location = new System.Drawing.Point(13, 223);
            this.lblDishName.Name = "lblDishName";
            this.lblDishName.Size = new System.Drawing.Size(318, 37);
            this.lblDishName.TabIndex = 1;
            this.lblDishName.Text = "Описание";
            this.lblDishName.UseMnemonic = false;
            this.lblDishName.Click += new System.EventHandler(this.lblDishName_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.Location = new System.Drawing.Point(13, 290);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(77, 16);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Стоимость";
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // buttonAddToCart
            // 
            this.buttonAddToCart.BackColor = System.Drawing.Color.White;
            this.buttonAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddToCart.Location = new System.Drawing.Point(274, 263);
            this.buttonAddToCart.Name = "buttonAddToCart";
            this.buttonAddToCart.Size = new System.Drawing.Size(110, 50);
            this.buttonAddToCart.TabIndex = 3;
            this.buttonAddToCart.Text = "Добавить в корзину";
            this.buttonAddToCart.UseVisualStyleBackColor = false;
            this.buttonAddToCart.Click += new System.EventHandler(this.buttonAddToCart_Click_1);
            // 
            // Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.buttonAddToCart);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDishName);
            this.Controls.Add(this.picDishImage);
            this.Name = "Card";
            this.Size = new System.Drawing.Size(397, 323);
            this.Load += new System.EventHandler(this.CardDish_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDishImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDishImage;
        private System.Windows.Forms.Button buttonAddToCart;
        public System.Windows.Forms.Label lblDishName;
        public System.Windows.Forms.Label lblPrice;
    }
}
