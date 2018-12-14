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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "数式";
            // 
            // Formula
            // 
            this.Formula.Location = new System.Drawing.Point(116, 27);
            this.Formula.Name = "Formula";
            this.Formula.Size = new System.Drawing.Size(561, 25);
            this.Formula.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "f=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "簡単化後の式";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(156, 82);
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
            this.Simplification_Formula.Size = new System.Drawing.Size(561, 130);
            this.Simplification_Formula.TabIndex = 5;
            // 
            // Run_Button
            // 
            this.Run_Button.Location = new System.Drawing.Point(836, 20);
            this.Run_Button.Name = "Run_Button";
            this.Run_Button.Size = new System.Drawing.Size(122, 45);
            this.Run_Button.TabIndex = 6;
            this.Run_Button.Text = "Run";
            this.Run_Button.UseVisualStyleBackColor = true;
            this.Run_Button.Click += new System.EventHandler(this.Run_Button_Click);
            // 
            // truth_table_output_00
            // 
            this.truth_table_output_00.Location = new System.Drawing.Point(345, 333);
            this.truth_table_output_00.Name = "truth_table_output_00";
            this.truth_table_output_00.ReadOnly = true;
            this.truth_table_output_00.Size = new System.Drawing.Size(25, 25);
            this.truth_table_output_00.TabIndex = 7;
            // 
            // truth_table_output_01
            // 
            this.truth_table_output_01.Location = new System.Drawing.Point(400, 333);
            this.truth_table_output_01.Name = "truth_table_output_01";
            this.truth_table_output_01.ReadOnly = true;
            this.truth_table_output_01.Size = new System.Drawing.Size(25, 25);
            this.truth_table_output_01.TabIndex = 8;
            // 
            // truth_table_output_02
            // 
            this.truth_table_output_02.Location = new System.Drawing.Point(460, 333);
            this.truth_table_output_02.Name = "truth_table_output_02";
            this.truth_table_output_02.ReadOnly = true;
            this.truth_table_output_02.Size = new System.Drawing.Size(25, 25);
            this.truth_table_output_02.TabIndex = 9;
            // 
            // truth_table_output_03
            // 
            this.truth_table_output_03.Location = new System.Drawing.Point(518, 333);
            this.truth_table_output_03.Name = "truth_table_output_03";
            this.truth_table_output_03.ReadOnly = true;
            this.truth_table_output_03.Size = new System.Drawing.Size(25, 25);
            this.truth_table_output_03.TabIndex = 10;
            // 
            // truth_table_output_13
            // 
            this.truth_table_output_13.Location = new System.Drawing.Point(518, 380);
            this.truth_table_output_13.Name = "truth_table_output_13";
            this.truth_table_output_13.ReadOnly = true;
            this.truth_table_output_13.Size = new System.Drawing.Size(25, 25);
            this.truth_table_output_13.TabIndex = 14;
            // 
            // truth_table_output_12
            // 
            this.truth_table_output_12.Location = new System.Drawing.Point(460, 380);
            this.truth_table_output_12.Name = "truth_table_output_12";
            this.truth_table_output_12.ReadOnly = true;
            this.truth_table_output_12.Size = new System.Drawing.Size(25, 25);
            this.truth_table_output_12.TabIndex = 13;
            // 
            // truth_table_output_11
            // 
            this.truth_table_output_11.Location = new System.Drawing.Point(400, 380);
            this.truth_table_output_11.Name = "truth_table_output_11";
            this.truth_table_output_11.ReadOnly = true;
            this.truth_table_output_11.Size = new System.Drawing.Size(25, 25);
            this.truth_table_output_11.TabIndex = 12;
            // 
            // truth_table_output_10
            // 
            this.truth_table_output_10.Location = new System.Drawing.Point(345, 380);
            this.truth_table_output_10.Name = "truth_table_output_10";
            this.truth_table_output_10.ReadOnly = true;
            this.truth_table_output_10.Size = new System.Drawing.Size(25, 25);
            this.truth_table_output_10.TabIndex = 11;
            // 
            // truth_table_output_23
            // 
            this.truth_table_output_23.Location = new System.Drawing.Point(518, 429);
            this.truth_table_output_23.Name = "truth_table_output_23";
            this.truth_table_output_23.ReadOnly = true;
            this.truth_table_output_23.Size = new System.Drawing.Size(25, 25);
            this.truth_table_output_23.TabIndex = 18;
            // 
            // truth_table_output_22
            // 
            this.truth_table_output_22.Location = new System.Drawing.Point(460, 429);
            this.truth_table_output_22.Name = "truth_table_output_22";
            this.truth_table_output_22.ReadOnly = true;
            this.truth_table_output_22.Size = new System.Drawing.Size(25, 25);
            this.truth_table_output_22.TabIndex = 17;
            // 
            // truth_table_output_21
            // 
            this.truth_table_output_21.Location = new System.Drawing.Point(400, 429);
            this.truth_table_output_21.Name = "truth_table_output_21";
            this.truth_table_output_21.ReadOnly = true;
            this.truth_table_output_21.Size = new System.Drawing.Size(25, 25);
            this.truth_table_output_21.TabIndex = 16;
            // 
            // truth_table_output_20
            // 
            this.truth_table_output_20.Location = new System.Drawing.Point(345, 429);
            this.truth_table_output_20.Name = "truth_table_output_20";
            this.truth_table_output_20.ReadOnly = true;
            this.truth_table_output_20.Size = new System.Drawing.Size(25, 25);
            this.truth_table_output_20.TabIndex = 15;
            // 
            // truth_table_output_33
            // 
            this.truth_table_output_33.Location = new System.Drawing.Point(518, 479);
            this.truth_table_output_33.Name = "truth_table_output_33";
            this.truth_table_output_33.ReadOnly = true;
            this.truth_table_output_33.Size = new System.Drawing.Size(25, 25);
            this.truth_table_output_33.TabIndex = 22;
            // 
            // truth_table_output_32
            // 
            this.truth_table_output_32.Location = new System.Drawing.Point(460, 479);
            this.truth_table_output_32.Name = "truth_table_output_32";
            this.truth_table_output_32.ReadOnly = true;
            this.truth_table_output_32.Size = new System.Drawing.Size(25, 25);
            this.truth_table_output_32.TabIndex = 21;
            // 
            // truth_table_output_31
            // 
            this.truth_table_output_31.Location = new System.Drawing.Point(400, 479);
            this.truth_table_output_31.Name = "truth_table_output_31";
            this.truth_table_output_31.ReadOnly = true;
            this.truth_table_output_31.Size = new System.Drawing.Size(25, 25);
            this.truth_table_output_31.TabIndex = 20;
            // 
            // truth_table_output_30
            // 
            this.truth_table_output_30.Location = new System.Drawing.Point(345, 479);
            this.truth_table_output_30.Name = "truth_table_output_30";
            this.truth_table_output_30.ReadOnly = true;
            this.truth_table_output_30.Size = new System.Drawing.Size(25, 25);
            this.truth_table_output_30.TabIndex = 19;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 676);
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
            this.Name = "View";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox Formula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Simplification_Formula;
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
    }
}

