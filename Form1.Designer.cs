namespace PriceListGenerator
{
    partial class PriceList
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
            this.DataGrid_products = new System.Windows.Forms.DataGridView();
            this.button_Save = new System.Windows.Forms.Button();
            this.checkBox_id = new System.Windows.Forms.CheckBox();
            this.checkBox_category = new System.Windows.Forms.CheckBox();
            this.checkBox_currency = new System.Windows.Forms.CheckBox();
            this.checkBox_price = new System.Windows.Forms.CheckBox();
            this.checkBox_title = new System.Windows.Forms.CheckBox();
            this.checkBox_rating = new System.Windows.Forms.CheckBox();
            this.checkBox_description = new System.Windows.Forms.CheckBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Currency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_products)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid_products
            // 
            this.DataGrid_products.AllowUserToAddRows = false;
            this.DataGrid_products.AllowUserToDeleteRows = false;
            this.DataGrid_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_products.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.Price,
            this.Currency,
            this.Category,
            this.Description,
            this.Rating});
            this.DataGrid_products.Location = new System.Drawing.Point(12, 3);
            this.DataGrid_products.Name = "DataGrid_products";
            this.DataGrid_products.ReadOnly = true;
            this.DataGrid_products.Size = new System.Drawing.Size(767, 367);
            this.DataGrid_products.TabIndex = 0;
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(687, 376);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 1;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // checkBox_id
            // 
            this.checkBox_id.Location = new System.Drawing.Point(73, 9);
            this.checkBox_id.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox_id.Name = "checkBox_id";
            this.checkBox_id.Size = new System.Drawing.Size(13, 14);
            this.checkBox_id.TabIndex = 2;
            this.checkBox_id.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBox_id.UseVisualStyleBackColor = true;
            // 
            // checkBox_category
            // 
            this.checkBox_category.Location = new System.Drawing.Point(506, 9);
            this.checkBox_category.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox_category.Name = "checkBox_category";
            this.checkBox_category.Size = new System.Drawing.Size(13, 14);
            this.checkBox_category.TabIndex = 3;
            this.checkBox_category.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBox_category.UseVisualStyleBackColor = true;
            // 
            // checkBox_currency
            // 
            this.checkBox_currency.Location = new System.Drawing.Point(406, 9);
            this.checkBox_currency.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox_currency.Name = "checkBox_currency";
            this.checkBox_currency.Size = new System.Drawing.Size(13, 14);
            this.checkBox_currency.TabIndex = 4;
            this.checkBox_currency.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBox_currency.UseVisualStyleBackColor = true;
            // 
            // checkBox_price
            // 
            this.checkBox_price.Location = new System.Drawing.Point(287, 9);
            this.checkBox_price.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox_price.Name = "checkBox_price";
            this.checkBox_price.Size = new System.Drawing.Size(13, 14);
            this.checkBox_price.TabIndex = 5;
            this.checkBox_price.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBox_price.UseVisualStyleBackColor = true;
            // 
            // checkBox_title
            // 
            this.checkBox_title.Location = new System.Drawing.Point(186, 9);
            this.checkBox_title.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox_title.Name = "checkBox_title";
            this.checkBox_title.Size = new System.Drawing.Size(13, 14);
            this.checkBox_title.TabIndex = 6;
            this.checkBox_title.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBox_title.UseVisualStyleBackColor = true;
            // 
            // checkBox_rating
            // 
            this.checkBox_rating.Location = new System.Drawing.Point(697, 9);
            this.checkBox_rating.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox_rating.Name = "checkBox_rating";
            this.checkBox_rating.Size = new System.Drawing.Size(13, 14);
            this.checkBox_rating.TabIndex = 7;
            this.checkBox_rating.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBox_rating.UseVisualStyleBackColor = true;
            // 
            // checkBox_description
            // 
            this.checkBox_description.Location = new System.Drawing.Point(617, 9);
            this.checkBox_description.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox_description.Name = "checkBox_description";
            this.checkBox_description.Size = new System.Drawing.Size(13, 14);
            this.checkBox_description.TabIndex = 8;
            this.checkBox_description.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBox_description.UseVisualStyleBackColor = true;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Currency
            // 
            this.Currency.HeaderText = "Currency";
            this.Currency.Name = "Currency";
            this.Currency.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Rating
            // 
            this.Rating.HeaderText = "Rating";
            this.Rating.Name = "Rating";
            this.Rating.ReadOnly = true;
            // 
            // PriceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 401);
            this.Controls.Add(this.checkBox_description);
            this.Controls.Add(this.checkBox_rating);
            this.Controls.Add(this.checkBox_title);
            this.Controls.Add(this.checkBox_price);
            this.Controls.Add(this.checkBox_currency);
            this.Controls.Add(this.checkBox_category);
            this.Controls.Add(this.checkBox_id);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.DataGrid_products);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "PriceList";
            this.Text = "Price List";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_products)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid_products;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.CheckBox checkBox_id;
        private System.Windows.Forms.CheckBox checkBox_category;
        private System.Windows.Forms.CheckBox checkBox_currency;
        private System.Windows.Forms.CheckBox checkBox_price;
        private System.Windows.Forms.CheckBox checkBox_title;
        private System.Windows.Forms.CheckBox checkBox_rating;
        private System.Windows.Forms.CheckBox checkBox_description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Currency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
    }
}

