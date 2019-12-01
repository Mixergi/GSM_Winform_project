using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;


namespace onelightmart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection conn;
        MySqlDataAdapter dataAdapter;
        DataSet dataSet;

        string selected_customer_ID;
        string selected_product_numer;
        string selected_oreder_number;


        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection("server=localhost;port=3306;database=평택;uid=C#Project;pwd=1234");
                conn.Open();

                dataSet = new DataSet();

                dataGridView1.ReadOnly = true;
                dataGridView2.ReadOnly = true;
                dataGridView3.ReadOnly = true;

                dataAdapter = new MySqlDataAdapter("SELECT * FROM 고객;", conn);
                dataAdapter.Fill(dataSet, "고객");
                dataGridView1.DataSource = dataSet.Tables["고객"];

                dataAdapter = new MySqlDataAdapter("SELECT * FROM 제품", conn);
                dataAdapter.Fill(dataSet, "제품");
                dataGridView2.DataSource = dataSet.Tables["제품"];

                dataAdapter = new MySqlDataAdapter("SELECT * FROM 주문", conn);
                dataAdapter.Fill(dataSet, "주문");
                dataGridView3.DataSource = dataSet.Tables["주문"];
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }

        
        #region DataGridView 선택시 textbox 채움

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            customer_ID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            customer_name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            customer_age.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            customer_grade.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            customer_job.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            customer_point.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

            selected_customer_ID = customer_ID.Text;
        }

        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            product_number.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            product_name.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            product_stock.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            product_price.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            product_manufacturer.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();

            selected_product_numer = product_number.Text;
        }

        private void DataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            order_number.Text = dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString();
            order_customer.Text = dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString();
            ordered_product.Text = dataGridView3.Rows[e.RowIndex].Cells[2].Value.ToString();
            order_quantity.Text = dataGridView3.Rows[e.RowIndex].Cells[3].Value.ToString();
            order_addess.Text = dataGridView3.Rows[e.RowIndex].Cells[4].Value.ToString();
            order_date.Text = dataGridView3.Rows[e.RowIndex].Cells[5].Value.ToString();

            selected_oreder_number = order_number.Text;
        }

        #endregion

        private void Customer_search_btn_Click(object sender, EventArgs e)
        {
            DataTable dt = dataSet.Tables["고객"].Copy();
            DataView dv = new DataView(dt);

            #region 대충 조건 추가하는 구문

            if (customer_ID.Text != "")
            {
                dv.RowFilter = $"고객아이디='{customer_ID.Text}'";
            }
            if (customer_name.Text != "")
            {
                dv.RowFilter = $"고객이름='{customer_name.Text}'";
            }
            if (customer_age.Text != "")
            {
                dv.RowFilter = $"나이={customer_age.Text}";
            }
            if (customer_grade.Text != "")
            {
                dv.RowFilter = $"등급='{customer_grade.Text}'";
            }
            if (customer_job.Text != "")
            {
                dv.RowFilter = $"직업='{customer_job.Text}'";
            }
            if (customer_point.Text != "")
            {
                dv.RowFilter = $"적립금={customer_point.Text}";
            }
            #endregion

            dataSet.Tables["고객"].Clear();
            dataSet.Tables["고객"].Merge(dv.ToTable());
        }

        private void Customer_add_btn_Click(object sender, EventArgs e)
        {

            #region NOT NULL 부분 확인
            if (customer_ID.Text == "")
            {
                MessageBox.Show("고객아이디는 NULL값일 수 없습니다.");
            }
            else if (customer_name.Text == "")
            {
                MessageBox.Show("고객이름는 NULL값일 수 없습니다.");
            }
            else if (customer_grade.Text == "")
            {
                MessageBox.Show("등급은 NULL값일 수 없습니다.");
            }
            #endregion

            else
            {
                #region  넣을 데이터 추가
                string data = "", inserted_data = "";
                if (customer_ID.Text != "")
                {
                    inserted_data += " 고객아이디";
                    data += $"'{customer_ID.Text}'";
                }
                if (customer_name.Text != "")
                {
                    if (data != "")
                    {
                        inserted_data += ",";
                        data += ",";
                    }
                    inserted_data += $" 고객이름";
                    data += $" '{customer_name.Text}'";
                }
                if (customer_age.Text != "")
                {
                    if (data != "")
                    {
                        inserted_data += ",";
                        data += ",";
                    }
                    inserted_data += $" 나이";
                    data += $" {customer_age.Text}";
                }
                if (customer_grade.Text != "")
                {
                    if (data != "")
                    {
                        inserted_data += ",";
                        data += ",";
                    }
                    inserted_data += $" 등급";
                    data += $" '{customer_grade.Text}'";
                }
                if (customer_job.Text != "")
                {
                    if (data != "")
                    {
                        inserted_data += ",";
                        data += " ,";
                    }
                    data += $" '{customer_job.Text}'";
                    inserted_data += $" 직업";
                }
                if (customer_point.Text != "")
                {
                    if (data != "")
                    {
                        inserted_data += ",";
                        data += ",";
                    }
                    data += $" {customer_point.Text}";
                    inserted_data += $" 적립금";
                }
                #endregion
                try
                {
                    MySqlCommand command = new MySqlCommand("INSERT INTO 고객(" + inserted_data + ") VALUES (" + data + ");", conn);
                    command.ExecuteNonQuery();
                    customer_search_clear_btn.PerformClick();
                }
                catch(Exception E)
                {
                    MessageBox.Show(E.Message);
                }
            }
        }

        private void Customer_remove_btn_Click(object sender, EventArgs e)
        {
            string require = "";

            #region 대충 조건 추가하는 구문

            if (customer_ID.Text != "")
            {
                require += $" 고객아이디='{customer_ID.Text}'";
            }
            if (customer_name.Text != "")
            {
                if (require != "")
                {
                    require += " and";
                }
                require += $" 고객이름='{customer_grade.Text}'";
            }
            if (customer_age.Text != "")
            {
                if (require != "")
                {
                    require += " and";
                }
                require += $" 나이={customer_age.Text}";
            }
            if (customer_grade.Text != "")
            {
                if (require != "")
                {
                    require += " and";
                }
                require += $" 등급='{customer_grade.Text}'";
            }
            if (customer_job.Text != "")
            {
                if (require != "")
                {
                    require += " and";
                }
                require += $" 직업='{customer_job.Text}'";
            }
            if (customer_point.Text != "")
            {
                if (require != "")
                {
                    require += " and";
                }
                require += $" 적립금={customer_point.Text}";
            }

            #endregion

            MySqlCommand command = new MySqlCommand("DELETE FROM 고객 WHERE" + require + ';', conn);
            command.ExecuteNonQuery();
            customer_search_clear_btn.PerformClick();
        }

        private void Customer_update_btn_Click(object sender, EventArgs e)
        {
            string update_content = "";

            #region 대충 바꾸는 내용 추가하는 구문

            if (customer_ID.Text != "")
            {
                update_content += $" 고객아이디='{customer_ID.Text}'";
            }
            if (customer_name.Text != "")
            {
                if (update_content != "")
                {
                    update_content += " , ";
                }
                update_content += $" 고객이름='{customer_name.Text}'";
            }
            if (customer_age.Text != "")
            {
                if (update_content != "")
                {
                    update_content += " , ";
                }
                update_content += $" 나이={customer_age.Text}";
            }
            if (customer_grade.Text != "")
            {
                if (update_content != "")
                {
                    update_content += " , ";
                }
                update_content += $" 등급='{customer_grade.Text}'";
            }
            if (customer_job.Text != "")
            {
                if (update_content != "")
                {
                    update_content += " , ";
                }
                update_content += $" 직업='{customer_job.Text}'";
            }
            if (customer_point.Text != "")
            {
                if (update_content != "")
                {
                    update_content += " , ";
                }
                update_content += $" 적립금={customer_point.Text}";
            }

            #endregion

            if (update_content != "")
            {
                MySqlCommand command = new MySqlCommand("UPDATE 고객 SET " + update_content + " WHERE 고객아이디='" + selected_customer_ID + "';", conn);
                command.ExecuteNonQuery();
                customer_search_clear_btn.PerformClick();
            }
        }

        private void Customer_search_clear_btn_Click(object sender, EventArgs e)
        {
            dataSet.Tables["고객"].Clear();
            dataAdapter = new MySqlDataAdapter("SELECT * FROM 고객;", conn);
            dataAdapter.Fill(dataSet, "고객");
            dataGridView1.DataSource = dataSet.Tables["고객"];

            customer_ID.Text = "";
            customer_name.Text = "";
            customer_age.Text = "";
            customer_grade.Text = "";
            customer_job.Text = "";
            customer_point.Text = "";

            selected_customer_ID = "";
        }

        private void Product_search_btn_Click(object sender, EventArgs e)
        {
            DataTable dt = dataSet.Tables["제품"].Copy();
            DataView dv = new DataView(dt);

            #region 대충 조건 추가하는 구문

            if (product_number.Text != "")
            {
                dv.RowFilter = $"제품번호='{product_number.Text}'";
            }
            if (product_name.Text != "")
            {
                dv.RowFilter = $"제품명='{product_name.Text}'";
            }
            if (product_stock.Text != "")
            {
                dv.RowFilter = $"재고량={product_stock.Text}";
            }
            if (product_price.Text != "")
            {
                dv.RowFilter = $"단가={product_price.Text}";
            }
            if (product_manufacturer.Text != "")
            {
                dv.RowFilter = $"제조업체='{product_manufacturer.Text}'";
            }
            #endregion

            dataSet.Tables["제품"].Clear();
            dataSet.Tables["제품"].Merge(dv.ToTable());
        }

        private void Product_add_btn_Click(object sender, EventArgs e)
        {
            #region NOT NULL 부분 확인
            if (product_number.Text == "")
            {
                MessageBox.Show("제품번호는 NULL값일 수 없습니다.");
                return;
            }
            #endregion

            #region  넣을 데이터 추가
            string data = "", inserted_data = "";
            if (product_number.Text != "")
            {
                inserted_data += " 제품번호";
                data += $"'{product_number.Text}'";
            }
            if (product_name.Text != "")
            {
                if (data != "")
                {
                    inserted_data += ",";
                    data += ",";
                }
                inserted_data += $" 제품명";
                data += $" '{product_name.Text}'";
            }
            if (product_stock.Text != "")
            {
                if (data != "")
                {
                    inserted_data += ",";
                    data += ",";
                }
                inserted_data += $" 재고량";
                data += $" {product_stock.Text}";
            }
            if (product_price.Text != "")
            {
                if (data != "")
                {
                    inserted_data += ",";
                    data += ",";
                }
                inserted_data += $" 단가";
                data += $" '{product_price.Text}'";
            }
            if (product_manufacturer.Text != "")
            {
                if (data != "")
                {
                    inserted_data += ",";
                    data += " ,";
                }
                data += $" '{product_manufacturer.Text}'";
                inserted_data += $" 제조업체";
            }
            #endregion

            try
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO 제품(" + inserted_data + ") VALUES (" + data + ");", conn);
                command.ExecuteNonQuery();
                product_search_btn.PerformClick();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void Product_remove_btn_Click(object sender, EventArgs e)
        {
            string require = "";

            #region 대충 조건 추가하는 구문

            if (product_number.Text != "")
            {
                require += $" 제품번호='{product_number.Text}'";
            }
            if (product_name.Text != "")
            {
                if (require != "")
                {
                    require += " and";
                }
                require += $" 제품명='{product_name.Text}'";
            }
            if (product_stock.Text != "")
            {
                if (require != "")
                {
                    require += " and";
                }
                require += $" 재고량={product_stock.Text}";
            }
            if (product_price.Text != "")
            {
                if (require != "")
                {
                    require += " and";
                }
                require += $" 단가='{product_price.Text}'";
            }
            if (product_manufacturer.Text != "")
            {
                if (require != "")
                {
                    require += " and";
                }
                require += $" 제조업체='{product_manufacturer.Text}'";
            }

            #endregion

            MySqlCommand command = new MySqlCommand("DELETE FROM 제품 WHERE" + require + ';', conn);
            command.ExecuteNonQuery();
            product_search_clear_btn.PerformClick();
        }

        private void Product_update_btn_Click(object sender, EventArgs e)
        {
            string update_content = "";

            #region 대충 바꾸는 내용 추가하는 구문

            if (product_number.Text != "")
            {
                update_content += $" 제품번호='{product_number.Text}'";
            }
            if (product_name.Text != "")
            {
                if (update_content != "")
                {
                    update_content += " , ";
                }
                update_content += $" 제품명='{product_name.Text}'";
            }
            if (product_stock.Text != "")
            {
                if (update_content != "")
                {
                    update_content += " , ";
                }
                update_content += $" 재고량={product_stock.Text}";
            }
            if (product_price.Text != "")
            {
                if (update_content != "")
                {
                    update_content += " , ";
                }
                update_content += $" 단가='{product_price.Text}'";
            }
            if (product_manufacturer.Text != "")
            {
                if (update_content != "")
                {
                    update_content += " , ";
                }
                update_content += $" 제조업체='{product_manufacturer.Text}'";
            }

            #endregion

            if (update_content != "")
            {
                MySqlCommand command = new MySqlCommand("UPDATE 제품 SET " + update_content + " WHERE 제품번호='" + selected_product_numer + "';", conn);
                command.ExecuteNonQuery();
                product_search_clear_btn.PerformClick();
            }
        }

        private void Product_search_clear_btn_Click(object sender, EventArgs e)
        {
            dataSet.Tables["제품"].Clear();
            dataAdapter = new MySqlDataAdapter("SELECT * FROM 제품;", conn);
            dataAdapter.Fill(dataSet, "제품");
            dataGridView1.DataSource = dataSet.Tables["제품"];

            product_number.Text = "";
            product_name.Text = "";
            product_stock.Text = "";
            product_price.Text = "";
            product_manufacturer.Text = "";

            selected_product_numer = "";
        }

        private void Order_search_btn_Click(object sender, EventArgs e)
        {
            DataTable dt = dataSet.Tables["주문"].Copy();
            DataView dv = new DataView(dt);

            #region 대충 조건 추가하는 구문

            if (order_number.Text != "")
            {
                dv.RowFilter = $"주문번호='{order_number.Text}'";
            }
            if (order_customer.Text != "")
            {
                dv.RowFilter = $"주문고객='{order_customer.Text}'";
            }
            if (ordered_product.Text != "")
            {
                dv.RowFilter = $"주문제품='{ordered_product.Text}'";
            }
            if (order_quantity.Text != "")
            {
                dv.RowFilter = $"수량='{order_quantity.Text}'";
            }
            if (order_addess.Text != "")
            {
                dv.RowFilter = $"배송지='{order_addess.Text}'";
            }
            if (order_date.Text != "")
            {
                dv.RowFilter = $"주문일자='{order_date.Text}'";
            }
            #endregion

            dataSet.Tables["주문"].Clear();
            dataSet.Tables["주문"].Merge(dv.ToTable());
        }

        private void Order_add_btn_Click(object sender, EventArgs e)
        {
            #region NOT NULL 부분 확인
            if (order_number.Text == "")
            {
                MessageBox.Show("주문번호 NULL값일 수 없습니다.");
                return;
            }
            #endregion

            #region  넣을 데이터 추가
            string data = "", inserted_data = "";
            if (order_number.Text != "")
            {
                inserted_data += " 주문번호";
                data += $"'{order_number.Text}'";
            }
            if (order_customer.Text != "")
            {
                if (data != "")
                {
                    inserted_data += ",";
                    data += ",";
                }
                inserted_data += $" 주문고객";
                data += $" '{order_customer.Text}'";
            }
            if (ordered_product.Text != "")
            {
                if (data != "")
                {
                    inserted_data += ",";
                    data += ",";
                }
                inserted_data += $" 주문제품";                  
                data += $" '{ordered_product.Text}'";
            }
            if (order_quantity.Text != "")
            {
                if (data != "")
                {
                    inserted_data += ",";
                    data += ",";
                }
                inserted_data += $" 수량";
                data += $" {order_quantity.Text}";
            }
            if (order_addess.Text != "")
            {
                if (data != "")
                {
                    inserted_data += ",";
                    data += " ,";
                }
                data += $" '{order_addess.Text}'";
                inserted_data += $" 배송지";
            }
            if (order_date.Text != "")
            {
                if (data != "")
                {
                    inserted_data += ",";
                    data += ",";
                }
                string text = order_date.Text;
                data += $" '{text.Substring(0,4)}/{text.Substring(5, 2)}/{text.Substring(8, 2)}'";
                inserted_data += $" 주문일자";
            }
            #endregion
            try
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO 주문(" + inserted_data + ") VALUES (" + data + ");", conn);
                command.ExecuteNonQuery();
                order_search_clear_btn.PerformClick();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void Order_remove_btn_Click(object sender, EventArgs e)
        {
            string require = "";

            #region 대충 조건 추가하는 구문

            if (order_number.Text != "")
            {
                require += $" 주문번호='{order_number.Text}'";
            }
            if (order_customer.Text != "")
            {
                if (require != "")
                {
                    require += " and";
                }
                require += $" 주문고객='{order_customer.Text}'";
            }
            if (ordered_product.Text != "")
            {
                if (require != "")
                {
                    require += " and";
                }
                require += $" 주문제품='{ordered_product.Text}'";
            }
            if (order_quantity.Text != "")
            {
                if (require != "")
                {
                    require += " and";
                }
                require += $" 수량='{order_quantity.Text}'";
            }
            if (order_addess.Text != "")
            {
                if (require != "")
                {
                    require += " and";
                }
                require += $" 배송지='{order_addess.Text}'";
            }
            if (order_date.Text != "")
            {
                if (require != "")
                {
                    require += " and";
                }
                string text = order_date.Text;
                require += $" 주문일자='{text.Substring(0, 4)}/{text.Substring(5, 2)}/{text.Substring(8, 2)}'";
            }

            #endregion

            MySqlCommand command = new MySqlCommand("DELETE FROM 주문 WHERE" + require + ';', conn);
            command.ExecuteNonQuery();
            order_search_clear_btn.PerformClick();
        }

        private void Order_update_btn_Click(object sender, EventArgs e)
        {
            string update_content = "";

            #region 대충 바꾸는 내용 추가하는 구문

            if (order_number.Text != "")
            {
                update_content += $" 주문번호='{order_number.Text}'";
            }
            if (order_customer.Text != "")
            {
                if (update_content != "")
                {
                    update_content += " , ";
                }
                update_content += $" 주문고객='{order_customer.Text}'";
            }
            if (ordered_product.Text != "")
            {
                if (update_content != "")
                {
                    update_content += " , ";
                }
                update_content += $" 주문제품='{ordered_product.Text}'";
            }
            if (order_quantity.Text != "")
            {
                if (update_content != "")
                {
                    update_content += " , ";
                }
                update_content += $" 수량={order_quantity.Text}";
            }
            if (order_addess.Text != "")
            {
                if (update_content != "")
                {
                    update_content += " , ";
                }
                update_content += $" 배송지='{order_addess.Text}'";
            }
            if (order_date.Text != "")
            {
                if (update_content != "")
                {
                    update_content += " , ";
                }
                string text = order_date.Text;
                update_content += $" 주문일자='{text.Substring(0, 4)}/{text.Substring(5, 2)}/{text.Substring(8, 2)}'";
            }

            #endregion

            if (update_content != "")
            {
                MySqlCommand command = new MySqlCommand("UPDATE 주문 SET " + update_content + " WHERE 주문번호='" + selected_oreder_number + "';", conn);
                MessageBox.Show(command.CommandText);
                command.ExecuteNonQuery();
                order_search_clear_btn.PerformClick();
            }
        }

        private void Order_search_clear_btn_Click(object sender, EventArgs e)
        {
            dataSet.Tables["주문"].Clear();
            dataAdapter = new MySqlDataAdapter("SELECT * FROM 주문;", conn);
            dataAdapter.Fill(dataSet, "주문");
            dataGridView1.DataSource = dataSet.Tables["주문"];

            order_number.Text = "";
            order_customer.Text = "";
            ordered_product.Text = "";
            order_quantity.Text = "";
            order_addess.Text = "";
            order_date.Text = "";

            selected_oreder_number = "";
        }
    }
}