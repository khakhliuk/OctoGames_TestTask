using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using Naninovel;
using Naninovel.Commands;

[CommandAlias("minigame")]
public class MiniGame : Command
{
    public override async UniTask ExecuteAsync(AsyncToken asyncToken = default)
    {
        asyncToken.ThrowIfCanceled();
        
        var uiManager = Engine.GetService<IUIManager>();
        var miniGame = uiManager.GetUI<MiniGameUI>();
        miniGame.Show();

        await Task.Run(() => miniGame.StartMiniGame());
        miniGame.Hide();
    }
}
