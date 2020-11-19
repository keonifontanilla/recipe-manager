using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace recipe_manager.Controls
{
    /// <summary>
    /// This class is a user control for the top bar of all open forms. It displays the name of the current folder
    /// and it exits the form or application.
    /// </summary>
    public partial class TopBar : UserControl
    {
        private Point lastLocation;
        private bool mouseDown;

        public TopBar()
        {
            InitializeComponent();

            this.Dock = DockStyle.Fill;
        }

        /// <summary>
        /// For dragging and moving the form. Stores the location of the mouse pointer on the topBar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TopBar_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        /// <summary>
        /// For dragging and moving the form. Sends the location of the form up to the parent and sets the new location
        /// when the mouse pointer is being moved.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Parent.Parent.Location = new Point((Parent.Parent.Location.X - lastLocation.X) + e.X, (Parent.Parent.Location.Y - lastLocation.Y) + e.Y);

                Parent.Update();
            }
        }

        /// <summary>
        /// For dragging and moving the form. When the mouse is no longer clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TopBar_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            var parentForm = Parent.Parent as Form;

            parentForm.Close();
        }
    }
}
