using GameFramework.Fsm;
using GameFramework.Procedure;
using UnityEngine;

namespace Hotfix.Procedure
{
    public class ProcedureHotfix: ProcedureBase
    {
        protected override void OnEnter(IFsm<IProcedureManager> procedureOwner)
        {
            base.OnEnter(procedureOwner);
            Debug.Log("真牛逼 plus!");
            ChangeState<ProcedureHotfix2>(procedureOwner);
        }
    }
}