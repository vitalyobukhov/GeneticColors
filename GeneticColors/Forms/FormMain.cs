using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using GeneticColors.Classes;

namespace GeneticColors.Forms
{
    public partial class frmMain : Form
    {
        #region fields
        private bool _closeFlag;
        private GeneticAlgorithm _algorythm;
        #endregion

        #region methods
        private GeneticSettings MapSettingsFromForm()
        {
            var result = new GeneticSettings()
            {
                Size = Convert.ToInt32(this.nudSize.Value),
                Mutation = Convert.ToInt32(this.nudMutation.Value),
                MutabilityMin = Convert.ToInt32(this.nudMutabilityMin.Value),
                MutabilityMax = Convert.ToInt32(this.nudMutabilityMax.Value),
                Elitism = Convert.ToInt32(this.nudElitism.Value),
                Iterations = Convert.ToInt32(this.nudIterations.Value),
                Age=Convert.ToInt32(this.nudAge.Value),
                Seed = Convert.ToInt32(this.nudSeed.Value),
                Comparsion = cbxComparsion.SelectedIndex,
                Target = new GeneticColor
                {
                    Red = btnTarget.BackColor.R,
                    Green = btnTarget.BackColor.G,
                    Blue = btnTarget.BackColor.B
                }
            };

            return result;
        }

        private void MapSettingsToForm(GeneticSettings settings)
        {
            this.nudSize.Value = settings.Size;
            this.nudMutation.Value = settings.Mutation;
            this.nudMutabilityMin.Value = settings.MutabilityMin;
            this.nudMutabilityMax.Value = settings.MutabilityMax;
            this.nudElitism.Value = settings.Elitism;
            this.nudIterations.Value = settings.Iterations;
            this.nudAge.Value = settings.Age;
            this.nudSeed.Value = settings.Seed;
            this.cbxComparsion.SelectedIndex = settings.Comparsion;
            this.btnTarget.BackColor = Color.FromArgb(byte.MaxValue,
                settings.Target.Red, settings.Target.Green, settings.Target.Blue);
            this.tbxValue.Text = string.Concat(settings.Target.Red, " ",
                settings.Target.Green, " ", settings.Target.Blue);
        }

        private void ToggleFromControls(bool enabled)
        {
            nudSize.Enabled = enabled;
            nudMutation.Enabled = enabled;
            nudMutabilityMin.Enabled = enabled;
            nudMutabilityMax.Enabled = enabled;
            nudElitism.Enabled = enabled;
            nudIterations.Enabled = enabled;
            nudAge.Enabled = enabled;
            nudSeed.Enabled = enabled;
            btnTarget.Enabled = enabled;
            pbProgress.Enabled = !enabled;
            btnSave.Enabled = enabled;
            btnLoad.Enabled = enabled;
            btnAnalysis.Text = !enabled ? "Stop" : "Start";
            btnAnalysis.Image = !enabled ? Properties.Resources.stop : Properties.Resources.chart_curve;
            pbProgress.Value = !enabled ? 0 : 100;
            btnExport.Enabled = enabled && dgvPopulations.Rows.Count > 0;
        }

        private Image GetEliteImage(GeneticPopulation population)
        {
            const int sizex = 45, sizey = 15;
            const int w = sizex - 1, h = sizey - 1;
            var bmp = new Bitmap(sizex, sizey);
            var g = Graphics.FromImage(bmp);
            var srcColor = population.Elite.Color;
            var color = Color.FromArgb(byte.MaxValue,
                srcColor.Red,
                srcColor.Green,
                srcColor.Blue);
            g.FillRectangle(new SolidBrush(color), 0, 0, w, h);
            g.DrawRectangle(Pens.Black, 0, 0, w, h);
            return bmp;
        }

