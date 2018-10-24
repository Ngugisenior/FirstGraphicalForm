using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace FirstGraphicalForm
{
	class MyForm : Form
	{

		public MyForm()
		{
			Initialize();
		}

		private void Initialize()
		{
			// Form to the center of the Screen
			this.CenterToScreen();
			// This will be the title of the form
			this.Text = "Test";
			// This will be the back color
			this.BackColor = Color.Blue;


			// Create the button object
			this.myButton = new Button();
			// The text of the button
			this.myButton.Text = "Click me";
			// Give the location of the button
			this.myButton.Location = new Point(100, 100);
			// The back color of the button.
			this.myButton.BackColor = Color.Coral;


			// Register Click event to the button
			this.myButton.Click += new EventHandler(this.myButton_Click);



			// Create Label object
			this.myLabel = new Label();
			// Set the location
			this.myLabel.Location = new Point(100, 150);
			// Set the color of letters
			myLabel.ForeColor = Color.White;

			// Add the two component to the form.
			this.Controls.Add(myButton);
			this.Controls.Add(myLabel);
		}

		// Declare variables:
		private Button myButton;
		private Label myLabel;

		// The handler of the click event of the myButton button
		private void myButton_Click(object sender, EventArgs e)
		{
			myLabel.Text = "Go on!";
		}
	}
}


