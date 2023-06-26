namespace NoteApp
{
    partial class Notes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            txtTitle = new TextBox();
            txtMessege = new TextBox();
            newBut = new Button();
            saveBut = new Button();
            readBut = new Button();
            deleteBut = new Button();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(79, 52);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Orange;
            label2.Location = new Point(53, 88);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Messege";
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.Black;
            txtTitle.ForeColor = Color.Orange;
            txtTitle.Location = new Point(130, 50);
            txtTitle.Margin = new Padding(3, 2, 3, 2);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(192, 23);
            txtTitle.TabIndex = 2;
            // 
            // txtMessege
            // 
            txtMessege.BackColor = Color.Black;
            txtMessege.ForeColor = Color.Orange;
            txtMessege.Location = new Point(130, 88);
            txtMessege.Margin = new Padding(3, 2, 3, 2);
            txtMessege.Multiline = true;
            txtMessege.Name = "txtMessege";
            txtMessege.Size = new Size(192, 130);
            txtMessege.TabIndex = 3;
            // 
            // newBut
            // 
            newBut.AutoSize = true;
            newBut.BackColor = Color.Black;
            newBut.FlatStyle = FlatStyle.Flat;
            newBut.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            newBut.ForeColor = Color.Orange;
            newBut.Location = new Point(130, 248);
            newBut.Margin = new Padding(3, 2, 3, 2);
            newBut.Name = "newBut";
            newBut.Size = new Size(82, 27);
            newBut.TabIndex = 5;
            newBut.Text = "New";
            newBut.UseVisualStyleBackColor = false;
            newBut.Click += newBut_Click;
            // 
            // saveBut
            // 
            saveBut.AutoSize = true;
            saveBut.BackColor = Color.Black;
            saveBut.BackgroundImageLayout = ImageLayout.None;
            saveBut.FlatStyle = FlatStyle.Flat;
            saveBut.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            saveBut.ForeColor = Color.Orange;
            saveBut.Location = new Point(240, 248);
            saveBut.Margin = new Padding(3, 2, 3, 2);
            saveBut.Name = "saveBut";
            saveBut.Size = new Size(82, 27);
            saveBut.TabIndex = 6;
            saveBut.Text = "Save";
            saveBut.UseVisualStyleBackColor = false;
            saveBut.Click += saveBut_Click;
            // 
            // readBut
            // 
            readBut.AutoSize = true;
            readBut.BackColor = Color.Black;
            readBut.FlatStyle = FlatStyle.Flat;
            readBut.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            readBut.ForeColor = Color.Orange;
            readBut.Location = new Point(130, 286);
            readBut.Margin = new Padding(3, 2, 3, 2);
            readBut.Name = "readBut";
            readBut.Size = new Size(82, 27);
            readBut.TabIndex = 7;
            readBut.Text = "Read";
            readBut.UseVisualStyleBackColor = false;
            readBut.Click += readBut_Click;
            // 
            // deleteBut
            // 
            deleteBut.AutoSize = true;
            deleteBut.BackColor = Color.Black;
            deleteBut.FlatStyle = FlatStyle.Flat;
            deleteBut.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            deleteBut.ForeColor = Color.Orange;
            deleteBut.Location = new Point(240, 286);
            deleteBut.Margin = new Padding(3, 2, 3, 2);
            deleteBut.Name = "deleteBut";
            deleteBut.Size = new Size(82, 27);
            deleteBut.TabIndex = 8;
            deleteBut.Text = "Delete";
            deleteBut.UseVisualStyleBackColor = false;
            deleteBut.Click += deleteBut_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = Color.Black;
            dataGridViewCellStyle11.ForeColor = Color.Orange;
            dataGridViewCellStyle11.SelectionBackColor = Color.Orange;
            dataGridViewCellStyle11.SelectionForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            dataGridView1.BackgroundColor = Color.Black;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.Black;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.Orange;
            dataGridViewCellStyle12.SelectionBackColor = Color.Orange;
            dataGridViewCellStyle12.SelectionForeColor = Color.Black;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = Color.Black;
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = Color.Orange;
            dataGridViewCellStyle13.SelectionBackColor = Color.Orange;
            dataGridViewCellStyle13.SelectionForeColor = Color.Black;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle13;
            dataGridView1.GridColor = Color.Orange;
            dataGridView1.Location = new Point(2, 2);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = Color.Black;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = Color.Orange;
            dataGridViewCellStyle14.SelectionBackColor = Color.Orange;
            dataGridViewCellStyle14.SelectionForeColor = Color.Black;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle15.BackColor = Color.Black;
            dataGridViewCellStyle15.ForeColor = Color.Orange;
            dataGridViewCellStyle15.SelectionBackColor = Color.Orange;
            dataGridViewCellStyle15.SelectionForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle15;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(229, 255);
            dataGridView1.TabIndex = 4;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = Color.Black;
            dataGridViewCellStyle16.ForeColor = Color.Orange;
            dataGridViewCellStyle16.SelectionBackColor = Color.Orange;
            dataGridViewCellStyle16.SelectionForeColor = Color.Black;
            dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            dataGridView2.BackgroundColor = Color.Black;
            dataGridView2.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = Color.Black;
            dataGridViewCellStyle17.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = Color.Orange;
            dataGridViewCellStyle17.SelectionBackColor = Color.Orange;
            dataGridViewCellStyle17.SelectionForeColor = Color.Black;
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = Color.Black;
            dataGridViewCellStyle18.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle18.ForeColor = Color.Orange;
            dataGridViewCellStyle18.SelectionBackColor = Color.Orange;
            dataGridViewCellStyle18.SelectionForeColor = Color.Black;
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle18;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.GridColor = Color.Orange;
            dataGridView2.Location = new Point(378, 50);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = Color.Black;
            dataGridViewCellStyle19.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle19.ForeColor = Color.Orange;
            dataGridViewCellStyle19.SelectionBackColor = Color.Orange;
            dataGridViewCellStyle19.SelectionForeColor = Color.Black;
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.True;
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dataGridView2.RowHeadersVisible = false;
            dataGridViewCellStyle20.BackColor = Color.Black;
            dataGridViewCellStyle20.ForeColor = Color.Orange;
            dataGridViewCellStyle20.SelectionBackColor = Color.Orange;
            dataGridViewCellStyle20.SelectionForeColor = Color.Black;
            dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle20;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(233, 259);
            dataGridView2.TabIndex = 9;
            // 
            // Notes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(648, 338);
            Controls.Add(dataGridView2);
            Controls.Add(deleteBut);
            Controls.Add(readBut);
            Controls.Add(saveBut);
            Controls.Add(newBut);
            Controls.Add(txtMessege);
            Controls.Add(txtTitle);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Notes";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTitle;
        private TextBox txtMessege;
        private Button newBut;
        private Button saveBut;
        private Button readBut;
        private Button deleteBut;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
    }
}