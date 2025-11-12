using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace opulencia_binary
{
    public partial class Form1 : Form
    {
        int[] arr;  
        System.Windows.Forms.Label[] labels;  
        int target, left, right, mid, step;

        private void btnStart_Click(object sender, EventArgs e)
        {
            panelArray.Controls.Clear();
            lblStatus.Text = "";
            lblResult.Text = "";

            try
            {
                { 
                    arr = txtArray.Text
                            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(x => int.Parse(x.Trim()))
                            .OrderBy(x => x)
                            .ToArray();

                    if (!int.TryParse(txtTarget.Text, out target))
                    {
                        MessageBox.Show("Invalid target number.");
                        return;
                    }

                    CreateArrayVisuals();

                    left = 0;
                    right = arr.Length - 1;
                    step = 1;

                    lblStatus.Text = "Starting Binary Search...";
                    timerStep.Interval = 1000;
                    timerStep.Start();
                }

            }

            catch
            {
                MessageBox.Show("Invalid array format! Use commas, e.g. 2,4,6,8,10");
            }
        }

        private void timerStep_Tick(object sender, EventArgs e)
        {
            if (left <= right)
            {
                mid = (left + right) / 2;

                // Reset lahat ng labels sa white
                foreach (var label in labels)
                    label.BackColor = Color.White;

                // Highlight current middle
                labels[mid].BackColor = Color.Yellow;

                lblStatus.Text = $"Step {step}: Left={left}, Right={right}, Mid={mid} (Value={arr[mid]})";

                if (arr[mid] == target)
                {
                    labels[mid].BackColor = Color.LightGreen;
                    lblStatus.Text = $"✅ Found {target} at index {mid}";
                    lblResult.Text = $"Result: {target} found at index {mid}";
                    timerStep.Stop();
                }
                else if (arr[mid] < target)
                {
                    // Eliminate left side → red
                    for (int i = left; i <= mid; i++)
                        labels[i].BackColor = Color.LightCoral;
                    left = mid + 1;
                }
                else
                {
                    // Eliminate right side → red
                    for (int i = mid; i <= right; i++)
                        labels[i].BackColor = Color.LightCoral;
                    right = mid - 1;
                }

                step++;
            }
            else
            {
                lblStatus.Text = "❌ Target not found.";
                lblResult.Text = "Result: Target not found.";
                timerStep.Stop();
            }
        }

        public Form1()
        {
            InitializeComponent();
            CreateArrayVisuals();
        }

        void CreateArrayVisuals()
        {

            if (arr == null || arr.Length == 0)
                return; // safeguard

            panelArray.Controls.Clear();
            labels = new System.Windows.Forms.Label[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                labels[i] = new System.Windows.Forms.Label();
                labels[i].Text = arr[i].ToString();
                labels[i].Width = 45;
                labels[i].Height = 45;
                labels[i].TextAlign = ContentAlignment.MiddleCenter;
                labels[i].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                labels[i].BackColor = Color.White;
                labels[i].Font = new Font("Arial", 10, FontStyle.Bold);
                panelArray.Controls.Add(labels[i]);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
