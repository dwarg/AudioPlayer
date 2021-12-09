namespace player
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
            System.Windows.Forms.Button btn_play;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip_main = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.songsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_add = new System.Windows.Forms.Button();
            this.listBox_songs = new System.Windows.Forms.ListBox();
            this.trackBar_volume = new System.Windows.Forms.TrackBar();
            this.btn_goFor = new System.Windows.Forms.Button();
            this.btn_goBack = new System.Windows.Forms.Button();
            this.btn_mute = new System.Windows.Forms.Button();
            this.btn_Pause = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_Previousbtn_Previous = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            btn_play = new System.Windows.Forms.Button();
            this.menuStrip_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_play
            // 
            btn_play.BackColor = System.Drawing.Color.White;
            btn_play.BackgroundImage = global::player.Properties.Resources.play;
            btn_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_play.Location = new System.Drawing.Point(105, 300);
            btn_play.Name = "btn_play";
            btn_play.Size = new System.Drawing.Size(33, 23);
            btn_play.TabIndex = 1;
            btn_play.UseVisualStyleBackColor = false;
            btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // menuStrip_main
            // 
            this.menuStrip_main.BackColor = System.Drawing.Color.Black;
            this.menuStrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip_main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_main.Name = "menuStrip_main";
            this.menuStrip_main.Size = new System.Drawing.Size(455, 24);
            this.menuStrip_main.TabIndex = 0;
            this.menuStrip_main.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSongToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.DropDownClosed += new System.EventHandler(this.fileToolStripMenuItem_DropDownClosed_1);
            this.fileToolStripMenuItem.DropDownOpened += new System.EventHandler(this.fileToolStripMenuItem_DropDownOpened_1);
            // 
            // addSongToolStripMenuItem
            // 
            this.addSongToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addSongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singleSongToolStripMenuItem,
            this.songsToolStripMenuItem});
            this.addSongToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addSongToolStripMenuItem.Name = "addSongToolStripMenuItem";
            this.addSongToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.addSongToolStripMenuItem.Text = "Add Song";
            // 
            // singleSongToolStripMenuItem
            // 
            this.singleSongToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.singleSongToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.singleSongToolStripMenuItem.Name = "singleSongToolStripMenuItem";
            this.singleSongToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.singleSongToolStripMenuItem.Text = "Single Song";
            this.singleSongToolStripMenuItem.Click += new System.EventHandler(this.singleSongToolStripMenuItem_Click);
            // 
            // songsToolStripMenuItem
            // 
            this.songsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.songsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.songsToolStripMenuItem.Name = "songsToolStripMenuItem";
            this.songsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.songsToolStripMenuItem.Text = "Songs";
            this.songsToolStripMenuItem.Click += new System.EventHandler(this.songsToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.closeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_add.Location = new System.Drawing.Point(389, 480);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(40, 22);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // listBox_songs
            // 
            this.listBox_songs.AllowDrop = true;
            this.listBox_songs.BackColor = System.Drawing.Color.Black;
            this.listBox_songs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_songs.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.listBox_songs.FormattingEnabled = true;
            this.listBox_songs.ItemHeight = 15;
            this.listBox_songs.Location = new System.Drawing.Point(30, 352);
            this.listBox_songs.Name = "listBox_songs";
            this.listBox_songs.Size = new System.Drawing.Size(356, 169);
            this.listBox_songs.TabIndex = 4;
            this.listBox_songs.SelectedIndexChanged += new System.EventHandler(this.listBox_songs_SelectedIndexChanged);
            this.listBox_songs.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_songs_DragDrop);
            this.listBox_songs.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox_songs_DragEnter);
            // 
            // trackBar_volume
            // 
            this.trackBar_volume.LargeChange = 3;
            this.trackBar_volume.Location = new System.Drawing.Point(303, 300);
            this.trackBar_volume.Name = "trackBar_volume";
            this.trackBar_volume.Size = new System.Drawing.Size(91, 45);
            this.trackBar_volume.TabIndex = 8;
            this.trackBar_volume.Value = 5;
            this.trackBar_volume.Scroll += new System.EventHandler(this.trackBar_volume_Scroll);
            // 
            // btn_goFor
            // 
            this.btn_goFor.BackColor = System.Drawing.Color.White;
            this.btn_goFor.BackgroundImage = global::player.Properties.Resources.goForw;
            this.btn_goFor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_goFor.Location = new System.Drawing.Point(238, 300);
            this.btn_goFor.Name = "btn_goFor";
            this.btn_goFor.Size = new System.Drawing.Size(30, 23);
            this.btn_goFor.TabIndex = 12;
            this.btn_goFor.Text = ">>";
            this.btn_goFor.UseVisualStyleBackColor = false;
            this.btn_goFor.Click += new System.EventHandler(this.btn_goFor_Click);
            // 
            // btn_goBack
            // 
            this.btn_goBack.BackColor = System.Drawing.Color.White;
            this.btn_goBack.BackgroundImage = global::player.Properties.Resources.goBack;
            this.btn_goBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_goBack.Location = new System.Drawing.Point(33, 300);
            this.btn_goBack.Name = "btn_goBack";
            this.btn_goBack.Size = new System.Drawing.Size(30, 23);
            this.btn_goBack.TabIndex = 11;
            this.btn_goBack.Text = "<<";
            this.btn_goBack.UseVisualStyleBackColor = false;
            this.btn_goBack.Click += new System.EventHandler(this.btn_goBack_Click);
            // 
            // btn_mute
            // 
            this.btn_mute.BackColor = System.Drawing.Color.White;
            this.btn_mute.BackgroundImage = global::player.Properties.Resources.mute_no;
            this.btn_mute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_mute.Location = new System.Drawing.Point(274, 300);
            this.btn_mute.Name = "btn_mute";
            this.btn_mute.Size = new System.Drawing.Size(23, 23);
            this.btn_mute.TabIndex = 9;
            this.btn_mute.UseVisualStyleBackColor = false;
            this.btn_mute.Click += new System.EventHandler(this.btn_mute_Click);
            // 
            // btn_Pause
            // 
            this.btn_Pause.BackColor = System.Drawing.Color.White;
            this.btn_Pause.BackgroundImage = global::player.Properties.Resources.pause;
            this.btn_Pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Pause.Location = new System.Drawing.Point(144, 300);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(23, 23);
            this.btn_Pause.TabIndex = 7;
            this.btn_Pause.UseVisualStyleBackColor = false;
            this.btn_Pause.Click += new System.EventHandler(this.btn_Pause_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.White;
            this.btn_next.BackgroundImage = global::player.Properties.Resources.next;
            this.btn_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_next.Location = new System.Drawing.Point(202, 300);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(30, 23);
            this.btn_next.TabIndex = 6;
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_Previousbtn_Previous
            // 
            this.btn_Previousbtn_Previous.BackColor = System.Drawing.Color.White;
            this.btn_Previousbtn_Previous.BackgroundImage = global::player.Properties.Resources.prev;
            this.btn_Previousbtn_Previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Previousbtn_Previous.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Previousbtn_Previous.Location = new System.Drawing.Point(69, 300);
            this.btn_Previousbtn_Previous.Name = "btn_Previousbtn_Previous";
            this.btn_Previousbtn_Previous.Size = new System.Drawing.Size(30, 23);
            this.btn_Previousbtn_Previous.TabIndex = 5;
            this.btn_Previousbtn_Previous.UseVisualStyleBackColor = false;
            this.btn_Previousbtn_Previous.Click += new System.EventHandler(this.btn_Previousbtn_Previous_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.Color.White;
            this.btn_stop.BackgroundImage = global::player.Properties.Resources.stop;
            this.btn_stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_stop.Location = new System.Drawing.Point(173, 300);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(23, 23);
            this.btn_stop.TabIndex = 2;
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(30, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Losowo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(320, 527);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Pętla";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(201, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(170, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "-:--";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(210, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "-:--";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(389, 499);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 22);
            this.button3.TabIndex = 21;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(389, 355);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 24);
            this.button4.TabIndex = 22;
            this.button4.Text = "up";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(389, 376);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 24);
            this.button5.TabIndex = 23;
            this.button5.Text = "down";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(74, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(170, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "-";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(170, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "-";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(455, 562);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_goFor);
            this.Controls.Add(this.btn_goBack);
            this.Controls.Add(this.btn_mute);
            this.Controls.Add(this.trackBar_volume);
            this.Controls.Add(this.btn_Pause);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_Previousbtn_Previous);
            this.Controls.Add(this.listBox_songs);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(btn_play);
            this.Controls.Add(this.menuStrip_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_main;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "player";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip_main.ResumeLayout(false);
            this.menuStrip_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_main;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ListBox listBox_songs;
        private System.Windows.Forms.Button btn_Previousbtn_Previous;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_Pause;
        private System.Windows.Forms.ToolStripMenuItem addSongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleSongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem songsToolStripMenuItem;
        private System.Windows.Forms.TrackBar trackBar_volume;
        private System.Windows.Forms.Button btn_mute;
        private System.Windows.Forms.Button btn_goBack;
        private System.Windows.Forms.Button btn_goFor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

