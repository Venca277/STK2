namespace STK2
{
    partial class STKmain
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Osobní automobily");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Nákladní automobily");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Motocykly");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Karavany a obytná vozidla");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Silniční vozidla", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Malá plavidla");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Velká plavidla");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Plavidla", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Malá letadla");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Dopravní letadla");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Vrtulníky a helikoptéry");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Letouny", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Zemědělská technika");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Stavební technika");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Vojenská vozidla");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Speciální vozidla");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Speciální a jiná vozidla", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(STKmain));
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonTreeView1 = new ComponentFactory.Krypton.Toolkit.KryptonTreeView();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.zakladni_infoPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.znacka_modeltxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.druh_vozidlatxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.spz_rztxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.vintxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.registracetxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.typ_variantatxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.barva_karoserietxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonComboBox1 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonCheckBox1 = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.zakladni_infoPanel)).BeginInit();
            this.zakladni_infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Form;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // kryptonTreeView1
            // 
            this.kryptonTreeView1.BorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.InputControlRibbon;
            this.kryptonTreeView1.Location = new System.Drawing.Point(12, 12);
            this.kryptonTreeView1.Name = "kryptonTreeView1";
            treeNode1.Name = "Uzel0";
            treeNode1.Text = "Osobní automobily";
            treeNode2.Name = "Uzel1";
            treeNode2.Text = "Nákladní automobily";
            treeNode3.Name = "Uzel2";
            treeNode3.Text = "Motocykly";
            treeNode4.Name = "Uzel3";
            treeNode4.Text = "Karavany a obytná vozidla";
            treeNode5.Name = "Uzel0";
            treeNode5.Text = "Silniční vozidla";
            treeNode6.Name = "Uzel5";
            treeNode6.Text = "Malá plavidla";
            treeNode7.Name = "Uzel6";
            treeNode7.Text = "Velká plavidla";
            treeNode8.Name = "Uzel4";
            treeNode8.Text = "Plavidla";
            treeNode9.Name = "Uzel8";
            treeNode9.Text = "Malá letadla";
            treeNode10.Name = "Uzel9";
            treeNode10.Text = "Dopravní letadla";
            treeNode11.Name = "Uzel10";
            treeNode11.Text = "Vrtulníky a helikoptéry";
            treeNode12.Name = "Uzel7";
            treeNode12.Text = "Letouny";
            treeNode13.Name = "Uzel12";
            treeNode13.Text = "Zemědělská technika";
            treeNode14.Name = "Uzel13";
            treeNode14.Text = "Stavební technika";
            treeNode15.Name = "Uzel14";
            treeNode15.Text = "Vojenská vozidla";
            treeNode16.Name = "Uzel16";
            treeNode16.Text = "Speciální vozidla";
            treeNode17.Name = "Uzel11";
            treeNode17.Text = "Speciální a jiná vozidla";
            this.kryptonTreeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode8,
            treeNode12,
            treeNode17});
            this.kryptonTreeView1.Palette = this.kryptonPalette1;
            this.kryptonTreeView1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonTreeView1.Size = new System.Drawing.Size(410, 432);
            this.kryptonTreeView1.StateCommon.Node.Content.ShortText.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kryptonTreeView1.TabIndex = 0;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kryptonButton1.CausesValidation = false;
            this.kryptonButton1.Location = new System.Drawing.Point(220, 450);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(221)))), ((int)(((byte)(119)))));
            this.kryptonButton1.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.kryptonButton1.OverrideDefault.Back.ColorAngle = 45F;
            this.kryptonButton1.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kryptonButton1.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kryptonButton1.OverrideDefault.Border.ColorAngle = 45F;
            this.kryptonButton1.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton1.OverrideDefault.Border.Rounding = 30;
            this.kryptonButton1.OverrideDefault.Border.Width = 1;
            this.kryptonButton1.OverrideDefault.Content.Padding = new System.Windows.Forms.Padding(0);
            this.kryptonButton1.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kryptonButton1.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.OverrideFocus.Border.Rounding = 30;
            this.kryptonButton1.OverrideFocus.Border.Width = 1;
            this.kryptonButton1.OverrideFocus.Content.Padding = new System.Windows.Forms.Padding(0);
            this.kryptonButton1.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.OverrideFocus.Content.ShortText.ColorAngle = 45F;
            this.kryptonButton1.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonButton1.Size = new System.Drawing.Size(202, 70);
            this.kryptonButton1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(221)))), ((int)(((byte)(119)))));
            this.kryptonButton1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.kryptonButton1.StateCommon.Back.ColorAngle = 45F;
            this.kryptonButton1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(221)))), ((int)(((byte)(119)))));
            this.kryptonButton1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(221)))), ((int)(((byte)(119)))));
            this.kryptonButton1.StateCommon.Border.ColorAngle = 45F;
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton1.StateCommon.Border.Rounding = 30;
            this.kryptonButton1.StateCommon.Border.Width = 1;
            this.kryptonButton1.StateCommon.Content.Padding = new System.Windows.Forms.Padding(0);
            this.kryptonButton1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kryptonButton1.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateNormal.Border.Rounding = 30;
            this.kryptonButton1.StateNormal.Border.Width = 1;
            this.kryptonButton1.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateNormal.Content.ShortText.ColorAngle = 45F;
            this.kryptonButton1.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kryptonButton1.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(221)))), ((int)(((byte)(119)))));
            this.kryptonButton1.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.kryptonButton1.StatePressed.Back.ColorAngle = 135F;
            this.kryptonButton1.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.kryptonButton1.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.kryptonButton1.StatePressed.Border.ColorAngle = 135F;
            this.kryptonButton1.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StatePressed.Border.Rounding = 30;
            this.kryptonButton1.StatePressed.Border.Width = 1;
            this.kryptonButton1.StatePressed.Content.Padding = new System.Windows.Forms.Padding(0);
            this.kryptonButton1.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kryptonButton1.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(221)))), ((int)(((byte)(119)))));
            this.kryptonButton1.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.kryptonButton1.StateTracking.Back.ColorAngle = 45F;
            this.kryptonButton1.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kryptonButton1.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kryptonButton1.StateTracking.Border.ColorAngle = 45F;
            this.kryptonButton1.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton1.StateTracking.Border.Rounding = 30;
            this.kryptonButton1.StateTracking.Border.Width = 1;
            this.kryptonButton1.StateTracking.Content.Padding = new System.Windows.Forms.Padding(0);
            this.kryptonButton1.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton1.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton1.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kryptonButton1.TabIndex = 3;
            this.kryptonButton1.Values.Text = "Přidat vozidlo";
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kryptonButton2.CausesValidation = false;
            this.kryptonButton2.Location = new System.Drawing.Point(12, 450);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.kryptonButton2.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.kryptonButton2.OverrideDefault.Back.ColorAngle = 45F;
            this.kryptonButton2.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kryptonButton2.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kryptonButton2.OverrideDefault.Border.ColorAngle = 45F;
            this.kryptonButton2.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton2.OverrideDefault.Border.Rounding = 30;
            this.kryptonButton2.OverrideDefault.Border.Width = 1;
            this.kryptonButton2.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton2.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton2.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kryptonButton2.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.OverrideFocus.Border.Rounding = 30;
            this.kryptonButton2.OverrideFocus.Border.Width = 1;
            this.kryptonButton2.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton2.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton2.OverrideFocus.Content.ShortText.ColorAngle = 45F;
            this.kryptonButton2.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kryptonButton2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonButton2.Size = new System.Drawing.Size(202, 70);
            this.kryptonButton2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.kryptonButton2.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.kryptonButton2.StateCommon.Back.ColorAngle = 45F;
            this.kryptonButton2.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(221)))), ((int)(((byte)(119)))));
            this.kryptonButton2.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(221)))), ((int)(((byte)(119)))));
            this.kryptonButton2.StateCommon.Border.ColorAngle = 45F;
            this.kryptonButton2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton2.StateCommon.Border.Rounding = 30;
            this.kryptonButton2.StateCommon.Border.Width = 1;
            this.kryptonButton2.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton2.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kryptonButton2.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.StateNormal.Border.Rounding = 30;
            this.kryptonButton2.StateNormal.Border.Width = 1;
            this.kryptonButton2.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton2.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton2.StateNormal.Content.ShortText.ColorAngle = 45F;
            this.kryptonButton2.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kryptonButton2.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.kryptonButton2.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.kryptonButton2.StatePressed.Back.ColorAngle = 135F;
            this.kryptonButton2.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.kryptonButton2.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.kryptonButton2.StatePressed.Border.ColorAngle = 135F;
            this.kryptonButton2.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.StatePressed.Border.Rounding = 30;
            this.kryptonButton2.StatePressed.Border.Width = 1;
            this.kryptonButton2.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton2.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton2.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kryptonButton2.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.kryptonButton2.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.kryptonButton2.StateTracking.Back.ColorAngle = 45F;
            this.kryptonButton2.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.kryptonButton2.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.kryptonButton2.StateTracking.Border.ColorAngle = 45F;
            this.kryptonButton2.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton2.StateTracking.Border.Rounding = 30;
            this.kryptonButton2.StateTracking.Border.Width = 1;
            this.kryptonButton2.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonButton2.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonButton2.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kryptonButton2.TabIndex = 4;
            this.kryptonButton2.Values.Text = "Odebrat vozidlo";
            // 
            // zakladni_infoPanel
            // 
            this.zakladni_infoPanel.Controls.Add(this.barva_karoserietxt);
            this.zakladni_infoPanel.Controls.Add(this.typ_variantatxt);
            this.zakladni_infoPanel.Controls.Add(this.spz_rztxt);
            this.zakladni_infoPanel.Controls.Add(this.vintxt);
            this.zakladni_infoPanel.Controls.Add(this.registracetxt);
            this.zakladni_infoPanel.Controls.Add(this.druh_vozidlatxt);
            this.zakladni_infoPanel.Controls.Add(this.znacka_modeltxt);
            this.zakladni_infoPanel.Controls.Add(this.label7);
            this.zakladni_infoPanel.Controls.Add(this.label6);
            this.zakladni_infoPanel.Controls.Add(this.label5);
            this.zakladni_infoPanel.Controls.Add(this.label4);
            this.zakladni_infoPanel.Controls.Add(this.label3);
            this.zakladni_infoPanel.Controls.Add(this.label2);
            this.zakladni_infoPanel.Controls.Add(this.label1);
            this.zakladni_infoPanel.Location = new System.Drawing.Point(428, 12);
            this.zakladni_infoPanel.Name = "zakladni_infoPanel";
            this.zakladni_infoPanel.Size = new System.Drawing.Size(778, 432);
            this.zakladni_infoPanel.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.zakladni_infoPanel.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.zakladni_infoPanel.StateCommon.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.zakladni_infoPanel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Značka a model: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(17, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Druh vozidla: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(17, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "SPZ / RZ: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(17, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "VIN: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.label5.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(17, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 36);
            this.label5.TabIndex = 4;
            this.label5.Text = "Datum první registrace: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.label6.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(17, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 36);
            this.label6.TabIndex = 5;
            this.label6.Text = "Typ a varianta: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.label7.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(17, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 36);
            this.label7.TabIndex = 6;
            this.label7.Text = "Barva karoserie: ";
            // 
            // znacka_modeltxt
            // 
            this.znacka_modeltxt.Location = new System.Drawing.Point(324, 14);
            this.znacka_modeltxt.Name = "znacka_modeltxt";
            this.znacka_modeltxt.Size = new System.Drawing.Size(436, 43);
            this.znacka_modeltxt.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.znacka_modeltxt.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.znacka_modeltxt.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.znacka_modeltxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.znacka_modeltxt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.znacka_modeltxt.StateCommon.Border.Rounding = 20;
            this.znacka_modeltxt.StateCommon.Border.Width = 1;
            this.znacka_modeltxt.TabIndex = 7;
            this.znacka_modeltxt.TextChanged += new System.EventHandler(this.kryptonTextBox1_TextChanged);
            // 
            // druh_vozidlatxt
            // 
            this.druh_vozidlatxt.Location = new System.Drawing.Point(324, 74);
            this.druh_vozidlatxt.Name = "druh_vozidlatxt";
            this.druh_vozidlatxt.Size = new System.Drawing.Size(436, 43);
            this.druh_vozidlatxt.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.druh_vozidlatxt.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.druh_vozidlatxt.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.druh_vozidlatxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.druh_vozidlatxt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.druh_vozidlatxt.StateCommon.Border.Rounding = 20;
            this.druh_vozidlatxt.StateCommon.Border.Width = 1;
            this.druh_vozidlatxt.TabIndex = 8;
            // 
            // spz_rztxt
            // 
            this.spz_rztxt.Location = new System.Drawing.Point(324, 134);
            this.spz_rztxt.Name = "spz_rztxt";
            this.spz_rztxt.Size = new System.Drawing.Size(436, 43);
            this.spz_rztxt.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.spz_rztxt.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.spz_rztxt.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.spz_rztxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.spz_rztxt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.spz_rztxt.StateCommon.Border.Rounding = 20;
            this.spz_rztxt.StateCommon.Border.Width = 1;
            this.spz_rztxt.TabIndex = 8;
            // 
            // vintxt
            // 
            this.vintxt.Location = new System.Drawing.Point(324, 194);
            this.vintxt.Name = "vintxt";
            this.vintxt.Size = new System.Drawing.Size(436, 43);
            this.vintxt.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.vintxt.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.vintxt.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.vintxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.vintxt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.vintxt.StateCommon.Border.Rounding = 20;
            this.vintxt.StateCommon.Border.Width = 1;
            this.vintxt.TabIndex = 9;
            // 
            // registracetxt
            // 
            this.registracetxt.Location = new System.Drawing.Point(324, 254);
            this.registracetxt.Name = "registracetxt";
            this.registracetxt.Size = new System.Drawing.Size(436, 43);
            this.registracetxt.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.registracetxt.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.registracetxt.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.registracetxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.registracetxt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.registracetxt.StateCommon.Border.Rounding = 20;
            this.registracetxt.StateCommon.Border.Width = 1;
            this.registracetxt.TabIndex = 10;
            // 
            // typ_variantatxt
            // 
            this.typ_variantatxt.Location = new System.Drawing.Point(324, 314);
            this.typ_variantatxt.Name = "typ_variantatxt";
            this.typ_variantatxt.Size = new System.Drawing.Size(436, 43);
            this.typ_variantatxt.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.typ_variantatxt.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.typ_variantatxt.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.typ_variantatxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.typ_variantatxt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.typ_variantatxt.StateCommon.Border.Rounding = 20;
            this.typ_variantatxt.StateCommon.Border.Width = 1;
            this.typ_variantatxt.TabIndex = 8;
            // 
            // barva_karoserietxt
            // 
            this.barva_karoserietxt.Location = new System.Drawing.Point(324, 374);
            this.barva_karoserietxt.Name = "barva_karoserietxt";
            this.barva_karoserietxt.Size = new System.Drawing.Size(436, 43);
            this.barva_karoserietxt.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.barva_karoserietxt.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.barva_karoserietxt.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.barva_karoserietxt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.barva_karoserietxt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.barva_karoserietxt.StateCommon.Border.Rounding = 20;
            this.barva_karoserietxt.StateCommon.Border.Width = 1;
            this.barva_karoserietxt.TabIndex = 11;
            // 
            // kryptonComboBox1
            // 
            this.kryptonComboBox1.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonNavigatorMini;
            this.kryptonComboBox1.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            this.kryptonComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kryptonComboBox1.DropDownWidth = 325;
            this.kryptonComboBox1.Items.AddRange(new object[] {
            "Základní identifikace vozidla",
            "Stav STK",
            "Technické údaje",
            "Majitel a provozovatel",
            "Kontroly, zásahy a nehody"});
            this.kryptonComboBox1.ItemStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorStack;
            this.kryptonComboBox1.Location = new System.Drawing.Point(865, 460);
            this.kryptonComboBox1.Name = "kryptonComboBox1";
            this.kryptonComboBox1.Size = new System.Drawing.Size(341, 48);
            this.kryptonComboBox1.StateActive.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.kryptonComboBox1.StateActive.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.kryptonComboBox1.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.kryptonComboBox1.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.kryptonComboBox1.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.kryptonComboBox1.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonComboBox1.StateCommon.ComboBox.Border.Rounding = 20;
            this.kryptonComboBox1.StateCommon.ComboBox.Border.Width = 2;
            this.kryptonComboBox1.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.kryptonComboBox1.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kryptonComboBox1.StateCommon.DropBack.Color1 = System.Drawing.Color.Transparent;
            this.kryptonComboBox1.StateCommon.DropBack.Color2 = System.Drawing.Color.Transparent;
            this.kryptonComboBox1.StateCommon.DropBack.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonComboBox1.StateCommon.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.kryptonComboBox1.StateCommon.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.kryptonComboBox1.StateCommon.Item.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.kryptonComboBox1.StateCommon.Item.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.kryptonComboBox1.StateCommon.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonComboBox1.StateCommon.Item.Content.AdjacentGap = 2;
            this.kryptonComboBox1.StateCommon.Item.Content.Padding = new System.Windows.Forms.Padding(1);
            this.kryptonComboBox1.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.kryptonComboBox1.StateCommon.Item.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.kryptonComboBox1.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kryptonComboBox1.StateCommon.Item.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.kryptonComboBox1.TabIndex = 6;
            this.kryptonComboBox1.Click += new System.EventHandler(this.kryptonComboBox1_Click);
            this.kryptonComboBox1.Enter += new System.EventHandler(this.kryptonComboBox1_Enter);
            // 
            // kryptonCheckBox1
            // 
            this.kryptonCheckBox1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.SuperTip;
            this.kryptonCheckBox1.Location = new System.Drawing.Point(655, 467);
            this.kryptonCheckBox1.Name = "kryptonCheckBox1";
            this.kryptonCheckBox1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonCheckBox1.Size = new System.Drawing.Size(203, 35);
            this.kryptonCheckBox1.TabIndex = 7;
            this.kryptonCheckBox1.Values.Text = "Vždy zobrazit první";
            // 
            // STKmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1218, 734);
            this.Controls.Add(this.kryptonCheckBox1);
            this.Controls.Add(this.kryptonComboBox1);
            this.Controls.Add(this.zakladni_infoPanel);
            this.Controls.Add(this.kryptonButton2);
            this.Controls.Add(this.kryptonButton1);
            this.Controls.Add(this.kryptonTreeView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "STKmain";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.Text = "STK údržba vozidel";
            ((System.ComponentModel.ISupportInitialize)(this.zakladni_infoPanel)).EndInit();
            this.zakladni_infoPanel.ResumeLayout(false);
            this.zakladni_infoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonTreeView kryptonTreeView1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel zakladni_infoPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox barva_karoserietxt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox typ_variantatxt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox spz_rztxt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox vintxt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox registracetxt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox druh_vozidlatxt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox znacka_modeltxt;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox kryptonCheckBox1;
    }
}