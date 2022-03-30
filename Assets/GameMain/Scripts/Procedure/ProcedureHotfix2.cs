using GameFramework.Fsm;
using GameFramework.Procedure;
using UnityGameFramework.Runtime;

namespace Hotfix.Procedure
{
    public class ProcedureHotfix2: ProcedureBase
    {
        protected override void OnEnter(IFsm<IProcedureManager> procedureOwner)
        {
            base.OnEnter(procedureOwner);
            Log.Info("来啦！老弟!3.0");
        }
    }
}