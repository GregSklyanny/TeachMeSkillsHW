using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesProgram
{
    public class ExecutionManager
    {
        private OperationManager _operationManager;
        public Dictionary<Operation, Func<int>> FuncExecute { get; set; }
        public ExecutionManager(OperationManager operationManager)
        {
            _operationManager = operationManager;
            FuncExecute = new Dictionary<Operation, Func<int>>();
        }
        public void PopulateFunctions(Operation operation, Func<int> func)
        {
            FuncExecute.Add(operation, func);
        }
        public void PrepareExecution()
        {
            PopulateFunctions(Operation.Sum, _operationManager.Execute(Operation.Sum));
            PopulateFunctions(Operation.Subtract, _operationManager.Execute(Operation.Subtract));
            PopulateFunctions(Operation.Multiply, _operationManager.Execute(Operation.Multiply));
        }
    }
}
