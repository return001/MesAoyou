﻿

namespace AYWCFClient
{

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName = "IAYServ")]
    public interface IAYServ
    {

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IAYServ/GetStep", ReplyAction = "http://tempuri.org/IAYServ/GetStepResponse")]
        bool GetStep(out int step, string TrayNO, ref string reStr);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IAYServ/UpdateStep", ReplyAction = "http://tempuri.org/IAYServ/UpdateStepResponse")]
        bool UpdateStep(int StepNow, string TrayNo, ref string reStr);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IAYServ/GetTrayBindingCell", ReplyAction = "http://tempuri.org/IAYServ/GetTrayBindingCellResponse")]
        bool GetTrayBindingCell(out string jsonCells, string TrayNo, ref string reStr);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IAYServ/GetTrayCellLotNO", ReplyAction = "http://tempuri.org/IAYServ/GetTrayCellLotNOResponse")]
        bool GetTrayCellLotNO(out string lot, string TrayNo, ref string reStr);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IAYServ/UploadTrayCellInfo", ReplyAction = "http://tempuri.org/IAYServ/UploadTrayCellInfoResponse")]
        bool UploadTrayCellInfo(string TrayNo, string opNO, string jsonCells, ref string reStr);
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IAYServChannel : IAYServ, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class AYServClient : System.ServiceModel.ClientBase<IAYServ>, IAYServ
    {

        public AYServClient()
        {
        }

        public AYServClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
        {
        }

        public AYServClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public AYServClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public AYServClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }

        public bool GetStep(out int step, string TrayNO, ref string reStr)
        {
            return base.Channel.GetStep(out step, TrayNO, ref reStr);
        }

        public bool UpdateStep(int StepNow, string TrayNo, ref string reStr)
        {
            return base.Channel.UpdateStep(StepNow, TrayNo, ref reStr);
        }

        public bool GetTrayBindingCell(out string jsonCells, string TrayNo, ref string reStr)
        {
            return base.Channel.GetTrayBindingCell(out jsonCells, TrayNo, ref reStr);
        }

        public bool GetTrayCellLotNO(out string lot, string TrayNo, ref string reStr)
        {
            return base.Channel.GetTrayCellLotNO(out lot, TrayNo, ref reStr);
        }

        public bool UploadTrayCellInfo(string TrayNo, string opNO, string jsonCells, ref string reStr)
        {
            return base.Channel.UploadTrayCellInfo(TrayNo, opNO, jsonCells, ref reStr);
        }
    }

}