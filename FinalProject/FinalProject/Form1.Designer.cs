namespace FinalProject
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.open = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.open_dir = new System.Windows.Forms.Button();
            this.next_img = new System.Windows.Forms.Button();
            this.pre_img = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.labellist = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addlabel = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.autoload = new System.Windows.Forms.CheckBox();
            this.autosave = new System.Windows.Forms.CheckBox();
            this.voccb = new System.Windows.Forms.CheckBox();
            this.yolocb = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // open
            // 
            this.open.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.open.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("open.BackgroundImage")));
            this.open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.open.FlatAppearance.BorderSize = 0;
            this.open.Location = new System.Drawing.Point(1, 0);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(57, 60);
            this.open.TabIndex = 0;
            this.open.Text = "open";
            this.open.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.open.UseVisualStyleBackColor = false;
            this.open.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // open_dir
            // 
            this.open_dir.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.open_dir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("open_dir.BackgroundImage")));
            this.open_dir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.open_dir.FlatAppearance.BorderSize = 0;
            this.open_dir.Location = new System.Drawing.Point(1, 57);
            this.open_dir.Name = "open_dir";
            this.open_dir.Size = new System.Drawing.Size(57, 60);
            this.open_dir.TabIndex = 1;
            this.open_dir.Text = "open dir";
            this.open_dir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.open_dir.UseVisualStyleBackColor = false;
            this.open_dir.Click += new System.EventHandler(this.open_dir_Click);
            // 
            // next_img
            // 
            this.next_img.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.next_img.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("next_img.BackgroundImage")));
            this.next_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.next_img.FlatAppearance.BorderSize = 0;
            this.next_img.Location = new System.Drawing.Point(1, 116);
            this.next_img.Name = "next_img";
            this.next_img.Size = new System.Drawing.Size(57, 60);
            this.next_img.TabIndex = 2;
            this.next_img.Text = "next img";
            this.next_img.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.next_img.UseVisualStyleBackColor = false;
            this.next_img.Click += new System.EventHandler(this.next_img_Click);
            // 
            // pre_img
            // 
            this.pre_img.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pre_img.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pre_img.BackgroundImage")));
            this.pre_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pre_img.FlatAppearance.BorderSize = 0;
            this.pre_img.Location = new System.Drawing.Point(1, 175);
            this.pre_img.Name = "pre_img";
            this.pre_img.Size = new System.Drawing.Size(57, 60);
            this.pre_img.TabIndex = 3;
            this.pre_img.Text = "pre img";
            this.pre_img.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pre_img.UseVisualStyleBackColor = false;
            this.pre_img.Click += new System.EventHandler(this.pre_img_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("save.BackgroundImage")));
            this.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.save.FlatAppearance.BorderSize = 0;
            this.save.Location = new System.Drawing.Point(1, 234);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(57, 60);
            this.save.TabIndex = 4;
            this.save.Text = "save";
            this.save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(739, 294);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(196, 412);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            // 
            // labellist
            // 
            this.labellist.FormattingEnabled = true;
            this.labellist.ItemHeight = 12;
            this.labellist.Location = new System.Drawing.Point(756, 83);
            this.labellist.Name = "labellist";
            this.labellist.Size = new System.Drawing.Size(169, 172);
            this.labellist.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(861, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(884, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(8, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(898, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(64, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(666, 666);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(754, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "Label list";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(756, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 22);
            this.textBox1.TabIndex = 12;
            // 
            // addlabel
            // 
            this.addlabel.Location = new System.Drawing.Point(878, 59);
            this.addlabel.Name = "addlabel";
            this.addlabel.Size = new System.Drawing.Size(47, 23);
            this.addlabel.TabIndex = 13;
            this.addlabel.Text = "add";
            this.addlabel.UseVisualStyleBackColor = true;
            this.addlabel.Click += new System.EventHandler(this.addlabel_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(878, 33);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(47, 23);
            this.delete.TabIndex = 14;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(1, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 60);
            this.button1.TabIndex = 15;
            this.button1.Text = "load ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // autoload
            // 
            this.autoload.AutoSize = true;
            this.autoload.Location = new System.Drawing.Point(959, 66);
            this.autoload.Name = "autoload";
            this.autoload.Size = new System.Drawing.Size(70, 16);
            this.autoload.TabIndex = 16;
            this.autoload.Text = "Auto load";
            this.autoload.UseVisualStyleBackColor = true;
            // 
            // autosave
            // 
            this.autosave.AutoSize = true;
            this.autosave.Location = new System.Drawing.Point(959, 44);
            this.autosave.Name = "autosave";
            this.autosave.Size = new System.Drawing.Size(70, 16);
            this.autosave.TabIndex = 17;
            this.autosave.Text = "Auto save";
            this.autosave.UseVisualStyleBackColor = true;
            // 
            // voccb
            // 
            this.voccb.AutoSize = true;
            this.voccb.Location = new System.Drawing.Point(1035, 66);
            this.voccb.Name = "voccb";
            this.voccb.Size = new System.Drawing.Size(43, 16);
            this.voccb.TabIndex = 18;
            this.voccb.Text = "Voc";
            this.voccb.UseVisualStyleBackColor = true;
            // 
            // yolocb
            // 
            this.yolocb.AutoSize = true;
            this.yolocb.Location = new System.Drawing.Point(1035, 44);
            this.yolocb.Name = "yolocb";
            this.yolocb.Size = new System.Drawing.Size(47, 16);
            this.yolocb.TabIndex = 19;
            this.yolocb.Text = "Yolo";
            this.yolocb.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1130, 723);
            this.Controls.Add(this.yolocb);
            this.Controls.Add(this.voccb);
            this.Controls.Add(this.autosave);
            this.Controls.Add(this.autoload);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.addlabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labellist);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.pre_img);
            this.Controls.Add(this.next_img);
            this.Controls.Add(this.open_dir);
            this.Controls.Add(this.open);
            this.Name = "Form1";
            this.Text = "Label Tool";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button open;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button open_dir;
        private System.Windows.Forms.Button next_img;
        private System.Windows.Forms.Button pre_img;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ListBox listBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListBox labellist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addlabel;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox autoload;
        private System.Windows.Forms.CheckBox autosave;
        private System.Windows.Forms.CheckBox voccb;
        private System.Windows.Forms.CheckBox yolocb;
    }
}

