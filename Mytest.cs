using Life;

using Life.Network;
using Life.UI;
using UnityEngine;



namespace MyTest
{
    public class Mytest : Plugin
    {
        public Mytest(IGameAPI aPI) : base(aPI)
        {
        }

        public override void OnPluginInit()
        {
           base.OnPluginInit();
            Debug.Log("MyMécanical est initialisé avec succès !");
        }

        public override void OnPlayerInput(Player player, KeyCode keyCode, bool onUI)
        {
            base.OnPlayerInput(player, keyCode, onUI);
            
            if(keyCode == KeyCode.F7)
            {
                player.Notify("MyMécanical", "Seulement les Employé on le droit le lancer se menu");

                UIPanel panel = new UIPanel("MyTest", UIPanel.PanelType.Tab);
                UIPanel panel2 = new UIPanel("Contacte", UIPanel.PanelType.Tab);
                panel.SetTitle("Menu Mécanical");
                panel.text = "Ceci est le menu pour les employés de Mécanical. Ce menu est en développement";
                panel.AddButton("Fermer", ui => player.ClosePanel(ui));
                panel.AddTabLine("Contacter le personnel", (ui) => player.Notify("MyMécanical", "Vous avez contacté le personnel"));
                panel2.AddTabLine("Louis Peche", (ui) => player.Notify("Téléphone", "Le numéro de téléphone est 010203040506"));

                player.ShowPanelUI(panel);
                player.ShowPanelUI(panel2);
            }
        }
    }
} 
