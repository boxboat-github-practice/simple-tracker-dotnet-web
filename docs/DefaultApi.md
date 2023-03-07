# SimpleTracker.Web.Api.DefaultApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ClientsClientIdDelete**](DefaultApi.md#clientsclientiddelete) | **DELETE** /clients/{clientId} | Delete a client by ID
[**ClientsClientIdGet**](DefaultApi.md#clientsclientidget) | **GET** /clients/{clientId} | Get a client by ID
[**ClientsClientIdPut**](DefaultApi.md#clientsclientidput) | **PUT** /clients/{clientId} | Update a client by ID
[**ClientsGet**](DefaultApi.md#clientsget) | **GET** /clients | Get all clients
[**ClientsPost**](DefaultApi.md#clientspost) | **POST** /clients | Create new client
[**ContractsContractIdDelete**](DefaultApi.md#contractscontractiddelete) | **DELETE** /contracts/{contractId} | Delete a contract by ID
[**ContractsContractIdGet**](DefaultApi.md#contractscontractidget) | **GET** /contracts/{contractId} | Get a contract by ID
[**ContractsContractIdPut**](DefaultApi.md#contractscontractidput) | **PUT** /contracts/{contractId} | Update a contract by ID
[**ContractsGet**](DefaultApi.md#contractsget) | **GET** /contracts | Get all contracts
[**ContractsPost**](DefaultApi.md#contractspost) | **POST** /contracts | Create new contract
[**EmployeesEmployeeIdDelete**](DefaultApi.md#employeesemployeeiddelete) | **DELETE** /employees/{employeeId} | Delete an employee by ID
[**EmployeesEmployeeIdGet**](DefaultApi.md#employeesemployeeidget) | **GET** /employees/{employeeId} | Get an employee by ID
[**EmployeesEmployeeIdPut**](DefaultApi.md#employeesemployeeidput) | **PUT** /employees/{employeeId} | Update an employee by ID
[**EmployeesGet**](DefaultApi.md#employeesget) | **GET** /employees | Get all employees
[**EmployeesPost**](DefaultApi.md#employeespost) | **POST** /employees | Create new employee
[**HistoryGet**](DefaultApi.md#historyget) | **GET** /history | Get all history
[**HistoryHistoryIdDelete**](DefaultApi.md#historyhistoryiddelete) | **DELETE** /history/{historyId} | Delete an employee contract assignment by ID
[**HistoryHistoryIdGet**](DefaultApi.md#historyhistoryidget) | **GET** /history/{historyId} | Get an employee contract asignment by ID
[**HistoryHistoryIdPut**](DefaultApi.md#historyhistoryidput) | **PUT** /history/{historyId} | Update an employee contract assignment by ID
[**HistoryPost**](DefaultApi.md#historypost) | **POST** /history | Create new employee contract assignment



## ClientsClientIdDelete

> void ClientsClientIdDelete (int clientId)

Delete a client by ID

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SimpleTracker.Web.Api;
using SimpleTracker.Web.Client;
using SimpleTracker.Web.Model;

namespace Example
{
    public class ClientsClientIdDeleteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(Configuration.Default);
            var clientId = 56;  // int | Numeric ID of the client

            try
            {
                // Delete a client by ID
                apiInstance.ClientsClientIdDelete(clientId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.ClientsClientIdDelete: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **int**| Numeric ID of the client | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ClientsClientIdGet

> ModelClient ClientsClientIdGet (int clientId)

Get a client by ID

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SimpleTracker.Web.Api;
using SimpleTracker.Web.Client;
using SimpleTracker.Web.Model;

namespace Example
{
    public class ClientsClientIdGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(Configuration.Default);
            var clientId = 56;  // int | Numeric ID of the client

            try
            {
                // Get a client by ID
                ModelClient result = apiInstance.ClientsClientIdGet(clientId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.ClientsClientIdGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **int**| Numeric ID of the client | 

### Return type

[**ModelClient**](ModelClient.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ClientsClientIdPut

> ModelClient ClientsClientIdPut (int clientId, ClientsPostRequest clientsPostRequest)

Update a client by ID

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SimpleTracker.Web.Api;
using SimpleTracker.Web.Client;
using SimpleTracker.Web.Model;

namespace Example
{
    public class ClientsClientIdPutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(Configuration.Default);
            var clientId = 56;  // int | Numeric ID of the client
            var clientsPostRequest = new ClientsPostRequest(); // ClientsPostRequest | 

            try
            {
                // Update a client by ID
                ModelClient result = apiInstance.ClientsClientIdPut(clientId, clientsPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.ClientsClientIdPut: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientId** | **int**| Numeric ID of the client | 
 **clientsPostRequest** | [**ClientsPostRequest**](ClientsPostRequest.md)|  | 

### Return type

[**ModelClient**](ModelClient.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ClientsGet

> List&lt;ModelClient&gt; ClientsGet ()

Get all clients

Retrieves all clients

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SimpleTracker.Web.Api;
using SimpleTracker.Web.Client;
using SimpleTracker.Web.Model;

namespace Example
{
    public class ClientsGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(Configuration.Default);

            try
            {
                // Get all clients
                List<ModelClient> result = apiInstance.ClientsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.ClientsGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**List&lt;ModelClient&gt;**](ModelClient.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ClientsPost

> ModelClient ClientsPost (ClientsPostRequest clientsPostRequest)

Create new client

Add a new client with given name and url

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SimpleTracker.Web.Api;
using SimpleTracker.Web.Client;
using SimpleTracker.Web.Model;

namespace Example
{
    public class ClientsPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(Configuration.Default);
            var clientsPostRequest = new ClientsPostRequest(); // ClientsPostRequest | 

            try
            {
                // Create new client
                ModelClient result = apiInstance.ClientsPost(clientsPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.ClientsPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **clientsPostRequest** | [**ClientsPostRequest**](ClientsPostRequest.md)|  | 

### Return type

[**ModelClient**](ModelClient.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ContractsContractIdDelete

> void ContractsContractIdDelete (int contractId)

Delete a contract by ID

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SimpleTracker.Web.Api;
using SimpleTracker.Web.Client;
using SimpleTracker.Web.Model;

namespace Example
{
    public class ContractsContractIdDeleteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(Configuration.Default);
            var contractId = 56;  // int | Numeric ID of the contract

            try
            {
                // Delete a contract by ID
                apiInstance.ContractsContractIdDelete(contractId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.ContractsContractIdDelete: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractId** | **int**| Numeric ID of the contract | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ContractsContractIdGet

> Contract ContractsContractIdGet (int contractId)

Get a contract by ID

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SimpleTracker.Web.Api;
using SimpleTracker.Web.Client;
using SimpleTracker.Web.Model;

namespace Example
{
    public class ContractsContractIdGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(Configuration.Default);
            var contractId = 56;  // int | Numeric ID of the contract

            try
            {
                // Get a contract by ID
                Contract result = apiInstance.ContractsContractIdGet(contractId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.ContractsContractIdGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractId** | **int**| Numeric ID of the contract | 

### Return type

[**Contract**](Contract.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ContractsContractIdPut

> Contract ContractsContractIdPut (int contractId, ContractPatch contractPatch)

Update a contract by ID

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SimpleTracker.Web.Api;
using SimpleTracker.Web.Client;
using SimpleTracker.Web.Model;

namespace Example
{
    public class ContractsContractIdPutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(Configuration.Default);
            var contractId = 56;  // int | Numeric ID of the contract
            var contractPatch = new ContractPatch(); // ContractPatch | 

            try
            {
                // Update a contract by ID
                Contract result = apiInstance.ContractsContractIdPut(contractId, contractPatch);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.ContractsContractIdPut: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractId** | **int**| Numeric ID of the contract | 
 **contractPatch** | [**ContractPatch**](ContractPatch.md)|  | 

### Return type

[**Contract**](Contract.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ContractsGet

> List&lt;Contract&gt; ContractsGet ()

Get all contracts

Retrieves all contracts

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SimpleTracker.Web.Api;
using SimpleTracker.Web.Client;
using SimpleTracker.Web.Model;

namespace Example
{
    public class ContractsGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(Configuration.Default);

            try
            {
                // Get all contracts
                List<Contract> result = apiInstance.ContractsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.ContractsGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**List&lt;Contract&gt;**](Contract.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ContractsPost

> Contract ContractsPost (ContractPatch contractPatch)

Create new contract

Add a new contract with fields

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SimpleTracker.Web.Api;
using SimpleTracker.Web.Client;
using SimpleTracker.Web.Model;

namespace Example
{
    public class ContractsPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(Configuration.Default);
            var contractPatch = new ContractPatch(); // ContractPatch | 

            try
            {
                // Create new contract
                Contract result = apiInstance.ContractsPost(contractPatch);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.ContractsPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **contractPatch** | [**ContractPatch**](ContractPatch.md)|  | 

### Return type

[**Contract**](Contract.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## EmployeesEmployeeIdDelete

> void EmployeesEmployeeIdDelete (int employeeId)

Delete an employee by ID

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SimpleTracker.Web.Api;
using SimpleTracker.Web.Client;
using SimpleTracker.Web.Model;

namespace Example
{
    public class EmployeesEmployeeIdDeleteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(Configuration.Default);
            var employeeId = 56;  // int | Numeric ID of the employee

            try
            {
                // Delete an employee by ID
                apiInstance.EmployeesEmployeeIdDelete(employeeId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.EmployeesEmployeeIdDelete: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **employeeId** | **int**| Numeric ID of the employee | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## EmployeesEmployeeIdGet

> Employee EmployeesEmployeeIdGet (int employeeId)

Get an employee by ID

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SimpleTracker.Web.Api;
using SimpleTracker.Web.Client;
using SimpleTracker.Web.Model;

namespace Example
{
    public class EmployeesEmployeeIdGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(Configuration.Default);
            var employeeId = 56;  // int | Numeric ID of the employee

            try
            {
                // Get an employee by ID
                Employee result = apiInstance.EmployeesEmployeeIdGet(employeeId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.EmployeesEmployeeIdGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **employeeId** | **int**| Numeric ID of the employee | 

### Return type

[**Employee**](Employee.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## EmployeesEmployeeIdPut

> Employee EmployeesEmployeeIdPut (int employeeId, EmployeesPostRequest employeesPostRequest)

Update an employee by ID

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SimpleTracker.Web.Api;
using SimpleTracker.Web.Client;
using SimpleTracker.Web.Model;

namespace Example
{
    public class EmployeesEmployeeIdPutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(Configuration.Default);
            var employeeId = 56;  // int | Numeric ID of the employee
            var employeesPostRequest = new EmployeesPostRequest(); // EmployeesPostRequest | 

            try
            {
                // Update an employee by ID
                Employee result = apiInstance.EmployeesEmployeeIdPut(employeeId, employeesPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.EmployeesEmployeeIdPut: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **employeeId** | **int**| Numeric ID of the employee | 
 **employeesPostRequest** | [**EmployeesPostRequest**](EmployeesPostRequest.md)|  | 

### Return type

[**Employee**](Employee.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## EmployeesGet

> List&lt;Employee&gt; EmployeesGet ()

Get all employees

Retrieves all employees

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SimpleTracker.Web.Api;
using SimpleTracker.Web.Client;
using SimpleTracker.Web.Model;

namespace Example
{
    public class EmployeesGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(Configuration.Default);

            try
            {
                // Get all employees
                List<Employee> result = apiInstance.EmployeesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.EmployeesGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**List&lt;Employee&gt;**](Employee.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## EmployeesPost

> Employee EmployeesPost (EmployeesPostRequest employeesPostRequest)

Create new employee

Add a new employee with given name and github username

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SimpleTracker.Web.Api;
using SimpleTracker.Web.Client;
using SimpleTracker.Web.Model;

namespace Example
{
    public class EmployeesPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(Configuration.Default);
            var employeesPostRequest = new EmployeesPostRequest(); // EmployeesPostRequest | 

            try
            {
                // Create new employee
                Employee result = apiInstance.EmployeesPost(employeesPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.EmployeesPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **employeesPostRequest** | [**EmployeesPostRequest**](EmployeesPostRequest.md)|  | 

### Return type

[**Employee**](Employee.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HistoryGet

> List&lt;History&gt; HistoryGet (int? employeeId = null, int? clientId = null, int? contractId = null)

Get all history

Retrieves all employee contract assignment history

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SimpleTracker.Web.Api;
using SimpleTracker.Web.Client;
using SimpleTracker.Web.Model;

namespace Example
{
    public class HistoryGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(Configuration.Default);
            var employeeId = 56;  // int? | numerical employee identifier (optional) 
            var clientId = 56;  // int? | numerical client identifier (optional) 
            var contractId = 56;  // int? | numerical contract identifier (optional) 

            try
            {
                // Get all history
                List<History> result = apiInstance.HistoryGet(employeeId, clientId, contractId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.HistoryGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **employeeId** | **int?**| numerical employee identifier | [optional] 
 **clientId** | **int?**| numerical client identifier | [optional] 
 **contractId** | **int?**| numerical contract identifier | [optional] 

### Return type

[**List&lt;History&gt;**](History.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HistoryHistoryIdDelete

> void HistoryHistoryIdDelete (int historyId)

Delete an employee contract assignment by ID

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SimpleTracker.Web.Api;
using SimpleTracker.Web.Client;
using SimpleTracker.Web.Model;

namespace Example
{
    public class HistoryHistoryIdDeleteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(Configuration.Default);
            var historyId = 56;  // int | Numeric ID of the employee contract assignment

            try
            {
                // Delete an employee contract assignment by ID
                apiInstance.HistoryHistoryIdDelete(historyId);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.HistoryHistoryIdDelete: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **historyId** | **int**| Numeric ID of the employee contract assignment | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HistoryHistoryIdGet

> History HistoryHistoryIdGet (int historyId)

Get an employee contract asignment by ID

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SimpleTracker.Web.Api;
using SimpleTracker.Web.Client;
using SimpleTracker.Web.Model;

namespace Example
{
    public class HistoryHistoryIdGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(Configuration.Default);
            var historyId = 56;  // int | Numeric ID of the employee contract assignment

            try
            {
                // Get an employee contract asignment by ID
                History result = apiInstance.HistoryHistoryIdGet(historyId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.HistoryHistoryIdGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **historyId** | **int**| Numeric ID of the employee contract assignment | 

### Return type

[**History**](History.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HistoryHistoryIdPut

> Contract HistoryHistoryIdPut (int historyId, HistoryPatch historyPatch)

Update an employee contract assignment by ID

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SimpleTracker.Web.Api;
using SimpleTracker.Web.Client;
using SimpleTracker.Web.Model;

namespace Example
{
    public class HistoryHistoryIdPutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(Configuration.Default);
            var historyId = 56;  // int | Numeric ID of the employee contract assignment
            var historyPatch = new HistoryPatch(); // HistoryPatch | 

            try
            {
                // Update an employee contract assignment by ID
                Contract result = apiInstance.HistoryHistoryIdPut(historyId, historyPatch);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.HistoryHistoryIdPut: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **historyId** | **int**| Numeric ID of the employee contract assignment | 
 **historyPatch** | [**HistoryPatch**](HistoryPatch.md)|  | 

### Return type

[**Contract**](Contract.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## HistoryPost

> History HistoryPost (HistoryPatch historyPatch)

Create new employee contract assignment

Add a new contract assignment with fields

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SimpleTracker.Web.Api;
using SimpleTracker.Web.Client;
using SimpleTracker.Web.Model;

namespace Example
{
    public class HistoryPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(Configuration.Default);
            var historyPatch = new HistoryPatch(); // HistoryPatch | 

            try
            {
                // Create new employee contract assignment
                History result = apiInstance.HistoryPost(historyPatch);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.HistoryPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **historyPatch** | [**HistoryPatch**](HistoryPatch.md)|  | 

### Return type

[**History**](History.md)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

