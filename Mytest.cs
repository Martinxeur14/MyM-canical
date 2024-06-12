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
            Debug.Log("MyTest est initialisé avec succès !");
        }

        public override void OnPlayerInput(Player player, KeyCode keyCode, bool onUI)
        {
            base.OnPlayerInput(player, keyCode, onUI);
            
            if(keyCode == KeyCode.F7)
            {
                player.SendText("Menu Mécanical");

                player.Notify("MyMécanical", "Seulement les Employé on le droit le lancer se menu");

                UIPanel panel = new UIPanel("MyTest", UIPanel.PanelType.Text);
                panel.SetTitle("Menu Mécanical");
                panel.text = "Ceci est le menu pour les employés de Mécanical. Ce menu est en développement";
                panel.AddButton("Fermer", ui => player.ClosePanel(ui));
                panel.AddButton("Contacter", ui => player.("Vous avez contacter un membre de Mécanical")(ui));

                player.ShowPanelUI(panel);
            }
        }
    }
}
