﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace carWash
{
    public partial class Form3 : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;

        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textBox1.Visible = true;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button1.Visible = false;
            button6.Visible = false;
            button8.Visible = true;
            button9.Visible = false;
            dataGridView1.Visible = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false;
            label2.Visible = false;
            textBox2.Visible = false;
            label3.Visible = false;
            textBox3.Visible = false;
            label4.Visible = false;
            textBox4.Visible = false;
            label5.Visible = false;
            textBox5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            dataGridView1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textBox1.Visible = true;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button1.Visible = false;
            button6.Visible = false;
            dataGridView1.Visible = false;

            label2.Visible = true;
            textBox2.Visible = true;
            label3.Visible = true;
            textBox3.Visible = true;
            label4.Visible = true;
            textBox4.Visible = true;
            label5.Visible = true;
            textBox5.Visible = true;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textBox1.Visible = true;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button1.Visible = false;
            button6.Visible = false;
            dataGridView1.Visible = false;

            label2.Visible = true;
            textBox2.Visible = true;
            label3.Visible = true;
            textBox3.Visible = true;
            label4.Visible = true;
            textBox4.Visible = true;
            label5.Visible = true;
            textBox5.Visible = true;
            button7.Visible = true;
            button8.Visible = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button1.Visible = false;
            dataGridView1.Visible = false;

            label2.Visible = true;
            textBox2.Visible = true;
            label3.Visible = true;
            textBox3.Visible = true;
            label4.Visible = true;
            textBox4.Visible = true;
            label5.Visible = true;
            textBox5.Visible = true;
            button6.Visible = true;

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=carwashdb;Uid=root;Pwd=root;");
                strSQL = "INSERT INTO tb_carro (Car_Nome, Car_Placa, Car_Cor, Car_Marca) VALUES (@NOME, @PLACA, @COR, @MARCA)";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@NOME", textBox2.Text);
                comando.Parameters.AddWithValue("@PLACA", textBox3.Text);
                comando.Parameters.AddWithValue("@COR", textBox4.Text);
                comando.Parameters.AddWithValue("@MARCA", textBox5.Text);

                conexao.Open();

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=carwashdb;Uid=root;Pwd=root;");
                strSQL = "UPDATE tb_carro SET Car_Nome = @NOME, Car_Placa = @PLACA, Car_Cor = @COR, Car_Marca = @MARCA WHERE Car_ID = @ID";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@ID", textBox1.Text);
                comando.Parameters.AddWithValue("@NOME", textBox2.Text);
                comando.Parameters.AddWithValue("@PLACA", textBox3.Text);
                comando.Parameters.AddWithValue("@COR", textBox4.Text);
                comando.Parameters.AddWithValue("@MARCA", textBox5.Text);

                conexao.Open();

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=carwashdb;Uid=root;Pwd=root;");
                strSQL = "DELETE FROM tb_carro WHERE Car_ID = @ID";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@ID", textBox1.Text);

                conexao.Open();

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=carwashdb;Uid=root;Pwd=root;");
                strSQL = "SELECT * FROM tb_carro WHERE Car_ID = @ID";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@ID", textBox1.Text);

                conexao.Open();

                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    textBox2.Text = Convert.ToString(dr["Car_Nome"]);
                    textBox3.Text = Convert.ToString(dr["Car_Placa"]);
                    textBox4.Text = Convert.ToString(dr["Car_Cor"]);
                    textBox5.Text = Convert.ToString(dr["Car_Marca"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button1.Visible = false;
            button6.Visible = false;
            button9.Visible = false;
            dataGridView1.Visible = true;

            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=carwashdb;Uid=root;Pwd=root;");
                strSQL = "SELECT * FROM tb_carro";

                da = new MySqlDataAdapter(strSQL, conexao);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }
    }
}
