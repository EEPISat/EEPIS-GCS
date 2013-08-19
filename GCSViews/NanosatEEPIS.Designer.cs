namespace ArdupilotMega.GCSViews
{
    partial class NanosatEEPIS
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NanosatEEPIS));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitBig = new System.Windows.Forms.SplitContainer();
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.tabControlUmum = new System.Windows.Forms.TabControl();
            this.tabData = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LVOrbit = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.LAzimuth = new System.Windows.Forms.Label();
            this.LAltitude = new System.Windows.Forms.Label();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LElevasi = new System.Windows.Forms.Label();
            this.Llatitude = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabGrafik = new System.Windows.Forms.TabPage();
            this.grafik = new ZedGraph.ZedGraphControl();
            this.tabStatHard = new System.Windows.Forms.TabPage();
            this.Gauge3 = new AGaugeApp.AGauge();
            this.Gauge2 = new AGaugeApp.AGauge();
            this.Gauge1 = new AGaugeApp.AGauge();
            this.tabAll = new System.Windows.Forms.TabPage();
            this.splitSmall = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBoxGrafik = new System.Windows.Forms.CheckBox();
            this.checkDataSatelit = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.monitor = new ArdupilotMega.Controls.HUD();
            this.currentStateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TGrafik = new System.Windows.Forms.Timer(this.components);
            this.ZedGraphTimer = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitBig.Panel1.SuspendLayout();
            this.splitBig.Panel2.SuspendLayout();
            this.splitBig.SuspendLayout();
            this.tabControlUmum.SuspendLayout();
            this.tabData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.tabGrafik.SuspendLayout();
            this.tabStatHard.SuspendLayout();
            this.splitSmall.Panel1.SuspendLayout();
            this.splitSmall.Panel2.SuspendLayout();
            this.splitSmall.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentStateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitBig);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitSmall);
            // 
            // splitBig
            // 
            resources.ApplyResources(this.splitBig, "splitBig");
            this.splitBig.Name = "splitBig";
            // 
            // splitBig.Panel1
            // 
            this.splitBig.Panel1.Controls.Add(this.gMap);
            // 
            // splitBig.Panel2
            // 
            this.splitBig.Panel2.Controls.Add(this.tabControlUmum);
            // 
            // gMap
            // 
            this.gMap.Bearing = 0F;
            this.gMap.CanDragMap = true;
            this.gMap.GrayScaleMode = false;
            this.gMap.LevelsKeepInMemmory = 5;
            resources.ApplyResources(this.gMap, "gMap");
            this.gMap.MarkersEnabled = true;
            this.gMap.MaxZoom = 19;
            this.gMap.MinZoom = 2;
            this.gMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMap.Name = "gMap";
            this.gMap.NegativeMode = false;
            this.gMap.PolygonsEnabled = true;
            this.gMap.RetryLoadTile = 0;
            this.gMap.RoutesEnabled = true;
            this.gMap.ShowTileGridLines = false;
            this.gMap.streamjpg = ((System.IO.MemoryStream)(resources.GetObject("gMap.streamjpg")));
            this.gMap.Zoom = 0D;
            // 
            // tabControlUmum
            // 
            this.tabControlUmum.Controls.Add(this.tabData);
            this.tabControlUmum.Controls.Add(this.tabGrafik);
            this.tabControlUmum.Controls.Add(this.tabStatHard);
            this.tabControlUmum.Controls.Add(this.tabAll);
            resources.ApplyResources(this.tabControlUmum, "tabControlUmum");
            this.tabControlUmum.Name = "tabControlUmum";
            this.tabControlUmum.SelectedIndex = 0;
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.label13);
            this.tabData.Controls.Add(this.label12);
            this.tabData.Controls.Add(this.label11);
            this.tabData.Controls.Add(this.label10);
            this.tabData.Controls.Add(this.LVOrbit);
            this.tabData.Controls.Add(this.label14);
            this.tabData.Controls.Add(this.LAzimuth);
            this.tabData.Controls.Add(this.LAltitude);
            this.tabData.Controls.Add(this.LElevasi);
            this.tabData.Controls.Add(this.Llatitude);
            this.tabData.Controls.Add(this.label9);
            this.tabData.Controls.Add(this.label8);
            this.tabData.Controls.Add(this.label7);
            this.tabData.Controls.Add(this.label6);
            this.tabData.Controls.Add(this.label5);
            this.tabData.Controls.Add(this.label4);
            this.tabData.Controls.Add(this.label3);
            this.tabData.Controls.Add(this.label2);
            this.tabData.Controls.Add(this.label1);
            resources.ApplyResources(this.tabData, "tabData");
            this.tabData.Name = "tabData";
            this.tabData.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.ForeColor = System.Drawing.Color.Magenta;
            this.label13.Name = "label13";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.ForeColor = System.Drawing.Color.Magenta;
            this.label12.Name = "label12";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.ForeColor = System.Drawing.Color.Magenta;
            this.label11.Name = "label11";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.ForeColor = System.Drawing.Color.Magenta;
            this.label10.Name = "label10";
            // 
            // LVOrbit
            // 
            resources.ApplyResources(this.LVOrbit, "LVOrbit");
            this.LVOrbit.ForeColor = System.Drawing.Color.Magenta;
            this.LVOrbit.Name = "LVOrbit";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.ForeColor = System.Drawing.Color.Lime;
            this.label14.Name = "label14";
            // 
            // LAzimuth
            // 
            resources.ApplyResources(this.LAzimuth, "LAzimuth");
            this.LAzimuth.ForeColor = System.Drawing.Color.Lime;
            this.LAzimuth.Name = "LAzimuth";
            // 
            // LAltitude
            // 
            resources.ApplyResources(this.LAltitude, "LAltitude");
            this.LAltitude.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "alt", true));
            this.LAltitude.ForeColor = System.Drawing.Color.Yellow;
            this.LAltitude.Name = "LAltitude";
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(ArdupilotMega.CurrentState);
            // 
            // LElevasi
            // 
            resources.ApplyResources(this.LElevasi, "LElevasi");
            this.LElevasi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "roll", true));
            this.LElevasi.ForeColor = System.Drawing.Color.Magenta;
            this.LElevasi.Name = "LElevasi";
            // 
            // Llatitude
            // 
            resources.ApplyResources(this.Llatitude, "Llatitude");
            this.Llatitude.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "lat", true));
            this.Llatitude.ForeColor = System.Drawing.Color.Lime;
            this.Llatitude.Name = "Llatitude";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Magenta;
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Magenta;
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Magenta;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "lng", true));
            this.label1.ForeColor = System.Drawing.Color.Magenta;
            this.label1.Name = "label1";
            // 
            // tabGrafik
            // 
            this.tabGrafik.Controls.Add(this.grafik);
            resources.ApplyResources(this.tabGrafik, "tabGrafik");
            this.tabGrafik.Name = "tabGrafik";
            this.tabGrafik.UseVisualStyleBackColor = true;
            // 
            // grafik
            // 
            resources.ApplyResources(this.grafik, "grafik");
            this.grafik.Name = "grafik";
            this.grafik.ScrollGrace = 0D;
            this.grafik.ScrollMaxX = 0D;
            this.grafik.ScrollMaxY = 0D;
            this.grafik.ScrollMaxY2 = 0D;
            this.grafik.ScrollMinX = 0D;
            this.grafik.ScrollMinY = 0D;
            this.grafik.ScrollMinY2 = 0D;
            this.grafik.DoubleClick += new System.EventHandler(this.grafik_DoubleClick);
            // 
            // tabStatHard
            // 
            this.tabStatHard.Controls.Add(this.Gauge3);
            this.tabStatHard.Controls.Add(this.Gauge2);
            this.tabStatHard.Controls.Add(this.Gauge1);
            resources.ApplyResources(this.tabStatHard, "tabStatHard");
            this.tabStatHard.Name = "tabStatHard";
            this.tabStatHard.UseVisualStyleBackColor = true;
            // 
            // Gauge3
            // 
            this.Gauge3.BackColor = System.Drawing.Color.Transparent;
            this.Gauge3.BackgroundImage = global::ArdupilotMega.Properties.Resources.Gaugebg;
            resources.ApplyResources(this.Gauge3, "Gauge3");
            this.Gauge3.BaseArcColor = System.Drawing.Color.Transparent;
            this.Gauge3.BaseArcRadius = 70;
            this.Gauge3.BaseArcStart = 135;
            this.Gauge3.BaseArcSweep = 270;
            this.Gauge3.BaseArcWidth = 2;
            this.Gauge3.basesize = new System.Drawing.Size(150, 150);
            this.Gauge3.Cap_Idx = ((byte)(0));
            this.Gauge3.CapColor = System.Drawing.Color.White;
            this.Gauge3.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.Gauge3.CapPosition = new System.Drawing.Point(58, 85);
            this.Gauge3.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(58, 85),
        new System.Drawing.Point(50, 110),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.Gauge3.CapsText = new string[] {
        "Suhu",
        "",
        "",
        "",
        ""};
            this.Gauge3.CapText = "Suhu";
            this.Gauge3.Center = new System.Drawing.Point(75, 75);
            this.Gauge3.DataBindings.Add(new System.Windows.Forms.Binding("Value1", this.bindingSource, "roll", true));
            this.Gauge3.DataBindings.Add(new System.Windows.Forms.Binding("Value0", this.bindingSource, "pitch", true));
            this.Gauge3.MaxValue = 10F;
            this.Gauge3.MinValue = 0F;
            this.Gauge3.Name = "Gauge3";
            this.Gauge3.Need_Idx = ((byte)(3));
            this.Gauge3.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.Gauge3.NeedleColor2 = System.Drawing.Color.Brown;
            this.Gauge3.NeedleEnabled = false;
            this.Gauge3.NeedleRadius = 70;
            this.Gauge3.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Blue,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.Gauge3.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Brown};
            this.Gauge3.NeedlesEnabled = new bool[] {
        true,
        true,
        false,
        false};
            this.Gauge3.NeedlesRadius = new int[] {
        50,
        50,
        70,
        70};
            this.Gauge3.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.Gauge3.NeedlesWidth = new int[] {
        2,
        1,
        2,
        2};
            this.Gauge3.NeedleType = 0;
            this.Gauge3.NeedleWidth = 2;
            this.Gauge3.Range_Idx = ((byte)(2));
            this.Gauge3.RangeColor = System.Drawing.Color.Orange;
            this.Gauge3.RangeEnabled = false;
            this.Gauge3.RangeEndValue = 50F;
            this.Gauge3.RangeInnerRadius = 1;
            this.Gauge3.RangeOuterRadius = 70;
            this.Gauge3.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.Color.Orange,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.Gauge3.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.Gauge3.RangesEndValue = new float[] {
        35F,
        60F,
        50F,
        0F,
        0F};
            this.Gauge3.RangesInnerRadius = new int[] {
        1,
        1,
        1,
        70,
        70};
            this.Gauge3.RangesOuterRadius = new int[] {
        70,
        70,
        70,
        80,
        80};
            this.Gauge3.RangesStartValue = new float[] {
        0F,
        50F,
        35F,
        0F,
        0F};
            this.Gauge3.RangeStartValue = 35F;
            this.Gauge3.ScaleLinesInterColor = System.Drawing.Color.White;
            this.Gauge3.ScaleLinesInterInnerRadius = 52;
            this.Gauge3.ScaleLinesInterOuterRadius = 60;
            this.Gauge3.ScaleLinesInterWidth = 1;
            this.Gauge3.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.Gauge3.ScaleLinesMajorInnerRadius = 50;
            this.Gauge3.ScaleLinesMajorOuterRadius = 60;
            this.Gauge3.ScaleLinesMajorStepValue = 10F;
            this.Gauge3.ScaleLinesMajorWidth = 2;
            this.Gauge3.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.Gauge3.ScaleLinesMinorInnerRadius = 55;
            this.Gauge3.ScaleLinesMinorNumOf = 9;
            this.Gauge3.ScaleLinesMinorOuterRadius = 60;
            this.Gauge3.ScaleLinesMinorWidth = 1;
            this.Gauge3.ScaleNumbersColor = System.Drawing.Color.White;
            this.Gauge3.ScaleNumbersFormat = null;
            this.Gauge3.ScaleNumbersRadius = 42;
            this.Gauge3.ScaleNumbersRotation = 0;
            this.Gauge3.ScaleNumbersStartScaleLine = 1;
            this.Gauge3.ScaleNumbersStepScaleLines = 1;
            this.Gauge3.Value = 0F;
            this.Gauge3.Value0 = 0F;
            this.Gauge3.Value1 = 0F;
            this.Gauge3.Value2 = 0F;
            this.Gauge3.Value3 = 0F;
            // 
            // Gauge2
            // 
            this.Gauge2.BackColor = System.Drawing.Color.Transparent;
            this.Gauge2.BackgroundImage = global::ArdupilotMega.Properties.Resources.Gaugebg;
            resources.ApplyResources(this.Gauge2, "Gauge2");
            this.Gauge2.BaseArcColor = System.Drawing.Color.Transparent;
            this.Gauge2.BaseArcRadius = 70;
            this.Gauge2.BaseArcStart = 135;
            this.Gauge2.BaseArcSweep = 270;
            this.Gauge2.BaseArcWidth = 2;
            this.Gauge2.basesize = new System.Drawing.Size(150, 150);
            this.Gauge2.Cap_Idx = ((byte)(0));
            this.Gauge2.CapColor = System.Drawing.Color.White;
            this.Gauge2.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.Gauge2.CapPosition = new System.Drawing.Point(58, 85);
            this.Gauge2.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(58, 85),
        new System.Drawing.Point(50, 110),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.Gauge2.CapsText = new string[] {
        "Suhu",
        "",
        "",
        "",
        ""};
            this.Gauge2.CapText = "Suhu";
            this.Gauge2.Center = new System.Drawing.Point(75, 75);
            this.Gauge2.DataBindings.Add(new System.Windows.Forms.Binding("Value1", this.bindingSource, "roll", true));
            this.Gauge2.DataBindings.Add(new System.Windows.Forms.Binding("Value0", this.bindingSource, "pitch", true));
            this.Gauge2.MaxValue = 10F;
            this.Gauge2.MinValue = 0F;
            this.Gauge2.Name = "Gauge2";
            this.Gauge2.Need_Idx = ((byte)(3));
            this.Gauge2.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.Gauge2.NeedleColor2 = System.Drawing.Color.Brown;
            this.Gauge2.NeedleEnabled = false;
            this.Gauge2.NeedleRadius = 70;
            this.Gauge2.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Blue,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.Gauge2.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Brown};
            this.Gauge2.NeedlesEnabled = new bool[] {
        true,
        true,
        false,
        false};
            this.Gauge2.NeedlesRadius = new int[] {
        50,
        50,
        70,
        70};
            this.Gauge2.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.Gauge2.NeedlesWidth = new int[] {
        2,
        1,
        2,
        2};
            this.Gauge2.NeedleType = 0;
            this.Gauge2.NeedleWidth = 2;
            this.Gauge2.Range_Idx = ((byte)(2));
            this.Gauge2.RangeColor = System.Drawing.Color.Orange;
            this.Gauge2.RangeEnabled = false;
            this.Gauge2.RangeEndValue = 50F;
            this.Gauge2.RangeInnerRadius = 1;
            this.Gauge2.RangeOuterRadius = 70;
            this.Gauge2.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.Color.Orange,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.Gauge2.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.Gauge2.RangesEndValue = new float[] {
        35F,
        60F,
        50F,
        0F,
        0F};
            this.Gauge2.RangesInnerRadius = new int[] {
        1,
        1,
        1,
        70,
        70};
            this.Gauge2.RangesOuterRadius = new int[] {
        70,
        70,
        70,
        80,
        80};
            this.Gauge2.RangesStartValue = new float[] {
        0F,
        50F,
        35F,
        0F,
        0F};
            this.Gauge2.RangeStartValue = 35F;
            this.Gauge2.ScaleLinesInterColor = System.Drawing.Color.White;
            this.Gauge2.ScaleLinesInterInnerRadius = 52;
            this.Gauge2.ScaleLinesInterOuterRadius = 60;
            this.Gauge2.ScaleLinesInterWidth = 1;
            this.Gauge2.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.Gauge2.ScaleLinesMajorInnerRadius = 50;
            this.Gauge2.ScaleLinesMajorOuterRadius = 60;
            this.Gauge2.ScaleLinesMajorStepValue = 10F;
            this.Gauge2.ScaleLinesMajorWidth = 2;
            this.Gauge2.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.Gauge2.ScaleLinesMinorInnerRadius = 55;
            this.Gauge2.ScaleLinesMinorNumOf = 9;
            this.Gauge2.ScaleLinesMinorOuterRadius = 60;
            this.Gauge2.ScaleLinesMinorWidth = 1;
            this.Gauge2.ScaleNumbersColor = System.Drawing.Color.White;
            this.Gauge2.ScaleNumbersFormat = null;
            this.Gauge2.ScaleNumbersRadius = 42;
            this.Gauge2.ScaleNumbersRotation = 0;
            this.Gauge2.ScaleNumbersStartScaleLine = 1;
            this.Gauge2.ScaleNumbersStepScaleLines = 1;
            this.Gauge2.Value = 0F;
            this.Gauge2.Value0 = 0F;
            this.Gauge2.Value1 = 0F;
            this.Gauge2.Value2 = 0F;
            this.Gauge2.Value3 = 0F;
            // 
            // Gauge1
            // 
            this.Gauge1.BackColor = System.Drawing.Color.Transparent;
            this.Gauge1.BackgroundImage = global::ArdupilotMega.Properties.Resources.Gaugebg;
            resources.ApplyResources(this.Gauge1, "Gauge1");
            this.Gauge1.BaseArcColor = System.Drawing.Color.Transparent;
            this.Gauge1.BaseArcRadius = 70;
            this.Gauge1.BaseArcStart = 135;
            this.Gauge1.BaseArcSweep = 270;
            this.Gauge1.BaseArcWidth = 2;
            this.Gauge1.basesize = new System.Drawing.Size(150, 150);
            this.Gauge1.Cap_Idx = ((byte)(0));
            this.Gauge1.CapColor = System.Drawing.Color.White;
            this.Gauge1.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.Gauge1.CapPosition = new System.Drawing.Point(58, 85);
            this.Gauge1.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(58, 85),
        new System.Drawing.Point(50, 110),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.Gauge1.CapsText = new string[] {
        "Suhu",
        "",
        "",
        "",
        ""};
            this.Gauge1.CapText = "Suhu";
            this.Gauge1.Center = new System.Drawing.Point(75, 75);
            this.Gauge1.DataBindings.Add(new System.Windows.Forms.Binding("Value0", this.bindingSource, "roll", true));
            this.Gauge1.DataBindings.Add(new System.Windows.Forms.Binding("Value1", this.bindingSource, "alt", true));
            this.Gauge1.MaxValue = 10F;
            this.Gauge1.MinValue = 0F;
            this.Gauge1.Name = "Gauge1";
            this.Gauge1.Need_Idx = ((byte)(3));
            this.Gauge1.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.Gauge1.NeedleColor2 = System.Drawing.Color.Brown;
            this.Gauge1.NeedleEnabled = false;
            this.Gauge1.NeedleRadius = 70;
            this.Gauge1.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Blue,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.Gauge1.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Brown};
            this.Gauge1.NeedlesEnabled = new bool[] {
        true,
        true,
        false,
        false};
            this.Gauge1.NeedlesRadius = new int[] {
        50,
        50,
        70,
        70};
            this.Gauge1.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.Gauge1.NeedlesWidth = new int[] {
        2,
        1,
        2,
        2};
            this.Gauge1.NeedleType = 0;
            this.Gauge1.NeedleWidth = 2;
            this.Gauge1.Range_Idx = ((byte)(2));
            this.Gauge1.RangeColor = System.Drawing.Color.Orange;
            this.Gauge1.RangeEnabled = false;
            this.Gauge1.RangeEndValue = 50F;
            this.Gauge1.RangeInnerRadius = 1;
            this.Gauge1.RangeOuterRadius = 70;
            this.Gauge1.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.Color.Orange,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.Gauge1.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.Gauge1.RangesEndValue = new float[] {
        35F,
        60F,
        50F,
        0F,
        0F};
            this.Gauge1.RangesInnerRadius = new int[] {
        1,
        1,
        1,
        70,
        70};
            this.Gauge1.RangesOuterRadius = new int[] {
        70,
        70,
        70,
        80,
        80};
            this.Gauge1.RangesStartValue = new float[] {
        0F,
        50F,
        35F,
        0F,
        0F};
            this.Gauge1.RangeStartValue = 35F;
            this.Gauge1.ScaleLinesInterColor = System.Drawing.Color.White;
            this.Gauge1.ScaleLinesInterInnerRadius = 52;
            this.Gauge1.ScaleLinesInterOuterRadius = 60;
            this.Gauge1.ScaleLinesInterWidth = 1;
            this.Gauge1.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.Gauge1.ScaleLinesMajorInnerRadius = 50;
            this.Gauge1.ScaleLinesMajorOuterRadius = 60;
            this.Gauge1.ScaleLinesMajorStepValue = 10F;
            this.Gauge1.ScaleLinesMajorWidth = 2;
            this.Gauge1.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.Gauge1.ScaleLinesMinorInnerRadius = 55;
            this.Gauge1.ScaleLinesMinorNumOf = 9;
            this.Gauge1.ScaleLinesMinorOuterRadius = 60;
            this.Gauge1.ScaleLinesMinorWidth = 1;
            this.Gauge1.ScaleNumbersColor = System.Drawing.Color.White;
            this.Gauge1.ScaleNumbersFormat = null;
            this.Gauge1.ScaleNumbersRadius = 42;
            this.Gauge1.ScaleNumbersRotation = 0;
            this.Gauge1.ScaleNumbersStartScaleLine = 1;
            this.Gauge1.ScaleNumbersStepScaleLines = 1;
            this.Gauge1.Value = 0F;
            this.Gauge1.Value0 = 0F;
            this.Gauge1.Value1 = 0F;
            this.Gauge1.Value2 = 0F;
            this.Gauge1.Value3 = 0F;
            // 
            // tabAll
            // 
            resources.ApplyResources(this.tabAll, "tabAll");
            this.tabAll.Name = "tabAll";
            this.tabAll.UseVisualStyleBackColor = true;
            this.tabAll.Enter += new System.EventHandler(this.tabAll_Enter);
            // 
            // splitSmall
            // 
            resources.ApplyResources(this.splitSmall, "splitSmall");
            this.splitSmall.Name = "splitSmall";
            // 
            // splitSmall.Panel1
            // 
            this.splitSmall.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitSmall.Panel2
            // 
            this.splitSmall.Panel2.Controls.Add(this.monitor);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkBoxGrafik);
            this.tabPage1.Controls.Add(this.checkDataSatelit);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBoxGrafik
            // 
            resources.ApplyResources(this.checkBoxGrafik, "checkBoxGrafik");
            this.checkBoxGrafik.Name = "checkBoxGrafik";
            this.checkBoxGrafik.UseVisualStyleBackColor = true;
            this.checkBoxGrafik.CheckedChanged += new System.EventHandler(this.checkBoxGrafik_CheckedChanged);
            // 
            // checkDataSatelit
            // 
            resources.ApplyResources(this.checkDataSatelit, "checkDataSatelit");
            this.checkDataSatelit.Checked = true;
            this.checkDataSatelit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDataSatelit.Name = "checkDataSatelit";
            this.checkDataSatelit.UseVisualStyleBackColor = true;
            this.checkDataSatelit.CheckedChanged += new System.EventHandler(this.checkDataSatelit_CheckedChanged);
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // monitor
            // 
            this.monitor.airspeed = 0F;
            this.monitor.alt = 0F;
            this.monitor.BackColor = System.Drawing.Color.Black;
            this.monitor.batterylevel = 0F;
            this.monitor.batteryremaining = 0F;
            this.monitor.current = 0F;
            this.monitor.datetime = new System.DateTime(((long)(0)));
            this.monitor.disttowp = 0F;
            this.monitor.failsafe = false;
            this.monitor.gpsfix = 0F;
            this.monitor.gpshdop = 0F;
            this.monitor.groundalt = 0F;
            this.monitor.groundcourse = 0F;
            this.monitor.groundspeed = 0F;
            this.monitor.heading = 0F;
            this.monitor.hudcolor = System.Drawing.Color.White;
            this.monitor.linkqualitygcs = 0F;
            resources.ApplyResources(this.monitor, "monitor");
            this.monitor.lowvoltagealert = false;
            this.monitor.message = "";
            this.monitor.mode = "Manual";
            this.monitor.Name = "monitor";
            this.monitor.navpitch = 0F;
            this.monitor.navroll = 0F;
            this.monitor.opengl = true;
            this.monitor.pitch = 0F;
            this.monitor.roll = 0F;
            this.monitor.status = false;
            this.monitor.streamjpg = ((System.IO.MemoryStream)(resources.GetObject("monitor.streamjpg")));
            this.monitor.targetalt = 0F;
            this.monitor.targetheading = 0F;
            this.monitor.targetspeed = 0F;
            this.monitor.turnrate = 0F;
            this.monitor.verticalspeed = 0F;
            this.monitor.VSync = false;
            this.monitor.wpno = 0;
            this.monitor.xtrack_error = 0F;
            // 
            // currentStateBindingSource
            // 
            this.currentStateBindingSource.DataSource = typeof(ArdupilotMega.CurrentState);
            // 
            // TGrafik
            // 
            this.TGrafik.Tick += new System.EventHandler(this.TGrafik_Tick);
            // 
            // NanosatEEPIS
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "NanosatEEPIS";
            this.Load += new System.EventHandler(this.NanosatEEPIS_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitBig.Panel1.ResumeLayout(false);
            this.splitBig.Panel2.ResumeLayout(false);
            this.splitBig.ResumeLayout(false);
            this.tabControlUmum.ResumeLayout(false);
            this.tabData.ResumeLayout(false);
            this.tabData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.tabGrafik.ResumeLayout(false);
            this.tabStatHard.ResumeLayout(false);
            this.splitSmall.Panel1.ResumeLayout(false);
            this.splitSmall.Panel2.ResumeLayout(false);
            this.splitSmall.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentStateBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitBig;
        private GMap.NET.WindowsForms.GMapControl gMap;
        private System.Windows.Forms.TabControl tabControlUmum;
        private System.Windows.Forms.TabPage tabData;
        private System.Windows.Forms.TabPage tabGrafik;
        private ZedGraph.ZedGraphControl grafik;
        private System.Windows.Forms.SplitContainer splitSmall;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox checkDataSatelit;
        private System.Windows.Forms.TabPage tabPage2;
        private Controls.HUD monitor;
        private System.Windows.Forms.TabPage tabStatHard;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource currentStateBindingSource;
        private System.Windows.Forms.Label LVOrbit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label LAzimuth;
        private System.Windows.Forms.Label LAltitude;
        private System.Windows.Forms.Label LElevasi;
        private System.Windows.Forms.Label Llatitude;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxGrafik;
        private System.Windows.Forms.Timer TGrafik;
        private System.Windows.Forms.Timer ZedGraphTimer;
        private AGaugeApp.AGauge Gauge3;
        private AGaugeApp.AGauge Gauge2;
        private AGaugeApp.AGauge Gauge1;
        private System.Windows.Forms.TabPage tabAll;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;

    }
}
