
namespace PR3
{
    partial class FormBan
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.administratorsidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bantypeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bantimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentfromadminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.banlistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pR3DataSet = new PR3.PR3DataSet();
            this.ban_listTableAdapter = new PR3.PR3DataSetTableAdapters.Ban_listTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banlistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pR3DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.playeridDataGridViewTextBoxColumn,
            this.administratorsidDataGridViewTextBoxColumn,
            this.bantypeidDataGridViewTextBoxColumn,
            this.bantimeDataGridViewTextBoxColumn,
            this.commentfromadminDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.banlistBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(505, 236);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 40;
            // 
            // playeridDataGridViewTextBoxColumn
            // 
            this.playeridDataGridViewTextBoxColumn.DataPropertyName = "Player_id";
            this.playeridDataGridViewTextBoxColumn.HeaderText = "Player_id";
            this.playeridDataGridViewTextBoxColumn.Name = "playeridDataGridViewTextBoxColumn";
            this.playeridDataGridViewTextBoxColumn.Width = 80;
            // 
            // administratorsidDataGridViewTextBoxColumn
            // 
            this.administratorsidDataGridViewTextBoxColumn.DataPropertyName = "Administrators_id";
            this.administratorsidDataGridViewTextBoxColumn.HeaderText = "Administrators_id";
            this.administratorsidDataGridViewTextBoxColumn.Name = "administratorsidDataGridViewTextBoxColumn";
            this.administratorsidDataGridViewTextBoxColumn.Width = 90;
            // 
            // bantypeidDataGridViewTextBoxColumn
            // 
            this.bantypeidDataGridViewTextBoxColumn.DataPropertyName = "Ban_type_id";
            this.bantypeidDataGridViewTextBoxColumn.HeaderText = "Ban_type_id";
            this.bantypeidDataGridViewTextBoxColumn.Name = "bantypeidDataGridViewTextBoxColumn";
            this.bantypeidDataGridViewTextBoxColumn.Width = 80;
            // 
            // bantimeDataGridViewTextBoxColumn
            // 
            this.bantimeDataGridViewTextBoxColumn.DataPropertyName = "Ban_time";
            this.bantimeDataGridViewTextBoxColumn.HeaderText = "Ban_time";
            this.bantimeDataGridViewTextBoxColumn.Name = "bantimeDataGridViewTextBoxColumn";
            this.bantimeDataGridViewTextBoxColumn.Width = 60;
            // 
            // commentfromadminDataGridViewTextBoxColumn
            // 
            this.commentfromadminDataGridViewTextBoxColumn.DataPropertyName = "Comment_from_admin";
            this.commentfromadminDataGridViewTextBoxColumn.HeaderText = "Comment_from_admin";
            this.commentfromadminDataGridViewTextBoxColumn.Name = "commentfromadminDataGridViewTextBoxColumn";
            this.commentfromadminDataGridViewTextBoxColumn.Width = 160;
            // 
            // banlistBindingSource
            // 
            this.banlistBindingSource.DataMember = "Ban_list";
            this.banlistBindingSource.DataSource = this.pR3DataSet;
            // 
            // pR3DataSet
            // 
            this.pR3DataSet.DataSetName = "PR3DataSet";
            this.pR3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ban_listTableAdapter
            // 
            this.ban_listTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 259);
            this.panel1.TabIndex = 1;
            // 
            // FormBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(529, 259);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBan";
            this.Text = "Ban list";
            this.Load += new System.EventHandler(this.FormBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banlistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pR3DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PR3DataSet pR3DataSet;
        private System.Windows.Forms.BindingSource banlistBindingSource;
        private PR3DataSetTableAdapters.Ban_listTableAdapter ban_listTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn administratorsidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bantypeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bantimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentfromadminDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
    }
}