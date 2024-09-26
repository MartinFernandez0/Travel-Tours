namespace TourismDesktop
{
    partial class MainMenuView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuView));
            sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            menubutton = new FontAwesome.Sharp.IconPictureBox();
            btnHome = new FontAwesome.Sharp.IconButton();
            btnHotels = new FontAwesome.Sharp.IconButton();
            btnDestination = new FontAwesome.Sharp.IconButton();
            btnActivity = new FontAwesome.Sharp.IconButton();
            btnItinerary = new FontAwesome.Sharp.IconButton();
            btnPaymentMethod = new FontAwesome.Sharp.IconButton();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            tabControl1 = new TabControl();
            TabPageHotels = new TabPage();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnModificar = new FontAwesome.Sharp.IconButton();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            dataGridHotels = new DataGridView();
            tabPageDestination = new TabPage();
            tabPageActivity = new TabPage();
            tabPageItinerary = new TabPage();
            tabPagePaymentMethod = new TabPage();
            TabPageHome = new TabPage();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            dataGridDestination = new DataGridView();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            iconButton6 = new FontAwesome.Sharp.IconButton();
            dataGridActivity = new DataGridView();
            iconButton7 = new FontAwesome.Sharp.IconButton();
            iconButton8 = new FontAwesome.Sharp.IconButton();
            iconButton9 = new FontAwesome.Sharp.IconButton();
            dataGridItinerary = new DataGridView();
            iconButton10 = new FontAwesome.Sharp.IconButton();
            iconButton11 = new FontAwesome.Sharp.IconButton();
            iconButton12 = new FontAwesome.Sharp.IconButton();
            dataGridPaymentMethod = new DataGridView();
            sidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menubutton).BeginInit();
            tabControl1.SuspendLayout();
            TabPageHotels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridHotels).BeginInit();
            tabPageDestination.SuspendLayout();
            tabPageActivity.SuspendLayout();
            tabPageItinerary.SuspendLayout();
            tabPagePaymentMethod.SuspendLayout();
            TabPageHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridDestination).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridActivity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridItinerary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridPaymentMethod).BeginInit();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(24, 24, 29);
            sidebar.BackgroundImageLayout = ImageLayout.Zoom;
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(btnHome);
            sidebar.Controls.Add(btnHotels);
            sidebar.Controls.Add(btnDestination);
            sidebar.Controls.Add(btnActivity);
            sidebar.Controls.Add(btnItinerary);
            sidebar.Controls.Add(btnPaymentMethod);
            sidebar.Dock = DockStyle.Left;
            sidebar.FlowDirection = FlowDirection.TopDown;
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(240, 465);
            sidebar.MinimumSize = new Size(64, 465);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(240, 465);
            sidebar.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(menubutton);
            panel1.Cursor = Cursors.Hand;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(237, 87);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Handwriting", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(62, 28);
            label1.Name = "label1";
            label1.Size = new Size(155, 20);
            label1.TabIndex = 3;
            label1.Text = "Menu Principal";
            // 
            // menubutton
            // 
            menubutton.BackColor = Color.FromArgb(24, 24, 29);
            menubutton.BackgroundImageLayout = ImageLayout.Stretch;
            menubutton.ForeColor = SystemColors.ControlLightLight;
            menubutton.IconChar = FontAwesome.Sharp.IconChar.Equals;
            menubutton.IconColor = SystemColors.ControlLightLight;
            menubutton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menubutton.IconSize = 37;
            menubutton.Location = new Point(16, 20);
            menubutton.Name = "menubutton";
            menubutton.Size = new Size(40, 37);
            menubutton.TabIndex = 3;
            menubutton.TabStop = false;
            menubutton.Click += menubutton_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.DimGray;
            btnHome.Cursor = Cursors.Hand;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Popup;
            btnHome.ForeColor = Color.Transparent;
            btnHome.IconChar = FontAwesome.Sharp.IconChar.House;
            btnHome.IconColor = Color.White;
            btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHome.IconSize = 30;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(8, 108);
            btnHome.Margin = new Padding(8, 15, 3, 3);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(7, 0, 0, 0);
            btnHome.Size = new Size(232, 39);
            btnHome.TabIndex = 4;
            btnHome.Text = "                       Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnHotels
            // 
            btnHotels.BackColor = Color.DimGray;
            btnHotels.FlatStyle = FlatStyle.Popup;
            btnHotels.ForeColor = Color.Transparent;
            btnHotels.IconChar = FontAwesome.Sharp.IconChar.Hotel;
            btnHotels.IconColor = Color.White;
            btnHotels.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHotels.IconSize = 30;
            btnHotels.ImageAlign = ContentAlignment.MiddleLeft;
            btnHotels.Location = new Point(8, 165);
            btnHotels.Margin = new Padding(8, 15, 3, 3);
            btnHotels.Name = "btnHotels";
            btnHotels.Padding = new Padding(7, 0, 0, 0);
            btnHotels.Size = new Size(232, 39);
            btnHotels.TabIndex = 6;
            btnHotels.Text = "                       Hoteles";
            btnHotels.TextAlign = ContentAlignment.MiddleLeft;
            btnHotels.UseVisualStyleBackColor = false;
            btnHotels.Click += btnHotels_Click;
            // 
            // btnDestination
            // 
            btnDestination.BackColor = Color.DimGray;
            btnDestination.FlatStyle = FlatStyle.Popup;
            btnDestination.ForeColor = Color.Transparent;
            btnDestination.IconChar = FontAwesome.Sharp.IconChar.Plane;
            btnDestination.IconColor = Color.White;
            btnDestination.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDestination.IconSize = 30;
            btnDestination.ImageAlign = ContentAlignment.MiddleLeft;
            btnDestination.Location = new Point(8, 222);
            btnDestination.Margin = new Padding(8, 15, 3, 3);
            btnDestination.Name = "btnDestination";
            btnDestination.Padding = new Padding(7, 0, 0, 0);
            btnDestination.Size = new Size(232, 39);
            btnDestination.TabIndex = 5;
            btnDestination.Text = "                       Destinos";
            btnDestination.TextAlign = ContentAlignment.MiddleLeft;
            btnDestination.UseVisualStyleBackColor = false;
            // 
            // btnActivity
            // 
            btnActivity.Anchor = AnchorStyles.Left;
            btnActivity.BackColor = Color.DimGray;
            btnActivity.BackgroundImageLayout = ImageLayout.None;
            btnActivity.FlatStyle = FlatStyle.Popup;
            btnActivity.ForeColor = Color.White;
            btnActivity.IconChar = FontAwesome.Sharp.IconChar.Landmark;
            btnActivity.IconColor = Color.White;
            btnActivity.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnActivity.IconSize = 30;
            btnActivity.ImageAlign = ContentAlignment.MiddleLeft;
            btnActivity.Location = new Point(8, 279);
            btnActivity.Margin = new Padding(8, 15, 3, 3);
            btnActivity.Name = "btnActivity";
            btnActivity.Padding = new Padding(7, 0, 0, 0);
            btnActivity.Size = new Size(232, 39);
            btnActivity.TabIndex = 7;
            btnActivity.Text = "                       Actividades";
            btnActivity.TextAlign = ContentAlignment.MiddleLeft;
            btnActivity.UseVisualStyleBackColor = false;
            // 
            // btnItinerary
            // 
            btnItinerary.Anchor = AnchorStyles.Left;
            btnItinerary.BackColor = Color.DimGray;
            btnItinerary.BackgroundImageLayout = ImageLayout.None;
            btnItinerary.FlatStyle = FlatStyle.Popup;
            btnItinerary.ForeColor = Color.White;
            btnItinerary.IconChar = FontAwesome.Sharp.IconChar.Landmark;
            btnItinerary.IconColor = Color.White;
            btnItinerary.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnItinerary.IconSize = 30;
            btnItinerary.ImageAlign = ContentAlignment.MiddleLeft;
            btnItinerary.Location = new Point(8, 336);
            btnItinerary.Margin = new Padding(8, 15, 3, 3);
            btnItinerary.Name = "btnItinerary";
            btnItinerary.Padding = new Padding(7, 0, 0, 0);
            btnItinerary.Size = new Size(232, 39);
            btnItinerary.TabIndex = 8;
            btnItinerary.Text = "                       Itinerarios";
            btnItinerary.TextAlign = ContentAlignment.MiddleLeft;
            btnItinerary.UseVisualStyleBackColor = false;
            // 
            // btnPaymentMethod
            // 
            btnPaymentMethod.Anchor = AnchorStyles.Left;
            btnPaymentMethod.BackColor = Color.DimGray;
            btnPaymentMethod.BackgroundImageLayout = ImageLayout.None;
            btnPaymentMethod.FlatStyle = FlatStyle.Popup;
            btnPaymentMethod.ForeColor = Color.White;
            btnPaymentMethod.IconChar = FontAwesome.Sharp.IconChar.Landmark;
            btnPaymentMethod.IconColor = Color.White;
            btnPaymentMethod.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPaymentMethod.IconSize = 30;
            btnPaymentMethod.ImageAlign = ContentAlignment.MiddleLeft;
            btnPaymentMethod.Location = new Point(8, 393);
            btnPaymentMethod.Margin = new Padding(8, 15, 3, 3);
            btnPaymentMethod.Name = "btnPaymentMethod";
            btnPaymentMethod.Padding = new Padding(7, 0, 0, 0);
            btnPaymentMethod.Size = new Size(232, 39);
            btnPaymentMethod.TabIndex = 9;
            btnPaymentMethod.Text = "                       Método de pago";
            btnPaymentMethod.TextAlign = ContentAlignment.MiddleLeft;
            btnPaymentMethod.UseVisualStyleBackColor = false;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TabPageHotels);
            tabControl1.Controls.Add(tabPageDestination);
            tabControl1.Controls.Add(tabPageActivity);
            tabControl1.Controls.Add(tabPageItinerary);
            tabControl1.Controls.Add(tabPagePaymentMethod);
            tabControl1.Controls.Add(TabPageHome);
            tabControl1.Location = new Point(0, -1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(846, 466);
            tabControl1.TabIndex = 3;
            tabControl1.Tag = "";
            // 
            // TabPageHotels
            // 
            TabPageHotels.Controls.Add(btnEliminar);
            TabPageHotels.Controls.Add(btnModificar);
            TabPageHotels.Controls.Add(btnAgregar);
            TabPageHotels.Controls.Add(dataGridHotels);
            TabPageHotels.Location = new Point(4, 24);
            TabPageHotels.Name = "TabPageHotels";
            TabPageHotels.Padding = new Padding(3);
            TabPageHotels.Size = new Size(838, 438);
            TabPageHotels.TabIndex = 1;
            TabPageHotels.Text = "2";
            TabPageHotels.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEliminar.ForeColor = SystemColors.ControlText;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 20;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(627, 199);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(127, 38);
            btnEliminar.TabIndex = 27;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnModificar.ForeColor = SystemColors.ControlText;
            btnModificar.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            btnModificar.IconColor = Color.Black;
            btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnModificar.IconSize = 20;
            btnModificar.ImageAlign = ContentAlignment.MiddleLeft;
            btnModificar.Location = new Point(480, 199);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(127, 38);
            btnModificar.TabIndex = 26;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregar.ForeColor = SystemColors.ControlText;
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            btnAgregar.IconColor = Color.Black;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.IconSize = 20;
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(329, 200);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(127, 38);
            btnAgregar.TabIndex = 25;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // dataGridHotels
            // 
            dataGridHotels.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridHotels.Location = new Point(274, 248);
            dataGridHotels.Name = "dataGridHotels";
            dataGridHotels.Size = new Size(523, 161);
            dataGridHotels.TabIndex = 0;
            // 
            // tabPageDestination
            // 
            tabPageDestination.Controls.Add(iconButton1);
            tabPageDestination.Controls.Add(iconButton2);
            tabPageDestination.Controls.Add(iconButton3);
            tabPageDestination.Controls.Add(dataGridDestination);
            tabPageDestination.Location = new Point(4, 24);
            tabPageDestination.Name = "tabPageDestination";
            tabPageDestination.Padding = new Padding(3);
            tabPageDestination.Size = new Size(838, 438);
            tabPageDestination.TabIndex = 2;
            tabPageDestination.Text = "3";
            tabPageDestination.UseVisualStyleBackColor = true;
            // 
            // tabPageActivity
            // 
            tabPageActivity.Controls.Add(iconButton4);
            tabPageActivity.Controls.Add(iconButton5);
            tabPageActivity.Controls.Add(iconButton6);
            tabPageActivity.Controls.Add(dataGridActivity);
            tabPageActivity.Location = new Point(4, 24);
            tabPageActivity.Name = "tabPageActivity";
            tabPageActivity.Padding = new Padding(3);
            tabPageActivity.Size = new Size(838, 438);
            tabPageActivity.TabIndex = 3;
            tabPageActivity.Text = "4";
            tabPageActivity.UseVisualStyleBackColor = true;
            // 
            // tabPageItinerary
            // 
            tabPageItinerary.Controls.Add(iconButton7);
            tabPageItinerary.Controls.Add(iconButton8);
            tabPageItinerary.Controls.Add(iconButton9);
            tabPageItinerary.Controls.Add(dataGridItinerary);
            tabPageItinerary.Location = new Point(4, 24);
            tabPageItinerary.Name = "tabPageItinerary";
            tabPageItinerary.Padding = new Padding(3);
            tabPageItinerary.Size = new Size(838, 438);
            tabPageItinerary.TabIndex = 4;
            tabPageItinerary.Text = "5";
            tabPageItinerary.UseVisualStyleBackColor = true;
            // 
            // tabPagePaymentMethod
            // 
            tabPagePaymentMethod.Controls.Add(iconButton10);
            tabPagePaymentMethod.Controls.Add(iconButton11);
            tabPagePaymentMethod.Controls.Add(iconButton12);
            tabPagePaymentMethod.Controls.Add(dataGridPaymentMethod);
            tabPagePaymentMethod.Location = new Point(4, 24);
            tabPagePaymentMethod.Name = "tabPagePaymentMethod";
            tabPagePaymentMethod.Padding = new Padding(3);
            tabPagePaymentMethod.Size = new Size(838, 438);
            tabPagePaymentMethod.TabIndex = 5;
            tabPagePaymentMethod.Text = "6";
            tabPagePaymentMethod.UseVisualStyleBackColor = true;
            // 
            // TabPageHome
            // 
            TabPageHome.Controls.Add(pictureBox1);
            TabPageHome.Controls.Add(pictureBox2);
            TabPageHome.Location = new Point(4, 24);
            TabPageHome.Name = "TabPageHome";
            TabPageHome.Padding = new Padding(3);
            TabPageHome.Size = new Size(838, 438);
            TabPageHome.TabIndex = 0;
            TabPageHome.Text = "1";
            TabPageHome.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-4, 162);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(839, 211);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(424, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(344, 123);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton1.ForeColor = SystemColors.ControlText;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Trash;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 20;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(626, 199);
            iconButton1.Margin = new Padding(3, 2, 3, 2);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(127, 38);
            iconButton1.TabIndex = 31;
            iconButton1.Text = "Eliminar";
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            iconButton2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton2.ForeColor = SystemColors.ControlText;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 20;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(479, 199);
            iconButton2.Margin = new Padding(3, 2, 3, 2);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(127, 38);
            iconButton2.TabIndex = 30;
            iconButton2.Text = "Modificar";
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            iconButton3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton3.ForeColor = SystemColors.ControlText;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 20;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(328, 200);
            iconButton3.Margin = new Padding(3, 2, 3, 2);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(127, 38);
            iconButton3.TabIndex = 29;
            iconButton3.Text = "Agregar";
            iconButton3.UseVisualStyleBackColor = true;
            // 
            // dataGridDestination
            // 
            dataGridDestination.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDestination.Location = new Point(274, 248);
            dataGridDestination.Name = "dataGridDestination";
            dataGridDestination.Size = new Size(523, 161);
            dataGridDestination.TabIndex = 28;
            // 
            // iconButton4
            // 
            iconButton4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton4.ForeColor = SystemColors.ControlText;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.Trash;
            iconButton4.IconColor = Color.Black;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 20;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(628, 199);
            iconButton4.Margin = new Padding(3, 2, 3, 2);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(127, 38);
            iconButton4.TabIndex = 35;
            iconButton4.Text = "Eliminar";
            iconButton4.UseVisualStyleBackColor = true;
            // 
            // iconButton5
            // 
            iconButton5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton5.ForeColor = SystemColors.ControlText;
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            iconButton5.IconColor = Color.Black;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.IconSize = 20;
            iconButton5.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton5.Location = new Point(481, 199);
            iconButton5.Margin = new Padding(3, 2, 3, 2);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(127, 38);
            iconButton5.TabIndex = 34;
            iconButton5.Text = "Modificar";
            iconButton5.UseVisualStyleBackColor = true;
            // 
            // iconButton6
            // 
            iconButton6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton6.ForeColor = SystemColors.ControlText;
            iconButton6.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            iconButton6.IconColor = Color.Black;
            iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton6.IconSize = 20;
            iconButton6.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton6.Location = new Point(330, 200);
            iconButton6.Margin = new Padding(3, 2, 3, 2);
            iconButton6.Name = "iconButton6";
            iconButton6.Size = new Size(127, 38);
            iconButton6.TabIndex = 33;
            iconButton6.Text = "Agregar";
            iconButton6.UseVisualStyleBackColor = true;
            // 
            // dataGridActivity
            // 
            dataGridActivity.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridActivity.Location = new Point(274, 248);
            dataGridActivity.Name = "dataGridActivity";
            dataGridActivity.Size = new Size(523, 161);
            dataGridActivity.TabIndex = 32;
            // 
            // iconButton7
            // 
            iconButton7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton7.ForeColor = SystemColors.ControlText;
            iconButton7.IconChar = FontAwesome.Sharp.IconChar.Trash;
            iconButton7.IconColor = Color.Black;
            iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton7.IconSize = 20;
            iconButton7.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton7.Location = new Point(628, 199);
            iconButton7.Margin = new Padding(3, 2, 3, 2);
            iconButton7.Name = "iconButton7";
            iconButton7.Size = new Size(127, 38);
            iconButton7.TabIndex = 35;
            iconButton7.Text = "Eliminar";
            iconButton7.UseVisualStyleBackColor = true;
            // 
            // iconButton8
            // 
            iconButton8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton8.ForeColor = SystemColors.ControlText;
            iconButton8.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            iconButton8.IconColor = Color.Black;
            iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton8.IconSize = 20;
            iconButton8.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton8.Location = new Point(481, 199);
            iconButton8.Margin = new Padding(3, 2, 3, 2);
            iconButton8.Name = "iconButton8";
            iconButton8.Size = new Size(127, 38);
            iconButton8.TabIndex = 34;
            iconButton8.Text = "Modificar";
            iconButton8.UseVisualStyleBackColor = true;
            // 
            // iconButton9
            // 
            iconButton9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton9.ForeColor = SystemColors.ControlText;
            iconButton9.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            iconButton9.IconColor = Color.Black;
            iconButton9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton9.IconSize = 20;
            iconButton9.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton9.Location = new Point(330, 200);
            iconButton9.Margin = new Padding(3, 2, 3, 2);
            iconButton9.Name = "iconButton9";
            iconButton9.Size = new Size(127, 38);
            iconButton9.TabIndex = 33;
            iconButton9.Text = "Agregar";
            iconButton9.UseVisualStyleBackColor = true;
            // 
            // dataGridItinerary
            // 
            dataGridItinerary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridItinerary.Location = new Point(274, 248);
            dataGridItinerary.Name = "dataGridItinerary";
            dataGridItinerary.Size = new Size(523, 161);
            dataGridItinerary.TabIndex = 32;
            // 
            // iconButton10
            // 
            iconButton10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton10.ForeColor = SystemColors.ControlText;
            iconButton10.IconChar = FontAwesome.Sharp.IconChar.Trash;
            iconButton10.IconColor = Color.Black;
            iconButton10.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton10.IconSize = 20;
            iconButton10.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton10.Location = new Point(629, 199);
            iconButton10.Margin = new Padding(3, 2, 3, 2);
            iconButton10.Name = "iconButton10";
            iconButton10.Size = new Size(127, 38);
            iconButton10.TabIndex = 35;
            iconButton10.Text = "Eliminar";
            iconButton10.UseVisualStyleBackColor = true;
            // 
            // iconButton11
            // 
            iconButton11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton11.ForeColor = SystemColors.ControlText;
            iconButton11.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            iconButton11.IconColor = Color.Black;
            iconButton11.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton11.IconSize = 20;
            iconButton11.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton11.Location = new Point(482, 199);
            iconButton11.Margin = new Padding(3, 2, 3, 2);
            iconButton11.Name = "iconButton11";
            iconButton11.Size = new Size(127, 38);
            iconButton11.TabIndex = 34;
            iconButton11.Text = "Modificar";
            iconButton11.UseVisualStyleBackColor = true;
            // 
            // iconButton12
            // 
            iconButton12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconButton12.ForeColor = SystemColors.ControlText;
            iconButton12.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            iconButton12.IconColor = Color.Black;
            iconButton12.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton12.IconSize = 20;
            iconButton12.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton12.Location = new Point(331, 200);
            iconButton12.Margin = new Padding(3, 2, 3, 2);
            iconButton12.Name = "iconButton12";
            iconButton12.Size = new Size(127, 38);
            iconButton12.TabIndex = 33;
            iconButton12.Text = "Agregar";
            iconButton12.UseVisualStyleBackColor = true;
            // 
            // dataGridPaymentMethod
            // 
            dataGridPaymentMethod.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPaymentMethod.Location = new Point(274, 248);
            dataGridPaymentMethod.Name = "dataGridPaymentMethod";
            dataGridPaymentMethod.Size = new Size(523, 161);
            dataGridPaymentMethod.TabIndex = 32;
            // 
            // MainMenuView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(845, 465);
            Controls.Add(sidebar);
            Controls.Add(tabControl1);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(845, 465);
            Name = "MainMenuView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pagina Principal";
            sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menubutton).EndInit();
            tabControl1.ResumeLayout(false);
            TabPageHotels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridHotels).EndInit();
            tabPageDestination.ResumeLayout(false);
            tabPageActivity.ResumeLayout(false);
            tabPageItinerary.ResumeLayout(false);
            tabPagePaymentMethod.ResumeLayout(false);
            TabPageHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridDestination).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridActivity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridItinerary).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridPaymentMethod).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel sidebar;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnDestination;
        private FontAwesome.Sharp.IconButton btnHotels;
        private FontAwesome.Sharp.IconButton btnActivity;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox menubutton;
        private System.Windows.Forms.Timer sidebarTimer;
        private TabControl tabControl1;
        private TabPage TabPageHome;
        private TabPage TabPageHotels;
        private FontAwesome.Sharp.IconButton btnItinerary;
        private FontAwesome.Sharp.IconButton btnPaymentMethod;
        private TabPage tabPageDestination;
        private TabPage tabPageActivity;
        private TabPage tabPageItinerary;
        private TabPage tabPagePaymentMethod;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private DataGridView dataGridHotels;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private DataGridView dataGridDestination;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton6;
        private DataGridView dataGridActivity;
        private FontAwesome.Sharp.IconButton iconButton7;
        private FontAwesome.Sharp.IconButton iconButton8;
        private FontAwesome.Sharp.IconButton iconButton9;
        private DataGridView dataGridItinerary;
        private FontAwesome.Sharp.IconButton iconButton10;
        private FontAwesome.Sharp.IconButton iconButton11;
        private FontAwesome.Sharp.IconButton iconButton12;
        private DataGridView dataGridPaymentMethod;
    }
}
