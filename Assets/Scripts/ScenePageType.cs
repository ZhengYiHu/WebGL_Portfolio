using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenePageType : PageType
{
    public override void ShowPageContent()
    {
        base.ShowPageContent();
        fullScreenContentPage.Show3DScene();
        fullScreenContentPage.ResetWipeValue();
        BackButton.ReplaceListener(ShowMenu);
    }

    public async override void ShowMenu()
    {
        await fullScreenContentPage.ShowMenu();
        base.ShowMenu();
    }
}
