# hc-project-children

Simple example of projecting child collections with Hot Chocolate.

- `dotnet watch --no-hot-reload`
- `http://localhost:5095/graphql/`
- Query:

    ```gql
    {
        parents {
            id
            name
            children {
                id
                name
            }
        }
    }
    ```
