using CellWar.GameData;
using CellWar.Utils.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CellWar.Model.Substance.Strain;

namespace PetriDish.App.Forms
{
    public partial class RaceHelperForm : Form
    {
        public RaceHelperForm()
        {
            InitializeComponent();
        }
        RegulatoryGene curReg;
        List<RegulatoryGene> regGene = new List<RegulatoryGene>();
        private void RaceHelperForm_Load(Object sender, EventArgs e)
        {
            regGene = ObjectHelper.CloneList2( Local.AllRegulartoryGenes );

            clb_regs.DataSource = regGene;
            clb_regs.DisplayMember = "Name";

            lb_cods.DataSource = Local.AllCodingGenes;
            lb_cods.DisplayMember = "Name";
        }

        private void Clb_regs_SelectedIndexChanged(Object sender, EventArgs e)
        {
            curReg = clb_regs.SelectedItem as RegulatoryGene;
            freshCods();
        }

        private void Lb_cods_DoubleClick(Object sender, EventArgs e)
        {
            curReg.DominatedGenes.Add( lb_cods.SelectedItem as CodingGene );
            freshCods();
        }

        private void freshCods()
        {
            lb_cur_cods.DataSource = null;
            lb_cur_cods.DataSource = curReg.DominatedGenes;
            lb_cur_cods.DisplayMember = "Name";
        }

        private void Button1_Click(Object sender, EventArgs e)
        {
            string generated = "";
            for (int i = 0; i < clb_regs.Items.Count; i++)
            {
                if (clb_regs.GetItemChecked(i))
                {
                    var reg = clb_regs.Items[i] as RegulatoryGene;
                    generated += reg.Name + ";";
                    foreach (var cod in reg.DominatedGenes)
                    {
                        generated += cod.Name + ";";
                    }
                }
            }
            generated = generated.Remove( generated.Length -1 );
            gen_res.Text = generated;
            Clipboard.SetText( generated );
        }

        private void Button2_Click(Object sender, EventArgs e)
        {
            RaceHelperForm form = new RaceHelperForm();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
            this.Close();
        }
    }
}
