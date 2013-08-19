namespace ArdupilotMega.GCSViews
{
    partial class NanosatGCS
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NanosatGCS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainH = new System.Windows.Forms.SplitContainer();
            this.SubMainLeft = new System.Windows.Forms.SplitContainer();
            this.tableMap = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.zg1 = new ZedGraph.ZedGraphControl();
            this.lbl_winddir = new ArdupilotMega.Controls.MyLabel();
            this.lbl_windvel = new ArdupilotMega.Controls.MyLabel();
            this.lbl_hdop = new ArdupilotMega.Controls.MyLabel();
            this.lbl_sats = new ArdupilotMega.Controls.MyLabel();
            this.TRK_zoom = new ArdupilotMega.Controls.MyTrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TXT_lat = new ArdupilotMega.Controls.MyLabel();
            this.Zoomlevel = new System.Windows.Forms.NumericUpDown();
            this.label1 = new ArdupilotMega.Controls.MyLabel();
            this.TXT_long = new ArdupilotMega.Controls.MyLabel();
            this.TXT_alt = new ArdupilotMega.Controls.MyLabel();
            this.CHK_autopan = new System.Windows.Forms.CheckBox();
            this.CB_tuning = new System.Windows.Forms.CheckBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.MainH.Panel1.SuspendLayout();
            this.MainH.Panel2.SuspendLayout();
            this.MainH.SuspendLayout();
            this.SubMainLeft.SuspendLayout();
            this.tableMap.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TRK_zoom)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Zoomlevel)).BeginInit();
            this.SuspendLayout();
            // 
            // MainH
            // 
            this.MainH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.MainH, "MainH");
            this.MainH.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.MainH.Name = "MainH";
            // 
            // MainH.Panel1
            // 
            this.MainH.Panel1.Controls.Add(this.SubMainLeft);
            // 
            // MainH.Panel2
            // 
            this.MainH.Panel2.Controls.Add(this.tableMap);
            // 
            // SubMainLeft
            // 
            this.SubMainLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.SubMainLeft, "SubMainLeft");
            this.SubMainLeft.Name = "SubMainLeft";
            // 
            // tableMap
            // 
            resources.ApplyResources(this.tableMap, "tableMap");
            this.tableMap.Controls.Add(this.splitContainer1, 0, 0);
            this.tableMap.Controls.Add(this.panel1, 0, 1);
            this.tableMap.Name = "tableMap";
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.zg1);
            this.splitContainer1.Panel1Collapsed = true;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lbl_winddir);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_windvel);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_hdop);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_sats);
            this.splitContainer1.Panel2.Controls.Add(this.TRK_zoom);
            // 
            // zg1
            // 
            resources.ApplyResources(this.zg1, "zg1");
            this.zg1.Name = "zg1";
            this.zg1.ScrollGrace = 0D;
            this.zg1.ScrollMaxX = 0D;
            this.zg1.ScrollMaxY = 0D;
            this.zg1.ScrollMaxY2 = 0D;
            this.zg1.ScrollMinX = 0D;
            this.zg1.ScrollMinY = 0D;
            this.zg1.ScrollMinY2 = 0D;

            // 
            // lbl_winddir
            // 
            resources.ApplyResources(this.lbl_winddir, "lbl_winddir");
            this.lbl_winddir.Name = "lbl_winddir";
            this.lbl_winddir.resize = true;
            // 
            // lbl_windvel
            // 
            resources.ApplyResources(this.lbl_windvel, "lbl_windvel");
            this.lbl_windvel.Name = "lbl_windvel";
            this.lbl_windvel.resize = true;
            // 
            // lbl_hdop
            // 
            resources.ApplyResources(this.lbl_hdop, "lbl_hdop");
            this.lbl_hdop.Name = "lbl_hdop";
            this.lbl_hdop.resize = true;
            // 
            // lbl_sats
            // 
            resources.ApplyResources(this.lbl_sats, "lbl_sats");
            this.lbl_sats.Name = "lbl_sats";
            this.lbl_sats.resize = true;
            // 
            // TRK_zoom
            // 

            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TXT_lat);
            this.panel1.Controls.Add(this.Zoomlevel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TXT_long);
            this.panel1.Controls.Add(this.TXT_alt);
            this.panel1.Controls.Add(this.CHK_autopan);
            this.panel1.Controls.Add(this.CB_tuning);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // TXT_lat
            // 
            resources.ApplyResources(this.TXT_lat, "TXT_lat");
            this.TXT_lat.Name = "TXT_lat";
            this.TXT_lat.resize = false;
            // 
            // Zoomlevel
            // 
            resources.ApplyResources(this.Zoomlevel, "Zoomlevel");
            this.Zoomlevel.DecimalPlaces = 1;
            this.Zoomlevel.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.Zoomlevel.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.Zoomlevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Zoomlevel.Name = "Zoomlevel";
            this.Zoomlevel.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.resize = false;
            // 
            // TXT_long
            // 
            resources.ApplyResources(this.TXT_long, "TXT_long");
            this.TXT_long.Name = "TXT_long";
            this.TXT_long.resize = false;
            // 
            // TXT_alt
            // 
            resources.ApplyResources(this.TXT_alt, "TXT_alt");
            this.TXT_alt.Name = "TXT_alt";
            this.TXT_alt.resize = false;
            // 
            // CHK_autopan
            // 
            resources.ApplyResources(this.CHK_autopan, "CHK_autopan");
            this.CHK_autopan.Checked = true;
            this.CHK_autopan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHK_autopan.Name = "CHK_autopan";
            this.CHK_autopan.UseVisualStyleBackColor = true;

            // 
            // CB_tuning
            // 
            resources.ApplyResources(this.CB_tuning, "CB_tuning");
            this.CB_tuning.Name = "CB_tuning";
            this.CB_tuning.UseVisualStyleBackColor = true;
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.dataGridViewImageColumn1, "dataGridViewImageColumn1");
            this.dataGridViewImageColumn1.Image = global::ArdupilotMega.Properties.Resources.up;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.dataGridViewImageColumn2, "dataGridViewImageColumn2");
            this.dataGridViewImageColumn2.Image = global::ArdupilotMega.Properties.Resources.down;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // NanosatGCS
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainH);
            this.MinimumSize = new System.Drawing.Size(1008, 461);
            this.Name = "NanosatGCS";

            this.Load += new System.EventHandler(this.NanosatGCS_Load);

            this.MainH.Panel1.ResumeLayout(false);
            this.MainH.Panel2.ResumeLayout(false);
            this.MainH.ResumeLayout(false);
            this.SubMainLeft.ResumeLayout(false);
            this.tableMap.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TRK_zoom)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Zoomlevel)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.SplitContainer MainH;
        private System.Windows.Forms.SplitContainer SubMainLeft;
        private System.Windows.Forms.CheckBox CB_tuning;
        private System.Windows.Forms.TableLayoutPanel tableMap;
        private System.Windows.Forms.Panel panel1;
        private ArdupilotMega.Controls.MyLabel TXT_lat;
        private System.Windows.Forms.NumericUpDown Zoomlevel;
        private ArdupilotMega.Controls.MyLabel label1;
        private ArdupilotMega.Controls.MyLabel TXT_long;
        private ArdupilotMega.Controls.MyLabel TXT_alt;
        private System.Windows.Forms.CheckBox CHK_autopan;
        private ZedGraph.ZedGraphControl zg1;
        private ArdupilotMega.Controls.MyLabel lbl_windvel;
        private ArdupilotMega.Controls.MyLabel lbl_winddir;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private ArdupilotMega.Controls.MyLabel lbl_hdop;
        private ArdupilotMega.Controls.MyLabel lbl_sats;
        //private Crom.Controls.Docking.DockContainer dockContainer1;
        private Controls.MyTrackBar TRK_zoom;

    }
}