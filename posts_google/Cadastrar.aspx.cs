using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cadastrar : System.Web.UI.Page
{

    protected void btnCadastrar_Click(object sender, EventArgs e)
    {
        using (SqlConnection con = new SqlConnection("Server=AME0556343W10-1\\SQLEXPRESS;Database=db_google;Trusted_Connection=Yes;"))
        {
            using (SqlCommand cmd = new SqlCommand("Insert into tb_posts (titulo, autor, conteudo) VALUES (@titulo, @autor, @conteudo)", con))
            {
                cmd.Parameters.AddWithValue("titulo", txtbTitulo.Text);
                cmd.Parameters.AddWithValue("autor", txtbAutor.Text);
                cmd.Parameters.AddWithValue("conteudo", txtbConteudo.Text);
                try
                {
                    con.Open();
                    if (cmd.ExecuteNonQuery() > -1)
                    {
                        lblMensagem.Text = "Post cadastrado com sucesso.";
                    }
                }
                catch (Exception ex)
                {
                    lblMensagem.Text = "Erro ao Cadastrar o Post.\n" + ex.Message;
                }
                finally
                {
                    con.Close();
                }
                }
            }
        }
    }