﻿namespace GDIProgramming
{
    partial class Painter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Painter));
            this.toolBar1 = new System.Windows.Forms.ToolBar();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.newButton = new System.Windows.Forms.ToolBarButton();
            this.lineButton = new System.Windows.Forms.ToolBarButton();
            this.squareButton = new System.Windows.Forms.ToolBarButton();
            this.circleButton = new System.Windows.Forms.ToolBarButton();
            this.dotLineButton = new System.Windows.Forms.ToolBarButton();
            this.line1Button = new System.Windows.Forms.ToolBarButton();
            this.line2Button = new System.Windows.Forms.ToolBarButton();
            this.line3Button = new System.Windows.Forms.ToolBarButton();
            this.SuspendLayout();
            // 
            // toolBar1
            // 
            this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.newButton,
            this.lineButton,
            this.squareButton,
            this.circleButton,
            this.dotLineButton,
            this.line1Button,
            this.line2Button,
            this.line3Button});
            this.toolBar1.ButtonSize = new System.Drawing.Size(30, 30);
            this.toolBar1.CausesValidation = false;
            this.toolBar1.DropDownArrows = true;
            this.toolBar1.ImageList = this.imageList1;
            this.toolBar1.Location = new System.Drawing.Point(0, 0);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.ShowToolTips = true;
            this.toolBar1.Size = new System.Drawing.Size(800, 28);
            this.toolBar1.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "newButton.png");
            this.imageList1.Images.SetKeyName(1, "lineButton.JPG");
            this.imageList1.Images.SetKeyName(2, "rectButton.JPG");
            this.imageList1.Images.SetKeyName(3, "circleButton.JPG");
            this.imageList1.Images.SetKeyName(4, "line0Button.jpg");
            this.imageList1.Images.SetKeyName(5, "line1Button.JPG");
            this.imageList1.Images.SetKeyName(6, "line2Button.JPG");
            this.imageList1.Images.SetKeyName(7, "line3Button.JPG");
            // 
            // newButton
            // 
            this.newButton.ImageIndex = 0;
            this.newButton.Name = "newButton";
            // 
            // lineButton
            // 
            this.lineButton.ImageIndex = 1;
            this.lineButton.Name = "lineButton";
            // 
            // squareButton
            // 
            this.squareButton.ImageIndex = 2;
            this.squareButton.Name = "squareButton";
            // 
            // circleButton
            // 
            this.circleButton.ImageIndex = 3;
            this.circleButton.Name = "circleButton";
            // 
            // dotLineButton
            // 
            this.dotLineButton.ImageIndex = 4;
            this.dotLineButton.Name = "dotLineButton";
            // 
            // line1Button
            // 
            this.line1Button.ImageIndex = 5;
            this.line1Button.Name = "line1Button";
            // 
            // line2Button
            // 
            this.line2Button.ImageIndex = 6;
            this.line2Button.Name = "line2Button";
            // 
            // line3Button
            // 
            this.line3Button.ImageIndex = 7;
            this.line3Button.Name = "line3Button";
            // 
            // Painter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolBar1);
            this.Name = "Painter";
            this.Text = "Painter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolBar toolBar1;
        private System.Windows.Forms.ToolBarButton newButton;
        private System.Windows.Forms.ToolBarButton lineButton;
        private System.Windows.Forms.ToolBarButton squareButton;
        private System.Windows.Forms.ToolBarButton circleButton;
        private System.Windows.Forms.ToolBarButton dotLineButton;
        private System.Windows.Forms.ToolBarButton line1Button;
        private System.Windows.Forms.ToolBarButton line2Button;
        private System.Windows.Forms.ToolBarButton line3Button;
        private System.Windows.Forms.ImageList imageList1;
    }
}