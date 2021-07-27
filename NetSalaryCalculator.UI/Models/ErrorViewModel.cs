using System;

namespace NetSalaryCalculator.UI.Models
{
    public class ErrorViewModel
    // NetSalaryCalculatorController views will be incapsulated, stored here. 
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
