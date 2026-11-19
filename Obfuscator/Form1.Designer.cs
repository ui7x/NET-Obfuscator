namespace Obfuscator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Button btnBrowse;
        private Guna.UI2.WinForms.Guna2Button btnBuild;

        private Guna.UI2.WinForms.Guna2TextBox txtOutput;
        private Guna.UI2.WinForms.Guna2TextBox txtTarget;
        private Guna.UI2.WinForms.Guna2TextBox txtPrefix;

        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label subtitle;
        private System.Windows.Forms.Label targetLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label prefixLabel;
        private System.Windows.Forms.Label footer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.btnBuild = new Guna.UI2.WinForms.Guna2Button();
            this.txtOutput = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTarget = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPrefix = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnBrowse = new Guna.UI2.WinForms.Guna2Button();
            this.title = new System.Windows.Forms.Label();
            this.subtitle = new System.Windows.Forms.Label();
            this.targetLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.prefixLabel = new System.Windows.Forms.Label();
            this.footer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(418, 12);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(32, 28);
            this.guna2ControlBox2.TabIndex = 12;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 12;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(456, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(32, 28);
            this.guna2ControlBox1.TabIndex = 11;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // btnBuild
            // 
            this.btnBuild.BorderRadius = 8;
            this.btnBuild.FillColor = System.Drawing.Color.White;
            this.btnBuild.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBuild.ForeColor = System.Drawing.Color.Black;
            this.btnBuild.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btnBuild.Location = new System.Drawing.Point(25, 355);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(450, 45);
            this.btnBuild.TabIndex = 9;
            this.btnBuild.Text = "Build & Save";
            // 
            // txtOutput
            // 
            this.txtOutput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.txtOutput.BorderRadius = 7;
            this.txtOutput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOutput.DefaultText = "";
            this.txtOutput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtOutput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtOutput.ForeColor = System.Drawing.Color.White;
            this.txtOutput.Location = new System.Drawing.Point(25, 215);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.PlaceholderText = "Enter assembly name...";
            this.txtOutput.SelectedText = "";
            this.txtOutput.Size = new System.Drawing.Size(450, 38);
            this.txtOutput.TabIndex = 6;
            // 
            // txtTarget
            // 
            this.txtTarget.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.txtTarget.BorderRadius = 7;
            this.txtTarget.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTarget.DefaultText = "";
            this.txtTarget.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtTarget.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTarget.ForeColor = System.Drawing.Color.White;
            this.txtTarget.Location = new System.Drawing.Point(25, 125);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.PlaceholderText = "Select EXE file...";
            this.txtTarget.ReadOnly = true;
            this.txtTarget.SelectedText = "";
            this.txtTarget.Size = new System.Drawing.Size(335, 38);
            this.txtTarget.TabIndex = 3;
            // 
            // txtPrefix
            // 
            this.txtPrefix.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.txtPrefix.BorderRadius = 7;
            this.txtPrefix.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrefix.DefaultText = "";
            this.txtPrefix.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtPrefix.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrefix.ForeColor = System.Drawing.Color.White;
            this.txtPrefix.Location = new System.Drawing.Point(25, 295);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.PlaceholderText = "Enter name to obfuscate with...";
            this.txtPrefix.SelectedText = "";
            this.txtPrefix.Size = new System.Drawing.Size(450, 38);
            this.txtPrefix.TabIndex = 8;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BorderRadius = 7;
            this.btnBrowse.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnBrowse.Location = new System.Drawing.Point(370, 125);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(105, 38);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(22, 17);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(222, 30);
            this.title.TabIndex = 0;
            this.title.Text = " C# .NET Obfuscator";
            // 
            // subtitle
            // 
            this.subtitle.AutoSize = true;
            this.subtitle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.subtitle.ForeColor = System.Drawing.Color.Gray;
            this.subtitle.Location = new System.Drawing.Point(25, 48);
            this.subtitle.Name = "subtitle";
            this.subtitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.subtitle.Size = new System.Drawing.Size(92, 13);
            this.subtitle.TabIndex = 1;
            this.subtitle.Text = "NET PROTECTOR";
            // 
            // targetLabel
            // 
            this.targetLabel.AutoSize = true;
            this.targetLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.targetLabel.ForeColor = System.Drawing.Color.White;
            this.targetLabel.Location = new System.Drawing.Point(25, 100);
            this.targetLabel.Name = "targetLabel";
            this.targetLabel.Size = new System.Drawing.Size(76, 15);
            this.targetLabel.TabIndex = 2;
            this.targetLabel.Text = "TARGET FILE";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(25, 190);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(103, 15);
            this.outputLabel.TabIndex = 5;
            this.outputLabel.Text = "ASSEMBLY NAME";
            // 
            // prefixLabel
            // 
            this.prefixLabel.AutoSize = true;
            this.prefixLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.prefixLabel.ForeColor = System.Drawing.Color.White;
            this.prefixLabel.Location = new System.Drawing.Point(25, 270);
            this.prefixLabel.Name = "prefixLabel";
            this.prefixLabel.Size = new System.Drawing.Size(179, 15);
            this.prefixLabel.TabIndex = 7;
            this.prefixLabel.Text = "CUSTOM OBFUSCATION NAME";
            // 
            // footer
            // 
            this.footer.AutoSize = true;
            this.footer.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.footer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.footer.Location = new System.Drawing.Point(25, 415);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(149, 13);
            this.footer.TabIndex = 10;
            this.footer.Text = "OBFUSCATOR | VERSION 1.0";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.title);
            this.Controls.Add(this.subtitle);
            this.Controls.Add(this.targetLabel);
            this.Controls.Add(this.txtTarget);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.prefixLabel);
            this.Controls.Add(this.txtPrefix);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2ControlBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Obfuscator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}