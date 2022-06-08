using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace CeciliaNigro
{
    class AcessoDadoscs
    {
        private static SQLiteConnection conexao;

        private static SQLiteConnection ConectaBanco()
        {
            conexao = new SQLiteConnection("Data Source = C:\\Users\\cecin\\source\\repos\\CeciliaNigro\\CeciliaNigro\\Banco\\acme.db");
            conexao.Open();
            return conexao;
        }


        public static void Inserir( Cadastro c)
        {
            try
            {
                var conn = ConectaBanco();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO TB_VOO (DATA_VOO , CUSTO, DISTANCIA, CAPTURA, NIVEL_DOR) VALUES (@DATA_VOO, @CUSTO, @DISTANCIA, @CAPTURA, @NIVEL_DOR )";
                cmd.Parameters.AddWithValue("@DATA_VOO", c.DATA_VOO);
                cmd.Parameters.AddWithValue("@CUSTO", c.CUSTO);
                cmd.Parameters.AddWithValue("@DISTANCIA", c.DISTANCIA);
                cmd.Parameters.AddWithValue("@CAPTURA", c.CAPTURA);
                cmd.Parameters.AddWithValue("@NIVEL_DOR", c.NIVEL_DOR);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastrado com sucesso");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar");
              
            }
        }

        public static void Atualizar(Cadastro c)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var conn = ConectaBanco();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE TB_VOO SET DATA_VOO ='"+c.DATA_VOO+"' , CUSTO ='"+c.CUSTO+"', DISTANCIA='"+c.DISTANCIA+"', CAPTURA='"+c.CAPTURA+"', NIVEL_DOR='"+c.NIVEL_DOR+"' WHERE ID_VOO = "+c.ID_VOO;
                da = new SQLiteDataAdapter(cmd.CommandText, conn);

                cmd.ExecuteNonQuery();
                conn.Clone();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static void Excluir(string Id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var conn = ConectaBanco();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM TB_VOO WHERE ID_VOO =" + Id;
                da = new SQLiteDataAdapter(cmd.CommandText, conn);

                cmd.ExecuteNonQuery();
                conn.Clone();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ExibirGrid()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var conn = ConectaBanco();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT ID_VOO AS 'ID', DATA_VOO AS 'DATA', CAPTURA, NIVEL_DOR AS 'NIVEL DE DOR' FROM TB_VOO";
                da = new SQLiteDataAdapter(cmd.CommandText, conn);
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable SelecionarGrid(string Id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var conn = ConectaBanco();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM TB_VOO WHERE ID_VOO = "+Id;
                da = new SQLiteDataAdapter(cmd.CommandText, conn);
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
