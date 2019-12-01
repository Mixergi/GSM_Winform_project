namespace onelightmart
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.customer_search_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.customer_point = new System.Windows.Forms.TextBox();
            this.customer_job = new System.Windows.Forms.TextBox();
            this.customer_grade = new System.Windows.Forms.TextBox();
            this.customer_age = new System.Windows.Forms.TextBox();
            this.customer_name = new System.Windows.Forms.TextBox();
            this.customer_ID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.customer_add_btn = new System.Windows.Forms.Button();
            this.customer_remove_btn = new System.Windows.Forms.Button();
            this.customer_update_btn = new System.Windows.Forms.Button();
            this.customer_search_clear_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.product_manufacturer = new System.Windows.Forms.TextBox();
            this.product_price = new System.Windows.Forms.TextBox();
            this.product_stock = new System.Windows.Forms.TextBox();
            this.product_name = new System.Windows.Forms.TextBox();
            this.product_number = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.product_search_btn = new System.Windows.Forms.Button();
            this.product_add_btn = new System.Windows.Forms.Button();
            this.product_remove_btn = new System.Windows.Forms.Button();
            this.product_update_btn = new System.Windows.Forms.Button();
            this.product_search_clear_btn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.order_date = new System.Windows.Forms.TextBox();
            this.order_addess = new System.Windows.Forms.TextBox();
            this.order_quantity = new System.Windows.Forms.TextBox();
            this.ordered_product = new System.Windows.Forms.TextBox();
            this.order_customer = new System.Windows.Forms.TextBox();
            this.order_number = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.order_search_btn = new System.Windows.Forms.Button();
            this.order_add_btn = new System.Windows.Forms.Button();
            this.order_remove_btn = new System.Windows.Forms.Button();
            this.order_update_btn = new System.Windows.Forms.Button();
            this.order_search_clear_btn = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.SystemColors.GrayText;
            this.title.Font = new System.Drawing.Font("나눔바른펜", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.title.Location = new System.Drawing.Point(222, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(784, 81);
            this.title.TabIndex = 1;
            this.title.Text = "       한빛 마트 데이터베이스      \r\n";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 102);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1221, 557);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.customer_search_btn);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.customer_add_btn);
            this.tabPage1.Controls.Add(this.customer_remove_btn);
            this.tabPage1.Controls.Add(this.customer_update_btn);
            this.tabPage1.Controls.Add(this.customer_search_clear_btn);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1213, 531);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "고객";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // customer_search_btn
            // 
            this.customer_search_btn.Font = new System.Drawing.Font("나눔바른펜", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.customer_search_btn.Location = new System.Drawing.Point(736, 292);
            this.customer_search_btn.Name = "customer_search_btn";
            this.customer_search_btn.Size = new System.Drawing.Size(438, 42);
            this.customer_search_btn.TabIndex = 7;
            this.customer_search_btn.Text = "검색하기";
            this.customer_search_btn.UseVisualStyleBackColor = true;
            this.customer_search_btn.Click += new System.EventHandler(this.Customer_search_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.customer_point);
            this.panel1.Controls.Add(this.customer_job);
            this.panel1.Controls.Add(this.customer_grade);
            this.panel1.Controls.Add(this.customer_age);
            this.panel1.Controls.Add(this.customer_name);
            this.panel1.Controls.Add(this.customer_ID);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(736, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 271);
            this.panel1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔바른펜", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(71, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "적립금";
            // 
            // customer_point
            // 
            this.customer_point.Font = new System.Drawing.Font("나눔바른펜", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.customer_point.Location = new System.Drawing.Point(137, 235);
            this.customer_point.Name = "customer_point";
            this.customer_point.Size = new System.Drawing.Size(281, 28);
            this.customer_point.TabIndex = 12;
            // 
            // customer_job
            // 
            this.customer_job.Font = new System.Drawing.Font("나눔바른펜", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.customer_job.Location = new System.Drawing.Point(137, 201);
            this.customer_job.Name = "customer_job";
            this.customer_job.Size = new System.Drawing.Size(281, 28);
            this.customer_job.TabIndex = 11;
            // 
            // customer_grade
            // 
            this.customer_grade.Font = new System.Drawing.Font("나눔바른펜", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.customer_grade.Location = new System.Drawing.Point(137, 167);
            this.customer_grade.Name = "customer_grade";
            this.customer_grade.Size = new System.Drawing.Size(281, 28);
            this.customer_grade.TabIndex = 10;
            // 
            // customer_age
            // 
            this.customer_age.Font = new System.Drawing.Font("나눔바른펜", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.customer_age.Location = new System.Drawing.Point(137, 133);
            this.customer_age.Name = "customer_age";
            this.customer_age.Size = new System.Drawing.Size(281, 28);
            this.customer_age.TabIndex = 9;
            // 
            // customer_name
            // 
            this.customer_name.Font = new System.Drawing.Font("나눔바른펜", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.customer_name.Location = new System.Drawing.Point(137, 99);
            this.customer_name.Name = "customer_name";
            this.customer_name.Size = new System.Drawing.Size(281, 28);
            this.customer_name.TabIndex = 8;
            // 
            // customer_ID
            // 
            this.customer_ID.Font = new System.Drawing.Font("나눔바른펜", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.customer_ID.Location = new System.Drawing.Point(137, 65);
            this.customer_ID.Name = "customer_ID";
            this.customer_ID.Size = new System.Drawing.Size(281, 28);
            this.customer_ID.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("나눔바른펜", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(87, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 26);
            this.label8.TabIndex = 6;
            this.label8.Text = "직업";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔바른펜", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(86, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 26);
            this.label7.TabIndex = 5;
            this.label7.Text = "나이";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔바른펜", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(87, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 26);
            this.label6.TabIndex = 4;
            this.label6.Text = "등급";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔바른펜", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(54, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "고객이름";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔바른펜", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(37, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "고객아이디";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔바른펜", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(153, 11);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(138, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "고객 관리";
            // 
            // customer_add_btn
            // 
            this.customer_add_btn.Font = new System.Drawing.Font("나눔바른펜", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.customer_add_btn.Location = new System.Drawing.Point(736, 340);
            this.customer_add_btn.Name = "customer_add_btn";
            this.customer_add_btn.Size = new System.Drawing.Size(438, 42);
            this.customer_add_btn.TabIndex = 5;
            this.customer_add_btn.Text = "추가하기";
            this.customer_add_btn.UseVisualStyleBackColor = true;
            this.customer_add_btn.Click += new System.EventHandler(this.Customer_add_btn_Click);
            // 
            // customer_remove_btn
            // 
            this.customer_remove_btn.Font = new System.Drawing.Font("나눔바른펜", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.customer_remove_btn.Location = new System.Drawing.Point(736, 388);
            this.customer_remove_btn.Name = "customer_remove_btn";
            this.customer_remove_btn.Size = new System.Drawing.Size(438, 42);
            this.customer_remove_btn.TabIndex = 4;
            this.customer_remove_btn.Text = "삭제하기";
            this.customer_remove_btn.UseVisualStyleBackColor = true;
            this.customer_remove_btn.Click += new System.EventHandler(this.Customer_remove_btn_Click);
            // 
            // customer_update_btn
            // 
            this.customer_update_btn.Font = new System.Drawing.Font("나눔바른펜", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.customer_update_btn.Location = new System.Drawing.Point(736, 436);
            this.customer_update_btn.Name = "customer_update_btn";
            this.customer_update_btn.Size = new System.Drawing.Size(438, 42);
            this.customer_update_btn.TabIndex = 3;
            this.customer_update_btn.Text = "갱신하기";
            this.customer_update_btn.UseVisualStyleBackColor = true;
            this.customer_update_btn.Click += new System.EventHandler(this.Customer_update_btn_Click);
            // 
            // customer_search_clear_btn
            // 
            this.customer_search_clear_btn.Font = new System.Drawing.Font("나눔바른펜", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.customer_search_clear_btn.Location = new System.Drawing.Point(736, 482);
            this.customer_search_clear_btn.Name = "customer_search_clear_btn";
            this.customer_search_clear_btn.Size = new System.Drawing.Size(438, 42);
            this.customer_search_clear_btn.TabIndex = 2;
            this.customer_search_clear_btn.Text = "검색 초기화";
            this.customer_search_clear_btn.UseVisualStyleBackColor = true;
            this.customer_search_clear_btn.Click += new System.EventHandler(this.Customer_search_clear_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(696, 513);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.product_search_btn);
            this.tabPage2.Controls.Add(this.product_add_btn);
            this.tabPage2.Controls.Add(this.product_remove_btn);
            this.tabPage2.Controls.Add(this.product_update_btn);
            this.tabPage2.Controls.Add(this.product_search_clear_btn);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1213, 531);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "제품";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.product_manufacturer);
            this.panel2.Controls.Add(this.product_price);
            this.panel2.Controls.Add(this.product_stock);
            this.panel2.Controls.Add(this.product_name);
            this.panel2.Controls.Add(this.product_number);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Location = new System.Drawing.Point(736, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 271);
            this.panel2.TabIndex = 13;
            // 
            // product_manufacturer
            // 
            this.product_manufacturer.Font = new System.Drawing.Font("나눔바른펜", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.product_manufacturer.Location = new System.Drawing.Point(137, 215);
            this.product_manufacturer.Name = "product_manufacturer";
            this.product_manufacturer.Size = new System.Drawing.Size(281, 34);
            this.product_manufacturer.TabIndex = 8;
            // 
            // product_price
            // 
            this.product_price.Font = new System.Drawing.Font("나눔바른펜", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.product_price.Location = new System.Drawing.Point(137, 174);
            this.product_price.Name = "product_price";
            this.product_price.Size = new System.Drawing.Size(281, 32);
            this.product_price.TabIndex = 10;
            // 
            // product_stock
            // 
            this.product_stock.Font = new System.Drawing.Font("나눔바른펜", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.product_stock.Location = new System.Drawing.Point(137, 136);
            this.product_stock.Name = "product_stock";
            this.product_stock.Size = new System.Drawing.Size(281, 32);
            this.product_stock.TabIndex = 9;
            // 
            // product_name
            // 
            this.product_name.Font = new System.Drawing.Font("나눔바른펜", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.product_name.Location = new System.Drawing.Point(137, 98);
            this.product_name.Name = "product_name";
            this.product_name.Size = new System.Drawing.Size(281, 32);
            this.product_name.TabIndex = 8;
            // 
            // product_number
            // 
            this.product_number.Font = new System.Drawing.Font("나눔바른펜", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.product_number.Location = new System.Drawing.Point(137, 60);
            this.product_number.Name = "product_number";
            this.product_number.Size = new System.Drawing.Size(281, 32);
            this.product_number.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("나눔바른펜", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(53, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 26);
            this.label9.TabIndex = 6;
            this.label9.Text = "제조업체";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("나눔바른펜", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(69, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 26);
            this.label10.TabIndex = 5;
            this.label10.Text = "재고량";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("나눔바른펜", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(85, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 26);
            this.label11.TabIndex = 4;
            this.label11.Text = "단가";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("나눔바른펜", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(69, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 26);
            this.label12.TabIndex = 3;
            this.label12.Text = "제품명";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("나눔바른펜", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(54, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 26);
            this.label13.TabIndex = 2;
            this.label13.Text = "제품번호";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("나눔바른펜", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(153, 11);
            this.label14.Name = "label14";
            this.label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label14.Size = new System.Drawing.Size(138, 45);
            this.label14.TabIndex = 1;
            this.label14.Text = "제품 관리";
            // 
            // product_search_btn
            // 
            this.product_search_btn.Font = new System.Drawing.Font("나눔바른펜", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.product_search_btn.Location = new System.Drawing.Point(736, 290);
            this.product_search_btn.Name = "product_search_btn";
            this.product_search_btn.Size = new System.Drawing.Size(438, 42);
            this.product_search_btn.TabIndex = 12;
            this.product_search_btn.Text = "검색하기";
            this.product_search_btn.UseVisualStyleBackColor = true;
            this.product_search_btn.Click += new System.EventHandler(this.Product_search_btn_Click);
            // 
            // product_add_btn
            // 
            this.product_add_btn.Font = new System.Drawing.Font("나눔바른펜", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.product_add_btn.Location = new System.Drawing.Point(736, 338);
            this.product_add_btn.Name = "product_add_btn";
            this.product_add_btn.Size = new System.Drawing.Size(438, 42);
            this.product_add_btn.TabIndex = 11;
            this.product_add_btn.Text = "추가하기";
            this.product_add_btn.UseVisualStyleBackColor = true;
            this.product_add_btn.Click += new System.EventHandler(this.Product_add_btn_Click);
            // 
            // product_remove_btn
            // 
            this.product_remove_btn.Font = new System.Drawing.Font("나눔바른펜", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.product_remove_btn.Location = new System.Drawing.Point(736, 386);
            this.product_remove_btn.Name = "product_remove_btn";
            this.product_remove_btn.Size = new System.Drawing.Size(438, 42);
            this.product_remove_btn.TabIndex = 10;
            this.product_remove_btn.Text = "삭제하기";
            this.product_remove_btn.UseVisualStyleBackColor = true;
            this.product_remove_btn.Click += new System.EventHandler(this.Product_remove_btn_Click);
            // 
            // product_update_btn
            // 
            this.product_update_btn.Font = new System.Drawing.Font("나눔바른펜", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.product_update_btn.Location = new System.Drawing.Point(736, 434);
            this.product_update_btn.Name = "product_update_btn";
            this.product_update_btn.Size = new System.Drawing.Size(438, 42);
            this.product_update_btn.TabIndex = 9;
            this.product_update_btn.Text = "갱신하기";
            this.product_update_btn.UseVisualStyleBackColor = true;
            this.product_update_btn.Click += new System.EventHandler(this.Product_update_btn_Click);
            // 
            // product_search_clear_btn
            // 
            this.product_search_clear_btn.Font = new System.Drawing.Font("나눔바른펜", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.product_search_clear_btn.Location = new System.Drawing.Point(736, 482);
            this.product_search_clear_btn.Name = "product_search_clear_btn";
            this.product_search_clear_btn.Size = new System.Drawing.Size(438, 42);
            this.product_search_clear_btn.TabIndex = 8;
            this.product_search_clear_btn.Text = "검색 초기화";
            this.product_search_clear_btn.UseVisualStyleBackColor = true;
            this.product_search_clear_btn.Click += new System.EventHandler(this.Product_search_clear_btn_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 15);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(696, 513);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Controls.Add(this.order_search_btn);
            this.tabPage3.Controls.Add(this.order_add_btn);
            this.tabPage3.Controls.Add(this.order_remove_btn);
            this.tabPage3.Controls.Add(this.order_update_btn);
            this.tabPage3.Controls.Add(this.order_search_clear_btn);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1213, 528);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "주문";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.order_date);
            this.panel3.Controls.Add(this.order_addess);
            this.panel3.Controls.Add(this.order_quantity);
            this.panel3.Controls.Add(this.ordered_product);
            this.panel3.Controls.Add(this.order_customer);
            this.panel3.Controls.Add(this.order_number);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Location = new System.Drawing.Point(736, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(438, 271);
            this.panel3.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔바른펜", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(54, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "주문일자";
            // 
            // order_date
            // 
            this.order_date.Font = new System.Drawing.Font("나눔바른펜", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.order_date.Location = new System.Drawing.Point(137, 235);
            this.order_date.Name = "order_date";
            this.order_date.Size = new System.Drawing.Size(281, 28);
            this.order_date.TabIndex = 12;
            // 
            // order_addess
            // 
            this.order_addess.Font = new System.Drawing.Font("나눔바른펜", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.order_addess.Location = new System.Drawing.Point(137, 201);
            this.order_addess.Name = "order_addess";
            this.order_addess.Size = new System.Drawing.Size(281, 28);
            this.order_addess.TabIndex = 11;
            // 
            // order_quantity
            // 
            this.order_quantity.Font = new System.Drawing.Font("나눔바른펜", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.order_quantity.Location = new System.Drawing.Point(137, 167);
            this.order_quantity.Name = "order_quantity";
            this.order_quantity.Size = new System.Drawing.Size(281, 28);
            this.order_quantity.TabIndex = 10;
            // 
            // ordered_product
            // 
            this.ordered_product.Font = new System.Drawing.Font("나눔바른펜", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ordered_product.Location = new System.Drawing.Point(137, 133);
            this.ordered_product.Name = "ordered_product";
            this.ordered_product.Size = new System.Drawing.Size(281, 28);
            this.ordered_product.TabIndex = 9;
            // 
            // order_customer
            // 
            this.order_customer.Font = new System.Drawing.Font("나눔바른펜", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.order_customer.Location = new System.Drawing.Point(137, 99);
            this.order_customer.Name = "order_customer";
            this.order_customer.Size = new System.Drawing.Size(281, 28);
            this.order_customer.TabIndex = 8;
            // 
            // order_number
            // 
            this.order_number.Font = new System.Drawing.Font("나눔바른펜", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.order_number.Location = new System.Drawing.Point(137, 65);
            this.order_number.Name = "order_number";
            this.order_number.Size = new System.Drawing.Size(281, 28);
            this.order_number.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("나눔바른펜", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(70, 201);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 26);
            this.label15.TabIndex = 6;
            this.label15.Text = "배송지";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("나눔바른펜", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(54, 132);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 26);
            this.label16.TabIndex = 5;
            this.label16.Text = "주문제품";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("나눔바른펜", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(86, 167);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 26);
            this.label17.TabIndex = 4;
            this.label17.Text = "수량";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("나눔바른펜", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.Location = new System.Drawing.Point(54, 98);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 26);
            this.label18.TabIndex = 3;
            this.label18.Text = "주문고객";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("나눔바른펜", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.Location = new System.Drawing.Point(54, 64);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 26);
            this.label19.TabIndex = 2;
            this.label19.Text = "주문번호";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("나눔바른펜", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label20.Location = new System.Drawing.Point(153, 11);
            this.label20.Name = "label20";
            this.label20.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label20.Size = new System.Drawing.Size(137, 45);
            this.label20.TabIndex = 1;
            this.label20.Text = "주문 관리";
            // 
            // order_search_btn
            // 
            this.order_search_btn.Font = new System.Drawing.Font("나눔바른펜", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.order_search_btn.Location = new System.Drawing.Point(736, 290);
            this.order_search_btn.Name = "order_search_btn";
            this.order_search_btn.Size = new System.Drawing.Size(438, 42);
            this.order_search_btn.TabIndex = 18;
            this.order_search_btn.Text = "검색하기";
            this.order_search_btn.UseVisualStyleBackColor = true;
            this.order_search_btn.Click += new System.EventHandler(this.Order_search_btn_Click);
            // 
            // order_add_btn
            // 
            this.order_add_btn.Font = new System.Drawing.Font("나눔바른펜", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.order_add_btn.Location = new System.Drawing.Point(736, 338);
            this.order_add_btn.Name = "order_add_btn";
            this.order_add_btn.Size = new System.Drawing.Size(438, 42);
            this.order_add_btn.TabIndex = 17;
            this.order_add_btn.Text = "추가하기";
            this.order_add_btn.UseVisualStyleBackColor = true;
            this.order_add_btn.Click += new System.EventHandler(this.Order_add_btn_Click);
            // 
            // order_remove_btn
            // 
            this.order_remove_btn.Font = new System.Drawing.Font("나눔바른펜", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.order_remove_btn.Location = new System.Drawing.Point(736, 386);
            this.order_remove_btn.Name = "order_remove_btn";
            this.order_remove_btn.Size = new System.Drawing.Size(438, 42);
            this.order_remove_btn.TabIndex = 16;
            this.order_remove_btn.Text = "삭제하기";
            this.order_remove_btn.UseVisualStyleBackColor = true;
            this.order_remove_btn.Click += new System.EventHandler(this.Order_remove_btn_Click);
            // 
            // order_update_btn
            // 
            this.order_update_btn.Font = new System.Drawing.Font("나눔바른펜", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.order_update_btn.Location = new System.Drawing.Point(736, 434);
            this.order_update_btn.Name = "order_update_btn";
            this.order_update_btn.Size = new System.Drawing.Size(438, 42);
            this.order_update_btn.TabIndex = 15;
            this.order_update_btn.Text = "갱신하기";
            this.order_update_btn.UseVisualStyleBackColor = true;
            this.order_update_btn.Click += new System.EventHandler(this.Order_update_btn_Click);
            // 
            // order_search_clear_btn
            // 
            this.order_search_clear_btn.Font = new System.Drawing.Font("나눔바른펜", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.order_search_clear_btn.Location = new System.Drawing.Point(736, 482);
            this.order_search_clear_btn.Name = "order_search_clear_btn";
            this.order_search_clear_btn.Size = new System.Drawing.Size(438, 42);
            this.order_search_clear_btn.TabIndex = 14;
            this.order_search_clear_btn.Text = "검색 초기화";
            this.order_search_clear_btn.UseVisualStyleBackColor = true;
            this.order_search_clear_btn.Click += new System.EventHandler(this.Order_search_clear_btn_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 15);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(696, 513);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView3_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 660);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "한빛마트 관리";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button customer_add_btn;
        private System.Windows.Forms.Button customer_remove_btn;
        private System.Windows.Forms.Button customer_update_btn;
        private System.Windows.Forms.Button customer_search_clear_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button customer_search_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox customer_ID;
        private System.Windows.Forms.Button product_search_btn;
        private System.Windows.Forms.Button product_add_btn;
        private System.Windows.Forms.Button product_remove_btn;
        private System.Windows.Forms.Button product_update_btn;
        private System.Windows.Forms.Button product_search_clear_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox product_manufacturer;
        private System.Windows.Forms.TextBox product_price;
        private System.Windows.Forms.TextBox product_stock;
        private System.Windows.Forms.TextBox product_name;
        private System.Windows.Forms.TextBox product_number;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button order_search_btn;
        private System.Windows.Forms.Button order_add_btn;
        private System.Windows.Forms.Button order_remove_btn;
        private System.Windows.Forms.Button order_update_btn;
        private System.Windows.Forms.Button order_search_clear_btn;
        private System.Windows.Forms.TextBox customer_point;
        private System.Windows.Forms.TextBox customer_job;
        private System.Windows.Forms.TextBox customer_grade;
        private System.Windows.Forms.TextBox customer_age;
        private System.Windows.Forms.TextBox customer_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox order_date;
        private System.Windows.Forms.TextBox order_addess;
        private System.Windows.Forms.TextBox order_quantity;
        private System.Windows.Forms.TextBox ordered_product;
        private System.Windows.Forms.TextBox order_customer;
        private System.Windows.Forms.TextBox order_number;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
    }
}

