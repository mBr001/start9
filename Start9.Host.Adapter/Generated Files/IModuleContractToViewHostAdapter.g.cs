//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Start9.Host.Adapters
{
    
    [System.AddIn.Pipeline.HostAdapterAttribute()]
    public class IModuleContractToViewHostAdapter : Start9.Host.Views.IModule
    {
        private Start9.Api.Contracts.IModuleContract _contract;
        private System.AddIn.Pipeline.ContractHandle _handle;
        static IModuleContractToViewHostAdapter()
        {
        }
        public IModuleContractToViewHostAdapter(Start9.Api.Contracts.IModuleContract contract)
        {
            _contract = contract;
            _handle = new System.AddIn.Pipeline.ContractHandle(contract);
        }
        public Start9.Host.Views.IConfiguration Configuration
        {
            get
            {
                return Start9.Host.Adapters.IConfigurationHostAdapter.ContractToViewAdapter(_contract.Configuration);
            }
        }
        public Start9.Host.Views.IMessageContract MessageContract
        {
            get
            {
                return Start9.Host.Adapters.IMessageContractHostAdapter.ContractToViewAdapter(_contract.MessageContract);
            }
        }
        public Start9.Host.Views.IReceiverContract ReceiverContract
        {
            get
            {
                return Start9.Host.Adapters.IReceiverContractHostAdapter.ContractToViewAdapter(_contract.ReceiverContract);
            }
        }
        public void Initialize(Start9.Host.Views.IHost host)
        {
            _contract.Initialize(Start9.Host.Adapters.IHostHostAdapter.ViewToContractAdapter(host));
        }
        internal Start9.Api.Contracts.IModuleContract GetSourceContract()
        {
            return _contract;
        }
    }
}
