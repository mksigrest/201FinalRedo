namespace igme201FinalRedo
{
    partial class Form1
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
            button0 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button7 = new Button();
            button6 = new Button();
            button8 = new Button();
            button10 = new Button();
            button9 = new Button();
            curOrder = new ListBox();
            prevOrder = new ListBox();
            checkButton = new Button();
            prevButton = new Button();
            priceLabel = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            button11 = new Button();
            SuspendLayout();
            // 
            // button0
            // 
            button0.Location = new Point(50, 175);
            button0.Name = "button0";
            button0.Size = new Size(175, 175);
            button0.TabIndex = 0;
            button0.Text = "Burger";
            button0.UseVisualStyleBackColor = true;
            button0.Click += label1_Click;
            button0.Tag = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(260, 51);
            label1.Name = "label1";
            label1.Size = new Size(480, 38);
            label1.TabIndex = 1;
            label1.Text = "Ritchies Fast Food Ordering System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(50, 125);
            label2.Name = "label2";
            label2.Size = new Size(92, 32);
            label2.TabIndex = 2;
            label2.Text = "Entrees";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(275, 125);
            label3.Name = "label3";
            label3.Size = new Size(70, 32);
            label3.TabIndex = 3;
            label3.Text = "Sides";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(500, 125);
            label4.Name = "label4";
            label4.Size = new Size(81, 32);
            label4.TabIndex = 4;
            label4.Text = "Drinks";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(725, 125);
            label5.Name = "label5";
            label5.Size = new Size(103, 32);
            label5.TabIndex = 5;
            label5.Text = "Desserts";
            // 
            // button1
            // 
            button1.Location = new Point(50, 400);
            button1.Name = "button1";
            button1.Size = new Size(175, 175);
            button1.TabIndex = 6;
            button1.Text = "Pizza";
            button1.UseVisualStyleBackColor = true;
            button1.Click += label1_Click;
            button1.Tag = 1;
            // 
            // button2
            // 
            button2.Location = new Point(50, 625);
            button2.Name = "button2";
            button2.Size = new Size(175, 175);
            button2.TabIndex = 7;
            button2.Text = "Salad";
            button2.UseVisualStyleBackColor = true;
            button2.Click += label1_Click;
            button2.Tag = 2;
            // 
            // button3
            // 
            button3.Location = new Point(275, 175);
            button3.Name = "button3";
            button3.Size = new Size(175, 175);
            button3.TabIndex = 8;
            button3.Text = "Fries";
            button3.UseVisualStyleBackColor = true;
            button3.Click += label1_Click;
            button3.Tag = 3;
            // 
            // button4
            // 
            button4.Location = new Point(275, 400);
            button4.Name = "button4";
            button4.Size = new Size(175, 175);
            button4.TabIndex = 9;
            button4.Text = "Steamed Veggies";
            button4.UseVisualStyleBackColor = true;
            button4.Click += label1_Click;
            button4.Tag = 4;
            // 
            // button5
            // 
            button5.Location = new Point(275, 625);
            button5.Name = "button5";
            button5.Size = new Size(175, 175);
            button5.TabIndex = 10;
            button5.Text = "Apple Slices";
            button5.UseVisualStyleBackColor = true;
            button5.Click += label1_Click;
            button5.Tag = 5;
            // 
            // button7
            // 
            button7.Location = new Point(500, 400);
            button7.Name = "button7";
            button7.Size = new Size(175, 175);
            button7.TabIndex = 12;
            button7.Text = "Soda";
            button7.UseVisualStyleBackColor = true;
            button7.Click += label1_Click;
            button7.Tag = 7;
            // 
            // button6
            // 
            button6.Location = new Point(500, 175);
            button6.Name = "button6";
            button6.Size = new Size(175, 175);
            button6.TabIndex = 13;
            button6.Text = "Water";
            button6.UseVisualStyleBackColor = true;
            button6.Click += label1_Click;
            button6.Tag = 6;
            // 
            // button8
            // 
            button8.Location = new Point(500, 625);
            button8.Name = "button8";
            button8.Size = new Size(175, 175);
            button8.TabIndex = 14;
            button8.Text = "Coffee";
            button8.UseVisualStyleBackColor = true;
            button8.Click += label1_Click;
            button8.Tag = 8;
            // 
            // button10
            // 
            button10.Location = new Point(725, 400);
            button10.Name = "button10";
            button10.Size = new Size(175, 175);
            button10.TabIndex = 17;
            button10.Text = "Cookie";
            button10.UseVisualStyleBackColor = true;
            button10.Click += label1_Click;
            button10.Tag = 10;
            // 
            // button9
            // 
            button9.Location = new Point(725, 175);
            button9.Name = "button9";
            button9.Size = new Size(175, 175);
            button9.TabIndex = 15;
            button9.Text = "Ice Cream";
            button9.UseVisualStyleBackColor = true;
            button9.Click += label1_Click;
            button9.Tag = 9;
            // 
            // curOrder
            // 
            curOrder.FormattingEnabled = true;
            curOrder.ItemHeight = 25;
            curOrder.Location = new Point(50, 975);
            curOrder.Name = "curOrder";
            curOrder.Size = new Size(400, 129);
            curOrder.TabIndex = 18;
            curOrder.Click += curOrder_Click;
            // 
            // prevOrder
            // 
            prevOrder.FormattingEnabled = true;
            prevOrder.ItemHeight = 25;
            prevOrder.Location = new Point(500, 975);
            prevOrder.Name = "prevOrder";
            prevOrder.Size = new Size(400, 129);
            prevOrder.TabIndex = 19;
            // 
            // checkButton
            // 
            checkButton.Location = new Point(260, 1125);
            checkButton.Name = "checkButton";
            checkButton.Size = new Size(150, 50);
            checkButton.TabIndex = 20;
            checkButton.Text = "checkout";
            checkButton.UseVisualStyleBackColor = true;
            checkButton.Click += checkButton_Click;
            // 
            // prevButton
            // 
            prevButton.Location = new Point(525, 1125);
            prevButton.Name = "prevButton";
            prevButton.Size = new Size(150, 50);
            prevButton.TabIndex = 21;
            prevButton.Text = "Add Prev Order";
            prevButton.UseVisualStyleBackColor = true;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            priceLabel.Location = new Point(50, 905);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(84, 32);
            priceLabel.TabIndex = 22;
            priceLabel.Text = "Total: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(500, 900);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(500, 837);
            label6.Name = "label6";
            label6.Size = new Size(204, 32);
            label6.TabIndex = 24;
            label6.Text = "Input Username:";
            // 
            // button11
            // 
            button11.Location = new Point(750, 900);
            button11.Name = "button11";
            button11.Size = new Size(150, 31);
            button11.TabIndex = 25;
            button11.Text = "Sign In/Up";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(978, 1194);
            Controls.Add(button11);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(priceLabel);
            Controls.Add(prevButton);
            Controls.Add(checkButton);
            Controls.Add(prevOrder);
            Controls.Add(curOrder);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button0);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button0;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button7;
        private Button button6;
        private Button button8;
        private Button button10;
        private Button button9;
        private ListBox curOrder;
        private ListBox prevOrder;
        private Button checkButton;
        private Button prevButton;
        private Label priceLabel;
        private TextBox textBox1;
        private Label label6;
        private Button button11;
    }
}
