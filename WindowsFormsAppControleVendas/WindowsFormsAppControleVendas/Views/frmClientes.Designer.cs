
namespace WindowsFormsAppControleVendas.Views
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCadastroCliente = new System.Windows.Forms.Label();
            this.tabControlClientes = new System.Windows.Forms.TabControl();
            this.tabPageDadosPessoais = new System.Windows.Forms.TabPage();
            this.comBoxUf = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxCep = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCelular = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxRg = new System.Windows.Forms.MaskedTextBox();
            this.labelCelular = new System.Windows.Forms.Label();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelRg = new System.Windows.Forms.Label();
            this.labelCpf = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.labelCidade = new System.Windows.Forms.Label();
            this.textBoxBairro = new System.Windows.Forms.TextBox();
            this.labelBairro = new System.Windows.Forms.Label();
            this.textBoxComplemento = new System.Windows.Forms.TextBox();
            this.labelComplemento = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.labelNumero = new System.Windows.Forms.Label();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.labelCep = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.tabPageConsulta = new System.Windows.Forms.TabPage();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxNomeConsulta = new System.Windows.Forms.TextBox();
            this.labelNomeConsulta = new System.Windows.Forms.Label();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.ButtonLimpar = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.buttonConsultaLimpar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControlClientes.SuspendLayout();
            this.tabPageDadosPessoais.SuspendLayout();
            this.tabPageConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.labelCadastroCliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 100);
            this.panel1.TabIndex = 0;
            // 
            // labelCadastroCliente
            // 
            this.labelCadastroCliente.AutoSize = true;
            this.labelCadastroCliente.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCadastroCliente.ForeColor = System.Drawing.Color.White;
            this.labelCadastroCliente.Location = new System.Drawing.Point(43, 43);
            this.labelCadastroCliente.Name = "labelCadastroCliente";
            this.labelCadastroCliente.Size = new System.Drawing.Size(222, 24);
            this.labelCadastroCliente.TabIndex = 0;
            this.labelCadastroCliente.Text = "Cadastro de clientes";
            // 
            // tabControlClientes
            // 
            this.tabControlClientes.Controls.Add(this.tabPageDadosPessoais);
            this.tabControlClientes.Controls.Add(this.tabPageConsulta);
            this.tabControlClientes.Location = new System.Drawing.Point(12, 121);
            this.tabControlClientes.Name = "tabControlClientes";
            this.tabControlClientes.SelectedIndex = 0;
            this.tabControlClientes.Size = new System.Drawing.Size(990, 325);
            this.tabControlClientes.TabIndex = 1;
            // 
            // tabPageDadosPessoais
            // 
            this.tabPageDadosPessoais.Controls.Add(this.comBoxUf);
            this.tabPageDadosPessoais.Controls.Add(this.maskedTextBoxCep);
            this.tabPageDadosPessoais.Controls.Add(this.maskedTextBoxCelular);
            this.tabPageDadosPessoais.Controls.Add(this.maskedTextBoxTelefone);
            this.tabPageDadosPessoais.Controls.Add(this.maskedTextBoxCpf);
            this.tabPageDadosPessoais.Controls.Add(this.maskedTextBoxRg);
            this.tabPageDadosPessoais.Controls.Add(this.labelCelular);
            this.tabPageDadosPessoais.Controls.Add(this.labelTelefone);
            this.tabPageDadosPessoais.Controls.Add(this.textBoxEmail);
            this.tabPageDadosPessoais.Controls.Add(this.labelEmail);
            this.tabPageDadosPessoais.Controls.Add(this.textBoxNome);
            this.tabPageDadosPessoais.Controls.Add(this.labelNome);
            this.tabPageDadosPessoais.Controls.Add(this.labelRg);
            this.tabPageDadosPessoais.Controls.Add(this.labelCpf);
            this.tabPageDadosPessoais.Controls.Add(this.labelEstado);
            this.tabPageDadosPessoais.Controls.Add(this.textBoxCidade);
            this.tabPageDadosPessoais.Controls.Add(this.labelCidade);
            this.tabPageDadosPessoais.Controls.Add(this.textBoxBairro);
            this.tabPageDadosPessoais.Controls.Add(this.labelBairro);
            this.tabPageDadosPessoais.Controls.Add(this.textBoxComplemento);
            this.tabPageDadosPessoais.Controls.Add(this.labelComplemento);
            this.tabPageDadosPessoais.Controls.Add(this.textBoxNumero);
            this.tabPageDadosPessoais.Controls.Add(this.labelNumero);
            this.tabPageDadosPessoais.Controls.Add(this.textBoxEndereco);
            this.tabPageDadosPessoais.Controls.Add(this.labelEndereco);
            this.tabPageDadosPessoais.Controls.Add(this.labelCep);
            this.tabPageDadosPessoais.Controls.Add(this.textBoxCodigo);
            this.tabPageDadosPessoais.Controls.Add(this.labelCodigo);
            this.tabPageDadosPessoais.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageDadosPessoais.ForeColor = System.Drawing.Color.Black;
            this.tabPageDadosPessoais.Location = new System.Drawing.Point(4, 22);
            this.tabPageDadosPessoais.Name = "tabPageDadosPessoais";
            this.tabPageDadosPessoais.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDadosPessoais.Size = new System.Drawing.Size(982, 299);
            this.tabPageDadosPessoais.TabIndex = 0;
            this.tabPageDadosPessoais.Text = "Dados Pessoais";
            this.tabPageDadosPessoais.UseVisualStyleBackColor = true;
            // 
            // comBoxUf
            // 
            this.comBoxUf.FormattingEnabled = true;
            this.comBoxUf.Items.AddRange(new object[] {
            "RO",
            "AC",
            "AM",
            "RR",
            "PA",
            "AP",
            "TO",
            "MA",
            "PI",
            "CE",
            "RN",
            "PB",
            "PE",
            "AL",
            "SE",
            "BA",
            "MG",
            "ES",
            "RJ",
            "SP",
            "PR",
            "SC",
            "RS",
            "MS",
            "MT",
            "GO",
            "DF"});
            this.comBoxUf.Location = new System.Drawing.Point(506, 236);
            this.comBoxUf.Name = "comBoxUf";
            this.comBoxUf.Size = new System.Drawing.Size(121, 24);
            this.comBoxUf.TabIndex = 33;
            // 
            // maskedTextBoxCep
            // 
            this.maskedTextBoxCep.Location = new System.Drawing.Point(506, 31);
            this.maskedTextBoxCep.Mask = "00000-999";
            this.maskedTextBoxCep.Name = "maskedTextBoxCep";
            this.maskedTextBoxCep.Size = new System.Drawing.Size(80, 23);
            this.maskedTextBoxCep.TabIndex = 32;
            // 
            // maskedTextBoxCelular
            // 
            this.maskedTextBoxCelular.Location = new System.Drawing.Point(107, 236);
            this.maskedTextBoxCelular.Mask = "(99) 00000-0000";
            this.maskedTextBoxCelular.Name = "maskedTextBoxCelular";
            this.maskedTextBoxCelular.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBoxCelular.TabIndex = 31;
            // 
            // maskedTextBoxTelefone
            // 
            this.maskedTextBoxTelefone.Location = new System.Drawing.Point(107, 201);
            this.maskedTextBoxTelefone.Mask = "(99) 0000-0000";
            this.maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            this.maskedTextBoxTelefone.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBoxTelefone.TabIndex = 30;
            // 
            // maskedTextBoxCpf
            // 
            this.maskedTextBoxCpf.Location = new System.Drawing.Point(107, 172);
            this.maskedTextBoxCpf.Mask = "###.###.###-##";
            this.maskedTextBoxCpf.Name = "maskedTextBoxCpf";
            this.maskedTextBoxCpf.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBoxCpf.TabIndex = 29;
            // 
            // maskedTextBoxRg
            // 
            this.maskedTextBoxRg.Location = new System.Drawing.Point(107, 135);
            this.maskedTextBoxRg.Mask = "##.###.###-##";
            this.maskedTextBoxRg.Name = "maskedTextBoxRg";
            this.maskedTextBoxRg.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBoxRg.TabIndex = 28;
            // 
            // labelCelular
            // 
            this.labelCelular.AutoSize = true;
            this.labelCelular.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelCelular.Location = new System.Drawing.Point(35, 239);
            this.labelCelular.Name = "labelCelular";
            this.labelCelular.Size = new System.Drawing.Size(56, 16);
            this.labelCelular.TabIndex = 26;
            this.labelCelular.Text = "Celular";
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelTelefone.Location = new System.Drawing.Point(35, 204);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(62, 16);
            this.labelTelefone.TabIndex = 24;
            this.labelTelefone.Text = "Telefone";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(107, 98);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(282, 23);
            this.textBoxEmail.TabIndex = 23;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelEmail.Location = new System.Drawing.Point(36, 101);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(48, 16);
            this.labelEmail.TabIndex = 22;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(107, 63);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(282, 23);
            this.textBoxNome.TabIndex = 21;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelNome.Location = new System.Drawing.Point(36, 66);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(50, 16);
            this.labelNome.TabIndex = 20;
            this.labelNome.Text = "Nome:";
            // 
            // labelRg
            // 
            this.labelRg.AutoSize = true;
            this.labelRg.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelRg.Location = new System.Drawing.Point(35, 138);
            this.labelRg.Name = "labelRg";
            this.labelRg.Size = new System.Drawing.Size(31, 16);
            this.labelRg.TabIndex = 18;
            this.labelRg.Text = "RG:";
            // 
            // labelCpf
            // 
            this.labelCpf.AutoSize = true;
            this.labelCpf.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelCpf.Location = new System.Drawing.Point(35, 175);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(35, 16);
            this.labelCpf.TabIndex = 16;
            this.labelCpf.Text = "CPF:";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelEstado.Location = new System.Drawing.Point(434, 241);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(26, 16);
            this.labelEstado.TabIndex = 14;
            this.labelEstado.Text = "UF:";
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Location = new System.Drawing.Point(506, 201);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(217, 23);
            this.textBoxCidade.TabIndex = 13;
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelCidade.Location = new System.Drawing.Point(434, 204);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(61, 16);
            this.labelCidade.TabIndex = 12;
            this.labelCidade.Text = "Cidade:";
            // 
            // textBoxBairro
            // 
            this.textBoxBairro.Location = new System.Drawing.Point(506, 168);
            this.textBoxBairro.Name = "textBoxBairro";
            this.textBoxBairro.Size = new System.Drawing.Size(217, 23);
            this.textBoxBairro.TabIndex = 11;
            // 
            // labelBairro
            // 
            this.labelBairro.AutoSize = true;
            this.labelBairro.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelBairro.Location = new System.Drawing.Point(434, 171);
            this.labelBairro.Name = "labelBairro";
            this.labelBairro.Size = new System.Drawing.Size(51, 16);
            this.labelBairro.TabIndex = 10;
            this.labelBairro.Text = "Bairro:";
            // 
            // textBoxComplemento
            // 
            this.textBoxComplemento.Location = new System.Drawing.Point(543, 135);
            this.textBoxComplemento.Name = "textBoxComplemento";
            this.textBoxComplemento.Size = new System.Drawing.Size(180, 23);
            this.textBoxComplemento.TabIndex = 9;
            // 
            // labelComplemento
            // 
            this.labelComplemento.AutoSize = true;
            this.labelComplemento.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelComplemento.Location = new System.Drawing.Point(434, 139);
            this.labelComplemento.Name = "labelComplemento";
            this.labelComplemento.Size = new System.Drawing.Size(103, 16);
            this.labelComplemento.TabIndex = 8;
            this.labelComplemento.Text = "Complemento:";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(506, 98);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(80, 23);
            this.textBoxNumero.TabIndex = 7;
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelNumero.Location = new System.Drawing.Point(434, 101);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(63, 16);
            this.labelNumero.TabIndex = 6;
            this.labelNumero.Text = "Número:";
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(506, 63);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(217, 23);
            this.textBoxEndereco.TabIndex = 5;
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelEndereco.Location = new System.Drawing.Point(434, 66);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(73, 16);
            this.labelEndereco.TabIndex = 4;
            this.labelEndereco.Text = "Endereço:";
            // 
            // labelCep
            // 
            this.labelCep.AutoSize = true;
            this.labelCep.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelCep.Location = new System.Drawing.Point(434, 34);
            this.labelCep.Name = "labelCep";
            this.labelCep.Size = new System.Drawing.Size(39, 16);
            this.labelCep.TabIndex = 2;
            this.labelCep.Text = "Cep:";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(107, 31);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.ReadOnly = true;
            this.textBoxCodigo.Size = new System.Drawing.Size(100, 23);
            this.textBoxCodigo.TabIndex = 1;
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelCodigo.Location = new System.Drawing.Point(35, 34);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(60, 16);
            this.labelCodigo.TabIndex = 0;
            this.labelCodigo.Text = "Código:";
            // 
            // tabPageConsulta
            // 
            this.tabPageConsulta.Controls.Add(this.buttonConsultaLimpar);
            this.tabPageConsulta.Controls.Add(this.dataGridViewClientes);
            this.tabPageConsulta.Controls.Add(this.button1);
            this.tabPageConsulta.Controls.Add(this.textBoxNomeConsulta);
            this.tabPageConsulta.Controls.Add(this.labelNomeConsulta);
            this.tabPageConsulta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageConsulta.ForeColor = System.Drawing.Color.Black;
            this.tabPageConsulta.Location = new System.Drawing.Point(4, 22);
            this.tabPageConsulta.Name = "tabPageConsulta";
            this.tabPageConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConsulta.Size = new System.Drawing.Size(982, 299);
            this.tabPageConsulta.TabIndex = 1;
            this.tabPageConsulta.Text = "Consulta";
            this.tabPageConsulta.UseVisualStyleBackColor = true;
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.AllowUserToAddRows = false;
            this.dataGridViewClientes.AllowUserToDeleteRows = false;
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Location = new System.Drawing.Point(9, 70);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.ReadOnly = true;
            this.dataGridViewClientes.Size = new System.Drawing.Size(967, 223);
            this.dataGridViewClientes.TabIndex = 25;
            this.dataGridViewClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClientes_CellClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(646, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 34);
            this.button1.TabIndex = 24;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxNomeConsulta
            // 
            this.textBoxNomeConsulta.Location = new System.Drawing.Point(98, 27);
            this.textBoxNomeConsulta.Name = "textBoxNomeConsulta";
            this.textBoxNomeConsulta.Size = new System.Drawing.Size(511, 27);
            this.textBoxNomeConsulta.TabIndex = 23;
            // 
            // labelNomeConsulta
            // 
            this.labelNomeConsulta.AutoSize = true;
            this.labelNomeConsulta.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelNomeConsulta.Location = new System.Drawing.Point(27, 30);
            this.labelNomeConsulta.Name = "labelNomeConsulta";
            this.labelNomeConsulta.Size = new System.Drawing.Size(61, 19);
            this.labelNomeConsulta.TabIndex = 22;
            this.labelNomeConsulta.Text = "Nome:";
            // 
            // buttonNovo
            // 
            this.buttonNovo.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonNovo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNovo.ForeColor = System.Drawing.Color.White;
            this.buttonNovo.Location = new System.Drawing.Point(38, 493);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(129, 54);
            this.buttonNovo.TabIndex = 2;
            this.buttonNovo.Text = "Novo";
            this.buttonNovo.UseVisualStyleBackColor = false;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonEditar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditar.ForeColor = System.Drawing.Color.White;
            this.buttonEditar.Location = new System.Drawing.Point(522, 493);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(129, 54);
            this.buttonEditar.TabIndex = 3;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonExcluir.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluir.ForeColor = System.Drawing.Color.White;
            this.buttonExcluir.Location = new System.Drawing.Point(360, 493);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(129, 54);
            this.buttonExcluir.TabIndex = 4;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = false;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSalvar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.ForeColor = System.Drawing.Color.White;
            this.buttonSalvar.Location = new System.Drawing.Point(199, 493);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(129, 54);
            this.buttonSalvar.TabIndex = 5;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // ButtonLimpar
            // 
            this.ButtonLimpar.BackColor = System.Drawing.SystemColors.Highlight;
            this.ButtonLimpar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLimpar.ForeColor = System.Drawing.Color.White;
            this.ButtonLimpar.Location = new System.Drawing.Point(684, 493);
            this.ButtonLimpar.Name = "ButtonLimpar";
            this.ButtonLimpar.Size = new System.Drawing.Size(129, 54);
            this.ButtonLimpar.TabIndex = 6;
            this.ButtonLimpar.Text = "Limpar";
            this.ButtonLimpar.UseVisualStyleBackColor = false;
            this.ButtonLimpar.Click += new System.EventHandler(this.ButtonLimpar_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonFechar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFechar.ForeColor = System.Drawing.Color.White;
            this.buttonFechar.Location = new System.Drawing.Point(845, 493);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(129, 54);
            this.buttonFechar.TabIndex = 7;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = false;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // buttonConsultaLimpar
            // 
            this.buttonConsultaLimpar.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonConsultaLimpar.ForeColor = System.Drawing.Color.White;
            this.buttonConsultaLimpar.Location = new System.Drawing.Point(829, 22);
            this.buttonConsultaLimpar.Name = "buttonConsultaLimpar";
            this.buttonConsultaLimpar.Size = new System.Drawing.Size(113, 34);
            this.buttonConsultaLimpar.TabIndex = 26;
            this.buttonConsultaLimpar.Text = "Limpar";
            this.buttonConsultaLimpar.UseVisualStyleBackColor = false;
            this.buttonConsultaLimpar.Click += new System.EventHandler(this.buttonConsultaLimpar_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 592);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.ButtonLimpar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonNovo);
            this.Controls.Add(this.tabControlClientes);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControlClientes.ResumeLayout(false);
            this.tabPageDadosPessoais.ResumeLayout(false);
            this.tabPageDadosPessoais.PerformLayout();
            this.tabPageConsulta.ResumeLayout(false);
            this.tabPageConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCadastroCliente;
        private System.Windows.Forms.TabControl tabControlClientes;
        private System.Windows.Forms.TabPage tabPageDadosPessoais;
        private System.Windows.Forms.Label labelCelular;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelRg;
        private System.Windows.Forms.Label labelCpf;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.TextBox textBoxCidade;
        private System.Windows.Forms.Label labelCidade;
        private System.Windows.Forms.TextBox textBoxBairro;
        private System.Windows.Forms.Label labelBairro;
        private System.Windows.Forms.TextBox textBoxComplemento;
        private System.Windows.Forms.Label labelComplemento;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.Label labelCep;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.TabPage tabPageConsulta;
        private System.Windows.Forms.ComboBox comBoxUf;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCep;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCelular;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefone;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCpf;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxRg;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxNomeConsulta;
        private System.Windows.Forms.Label labelNomeConsulta;
        private System.Windows.Forms.Button ButtonLimpar;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Button buttonConsultaLimpar;
    }
}