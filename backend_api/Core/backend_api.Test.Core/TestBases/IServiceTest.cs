using System;

namespace backend_api.Test.Core.TestBases;

public interface IServiceTest<out TService>
{
    TService GetServiceInstance(Action action = null);
}