# hotchocolate-nodatime-issue

Go to https://localhost:5001/graphql/ and run this query to reproduce:
```graphql
query test {
  models {
    createdOn
  }
}
```
