namespace ArdupilotMega.GCSViews
{
    partial class Hardware
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hardware));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Gauge1 = new AGaugeApp.AGauge();
            this.aGauge1 = new AGaugeApp.AGauge();
            this.aGauge2 = new AGaugeApp.AGauge();
            this.aGauge3 = new AGaugeApp.AGauge();
            this.aGauge4 = new AGaugeApp.AGauge();
            this.currentStateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aGauge5 = new AGaugeApp.AGauge();
            this.bindingSourceHW = new System.Windows.Forms.BindingSource(this.components);
            this.LAltitude = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentStateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHW)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ArdupilotMega.Properties.Resources.sistemhardware_copy;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
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
            // aGauge1
            // 
            this.aGauge1.BackColor = System.Drawing.Color.Transparent;
            this.aGauge1.BackgroundImage = global::ArdupilotMega.Properties.Resources.Gaugebg;
            resources.ApplyResources(this.aGauge1, "aGauge1");
            this.aGauge1.BaseArcColor = System.Drawing.Color.Transparent;
            this.aGauge1.BaseArcRadius = 70;
            this.aGauge1.BaseArcStart = 135;
            this.aGauge1.BaseArcSweep = 270;
            this.aGauge1.BaseArcWidth = 2;
            this.aGauge1.basesize = new System.Drawing.Size(150, 150);
            this.aGauge1.Cap_Idx = ((byte)(0));
            this.aGauge1.CapColor = System.Drawing.Color.White;
            this.aGauge1.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge1.CapPosition = new System.Drawing.Point(58, 85);
            this.aGauge1.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(58, 85),
        new System.Drawing.Point(50, 110),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge1.CapsText = new string[] {
        "Suhu",
        "",
        "",
        "",
        ""};
            this.aGauge1.CapText = "Suhu";
            this.aGauge1.Center = new System.Drawing.Point(75, 75);
            this.aGauge1.MaxValue = 10F;
            this.aGauge1.MinValue = 0F;
            this.aGauge1.Name = "aGauge1";
            this.aGauge1.Need_Idx = ((byte)(3));
            this.aGauge1.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.aGauge1.NeedleColor2 = System.Drawing.Color.Brown;
            this.aGauge1.NeedleEnabled = false;
            this.aGauge1.NeedleRadius = 70;
            this.aGauge1.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Blue,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.aGauge1.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Brown};
            this.aGauge1.NeedlesEnabled = new bool[] {
        true,
        true,
        false,
        false};
            this.aGauge1.NeedlesRadius = new int[] {
        50,
        50,
        70,
        70};
            this.aGauge1.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.aGauge1.NeedlesWidth = new int[] {
        2,
        1,
        2,
        2};
            this.aGauge1.NeedleType = 0;
            this.aGauge1.NeedleWidth = 2;
            this.aGauge1.Range_Idx = ((byte)(2));
            this.aGauge1.RangeColor = System.Drawing.Color.Orange;
            this.aGauge1.RangeEnabled = false;
            this.aGauge1.RangeEndValue = 50F;
            this.aGauge1.RangeInnerRadius = 1;
            this.aGauge1.RangeOuterRadius = 70;
            this.aGauge1.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.Color.Orange,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge1.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.aGauge1.RangesEndValue = new float[] {
        35F,
        60F,
        50F,
        0F,
        0F};
            this.aGauge1.RangesInnerRadius = new int[] {
        1,
        1,
        1,
        70,
        70};
            this.aGauge1.RangesOuterRadius = new int[] {
        70,
        70,
        70,
        80,
        80};
            this.aGauge1.RangesStartValue = new float[] {
        0F,
        50F,
        35F,
        0F,
        0F};
            this.aGauge1.RangeStartValue = 35F;
            this.aGauge1.ScaleLinesInterColor = System.Drawing.Color.White;
            this.aGauge1.ScaleLinesInterInnerRadius = 52;
            this.aGauge1.ScaleLinesInterOuterRadius = 60;
            this.aGauge1.ScaleLinesInterWidth = 1;
            this.aGauge1.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.aGauge1.ScaleLinesMajorInnerRadius = 50;
            this.aGauge1.ScaleLinesMajorOuterRadius = 60;
            this.aGauge1.ScaleLinesMajorStepValue = 10F;
            this.aGauge1.ScaleLinesMajorWidth = 2;
            this.aGauge1.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.aGauge1.ScaleLinesMinorInnerRadius = 55;
            this.aGauge1.ScaleLinesMinorNumOf = 9;
            this.aGauge1.ScaleLinesMinorOuterRadius = 60;
            this.aGauge1.ScaleLinesMinorWidth = 1;
            this.aGauge1.ScaleNumbersColor = System.Drawing.Color.White;
            this.aGauge1.ScaleNumbersFormat = null;
            this.aGauge1.ScaleNumbersRadius = 42;
            this.aGauge1.ScaleNumbersRotation = 0;
            this.aGauge1.ScaleNumbersStartScaleLine = 1;
            this.aGauge1.ScaleNumbersStepScaleLines = 1;
            this.aGauge1.Value = 0F;
            this.aGauge1.Value0 = 0F;
            this.aGauge1.Value1 = 0F;
            this.aGauge1.Value2 = 0F;
            this.aGauge1.Value3 = 0F;
            // 
            // aGauge2
            // 
            this.aGauge2.BackColor = System.Drawing.Color.Transparent;
            this.aGauge2.BackgroundImage = global::ArdupilotMega.Properties.Resources.Gaugebg;
            resources.ApplyResources(this.aGauge2, "aGauge2");
            this.aGauge2.BaseArcColor = System.Drawing.Color.Transparent;
            this.aGauge2.BaseArcRadius = 70;
            this.aGauge2.BaseArcStart = 135;
            this.aGauge2.BaseArcSweep = 270;
            this.aGauge2.BaseArcWidth = 2;
            this.aGauge2.basesize = new System.Drawing.Size(150, 150);
            this.aGauge2.Cap_Idx = ((byte)(0));
            this.aGauge2.CapColor = System.Drawing.Color.White;
            this.aGauge2.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge2.CapPosition = new System.Drawing.Point(58, 85);
            this.aGauge2.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(58, 85),
        new System.Drawing.Point(50, 110),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge2.CapsText = new string[] {
        "Suhu",
        "",
        "",
        "",
        ""};
            this.aGauge2.CapText = "Suhu";
            this.aGauge2.Center = new System.Drawing.Point(75, 75);
            this.aGauge2.MaxValue = 10F;
            this.aGauge2.MinValue = 0F;
            this.aGauge2.Name = "aGauge2";
            this.aGauge2.Need_Idx = ((byte)(3));
            this.aGauge2.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.aGauge2.NeedleColor2 = System.Drawing.Color.Brown;
            this.aGauge2.NeedleEnabled = false;
            this.aGauge2.NeedleRadius = 70;
            this.aGauge2.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Blue,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.aGauge2.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Brown};
            this.aGauge2.NeedlesEnabled = new bool[] {
        true,
        true,
        false,
        false};
            this.aGauge2.NeedlesRadius = new int[] {
        50,
        50,
        70,
        70};
            this.aGauge2.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.aGauge2.NeedlesWidth = new int[] {
        2,
        1,
        2,
        2};
            this.aGauge2.NeedleType = 0;
            this.aGauge2.NeedleWidth = 2;
            this.aGauge2.Range_Idx = ((byte)(2));
            this.aGauge2.RangeColor = System.Drawing.Color.Orange;
            this.aGauge2.RangeEnabled = false;
            this.aGauge2.RangeEndValue = 50F;
            this.aGauge2.RangeInnerRadius = 1;
            this.aGauge2.RangeOuterRadius = 70;
            this.aGauge2.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.Color.Orange,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge2.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.aGauge2.RangesEndValue = new float[] {
        35F,
        60F,
        50F,
        0F,
        0F};
            this.aGauge2.RangesInnerRadius = new int[] {
        1,
        1,
        1,
        70,
        70};
            this.aGauge2.RangesOuterRadius = new int[] {
        70,
        70,
        70,
        80,
        80};
            this.aGauge2.RangesStartValue = new float[] {
        0F,
        50F,
        35F,
        0F,
        0F};
            this.aGauge2.RangeStartValue = 35F;
            this.aGauge2.ScaleLinesInterColor = System.Drawing.Color.White;
            this.aGauge2.ScaleLinesInterInnerRadius = 52;
            this.aGauge2.ScaleLinesInterOuterRadius = 60;
            this.aGauge2.ScaleLinesInterWidth = 1;
            this.aGauge2.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.aGauge2.ScaleLinesMajorInnerRadius = 50;
            this.aGauge2.ScaleLinesMajorOuterRadius = 60;
            this.aGauge2.ScaleLinesMajorStepValue = 10F;
            this.aGauge2.ScaleLinesMajorWidth = 2;
            this.aGauge2.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.aGauge2.ScaleLinesMinorInnerRadius = 55;
            this.aGauge2.ScaleLinesMinorNumOf = 9;
            this.aGauge2.ScaleLinesMinorOuterRadius = 60;
            this.aGauge2.ScaleLinesMinorWidth = 1;
            this.aGauge2.ScaleNumbersColor = System.Drawing.Color.White;
            this.aGauge2.ScaleNumbersFormat = null;
            this.aGauge2.ScaleNumbersRadius = 42;
            this.aGauge2.ScaleNumbersRotation = 0;
            this.aGauge2.ScaleNumbersStartScaleLine = 1;
            this.aGauge2.ScaleNumbersStepScaleLines = 1;
            this.aGauge2.Value = 0F;
            this.aGauge2.Value0 = 0F;
            this.aGauge2.Value1 = 0F;
            this.aGauge2.Value2 = 0F;
            this.aGauge2.Value3 = 0F;
            // 
            // aGauge3
            // 
            this.aGauge3.BackColor = System.Drawing.Color.Transparent;
            this.aGauge3.BackgroundImage = global::ArdupilotMega.Properties.Resources.Gaugebg;
            resources.ApplyResources(this.aGauge3, "aGauge3");
            this.aGauge3.BaseArcColor = System.Drawing.Color.Transparent;
            this.aGauge3.BaseArcRadius = 70;
            this.aGauge3.BaseArcStart = 135;
            this.aGauge3.BaseArcSweep = 270;
            this.aGauge3.BaseArcWidth = 2;
            this.aGauge3.basesize = new System.Drawing.Size(150, 150);
            this.aGauge3.Cap_Idx = ((byte)(0));
            this.aGauge3.CapColor = System.Drawing.Color.White;
            this.aGauge3.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge3.CapPosition = new System.Drawing.Point(58, 85);
            this.aGauge3.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(58, 85),
        new System.Drawing.Point(50, 110),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge3.CapsText = new string[] {
        "Suhu",
        "",
        "",
        "",
        ""};
            this.aGauge3.CapText = "Suhu";
            this.aGauge3.Center = new System.Drawing.Point(75, 75);
            this.aGauge3.MaxValue = 10F;
            this.aGauge3.MinValue = 0F;
            this.aGauge3.Name = "aGauge3";
            this.aGauge3.Need_Idx = ((byte)(3));
            this.aGauge3.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.aGauge3.NeedleColor2 = System.Drawing.Color.Brown;
            this.aGauge3.NeedleEnabled = false;
            this.aGauge3.NeedleRadius = 70;
            this.aGauge3.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Blue,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.aGauge3.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Brown};
            this.aGauge3.NeedlesEnabled = new bool[] {
        true,
        true,
        false,
        false};
            this.aGauge3.NeedlesRadius = new int[] {
        50,
        50,
        70,
        70};
            this.aGauge3.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.aGauge3.NeedlesWidth = new int[] {
        2,
        1,
        2,
        2};
            this.aGauge3.NeedleType = 0;
            this.aGauge3.NeedleWidth = 2;
            this.aGauge3.Range_Idx = ((byte)(2));
            this.aGauge3.RangeColor = System.Drawing.Color.Orange;
            this.aGauge3.RangeEnabled = false;
            this.aGauge3.RangeEndValue = 50F;
            this.aGauge3.RangeInnerRadius = 1;
            this.aGauge3.RangeOuterRadius = 70;
            this.aGauge3.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.Color.Orange,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge3.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.aGauge3.RangesEndValue = new float[] {
        35F,
        60F,
        50F,
        0F,
        0F};
            this.aGauge3.RangesInnerRadius = new int[] {
        1,
        1,
        1,
        70,
        70};
            this.aGauge3.RangesOuterRadius = new int[] {
        70,
        70,
        70,
        80,
        80};
            this.aGauge3.RangesStartValue = new float[] {
        0F,
        50F,
        35F,
        0F,
        0F};
            this.aGauge3.RangeStartValue = 35F;
            this.aGauge3.ScaleLinesInterColor = System.Drawing.Color.White;
            this.aGauge3.ScaleLinesInterInnerRadius = 52;
            this.aGauge3.ScaleLinesInterOuterRadius = 60;
            this.aGauge3.ScaleLinesInterWidth = 1;
            this.aGauge3.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.aGauge3.ScaleLinesMajorInnerRadius = 50;
            this.aGauge3.ScaleLinesMajorOuterRadius = 60;
            this.aGauge3.ScaleLinesMajorStepValue = 10F;
            this.aGauge3.ScaleLinesMajorWidth = 2;
            this.aGauge3.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.aGauge3.ScaleLinesMinorInnerRadius = 55;
            this.aGauge3.ScaleLinesMinorNumOf = 9;
            this.aGauge3.ScaleLinesMinorOuterRadius = 60;
            this.aGauge3.ScaleLinesMinorWidth = 1;
            this.aGauge3.ScaleNumbersColor = System.Drawing.Color.White;
            this.aGauge3.ScaleNumbersFormat = null;
            this.aGauge3.ScaleNumbersRadius = 42;
            this.aGauge3.ScaleNumbersRotation = 0;
            this.aGauge3.ScaleNumbersStartScaleLine = 1;
            this.aGauge3.ScaleNumbersStepScaleLines = 1;
            this.aGauge3.Value = 0F;
            this.aGauge3.Value0 = 0F;
            this.aGauge3.Value1 = 0F;
            this.aGauge3.Value2 = 0F;
            this.aGauge3.Value3 = 0F;
            // 
            // aGauge4
            // 
            this.aGauge4.BackColor = System.Drawing.Color.Transparent;
            this.aGauge4.BackgroundImage = global::ArdupilotMega.Properties.Resources.Gaugebg;
            resources.ApplyResources(this.aGauge4, "aGauge4");
            this.aGauge4.BaseArcColor = System.Drawing.Color.Transparent;
            this.aGauge4.BaseArcRadius = 70;
            this.aGauge4.BaseArcStart = 135;
            this.aGauge4.BaseArcSweep = 270;
            this.aGauge4.BaseArcWidth = 2;
            this.aGauge4.basesize = new System.Drawing.Size(150, 150);
            this.aGauge4.Cap_Idx = ((byte)(0));
            this.aGauge4.CapColor = System.Drawing.Color.White;
            this.aGauge4.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge4.CapPosition = new System.Drawing.Point(58, 85);
            this.aGauge4.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(58, 85),
        new System.Drawing.Point(50, 110),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge4.CapsText = new string[] {
        "Suhu",
        "",
        "",
        "",
        ""};
            this.aGauge4.CapText = "Suhu";
            this.aGauge4.Center = new System.Drawing.Point(75, 75);
            this.aGauge4.DataBindings.Add(new System.Windows.Forms.Binding("Value0", this.currentStateBindingSource, "roll", true));
            this.aGauge4.MaxValue = 10F;
            this.aGauge4.MinValue = 0F;
            this.aGauge4.Name = "aGauge4";
            this.aGauge4.Need_Idx = ((byte)(3));
            this.aGauge4.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.aGauge4.NeedleColor2 = System.Drawing.Color.Brown;
            this.aGauge4.NeedleEnabled = false;
            this.aGauge4.NeedleRadius = 70;
            this.aGauge4.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Blue,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.aGauge4.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Brown};
            this.aGauge4.NeedlesEnabled = new bool[] {
        true,
        true,
        false,
        false};
            this.aGauge4.NeedlesRadius = new int[] {
        50,
        50,
        70,
        70};
            this.aGauge4.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.aGauge4.NeedlesWidth = new int[] {
        2,
        1,
        2,
        2};
            this.aGauge4.NeedleType = 0;
            this.aGauge4.NeedleWidth = 2;
            this.aGauge4.Range_Idx = ((byte)(2));
            this.aGauge4.RangeColor = System.Drawing.Color.Orange;
            this.aGauge4.RangeEnabled = false;
            this.aGauge4.RangeEndValue = 50F;
            this.aGauge4.RangeInnerRadius = 1;
            this.aGauge4.RangeOuterRadius = 70;
            this.aGauge4.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.Color.Orange,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge4.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.aGauge4.RangesEndValue = new float[] {
        35F,
        60F,
        50F,
        0F,
        0F};
            this.aGauge4.RangesInnerRadius = new int[] {
        1,
        1,
        1,
        70,
        70};
            this.aGauge4.RangesOuterRadius = new int[] {
        70,
        70,
        70,
        80,
        80};
            this.aGauge4.RangesStartValue = new float[] {
        0F,
        50F,
        35F,
        0F,
        0F};
            this.aGauge4.RangeStartValue = 35F;
            this.aGauge4.ScaleLinesInterColor = System.Drawing.Color.White;
            this.aGauge4.ScaleLinesInterInnerRadius = 52;
            this.aGauge4.ScaleLinesInterOuterRadius = 60;
            this.aGauge4.ScaleLinesInterWidth = 1;
            this.aGauge4.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.aGauge4.ScaleLinesMajorInnerRadius = 50;
            this.aGauge4.ScaleLinesMajorOuterRadius = 60;
            this.aGauge4.ScaleLinesMajorStepValue = 10F;
            this.aGauge4.ScaleLinesMajorWidth = 2;
            this.aGauge4.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.aGauge4.ScaleLinesMinorInnerRadius = 55;
            this.aGauge4.ScaleLinesMinorNumOf = 9;
            this.aGauge4.ScaleLinesMinorOuterRadius = 60;
            this.aGauge4.ScaleLinesMinorWidth = 1;
            this.aGauge4.ScaleNumbersColor = System.Drawing.Color.White;
            this.aGauge4.ScaleNumbersFormat = null;
            this.aGauge4.ScaleNumbersRadius = 42;
            this.aGauge4.ScaleNumbersRotation = 0;
            this.aGauge4.ScaleNumbersStartScaleLine = 1;
            this.aGauge4.ScaleNumbersStepScaleLines = 1;
            this.aGauge4.Value = 0F;
            this.aGauge4.Value0 = 0F;
            this.aGauge4.Value1 = 0F;
            this.aGauge4.Value2 = 0F;
            this.aGauge4.Value3 = 0F;
            // 
            // currentStateBindingSource
            // 
            this.currentStateBindingSource.DataSource = typeof(ArdupilotMega.CurrentState);
            // 
            // aGauge5
            // 
            this.aGauge5.BackColor = System.Drawing.Color.Transparent;
            this.aGauge5.BackgroundImage = global::ArdupilotMega.Properties.Resources.Gaugebg;
            resources.ApplyResources(this.aGauge5, "aGauge5");
            this.aGauge5.BaseArcColor = System.Drawing.Color.Transparent;
            this.aGauge5.BaseArcRadius = 70;
            this.aGauge5.BaseArcStart = 135;
            this.aGauge5.BaseArcSweep = 270;
            this.aGauge5.BaseArcWidth = 2;
            this.aGauge5.basesize = new System.Drawing.Size(150, 150);
            this.aGauge5.Cap_Idx = ((byte)(0));
            this.aGauge5.CapColor = System.Drawing.Color.White;
            this.aGauge5.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge5.CapPosition = new System.Drawing.Point(58, 85);
            this.aGauge5.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(58, 85),
        new System.Drawing.Point(50, 110),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge5.CapsText = new string[] {
        "Suhu",
        "",
        "",
        "",
        ""};
            this.aGauge5.CapText = "Suhu";
            this.aGauge5.Center = new System.Drawing.Point(75, 75);
            this.aGauge5.MaxValue = 10F;
            this.aGauge5.MinValue = 0F;
            this.aGauge5.Name = "aGauge5";
            this.aGauge5.Need_Idx = ((byte)(3));
            this.aGauge5.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.aGauge5.NeedleColor2 = System.Drawing.Color.Brown;
            this.aGauge5.NeedleEnabled = false;
            this.aGauge5.NeedleRadius = 70;
            this.aGauge5.NeedlesColor1 = new AGaugeApp.AGauge.NeedleColorEnum[] {
        AGaugeApp.AGauge.NeedleColorEnum.Gray,
        AGaugeApp.AGauge.NeedleColorEnum.Red,
        AGaugeApp.AGauge.NeedleColorEnum.Blue,
        AGaugeApp.AGauge.NeedleColorEnum.Gray};
            this.aGauge5.NeedlesColor2 = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.Brown};
            this.aGauge5.NeedlesEnabled = new bool[] {
        true,
        true,
        false,
        false};
            this.aGauge5.NeedlesRadius = new int[] {
        50,
        50,
        70,
        70};
            this.aGauge5.NeedlesType = new int[] {
        0,
        0,
        0,
        0};
            this.aGauge5.NeedlesWidth = new int[] {
        2,
        1,
        2,
        2};
            this.aGauge5.NeedleType = 0;
            this.aGauge5.NeedleWidth = 2;
            this.aGauge5.Range_Idx = ((byte)(2));
            this.aGauge5.RangeColor = System.Drawing.Color.Orange;
            this.aGauge5.RangeEnabled = false;
            this.aGauge5.RangeEndValue = 50F;
            this.aGauge5.RangeInnerRadius = 1;
            this.aGauge5.RangeOuterRadius = 70;
            this.aGauge5.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.Red,
        System.Drawing.Color.Orange,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge5.RangesEnabled = new bool[] {
        false,
        false,
        false,
        false,
        false};
            this.aGauge5.RangesEndValue = new float[] {
        35F,
        60F,
        50F,
        0F,
        0F};
            this.aGauge5.RangesInnerRadius = new int[] {
        1,
        1,
        1,
        70,
        70};
            this.aGauge5.RangesOuterRadius = new int[] {
        70,
        70,
        70,
        80,
        80};
            this.aGauge5.RangesStartValue = new float[] {
        0F,
        50F,
        35F,
        0F,
        0F};
            this.aGauge5.RangeStartValue = 35F;
            this.aGauge5.ScaleLinesInterColor = System.Drawing.Color.White;
            this.aGauge5.ScaleLinesInterInnerRadius = 52;
            this.aGauge5.ScaleLinesInterOuterRadius = 60;
            this.aGauge5.ScaleLinesInterWidth = 1;
            this.aGauge5.ScaleLinesMajorColor = System.Drawing.Color.White;
            this.aGauge5.ScaleLinesMajorInnerRadius = 50;
            this.aGauge5.ScaleLinesMajorOuterRadius = 60;
            this.aGauge5.ScaleLinesMajorStepValue = 10F;
            this.aGauge5.ScaleLinesMajorWidth = 2;
            this.aGauge5.ScaleLinesMinorColor = System.Drawing.Color.White;
            this.aGauge5.ScaleLinesMinorInnerRadius = 55;
            this.aGauge5.ScaleLinesMinorNumOf = 9;
            this.aGauge5.ScaleLinesMinorOuterRadius = 60;
            this.aGauge5.ScaleLinesMinorWidth = 1;
            this.aGauge5.ScaleNumbersColor = System.Drawing.Color.White;
            this.aGauge5.ScaleNumbersFormat = null;
            this.aGauge5.ScaleNumbersRadius = 42;
            this.aGauge5.ScaleNumbersRotation = 0;
            this.aGauge5.ScaleNumbersStartScaleLine = 1;
            this.aGauge5.ScaleNumbersStepScaleLines = 1;
            this.aGauge5.Value = 0F;
            this.aGauge5.Value0 = 0F;
            this.aGauge5.Value1 = 0F;
            this.aGauge5.Value2 = 0F;
            this.aGauge5.Value3 = 0F;
            // 
            // bindingSourceHW
            // 
            this.bindingSourceHW.DataSource = typeof(ArdupilotMega.CurrentState);
            // 
            // LAltitude
            // 
            resources.ApplyResources(this.LAltitude, "LAltitude");
            this.LAltitude.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.currentStateBindingSource, "roll", true));
            this.LAltitude.ForeColor = System.Drawing.Color.Yellow;
            this.LAltitude.Name = "LAltitude";
            // 
            // Hardware
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LAltitude);
            this.Controls.Add(this.aGauge5);
            this.Controls.Add(this.aGauge4);
            this.Controls.Add(this.aGauge3);
            this.Controls.Add(this.aGauge2);
            this.Controls.Add(this.aGauge1);
            this.Controls.Add(this.Gauge1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Hardware";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentStateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private AGaugeApp.AGauge Gauge1;
        private AGaugeApp.AGauge aGauge1;
        private AGaugeApp.AGauge aGauge2;
        private AGaugeApp.AGauge aGauge3;
        private AGaugeApp.AGauge aGauge4;
        private AGaugeApp.AGauge aGauge5;
        private System.Windows.Forms.BindingSource bindingSourceHW;
        private System.Windows.Forms.BindingSource currentStateBindingSource;
        private System.Windows.Forms.Label LAltitude;


    }
}
