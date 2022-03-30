using Cysharp.Threading.Tasks;
using GameFramework;
using GameFramework.Fsm;
using GameFramework.Procedure;
using UnityGameFramework.Runtime;

namespace MainProject.Scripts.Procedure
{
    public class ProcedureUpdateResource: ProcedureBase
    {
        protected override async void OnEnter(IFsm<IProcedureManager> procedureOwner)
        {
            base.OnEnter(procedureOwner);
            var hotfixComponent = GameEntry.GetComponent<HotfixComponent>();
            await hotfixComponent.UpdateAndLoadHotfixDll();
            await GameEntry.GetComponent<ProcedureComponent>().UpdateHotProcedure();
            await UniTask.Yield();
            var mgr =GameFrameworkEntry.GetModule<IProcedureManager>();
            mgr.StartProcedure(HotfixComponent.HotfixAssembly.GetType("Hotfix.Procedure.ProcedureHotfix"));
        }
    }
}