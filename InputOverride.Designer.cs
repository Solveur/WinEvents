namespace WinEvents
{
	partial class InputOverride
	{
		/// <summary> 
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором компонентов

		/// <summary> 
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			button_SelectInput = new Button();
			button_SelectAction = new Button();
			SuspendLayout();
			// 
			// button_SelectInput
			// 
			button_SelectInput.FlatStyle = FlatStyle.Flat;
			button_SelectInput.Location = new Point(3, 3);
			button_SelectInput.Margin = new Padding(3, 3, 0, 3);
			button_SelectInput.Name = "button_SelectInput";
			button_SelectInput.Size = new Size(175, 79);
			button_SelectInput.TabIndex = 0;
			button_SelectInput.Text = "button_SelectInput";
			button_SelectInput.UseVisualStyleBackColor = true;
			button_SelectInput.Click += button1_Click;
			// 
			// button_SelectAction
			// 
			button_SelectAction.FlatStyle = FlatStyle.Flat;
			button_SelectAction.Location = new Point(182, 3);
			button_SelectAction.Margin = new Padding(0, 3, 3, 3);
			button_SelectAction.Name = "button_SelectAction";
			button_SelectAction.Size = new Size(175, 79);
			button_SelectAction.TabIndex = 0;
			button_SelectAction.Text = "button_SelectAction";
			button_SelectAction.UseVisualStyleBackColor = true;
			button_SelectAction.Click += button2_Click;
			// 
			// InputOverride
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(button_SelectAction);
			Controls.Add(button_SelectInput);
			Margin = new Padding(0);
			Name = "InputOverride";
			Size = new Size(360, 85);
			ResumeLayout(false);
		}

		#endregion

		private Button button_SelectInput;
		private Button button_SelectAction;
	}
}
