namespace Wykresy
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
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownEnd2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownA1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownB1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownStart1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownEnd1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownStart2 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownB2 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDownA2 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDownC2 = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.labelZeros = new System.Windows.Forms.Label();
            this.labelYIntercept = new System.Windows.Forms.Label();
            this.labelMonotonicity = new System.Windows.Forms.Label();
            this.labelMonotonicity2 = new System.Windows.Forms.Label();
            this.labelYIntercept2 = new System.Windows.Forms.Label();
            this.labelZeros2 = new System.Windows.Forms.Label();
            this.Delta = new System.Windows.Forms.Label();
            this.labelSymmetryAxis = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.stopnie = new System.Windows.Forms.Label();
            this.stopnieWpis = new System.Windows.Forms.NumericUpDown();
            this.Radiany = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.radianyWpis = new System.Windows.Forms.NumericUpDown();
            this.StopnieDane = new System.Windows.Forms.Label();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.kolkoRadiany = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEnd2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEnd1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownC2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopnieWpis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radianyWpis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolkoRadiany)).BeginInit();
            this.SuspendLayout();
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartesianChart1.Location = new System.Drawing.Point(0, 0);
            this.cartesianChart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(761, 499);
            this.cartesianChart1.TabIndex = 0;
            this.cartesianChart1.Text = "cartesianChart1";
            this.cartesianChart1.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.cartesianChart1_ChildChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(767, 450);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Wylicz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(827, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Wzór: f(x) = ax + b";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(813, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Wzór: f(x) = ax^2+bx+c";
            // 
            // numericUpDownEnd2
            // 
            this.numericUpDownEnd2.Location = new System.Drawing.Point(811, 405);
            this.numericUpDownEnd2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownEnd2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownEnd2.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDownEnd2.Name = "numericUpDownEnd2";
            this.numericUpDownEnd2.Size = new System.Drawing.Size(179, 22);
            this.numericUpDownEnd2.TabIndex = 8;
            // 
            // numericUpDownA1
            // 
            this.numericUpDownA1.Location = new System.Drawing.Point(811, 126);
            this.numericUpDownA1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownA1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownA1.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDownA1.Name = "numericUpDownA1";
            this.numericUpDownA1.Size = new System.Drawing.Size(179, 22);
            this.numericUpDownA1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(787, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "a:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(787, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "b:";
            // 
            // numericUpDownB1
            // 
            this.numericUpDownB1.Location = new System.Drawing.Point(811, 158);
            this.numericUpDownB1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownB1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownB1.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDownB1.Name = "numericUpDownB1";
            this.numericUpDownB1.Size = new System.Drawing.Size(179, 22);
            this.numericUpDownB1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(787, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "x1:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // numericUpDownStart1
            // 
            this.numericUpDownStart1.Location = new System.Drawing.Point(811, 190);
            this.numericUpDownStart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownStart1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownStart1.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDownStart1.Name = "numericUpDownStart1";
            this.numericUpDownStart1.Size = new System.Drawing.Size(179, 22);
            this.numericUpDownStart1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(787, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "x2:";
            // 
            // numericUpDownEnd1
            // 
            this.numericUpDownEnd1.Location = new System.Drawing.Point(811, 224);
            this.numericUpDownEnd1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownEnd1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownEnd1.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDownEnd1.Name = "numericUpDownEnd1";
            this.numericUpDownEnd1.Size = new System.Drawing.Size(179, 22);
            this.numericUpDownEnd1.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(787, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "x2:";
            // 
            // numericUpDownStart2
            // 
            this.numericUpDownStart2.Location = new System.Drawing.Point(811, 373);
            this.numericUpDownStart2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownStart2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownStart2.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDownStart2.Name = "numericUpDownStart2";
            this.numericUpDownStart2.Size = new System.Drawing.Size(179, 22);
            this.numericUpDownStart2.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(787, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "x1:";
            // 
            // numericUpDownB2
            // 
            this.numericUpDownB2.Location = new System.Drawing.Point(811, 318);
            this.numericUpDownB2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownB2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownB2.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDownB2.Name = "numericUpDownB2";
            this.numericUpDownB2.Size = new System.Drawing.Size(179, 22);
            this.numericUpDownB2.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(787, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "b:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(787, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "a:";
            // 
            // numericUpDownA2
            // 
            this.numericUpDownA2.Location = new System.Drawing.Point(811, 286);
            this.numericUpDownA2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownA2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownA2.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDownA2.Name = "numericUpDownA2";
            this.numericUpDownA2.Size = new System.Drawing.Size(179, 22);
            this.numericUpDownA2.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(787, 347);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "c:";
            // 
            // numericUpDownC2
            // 
            this.numericUpDownC2.Location = new System.Drawing.Point(811, 345);
            this.numericUpDownC2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownC2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownC2.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDownC2.Name = "numericUpDownC2";
            this.numericUpDownC2.Size = new System.Drawing.Size(179, 22);
            this.numericUpDownC2.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(12, 502);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(620, 16);
            this.label12.TabIndex = 27;
            this.label12.Text = "Zakładamy że nasza funkja przyjmuje znaczenia tylko ze zbioru liczb Całkowitych (" +
    "x є C) ";
            // 
            // labelZeros
            // 
            this.labelZeros.AutoSize = true;
            this.labelZeros.Location = new System.Drawing.Point(13, 572);
            this.labelZeros.Name = "labelZeros";
            this.labelZeros.Size = new System.Drawing.Size(108, 16);
            this.labelZeros.TabIndex = 28;
            this.labelZeros.Text = "Miejsce Zerowe: ";
            // 
            // labelYIntercept
            // 
            this.labelYIntercept.AutoSize = true;
            this.labelYIntercept.Location = new System.Drawing.Point(13, 601);
            this.labelYIntercept.Name = "labelYIntercept";
            this.labelYIntercept.Size = new System.Drawing.Size(158, 16);
            this.labelYIntercept.TabIndex = 31;
            this.labelYIntercept.Text = "Punkt przecięcia z osią Y:";
            // 
            // labelMonotonicity
            // 
            this.labelMonotonicity.AutoSize = true;
            this.labelMonotonicity.Location = new System.Drawing.Point(13, 630);
            this.labelMonotonicity.Name = "labelMonotonicity";
            this.labelMonotonicity.Size = new System.Drawing.Size(107, 16);
            this.labelMonotonicity.TabIndex = 32;
            this.labelMonotonicity.Text = "Monotoniczność:";
            // 
            // labelMonotonicity2
            // 
            this.labelMonotonicity2.AutoSize = true;
            this.labelMonotonicity2.Location = new System.Drawing.Point(388, 630);
            this.labelMonotonicity2.Name = "labelMonotonicity2";
            this.labelMonotonicity2.Size = new System.Drawing.Size(107, 16);
            this.labelMonotonicity2.TabIndex = 37;
            this.labelMonotonicity2.Text = "Monotoniczność:";
            // 
            // labelYIntercept2
            // 
            this.labelYIntercept2.AutoSize = true;
            this.labelYIntercept2.Location = new System.Drawing.Point(388, 601);
            this.labelYIntercept2.Name = "labelYIntercept2";
            this.labelYIntercept2.Size = new System.Drawing.Size(158, 16);
            this.labelYIntercept2.TabIndex = 36;
            this.labelYIntercept2.Text = "Punkt przecięcia z osią Y:";
            // 
            // labelZeros2
            // 
            this.labelZeros2.AutoSize = true;
            this.labelZeros2.Location = new System.Drawing.Point(388, 572);
            this.labelZeros2.Name = "labelZeros2";
            this.labelZeros2.Size = new System.Drawing.Size(105, 16);
            this.labelZeros2.TabIndex = 33;
            this.labelZeros2.Text = "Miejsce Zerowe:";
            // 
            // Delta
            // 
            this.Delta.AutoSize = true;
            this.Delta.Location = new System.Drawing.Point(388, 661);
            this.Delta.Name = "Delta";
            this.Delta.Size = new System.Drawing.Size(42, 16);
            this.Delta.TabIndex = 38;
            this.Delta.Text = "Delta:";
            this.Delta.Click += new System.EventHandler(this.Delta_Click);
            // 
            // labelSymmetryAxis
            // 
            this.labelSymmetryAxis.AutoSize = true;
            this.labelSymmetryAxis.Location = new System.Drawing.Point(388, 693);
            this.labelSymmetryAxis.Name = "labelSymmetryAxis";
            this.labelSymmetryAxis.Size = new System.Drawing.Size(76, 16);
            this.labelSymmetryAxis.TabIndex = 39;
            this.labelSymmetryAxis.Text = "Oś symetrii:";
            this.labelSymmetryAxis.Click += new System.EventHandler(this.label24_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.Location = new System.Drawing.Point(29, 549);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(59, 16);
            this.label25.TabIndex = 40;
            this.label25.Text = "Liniowa";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label26.Location = new System.Drawing.Point(405, 549);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(90, 16);
            this.label26.TabIndex = 41;
            this.label26.Text = "Kwadratowa";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(12, 724);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(201, 16);
            this.label13.TabIndex = 42;
            this.label13.Text = "Obliczenie radianów i stopni";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // stopnie
            // 
            this.stopnie.AutoSize = true;
            this.stopnie.Location = new System.Drawing.Point(12, 756);
            this.stopnie.Name = "stopnie";
            this.stopnie.Size = new System.Drawing.Size(96, 16);
            this.stopnie.TabIndex = 43;
            this.stopnie.Text = "Podaj stopnie: ";
            // 
            // stopnieWpis
            // 
            this.stopnieWpis.Location = new System.Drawing.Point(120, 756);
            this.stopnieWpis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stopnieWpis.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.stopnieWpis.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.stopnieWpis.Name = "stopnieWpis";
            this.stopnieWpis.Size = new System.Drawing.Size(179, 22);
            this.stopnieWpis.TabIndex = 44;
            // 
            // Radiany
            // 
            this.Radiany.AutoSize = true;
            this.Radiany.Location = new System.Drawing.Point(12, 796);
            this.Radiany.Name = "Radiany";
            this.Radiany.Size = new System.Drawing.Size(61, 16);
            this.Radiany.TabIndex = 45;
            this.Radiany.Text = "Radiany:";
            this.Radiany.Click += new System.EventHandler(this.label14_Click_1);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(365, 758);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 16);
            this.label14.TabIndex = 46;
            this.label14.Text = "Podaj radiany: ";
            // 
            // radianyWpis
            // 
            this.radianyWpis.Location = new System.Drawing.Point(473, 753);
            this.radianyWpis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radianyWpis.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.radianyWpis.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.radianyWpis.Name = "radianyWpis";
            this.radianyWpis.Size = new System.Drawing.Size(179, 22);
            this.radianyWpis.TabIndex = 47;
            // 
            // StopnieDane
            // 
            this.StopnieDane.AutoSize = true;
            this.StopnieDane.Location = new System.Drawing.Point(365, 796);
            this.StopnieDane.Name = "StopnieDane";
            this.StopnieDane.Size = new System.Drawing.Size(56, 16);
            this.StopnieDane.TabIndex = 48;
            this.StopnieDane.Text = "Stopnie:";
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar1.ForeColor = System.Drawing.Color.White;
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(672, 601);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.White;
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 0;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBar1.ProgressWidth = 200;
            this.circularProgressBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(318, 309);
            this.circularProgressBar1.StartAngle = 0;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = ".23";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "°C";
            this.circularProgressBar1.TabIndex = 49;
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.UseWaitCursor = true;
            // 
            // kolkoRadiany
            // 
            this.kolkoRadiany.Location = new System.Drawing.Point(811, 566);
            this.kolkoRadiany.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kolkoRadiany.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.kolkoRadiany.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.kolkoRadiany.Name = "kolkoRadiany";
            this.kolkoRadiany.Size = new System.Drawing.Size(179, 22);
            this.kolkoRadiany.TabIndex = 50;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(710, 568);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 16);
            this.label15.TabIndex = 51;
            this.label15.Text = "Podaj radiany:";
            this.label15.Click += new System.EventHandler(this.label15_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1550, 1043);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.kolkoRadiany);
            this.Controls.Add(this.circularProgressBar1);
            this.Controls.Add(this.StopnieDane);
            this.Controls.Add(this.radianyWpis);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Radiany);
            this.Controls.Add(this.stopnieWpis);
            this.Controls.Add(this.stopnie);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.labelSymmetryAxis);
            this.Controls.Add(this.Delta);
            this.Controls.Add(this.labelMonotonicity2);
            this.Controls.Add(this.labelYIntercept2);
            this.Controls.Add(this.labelZeros2);
            this.Controls.Add(this.labelMonotonicity);
            this.Controls.Add(this.labelYIntercept);
            this.Controls.Add(this.labelZeros);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.numericUpDownC2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDownStart2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDownB2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numericUpDownA2);
            this.Controls.Add(this.numericUpDownEnd1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownStart1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownB1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownA1);
            this.Controls.Add(this.numericUpDownEnd2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cartesianChart1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wykresy Funkcji (Artem Mamczenko III TP)";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEnd2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEnd1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownC2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopnieWpis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radianyWpis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolkoRadiany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownEnd2;
        private System.Windows.Forms.NumericUpDown numericUpDownA1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownB1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownStart1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownEnd1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownStart2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownB2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDownA2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDownC2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelZeros;
        private System.Windows.Forms.Label labelYIntercept;
        private System.Windows.Forms.Label labelMonotonicity;
        private System.Windows.Forms.Label labelMonotonicity2;
        private System.Windows.Forms.Label labelYIntercept2;
        private System.Windows.Forms.Label labelZeros2;
        private System.Windows.Forms.Label Delta;
        private System.Windows.Forms.Label labelSymmetryAxis;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label stopnie;
        private System.Windows.Forms.NumericUpDown stopnieWpis;
        private System.Windows.Forms.Label Radiany;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown radianyWpis;
        private System.Windows.Forms.Label StopnieDane;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.NumericUpDown kolkoRadiany;
        private System.Windows.Forms.Label label15;
    }
}

