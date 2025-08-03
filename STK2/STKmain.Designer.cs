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
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Osobní automobily");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Nákladní automobily");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Motocykly");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Karavany a obytná vozidla");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Silniční vozidla", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22});
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Malá plavidla");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Velká plavidla");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Plavidla", new System.Windows.Forms.TreeNode[] {
            treeNode24,
            treeNode25});
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Malá letadla");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Dopravní letadla");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Vrtulníky a helikoptéry");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Letouny", new System.Windows.Forms.TreeNode[] {
            treeNode27,
            treeNode28,
            treeNode29});
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Zemědělská technika");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Stavební technika");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Vojenská vozidla");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Speciální vozidla");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Speciální a jiná vozidla", new System.Windows.Forms.TreeNode[] {
            treeNode31,
            treeNode32,
            treeNode33,
            treeNode34});
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Hlavní přehled");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(STKmain));
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonTreeView1 = new ComponentFactory.Krypton.Toolkit.KryptonTreeView();
            this.pridatButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.odebratButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonComboBox1 = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.backButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.nextButton = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.technicke_udajePanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.rozmeryTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.mistaTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pneuTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.hmotnostTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.vykonTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.palivoTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pohonTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.stav_stkPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.vysledekEKPanel = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.vysledekSTKPanel = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.platnostEKDateTimePicker = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.platnostSTKDateTimePicker = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.posledniSTKDateTimePicker = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.poznamkyTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.typSTKTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.majitelPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.poznamky_vlastnikBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.vlastnikTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.provozovatelTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kontaktTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.historiePanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.label26 = new System.Windows.Forms.Label();
            this.zaznamyTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.poznamkySTKTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.vlastnictviTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.zakladni_infoPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.registraceDateTimePicker = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.barva_karoserietxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.typ_variantatxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.vintxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.znacka_modeltxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.druh_vozidlatxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.spz_rztxt = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ulozitLabel = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.shrnutiTextBox = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.gradientPanel1 = new GradientPanel();
            this.logoutLabel = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.nastaveniLabel = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.nameLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicke_udajePanel)).BeginInit();
            this.technicke_udajePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stav_stkPanel)).BeginInit();
            this.stav_stkPanel.SuspendLayout();
            this.vysledekEKPanel.SuspendLayout();
            this.vysledekSTKPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.majitelPanel)).BeginInit();
            this.majitelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historiePanel)).BeginInit();
            this.historiePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zakladni_infoPanel)).BeginInit();
            this.zakladni_infoPanel.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
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
            treeNode19.Name = "osobni";
            treeNode19.Text = "Osobní automobily";
            treeNode20.Name = "nakladni";
            treeNode20.Text = "Nákladní automobily";
            treeNode21.Name = "motocykly";
            treeNode21.Text = "Motocykly";
            treeNode22.Name = "karavany";
            treeNode22.Text = "Karavany a obytná vozidla";
            treeNode23.Name = "silnicni_vozidla";
            treeNode23.Text = "Silniční vozidla";
            treeNode24.Name = "mala_plavidla";
            treeNode24.Text = "Malá plavidla";
            treeNode25.Name = "velka_plavidla";
            treeNode25.Text = "Velká plavidla";
            treeNode26.Name = "plavidla";
            treeNode26.Text = "Plavidla";
            treeNode27.Name = "mala_letadla";
            treeNode27.Text = "Malá letadla";
            treeNode28.Name = "dopravni_letadla";
            treeNode28.Text = "Dopravní letadla";
            treeNode29.Name = "vrtulniky";
            treeNode29.Text = "Vrtulníky a helikoptéry";
            treeNode30.Name = "letouny";
            treeNode30.Text = "Letouny";
            treeNode31.Name = "zemedelska_technika";
            treeNode31.Text = "Zemědělská technika";
            treeNode32.Name = "stavebni_technika";
            treeNode32.Text = "Stavební technika";
            treeNode33.Name = "vojenska_technika";
            treeNode33.Text = "Vojenská vozidla";
            treeNode34.Name = "specialni_technika";
            treeNode34.Text = "Speciální vozidla";
            treeNode35.Name = "specialni_vozidla";
            treeNode35.Text = "Speciální a jiná vozidla";
            treeNode36.Name = "prehled";
            treeNode36.Text = "Hlavní přehled";
            this.kryptonTreeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode23,
            treeNode26,
            treeNode30,
            treeNode35,
            treeNode36});
            this.kryptonTreeView1.Palette = this.kryptonPalette1;
            this.kryptonTreeView1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.kryptonTreeView1.Size = new System.Drawing.Size(410, 432);
            this.kryptonTreeView1.StateCommon.Node.Content.ShortText.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kryptonTreeView1.TabIndex = 0;
            this.kryptonTreeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.kryptonTreeView1_AfterSelect);
            // 
            // pridatButton
            // 
            this.pridatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pridatButton.CausesValidation = false;
            this.pridatButton.Location = new System.Drawing.Point(220, 450);
            this.pridatButton.Name = "pridatButton";
            this.pridatButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(221)))), ((int)(((byte)(119)))));
            this.pridatButton.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.pridatButton.OverrideDefault.Back.ColorAngle = 45F;
            this.pridatButton.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.pridatButton.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.pridatButton.OverrideDefault.Border.ColorAngle = 45F;
            this.pridatButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.pridatButton.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.pridatButton.OverrideDefault.Border.Rounding = 30;
            this.pridatButton.OverrideDefault.Border.Width = 1;
            this.pridatButton.OverrideDefault.Content.Padding = new System.Windows.Forms.Padding(0);
            this.pridatButton.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.pridatButton.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.pridatButton.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pridatButton.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.pridatButton.OverrideFocus.Border.Rounding = 30;
            this.pridatButton.OverrideFocus.Border.Width = 1;
            this.pridatButton.OverrideFocus.Content.Padding = new System.Windows.Forms.Padding(0);
            this.pridatButton.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.pridatButton.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.pridatButton.OverrideFocus.Content.ShortText.ColorAngle = 45F;
            this.pridatButton.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pridatButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.pridatButton.Size = new System.Drawing.Size(202, 70);
            this.pridatButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(221)))), ((int)(((byte)(119)))));
            this.pridatButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.pridatButton.StateCommon.Back.ColorAngle = 45F;
            this.pridatButton.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(221)))), ((int)(((byte)(119)))));
            this.pridatButton.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(221)))), ((int)(((byte)(119)))));
            this.pridatButton.StateCommon.Border.ColorAngle = 45F;
            this.pridatButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.pridatButton.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.pridatButton.StateCommon.Border.Rounding = 30;
            this.pridatButton.StateCommon.Border.Width = 1;
            this.pridatButton.StateCommon.Content.Padding = new System.Windows.Forms.Padding(0);
            this.pridatButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.pridatButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.pridatButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pridatButton.StateDisabled.Back.Color1 = System.Drawing.Color.Gray;
            this.pridatButton.StateDisabled.Back.Color2 = System.Drawing.Color.Gray;
            this.pridatButton.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.pridatButton.StateNormal.Border.Rounding = 30;
            this.pridatButton.StateNormal.Border.Width = 1;
            this.pridatButton.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.pridatButton.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.pridatButton.StateNormal.Content.ShortText.ColorAngle = 45F;
            this.pridatButton.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pridatButton.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(221)))), ((int)(((byte)(119)))));
            this.pridatButton.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.pridatButton.StatePressed.Back.ColorAngle = 135F;
            this.pridatButton.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.pridatButton.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.pridatButton.StatePressed.Border.ColorAngle = 135F;
            this.pridatButton.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.pridatButton.StatePressed.Border.Rounding = 30;
            this.pridatButton.StatePressed.Border.Width = 1;
            this.pridatButton.StatePressed.Content.Padding = new System.Windows.Forms.Padding(0);
            this.pridatButton.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.pridatButton.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.pridatButton.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pridatButton.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(221)))), ((int)(((byte)(119)))));
            this.pridatButton.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.pridatButton.StateTracking.Back.ColorAngle = 45F;
            this.pridatButton.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.pridatButton.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.pridatButton.StateTracking.Border.ColorAngle = 45F;
            this.pridatButton.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.pridatButton.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.pridatButton.StateTracking.Border.Rounding = 30;
            this.pridatButton.StateTracking.Border.Width = 1;
            this.pridatButton.StateTracking.Content.Padding = new System.Windows.Forms.Padding(0);
            this.pridatButton.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.pridatButton.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.pridatButton.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pridatButton.TabIndex = 3;
            this.pridatButton.Values.Text = "Přidat vozidlo";
            this.pridatButton.Click += new System.EventHandler(this.pridatButton_Click);
            // 
            // odebratButton
            // 
            this.odebratButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.odebratButton.CausesValidation = false;
            this.odebratButton.Location = new System.Drawing.Point(12, 450);
            this.odebratButton.Name = "odebratButton";
            this.odebratButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.odebratButton.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.odebratButton.OverrideDefault.Back.ColorAngle = 45F;
            this.odebratButton.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.odebratButton.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.odebratButton.OverrideDefault.Border.ColorAngle = 45F;
            this.odebratButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.odebratButton.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.odebratButton.OverrideDefault.Border.Rounding = 30;
            this.odebratButton.OverrideDefault.Border.Width = 1;
            this.odebratButton.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.odebratButton.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.odebratButton.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odebratButton.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.odebratButton.OverrideFocus.Border.Rounding = 30;
            this.odebratButton.OverrideFocus.Border.Width = 1;
            this.odebratButton.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.odebratButton.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.odebratButton.OverrideFocus.Content.ShortText.ColorAngle = 45F;
            this.odebratButton.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odebratButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.odebratButton.Size = new System.Drawing.Size(202, 70);
            this.odebratButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.odebratButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.odebratButton.StateCommon.Back.ColorAngle = 45F;
            this.odebratButton.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(221)))), ((int)(((byte)(119)))));
            this.odebratButton.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(221)))), ((int)(((byte)(119)))));
            this.odebratButton.StateCommon.Border.ColorAngle = 45F;
            this.odebratButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.odebratButton.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.odebratButton.StateCommon.Border.Rounding = 30;
            this.odebratButton.StateCommon.Border.Width = 1;
            this.odebratButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.odebratButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.odebratButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odebratButton.StateDisabled.Back.Color1 = System.Drawing.Color.Gray;
            this.odebratButton.StateDisabled.Back.Color2 = System.Drawing.Color.Gray;
            this.odebratButton.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.odebratButton.StateNormal.Border.Rounding = 30;
            this.odebratButton.StateNormal.Border.Width = 1;
            this.odebratButton.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.odebratButton.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.odebratButton.StateNormal.Content.ShortText.ColorAngle = 45F;
            this.odebratButton.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odebratButton.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.odebratButton.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.odebratButton.StatePressed.Back.ColorAngle = 135F;
            this.odebratButton.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.odebratButton.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.odebratButton.StatePressed.Border.ColorAngle = 135F;
            this.odebratButton.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.odebratButton.StatePressed.Border.Rounding = 30;
            this.odebratButton.StatePressed.Border.Width = 1;
            this.odebratButton.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.odebratButton.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.odebratButton.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odebratButton.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.odebratButton.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.odebratButton.StateTracking.Back.ColorAngle = 45F;
            this.odebratButton.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.odebratButton.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.odebratButton.StateTracking.Border.ColorAngle = 45F;
            this.odebratButton.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.odebratButton.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.odebratButton.StateTracking.Border.Rounding = 30;
            this.odebratButton.StateTracking.Border.Width = 1;
            this.odebratButton.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.odebratButton.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.odebratButton.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odebratButton.TabIndex = 4;
            this.odebratButton.Values.Text = "Odebrat vozidlo";
            this.odebratButton.Click += new System.EventHandler(this.odebratButton_Click);
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
            this.kryptonComboBox1.Location = new System.Drawing.Point(652, 455);
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
            this.kryptonComboBox1.SelectedIndexChanged += new System.EventHandler(this.kryptonComboBox1_SelectedIndexChanged);
            // 
            // backButton
            // 
            this.backButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backButton.CausesValidation = false;
            this.backButton.Location = new System.Drawing.Point(530, 450);
            this.backButton.Name = "backButton";
            this.backButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(221)))), ((int)(((byte)(119)))));
            this.backButton.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.backButton.OverrideDefault.Back.ColorAngle = 45F;
            this.backButton.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.backButton.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.backButton.OverrideDefault.Border.ColorAngle = 45F;
            this.backButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.backButton.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.backButton.OverrideDefault.Border.Rounding = 30;
            this.backButton.OverrideDefault.Border.Width = 1;
            this.backButton.OverrideDefault.Content.Padding = new System.Windows.Forms.Padding(0);
            this.backButton.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.backButton.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.backButton.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.backButton.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.backButton.OverrideFocus.Border.Rounding = 30;
            this.backButton.OverrideFocus.Border.Width = 1;
            this.backButton.OverrideFocus.Content.Padding = new System.Windows.Forms.Padding(0);
            this.backButton.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.backButton.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.backButton.OverrideFocus.Content.ShortText.ColorAngle = 45F;
            this.backButton.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.backButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.backButton.Size = new System.Drawing.Size(108, 70);
            this.backButton.StateCommon.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.backButton.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.backButton.StateCommon.Back.ColorAngle = 45F;
            this.backButton.StateCommon.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.backButton.StateCommon.Border.Color2 = System.Drawing.Color.DodgerBlue;
            this.backButton.StateCommon.Border.ColorAngle = 45F;
            this.backButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.backButton.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.backButton.StateCommon.Border.Rounding = 30;
            this.backButton.StateCommon.Border.Width = 1;
            this.backButton.StateCommon.Content.Padding = new System.Windows.Forms.Padding(0);
            this.backButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.backButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.backButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.backButton.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.backButton.StateNormal.Border.Rounding = 30;
            this.backButton.StateNormal.Border.Width = 1;
            this.backButton.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.backButton.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.backButton.StateNormal.Content.ShortText.ColorAngle = 45F;
            this.backButton.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.backButton.StatePressed.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.backButton.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.backButton.StatePressed.Back.ColorAngle = 135F;
            this.backButton.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.backButton.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.backButton.StatePressed.Border.ColorAngle = 135F;
            this.backButton.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.backButton.StatePressed.Border.Rounding = 30;
            this.backButton.StatePressed.Border.Width = 1;
            this.backButton.StatePressed.Content.Padding = new System.Windows.Forms.Padding(0);
            this.backButton.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.backButton.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.backButton.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.backButton.StateTracking.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.backButton.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.backButton.StateTracking.Back.ColorAngle = 45F;
            this.backButton.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.backButton.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.backButton.StateTracking.Border.ColorAngle = 45F;
            this.backButton.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.backButton.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.backButton.StateTracking.Border.Rounding = 30;
            this.backButton.StateTracking.Border.Width = 1;
            this.backButton.StateTracking.Content.Padding = new System.Windows.Forms.Padding(0);
            this.backButton.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.backButton.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.backButton.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.backButton.TabIndex = 11;
            this.backButton.Values.Text = "◄";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nextButton.CausesValidation = false;
            this.nextButton.Location = new System.Drawing.Point(1008, 450);
            this.nextButton.Name = "nextButton";
            this.nextButton.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(221)))), ((int)(((byte)(119)))));
            this.nextButton.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.nextButton.OverrideDefault.Back.ColorAngle = 45F;
            this.nextButton.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.nextButton.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.nextButton.OverrideDefault.Border.ColorAngle = 45F;
            this.nextButton.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nextButton.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.nextButton.OverrideDefault.Border.Rounding = 30;
            this.nextButton.OverrideDefault.Border.Width = 1;
            this.nextButton.OverrideDefault.Content.Padding = new System.Windows.Forms.Padding(0);
            this.nextButton.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.nextButton.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.nextButton.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nextButton.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nextButton.OverrideFocus.Border.Rounding = 30;
            this.nextButton.OverrideFocus.Border.Width = 1;
            this.nextButton.OverrideFocus.Content.Padding = new System.Windows.Forms.Padding(0);
            this.nextButton.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.nextButton.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.nextButton.OverrideFocus.Content.ShortText.ColorAngle = 45F;
            this.nextButton.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nextButton.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.nextButton.Size = new System.Drawing.Size(108, 70);
            this.nextButton.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.nextButton.StateCommon.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.nextButton.StateCommon.Back.ColorAngle = -45F;
            this.nextButton.StateCommon.Border.Color1 = System.Drawing.Color.DodgerBlue;
            this.nextButton.StateCommon.Border.Color2 = System.Drawing.Color.DodgerBlue;
            this.nextButton.StateCommon.Border.ColorAngle = 45F;
            this.nextButton.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nextButton.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.nextButton.StateCommon.Border.Rounding = 30;
            this.nextButton.StateCommon.Border.Width = 1;
            this.nextButton.StateCommon.Content.Padding = new System.Windows.Forms.Padding(0);
            this.nextButton.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.nextButton.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.nextButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nextButton.StateNormal.Back.Image = ((System.Drawing.Image)(resources.GetObject("nextButton.StateNormal.Back.Image")));
            this.nextButton.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nextButton.StateNormal.Border.Rounding = 30;
            this.nextButton.StateNormal.Border.Width = 1;
            this.nextButton.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.nextButton.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.nextButton.StateNormal.Content.ShortText.ColorAngle = 45F;
            this.nextButton.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Poppins Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nextButton.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.nextButton.StatePressed.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.nextButton.StatePressed.Back.ColorAngle = 135F;
            this.nextButton.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.nextButton.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.nextButton.StatePressed.Border.ColorAngle = 135F;
            this.nextButton.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nextButton.StatePressed.Border.Rounding = 30;
            this.nextButton.StatePressed.Border.Width = 1;
            this.nextButton.StatePressed.Content.Padding = new System.Windows.Forms.Padding(0);
            this.nextButton.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.nextButton.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.nextButton.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nextButton.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.nextButton.StateTracking.Back.Color2 = System.Drawing.Color.DodgerBlue;
            this.nextButton.StateTracking.Back.ColorAngle = 45F;
            this.nextButton.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.nextButton.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.nextButton.StateTracking.Border.ColorAngle = 45F;
            this.nextButton.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nextButton.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.nextButton.StateTracking.Border.Rounding = 30;
            this.nextButton.StateTracking.Border.Width = 1;
            this.nextButton.StateTracking.Content.Padding = new System.Windows.Forms.Padding(0);
            this.nextButton.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.nextButton.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.nextButton.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nextButton.TabIndex = 12;
            this.nextButton.Values.Image = ((System.Drawing.Image)(resources.GetObject("nextButton.Values.Image")));
            this.nextButton.Values.Text = "►";
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Visible = true;
            // 
            // technicke_udajePanel
            // 
            this.technicke_udajePanel.Controls.Add(this.rozmeryTextBox);
            this.technicke_udajePanel.Controls.Add(this.label17);
            this.technicke_udajePanel.Controls.Add(this.label18);
            this.technicke_udajePanel.Controls.Add(this.label19);
            this.technicke_udajePanel.Controls.Add(this.mistaTextBox);
            this.technicke_udajePanel.Controls.Add(this.pneuTextBox);
            this.technicke_udajePanel.Controls.Add(this.hmotnostTextBox);
            this.technicke_udajePanel.Controls.Add(this.vykonTextBox);
            this.technicke_udajePanel.Controls.Add(this.label20);
            this.technicke_udajePanel.Controls.Add(this.label21);
            this.technicke_udajePanel.Controls.Add(this.label22);
            this.technicke_udajePanel.Controls.Add(this.label23);
            this.technicke_udajePanel.Controls.Add(this.palivoTextBox);
            this.technicke_udajePanel.Controls.Add(this.pohonTextBox);
            this.technicke_udajePanel.Location = new System.Drawing.Point(1202, 12);
            this.technicke_udajePanel.Name = "technicke_udajePanel";
            this.technicke_udajePanel.Size = new System.Drawing.Size(786, 432);
            this.technicke_udajePanel.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.technicke_udajePanel.StateCommon.Color2 = System.Drawing.Color.Gray;
            this.technicke_udajePanel.StateCommon.ColorAngle = 45F;
            this.technicke_udajePanel.TabIndex = 12;
            // 
            // rozmeryTextBox
            // 
            this.rozmeryTextBox.Location = new System.Drawing.Point(324, 375);
            this.rozmeryTextBox.Name = "rozmeryTextBox";
            this.rozmeryTextBox.Size = new System.Drawing.Size(436, 43);
            this.rozmeryTextBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.rozmeryTextBox.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.rozmeryTextBox.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.rozmeryTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.rozmeryTextBox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.rozmeryTextBox.StateCommon.Border.Rounding = 20;
            this.rozmeryTextBox.StateCommon.Border.Width = 1;
            this.rozmeryTextBox.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.label17.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label17.Location = new System.Drawing.Point(17, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(274, 36);
            this.label17.TabIndex = 0;
            this.label17.Text = "Objem a výkon motoru:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.label18.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label18.Location = new System.Drawing.Point(17, 202);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(128, 36);
            this.label18.TabIndex = 3;
            this.label18.Text = "Hmotnost:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.label19.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label19.Location = new System.Drawing.Point(17, 382);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(201, 36);
            this.label19.TabIndex = 6;
            this.label19.Text = "Rozměry vozidla:";
            // 
            // mistaTextBox
            // 
            this.mistaTextBox.Location = new System.Drawing.Point(324, 255);
            this.mistaTextBox.Name = "mistaTextBox";
            this.mistaTextBox.Size = new System.Drawing.Size(436, 43);
            this.mistaTextBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.mistaTextBox.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.mistaTextBox.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.mistaTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.mistaTextBox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.mistaTextBox.StateCommon.Border.Rounding = 20;
            this.mistaTextBox.StateCommon.Border.Width = 1;
            this.mistaTextBox.TabIndex = 10;
            // 
            // pneuTextBox
            // 
            this.pneuTextBox.Location = new System.Drawing.Point(324, 315);
            this.pneuTextBox.Name = "pneuTextBox";
            this.pneuTextBox.Size = new System.Drawing.Size(436, 43);
            this.pneuTextBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.pneuTextBox.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.pneuTextBox.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.pneuTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.pneuTextBox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.pneuTextBox.StateCommon.Border.Rounding = 20;
            this.pneuTextBox.StateCommon.Border.Width = 1;
            this.pneuTextBox.TabIndex = 8;
            // 
            // hmotnostTextBox
            // 
            this.hmotnostTextBox.Location = new System.Drawing.Point(324, 195);
            this.hmotnostTextBox.Name = "hmotnostTextBox";
            this.hmotnostTextBox.Size = new System.Drawing.Size(436, 43);
            this.hmotnostTextBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.hmotnostTextBox.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.hmotnostTextBox.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.hmotnostTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.hmotnostTextBox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.hmotnostTextBox.StateCommon.Border.Rounding = 20;
            this.hmotnostTextBox.StateCommon.Border.Width = 1;
            this.hmotnostTextBox.TabIndex = 9;
            // 
            // vykonTextBox
            // 
            this.vykonTextBox.Location = new System.Drawing.Point(324, 15);
            this.vykonTextBox.Name = "vykonTextBox";
            this.vykonTextBox.Size = new System.Drawing.Size(436, 43);
            this.vykonTextBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.vykonTextBox.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.vykonTextBox.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.vykonTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.vykonTextBox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.vykonTextBox.StateCommon.Border.Rounding = 20;
            this.vykonTextBox.StateCommon.Border.Width = 1;
            this.vykonTextBox.TabIndex = 7;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.label20.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label20.Location = new System.Drawing.Point(17, 262);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(136, 36);
            this.label20.TabIndex = 4;
            this.label20.Text = "Počet míst:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.label21.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label21.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label21.Location = new System.Drawing.Point(17, 82);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(137, 36);
            this.label21.TabIndex = 1;
            this.label21.Text = "Typ paliva:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.label22.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label22.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label22.Location = new System.Drawing.Point(17, 142);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(90, 36);
            this.label22.TabIndex = 2;
            this.label22.Text = "Pohon:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.label23.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label23.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label23.Location = new System.Drawing.Point(17, 322);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(241, 36);
            this.label23.TabIndex = 5;
            this.label23.Text = "Rozměry pneumatik:";
            // 
            // palivoTextBox
            // 
            this.palivoTextBox.Location = new System.Drawing.Point(324, 75);
            this.palivoTextBox.Name = "palivoTextBox";
            this.palivoTextBox.Size = new System.Drawing.Size(436, 43);
            this.palivoTextBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.palivoTextBox.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.palivoTextBox.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.palivoTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.palivoTextBox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.palivoTextBox.StateCommon.Border.Rounding = 20;
            this.palivoTextBox.StateCommon.Border.Width = 1;
            this.palivoTextBox.TabIndex = 8;
            // 
            // pohonTextBox
            // 
            this.pohonTextBox.Location = new System.Drawing.Point(324, 135);
            this.pohonTextBox.Name = "pohonTextBox";
            this.pohonTextBox.Size = new System.Drawing.Size(436, 43);
            this.pohonTextBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.pohonTextBox.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.pohonTextBox.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.pohonTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.pohonTextBox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.pohonTextBox.StateCommon.Border.Rounding = 20;
            this.pohonTextBox.StateCommon.Border.Width = 1;
            this.pohonTextBox.TabIndex = 8;
            // 
            // stav_stkPanel
            // 
            this.stav_stkPanel.Controls.Add(this.vysledekEKPanel);
            this.stav_stkPanel.Controls.Add(this.vysledekSTKPanel);
            this.stav_stkPanel.Controls.Add(this.platnostEKDateTimePicker);
            this.stav_stkPanel.Controls.Add(this.platnostSTKDateTimePicker);
            this.stav_stkPanel.Controls.Add(this.posledniSTKDateTimePicker);
            this.stav_stkPanel.Controls.Add(this.poznamkyTextBox);
            this.stav_stkPanel.Controls.Add(this.label8);
            this.stav_stkPanel.Controls.Add(this.label9);
            this.stav_stkPanel.Controls.Add(this.label10);
            this.stav_stkPanel.Controls.Add(this.typSTKTextBox);
            this.stav_stkPanel.Controls.Add(this.label11);
            this.stav_stkPanel.Controls.Add(this.label12);
            this.stav_stkPanel.Controls.Add(this.label13);
            this.stav_stkPanel.Controls.Add(this.label14);
            this.stav_stkPanel.Location = new System.Drawing.Point(1179, 42);
            this.stav_stkPanel.Name = "stav_stkPanel";
            this.stav_stkPanel.Size = new System.Drawing.Size(786, 432);
            this.stav_stkPanel.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.stav_stkPanel.StateCommon.Color2 = System.Drawing.Color.Gray;
            this.stav_stkPanel.StateCommon.ColorAngle = 45F;
            this.stav_stkPanel.TabIndex = 12;
            // 
            // vysledekEKPanel
            // 
            this.vysledekEKPanel.Controls.Add(this.label16);
            this.vysledekEKPanel.Location = new System.Drawing.Point(576, 134);
            this.vysledekEKPanel.Name = "vysledekEKPanel";
            this.vysledekEKPanel.Size = new System.Drawing.Size(127, 51);
            this.vysledekEKPanel.TabIndex = 21;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(3, 8);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 36);
            this.label16.TabIndex = 0;
            this.label16.Text = "Neplatná";
            // 
            // vysledekSTKPanel
            // 
            this.vysledekSTKPanel.Controls.Add(this.label15);
            this.vysledekSTKPanel.Location = new System.Drawing.Point(220, 134);
            this.vysledekSTKPanel.Name = "vysledekSTKPanel";
            this.vysledekSTKPanel.Size = new System.Drawing.Size(127, 51);
            this.vysledekSTKPanel.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(3, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 36);
            this.label15.TabIndex = 0;
            this.label15.Text = "Platná";
            // 
            // platnostEKDateTimePicker
            // 
            this.platnostEKDateTimePicker.Location = new System.Drawing.Point(324, 76);
            this.platnostEKDateTimePicker.Name = "platnostEKDateTimePicker";
            this.platnostEKDateTimePicker.Size = new System.Drawing.Size(436, 42);
            this.platnostEKDateTimePicker.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.platnostEKDateTimePicker.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.platnostEKDateTimePicker.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.platnostEKDateTimePicker.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.platnostEKDateTimePicker.StateCommon.Border.Rounding = 20;
            this.platnostEKDateTimePicker.StateCommon.Border.Width = 1;
            this.platnostEKDateTimePicker.TabIndex = 19;
            // 
            // platnostSTKDateTimePicker
            // 
            this.platnostSTKDateTimePicker.Location = new System.Drawing.Point(324, 16);
            this.platnostSTKDateTimePicker.Name = "platnostSTKDateTimePicker";
            this.platnostSTKDateTimePicker.Size = new System.Drawing.Size(436, 42);
            this.platnostSTKDateTimePicker.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.platnostSTKDateTimePicker.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.platnostSTKDateTimePicker.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.platnostSTKDateTimePicker.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.platnostSTKDateTimePicker.StateCommon.Border.Rounding = 20;
            this.platnostSTKDateTimePicker.StateCommon.Border.Width = 1;
            this.platnostSTKDateTimePicker.TabIndex = 18;
            // 
            // posledniSTKDateTimePicker
            // 
            this.posledniSTKDateTimePicker.Location = new System.Drawing.Point(324, 255);
            this.posledniSTKDateTimePicker.Name = "posledniSTKDateTimePicker";
            this.posledniSTKDateTimePicker.Size = new System.Drawing.Size(436, 42);
            this.posledniSTKDateTimePicker.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.posledniSTKDateTimePicker.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.posledniSTKDateTimePicker.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.posledniSTKDateTimePicker.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.posledniSTKDateTimePicker.StateCommon.Border.Rounding = 20;
            this.posledniSTKDateTimePicker.StateCommon.Border.Width = 1;
            this.posledniSTKDateTimePicker.TabIndex = 17;
            // 
            // poznamkyTextBox
            // 
            this.poznamkyTextBox.Location = new System.Drawing.Point(324, 314);
            this.poznamkyTextBox.Multiline = true;
            this.poznamkyTextBox.Name = "poznamkyTextBox";
            this.poznamkyTextBox.Size = new System.Drawing.Size(436, 100);
            this.poznamkyTextBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.poznamkyTextBox.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.poznamkyTextBox.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.poznamkyTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.poznamkyTextBox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.poznamkyTextBox.StateCommon.Border.Rounding = 20;
            this.poznamkyTextBox.StateCommon.Border.Width = 1;
            this.poznamkyTextBox.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.label8.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(17, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 36);
            this.label8.TabIndex = 0;
            this.label8.Text = "Platnost STK do: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.label9.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(383, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 36);
            this.label9.TabIndex = 3;
            this.label9.Text = "Výsledek EK: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.label10.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(17, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(263, 36);
            this.label10.TabIndex = 6;
            this.label10.Text = "Poznámky k prohlídce:";
            // 
            // typSTKTextBox
            // 
            this.typSTKTextBox.Location = new System.Drawing.Point(324, 194);
            this.typSTKTextBox.Name = "typSTKTextBox";
            this.typSTKTextBox.Size = new System.Drawing.Size(436, 43);
            this.typSTKTextBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.typSTKTextBox.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.typSTKTextBox.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.typSTKTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.typSTKTextBox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.typSTKTextBox.StateCommon.Border.Rounding = 20;
            this.typSTKTextBox.StateCommon.Border.Width = 1;
            this.typSTKTextBox.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.label11.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(17, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 36);
            this.label11.TabIndex = 4;
            this.label11.Text = "Typ STK / EK:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.label12.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(17, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(177, 36);
            this.label12.TabIndex = 1;
            this.label12.Text = "Platnost EK do:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.label13.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(17, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(165, 36);
            this.label13.TabIndex = 2;
            this.label13.Text = "Výsledek STK:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.label14.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Location = new System.Drawing.Point(17, 261);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(241, 36);
            this.label14.TabIndex = 5;
            this.label14.Text = "Datum poslední STK:";
            // 
            // majitelPanel
            // 
            this.majitelPanel.Controls.Add(this.label24);
            this.majitelPanel.Controls.Add(this.label25);
            this.majitelPanel.Controls.Add(this.poznamky_vlastnikBox);
            this.majitelPanel.Controls.Add(this.vlastnikTextBox);
            this.majitelPanel.Controls.Add(this.label28);
            this.majitelPanel.Controls.Add(this.label29);
            this.majitelPanel.Controls.Add(this.provozovatelTextBox);
            this.majitelPanel.Controls.Add(this.kontaktTextBox);
            this.majitelPanel.Location = new System.Drawing.Point(1162, 71);
            this.majitelPanel.Name = "majitelPanel";
            this.majitelPanel.Size = new System.Drawing.Size(786, 432);
            this.majitelPanel.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.majitelPanel.StateCommon.Color2 = System.Drawing.Color.Gray;
            this.majitelPanel.StateCommon.ColorAngle = 45F;
            this.majitelPanel.TabIndex = 13;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.label24.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label24.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label24.Location = new System.Drawing.Point(17, 22);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(287, 36);
            this.label24.TabIndex = 0;
            this.label24.Text = "Jméno, příjmení (vlast.):";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.label25.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label25.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label25.Location = new System.Drawing.Point(17, 277);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(134, 36);
            this.label25.TabIndex = 3;
            this.label25.Text = "Poznámky:";
            // 
            // poznamky_vlastnikBox
            // 
            this.poznamky_vlastnikBox.Location = new System.Drawing.Point(347, 270);
            this.poznamky_vlastnikBox.Multiline = true;
            this.poznamky_vlastnikBox.Name = "poznamky_vlastnikBox";
            this.poznamky_vlastnikBox.Size = new System.Drawing.Size(413, 142);
            this.poznamky_vlastnikBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.poznamky_vlastnikBox.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.poznamky_vlastnikBox.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.poznamky_vlastnikBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.poznamky_vlastnikBox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.poznamky_vlastnikBox.StateCommon.Border.Rounding = 20;
            this.poznamky_vlastnikBox.StateCommon.Border.Width = 1;
            this.poznamky_vlastnikBox.TabIndex = 9;
            // 
            // vlastnikTextBox
            // 
            this.vlastnikTextBox.Location = new System.Drawing.Point(347, 15);
            this.vlastnikTextBox.Name = "vlastnikTextBox";
            this.vlastnikTextBox.Size = new System.Drawing.Size(413, 43);
            this.vlastnikTextBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.vlastnikTextBox.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.vlastnikTextBox.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.vlastnikTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.vlastnikTextBox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.vlastnikTextBox.StateCommon.Border.Rounding = 20;
            this.vlastnikTextBox.StateCommon.Border.Width = 1;
            this.vlastnikTextBox.TabIndex = 7;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.label28.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label28.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label28.Location = new System.Drawing.Point(17, 82);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(284, 36);
            this.label28.TabIndex = 1;
            this.label28.Text = "Jméno, příjmení (prov.):";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.label29.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label29.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label29.Location = new System.Drawing.Point(17, 142);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(195, 36);
            this.label29.TabIndex = 2;
            this.label29.Text = "Kontaktní údaje:";
            // 
            // provozovatelTextBox
            // 
            this.provozovatelTextBox.Location = new System.Drawing.Point(347, 75);
            this.provozovatelTextBox.Name = "provozovatelTextBox";
            this.provozovatelTextBox.Size = new System.Drawing.Size(413, 43);
            this.provozovatelTextBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.provozovatelTextBox.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.provozovatelTextBox.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.provozovatelTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.provozovatelTextBox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.provozovatelTextBox.StateCommon.Border.Rounding = 20;
            this.provozovatelTextBox.StateCommon.Border.Width = 1;
            this.provozovatelTextBox.TabIndex = 8;
            // 
            // kontaktTextBox
            // 
            this.kontaktTextBox.Location = new System.Drawing.Point(347, 135);
            this.kontaktTextBox.Multiline = true;
            this.kontaktTextBox.Name = "kontaktTextBox";
            this.kontaktTextBox.Size = new System.Drawing.Size(413, 121);
            this.kontaktTextBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kontaktTextBox.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.kontaktTextBox.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.kontaktTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kontaktTextBox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kontaktTextBox.StateCommon.Border.Rounding = 20;
            this.kontaktTextBox.StateCommon.Border.Width = 1;
            this.kontaktTextBox.TabIndex = 8;
            // 
            // historiePanel
            // 
            this.historiePanel.Controls.Add(this.label26);
            this.historiePanel.Controls.Add(this.zaznamyTextBox);
            this.historiePanel.Controls.Add(this.label32);
            this.historiePanel.Controls.Add(this.label33);
            this.historiePanel.Controls.Add(this.poznamkySTKTextBox);
            this.historiePanel.Controls.Add(this.vlastnictviTextBox);
            this.historiePanel.Location = new System.Drawing.Point(1153, 106);
            this.historiePanel.Name = "historiePanel";
            this.historiePanel.Size = new System.Drawing.Size(786, 432);
            this.historiePanel.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.historiePanel.StateCommon.Color2 = System.Drawing.Color.Gray;
            this.historiePanel.StateCommon.ColorAngle = 45F;
            this.historiePanel.TabIndex = 14;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.label26.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label26.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label26.Location = new System.Drawing.Point(17, 22);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(187, 36);
            this.label26.TabIndex = 0;
            this.label26.Text = "Záznamy o STK:";
            // 
            // zaznamyTextBox
            // 
            this.zaznamyTextBox.Location = new System.Drawing.Point(324, 22);
            this.zaznamyTextBox.Multiline = true;
            this.zaznamyTextBox.Name = "zaznamyTextBox";
            this.zaznamyTextBox.Size = new System.Drawing.Size(436, 122);
            this.zaznamyTextBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.zaznamyTextBox.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.zaznamyTextBox.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.zaznamyTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.zaznamyTextBox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.zaznamyTextBox.StateCommon.Border.Rounding = 20;
            this.zaznamyTextBox.StateCommon.Border.Width = 1;
            this.zaznamyTextBox.TabIndex = 7;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.label32.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label32.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label32.Location = new System.Drawing.Point(17, 172);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(257, 36);
            this.label32.TabIndex = 1;
            this.label32.Text = "Poznámky k absl. STK:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.label33.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label33.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label33.Location = new System.Drawing.Point(17, 316);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(247, 36);
            this.label33.TabIndex = 2;
            this.label33.Text = "Změny ve vlastnictví:";
            // 
            // poznamkySTKTextBox
            // 
            this.poznamkySTKTextBox.Location = new System.Drawing.Point(324, 165);
            this.poznamkySTKTextBox.Multiline = true;
            this.poznamkySTKTextBox.Name = "poznamkySTKTextBox";
            this.poznamkySTKTextBox.Size = new System.Drawing.Size(436, 128);
            this.poznamkySTKTextBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.poznamkySTKTextBox.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.poznamkySTKTextBox.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.poznamkySTKTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.poznamkySTKTextBox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.poznamkySTKTextBox.StateCommon.Border.Rounding = 20;
            this.poznamkySTKTextBox.StateCommon.Border.Width = 1;
            this.poznamkySTKTextBox.TabIndex = 8;
            // 
            // vlastnictviTextBox
            // 
            this.vlastnictviTextBox.Location = new System.Drawing.Point(324, 309);
            this.vlastnictviTextBox.Multiline = true;
            this.vlastnictviTextBox.Name = "vlastnictviTextBox";
            this.vlastnictviTextBox.Size = new System.Drawing.Size(436, 105);
            this.vlastnictviTextBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.vlastnictviTextBox.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.vlastnictviTextBox.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.vlastnictviTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.vlastnictviTextBox.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.vlastnictviTextBox.StateCommon.Border.Rounding = 20;
            this.vlastnictviTextBox.StateCommon.Border.Width = 1;
            this.vlastnictviTextBox.TabIndex = 8;
            // 
            // zakladni_infoPanel
            // 
            this.zakladni_infoPanel.Controls.Add(this.registraceDateTimePicker);
            this.zakladni_infoPanel.Controls.Add(this.barva_karoserietxt);
            this.zakladni_infoPanel.Controls.Add(this.label1);
            this.zakladni_infoPanel.Controls.Add(this.label4);
            this.zakladni_infoPanel.Controls.Add(this.label7);
            this.zakladni_infoPanel.Controls.Add(this.typ_variantatxt);
            this.zakladni_infoPanel.Controls.Add(this.vintxt);
            this.zakladni_infoPanel.Controls.Add(this.znacka_modeltxt);
            this.zakladni_infoPanel.Controls.Add(this.label5);
            this.zakladni_infoPanel.Controls.Add(this.label2);
            this.zakladni_infoPanel.Controls.Add(this.label3);
            this.zakladni_infoPanel.Controls.Add(this.label6);
            this.zakladni_infoPanel.Controls.Add(this.druh_vozidlatxt);
            this.zakladni_infoPanel.Controls.Add(this.spz_rztxt);
            this.zakladni_infoPanel.Location = new System.Drawing.Point(1188, 24);
            this.zakladni_infoPanel.Name = "zakladni_infoPanel";
            this.zakladni_infoPanel.Size = new System.Drawing.Size(786, 432);
            this.zakladni_infoPanel.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.zakladni_infoPanel.StateCommon.Color2 = System.Drawing.Color.Gray;
            this.zakladni_infoPanel.StateCommon.ColorAngle = 45F;
            this.zakladni_infoPanel.TabIndex = 10;
            // 
            // registraceDateTimePicker
            // 
            this.registraceDateTimePicker.Location = new System.Drawing.Point(324, 255);
            this.registraceDateTimePicker.Name = "registraceDateTimePicker";
            this.registraceDateTimePicker.Size = new System.Drawing.Size(436, 42);
            this.registraceDateTimePicker.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.registraceDateTimePicker.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.registraceDateTimePicker.StateCommon.Border.Color2 = System.Drawing.Color.Gray;
            this.registraceDateTimePicker.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.registraceDateTimePicker.StateCommon.Border.Rounding = 20;
            this.registraceDateTimePicker.StateCommon.Border.Width = 1;
            this.registraceDateTimePicker.TabIndex = 18;
            // 
            // barva_karoserietxt
            // 
            this.barva_karoserietxt.Location = new System.Drawing.Point(324, 375);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Značka a model: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(17, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "VIN: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.label7.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(17, 382);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 36);
            this.label7.TabIndex = 6;
            this.label7.Text = "Barva karoserie: ";
            // 
            // typ_variantatxt
            // 
            this.typ_variantatxt.Location = new System.Drawing.Point(324, 315);
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
            // vintxt
            // 
            this.vintxt.Location = new System.Drawing.Point(324, 195);
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
            // znacka_modeltxt
            // 
            this.znacka_modeltxt.Location = new System.Drawing.Point(324, 15);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.label5.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(17, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 36);
            this.label5.TabIndex = 4;
            this.label5.Text = "Datum první registrace: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(17, 82);
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
            this.label3.Location = new System.Drawing.Point(17, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "SPZ / RZ: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.label6.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(17, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 36);
            this.label6.TabIndex = 5;
            this.label6.Text = "Typ a varianta: ";
            // 
            // druh_vozidlatxt
            // 
            this.druh_vozidlatxt.Location = new System.Drawing.Point(324, 75);
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
            this.spz_rztxt.Location = new System.Drawing.Point(324, 135);
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
            // ulozitLabel
            // 
            this.ulozitLabel.Location = new System.Drawing.Point(756, 521);
            this.ulozitLabel.Name = "ulozitLabel";
            this.ulozitLabel.Size = new System.Drawing.Size(118, 29);
            this.ulozitLabel.TabIndex = 16;
            this.ulozitLabel.Values.Text = "Uložit změny";
            this.ulozitLabel.LinkClicked += new System.EventHandler(this.ulozitLabel_LinkClicked);
            // 
            // shrnutiTextBox
            // 
            this.shrnutiTextBox.Location = new System.Drawing.Point(433, 12);
            this.shrnutiTextBox.Name = "shrnutiTextBox";
            this.shrnutiTextBox.ReadOnly = true;
            this.shrnutiTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.shrnutiTextBox.Size = new System.Drawing.Size(773, 432);
            this.shrnutiTextBox.StateCommon.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.shrnutiTextBox.StateCommon.Border.Color1 = System.Drawing.Color.Gainsboro;
            this.shrnutiTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.shrnutiTextBox.StateCommon.Border.Rounding = 20;
            this.shrnutiTextBox.StateCommon.Border.Width = 1;
            this.shrnutiTextBox.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.shrnutiTextBox.TabIndex = 18;
            this.shrnutiTextBox.Text = "";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 90F;
            this.gradientPanel1.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.gradientPanel1.Color2 = System.Drawing.Color.DarkGreen;
            this.gradientPanel1.Controls.Add(this.logoutLabel);
            this.gradientPanel1.Controls.Add(this.nastaveniLabel);
            this.gradientPanel1.Controls.Add(this.nameLabel);
            this.gradientPanel1.Location = new System.Drawing.Point(-2, 581);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1220, 159);
            this.gradientPanel1.TabIndex = 15;
            // 
            // logoutLabel
            // 
            this.logoutLabel.Location = new System.Drawing.Point(1066, 60);
            this.logoutLabel.Name = "logoutLabel";
            this.logoutLabel.Size = new System.Drawing.Size(128, 33);
            this.logoutLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logoutLabel.TabIndex = 2;
            this.logoutLabel.Values.Text = "Odhlásit se";
            this.logoutLabel.LinkClicked += new System.EventHandler(this.logoutLabel_LinkClicked);
            // 
            // nastaveniLabel
            // 
            this.nastaveniLabel.Location = new System.Drawing.Point(931, 60);
            this.nastaveniLabel.Name = "nastaveniLabel";
            this.nastaveniLabel.Size = new System.Drawing.Size(116, 33);
            this.nastaveniLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nastaveniLabel.TabIndex = 1;
            this.nastaveniLabel.Values.Text = "Nastavení";
            this.nastaveniLabel.LinkClicked += new System.EventHandler(this.nastaveniLabel_LinkClicked);
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(33, 51);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(140, 57);
            this.nameLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Poppins", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Values.Text = "jmeno";
            // 
            // STKmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1218, 734);
            this.Controls.Add(this.shrnutiTextBox);
            this.Controls.Add(this.ulozitLabel);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.historiePanel);
            this.Controls.Add(this.majitelPanel);
            this.Controls.Add(this.stav_stkPanel);
            this.Controls.Add(this.technicke_udajePanel);
            this.Controls.Add(this.zakladni_infoPanel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.kryptonComboBox1);
            this.Controls.Add(this.odebratButton);
            this.Controls.Add(this.pridatButton);
            this.Controls.Add(this.kryptonTreeView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "STKmain";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STK údržba vozidel";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicke_udajePanel)).EndInit();
            this.technicke_udajePanel.ResumeLayout(false);
            this.technicke_udajePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stav_stkPanel)).EndInit();
            this.stav_stkPanel.ResumeLayout(false);
            this.stav_stkPanel.PerformLayout();
            this.vysledekEKPanel.ResumeLayout(false);
            this.vysledekEKPanel.PerformLayout();
            this.vysledekSTKPanel.ResumeLayout(false);
            this.vysledekSTKPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.majitelPanel)).EndInit();
            this.majitelPanel.ResumeLayout(false);
            this.majitelPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historiePanel)).EndInit();
            this.historiePanel.ResumeLayout(false);
            this.historiePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zakladni_infoPanel)).EndInit();
            this.zakladni_infoPanel.ResumeLayout(false);
            this.zakladni_infoPanel.PerformLayout();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonTreeView kryptonTreeView1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton pridatButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton odebratButton;
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
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox druh_vozidlatxt;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox znacka_modeltxt;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel zakladni_infoPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton backButton;
        private ComponentFactory.Krypton.Toolkit.KryptonButton nextButton;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel stav_stkPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox poznamkyTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox typSTKTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel technicke_udajePanel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox rozmeryTextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox mistaTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox pneuTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox hmotnostTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox vykonTextBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox palivoTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox pohonTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel majitelPanel;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox poznamky_vlastnikBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox vlastnikTextBox;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox provozovatelTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kontaktTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel historiePanel;
        private System.Windows.Forms.Label label26;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox zaznamyTextBox;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox poznamkySTKTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox vlastnictviTextBox;
        private GradientPanel gradientPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel nameLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel logoutLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel nastaveniLabel;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel ulozitLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker posledniSTKDateTimePicker;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker registraceDateTimePicker;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker platnostEKDateTimePicker;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker platnostSTKDateTimePicker;
        private System.Windows.Forms.Panel vysledekEKPanel;
        private System.Windows.Forms.Panel vysledekSTKPanel;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox shrnutiTextBox;
    }
}