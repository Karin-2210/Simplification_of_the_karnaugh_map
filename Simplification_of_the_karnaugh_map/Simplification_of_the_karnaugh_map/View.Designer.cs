namespace Simplification_of_the_karnaugh_map
{
    partial class View
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Formula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Simplification_Formula = new System.Windows.Forms.TextBox();
            this.Run_Button = new System.Windows.Forms.Button();
            this.truth_table_output_00 = new System.Windows.Forms.TextBox();
            this.truth_table_output_01 = new System.Windows.Forms.TextBox();
            this.truth_table_output_02 = new System.Windows.Forms.TextBox();
            this.truth_table_output_03 = new System.Windows.Forms.TextBox();
            this.truth_table_output_13 = new System.Windows.Forms.TextBox();
            this.truth_table_output_12 = new System.Windows.Forms.TextBox();
            this.truth_table_output_11 = new System.Windows.Forms.TextBox();
            this.truth_table_output_10 = new System.Windows.Forms.TextBox();
            this.truth_table_output_23 = new System.Windows.Forms.TextBox();
            this.truth_table_output_22 = new System.Windows.Forms.TextBox();
            this.truth_table_output_21 = new System.Windows.Forms.TextBox();
            this.truth_table_output_20 = new System.Windows.Forms.TextBox();
            this.truth_table_output_33 = new System.Windows.Forms.TextBox();
            this.truth_table_output_32 = new System.Windows.Forms.TextBox();
            this.truth_table_output_31 = new System.Windows.Forms.TextBox();
            this.truth_table_output_30 = new System.Windows.Forms.TextBox();
            this.Simplified_Draw = new System.Windows.Forms.PictureBox();
            this.DontCare_Table00 = new System.Windows.Forms.CheckBox();
            this.DontCare_Table01 = new System.Windows.Forms.CheckBox();
            this.DontCare_Table02 = new System.Windows.Forms.CheckBox();
            this.DontCare_Table03 = new System.Windows.Forms.CheckBox();
            this.DontCare_Table13 = new System.Windows.Forms.CheckBox();
            this.DontCare_Table12 = new System.Windows.Forms.CheckBox();
            this.DontCare_Table11 = new System.Windows.Forms.CheckBox();
            this.DontCare_Table10 = new System.Windows.Forms.CheckBox();
            this.DontCare_Table23 = new System.Windows.Forms.CheckBox();
            this.DontCare_Table22 = new System.Windows.Forms.CheckBox();
            this.DontCare_Table21 = new System.Windows.Forms.CheckBox();
            this.DontCare_Table20 = new System.Windows.Forms.CheckBox();
            this.DontCare_Table33 = new System.Windows.Forms.CheckBox();
            this.DontCare_Table32 = new System.Windows.Forms.CheckBox();
            this.DontCare_Table31 = new System.Windows.Forms.CheckBox();
            this.DontCare_Table30 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Simplified_Draw)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "数式";
            // 
            // Formula
            // 
            this.Formula.Location = new System.Drawing.Point(117, 27);
            this.Formula.Name = "Formula";
            this.Formula.Size = new System.Drawing.Size(561, 25);
            this.Formula.TabIndex = 1;
            this.Formula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Formula_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "f=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "簡単化後の式";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(157, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "f=";
            // 
            // Simplification_Formula
            // 
            this.Simplification_Formula.Location = new System.Drawing.Point(188, 80);
            this.Simplification_Formula.Multiline = true;
            this.Simplification_Formula.Name = "Simplification_Formula";
            this.Simplification_Formula.Size = new System.Drawing.Size(490, 130);
            this.Simplification_Formula.TabIndex = 5;
            // 
            // Run_Button
            // 
            this.Run_Button.Location = new System.Drawing.Point(858, 243);
            this.Run_Button.Name = "Run_Button";
            this.Run_Button.Size = new System.Drawing.Size(122, 45);
            this.Run_Button.TabIndex = 6;
            this.Run_Button.Text = "Run";
            this.Run_Button.UseVisualStyleBackColor = true;
            this.Run_Button.Click += new System.EventHandler(this.Run_Button_Click);
            // 
            // truth_table_output_00
            // 
            this.truth_table_output_00.Location = new System.Drawing.Point(367, 330);
            this.truth_table_output_00.Name = "truth_table_output_00";
            this.truth_table_output_00.ReadOnly = true;
            this.truth_table_output_00.Size = new System.Drawing.Size(29, 25);
            this.truth_table_output_00.TabIndex = 7;
            // 
            // truth_table_output_01
            // 
            this.truth_table_output_01.Location = new System.Drawing.Point(417, 330);
            this.truth_table_output_01.Name = "truth_table_output_01";
            this.truth_table_output_01.ReadOnly = true;
            this.truth_table_output_01.Size = new System.Drawing.Size(29, 25);
            this.truth_table_output_01.TabIndex = 8;
            // 
            // truth_table_output_02
            // 
            this.truth_table_output_02.Location = new System.Drawing.Point(467, 330);
            this.truth_table_output_02.Name = "truth_table_output_02";
            this.truth_table_output_02.ReadOnly = true;
            this.truth_table_output_02.Size = new System.Drawing.Size(29, 25);
            this.truth_table_output_02.TabIndex = 9;
            // 
            // truth_table_output_03
            // 
            this.truth_table_output_03.Location = new System.Drawing.Point(517, 330);
            this.truth_table_output_03.Name = "truth_table_output_03";
            this.truth_table_output_03.ReadOnly = true;
            this.truth_table_output_03.Size = new System.Drawing.Size(29, 25);
            this.truth_table_output_03.TabIndex = 10;
            // 
            // truth_table_output_13
            // 
            this.truth_table_output_13.Location = new System.Drawing.Point(517, 375);
            this.truth_table_output_13.Name = "truth_table_output_13";
            this.truth_table_output_13.ReadOnly = true;
            this.truth_table_output_13.Size = new System.Drawing.Size(29, 25);
            this.truth_table_output_13.TabIndex = 14;
            // 
            // truth_table_output_12
            // 
            this.truth_table_output_12.Location = new System.Drawing.Point(467, 375);
            this.truth_table_output_12.Name = "truth_table_output_12";
            this.truth_table_output_12.ReadOnly = true;
            this.truth_table_output_12.Size = new System.Drawing.Size(29, 25);
            this.truth_table_output_12.TabIndex = 13;
            // 
            // truth_table_output_11
            // 
            this.truth_table_output_11.Location = new System.Drawing.Point(417, 375);
            this.truth_table_output_11.Name = "truth_table_output_11";
            this.truth_table_output_11.ReadOnly = true;
            this.truth_table_output_11.Size = new System.Drawing.Size(29, 25);
            this.truth_table_output_11.TabIndex = 12;
            // 
            // truth_table_output_10
            // 
            this.truth_table_output_10.Location = new System.Drawing.Point(367, 375);
            this.truth_table_output_10.Name = "truth_table_output_10";
            this.truth_table_output_10.ReadOnly = true;
            this.truth_table_output_10.Size = new System.Drawing.Size(29, 25);
            this.truth_table_output_10.TabIndex = 11;
            // 
            // truth_table_output_23
            // 
            this.truth_table_output_23.Location = new System.Drawing.Point(517, 420);
            this.truth_table_output_23.Name = "truth_table_output_23";
            this.truth_table_output_23.ReadOnly = true;
            this.truth_table_output_23.Size = new System.Drawing.Size(29, 25);
            this.truth_table_output_23.TabIndex = 18;
            // 
            // truth_table_output_22
            // 
            this.truth_table_output_22.Location = new System.Drawing.Point(467, 420);
            this.truth_table_output_22.Name = "truth_table_output_22";
            this.truth_table_output_22.ReadOnly = true;
            this.truth_table_output_22.Size = new System.Drawing.Size(29, 25);
            this.truth_table_output_22.TabIndex = 17;
            // 
            // truth_table_output_21
            // 
            this.truth_table_output_21.Location = new System.Drawing.Point(417, 420);
            this.truth_table_output_21.Name = "truth_table_output_21";
            this.truth_table_output_21.ReadOnly = true;
            this.truth_table_output_21.Size = new System.Drawing.Size(29, 25);
            this.truth_table_output_21.TabIndex = 16;
            // 
            // truth_table_output_20
            // 
            this.truth_table_output_20.Location = new System.Drawing.Point(367, 420);
            this.truth_table_output_20.Name = "truth_table_output_20";
            this.truth_table_output_20.ReadOnly = true;
            this.truth_table_output_20.Size = new System.Drawing.Size(29, 25);
            this.truth_table_output_20.TabIndex = 15;
            // 
            // truth_table_output_33
            // 
            this.truth_table_output_33.Location = new System.Drawing.Point(517, 465);
            this.truth_table_output_33.Name = "truth_table_output_33";
            this.truth_table_output_33.ReadOnly = true;
            this.truth_table_output_33.Size = new System.Drawing.Size(29, 25);
            this.truth_table_output_33.TabIndex = 22;
            // 
            // truth_table_output_32
            // 
            this.truth_table_output_32.Location = new System.Drawing.Point(467, 465);
            this.truth_table_output_32.Name = "truth_table_output_32";
            this.truth_table_output_32.ReadOnly = true;
            this.truth_table_output_32.Size = new System.Drawing.Size(29, 25);
            this.truth_table_output_32.TabIndex = 21;
            // 
            // truth_table_output_31
            // 
            this.truth_table_output_31.Location = new System.Drawing.Point(417, 465);
            this.truth_table_output_31.Name = "truth_table_output_31";
            this.truth_table_output_31.ReadOnly = true;
            this.truth_table_output_31.Size = new System.Drawing.Size(29, 25);
            this.truth_table_output_31.TabIndex = 20;
            // 
            // truth_table_output_30
            // 
            this.truth_table_output_30.Location = new System.Drawing.Point(367, 465);
            this.truth_table_output_30.Name = "truth_table_output_30";
            this.truth_table_output_30.ReadOnly = true;
            this.truth_table_output_30.Size = new System.Drawing.Size(29, 25);
            this.truth_table_output_30.TabIndex = 19;
            // 
            // Simplified_Draw
            // 
            this.Simplified_Draw.Location = new System.Drawing.Point(-5, 0);
            this.Simplified_Draw.Name = "Simplified_Draw";
            this.Simplified_Draw.Size = new System.Drawing.Size(997, 676);
            this.Simplified_Draw.TabIndex = 23;
            this.Simplified_Draw.TabStop = false;
            // 
            // DontCare_Table00
            // 
            this.DontCare_Table00.AutoSize = true;
            this.DontCare_Table00.Location = new System.Drawing.Point(770, 97);
            this.DontCare_Table00.Name = "DontCare_Table00";
            this.DontCare_Table00.Size = new System.Drawing.Size(22, 21);
            this.DontCare_Table00.TabIndex = 24;
            this.DontCare_Table00.UseVisualStyleBackColor = true;
            // 
            // DontCare_Table01
            // 
            this.DontCare_Table01.AutoSize = true;
            this.DontCare_Table01.Location = new System.Drawing.Point(807, 97);
            this.DontCare_Table01.Name = "DontCare_Table01";
            this.DontCare_Table01.Size = new System.Drawing.Size(22, 21);
            this.DontCare_Table01.TabIndex = 25;
            this.DontCare_Table01.UseVisualStyleBackColor = true;
            // 
            // DontCare_Table02
            // 
            this.DontCare_Table02.AutoSize = true;
            this.DontCare_Table02.Location = new System.Drawing.Point(843, 97);
            this.DontCare_Table02.Name = "DontCare_Table02";
            this.DontCare_Table02.Size = new System.Drawing.Size(22, 21);
            this.DontCare_Table02.TabIndex = 26;
            this.DontCare_Table02.UseVisualStyleBackColor = true;
            // 
            // DontCare_Table03
            // 
            this.DontCare_Table03.AutoSize = true;
            this.DontCare_Table03.Location = new System.Drawing.Point(877, 97);
            this.DontCare_Table03.Name = "DontCare_Table03";
            this.DontCare_Table03.Size = new System.Drawing.Size(22, 21);
            this.DontCare_Table03.TabIndex = 27;
            this.DontCare_Table03.UseVisualStyleBackColor = true;
            // 
            // DontCare_Table13
            // 
            this.DontCare_Table13.AutoSize = true;
            this.DontCare_Table13.Location = new System.Drawing.Point(877, 132);
            this.DontCare_Table13.Name = "DontCare_Table13";
            this.DontCare_Table13.Size = new System.Drawing.Size(22, 21);
            this.DontCare_Table13.TabIndex = 31;
            this.DontCare_Table13.UseVisualStyleBackColor = true;
            // 
            // DontCare_Table12
            // 
            this.DontCare_Table12.AutoSize = true;
            this.DontCare_Table12.Location = new System.Drawing.Point(843, 132);
            this.DontCare_Table12.Name = "DontCare_Table12";
            this.DontCare_Table12.Size = new System.Drawing.Size(22, 21);
            this.DontCare_Table12.TabIndex = 30;
            this.DontCare_Table12.UseVisualStyleBackColor = true;
            // 
            // DontCare_Table11
            // 
            this.DontCare_Table11.AutoSize = true;
            this.DontCare_Table11.Location = new System.Drawing.Point(807, 132);
            this.DontCare_Table11.Name = "DontCare_Table11";
            this.DontCare_Table11.Size = new System.Drawing.Size(22, 21);
            this.DontCare_Table11.TabIndex = 29;
            this.DontCare_Table11.UseVisualStyleBackColor = true;
            // 
            // DontCare_Table10
            // 
            this.DontCare_Table10.AutoSize = true;
            this.DontCare_Table10.Location = new System.Drawing.Point(770, 132);
            this.DontCare_Table10.Name = "DontCare_Table10";
            this.DontCare_Table10.Size = new System.Drawing.Size(22, 21);
            this.DontCare_Table10.TabIndex = 28;
            this.DontCare_Table10.UseVisualStyleBackColor = true;
            // 
            // DontCare_Table23
            // 
            this.DontCare_Table23.AutoSize = true;
            this.DontCare_Table23.Location = new System.Drawing.Point(877, 170);
            this.DontCare_Table23.Name = "DontCare_Table23";
            this.DontCare_Table23.Size = new System.Drawing.Size(22, 21);
            this.DontCare_Table23.TabIndex = 35;
            this.DontCare_Table23.UseVisualStyleBackColor = true;
            // 
            // DontCare_Table22
            // 
            this.DontCare_Table22.AutoSize = true;
            this.DontCare_Table22.Location = new System.Drawing.Point(843, 170);
            this.DontCare_Table22.Name = "DontCare_Table22";
            this.DontCare_Table22.Size = new System.Drawing.Size(22, 21);
            this.DontCare_Table22.TabIndex = 34;
            this.DontCare_Table22.UseVisualStyleBackColor = true;
            // 
            // DontCare_Table21
            // 
            this.DontCare_Table21.AutoSize = true;
            this.DontCare_Table21.Location = new System.Drawing.Point(807, 170);
            this.DontCare_Table21.Name = "DontCare_Table21";
            this.DontCare_Table21.Size = new System.Drawing.Size(22, 21);
            this.DontCare_Table21.TabIndex = 33;
            this.DontCare_Table21.UseVisualStyleBackColor = true;
            // 
            // DontCare_Table20
            // 
            this.DontCare_Table20.AutoSize = true;
            this.DontCare_Table20.Location = new System.Drawing.Point(770, 170);
            this.DontCare_Table20.Name = "DontCare_Table20";
            this.DontCare_Table20.Size = new System.Drawing.Size(22, 21);
            this.DontCare_Table20.TabIndex = 32;
            this.DontCare_Table20.UseVisualStyleBackColor = true;
            // 
            // DontCare_Table33
            // 
            this.DontCare_Table33.AutoSize = true;
            this.DontCare_Table33.Location = new System.Drawing.Point(877, 207);
            this.DontCare_Table33.Name = "DontCare_Table33";
            this.DontCare_Table33.Size = new System.Drawing.Size(22, 21);
            this.DontCare_Table33.TabIndex = 39;
            this.DontCare_Table33.UseVisualStyleBackColor = true;
            // 
            // DontCare_Table32
            // 
            this.DontCare_Table32.AutoSize = true;
            this.DontCare_Table32.Location = new System.Drawing.Point(843, 207);
            this.DontCare_Table32.Name = "DontCare_Table32";
            this.DontCare_Table32.Size = new System.Drawing.Size(22, 21);
            this.DontCare_Table32.TabIndex = 38;
            this.DontCare_Table32.UseVisualStyleBackColor = true;
            // 
            // DontCare_Table31
            // 
            this.DontCare_Table31.AutoSize = true;
            this.DontCare_Table31.Location = new System.Drawing.Point(807, 207);
            this.DontCare_Table31.Name = "DontCare_Table31";
            this.DontCare_Table31.Size = new System.Drawing.Size(22, 21);
            this.DontCare_Table31.TabIndex = 37;
            this.DontCare_Table31.UseVisualStyleBackColor = true;
            // 
            // DontCare_Table30
            // 
            this.DontCare_Table30.AutoSize = true;
            this.DontCare_Table30.Location = new System.Drawing.Point(770, 207);
            this.DontCare_Table30.Name = "DontCare_Table30";
            this.DontCare_Table30.Size = new System.Drawing.Size(22, 21);
            this.DontCare_Table30.TabIndex = 36;
            this.DontCare_Table30.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(768, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 18);
            this.label5.TabIndex = 40;
            this.label5.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(806, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 18);
            this.label6.TabIndex = 41;
            this.label6.Text = "01";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(842, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 18);
            this.label7.TabIndex = 42;
            this.label7.Text = "11";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(876, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 18);
            this.label8.TabIndex = 43;
            this.label8.Text = "10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(737, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 18);
            this.label9.TabIndex = 47;
            this.label9.Text = "10";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(737, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 18);
            this.label10.TabIndex = 46;
            this.label10.Text = "11";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(737, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 18);
            this.label11.TabIndex = 45;
            this.label11.Text = "01";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(737, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 18);
            this.label12.TabIndex = 44;
            this.label12.Text = "00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(335, 468);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 18);
            this.label13.TabIndex = 51;
            this.label13.Text = "10";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(335, 423);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 18);
            this.label14.TabIndex = 50;
            this.label14.Text = "11";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(335, 378);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 18);
            this.label15.TabIndex = 49;
            this.label15.Text = "01";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(335, 333);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 18);
            this.label16.TabIndex = 48;
            this.label16.Text = "00";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(519, 299);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(26, 18);
            this.label17.TabIndex = 55;
            this.label17.Text = "10";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(470, 299);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(26, 18);
            this.label18.TabIndex = 54;
            this.label18.Text = "11";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(421, 299);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(26, 18);
            this.label19.TabIndex = 53;
            this.label19.Text = "01";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(369, 299);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(26, 18);
            this.label20.TabIndex = 52;
            this.label20.Text = "00";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(701, 80);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(30, 18);
            this.label21.TabIndex = 56;
            this.label21.Text = "AB";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(741, 46);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(32, 18);
            this.label22.TabIndex = 57;
            this.label22.Text = "CD";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(335, 280);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(32, 18);
            this.label23.TabIndex = 59;
            this.label23.Text = "CD";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(295, 314);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(30, 18);
            this.label24.TabIndex = 58;
            this.label24.Text = "AB";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(781, 13);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(89, 18);
            this.label25.TabIndex = 60;
            this.label25.Text = "Don\'t Care";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 676);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DontCare_Table33);
            this.Controls.Add(this.DontCare_Table32);
            this.Controls.Add(this.DontCare_Table31);
            this.Controls.Add(this.DontCare_Table30);
            this.Controls.Add(this.DontCare_Table23);
            this.Controls.Add(this.DontCare_Table22);
            this.Controls.Add(this.DontCare_Table21);
            this.Controls.Add(this.DontCare_Table20);
            this.Controls.Add(this.DontCare_Table13);
            this.Controls.Add(this.DontCare_Table12);
            this.Controls.Add(this.DontCare_Table11);
            this.Controls.Add(this.DontCare_Table10);
            this.Controls.Add(this.DontCare_Table03);
            this.Controls.Add(this.DontCare_Table02);
            this.Controls.Add(this.DontCare_Table01);
            this.Controls.Add(this.DontCare_Table00);
            this.Controls.Add(this.truth_table_output_33);
            this.Controls.Add(this.truth_table_output_32);
            this.Controls.Add(this.truth_table_output_31);
            this.Controls.Add(this.truth_table_output_30);
            this.Controls.Add(this.truth_table_output_23);
            this.Controls.Add(this.truth_table_output_22);
            this.Controls.Add(this.truth_table_output_21);
            this.Controls.Add(this.truth_table_output_20);
            this.Controls.Add(this.truth_table_output_13);
            this.Controls.Add(this.truth_table_output_12);
            this.Controls.Add(this.truth_table_output_11);
            this.Controls.Add(this.truth_table_output_10);
            this.Controls.Add(this.truth_table_output_03);
            this.Controls.Add(this.truth_table_output_02);
            this.Controls.Add(this.truth_table_output_01);
            this.Controls.Add(this.truth_table_output_00);
            this.Controls.Add(this.Run_Button);
            this.Controls.Add(this.Simplification_Formula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Formula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Simplified_Draw);
            this.Name = "View";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Simplified_Draw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox Formula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox Simplification_Formula;
        private System.Windows.Forms.Button Run_Button;
        private System.Windows.Forms.TextBox truth_table_output_00;
        private System.Windows.Forms.TextBox truth_table_output_01;
        private System.Windows.Forms.TextBox truth_table_output_02;
        private System.Windows.Forms.TextBox truth_table_output_03;
        private System.Windows.Forms.TextBox truth_table_output_13;
        private System.Windows.Forms.TextBox truth_table_output_12;
        private System.Windows.Forms.TextBox truth_table_output_11;
        private System.Windows.Forms.TextBox truth_table_output_10;
        private System.Windows.Forms.TextBox truth_table_output_23;
        private System.Windows.Forms.TextBox truth_table_output_22;
        private System.Windows.Forms.TextBox truth_table_output_21;
        private System.Windows.Forms.TextBox truth_table_output_20;
        private System.Windows.Forms.TextBox truth_table_output_33;
        private System.Windows.Forms.TextBox truth_table_output_32;
        private System.Windows.Forms.TextBox truth_table_output_31;
        private System.Windows.Forms.TextBox truth_table_output_30;
        private System.Windows.Forms.PictureBox Simplified_Draw;
        private System.Windows.Forms.CheckBox DontCare_Table00;
        private System.Windows.Forms.CheckBox DontCare_Table01;
        private System.Windows.Forms.CheckBox DontCare_Table02;
        private System.Windows.Forms.CheckBox DontCare_Table03;
        private System.Windows.Forms.CheckBox DontCare_Table13;
        private System.Windows.Forms.CheckBox DontCare_Table12;
        private System.Windows.Forms.CheckBox DontCare_Table11;
        private System.Windows.Forms.CheckBox DontCare_Table10;
        private System.Windows.Forms.CheckBox DontCare_Table23;
        private System.Windows.Forms.CheckBox DontCare_Table22;
        private System.Windows.Forms.CheckBox DontCare_Table21;
        private System.Windows.Forms.CheckBox DontCare_Table20;
        private System.Windows.Forms.CheckBox DontCare_Table33;
        private System.Windows.Forms.CheckBox DontCare_Table32;
        private System.Windows.Forms.CheckBox DontCare_Table31;
        private System.Windows.Forms.CheckBox DontCare_Table30;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
    }
}

