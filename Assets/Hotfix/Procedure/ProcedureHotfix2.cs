using GameFramework.Fsm;
using GameFramework.Procedure;
using UnityEngine;

namespace Hotfix.Procedure
{
    public class ProcedureHotfix2: ProcedureBase
    {
        protected override void OnEnter(IFsm<IProcedureManager> procedureOwner)
        {
            base.OnEnter(procedureOwner);
            Debug.Log("来啦！老弟!");
        }
    }
}