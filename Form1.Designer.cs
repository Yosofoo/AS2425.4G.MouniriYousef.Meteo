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
            dgvMeteo.CellContentClick += dgvMeteo_CellContentClick;

            dgvMeteo = new DataGridView();
            btnRefresh = new Button();
            lblCity = new Label();
            lblOrario = new Label();
            lblData = new Label();
            txtCity = new TextBox();
            txtOrario = new TextBox();
            txtData = new TextBox();
            btnAggiungiPrenotazione = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvMeteo).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvMeteo
            // 
            dgvMeteo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMeteo.Location = new Point(12, 221);
            dgvMeteo.Name = "dgvMeteo";
            dgvMeteo.RowHeadersWidth = 51;
            dgvMeteo.Size = new Size(767, 217);
            dgvMeteo.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(255, 255, 128);
            btnRefresh.Location = new Point(340, 190);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(167, 29);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Aggiorna i dati";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(30, 35);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(43, 20);
            lblCity.TabIndex = 2;
            lblCity.Text = "Città:";
            // 
            // lblOrario
            // 
            lblOrario.AutoSize = true;
            lblOrario.Location = new Point(30, 79);
            lblOrario.Name = "lblOrario";
            lblOrario.Size = new Size(54, 20);
            lblOrario.TabIndex = 3;
            lblOrario.Text = "Orario:";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(30, 121);
            lblData.Name = "lblData";
            lblData.Size = new Size(44, 20);
            lblData.TabIndex = 4;
            lblData.Text = "Data:";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(111, 35);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(125, 27);
            txtCity.TabIndex = 5;
            // 
            // txtOrario
            // 
            txtOrario.Location = new Point(111, 79);
            txtOrario.Name = "txtOrario";
            txtOrario.Size = new Size(125, 27);
            txtOrario.TabIndex = 6;
            // 
            // txtData
            // 
            txtData.Location = new Point(111, 121);
            txtData.Name = "txtData";
            txtData.Size = new Size(125, 27);
            txtData.TabIndex = 7;
            // 
            // btnAggiungiPrenotazione
            // 
            btnAggiungiPrenotazione.AccessibleRole = AccessibleRole.None;
            btnAggiungiPrenotazione.BackColor = Color.FromArgb(128, 128, 255);
            btnAggiungiPrenotazione.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAggiungiPrenotazione.Location = new Point(295, 50);
            btnAggiungiPrenotazione.Name = "btnAggiungiPrenotazione";
            btnAggiungiPrenotazione.Size = new Size(213, 85);
            btnAggiungiPrenotazione.TabIndex = 8;
            btnAggiungiPrenotazione.Text = "Inserisci una prenotazione di temperatura";
            btnAggiungiPrenotazione.UseVisualStyleBackColor = false;
            btnAggiungiPrenotazione.Click += btnAggiungiPrenotazione_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(192, 192, 255);
            groupBox1.Controls.Add(txtOrario);
            groupBox1.Controls.Add(btnAggiungiPrenotazione);
            groupBox1.Controls.Add(lblCity);
            groupBox1.Controls.Add(txtData);
            groupBox1.Controls.Add(lblOrario);
            groupBox1.Controls.Add(lblData);
            groupBox1.Controls.Add(txtCity);
            groupBox1.Location = new Point(148, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(532, 172);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Area di inserimento";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(btnRefresh);
            Controls.Add(dgvMeteo);
            Name = "Form1";
            Text = "Prenota forecast  temperatura";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMeteo).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMeteo;
        private Button btnRefresh;
        private Label lblCity;
        private Label lblOrario;
        private Label lblData;
        private TextBox txtCity;
        private TextBox txtOrario;
        private TextBox txtData;
        private Button btnAggiungiPrenotazione;
        private GroupBox groupBox1;
    }
}
