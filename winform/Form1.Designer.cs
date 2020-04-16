namespace winform
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
            this.btnFeed = new System.Windows.Forms.Button();
            this.dgElephant = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.canWalkDataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.elephantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dgGiraffe = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.canWalkDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.giraffeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblGiraffe = new System.Windows.Forms.Label();
            this.dgMonkey = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.canWalkDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.monkeyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblMonkey = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgElephant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elephantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGiraffe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giraffeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMonkey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monkeyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFeed
            // 
            this.btnFeed.Location = new System.Drawing.Point(406, 364);
            this.btnFeed.Name = "btnFeed";
            this.btnFeed.Size = new System.Drawing.Size(247, 37);
            this.btnFeed.TabIndex = 0;
            this.btnFeed.Text = "Feed";
            this.btnFeed.UseVisualStyleBackColor = true;
            this.btnFeed.Click += new System.EventHandler(this.btnFeed_Click);
            // 
            // dgElephant
            // 
            this.dgElephant.AllowUserToOrderColumns = true;
            this.dgElephant.AutoGenerateColumns = false;
            this.dgElephant.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgElephant.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgElephant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgElephant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn3,
            this.canWalkDataGridViewCheckBoxColumn2});
            this.dgElephant.DataSource = this.elephantBindingSource;
            this.dgElephant.Location = new System.Drawing.Point(43, 112);
            this.dgElephant.Name = "dgElephant";
            this.dgElephant.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgElephant.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgElephant.Size = new System.Drawing.Size(240, 150);
            this.dgElephant.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FeedValue";
            this.dataGridViewTextBoxColumn3.HeaderText = "FeedValue";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "IsLive";
            this.dataGridViewCheckBoxColumn3.HeaderText = "IsLive";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            // 
            // canWalkDataGridViewCheckBoxColumn2
            // 
            this.canWalkDataGridViewCheckBoxColumn2.DataPropertyName = "CanWalk";
            this.canWalkDataGridViewCheckBoxColumn2.HeaderText = "CanWalk";
            this.canWalkDataGridViewCheckBoxColumn2.Name = "canWalkDataGridViewCheckBoxColumn2";
            // 
            // elephantBindingSource
            // 
            this.elephantBindingSource.DataSource = typeof(Dyball.Domain.Elephant);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 53);
            this.label1.TabIndex = 2;
            this.label1.Text = "Elephant";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgGiraffe
            // 
            this.dgGiraffe.AutoGenerateColumns = false;
            this.dgGiraffe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGiraffe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewCheckBoxColumn1,
            this.canWalkDataGridViewCheckBoxColumn});
            this.dgGiraffe.DataSource = this.giraffeBindingSource;
            this.dgGiraffe.Location = new System.Drawing.Point(406, 112);
            this.dgGiraffe.Name = "dgGiraffe";
            this.dgGiraffe.Size = new System.Drawing.Size(240, 150);
            this.dgGiraffe.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FeedValue";
            this.dataGridViewTextBoxColumn1.HeaderText = "FeedValue";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsLive";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IsLive";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // canWalkDataGridViewCheckBoxColumn
            // 
            this.canWalkDataGridViewCheckBoxColumn.DataPropertyName = "CanWalk";
            this.canWalkDataGridViewCheckBoxColumn.HeaderText = "CanWalk";
            this.canWalkDataGridViewCheckBoxColumn.Name = "canWalkDataGridViewCheckBoxColumn";
            this.canWalkDataGridViewCheckBoxColumn.Visible = false;
            // 
            // giraffeBindingSource
            // 
            this.giraffeBindingSource.DataSource = typeof(Dyball.Domain.Giraffe);
            // 
            // lblGiraffe
            // 
            this.lblGiraffe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiraffe.Location = new System.Drawing.Point(410, 44);
            this.lblGiraffe.Name = "lblGiraffe";
            this.lblGiraffe.Size = new System.Drawing.Size(199, 53);
            this.lblGiraffe.TabIndex = 4;
            this.lblGiraffe.Text = "Giraffe";
            this.lblGiraffe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgMonkey
            // 
            this.dgMonkey.AutoGenerateColumns = false;
            this.dgMonkey.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMonkey.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn2,
            this.canWalkDataGridViewCheckBoxColumn1});
            this.dgMonkey.DataSource = this.monkeyBindingSource;
            this.dgMonkey.Location = new System.Drawing.Point(783, 112);
            this.dgMonkey.Name = "dgMonkey";
            this.dgMonkey.Size = new System.Drawing.Size(240, 150);
            this.dgMonkey.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FeedValue";
            this.dataGridViewTextBoxColumn2.HeaderText = "FeedValue";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "IsLive";
            this.dataGridViewCheckBoxColumn2.HeaderText = "IsLive";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // canWalkDataGridViewCheckBoxColumn1
            // 
            this.canWalkDataGridViewCheckBoxColumn1.DataPropertyName = "CanWalk";
            this.canWalkDataGridViewCheckBoxColumn1.HeaderText = "CanWalk";
            this.canWalkDataGridViewCheckBoxColumn1.Name = "canWalkDataGridViewCheckBoxColumn1";
            this.canWalkDataGridViewCheckBoxColumn1.Visible = false;
            // 
            // monkeyBindingSource
            // 
            this.monkeyBindingSource.DataSource = typeof(Dyball.Domain.Monkey);
            // 
            // lblMonkey
            // 
            this.lblMonkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonkey.Location = new System.Drawing.Point(786, 44);
            this.lblMonkey.Name = "lblMonkey";
            this.lblMonkey.Size = new System.Drawing.Size(199, 53);
            this.lblMonkey.TabIndex = 6;
            this.lblMonkey.Text = "Monkey";
            this.lblMonkey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(436, 20);
            this.lblTime.MaximumSize = new System.Drawing.Size(400, 50);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(182, 25);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "Display current time";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 418);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblMonkey);
            this.Controls.Add(this.dgMonkey);
            this.Controls.Add(this.lblGiraffe);
            this.Controls.Add(this.dgGiraffe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgElephant);
            this.Controls.Add(this.btnFeed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgElephant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elephantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGiraffe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giraffeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMonkey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monkeyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFeed;
        private System.Windows.Forms.DataGridView dgElephant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgGiraffe;
        private System.Windows.Forms.Label lblGiraffe;
        private System.Windows.Forms.DataGridView dgMonkey;
        private System.Windows.Forms.Label lblMonkey;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isLiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedValueDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedValueDataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource giraffeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn canWalkDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn canWalkDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.BindingSource monkeyBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn canWalkDataGridViewCheckBoxColumn2;
        private System.Windows.Forms.BindingSource elephantBindingSource;
        private System.Windows.Forms.Label lblTime;
    }
}

