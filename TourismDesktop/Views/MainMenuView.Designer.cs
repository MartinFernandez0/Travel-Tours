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
            btnAdmin = new FontAwesome.Sharp.IconButton();
            btnClient = new FontAwesome.Sharp.IconButton();
            btnDestination = new FontAwesome.Sharp.IconButton();
            btnItinerary = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            btnClose = new FontAwesome.Sharp.IconButton();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnModificar = new FontAwesome.Sharp.IconButton();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            sidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menubutton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(24, 24, 29);
            sidebar.BackgroundImageLayout = ImageLayout.Zoom;
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(btnHome);
            sidebar.Controls.Add(btnAdmin);
            sidebar.Controls.Add(btnClient);
            sidebar.Controls.Add(btnDestination);
            sidebar.Controls.Add(btnItinerary);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(btnClose);
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
            panel1.Size = new Size(237, 59);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Handwriting", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(67, 23);
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
            menubutton.Location = new Point(15, 16);
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
            btnHome.Location = new Point(8, 80);
            btnHome.Margin = new Padding(8, 15, 3, 3);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(7, 0, 0, 0);
            btnHome.Size = new Size(232, 34);
            btnHome.TabIndex = 4;
            btnHome.Text = "                       Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = false;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.DimGray;
            btnAdmin.FlatStyle = FlatStyle.Popup;
            btnAdmin.ForeColor = Color.Transparent;
            btnAdmin.IconChar = FontAwesome.Sharp.IconChar.Hotel;
            btnAdmin.IconColor = Color.White;
            btnAdmin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdmin.IconSize = 30;
            btnAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdmin.Location = new Point(8, 132);
            btnAdmin.Margin = new Padding(8, 15, 3, 3);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Padding = new Padding(7, 0, 0, 0);
            btnAdmin.Size = new Size(232, 34);
            btnAdmin.TabIndex = 6;
            btnAdmin.Text = "                       Administradores";
            btnAdmin.TextAlign = ContentAlignment.MiddleLeft;
            btnAdmin.UseVisualStyleBackColor = false;
            // 
            // btnClient
            // 
            btnClient.Anchor = AnchorStyles.Left;
            btnClient.BackColor = Color.DimGray;
            btnClient.BackgroundImageLayout = ImageLayout.None;
            btnClient.FlatStyle = FlatStyle.Popup;
            btnClient.ForeColor = Color.White;
            btnClient.IconChar = FontAwesome.Sharp.IconChar.Landmark;
            btnClient.IconColor = Color.White;
            btnClient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClient.IconSize = 30;
            btnClient.ImageAlign = ContentAlignment.MiddleLeft;
            btnClient.Location = new Point(8, 184);
            btnClient.Margin = new Padding(8, 15, 3, 3);
            btnClient.Name = "btnClient";
            btnClient.Padding = new Padding(7, 0, 0, 0);
            btnClient.Size = new Size(232, 34);
            btnClient.TabIndex = 7;
            btnClient.Text = "                       Clientes";
            btnClient.TextAlign = ContentAlignment.MiddleLeft;
            btnClient.UseVisualStyleBackColor = false;
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
            btnDestination.Location = new Point(8, 236);
            btnDestination.Margin = new Padding(8, 15, 3, 3);
            btnDestination.Name = "btnDestination";
            btnDestination.Padding = new Padding(7, 0, 0, 0);
            btnDestination.Size = new Size(232, 34);
            btnDestination.TabIndex = 5;
            btnDestination.Text = "                       Destinos";
            btnDestination.TextAlign = ContentAlignment.MiddleLeft;
            btnDestination.UseVisualStyleBackColor = false;
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
            btnItinerary.Location = new Point(8, 288);
            btnItinerary.Margin = new Padding(8, 15, 3, 3);
            btnItinerary.Name = "btnItinerary";
            btnItinerary.Padding = new Padding(7, 0, 0, 0);
            btnItinerary.Size = new Size(232, 34);
            btnItinerary.TabIndex = 8;
            btnItinerary.Text = "                       Itinerarios";
            btnItinerary.TextAlign = ContentAlignment.MiddleLeft;
            btnItinerary.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Cursor = Cursors.Hand;
            panel2.Location = new Point(3, 328);
            panel2.Name = "panel2";
            panel2.Size = new Size(237, 81);
            panel2.TabIndex = 28;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.ForeColor = Color.Transparent;
            btnClose.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            btnClose.IconColor = Color.White;
            btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClose.IconSize = 40;
            btnClose.Location = new Point(3, 415);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(61, 41);
            btnClose.TabIndex = 28;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
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
            btnEliminar.Location = new Point(673, 19);
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
            btnModificar.Location = new Point(526, 19);
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
            btnAgregar.Location = new Point(375, 20);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(127, 38);
            btnAgregar.TabIndex = 25;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(238, 184);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 211);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(457, 184);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(223, 211);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(680, 184);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(223, 211);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 30;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Handwriting", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(526, 143);
            label2.Name = "label2";
            label2.Size = new Size(92, 24);
            label2.TabIndex = 4;
            label2.Text = "Hoteles";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Handwriting", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(731, 142);
            label3.Name = "label3";
            label3.Size = new Size(105, 24);
            label3.TabIndex = 31;
            label3.Text = "Destinos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Handwriting", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(287, 142);
            label4.Name = "label4";
            label4.Size = new Size(145, 24);
            label4.TabIndex = 32;
            label4.Text = "Actividades";
            // 
            // MainMenuView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(900, 465);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(sidebar);
            Controls.Add(btnAgregar);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(900, 465);
            Name = "MainMenuView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pagina Principal";
            sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menubutton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel sidebar;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnDestination;
        private FontAwesome.Sharp.IconButton btnAdmin;
        private FontAwesome.Sharp.IconButton btnClient;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox menubutton;
        private System.Windows.Forms.Timer sidebarTimer;
        private FontAwesome.Sharp.IconButton btnItinerary;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton btnClose;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