        private Image GetPopulationImage(GeneticPopulation population)
        {
            const int size = 10;
            const int w = size - 1;
            var bmp = new Bitmap(size * population.Samples.Count, size);
            var g = Graphics.FromImage(bmp);
            for (int i = 0; i < population.Samples.Count; i++)
            {
                var color = Color.FromArgb(byte.MaxValue,
                    population.Samples[i].Color.Red,
                    population.Samples[i].Color.Green,
                    population.Samples[i].Color.Blue);
                g.FillRectangle(new SolidBrush(color), i * size, 0, size, w);
                g.DrawRectangle(Pens.Black, i * size, 0, size, w);
            }
            g.DrawLine(Pens.Black, population.Samples.Count * size - 1, 0, population.Samples.Count * size - 1, size);
            return bmp;
        }

        private bool? SavePopulationsImagesToFile(string path)
        {
            bool? result = false;
            if (dgvPopulations.Rows.Count > 0)
            {
                Bitmap outputBmp=null;
                try
                {
                    var firstBmp = (Bitmap) dgvPopulations.Rows[0].Cells["clmnPopulation"].Value;
                    var w = firstBmp.Width;
                    var firstBmpH = firstBmp.Height - 1;
                    var h = dgvPopulations.Rows.Count*firstBmpH + 1;
                    outputBmp = new Bitmap(w, h);
                    var g = Graphics.FromImage(outputBmp);

                    for (int i = 0; i < dgvPopulations.Rows.Count; i++)
                    {
                        var bmp = (Bitmap) dgvPopulations.Rows[i].Cells["clmnPopulation"].Value;
                        g.DrawImage(bmp, 0, i*firstBmpH);
                    }
                }
                catch
                {
                    result = null;
                }

                try
                {
                    outputBmp.Save(path, ImageFormat.Png);
                    result = true;
                }
                catch { }
            }
            return result;
        }

        private void AddPopulation(GeneticPopulation population)
        {
            dgvPopulations.Rows.Add
            (
                dgvPopulations.Rows.Count + 1,
                GetEliteImage(population),
                string.Concat(population.Elite.Color.Red, " ",
                    population.Elite.Color.Green, " ",
                    population.Elite.Color.Blue),
                population.Elite.DifferenceUnits,
                population.Elite.SimilarityPercents,
                GetPopulationImage(population)
            );
        }

        private void ShowResults(GeneticPopulation population)
        {
            var color = population.Elite.Color;
            btnEliteColor.BackColor = Color.FromArgb(byte.MaxValue,
                color.Red, color.Green, color.Blue);
            tbxEliteValue.Text = string.Concat(color.Red, " ",
                color.Green, " ", color.Blue);
            if (color.Red == btnTarget.BackColor.R &&
                color.Green == btnTarget.BackColor.G &&
                color.Blue == btnTarget.BackColor.B)
            {
                tbxResult.Text = @"SUCCESS";
            }
            else
            {
                tbxResult.Text = string.Format("{0} %",
                    population.Elite.SimilarityPercents);
            }
        }

        private void _algorythm_PopulationCalculated(byte progressPercents, GeneticPopulation population)
        {
            if (this.InvokeRequired)
                this.Invoke(new GeneticAlgorithm.PopulationDelegate(_algorythm_PopulationCalculated),
                    progressPercents, population);
            else
            {
                pbProgress.Value = progressPercents;
                AddPopulation(population);
            }
        }

        private void _algorythm_CalculationAborted(byte progressPercents, GeneticPopulation population)
        {
            if (this.InvokeRequired)
                this.Invoke(new GeneticAlgorithm.PopulationDelegate(_algorythm_CalculationAborted),
                    progressPercents, population);
            else
            {
                ShowResults(population);
                ToggleFromControls(true);
                if (_closeFlag)
                    this.Close();
            }
        }

        private void _algorythm_CalculationSucess(byte progressPercents, GeneticPopulation population)
        {
            if (this.InvokeRequired)
                this.Invoke(new GeneticAlgorithm.PopulationDelegate(_algorythm_CalculationSucess),
                    progressPercents, population);
            else
            {
                ShowResults(population);
                ToggleFromControls(true);
                if (_closeFlag)
                    this.Close();
            }
        }

