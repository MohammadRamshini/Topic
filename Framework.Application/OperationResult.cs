using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Application
{
    public class OperationResult
    {
        public string TableName { get; set; }
        public string Operation { get; set; }
        public long RecordId { get; private set; }
        public string Message { get; private set; }
        public bool Success { get; private set; }
        public DateTime OperationDate { get; private set; }

        public OperationResult()
        {
        }

        public OperationResult(string tableName, string operation)
        {
            TableName = tableName;
            Operation = operation;
            Success = false;
            OperationDate = DateTime.Now;
        }
        public OperationResult Failed(string failureMessage)
        {
            Message = failureMessage;
            return this;
        }

        public OperationResult Succeeded(string successMessage)
        {
            Message = successMessage;
            Success = true;
            return this;
        }
    }
}
