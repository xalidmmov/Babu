﻿namespace TestApi.Exceptions
{
    public interface IBaseException
    {
        public int StatusCode { get; }
        public string ErrorMessage { get;  }
    }
}
