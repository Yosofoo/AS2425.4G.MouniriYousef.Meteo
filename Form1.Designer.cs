namespace AS2425._4G.MouniriYousef.Meteo
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            lblCity = new Label();
            lblOrario = new Label();
            lblData = new Label();
            txtCity = new TextBox();
            txtOrario = new TextBox();
            txtData = new TextBox();
            btnCerca = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 221);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(603, 217);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(621, 295);
            button1.Name = "button1";
            button1.Size = new Size(167, 29);
            button1.TabIndex = 1;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(154, 53);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(43, 20);
            lblCity.TabIndex = 2;
            lblCity.Text = "Città:";
            // 
            // lblOrario
            // 
            lblOrario.AutoSize = true;
            lblOrario.Location = new Point(154, 97);
            lblOrario.Name = "lblOrario";
            lblOrario.Size = new Size(54, 20);
            lblOrario.TabIndex = 3;
            lblOrario.Text = "Orario:";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(154, 139);
            lblData.Name = "lblData";
            lblData.Size = new Size(44, 20);
            lblData.TabIndex = 4;
            lblData.Text = "Data:";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(235, 53);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(125, 27);
            txtCity.TabIndex = 5;
            // 
            // txtOrario
            // 
            txtOrario.Location = new Point(235, 97);
            txtOrario.Name = "txtOrario";
            txtOrario.Size = new Size(125, 27);
            txtOrario.TabIndex = 6;
            // 
            // txtData
            // 
            txtData.Location = new Point(235, 139);
            txtData.Name = "txtData";
            txtData.Size = new Size(125, 27);
            txtData.TabIndex = 7;
            // 
            // btnCerca
            // 
            btnCerca.AccessibleRole = AccessibleRole.None;
            btnCerca.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerca.Location = new Point(440, 74);
            btnCerca.Name = "btnCerca";
            btnCerca.Size = new Size(102, 85);
            btnCerca.TabIndex = 8;
            btnCerca.Text = "🔎";
            btnCerca.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCerca);
            Controls.Add(txtData);
            Controls.Add(txtOrario);
            Controls.Add(txtCity);
            Controls.Add(lblData);
            Controls.Add(lblOrario);
            Controls.Add(lblCity);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Label lblCity;
        private Label lblOrario;
        private Label lblData;
        private TextBox txtCity;
        private TextBox txtOrario;
        private TextBox txtData;
        private Button btnCerca;
    }
}
