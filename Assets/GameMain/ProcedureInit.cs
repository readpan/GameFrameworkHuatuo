using GameFramework.Fsm;
using GameFramework.Procedure;
using UnityGameFramework.Runtime;

namespace GameMain
{
    public class ProcedureInit : ProcedureBase
    {
        protected override void OnEnter(IFsm<IProcedureManager> procedureOwner)
        {
            base.OnEnter(procedureOwner);

            ChangeState(procedureOwner, HotfixComponent.HotfixAssembly.GetType("Hotfix.Procedure.ProcedureHotfix"));
        }
    }
}