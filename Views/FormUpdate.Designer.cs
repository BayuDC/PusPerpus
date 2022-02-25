
namespace PusPerpus.Views {
    partial class FormUpdate {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.CmbGenre = new System.Windows.Forms.ComboBox();
            this.LblGenre = new System.Windows.Forms.Label();
            this.LblAuthor = new System.Windows.Forms.Label();
            this.TxtAuthor = new System.Windows.Forms.TextBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(252, 309);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(120, 40);
            this.BtnUpdate.TabIndex = 26;
            this.BtnUpdate.Text = "Update Book";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdateClick);
            // 
            // CmbGenre
            // 
            this.CmbGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbGenre.FormattingEnabled = true;
            this.CmbGenre.Location = new System.Drawing.Point(13, 238);
            this.CmbGenre.Name = "CmbGenre";
            this.CmbGenre.Size = new System.Drawing.Size(359, 29);
            this.CmbGenre.TabIndex = 25;
            // 
            // LblGenre
            // 
            this.LblGenre.AutoSize = true;
            this.LblGenre.Location = new System.Drawing.Point(12, 214);
            this.LblGenre.Name = "LblGenre";
            this.LblGenre.Size = new System.Drawing.Size(52, 21);
            this.LblGenre.TabIndex = 24;
            this.LblGenre.Text = "Genre";
            // 
            // LblAuthor
            // 
            this.LblAuthor.AutoSize = true;
            this.LblAuthor.Location = new System.Drawing.Point(12, 144);
            this.LblAuthor.Name = "LblAuthor";
            this.LblAuthor.Size = new System.Drawing.Size(58, 21);
            this.LblAuthor.TabIndex = 23;
            this.LblAuthor.Text = "Author";
            // 
            // TxtAuthor
            // 
            this.TxtAuthor.Location = new System.Drawing.Point(12, 168);
            this.TxtAuthor.Name = "TxtAuthor";
            this.TxtAuthor.Size = new System.Drawing.Size(359, 29);
            this.TxtAuthor.TabIndex = 22;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTitle.Location = new System.Drawing.Point(29, 10);
            this.LblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(327, 37);
            this.LblTitle.TabIndex = 21;
            this.LblTitle.Text = "PusPerpus - Update Book";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(13, 72);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(52, 21);
            this.LblName.TabIndex = 20;
            this.LblName.Text = "Name";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(13, 96);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(359, 29);
            this.TxtName.TabIndex = 19;
            // 
            // FormUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.CmbGenre);
            this.Controls.Add(this.LblGenre);
            this.Controls.Add(this.LblAuthor);
            this.Controls.Add(this.TxtAuthor);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.TxtName);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormUpdate";
            this.Text = "PusPerpus - Update Book";
            this.Load += new System.EventHandler(this.FormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.ComboBox CmbGenre;
        private System.Windows.Forms.Label LblGenre;
        private System.Windows.Forms.Label LblAuthor;
        private System.Windows.Forms.TextBox TxtAuthor;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtName;
    }
}