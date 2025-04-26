namespace _2doParcial_Aranza.UI.FormsBloques
{
    partial class FormBloques
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBloques));
            btnActualizarBloque = new Button();
            lblIdB = new Label();
            txtID = new TextBox();
            btnBuscarBloqueID = new Button();
            dgvDatosBloque = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Rareza = new DataGridViewTextBoxColumn();
            labelNivel = new Label();
            labelNombrebloque = new Label();
            cmbRareza = new ComboBox();
            cmbTipo = new ComboBox();
            txtNombreBloque = new TextBox();
            lblRareza = new Label();
            lblTipo = new Label();
            txtIdBloqueRegistrado = new TextBox();
            btnBuscarT = new Button();
            btnRareza = new Button();
            labelTipo = new Label();
            labelRareza = new Label();
            button1 = new Button();
            btnSalirBloque = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            btnGuardarBloque = new Button();
            buttonEliminarBloque = new Button();
            btnVerBloques = new Button();
            cbmSearchTipo = new ComboBox();
            cbmSearchRareza = new ComboBox();
            btnVerGrafica = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDatosBloque).BeginInit();
            SuspendLayout();
            // 
            // btnActualizarBloque
            // 
            btnActualizarBloque.Font = new Font("Sylfaen", 10F, FontStyle.Bold);
            btnActualizarBloque.Location = new Point(775, 477);
            btnActualizarBloque.Margin = new Padding(4, 3, 4, 3);
            btnActualizarBloque.Name = "btnActualizarBloque";
            btnActualizarBloque.Size = new Size(178, 36);
            btnActualizarBloque.TabIndex = 26;
            btnActualizarBloque.Text = "Actualizar Bloque";
            btnActualizarBloque.UseVisualStyleBackColor = true;
            btnActualizarBloque.Click += btnActualizarBloque_Click_1;
            // 
            // lblIdB
            // 
            lblIdB.AutoSize = true;
            lblIdB.Font = new Font("Sylfaen", 10F, FontStyle.Bold);
            lblIdB.Location = new Point(33, 247);
            lblIdB.Margin = new Padding(4, 0, 4, 0);
            lblIdB.Name = "lblIdB";
            lblIdB.Size = new Size(205, 22);
            lblIdB.TabIndex = 23;
            lblIdB.Text = "Ingrese el ID del Bloque";
            // 
            // txtID
            // 
            txtID.Location = new Point(294, 247);
            txtID.Margin = new Padding(4, 3, 4, 3);
            txtID.Name = "txtID";
            txtID.Size = new Size(281, 29);
            txtID.TabIndex = 22;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // btnBuscarBloqueID
            // 
            btnBuscarBloqueID.Font = new Font("Sylfaen", 10F, FontStyle.Bold);
            btnBuscarBloqueID.Location = new Point(602, 247);
            btnBuscarBloqueID.Margin = new Padding(4, 3, 4, 3);
            btnBuscarBloqueID.Name = "btnBuscarBloqueID";
            btnBuscarBloqueID.Size = new Size(168, 36);
            btnBuscarBloqueID.TabIndex = 21;
            btnBuscarBloqueID.Text = "Buscar por ID";
            btnBuscarBloqueID.TextAlign = ContentAlignment.TopLeft;
            btnBuscarBloqueID.UseVisualStyleBackColor = true;
            btnBuscarBloqueID.Click += btnBuscarBloqueID_Click;
            // 
            // dgvDatosBloque
            // 
            dgvDatosBloque.BackgroundColor = Color.LightSteelBlue;
            dgvDatosBloque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatosBloque.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Tipo, Rareza });
            dgvDatosBloque.GridColor = SystemColors.Window;
            dgvDatosBloque.Location = new Point(24, 458);
            dgvDatosBloque.Margin = new Padding(4, 3, 4, 3);
            dgvDatosBloque.Name = "dgvDatosBloque";
            dgvDatosBloque.RowHeadersWidth = 51;
            dgvDatosBloque.Size = new Size(551, 187);
            dgvDatosBloque.TabIndex = 19;
            dgvDatosBloque.CellContentClick += dgvDatosBloque_CellContentClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.MinimumWidth = 6;
            Tipo.Name = "Tipo";
            Tipo.Width = 125;
            // 
            // Rareza
            // 
            Rareza.HeaderText = "Rareza";
            Rareza.MinimumWidth = 6;
            Rareza.Name = "Rareza";
            Rareza.Width = 125;
            // 
            // labelNivel
            // 
            labelNivel.AutoSize = true;
            labelNivel.Font = new Font("Sylfaen", 10F, FontStyle.Bold);
            labelNivel.Location = new Point(332, 38);
            labelNivel.Margin = new Padding(4, 0, 4, 0);
            labelNivel.Name = "labelNivel";
            labelNivel.Size = new Size(213, 22);
            labelNivel.TabIndex = 18;
            labelNivel.Text = "ID del Bloque Registrado";
            // 
            // labelNombrebloque
            // 
            labelNombrebloque.AutoSize = true;
            labelNombrebloque.Font = new Font("Sylfaen", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombrebloque.Location = new Point(33, 38);
            labelNombrebloque.Margin = new Padding(4, 0, 4, 0);
            labelNombrebloque.Name = "labelNombrebloque";
            labelNombrebloque.Size = new Size(168, 22);
            labelNombrebloque.TabIndex = 17;
            labelNombrebloque.Text = "Nombre del Bloque";
            // 
            // cmbRareza
            // 
            cmbRareza.FormattingEnabled = true;
            cmbRareza.Location = new Point(332, 162);
            cmbRareza.Margin = new Padding(4, 3, 4, 3);
            cmbRareza.Name = "cmbRareza";
            cmbRareza.Size = new Size(255, 30);
            cmbRareza.TabIndex = 28;
            cmbRareza.SelectedIndexChanged += cmbRareza_SelectedIndexChanged;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(33, 162);
            cmbTipo.Margin = new Padding(4, 3, 4, 3);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(255, 30);
            cmbTipo.TabIndex = 29;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // txtNombreBloque
            // 
            txtNombreBloque.Location = new Point(33, 73);
            txtNombreBloque.Margin = new Padding(4, 3, 4, 3);
            txtNombreBloque.Name = "txtNombreBloque";
            txtNombreBloque.Size = new Size(255, 29);
            txtNombreBloque.TabIndex = 30;
            txtNombreBloque.TextChanged += txtNombreBloque_TextChanged;
            // 
            // lblRareza
            // 
            lblRareza.AutoSize = true;
            lblRareza.Font = new Font("Sylfaen", 10F, FontStyle.Bold);
            lblRareza.ForeColor = SystemColors.ControlText;
            lblRareza.Location = new Point(332, 127);
            lblRareza.Margin = new Padding(4, 0, 4, 0);
            lblRareza.Name = "lblRareza";
            lblRareza.Size = new Size(66, 22);
            lblRareza.TabIndex = 31;
            lblRareza.Text = "Rareza";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Sylfaen", 10F, FontStyle.Bold);
            lblTipo.Location = new Point(33, 127);
            lblTipo.Margin = new Padding(4, 0, 4, 0);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(48, 22);
            lblTipo.TabIndex = 32;
            lblTipo.Text = "Tipo";
            // 
            // txtIdBloqueRegistrado
            // 
            txtIdBloqueRegistrado.Location = new Point(332, 73);
            txtIdBloqueRegistrado.Margin = new Padding(4, 3, 4, 3);
            txtIdBloqueRegistrado.Name = "txtIdBloqueRegistrado";
            txtIdBloqueRegistrado.Size = new Size(255, 29);
            txtIdBloqueRegistrado.TabIndex = 33;
            txtIdBloqueRegistrado.TextChanged += txtIdBloqueRegistrado_TextChanged;
            // 
            // btnBuscarT
            // 
            btnBuscarT.Font = new Font("Sylfaen", 10F, FontStyle.Bold);
            btnBuscarT.Location = new Point(602, 313);
            btnBuscarT.Margin = new Padding(4, 3, 4, 3);
            btnBuscarT.Name = "btnBuscarT";
            btnBuscarT.Size = new Size(168, 35);
            btnBuscarT.TabIndex = 34;
            btnBuscarT.Text = "Buscar por Tipo";
            btnBuscarT.TextAlign = ContentAlignment.TopLeft;
            btnBuscarT.UseVisualStyleBackColor = true;
            btnBuscarT.Click += btnBuscarT_Click;
            // 
            // btnRareza
            // 
            btnRareza.Font = new Font("Sylfaen", 10F, FontStyle.Bold);
            btnRareza.Location = new Point(602, 368);
            btnRareza.Margin = new Padding(4, 3, 4, 3);
            btnRareza.Name = "btnRareza";
            btnRareza.Size = new Size(168, 35);
            btnRareza.TabIndex = 35;
            btnRareza.Text = "Buscar por Rareza";
            btnRareza.TextAlign = ContentAlignment.TopLeft;
            btnRareza.UseVisualStyleBackColor = true;
            btnRareza.Click += btnRareza_Click;
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Font = new Font("Sylfaen", 10F, FontStyle.Bold);
            labelTipo.Location = new Point(33, 317);
            labelTipo.Margin = new Padding(4, 0, 4, 0);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(218, 22);
            labelTipo.TabIndex = 37;
            labelTipo.Text = "Ingrese el Tipo de Bloque";
            // 
            // labelRareza
            // 
            labelRareza.AutoSize = true;
            labelRareza.Font = new Font("Sylfaen", 10F, FontStyle.Bold);
            labelRareza.Location = new Point(33, 381);
            labelRareza.Margin = new Padding(4, 0, 4, 0);
            labelRareza.Name = "labelRareza";
            labelRareza.Size = new Size(242, 22);
            labelRareza.TabIndex = 39;
            labelRareza.Text = "Ingrese la Rareza del Bloque";
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 44;
            // 
            // btnSalirBloque
            // 
            btnSalirBloque.Font = new Font("Sylfaen", 10F, FontStyle.Bold);
            btnSalirBloque.Location = new Point(908, 12);
            btnSalirBloque.Margin = new Padding(4, 3, 4, 3);
            btnSalirBloque.Name = "btnSalirBloque";
            btnSalirBloque.Size = new Size(117, 61);
            btnSalirBloque.TabIndex = 42;
            btnSalirBloque.Text = "Salir";
            btnSalirBloque.UseVisualStyleBackColor = true;
            btnSalirBloque.Click += btnSalirBloque_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // btnGuardarBloque
            // 
            btnGuardarBloque.Location = new Point(643, 113);
            btnGuardarBloque.Name = "btnGuardarBloque";
            btnGuardarBloque.Size = new Size(108, 50);
            btnGuardarBloque.TabIndex = 43;
            btnGuardarBloque.Text = "Guardar";
            btnGuardarBloque.UseVisualStyleBackColor = true;
            btnGuardarBloque.Click += btnGuardarBloque_Click;
            // 
            // buttonEliminarBloque
            // 
            buttonEliminarBloque.Font = new Font("Sylfaen", 10F, FontStyle.Bold);
            buttonEliminarBloque.Location = new Point(775, 609);
            buttonEliminarBloque.Margin = new Padding(4, 3, 4, 3);
            buttonEliminarBloque.Name = "buttonEliminarBloque";
            buttonEliminarBloque.Size = new Size(178, 36);
            buttonEliminarBloque.TabIndex = 45;
            buttonEliminarBloque.Text = "Eliminar";
            buttonEliminarBloque.UseVisualStyleBackColor = true;
            buttonEliminarBloque.Click += buttonEliminarBloque_Click;
            // 
            // btnVerBloques
            // 
            btnVerBloques.Location = new Point(775, 544);
            btnVerBloques.Name = "btnVerBloques";
            btnVerBloques.Size = new Size(178, 29);
            btnVerBloques.TabIndex = 46;
            btnVerBloques.Text = "Ver Bloques";
            btnVerBloques.UseVisualStyleBackColor = true;
            btnVerBloques.Click += btnVerBloques_Click_1;
            // 
            // cbmSearchTipo
            // 
            cbmSearchTipo.FormattingEnabled = true;
            cbmSearchTipo.Location = new Point(294, 309);
            cbmSearchTipo.Margin = new Padding(4, 3, 4, 3);
            cbmSearchTipo.Name = "cbmSearchTipo";
            cbmSearchTipo.Size = new Size(281, 30);
            cbmSearchTipo.TabIndex = 47;
            // 
            // cbmSearchRareza
            // 
            cbmSearchRareza.FormattingEnabled = true;
            cbmSearchRareza.Location = new Point(294, 373);
            cbmSearchRareza.Margin = new Padding(4, 3, 4, 3);
            cbmSearchRareza.Name = "cbmSearchRareza";
            cbmSearchRareza.Size = new Size(281, 30);
            cbmSearchRareza.TabIndex = 48;
            // 
            // btnVerGrafica
            // 
            btnVerGrafica.Location = new Point(796, 674);
            btnVerGrafica.Name = "btnVerGrafica";
            btnVerGrafica.Size = new Size(140, 52);
            btnVerGrafica.TabIndex = 49;
            btnVerGrafica.Text = "Ver Estadísticas";
            btnVerGrafica.UseVisualStyleBackColor = true;
            btnVerGrafica.Click += btnVerGrafica_Click;
            // 
            // FormBloques
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1064, 763);
            Controls.Add(btnVerGrafica);
            Controls.Add(cbmSearchRareza);
            Controls.Add(cbmSearchTipo);
            Controls.Add(btnVerBloques);
            Controls.Add(buttonEliminarBloque);
            Controls.Add(btnGuardarBloque);
            Controls.Add(btnSalirBloque);
            Controls.Add(button1);
            Controls.Add(labelRareza);
            Controls.Add(labelTipo);
            Controls.Add(btnRareza);
            Controls.Add(btnBuscarT);
            Controls.Add(txtIdBloqueRegistrado);
            Controls.Add(lblTipo);
            Controls.Add(lblRareza);
            Controls.Add(txtNombreBloque);
            Controls.Add(cmbTipo);
            Controls.Add(cmbRareza);
            Controls.Add(btnActualizarBloque);
            Controls.Add(lblIdB);
            Controls.Add(txtID);
            Controls.Add(btnBuscarBloqueID);
            Controls.Add(dgvDatosBloque);
            Controls.Add(labelNivel);
            Controls.Add(labelNombrebloque);
            Font = new Font("Sylfaen", 10F, FontStyle.Bold);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormBloques";
            Text = "FormBloques";
            Load += FormBloques_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatosBloque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion



        private Button btnActualizarBloque;
        private Label lblIdB;
        private TextBox txtID;
        private Button btnBuscarBloqueID;
        private DataGridView dgvDatosBloque;
        private Label labelNivel;
        private Label labelNombrebloque;
        private ComboBox cmbRareza;
        private ComboBox cmbTipo;
        private TextBox txtNombreBloque;
        private Label lblRareza;
        private Label lblTipo;
        private TextBox txtIdBloqueRegistrado;
        private Button btnBuscarT;
        private Button btnRareza;
        private Label labelTipo;
        private Label labelRareza;
        private Button button1;
        private Button btnSalirBloque;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button btnGuardarBloque;
        private Button buttonEliminarBloque;
        private Button btnVerBloques;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Rareza;
        private ComboBox cbmSearchTipo;
        private ComboBox cbmSearchRareza;
        private Button btnVerGrafica;
    }
}