using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IResult
    {

        bool Succes { get; } //okumak içindir - GET

        string Message { get; } 

    }
}
