
namespace duloveme.Calculator
{
    partial class FormMain
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblHistory = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClearEntry = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblHistory, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCurrent, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(304, 408);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblHistory
            // 
            this.lblHistory.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblHistory.AutoSize = true;
            this.lblHistory.Location = new System.Drawing.Point(301, 9);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(0, 12);
            this.lblHistory.TabIndex = 0;
            // 
            // lblCurrent
            // 
            this.lblCurrent.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold);
            this.lblCurrent.Location = new System.Drawing.Point(256, 31);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(45, 48);
            this.lblCurrent.TabIndex = 1;
            this.lblCurrent.Text = "0";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.btnBackspace, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnClear, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnClearEntry, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnEqual, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.button23, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.button22, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.button21, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnPlus, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.button19, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.button18, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.button17, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnMinus, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.button15, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.button14, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.button13, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnMultiply, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.button11, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.button10, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.button9, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnMod, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 83);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(298, 322);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnBackspace
            // 
            this.btnBackspace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBackspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBackspace.FlatAppearance.BorderSize = 0;
            this.btnBackspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackspace.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnBackspace.Location = new System.Drawing.Point(151, 3);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(68, 58);
            this.btnBackspace.TabIndex = 28;
            this.btnBackspace.Text = "<=";
            this.btnBackspace.UseVisualStyleBackColor = false;
            this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.Location = new System.Drawing.Point(77, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(68, 58);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClearEntry
            // 
            this.btnClearEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClearEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearEntry.FlatAppearance.BorderSize = 0;
            this.btnClearEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearEntry.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnClearEntry.Location = new System.Drawing.Point(3, 3);
            this.btnClearEntry.Name = "btnClearEntry";
            this.btnClearEntry.Size = new System.Drawing.Size(68, 58);
            this.btnClearEntry.TabIndex = 26;
            this.btnClearEntry.Text = "CE";
            this.btnClearEntry.UseVisualStyleBackColor = false;
            this.btnClearEntry.Click += new System.EventHandler(this.btnClearEntry_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEqual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEqual.FlatAppearance.BorderSize = 0;
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqual.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnEqual.Location = new System.Drawing.Point(225, 259);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(70, 60);
            this.btnEqual.TabIndex = 23;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button23.FlatAppearance.BorderSize = 0;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button23.Location = new System.Drawing.Point(151, 259);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(68, 60);
            this.button23.TabIndex = 22;
            this.button23.Text = ".";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.Number_Click);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button22.FlatAppearance.BorderSize = 0;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button22.Location = new System.Drawing.Point(77, 259);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(68, 60);
            this.button22.TabIndex = 21;
            this.button22.Text = "0";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.Number_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button21.FlatAppearance.BorderSize = 0;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button21.Location = new System.Drawing.Point(3, 259);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(68, 60);
            this.button21.TabIndex = 20;
            this.button21.Text = "±";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.Symbol_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlus.FlatAppearance.BorderSize = 0;
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnPlus.Location = new System.Drawing.Point(225, 195);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(70, 58);
            this.btnPlus.TabIndex = 19;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.Operator_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button19.Location = new System.Drawing.Point(151, 195);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(68, 58);
            this.button19.TabIndex = 18;
            this.button19.Text = "3";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.Number_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button18.Location = new System.Drawing.Point(77, 195);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(68, 58);
            this.button18.TabIndex = 17;
            this.button18.Text = "2";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.Number_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button17.Location = new System.Drawing.Point(3, 195);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(68, 58);
            this.button17.TabIndex = 16;
            this.button17.Text = "1";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMinus.FlatAppearance.BorderSize = 0;
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnMinus.Location = new System.Drawing.Point(225, 131);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(70, 58);
            this.btnMinus.TabIndex = 15;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.Operator_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button15.Location = new System.Drawing.Point(151, 131);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(68, 58);
            this.button15.TabIndex = 14;
            this.button15.Text = "6";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.Number_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button14.Location = new System.Drawing.Point(77, 131);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(68, 58);
            this.button14.TabIndex = 13;
            this.button14.Text = "5";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.Number_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button13.Location = new System.Drawing.Point(3, 131);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(68, 58);
            this.button13.TabIndex = 12;
            this.button13.Text = "4";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMultiply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMultiply.FlatAppearance.BorderSize = 0;
            this.btnMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiply.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnMultiply.Location = new System.Drawing.Point(225, 67);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(70, 58);
            this.btnMultiply.TabIndex = 11;
            this.btnMultiply.Text = "×";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.Operator_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button11.Location = new System.Drawing.Point(151, 67);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(68, 58);
            this.button11.TabIndex = 10;
            this.button11.Text = "9";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.Number_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button10.Location = new System.Drawing.Point(77, 67);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(68, 58);
            this.button10.TabIndex = 9;
            this.button10.Text = "8";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.Number_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button9.Location = new System.Drawing.Point(3, 67);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(68, 58);
            this.button9.TabIndex = 8;
            this.button9.Text = "7";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.Number_Click);
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMod.FlatAppearance.BorderSize = 0;
            this.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMod.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnMod.Location = new System.Drawing.Point(225, 3);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(70, 58);
            this.btnMod.TabIndex = 7;
            this.btnMod.Text = "÷";
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.Operator_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(304, 408);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(500, 600);
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.Text = "계산기";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClearEntry;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnMod;
    }
}

