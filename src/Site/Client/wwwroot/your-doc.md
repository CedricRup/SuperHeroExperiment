# Hero Http API documentation - Endpoints

## Registration endpoint

```text
POST {api-root-url}/registration
```

- Returned status codes

  - `200 Ok` The request has been successfully processed

- Example

  - Request

    ```json
    {
      "name": "Batman",
    }
    ```

## Event endpoint

```text
POST {api-root-url}/event
```

- Returned status codes

  - `200 Ok` The request has been successfully processed

- Example

  - Request

    ```json
    {
      "type": "Flood",
      "location": "New York"
    }
    ```

## Intervention Plan endpoint

```text
GET {api-root-url}/interventionPlan
```

- Returned status codes

  - `200 Ok` The request has been successfully processed

- Example

  - Response

    ```json
    [
      {
        "hero": "Batman",
        "location": "Batcave",
        "action": "Standby"
      }
    ]
    ```

