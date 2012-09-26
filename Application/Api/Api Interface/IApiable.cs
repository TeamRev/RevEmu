using Revolution.Api.Api_Enumerables;

namespace Revolution.Api.Api_Interface
{
    interface IApiable
    {
        // Api Data Will Be Set Here

        // Then Here Comes The interface Data
        string ApiName { get; }

        ApiPermissionEnumerable Priority { get; }
    }
}
