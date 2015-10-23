namespace BattleShipClient
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.battleShipGrid1 = new BattleShipGrid.BattleShipGrid();
            this.battleShipGrid2 = new BattleShipGrid.BattleShipGrid();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LB_State = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // battleShipGrid1
            // 
            this.battleShipGrid1.BorderOfSelection = System.Drawing.Color.Transparent;
            this.battleShipGrid1.Croiseur = null;
            this.battleShipGrid1.GridColor = System.Drawing.Color.Black;
            this.battleShipGrid1.InteriorOfSelection = System.Drawing.Color.Red;
            this.battleShipGrid1.Location = new System.Drawing.Point(12, 12);
            this.battleShipGrid1.Name = "battleShipGrid1";
            this.battleShipGrid1.PorteAvions = null;
            this.battleShipGrid1.Size = new System.Drawing.Size(150, 150);
            this.battleShipGrid1.SousMarin = null;
            this.battleShipGrid1.TabIndex = 0;
            this.battleShipGrid1.Torpilleur = null;
            // 
            // battleShipGrid2
            // 
            this.battleShipGrid2.BorderOfSelection = System.Drawing.Color.Transparent;
            this.battleShipGrid2.Croiseur = null;
            this.battleShipGrid2.GridColor = System.Drawing.Color.Black;
            this.battleShipGrid2.InteriorOfSelection = System.Drawing.Color.Red;
            this.battleShipGrid2.Location = new System.Drawing.Point(485, 12);
            this.battleShipGrid2.Name = "battleShipGrid2";
            this.battleShipGrid2.PorteAvions = null;
            this.battleShipGrid2.Size = new System.Drawing.Size(150, 150);
            this.battleShipGrid2.SousMarin = null;
            this.battleShipGrid2.TabIndex = 1;
            this.battleShipGrid2.Torpilleur = null;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LB_State
            // 
            this.LB_State.AutoSize = true;
            this.LB_State.Location = new System.Drawing.Point(253, 244);
            this.LB_State.Name = "LB_State";
            this.LB_State.Size = new System.Drawing.Size(35, 13);
            this.LB_State.TabIndex = 2;
            this.LB_State.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 462);
            this.Controls.Add(this.LB_State);
            this.Controls.Add(this.battleShipGrid2);
            this.Controls.Add(this.battleShipGrid1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BattleShipGrid.BattleShipGrid battleShipGrid1;
        private BattleShipGrid.BattleShipGrid battleShipGrid2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LB_State;

    }
}

