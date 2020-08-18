namespace ACalculatorProject
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.FirstNumber = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtFirstNum = new System.Windows.Forms.TextBox();
			this.txtsecNum = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnSub = new System.Windows.Forms.Button();
			this.btnDiv = new System.Windows.Forms.Button();
			this.btnMin = new System.Windows.Forms.Button();
			this.txtResult = new System.Windows.Forms.TextBox();
			this.butClear = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// FirstNumber
			// 
			this.FirstNumber.AutoSize = true;
			this.FirstNumber.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FirstNumber.ForeColor = System.Drawing.Color.White;
			this.FirstNumber.Location = new System.Drawing.Point(12, 82);
			this.FirstNumber.Name = "FirstNumber";
			this.FirstNumber.Size = new System.Drawing.Size(104, 19);
			this.FirstNumber.TabIndex = 3;
			this.FirstNumber.Text = " First Number";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Harrington", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(12, 117);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 19);
			this.label1.TabIndex = 4;
			this.label1.Text = "Second Number";
			// 
			// txtFirstNum
			// 
			this.txtFirstNum.BackColor = System.Drawing.Color.White;
			this.txtFirstNum.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFirstNum.Location = new System.Drawing.Point(182, 82);
			this.txtFirstNum.Name = "txtFirstNum";
			this.txtFirstNum.Size = new System.Drawing.Size(174, 23);
			this.txtFirstNum.TabIndex = 5;
			// 
			// txtsecNum
			// 
			this.txtsecNum.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtsecNum.Location = new System.Drawing.Point(182, 117);
			this.txtsecNum.Multiline = true;
			this.txtsecNum.Name = "txtsecNum";
			this.txtsecNum.Size = new System.Drawing.Size(174, 25);
			this.txtsecNum.TabIndex = 6;
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.PaleTurquoise;
			this.btnAdd.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.Location = new System.Drawing.Point(38, 166);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 44);
			this.btnAdd.TabIndex = 7;
			this.btnAdd.Text = "+";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnSub
			// 
			this.btnSub.BackColor = System.Drawing.Color.Teal;
			this.btnSub.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSub.Location = new System.Drawing.Point(119, 166);
			this.btnSub.Name = "btnSub";
			this.btnSub.Size = new System.Drawing.Size(75, 44);
			this.btnSub.TabIndex = 8;
			this.btnSub.Text = "-";
			this.btnSub.UseVisualStyleBackColor = false;
			this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
			// 
			// btnDiv
			// 
			this.btnDiv.BackColor = System.Drawing.Color.PaleTurquoise;
			this.btnDiv.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDiv.Location = new System.Drawing.Point(200, 166);
			this.btnDiv.Name = "btnDiv";
			this.btnDiv.Size = new System.Drawing.Size(75, 44);
			this.btnDiv.TabIndex = 9;
			this.btnDiv.Text = "/";
			this.btnDiv.UseVisualStyleBackColor = false;
			this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
			// 
			// btnMin
			// 
			this.btnMin.BackColor = System.Drawing.Color.Teal;
			this.btnMin.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMin.Location = new System.Drawing.Point(281, 166);
			this.btnMin.Name = "btnMin";
			this.btnMin.Size = new System.Drawing.Size(75, 44);
			this.btnMin.TabIndex = 10;
			this.btnMin.Text = "*";
			this.btnMin.UseVisualStyleBackColor = false;
			this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
			// 
			// txtResult
			// 
			this.txtResult.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtResult.Location = new System.Drawing.Point(38, 21);
			this.txtResult.Multiline = true;
			this.txtResult.Name = "txtResult";
			this.txtResult.Size = new System.Drawing.Size(318, 39);
			this.txtResult.TabIndex = 11;
			// 
			// butClear
			// 
			this.butClear.BackColor = System.Drawing.Color.PaleTurquoise;
			this.butClear.Font = new System.Drawing.Font("Harrington", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.butClear.ForeColor = System.Drawing.Color.White;
			this.butClear.Location = new System.Drawing.Point(163, 237);
			this.butClear.Name = "butClear";
			this.butClear.Size = new System.Drawing.Size(75, 39);
			this.butClear.TabIndex = 12;
			this.butClear.Text = " Clear";
			this.butClear.UseVisualStyleBackColor = false;
			this.butClear.Click += new System.EventHandler(this.butClear_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Teal;
			this.ClientSize = new System.Drawing.Size(378, 299);
			this.Controls.Add(this.butClear);
			this.Controls.Add(this.txtResult);
			this.Controls.Add(this.btnMin);
			this.Controls.Add(this.btnDiv);
			this.Controls.Add(this.btnSub);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtsecNum);
			this.Controls.Add(this.txtFirstNum);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.FirstNumber);
			this.Font = new System.Drawing.Font("Harrington", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "Form1";
			this.Text = "Calculator Application";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Label FirstNumber;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtFirstNum;
		private System.Windows.Forms.TextBox txtsecNum;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnSub;
		private System.Windows.Forms.Button btnDiv;
		private System.Windows.Forms.Button btnMin;
		private System.Windows.Forms.TextBox txtResult;
		private System.Windows.Forms.Button butClear;
	}
}

