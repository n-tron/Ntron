using Ntron.Models.SmartContract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ntron.Providers
{
    public interface ISmartContractProvider 
    {
        GetContract.Response GetContract(GetContract.Request model);
        TriggerSmartContract.Response TriggerSmartContract(TriggerSmartContract.Request model);
        DeployContract.Response DeployContract(DeployContract.Request model);

    }
    public class SmartContractProvider : ISmartContractProvider
    {
        public DeployContract.Response DeployContract(DeployContract.Request model)
        {
            throw new NotImplementedException();
        }

        public GetContract.Response GetContract(GetContract.Request model)
        {
            throw new NotImplementedException();
        }

        public TriggerSmartContract.Response TriggerSmartContract(TriggerSmartContract.Request model)
        {
            throw new NotImplementedException();
        }
    }
}
