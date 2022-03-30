using GameFramework.Fsm;
using GameFramework.Procedure;
using MainProject.Scripts.Procedure;
using UnityGameFramework.Runtime;

namespace MainProject.Scripts.Procedure
{
    public class ProcedureInit : ProcedureBase
    {
        protected override void OnEnter(IFsm<IProcedureManager> procedureOwner)
        {
            base.OnEnter(procedureOwner);

            ChangeState<ProcedureUpdateResource>(procedureOwner);
        }
    }
}