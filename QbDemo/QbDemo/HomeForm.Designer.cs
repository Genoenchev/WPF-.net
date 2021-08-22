
namespace QbDemo
{
    partial class HomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InputId = new System.Windows.Forms.TextBox();
            this.LabelId = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.InputCityName = new System.Windows.Forms.TextBox();
            this.LabelPopulation = new System.Windows.Forms.Label();
            this.InputPopulation = new System.Windows.Forms.TextBox();
            this.InputCountryId = new System.Windows.Forms.ComboBox();
            this.LabelCountry = new System.Windows.Forms.Label();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.CityGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CityGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // InputId
            // 
            this.InputId.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputId.Location = new System.Drawing.Point(109, 25);
            this.InputId.Name = "InputId";
            this.InputId.ReadOnly = true;
            this.InputId.Size = new System.Drawing.Size(117, 32);
            this.InputId.TabIndex = 0;
            // 
            // LabelId
            // 
            this.LabelId.AutoSize = true;
            this.LabelId.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelId.Location = new System.Drawing.Point(61, 28);
            this.LabelId.Name = "LabelId";
            this.LabelId.Size = new System.Drawing.Size(30, 25);
            this.LabelId.TabIndex = 1;
            this.LabelId.Text = "ID";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelName.Location = new System.Drawing.Point(29, 94);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(62, 25);
            this.LabelName.TabIndex = 3;
            this.LabelName.Text = "Name";
            // 
            // InputCityName
            // 
            this.InputCityName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputCityName.Location = new System.Drawing.Point(109, 91);
            this.InputCityName.Name = "InputCityName";
            this.InputCityName.Size = new System.Drawing.Size(117, 32);
            this.InputCityName.TabIndex = 2;
            // 
            // LabelPopulation
            // 
            this.LabelPopulation.AutoSize = true;
            this.LabelPopulation.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelPopulation.Location = new System.Drawing.Point(0, 156);
            this.LabelPopulation.Name = "LabelPopulation";
            this.LabelPopulation.Size = new System.Drawing.Size(103, 25);
            this.LabelPopulation.TabIndex = 5;
            this.LabelPopulation.Text = "Population";
            // 
            // InputPopulation
            // 
            this.InputPopulation.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputPopulation.Location = new System.Drawing.Point(109, 153);
            this.InputPopulation.Name = "InputPopulation";
            this.InputPopulation.Size = new System.Drawing.Size(117, 32);
            this.InputPopulation.TabIndex = 4;
            // 
            // InputCountryId
            // 
            this.InputCountryId.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputCountryId.FormattingEnabled = true;
            this.InputCountryId.Location = new System.Drawing.Point(109, 218);
            this.InputCountryId.Name = "InputCountryId";
            this.InputCountryId.Size = new System.Drawing.Size(121, 33);
            this.InputCountryId.TabIndex = 6;
            // 
            // LabelCountry
            // 
            this.LabelCountry.AutoSize = true;
            this.LabelCountry.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelCountry.Location = new System.Drawing.Point(12, 221);
            this.LabelCountry.Name = "LabelCountry";
            this.LabelCountry.Size = new System.Drawing.Size(79, 25);
            this.LabelCountry.TabIndex = 7;
            this.LabelCountry.Text = "Country";
            // 
            // BtnCreate
            // 
            this.BtnCreate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCreate.Location = new System.Drawing.Point(12, 284);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(91, 50);
            this.BtnCreate.TabIndex = 8;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnUpdate.Location = new System.Drawing.Point(118, 284);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(91, 50);
            this.BtnUpdate.TabIndex = 9;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnDelete.Location = new System.Drawing.Point(224, 284);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(91, 50);
            this.BtnDelete.TabIndex = 10;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // CityGridView
            // 
            this.CityGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CityGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.CityGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CityGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CityGridView.Location = new System.Drawing.Point(334, 25);
            this.CityGridView.Name = "CityGridView";
            this.CityGridView.ReadOnly = true;
            this.CityGridView.RowTemplate.Height = 25;
            this.CityGridView.Size = new System.Drawing.Size(553, 381);
            this.CityGridView.TabIndex = 11;
            this.CityGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CityGridView_RowHeaderMouseClick);
            this.CityGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CityGridView_RowHeaderMouseDoubleClick);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 450);
            this.Controls.Add(this.CityGridView);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.LabelCountry);
            this.Controls.Add(this.InputCountryId);
            this.Controls.Add(this.LabelPopulation);
            this.Controls.Add(this.InputPopulation);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.InputCityName);
            this.Controls.Add(this.LabelId);
            this.Controls.Add(this.InputId);
            this.Name = "HomeForm";
            this.Text = "Home Form";
            ((System.ComponentModel.ISupportInitialize)(this.CityGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputId;
        private System.Windows.Forms.Label LabelId;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.TextBox InputCityName;
        private System.Windows.Forms.Label LabelPopulation;
        private System.Windows.Forms.TextBox InputPopulation;
        private System.Windows.Forms.ComboBox InputCountryId;
        private System.Windows.Forms.Label LabelCountry;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.DataGridView CityGridView;
    }
}

