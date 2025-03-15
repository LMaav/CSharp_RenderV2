using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoRenderizador
{
    public partial class Form1 : Form
    {
        private TextBox txt_Quantidade, txt_Descricao;
        private DataGridView dtg_Mostrar;
        private bool renderizado = false, dataCriado = false;
        private List<Produto> produtos = new List<Produto>();

        public Form1()
        {
            InitializeComponent();
        }

        private void renderizar()
        {
            Label lbl_Quantidade = new Label();
            lbl_Quantidade.Name = "lbl_Quantidade";
            lbl_Quantidade.Text = "Quantidade";
            lbl_Quantidade.Location = new Point(29, 157);
            lbl_Quantidade.Width = 92;
            lbl_Quantidade.Font = new Font("Microsoft Sans Serif",12);

            Label lbl_Descricao = new Label();
            lbl_Descricao.Name = "lbl_Descricao";
            lbl_Descricao.Text = "Descrição";
            lbl_Descricao.Location = new Point(29, 214);
            lbl_Descricao.Width = 80;
            lbl_Descricao.Font = new Font("Microsoft Sans Serif", 12);
            this.Controls.Add(lbl_Quantidade);
            this.Controls.Add(lbl_Descricao);
            

            /*TextBox*/ txt_Quantidade = new TextBox
            {
                Name = "txt_Quantidade",
                Location = new Point(143, 157),
                Width = 125,
                Font = new Font("Microsoft Sans Serif", 12),
                BackColor = Color.Snow,
                TabIndex = 3
            };

            /*TextBox*/ txt_Descricao = new TextBox
            {
                Name = "txt_Descricao",
                Location = new Point(143, 211),
                Width = 125,
                Font = new Font("Microsoft Sans Serif",12),
                BackColor = Color.Snow,
                TabIndex = 4
            };
            this.Controls.Add(txt_Quantidade);
            this.Controls.Add(txt_Descricao);


            Button btn_Salvar = new Button
            {
                Name = "btn_Salvar",
                Text = "Salvar",
                Location = new Point(288, 157),
                Size = new Size(114, 80),
                Font = new Font("Microsoft Sans Serif", 15),
                BackColor = Color.Snow,
                TabIndex = 5
            };
            btn_Salvar.Click += (s, e) =>
            {
                String nome = txt_Nome.Text;
                double preco;
                int qtd = 1;
                String desc = txt_Descricao.Text;

                
                if (double.TryParse(txt_Preco.Text, out preco) && int.TryParse(txt_Quantidade.Text, out qtd) && !string.IsNullOrEmpty(txt_Nome.Text))
                {
                    if (dataCriado == false)
                    {
                        dtg_Mostrar = new DataGridView
                        {
                            Name = "dtg_Mostrar",
                            Location = new Point(33, 291),
                            Size = new Size(369, 147),
                            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                        };
                        this.Controls.Add(dtg_Mostrar);
                        dataCriado = true;
                    }
                    produtos.Add(new Produto(txt_Nome.Text, preco, qtd, txt_Descricao.Text));
                    AtualizarLista();
                    Limpar();
                    Produto prod = new Produto(nome, preco, qtd, desc);
                    double valorEstoque = prod.calcular_estoque();
                    MessageBox.Show("Produto Cadastrado, Valor em Estoque: " + valorEstoque.ToString("R$0.00"));

                }
                else
                {
                    MessageBox.Show("Insira os dados corretamente");
                }
            };
            this.Controls.Add(btn_Salvar);

            renderizado = true;
        }

        private void btn_Criar_Click(object sender, EventArgs e)
        {
            if (renderizado == false)
            {
                this.renderizar();
            }
            else
            {
                MessageBox.Show("Já renderizado");
            }
        }

        private void AtualizarLista()
        {
            dtg_Mostrar.DataSource = null;
            dtg_Mostrar.DataSource = produtos.Select(p => new { p.Nome, p.Valor, p.Quantidade, p.Descricao, ValorTotal = p.calcular_estoque() }).ToList();

           
        }
        private void Limpar()
        {
            txt_Nome.Text = string.Empty;
            txt_Preco.Text = string.Empty;
            txt_Descricao.Text = string.Empty;
            txt_Quantidade.Text = string.Empty;
            txt_Nome.Focus();

        }
    }
}