        private void _algorythm_CalculationStarted()
        {
            if (this.InvokeRequired)
                this.Invoke(new GeneticAlgorithm.VoidDelegate(_algorythm_CalculationStarted));
            else
                dgvPopulations.Rows.Clear();
        }
        #endregion

        #region constructor
        public frmMain()
        {
            InitializeComponent();
        }
        #endregion

        #region handlers
        private void frmMain_Load(object sender, EventArgs e)
        {
            cbxComparsion.SelectedIndex = 0;
        }

        private void btnTarget_Click(object sender, EventArgs e)
        {
            clrdlgTarget.Color = btnTarget.BackColor;
            if (clrdlgTarget.ShowDialog() == DialogResult.OK)
            {
                var color = clrdlgTarget.Color;
                btnTarget.BackColor = color;
                tbxValue.Text = string.Concat(color.R, " ", color.G, " ", color.B);
            }
        }

        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            if (_algorythm == null || _algorythm.State == GeneticAlgorithm.States.Idle)
            {
                _algorythm = new GeneticAlgorithm(MapSettingsFromForm());
                _algorythm.CalculationStarted += _algorythm_CalculationStarted;
                _algorythm.CalculationSucess += _algorythm_CalculationSucess;
                _algorythm.CalculationAborted += _algorythm_CalculationAborted;
                _algorythm.PopulationCalculated += _algorythm_PopulationCalculated;
            }
            if (_algorythm.State == GeneticAlgorithm.States.Idle)
            {
                ToggleFromControls(false);
                _algorythm.Start();
            }
            else if (_algorythm.State == GeneticAlgorithm.States.Working)
            {
                //ToggleFromControls(true);
                _algorythm.Stop();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (sfdlgSave.ShowDialog(this) == DialogResult.OK)
            {
                var settings = MapSettingsFromForm();
                if (settings.Save(sfdlgSave.FileName))
                    this.ShowInformation("Settings was successfully saved.");
                else
                    this.ShowError("Program failed to save settings.");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (ofdlgLoad.ShowDialog(this) == DialogResult.OK)
            {
                var settings = GeneticSettings.Load(ofdlgLoad.FileName);
                if (settings != null)
                {
                    MapSettingsToForm(settings);
                    this.ShowInformation("Settings was successfully loaded.");
                }
                else
                    this.ShowError("Program failed to load settings.");
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_algorythm != null && _algorythm.State != GeneticAlgorithm.States.Idle)
            {
                btnAnalysis_Click(sender, EventArgs.Empty);
                e.Cancel = true;
                _closeFlag = true;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (sfdlgExport.ShowDialog(this) == DialogResult.OK)
            {
                var result = SavePopulationsImagesToFile(sfdlgExport.FileName);
                if (result==null)
                    this.ShowError("Program failed to prepare image with requested size. Not enought memory.");
                else if (result==false)
                    this.ShowError("Program failed to save image.");
                else
                    this.ShowInformation("Image was successfully saved."); 
            }
        }

        private void nudMutabilityMin_ValueChanged(object sender, EventArgs e)
        {
            if (nudMutabilityMin.Value > nudMutabilityMax.Value)
                nudMutabilityMax.Value = nudMutabilityMin.Value;
        }

        private void nudMutabilityMax_ValueChanged(object sender, EventArgs e)
        {
            if (nudMutabilityMax.Value < nudMutabilityMin.Value)
                nudMutabilityMin.Value = nudMutabilityMax.Value;
        }

        private void nudIterations_ValueChanged(object sender, EventArgs e)
        {
            if (nudAge.Value > nudIterations.Value)
                nudAge.Value = nudIterations.Value;
        }

        private void nudAge_ValueChanged(object sender, EventArgs e)
        {
            if (nudAge.Value > nudIterations.Value)
                nudIterations.Value = nudAge.Value;
        }
        #endregion
    }
}
