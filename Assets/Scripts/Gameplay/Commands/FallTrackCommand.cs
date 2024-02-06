using Main.Gameplay.Core;
using System;

namespace Main.Gameplay.CommandSystem
{
    public class FallTrackCommand : ICommand
    {
        private Action DoOnComplete;

        public FallTrackCommand()
        {
            CommandManager.Instance.AddCommand(this);
            FallManager.Instance.OnCompleted += OnCompleted;
        }

        public void Execute(Action OnCompleted)
        {
            DoOnComplete = OnCompleted;
        }

        private void OnCompleted()
        {
            DoOnComplete();
        }
    }
}
