namespace SharpC2.API.V1.Requests
{
    public class PayloadRequest
    {
        public string Handler { get; set; }
        public PayloadFormat Format { get; set; } = PayloadFormat.Exe;
        public string DllExport { get; set; } = "Execute";
        
        public enum PayloadFormat : int
        {
            Exe = 0,
            Dll = 1,
            PowerShell = 2,
            Raw = 3
        }
    }
}