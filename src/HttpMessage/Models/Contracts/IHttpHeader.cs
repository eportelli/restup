﻿namespace Devkoes.HttpMessage.Models.Contracts
{
    public interface IHttpHeader
    {
        string Name { get; }
        string Value { get; }
    }
}
