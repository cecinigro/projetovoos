using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CeciliaNigro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            Carrega();
            Limpar();
        }

        public void Carrega()
        {
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;

            GridDados.DataSource = AcessoDadoscs.ExibirGrid();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                txtCusto.Text = String.Empty;
                txtDistancia.Text = String.Empty;
                txtNivel.Text = String.Empty;
                radioNao.Checked = false;
                radioSim.Checked = false;
                dtData.Value = DateTime.Now;
                btnCancelar.Enabled = false;
                btnSalvar.Enabled = false;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtCusto.Text) || String.IsNullOrEmpty(txtDistancia.Text) || String.IsNullOrEmpty(txtNivel.Text) || String.IsNullOrEmpty(dtData.Text))
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                Cadastro cadastro = new Cadastro();

                cadastro.DATA_VOO = Convert.ToDateTime(dtData.Text);
                cadastro.CUSTO = Convert.ToDouble(txtCusto.Text);
                cadastro.DISTANCIA = Convert.ToInt32(txtDistancia.Text);
                cadastro.NIVEL_DOR = Convert.ToInt32(txtNivel.Text);
                if (radioNao.Checked == true)
                {
                    cadastro.CAPTURA = Convert.ToChar(radioNao.Text);
                }

                if (radioSim.Checked == true)
                {
                    cadastro.CAPTURA = Convert.ToChar(radioSim.Text);
                }
                
                AcessoDadoscs.Inserir(cadastro);
                btnCancelar.Enabled = false;
                btnSalvar.Enabled = false;
                Limpar();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                Limpar();
                btnCancelar.Enabled = false;
                btnSalvar.Enabled = false;
                AcessoDadoscs.Excluir(txtID.Text);
                GridDados.Rows.Remove(GridDados.CurrentRow);
               
            }

                

        }

        private void txtCusto_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void Limpar()
        {
            txtCusto.Text = String.Empty;
            txtDistancia.Text = String.Empty;
            txtNivel.Text = String.Empty;
            radioNao.Checked = false;
            radioSim.Checked = false;
            dtData.Value = DateTime.Now;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int linha = GridDados.SelectedRows[0].Index;

            Cadastro c = new Cadastro();
            c.DATA_VOO = Convert.ToDateTime(dtData.Text);
            c.CUSTO = Convert.ToInt32(txtCusto.Text);
            c.DISTANCIA = Convert.ToInt32(txtDistancia.Text);
            if (radioNao.Checked == true)
            {
                c.CAPTURA = Convert.ToChar(radioNao.Text);
            }
            else
            {
                c.CAPTURA = Convert.ToChar(radioSim.Text);
            }

            AcessoDadoscs.Atualizar(c);
            GridDados[0, linha].Value = txtID.Text;
            GridDados[1, linha].Value = dtData.Text;
            GridDados[3, linha].Value = txtNivel.Text;

            if (radioNao.Checked == true)
            {
                GridDados[2, linha].Value = Convert.ToChar(radioNao.Text);
            }
            else
            {
                GridDados[2, linha].Value = Convert.ToChar(radioSim.Text);
            }

            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            
        }

        private void GridDados_SelectionChanged(object sender, EventArgs e)
        {
            Limpar();
            DataGridView grid = (DataGridView)sender;
            int contlinhas = grid.SelectedRows.Count;
            if (contlinhas > 0 )
            {
                DataTable dt = new DataTable(); 
                string Id = grid.SelectedRows[0].Cells[0].Value.ToString();

                dt = AcessoDadoscs.SelecionarGrid(Id);
                txtID.Text = dt.Rows[0].Field<Int64>("ID_VOO").ToString();
                dtData.Text = dt.Rows[0].Field<DateTime>("DATA_VOO").ToString();
                txtCusto.Text = dt.Rows[0].Field<Decimal>("CUSTO").ToString();
                txtDistancia.Text = dt.Rows[0].Field<Int32>("DISTANCIA").ToString();
                txtNivel.Text = dt.Rows[0].Field<Int32>("DISTANCIA").ToString();


            }

            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;

        }

        private void GridDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
