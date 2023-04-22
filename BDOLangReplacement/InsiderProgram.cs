using BDOLangReplacement.Localizations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDOLangReplacement
{
    public partial class InsiderProgram : Form
    {
        private Localization myLoc = null;
        public InsiderProgram(Localization loc)
        {
            InitializeComponent();
            myLoc = loc;
            LocalizeComponents();
        }

        private void LocalizeComponents()
        {
            Text = myLoc.localize(Localization.FormComponent.InsiderProgramFormTitle);
            insiderTitle.Text = myLoc.localize(Localization.FormComponent.InsiderProgramTitle);
            descriptionLabel.Text = myLoc.localize(Localization.FormComponent.InsiderProgramDescription);
            details.Text = myLoc.localize(Localization.FormComponent.InsiderProgramDetails);
            linkLabel1.Text = myLoc.localize(Localization.FormComponent.InsiderProgramLink);
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/kroulis/BDOLanguageReplacementTool/tree/beta");
        }
    }
}
