﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

using Kedrah;
using Kedrah.Constants;
using Kedrah.Modules;
using Kedrah.Objects;
using Kedrah.Util;

using Tibia;
using Tibia.Util;
using Tibia.Objects;
using Tibia.Constants;

namespace WindowsFormsApplication1
{
    public partial class mBot : Form
    {


        public mBot()
        {
            InitializeComponent();
        }


        private Tibia.Objects.Console console;
        Client c;
        Player p;
        private void mBot_Load(object sender, EventArgs e)
        {
            c = ClientChooser.ShowBox();
            if (c == null || !c.LoggedIn)
            {
                MessageBox.Show("Você deve ter pelo menos um cliente aberto e conectado.");
                Application.Exit();
            }
            else
            {
                p = c.GetPlayer();
                this.Text = "MBot - " + p.Name + " (" + p.WorldName + ")";
                c.Statusbar = "MBot: Injetado com sucesso.";
                console = new Tibia.Objects.Console(c);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabSelect.SelectTab(tabBasics);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabSelect.SelectTab(tabHeal);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabSelect.SelectTab(tabMana);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabSelect.SelectTab(tabTrainer);
        }

        private void btnEspiarCima_Click(object sender, EventArgs e)
        {
            c.Map.LevelSpyOn(1);
        }

        private void btnEspiarBaixo_Click(object sender, EventArgs e)
        {
            c.Map.LevelSpyOn(-1);
        }

        private void btnEspiarClear_Click(object sender, EventArgs e)
        {
            c.Map.LevelSpyOff();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void gbBasicf_Enter(object sender, EventArgs e)
        {

        }

        private void btnAndarCima_Click(object sender, EventArgs e)
        {
            p.Walk(Direction.Up);
        }

        private void btnVirarBaixo_Click(object sender, EventArgs e)
        {
            p.Turn(Direction.Down);
        }

        private void btnEnviarMenssagem_Click(object sender, EventArgs e)
        {
            c.Console.Say("exura");
        }

        private void btnComerCarne_Click(object sender, EventArgs e)
        {
            c.Inventory.UseItem(Items.Food.Ham.Id);
        }

        private void btnMudarOutfit_Click(object sender, EventArgs e)
        {
            p.OutfitType = OutfitType.WizardMale;
            
        }

        private void btnOutfitDeamon_Click(object sender, EventArgs e)
        {
            p.OutfitType = OutfitType.Demon;
           
        }

        private void chkLuzTotal_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLuzTotal.Checked == true)
            {
                c.Map.FullLightOn();
            }
            else {
                c.Map.FullLightOff();
            }
        }

        private void chkRaioX_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRaioX.Checked == true) {
                c.Map.NameSpyOn();
            }
            else
            {
                c.Map.NameSpyOff();
            }
        }

        private void chkEsconderArvores_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEsconderArvores.Checked == true)
            {
                c.Map.ReplaceTrees();
            }
        }
    }
}
