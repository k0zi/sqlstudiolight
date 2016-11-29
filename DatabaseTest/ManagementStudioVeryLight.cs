using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using DatabaseLib;

namespace DatabaseTest
{
    public partial class ManagementStudioVeryLight : Form
    {
        private SQLEngine engine;
        private Color defaultFore;
        private ScriptFiles files;
        private List<FileInfo> scripts;
        public ManagementStudioVeryLight(Credentials c)
        {
            InitializeComponent();
            engine = new SQLEngine(c);
            defaultFore = txtMessages.ForeColor;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            txtMessages.Text = "";
            txtResult.Text = "";
            dgvResultGrid.Rows.Clear();
            dgvResultGrid.Columns.Clear();
            try
            {
                Recordset rs = engine.Run(txtQuery.Text);
                if(rs.Records.Count > 0)
                {
                    Record r = rs.Records.First<Record>();
                    for(int i = 0; i < r.Fields.Count; i++)
                    {
                        dgvResultGrid.Columns.Add("col" + i, rs.GetName(i));
                        txtResult.Text += rs.GetName(i);
                        txtResult.Text += "	";
                    }
                    txtResult.Text += Environment.NewLine;
                }
                foreach(Record r in rs.Records)
                {
                    string row = "";
                    foreach(var field in r.Fields)
                    {
                        row += field.ToString();
                        row += "	";
                    }
                    dgvResultGrid.Rows.Add(row.Split(new char[] { '	' }));
                    row += Environment.NewLine;

                    txtResult.Text += row;
                }
            }
            catch(SqlException ex)
            {
                txtMessages.Text = ex.Message;
                txtMessages.ForeColor = Color.Red;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (txtMessages.Text != "")
                {
                    txtMessages.Text = "Completed successfully!";
                    txtMessages.ForeColor = defaultFore;
                }

            }
            tcQuery.SelectedIndex = 1;
        }

        private void btnGetPath_Click(object sender, EventArgs e)
        {
            if (fbdScriptPath.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtPath.Text = fbdScriptPath.SelectedPath;
                
                files = new ScriptFiles(txtPath.Text);
                (clbExtensions as ListBox).DataSource = files.Extensions;
                (clbExtensions as ListBox).DisplayMember = "Name";
                (clbExtensions as ListBox).ValueMember = "IsChecked";
                gbExtension.Enabled = true;
            }
            else if(string.IsNullOrEmpty(txtPath.Text))
            {
                gbExtension.Enabled = false;
            }
        }

        private void btnRunScript_Click(object sender, EventArgs e)
        {
            scripts = new List<FileInfo>();
            foreach (var item in clbExtensions.CheckedItems)
            {
                scripts.AddRange(files.GetFilesWithExtension((item as ExtensionView).Name));
            }
            foreach (var s in scripts)
            {
                txtResult.Text += Environment.NewLine;
                try
                {
                    engine.RunAffectedRows(files.GetScript(s));
                    txtScriptResult.Text += "\nOK! " + s.Name + Environment.NewLine;
                }
                catch (SqlException ex)
                {
                    txtScriptResult.Text += "\nFAILED! : " + s.Name + " : " + ex.Message + Environment.NewLine;
                }
            }
        }

        private void clbExtensions_SelectedValueChanged(object sender, EventArgs e)
        {
            if (clbExtensions.CheckedItems.Count > 0)
            {
                gbResult.Enabled = true;
            }
            else
            {
                gbResult.Enabled = false;
            }
        }
    }
}
