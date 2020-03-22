namespace CG_lab2
{
    partial class FileFormat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chooseButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resolution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDepth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compression = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseButton
            // 
            this.chooseButton.Location = new System.Drawing.Point(34, 395);
            this.chooseButton.Name = "chooseButton";
            this.chooseButton.Size = new System.Drawing.Size(197, 43);
            this.chooseButton.TabIndex = 0;
            this.chooseButton.Text = "Choose file/directory";
            this.chooseButton.UseVisualStyleBackColor = true;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(550, 395);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(176, 43);
            this.showButton.TabIndex = 2;
            this.showButton.Text = "Show image\'s info";
            this.showButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.size,
            this.resolution,
            this.colorDepth,
            this.compression});
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(733, 355);
            this.dataGridView1.TabIndex = 3;
            // 
            // name
            // 
            this.name.HeaderText = "File name";
            this.name.Name = "name";
            this.name.Width = 200;
            // 
            // size
            // 
            this.size.HeaderText = "Image size (px)";
            this.size.Name = "size";
            this.size.Width = 120;
            // 
            // resolution
            // 
            this.resolution.HeaderText = "Resolution (dot/inch)";
            this.resolution.Name = "resolution";
            // 
            // colorDepth
            // 
            this.colorDepth.HeaderText = "Color depth";
            this.colorDepth.Name = "colorDepth";
            this.colorDepth.Width = 120;
            // 
            // compression
            // 
            this.compression.HeaderText = "Compression";
            this.compression.Name = "compression";
            this.compression.Width = 150;
            // 
            // FileFormat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.chooseButton);
            this.Name = "FileFormat";
            this.Text = "File format";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button chooseButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn resolution;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDepth;
        private System.Windows.Forms.DataGridViewTextBoxColumn compression;
    }
}

