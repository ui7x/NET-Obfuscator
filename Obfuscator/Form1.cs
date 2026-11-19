using System;
using System.IO;
using System.Windows.Forms;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System.Collections.Generic;

namespace Obfuscator
{
    public partial class Form1 : Form
    {
        private string selectedFile = "";

        private HashSet<string> usedNames = new HashSet<string>();
        private int nameCounter = 0;

        public Form1()
        {
            InitializeComponent();

            btnBrowse.Click += btnBrowse_Click;
            btnBuild.Click += btnBuild_Click;
        }

        private string GenerateObfuscatedName()
        {
            string customName = txtPrefix.Text.Trim();

            if (string.IsNullOrEmpty(customName))
            {
                customName = "Obf";
            }

            nameCounter++;

            string name = customName + "_" + nameCounter;

            if (usedNames.Contains(name))
            {
                return GenerateObfuscatedName();
            }

            usedNames.Add(name);
            return name;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Select .NET Assembly";
                dialog.Filter = "Assembly Files (*.exe;*.dll)|*.exe;*.dll";
                dialog.Multiselect = false;

                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                selectedFile = dialog.FileName;
                txtTarget.Text = selectedFile;

                if (string.IsNullOrWhiteSpace(txtOutput.Text))
                {
                    txtOutput.Text = Path.GetFileNameWithoutExtension(selectedFile);
                }
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(selectedFile) || !File.Exists(selectedFile))
            {
                MessageBox.Show("Please select a valid assembly.");
                return false;
            }

            string name = txtOutput.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) ||
                name.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0 ||
                name.Contains("."))
            {
                MessageBox.Show("Enter a valid Assembly name without extension.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPrefix.Text))
            {
                MessageBox.Show("Please enter a name in 'CUSTOM OBFUSCATION NAME' box.");
                return false;
            }

            return true;
        }

        private void ObfuscateModule(ModuleDefMD module)
        {
            module.Assembly.Name = txtOutput.Text.Trim();
            module.Name = txtOutput.Text.Trim() + Path.GetExtension(selectedFile);

            foreach (var type in module.GetTypes())
            {
                if (type.IsGlobalModuleType) continue;

                ObfuscateType(type);
            }

            foreach (var resource in module.Resources)
            {
                if (resource is EmbeddedResource er)
                {
                    er.Name = GenerateObfuscatedName();
                }
            }
        }

        private void ObfuscateType(TypeDef type)
        {
            type.Name = GenerateObfuscatedName();
            type.Namespace = "";

            foreach (var gp in type.GenericParameters)
            {
                gp.Name = GenerateObfuscatedName();
            }

            foreach (var method in type.Methods)
            {
                if (method.IsConstructor || method.IsRuntimeSpecialName || method.IsSpecialName)
                    continue;

                method.Name = GenerateObfuscatedName();

                foreach (var gp in method.GenericParameters)
                {
                    gp.Name = GenerateObfuscatedName();
                }

                foreach (var param in method.ParamDefs)
                {
                    if (param.Sequence != 0)
                    {
                        param.Name = GenerateObfuscatedName();
                    }
                }
            }

            foreach (var field in type.Fields)
            {
                if (field.IsRuntimeSpecialName) continue;

                if (type.IsEnum && field.Name == "value__") continue;

                field.Name = GenerateObfuscatedName();
            }

            foreach (var prop in type.Properties)
            {
                if (prop.IsRuntimeSpecialName) continue;

                prop.Name = GenerateObfuscatedName();
            }

            foreach (var evt in type.Events)
            {
                if (evt.IsRuntimeSpecialName) continue;

                evt.Name = GenerateObfuscatedName();

                if (evt.AddMethod != null && !evt.AddMethod.IsSpecialName)
                    evt.AddMethod.Name = GenerateObfuscatedName();

                if (evt.RemoveMethod != null && !evt.RemoveMethod.IsSpecialName)
                    evt.RemoveMethod.Name = GenerateObfuscatedName();

                if (evt.InvokeMethod != null && !evt.InvokeMethod.IsSpecialName)
                    evt.InvokeMethod.Name = GenerateObfuscatedName();
            }
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            string tempFile = "";

            try
            {
                btnBuild.Enabled = false;

                usedNames.Clear();
                nameCounter = 0;

                string extension = Path.GetExtension(selectedFile);

                tempFile = Path.Combine(
                    Path.GetTempPath(),
                    Guid.NewGuid().ToString("N") + extension
                );

                using (ModuleDefMD module = ModuleDefMD.Load(selectedFile))
                {
                    if (module.Assembly == null)
                    {
                        throw new InvalidOperationException("The selected file is not a managed Assembly.");
                    }

                    ObfuscateModule(module);

                    foreach (var type in module.GetTypes())
                    {
                        foreach (var method in type.Methods)
                        {
                            if (method.HasBody)
                            {
                                method.Body.SimplifyBranches();
                                method.Body.OptimizeBranches();
                            }
                        }
                    }

                    module.Write(tempFile);
                }

                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.Title = "Save Obfuscated File";
                    dialog.Filter = extension.Equals(".dll", StringComparison.OrdinalIgnoreCase)
                        ? "DLL Files (*.dll)|*.dll"
                        : "EXE Files (*.exe)|*.exe";
                    dialog.FileName = txtOutput.Text.Trim() + extension;

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        File.Copy(tempFile, dialog.FileName, true);
                        MessageBox.Show(
                            "Build and Save completed successfully!",
                            "Obfuscator",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                    else
                    {
                        MessageBox.Show(
                            "Build successful, but save was canceled.",
                            "Obfuscator",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Build failed:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                try
                {
                    if (!string.IsNullOrEmpty(tempFile) && File.Exists(tempFile))
                    {
                        File.Delete(tempFile);
                    }
                }
                catch { }

                btnBuild.Enabled = true;
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
        }
    }
}